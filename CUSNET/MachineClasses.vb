Imports System
Imports System.Threading
Imports System.Collections

#Region " Machines Array Class "
Public Class MachineArray
    Inherits CollectionBase

    Default Public Property Item(ByVal Index As Integer) As Machine
        Get
            Return CType(list.Item(Index), Machine)
        End Get
        Set(ByVal Value As Machine)
            list.Item(Index) = Value
        End Set
    End Property

    Default Public Property Item(ByVal Name As String) As Machine
        Get
            For Each pObj As Machine In list
                If UCase(pObj.Name) = UCase(Name) Then
                    Return pObj
                End If
            Next

            Return Nothing
        End Get
        Set(ByVal Value As Machine)
            For Each pObj As Machine In list
                If UCase(pObj.Name) = UCase(Name) Then
                    pObj = Value
                End If
            Next
        End Set
    End Property

    Public Function Find(ByVal Name As String) As Integer
        Dim i As Integer

        For i = 0 To list.Count - 1
            If UCase(list.Item(i).Name) = UCase(Name) Then
                Return i
                Exit Function
            End If
        Next

        Return -1
    End Function

    'Adds an item to the collection 
    Friend Function Add(ByVal Item As Machine) As Integer
        Return list.Add(Item)
    End Function

    Public Sub Remove(ByVal Item As Machine)
        list.Remove(Item)
    End Sub

End Class
#End Region

#Region " Machine Class "

Public Class Machine

#Region " Private Declarations "
    Private _cus As CUSMain
    Private _name As String
    Private _pinout As PCBStructs.SYSTEM_ID_DEF
    Private _boardNumber As Integer 'the board number for the IO card
    Private _bayNumber As Integer 'the bay number

    Private _guidelines As String
    Private _detergent As String
    Private _liquid_sterilant As String
    Private _profile As String
    Private _lubrication As Boolean = False

    Private _demoMode As Boolean = False
    Private _setup As Boolean = False
    Private _bay_running As Boolean = False
    Private _finished As Boolean = False
    Private _processed As Boolean = False
    Private _maint_status As Boolean = False
    Private _EnglandMode As Boolean = False

    Private _inputMonitor As InputMonitor 'used for input monitoring
    Private _monitorResTemp As Boolean    'used for the temp monitoring
    Private _servicesBayTemp As Boolean   'used for the bay temp override

    Private _startTime As DateTime
    Private _stopTime As DateTime
    Private _final_disinfect_temp As Double

    'Create a new instance of the system to run
    Private _CUSProcess As CUSProcess
    Private ProfileThread As System.Threading.Thread
    Private MaintThread As System.Threading.Thread
#End Region

#Region " Public Declarations "
    Public SystemOverrides As SystemOverrides
    Public Cycles As CycleArray
    Friend MachineRunProfile As RunProfile

    Public DaqBoard As MccDaq.MccBoard
    Public Has_Disinfect As Boolean
#End Region

#Region " Private Event Handlers "
    Private Sub onCycleBegin(ByVal sender As Object, ByVal e As System.EventArgs)
        RaiseEvent BeforeCycleCompleted(sender, e)
    End Sub

    Private Sub onCycleCompleted(ByVal sender As Object, ByVal e As System.EventArgs)
        RaiseEvent AfterCycleCompleted(sender, e)
    End Sub

    Private Sub onBitStatesChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        RaiseEvent BitStatesChanged(sender, e)
    End Sub

    Private Sub onBeforePhaseCompleted(ByVal sender As Object, ByVal e As System.EventArgs)
        RaiseEvent BeforePhaseCompleted(sender, e)
    End Sub

    Private Sub onAfterPhaseCompleted(ByVal sender As Object, ByVal e As System.EventArgs)
        RaiseEvent AfterPhaseCompleted(sender, e)
    End Sub

    Private Sub onMachineStarted(ByVal sender As Object, ByVal e As System.EventArgs)
        ' Get Start Time
        _startTime = DateTime.Now

        RaiseEvent MachineStarted(sender, e)
    End Sub

    Private Sub onMachineFinished(ByVal sender As Object, ByVal e As System.EventArgs)
        ' Get Stop Time
        _stopTime = DateTime.Now

        ' Dispose of Processing Thread
        ProfileThread = Nothing

        RaiseEvent MachineFinished(sender, e)
    End Sub

    Private Sub onInputsChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        RaiseEvent BitStatesChanged(sender, e)
    End Sub
#End Region

#Region " Public Events Handlers "
    Public Event BeforePhaseCompleted As EventHandler
    Public Event AfterPhaseCompleted As EventHandler

    Public Event BeforeCycleCompleted As EventHandler
    Public Event AfterCycleCompleted As EventHandler

    Public Event MachineStarted As EventHandler
    Public Event MachineFinished As EventHandler

    Public Event BitStatesChanged As EventHandler
    Public Event TemperatureChanged As EventHandler

    Public Event ErrorOccurred As EventHandler
#End Region

#Region " Public Properties "
    Public ReadOnly Property BayNumber() As Integer
        Get
            Return _bayNumber
        End Get
    End Property

    Public ReadOnly Property BoardNumber() As Integer
        Get
            Return _boardNumber
        End Get
    End Property

    Public ReadOnly Property Bits() As BitArray
        Get
            Return MachineRunProfile.bits
        End Get
    End Property

    Public ReadOnly Property ReservoirTemperature() As Integer
        Get
            Return MachineRunProfile.res_temperature
        End Get
    End Property

    Public ReadOnly Property BayTemperature() As Integer
        Get
            Return MachineRunProfile.bay_temperature
        End Get
    End Property

    Public ReadOnly Property StartTime() As DateTime
        Get
            Return _startTime
        End Get
    End Property

    Public ReadOnly Property StopTime() As DateTime
        Get
            Return _stopTime
        End Get
    End Property

    Public ReadOnly Property TotalCycles() As Integer
        Get
            Return Cycles.Count
        End Get
    End Property

    Public ReadOnly Property TotalPhases() As Integer
        Get
            Dim p_phase_total As Integer = 0
            For p_x As Integer = 0 To Cycles.Count - 1
                p_phase_total += Cycles(p_x).Phases.Count
            Next

            If p_phase_total = 0 Then
                Return 1
            Else
                Return p_phase_total
            End If
        End Get
    End Property

    Public ReadOnly Property CyclesCompleted() As Integer
        Get
            Return MachineRunProfile.cycles_completed
        End Get
    End Property

    Public ReadOnly Property CurrentCycle() As Cycle
        Get
            Return MachineRunProfile.current_cycle
        End Get
    End Property

    Public ReadOnly Property PhasesCompleted() As Integer
        Get
            Return MachineRunProfile.phases_completed
        End Get
    End Property

    Public ReadOnly Property CurrentPhase() As Phase
        Get
            Return MachineRunProfile.current_phase
        End Get
    End Property

    Public ReadOnly Property Error_Message() As String
        Get
            Return MachineRunProfile.error_message
        End Get
    End Property

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
        End Set
    End Property

    Public Property detergent() As String
        Get
            Return _detergent
        End Get
        Set(ByVal Value As String)
            _detergent = Value
        End Set
    End Property

    Public Property liquid_sterilant() As String
        Get
            Return _liquid_sterilant
        End Get
        Set(ByVal Value As String)
            _liquid_sterilant = Value
        End Set
    End Property

    Public Property Guidelines() As String
        Get
            Return _guidelines
        End Get
        Set(ByVal Value As String)
            _guidelines = Value
        End Set
    End Property

    Public Property PinOut() As PCBStructs.SYSTEM_ID_DEF
        Get
            Return _pinout
        End Get
        Set(ByVal Value As PCBStructs.SYSTEM_ID_DEF)
            _pinout = Value
        End Set
    End Property

    Public Property Profile() As String
        Get
            Return _profile
        End Get
        Set(ByVal Value As String)
            _profile = Value
        End Set
    End Property

    Public Property Setup() As Boolean
        Get
            Return _setup
        End Get
        Set(ByVal Value As Boolean)
            _setup = Value
        End Set
    End Property

    Public Property Lubrication() As Boolean
        Get
            Return _lubrication
        End Get
        Set(ByVal Value As Boolean)
            _lubrication = Value
        End Set
    End Property

    Public Property DemoMode() As Boolean
        Get
            Return _demoMode
        End Get
        Set(ByVal Value As Boolean)
            _demoMode = Value
        End Set
    End Property

    Public Property EnglandMode() As Boolean
        Get
            Return _EnglandMode
        End Get
        Set(ByVal Value As Boolean)
            _EnglandMode = Value
        End Set
    End Property

    Public Property Bay_Running() As Boolean
        Get
            Return _bay_running
        End Get
        Set(ByVal Value As Boolean)
            _bay_running = Value
        End Set
    End Property

    Public Property Finished() As Boolean
        Get
            Return _finished
        End Get
        Set(ByVal Value As Boolean)
            _finished = Value
        End Set
    End Property

    Public Property Processed() As Boolean
        Get
            Return _processed
        End Get
        Set(ByVal Value As Boolean)
            _processed = Value
        End Set
    End Property

    Public Property MonitorResTemperature() As Boolean
        Get
            Return _monitorResTemp
        End Get
        Set(ByVal Value As Boolean)
            _monitorResTemp = Value
        End Set
    End Property

    Public Property Final_Disinfect_Temp() As Double
        Get
            Return _final_disinfect_temp
        End Get
        Set(ByVal Value As Double)
            _final_disinfect_temp = Value
        End Set
    End Property

    Public Property Run_Header_ID() As String
        Get
            Return MachineRunProfile.run_header_id
        End Get
        Set(ByVal Value As String)
            MachineRunProfile.run_header_id = Value
        End Set
    End Property

    Public Property ServiceBayTemp() As Boolean
        Get
            Return _servicesBayTemp
        End Get
        Set(ByVal Value As Boolean)
            _servicesBayTemp = Value
        End Set
    End Property

#End Region

#Region " Public Sub New "
    Public Sub New(ByVal MachineName As String, ByVal BoardNumber As Integer, ByVal BayNumber As Integer, ByVal CUS As CUSMain, _
        ByVal DemoMode As Boolean, ByVal EnglandMode As Boolean)
        ' -------------------------
        ' * Set Machine Information
        ' -------------------------
        _name = MachineName
        _boardNumber = BoardNumber
        _bayNumber = BayNumber
        _cus = CUS

        _demoMode = DemoMode
        _EnglandMode = EnglandMode

        'Create a new instance of objects
        SystemOverrides = New SystemOverrides
        MachineRunProfile = New RunProfile
        Cycles = New CycleArray

        ' -------------------------------------
        ' * Create a new reference to the board
        ' -------------------------------------
        DaqBoard = New MccDaq.MccBoard(_boardNumber)

        ' Initialize the IO board
        Call InitIOBoard()

        ' initialize the input/output bits
        Call InitializeBits()


        'Setup the CUS process and event handlers
        Call SetupCUSProcess()

        ' -------------------------------------
        ' * Create a new input monitor instance
        ' -------------------------------------
        _inputMonitor = New InputMonitor(Me)
        AddHandler _inputMonitor.InputsChanged, AddressOf onInputsChanged
    End Sub
#End Region

#Region " Setup CUSProcess "
    Private Sub SetupCUSProcess()
        ' --------------------------------------------
        ' * Create a new instance of the system to run
        ' --------------------------------------------
        _CUSProcess = Nothing
        _CUSProcess = New CUSProcess(Me)

        'Add the handlers
        AddHandler _CUSProcess.MachineStarted, AddressOf onMachineStarted
        AddHandler _CUSProcess.MachineFinished, AddressOf onMachineFinished

        AddHandler _CUSProcess.AfterCycleCompleted, AddressOf onCycleCompleted
        AddHandler _CUSProcess.BeforeCycleCompleted, AddressOf onCycleBegin

        AddHandler _CUSProcess.BeforePhaseCompleted, AddressOf onBeforePhaseCompleted
        AddHandler _CUSProcess.AfterPhaseCompleted, AddressOf onAfterPhaseCompleted

        AddHandler _CUSProcess.BitStatesChanged, AddressOf onBitStatesChanged
    End Sub
#End Region

#Region " Initialize Bits "
    Friend Sub InitializeBits()
        MachineRunProfile.bits = New BitArray

        With MachineRunProfile.bits
            ' Add FirstPortA Items
            .Add(New Bit(O_ULTRA, MccDaq.DigitalPortType.FirstPortA, 0))
            .Add(New Bit(O_DRAIN_P, MccDaq.DigitalPortType.FirstPortA, 1))
            .Add(New Bit(O_DRAIN_V, MccDaq.DigitalPortType.FirstPortA, 2))
            .Add(New Bit(O_WATER_V, MccDaq.DigitalPortType.FirstPortA, 3))
            .Add(New Bit(O_OSC_P, MccDaq.DigitalPortType.FirstPortA, 4))
            .Add(New Bit(O_DIS_P, MccDaq.DigitalPortType.FirstPortA, 5))
            .Add(New Bit(O_DIS_F_V, MccDaq.DigitalPortType.FirstPortA, 6))
            .Add(New Bit(O_DIS_R_V, MccDaq.DigitalPortType.FirstPortA, 7))

            ' Add FirstPortCL Items
            .Add(New Bit(O_RES_D, MccDaq.DigitalPortType.FirstPortCL, 1))
            .Add(New Bit(O_AIR, MccDaq.DigitalPortType.FirstPortCL, 2))
            .Add(New Bit(O_LUB_P, MccDaq.DigitalPortType.FirstPortCL, 4))
            .Add(New Bit(O_RES_H, MccDaq.DigitalPortType.FirstPortCL, 8))

            ' Add FirstPortCH Items
            .Add(New Bit(O_BAY_H, MccDaq.DigitalPortType.FirstPortCH, 1))
            .Add(New Bit(O_RINSE_S, MccDaq.DigitalPortType.FirstPortCH, 2))
            .Add(New Bit(O_DET_81_P, MccDaq.DigitalPortType.FirstPortCH, 4))
            .Add(New Bit(O_ENZ_P, MccDaq.DigitalPortType.FirstPortCH, 8))

            ' Add FirstPortB Items
            .Add(New Bit(I_FLOW, MccDaq.DigitalPortType.FirstPortB, 0))
            .Add(New Bit(I_FLOAT, MccDaq.DigitalPortType.FirstPortB, 1))
            .Add(New Bit(I_SAFETY, MccDaq.DigitalPortType.FirstPortB, 2))
            .Add(New Bit(I_PRESSURE, MccDaq.DigitalPortType.FirstPortB, 4))
            .Add(New Bit(I_ULTRASONICS, MccDaq.DigitalPortType.FirstPortB, 5))
        End With
    End Sub
#End Region

#Region " Initialize IO Board "
    Private Sub InitIOBoard()
        Dim p_ULStat As MccDaq.ErrorInfo

        p_ULStat = MccDaq.MccService.DeclareRevision(MccDaq.MccService.CurrentRevNum)
        p_ULStat = MccDaq.MccService.ErrHandling(MccDaq.ErrorReporting.DontPrint, MccDaq.ErrorHandling.DontStop)

        p_ULStat = DaqBoard.DConfigPort(MccDaq.DigitalPortType.FirstPortA, MccDaq.DigitalPortDirection.DigitalOut)
        p_ULStat = DaqBoard.DConfigPort(MccDaq.DigitalPortType.FirstPortB, MccDaq.DigitalPortDirection.DigitalIn)
        p_ULStat = DaqBoard.DConfigPort(MccDaq.DigitalPortType.FirstPortCH, MccDaq.DigitalPortDirection.DigitalOut)
        p_ULStat = DaqBoard.DConfigPort(MccDaq.DigitalPortType.FirstPortCL, MccDaq.DigitalPortDirection.DigitalOut)

        ' ----------------------------------
        ' * TurnOff All A/CL/CH Output Ports
        ' ----------------------------------
        p_ULStat = Me.DaqBoard.DOut(MccDaq.DigitalPortType.FirstPortA, 0)
        p_ULStat = Me.DaqBoard.DOut(MccDaq.DigitalPortType.FirstPortCL, 0)
        p_ULStat = Me.DaqBoard.DOut(MccDaq.DigitalPortType.FirstPortCH, 0)
    End Sub
#End Region

#Region " Get Run Seconds "
    Friend Function get_cycle_run_seconds() As Long
        ' --------------------------
        ' * Return Cycle Run Seconds
        ' --------------------------
        get_cycle_run_seconds = DateDiff(DateInterval.Second, CurrentCycle.StartTime, DateTime.Now)
    End Function

    Friend Function get_phase_run_seconds() As Long
        ' --------------------------
        ' * Return Phase Run Seconds
        ' --------------------------
        get_phase_run_seconds = DateDiff(DateInterval.Second, CurrentPhase.StartTime, DateTime.Now)
    End Function
#End Region


#Region " Run Machine "
    Public Sub RunMachine()
        If Not ProfileThread Is Nothing Then
            ProfileThread.Abort()
            ProfileThread = Nothing
        End If

        'Setup the CUS Process Again
        Call SetupCUSProcess()

        'Create a new thread for the process to run
        ProfileThread = New System.Threading.Thread(AddressOf _CUSProcess.Run_Machine)
        ProfileThread.Start()
    End Sub
#End Region

#Region " Temperature Changed "
    Friend Sub TempChanged()
        ' Raise Temperature Change
        RaiseEvent TemperatureChanged(Me, New System.EventArgs)
    End Sub
#End Region

#Region " Error Occurred "
    Friend Sub ErrorOccurr()
        ' Raise Error
        RaiseEvent ErrorOccurred(Me, New System.EventArgs)
    End Sub
#End Region


#Region " Setup Machine Defaults "
    Public Sub SetupMachineDefaults()
        ' ======================
        ' * Set Machine Defaults
        ' ======================
        With Me.MachineRunProfile
            .current_cycle = Nothing
            .current_phase = Nothing
            .cycles_completed = 0
            .phases_completed = 0

            .error_message = Nothing
        End With
    End Sub
#End Region

#Region " Change BitStates "
    Public Sub ChangeBitStates(Optional ByVal RES_H_Only As Boolean = False)
        Dim p_ULStat As MccDaq.ErrorInfo
        Dim p_bit_value As Short
        Dim p_CL_value As Short = 0
        Dim p_CH_value As Short = 0

        If DemoMode Then
            If RES_H_Only Then
                ' --------------------
                ' * Set Reservior Heat 
                ' --------------------
                Dim p_bit As Bit
                p_bit = Me.Bits.Item("O_RES_H")

                If p_bit.State = True Then
                    p_CL_value = p_bit.PortNum
                End If

                p_ULStat = Me.DaqBoard.DOut(MccDaq.DigitalPortType.FirstPortCL, p_CL_value)
                If check_io_error(p_ULStat, "DOutCL") Then Exit Sub
            End If

            ' -----------------------------------------
            ' * In Demo Mode, No Need To Set Card Ports
            ' * Just Call For Detail Screen Updating
            ' -----------------------------------------
            RaiseEvent BitStatesChanged(Me, New System.EventArgs)

            Exit Sub
        End If

        ' =====================================
        ' * Set Changes To A/CL/CH Output Ports
        ' =====================================
        For Each p_bit As Bit In Me.Bits
            Select Case p_bit.PortType
                Case MccDaq.DigitalPortType.FirstPortA
                    ' -----------------
                    ' * Set PortA Bytes
                    ' -----------------
                    If p_bit.State = True Then
                        p_bit_value = 1
                    Else
                        p_bit_value = 0
                    End If

                    p_ULStat = Me.DaqBoard.DBitOut(p_bit.PortType, p_bit.PortNum, p_bit_value)
                    If check_io_error(p_ULStat, "DBitOut") Then Exit Sub

                Case MccDaq.DigitalPortType.FirstPortCL
                    ' ---------------------------
                    ' * Add Up Bytes for CL Ports
                    ' ---------------------------
                    If p_bit.State = True Then
                        p_CL_value += p_bit.PortNum
                    End If

                Case MccDaq.DigitalPortType.FirstPortCH
                    ' ---------------------------
                    ' * Add Up Bytes for CH Ports
                    ' ---------------------------
                    If p_bit.State = True Then
                        p_CH_value += p_bit.PortNum
                    End If
            End Select
        Next

        ' Set CL/CH Ports
        p_ULStat = Me.DaqBoard.DOut(MccDaq.DigitalPortType.FirstPortCL, p_CL_value)
        If check_io_error(p_ULStat, "DOutCL") Then Exit Sub

        p_ULStat = Me.DaqBoard.DOut(MccDaq.DigitalPortType.FirstPortCH, p_CH_value)
        If check_io_error(p_ULStat, "DOutCH") Then Exit Sub

        ' Call For Detail Screen Updating
        RaiseEvent BitStatesChanged(Me, New System.EventArgs)
    End Sub
#End Region

#Region " TurnOffAllBits "
    Public Sub TurnOffAllBits()
        If Not DemoMode Then
            Dim p_ULStat As MccDaq.ErrorInfo

            ' ------------------------------------
            ' * TurnOff All A/CL/CH Output Ports
            ' ------------------------------------
            p_ULStat = Me.DaqBoard.DOut(MccDaq.DigitalPortType.FirstPortA, 0)
            If check_io_error(p_ULStat, "DOutA") Then Exit Sub

            p_ULStat = Me.DaqBoard.DOut(MccDaq.DigitalPortType.FirstPortCL, 0)
            If check_io_error(p_ULStat, "DOutCL") Then Exit Sub

            p_ULStat = Me.DaqBoard.DOut(MccDaq.DigitalPortType.FirstPortCH, 0)
            If check_io_error(p_ULStat, "DOutCH") Then Exit Sub

            ' ----------------------------
            ' * Leave Inputs Alone (PortB) 
            ' ----------------------------
            For Each p_bit As Bit In Me.Bits
                If p_bit.PortType <> MccDaq.DigitalPortType.FirstPortB Then
                    p_bit.State = False
                End If
            Next
        Else
            ' Demo Mode
            If Me.Bay_Running Then
                ' ----------------------------
                ' * Leave Inputs Alone (PortB) 
                ' ----------------------------
                For Each p_bit As Bit In Me.Bits
                    If p_bit.PortType <> MccDaq.DigitalPortType.FirstPortB Then
                        p_bit.State = False
                    End If
                Next
            Else
                ' ------------
                ' * Reset Bits
                ' ------------
                For Each p_bit As Bit In Me.Bits
                    p_bit.State = False
                Next
            End If
        End If

        ' Call For Detail Screen Updating
        RaiseEvent BitStatesChanged(Me, New System.EventArgs)
    End Sub
#End Region

#Region " Set Bit "
    Public Sub set_bit(ByVal p_string As String, ByVal p_state As Boolean)
        ' ======================================
        ' * Procedure Called From Service Screen
        ' ======================================
        ' Set Output Bit/Card 
        MachineRunProfile.bits(p_string).State = p_state
        Call ChangeBitStates()
    End Sub
#End Region


#Region " Check Startup "
    Public Function check_startup() As Boolean
        Dim p_error As String = ""

        ' ----------------------------------
        ' * Check Status of Safety and Float
        ' ----------------------------------
        If Me.Has_Disinfect And Me.MonitorResTemperature _
           And Me.ReservoirTemperature < Me.SystemOverrides.min_start_temperature Then
            p_error = "Error:  Invalid Min Reservoir Start Temperature "
        End If

        If Me.MachineRunProfile.bits(I_FLOAT).State _
            And Me.MachineRunProfile.bits(I_SAFETY).State Then
            If p_error <> "" Then p_error &= vbCrLf

            p_error &= "Error:  Invalid Start State (Safety and Float On) "
        Else
            If Me.MachineRunProfile.bits(I_FLOAT).State Then
                If p_error <> "" Then p_error &= vbCrLf

                p_error &= "Error:  Invalid Start State (Float On) "

            ElseIf Me.MachineRunProfile.bits(I_SAFETY).State Then
                If p_error <> "" Then p_error &= vbCrLf

                p_error &= "Error:  Invalid Start State (Safety On) "
            End If
        End If

        If Trim(p_error) <> "" Then
            ' Stop Machine
            Call Me.stop_machine()
            Call Me.TurnOffAllBits()

            ' Raise Error
            Me.MachineRunProfile.error_message = p_error
            Call Me.ErrorOccurr()

            Call Me.SetupMachineDefaults()

            check_startup = True
        Else
            check_startup = False
        End If
    End Function
#End Region

#Region " Stop Machine "
    Public Sub stop_machine()
        ' --------------
        ' * Stop Machine
        ' --------------
        If Me.DemoMode Then Call stop_input_monitor()
        ProfileThread = Nothing

        _stopTime = DateTime.Now
        _bay_running = False
    End Sub
#End Region

#Region " Start Input Monitoring "
    Public Sub start_input_monitor()
        ' Start monitoring the inputs
        _inputMonitor.StartMonitoring()
    End Sub
#End Region

#Region " Stop Input Monitoring "
    Public Sub stop_input_monitor()
        ' Stop monitoring the inputs
        _inputMonitor.StopMonitoring()
    End Sub
#End Region


#Region " Start Maintenance "
    Public Sub Start_Maintenance(ByVal p_type As String)
        _maint_status = True

        If Not MaintThread Is Nothing Then MaintThread = Nothing

        'Start the threading to monitory
        Select Case UCase(p_type)
            Case "PURGE"
                MaintThread = New System.Threading.Thread(AddressOf purge_process)
                MaintThread.Start()

            Case "RETURN"
                MaintThread = New System.Threading.Thread(AddressOf return_process)
                MaintThread.Start()
        End Select
    End Sub
#End Region

#Region " Stop Maintenance "
    Public Sub Stop_Maintenance()
        _maint_status = False

        MaintThread = Nothing
    End Sub
#End Region

#Region " Empty Process "
    Public Sub empty_process()
        ' ==============================
        ' * Do Empty Chamber Maintenance
        ' ==============================

        ' ----------------------------------------------------------
        ' * Turn on the Drain Valve, Drain Pump and Oscillating Pump
        ' ----------------------------------------------------------
        With MachineRunProfile
            .bits(O_DRAIN_P).State = True
            .bits(O_DRAIN_V).State = True
            .bits(O_OSC_P).State = True
        End With

        Call ChangeBitStates()
    End Sub
#End Region

#Region " Purge Process "
    Private Sub purge_process()
        ' ==============================
        ' * Do Purge Process Maintenance
        ' ==============================
        ' -----------------------------------------------------------
        ' * Turn on the Drain Valve, Drain Pump and Oscillating Pump
        ' * Turn on the Disinfect Pump, Feed Valve and Residual Drain
        ' -----------------------------------------------------------
        With Me.MachineRunProfile
            .bits(O_DRAIN_P).State = True
            .bits(O_DRAIN_V).State = True
            .bits(O_OSC_P).State = True

            .bits(O_DIS_P).State = True
            .bits(O_DIS_F_V).State = True
            .bits(O_RES_D).State = True
        End With

        Call ChangeBitStates()

        ' -----------------
        ' * Do Safety Check
        ' -----------------
        Do While _maint_status = True
            System.Threading.Thread.Sleep(1) 'Make it sleep for an amount of Milliseconds.

            If Me.MachineRunProfile.bits(I_SAFETY).State Then Call check_safety()
        Loop
    End Sub
#End Region

#Region " Return Process "
    Private Sub return_process()
        ' ====================================
        ' * Do Return to Reservoir Maintenance
        ' ====================================

        ' ---------------------------------------------------------------------
        ' * Turn on the Drain Pump, Oscillating Pump and Disinfect Return Valve
        ' ---------------------------------------------------------------------
        With MachineRunProfile
            .bits(O_DRAIN_P).State = True
            .bits(O_OSC_P).State = True
            .bits(O_DIS_R_V).State = True
        End With
        Call ChangeBitStates()

        ' -----------------
        ' * Do Safety Check
        ' -----------------
        Do While _maint_status = True
            System.Threading.Thread.Sleep(1) 'Make it sleep for an amount of Milliseconds.

            If Me.MachineRunProfile.bits(I_SAFETY).State Then Call check_safety()
        Loop
    End Sub
#End Region

#Region " Check Safety Information "
    Private Sub check_safety()
        Dim p_delay_flag As Boolean = False
        Dim p_delay_start_time As DateTime

        ' --------------------
        ' * Check Safety Float
        ' --------------------
        Do
            If Me.MachineRunProfile.bits(I_SAFETY).State Then
                If p_delay_flag = False Then
                    p_delay_start_time = DateTime.Now
                    p_delay_flag = True

                Else
                    If Me.SystemOverrides.safety_delay_secs < DateDiff(DateInterval.Second, p_delay_start_time, DateTime.Now) Then
                        ' Stop Machine
                        Call Me.stop_machine()
                        Call Me.TurnOffAllBits()

                        ' Raise Error
                        Me.MachineRunProfile.error_message = "Error:  Safety Float On "
                        Call Me.ErrorOccurr()

                        Call Me.SetupMachineDefaults()
                        Call Me.Stop_Maintenance()

                        Exit Do
                    End If
                End If
            Else
                Exit Do
            End If
        Loop
    End Sub
#End Region


#Region " Check for I/O Error "
    Private Function check_io_error(ByVal p_ULStat As MccDaq.ErrorInfo, ByVal p_type As String) As Boolean
        check_io_error = False

        If p_ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors And Me.Bay_Running Then
            check_io_error = True

            ' ---------------------------------
            ' * Catch Error and Stop Processing
            ' ---------------------------------
            ' Stop Machine
            Call Me.stop_machine()
            Call Me.TurnOffAllBits()

            ' Raise Error
            Me.MachineRunProfile.error_message = Mid("I/O Error: " & p_type & " " & p_ULStat.Value & " " & p_ULStat.Message, 1, 150)
            Call Me.ErrorOccurr()

            Call Me.SetupMachineDefaults()
        End If
    End Function
#End Region

End Class

#End Region