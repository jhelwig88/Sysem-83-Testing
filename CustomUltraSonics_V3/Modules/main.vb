Module main

#Const IO_TYPE = "USB"
    '#Const IO_TYPE = "PCI"

#Region " Declarations "
    ' --------------------------------
    ' * Framework Settings Information
    ' --------------------------------
    Public g_is_internal As Boolean = True
    Public g_mdi_form As backdrop
    Public g_login As login

    ' CU Local Machine
    Public g_framework As New DBA_Framework.DBA_Foundation_Class("CU", "", "")
    Public g_service_url As String = "http://localhost/dba_xzip_webservice/service.asmx"
    Public g_login_as As String = "CU"
    Public g_shutdown As Boolean = True

    ' DBA INTERNAL
    'Public g_framework As New DBA_Framework.DBA_Foundation_Class("CU_DBA", "", "")
    'Public g_service_url As String = "http://win2003-dba1/dba_xzip_webservice/service.asmx"
    'Public g_login_as As String = "DBA"
    'Public g_shutdown As Boolean = False

    ' CUS EXTERNAL
    'Public g_framework As New DBA_Framework.DBA_Foundation_Class("CU_TEST", "", "")
    'Public g_service_url As String = "http://71.162.146.2/dba_xzip_webservice/service.asmx"
    ''Public g_service_url As String = "http://dba-web/dba_xzip_webservice/service.asmx"
    'Public g_login_as As String = "CU"
    'Public g_shutdown As Boolean = False

    ' England EXTERNAL
    'Public g_framework As New DBA_Framework.DBA_Foundation_Class("CU_ENGLAND", "", "")
    'Public g_service_url As String = "http://71.162.146.2/dba_xzip_webservice/service.asmx"
    ''Public g_service_url As String = "http://dba-web/dba_xzip_webservice/service.asmx"
    'Public g_login_as As String = "CU"
    'Public g_shutdown As Boolean = False

    Public g_master_password As String

    ' ---------
    ' * Globals
    ' ---------
    ' Program Globals
    Public g_forms(3) As DBA_Framework.DBA_Foundation_Class
    Public g_master As Boolean
    Public g_admin As Boolean
    Public g_reload_dd As Boolean
    Public g_pass_str As String
    Public g_pass_str2 As String
    Public g_pass_str3 As String

    Public g_organization As String
    Public g_demo_mode As String
    Public g_demo_mode_flag As Boolean
    Public g_bay_count As Integer
    Public g_max_instrument As Integer
    Public g_ss_disabled_flag As Boolean
    Public g_england_flag As Boolean
    Public g_hide_F7_flag As Boolean

    Public g_disinfect_lot1 As String
    Public g_disinfect_lot2 As String
    Public g_disinfect_lot3 As String
    Public g_disinfect_lot4 As String

    Public g_override_patient_entry_flag As Boolean
    Public g_enable_file_output_flag As Boolean
    Public g_file_output_path As String

    ' Bay Globals
    Public g_disinfect_settings(3) As Integer
    Public g_disinfect_overrides(3) As Integer

    Public g_lubrication_settings(3) As Integer
    Public g_lubrication_overrides(3) As Integer

    ' Machine Globals
    Public Const g_max_bays As Integer = 4
    Public g_CUSMain As CUSNET.CUSMain

    'Ultrasonics Sensor Usage
    Public g_us_usage As Boolean = True

    'Printing
#If IO_TYPE = "USB" Then
    Public g_PrintPort As String = ""

#ElseIf IO_TYPE = "PCI" Then
    Public g_PrintPort As String = "LPT1"
#End If

    ' ------
    ' * APIs
    ' ------
    Declare Function ShowCursor& Lib "user32" (ByVal bShow As Long)
    Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal parentHandle As IntPtr, ByVal childAfter As IntPtr, ByVal className As String, ByVal windowTitle As String) As IntPtr
    Declare Function ShowWindow Lib "user32" (ByVal hwnd As IntPtr, ByVal nCmdShow As Integer) As Integer

    Private Const SW_HIDE As Integer = 0
    Private Const SW_SHOW As Integer = 5

#Region " Structures "
    Public Structure BitCheck
        Dim p_label As DBA.Library.DBA_Label
        Dim p_bit_name As String
    End Structure
#End Region

#End Region

#Region " Sub Main "
    Public Sub main()
        If Check_SQL_Server_Status() Then
            ' ---------------------
            ' * Remove MousePointer
            ' ---------------------
            ShowCursor(False)

            ' ----------------
            ' * Remove Taskbar
            ' ----------------
            SetTaskbarVisibility(False)

            ' ========================
            ' * Set Xceed Licence Keys
            ' ========================
            Xceed.Editors.Licenser.LicenseKey = "EDN25-L14KB-4TX1D-CNAA"
            Xceed.Grid.Licenser.LicenseKey = "GRD38-Y14YB-ZKXWP-NNAA"
            Xceed.Zip.Licenser.LicenseKey = "SFN37-G141C-HANTY-Y8MA"

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

            ' -----------------------------------------------------------------
            ' * Check for a previous instance of the program is already running
            ' -----------------------------------------------------------------
            g_framework.update_url(g_service_url)

            ' -------------
            ' * Set g_forms
            ' -------------
            g_framework.g_forms = g_forms

            ' ---------------------
            ' * Get Master Password
            ' ---------------------
            g_master_password = GET_ADMINPASSWORD()

            ' ----------------------
            ' * Get Program Settings
            ' ----------------------
            g_CUSMain = New CUSNET.CUSMain(1)
            Call get_settings()

            ' --------------------------------------------------------
            ' * Build the machines and start the temperature if needed
            ' --------------------------------------------------------
            Call Build_Machines()

            ' ------------------
            ' * Cleanup Run Data
            ' ------------------
            Call cleanup_run_data()

            ' Load Back Drop
            g_mdi_form = New backdrop
            g_mdi_form.ShowDialog()
        Else
            Call message_box("Problem with SQL Server; please contact CustomUltrasonics.", 1)
            End
        End If
    End Sub
#End Region

#Region " Message Box Functions "
    Public Function message_box(ByVal p_msg As String, ByVal p_mode As Integer, Optional ByVal p_passed_title As String = "") As Integer
        Dim p_title As String
        Dim p_ans As Integer

        If p_passed_title = "" Then
            p_title = "Please be advised..."
        Else
            p_title = p_passed_title
        End If

        Select Case p_mode
            Case 0 ' Invalid login
                MsgBox(p_msg, MsgBoxStyle.OkOnly, "USER/PASSWORD NOT VALID")

            Case 1 ' Critical
                MsgBox(p_msg, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical Or MsgBoxStyle.DefaultButton2, p_title)

            Case 2 ' Yes/No Question Asked - Default No
                p_ans = MsgBox(p_msg, MsgBoxStyle.YesNo Or MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton2, p_title)

            Case 3 ' Yes/No/Cancel Question Asked
                p_ans = MsgBox(p_msg, MsgBoxStyle.YesNoCancel Or MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton2, p_title)

            Case 4
                p_ans = MsgBox(p_msg, MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, p_title)

            Case 5 ' Yes/No Question Asked - Default Yes
                p_ans = MsgBox(p_msg, MsgBoxStyle.YesNo Or MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton1, p_title)
        End Select

        Return p_ans
    End Function
#End Region

#Region " Build Machines "
    Public Sub Build_Machines()
        ' =====================================================
        ' * Add the machines, set demo mode, set England flag
        ' * Handle the temperature monitoring of the reservoir.
        ' =====================================================
        For p_x As Integer = 1 To g_max_bays
            g_CUSMain.AddMachine("Bay " & p_x, p_x + 1, p_x, g_demo_mode_flag, g_england_flag)
        Next

        ' -----------------------
        ' * Check Temp Monitoring
        ' -----------------------
        Call Check_Machines_Temp_Monitoring()
    End Sub
#End Region

#Region " Handle Reservoir Temperature "
    Public Sub Check_Machines_Temp_Monitoring()
        Dim p_temp_count As Integer

        ' ---------------------------
        ' * Set Demo Mode of Machines
        ' ---------------------------
        For p_x As Integer = 1 To g_bay_count
            p_temp_count += HandleResTemp(p_x - 1, p_x)
        Next

        ' ---------------------
        ' * Set Temp Monitoring
        ' ---------------------
        If p_temp_count = 0 Then
            g_CUSMain.Stop_Temp_Monitor()
        Else
            g_CUSMain.Start_Temp_Monitor()
        End If
    End Sub

    Private Function HandleResTemp(ByVal p_machineIndex As Integer, ByVal p_bay_num As Integer) As Integer
        Dim p_sql As String
        Dim p_dataset As DataSet
        Dim p_db_row As DataRow

        ' ----------------------------------------------------
        ' * Get Min/Max Temp Settings for Bay Profile/Defaults
        ' ----------------------------------------------------
        p_sql = "SELECT B1.profile_id, P1.heat_pad_max, P1.heat_pad_min " & _
                "FROM bay_settings B1 " & _
                "INNER JOIN profile_maint P1 ON P1.profile_id = B1.profile_id " & _
                "WHERE B1.heating = 1 AND B1.bay_number = '" & p_bay_num & _
                "' ORDER BY B1.bay_number; "

        p_sql &= "SELECT var_name, default_value, override " & _
                 "FROM minimum_overrides " & _
                 "Where var_name = 'min_temperature'; "

        p_sql &= "SELECT var_name, default_value, override " & _
                 "FROM minimum_overrides " & _
                 "Where var_name = 'max_temperature'; "

        p_dataset = g_framework.Get_Data(p_sql)

        If p_dataset.Tables(0).Rows.Count > 0 Then
            ' ---------------------------------------
            ' * Set Machine Defaults for Min/Max Heat
            ' ---------------------------------------
            p_db_row = p_dataset.Tables(1).Rows(0)
            g_CUSMain.Machines(p_machineIndex).SystemOverrides.min_temperature = IIf(Trim(p_db_row("override").ToString) = "", p_db_row("default_value"), p_db_row("override"))

            p_db_row = p_dataset.Tables(2).Rows(0)
            g_CUSMain.Machines(p_machineIndex).SystemOverrides.max_temperature = IIf(Trim(p_db_row("override").ToString) = "", p_db_row("default_value"), p_db_row("override"))

            ' ----------------------------------
            ' * Reset with any Profile overrides
            ' ----------------------------------
            p_db_row = p_dataset.Tables(0).Rows(0)

            With g_CUSMain.Machines(p_machineIndex).SystemOverrides
                If p_db_row.Item("heat_pad_max").ToString <> "" Then .max_temperature = p_db_row.Item("heat_pad_max")
                If p_db_row.Item("heat_pad_min").ToString <> "" Then .min_temperature = p_db_row.Item("heat_pad_min")
            End With

            g_CUSMain.Machines(p_machineIndex).MonitorResTemperature = True
            Return 1
        Else
            'Don't monitor
            g_CUSMain.Machines(p_machineIndex).MonitorResTemperature = False
            Return 0
        End If

        ' Dispose of Dataset
        p_dataset.Dispose()
    End Function
#End Region

#Region " Cleanup Run Data "
    Public Sub cleanup_run_data()
        Dim p_sql As String = ""

        ' -------------------------
        ' * Remove Demo Header/Data
        ' -------------------------
        If g_shutdown Then
            p_sql &= "DELETE FROM run_info_detail " & _
                     "Where run_header_id In (Select run_header_id FROM run_info_header Where demo_mode = 1);"
        Else
            p_sql &= "DELETE FROM run_info_detail " & _
                     "Where run_header_id Not In (Select run_header_id FROM run_info_header Where demo_mode = 0);"
        End If
        p_sql &= "DELETE FROM run_info_header Where demo_mode = 1;"

        ' ---------------------
        ' * Clear Pre-run Table
        ' ---------------------
        p_sql &= "DELETE FROM pre_run_info;"

        ' ---------------------------------------
        ' * Mark Non-Completed Processes As Error
        ' ---------------------------------------
        p_sql &= "Update run_info_header " & _
                 "Set error = 'Unknown Abort' " & _
                 "Where error Is Null And end_time Is Null;"

        ' Execute Queries
        Call g_framework.Execute_Query(p_sql)
    End Sub
#End Region

#Region " Get Program Settings "
    Public Sub get_settings()
        Dim p_sql As String
        Dim p_dataset As DataSet
        Dim p_mode As Boolean

        ' ==============
        ' * Get Settings
        ' ==============
        p_sql = "Select num_of_systems, demo_mode, num_of_instruments, " & _
                "organization, ss_disable, england_settings, hide_F7, " & _
                "disinfect_lot_1, disinfect_lot_2, disinfect_lot_3, disinfect_lot_4, " & _
                "disinfect_override_1, disinfect_override_2, disinfect_override_3, disinfect_override_4, " & _
                "lub_override_1, lub_override_2, lub_override_3, lub_override_4, " & _
                "override_patient_entry, enable_file_output, file_output_path " & _
                "From settings_maint"
        p_dataset = g_framework.Get_Data(p_sql)

        If p_dataset.Tables(0).Rows.Count = 0 Then
            ' Set Default Name
            g_organization = "System for Hospitals"

            ' Default of 1
            g_bay_count = 1

            ' Default of 2
            g_max_instrument = 2

            ' Set Demo Mode Off
            g_demo_mode = ""
            p_mode = False

            ' Set Screen Saver Disabled
            g_ss_disabled_flag = False

            ' Set England Machine Flag
            g_england_flag = False

            ' Set Hide F7
            g_hide_F7_flag = False

            ' Set Disinfect Lot #
            g_disinfect_lot1 = "Init 1"
            g_disinfect_lot2 = "Init 2"
            g_disinfect_lot3 = "Init 3"
            g_disinfect_lot4 = "Init 4"

            ' Set Override Patient Entry Flag
            g_override_patient_entry_flag = False

            ' Set File Output Info
            g_enable_file_output_flag = False
            g_file_output_path = "C:\"
        Else
            ' Get Organization name
            g_organization = p_dataset.Tables(0).Rows(0).Item("organization").ToString

            ' Get Systems Count
            g_bay_count = p_dataset.Tables(0).Rows(0).Item("num_of_systems")

            ' Get Instrument Max
            g_max_instrument = p_dataset.Tables(0).Rows(0).Item("num_of_instruments")

            ' Get Screen Saver Disabled
            g_ss_disabled_flag = p_dataset.Tables(0).Rows(0).Item("ss_disable")

            ' Get England Machine Flag
            g_england_flag = p_dataset.Tables(0).Rows(0).Item("england_settings")

            ' Set Hide F7
            g_hide_F7_flag = p_dataset.Tables(0).Rows(0).Item("hide_F7")

            ' Get Disinfect Lot #
            g_disinfect_lot1 = p_dataset.Tables(0).Rows(0).Item("disinfect_lot_1")
            g_disinfect_lot2 = p_dataset.Tables(0).Rows(0).Item("disinfect_lot_2")
            g_disinfect_lot3 = p_dataset.Tables(0).Rows(0).Item("disinfect_lot_3")
            g_disinfect_lot4 = p_dataset.Tables(0).Rows(0).Item("disinfect_lot_4")

            ' Set Override Patient Entry Flag
            g_override_patient_entry_flag = p_dataset.Tables(0).Rows(0).Item("override_patient_entry")

            ' Set File Output Info
            g_enable_file_output_flag = p_dataset.Tables(0).Rows(0).Item("enable_file_output")
            g_file_output_path = p_dataset.Tables(0).Rows(0).Item("file_output_path").ToString

            ' Get Demo Mode
            If p_dataset.Tables(0).Rows(0).Item("demo_mode") Then
                g_demo_mode = "(Demo Mode)"
                p_mode = True
            Else
                g_demo_mode = ""
                p_mode = False
            End If

            ' Get Disinfection Overrides Values
            g_disinfect_overrides(0) = p_dataset.Tables(0).Rows(0).Item("disinfect_override_1")
            g_disinfect_overrides(1) = p_dataset.Tables(0).Rows(0).Item("disinfect_override_2")
            g_disinfect_overrides(2) = p_dataset.Tables(0).Rows(0).Item("disinfect_override_3")
            g_disinfect_overrides(3) = p_dataset.Tables(0).Rows(0).Item("disinfect_override_4")

            ' Get Lubrication Overrides Values
            g_lubrication_overrides(0) = p_dataset.Tables(0).Rows(0).Item("lub_override_1")
            g_lubrication_overrides(1) = p_dataset.Tables(0).Rows(0).Item("lub_override_2")
            g_lubrication_overrides(2) = p_dataset.Tables(0).Rows(0).Item("lub_override_3")
            g_lubrication_overrides(3) = p_dataset.Tables(0).Rows(0).Item("lub_override_4")
        End If

        ' Dispose of Dataset
        p_dataset.Dispose()

        ' ---------------------------
        ' * Set Demo Mode of Machines
        ' ---------------------------
        g_demo_mode_flag = p_mode

        ' Get Active Bay Count
        g_CUSMain.Active_Bays = g_bay_count
    End Sub
#End Region

#Region " Get Bay Count "
    Public Sub get_bay_count()
        Dim p_sql As String
        Dim p_dataset As DataSet

        p_sql = "Select num_of_systems " & _
                "From settings_maint"
        p_dataset = g_framework.Get_Data(p_sql)

        If p_dataset.Tables(0).Rows.Count > 0 Then
            g_bay_count = p_dataset.Tables(0).Rows(0).Item(0)
        Else
            ' Default of 1
            g_bay_count = 1
        End If

        ' Get Active Bay Count
        g_CUSMain.Active_Bays = g_bay_count

        ' Dispose of Dataset
        p_dataset.Dispose()
    End Sub
#End Region

#Region " Get Demo Mode "
    Public Sub get_demo_mode()
        Dim p_sql As String
        Dim p_dataset As DataSet
        Dim p_mode As Boolean

        p_sql = "Select demo_mode From settings_maint"
        p_dataset = g_framework.Get_Data(p_sql)

        If p_dataset.Tables(0).Rows.Count > 0 Then
            If p_dataset.Tables(0).Rows(0).Item(0) Then
                g_demo_mode = "(Demo Mode)"
                p_mode = True
            Else
                g_demo_mode = ""
                p_mode = False
            End If
        Else
            g_demo_mode = ""
            p_mode = False
        End If

        ' Dispose of Dataset
        p_dataset.Dispose()

        ' ---------------------------
        ' * Set Demo Mode of Machines
        ' ---------------------------
        g_demo_mode_flag = p_mode
        For p_x As Integer = 0 To g_bay_count - 1
            g_CUSMain.Machines(p_x).DemoMode = p_mode
        Next
    End Sub
#End Region

#Region " Get Max Instruments "
    Public Sub get_max_instruments()
        Dim p_sql As String
        Dim p_dataset As DataSet

        p_sql = "Select num_of_instruments " & _
                "From settings_maint"
        p_dataset = g_framework.Get_Data(p_sql)

        If p_dataset.Tables(0).Rows.Count > 0 Then
            g_max_instrument = p_dataset.Tables(0).Rows(0).Item(0)
        Else
            ' Default of 2
            g_max_instrument = 2
        End If

        ' Dispose of Dataset
        p_dataset.Dispose()
    End Sub
#End Region

#Region " Get MDI Caption "
    Public Sub get_mdi_caption()
        ' -------------
        ' * Get Version
        ' -------------
        Dim p_vertemp As String
        p_vertemp = RTrim(LTrim(Str(System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMajorPart))) & _
                            "." & RTrim(LTrim(Str(System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMinorPart))) & _
                            "." & RTrim(LTrim(Str(System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileBuildPart)))

        g_mdi_form.Text = "Custom Ultrasonics Inc.  © Copyright 1991-" & g_framework.Get_Server_Date.Year & _
                " - Version " & p_vertemp & "  " & g_demo_mode
    End Sub
#End Region

#Region " Get Organization Name "
    Public Sub get_organization()
        Dim p_sql As String
        Dim p_dataset As DataSet

        p_sql = "SELECT organization FROM settings_maint"
        p_dataset = g_framework.Get_Data(p_sql)

        If p_dataset.Tables(0).Rows.Count > 0 Then
            g_organization = p_dataset.Tables(0).Rows(0).Item(0).ToString
        Else
            g_organization = "System for Hospitals"
        End If

        ' Dispose of Dataset
        p_dataset.Dispose()
    End Sub
#End Region

#Region " Get Pinout "
    Public Function Get_Pinout(ByVal pinout As String) As CUSNET.PCBStructs.SYSTEM_ID_DEF
        Select Case UCase(pinout)
            Case "S80"
                Return CUSNET.PCBStructs.SYSTEM_ID_DEF.S80
            Case "S81"
                Return CUSNET.PCBStructs.SYSTEM_ID_DEF.S81
            Case "S81P"
                Return CUSNET.PCBStructs.SYSTEM_ID_DEF.S81P
            Case "S81X"
                Return CUSNET.PCBStructs.SYSTEM_ID_DEF.S81X
            Case "S81Y"
                Return CUSNET.PCBStructs.SYSTEM_ID_DEF.S81Y
            Case "S81Z"
                Return CUSNET.PCBStructs.SYSTEM_ID_DEF.S81Z
            Case "S82"
                Return CUSNET.PCBStructs.SYSTEM_ID_DEF.S82
            Case "S83"
                Return CUSNET.PCBStructs.SYSTEM_ID_DEF.S83
            Case "S83A"
                Return CUSNET.PCBStructs.SYSTEM_ID_DEF.S83A
            Case "S83D"
                Return CUSNET.PCBStructs.SYSTEM_ID_DEF.S83D
            Case "S83DT"
                Return CUSNET.PCBStructs.SYSTEM_ID_DEF.S83DT
            Case "S83R"
                Return CUSNET.PCBStructs.SYSTEM_ID_DEF.S83R
            Case "S83S"
                Return CUSNET.PCBStructs.SYSTEM_ID_DEF.S83S
            Case Else
                Return Nothing
        End Select
    End Function
#End Region

#Region " Get Process Data "
    Public Function get_process_data(ByVal p_id As String, ByVal p_bay_number As Integer, _
        ByVal p_mode As Boolean, ByVal p_type As String, _
        ByRef p_ticket_count As Integer) As String

        Dim p_sql As String
        Dim p_sql2 As String
        Dim p_dataset As DataSet
        Dim p_db_row As DataRow
        Dim p_db_row2 As DataRow

        Dim p_header As String
        Dim p_cycle_info As String = ""
        Dim p_patient_info As String = ""
        Dim p_prev_id As String

        Dim p_results As String = ""
        Dim p_err As String
        Dim p_notes As String = ""

        ' =====================
        ' * Get Process Details
        ' =====================
        p_sql = "Select a.bay_number, button_text, start_time, end_time, error, title, notes, " & _
                "detergent, liquid_sterilant, lub_secs, final_disinfect_temp, disinfect_lot, process_num, " & _
                "Case When U1.employee_id Is Null Then U2.employee_id Else U1.employee_id End As employee_id, " & _
                "Case When U3.employee_id Is Null Then U4.employee_id Else U3.employee_id End As unload_id " & _
                "From run_info_header a " & _
                "INNER JOIN bay_settings b On b.bay_number = a.bay_number " & _
                "LEFT JOIN Users U1 On U1.user_id = a.run_user_id " & _
                "LEFT JOIN Users_Deleted U2 On U2.user_id = a.run_user_id " & _
                "LEFT JOIN Users U3 On U3.user_id = a.unload_user_id " & _
                "LEFT JOIN Users_Deleted U4 On U4.user_id = a.unload_user_id " & _
                "Where run_header_id = '" & p_id & "';"

        p_sql2 = "Select T1.patient_id, code, P1.last_name + ', ' + P1.first_name + Case When IsNull(P1.middle_initial, '') <> '' Then ' ' + P1.middle_initial Else '' End As Patient, " & _
                 "Case When PH1.prefix = '' Then '' Else PH1.prefix + ' ' End + " & _
                 "PH1.first_name + ' ' + Case When PH1.middle_initial = '' Then '' Else PH1.middle_initial + ' ' End " & _
                 "+ PH1.last_name + ' ' + PH1.suffix As Physician, Instrument, P1.last_name, P1.first_name, P1.middle_initial "

        If p_mode Then
            p_sql &= p_sql2 & "FROM pre_run_info T1 " & _
                     "INNER JOIN instrument_maint I1 On I1.instrument_id = T1.instrument_id " & _
                     "LEFT JOIN patient_maint P1 On P1.patient_id = T1.patient_id " & _
                     "LEFT JOIN physician_maint PH1 On PH1.physician_id = P1.physician_id " & _
                     "Where bay_number = '" & p_bay_number & _
                     "' Order By P1.last_name, P1.first_name, P1.middle_initial, Instrument;"

        Else
            p_sql &= "Select Null As patient_id, '' As code, '' As Patient, " & _
                     "'' As Physician, Instrument, '' As last_name, '' As first_name, '' As middle_initial " & _
                     "FROM run_info_data T1 " & _
                     "INNER JOIN instrument_maint I1 On I1.instrument_id = T1.instrument_id " & _
                     "Where run_header_id = '" & p_id & "' And patient_id Is Null " & _
                     "UNION " & _
                     p_sql2 & "FROM run_info_data T1 " & _
                     "INNER JOIN instrument_maint I1 On I1.instrument_id = T1.instrument_id " & _
                     "INNER JOIN patient_maint P1 On P1.patient_id = T1.patient_id " & _
                     "INNER JOIN physician_maint PH1 On PH1.physician_id = P1.physician_id " & _
                     "Where run_header_id = '" & p_id & _
                     "' UNION " & _
                     p_sql2 & "FROM run_info_data T1 " & _
                     "INNER JOIN instrument_maint I1 On I1.instrument_id = T1.instrument_id " & _
                     "INNER JOIN processed_patients P1 On P1.patient_id = T1.patient_id " & _
                     "INNER JOIN physician_maint PH1 On PH1.physician_id = P1.physician_id " & _
                     "Where run_header_id = '" & p_id & _
                     "' Order By last_name, first_name, middle_initial, Instrument;"
        End If

        p_sql &= "Select cycle_name, secs " & _
                 "From run_info_detail " & _
                 "Where run_header_id = '" & p_id & _
                 "' Order by run_order;"

        p_dataset = g_framework.Get_Data(p_sql)

        ' =================
        ' * Get Header Info
        ' =================
        p_header = vbCrLf & g_organization & vbCrLf & vbCrLf

        p_db_row = p_dataset.Tables(0).Rows(0)
        p_header &= p_db_row.Item("title").ToString & "  BAY " & p_db_row.Item("bay_number").ToString & vbCrLf & vbCrLf

        ' ------------------
        ' * Get Process Info
        ' ------------------
        p_header &= "Process: " & p_db_row.Item("button_text").ToString & vbCrLf
        p_header &= "Process#: " & p_db_row.Item("process_num").ToString & vbCrLf
        If g_england_flag Then
            p_header &= "Lot#: " & p_db_row.Item("disinfect_lot").ToString & vbCrLf
        End If
        p_header &= vbCrLf

        ' --------------
        ' * Get Run User
        ' --------------
        If p_db_row.Item("employee_id").ToString = "" Then
            p_header &= "Load: CUS"
        Else
            Dim p_dataset2 As DataSet
            p_sql = "Select first_name + ' ' + Case When middle_initial = '' Then '' Else middle_initial + ' ' End " & _
                    "+ last_name As [User] " & _
                    "FROM Employee " & _
                    "Where employee_id = '" & p_db_row.Item("employee_id").ToString & _
                    "' UNION " & _
                    "Select first_name + ' ' + Case When middle_initial = '' Then '' Else middle_initial + ' ' End " & _
                    "+ last_name As [User] " & _
                    "FROM Employees_Deleted " & _
                    "Where employee_id = '" & p_db_row.Item("employee_id").ToString & "'"
            p_dataset2 = g_framework.Get_Data(p_sql)

            p_header &= "Load: " & p_dataset2.Tables(0).Rows(0).Item(0).ToString

            p_dataset2.Dispose()
        End If
        p_header &= vbCrLf

        ' --------------------
        ' * Get Process Timing
        ' --------------------
        p_header &= "Started:   " & Format(p_db_row.Item("start_time"), "ddd MMM d yyyy h:mm:ss tt") & vbCrLf

        If IsDBNull(p_db_row.Item("end_time")) Then
            p_header &= "Completed: " & vbCrLf
            p_header &= "Duration: " & vbCrLf
        Else
            p_header &= "Completed: " & Format(p_db_row.Item("end_time"), "ddd MMM d yyyy h:mm:ss tt") & vbCrLf

            ' Get Duration
            p_header &= "Duration: "

            Dim p_seconds As Long
            Dim p_int As Long
            p_seconds = DateDiff(DateInterval.Second, p_db_row.Item("start_time"), p_db_row.Item("end_time"))

            ' Get Hours
            If p_seconds >= 3600 Then
                p_int = Fix(p_seconds / 3600)
                p_header &= p_int & IIf(p_int > 1, " hrs ", " hr ")
                p_seconds = p_seconds - (p_int * 3600)
            End If

            ' Get Minutes
            If p_seconds >= 60 Then
                p_int = Fix(p_seconds / 60)
                p_header &= p_int & IIf(p_int > 1, " mins ", " min ")
                p_seconds = p_seconds - (p_int * 60)
            End If

            ' Get Minutes
            If p_seconds > 0 Then
                p_header &= p_seconds & IIf(p_seconds > 1, " secs", " sec")
            End If

            p_header &= vbCrLf
        End If

        ' -----------------
        ' * Get Unload User
        ' -----------------
        If g_england_flag And (Not IsDBNull(p_db_row.Item("end_time"))) Then
            If p_db_row.Item("unload_id").ToString <> "" Then
                Dim p_dataset2 As DataSet
                p_sql = "Select first_name + ' ' + Case When middle_initial = '' Then '' Else middle_initial + ' ' End " & _
                        "+ last_name As [User] " & _
                        "FROM Employee " & _
                        "Where employee_id = '" & p_db_row.Item("unload_id").ToString & _
                        "' UNION " & _
                        "Select first_name + ' ' + Case When middle_initial = '' Then '' Else middle_initial + ' ' End " & _
                        "+ last_name As [User] " & _
                        "FROM Employees_Deleted " & _
                        "Where employee_id = '" & p_db_row.Item("unload_id").ToString & "'"
                p_dataset2 = g_framework.Get_Data(p_sql)

                p_header &= "Unload: " & p_dataset2.Tables(0).Rows(0).Item(0).ToString & vbCrLf

                p_dataset2.Dispose()
            End If
        End If

        ' -----------------------
        ' * Add Error Information
        ' -----------------------
        If Not IsDBNull(p_db_row.Item("error")) Then
            If IsDBNull(p_db_row.Item("end_time")) Then
                p_err = vbCrLf & "Error:  " & p_db_row.Item("error").ToString
            Else
                p_err = p_db_row.Item("error").replace(Chr(10), "").replace(Chr(13), "")
                p_err = vbCrLf & p_err.Replace(" Error:", vbCrLf + "Error:")
            End If

            p_header &= p_err & vbCrLf
        End If

        ' -----------
        ' * Add Notes
        ' -----------
        If Not IsDBNull(p_db_row.Item("notes")) Then
            p_notes = p_db_row.Item("notes").replace(Chr(10), " ").replace(Chr(13), "")
            p_notes = vbCrLf & "Notes:  " & p_notes & vbCrLf
        End If

        ' ----------------
        ' * Get Run Cycles
        ' ----------------
        If p_dataset.Tables(2).Rows.Count > 0 Then
            p_cycle_info = vbCrLf & "Description:" & vbCrLf

            p_prev_id = ""
            For p_x As Integer = 0 To p_dataset.Tables(2).Rows.Count - 1
                p_db_row2 = p_dataset.Tables(2).Rows(p_x)
                Select Case p_db_row2.Item("cycle_name").ToString
                    Case "DISINFECT"
                        If Trim(p_db_row.Item("liquid_sterilant").ToString) <> "" Then
                            p_cycle_info &= "Exposed to " & p_db_row.Item("liquid_sterilant").ToString
                        Else
                            p_cycle_info &= "Exposed to N/A"
                        End If

                        p_cycle_info &= vbCrLf & "for " & CInt(p_db_row2.Item("secs") / 60) & " mins "

                        If Trim(p_db_row.Item("final_disinfect_temp").ToString) <> "" Then
                            p_cycle_info &= "at " & p_db_row.Item("final_disinfect_temp").ToString & " C"
                        End If

                        p_cycle_info &= vbCrLf

                    Case "DRAIN"
                        p_cycle_info &= "Drain for " & p_db_row2.Item("secs") & " secs" & vbCrLf

                    Case "DRY"
                        p_cycle_info &= "Dry for " & p_db_row2.Item("secs") & " secs" & vbCrLf

                    Case "FILL"
                        p_cycle_info &= "Fill for " & p_db_row2.Item("secs") & " secs" & vbCrLf

                    Case "PRE-RINSE"
                        p_cycle_info &= "Pre-Rinse for " & p_db_row2.Item("secs") & " secs" & vbCrLf

                    Case "RINSE"
                        p_cycle_info &= "Rinse for " & p_db_row2.Item("secs") & " secs"

                        If Trim(p_db_row.Item("lub_Secs").ToString) <> "" Then
                            If UCase(p_prev_id) = "WASH" _
                                Or p_x = p_dataset.Tables(2).Rows.Count - 1 Then
                                ' Rinse After Wash / Last Rinse Of Process
                                p_cycle_info &= " with " & p_db_row.Item("lub_Secs") & " secs" & vbCrLf
                                p_cycle_info &= "of metered lubrication"
                            End If
                        End If

                        p_cycle_info &= vbCrLf

                    Case "SOAK"
                        p_cycle_info &= "Soak for " & p_db_row2.Item("secs") & " secs" & vbCrLf

                    Case "WASH"
                        p_cycle_info &= "Ultrasonics Wash for " & p_db_row2.Item("secs") & " secs" & vbCrLf
                        If Trim(p_db_row.Item("detergent").ToString) <> "" Then
                            p_cycle_info &= "with " & p_db_row.Item("detergent").ToString
                        Else
                            p_cycle_info &= "with N/A"
                        End If

                        p_cycle_info &= vbCrLf
                End Select

                ' Get Previous Cycle
                p_prev_id = p_db_row2.Item("cycle_name").ToString
            Next
        End If
        p_prev_id = ""

        ' ---------------------------------
        ' * Get Run Patient/Instrument Info
        ' ---------------------------------
        If p_dataset.Tables(1).Rows.Count > 0 Then
            Dim p_patient_count As Short
            For Each p_db_row2 In p_dataset.Tables(1).Rows
                If Not IsDBNull(p_db_row2.Item("patient_id")) Then
                    p_patient_count += 1
                End If
            Next

            If p_patient_count > 0 Then
                ' ----------------------------
                ' * Output Patient Information
                ' ----------------------------
                For Each p_db_row2 In p_dataset.Tables(1).Rows
                    If UCase(p_prev_id) <> UCase(p_db_row2.Item("patient_id").ToString) Then
                        If Trim(p_prev_id) <> "" Then
                            If UCase(p_type) = "PRINT" Then
                                ' Combine Results
                                p_results = p_header & p_patient_info & p_cycle_info & p_notes & vbCrLf
                                p_patient_info = vbCrLf & "Patient/ID/Physician/Instrument(s):"
                            End If
                        Else
                            p_patient_info = vbCrLf & "Patient/ID/Physician/Instrument(s):"
                        End If

                        p_prev_id = p_db_row2.Item("patient_id").ToString

                        p_patient_info &= vbCrLf
                        p_patient_info &= p_db_row2.Item("Patient").ToString & vbCrLf
                        If Trim(p_db_row2.Item("code").ToString) <> "" Then
                            p_patient_info &= p_db_row2.Item("code").ToString & vbCrLf
                        End If
                        p_patient_info &= p_db_row2.Item("Physician").ToString & vbCrLf
                    End If

                    ' Output Instrument
                    p_patient_info &= p_db_row2.Item("Instrument").ToString & vbCrLf
                Next
            Else
                ' -------------------------------
                ' * Output Instrument Information
                ' -------------------------------
                p_patient_info = vbCrLf & "Instrument(s):" & vbCrLf

                For Each p_db_row2 In p_dataset.Tables(1).Rows
                    p_patient_info &= p_db_row2.Item("Instrument").ToString & vbCrLf
                Next
            End If

            p_ticket_count = p_patient_count
        End If

        ' Dispose of Dataset
        p_dataset.Dispose()

        ' Combine Results
        p_results &= p_header & p_patient_info & p_cycle_info & p_notes

        ' Return Data
        get_process_data = p_results
    End Function
#End Region

#Region " Get Minimum "
    Public Function GetMinimum(ByVal varName As String) As Integer
        Dim p_Sql As String
        Dim p_dataset As DataSet
        Dim p_db_row As DataRow

        p_Sql = "SELECT * FROM minimum_overrides WHERE var_name='" & varName & "'"
        p_dataset = g_framework.Get_Data(p_Sql)

        Dim Val As String

        If p_dataset.Tables(0).Rows.Count > 0 Then
            p_db_row = p_dataset.Tables(0).Rows(0)

            If Trim(p_db_row("override").ToString) <> "" Then
                Val = p_db_row("override").ToString
            Else
                Val = p_db_row("default_value").ToString
            End If

            Return Val

        Else
            Return 0
        End If
    End Function
#End Region

#Region " Load Machine Defaults "
    Public Sub LoadMachineDefaults(ByVal index As Integer)
        Dim p_sql As String
        Dim p_dataset As DataSet
        Dim p_db_row As DataRow

        Dim p_val As Long

        p_sql = "SELECT var_name, default_value, override " & _
                "FROM minimum_overrides"
        p_dataset = g_framework.Get_Data(p_sql)

        For Each p_db_row In p_dataset.Tables(0).Rows
            p_val = IIf(Trim(p_db_row("override").ToString) = "", p_db_row("default_value"), p_db_row("override"))

            Select Case p_db_row("var_name").ToString
                'General
                Case "wash_secs"
                    g_CUSMain.Machines(index).SystemOverrides.wash_secs = p_val
                Case "rinse_secs"
                    g_CUSMain.Machines(index).SystemOverrides.rinse_secs = p_val
                Case "disinfect_secs"
                    g_CUSMain.Machines(index).SystemOverrides.disinfect_secs = (p_val * 60) 'minutes to seconds
                Case "lub_secs"
                    g_CUSMain.Machines(index).SystemOverrides.lub_secs = p_val
                Case "drain_30_secs"
                    g_CUSMain.Machines(index).SystemOverrides.drain_30_secs = p_val
                Case "drain_10_secs"
                    g_CUSMain.Machines(index).SystemOverrides.drain_10_secs = p_val
                Case "warwick_delay_secs"
                    g_CUSMain.Machines(index).SystemOverrides.warwick_delay_secs = p_val
                Case "float_delay_secs"
                    g_CUSMain.Machines(index).SystemOverrides.float_delay_secs = p_val
                Case "pressure_start_delay_secs"
                    g_CUSMain.Machines(index).SystemOverrides.pressure_start_delay_secs = p_val
                Case "pressure_error_delay_secs"
                    g_CUSMain.Machines(index).SystemOverrides.pressure_error_delay_secs = p_val
                Case "safety_delay_secs"
                    g_CUSMain.Machines(index).SystemOverrides.safety_delay_secs = p_val
                Case "float_abort_delay_secs"
                    g_CUSMain.Machines(index).SystemOverrides.float_abort_delay_secs = ((p_val * 60) * 60) 'hours to seconds
                Case "ultrasonics_delay_secs"
                    g_CUSMain.Machines(index).SystemOverrides.ultrasonics_delay_secs = p_val

                    ' Temperature
                Case "min_temperature"
                    g_CUSMain.Machines(index).SystemOverrides.min_temperature = p_val
                Case "max_temperature"
                    g_CUSMain.Machines(index).SystemOverrides.max_temperature = p_val
                Case "min_start_temperature"
                    g_CUSMain.Machines(index).SystemOverrides.min_start_temperature = p_val
                Case "max_abort_temperature"
                    g_CUSMain.Machines(index).SystemOverrides.max_abort_temperature = p_val

                    ' 82
                Case "dis_ultra_secs"
                    g_CUSMain.Machines(index).SystemOverrides.dis_ultra_secs = p_val

                    ' 81
                Case "spray_rinse_wait_secs"
                    g_CUSMain.Machines(index).SystemOverrides.spray_rinse_wait_secs = p_val
                Case "spray_rinse_secs"
                    g_CUSMain.Machines(index).SystemOverrides.spray_rinse_secs = p_val
                Case "detergent_81_secs"
                    g_CUSMain.Machines(index).SystemOverrides.detergent_81_secs = p_val
                Case "enzyme_secs"
                    g_CUSMain.Machines(index).SystemOverrides.enzyme_secs = p_val
                Case "soak_secs"
                    g_CUSMain.Machines(index).SystemOverrides.soak_secs = p_val
                Case "prerinse_secs"
                    g_CUSMain.Machines(index).SystemOverrides.prerinse_secs = p_val
                Case "reservoir_fill_secs"
                    g_CUSMain.Machines(index).SystemOverrides.reservoir_fill_secs = p_val

                    ' 83
                Case "detergent_83_secs"
                    g_CUSMain.Machines(index).SystemOverrides.detergent_83_secs = p_val
                Case "dry_heat_secs"
                    g_CUSMain.Machines(index).SystemOverrides.dry_heat_secs = p_val
                Case "dry_cool_secs"
                    g_CUSMain.Machines(index).SystemOverrides.dry_cool_secs = p_val

                    ' Delays
                Case "fill_flow_secs"
                    g_CUSMain.Machines(index).SystemOverrides.fill_flow_secs = p_val
                Case "fill_float_secs"
                    g_CUSMain.Machines(index).SystemOverrides.fill_float_secs = p_val
                Case "drain_float_secs"
                    g_CUSMain.Machines(index).SystemOverrides.drain_float_secs = p_val
                Case "drain_flow_secs"
                    g_CUSMain.Machines(index).SystemOverrides.drain_flow_secs = p_val

                    ' England Aborts
                Case "fill_min_abort_secs"
                    g_CUSMain.Machines(index).SystemOverrides.fill_min_abort_secs = p_val
                Case "fill_max_abort_secs"
                    g_CUSMain.Machines(index).SystemOverrides.fill_max_abort_secs = (p_val * 60) 'minutes to seconds
                Case "drain_min_abort_secs"
                    g_CUSMain.Machines(index).SystemOverrides.drain_min_abort_secs = p_val
                Case "drain_max_abort_secs"
                    g_CUSMain.Machines(index).SystemOverrides.drain_max_abort_secs = (p_val * 60) 'minutes to seconds
            End Select
        Next
    End Sub
#End Region

#Region " Set Monitoring "
    Public Sub set_monitoring(ByVal p_mode As Boolean)
        ' -----------------------------------
        ' * Set Input Monitoring For Machines
        ' -----------------------------------
        For p_x As Integer = 0 To g_bay_count - 1
            If p_mode Then
                g_CUSMain.Machines(p_x).start_input_monitor()
            Else
                g_CUSMain.Machines(p_x).stop_input_monitor()
            End If
        Next
    End Sub
#End Region

#Region " Size MDI Child "
    Public Sub size_screen(ByRef p_form As DBA_Framework.DBA_Foundation_Class)
        p_form.Left = 0
        p_form.Top = 0

        p_form.Height = g_mdi_form.Height - 42
        p_form.Width = g_mdi_form.Width - 16
    End Sub
#End Region

#Region " Get Master Password "
    Public Function GET_ADMINPASSWORD() As String
        Dim p_day As String
        Dim p_month As String
        Dim p_year As String
        Dim p_day_name As String
        Dim p_pass_word As String

        Dim p_tmp_num As Double
        Dim p_tmp_str As String
        Dim p_tmp_str2 As String = ""
        Dim p_chr As String
        Dim p_x As Integer

        Dim p_date As DateTime

        ' Get Server Date
        p_date = g_framework.Get_Server_Date

        ' Get Parts of Date
        p_day = p_date.DayOfYear
        p_month = p_date.Month
        p_year = p_date.Year
        p_day_name = p_date.DayOfWeek.ToString

        ' First Letter
        p_tmp_num = Val(p_date.Day) + Val(p_month)
        p_tmp_num += 65

        p_pass_word = Chr(p_tmp_num)

        p_tmp_num = ((Val(p_day) * 234567) / 12) * 34

        p_tmp_str = p_tmp_num.ToString

        For p_x = 1 To p_tmp_str.Length
            p_chr = Mid(p_tmp_str, p_x, 1)
            Select Case p_chr
                Case "."
                Case Else
                    p_tmp_str2 += p_chr
            End Select

            If p_tmp_str2.Length = 6 Then
                Exit For
            End If
        Next

        p_pass_word += p_tmp_str2
        p_tmp_str = ""

        Select Case p_day_name.ToUpper
            Case "SUNDAY" ' DAVID
                For p_x = 1 To 5
                    p_chr = Mid(p_pass_word, p_x, 1)
                    p_tmp_str += p_chr + Mid("DAVID", p_x, 1)
                Next
                p_tmp_str += Mid(p_pass_word, 6)
            Case "MONDAY" ' ROBIN
                For p_x = 1 To 5
                    p_chr = Mid(p_pass_word, p_x, 1)
                    p_tmp_str += p_chr + Mid("ROBIN", p_x, 1)
                Next
                p_tmp_str += Mid(p_pass_word, 6)
            Case "TUESDAY" ' RYAN
                For p_x = 1 To 4
                    p_chr = Mid(p_pass_word, p_x, 1)
                    p_tmp_str += p_chr + Mid("RYAN", p_x, 1)
                Next
                p_tmp_str += Mid(p_pass_word, 5)
            Case "WEDNESDAY" ' JOHN
                For p_x = 1 To 4
                    p_chr = Mid(p_pass_word, p_x, 1)
                    p_tmp_str += p_chr + Mid("JOHN", p_x, 1)
                Next
                p_tmp_str += Mid(p_pass_word, 5)
            Case "THURSDAY" ' KATIE
                For p_x = 1 To 5
                    p_chr = Mid(p_pass_word, p_x, 1)
                    p_tmp_str += p_chr + Mid("KATIE", p_x, 1)
                Next
                p_tmp_str += Mid(p_pass_word, 6)
            Case "FRIDAY" ' BUBBA
                For p_x = 1 To 5
                    p_chr = Mid(p_pass_word, p_x, 1)
                    p_tmp_str += p_chr + Mid("KATIE", p_x, 1)
                Next
                p_tmp_str += Mid(p_pass_word, 6)

            Case "SATURDAY" ' FRED
                For p_x = 1 To 4
                    p_chr = Mid(p_pass_word, p_x, 1)
                    p_tmp_str += p_chr + Mid("FRED", p_x, 1)
                Next
                p_tmp_str += Mid(p_pass_word, 5)
        End Select

        p_pass_word = p_tmp_str
        GET_ADMINPASSWORD = p_pass_word
    End Function
#End Region

#Region " Check Where Clause "
    Public Function Check_where(ByVal p_string As String) As String
        ' ================================================
        ' * Function Used For Building An SQL Where Clause
        ' ================================================
        If Trim(p_string) <> "" Then
            p_string = p_string & " And "
        Else
            p_string = " Where "
        End If

        Check_where = p_string
    End Function
#End Region

#Region " Not Used - For Update Only "
    Public Sub update_process_num()
        Dim p_sql As String
        Dim p_dataset As DataSet
        Dim p_db_row As DataRow
        Dim p_count As Integer = 1

        p_sql = "SELECT run_header_id, start_time " & _
                "FROM run_info_header " & _
                "WHERE IsNull(error, '') = '' " & _
                "ORDER BY start_time"
        p_dataset = g_framework.Get_Data(p_sql)

        For Each p_db_row In p_dataset.Tables(0).Rows
            p_sql = "Update run_info_header " & _
                    "Set process_num = " & p_count & _
                    " Where run_header_id = '" & p_db_row.Item("run_header_id").ToString & "'"
            g_framework.Execute_Query(p_sql)

            p_count += 1
        Next

        ' DIspose of Dataset
        p_dataset.Dispose()
    End Sub

    Public Sub update_procedure_num()
        Dim p_sql As String
        Dim p_dataset As DataSet
        Dim p_db_row As DataRow
        Dim p_count As Integer = 1

        p_sql = "SELECT run_data_id " & _
                "FROM run_info_data a " & _
                "INNER JOIN run_info_header b On b.run_header_id = a.run_header_id " & _
                "Where b.complete = 1 and b.button_text = 'WASH/DISINFECT' " & _
                "ORDER BY start_time"
        p_dataset = g_framework.Get_Data(p_sql)

        For Each p_db_row In p_dataset.Tables(0).Rows
            p_sql = "Update run_info_data " & _
                    "Set procedure_num = " & p_count & _
                    " Where run_data_id = '" & p_db_row.Item("run_data_id").ToString & "'"
            g_framework.Execute_Query(p_sql)

            p_count += 1
        Next

        ' DIspose of Dataset
        p_dataset.Dispose()
    End Sub
#End Region

#Region " Reset System Data Overrides "
    Public Sub reset_system_data_overrides()
        Call g_framework.Execute_Query("Update settings_maint " & _
                "Set disinfect_override_1 = 0, disinfect_override_2 = 0, disinfect_override_3 = 0, disinfect_override_4 = 0, " & _
                "lub_override_1 = 0, lub_override_2 = 0, lub_override_3 = 0, lub_override_4 = 0")

        ' Get Disinfection Overrides Values
        g_disinfect_overrides(0) = 0
        g_disinfect_overrides(1) = 0
        g_disinfect_overrides(2) = 0
        g_disinfect_overrides(3) = 0

        ' Get Lubrication Overrides Values
        g_lubrication_overrides(0) = 0
        g_lubrication_overrides(1) = 0
        g_lubrication_overrides(2) = 0
        g_lubrication_overrides(3) = 0
    End Sub
#End Region

#Region " Set Taskbar Visibility "
    Public Sub SetTaskbarVisibility(ByVal show As Boolean)
        Try
            ' --------------------
            ' * Get Taskbar Window
            ' --------------------
            Dim taskBarWnd As IntPtr = FindWindow("Shell_TrayWnd", Nothing)

            ' --------------------------------------------------
            ' * Get Start Button - try it the WinXP way first...
            ' --------------------------------------------------
            Dim startWnd As IntPtr = FindWindowEx(taskBarWnd, IntPtr.Zero, "Button", "Start")
            If startWnd = IntPtr.Zero Then
                ' -----------------------------------------------
                ' * ok, let's try the Vista/Windows 7 easy way...
                ' -----------------------------------------------
                startWnd = FindWindow("Button", Nothing)
            End If

            ShowWindow(taskBarWnd, If(show, SW_SHOW, SW_HIDE))
            ShowWindow(startWnd, If(show, SW_SHOW, SW_HIDE))

        Catch
        End Try
    End Sub
#End Region

#Region " Parasoft dotTest Return String "
    Public Function validate(ByVal s As String) As String
        ' Use this as Parasoft dotTest Help recommends to show validation
        Return s
    End Function
#End Region

End Module

