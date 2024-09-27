Public Class main_menu
    Inherits DBA_Framework.DBA_Foundation_Class

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal p_db_name As String)
        MyBase.New(p_db_name, g_framework.g_version, g_framework.g_user_id)

        'set the webservice url
        MyBase.update_url(g_service_url)

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        g_framework.HandleClose(Me.Name)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents pnl_main As DBA.Library.DBA_Panel
    Friend WithEvents lbl_info As DBA.Library.DBA_Label
    Friend WithEvents btn_setup As DBA.Library.DBA_Button
    Friend WithEvents btn_database As DBA.Library.DBA_Button
    Friend WithEvents btn_reports As DBA.Library.DBA_Button
    Friend WithEvents btn_cu_system As DBA.Library.DBA_Button
    Friend WithEvents lbl_shutdown As DBA.Library.DBA_Label
    Friend WithEvents lbl_logoff As DBA.Library.DBA_Label
    Friend WithEvents btn_service As DBA.Library.DBA_Button
    Friend WithEvents lbl_problem As System.Windows.Forms.Label
    Friend WithEvents lbl_night_mode As DBA.Library.DBA_Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_menu))
        Me.pnl_main = New DBA.Library.DBA_Panel
        Me.lbl_problem = New System.Windows.Forms.Label
        Me.lbl_night_mode = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_logoff = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_shutdown = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_info = New DBA.Library.DBA_Label(Me.components)
        Me.btn_database = New DBA.Library.DBA_Button(Me.components)
        Me.btn_reports = New DBA.Library.DBA_Button(Me.components)
        Me.btn_cu_system = New DBA.Library.DBA_Button(Me.components)
        Me.btn_setup = New DBA.Library.DBA_Button(Me.components)
        Me.btn_service = New DBA.Library.DBA_Button(Me.components)
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_main
        '
        Me.pnl_main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_main.Controls.Add(Me.lbl_problem)
        Me.pnl_main.Controls.Add(Me.lbl_night_mode)
        Me.pnl_main.Controls.Add(Me.lbl_logoff)
        Me.pnl_main.Controls.Add(Me.lbl_shutdown)
        Me.pnl_main.Controls.Add(Me.lbl_info)
        Me.pnl_main.Controls.Add(Me.btn_database)
        Me.pnl_main.Controls.Add(Me.btn_reports)
        Me.pnl_main.Controls.Add(Me.btn_cu_system)
        Me.pnl_main.Controls.Add(Me.btn_setup)
        Me.pnl_main.Controls.Add(Me.btn_service)
        Me.pnl_main.DataSettings.IDField = Nothing
        Me.pnl_main.DataSettings.JoinData = Nothing
        Me.pnl_main.DataSettings.LinkField = Nothing
        Me.pnl_main.DataSettings.TableName = Nothing
        Me.pnl_main.Gradient = False
        Me.pnl_main.Location = New System.Drawing.Point(0, 0)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.RecordID = Nothing
        Me.pnl_main.Saved = False
        Me.pnl_main.Size = New System.Drawing.Size(561, 440)
        Me.pnl_main.TabIndex = 0
        '
        'lbl_problem
        '
        Me.lbl_problem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_problem.BackColor = System.Drawing.Color.Red
        Me.lbl_problem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_problem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_problem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_problem.ForeColor = System.Drawing.Color.White
        Me.lbl_problem.Location = New System.Drawing.Point(15, 339)
        Me.lbl_problem.Name = "lbl_problem"
        Me.lbl_problem.Size = New System.Drawing.Size(531, 88)
        Me.lbl_problem.TabIndex = 8
        Me.lbl_problem.Text = "- PROBLEM -"
        Me.lbl_problem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl_problem.Visible = False
        '
        'lbl_night_mode
        '
        Me.lbl_night_mode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_night_mode.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_night_mode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_night_mode.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_night_mode.ForeColor = System.Drawing.Color.Black
        Me.lbl_night_mode.Image = CType(resources.GetObject("lbl_night_mode.Image"), System.Drawing.Image)
        Me.lbl_night_mode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_night_mode.Location = New System.Drawing.Point(216, 233)
        Me.lbl_night_mode.Name = "lbl_night_mode"
        Me.lbl_night_mode.Size = New System.Drawing.Size(127, 43)
        Me.lbl_night_mode.TabIndex = 7
        Me.lbl_night_mode.Text = "Backup"
        Me.lbl_night_mode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_night_mode.UseMnemonic = False
        '
        'lbl_logoff
        '
        Me.lbl_logoff.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_logoff.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_logoff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_logoff.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_logoff.ForeColor = System.Drawing.Color.Black
        Me.lbl_logoff.Image = CType(resources.GetObject("lbl_logoff.Image"), System.Drawing.Image)
        Me.lbl_logoff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_logoff.Location = New System.Drawing.Point(70, 233)
        Me.lbl_logoff.Name = "lbl_logoff"
        Me.lbl_logoff.Size = New System.Drawing.Size(127, 43)
        Me.lbl_logoff.TabIndex = 6
        Me.lbl_logoff.Text = "Log off"
        Me.lbl_logoff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_logoff.UseMnemonic = False
        '
        'lbl_shutdown
        '
        Me.lbl_shutdown.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_shutdown.BackColor = System.Drawing.Color.Red
        Me.lbl_shutdown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_shutdown.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_shutdown.ForeColor = System.Drawing.Color.White
        Me.lbl_shutdown.Image = CType(resources.GetObject("lbl_shutdown.Image"), System.Drawing.Image)
        Me.lbl_shutdown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_shutdown.Location = New System.Drawing.Point(363, 233)
        Me.lbl_shutdown.Name = "lbl_shutdown"
        Me.lbl_shutdown.Size = New System.Drawing.Size(127, 43)
        Me.lbl_shutdown.TabIndex = 5
        Me.lbl_shutdown.Text = "Shutdown"
        Me.lbl_shutdown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_shutdown.UseMnemonic = False
        '
        'lbl_info
        '
        Me.lbl_info.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_info.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_info.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info.ForeColor = System.Drawing.Color.Black
        Me.lbl_info.Location = New System.Drawing.Point(61, 293)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(443, 31)
        Me.lbl_info.TabIndex = 4
        Me.lbl_info.Text = "Use arrow/enter keys or press underlined letter to a select button."
        Me.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_info.UseMnemonic = False
        '
        'btn_database
        '
        Me.btn_database.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_database.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_database.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_database.DisplayText = "Database Entry"
        Me.btn_database.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_database.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_database.ForeColor = System.Drawing.Color.Black
        Me.btn_database.Image = CType(resources.GetObject("btn_database.Image"), System.Drawing.Image)
        Me.btn_database.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_database.Location = New System.Drawing.Point(70, 166)
        Me.btn_database.Name = "btn_database"
        Me.btn_database.Size = New System.Drawing.Size(202, 47)
        Me.btn_database.TabIndex = 1
        Me.btn_database.TabStop = False
        Me.btn_database.Text = "Database &Entry"
        Me.btn_database.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_database.UseVisualStyleBackColor = False
        Me.btn_database.Visible = False
        '
        'btn_reports
        '
        Me.btn_reports.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_reports.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_reports.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_reports.DisplayText = "Reports"
        Me.btn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_reports.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reports.ForeColor = System.Drawing.Color.Black
        Me.btn_reports.Image = CType(resources.GetObject("btn_reports.Image"), System.Drawing.Image)
        Me.btn_reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reports.Location = New System.Drawing.Point(288, 102)
        Me.btn_reports.Name = "btn_reports"
        Me.btn_reports.Size = New System.Drawing.Size(202, 47)
        Me.btn_reports.TabIndex = 3
        Me.btn_reports.TabStop = False
        Me.btn_reports.Text = "&Reports"
        Me.btn_reports.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_reports.UseVisualStyleBackColor = False
        '
        'btn_cu_system
        '
        Me.btn_cu_system.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_cu_system.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_cu_system.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_cu_system.DisplayText = "CU System"
        Me.btn_cu_system.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cu_system.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cu_system.ForeColor = System.Drawing.Color.Black
        Me.btn_cu_system.Image = CType(resources.GetObject("btn_cu_system.Image"), System.Drawing.Image)
        Me.btn_cu_system.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cu_system.Location = New System.Drawing.Point(70, 102)
        Me.btn_cu_system.Name = "btn_cu_system"
        Me.btn_cu_system.Size = New System.Drawing.Size(202, 47)
        Me.btn_cu_system.TabIndex = 2
        Me.btn_cu_system.TabStop = False
        Me.btn_cu_system.Text = "&CU System"
        Me.btn_cu_system.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cu_system.UseVisualStyleBackColor = False
        '
        'btn_setup
        '
        Me.btn_setup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_setup.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_setup.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_setup.DisplayText = "Setup"
        Me.btn_setup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_setup.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_setup.ForeColor = System.Drawing.Color.Black
        Me.btn_setup.Image = CType(resources.GetObject("btn_setup.Image"), System.Drawing.Image)
        Me.btn_setup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_setup.Location = New System.Drawing.Point(288, 166)
        Me.btn_setup.Name = "btn_setup"
        Me.btn_setup.Size = New System.Drawing.Size(202, 47)
        Me.btn_setup.TabIndex = 4
        Me.btn_setup.TabStop = False
        Me.btn_setup.Text = "Machine &Setup"
        Me.btn_setup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_setup.UseVisualStyleBackColor = False
        Me.btn_setup.Visible = False
        '
        'btn_service
        '
        Me.btn_service.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_service.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_service.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_service.DisplayText = "Database Entry"
        Me.btn_service.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_service.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_service.ForeColor = System.Drawing.Color.Black
        Me.btn_service.Image = CType(resources.GetObject("btn_service.Image"), System.Drawing.Image)
        Me.btn_service.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_service.Location = New System.Drawing.Point(288, 166)
        Me.btn_service.Name = "btn_service"
        Me.btn_service.Size = New System.Drawing.Size(202, 47)
        Me.btn_service.TabIndex = 5
        Me.btn_service.TabStop = False
        Me.btn_service.Text = "&Service Screen"
        Me.btn_service.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_service.UseVisualStyleBackColor = False
        Me.btn_service.Visible = False
        '
        'main_menu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(561, 437)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "main_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_main.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Overrides "
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Dim keyCode As Keys = CType((msg.WParam.ToInt32 And Keys.KeyCode), Keys)

        ' ----------------------------
        ' * Restart Screen Saver Timer
        ' ----------------------------
        Call restart_timer()

        ' -------------------
        ' * Process Keystokes
        ' -------------------
        Select Case keyCode
            Case Keys.F3
                If lbl_shutdown.Visible Then Call Process("CLOSE")

            Case Keys.F6
                Call Process("BACKUP")

            Case Keys.F8
                Call Process("LOGOFF")

            Case Keys.C
                Call Process("C")

            Case Keys.R
                Call Process("R")

            Case Keys.E
                If btn_database.Visible Then Call Process("E")

            Case Keys.S
                If btn_setup.Visible Then
                    Call Process("Setup")

                ElseIf btn_service.Visible Then
                    Call Process("Service")
                End If
        End Select

        Select Case keyCode
            Case Keys.F3, Keys.F4, Keys.F6, Keys.F8, Keys.F9, _
                 Keys.C, Keys.R, Keys.E, Keys.S
                Return True
        End Select
    End Function
#End Region

#Region " Button Events "
    Private Sub btn_cu_system_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cu_system.Click
        Call Process("C")
    End Sub

    Private Sub btn_reports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reports.Click
        Call Process("R")
    End Sub

    Private Sub btn_database_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_database.Click
        Call Process("E")
    End Sub

    Private Sub btn_service_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_service.Click
        Call Process("Service")
    End Sub

    Private Sub btn_setup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_setup.Click
        Call Process("Setup")
    End Sub

    Private Sub lbl_logoff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_logoff.Click
        Call Process("LOGOFF")
    End Sub

    Private Sub lbl_shutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_shutdown.Click
        Call Process("CLOSE")
    End Sub
#End Region

#Region " Form Activate "
    Private Sub Form_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        btn_cu_system.Focus()
    End Sub
#End Region

#Region " Form Load "
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call size_screen(Me)

        ' ----------------------
        ' * Check Night Problems
        ' ----------------------
        ''Call check_for_night_problems()   Removed RM - 6/28/06

        ' -------------------------------
        ' * Set Buttons For Access Rights
        ' -------------------------------
        If g_master Then
            btn_setup.Visible = True
            btn_database.Visible = True

        ElseIf g_admin Then
            btn_database.Visible = True
            btn_service.Visible = True

        Else
            Me.lbl_logoff.Top = Me.btn_cu_system.Top + 85
            Me.lbl_night_mode.Top = Me.btn_cu_system.Top + 85
            Me.lbl_shutdown.Top = Me.btn_cu_system.Top + 85
            Me.lbl_info.Top = Me.btn_cu_system.Top + 170
        End If

        If Not g_shutdown Then
            Me.lbl_shutdown.Text = "Exit"
        End If
    End Sub
#End Region

#Region " Process "
    Private Sub Process(ByVal p_type As String)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Refresh()

        Select Case UCase(p_type)
            Case "C"
                ' Load Main Run Screen
                g_framework.g_forms(1) = New run_main(g_framework.g_db_name)
                g_framework.g_forms(1).MdiParent = g_mdi_form
                g_framework.g_forms(1).Show()

                g_framework.g_forms(0).Hide()

            Case "E"
                g_framework.g_forms(1) = New data_entry_menu(g_framework.g_db_name)
                g_framework.g_forms(1).MdiParent = g_mdi_form
                g_framework.g_forms(1).Show()

                g_framework.g_forms(0).Hide()

            Case "R"
                g_framework.g_forms(1) = New report_mnu(g_framework.g_db_name)
                g_framework.g_forms(1).MdiParent = g_mdi_form
                g_framework.g_forms(1).Show()

                g_framework.g_forms(0).Hide()

            Case "SERVICE"
                g_framework.g_forms(1) = New services(g_framework.g_db_name, Me, 1)
                g_framework.g_forms(1).MdiParent = g_mdi_form
                g_framework.g_forms(1).Show()

                g_framework.g_forms(0).Hide()

            Case "SETUP"
                g_framework.g_forms(1) = New admin_setup_mnu(g_framework.g_db_name)
                g_framework.g_forms(1).MdiParent = g_mdi_form
                g_framework.g_forms(1).Show()

                g_framework.g_forms(0).Hide()

            Case "BACKUP"
                If message_box("Do you wish to start the Backup Service?", 2, "Confirm Backup Service") = vbNo Then
                    Exit Sub
                End If
                Shell("cubackup.exe")
                End

            Case "LOGOFF"
                Me.Cursor = System.Windows.Forms.Cursors.Default

                If message_box("Are you sure that you want to logoff?", 2, "Confirm Logoff") = vbNo Then
                    Exit Sub
                End If

                g_login.Show()

                g_framework.g_forms(0).Hide()

            Case "CLOSE"
                Me.Cursor = System.Windows.Forms.Cursors.Default

                If g_shutdown Then
                    If message_box("Are you sure that you want to shutdown?", 2, "Confirm Shutdown") = vbNo Then
                        Exit Sub
                    End If

                    ' ----------------------
                    ' * Confirm/Log Shutdown
                    ' ----------------------
                    Dim p_form As run_login
                    g_pass_str2 = "SHUTDOWN"

                    p_form = New run_login(g_framework.g_db_name)
                    p_form.ShowDialog()

                    ' Cancel Shutdown If Login Invalid
                    If Trim(g_pass_str2) = "" Then
                        Exit Sub
                    Else
                        ' --------------------------------
                        ' * Insert Shutdown History Record
                        ' --------------------------------
                        Dim p_sql As String
                        p_sql = "INSERT INTO shutdown_history (user_id, shutdown_time) " & _
                                "Values ('" & g_pass_str2 & "', getdate())"
                        Call g_framework.Execute_Query(p_sql)
                    End If

                    ' -------------------------
                    ' * Stop Screen Saver Timer
                    ' -------------------------
                    g_timer.AutoReset = False
                    g_timer.Enabled = False

                    ' Use these switches with the "Shutdown" command to execute various shut down options in Windows XP.

                    ' Switches:
                    '   -l  Log off profile
                    '   -s  Shut down computer
                    '   -r  Restart computer
                    '   -f  Force applications to close
                    '   -t  Set a timeout for shutdown
                    '   -m \\computer name  Shut down remote computer
                    '   -i  Show the Shutdown GUI

                    ' Example of shutdown:
                    'Shell("Shutdown -s -t 5")   ' Shuts computer down after timeout of 5

                    Shell("Shutdown -s -f -t 0")

                Else
                    ' -------------------------
                    ' * Stop Screen Saver Timer
                    ' -------------------------
                    g_timer.AutoReset = False
                    g_timer.Enabled = False
                    End

                End If
        End Select

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
#End Region

#Region " CHECK FOR NIGHT PROBLEMS "
    Private Sub check_for_night_problems()
        Dim p_sql As String
        Dim p_dataset As DataSet
        Dim p_row As DataRow

        Dim p_string As String
        Dim p_title As String

        p_string = ""

        ' ==================================
        ' * Get Max Dates For Backup History
        ' ==================================
        p_sql = "SELECT " & _
                "(Select MAX(date_event) FROM system_night) As last_night, " & _
                "(Select MAX(date_event) FROM system_night where backup_ok = 1) As backup_date, " & _
                "(Select MAX(date_event) FROM system_night where report_ok = 1) As report_date, " & _
                "(Select MAX(date_event) FROM system_night where update_ok = 1) As update_date "
        p_dataset = g_framework.Get_Data(p_sql)

        ' --------------------
        ' * Has Never Been Run
        ' --------------------
        If p_dataset.Tables(0).Rows.Count = 0 Then
            lbl_problem.Visible = False

            ' Dispose of Dataset
            p_dataset.Dispose()

            Exit Sub
        End If

        ' Get DataRow
        p_row = p_dataset.Tables(0).Rows(0)

        ' ---------------------------------
        ' * Check Again, Has Never Been Run
        ' ---------------------------------
        If IsDBNull(p_row.Item(0)) Then
            lbl_problem.Visible = False

            ' Dispose of Dataset
            p_dataset.Dispose()

            Exit Sub
        End If

        ' ---------------
        ' * Backup Status
        ' ---------------
        If Not IsDBNull(p_row.Item(1)) Then
            If p_row.Item(0) > p_row.Item(1) Then
                p_string &= "LAST BACKUP WAS " & p_row.Item(1).ToString & vbCrLf
            End If
        Else
            p_string &= "BACKUP WAS NEVER DONE" & vbCrLf
        End If

        ' ---------------
        ' * Report Status
        ' ---------------
        If Not IsDBNull(p_row.Item(2)) Then
            If p_row.Item(0) > p_row.Item(2) Then
                p_string &= "LAST REPORT CREATION WAS " & p_row.Item(3).ToString & vbCrLf
            End If
        Else
            p_string &= "REPORTS WERE NEVER DONE" & vbCrLf
        End If

        ' Update Status
        'If Not IsDBNull(p_row.Item(3)) Then
        '    If p_row.Item(0) > p_row.Item(3) Then
        '        p_string &= "LAST UPDATE WAS " & p_row.Item(2).ToString & vbCrLf
        '    End If
        'Else
        '    p_string &= "UPDATE WAS NEVER DONE" & vbCrLf
        'End If

        If p_string.Trim.Length > 0 Then
            p_title = "- PROBLEM -" & vbCrLf
            p_title &= "- THESE FUNCTIONS ARE NOT CURRENT -" & vbCrLf

            lbl_problem.Text = main.validate(p_title & p_string)
            lbl_problem.Visible = True
        End If

        ' Dispose of Dataset
        p_dataset.Dispose()
    End Sub

#End Region

End Class
