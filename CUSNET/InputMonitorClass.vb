Public Class InputMonitor

#Region " Private Declarations "
    Private _MachineObj As Machine
    Private _status As Boolean
    Private _monitorThread As System.Threading.Thread
    Private _last_input_value As Short

    Private p_ULStat As MccDaq.ErrorInfo
    Private DataValue As UInt16
    Private p_bit_value As Boolean
    Private p_x As Short
#End Region

#Region " Public Declarations "
    Public Event InputsChanged As EventHandler
#End Region

#Region " Constructor "
    Public Sub New(ByVal MachineObj As Machine)
        _MachineObj = MachineObj
    End Sub
#End Region

#Region " Start Monitoring "
    Public Sub StartMonitoring()
        _status = True
        _last_input_value = 0

        If Not _monitorThread Is Nothing Then _monitorThread = Nothing

        'Start the threading to monitory
        _monitorThread = New System.Threading.Thread(AddressOf Monitor)
        _monitorThread.Start()
    End Sub
#End Region

#Region " Stop Monitoring "
    Public Sub StopMonitoring()
        _status = False

        _monitorThread = Nothing
    End Sub
#End Region

#Region " Monitor "
    Private Sub Monitor()
        ' ----------------
        ' * Monitor Inputs
        ' ----------------
        Do While _status = True
            If _MachineObj.DemoMode Then
                ' Demo Mode
                Call HandleDemoMode()
            Else
                ' Live Mode
                Call HandleLiveMode()
            End If

            Threading.Thread.Sleep(1) 'Make it sleep for an amount of Milliseconds.
        Loop
    End Sub
#End Region

#Region " Handle Demo Mode "
    Private Sub HandleDemoMode()
        If g_us_usage Then
            ' Handle Ultrasonics Sensor
            If _MachineObj.MachineRunProfile.bits(O_ULTRA).State = True Then
                If _MachineObj.MachineRunProfile.bits(I_ULTRASONICS).State = False Then
                    _MachineObj.MachineRunProfile.bits(I_ULTRASONICS).State = True
                    RaiseEvent InputsChanged(_MachineObj, New System.EventArgs)
                End If
            Else
                If _MachineObj.MachineRunProfile.bits(I_ULTRASONICS).State = True Then
                    _MachineObj.MachineRunProfile.bits(I_ULTRASONICS).State = False
                    RaiseEvent InputsChanged(_MachineObj, New System.EventArgs)
                End If
            End If
        End If

        ' Handle Other Inputs
        Select Case _MachineObj.CurrentPhase.Phase
            Case PCBStructs.PHASES.FILL
                If _MachineObj.MachineRunProfile.bits(I_FLOW).State = False _
                    And _MachineObj.CurrentCycle.SystemOverrides.fill_flow_secs < _MachineObj.get_phase_run_seconds Then

                    _MachineObj.MachineRunProfile.bits(I_FLOW).State = True
                    RaiseEvent InputsChanged(_MachineObj, New System.EventArgs)
                End If

                If _MachineObj.MachineRunProfile.bits(I_FLOAT).State = False _
                    And _MachineObj.CurrentCycle.SystemOverrides.fill_float_secs < _MachineObj.get_phase_run_seconds Then

                    _MachineObj.MachineRunProfile.bits(I_FLOAT).State = True
                    RaiseEvent InputsChanged(_MachineObj, New System.EventArgs)
                End If

            Case PCBStructs.PHASES.WASH, PCBStructs.PHASES.SOAK, PCBStructs.PHASES.DISINFECT, PCBStructs.PHASES.RINSE
                If _MachineObj.MachineRunProfile.bits(I_PRESSURE).State = False _
                    And _MachineObj.CurrentCycle.SystemOverrides.pressure_start_delay_secs < _MachineObj.get_cycle_run_seconds Then

                    _MachineObj.MachineRunProfile.bits(I_PRESSURE).State = True
                    RaiseEvent InputsChanged(_MachineObj, New System.EventArgs)
                End If

            Case PCBStructs.PHASES.DRAIN
                If _MachineObj.MachineRunProfile.bits(I_FLOW).State = True _
                    And _MachineObj.CurrentCycle.SystemOverrides.drain_flow_secs <= _MachineObj.get_phase_run_seconds Then

                    _MachineObj.MachineRunProfile.bits(I_FLOW).State = False
                    _MachineObj.MachineRunProfile.bits(I_PRESSURE).State = False
                    RaiseEvent InputsChanged(_MachineObj, New System.EventArgs)
                End If

                If _MachineObj.MachineRunProfile.bits(I_FLOAT).State = True _
                    And _MachineObj.CurrentCycle.SystemOverrides.drain_float_secs <= _MachineObj.get_phase_run_seconds Then

                    _MachineObj.MachineRunProfile.bits(I_FLOAT).State = False
                    RaiseEvent InputsChanged(_MachineObj, New System.EventArgs)
                End If
        End Select
    End Sub
#End Region

#Region " Handle Live Mode "
    Private Sub HandleLiveMode()
        Try
            p_ULStat = _MachineObj.DaqBoard.DIn(MccDaq.DigitalPortType.FirstPortB, DataValue)

            If p_ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors And _MachineObj.Bay_Running Then
                ' ---------------------------------
                ' * Catch Error and Stop Processing
                ' ---------------------------------
                ' Stop Machine
                Call _MachineObj.stop_machine()
                Call _MachineObj.TurnOffAllBits()

                ' Raise Error
                _MachineObj.MachineRunProfile.error_message = Mid("I/O Error: DIn " & p_ULStat.Value & " " & p_ULStat.Message, 1, 150)
                Call _MachineObj.ErrorOccurr()

                Call _MachineObj.SetupMachineDefaults()

                Exit Sub
            End If

            If _last_input_value <> Convert.ToInt16(DataValue) Then
                _last_input_value = Convert.ToInt16(DataValue)
            Else
                Exit Sub
            End If

            Dim p_end As Integer

            If g_us_usage Then
                p_end = 5
            Else
                p_end = 4
            End If

            For p_x As Integer = 0 To p_end
                If (Convert.ToInt32(DataValue) And CInt((2 ^ p_x))) <> 0 Then
                    p_bit_value = False
                Else
                    p_bit_value = True
                End If

                Select Case p_x
                    Case 0
                        ' Get I_FLOW Input (Warrick Control)
                        _MachineObj.MachineRunProfile.bits(I_FLOW).State = p_bit_value

                    Case 1
                        ' Get I_FLOAT Input (Operating Float in Bay)
                        _MachineObj.MachineRunProfile.bits(I_FLOAT).State = p_bit_value

                    Case 2
                        ' Get I_SAFETY Input (Any Safety Float)
                        _MachineObj.MachineRunProfile.bits(I_SAFETY).State = p_bit_value

                    Case 4
                        ' Get I_PRESSURE Input (Water Channel)
                        _MachineObj.MachineRunProfile.bits(I_PRESSURE).State = p_bit_value

                    Case 5
                        ' Get I_ULTRASONICS Input (Ultrasonics Sensor)
                        _MachineObj.MachineRunProfile.bits(I_ULTRASONICS).State = p_bit_value
                End Select
            Next

            ' Call For Detail Screen Updating
            RaiseEvent InputsChanged(_MachineObj, New System.EventArgs)

        Catch
        End Try
    End Sub
#End Region

#Region " Public Properties "
    Public ReadOnly Property MonitoringState() As Boolean
        Get
            Return _status
        End Get
    End Property
#End Region

End Class
