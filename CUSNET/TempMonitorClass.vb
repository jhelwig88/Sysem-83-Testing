Public Class TempMonitor

#Region " Private Declarations "
    Private _cus As CUSMain
    Private _status As Boolean
    Private _monitorThread As System.Threading.Thread

    Private DataBuffer(7) As Single ' dimension an array to hold the temperatures
    Private Options As MccDaq.ThermocoupleOptions
    Private ULStat As MccDaq.ErrorInfo
    Private Element As Integer      ' Holds Current Channel Number

    Private m_res_temp As Integer
    Private m_bay_temp As Integer
#End Region

#Region " Public Properties "
    Public ReadOnly Property MonitoringState() As Boolean
        Get
            Return _status
        End Get
    End Property
#End Region

#Region " Constructor "
    Public Sub New(ByVal CUS As CUSMain)
        _cus = CUS

        ' Turn on the filter
        Options = MccDaq.ThermocoupleOptions.Filter
    End Sub
#End Region

#Region " Start Monitoring "
    Public Sub StartMonitoring()
        _status = True

        If Not _monitorThread Is Nothing Then _monitorThread = Nothing

        'Start the threading to monitory
        _monitorThread = New System.Threading.Thread(AddressOf Monitor)
        _monitorThread.Start()
    End Sub
#End Region

#Region " Stop Monitoring "
    Public Sub StopMonitoring()
        _status = False

        If Not _monitorThread Is Nothing Then _monitorThread = Nothing

        ' ------------------------
        ' * Reset Temperature Data
        ' ------------------------
        m_res_temp = 0
        m_bay_temp = 0

        For Each pMachine As Machine In _cus.Machines
            pMachine.MachineRunProfile.res_temperature = 0
            pMachine.MachineRunProfile.bay_temperature = 0
        Next
    End Sub
#End Region

#Region " Monitor "
    Private Sub Monitor()
        Dim p_value As Short
        Dim p_bays As Integer

        Do While _status = True
            If p_bays <> _cus.Active_Bays Then
                ' Get Active # of Bays
                p_bays = _cus.Active_Bays
            End If

            Element = 0

            For Each pMachine As Machine In _cus.Machines
                If pMachine.MonitorResTemperature = True And pMachine.DemoMode = False And pMachine.BayNumber <= p_bays Then
                    ' Get Temperature Readings From Channels For machine
                    p_value = (pMachine.BayNumber - 1) * 2

                    ' Set Reading of I/O per type
                    If g_io_usb Then
                        ' USB
                        ULStat = _cus.ADBoard.TInScan(p_value, 1 + p_value, MccDaq.TempScale.Celsius, DataBuffer(0), Options)
                    Else
                        ' PCI
                        ULStat = _cus.ADBoard.TInScan(16 + p_value, 17 + p_value, MccDaq.TempScale.Celsius, DataBuffer(0), Options)
                    End If

                    If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors And pMachine.Bay_Running Then
                        ' ---------------------------------
                        ' * Catch Error and Stop Processing
                        ' ---------------------------------
                        ' Stop Machine
                        Call pMachine.stop_machine()
                        Call pMachine.TurnOffAllBits()

                        ' Raise Error
                        pMachine.MachineRunProfile.error_message = Mid("I/O Error: TInScan " & ULStat.Value & " " & ULStat.Message, 1, 150)
                        Call pMachine.ErrorOccurr()

                        Call pMachine.SetupMachineDefaults()

                        Exit Sub
                    End If

                    m_res_temp = Fix(DataBuffer(Element))
                    m_bay_temp = Fix(DataBuffer(Element + 1))

                    ' If IO Card Returning Invalid Temperatures Then Reset
                    If g_io_usb Then
                        ' USB
                        If m_res_temp = -9999 Then m_res_temp = 0
                        If m_bay_temp = -9999 Then m_bay_temp = 0
                    Else
                        ' PCI
                        If m_res_temp = 308 Then m_res_temp = 0
                        If m_bay_temp = 308 Then m_bay_temp = 0
                    End If

                    ' ======================================================================
                    ' * Check the max and min of the reservoir, adjust the temp. accordingly
                    ' ======================================================================
                    If m_res_temp <= pMachine.SystemOverrides.min_temperature _
                        And pMachine.Bits(O_RES_H).State = False Then

                        ' Turn ON Reservoir Heat Pad
                        pMachine.Bits(O_RES_H).State = True
                        Call pMachine.ChangeBitStates(True)

                    ElseIf m_res_temp >= pMachine.SystemOverrides.max_temperature _
                        And pMachine.Bits(O_RES_H).State = True Then

                        ' Turn OFF Reservoir Heat Pad
                        pMachine.Bits(O_RES_H).State = False
                        Call pMachine.ChangeBitStates(True)
                    End If

                    ' ----------------------------------
                    ' * Update the reservoir temperature
                    ' ----------------------------------
                    If m_res_temp <> pMachine.MachineRunProfile.res_temperature Then
                        ' Get Reservoir Temperature
                        pMachine.MachineRunProfile.res_temperature = m_res_temp

                        'Change the temperature
                        Call pMachine.TempChanged()
                    End If

                    '=================================================================

                    ' ================================================================
                    ' * Check the max and min of the bay, adjust the temp. accordingly
                    ' ================================================================
                    If Not pMachine.CurrentCycle Is Nothing Then
                        If pMachine.CurrentCycle.Cycle = PCBStructs.CYCLES.DISINFECT Then
                            If m_bay_temp <= pMachine.SystemOverrides.min_temperature _
                                And pMachine.Bits(O_BAY_H).State = False _
                                And pMachine.Bits(I_FLOAT).State = True Then

                                ' Turn ON Bay Heat Pad
                                pMachine.Bits(O_BAY_H).State = True
                                Call pMachine.ChangeBitStates()

                            ElseIf m_bay_temp >= pMachine.SystemOverrides.max_temperature _
                                And pMachine.Bits(O_BAY_H).State = True Then

                                'Turn OFF Bay Heat Pad
                                pMachine.Bits(O_BAY_H).State = False
                                Call pMachine.ChangeBitStates()
                            End If

                        ElseIf pMachine.Bits(O_BAY_H).State = True Then
                            'Turn OFF Bay Heat Pad
                            pMachine.Bits(O_BAY_H).State = False
                            Call pMachine.ChangeBitStates()
                        End If

                    ElseIf pMachine.Bits(O_BAY_H).State = True _
                        And pMachine.ServiceBayTemp = False Then
                        'Turn OFF Bay Heat Pad
                        pMachine.Bits(O_BAY_H).State = False
                        Call pMachine.ChangeBitStates()
                    End If

                    ' ----------------------------
                    ' * Update the bay temperature
                    ' ----------------------------
                    If m_bay_temp <> pMachine.MachineRunProfile.bay_temperature Then
                        ' Get Bay Temperature
                        pMachine.MachineRunProfile.bay_temperature = m_bay_temp

                        'Change the temperature
                        Call pMachine.TempChanged()
                    End If

                    ' -----------------------------------------------------
                    ' * Check Bay Temperature Against Min Start / Max Abort
                    ' -----------------------------------------------------
                    If Not pMachine.CurrentPhase Is Nothing And Not pMachine.DemoMode Then
                        If pMachine.CurrentPhase.Phase = PCBStructs.PHASES.DISINFECT _
                            And pMachine.Bits(I_FLOAT).State = True Then

                            ' ----------------------------------
                            ' * Added 1/31/2007 - RM 
                            ' * Check Only After 30 Second Delay
                            ' ----------------------------------
                            If DateDiff(DateInterval.Second, pMachine.CurrentPhase.StartTime, DateTime.Now) > 30 Then
                                ' -----------------
                                ' * Check Min Start
                                ' -----------------
                                If pMachine.MachineRunProfile.bay_temperature < pMachine.SystemOverrides.min_start_temperature Then
                                    ' Stop Machine
                                    Call pMachine.stop_machine()
                                    Call pMachine.TurnOffAllBits()

                                    ' Raise Error
                                    pMachine.MachineRunProfile.error_message = "Error:  Bay Temperature Below Min Start Temp"
                                    Call pMachine.ErrorOccurr()

                                    Call pMachine.SetupMachineDefaults()
                                End If

                                ' -----------------
                                ' * Check Max Abort
                                ' -----------------
                                If pMachine.MachineRunProfile.bay_temperature >= pMachine.SystemOverrides.max_abort_temperature Then
                                    ' Stop Machine
                                    Call pMachine.stop_machine()
                                    Call pMachine.TurnOffAllBits()

                                    ' Raise Error
                                    pMachine.MachineRunProfile.error_message = "Error:  Bay Temperature Reached Max Abort Temp"
                                    Call pMachine.ErrorOccurr()

                                    Call pMachine.SetupMachineDefaults()
                                End If
                            End If
                        End If
                    End If
                End If
            Next

            Threading.Thread.Sleep(1000) 'Make it sleep for an amount of Milliseconds.
        Loop
    End Sub
#End Region

End Class
