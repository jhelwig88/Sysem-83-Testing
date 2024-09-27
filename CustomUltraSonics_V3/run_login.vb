Public Class run_login
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
    Friend WithEvents btn_enter As DBA.Library.DBA_Button
    Friend WithEvents txt_password As DBA.Library.DBA_TextBox
    Friend WithEvents txt_username As DBA.Library.DBA_TextBox
    Friend WithEvents btn_cancel As DBA.Library.DBA_Button
    Friend WithEvents txt_disinfect_lot As DBA.Library.DBA_TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(run_login))
        Me.pnl_main = New DBA.Library.DBA_Panel
        Me.txt_disinfect_lot = New DBA.Library.DBA_TextBox
        Me.btn_cancel = New DBA.Library.DBA_Button(Me.components)
        Me.btn_enter = New DBA.Library.DBA_Button(Me.components)
        Me.txt_password = New DBA.Library.DBA_TextBox
        Me.txt_username = New DBA.Library.DBA_TextBox
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_main
        '
        Me.pnl_main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_main.Controls.Add(Me.txt_disinfect_lot)
        Me.pnl_main.Controls.Add(Me.btn_cancel)
        Me.pnl_main.Controls.Add(Me.btn_enter)
        Me.pnl_main.Controls.Add(Me.txt_password)
        Me.pnl_main.Controls.Add(Me.txt_username)
        Me.pnl_main.DataSettings.IDField = Nothing
        Me.pnl_main.DataSettings.JoinData = Nothing
        Me.pnl_main.DataSettings.LinkField = Nothing
        Me.pnl_main.DataSettings.TableName = Nothing
        Me.pnl_main.Gradient = False
        Me.pnl_main.Location = New System.Drawing.Point(0, 0)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.RecordID = Nothing
        Me.pnl_main.Saved = False
        Me.pnl_main.Size = New System.Drawing.Size(280, 107)
        Me.pnl_main.TabIndex = 0
        '
        'txt_disinfect_lot
        '
        Me.txt_disinfect_lot.AllowNegative = False
        Me.txt_disinfect_lot.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_disinfect_lot.ColorCursor = True
        Me.txt_disinfect_lot.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_disinfect_lot.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_disinfect_lot.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_disinfect_lot.Field_Name = ""
        Me.txt_disinfect_lot.GridBinding = Nothing
        Me.txt_disinfect_lot.Label_On_Top = False
        Me.txt_disinfect_lot.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_disinfect_lot.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_disinfect_lot.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_disinfect_lot.Label_Properties.Text = "Disinfect Lot #"
        Me.txt_disinfect_lot.Label_Properties.Width = 65
        Me.txt_disinfect_lot.Location = New System.Drawing.Point(11, 74)
        Me.txt_disinfect_lot.Mandatory = True
        Me.txt_disinfect_lot.Name = "txt_disinfect_lot"
        Me.txt_disinfect_lot.Override_Modified = False
        Me.txt_disinfect_lot.SaveLoadOrder = 0
        Me.txt_disinfect_lot.Size = New System.Drawing.Size(250, 26)
        Me.txt_disinfect_lot.TabIndex = 2
        Me.txt_disinfect_lot.TabStop = False
        Me.txt_disinfect_lot.Text = "DbA_TextBox2"
        Me.txt_disinfect_lot.TextBox_Properties.AcceptsReturn = False
        Me.txt_disinfect_lot.TextBox_Properties.AcceptsTab = False
        Me.txt_disinfect_lot.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_disinfect_lot.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_disinfect_lot.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_disinfect_lot.TextBox_Properties.Enabled = True
        Me.txt_disinfect_lot.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_disinfect_lot.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_disinfect_lot.TextBox_Properties.MaximumValue = 999999
        Me.txt_disinfect_lot.TextBox_Properties.MaxLength = 50
        Me.txt_disinfect_lot.TextBox_Properties.MinimumValue = -999999
        Me.txt_disinfect_lot.TextBox_Properties.MultiLine = False
        Me.txt_disinfect_lot.TextBox_Properties.PasswordChar = ""
        Me.txt_disinfect_lot.TextBox_Properties.ReadOnly = False
        Me.txt_disinfect_lot.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_disinfect_lot.TextBox_Properties.TabStop = True
        Me.txt_disinfect_lot.TextBox_Properties.Text = ""
        Me.txt_disinfect_lot.TextBox_Properties.WordWrap = True
        Me.txt_disinfect_lot.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        Me.txt_disinfect_lot.Visible = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_cancel.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.BTN_EXIT
        Me.btn_cancel.DisplayText = "Exit"
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(175, 72)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(83, 24)
        Me.btn_cancel.TabIndex = 4
        Me.btn_cancel.TabStop = False
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_enter
        '
        Me.btn_enter.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_enter.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.BTN_OPEN
        Me.btn_enter.DisplayText = "Open"
        Me.btn_enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_enter.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enter.ForeColor = System.Drawing.Color.Black
        Me.btn_enter.Image = CType(resources.GetObject("btn_enter.Image"), System.Drawing.Image)
        Me.btn_enter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_enter.Location = New System.Drawing.Point(79, 72)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(77, 24)
        Me.btn_enter.TabIndex = 3
        Me.btn_enter.TabStop = False
        Me.btn_enter.Text = "Enter"
        Me.btn_enter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_enter.UseVisualStyleBackColor = False
        '
        'txt_password
        '
        Me.txt_password.AllowNegative = False
        Me.txt_password.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_password.ColorCursor = True
        Me.txt_password.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_password.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_password.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_password.Field_Name = "password"
        Me.txt_password.GridBinding = Nothing
        Me.txt_password.Label_On_Top = False
        Me.txt_password.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_password.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_password.Label_Properties.Text = "Password"
        Me.txt_password.Label_Properties.Width = 65
        Me.txt_password.Location = New System.Drawing.Point(11, 42)
        Me.txt_password.Mandatory = True
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Override_Modified = False
        Me.txt_password.SaveLoadOrder = 0
        Me.txt_password.Size = New System.Drawing.Size(250, 26)
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
        Me.txt_username.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_username.ColorCursor = True
        Me.txt_username.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_username.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_username.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_username.Field_Name = "user_name"
        Me.txt_username.GridBinding = Nothing
        Me.txt_username.Label_On_Top = False
        Me.txt_username.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_username.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_username.Label_Properties.Text = "Username"
        Me.txt_username.Label_Properties.Width = 65
        Me.txt_username.Location = New System.Drawing.Point(11, 10)
        Me.txt_username.Mandatory = True
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Override_Modified = False
        Me.txt_username.SaveLoadOrder = 0
        Me.txt_username.Size = New System.Drawing.Size(250, 26)
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
        'run_login
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(280, 104)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_main)
        Me.Name = "run_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Run Login"
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

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        g_pass_str2 = ""
        g_pass_str3 = ""
        Me.Close()
    End Sub
#End Region

#Region " Form Activate "
    Private Sub Run_Login_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        txt_username.txtbox.Focus()
    End Sub
#End Region

#Region " Form Load "
    Private Sub Run_Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dba_init_form(pnl_main, False, Nothing)
        Me.dba_screen_state(pnl_main, DBA_Framework.DBA_Foundation_Class.SCREEN_BUTTON_MODE.Edit, DBA_Framework.DBA_Foundation_Class.ScreenLockMode.UNLOCK, False)

        btn_enter.TabStop = True
        btn_cancel.TabStop = True

        ' ----------------------
        ' * Set Screen For Purge
        ' ----------------------
        Select Case g_pass_str3
            Case "PURGE_ENG"
                Me.Height = 175

                txt_disinfect_lot.Visible = True

                btn_enter.Top = 105
                btn_cancel.Top = 105

                Me.Text = "Purge Login"

            Case "PURGE"
                Me.Text = "Purge Login"
        End Select

        ' --------------------------
        ' * Set Screen For Unloading
        ' --------------------------
        Select Case g_pass_str2
            Case "UNLOADING"
                g_pass_str2 = ""
                Me.Text = "Unloading Login"

            Case "SHUTDOWN"
                Me.Text = "Confirm Shutdown"
        End Select
    End Sub
#End Region

#Region " Validation "
    Private Sub Validation()
        ' ===========================================
        ' * Verify Username And Password Were Entered
        ' ===========================================
        If Trim(txt_username.TextBox_Properties.Text) = "" Then
            Call message_box("A username is required!", 1, "MISSING USERNAME")
            txt_username.txtbox.Focus()

            Exit Sub
        End If

        If Trim(txt_password.TextBox_Properties.Text) = "" Then
            Call message_box("A password is required!", 1, "MISSING PASSWORD")
            txt_password.txtbox.Focus()

            Exit Sub
        End If

        ' ----------------------------------------------------
        ' * Check That Disinfect Lot Entered - England Machine
        ' ----------------------------------------------------
        If g_pass_str3 = "PURGE_ENG" Then
            If Trim(txt_disinfect_lot.TextBox_Properties.Text) = "" Then
                Call message_box("New Disinfect Lot # must be entered.", 1, "Missing Disinfect Lot #")
                txt_password.txtbox.Focus()

                Exit Sub
            End If
        End If

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim p_sql As String                 ' String To Hold SQL Statement
        Dim p_dataset As DataSet            ' Create DataSet Reference
        Dim p_db_row As DataRow             ' Create DataRow Reference

        ' ==============================
        ' * Verify Username And Password
        ' ==============================
        Select Case UCase(Trim(txt_username.TextBox_Properties.Text))
            Case "CUS"
                If UCase(Trim(txt_password.TextBox_Properties.Text)) <> UCase(g_master_password) Then
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Call message_box("The username and password could not be verified!", 0)
                    txt_password.txtbox.Focus()

                    Exit Sub
                Else
                    ' Get Master User ID
                    p_sql = "SELECT user_id FROM Users WHERE master = 1"
                    p_dataset = g_framework.Get_Data(p_sql)

                    ' Set the row to temp row
                    p_db_row = p_dataset.Tables(0).Rows(0)

                    g_pass_str2 = p_db_row.Item("user_id").ToString ' Used Through Out System

                    ' Dipose Of Dataset
                    p_dataset.Dispose()
                End If

            Case Else
                p_sql = "SELECT user_id " & _
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

                g_pass_str2 = p_db_row.Item("user_id").ToString ' Used Through Out System

                ' Dipose Of Dataset
                p_dataset.Dispose()
        End Select

        ' --------------------
        ' * Set Value of Purge
        ' --------------------
        Select Case g_pass_str3
            Case "PURGE_ENG"
                ' Get New Disinfect Lot #
                g_pass_str3 = Trim(txt_disinfect_lot.TextBox_Properties.Text)

            Case "PURGE"
                g_pass_str3 = ""
        End Select

        Me.Cursor = System.Windows.Forms.Cursors.Default

        ' Close Screen
        Me.Close()
    End Sub
#End Region

#Region " Screen Object Events "
    Private Sub txt_password_TextBox_KeyPressed(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_password.TextBox_KeyPressed
        If Mid(g_pass_str3, 1, 5) = "PURGE" Then Exit Sub

        If e.KeyChar = Chr(13) Then
            e.Handled = True
            Call Validation()
        End If
    End Sub

    Private Sub txt_disinfect_lot_TextBox_KeyPressed(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_disinfect_lot.TextBox_KeyPressed
        If Mid(g_pass_str3, 1, 5) <> "PURGE" Then Exit Sub

        If e.KeyChar = Chr(13) Then
            e.Handled = True
            Call Validation()
        End If
    End Sub
#End Region

End Class
