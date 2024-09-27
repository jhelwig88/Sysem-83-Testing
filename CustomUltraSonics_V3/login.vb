Public Class login
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents txt_password As DBA.Library.DBA_TextBox
    Friend WithEvents txt_username As DBA.Library.DBA_TextBox
    Friend WithEvents lbl_Version As System.Windows.Forms.Label
    Friend WithEvents btn_enter As DBA.Library.DBA_Button
    Friend WithEvents ct_box As System.Windows.Forms.PictureBox
    Friend WithEvents pnl_main As DBA.Library.DBA_Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(login))
        Me.pnl_main = New DBA.Library.DBA_Panel
        Me.btn_enter = New DBA.Library.DBA_Button(Me.components)
        Me.ct_box = New System.Windows.Forms.PictureBox
        Me.txt_password = New DBA.Library.DBA_TextBox
        Me.txt_username = New DBA.Library.DBA_TextBox
        Me.lbl_Version = New System.Windows.Forms.Label
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_main
        '
        Me.pnl_main.BackColor = System.Drawing.Color.PapayaWhip
        Me.pnl_main.Controls.Add(Me.btn_enter)
        Me.pnl_main.Controls.Add(Me.ct_box)
        Me.pnl_main.Controls.Add(Me.txt_password)
        Me.pnl_main.Controls.Add(Me.txt_username)
        Me.pnl_main.Controls.Add(Me.lbl_Version)
        Me.pnl_main.DataSettings.IDField = Nothing
        Me.pnl_main.DataSettings.JoinData = Nothing
        Me.pnl_main.DataSettings.LinkField = Nothing
        Me.pnl_main.DataSettings.TableName = Nothing
        Me.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_main.Gradient = False
        Me.pnl_main.Location = New System.Drawing.Point(0, 0)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.RecordID = Nothing
        Me.pnl_main.Saved = False
        Me.pnl_main.Size = New System.Drawing.Size(452, 220)
        Me.pnl_main.TabIndex = 0
        '
        'btn_enter
        '
        Me.btn_enter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_enter.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_enter.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.BTN_OPEN
        Me.btn_enter.DisplayText = "Open"
        Me.btn_enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_enter.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enter.ForeColor = System.Drawing.Color.Black
        Me.btn_enter.Image = CType(resources.GetObject("btn_enter.Image"), System.Drawing.Image)
        Me.btn_enter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_enter.Location = New System.Drawing.Point(167, 187)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(83, 24)
        Me.btn_enter.TabIndex = 2
        Me.btn_enter.TabStop = False
        Me.btn_enter.Text = "Enter"
        Me.btn_enter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ct_box
        '
        Me.ct_box.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ct_box.BackColor = System.Drawing.Color.White
        Me.ct_box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ct_box.Image = CType(resources.GetObject("ct_box.Image"), System.Drawing.Image)
        Me.ct_box.Location = New System.Drawing.Point(92, 55)
        Me.ct_box.Name = "ct_box"
        Me.ct_box.Size = New System.Drawing.Size(257, 58)
        Me.ct_box.TabIndex = 29
        Me.ct_box.TabStop = False
        '
        'txt_password
        '
        Me.txt_password.AllowNegative = False
        Me.txt_password.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_password.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_password.ColorCursor = True
        Me.txt_password.ColorFocus = System.Drawing.Color.FromArgb(CType(239, Byte), CType(239, Byte), CType(239, Byte))
        Me.txt_password.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_password.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_password.Field_Name = "password"
        Me.txt_password.GridBinding = Nothing
        Me.txt_password.Label_On_Top = False
        Me.txt_password.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_password.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_password.Label_Properties.Text = "Password"
        Me.txt_password.Label_Properties.Width = 75
        Me.txt_password.Location = New System.Drawing.Point(90, 155)
        Me.txt_password.Mandatory = True
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Override_Modified = False
        Me.txt_password.SaveLoadOrder = 0
        Me.txt_password.Size = New System.Drawing.Size(250, 25)
        Me.txt_password.TabIndex = 1
        Me.txt_password.TabStop = False
        Me.txt_password.Text = "DbA_TextBox2"
        Me.txt_password.TextBox_Properties.AcceptsReturn = False
        Me.txt_password.TextBox_Properties.AcceptsTab = False
        Me.txt_password.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_password.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_password.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_password.TextBox_Properties.Enabled = True
        Me.txt_password.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_password.TextBox_Properties.MaximumValue = 999999
        Me.txt_password.TextBox_Properties.MaxLength = 50
        Me.txt_password.TextBox_Properties.MinimumValue = -999999
        Me.txt_password.TextBox_Properties.MultiLine = False
        Me.txt_password.TextBox_Properties.PasswordChar = "*"
        Me.txt_password.TextBox_Properties.ReadOnly = False
        Me.txt_password.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_password.TextBox_Properties.TabStop = True
        Me.txt_password.TextBox_Properties.Text = ""
        Me.txt_password.TextBox_Properties.WordWrap = True
        Me.txt_password.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_username
        '
        Me.txt_username.AllowNegative = False
        Me.txt_username.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_username.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_username.ColorCursor = True
        Me.txt_username.ColorFocus = System.Drawing.Color.FromArgb(CType(239, Byte), CType(239, Byte), CType(239, Byte))
        Me.txt_username.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_username.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_username.Field_Name = "user_name"
        Me.txt_username.GridBinding = Nothing
        Me.txt_username.Label_On_Top = False
        Me.txt_username.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_username.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_username.Label_Properties.Text = "Username"
        Me.txt_username.Label_Properties.Width = 75
        Me.txt_username.Location = New System.Drawing.Point(90, 125)
        Me.txt_username.Mandatory = True
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Override_Modified = False
        Me.txt_username.SaveLoadOrder = 0
        Me.txt_username.Size = New System.Drawing.Size(250, 25)
        Me.txt_username.TabIndex = 0
        Me.txt_username.TabStop = False
        Me.txt_username.Text = "DbA_TextBox1"
        Me.txt_username.TextBox_Properties.AcceptsReturn = False
        Me.txt_username.TextBox_Properties.AcceptsTab = False
        Me.txt_username.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_username.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_username.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_username.TextBox_Properties.Enabled = True
        Me.txt_username.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_username.TextBox_Properties.MaximumValue = 999999
        Me.txt_username.TextBox_Properties.MaxLength = 50
        Me.txt_username.TextBox_Properties.MinimumValue = -999999
        Me.txt_username.TextBox_Properties.MultiLine = False
        Me.txt_username.TextBox_Properties.PasswordChar = Nothing
        Me.txt_username.TextBox_Properties.ReadOnly = False
        Me.txt_username.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_username.TextBox_Properties.TabStop = True
        Me.txt_username.TextBox_Properties.Text = ""
        Me.txt_username.TextBox_Properties.WordWrap = True
        Me.txt_username.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'lbl_Version
        '
        Me.lbl_Version.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_Version.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Version.Location = New System.Drawing.Point(15, 8)
        Me.lbl_Version.Name = "lbl_Version"
        Me.lbl_Version.Size = New System.Drawing.Size(419, 36)
        Me.lbl_Version.TabIndex = 19
        Me.lbl_Version.Text = "CU System for Hospitals"
        Me.lbl_Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'login
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(452, 220)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.Text = "Login"
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

        Select Case keyCode
            Case Keys.F4
                Return True
        End Select
    End Function
#End Region

#Region " Button Events "
    Private Sub btn_enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enter.Click
        ' ---------------------
        ' * Valid Password Info
        ' ---------------------
        Call Validation()
    End Sub
#End Region

#Region " Form Activate "
    Private Sub login_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.Location = New System.Drawing.Point(0, 0)
        txt_username.txtbox.Focus()
    End Sub
#End Region

#Region " Form Load "
    Private Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim p_excludes(0) As dba_RemoveControls
        p_excludes(0).Control = Me.lbl_Version

        dba_init_form(pnl_main, False, p_excludes)
        Me.dba_screen_state(pnl_main, DBA_Framework.DBA_Foundation_Class.SCREEN_BUTTON_MODE.Edit, DBA_Framework.DBA_Foundation_Class.ScreenLockMode.UNLOCK, False)

        Call size_screen(Me)
        btn_enter.TabStop = True

        ' Set Title
        lbl_Version.Text = "CU Systems for Hospitals"
    End Sub
#End Region

#Region " Validation "
    Private Sub Validation()
        ' ===========================================
        ' * Verify Username And Password Were Entered
        ' ===========================================
        If Trim(txt_username.Text) = "" Then
            Call message_box("A username is required!", 1, "MISSING USERNAME")
            txt_username.txtbox.Focus()

            Exit Sub
        End If

        If Trim(txt_password.Text) = "" Then
            Call message_box("A password is required!", 1, "MISSING PASSWORD")
            txt_password.txtbox.Focus()

            Exit Sub
        End If

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim p_sql As String                 ' String To Hold SQL Statement
        Dim p_dataset As DataSet            ' Create DataSet Reference
        Dim p_db_row As DataRow             ' Create DataRow Reference

        ' Set Flags
        g_admin = False
        g_master = False

        ' ==============================
        ' * Verify Username And Password
        ' ==============================
        Select Case UCase(g_login_as)
            Case "CU"
                Select Case UCase(Trim(txt_username.TextBox_Properties.Text))
                    Case "CUS"
                        If UCase(Trim(txt_password.TextBox_Properties.Text)) <> UCase(g_master_password) Then
                            Me.Cursor = System.Windows.Forms.Cursors.Default
                            Call message_box("The username and password could not be verified!", 0)
                            txt_password.txtbox.Focus()

                            Exit Sub
                        Else
                            ' Get Master ID
                            p_sql = "SELECT user_id FROM Users WHERE master = 1"
                            p_dataset = g_framework.Get_Data(p_sql)

                            ' Set the row to temp row
                            p_db_row = p_dataset.Tables(0).Rows(0)

                            g_framework.g_user_id = p_db_row.Item("user_id").ToString ' Used Through Out System
                            g_master = True

                            ' Dipose Of Dataset
                            p_dataset.Dispose()
                        End If

                    Case Else
                        p_sql = "SELECT user_id, administrator " & _
                                "FROM Users " & _
                                "WHERE user_name = " & return_parsed_single_quote_string(Trim(txt_username.TextBox_Properties.Text)) & " " & _
                                " AND password = " & return_parsed_single_quote_string(Trim(txt_password.TextBox_Properties.Text)) & _
                                " AND inactive = 0"

                        ' Get Dataset
                        p_dataset = g_framework.Get_Data(p_sql)

                        If p_dataset.Tables(0).Rows.Count = 0 Then
                            Me.Cursor = System.Windows.Forms.Cursors.Default
                            Call message_box("The username and password could not be verified!", 0)
                            txt_password.txtbox.Focus()

                            ' Dipose Of Dataset
                            p_dataset.Dispose()

                            Exit Sub
                        End If

                        ' Set the row to temp row
                        p_db_row = p_dataset.Tables(0).Rows(0)

                        g_framework.g_user_id = p_db_row.Item("user_id").ToString ' Used Through Out System
                        g_admin = p_db_row.Item("administrator") ' Check Rights
                        g_master = False

                        ' Dipose Of Dataset
                        p_dataset.Dispose()
                End Select

            Case "DBA"
                ' Get Master ID
                p_sql = "SELECT user_id FROM Users WHERE master = 1"
                p_dataset = g_framework.Get_Data(p_sql)

                ' Set the row to temp row
                p_db_row = p_dataset.Tables(0).Rows(0)

                g_framework.g_user_id = p_db_row.Item("user_id").ToString ' Used Through Out System
                g_master = True

                ' Dipose Of Dataset
                p_dataset.Dispose()
        End Select

        ' -------------------
        ' * Update Last Login
        ' -------------------
        g_framework.Execute_Query("Update Users Set last_login = getdate() Where user_id = '" & g_framework.g_user_id & "'")

        'Reset the password/username fields
        txt_password.TextBox_Properties.Text = ""
        txt_username.TextBox_Properties.Text = ""

        ' ----------------
        ' * Load Main Menu
        ' ----------------
        g_framework.g_forms(0) = Nothing

        g_framework.g_forms(0) = New main_menu(g_framework.g_db_name)
        g_framework.g_forms(0).MdiParent = g_mdi_form

        g_framework.g_forms(0).Show()

        ' ------------
        ' * Hide Login
        ' ------------
        g_login.Hide()
    End Sub
#End Region

#Region " Screen Object Events "
    Private Sub txt_password_TextBox_KeyPressed(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_password.TextBox_KeyPressed
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            Call Validation()
        End If
    End Sub
#End Region

End Class