Public Class admin_setup_mnu
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
    Friend WithEvents lbl_info As DBA.Library.DBA_Label
    Friend WithEvents btn_reports As DBA.Library.DBA_Button
    Friend WithEvents btn_settings As DBA.Library.DBA_Button
    Friend WithEvents btn_back As DBA.Library.DBA_Button
    Friend WithEvents btn_service As DBA.Library.DBA_Button
    Friend WithEvents btn_bay As DBA.Library.DBA_Button
    Friend WithEvents btn_profile As DBA.Library.DBA_Button
    Friend WithEvents btn_guidelines As DBA.Library.DBA_Button
    Friend WithEvents btn_minimums As DBA.Library.DBA_Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_setup_mnu))
        Me.pnl_main = New DBA.Library.DBA_Panel
        Me.btn_minimums = New DBA.Library.DBA_Button(Me.components)
        Me.btn_guidelines = New DBA.Library.DBA_Button(Me.components)
        Me.btn_back = New DBA.Library.DBA_Button(Me.components)
        Me.btn_reports = New DBA.Library.DBA_Button(Me.components)
        Me.lbl_info = New DBA.Library.DBA_Label(Me.components)
        Me.btn_settings = New DBA.Library.DBA_Button(Me.components)
        Me.btn_service = New DBA.Library.DBA_Button(Me.components)
        Me.btn_bay = New DBA.Library.DBA_Button(Me.components)
        Me.btn_profile = New DBA.Library.DBA_Button(Me.components)
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_main
        '
        Me.pnl_main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_main.Controls.Add(Me.btn_minimums)
        Me.pnl_main.Controls.Add(Me.btn_guidelines)
        Me.pnl_main.Controls.Add(Me.btn_back)
        Me.pnl_main.Controls.Add(Me.btn_reports)
        Me.pnl_main.Controls.Add(Me.lbl_info)
        Me.pnl_main.Controls.Add(Me.btn_settings)
        Me.pnl_main.Controls.Add(Me.btn_service)
        Me.pnl_main.Controls.Add(Me.btn_bay)
        Me.pnl_main.Controls.Add(Me.btn_profile)
        Me.pnl_main.DataSettings.IDField = Nothing
        Me.pnl_main.DataSettings.JoinData = Nothing
        Me.pnl_main.DataSettings.LinkField = Nothing
        Me.pnl_main.DataSettings.TableName = Nothing
        Me.pnl_main.Gradient = False
        Me.pnl_main.Location = New System.Drawing.Point(0, 0)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.RecordID = Nothing
        Me.pnl_main.Saved = False
        Me.pnl_main.Size = New System.Drawing.Size(512, 304)
        Me.pnl_main.TabIndex = 1
        '
        'btn_minimums
        '
        Me.btn_minimums.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_minimums.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_minimums.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_minimums.DisplayText = "Database Entry"
        Me.btn_minimums.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_minimums.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minimums.ForeColor = System.Drawing.Color.Black
        Me.btn_minimums.Image = CType(resources.GetObject("btn_minimums.Image"), System.Drawing.Image)
        Me.btn_minimums.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_minimums.Location = New System.Drawing.Point(33, 199)
        Me.btn_minimums.Name = "btn_minimums"
        Me.btn_minimums.Size = New System.Drawing.Size(214, 47)
        Me.btn_minimums.TabIndex = 1
        Me.btn_minimums.TabStop = False
        Me.btn_minimums.Text = "&Overrides"
        Me.btn_minimums.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_minimums.UseVisualStyleBackColor = False
        '
        'btn_guidelines
        '
        Me.btn_guidelines.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_guidelines.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_guidelines.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_guidelines.DisplayText = "Guidelines"
        Me.btn_guidelines.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guidelines.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guidelines.ForeColor = System.Drawing.Color.Black
        Me.btn_guidelines.Image = CType(resources.GetObject("btn_guidelines.Image"), System.Drawing.Image)
        Me.btn_guidelines.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guidelines.Location = New System.Drawing.Point(265, 22)
        Me.btn_guidelines.Name = "btn_guidelines"
        Me.btn_guidelines.Size = New System.Drawing.Size(214, 47)
        Me.btn_guidelines.TabIndex = 5
        Me.btn_guidelines.TabStop = False
        Me.btn_guidelines.Text = "&Guidelines"
        Me.btn_guidelines.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guidelines.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_back.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_back.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_back.DisplayText = "Database Entry"
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_back.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.Black
        Me.btn_back.Image = CType(resources.GetObject("btn_back.Image"), System.Drawing.Image)
        Me.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_back.Location = New System.Drawing.Point(265, 199)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(214, 47)
        Me.btn_back.TabIndex = 0
        Me.btn_back.TabStop = False
        Me.btn_back.Text = "Back"
        Me.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_reports
        '
        Me.btn_reports.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_reports.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_reports.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_reports.DisplayText = "Database Entry"
        Me.btn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_reports.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reports.ForeColor = System.Drawing.Color.Black
        Me.btn_reports.Image = CType(resources.GetObject("btn_reports.Image"), System.Drawing.Image)
        Me.btn_reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reports.Location = New System.Drawing.Point(265, 140)
        Me.btn_reports.Name = "btn_reports"
        Me.btn_reports.Size = New System.Drawing.Size(214, 47)
        Me.btn_reports.TabIndex = 7
        Me.btn_reports.TabStop = False
        Me.btn_reports.Text = "Admin &Reports"
        Me.btn_reports.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_reports.UseVisualStyleBackColor = False
        '
        'lbl_info
        '
        Me.lbl_info.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_info.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_info.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info.ForeColor = System.Drawing.Color.Black
        Me.lbl_info.Location = New System.Drawing.Point(6, 284)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(500, 17)
        Me.lbl_info.TabIndex = 5
        Me.lbl_info.Text = "Use arrow/enter keys or press underlined letter to a select button."
        Me.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_info.UseMnemonic = False
        '
        'btn_settings
        '
        Me.btn_settings.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_settings.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_settings.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_settings.DisplayText = "Setup"
        Me.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_settings.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_settings.ForeColor = System.Drawing.Color.Black
        Me.btn_settings.Image = CType(resources.GetObject("btn_settings.Image"), System.Drawing.Image)
        Me.btn_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_settings.Location = New System.Drawing.Point(33, 22)
        Me.btn_settings.Name = "btn_settings"
        Me.btn_settings.Size = New System.Drawing.Size(214, 47)
        Me.btn_settings.TabIndex = 4
        Me.btn_settings.TabStop = False
        Me.btn_settings.Text = "&Main Settings"
        Me.btn_settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_settings.UseVisualStyleBackColor = False
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
        Me.btn_service.Location = New System.Drawing.Point(33, 140)
        Me.btn_service.Name = "btn_service"
        Me.btn_service.Size = New System.Drawing.Size(214, 47)
        Me.btn_service.TabIndex = 2
        Me.btn_service.TabStop = False
        Me.btn_service.Text = "&Service Screen"
        Me.btn_service.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_service.UseVisualStyleBackColor = False
        '
        'btn_bay
        '
        Me.btn_bay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_bay.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_bay.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_bay.DisplayText = "Reports"
        Me.btn_bay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_bay.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bay.ForeColor = System.Drawing.Color.Black
        Me.btn_bay.Image = CType(resources.GetObject("btn_bay.Image"), System.Drawing.Image)
        Me.btn_bay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_bay.Location = New System.Drawing.Point(265, 81)
        Me.btn_bay.Name = "btn_bay"
        Me.btn_bay.Size = New System.Drawing.Size(214, 47)
        Me.btn_bay.TabIndex = 6
        Me.btn_bay.TabStop = False
        Me.btn_bay.Text = "&Bay Setup"
        Me.btn_bay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_bay.UseVisualStyleBackColor = False
        '
        'btn_profile
        '
        Me.btn_profile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_profile.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_profile.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_profile.DisplayText = "CU System"
        Me.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_profile.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_profile.ForeColor = System.Drawing.Color.Black
        Me.btn_profile.Image = CType(resources.GetObject("btn_profile.Image"), System.Drawing.Image)
        Me.btn_profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_profile.Location = New System.Drawing.Point(33, 81)
        Me.btn_profile.Name = "btn_profile"
        Me.btn_profile.Size = New System.Drawing.Size(214, 47)
        Me.btn_profile.TabIndex = 3
        Me.btn_profile.TabStop = False
        Me.btn_profile.Text = "&Profile Setup"
        Me.btn_profile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_profile.UseVisualStyleBackColor = False
        '
        'admin_setup_mnu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(512, 304)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "admin_setup_mnu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin_setup_mnu"
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
            Case Keys.F8
                Call Process("BACK")

            Case Keys.B
                Call Process("B")

            Case Keys.G
                Call Process("G")

            Case Keys.M
                Call Process("M")

            Case Keys.P
                Call Process("P")

            Case Keys.R
                Call Process("R")

            Case Keys.S
                Call Process("S")
        End Select

        Select Case keyCode
            Case Keys.F4, Keys.F8, Keys.B, Keys.G, _
                 Keys.M, Keys.P, Keys.R, Keys.S
                Return True
        End Select
    End Function
#End Region

#Region " Button Events "
    Private Sub btn_settings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_settings.Click
        Call Process("M")
    End Sub

    Private Sub btn_guidelines_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guidelines.Click
        Call Process("G")
    End Sub

    Private Sub btn_profile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_profile.Click
        Call Process("P")
    End Sub

    Private Sub btn_bay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bay.Click
        Call Process("B")
    End Sub

    Private Sub btn_reports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reports.Click
        Call Process("R")
    End Sub

    Private Sub btn_service_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_service.Click
        Call Process("S")
    End Sub

    Private Sub btn_minimums_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_minimums.Click
        Call Process("O")
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Call Process("BACK")
    End Sub
#End Region

#Region " Close Form "
    Private Sub close_form()
        g_framework.g_forms(0).Show()
        g_framework.g_forms(1) = Nothing
        Me.Close()
    End Sub
#End Region

#Region " Form Activated "
    Private Sub Form_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        btn_back.Focus()
    End Sub
#End Region

#Region " Form GotFocus "
    Private Sub Form_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        btn_back.Focus()
    End Sub
#End Region

#Region " Form Load "
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call size_screen(Me)
    End Sub
#End Region

#Region " Process "
    Private Sub Process(ByVal p_type As String)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Refresh()

        Select Case UCase(p_type)
            Case "BACK"
                Call close_form()

            Case "M"
                g_framework.g_forms(2) = New settings(g_framework.g_db_name)
                g_framework.g_forms(2).MdiParent = g_mdi_form
                g_framework.g_forms(2).Show()

                g_framework.g_forms(1).Hide()

            Case "G"
                g_framework.g_forms(2) = New guideline_maint(g_framework.g_db_name)
                g_framework.g_forms(2).MdiParent = g_mdi_form
                g_framework.g_forms(2).Show()

                g_framework.g_forms(1).Hide()

            Case "O"
                g_framework.g_forms(2) = New minimum_overrides(g_framework.g_db_name)
                g_framework.g_forms(2).MdiParent = g_mdi_form
                g_framework.g_forms(2).Show()

                g_framework.g_forms(1).Hide()

            Case "P"
                g_framework.g_forms(2) = New profile_setup(g_framework.g_db_name)
                g_framework.g_forms(2).MdiParent = g_mdi_form
                g_framework.g_forms(2).Show()

                g_framework.g_forms(1).Hide()

            Case "B"
                g_framework.g_forms(2) = New bay_settings(g_framework.g_db_name, Me, 2)
                g_framework.g_forms(2).MdiParent = g_mdi_form
                g_framework.g_forms(2).Show()

                g_framework.g_forms(1).Hide()

            Case "R"
                g_framework.g_forms(2) = New admin_reports(g_framework.g_db_name, Me, 2)
                g_framework.g_forms(2).MdiParent = g_mdi_form
                g_framework.g_forms(2).Show()

                g_framework.g_forms(1).Hide()

            Case "S"
                g_framework.g_forms(2) = New services(g_framework.g_db_name, Me, 2)
                g_framework.g_forms(2).MdiParent = g_mdi_form
                g_framework.g_forms(2).Show()

                g_framework.g_forms(1).Hide()
        End Select

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
#End Region

End Class
