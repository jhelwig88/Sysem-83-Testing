Public Class settings
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
    Friend WithEvents btn_save As DBA.Library.DBA_Button
    Friend WithEvents btn_close As DBA.Library.DBA_Button
    Friend WithEvents lbl_info As DBA.Library.DBA_Label
    Friend WithEvents chk_demo_mode As DBA.Library.DBA_CheckBox
    Friend WithEvents btn_cancel As DBA.Library.DBA_Button
    Friend WithEvents txt_organization As DBA.Library.DBA_TextBox
    Friend WithEvents txt_scr_saver As DBA.Library.DBA_TextBox
    Friend WithEvents txt_systems As DBA.Library.DBA_TextBox
    Friend WithEvents txt_max_instrument As DBA.Library.DBA_TextBox
    Friend WithEvents pnl_info As DBA.Library.DBA_Panel
    Friend WithEvents chk_ss_disable As DBA.Library.DBA_CheckBox
    Friend WithEvents txt_back_dl As DBA.Library.DBA_TextBox
    Friend WithEvents txt_back_bl As DBA.Library.DBA_TextBox
    Friend WithEvents txt_back_bt As DBA.Library.DBA_TextBox
    Friend WithEvents chk_back_cd As DBA.Library.DBA_CheckBox
    Friend WithEvents lbl_bt As System.Windows.Forms.Label
    Friend WithEvents lbl_dl As System.Windows.Forms.Label
    Friend WithEvents chk_england As DBA.Library.DBA_CheckBox
    Friend WithEvents chk_hide_F7 As DBA.Library.DBA_CheckBox
    Friend WithEvents chk_hide_F1 As DBA.Library.DBA_CheckBox
    Friend WithEvents chk_file_output As DBA.Library.DBA_CheckBox
    Friend WithEvents lbl_F7 As DBA.Library.DBA_Label
    Friend WithEvents lbl_F5 As DBA.Library.DBA_Label
    Friend WithEvents txt_file_output_path As DBA.Library.DBA_TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings))
        Me.pnl_main = New DBA.Library.DBA_Panel
        Me.lbl_F7 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_F5 = New DBA.Library.DBA_Label(Me.components)
        Me.pnl_info = New DBA.Library.DBA_Panel
        Me.txt_file_output_path = New DBA.Library.DBA_TextBox
        Me.chk_file_output = New DBA.Library.DBA_CheckBox
        Me.chk_hide_F1 = New DBA.Library.DBA_CheckBox
        Me.chk_hide_F7 = New DBA.Library.DBA_CheckBox
        Me.chk_england = New DBA.Library.DBA_CheckBox
        Me.lbl_bt = New System.Windows.Forms.Label
        Me.lbl_dl = New System.Windows.Forms.Label
        Me.chk_back_cd = New DBA.Library.DBA_CheckBox
        Me.txt_back_bt = New DBA.Library.DBA_TextBox
        Me.txt_back_bl = New DBA.Library.DBA_TextBox
        Me.txt_back_dl = New DBA.Library.DBA_TextBox
        Me.chk_ss_disable = New DBA.Library.DBA_CheckBox
        Me.txt_systems = New DBA.Library.DBA_TextBox
        Me.chk_demo_mode = New DBA.Library.DBA_CheckBox
        Me.txt_organization = New DBA.Library.DBA_TextBox
        Me.txt_max_instrument = New DBA.Library.DBA_TextBox
        Me.txt_scr_saver = New DBA.Library.DBA_TextBox
        Me.btn_cancel = New DBA.Library.DBA_Button(Me.components)
        Me.lbl_info = New DBA.Library.DBA_Label(Me.components)
        Me.btn_save = New DBA.Library.DBA_Button(Me.components)
        Me.btn_close = New DBA.Library.DBA_Button(Me.components)
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_main.SuspendLayout()
        Me.pnl_info.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_main
        '
        Me.pnl_main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_main.Controls.Add(Me.lbl_F7)
        Me.pnl_main.Controls.Add(Me.lbl_F5)
        Me.pnl_main.Controls.Add(Me.pnl_info)
        Me.pnl_main.Controls.Add(Me.btn_cancel)
        Me.pnl_main.Controls.Add(Me.lbl_info)
        Me.pnl_main.Controls.Add(Me.btn_save)
        Me.pnl_main.Controls.Add(Me.btn_close)
        Me.pnl_main.DataSettings.IDField = "settings_id"
        Me.pnl_main.DataSettings.JoinData = Nothing
        Me.pnl_main.DataSettings.LinkField = Nothing
        Me.pnl_main.DataSettings.TableName = "settings_maint"
        Me.pnl_main.Gradient = False
        Me.pnl_main.Location = New System.Drawing.Point(0, 0)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.RecordID = Nothing
        Me.pnl_main.Saved = False
        Me.pnl_main.Size = New System.Drawing.Size(750, 553)
        Me.pnl_main.TabIndex = 0
        '
        'lbl_F7
        '
        Me.lbl_F7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_F7.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_F7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_F7.ForeColor = System.Drawing.Color.Black
        Me.lbl_F7.Location = New System.Drawing.Point(581, 37)
        Me.lbl_F7.Name = "lbl_F7"
        Me.lbl_F7.Size = New System.Drawing.Size(120, 17)
        Me.lbl_F7.TabIndex = 36
        Me.lbl_F7.Text = "F7 - Hide Taskbar"
        Me.lbl_F7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_F7.UseMnemonic = False
        '
        'lbl_F5
        '
        Me.lbl_F5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_F5.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_F5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_F5.ForeColor = System.Drawing.Color.Black
        Me.lbl_F5.Location = New System.Drawing.Point(581, 17)
        Me.lbl_F5.Name = "lbl_F5"
        Me.lbl_F5.Size = New System.Drawing.Size(120, 17)
        Me.lbl_F5.TabIndex = 35
        Me.lbl_F5.Text = "F5 - Show Taskbar"
        Me.lbl_F5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_F5.UseMnemonic = False
        '
        'pnl_info
        '
        Me.pnl_info.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnl_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_info.Controls.Add(Me.txt_file_output_path)
        Me.pnl_info.Controls.Add(Me.chk_file_output)
        Me.pnl_info.Controls.Add(Me.chk_hide_F1)
        Me.pnl_info.Controls.Add(Me.chk_hide_F7)
        Me.pnl_info.Controls.Add(Me.chk_england)
        Me.pnl_info.Controls.Add(Me.lbl_bt)
        Me.pnl_info.Controls.Add(Me.lbl_dl)
        Me.pnl_info.Controls.Add(Me.chk_back_cd)
        Me.pnl_info.Controls.Add(Me.txt_back_bt)
        Me.pnl_info.Controls.Add(Me.txt_back_bl)
        Me.pnl_info.Controls.Add(Me.txt_back_dl)
        Me.pnl_info.Controls.Add(Me.chk_ss_disable)
        Me.pnl_info.Controls.Add(Me.txt_systems)
        Me.pnl_info.Controls.Add(Me.chk_demo_mode)
        Me.pnl_info.Controls.Add(Me.txt_organization)
        Me.pnl_info.Controls.Add(Me.txt_max_instrument)
        Me.pnl_info.Controls.Add(Me.txt_scr_saver)
        Me.pnl_info.DataSettings.IDField = Nothing
        Me.pnl_info.DataSettings.JoinData = Nothing
        Me.pnl_info.DataSettings.LinkField = Nothing
        Me.pnl_info.DataSettings.TableName = Nothing
        Me.pnl_info.Gradient = False
        Me.pnl_info.Location = New System.Drawing.Point(49, 72)
        Me.pnl_info.Name = "pnl_info"
        Me.pnl_info.RecordID = Nothing
        Me.pnl_info.Saved = False
        Me.pnl_info.Size = New System.Drawing.Size(655, 375)
        Me.pnl_info.TabIndex = 0
        '
        'txt_file_output_path
        '
        Me.txt_file_output_path.AllowNegative = False
        Me.txt_file_output_path.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_file_output_path.ColorCursor = True
        Me.txt_file_output_path.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_file_output_path.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_file_output_path.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_file_output_path.Field_Name = "file_output_path"
        Me.txt_file_output_path.GridBinding = Nothing
        Me.txt_file_output_path.Label_On_Top = False
        Me.txt_file_output_path.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_file_output_path.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_file_output_path.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_file_output_path.Label_Properties.Text = "File Output Path"
        Me.txt_file_output_path.Label_Properties.Width = 120
        Me.txt_file_output_path.Location = New System.Drawing.Point(86, 330)
        Me.txt_file_output_path.Mandatory = False
        Me.txt_file_output_path.Name = "txt_file_output_path"
        Me.txt_file_output_path.Override_Modified = False
        Me.txt_file_output_path.SaveLoadOrder = 0
        Me.txt_file_output_path.Size = New System.Drawing.Size(376, 26)
        Me.txt_file_output_path.TabIndex = 14
        Me.txt_file_output_path.TabStop = False
        Me.txt_file_output_path.Text = "DbA_TextBox2"
        Me.txt_file_output_path.TextBox_Properties.AcceptsReturn = False
        Me.txt_file_output_path.TextBox_Properties.AcceptsTab = False
        Me.txt_file_output_path.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_file_output_path.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_file_output_path.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_file_output_path.TextBox_Properties.Enabled = True
        Me.txt_file_output_path.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_file_output_path.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_file_output_path.TextBox_Properties.MaximumValue = 999999
        Me.txt_file_output_path.TextBox_Properties.MaxLength = 50
        Me.txt_file_output_path.TextBox_Properties.MinimumValue = -999999
        Me.txt_file_output_path.TextBox_Properties.MultiLine = False
        Me.txt_file_output_path.TextBox_Properties.PasswordChar = Nothing
        Me.txt_file_output_path.TextBox_Properties.ReadOnly = False
        Me.txt_file_output_path.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_file_output_path.TextBox_Properties.TabStop = True
        Me.txt_file_output_path.TextBox_Properties.Text = ""
        Me.txt_file_output_path.TextBox_Properties.WordWrap = True
        Me.txt_file_output_path.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'chk_file_output
        '
        Me.chk_file_output.BackColor = System.Drawing.Color.PapayaWhip
        Me.chk_file_output.Caption = "Enable Process File Output"
        Me.chk_file_output.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chk_file_output.Field_Name = "enable_file_output"
        Me.chk_file_output.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_file_output.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chk_file_output.ForeColor = System.Drawing.Color.Black
        Me.chk_file_output.GridBinding = Nothing
        Me.chk_file_output.Location = New System.Drawing.Point(37, 308)
        Me.chk_file_output.Mandatory = False
        Me.chk_file_output.Name = "chk_file_output"
        Me.chk_file_output.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_file_output.SaveLoadOrder = 0
        Me.chk_file_output.Size = New System.Drawing.Size(182, 24)
        Me.chk_file_output.TabIndex = 13
        Me.chk_file_output.Text = "Enable Process File Output"
        Me.chk_file_output.UseVisualStyleBackColor = False
        '
        'chk_hide_F1
        '
        Me.chk_hide_F1.BackColor = System.Drawing.Color.PapayaWhip
        Me.chk_hide_F1.Caption = "Override Patient/Instrument Entry"
        Me.chk_hide_F1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chk_hide_F1.Field_Name = "override_patient_entry"
        Me.chk_hide_F1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_hide_F1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chk_hide_F1.ForeColor = System.Drawing.Color.Black
        Me.chk_hide_F1.GridBinding = Nothing
        Me.chk_hide_F1.Location = New System.Drawing.Point(255, 58)
        Me.chk_hide_F1.Mandatory = False
        Me.chk_hide_F1.Name = "chk_hide_F1"
        Me.chk_hide_F1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_hide_F1.SaveLoadOrder = 0
        Me.chk_hide_F1.Size = New System.Drawing.Size(225, 24)
        Me.chk_hide_F1.TabIndex = 4
        Me.chk_hide_F1.Text = "Override Patient/Instrument Entry"
        Me.chk_hide_F1.UseVisualStyleBackColor = False
        '
        'chk_hide_F7
        '
        Me.chk_hide_F7.BackColor = System.Drawing.Color.PapayaWhip
        Me.chk_hide_F7.Caption = "Hide F7 Button"
        Me.chk_hide_F7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chk_hide_F7.Field_Name = "hide_F7"
        Me.chk_hide_F7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_hide_F7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chk_hide_F7.ForeColor = System.Drawing.Color.Black
        Me.chk_hide_F7.GridBinding = Nothing
        Me.chk_hide_F7.Location = New System.Drawing.Point(358, 35)
        Me.chk_hide_F7.Mandatory = False
        Me.chk_hide_F7.Name = "chk_hide_F7"
        Me.chk_hide_F7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_hide_F7.SaveLoadOrder = 0
        Me.chk_hide_F7.Size = New System.Drawing.Size(122, 24)
        Me.chk_hide_F7.TabIndex = 3
        Me.chk_hide_F7.Text = "Hide F7 Button"
        Me.chk_hide_F7.UseVisualStyleBackColor = False
        '
        'chk_england
        '
        Me.chk_england.BackColor = System.Drawing.Color.PapayaWhip
        Me.chk_england.Caption = "England Machine"
        Me.chk_england.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chk_england.Field_Name = "england_settings"
        Me.chk_england.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_england.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chk_england.ForeColor = System.Drawing.Color.Black
        Me.chk_england.GridBinding = Nothing
        Me.chk_england.Location = New System.Drawing.Point(358, 11)
        Me.chk_england.Mandatory = False
        Me.chk_england.Name = "chk_england"
        Me.chk_england.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_england.SaveLoadOrder = 0
        Me.chk_england.Size = New System.Drawing.Size(122, 24)
        Me.chk_england.TabIndex = 2
        Me.chk_england.Text = "England Machine"
        Me.chk_england.UseVisualStyleBackColor = False
        '
        'lbl_bt
        '
        Me.lbl_bt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bt.Location = New System.Drawing.Point(280, 251)
        Me.lbl_bt.Name = "lbl_bt"
        Me.lbl_bt.Size = New System.Drawing.Size(144, 17)
        Me.lbl_bt.TabIndex = 12
        Me.lbl_bt.Text = "ex. 10:00 pm or 1:00 am"
        '
        'lbl_dl
        '
        Me.lbl_dl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dl.Location = New System.Drawing.Point(280, 227)
        Me.lbl_dl.Name = "lbl_dl"
        Me.lbl_dl.Size = New System.Drawing.Size(76, 17)
        Me.lbl_dl.TabIndex = 13
        Me.lbl_dl.Text = "ex. D or E"
        '
        'chk_back_cd
        '
        Me.chk_back_cd.BackColor = System.Drawing.Color.PapayaWhip
        Me.chk_back_cd.Caption = "Backup to CD"
        Me.chk_back_cd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chk_back_cd.Field_Name = "back_cdrom"
        Me.chk_back_cd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_back_cd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chk_back_cd.ForeColor = System.Drawing.Color.Black
        Me.chk_back_cd.GridBinding = Nothing
        Me.chk_back_cd.Location = New System.Drawing.Point(61, 199)
        Me.chk_back_cd.Mandatory = False
        Me.chk_back_cd.Name = "chk_back_cd"
        Me.chk_back_cd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_back_cd.SaveLoadOrder = 0
        Me.chk_back_cd.Size = New System.Drawing.Size(158, 24)
        Me.chk_back_cd.TabIndex = 9
        Me.chk_back_cd.Text = "Backup to Local Drive"
        Me.chk_back_cd.UseVisualStyleBackColor = False
        '
        'txt_back_bt
        '
        Me.txt_back_bt.AllowNegative = False
        Me.txt_back_bt.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_back_bt.ColorCursor = True
        Me.txt_back_bt.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_back_bt.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_back_bt.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_back_bt.Field_Name = "back_time"
        Me.txt_back_bt.GridBinding = Nothing
        Me.txt_back_bt.Label_On_Top = False
        Me.txt_back_bt.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_back_bt.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_back_bt.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_back_bt.Label_Properties.Text = "Backup Delay Time"
        Me.txt_back_bt.Label_Properties.Width = 120
        Me.txt_back_bt.Location = New System.Drawing.Point(86, 246)
        Me.txt_back_bt.Mandatory = True
        Me.txt_back_bt.Name = "txt_back_bt"
        Me.txt_back_bt.Override_Modified = False
        Me.txt_back_bt.SaveLoadOrder = 0
        Me.txt_back_bt.Size = New System.Drawing.Size(184, 26)
        Me.txt_back_bt.TabIndex = 11
        Me.txt_back_bt.TabStop = False
        Me.txt_back_bt.Text = "DbA_TextBox3"
        Me.txt_back_bt.TextBox_Properties.AcceptsReturn = False
        Me.txt_back_bt.TextBox_Properties.AcceptsTab = False
        Me.txt_back_bt.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_back_bt.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_back_bt.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_back_bt.TextBox_Properties.Enabled = True
        Me.txt_back_bt.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_back_bt.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_back_bt.TextBox_Properties.MaximumValue = 999999
        Me.txt_back_bt.TextBox_Properties.MaxLength = 8
        Me.txt_back_bt.TextBox_Properties.MinimumValue = -999999
        Me.txt_back_bt.TextBox_Properties.MultiLine = False
        Me.txt_back_bt.TextBox_Properties.PasswordChar = Nothing
        Me.txt_back_bt.TextBox_Properties.ReadOnly = False
        Me.txt_back_bt.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_back_bt.TextBox_Properties.TabStop = True
        Me.txt_back_bt.TextBox_Properties.Text = ""
        Me.txt_back_bt.TextBox_Properties.WordWrap = True
        Me.txt_back_bt.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_back_bl
        '
        Me.txt_back_bl.AllowNegative = False
        Me.txt_back_bl.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_back_bl.ColorCursor = True
        Me.txt_back_bl.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_back_bl.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_back_bl.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_back_bl.Field_Name = "back_location"
        Me.txt_back_bl.GridBinding = Nothing
        Me.txt_back_bl.Label_On_Top = False
        Me.txt_back_bl.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_back_bl.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_back_bl.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_back_bl.Label_Properties.Text = "Backup Network Path"
        Me.txt_back_bl.Label_Properties.Width = 135
        Me.txt_back_bl.Location = New System.Drawing.Point(71, 270)
        Me.txt_back_bl.Mandatory = False
        Me.txt_back_bl.Name = "txt_back_bl"
        Me.txt_back_bl.Override_Modified = False
        Me.txt_back_bl.SaveLoadOrder = 0
        Me.txt_back_bl.Size = New System.Drawing.Size(391, 26)
        Me.txt_back_bl.TabIndex = 12
        Me.txt_back_bl.TabStop = False
        Me.txt_back_bl.Text = "DbA_TextBox2"
        Me.txt_back_bl.TextBox_Properties.AcceptsReturn = False
        Me.txt_back_bl.TextBox_Properties.AcceptsTab = False
        Me.txt_back_bl.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_back_bl.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_back_bl.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_back_bl.TextBox_Properties.Enabled = True
        Me.txt_back_bl.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_back_bl.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_back_bl.TextBox_Properties.MaximumValue = 999999
        Me.txt_back_bl.TextBox_Properties.MaxLength = 50
        Me.txt_back_bl.TextBox_Properties.MinimumValue = -999999
        Me.txt_back_bl.TextBox_Properties.MultiLine = False
        Me.txt_back_bl.TextBox_Properties.PasswordChar = Nothing
        Me.txt_back_bl.TextBox_Properties.ReadOnly = False
        Me.txt_back_bl.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_back_bl.TextBox_Properties.TabStop = True
        Me.txt_back_bl.TextBox_Properties.Text = ""
        Me.txt_back_bl.TextBox_Properties.WordWrap = True
        Me.txt_back_bl.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_back_dl
        '
        Me.txt_back_dl.AllowNegative = False
        Me.txt_back_dl.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_back_dl.ColorCursor = True
        Me.txt_back_dl.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_back_dl.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_back_dl.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_back_dl.Field_Name = "backup_drive_letter"
        Me.txt_back_dl.GridBinding = Nothing
        Me.txt_back_dl.Label_On_Top = False
        Me.txt_back_dl.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_back_dl.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_back_dl.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_back_dl.Label_Properties.Text = "Local Drive Letter"
        Me.txt_back_dl.Label_Properties.Width = 145
        Me.txt_back_dl.Location = New System.Drawing.Point(61, 222)
        Me.txt_back_dl.Mandatory = True
        Me.txt_back_dl.Name = "txt_back_dl"
        Me.txt_back_dl.Override_Modified = False
        Me.txt_back_dl.SaveLoadOrder = 0
        Me.txt_back_dl.Size = New System.Drawing.Size(209, 26)
        Me.txt_back_dl.TabIndex = 10
        Me.txt_back_dl.TabStop = False
        Me.txt_back_dl.Text = "DbA_TextBox2"
        Me.txt_back_dl.TextBox_Properties.AcceptsReturn = False
        Me.txt_back_dl.TextBox_Properties.AcceptsTab = False
        Me.txt_back_dl.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_back_dl.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_back_dl.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_back_dl.TextBox_Properties.Enabled = True
        Me.txt_back_dl.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_back_dl.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_back_dl.TextBox_Properties.MaximumValue = 999999
        Me.txt_back_dl.TextBox_Properties.MaxLength = 1
        Me.txt_back_dl.TextBox_Properties.MinimumValue = -999999
        Me.txt_back_dl.TextBox_Properties.MultiLine = False
        Me.txt_back_dl.TextBox_Properties.PasswordChar = Nothing
        Me.txt_back_dl.TextBox_Properties.ReadOnly = False
        Me.txt_back_dl.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_back_dl.TextBox_Properties.TabStop = True
        Me.txt_back_dl.TextBox_Properties.Text = ""
        Me.txt_back_dl.TextBox_Properties.WordWrap = True
        Me.txt_back_dl.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'chk_ss_disable
        '
        Me.chk_ss_disable.BackColor = System.Drawing.Color.PapayaWhip
        Me.chk_ss_disable.Caption = "Disable Screen Saver"
        Me.chk_ss_disable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chk_ss_disable.Field_Name = "ss_disable"
        Me.chk_ss_disable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_ss_disable.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chk_ss_disable.ForeColor = System.Drawing.Color.Black
        Me.chk_ss_disable.GridBinding = Nothing
        Me.chk_ss_disable.Location = New System.Drawing.Point(49, 35)
        Me.chk_ss_disable.Mandatory = False
        Me.chk_ss_disable.Name = "chk_ss_disable"
        Me.chk_ss_disable.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_ss_disable.SaveLoadOrder = 0
        Me.chk_ss_disable.Size = New System.Drawing.Size(170, 24)
        Me.chk_ss_disable.TabIndex = 1
        Me.chk_ss_disable.Text = "Disable Screen Saver"
        Me.chk_ss_disable.UseVisualStyleBackColor = False
        '
        'txt_systems
        '
        Me.txt_systems.AllowNegative = False
        Me.txt_systems.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_systems.ColorCursor = True
        Me.txt_systems.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_systems.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_systems.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_systems.Field_Name = "num_of_systems"
        Me.txt_systems.GridBinding = Nothing
        Me.txt_systems.Label_On_Top = False
        Me.txt_systems.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_systems.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_systems.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_systems.Label_Properties.Text = "# of Systems"
        Me.txt_systems.Label_Properties.Width = 120
        Me.txt_systems.Location = New System.Drawing.Point(85, 89)
        Me.txt_systems.Mandatory = True
        Me.txt_systems.Name = "txt_systems"
        Me.txt_systems.Override_Modified = False
        Me.txt_systems.SaveLoadOrder = 0
        Me.txt_systems.Size = New System.Drawing.Size(183, 26)
        Me.txt_systems.TabIndex = 5
        Me.txt_systems.TabStop = False
        Me.txt_systems.Text = "DbA_TextBox1"
        Me.txt_systems.TextBox_Properties.AcceptsReturn = False
        Me.txt_systems.TextBox_Properties.AcceptsTab = False
        Me.txt_systems.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_systems.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_systems.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_systems.TextBox_Properties.Enabled = True
        Me.txt_systems.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_systems.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_systems.TextBox_Properties.MaximumValue = 999999
        Me.txt_systems.TextBox_Properties.MaxLength = 3
        Me.txt_systems.TextBox_Properties.MinimumValue = -999999
        Me.txt_systems.TextBox_Properties.MultiLine = False
        Me.txt_systems.TextBox_Properties.PasswordChar = Nothing
        Me.txt_systems.TextBox_Properties.ReadOnly = False
        Me.txt_systems.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_systems.TextBox_Properties.TabStop = True
        Me.txt_systems.TextBox_Properties.Text = ""
        Me.txt_systems.TextBox_Properties.WordWrap = True
        Me.txt_systems.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'chk_demo_mode
        '
        Me.chk_demo_mode.BackColor = System.Drawing.Color.PapayaWhip
        Me.chk_demo_mode.Caption = "Demo Mode"
        Me.chk_demo_mode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chk_demo_mode.Field_Name = "demo_mode"
        Me.chk_demo_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_demo_mode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chk_demo_mode.ForeColor = System.Drawing.Color.Black
        Me.chk_demo_mode.GridBinding = Nothing
        Me.chk_demo_mode.Location = New System.Drawing.Point(123, 11)
        Me.chk_demo_mode.Mandatory = False
        Me.chk_demo_mode.Name = "chk_demo_mode"
        Me.chk_demo_mode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_demo_mode.SaveLoadOrder = 0
        Me.chk_demo_mode.Size = New System.Drawing.Size(96, 24)
        Me.chk_demo_mode.TabIndex = 0
        Me.chk_demo_mode.Text = "Demo Mode"
        Me.chk_demo_mode.UseVisualStyleBackColor = False
        '
        'txt_organization
        '
        Me.txt_organization.AllowNegative = False
        Me.txt_organization.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_organization.ColorCursor = True
        Me.txt_organization.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_organization.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_organization.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_organization.Field_Name = "organization"
        Me.txt_organization.GridBinding = Nothing
        Me.txt_organization.Label_On_Top = False
        Me.txt_organization.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_organization.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_organization.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_organization.Label_Properties.Text = "Organization Name"
        Me.txt_organization.Label_Properties.Width = 120
        Me.txt_organization.Location = New System.Drawing.Point(85, 113)
        Me.txt_organization.Mandatory = True
        Me.txt_organization.Name = "txt_organization"
        Me.txt_organization.Override_Modified = False
        Me.txt_organization.SaveLoadOrder = 0
        Me.txt_organization.Size = New System.Drawing.Size(401, 26)
        Me.txt_organization.TabIndex = 6
        Me.txt_organization.TabStop = False
        Me.txt_organization.Text = "DbA_TextBox6"
        Me.txt_organization.TextBox_Properties.AcceptsReturn = False
        Me.txt_organization.TextBox_Properties.AcceptsTab = False
        Me.txt_organization.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_organization.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_organization.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_organization.TextBox_Properties.Enabled = True
        Me.txt_organization.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_organization.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_organization.TextBox_Properties.MaximumValue = 999999
        Me.txt_organization.TextBox_Properties.MaxLength = 50
        Me.txt_organization.TextBox_Properties.MinimumValue = -999999
        Me.txt_organization.TextBox_Properties.MultiLine = False
        Me.txt_organization.TextBox_Properties.PasswordChar = Nothing
        Me.txt_organization.TextBox_Properties.ReadOnly = False
        Me.txt_organization.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_organization.TextBox_Properties.TabStop = True
        Me.txt_organization.TextBox_Properties.Text = ""
        Me.txt_organization.TextBox_Properties.WordWrap = True
        Me.txt_organization.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_max_instrument
        '
        Me.txt_max_instrument.AllowNegative = False
        Me.txt_max_instrument.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_max_instrument.ColorCursor = True
        Me.txt_max_instrument.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_max_instrument.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_max_instrument.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_max_instrument.Field_Name = "num_of_instruments"
        Me.txt_max_instrument.GridBinding = Nothing
        Me.txt_max_instrument.Label_On_Top = False
        Me.txt_max_instrument.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_max_instrument.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_max_instrument.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_max_instrument.Label_Properties.Text = "Max # of Instruments per Bay"
        Me.txt_max_instrument.Label_Properties.Width = 180
        Me.txt_max_instrument.Location = New System.Drawing.Point(25, 137)
        Me.txt_max_instrument.Mandatory = True
        Me.txt_max_instrument.Name = "txt_max_instrument"
        Me.txt_max_instrument.Override_Modified = False
        Me.txt_max_instrument.SaveLoadOrder = 0
        Me.txt_max_instrument.Size = New System.Drawing.Size(243, 26)
        Me.txt_max_instrument.TabIndex = 7
        Me.txt_max_instrument.TabStop = False
        Me.txt_max_instrument.Text = "DbA_TextBox1"
        Me.txt_max_instrument.TextBox_Properties.AcceptsReturn = False
        Me.txt_max_instrument.TextBox_Properties.AcceptsTab = False
        Me.txt_max_instrument.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_max_instrument.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_max_instrument.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_max_instrument.TextBox_Properties.Enabled = True
        Me.txt_max_instrument.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_max_instrument.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_max_instrument.TextBox_Properties.MaximumValue = 999999
        Me.txt_max_instrument.TextBox_Properties.MaxLength = 3
        Me.txt_max_instrument.TextBox_Properties.MinimumValue = -999999
        Me.txt_max_instrument.TextBox_Properties.MultiLine = False
        Me.txt_max_instrument.TextBox_Properties.PasswordChar = Nothing
        Me.txt_max_instrument.TextBox_Properties.ReadOnly = False
        Me.txt_max_instrument.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_max_instrument.TextBox_Properties.TabStop = True
        Me.txt_max_instrument.TextBox_Properties.Text = ""
        Me.txt_max_instrument.TextBox_Properties.WordWrap = True
        Me.txt_max_instrument.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_scr_saver
        '
        Me.txt_scr_saver.AllowNegative = False
        Me.txt_scr_saver.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_scr_saver.ColorCursor = True
        Me.txt_scr_saver.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_scr_saver.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_scr_saver.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_scr_saver.Field_Name = "screen_saver_sec"
        Me.txt_scr_saver.GridBinding = Nothing
        Me.txt_scr_saver.Label_On_Top = False
        Me.txt_scr_saver.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_scr_saver.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_scr_saver.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_scr_saver.Label_Properties.Text = "Screen Saver (sec.)"
        Me.txt_scr_saver.Label_Properties.Width = 120
        Me.txt_scr_saver.Location = New System.Drawing.Point(85, 161)
        Me.txt_scr_saver.Mandatory = True
        Me.txt_scr_saver.Name = "txt_scr_saver"
        Me.txt_scr_saver.Override_Modified = False
        Me.txt_scr_saver.SaveLoadOrder = 0
        Me.txt_scr_saver.Size = New System.Drawing.Size(184, 26)
        Me.txt_scr_saver.TabIndex = 8
        Me.txt_scr_saver.TabStop = False
        Me.txt_scr_saver.Text = "DbA_TextBox2"
        Me.txt_scr_saver.TextBox_Properties.AcceptsReturn = False
        Me.txt_scr_saver.TextBox_Properties.AcceptsTab = False
        Me.txt_scr_saver.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_scr_saver.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_scr_saver.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_scr_saver.TextBox_Properties.Enabled = True
        Me.txt_scr_saver.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_scr_saver.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_scr_saver.TextBox_Properties.MaximumValue = 999999
        Me.txt_scr_saver.TextBox_Properties.MaxLength = 6
        Me.txt_scr_saver.TextBox_Properties.MinimumValue = -999999
        Me.txt_scr_saver.TextBox_Properties.MultiLine = False
        Me.txt_scr_saver.TextBox_Properties.PasswordChar = Nothing
        Me.txt_scr_saver.TextBox_Properties.ReadOnly = False
        Me.txt_scr_saver.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_scr_saver.TextBox_Properties.TabStop = True
        Me.txt_scr_saver.TextBox_Properties.Text = ""
        Me.txt_scr_saver.TextBox_Properties.WordWrap = True
        Me.txt_scr_saver.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_cancel.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_cancel.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_cancel.DisplayText = ""
        Me.btn_cancel.Enabled = False
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(311, 14)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(104, 43)
        Me.btn_cancel.TabIndex = 2
        Me.btn_cancel.TabStop = False
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'lbl_info
        '
        Me.lbl_info.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_info.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_info.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info.ForeColor = System.Drawing.Color.Black
        Me.lbl_info.Location = New System.Drawing.Point(127, 456)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(485, 27)
        Me.lbl_info.TabIndex = 16
        Me.lbl_info.Text = "Use tab/arrow keys to move around.  Press spacebar for checkbox edit."
        Me.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_info.UseMnemonic = False
        '
        'btn_save
        '
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_save.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_save.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_save.DisplayText = ""
        Me.btn_save.Enabled = False
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_save.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Location = New System.Drawing.Point(175, 14)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(104, 43)
        Me.btn_save.TabIndex = 1
        Me.btn_save.TabStop = False
        Me.btn_save.Text = "Save"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.UseVisualStyleBackColor = False
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
        Me.btn_close.Location = New System.Drawing.Point(447, 14)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(104, 43)
        Me.btn_close.TabIndex = 3
        Me.btn_close.TabStop = False
        Me.btn_close.Text = "Close"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'settings
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(750, 550)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "settings"
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_main.ResumeLayout(False)
        Me.pnl_info.ResumeLayout(False)
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
            Case Keys.F2
                Call Process("SAVE")

            Case Keys.F3
                Call Process("CANCEL")

            Case Keys.F8
                Call Process("CLOSE")

            Case Keys.F5
                Call Process("TASKBAR SHOW")

            Case Keys.F7
                Call Process("TASKBAR HIDE")
        End Select

        Select Case keyCode
            Case Keys.F2, Keys.F3, Keys.F5, Keys.F7, Keys.F8
                Return True
        End Select
    End Function
#End Region

#Region " Declarations "
    Dim m_screen_secs_flag As Boolean
    Dim m_ss_disable_flag As Boolean

    Dim m_demo_mode_flag As Boolean
    Dim m_bay_count_flag As Boolean
    Dim m_instrument_count_flag As Boolean
    Dim m_england_flag As Boolean
    Dim m_hide_F7_flag As Boolean
#End Region

#Region " Button Events "
    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Call Process("SAVE")
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Call Process("CANCEL")
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Call Process("CLOSE")
    End Sub
#End Region

#Region " Close Form "
    Private Sub close_form()
        g_framework.g_forms(1).Show()
        g_framework.g_forms(2) = Nothing
        Me.Close()
    End Sub
#End Region

#Region " Form Activated "
    Private Sub Form_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        chk_demo_mode.Focus()
    End Sub
#End Region

#Region " Form AfterFillScreen "
    Private Sub Form_AfterFillScreen(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.AfterFillScreen
        Call set_toolbar_buttons("F", "F")

        ' -----------------------------------
        ' * Set Mandatory of Network Location
        ' -----------------------------------
        If Not chk_back_cd.Checked Then
            Me.txt_back_bl.Mandatory = True
        Else
            Me.txt_back_bl.Mandatory = False
        End If

        ' ---------------------------------------
        ' * Set Mandatory of File Output Location
        ' ---------------------------------------
        If chk_file_output.Checked Then
            Me.txt_file_output_path.Mandatory = True
        Else
            Me.txt_file_output_path.Mandatory = False
        End If

        pnl_main.Focus()
        Me.Refresh()
    End Sub
#End Region

#Region " Form GotFocus "
    Private Sub Form_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        chk_demo_mode.Focus()
    End Sub
#End Region

#Region " Form Load "
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim p_excludes(0) As dba_RemoveControls
        p_excludes(0).Control = btn_close

        Me.dba_init_form(pnl_main, True, p_excludes, g_is_internal)
        Me.g_focus_fld = chk_demo_mode
        Call size_screen(Me)

        ' -----------------------
        ' * Get Existing Settings
        ' -----------------------
        Dim p_dataset As DataSet
        p_dataset = g_framework.Get_Data("Select " & pnl_main.DataSettings.IDField & " From " & pnl_main.DataSettings.TableName)

        If p_dataset.Tables(0).Rows.Count > 0 Then
            pnl_main.RecordID = main.validate(p_dataset.Tables(0).Rows(0).Item(0).ToString)

            ' Dispose of Dataset
            p_dataset.Dispose()

            ' -------------
            ' * Fill Screen
            ' -------------
            Call dba_fill_screen_values(pnl_main)
        Else
            Me.dba_screen_state(pnl_main, DBA_Framework.DBA_Foundation_Class.SCREEN_BUTTON_MODE.New_Screen, DBA_Framework.DBA_Foundation_Class.ScreenLockMode.UNLOCK, False)

            ' Dispose of Dataset
            p_dataset.Dispose()

            pnl_main.Focus()
            Me.Refresh()
        End If
    End Sub
#End Region

#Region " Process "
    Private Sub Process(ByVal p_type As String)
        If g_fill_screen Then Exit Sub

        Select Case UCase(p_type)
            Case "SAVE"
                If dba_save_record(pnl_main) Then
                    Call set_toolbar_buttons("F", "F")

                    ' ------------------
                    ' * Get All Settings
                    ' ------------------
                    If m_demo_mode_flag And m_bay_count_flag And m_instrument_count_flag Then
                        Call get_settings()
                        Call get_mdi_caption()
                    Else
                        ' Get Update Organization Name
                        g_organization = txt_organization.TextBox_Properties.Text

                        ' Check Demo Mode Flag
                        If m_demo_mode_flag Then
                            Call get_demo_mode()
                            Call get_mdi_caption()
                        End If

                        ' Check Bay Count Flag
                        If m_bay_count_flag Then Call get_bay_count()

                        ' Check Max Instrument Count Flag
                        If m_instrument_count_flag Then Call get_max_instruments()
                    End If

                    ' --------------------
                    ' * Check Screen Saver
                    ' --------------------
                    If m_screen_secs_flag Then
                        Call reset_timer_interval(CInt(txt_scr_saver.TextBox_Properties.Text))
                    End If
                    If m_ss_disable_flag Then
                        g_ss_disabled_flag = chk_ss_disable.Checked
                        Call set_timer()
                    End If

                    ' --------------------
                    ' * Check England Flag
                    ' --------------------
                    If m_england_flag Then
                        g_england_flag = chk_england.Checked

                        ' ------------------------------
                        ' * Set England Mode of Machines
                        ' ------------------------------
                        For p_x As Integer = 0 To g_bay_count - 1
                            g_CUSMain.Machines(p_x).EnglandMode = g_england_flag
                        Next
                    End If

                    ' --------------------
                    ' * Check Hide F7 Flag
                    ' --------------------
                    If m_hide_F7_flag Then
                        g_hide_F7_flag = chk_hide_F7.Checked
                    End If

                    ' ---------------------------------
                    ' * Set Override Patient Entry Flag
                    ' ---------------------------------
                    g_override_patient_entry_flag = chk_hide_F1.Checked

                    ' ----------------------
                    ' * Set File Output Info
                    ' ----------------------
                    g_enable_file_output_flag = chk_file_output.Checked
                    g_file_output_path = txt_file_output_path.TextBox_Properties.Text

                    ' ------------------------------
                    ' * Check Temperature Monitoring
                    ' ------------------------------
                    If m_bay_count_flag Then Call Check_Machines_Temp_Monitoring()

                    ' -------------
                    ' * Reset Flags
                    ' -------------
                    Call reset_flags()
                End If

            Case "CANCEL"
                ' -------------
                ' * Reset Flags
                ' -------------
                Call reset_flags()

                dba_cancel_record(pnl_main)

                If pnl_main.RecordID = "" Then
                    Me.dba_screen_state(pnl_main, DBA_Framework.DBA_Foundation_Class.SCREEN_BUTTON_MODE.New_Screen, DBA_Framework.DBA_Foundation_Class.ScreenLockMode.UNLOCK, False)
                End If

                Call set_toolbar_buttons("F", "F")
                Me.g_focus_fld.Focus()

            Case "CLOSE"
                If btn_save.Enabled Then
                    If message_box("Do you want to save before exiting this screen?", 2, "Save before close") = MsgBoxResult.Yes Then
                        If dba_save_record(pnl_main) = True Then
                            Call close_form()
                        End If
                    Else
                        Call close_form()
                    End If
                Else
                    Call close_form()
                End If

            Case "TASKBAR SHOW"
                Call SetTaskbarVisibility(True)

            Case "TASKBAR HIDE"
                Call SetTaskbarVisibility(False)
        End Select
    End Sub
#End Region

#Region " Reset Flags "
    Private Sub reset_flags()
        ' -------------
        ' * Reset Flags
        ' -------------
        m_screen_secs_flag = False
        m_demo_mode_flag = False
        m_bay_count_flag = False
        m_instrument_count_flag = False
        m_ss_disable_flag = False
        m_england_flag = False
        m_hide_F7_flag = False
    End Sub
#End Region

#Region " Set Buttons "
    Private Sub set_toolbar_buttons(ByVal p_save_status As String, _
        ByVal p_cancel_status As String)

        ' =============================================
        ' * Enable/Disable Toolbar Buttons As Requested
        ' =============================================

        ' Set Save Button
        If p_save_status <> "" Then
            btn_save.Enabled = IIf(p_save_status = "T", True, False)
        End If

        ' Set Cancel Button
        If p_cancel_status <> "" Then
            btn_cancel.Enabled = IIf(p_cancel_status = "T", True, False)
        End If
    End Sub
#End Region

#Region " Screen Object Events "

#Region " Checkbox Events "
    Private Sub chk_demo_mode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_demo_mode.CheckedChanged
        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("T", "T")
        m_demo_mode_flag = True
    End Sub

    Private Sub chk_ss_disable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ss_disable.CheckedChanged
        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("T", "T")
        m_ss_disable_flag = True
    End Sub

    Private Sub chk_england_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_england.CheckedChanged
        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("T", "T")
        m_england_flag = True
    End Sub

    Private Sub chk_hide_F7_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_hide_F7.CheckedChanged
        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("T", "T")
        m_hide_F7_flag = True
    End Sub

    Private Sub chk_hide_F1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_hide_F1.CheckedChanged
        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("T", "T")
    End Sub

    Private Sub chk_back_cd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_back_cd.CheckedChanged
        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("T", "T")

        If Not chk_back_cd.Checked Then
            Me.txt_back_bl.Mandatory = True
        Else
            Me.txt_back_bl.Mandatory = False
            Me.txt_back_bl.TextBox_Properties.Text = ""
        End If
    End Sub

    Private Sub chk_file_output_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_file_output.CheckedChanged
        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("T", "T")

        If chk_file_output.Checked Then
            Me.txt_file_output_path.Mandatory = True
        Else
            Me.txt_file_output_path.Mandatory = False
        End If
    End Sub
#End Region

#Region " Textbox Events "
    Private Sub txt_systems_TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_systems.TextBox_TextChanged
        If Me.g_fill_screen Then Exit Sub

        Call set_toolbar_buttons("T", "T")
        m_bay_count_flag = True
    End Sub

    Private Sub txt_max_instrument_TextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_max_instrument.TextBox_TextChanged
        If Me.g_fill_screen Then Exit Sub

        Call set_toolbar_buttons("T", "T")
        m_instrument_count_flag = True
    End Sub

    Private Sub txt_scr_saver_TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_scr_saver.TextBox_TextChanged
        If Me.g_fill_screen Then Exit Sub

        Call set_toolbar_buttons("T", "T")
        m_screen_secs_flag = True
    End Sub

    Private Sub TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        txt_organization.TextBox_TextChanged, txt_back_dl.TextBox_TextChanged, _
        txt_back_bl.TextBox_TextChanged, txt_back_bt.TextBox_TextChanged, _
        txt_file_output_path.TextBox_TextChanged

        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("T", "T")
    End Sub
#End Region

#End Region

End Class
