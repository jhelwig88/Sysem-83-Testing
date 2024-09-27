Public Class run_system_data
    Inherits DBA_Framework.DBA_Foundation_Class

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal p_db_name As String, ByVal p_form As run_bay_detail)
        MyBase.New(p_db_name, g_framework.g_version, g_framework.g_user_id)

        'set the webservice url
        MyBase.update_url(g_service_url)

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        m_prev_form = p_form
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
    Friend WithEvents grpbx_bay_info As DBA.Library.DBA_StyleGroupBox
    Friend WithEvents txt_title As DBA.Library.DBA_TextBox
    Friend WithEvents txt_lubrication As DBA.Library.DBA_TextBox
    Friend WithEvents txt_chemical_immersion As DBA.Library.DBA_TextBox
    Friend WithEvents txt_ls As DBA.Library.DBA_TextBox
    Friend WithEvents txt_detergent As DBA.Library.DBA_TextBox
    Friend WithEvents grpbx_cycle_info As DBA.Library.DBA_StyleGroupBox
    Friend WithEvents btn_cancel As DBA.Library.DBA_Button
    Friend WithEvents lbl_lub_info As DBA.Library.DBA_Label
    Friend WithEvents lbl_overrides As DBA.Library.DBA_Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(run_system_data))
        Me.pnl_main = New DBA.Library.DBA_Panel
        Me.btn_cancel = New DBA.Library.DBA_Button(Me.components)
        Me.grpbx_cycle_info = New DBA.Library.DBA_StyleGroupBox
        Me.lbl_overrides = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_lub_info = New DBA.Library.DBA_Label(Me.components)
        Me.txt_lubrication = New DBA.Library.DBA_TextBox
        Me.txt_chemical_immersion = New DBA.Library.DBA_TextBox
        Me.grpbx_bay_info = New DBA.Library.DBA_StyleGroupBox
        Me.txt_ls = New DBA.Library.DBA_TextBox
        Me.txt_detergent = New DBA.Library.DBA_TextBox
        Me.txt_title = New DBA.Library.DBA_TextBox
        Me.btn_save = New DBA.Library.DBA_Button(Me.components)
        Me.btn_close = New DBA.Library.DBA_Button(Me.components)
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_main.SuspendLayout()
        Me.grpbx_cycle_info.SuspendLayout()
        Me.grpbx_bay_info.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_main
        '
        Me.pnl_main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_main.Controls.Add(Me.btn_cancel)
        Me.pnl_main.Controls.Add(Me.grpbx_cycle_info)
        Me.pnl_main.Controls.Add(Me.grpbx_bay_info)
        Me.pnl_main.Controls.Add(Me.btn_save)
        Me.pnl_main.Controls.Add(Me.btn_close)
        Me.pnl_main.DataSettings.IDField = Nothing
        Me.pnl_main.DataSettings.JoinData = Nothing
        Me.pnl_main.DataSettings.LinkField = Nothing
        Me.pnl_main.DataSettings.TableName = Nothing
        Me.pnl_main.Gradient = False
        Me.pnl_main.Location = New System.Drawing.Point(0, 0)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.RecordID = Nothing
        Me.pnl_main.Saved = False
        Me.pnl_main.Size = New System.Drawing.Size(499, 414)
        Me.pnl_main.TabIndex = 0
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
        Me.btn_cancel.Location = New System.Drawing.Point(163, 14)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(104, 43)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.TabStop = False
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'grpbx_cycle_info
        '
        Me.grpbx_cycle_info.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpbx_cycle_info.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpbx_cycle_info.Controls.Add(Me.lbl_overrides)
        Me.grpbx_cycle_info.Controls.Add(Me.lbl_lub_info)
        Me.grpbx_cycle_info.Controls.Add(Me.txt_lubrication)
        Me.grpbx_cycle_info.Controls.Add(Me.txt_chemical_immersion)
        Me.grpbx_cycle_info.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbx_cycle_info.ForeColor = System.Drawing.Color.Black
        Me.grpbx_cycle_info.LineColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grpbx_cycle_info.Location = New System.Drawing.Point(25, 174)
        Me.grpbx_cycle_info.Name = "grpbx_cycle_info"
        Me.grpbx_cycle_info.Size = New System.Drawing.Size(448, 228)
        Me.grpbx_cycle_info.TabIndex = 1
        Me.grpbx_cycle_info.Text = "Cycle Information"
        '
        'lbl_overrides
        '
        Me.lbl_overrides.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_overrides.ForeColor = System.Drawing.Color.Black
        Me.lbl_overrides.Location = New System.Drawing.Point(210, 22)
        Me.lbl_overrides.Name = "lbl_overrides"
        Me.lbl_overrides.Size = New System.Drawing.Size(101, 20)
        Me.lbl_overrides.TabIndex = 3
        Me.lbl_overrides.Text = "Overrides:"
        Me.lbl_overrides.UseMnemonic = False
        '
        'lbl_lub_info
        '
        Me.lbl_lub_info.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lub_info.ForeColor = System.Drawing.Color.Black
        Me.lbl_lub_info.Location = New System.Drawing.Point(216, 132)
        Me.lbl_lub_info.Name = "lbl_lub_info"
        Me.lbl_lub_info.Size = New System.Drawing.Size(179, 22)
        Me.lbl_lub_info.TabIndex = 2
        Me.lbl_lub_info.Text = "Lubrication       10 secs"
        Me.lbl_lub_info.UseMnemonic = False
        Me.lbl_lub_info.Visible = False
        '
        'txt_lubrication
        '
        Me.txt_lubrication.AllowNegative = False
        Me.txt_lubrication.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_lubrication.ColorCursor = True
        Me.txt_lubrication.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_lubrication.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_lubrication.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_lubrication.Field_Name = "lubrication_secs"
        Me.txt_lubrication.GridBinding = Nothing
        Me.txt_lubrication.Label_On_Top = False
        Me.txt_lubrication.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_lubrication.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lubrication.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_lubrication.Label_Properties.Text = "Lubrication (10 secs)"
        Me.txt_lubrication.Label_Properties.Width = 130
        Me.txt_lubrication.Location = New System.Drawing.Point(258, 62)
        Me.txt_lubrication.Mandatory = False
        Me.txt_lubrication.Name = "txt_lubrication"
        Me.txt_lubrication.Override_Modified = False
        Me.txt_lubrication.SaveLoadOrder = 0
        Me.txt_lubrication.Size = New System.Drawing.Size(181, 26)
        Me.txt_lubrication.TabIndex = 1
        Me.txt_lubrication.TabStop = False
        Me.txt_lubrication.Tag = "10"
        Me.txt_lubrication.Text = "DbA_TextBox1"
        Me.txt_lubrication.TextBox_Properties.AcceptsReturn = False
        Me.txt_lubrication.TextBox_Properties.AcceptsTab = False
        Me.txt_lubrication.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_lubrication.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_lubrication.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_lubrication.TextBox_Properties.Enabled = True
        Me.txt_lubrication.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lubrication.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_lubrication.TextBox_Properties.MaximumValue = 999999
        Me.txt_lubrication.TextBox_Properties.MaxLength = 3
        Me.txt_lubrication.TextBox_Properties.MinimumValue = -999999
        Me.txt_lubrication.TextBox_Properties.MultiLine = False
        Me.txt_lubrication.TextBox_Properties.PasswordChar = Nothing
        Me.txt_lubrication.TextBox_Properties.ReadOnly = False
        Me.txt_lubrication.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_lubrication.TextBox_Properties.TabStop = True
        Me.txt_lubrication.TextBox_Properties.Text = ""
        Me.txt_lubrication.TextBox_Properties.WordWrap = True
        Me.txt_lubrication.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        Me.txt_lubrication.Visible = False
        '
        'txt_chemical_immersion
        '
        Me.txt_chemical_immersion.AllowNegative = False
        Me.txt_chemical_immersion.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_chemical_immersion.ColorCursor = True
        Me.txt_chemical_immersion.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_chemical_immersion.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_chemical_immersion.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_chemical_immersion.Field_Name = "chemical_immersion"
        Me.txt_chemical_immersion.GridBinding = Nothing
        Me.txt_chemical_immersion.Label_On_Top = False
        Me.txt_chemical_immersion.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_chemical_immersion.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_chemical_immersion.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_chemical_immersion.Label_Properties.Text = "Chemical immersion (10 mins)"
        Me.txt_chemical_immersion.Label_Properties.Width = 178
        Me.txt_chemical_immersion.Location = New System.Drawing.Point(210, 38)
        Me.txt_chemical_immersion.Mandatory = False
        Me.txt_chemical_immersion.Name = "txt_chemical_immersion"
        Me.txt_chemical_immersion.Override_Modified = False
        Me.txt_chemical_immersion.SaveLoadOrder = 0
        Me.txt_chemical_immersion.Size = New System.Drawing.Size(229, 26)
        Me.txt_chemical_immersion.TabIndex = 0
        Me.txt_chemical_immersion.TabStop = False
        Me.txt_chemical_immersion.Tag = "10"
        Me.txt_chemical_immersion.Text = "DbA_TextBox1"
        Me.txt_chemical_immersion.TextBox_Properties.AcceptsReturn = False
        Me.txt_chemical_immersion.TextBox_Properties.AcceptsTab = False
        Me.txt_chemical_immersion.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_chemical_immersion.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_chemical_immersion.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_chemical_immersion.TextBox_Properties.Enabled = True
        Me.txt_chemical_immersion.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_chemical_immersion.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_chemical_immersion.TextBox_Properties.MaximumValue = 999999
        Me.txt_chemical_immersion.TextBox_Properties.MaxLength = 3
        Me.txt_chemical_immersion.TextBox_Properties.MinimumValue = -999999
        Me.txt_chemical_immersion.TextBox_Properties.MultiLine = False
        Me.txt_chemical_immersion.TextBox_Properties.PasswordChar = Nothing
        Me.txt_chemical_immersion.TextBox_Properties.ReadOnly = False
        Me.txt_chemical_immersion.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_chemical_immersion.TextBox_Properties.TabStop = True
        Me.txt_chemical_immersion.TextBox_Properties.Text = ""
        Me.txt_chemical_immersion.TextBox_Properties.WordWrap = True
        Me.txt_chemical_immersion.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        Me.txt_chemical_immersion.Visible = False
        '
        'grpbx_bay_info
        '
        Me.grpbx_bay_info.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpbx_bay_info.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpbx_bay_info.Controls.Add(Me.txt_ls)
        Me.grpbx_bay_info.Controls.Add(Me.txt_detergent)
        Me.grpbx_bay_info.Controls.Add(Me.txt_title)
        Me.grpbx_bay_info.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbx_bay_info.ForeColor = System.Drawing.Color.Black
        Me.grpbx_bay_info.LineColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grpbx_bay_info.Location = New System.Drawing.Point(25, 68)
        Me.grpbx_bay_info.Name = "grpbx_bay_info"
        Me.grpbx_bay_info.Size = New System.Drawing.Size(448, 103)
        Me.grpbx_bay_info.TabIndex = 0
        Me.grpbx_bay_info.TabStop = False
        Me.grpbx_bay_info.Text = "Bay Information"
        '
        'txt_ls
        '
        Me.txt_ls.AllowNegative = False
        Me.txt_ls.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_ls.ColorCursor = False
        Me.txt_ls.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_ls.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_ls.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_ls.Field_Name = ""
        Me.txt_ls.GridBinding = Nothing
        Me.txt_ls.Label_On_Top = False
        Me.txt_ls.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_ls.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ls.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_ls.Label_Properties.Text = "Liquid Sterilant"
        Me.txt_ls.Label_Properties.Width = 95
        Me.txt_ls.Location = New System.Drawing.Point(13, 74)
        Me.txt_ls.Mandatory = False
        Me.txt_ls.Name = "txt_ls"
        Me.txt_ls.Override_Modified = False
        Me.txt_ls.SaveLoadOrder = 0
        Me.txt_ls.Size = New System.Drawing.Size(425, 26)
        Me.txt_ls.TabIndex = 2
        Me.txt_ls.TabStop = False
        Me.txt_ls.Text = "DbA_TextBox3"
        Me.txt_ls.TextBox_Properties.AcceptsReturn = False
        Me.txt_ls.TextBox_Properties.AcceptsTab = False
        Me.txt_ls.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_ls.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ls.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_ls.TextBox_Properties.Enabled = True
        Me.txt_ls.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ls.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_ls.TextBox_Properties.MaximumValue = 999999
        Me.txt_ls.TextBox_Properties.MaxLength = 50
        Me.txt_ls.TextBox_Properties.MinimumValue = -999999
        Me.txt_ls.TextBox_Properties.MultiLine = False
        Me.txt_ls.TextBox_Properties.PasswordChar = Nothing
        Me.txt_ls.TextBox_Properties.ReadOnly = True
        Me.txt_ls.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_ls.TextBox_Properties.TabStop = False
        Me.txt_ls.TextBox_Properties.Text = ""
        Me.txt_ls.TextBox_Properties.WordWrap = True
        Me.txt_ls.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_detergent
        '
        Me.txt_detergent.AllowNegative = False
        Me.txt_detergent.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_detergent.ColorCursor = False
        Me.txt_detergent.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_detergent.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_detergent.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_detergent.Field_Name = ""
        Me.txt_detergent.GridBinding = Nothing
        Me.txt_detergent.Label_On_Top = False
        Me.txt_detergent.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_detergent.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_detergent.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_detergent.Label_Properties.Text = "Detergent"
        Me.txt_detergent.Label_Properties.Width = 95
        Me.txt_detergent.Location = New System.Drawing.Point(13, 48)
        Me.txt_detergent.Mandatory = False
        Me.txt_detergent.Name = "txt_detergent"
        Me.txt_detergent.Override_Modified = False
        Me.txt_detergent.SaveLoadOrder = 0
        Me.txt_detergent.Size = New System.Drawing.Size(425, 26)
        Me.txt_detergent.TabIndex = 1
        Me.txt_detergent.TabStop = False
        Me.txt_detergent.Text = "DbA_TextBox2"
        Me.txt_detergent.TextBox_Properties.AcceptsReturn = False
        Me.txt_detergent.TextBox_Properties.AcceptsTab = False
        Me.txt_detergent.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_detergent.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_detergent.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_detergent.TextBox_Properties.Enabled = True
        Me.txt_detergent.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_detergent.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_detergent.TextBox_Properties.MaximumValue = 999999
        Me.txt_detergent.TextBox_Properties.MaxLength = 50
        Me.txt_detergent.TextBox_Properties.MinimumValue = -999999
        Me.txt_detergent.TextBox_Properties.MultiLine = False
        Me.txt_detergent.TextBox_Properties.PasswordChar = Nothing
        Me.txt_detergent.TextBox_Properties.ReadOnly = True
        Me.txt_detergent.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_detergent.TextBox_Properties.TabStop = False
        Me.txt_detergent.TextBox_Properties.Text = ""
        Me.txt_detergent.TextBox_Properties.WordWrap = True
        Me.txt_detergent.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_title
        '
        Me.txt_title.AllowNegative = False
        Me.txt_title.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_title.ColorCursor = False
        Me.txt_title.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_title.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_title.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_title.Field_Name = ""
        Me.txt_title.GridBinding = Nothing
        Me.txt_title.Label_On_Top = False
        Me.txt_title.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_title.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_title.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_title.Label_Properties.Text = "Title"
        Me.txt_title.Label_Properties.Width = 95
        Me.txt_title.Location = New System.Drawing.Point(13, 22)
        Me.txt_title.Mandatory = False
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Override_Modified = False
        Me.txt_title.SaveLoadOrder = 0
        Me.txt_title.Size = New System.Drawing.Size(425, 26)
        Me.txt_title.TabIndex = 0
        Me.txt_title.TabStop = False
        Me.txt_title.Text = "DbA_TextBox1"
        Me.txt_title.TextBox_Properties.AcceptsReturn = False
        Me.txt_title.TextBox_Properties.AcceptsTab = False
        Me.txt_title.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_title.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_title.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_title.TextBox_Properties.Enabled = True
        Me.txt_title.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_title.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_title.TextBox_Properties.MaximumValue = 999999
        Me.txt_title.TextBox_Properties.MaxLength = 50
        Me.txt_title.TextBox_Properties.MinimumValue = -999999
        Me.txt_title.TextBox_Properties.MultiLine = False
        Me.txt_title.TextBox_Properties.PasswordChar = Nothing
        Me.txt_title.TextBox_Properties.ReadOnly = True
        Me.txt_title.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_title.TextBox_Properties.TabStop = False
        Me.txt_title.TextBox_Properties.Text = ""
        Me.txt_title.TextBox_Properties.WordWrap = True
        Me.txt_title.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
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
        Me.btn_save.Location = New System.Drawing.Point(25, 14)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(105, 43)
        Me.btn_save.TabIndex = 2
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
        Me.btn_close.Location = New System.Drawing.Point(300, 14)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(100, 43)
        Me.btn_close.TabIndex = 4
        Me.btn_close.TabStop = False
        Me.btn_close.Text = "Close"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'run_system_data
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(499, 411)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "run_system_data"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "run_system_data"
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_main.ResumeLayout(False)
        Me.grpbx_cycle_info.ResumeLayout(False)
        Me.grpbx_bay_info.ResumeLayout(False)
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
                If btn_save.Enabled Then Call Process("SAVE")

            Case Keys.F3
                If btn_cancel.Enabled Then Call Process("CANCEL")

            Case Keys.F8
                Call Process("CLOSE")
        End Select

        Select Case keyCode
            Case Keys.F2, Keys.F3, Keys.F4, Keys.F8
                Return True
        End Select
    End Function
#End Region

#Region " Declarations "
    Dim m_prev_form As run_bay_detail
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
        m_prev_form.Show()
        g_framework.g_forms(2) = Nothing
        Me.Close()
    End Sub
#End Region

#Region " Form Load "
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call size_screen(Me)

        ' ----------------------
        ' * Fill Bay Information
        ' ----------------------
        txt_title.TextBox_Properties.Text = g_CUSMain.Machines(m_prev_form.m_machine_index).Name
        txt_detergent.TextBox_Properties.Text = g_CUSMain.Machines(m_prev_form.m_machine_index).detergent
        txt_ls.TextBox_Properties.Text = g_CUSMain.Machines(m_prev_form.m_machine_index).liquid_sterilant

        ' Check Profile ID
        If Trim(g_CUSMain.Machines(m_prev_form.m_machine_index).Profile) = "" Then
            Exit Sub
        ElseIf m_prev_form.chk_lub.Visible Then
            txt_lubrication.Visible = True
            lbl_lub_info.Visible = True
        End If

        ' ------------------------------------
        ' * Get Max Time of Disinfect Cycle(s)
        ' ------------------------------------
        Call get_disinfect_time()

        ' -------------------
        ' * Get Min Overrides
        ' -------------------
        Dim p_val As Integer
        p_val = g_disinfect_settings(m_prev_form.m_machine_index)
        txt_chemical_immersion.Tag = p_val
        txt_chemical_immersion.Label_Properties.Text = "Chemical immersion (" & p_val & " " & IIf(p_val > 1, "mins", "min") & ")"

        p_val = g_lubrication_settings(m_prev_form.m_machine_index)
        txt_lubrication.Tag = p_val
        txt_lubrication.Label_Properties.Text = "Lubrication (" & p_val & " " & IIf(p_val > 1, "secs", "sec") & ")"

        ' ------------------------
        ' * Fill Cycle Information
        ' ------------------------
        Call get_cycle_info()
    End Sub
#End Region

#Region " Get Cycle Information "
    Private Sub get_cycle_info()
        Dim p_sql As String
        Dim p_dataset As DataSet
        Dim p_db_row As DataRow
        Dim p_array(0, 1) As String
        Dim p_counter As Integer

        ' ========================
        ' * Fill Cycle Information
        ' ========================

        ' --------------------
        ' * Load up the cycles
        ' --------------------
        p_sql = "SELECT cycle_number, cycle_name, default_override " & _
                "FROM profile_cycles PC1 " & _
                "INNER JOIN cycles C1 ON C1.cycle_id = PC1.cycle_id " & _
                "WHERE PC1.profile_id = '" & g_CUSMain.Machines(m_prev_form.m_machine_index).Profile & _
                "' ORDER BY PC1.order_num"
        p_dataset = g_framework.Get_Data(p_sql)

        ReDim p_array(p_dataset.Tables(0).Rows.Count, 1)

        For Each p_db_row In p_dataset.Tables(0).Rows
            p_counter += 1
            Select Case UCase(p_db_row("cycle_name").ToString)
                Case "DISINFECT"
                    txt_chemical_immersion.Visible = True
                    p_array(p_counter, 0) = "Disinfect"

                    ' ----------------------
                    ' * Load Cycle Overrides
                    ' ----------------------
                    If g_disinfect_overrides(m_prev_form.m_machine_index) <> 0 Then
                        p_array(p_counter, 1) = g_disinfect_overrides(m_prev_form.m_machine_index) & " " & IIf(g_disinfect_overrides(m_prev_form.m_machine_index) > 1, "mins", "min")
                    Else
                        If p_db_row("default_override").ToString <> "" Then
                            p_array(p_counter, 1) = p_db_row("default_override") & " " & IIf(p_db_row("default_override") > 1, "mins", "min")
                        Else
                            p_array(p_counter, 1) = g_disinfect_settings(m_prev_form.m_machine_index) & " " & IIf(g_disinfect_settings(m_prev_form.m_machine_index) > 1, "mins", "min")
                        End If
                    End If

                Case "DRY"
                    p_array(p_counter, 0) = "Dry"

                    ' ----------------------
                    ' * Load Cycle Overrides
                    ' ----------------------
                    If p_db_row("default_override").ToString <> "" Then
                        p_array(p_counter, 1) = p_db_row("default_override") & " secs"
                    Else
                        p_array(p_counter, 1) = g_CUSMain.Machines(m_prev_form.m_machine_index).SystemOverrides.dry_heat_secs & " secs"
                    End If

                Case "PRERINSE"
                    p_array(p_counter, 0) = "Pre-rinse"

                    ' ----------------------
                    ' * Load Cycle Overrides
                    ' ----------------------
                    If p_db_row("default_override").ToString <> "" Then
                        p_array(p_counter, 1) = p_db_row("default_override") & " secs"
                    Else
                        p_array(p_counter, 1) = g_CUSMain.Machines(m_prev_form.m_machine_index).SystemOverrides.prerinse_secs & " secs"
                    End If

                Case "RINSE"
                    p_array(p_counter, 0) = "Rinse"

                    ' ----------------------
                    ' * Load Cycle Overrides
                    ' ----------------------
                    If p_db_row("default_override").ToString <> "" Then
                        p_array(p_counter, 1) = p_db_row("default_override") & " secs"
                    Else
                        p_array(p_counter, 1) = g_CUSMain.Machines(m_prev_form.m_machine_index).SystemOverrides.rinse_secs & " secs"
                    End If

                Case "SOAK"
                    p_array(p_counter, 0) = "Soak"

                    ' ----------------------
                    ' * Load Cycle Overrides
                    ' ----------------------
                    If p_db_row("default_override").ToString <> "" Then
                        p_array(p_counter, 1) = p_db_row("default_override") & " secs"
                    Else
                        p_array(p_counter, 1) = g_CUSMain.Machines(m_prev_form.m_machine_index).SystemOverrides.soak_secs & " secs"
                    End If

                Case "WASH"
                    p_array(p_counter, 0) = "Wash"

                    ' ----------------------
                    ' * Load Cycle Overrides
                    ' ----------------------
                    If p_db_row("default_override").ToString <> "" Then
                        p_array(p_counter, 1) = p_db_row("default_override") & " secs"
                    Else
                        p_array(p_counter, 1) = g_CUSMain.Machines(m_prev_form.m_machine_index).SystemOverrides.wash_secs & " secs"
                    End If
            End Select
        Next

        ' Dispose of Dataset
        p_dataset.Dispose()

        ' ------------------------------
        ' * Add Cycle Information Labels
        ' ------------------------------
        Dim p_label As DBA.Library.DBA_Label
        Dim p_label2 As DBA.Library.DBA_Label

        For p_x As Integer = 1 To p_counter
            ' Cycle
            p_label = New DBA.Library.DBA_Label

            With p_label
                .Height = 20
                .Name = "lbl_" & p_x
                .Left = 20
                .Top = 10 + (p_x * 20)
                .Text = main.validate(p_x & ") " & p_array(p_x, 0))
            End With

            grpbx_cycle_info.Controls.Add(p_label)

            ' Cycle Time
            p_label2 = New DBA.Library.DBA_Label

            With p_label2
                .Height = 20
                .Name = "lbl_v_" & p_x
                .Left = 120
                .Top = 10 + (p_x * 20)
                .Text = main.validate(p_array(p_x, 1))
            End With

            grpbx_cycle_info.Controls.Add(p_label2)
        Next

        ' ----------------------
        ' * Set Lubrication Secs
        ' ----------------------
        If lbl_lub_info.Visible Then
            If g_lubrication_overrides(m_prev_form.m_machine_index) <> 0 Then
                lbl_lub_info.Text = main.validate("Lubrication       " & g_lubrication_overrides(m_prev_form.m_machine_index) & " " & IIf(g_lubrication_overrides(m_prev_form.m_machine_index) > 1, "secs", "sec"))
            Else
                lbl_lub_info.Text = main.validate("Lubrication       " & g_lubrication_settings(m_prev_form.m_machine_index) & " " & IIf(g_lubrication_settings(m_prev_form.m_machine_index) > 1, "secs", "sec"))
            End If
        End If

        Me.Refresh()
    End Sub
#End Region

#Region " Get Disinfect Time "
    Private Sub get_disinfect_time()
        Dim p_sql As String
        Dim p_dataset As DataSet

        ' --------------------
        ' * Load up the cycles
        ' --------------------
        p_sql = "SELECT Max(default_override) " & _
                "FROM profile_cycles PC1 " & _
                "INNER JOIN cycles C1 ON C1.cycle_id = PC1.cycle_id " & _
                "WHERE PC1.profile_id = '" & g_CUSMain.Machines(m_prev_form.m_machine_index).Profile & _
                "' And cycle_name = 'Disinfect'"
        p_dataset = g_framework.Get_Data(p_sql)

        If p_dataset.Tables(0).Rows.Count > 0 Then
            If Not IsDBNull(p_dataset.Tables(0).Rows(0).Item(0)) Then
                Dim p_val As Integer

                ' Get Max Override
                p_val = p_dataset.Tables(0).Rows(0).Item(0)

                ' --------------------------------
                ' * Compare with Existing Override
                ' --------------------------------
                If p_val > g_disinfect_settings(m_prev_form.m_machine_index) Then
                    g_disinfect_settings(m_prev_form.m_machine_index) = p_val
                End If
            End If
        End If

        ' Dispose of Dataset
        p_dataset.Dispose()
    End Sub
#End Region

#Region " Process "
    Private Sub Process(ByVal p_type As String)
        Select Case UCase(p_type)
            Case "SAVE"
                Dim p_invalid As String = ""

                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Refresh()

                ' ----------------------------
                ' * Verify Default Information
                ' ----------------------------
                ' Check Chemmical Immersion
                If Trim(txt_chemical_immersion.Tag) <> "" And Trim(txt_chemical_immersion.TextBox_Properties.Text) <> "" Then
                    If Val(Trim(txt_chemical_immersion.TextBox_Properties.Text)) < Val(Trim(txt_chemical_immersion.Tag)) Then
                        p_invalid &= txt_chemical_immersion.Label_Properties.Text & vbCrLf
                    End If
                End If

                ' Check Lubrication
                If Trim(txt_lubrication.Tag) <> "" And Trim(txt_lubrication.TextBox_Properties.Text) <> "" Then
                    If Val(Trim(txt_lubrication.TextBox_Properties.Text)) < Val(Trim(txt_lubrication.Tag)) Then
                        p_invalid &= txt_lubrication.Label_Properties.Text & vbCrLf
                    End If
                End If

                If Trim(p_invalid) <> "" Then
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Call message_box("Value(s) entered must be greater than or equal to the default." & vbCrLf & vbCrLf & _
                        "Check Default(s): " & vbCrLf & vbCrLf & p_invalid, 1)

                    Exit Sub
                End If

                ' ================================
                ' * Update Machine/Cycle Overrides
                ' ================================
                If Trim(txt_chemical_immersion.TextBox_Properties.Text) <> "" Then
                    ' ----------------------------------
                    ' * Update Global Disinfect Override
                    ' ----------------------------------
                    If Val(Trim(txt_chemical_immersion.TextBox_Properties.Text)) = Val(Trim(txt_chemical_immersion.Tag)) Then
                        ' Clear Override
                        g_disinfect_overrides(m_prev_form.m_machine_index) = 0
                    Else
                        ' Set Override
                        g_disinfect_overrides(m_prev_form.m_machine_index) = Val(Trim(txt_chemical_immersion.TextBox_Properties.Text))
                    End If

                    ' --------------------------------------------
                    ' * Update SQL Data Field - Disinfect Override
                    ' --------------------------------------------
                    Call g_framework.Execute_Query("Update settings_maint " & _
                        "Set disinfect_override_" & m_prev_form.m_machine_index + 1 & _
                        " = " & g_disinfect_overrides(m_prev_form.m_machine_index))

                    ' Reset Field
                    txt_chemical_immersion.TextBox_Properties.Text = ""
                End If

                If Trim(txt_lubrication.TextBox_Properties.Text) <> "" Then
                    ' ------------------------------------
                    ' * Update Global Lubrication Override
                    ' ------------------------------------
                    If Val(Trim(txt_lubrication.TextBox_Properties.Text)) = Val(Trim(txt_lubrication.Tag)) Then
                        ' Clear Override
                        g_lubrication_overrides(m_prev_form.m_machine_index) = 0
                    Else
                        ' Set Override
                        g_lubrication_overrides(m_prev_form.m_machine_index) = Val(Trim(txt_lubrication.TextBox_Properties.Text))
                    End If

                    ' ----------------------------------------------
                    ' * Update SQL Data Field - Lubrication Override
                    ' ----------------------------------------------
                    Call g_framework.Execute_Query("Update settings_maint " & _
                        "Set lub_override_" & m_prev_form.m_machine_index + 1 & _
                        " = " & g_disinfect_overrides(m_prev_form.m_machine_index))

                    ' Reset Field
                    txt_lubrication.TextBox_Properties.Text = ""
                End If

                ' ----------------------
                ' * Save Bay Information
                ' ----------------------
                Call set_toolbar_buttons("F", "F")

                If grpbx_cycle_info.Controls.Count > 4 Then
                    For p_x As Integer = 4 To grpbx_cycle_info.Controls.Count - 1
                        grpbx_cycle_info.Controls.RemoveAt(4)
                    Next

                    Call get_cycle_info()
                End If

                Me.Cursor = System.Windows.Forms.Cursors.Default

            Case "CANCEL"
                ' ----------------
                ' * Cancel Changes
                ' ----------------
                txt_chemical_immersion.TextBox_Properties.Text = ""
                txt_lubrication.TextBox_Properties.Text = ""

                Call set_toolbar_buttons("F", "F")
                txt_chemical_immersion.txtbox.Focus()

            Case "CLOSE"
                ' --------------------------
                ' * Close Form Functionality
                ' --------------------------
                If btn_save.Enabled Then
                    If message_box("Do you want to save before exiting this screen?", 2, "Save before close") = MsgBoxResult.Yes Then
                        Call Process("SAVE")
                    Else
                        Call close_form()
                    End If
                Else
                    Call close_form()
                End If
        End Select
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

#Region " Textbox Events "
    Private Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        txt_chemical_immersion.TextBox_TextChanged, txt_lubrication.TextBox_TextChanged

        Call set_toolbar_buttons("T", "T")
    End Sub
#End Region

#End Region

End Class
