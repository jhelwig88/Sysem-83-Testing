Public Class data_entry_menu
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
    Friend WithEvents btn_detergents As DBA.Library.DBA_Button
    Friend WithEvents btn_instruments As DBA.Library.DBA_Button
    Friend WithEvents btn_physicians As DBA.Library.DBA_Button
    Friend WithEvents btn_liquid As DBA.Library.DBA_Button
    Friend WithEvents btn_back As DBA.Library.DBA_Button
    Friend WithEvents btn_patient As DBA.Library.DBA_Button
    Friend WithEvents btn_employees As DBA.Library.DBA_Button
    Friend WithEvents btn_users As DBA.Library.DBA_Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(data_entry_menu))
        Me.pnl_main = New DBA.Library.DBA_Panel
        Me.btn_users = New DBA.Library.DBA_Button(Me.components)
        Me.btn_employees = New DBA.Library.DBA_Button(Me.components)
        Me.btn_patient = New DBA.Library.DBA_Button(Me.components)
        Me.btn_back = New DBA.Library.DBA_Button(Me.components)
        Me.lbl_info = New DBA.Library.DBA_Label(Me.components)
        Me.btn_liquid = New DBA.Library.DBA_Button(Me.components)
        Me.btn_detergents = New DBA.Library.DBA_Button(Me.components)
        Me.btn_instruments = New DBA.Library.DBA_Button(Me.components)
        Me.btn_physicians = New DBA.Library.DBA_Button(Me.components)
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_main
        '
        Me.pnl_main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_main.Controls.Add(Me.btn_users)
        Me.pnl_main.Controls.Add(Me.btn_employees)
        Me.pnl_main.Controls.Add(Me.btn_patient)
        Me.pnl_main.Controls.Add(Me.btn_back)
        Me.pnl_main.Controls.Add(Me.lbl_info)
        Me.pnl_main.Controls.Add(Me.btn_liquid)
        Me.pnl_main.Controls.Add(Me.btn_detergents)
        Me.pnl_main.Controls.Add(Me.btn_instruments)
        Me.pnl_main.Controls.Add(Me.btn_physicians)
        Me.pnl_main.DataSettings.IDField = Nothing
        Me.pnl_main.DataSettings.JoinData = Nothing
        Me.pnl_main.DataSettings.LinkField = Nothing
        Me.pnl_main.DataSettings.TableName = Nothing
        Me.pnl_main.Gradient = False
        Me.pnl_main.Location = New System.Drawing.Point(0, 0)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.RecordID = Nothing
        Me.pnl_main.Saved = False
        Me.pnl_main.Size = New System.Drawing.Size(448, 304)
        Me.pnl_main.TabIndex = 0
        '
        'btn_users
        '
        Me.btn_users.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_users.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_users.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_users.DisplayText = "Users"
        Me.btn_users.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_users.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_users.ForeColor = System.Drawing.Color.Black
        Me.btn_users.Image = CType(resources.GetObject("btn_users.Image"), System.Drawing.Image)
        Me.btn_users.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_users.Location = New System.Drawing.Point(21, 199)
        Me.btn_users.Name = "btn_users"
        Me.btn_users.Size = New System.Drawing.Size(197, 47)
        Me.btn_users.TabIndex = 1
        Me.btn_users.TabStop = False
        Me.btn_users.Text = "&Users"
        Me.btn_users.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_users.UseVisualStyleBackColor = False
        '
        'btn_employees
        '
        Me.btn_employees.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_employees.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_employees.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_employees.DisplayText = "Employees"
        Me.btn_employees.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_employees.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_employees.ForeColor = System.Drawing.Color.Black
        Me.btn_employees.Image = CType(resources.GetObject("btn_employees.Image"), System.Drawing.Image)
        Me.btn_employees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_employees.Location = New System.Drawing.Point(234, 140)
        Me.btn_employees.Name = "btn_employees"
        Me.btn_employees.Size = New System.Drawing.Size(197, 47)
        Me.btn_employees.TabIndex = 7
        Me.btn_employees.TabStop = False
        Me.btn_employees.Text = "&Employees"
        Me.btn_employees.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_employees.UseVisualStyleBackColor = False
        '
        'btn_patient
        '
        Me.btn_patient.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_patient.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_patient.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_patient.DisplayText = "Patients"
        Me.btn_patient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_patient.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_patient.ForeColor = System.Drawing.Color.Black
        Me.btn_patient.Image = CType(resources.GetObject("btn_patient.Image"), System.Drawing.Image)
        Me.btn_patient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient.Location = New System.Drawing.Point(234, 24)
        Me.btn_patient.Name = "btn_patient"
        Me.btn_patient.Size = New System.Drawing.Size(197, 47)
        Me.btn_patient.TabIndex = 5
        Me.btn_patient.TabStop = False
        Me.btn_patient.Text = "P&atients"
        Me.btn_patient.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_patient.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_back.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_back.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_back.DisplayText = "Back"
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_back.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.Black
        Me.btn_back.Image = CType(resources.GetObject("btn_back.Image"), System.Drawing.Image)
        Me.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_back.Location = New System.Drawing.Point(234, 199)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(197, 47)
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
        Me.lbl_info.Location = New System.Drawing.Point(8, 268)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(433, 17)
        Me.lbl_info.TabIndex = 5
        Me.lbl_info.Text = "Use arrow/enter keys or press underlined letter to a select button."
        Me.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_info.UseMnemonic = False
        '
        'btn_liquid
        '
        Me.btn_liquid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_liquid.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_liquid.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_liquid.DisplayText = "Liquid Sterilant"
        Me.btn_liquid.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_liquid.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_liquid.ForeColor = System.Drawing.Color.Black
        Me.btn_liquid.Image = CType(resources.GetObject("btn_liquid.Image"), System.Drawing.Image)
        Me.btn_liquid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_liquid.Location = New System.Drawing.Point(234, 82)
        Me.btn_liquid.Name = "btn_liquid"
        Me.btn_liquid.Size = New System.Drawing.Size(197, 47)
        Me.btn_liquid.TabIndex = 6
        Me.btn_liquid.TabStop = False
        Me.btn_liquid.Text = "&Liquid Sterilant"
        Me.btn_liquid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_liquid.UseVisualStyleBackColor = False
        '
        'btn_detergents
        '
        Me.btn_detergents.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_detergents.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_detergents.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_detergents.DisplayText = "Detergents"
        Me.btn_detergents.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_detergents.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_detergents.ForeColor = System.Drawing.Color.Black
        Me.btn_detergents.Image = CType(resources.GetObject("btn_detergents.Image"), System.Drawing.Image)
        Me.btn_detergents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_detergents.Location = New System.Drawing.Point(21, 82)
        Me.btn_detergents.Name = "btn_detergents"
        Me.btn_detergents.Size = New System.Drawing.Size(197, 47)
        Me.btn_detergents.TabIndex = 3
        Me.btn_detergents.TabStop = False
        Me.btn_detergents.Text = "&Detergents"
        Me.btn_detergents.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_detergents.UseVisualStyleBackColor = False
        '
        'btn_instruments
        '
        Me.btn_instruments.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_instruments.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_instruments.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_instruments.DisplayText = "Instruments"
        Me.btn_instruments.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_instruments.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_instruments.ForeColor = System.Drawing.Color.Black
        Me.btn_instruments.Image = CType(resources.GetObject("btn_instruments.Image"), System.Drawing.Image)
        Me.btn_instruments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_instruments.Location = New System.Drawing.Point(21, 140)
        Me.btn_instruments.Name = "btn_instruments"
        Me.btn_instruments.Size = New System.Drawing.Size(197, 47)
        Me.btn_instruments.TabIndex = 2
        Me.btn_instruments.TabStop = False
        Me.btn_instruments.Text = "&Instruments"
        Me.btn_instruments.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_instruments.UseVisualStyleBackColor = False
        '
        'btn_physicians
        '
        Me.btn_physicians.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_physicians.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_physicians.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_physicians.DisplayText = "Physicians"
        Me.btn_physicians.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_physicians.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_physicians.ForeColor = System.Drawing.Color.Black
        Me.btn_physicians.Image = CType(resources.GetObject("btn_physicians.Image"), System.Drawing.Image)
        Me.btn_physicians.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_physicians.Location = New System.Drawing.Point(21, 24)
        Me.btn_physicians.Name = "btn_physicians"
        Me.btn_physicians.Size = New System.Drawing.Size(197, 47)
        Me.btn_physicians.TabIndex = 4
        Me.btn_physicians.TabStop = False
        Me.btn_physicians.Text = "&Physicians"
        Me.btn_physicians.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_physicians.UseVisualStyleBackColor = False
        '
        'data_entry_menu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(448, 304)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "data_entry_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "data_entry_menu"
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

            Case Keys.A
                Call Process("A")

            Case Keys.D
                Call Process("D")

            Case Keys.E
                Call Process("E")

            Case Keys.I
                Call Process("I")

            Case Keys.L
                Call Process("L")

            Case Keys.P
                Call Process("P")

            Case Keys.U
                Call Process("U")
        End Select

        Select Case keyCode
            Case Keys.F4, Keys.F8, Keys.A, Keys.D, Keys.E, _
                 Keys.I, Keys.L, Keys.P, Keys.U
                Return True
        End Select
    End Function
#End Region

#Region " Button Events "
    Private Sub btn_physicians_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_physicians.Click
        Call Process("P")
    End Sub

    Private Sub btn_patient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_patient.Click
        Call Process("A")
    End Sub

    Private Sub btn_instruments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_instruments.Click
        Call Process("I")
    End Sub

    Private Sub btn_detergents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_detergents.Click
        Call Process("D")
    End Sub

    Private Sub btn_liquid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_liquid.Click
        Call Process("L")
    End Sub

    Private Sub btn_employees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_employees.Click
        Call Process("E")
    End Sub

    Private Sub btn_users_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_users.Click
        Call Process("U")
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
        If Not (g_master Or g_admin) Then
            btn_employees.Visible = False
            btn_users.Visible = False

            btn_back.Top = btn_employees.Top
            lbl_info.Top = btn_employees.Top + 80
        End If

        Call size_screen(Me)
    End Sub
#End Region

#Region " Load Screen "
    Private Sub load_screen()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Refresh()

        g_framework.g_forms(2) = New de_maint(g_framework.g_db_name, Me, 2)
        g_framework.g_forms(2).MdiParent = g_mdi_form
        g_framework.g_forms(2).Show()

        Me.Hide()

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
#End Region

#Region " Process "
    Private Sub Process(ByVal p_type As String)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Refresh()

        Select Case UCase(p_type)
            Case "BACK"
                Call close_form()

            Case "A"
                g_framework.g_forms(2) = New patient(g_framework.g_db_name, g_framework.g_forms(1), 2)
                g_framework.g_forms(2).MdiParent = g_mdi_form
                g_framework.g_forms(2).Show()

                g_framework.g_forms(1).Hide()

            Case "D"
                g_pass_str = "DETERGENT"
                Call load_screen()

            Case "E"
                g_framework.g_forms(2) = New employee(g_framework.g_db_name)
                g_framework.g_forms(2).MdiParent = g_mdi_form
                g_framework.g_forms(2).Show()

                g_framework.g_forms(1).Hide()

            Case "I"
                g_pass_str = "INSTRUMENT"
                Call load_screen()

            Case "L"
                g_pass_str = "LIQUID"
                Call load_screen()

            Case "P"
                g_framework.g_forms(2) = New physician(g_framework.g_db_name, g_framework.g_forms(1), 2)
                g_framework.g_forms(2).MdiParent = g_mdi_form
                g_framework.g_forms(2).Show()

                g_framework.g_forms(1).Hide()

            Case "U"
                g_framework.g_forms(2) = New user_maint(g_framework.g_db_name)
                g_framework.g_forms(2).MdiParent = g_mdi_form
                g_framework.g_forms(2).Show()

                g_framework.g_forms(1).Hide()
        End Select

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
#End Region

End Class
