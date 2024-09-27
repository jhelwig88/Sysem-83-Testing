Public Class run_main
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
        g_framework.handle_windows()
    End Sub

    Protected Overrides Sub OnActivated(ByVal e As System.EventArgs)
        g_framework.handle_windows(Me.Text)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents pnl_main As DBA.Library.DBA_Panel
    Friend WithEvents btn_close As DBA.Library.DBA_Button
    Friend WithEvents DbA_Label10 As DBA.Library.DBA_Label
    Friend WithEvents lbl_main As DBA.Library.DBA_Label
    Friend WithEvents pnl_guidelines As DBA.Library.DBA_Panel
    Friend WithEvents btn_continue As DBA.Library.DBA_Button
    Friend WithEvents btn_back As DBA.Library.DBA_Button
    Friend WithEvents lbl_title As DBA.Library.DBA_Label
    Friend WithEvents lbl_guidelines As DBA.Library.DBA_Label
    Friend WithEvents ct_box As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(run_main))
        Me.pnl_main = New DBA.Library.DBA_Panel
        Me.ct_box = New System.Windows.Forms.PictureBox
        Me.DbA_Label10 = New DBA.Library.DBA_Label(Me.components)
        Me.btn_close = New DBA.Library.DBA_Button(Me.components)
        Me.lbl_main = New DBA.Library.DBA_Label(Me.components)
        Me.pnl_guidelines = New DBA.Library.DBA_Panel
        Me.lbl_guidelines = New DBA.Library.DBA_Label(Me.components)
        Me.btn_continue = New DBA.Library.DBA_Button(Me.components)
        Me.btn_back = New DBA.Library.DBA_Button(Me.components)
        Me.lbl_title = New DBA.Library.DBA_Label(Me.components)
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_main.SuspendLayout()
        CType(Me.ct_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_guidelines.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_main
        '
        Me.pnl_main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_main.Controls.Add(Me.ct_box)
        Me.pnl_main.Controls.Add(Me.DbA_Label10)
        Me.pnl_main.Controls.Add(Me.btn_close)
        Me.pnl_main.Controls.Add(Me.lbl_main)
        Me.pnl_main.DataSettings.IDField = Nothing
        Me.pnl_main.DataSettings.JoinData = Nothing
        Me.pnl_main.DataSettings.LinkField = Nothing
        Me.pnl_main.DataSettings.TableName = Nothing
        Me.pnl_main.Gradient = False
        Me.pnl_main.Location = New System.Drawing.Point(0, 0)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.RecordID = Nothing
        Me.pnl_main.Saved = False
        Me.pnl_main.Size = New System.Drawing.Size(769, 513)
        Me.pnl_main.TabIndex = 0
        '
        'ct_box
        '
        Me.ct_box.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ct_box.BackColor = System.Drawing.Color.White
        Me.ct_box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ct_box.Image = CType(resources.GetObject("ct_box.Image"), System.Drawing.Image)
        Me.ct_box.Location = New System.Drawing.Point(445, 300)
        Me.ct_box.Name = "ct_box"
        Me.ct_box.Size = New System.Drawing.Size(257, 58)
        Me.ct_box.TabIndex = 30
        Me.ct_box.TabStop = False
        Me.ct_box.Visible = False
        '
        'DbA_Label10
        '
        Me.DbA_Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DbA_Label10.BackColor = System.Drawing.Color.PapayaWhip
        Me.DbA_Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DbA_Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DbA_Label10.ForeColor = System.Drawing.Color.Black
        Me.DbA_Label10.Location = New System.Drawing.Point(16, 449)
        Me.DbA_Label10.Name = "DbA_Label10"
        Me.DbA_Label10.Size = New System.Drawing.Size(471, 24)
        Me.DbA_Label10.TabIndex = 22
        Me.DbA_Label10.Text = "Arrow Keys - Switch System Selected                 Enter - System Detail Screen"
        Me.DbA_Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DbA_Label10.UseMnemonic = False
        '
        'btn_close
        '
        Me.btn_close.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_close.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_close.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_close.DisplayText = ""
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_close.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.Black
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_close.Location = New System.Drawing.Point(574, 439)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(104, 43)
        Me.btn_close.TabIndex = 21
        Me.btn_close.TabStop = False
        Me.btn_close.Text = "Close"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'lbl_main
        '
        Me.lbl_main.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_main.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_main.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_main.ForeColor = System.Drawing.Color.Black
        Me.lbl_main.Location = New System.Drawing.Point(16, 6)
        Me.lbl_main.Name = "lbl_main"
        Me.lbl_main.Size = New System.Drawing.Size(741, 41)
        Me.lbl_main.TabIndex = 0
        Me.lbl_main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_main.UseMnemonic = False
        '
        'pnl_guidelines
        '
        Me.pnl_guidelines.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_guidelines.Controls.Add(Me.lbl_guidelines)
        Me.pnl_guidelines.Controls.Add(Me.btn_continue)
        Me.pnl_guidelines.Controls.Add(Me.btn_back)
        Me.pnl_guidelines.Controls.Add(Me.lbl_title)
        Me.pnl_guidelines.DataSettings.IDField = Nothing
        Me.pnl_guidelines.DataSettings.JoinData = Nothing
        Me.pnl_guidelines.DataSettings.LinkField = Nothing
        Me.pnl_guidelines.DataSettings.TableName = Nothing
        Me.pnl_guidelines.Gradient = False
        Me.pnl_guidelines.Location = New System.Drawing.Point(0, 0)
        Me.pnl_guidelines.Name = "pnl_guidelines"
        Me.pnl_guidelines.RecordID = Nothing
        Me.pnl_guidelines.Saved = False
        Me.pnl_guidelines.Size = New System.Drawing.Size(769, 513)
        Me.pnl_guidelines.TabIndex = 1
        Me.pnl_guidelines.Visible = False
        '
        'lbl_guidelines
        '
        Me.lbl_guidelines.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_guidelines.BackColor = System.Drawing.Color.FloralWhite
        Me.lbl_guidelines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_guidelines.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_guidelines.ForeColor = System.Drawing.Color.Black
        Me.lbl_guidelines.Location = New System.Drawing.Point(67, 71)
        Me.lbl_guidelines.Name = "lbl_guidelines"
        Me.lbl_guidelines.Size = New System.Drawing.Size(631, 390)
        Me.lbl_guidelines.TabIndex = 2
        Me.lbl_guidelines.UseMnemonic = False
        '
        'btn_continue
        '
        Me.btn_continue.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_continue.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_continue.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_continue.DisplayText = "Continue"
        Me.btn_continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_continue.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_continue.ForeColor = System.Drawing.Color.Black
        Me.btn_continue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_continue.Location = New System.Drawing.Point(427, 23)
        Me.btn_continue.Name = "btn_continue"
        Me.btn_continue.Size = New System.Drawing.Size(125, 43)
        Me.btn_continue.TabIndex = 0
        Me.btn_continue.TabStop = False
        Me.btn_continue.Text = "Press Enter To Continue"
        Me.btn_continue.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_back.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_back.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_back.DisplayText = "Return"
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.Black
        Me.btn_back.Image = CType(resources.GetObject("btn_back.Image"), System.Drawing.Image)
        Me.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_back.Location = New System.Drawing.Point(572, 23)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(125, 43)
        Me.btn_back.TabIndex = 1
        Me.btn_back.TabStop = False
        Me.btn_back.Text = "Back"
        Me.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'lbl_title
        '
        Me.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_title.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_title.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Black
        Me.lbl_title.Location = New System.Drawing.Point(65, 43)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(168, 21)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Bay Guidelines"
        Me.lbl_title.UseMnemonic = False
        '
        'run_main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(769, 510)
        Me.Controls.Add(Me.pnl_main)
        Me.Controls.Add(Me.pnl_guidelines)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "run_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "run_main"
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_main.ResumeLayout(False)
        CType(Me.ct_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_guidelines.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Overrides "
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Dim keyCode As Keys = CType((msg.WParam.ToInt32 And Keys.KeyCode), Keys)
        Dim i As Integer
        Dim hasfocus As Boolean
        Dim p_detail_scr As detail_screen

        ' -------------------
        ' * Process Keystokes
        ' -------------------
        Select Case keyCode
            Case Keys.F8
                If pnl_main.Visible = True Then
                    Call Process("CLOSE")
                Else
                    Call Process("BACK")
                End If

            Case Keys.Down, Keys.Left
                For i = 0 To m_detail_screens.Count - 1
                    If m_detail_screens(i).focus = True Then
                        p_detail_scr = m_detail_screens(i)
                        p_detail_scr.focus = False

                        m_detail_screens.Item(i) = p_detail_scr


                        If i = 0 Then
                            p_detail_scr = m_detail_screens(m_detail_screens.Count - 1)
                            p_detail_scr.focus = True

                            m_detail_screens.Item(m_detail_screens.Count - 1) = p_detail_scr
                        Else
                            p_detail_scr = m_detail_screens(i - 1)
                            p_detail_scr.focus = True

                            m_detail_screens.Item(i - 1) = p_detail_scr
                        End If

                        hasfocus = True

                        Exit For
                    End If
                Next

                If hasfocus = False Then
                    p_detail_scr = m_detail_screens(0)
                    p_detail_scr.focus = True

                    m_detail_screens.Item(0) = p_detail_scr
                End If

                Call DrawPanel()

            Case Keys.Up, Keys.Right
                For i = 0 To m_detail_screens.Count - 1
                    If m_detail_screens(i).focus = True Then
                        p_detail_scr = m_detail_screens(i)
                        p_detail_scr.focus = False

                        m_detail_screens.Item(i) = p_detail_scr

                        If i = m_detail_screens.Count - 1 Then
                            p_detail_scr = m_detail_screens(0)
                            p_detail_scr.focus = True

                            m_detail_screens.Item(0) = p_detail_scr
                        Else
                            p_detail_scr = m_detail_screens(i + 1)
                            p_detail_scr.focus = True

                            m_detail_screens.Item(i + 1) = p_detail_scr
                        End If

                        hasfocus = True

                        Exit For
                    End If
                Next

                If hasfocus = False Then
                    p_detail_scr = m_detail_screens(0)
                    p_detail_scr.focus = True

                    m_detail_screens.Item(0) = p_detail_scr
                End If

                Call DrawPanel()

            Case Keys.Enter
                If pnl_main.Visible = True Then
                    Call PanelClick()
                Else
                    Call Process("CONTINUE")
                End If
        End Select

        Select Case keyCode
            Case Keys.F4, Keys.F8
                Return True
        End Select
    End Function
#End Region

#Region " Structures "
    Public Structure detail_screen
        Dim focus As Boolean
        Dim screen As run_bay_detail
        Dim machine As CUSNET.Machine
        Dim mainPanel As DBA.Library.DBA_Panel
        Dim bay_number As Integer
    End Structure
#End Region

#Region " Declarations "
    Dim m_detail_screens As ArrayList
    Dim m_cur_bay_detail As detail_screen
#End Region

#Region " Button Events "
    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Call Process("CLOSE")
    End Sub

    Private Sub btn_run_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Process("RUN")
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Call Process("BACK")
    End Sub

    Private Sub btn_continue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_continue.Click
        Call Process("CONTINUE")
    End Sub
#End Region

#Region " Close Form "
    Public Sub close_form()
        ' ----------------------------------
        ' * Stop Input Monitoring (Non Demo)
        ' ----------------------------------
        If Not g_demo_mode_flag Then
            Call set_monitoring(False)
        End If

        'Remove any existing handlers
        Call RemoveHandlers()

        g_framework.g_forms(0).Show()
        g_framework.g_forms(1) = Nothing

        Me.Close()
    End Sub
#End Region

#Region " Draw Bays "
    Private Sub draw_bays()
        Dim p_panel As DBA.Library.DBA_Panel
        Dim p_label As DBA.Library.DBA_Label
        Dim p_progbar As DBA.Library.DBA_ProgressBar
        Dim p_detail_scr As detail_screen
        Dim p_counter As Integer = 0

        m_detail_screens = New ArrayList

        For Each p_machine As CUSNET.Machine In g_CUSMain.Machines
            If p_machine.Setup And p_machine.BayNumber <= g_bay_count Then

                p_panel = New DBA.Library.DBA_Panel
                With p_panel
                    .Anchor = AnchorStyles.None
                    .BorderStyle = BorderStyle.FixedSingle
                    .Height = 174
                    .Name = "pnl__" & p_machine.Name & "_" & p_machine.BayNumber
                    .Width = 355
                End With

                ' --------------------------
                ' * Create the detail object
                ' --------------------------
                p_detail_scr = New detail_screen
                p_detail_scr.screen = New run_bay_detail(g_framework.g_db_name)
                p_detail_scr.screen.MdiParent = Me.MdiParent

                With p_detail_scr
                    .machine = p_machine
                    .focus = False
                    .mainPanel = p_panel
                    .bay_number = p_machine.BayNumber
                End With

                With p_detail_scr.screen
                    .lbl_machine_name.Text = "Bay " & p_machine.BayNumber & ":  " & p_machine.Name
                    .m_machine_index = p_counter

                    .Load_Label_Array()
                    .set_screen(p_machine.PinOut, p_machine.Profile)
                End With

                Call size_screen(p_detail_scr.screen)
                m_detail_screens.Add(p_detail_scr)

                Select Case p_counter
                    Case 0
                        p_panel.Left = lbl_main.Left
                        p_panel.Top = 50

                    Case 1
                        p_panel.Left = lbl_main.Left + 385
                        p_panel.Top = 50

                    Case 2
                        p_panel.Left = lbl_main.Left
                        p_panel.Top = 240

                    Case 3
                        p_panel.Left = lbl_main.Left + 385
                        p_panel.Top = 240
                End Select

                'CREATE THE NAME LABEL
                p_label = New DBA.Library.DBA_Label
                With p_label
                    .BorderStyle = BorderStyle.FixedSingle
                    .Height = 24
                    .Left = 7
                    .Name = "lbl_name__" & p_machine.Name & "_" & p_machine.BayNumber
                    .Text = "Bay " & p_machine.BayNumber & ":  " & p_machine.Name
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Top = 8
                    .Width = 339
                End With

                p_panel.Controls.Add(p_label)

                'CREATE THE CYCLE LABEL
                p_label = New DBA.Library.DBA_Label
                With p_label
                    .BorderStyle = BorderStyle.FixedSingle
                    .Font = New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Pixel)
                    .Height = 33
                    .Left = 7
                    .Name = "lbl_cycle__" & p_machine.Name & "_" & p_machine.BayNumber
                    .Text = "Cycle: NONE"
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Top = 28
                    .Width = 339
                End With

                p_panel.Controls.Add(p_label)

                'CREATE THE PHASE LABEL
                p_label = New DBA.Library.DBA_Label
                With p_label
                    .BorderStyle = BorderStyle.FixedSingle
                    .Height = 33
                    .Font = New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Pixel)
                    .Left = 7
                    .Name = "lbl_phase__" & p_machine.Name & "_" & p_machine.BayNumber
                    .Text = "Phase: NONE"
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Top = 64
                    .Width = 339
                End With

                p_panel.Controls.Add(p_label)

                'CREATE THE TOTAL PROGRESS BAR
                p_progbar = New DBA.Library.DBA_ProgressBar
                With p_progbar
                    .DisplayPercentText = True
                    .Height = 53
                    .Left = 7
                    .Name = "prog_total__" & p_machine.Name & "_" & p_machine.BayNumber
                    .PercentTextFont = New Font("Verdana", 20, FontStyle.Bold, GraphicsUnit.Pixel)
                    .Top = 96
                    .Width = 339
                End With

                p_panel.Controls.Add(p_progbar)

                'CREATE THE PROGRESS BAR FOR RUNNING
                p_progbar = New DBA.Library.DBA_ProgressBar
                With p_progbar
                    .Bounce = False
                    .DisplayPercentText = False
                    .Height = 15
                    .Left = 7
                    .Name = "prog_run__" & p_machine.Name & "_" & p_machine.BayNumber
                    .ProgressBarColor = System.Drawing.Color.Blue
                    .Top = 150
                    .Width = 339
                End With

                p_panel.Controls.Add(p_progbar)

                'add in the panel
                pnl_main.Controls.Add(p_panel)

                p_counter += 1
            End If
        Next

        ' ------------------------
        ' * Set focus to first bay
        '' ------------------------
        Dim tmpDetail As detail_screen
        tmpDetail = m_detail_screens(0)
        tmpDetail.focus = True
        m_detail_screens.Item(0) = tmpDetail
        Call DrawPanel()
    End Sub
#End Region

#Region " Form Activate/Enter "
    Private Sub Form_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated, MyBase.Enter
        pnl_main.Focus()
    End Sub
#End Region

#Region " Form Load "
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' -----------------------------
        ' * Reset Demo Mode of Machines
        ' -----------------------------
        For p_x As Integer = 0 To g_bay_count - 1
            g_CUSMain.Machines(p_x).DemoMode = g_demo_mode_flag
        Next

        ' ----------------------
        ' * Load Bay Information
        ' ----------------------
        lbl_main.Text = g_organization

        'Remove any existing handlers
        Call RemoveHandlers()

        'Setup the machines
        Call setup_machines()

        'Draw for display
        Call draw_bays()

        ' -----------------------------------------
        ' * Load Detail Screen Directly for one bay
        ' -----------------------------------------
        Select Case g_bay_count
            Case 1
                m_cur_bay_detail = m_detail_screens(0)
                lbl_guidelines.Text = g_CUSMain.Machines(0).Guidelines
                pnl_guidelines.Visible = True
                pnl_main.Visible = False

            Case 2
                ' Set Logo Box
                ct_box.Left = 250
                ct_box.Top = 300
                ct_box.Visible = True

            Case 3
                ' Set Logo Box
                ct_box.Left = 445
                ct_box.Top = 300
                ct_box.Visible = True
        End Select

        Call size_screen(Me)

        ' -----------------------------------
        ' * Start Input Monitoring (Non Demo)
        ' -----------------------------------
        If Not g_demo_mode_flag Then
            Call set_monitoring(True)
        End If
    End Sub
#End Region

#Region " Get Profile Overrides "
    Private Sub get_profile_overrides(ByVal p_profile_id As String, ByVal p_index As Integer)
        Dim p_sql As String
        Dim p_dataset As DataSet
        Dim p_db_row As DataRow

        ' -----------------------
        ' * Get Profile Overrides
        ' -----------------------
        p_sql = "Select * From profile_maint " & _
                "Where profile_id = '" & p_profile_id & "'"
        p_dataset = g_framework.Get_Data(p_sql)

        ' Get Row
        p_db_row = p_dataset.Tables(0).Rows(0)

        With g_CUSMain.Machines(p_index).SystemOverrides
            ' Wash Seconds
            If p_db_row.Item("wash_secs").ToString <> "" Then
                If .wash_secs < p_db_row.Item("wash_secs") Then
                    .wash_secs = p_db_row.Item("wash_secs")
                End If
            End If

            ' Rinse Seconds
            If p_db_row.Item("rinse_secs").ToString <> "" Then
                If .rinse_secs < p_db_row.Item("rinse_secs") Then
                    .rinse_secs = p_db_row.Item("rinse_secs")
                End If
            End If

            ' Chemical Immersion Minutes, Convert Input to Seconds
            If p_db_row.Item("chemical_immersion").ToString <> "" Then
                If .disinfect_secs < (p_db_row.Item("chemical_immersion") * 60) Then
                    .disinfect_secs = p_db_row.Item("chemical_immersion") * 60
                End If
            End If

            ' Lubrication Seconds
            If p_db_row.Item("lubrication_secs").ToString <> "" Then
                If .lub_secs < p_db_row.Item("lubrication_secs") Then
                    .lub_secs = p_db_row.Item("lubrication_secs")
                End If
            End If

            ' Drain 30 Seconds
            If p_db_row.Item("drain1_secs").ToString <> "" Then
                If .drain_30_secs < p_db_row.Item("drain1_secs") Then
                    .drain_30_secs = p_db_row.Item("drain1_secs")
                End If
            End If

            ' Drain 10 Seconds
            If p_db_row.Item("drain2_secs").ToString <> "" Then
                If .drain_10_secs < p_db_row.Item("drain2_secs") Then
                    .drain_10_secs = p_db_row.Item("drain2_secs")
                End If
            End If

            ' Warwick Delay Seconds
            If p_db_row.Item("warwick_delay_secs").ToString <> "" Then
                If .warwick_delay_secs < p_db_row.Item("warwick_delay_secs") Then
                    .warwick_delay_secs = p_db_row.Item("warwick_delay_secs")
                End If
            End If

            ' Float Delay Seconds
            If p_db_row.Item("float_delay_secs").ToString <> "" Then
                If .float_delay_secs < p_db_row.Item("float_delay_secs") Then
                    .float_delay_secs = p_db_row.Item("float_delay_secs")
                End If
            End If

            ' Pressure Start Delay Seconds
            If p_db_row.Item("pressure_start_delay_secs").ToString <> "" Then
                If .pressure_start_delay_secs < p_db_row.Item("pressure_start_delay_secs") Then
                    .pressure_start_delay_secs = p_db_row.Item("pressure_start_delay_secs")
                End If
            End If

            ' Pressure Error Delay Seconds
            If p_db_row.Item("pressure_error_delay_secs").ToString <> "" Then
                If .pressure_error_delay_secs < p_db_row.Item("pressure_error_delay_secs") Then
                    .pressure_error_delay_secs = p_db_row.Item("pressure_error_delay_secs")
                End If
            End If

            ' Safety Delay Seconds
            If p_db_row.Item("safety_delay_secs").ToString <> "" Then
                If .safety_delay_secs < p_db_row.Item("safety_delay_secs") Then
                    .safety_delay_secs = p_db_row.Item("safety_delay_secs")
                End If
            End If

            If g_us_usage Then
                ' Ultrasonics Delay Seconds
                If p_db_row.Item("ultrasonics_delay_secs").ToString <> "" Then
                    If .ultrasonics_delay_secs < p_db_row.Item("ultrasonics_delay_secs") Then
                        .ultrasonics_delay_secs = p_db_row.Item("ultrasonics_delay_secs")
                    End If
                End If
            End If

            ' Heat Pad Off Temp
            If p_db_row.Item("heat_pad_max").ToString <> "" Then
                If .max_temperature < p_db_row.Item("heat_pad_max") Then
                    .max_temperature = p_db_row.Item("heat_pad_max")
                End If
            End If

            ' Heat Pad On Temp
            If p_db_row.Item("heat_pad_min").ToString <> "" Then
                If .min_temperature < p_db_row.Item("heat_pad_min") Then
                    .min_temperature = p_db_row.Item("heat_pad_min")
                End If
            End If

            ' Min Start Temp
            If p_db_row.Item("min_start_temp").ToString <> "" Then
                If .min_start_temperature < p_db_row.Item("min_start_temp") Then
                    .min_start_temperature = p_db_row.Item("min_start_temp")
                End If
            End If

            ' Max Abort Temp
            If p_db_row.Item("max_abort_temp").ToString <> "" Then
                If .max_abort_temperature < p_db_row.Item("max_abort_temp") Then
                    .max_abort_temperature = p_db_row.Item("max_abort_temp")
                End If
            End If

            ' 81 Spray Rinse Delay Seconds
            If p_db_row.Item("spray_rinse_delay_81").ToString <> "" Then
                If .spray_rinse_wait_secs < p_db_row.Item("spray_rinse_delay_81") Then
                    .spray_rinse_wait_secs = p_db_row.Item("spray_rinse_delay_81")
                End If
            End If

            ' 81 Spray Rinse Seconds
            If p_db_row.Item("spray_rinse_secs_81").ToString <> "" Then
                If .spray_rinse_secs < p_db_row.Item("spray_rinse_secs_81") Then
                    .spray_rinse_secs = p_db_row.Item("spray_rinse_secs_81")
                End If
            End If

            ' 81 Detergent Seconds
            If p_db_row.Item("detergent_secs_81").ToString <> "" Then
                If .detergent_81_secs < p_db_row.Item("detergent_secs_81") Then
                    .detergent_81_secs = p_db_row.Item("detergent_secs_81")
                End If
            End If

            ' 81 Enzyme Seconds
            If p_db_row.Item("enzyme_secs_81").ToString <> "" Then
                If .enzyme_secs < p_db_row.Item("enzyme_secs_81") Then
                    .enzyme_secs = p_db_row.Item("enzyme_secs_81")
                End If
            End If

            ' 81 Soak Seconds
            If p_db_row.Item("soak_secs_81").ToString <> "" Then
                If .soak_secs < p_db_row.Item("soak_secs_81") Then
                    .soak_secs = p_db_row.Item("soak_secs_81")
                End If
            End If

            ' 81 Prerinse Seconds
            If p_db_row.Item("prerinse_secs_81").ToString <> "" Then
                If .prerinse_secs < p_db_row.Item("prerinse_secs_81") Then
                    .prerinse_secs = p_db_row.Item("prerinse_secs_81")
                End If
            End If

            ' 81 Reservoir Fill Seconds
            If p_db_row.Item("reservoir_fill_secs_81").ToString <> "" Then
                If .reservoir_fill_secs < p_db_row.Item("reservoir_fill_secs_81") Then
                    .reservoir_fill_secs = p_db_row.Item("reservoir_fill_secs_81")
                End If
            End If

            ' 82 Ultrasonics Seconds
            If p_db_row.Item("ultrasonics_disinfect_secs_82").ToString <> "" Then
                If .dis_ultra_secs < p_db_row.Item("ultrasonics_disinfect_secs_82") Then
                    .dis_ultra_secs = p_db_row.Item("ultrasonics_disinfect_secs_82")
                End If
            End If

            ' 83 Detergent Seconds
            If p_db_row.Item("detergent_secs_83").ToString <> "" Then
                If .detergent_83_secs < p_db_row.Item("detergent_secs_83") Then
                    .detergent_83_secs = p_db_row.Item("detergent_secs_83")
                End If
            End If

            ' 83 Drying Heat Seconds
            If p_db_row.Item("dry_heat_secs_83").ToString <> "" Then
                If .dry_heat_secs < p_db_row.Item("dry_heat_secs_83") Then
                    .dry_heat_secs = p_db_row.Item("dry_heat_secs_83")
                End If
            End If

            ' 83 Drying Cool Seconds
            If p_db_row.Item("dry_cool_secs_83").ToString <> "" Then
                If .dry_cool_secs < p_db_row.Item("dry_cool_secs_83") Then
                    .dry_cool_secs = p_db_row.Item("dry_cool_secs_83")
                End If
            End If
        End With

        ' Dispose of Dataset
        p_dataset.Dispose()
    End Sub
#End Region

#Region " Handler Functions "
    Private Sub MachineStarted(ByVal sender As Object, ByVal e As System.EventArgs)
        If g_bay_count = 1 Then Exit Sub

        Dim p_machine As CUSNET.Machine = sender

        ' ---------------------
        ' * Reset Panel For Run
        ' ---------------------
        Call reset_bay_info(p_machine.BayNumber - 1)
        Call set_run_progress(sender, True)
    End Sub

    Private Sub MachineFinished(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim p_machine As CUSNET.Machine = sender
        Dim pObj As detail_screen
        Dim p_sql As String

        ' Get Run Detail Screen
        pObj = m_detail_screens(p_machine.BayNumber - 1)

        ' -----------------------------------
        ' * Update Run Header Completion Data
        ' -----------------------------------
        p_sql = "Update run_info_header " & _
                "Set complete = 1, end_time = getdate()"

        If p_machine.Has_Disinfect Then
            p_sql &= ", final_disinfect_temp = " & p_machine.Final_Disinfect_Temp.ToString
        End If

        p_sql &= " Where run_header_id = '" & p_machine.Run_Header_ID & "'"

        g_framework.Execute_Query(p_sql)

        If g_bay_count > 1 Then
            Dim p_name As String
            Dim p_pnl As DBA.Library.DBA_Panel
            Dim p_progbar As DBA.Library.DBA_ProgressBar

            ' ------------------
            ' * Get Machine Name
            ' ------------------
            p_name = p_machine.Name & "_" & p_machine.BayNumber
            p_pnl = get_panel("pnl__" & p_name)

            ' Get Overall Progress
            p_progbar = get_control("prog_total__" & p_name, p_pnl)
            If Not p_progbar Is Nothing Then p_progbar.Value = 100

            ' -----------------------
            ' * Start Run ProgressBar
            ' -----------------------
            Call set_run_progress(sender, False)
        End If

        ' --------------------------
        ' * Update the detail screen
        ' --------------------------
        pObj.screen.setup_finish()
    End Sub

    Private Sub TemperatureChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim p_machine As CUSNET.Machine = sender
        Dim pObj As detail_screen

        Try

            'Update the detail screen
            pObj = m_detail_screens(p_machine.BayNumber - 1)

            With pObj.screen
                .lbl_res_temp_dis.Text = p_machine.ReservoirTemperature
                .prog_res_temp.Value = p_machine.ReservoirTemperature

                .lbl_bay_temp_dis.Text = p_machine.BayTemperature
                .prog_bay_temp.Value = p_machine.BayTemperature

                .lbl_res_temp_dis.Refresh()
                .prog_res_temp.Refresh()

                .lbl_bay_temp_dis.Refresh()
                .prog_bay_temp.Refresh()
            End With

        Catch
        End Try
    End Sub

    Private Sub BitStatesChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim p_machine As CUSNET.Machine = sender
        Dim pObj As detail_screen
        Dim p_lbl As BitCheck

        Try

            'Update the detail screen
            pObj = m_detail_screens(p_machine.BayNumber - 1)

            For Each p_lbl In pObj.screen.m_lbl_array
                If p_machine.Bits(p_lbl.p_bit_name).State Then
                    If p_lbl.p_label.Tag <> "ON" Then
                        p_lbl.p_label.BackColor = System.Drawing.Color.Green
                        p_lbl.p_label.ForeColor = System.Drawing.Color.White

                        p_lbl.p_label.Tag = "ON"
                    End If
                Else
                    If p_lbl.p_label.Tag = "ON" Then
                        p_lbl.p_label.BackColor = System.Drawing.Color.PapayaWhip
                        p_lbl.p_label.ForeColor = System.Drawing.Color.Black

                        p_lbl.p_label.Tag = "OFF"
                    End If
                End If
            Next

            pObj.screen.Refresh()

        Catch
        End Try
    End Sub

    Private Sub BeforeCycleCompleted(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim p_machine As CUSNET.Machine = sender
        Dim pObj As detail_screen

        ' --------------------------
        ' * Update the detail screen
        ' --------------------------
        pObj = m_detail_screens(p_machine.BayNumber - 1)

        pObj.screen.lbl_stage.Text = main.validate(p_machine.CurrentCycle.Cycle.ToString)
        pObj.screen.lbl_completed.Text = p_machine.CyclesCompleted
        pObj.screen.lbl_left.Text = (p_machine.TotalCycles - p_machine.CyclesCompleted)
        pObj.screen.Refresh()

        If g_bay_count = 1 Then Exit Sub

        Dim p_name As String
        Dim p_pnl As DBA.Library.DBA_Panel
        Dim p_label As DBA.Library.DBA_Label

        ' Get Machine Name
        p_name = p_machine.Name & "_" & p_machine.BayNumber
        p_pnl = get_panel("pnl__" & p_name)

        p_label = get_control("lbl_cycle__" & p_name, p_pnl)
        If Not p_label Is Nothing Then
            p_label.Text = main.validate("Processing Cycle: " & p_machine.CurrentCycle.Cycle.ToString)
            p_label.Refresh()
        End If
    End Sub

    Private Sub AfterCycleCompleted(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim p_machine As CUSNET.Machine = sender
        Dim pObj As detail_screen
        Dim p_sql As String

        ' Get Run Detail Screen
        pObj = m_detail_screens(p_machine.BayNumber - 1)

        If Not g_england_flag Then
            ' -------------------------------
            ' * Add Run Cycle Detail To Table
            ' -------------------------------
            p_sql = "INSERT INTO run_info_detail (run_header_id, cycle_name, " & _
                    "secs, run_order) Values ('" & p_machine.Run_Header_ID & _
                    "', '" & p_machine.CurrentCycle.Cycle.ToString & "', "

            ' Get Run Seconds
            Select Case UCase(p_machine.CurrentCycle.Cycle.ToString)
                Case "DISINFECT"
                    p_sql &= p_machine.CurrentCycle.SystemOverrides.disinfect_secs

                Case "DRY"
                    p_sql &= p_machine.CurrentCycle.SystemOverrides.dry_cool_secs + _
                        p_machine.CurrentCycle.SystemOverrides.dry_heat_secs

                Case "PRERINSE"
                    p_sql &= p_machine.CurrentCycle.SystemOverrides.prerinse_secs

                Case "RINSE"
                    p_sql &= p_machine.CurrentCycle.SystemOverrides.rinse_secs

                Case "SOAK"
                    p_sql &= p_machine.CurrentCycle.SystemOverrides.soak_secs

                Case "WASH"
                    p_sql &= p_machine.CurrentCycle.SystemOverrides.wash_secs
            End Select

            p_sql &= ", " & p_machine.CyclesCompleted & ")"

            g_framework.Execute_Query(p_sql)
        End If

        ' Update the detail screen
        pObj.screen.lbl_completed.Text = p_machine.CyclesCompleted
        pObj.screen.lbl_left.Text = (p_machine.TotalCycles - p_machine.CyclesCompleted)
        pObj.screen.Refresh()

        If g_bay_count = 1 Then Exit Sub

        Dim p_name As String
        Dim p_pnl As DBA.Library.DBA_Panel
        Dim p_label As DBA.Library.DBA_Label

        ' ------------------
        ' * Get Machine Name
        ' ------------------
        p_name = p_machine.Name & "_" & p_machine.BayNumber
        p_pnl = get_panel("pnl__" & p_name)

        p_label = get_control("lbl_cycle__" & p_name, p_pnl)
        If Not p_label Is Nothing Then
            p_label.Text = main.validate("Finished Cycle: " & p_machine.CurrentCycle.Cycle.ToString)
            p_label.Refresh()
        End If
    End Sub

    Private Sub BeforePhaseCompleted(ByVal sender As Object, ByVal e As System.EventArgs)
        If g_bay_count = 1 Then Exit Sub

        Dim p_machine As CUSNET.Machine = sender
        Dim p_name As String
        Dim p_pnl As DBA.Library.DBA_Panel
        Dim p_label As DBA.Library.DBA_Label

        ' Get Machine Name
        p_name = p_machine.Name & "_" & p_machine.BayNumber
        p_pnl = get_panel("pnl__" & p_name)

        ' Get Phase Label
        p_label = get_control("lbl_phase__" & p_name, p_pnl)

        If Not p_label Is Nothing Then
            p_label.Text = main.validate("Processing Phase: " & p_machine.CurrentPhase.Phase.ToString)
            p_label.Refresh()
        End If
    End Sub

    Private Sub AfterPhaseCompleted(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim p_machine As CUSNET.Machine = sender
        Dim pObj As detail_screen

        ' Update the detail screen
        pObj = m_detail_screens(p_machine.BayNumber - 1)

        If g_england_flag Then
            ' ----------------------------------------------
            ' * Output Phase Information for England Machine
            ' ----------------------------------------------
            Dim p_sql As String
            p_sql = "INSERT INTO run_info_detail (run_header_id, cycle_name, " & _
                    "secs, run_order) Values ('" & p_machine.Run_Header_ID & _
                    "', '" & p_machine.CurrentPhase.Phase.ToString & "', "

            ' Get Run Seconds
            p_sql &= DateDiff(DateInterval.Second, p_machine.CurrentPhase.StartTime, p_machine.CurrentPhase.StopTime)

            p_sql &= ", " & p_machine.PhasesCompleted & ")"

            g_framework.Execute_Query(p_sql)
        End If

        ' Update Overrall Progress
        pObj.screen.prog_overall.Value = CInt((p_machine.PhasesCompleted / p_machine.TotalPhases) * 100)
        pObj.screen.Refresh()

        If g_bay_count = 1 Then Exit Sub

        Dim p_progbar As DBA.Library.DBA_ProgressBar
        Dim p_name As String
        Dim p_pnl As DBA.Library.DBA_Panel
        Dim p_label As DBA.Library.DBA_Label

        ' Get Machine Name
        p_name = p_machine.Name & "_" & p_machine.BayNumber
        p_pnl = get_panel("pnl__" & p_name)

        ' Get Phase Label
        p_label = get_control("lbl_phase__" & p_name, p_pnl)
        If Not p_label Is Nothing Then
            p_label.Text = main.validate("Finished Phase: " & p_machine.CurrentPhase.Phase.ToString)
            p_label.Refresh()
        End If

        ' Get Overall Progress
        p_progbar = get_control("prog_total__" & p_name, p_pnl)
        If Not p_progbar Is Nothing Then
            p_progbar.Value = CInt((p_machine.PhasesCompleted / p_machine.TotalPhases) * 100)
        End If
    End Sub

    Private Sub ErrorOccurred(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim p_machine As CUSNET.Machine = sender
        Dim pObj As detail_screen

        ' Get Detail Screen
        pObj = m_detail_screens(p_machine.BayNumber - 1)

        ' --------------------------------------------
        ' * Write Error To Database for Error Occurred
        ' --------------------------------------------
        If p_machine.Run_Header_ID <> "" Then
            Dim p_sql As String

            ' -------------------
            ' * Update Run Header
            ' -------------------
            p_sql = "Update run_info_header " & _
                    "Set error = Substring(Ltrim(Rtrim(ISNUll(error, '') + '   " & g_CUSMain.Machines(p_machine.BayNumber - 1).Error_Message & _
                    "')), 1, 150), end_time = getdate() "

            If g_england_flag Then
                Select Case p_machine.BayNumber - 1
                    Case 0
                        p_sql &= ", disinfect_lot = " & Me.return_parsed_single_quote_string(g_disinfect_lot1)

                    Case 1
                        p_sql &= ", disinfect_lot = " & Me.return_parsed_single_quote_string(g_disinfect_lot2)

                    Case 2
                        p_sql &= ", disinfect_lot = " & Me.return_parsed_single_quote_string(g_disinfect_lot3)

                    Case 3
                        p_sql &= ", disinfect_lot = " & Me.return_parsed_single_quote_string(g_disinfect_lot4)
                End Select
            End If

            p_sql &= " Where run_header_id = '" & p_machine.Run_Header_ID & "';"

            ' ------------------------------
            ' * Move Patient/Instrument Data
            ' ------------------------------
            p_sql &= "INSERT INTO run_info_data (run_header_id, patient_id, instrument_id) " & _
                     "Select '" & p_machine.Run_Header_ID & "', patient_id, instrument_id " & _
                     "FROM pre_run_info Where bay_number = " & p_machine.BayNumber & ";"
            Call g_framework.Execute_Query(p_sql)

            ' -------------
            ' * Print Error
            ' -------------
            If g_england_flag Then
                Call print_error(p_machine.Run_Header_ID, p_machine.BayNumber)
            End If
        End If

        ' --------------------------
        ' * Reset Main Panel for Bay
        ' --------------------------
        If g_bay_count > 1 Then
            Call error_bay_info(p_machine.BayNumber - 1)
        End If

        ' -----------------------------
        ' * Set Detail Screen for Error
        ' -----------------------------
        pObj.screen.set_screen_for_error()

        ' ---------------
        ' * Display Error
        ' ---------------
        Call message_box("Bay #" & p_machine.BayNumber & " - " & g_CUSMain.Machines(p_machine.BayNumber - 1).Error_Message, 1)
    End Sub

    Public Sub set_run_progress(ByVal p_machine As CUSNET.Machine, ByVal p_mode As Boolean)
        Dim p_name As String
        Dim p_pnl As DBA.Library.DBA_Panel
        Dim p_progbar As DBA.Library.DBA_ProgressBar

        ' Get Machine Name
        p_name = p_machine.Name & "_" & p_machine.BayNumber
        p_pnl = get_panel("pnl__" & p_name)

        p_progbar = get_control("prog_run__" & p_name, p_pnl)
        If Not p_progbar Is Nothing Then
            p_progbar.Bounce = p_mode
            p_progbar.Refresh()
        End If

        If Not p_pnl Is Nothing Then p_pnl.Refresh()
        Me.Refresh()
    End Sub

    Public Sub set_special_function(ByVal p_machine_name As String, ByVal p_machine_number As String, _
        ByVal p_string As String)
        Dim p_pnl As DBA.Library.DBA_Panel
        Dim p_label As DBA.Library.DBA_Label

        ' Get Machine Name
        p_pnl = get_panel("pnl__" & p_machine_name & "_" & p_machine_number)

        p_label = get_control("lbl_cycle__" & p_machine_name & "_" & p_machine_number, p_pnl)

        If Not p_label Is Nothing Then
            If p_string = "" Then
                p_label.Text = "Cycle: NONE"
            Else
                p_label.Text = "Processing: " & p_string
            End If
            p_label.Refresh()
        End If
    End Sub
#End Region

#Region " Panel Events "
    Private Sub PanelClick()
        'Update the detail screen
        For Each pObj As detail_screen In m_detail_screens
            If pObj.focus = True Then
                m_cur_bay_detail = pObj

                If pObj.machine.Bay_Running Or (Not pObj.machine.Finished And pObj.machine.Processed) _
                    Or pObj.screen.btn_additional.Tag = "ERROR" Then
                    Call Process("CONTINUE")
                Else
                    lbl_guidelines.Text = g_CUSMain.Machines(pObj.bay_number - 1).Guidelines
                    pnl_main.Visible = False
                    pnl_guidelines.Visible = True
                End If

                Exit For
            End If
        Next
    End Sub

    Private Sub DrawPanel()
        For Each pObj As detail_screen In m_detail_screens
            If pObj.focus = True Then
                pObj.mainPanel.BackColor = System.Drawing.Color.Gainsboro
                For Each pCtrl As Control In pObj.mainPanel.Controls
                    pCtrl.BackColor = System.Drawing.Color.Gainsboro
                Next
            Else
                pObj.mainPanel.BackColor = Nothing
                For Each pCtrl As Control In pObj.mainPanel.Controls
                    pCtrl.BackColor = Nothing
                Next
            End If
        Next
    End Sub
#End Region

#Region " Print Error "
    Private Sub print_error(ByVal p_header_id As String, ByVal p_bay_number As Integer)
        Dim p_string As String
        Dim p_print As New ArrayList

        ' ------------------
        ' * Get Process Data
        ' ------------------
        Dim p_ticket_count As Integer
        p_string = get_process_data(p_header_id, p_bay_number, True, "PRINT", p_ticket_count)

        ' ------------
        ' * Print Data
        ' ------------
        p_print.Clear()
        p_print.Add(p_string)

        'Used to line feeds
        p_print.Add("")
        p_print.Add("")
        p_print.Add("")
        p_print.Add("")

        Try
            ' Print Results
            Dim p_printing As New CUSPrint.TextPrinting(g_PrintPort)
            p_printing.Print(p_print)

        Catch
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Call message_box("Bad printer connection.", 4, "Print Error")
        End Try
    End Sub
#End Region

#Region " Process "
    Private Sub Process(ByVal p_type As String)
        Select Case UCase(p_type)
            Case "CLOSE"
                For Each p_machine As CUSNET.Machine In g_CUSMain.Machines
                    If p_machine.Bay_Running Then
                        Call message_box("Bay(s) are still running!", 1, "Close Cancelled")

                        pnl_main.Focus()
                        Exit Sub

                    ElseIf Not p_machine.Finished And p_machine.Processed Then
                        Call message_box("Bay(s) need to be finalized!", 1, "Close Cancelled")

                        pnl_main.Focus()
                        Exit Sub
                    End If
                Next

                ' ------------------
                ' * Cleanup Run Data
                ' ------------------
                Call cleanup_run_data()

                Call close_form()

            Case "CONTINUE"
                lbl_guidelines.Text = ""
                pnl_main.Visible = True
                pnl_guidelines.Visible = False

                ' ----------------------
                ' * Washer Detail Screen
                ' ----------------------
                m_cur_bay_detail.screen.TopMost = True
                m_cur_bay_detail.screen.MdiParent = g_mdi_form
                m_cur_bay_detail.screen.Show()

                Me.Hide()

            Case "BACK"
                If g_bay_count = 1 Then
                    Call close_form()
                Else
                    lbl_guidelines.Text = ""
                    pnl_main.Visible = True
                    pnl_guidelines.Visible = False
                End If
        End Select
    End Sub
#End Region

#Region " Reset Bay Info "
    Private Function get_panel(ByVal p_name As String) As DBA.Library.DBA_Panel
        get_panel = Nothing

        For Each p_ctrl As Control In pnl_main.Controls
            If p_ctrl.Name = p_name Then
                get_panel = p_ctrl
            End If
        Next
    End Function

    Private Function get_control(ByVal p_name As String, ByVal p_pnl As DBA.Library.DBA_Panel) As Control
        get_control = Nothing

        If Not p_pnl Is Nothing Then
            For Each p_ctrl As Control In p_pnl.Controls
                If p_ctrl.Name = p_name Then
                    get_control = p_ctrl
                End If
            Next
        End If
    End Function

    Public Sub reset_bay_info(ByVal p_index As Integer)
        Dim p_name As String
        Dim p_pnl As DBA.Library.DBA_Panel
        Dim p_label As DBA.Library.DBA_Label
        Dim p_progbar As DBA.Library.DBA_ProgressBar

        ' Get Machine Name
        p_name = g_CUSMain.Machines(p_index).Name & "_" & g_CUSMain.Machines(p_index).BayNumber
        p_pnl = get_panel("pnl__" & p_name)

        ' Reset Values
        p_label = get_control("lbl_cycle__" & p_name, p_pnl)
        If Not p_label Is Nothing Then p_label.Text = "Cycle: NONE"

        p_label = get_control("lbl_phase__" & p_name, p_pnl)
        If Not p_label Is Nothing Then p_label.Text = "Phase: NONE"

        p_progbar = get_control("prog_total__" & p_name, p_pnl)
        If Not p_progbar Is Nothing Then
            p_progbar.Value = 0
        End If

        p_progbar = get_control("prog_run__" & p_name, p_pnl)
        If Not p_progbar Is Nothing Then
            p_progbar.Bounce = False
            p_progbar.Value = 0
        End If
    End Sub

    Private Sub error_bay_info(ByVal p_index As Integer)
        Dim p_name As String
        Dim p_pnl As DBA.Library.DBA_Panel
        Dim p_label As DBA.Library.DBA_Label
        Dim p_progbar As DBA.Library.DBA_ProgressBar

        ' Get Machine Name
        p_name = g_CUSMain.Machines(p_index).Name & "_" & g_CUSMain.Machines(p_index).BayNumber
        p_pnl = get_panel("pnl__" & p_name)

        ' Reset Values
        p_label = get_control("lbl_cycle__" & p_name, p_pnl)
        If Not p_label Is Nothing Then p_label.Text = "Error Occurred"

        p_label = get_control("lbl_phase__" & p_name, p_pnl)
        If Not p_label Is Nothing Then p_label.Text = ""

        p_progbar = get_control("prog_total__" & p_name, p_pnl)
        If Not p_progbar Is Nothing Then
            p_progbar.Value = 0
        End If

        p_progbar = get_control("prog_run__" & p_name, p_pnl)
        If Not p_progbar Is Nothing Then
            p_progbar.Bounce = False
            p_progbar.Value = 0
        End If
    End Sub
#End Region

#Region " Setup Machines "
    Private Sub setup_machines()
        Dim p_sql As String
        Dim p_dataset As DataSet
        Dim p_db_row As DataRow
        Dim p_index As Integer

        ' ----------------------
        ' * Load up the profiles
        ' ----------------------
        p_sql = "SELECT title, pinout, B1.profile_id, bay_number, guidelines, " & _
                "detergent, liquid_sterilant " & _
                "FROM bay_settings B1 " & _
                "INNER JOIN profile_maint P1 ON P1.profile_id = B1.profile_id " & _
                "INNER JOIN pinouts P2 ON P2.pinout_id = B1.pinout_id " & _
                "LEFT JOIN guideline_maint G1 On G1.guideline_id = B1.guideline_id " & _
                "LEFT JOIN detergent_maint D1 On D1.detergent_id = B1.detergent_id " & _
                "LEFT JOIN liquid_sterilant_maint L1 On L1.liquid_sterilant_id = B1.liquid_sterilant_id " & _
                "ORDER BY B1.bay_number"
        p_dataset = g_framework.Get_Data(p_sql)

        ' ----------------------------------
        ' * loop through all of the profiles
        ' ----------------------------------
        For Each p_db_row In p_dataset.Tables(0).Rows
            p_index = p_db_row("bay_number") - 1

            If p_db_row("bay_number") <= g_bay_count Then
                If g_CUSMain.Machines(p_index).Setup = False Then

                    'Load up all of the minimum defaults
                    Call LoadMachineDefaults(p_index)

                    ' Set the machine name
                    g_CUSMain.Machines(p_index).Name = p_db_row("title").ToString

                    ' Set the machine pinout
                    g_CUSMain.Machines(p_index).PinOut = Get_Pinout(p_db_row("pinout").ToString)

                    ' Get the machine guidelines
                    g_CUSMain.Machines(p_index).Guidelines = p_db_row("guidelines").ToString

                    ' Get the machine detergent
                    g_CUSMain.Machines(p_index).detergent = p_db_row("detergent").ToString

                    ' Get the machine liquid sterilant
                    g_CUSMain.Machines(p_index).liquid_sterilant = p_db_row("liquid_sterilant").ToString

                    ' ------------------------
                    ' * Load Profile Overrides
                    ' ------------------------
                    g_CUSMain.Machines(p_index).Profile = p_db_row("profile_id").ToString
                    Call get_profile_overrides(p_db_row("profile_id").ToString, p_index)

                    ' --------------------------
                    ' * Get System Data Settings
                    ' --------------------------
                    ' Get Disinfect Mins
                    g_disinfect_settings(p_index) = g_CUSMain.Machines(p_index).SystemOverrides.disinfect_secs / 60

                    ' Get Lubrication Secs
                    g_lubrication_settings(p_index) = g_CUSMain.Machines(p_index).SystemOverrides.lub_secs

                    g_CUSMain.Machines(p_index).Setup = True
                End If

                'Create New Handlers
                AddHandler g_CUSMain.Machines(p_index).MachineStarted, AddressOf MachineStarted
                AddHandler g_CUSMain.Machines(p_index).MachineFinished, AddressOf MachineFinished

                AddHandler g_CUSMain.Machines(p_index).BeforeCycleCompleted, AddressOf BeforeCycleCompleted
                AddHandler g_CUSMain.Machines(p_index).AfterCycleCompleted, AddressOf AfterCycleCompleted

                AddHandler g_CUSMain.Machines(p_index).BeforePhaseCompleted, AddressOf BeforePhaseCompleted
                AddHandler g_CUSMain.Machines(p_index).AfterPhaseCompleted, AddressOf AfterPhaseCompleted

                AddHandler g_CUSMain.Machines(p_index).BitStatesChanged, AddressOf BitStatesChanged
                AddHandler g_CUSMain.Machines(p_index).TemperatureChanged, AddressOf TemperatureChanged

                AddHandler g_CUSMain.Machines(p_index).ErrorOccurred, AddressOf ErrorOccurred
            End If
        Next

        ' Dispose of Dataset
        p_dataset.Dispose()
    End Sub
#End Region

#Region " Remove Handlers "
    Public Sub RemoveHandlers()
        Dim i As Integer

        For i = 0 To g_bay_count - 1
            'Remove Existing Handlers
            RemoveHandler g_CUSMain.Machines(i).MachineStarted, AddressOf MachineStarted
            RemoveHandler g_CUSMain.Machines(i).MachineFinished, AddressOf MachineFinished
            RemoveHandler g_CUSMain.Machines(i).BeforeCycleCompleted, AddressOf BeforeCycleCompleted
            RemoveHandler g_CUSMain.Machines(i).AfterCycleCompleted, AddressOf AfterCycleCompleted
            RemoveHandler g_CUSMain.Machines(i).BeforePhaseCompleted, AddressOf BeforePhaseCompleted
            RemoveHandler g_CUSMain.Machines(i).AfterPhaseCompleted, AddressOf AfterPhaseCompleted
            RemoveHandler g_CUSMain.Machines(i).BitStatesChanged, AddressOf BitStatesChanged
            RemoveHandler g_CUSMain.Machines(i).TemperatureChanged, AddressOf TemperatureChanged
            RemoveHandler g_CUSMain.Machines(i).ErrorOccurred, AddressOf ErrorOccurred
        Next

    End Sub
#End Region

End Class
