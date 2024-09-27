Imports System.Threading
Imports System

Friend Class CUSProcess

#Region " Public Events "
    Public Event BeforePhaseCompleted As EventHandler
    Public Event AfterPhaseCompleted As EventHandler

    Public Event BeforeCycleCompleted As EventHandler
    Public Event AfterCycleCompleted As EventHandler

    Public Event MachineStarted As EventHandler
    Public Event MachineFinished As EventHandler

    Public Event BitStatesChanged As EventHandler

    Public Event ErrorOccurred As EventHandler
#End Region

#Region " Private Declarations "
    Private _MachineObj As Machine
#End Region

#Region " Sub New "
    Public Sub New(ByVal MachineObj As Machine)
        _MachineObj = MachineObj
    End Sub
#End Region

#Region " Run Machine "
    Public Sub Run_Machine()
        ' Set Run Profile defaults for the Machine
        Call _MachineObj.SetupMachineDefaults()

        ' ----------------------------------------
        ' * Initialize the starter cycle and phase
        ' * Needed For Demo Mode
        ' ----------------------------------------
        If _MachineObj.DemoMode Then
            _MachineObj.MachineRunProfile.current_cycle = _MachineObj.Cycles(0)
            _MachineObj.MachineRunProfile.current_phase = _MachineObj.Cycles(0).Phases(0)

            ' Start monitoring the inputs (Demo Mode)
            Call _MachineObj.start_input_monitor()
        End If

        System.Threading.Thread.Sleep(1) 'Make it sleep for an amount of Milliseconds.

        ' Set Flags
        _MachineObj.Bay_Running = True
        _MachineObj.Processed = False
        _MachineObj.Finished = False

        'Raise the start event
        RaiseEvent MachineStarted(_MachineObj, New System.EventArgs)

        ' Initialize Outputs
        Call _MachineObj.TurnOffAllBits()

        ' This looks at the cycle settings and extracts the timing specifications for the phase
        Call InitializePhaseTiming()

        ' ----------------------------------------------------------
        ' * Check Machine's Status; Old process_init_startup_process
        ' ----------------------------------------------------------
        If Not _MachineObj.DemoMode Then
            If _MachineObj.check_startup() Then Exit Sub
        End If

        ' -------------------------------
        ' * Perform the individual cycles
        ' -------------------------------
        For Each pCycle As Cycle In _MachineObj.Cycles
            'Set the current cycle
            _MachineObj.MachineRunProfile.current_cycle = pCycle

            'Set the current cycle start time
            pCycle.StartTime = DateTime.Now

            'Fire off the event
            RaiseEvent BeforeCycleCompleted(_MachineObj, New System.EventArgs)

            'Execute the phases that make up the cycle
            For Each pPhase As Phase In pCycle.Phases
                'Change the phase status to the current phase
                _MachineObj.MachineRunProfile.current_phase = pPhase

                'Set the current phase start time
                pPhase.StartTime = DateTime.Now

                'Fire off the before phase completed event
                RaiseEvent BeforePhaseCompleted(_MachineObj, New System.EventArgs)

                Select Case pPhase.Phase
                    Case PCBStructs.PHASES.DISINFECT
                        Call DisinfectPhase()           'Execute the Disinfectant Phase

                    Case PCBStructs.PHASES.DRAIN
                        Call DrainPhase()               'Execute the Drain Phase

                    Case PCBStructs.PHASES.DRY
                        Call DryPhase()                 'Execute the Dry Phase

                    Case PCBStructs.PHASES.FILL
                        Call FillPhase()                'Execute the Fill Phase

                    Case PCBStructs.PHASES.PRERINSE
                        Call PreRinsePhase()            'Execute the Prerinse phase

                    Case PCBStructs.PHASES.RINSE
                        Call RinsePhase()               'Execute the Rinse phase

                    Case PCBStructs.PHASES.SOAK
                        Call SoakPhase()                'Execute the soak phase

                    Case PCBStructs.PHASES.WASH
                        Call WashPhase()                'Execute the wash phase
                End Select

                ' --------------------------------------
                ' * Check If Error Occurred During Phase
                ' --------------------------------------
                If Error_Check() Then Exit Sub

                'Update the number of phases completed
                _MachineObj.MachineRunProfile.phases_completed += 1

                'Set the current phase stop time
                pPhase.StopTime = DateTime.Now

                'Fire off the after phase completed event
                RaiseEvent AfterPhaseCompleted(_MachineObj, New System.EventArgs)
            Next

            'Update the number of cycles completed
            _MachineObj.MachineRunProfile.cycles_completed += 1

            'Set the current cycle stop time
            pCycle.StopTime = DateTime.Now

            'fire off the after cycle completed event
            RaiseEvent AfterCycleCompleted(_MachineObj, New System.EventArgs)
        Next

        If _MachineObj.DemoMode Then
            ' Stop monitoring the inputs (Demo Mode)
            Call _MachineObj.stop_input_monitor()
        End If

        ' Set Flags
        _MachineObj.Bay_Running = False
        _MachineObj.Processed = True

        'Turn off all of the bits
        Call _MachineObj.TurnOffAllBits()

        ' --------------------------------------------------------------------
        ' * Reset Machine Current Cycle/Phase (Needed for Temperature Monitor)
        ' --------------------------------------------------------------------
        With _MachineObj.MachineRunProfile
            .current_cycle = Nothing
            .current_phase = Nothing
        End With

        'Raise the Finished event
        RaiseEvent MachineFinished(_MachineObj, New System.EventArgs)
    End Sub
#End Region

#Region " Error Check "
    Private Function Error_Check() As Boolean
        If Not _MachineObj.Bay_Running Then
            Error_Check = True
        Else
            Error_Check = False
        End If
    End Function
#End Region

#Region " Initialize Phase Timing "
    Private Sub InitializePhaseTiming()
        For Each pCycle As Cycle In _MachineObj.Cycles
            For Each pPhase As Phase In pCycle.Phases
                'Do the timing for the phase based on the cycle overrides
                pPhase.AssignTimeInfo(_MachineObj.PinOut, pCycle.SystemOverrides)
            Next
        Next
    End Sub
#End Region

#Region " Execute Phases "

#Region " Drain Phase "
    Private Sub DrainPhase()
        Try

            ' ---------------------------------------------
            ' * Start Drain - Old process_start_drain1 code
            ' ---------------------------------------------
            If _MachineObj.CurrentCycle.Cycle <> PCBStructs.CYCLES.PRERINSE Then
                ' Turn on the Oscillating Pump and Drain Pump
                _MachineObj.MachineRunProfile.bits(O_OSC_P).State = True
                _MachineObj.MachineRunProfile.bits(O_DRAIN_P).State = True

                If (_MachineObj.CurrentCycle.Cycle = PCBStructs.CYCLES.DISINFECT _
                    And _MachineObj.PinOut <> PCBStructs.SYSTEM_ID_DEF.S83S) _
                    Or (_MachineObj.CurrentCycle.Cycle = PCBStructs.CYCLES.RINSE _
                    And _MachineObj.PinOut = PCBStructs.SYSTEM_ID_DEF.S81P) Then

                    ' Turn on the Disinfect Return Valve
                    _MachineObj.MachineRunProfile.bits(O_DIS_R_V).State = True
                Else
                    ' Turn on the Drain Valve
                    _MachineObj.MachineRunProfile.bits(O_DRAIN_V).State = True
                End If

                Call _MachineObj.ChangeBitStates()
            End If

            ' ---------------------------------------------
            ' * Do Wait Drain - Old process_wait_drain code
            ' ---------------------------------------------
            Dim p_start_time As DateTime
            Dim p_delay_start_time As DateTime

            Dim p_delay_flag As Boolean = False
            Dim p_complete As Boolean = False

            p_start_time = DateTime.Now

            Do
                System.Threading.Thread.Sleep(1) 'Make it sleep for an amount of Milliseconds.

                ' -----------------
                ' * Do Safety Check
                ' -----------------
                If _MachineObj.MachineRunProfile.bits(I_SAFETY).State Then Call check_safety()
                If _MachineObj.Bay_Running = False Then Exit Sub

                ' --------------------------
                ' * Do Wait Drain Processing
                ' --------------------------
                If process_wait_drain(p_delay_flag, p_start_time, p_delay_start_time, p_complete) Then Exit Do
            Loop

            ' --------------------------------------------------
            ' * Continue Drain 2 - Old process_start_drain2 code
            ' --------------------------------------------------
            Select Case _MachineObj.CurrentCycle.Cycle
                Case PCBStructs.CYCLES.DISINFECT, PCBStructs.CYCLES.SOAK, PCBStructs.CYCLES.WASH
                    ' Turn off the Drain Pump, Value and Disinfect Return Valve
                    _MachineObj.MachineRunProfile.bits(O_DRAIN_P).State = False
                    _MachineObj.MachineRunProfile.bits(O_DRAIN_V).State = False
                    _MachineObj.MachineRunProfile.bits(O_DIS_R_V).State = False
                    Call _MachineObj.ChangeBitStates()

                Case PCBStructs.CYCLES.RINSE
                    ' Turn off the Drain Pump and Value
                    _MachineObj.MachineRunProfile.bits(O_DRAIN_P).State = False
                    _MachineObj.MachineRunProfile.bits(O_DRAIN_V).State = False

                    ' Check if Rinse After Wash or Last Rinse Of Cycle
                    If _MachineObj.Cycles(_MachineObj.MachineRunProfile.cycles_completed - 1).Cycle = PCBStructs.CYCLES.WASH _
                        Or _MachineObj.MachineRunProfile.cycles_completed = (_MachineObj.Cycles.Count - 1) Then

                        ' Turn off the Oscillating Pump
                        _MachineObj.MachineRunProfile.bits(O_OSC_P).State = False

                        ' Turn on the Air and Residual Drain
                        _MachineObj.MachineRunProfile.bits(O_AIR).State = True
                        _MachineObj.MachineRunProfile.bits(O_RES_D).State = True
                    End If

                    Call _MachineObj.ChangeBitStates()
            End Select

            ' -------------------------------------------
            ' * Do Wait Time - Old process_wait_time code
            ' -------------------------------------------
            ' Drain 30 Secs Variable
            _MachineObj.CurrentPhase._phaseTime = _MachineObj.CurrentCycle.SystemOverrides.drain_30_secs

            Call do_wait_time("DRAIN2", False)
            If _MachineObj.Bay_Running = False Then Exit Sub

            ' --------------------------------------------------
            ' * Continue Drain 3 - Old process_start_drain3 code
            ' --------------------------------------------------
            ' Turn on the Drain Pump
            _MachineObj.MachineRunProfile.bits(O_DRAIN_P).State = True

            Select Case _MachineObj.CurrentCycle.Cycle
                Case PCBStructs.CYCLES.DISINFECT
                    If _MachineObj.PinOut <> PCBStructs.SYSTEM_ID_DEF.S83S Then
                        ' Turn on the Disinfect Return Valve
                        _MachineObj.MachineRunProfile.bits(O_DIS_R_V).State = True
                    Else
                        ' Turn on the Drain Valve
                        _MachineObj.MachineRunProfile.bits(O_DRAIN_V).State = True
                    End If

                Case PCBStructs.CYCLES.RINSE
                    ' --------------------------------------------------
                    ' * Check if Rinse After Wash or Last Rinse Of Cycle
                    ' --------------------------------------------------
                    If _MachineObj.Cycles(_MachineObj.MachineRunProfile.cycles_completed - 1).Cycle = PCBStructs.CYCLES.WASH _
                        Or _MachineObj.MachineRunProfile.cycles_completed = (_MachineObj.Cycles.Count - 1) Then

                        If _MachineObj.PinOut <> PCBStructs.SYSTEM_ID_DEF.S81P Then
                            ' Turn on the Drain Valve
                            _MachineObj.MachineRunProfile.bits(O_DRAIN_V).State = True
                        Else
                            ' Turn on the Disinfect Return Valve
                            _MachineObj.MachineRunProfile.bits(O_DIS_R_V).State = True
                        End If
                    Else
                        ' Turn on the Drain Valve
                        _MachineObj.MachineRunProfile.bits(O_DRAIN_V).State = True
                    End If

                Case PCBStructs.CYCLES.SOAK, PCBStructs.CYCLES.WASH
                    ' Turn on the Drain Valve
                    _MachineObj.MachineRunProfile.bits(O_DRAIN_V).State = True
            End Select

            Call _MachineObj.ChangeBitStates()

            ' -------------------------------------------
            ' * Do Wait Time - Old process_wait_time code
            ' -------------------------------------------
            ' Drain 10 Secs Variable
            _MachineObj.CurrentPhase._phaseTime = _MachineObj.CurrentCycle.SystemOverrides.drain_10_secs

            Call do_wait_time("DRAIN3")
            If _MachineObj.Bay_Running = False Then Exit Sub

            ' -------------------------------------------------------------------------------------------------
            ' * After Drain Completed - Check Drain Min and Max Aborts - Non-Demo Mode And England Machine Only
            ' -------------------------------------------------------------------------------------------------
            If _MachineObj.DemoMode = False And _MachineObj.EnglandMode = True Then
                ' Get the current phase seconds lapsed
                Dim p_seconds_lapsed As Long
                p_seconds_lapsed = DateDiff(DateInterval.Second, _MachineObj.CurrentPhase.StartTime, DateTime.Now)

                ' -----------------------
                ' * Check Drain Min Abort
                ' -----------------------
                If _MachineObj.SystemOverrides.drain_min_abort_secs >= p_seconds_lapsed Then
                    ' Stop Machine
                    Call _MachineObj.stop_machine()
                    Call _MachineObj.TurnOffAllBits()

                    ' Raise Error
                    _MachineObj.MachineRunProfile.error_message = "Error:  Drain Min Abort"
                    Call _MachineObj.ErrorOccurr()

                    Call _MachineObj.SetupMachineDefaults()
                End If

                ' -----------------------
                ' * Check Drain Max Abort
                ' -----------------------
                If _MachineObj.SystemOverrides.drain_max_abort_secs <= p_seconds_lapsed Then
                    ' Stop Machine
                    Call _MachineObj.stop_machine()
                    Call _MachineObj.TurnOffAllBits()

                    ' Raise Error
                    _MachineObj.MachineRunProfile.error_message = "Error:  Drain Max Abort"
                    Call _MachineObj.ErrorOccurr()

                    Call _MachineObj.SetupMachineDefaults()
                End If
            End If

        Catch
        End Try
    End Sub
#End Region

#Region " Fill Phase "
    Private Sub FillPhase()
        Try
            ' ----------------------------------------------------------
            ' * Set Phase Specific Outputs - Old process_start_fill code
            ' ----------------------------------------------------------
            Select Case _MachineObj.CurrentCycle.Cycle
                Case PCBStructs.CYCLES.RINSE
                    ' Check if Rinse After Wash or Last Rinse Of Cycle
                    If (_MachineObj.Cycles(_MachineObj.MachineRunProfile.cycles_completed - 1).Cycle = PCBStructs.CYCLES.WASH _
                        Or _MachineObj.MachineRunProfile.cycles_completed = (_MachineObj.Cycles.Count - 1)) _
                        And _MachineObj.Lubrication Then

                        ' Turn on the Lubrication Pump
                        _MachineObj.MachineRunProfile.bits(O_LUB_P).State = True
                    End If

                Case PCBStructs.CYCLES.SOAK
                    ' Turn on the Enzyme Pump
                    _MachineObj.MachineRunProfile.bits(O_ENZ_P).State = True

                Case PCBStructs.CYCLES.WASH
                    Select Case _MachineObj.PinOut
                        Case PCBStructs.SYSTEM_ID_DEF.S81X, PCBStructs.SYSTEM_ID_DEF.S81Y, _
                             PCBStructs.SYSTEM_ID_DEF.S81Z, PCBStructs.SYSTEM_ID_DEF.S83A, _
                             PCBStructs.SYSTEM_ID_DEF.S83S

                            ' Turn on the Detergent Pump
                            _MachineObj.MachineRunProfile.bits(O_DET_81_P).State = True

                        Case PCBStructs.SYSTEM_ID_DEF.S83D, PCBStructs.SYSTEM_ID_DEF.S83DT

                            ' Turn on the Lubrication Pump
                            _MachineObj.MachineRunProfile.bits(O_LUB_P).State = True
                    End Select
            End Select

            ' ------------------------------------------------------
            ' * Set Fill Valve Outputs - Old process_start_fill code
            ' ------------------------------------------------------
            If _MachineObj.CurrentCycle.Cycle = PCBStructs.CYCLES.DISINFECT _
                Or (_MachineObj.CurrentCycle.Cycle = PCBStructs.CYCLES.WASH _
                And _MachineObj.PinOut = PCBStructs.SYSTEM_ID_DEF.S81P) Then

                ' Turn on the Disinfect Feed/Pump
                _MachineObj.MachineRunProfile.bits(O_DIS_F_V).State = True
                _MachineObj.MachineRunProfile.bits(O_DIS_P).State = True

            ElseIf _MachineObj.PinOut = PCBStructs.SYSTEM_ID_DEF.S83S _
                And _MachineObj.CurrentCycle.Cycle = PCBStructs.CYCLES.RINSE _
                And _MachineObj.MachineRunProfile.cycles_completed = (_MachineObj.Cycles.Count - 1) Then

                ' Turn on the Steril Water Valve
                _MachineObj.MachineRunProfile.bits(O_DIS_R_V).State = True
            Else
                ' Turn on the Water Valve
                _MachineObj.MachineRunProfile.bits(O_WATER_V).State = True
            End If

            Call _MachineObj.ChangeBitStates()

            ' ---------------------------------------------------
            ' * Run Wait Fill Checks - Old process_wait_fill code
            ' ---------------------------------------------------
            Dim p_delay_flag As Boolean = False
            Dim p_start_time As DateTime
            Dim p_delay_start_time As DateTime

            p_start_time = DateTime.Now

            Do
                ' ------------------------
                ' * Pinout Specific Checks
                ' ------------------------
                Select Case _MachineObj.PinOut
                    Case PCBStructs.SYSTEM_ID_DEF.S81, PCBStructs.SYSTEM_ID_DEF.S81X, _
                         PCBStructs.SYSTEM_ID_DEF.S81Y, PCBStructs.SYSTEM_ID_DEF.S81Z, _
                         PCBStructs.SYSTEM_ID_DEF.S83A

                        If _MachineObj.MachineRunProfile.bits(O_LUB_P).State _
                            And _MachineObj.CurrentCycle.SystemOverrides.lub_secs < DateDiff(DateInterval.Second, p_start_time, DateTime.Now) Then

                            ' Turn off the Lubrication Pump
                            _MachineObj.MachineRunProfile.bits(O_LUB_P).State = False
                            Call _MachineObj.ChangeBitStates()
                        End If
                End Select

                ' -----------------------
                ' * Phase Specific Checks
                ' -----------------------
                Select Case _MachineObj.CurrentCycle.Cycle
                    Case PCBStructs.CYCLES.SOAK
                        ' ---------------------
                        ' * Soak Phase Specific
                        ' ---------------------
                        If _MachineObj.MachineRunProfile.bits(O_ENZ_P).State _
                            And _MachineObj.CurrentCycle.SystemOverrides.enzyme_secs < DateDiff(DateInterval.Second, p_start_time, DateTime.Now) Then

                            ' Turn off the Enzyme Pump
                            _MachineObj.MachineRunProfile.bits(O_ENZ_P).State = False
                            Call _MachineObj.ChangeBitStates()
                        End If

                    Case PCBStructs.CYCLES.WASH
                        ' ---------------------
                        ' * Wash Phase Specific
                        ' ---------------------
                        Select Case _MachineObj.PinOut
                            Case PCBStructs.SYSTEM_ID_DEF.S81P
                                If _MachineObj.MachineRunProfile.bits(O_WATER_V).State = False _
                                    And _MachineObj.CurrentCycle.SystemOverrides.reservoir_fill_secs < DateDiff(DateInterval.Second, p_start_time, DateTime.Now) Then

                                    ' Turn on the Water Valve
                                    _MachineObj.MachineRunProfile.bits(O_WATER_V).State = True
                                    Call _MachineObj.ChangeBitStates()
                                End If

                            Case PCBStructs.SYSTEM_ID_DEF.S81X, PCBStructs.SYSTEM_ID_DEF.S81Y, _
                                 PCBStructs.SYSTEM_ID_DEF.S81Z
                                If _MachineObj.MachineRunProfile.bits(O_DET_81_P).State _
                                    And _MachineObj.CurrentCycle.SystemOverrides.detergent_81_secs < DateDiff(DateInterval.Second, p_start_time, DateTime.Now) Then

                                    ' Turn off the Detergent Pump
                                    _MachineObj.MachineRunProfile.bits(O_DET_81_P).State = False
                                    Call _MachineObj.ChangeBitStates()
                                End If

                            Case PCBStructs.SYSTEM_ID_DEF.S83A, PCBStructs.SYSTEM_ID_DEF.S83S
                                If _MachineObj.MachineRunProfile.bits(O_DET_81_P).State _
                                    And _MachineObj.CurrentCycle.SystemOverrides.detergent_83_secs < DateDiff(DateInterval.Second, p_start_time, DateTime.Now) Then

                                    ' Turn off the Detergent Pump
                                    _MachineObj.MachineRunProfile.bits(O_DET_81_P).State = False
                                    Call _MachineObj.ChangeBitStates()
                                End If

                            Case PCBStructs.SYSTEM_ID_DEF.S83, PCBStructs.SYSTEM_ID_DEF.S83D, _
                                 PCBStructs.SYSTEM_ID_DEF.S83DT, PCBStructs.SYSTEM_ID_DEF.S83R
                                If _MachineObj.MachineRunProfile.bits(O_LUB_P).State _
                                    And _MachineObj.CurrentCycle.SystemOverrides.detergent_83_secs < DateDiff(DateInterval.Second, p_start_time, DateTime.Now) Then

                                    ' Turn off the Lubrication Pump
                                    _MachineObj.MachineRunProfile.bits(O_LUB_P).State = False
                                    Call _MachineObj.ChangeBitStates()
                                End If
                        End Select
                End Select

                System.Threading.Thread.Sleep(1) 'Make it sleep for an amount of Milliseconds.

                ' -----------------
                ' * Do Safety Check
                ' -----------------
                If _MachineObj.MachineRunProfile.bits(I_SAFETY).State Then Call check_safety()
                If _MachineObj.Bay_Running = False Then Exit Sub

                ' ----------------------------------------------------
                ' * Check Float For Fill Status, Exit if Fill Complete
                ' ----------------------------------------------------
                If check_float(p_delay_flag, p_delay_start_time, p_start_time) Then Exit Do
                If _MachineObj.Bay_Running = False Then Exit Sub
            Loop

            ' -----------------------------------------------------------------------------------------------
            ' * After Fill Completed - Check Fill Min and Max Aborts - Non-Demo Mode and England Machine Only
            ' -----------------------------------------------------------------------------------------------
            If _MachineObj.DemoMode = False And _MachineObj.EnglandMode = True Then
                ' Get the current phase seconds lapsed
                Dim p_seconds_lapsed As Long
                p_seconds_lapsed = DateDiff(DateInterval.Second, _MachineObj.CurrentPhase.StartTime, DateTime.Now)

                ' ----------------------
                ' * Check Fill Min Abort
                ' ----------------------
                If _MachineObj.SystemOverrides.fill_min_abort_secs >= p_seconds_lapsed Then
                    ' Stop Machine
                    Call _MachineObj.stop_machine()
                    Call _MachineObj.TurnOffAllBits()

                    ' Raise Error
                    _MachineObj.MachineRunProfile.error_message = "Error:  Fill Min Abort"
                    Call _MachineObj.ErrorOccurr()

                    Call _MachineObj.SetupMachineDefaults()
                End If

                ' ----------------------
                ' * Check Fill Max Abort
                ' ----------------------
                If _MachineObj.SystemOverrides.fill_max_abort_secs <= p_seconds_lapsed Then
                    ' Stop Machine
                    Call _MachineObj.stop_machine()
                    Call _MachineObj.TurnOffAllBits()

                    ' Raise Error
                    _MachineObj.MachineRunProfile.error_message = "Error:  Fill Max Abort"
                    Call _MachineObj.ErrorOccurr()

                    Call _MachineObj.SetupMachineDefaults()
                End If

                If _MachineObj.Bay_Running = False Then Exit Sub
            End If

            ' -----------------------
            ' * Do Post Fill Activity
            ' -----------------------
            ' Turn on the Oscillating Pump
            _MachineObj.MachineRunProfile.bits(O_OSC_P).State = True

            If _MachineObj.CurrentCycle.Cycle <> PCBStructs.CYCLES.SOAK Then
                If _MachineObj.CurrentCycle.Cycle <> PCBStructs.CYCLES.DISINFECT _
                    Or _MachineObj.PinOut = PCBStructs.SYSTEM_ID_DEF.S82 Then
                    ' Turn on the UltraSonics
                    _MachineObj.MachineRunProfile.bits(O_ULTRA).State = True
                End If
            End If

            Call _MachineObj.ChangeBitStates()

        Catch
        End Try
    End Sub
#End Region

#Region " Disinfect Phase "
    Private Sub DisinfectPhase()
        ' ==================
        ' * Do the Disinfect
        ' ==================
        Try
            Call do_wait_time("PROCESSING")
            If _MachineObj.Bay_Running = False Then Exit Sub
        Catch
        End Try

        ' ------------------------------------------------------------------
        ' * Get Bay Temperature After Disfect - in Old process_system_states
        ' ------------------------------------------------------------------
        If _MachineObj.MonitorResTemperature Then
            _MachineObj.Final_Disinfect_Temp = _MachineObj.BayTemperature
        Else
            _MachineObj.Final_Disinfect_Temp = 0
        End If
    End Sub
#End Region

#Region " Dry Phase "
    Private Sub DryPhase()
        ' ============================
        ' * Do the Dry Heat, Cool Down
        ' ============================

        Try

            ' ----------
            ' * Dry Heat
            ' ----------
            ' Turn on the Air and Reservoir Heat
            _MachineObj.MachineRunProfile.bits(O_AIR).State = True
            _MachineObj.MachineRunProfile.bits(O_RES_H).State = True
            Call _MachineObj.ChangeBitStates()

            ' -------------------------------------------
            ' * Do Wait Time - Old process_wait_time code
            ' -------------------------------------------
            ' Dry Heat Secs Variable
            _MachineObj.CurrentPhase._phaseTime = _MachineObj.CurrentCycle.SystemOverrides.dry_heat_secs

            Call do_wait_time("DRY_HEAT", False) ' Keeps Air On
            If _MachineObj.Bay_Running = False Then Exit Sub

            ' -----------
            ' * Cool Down
            ' -----------
            ' Turn off Reservoir Heat
            _MachineObj.MachineRunProfile.bits(O_RES_H).State = False
            Call _MachineObj.ChangeBitStates()

            ' -------------------------------------------
            ' * Do Wait Time - Old process_wait_time code
            ' -------------------------------------------
            ' Cool down Secs Variable
            _MachineObj.CurrentPhase._phaseTime = _MachineObj.CurrentCycle.SystemOverrides.dry_cool_secs

            Call do_wait_time("COOL_DOWN")
            If _MachineObj.Bay_Running = False Then Exit Sub

        Catch
        End Try
    End Sub
#End Region

#Region " Prerinse Phase "
    Private Sub PreRinsePhase()
        ' =================
        ' * Do the Prerinse
        ' =================

        'Turn on the Drain Pump, Valve and Rinse Spray
        _MachineObj.MachineRunProfile.bits(O_DRAIN_P).State = True
        _MachineObj.MachineRunProfile.bits(O_DRAIN_V).State = True
        _MachineObj.MachineRunProfile.bits(O_RINSE_S).State = True
        Call _MachineObj.ChangeBitStates()

        ' -------------------------------------------
        ' * Do Wait Time - Old process_wait_time code
        ' -------------------------------------------
        Try
            Call do_wait_time("PROCESSING", False) ' Keeps Drain P+V On
            If _MachineObj.Bay_Running = False Then Exit Sub

            'Turn off Rinse Spray
            _MachineObj.MachineRunProfile.bits(O_RINSE_S).State = False
            Call _MachineObj.ChangeBitStates()
        Catch
        End Try
    End Sub
#End Region

#Region " Rinse Phase "
    Private Sub RinsePhase()
        ' =============
        ' * Do the Soak
        ' =============
        Try
            Call do_wait_time("PROCESSING")
            If _MachineObj.Bay_Running = False Then Exit Sub
        Catch
        End Try
    End Sub
#End Region

#Region " Soak Phase "
    Private Sub SoakPhase()
        ' =============
        ' * Do the Soak
        ' =============
        Try
            Call do_wait_time("PROCESSING")
            If _MachineObj.Bay_Running = False Then Exit Sub
        Catch
        End Try
    End Sub
#End Region

#Region " Wash Phase "
    Private Sub WashPhase()
        ' =============
        ' * Do the Wash
        ' =============
        Try
            Call do_wait_time("PROCESSING")
            If _MachineObj.Bay_Running = False Then Exit Sub
        Catch
        End Try
    End Sub
#End Region

#End Region

#Region " Extra Phase Functions "

#Region " Check Float Information "
    Private Function check_float(ByRef p_delay_flag As Boolean, ByRef p_delay_start_time As DateTime, _
        ByRef p_start_time As DateTime) As Boolean

        ' -----------------------------------------
        ' * Check For Regular Operation Float Delay
        ' -----------------------------------------
        If _MachineObj.MachineRunProfile.bits(I_FLOAT).State _
            And p_delay_flag = False Then

            p_delay_start_time = DateTime.Now
            p_delay_flag = True

        ElseIf _MachineObj.MachineRunProfile.bits(I_FLOAT).State = False _
            And p_delay_flag Then
            p_delay_flag = False

        ElseIf p_delay_flag _
            And _MachineObj.MachineRunProfile.bits(I_FLOAT).State _
            And _MachineObj.MachineRunProfile.bits(I_FLOW).State _
            And _MachineObj.CurrentCycle.SystemOverrides.float_delay_secs < DateDiff(DateInterval.Second, p_delay_start_time, DateTime.Now) _
            And (_MachineObj.MachineRunProfile.bits(O_DIS_F_V).State _
            Or _MachineObj.MachineRunProfile.bits(O_DIS_P).State _
            Or _MachineObj.MachineRunProfile.bits(O_WATER_V).State) Then

            If _MachineObj.PinOut <> PCBStructs.SYSTEM_ID_DEF.S81X Then
                ' Turn off the Disinfect Feed/Pump
                _MachineObj.MachineRunProfile.bits(O_DIS_F_V).State = False
                _MachineObj.MachineRunProfile.bits(O_DIS_P).State = False
            End If

            ' Turn off the Water Valve
            _MachineObj.MachineRunProfile.bits(O_WATER_V).State = False
            Call _MachineObj.ChangeBitStates()
        End If

        If p_delay_flag _
            And _MachineObj.MachineRunProfile.bits(O_LUB_P).State = False _
            And _MachineObj.MachineRunProfile.bits(O_DET_81_P).State = False _
            And _MachineObj.MachineRunProfile.bits(O_ENZ_P).State = False _
            And _MachineObj.MachineRunProfile.bits(I_FLOAT).State _
            And _MachineObj.MachineRunProfile.bits(I_FLOW).State _
            And _MachineObj.CurrentCycle.SystemOverrides.float_delay_secs < DateDiff(DateInterval.Second, p_delay_start_time, DateTime.Now) Then

            check_float = True

            ' -----------------------------------------------------------------
            ' * Turn Off All Bits - Old program_system_states done If statement
            ' -----------------------------------------------------------------
            Call _MachineObj.TurnOffAllBits()
        Else
            check_float = False

            ' -------------------------
            ' * Check Float Abort Delay
            ' -------------------------
            If _MachineObj.CurrentCycle.SystemOverrides.float_abort_delay_secs < DateDiff(DateInterval.Second, p_start_time, DateTime.Now) Then
                ' Stop Machine
                Call _MachineObj.stop_machine()
                Call _MachineObj.TurnOffAllBits()

                ' Raise Error
                _MachineObj.MachineRunProfile.error_message = "Error:  Operation Float Abort"
                Call _MachineObj.ErrorOccurr()

                Call _MachineObj.SetupMachineDefaults()
            End If
        End If
    End Function
#End Region

#Region " Check Safety Information "
    Private Sub check_safety()
        Dim p_delay_flag As Boolean = False
        Dim p_delay_start_time As DateTime

        ' --------------------
        ' * Check Safety Float
        ' --------------------
        Do
            If _MachineObj.MachineRunProfile.bits(I_SAFETY).State Then
                If p_delay_flag = False Then
                    p_delay_start_time = DateTime.Now
                    p_delay_flag = True

                Else
                    If Not _MachineObj.CurrentCycle Is Nothing Then
                        If _MachineObj.CurrentCycle.SystemOverrides.safety_delay_secs < DateDiff(DateInterval.Second, p_delay_start_time, DateTime.Now) Then
                            ' Stop Machine
                            Call _MachineObj.stop_machine()
                            Call _MachineObj.TurnOffAllBits()

                            ' Raise Error
                            _MachineObj.MachineRunProfile.error_message = "Error:  Safety Float On "
                            Call _MachineObj.ErrorOccurr()

                            Call _MachineObj.SetupMachineDefaults()

                            Exit Do
                        End If
                    Else
                        If _MachineObj.SystemOverrides.safety_delay_secs < DateDiff(DateInterval.Second, p_delay_start_time, DateTime.Now) Then
                            ' Stop Machine
                            Call _MachineObj.stop_machine()
                            Call _MachineObj.TurnOffAllBits()

                            ' Raise Error
                            _MachineObj.MachineRunProfile.error_message = "Error:  Safety Float On "
                            Call _MachineObj.ErrorOccurr()

                            Call _MachineObj.SetupMachineDefaults()

                            Exit Do
                        End If
                    End If
                End If
            Else
                Exit Do
            End If
        Loop
    End Sub
#End Region

#Region " Check Ultrasonics Information "
    Private Sub check_ultrasonics()
        Dim p_delay_flag As Boolean = False
        Dim p_delay_start_time As DateTime

        ' --------------------------
        ' * Check Ultrasonics Sensor
        ' --------------------------
        Do
            If _MachineObj.MachineRunProfile.bits(O_ULTRA).State = True And _MachineObj.MachineRunProfile.bits(I_ULTRASONICS).State = False Then
                If p_delay_flag = False Then
                    p_delay_start_time = DateTime.Now
                    p_delay_flag = True

                ElseIf _MachineObj.CurrentCycle.SystemOverrides.ultrasonics_delay_secs < DateDiff(DateInterval.Second, p_delay_start_time, DateTime.Now) Then
                    ' Stop Machine
                    Call _MachineObj.stop_machine()
                    Call _MachineObj.TurnOffAllBits()

                    ' Raise Error
                    _MachineObj.MachineRunProfile.error_message = "Error:  Ultrasonics Abort "
                    Call _MachineObj.ErrorOccurr()

                    Call _MachineObj.SetupMachineDefaults()

                    Exit Do
                End If
            Else
                Exit Do
            End If
        Loop
    End Sub
#End Region

#Region " Process Wait Drain "
    Private Function process_wait_drain(ByRef p_delay_flag As Boolean, ByRef p_start_time As DateTime, _
        ByRef p_delay_start_time As DateTime, ByRef p_complete As Boolean) As Boolean

        ' ------------------
        ' * Check Wait Drain
        ' ------------------
        If _MachineObj.PinOut = PCBStructs.SYSTEM_ID_DEF.S81P _
            And _MachineObj.CurrentCycle.Cycle = PCBStructs.CYCLES.RINSE _
            And _MachineObj.MachineRunProfile.bits(O_DIS_R_V).State Then

            ' Turn off Disinfect Return Valve and Turn On Drain Valve
            _MachineObj.MachineRunProfile.bits(O_DIS_R_V).State = False
            _MachineObj.MachineRunProfile.bits(O_DRAIN_V).State = True
            Call _MachineObj.ChangeBitStates()
        End If

        If p_complete = False _
            And (_MachineObj.PinOut = PCBStructs.SYSTEM_ID_DEF.S81 Or _MachineObj.PinOut = PCBStructs.SYSTEM_ID_DEF.S81X _
            Or _MachineObj.PinOut = PCBStructs.SYSTEM_ID_DEF.S81Y Or _MachineObj.PinOut = PCBStructs.SYSTEM_ID_DEF.S81Z) _
            And (_MachineObj.CurrentCycle.Cycle = PCBStructs.CYCLES.WASH Or _MachineObj.CurrentCycle.Cycle = PCBStructs.CYCLES.RINSE) Then

            If _MachineObj.MachineRunProfile.bits(O_RINSE_S).State = False _
                And _MachineObj.CurrentCycle.SystemOverrides.spray_rinse_wait_secs < DateDiff(DateInterval.Second, p_start_time, DateTime.Now) Then

                ' Turn on Spray Rinse Valve
                _MachineObj.MachineRunProfile.bits(O_RINSE_S).State = True
                Call _MachineObj.ChangeBitStates()

            ElseIf _MachineObj.CurrentCycle.SystemOverrides.spray_rinse_wait_secs + _MachineObj.CurrentCycle.SystemOverrides.spray_rinse_secs < DateDiff(DateInterval.Second, p_start_time, DateTime.Now) Then
                ' Turn off Spray Rinse Valve
                _MachineObj.MachineRunProfile.bits(O_RINSE_S).State = False
                Call _MachineObj.ChangeBitStates()

                ' Flag Spray Rinse As Completed
                p_complete = True
            End If
        Else
            ' Run Delay Start Time
            If p_delay_flag = False _
                And _MachineObj.MachineRunProfile.bits(I_FLOW).State = False _
                And _MachineObj.MachineRunProfile.bits(I_FLOAT).State = False Then

                p_delay_start_time = DateTime.Now
                p_delay_flag = True

            ElseIf p_delay_flag _
                And (_MachineObj.MachineRunProfile.bits(I_FLOW).State _
                Or _MachineObj.MachineRunProfile.bits(I_FLOAT).State) Then

                p_delay_flag = False

            ElseIf p_delay_flag _
                And _MachineObj.MachineRunProfile.bits(I_FLOW).State = False _
                And _MachineObj.MachineRunProfile.bits(I_FLOAT).State = False _
                And _MachineObj.CurrentCycle.SystemOverrides.warwick_delay_secs < DateDiff(DateInterval.Second, p_delay_start_time, DateTime.Now) Then

                process_wait_drain = True

                '' -----------------------------------------------------------------
                '' * Turn Off All Bits - Old program_system_states done If statement
                '' -----------------------------------------------------------------
                'Call _MachineObj.TurnOffAllBits()

                Exit Function
            End If
        End If

        process_wait_drain = False
    End Function
#End Region

#Region " Process Wait Time "
    Private Sub do_wait_time(ByVal p_state As String, Optional ByVal p_reset_all As Boolean = True)
        Dim p_start_time As DateTime
        Dim p_pressure_delay_start_time As DateTime

        ' -------------------------------------------
        ' * Do Wait Time - Old process_wait_time code
        ' -------------------------------------------

        p_start_time = DateTime.Now

        Do
            System.Threading.Thread.Sleep(1) 'Make it sleep for an amount of Milliseconds.

            ' -----------------
            ' * Do Safety Check
            ' -----------------
            If _MachineObj.MachineRunProfile.bits(I_SAFETY).State Then Call check_safety()
            If _MachineObj.Bay_Running = False Then Exit Sub

            If g_us_usage Then
                ' -----------------------------
                ' * Do Ultrasonics Sensor Check
                ' -----------------------------
                If _MachineObj.MachineRunProfile.bits(O_ULTRA).State Then Call check_ultrasonics()
                If _MachineObj.Bay_Running = False Then Exit Sub
            End If

            ' --------------------------
            ' * Do Phase Time Processing
            ' --------------------------
            If process_wait_time(p_start_time, p_pressure_delay_start_time, p_state) Then Exit Do
            If _MachineObj.Bay_Running = False Then Exit Sub
        Loop

        ' -----------------------------------------------------------------
        ' * Turn Off All Bits - Old program_system_states done If statement
        ' -----------------------------------------------------------------
        If p_reset_all Then Call _MachineObj.TurnOffAllBits()
    End Sub

    Private Function process_wait_time(ByRef p_start_time As DateTime, ByRef p_pressure_delay_start_time As DateTime, ByVal p_state As String) As Boolean
        ' ------------------------------------
        ' * Check Wait Time And Pressure Input
        ' ------------------------------------
        If UCase(p_state) = "DRAIN3" Then
            If _MachineObj.PinOut = PCBStructs.SYSTEM_ID_DEF.S81P _
                And _MachineObj.CurrentCycle.Cycle = PCBStructs.CYCLES.RINSE _
                And _MachineObj.MachineRunProfile.bits(O_DIS_R_V).State Then

                ' Turn off Disinfect Return Valve
                _MachineObj.MachineRunProfile.bits(O_DIS_R_V).State = False

                ' Turn on Drain Valve
                _MachineObj.MachineRunProfile.bits(O_DRAIN_V).State = True

                Call _MachineObj.ChangeBitStates()
            End If
        End If

        If _MachineObj.CurrentPhase.PhaseTime > DateDiff(DateInterval.Second, p_start_time, DateTime.Now) Then
            ' --------------------------------------------------------------
            ' * Changed 10/29/2007 - RM
            ' * Pressure Delay Start Time was not getting properly set/reset
            ' --------------------------------------------------------------
            If _MachineObj.MachineRunProfile.bits(I_PRESSURE).State Then
                ' Reset Pressure Delay Start Time
                p_pressure_delay_start_time = Nothing
            Else
                ' Get Pressure Delay Start Time, If Blank
                If p_pressure_delay_start_time = "12:00:00 AM" Then
                    p_pressure_delay_start_time = DateTime.Now
                End If

                If UCase(p_state) = "PROCESSING" _
                    And _MachineObj.CurrentCycle.SystemOverrides.pressure_start_delay_secs < DateDiff(DateInterval.Second, p_start_time, DateTime.Now) _
                    And _MachineObj.CurrentCycle.SystemOverrides.pressure_error_delay_secs < DateDiff(DateInterval.Second, p_pressure_delay_start_time, DateTime.Now) _
                    And _MachineObj.CurrentCycle.Cycle <> PCBStructs.CYCLES.PRERINSE Then
                    ' ----------------------
                    ' * Error Water Channels
                    ' ----------------------
                    ' Stop Machine
                    Call _MachineObj.stop_machine()
                    Call _MachineObj.TurnOffAllBits()

                    ' Raise Error
                    _MachineObj.MachineRunProfile.error_message = "Error:  Check Water Channels "
                    Call _MachineObj.ErrorOccurr()

                    Call _MachineObj.SetupMachineDefaults()
                End If
            End If

            If _MachineObj.CurrentCycle.Cycle = PCBStructs.CYCLES.DISINFECT _
                And _MachineObj.PinOut = PCBStructs.SYSTEM_ID_DEF.S82 _
                And _MachineObj.MachineRunProfile.bits(O_ULTRA).State _
                And _MachineObj.CurrentCycle.SystemOverrides.dis_ultra_secs < DateDiff(DateInterval.Second, p_start_time, DateTime.Now) Then

                ' Turn off UltraSonics
                _MachineObj.MachineRunProfile.bits(O_ULTRA).State = False
                Call _MachineObj.ChangeBitStates()
            End If

            process_wait_time = False
        Else
            process_wait_time = True
        End If
    End Function
#End Region

#End Region

End Class
