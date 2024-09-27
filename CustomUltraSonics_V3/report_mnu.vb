Public Class report_mnu
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
    Friend WithEvents btn_back As DBA.Library.DBA_Button
    Friend WithEvents btn_purge_history As DBA.Library.DBA_Button
    Friend WithEvents btn_process_info As DBA.Library.DBA_Button
    Friend WithEvents btn_shutdown As DBA.Library.DBA_Button
    Friend WithEvents btn_backup As DBA.Library.DBA_Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(report_mnu))
        Me.pnl_main = New DBA.Library.DBA_Panel
        Me.btn_backup = New DBA.Library.DBA_Button(Me.components)
        Me.btn_shutdown = New DBA.Library.DBA_Button(Me.components)
        Me.btn_purge_history = New DBA.Library.DBA_Button(Me.components)
        Me.btn_back = New DBA.Library.DBA_Button(Me.components)
        Me.lbl_info = New DBA.Library.DBA_Label(Me.components)
        Me.btn_process_info = New DBA.Library.DBA_Button(Me.components)
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_main
        '
        Me.pnl_main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_main.Controls.Add(Me.btn_backup)
        Me.pnl_main.Controls.Add(Me.btn_shutdown)
        Me.pnl_main.Controls.Add(Me.btn_purge_history)
        Me.pnl_main.Controls.Add(Me.btn_back)
        Me.pnl_main.Controls.Add(Me.lbl_info)
        Me.pnl_main.Controls.Add(Me.btn_process_info)
        Me.pnl_main.DataSettings.IDField = Nothing
        Me.pnl_main.DataSettings.JoinData = Nothing
        Me.pnl_main.DataSettings.LinkField = Nothing
        Me.pnl_main.DataSettings.TableName = Nothing
        Me.pnl_main.Gradient = False
        Me.pnl_main.Location = New System.Drawing.Point(0, 0)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.RecordID = Nothing
        Me.pnl_main.Saved = False
        Me.pnl_main.Size = New System.Drawing.Size(512, 347)
        Me.pnl_main.TabIndex = 1
        '
        'btn_backup
        '
        Me.btn_backup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_backup.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_backup.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_backup.DisplayText = "Guidelines"
        Me.btn_backup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_backup.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_backup.ForeColor = System.Drawing.Color.Black
        Me.btn_backup.Image = CType(resources.GetObject("btn_backup.Image"), System.Drawing.Image)
        Me.btn_backup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_backup.Location = New System.Drawing.Point(32, 129)
        Me.btn_backup.Name = "btn_backup"
        Me.btn_backup.Size = New System.Drawing.Size(204, 47)
        Me.btn_backup.TabIndex = 1
        Me.btn_backup.TabStop = False
        Me.btn_backup.Text = "&Backup Log"
        Me.btn_backup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_backup.UseVisualStyleBackColor = False
        '
        'btn_shutdown
        '
        Me.btn_shutdown.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_shutdown.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_shutdown.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_shutdown.DisplayText = "Guidelines"
        Me.btn_shutdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_shutdown.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_shutdown.ForeColor = System.Drawing.Color.Black
        Me.btn_shutdown.Image = CType(resources.GetObject("btn_shutdown.Image"), System.Drawing.Image)
        Me.btn_shutdown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_shutdown.Location = New System.Drawing.Point(272, 129)
        Me.btn_shutdown.Name = "btn_shutdown"
        Me.btn_shutdown.Size = New System.Drawing.Size(204, 47)
        Me.btn_shutdown.TabIndex = 4
        Me.btn_shutdown.TabStop = False
        Me.btn_shutdown.Text = "&Shutdown Log"
        Me.btn_shutdown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_shutdown.UseVisualStyleBackColor = False
        '
        'btn_purge_history
        '
        Me.btn_purge_history.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_purge_history.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_purge_history.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_purge_history.DisplayText = "Guidelines"
        Me.btn_purge_history.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_purge_history.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_purge_history.ForeColor = System.Drawing.Color.Black
        Me.btn_purge_history.Image = CType(resources.GetObject("btn_purge_history.Image"), System.Drawing.Image)
        Me.btn_purge_history.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_purge_history.Location = New System.Drawing.Point(272, 57)
        Me.btn_purge_history.Name = "btn_purge_history"
        Me.btn_purge_history.Size = New System.Drawing.Size(204, 47)
        Me.btn_purge_history.TabIndex = 3
        Me.btn_purge_history.TabStop = False
        Me.btn_purge_history.Text = "&Purge Log"
        Me.btn_purge_history.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_purge_history.UseVisualStyleBackColor = False
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
        Me.btn_back.Location = New System.Drawing.Point(167, 201)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(176, 47)
        Me.btn_back.TabIndex = 0
        Me.btn_back.TabStop = False
        Me.btn_back.Text = "Back"
        Me.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'lbl_info
        '
        Me.lbl_info.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_info.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_info.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info.ForeColor = System.Drawing.Color.Black
        Me.lbl_info.Location = New System.Drawing.Point(6, 270)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(500, 17)
        Me.lbl_info.TabIndex = 5
        Me.lbl_info.Text = "Use arrow/enter keys or press underlined letter to a select button."
        Me.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_info.UseMnemonic = False
        '
        'btn_process_info
        '
        Me.btn_process_info.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_process_info.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_process_info.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_process_info.DisplayText = "Setup"
        Me.btn_process_info.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_process_info.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_process_info.ForeColor = System.Drawing.Color.Black
        Me.btn_process_info.Image = CType(resources.GetObject("btn_process_info.Image"), System.Drawing.Image)
        Me.btn_process_info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_process_info.Location = New System.Drawing.Point(32, 57)
        Me.btn_process_info.Name = "btn_process_info"
        Me.btn_process_info.Size = New System.Drawing.Size(204, 47)
        Me.btn_process_info.TabIndex = 2
        Me.btn_process_info.TabStop = False
        Me.btn_process_info.Text = "Process &Info"
        Me.btn_process_info.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_process_info.UseVisualStyleBackColor = False
        '
        'report_mnu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(512, 347)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "report_mnu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "report_mnu"
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

            Case Keys.I
                Call Process("I")

            Case Keys.P
                Call Process("P")

            Case Keys.S
                Call Process("S")

            Case Keys.B
                Call Process("B")
        End Select

        Select Case keyCode
            Case Keys.F4, Keys.F8, Keys.I, Keys.P, Keys.S, Keys.B
                Return True
        End Select
    End Function
#End Region

#Region " Button Events "
    Private Sub btn_process_info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_process_info.Click
        Call Process("I")
    End Sub

    Private Sub btn_purge_history_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_purge_history.Click
        Call Process("P")
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Call Process("BACK")
    End Sub

    Private Sub btn_shutdown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_shutdown.Click
        Call Process("S")
    End Sub

    Private Sub btn_backup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_backup.Click
        Call Process("B")
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

            Case "I"
                g_framework.g_forms(2) = New reports(g_framework.g_db_name, Me, 2)
                g_framework.g_forms(2).MdiParent = g_mdi_form
                g_framework.g_forms(2).Show()

                g_framework.g_forms(1).Hide()

            Case "P"
                g_framework.g_forms(2) = New purge_history(g_framework.g_db_name, Me, 2)
                g_framework.g_forms(2).MdiParent = g_mdi_form
                g_framework.g_forms(2).Show()

                g_framework.g_forms(1).Hide()

            Case "S"
                g_framework.g_forms(2) = New shutdown_history(g_framework.g_db_name, Me, 2)
                g_framework.g_forms(2).MdiParent = g_mdi_form
                g_framework.g_forms(2).Show()

                g_framework.g_forms(1).Hide()

            Case "B"
                g_framework.g_forms(2) = New backup_view(g_framework.g_db_name, Me, 2)
                g_framework.g_forms(2).MdiParent = g_mdi_form
                g_framework.g_forms(2).Show()

                g_framework.g_forms(1).Hide()
        End Select

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
#End Region

End Class
