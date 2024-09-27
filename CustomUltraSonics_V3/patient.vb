Public Class patient
    Inherits DBA_Framework.DBA_Foundation_Class

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal p_db_name As String, ByVal p_prev_form As Form, ByVal p_close_index As Integer)
        MyBase.New(p_db_name, g_framework.g_version, g_framework.g_user_id)

        'set the webservice url
        MyBase.update_url(g_service_url)

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        m_prev_form = p_prev_form
        m_close_index = p_close_index
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
    Friend WithEvents txt_notes As DBA.Library.DBA_TextBox
    Friend WithEvents btn_delete As DBA.Library.DBA_Button
    Friend WithEvents btn_cancel As DBA.Library.DBA_Button
    Friend WithEvents btn_save As DBA.Library.DBA_Button
    Friend WithEvents btn_new As DBA.Library.DBA_Button
    Friend WithEvents btn_close As DBA.Library.DBA_Button
    Friend WithEvents txt_code As DBA.Library.DBA_TextBox
    Friend WithEvents txt_mi As DBA.Library.DBA_TextBox
    Friend WithEvents txt_first_name As DBA.Library.DBA_TextBox
    Friend WithEvents txt_last_name As DBA.Library.DBA_TextBox
    Friend WithEvents btn_physician As DBA.Library.DBA_Button
    Friend WithEvents lbl_F10 As DBA.Library.DBA_Label
    Friend WithEvents pnl_info As DBA.Library.DBA_Panel
    Friend WithEvents lbl_F9 As DBA.Library.DBA_Label
    Friend WithEvents tlb_main As DBA.Library.DBA_StyleToolbar
    Friend WithEvents grd_display As DBA.Library.DBA_StyleGrid
    Friend WithEvents GroupByRow1 As Xceed.Grid.GroupByRow
    Friend WithEvents ColumnManagerRow1 As Xceed.Grid.ColumnManagerRow
    Friend WithEvents dataRowTemplate1 As Xceed.Grid.DataRow
    Friend WithEvents dd_physician As DBA.Library.DBA_StyleComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(patient))
        Me.pnl_main = New DBA.Library.DBA_Panel
        Me.grd_display = New DBA.Library.DBA_StyleGrid
        Me.dataRowTemplate1 = New Xceed.Grid.DataRow
        Me.GroupByRow1 = New Xceed.Grid.GroupByRow
        Me.ColumnManagerRow1 = New Xceed.Grid.ColumnManagerRow
        Me.tlb_main = New DBA.Library.DBA_StyleToolbar
        Me.pnl_info = New DBA.Library.DBA_Panel
        Me.dd_physician = New DBA.Library.DBA_StyleComboBox
        Me.lbl_F9 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_F10 = New DBA.Library.DBA_Label(Me.components)
        Me.btn_physician = New DBA.Library.DBA_Button(Me.components)
        Me.txt_last_name = New DBA.Library.DBA_TextBox
        Me.txt_mi = New DBA.Library.DBA_TextBox
        Me.txt_code = New DBA.Library.DBA_TextBox
        Me.txt_notes = New DBA.Library.DBA_TextBox
        Me.txt_first_name = New DBA.Library.DBA_TextBox
        Me.btn_delete = New DBA.Library.DBA_Button(Me.components)
        Me.btn_cancel = New DBA.Library.DBA_Button(Me.components)
        Me.btn_save = New DBA.Library.DBA_Button(Me.components)
        Me.btn_new = New DBA.Library.DBA_Button(Me.components)
        Me.btn_close = New DBA.Library.DBA_Button(Me.components)
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_main.SuspendLayout()
        CType(Me.grd_display, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataRowTemplate1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColumnManagerRow1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_info.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_main
        '
        Me.pnl_main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_main.Controls.Add(Me.grd_display)
        Me.pnl_main.Controls.Add(Me.tlb_main)
        Me.pnl_main.Controls.Add(Me.pnl_info)
        Me.pnl_main.Controls.Add(Me.btn_delete)
        Me.pnl_main.Controls.Add(Me.btn_cancel)
        Me.pnl_main.Controls.Add(Me.btn_save)
        Me.pnl_main.Controls.Add(Me.btn_new)
        Me.pnl_main.Controls.Add(Me.btn_close)
        Me.pnl_main.DataSettings.IDField = "patient_id"
        Me.pnl_main.DataSettings.JoinData = Nothing
        Me.pnl_main.DataSettings.LinkField = Nothing
        Me.pnl_main.DataSettings.TableName = "patient_maint"
        Me.pnl_main.Gradient = False
        Me.pnl_main.Location = New System.Drawing.Point(0, 0)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.RecordID = Nothing
        Me.pnl_main.Saved = False
        Me.pnl_main.Size = New System.Drawing.Size(624, 443)
        Me.pnl_main.TabIndex = 1
        '
        'grd_display
        '
        Me.grd_display.AllowCellNavigation = False
        Me.grd_display.AllowGrouping = False
        Me.grd_display.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.grd_display.AutoFitColumns = True
        Me.grd_display.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grd_display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grd_display.DataRowTemplate = Me.dataRowTemplate1
        Me.grd_display.DataSettings.IDField = Nothing
        Me.grd_display.DataSettings.TableName = Nothing
        '
        '
        '
        Me.grd_display.FixedColumnSplitter.Visible = False
        Me.grd_display.FixedHeaderRows.Add(Me.GroupByRow1)
        Me.grd_display.FixedHeaderRows.Add(Me.ColumnManagerRow1)
        Me.grd_display.LinkSettings.IsMainGrid = True
        Me.grd_display.LinkSettings.RecordContainer = Me.pnl_main
        Me.grd_display.Location = New System.Drawing.Point(8, 210)
        Me.grd_display.Name = "grd_display"
        Me.grd_display.ReadOnly = True
        Me.grd_display.SelectionMode = System.Windows.Forms.SelectionMode.One
        Me.grd_display.Size = New System.Drawing.Size(608, 196)
        Me.grd_display.SQL = Nothing
        Me.grd_display.TabIndex = 0
        Me.grd_display.UIStyle = Xceed.UI.UIStyle.ResourceAssembly
        '
        'GroupByRow1
        '
        Me.GroupByRow1.Visible = False
        '
        'tlb_main
        '
        Me.tlb_main.DisplayLogo = False
        Me.tlb_main.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlb_main.Location = New System.Drawing.Point(0, 0)
        Me.tlb_main.Name = "tlb_main"
        Me.tlb_main.OverridePrintButtons = False
        Me.tlb_main.PanelContainer = Me.pnl_main
        Me.tlb_main.ShowBackDrop = False
        Me.tlb_main.Size = New System.Drawing.Size(624, 1)
        Me.tlb_main.TabIndex = 7
        Me.tlb_main.TabStop = False
        Me.tlb_main.ToolBarCustom = Nothing
        Me.tlb_main.ToolbarDisplayType = DBA.Library.DBA_StyleToolbar.DisplayType.IconsOnSide
        Me.tlb_main.ToolBarType = DBA.Library.DBA_StyleToolbar.DBA_ToolBarType.Normal
        Me.tlb_main.Visible = False
        '
        'pnl_info
        '
        Me.pnl_info.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnl_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_info.Controls.Add(Me.dd_physician)
        Me.pnl_info.Controls.Add(Me.lbl_F9)
        Me.pnl_info.Controls.Add(Me.lbl_F10)
        Me.pnl_info.Controls.Add(Me.btn_physician)
        Me.pnl_info.Controls.Add(Me.txt_last_name)
        Me.pnl_info.Controls.Add(Me.txt_mi)
        Me.pnl_info.Controls.Add(Me.txt_code)
        Me.pnl_info.Controls.Add(Me.txt_notes)
        Me.pnl_info.Controls.Add(Me.txt_first_name)
        Me.pnl_info.DataSettings.IDField = Nothing
        Me.pnl_info.DataSettings.JoinData = Nothing
        Me.pnl_info.DataSettings.LinkField = Nothing
        Me.pnl_info.DataSettings.TableName = Nothing
        Me.pnl_info.Gradient = False
        Me.pnl_info.Location = New System.Drawing.Point(8, 56)
        Me.pnl_info.Name = "pnl_info"
        Me.pnl_info.RecordID = Nothing
        Me.pnl_info.Saved = False
        Me.pnl_info.Size = New System.Drawing.Size(608, 152)
        Me.pnl_info.TabIndex = 0
        '
        'dd_physician
        '
        Me.dd_physician.ColorCursor = True
        Me.dd_physician.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dd_physician.Column_To_Display = 1
        Me.dd_physician.ComboBox_Properties.AllowFreeText = False
        Me.dd_physician.ComboBox_Properties.ColumnWidthAdjustment = Xceed.Editors.ColumnWidthAdjustment.None
        Me.dd_physician.ComboBox_Properties.CompareType = CType((Xceed.Editors.CompareType.CaseInsensitive Or Xceed.Editors.CompareType.AccentInsensitive), Xceed.Editors.CompareType)
        Me.dd_physician.ComboBox_Properties.Cursor = System.Windows.Forms.Cursors.Default
        Me.dd_physician.ComboBox_Properties.DropDownResizable = False
        Me.dd_physician.ComboBox_Properties.Enabled = True
        Me.dd_physician.ComboBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd_physician.ComboBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_physician.ComboBox_Properties.IntegralHeight = True
        Me.dd_physician.ComboBox_Properties.MaxDropDownItems = 8
        Me.dd_physician.ComboBox_Properties.Text = ""
        Me.dd_physician.ComboBox_Properties.TextBoxArea_BackColor = System.Drawing.Color.White
        Me.dd_physician.ComboBox_Properties.TextBoxArea_TabStop = True
        Me.dd_physician.DataSet = Nothing
        Me.dd_physician.DataType = DBA.Library.DBA_StyleComboBox.DBA_data_type.DBA_UID
        Me.dd_physician.DisplayFieldName = Nothing
        Me.dd_physician.DisplayFieldSQL = Nothing
        Me.dd_physician.DisplayFieldTable = Nothing
        Me.dd_physician.DisplayFieldTableJoin = Nothing
        Me.dd_physician.Enabled = False
        Me.dd_physician.Field_Name = "physician_id"
        Me.dd_physician.GridBinding = Me.grd_display
        Me.dd_physician.ID_Column_Number = 0
        Me.dd_physician.ID_Value = Nothing
        Me.dd_physician.Label_On_Top = True
        Me.dd_physician.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.dd_physician.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.dd_physician.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_physician.Label_Properties.Text = "Physician"
        Me.dd_physician.Label_Properties.Width = 70
        Me.dd_physician.Location = New System.Drawing.Point(10, 60)
        Me.dd_physician.Mandatory = True
        Me.dd_physician.Name = "dd_physician"
        Me.dd_physician.SaveLoadOrder = 0
        Me.dd_physician.SaveType = DBA.Library.DBA_StyleComboBox.DbA_SaveType.UID
        Me.dd_physician.Size = New System.Drawing.Size(184, 42)
        Me.dd_physician.SQL_Statement = Nothing
        Me.dd_physician.TabIndex = 3
        '
        'lbl_F9
        '
        Me.lbl_F9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_F9.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_F9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_F9.ForeColor = System.Drawing.Color.Black
        Me.lbl_F9.Location = New System.Drawing.Point(431, 5)
        Me.lbl_F9.Name = "lbl_F9"
        Me.lbl_F9.Size = New System.Drawing.Size(86, 17)
        Me.lbl_F9.TabIndex = 34
        Me.lbl_F9.Text = "F9 - Print List"
        Me.lbl_F9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_F9.UseMnemonic = False
        '
        'lbl_F10
        '
        Me.lbl_F10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_F10.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_F10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_F10.ForeColor = System.Drawing.Color.Black
        Me.lbl_F10.Location = New System.Drawing.Point(521, 1)
        Me.lbl_F10.Name = "lbl_F10"
        Me.lbl_F10.Size = New System.Drawing.Size(77, 26)
        Me.lbl_F10.TabIndex = 33
        Me.lbl_F10.Text = "F10 - Access Main Grid"
        Me.lbl_F10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_F10.UseMnemonic = False
        '
        'btn_physician
        '
        Me.btn_physician.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_physician.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_physician.DisplayText = "Add Physician"
        Me.btn_physician.Enabled = False
        Me.btn_physician.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_physician.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_physician.ForeColor = System.Drawing.Color.Black
        Me.btn_physician.Image = CType(resources.GetObject("btn_physician.Image"), System.Drawing.Image)
        Me.btn_physician.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_physician.Location = New System.Drawing.Point(445, 28)
        Me.btn_physician.Name = "btn_physician"
        Me.btn_physician.Size = New System.Drawing.Size(150, 42)
        Me.btn_physician.TabIndex = 6
        Me.btn_physician.TabStop = False
        Me.btn_physician.Text = "Add Physician (FM)"
        Me.btn_physician.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_physician.UseVisualStyleBackColor = False
        '
        'txt_last_name
        '
        Me.txt_last_name.AllowNegative = False
        Me.txt_last_name.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_last_name.ColorCursor = True
        Me.txt_last_name.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_last_name.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_last_name.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_last_name.Enabled = False
        Me.txt_last_name.Field_Name = "last_name"
        Me.txt_last_name.GridBinding = Me.grd_display
        Me.txt_last_name.Label_On_Top = True
        Me.txt_last_name.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_last_name.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_last_name.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_last_name.Label_Properties.Text = "Last Name"
        Me.txt_last_name.Label_Properties.Width = 500
        Me.txt_last_name.Location = New System.Drawing.Point(10, 16)
        Me.txt_last_name.Mandatory = True
        Me.txt_last_name.Name = "txt_last_name"
        Me.txt_last_name.Override_Modified = False
        Me.txt_last_name.SaveLoadOrder = 0
        Me.txt_last_name.Size = New System.Drawing.Size(184, 40)
        Me.txt_last_name.TabIndex = 0
        Me.txt_last_name.TabStop = False
        Me.txt_last_name.Text = "DbA_TextBox1"
        Me.txt_last_name.TextBox_Properties.AcceptsReturn = False
        Me.txt_last_name.TextBox_Properties.AcceptsTab = False
        Me.txt_last_name.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_last_name.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_last_name.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_last_name.TextBox_Properties.Enabled = True
        Me.txt_last_name.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_last_name.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_last_name.TextBox_Properties.MaximumValue = 999999
        Me.txt_last_name.TextBox_Properties.MaxLength = 100
        Me.txt_last_name.TextBox_Properties.MinimumValue = -999999
        Me.txt_last_name.TextBox_Properties.MultiLine = False
        Me.txt_last_name.TextBox_Properties.PasswordChar = Nothing
        Me.txt_last_name.TextBox_Properties.ReadOnly = False
        Me.txt_last_name.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_last_name.TextBox_Properties.TabStop = True
        Me.txt_last_name.TextBox_Properties.Text = ""
        Me.txt_last_name.TextBox_Properties.WordWrap = True
        Me.txt_last_name.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_mi
        '
        Me.txt_mi.AllowNegative = False
        Me.txt_mi.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_mi.ColorCursor = True
        Me.txt_mi.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_mi.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_mi.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_mi.Enabled = False
        Me.txt_mi.Field_Name = "middle_initial"
        Me.txt_mi.GridBinding = Me.grd_display
        Me.txt_mi.Label_On_Top = True
        Me.txt_mi.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_mi.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mi.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_mi.Label_Properties.Text = "M.I."
        Me.txt_mi.Label_Properties.Width = 500
        Me.txt_mi.Location = New System.Drawing.Point(380, 16)
        Me.txt_mi.Mandatory = False
        Me.txt_mi.Name = "txt_mi"
        Me.txt_mi.Override_Modified = False
        Me.txt_mi.SaveLoadOrder = 0
        Me.txt_mi.Size = New System.Drawing.Size(41, 40)
        Me.txt_mi.TabIndex = 2
        Me.txt_mi.TabStop = False
        Me.txt_mi.Text = "DbA_TextBox1"
        Me.txt_mi.TextBox_Properties.AcceptsReturn = False
        Me.txt_mi.TextBox_Properties.AcceptsTab = False
        Me.txt_mi.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_mi.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mi.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_mi.TextBox_Properties.Enabled = True
        Me.txt_mi.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mi.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_mi.TextBox_Properties.MaximumValue = 999999
        Me.txt_mi.TextBox_Properties.MaxLength = 2
        Me.txt_mi.TextBox_Properties.MinimumValue = -999999
        Me.txt_mi.TextBox_Properties.MultiLine = False
        Me.txt_mi.TextBox_Properties.PasswordChar = Nothing
        Me.txt_mi.TextBox_Properties.ReadOnly = False
        Me.txt_mi.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_mi.TextBox_Properties.TabStop = True
        Me.txt_mi.TextBox_Properties.Text = ""
        Me.txt_mi.TextBox_Properties.WordWrap = True
        Me.txt_mi.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_code
        '
        Me.txt_code.AllowNegative = False
        Me.txt_code.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_code.ColorCursor = True
        Me.txt_code.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_code.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_code.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_code.Enabled = False
        Me.txt_code.Field_Name = "code"
        Me.txt_code.GridBinding = Me.grd_display
        Me.txt_code.Label_On_Top = True
        Me.txt_code.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_code.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_code.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_code.Label_Properties.Text = "Code"
        Me.txt_code.Label_Properties.Width = 500
        Me.txt_code.Location = New System.Drawing.Point(10, 103)
        Me.txt_code.Mandatory = True
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Override_Modified = False
        Me.txt_code.SaveLoadOrder = 0
        Me.txt_code.Size = New System.Drawing.Size(184, 40)
        Me.txt_code.TabIndex = 4
        Me.txt_code.TabStop = False
        Me.txt_code.Text = "DbA_TextBox1"
        Me.txt_code.TextBox_Properties.AcceptsReturn = False
        Me.txt_code.TextBox_Properties.AcceptsTab = False
        Me.txt_code.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_code.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_code.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_code.TextBox_Properties.Enabled = True
        Me.txt_code.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_code.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_code.TextBox_Properties.MaximumValue = 999999
        Me.txt_code.TextBox_Properties.MaxLength = 100
        Me.txt_code.TextBox_Properties.MinimumValue = -999999
        Me.txt_code.TextBox_Properties.MultiLine = False
        Me.txt_code.TextBox_Properties.PasswordChar = Nothing
        Me.txt_code.TextBox_Properties.ReadOnly = False
        Me.txt_code.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_code.TextBox_Properties.TabStop = True
        Me.txt_code.TextBox_Properties.Text = ""
        Me.txt_code.TextBox_Properties.WordWrap = True
        Me.txt_code.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_notes
        '
        Me.txt_notes.AllowNegative = False
        Me.txt_notes.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_notes.ColorCursor = True
        Me.txt_notes.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_notes.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_notes.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_notes.Enabled = False
        Me.txt_notes.Field_Name = "notes"
        Me.txt_notes.GridBinding = Me.grd_display
        Me.txt_notes.Label_On_Top = True
        Me.txt_notes.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_notes.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_notes.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_notes.Label_Properties.Text = "Notes"
        Me.txt_notes.Label_Properties.Width = 70
        Me.txt_notes.Location = New System.Drawing.Point(217, 55)
        Me.txt_notes.Mandatory = False
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.Override_Modified = False
        Me.txt_notes.SaveLoadOrder = 0
        Me.txt_notes.Size = New System.Drawing.Size(381, 89)
        Me.txt_notes.TabIndex = 5
        Me.txt_notes.TabStop = False
        Me.txt_notes.Text = "DbA_TextBox1"
        Me.txt_notes.TextBox_Properties.AcceptsReturn = True
        Me.txt_notes.TextBox_Properties.AcceptsTab = False
        Me.txt_notes.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_notes.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_notes.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_notes.TextBox_Properties.Enabled = True
        Me.txt_notes.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_notes.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_notes.TextBox_Properties.MaximumValue = 999999
        Me.txt_notes.TextBox_Properties.MaxLength = 1200
        Me.txt_notes.TextBox_Properties.MinimumValue = -999999
        Me.txt_notes.TextBox_Properties.MultiLine = True
        Me.txt_notes.TextBox_Properties.PasswordChar = Nothing
        Me.txt_notes.TextBox_Properties.ReadOnly = False
        Me.txt_notes.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_notes.TextBox_Properties.TabStop = True
        Me.txt_notes.TextBox_Properties.Text = ""
        Me.txt_notes.TextBox_Properties.WordWrap = True
        Me.txt_notes.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_first_name
        '
        Me.txt_first_name.AllowNegative = False
        Me.txt_first_name.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_first_name.ColorCursor = True
        Me.txt_first_name.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_first_name.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_first_name.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_first_name.Enabled = False
        Me.txt_first_name.Field_Name = "first_name"
        Me.txt_first_name.GridBinding = Me.grd_display
        Me.txt_first_name.Label_On_Top = True
        Me.txt_first_name.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_first_name.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_first_name.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_first_name.Label_Properties.Text = "First Name"
        Me.txt_first_name.Label_Properties.Width = 500
        Me.txt_first_name.Location = New System.Drawing.Point(195, 16)
        Me.txt_first_name.Mandatory = True
        Me.txt_first_name.Name = "txt_first_name"
        Me.txt_first_name.Override_Modified = False
        Me.txt_first_name.SaveLoadOrder = 0
        Me.txt_first_name.Size = New System.Drawing.Size(184, 40)
        Me.txt_first_name.TabIndex = 1
        Me.txt_first_name.TabStop = False
        Me.txt_first_name.Text = "DbA_TextBox1"
        Me.txt_first_name.TextBox_Properties.AcceptsReturn = False
        Me.txt_first_name.TextBox_Properties.AcceptsTab = False
        Me.txt_first_name.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_first_name.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_first_name.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_first_name.TextBox_Properties.Enabled = True
        Me.txt_first_name.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_first_name.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_first_name.TextBox_Properties.MaximumValue = 999999
        Me.txt_first_name.TextBox_Properties.MaxLength = 100
        Me.txt_first_name.TextBox_Properties.MinimumValue = -999999
        Me.txt_first_name.TextBox_Properties.MultiLine = False
        Me.txt_first_name.TextBox_Properties.PasswordChar = Nothing
        Me.txt_first_name.TextBox_Properties.ReadOnly = False
        Me.txt_first_name.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_first_name.TextBox_Properties.TabStop = True
        Me.txt_first_name.TextBox_Properties.Text = ""
        Me.txt_first_name.TextBox_Properties.WordWrap = True
        Me.txt_first_name.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_delete.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_delete.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_delete.DisplayText = ""
        Me.btn_delete.Enabled = False
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_delete.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Image = CType(resources.GetObject("btn_delete.Image"), System.Drawing.Image)
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.Location = New System.Drawing.Point(385, 8)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(104, 43)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.TabStop = False
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_cancel.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_cancel.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_cancel.DisplayText = ""
        Me.btn_cancel.Enabled = False
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(258, 8)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(104, 43)
        Me.btn_cancel.TabIndex = 2
        Me.btn_cancel.TabStop = False
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_save.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_save.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_save.DisplayText = ""
        Me.btn_save.Enabled = False
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_save.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Location = New System.Drawing.Point(133, 8)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(104, 43)
        Me.btn_save.TabIndex = 1
        Me.btn_save.TabStop = False
        Me.btn_save.Text = "Save"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_new
        '
        Me.btn_new.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_new.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_new.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_new.DisplayText = ""
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_new.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.ForeColor = System.Drawing.Color.Black
        Me.btn_new.Image = CType(resources.GetObject("btn_new.Image"), System.Drawing.Image)
        Me.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_new.Location = New System.Drawing.Point(8, 8)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(104, 43)
        Me.btn_new.TabIndex = 0
        Me.btn_new.TabStop = False
        Me.btn_new.Text = "New"
        Me.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_close.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_close.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_close.DisplayText = ""
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_close.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.Black
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_close.Location = New System.Drawing.Point(512, 8)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(104, 43)
        Me.btn_close.TabIndex = 4
        Me.btn_close.TabStop = False
        Me.btn_close.Text = "Close"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'patient
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(624, 440)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "patient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "patient"
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_main.ResumeLayout(False)
        CType(Me.grd_display, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataRowTemplate1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColumnManagerRow1, System.ComponentModel.ISupportInitialize).EndInit()
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
            Case Keys.F1
                If btn_new.Enabled Then Call Process("NEW")

            Case Keys.F2
                If btn_save.Enabled Then Call Process("SAVE")

            Case Keys.F3
                If btn_cancel.Enabled Then Call Process("CANCEL")

            Case Keys.F4
                If btn_delete.Enabled Then Call Process("DELETE")

            Case Keys.F5
                If btn_physician.Enabled And btn_physician.Visible Then
                    Call Process("PHYSICIAN")
                End If

            Case Keys.F8
                Call Process("CLOSE")

            Case Keys.F9
                Call Process("PRINT")

            Case Keys.F10
                grd_display.Focus()
        End Select

        Select Case keyCode
            Case Keys.F1, Keys.F2, Keys.F3, Keys.F4, _
                Keys.F5, Keys.F8, Keys.F9, Keys.F10
                Return True
        End Select
    End Function
#End Region

#Region " Declarations "
    Dim m_prev_form As Form
    Dim m_close_index As Integer
#End Region

#Region " Button Events "
    Private Sub btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new.Click
        Call Process("NEW")
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Call Process("SAVE")
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Call Process("CANCEL")
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Call Process("DELETE")
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Call Process("CLOSE")
    End Sub

    Private Sub btn_physician_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_physician.Click
        Call Process("PHYSICIAN")
    End Sub
#End Region

#Region " Close Form "
    Private Sub close_form()
        m_prev_form.Show()
        g_framework.g_forms(m_close_index) = Nothing
        Me.Close()
    End Sub
#End Region

#Region " Fill Dropdown "
    Private Sub Fill_Dropdown()
        ' -------------------------
        ' * Fill Physician Dropdown
        ' -------------------------
        dd_physician.SQL_Statement = "SELECT Null As physician_id, '' As Physician " & _
            "UNION " & _
            "SELECT physician_id, " & _
            "last_name + Case When suffix = '' Then '' Else ' ' + suffix End + ', ' + " & _
            "Case When prefix = '' Then '' Else prefix + ' ' End + " & _
            "first_name + Case When IsNull(middle_initial, '') <> '' Then ' ' + middle_initial Else '' End As Physician " & _
            "FROM physician_maint " & _
            "Where stop_use <> 1 " & _
            "ORDER BY Physician"
        dba_load_drop_down(dd_physician)
    End Sub
#End Region

#Region " Fill Grid "
    Private Sub Fill_Grid()
        Dim p_sql As String                 ' String To Hold SQL Statement

        ' ==========================
        ' * Get Dataset To Fill Grid
        ' ==========================
        p_sql = "Select " & pnl_main.DataSettings.IDField & _
                ", P1.last_name + ', ' + P1.first_name + ' ' + P1.middle_initial As Patient, " & _
                "Case When PH1.prefix = '' Then '' Else PH1.prefix + ' ' End + " & _
                "PH1.first_name + ' ' + Case When PH1.middle_initial = '' Then '' Else PH1.middle_initial + ' ' End " & _
                "+ PH1.last_name + ' ' + PH1.suffix As Physician, " & _
                "P1.date_added as [Date Entered] " & _
                "FROM " & pnl_main.DataSettings.TableName & _
                " P1 INNER JOIN physician_maint PH1 On PH1.physician_id = P1.physician_id " & _
                " Order By P1.date_added, P1.last_name, P1.first_name, P1.middle_initial"

        grd_display.SQL = p_sql

        'fill the grid
        Me.dba_fill_grid(grd_display)

        If grd_display.DataRows.Count = 0 Then
            pnl_main.Focus()
        Else
            ' =======================================
            ' * Position Row Selector To Current Item
            ' =======================================
            If Trim(pnl_main.RecordID) <> "" Then
                grd_display.FindInGrid(0, Trim(pnl_main.RecordID), False)
            End If
        End If
    End Sub
#End Region

#Region " Form AfterFillScreen "
    Private Sub Form_AfterFillScreen(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.AfterFillScreen
        Call set_toolbar_buttons("T", "F", "F", "T")
    End Sub
#End Region

#Region " Form Enter "
    Private Sub Form_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        If g_reload_dd Then
            dd_physician.ComboBox_Properties.Text = ""
            dd_physician.ID_Value = ""
            g_framework.dba_load_drop_down(dd_physician)

            ' Get New Physician
            dd_physician.Load_Item(dd_physician.ID_Column_Number, dd_physician.Column_To_Display, g_pass_str2.Replace("{", "").Replace("}", ""))

            g_pass_str2 = ""
            g_reload_dd = False
        End If
    End Sub
#End Region

#Region " Form Load "
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim p_excludes(6) As dba_RemoveControls
        p_excludes(0).Control = btn_close
        p_excludes(1).Control = lbl_F9
        p_excludes(2).Control = lbl_F10

        p_excludes(3).Control = btn_new
        p_excludes(4).Control = btn_save
        p_excludes(5).Control = btn_cancel
        p_excludes(6).Control = btn_delete

        Me.dba_init_form(pnl_main, True, p_excludes, g_is_internal)
        Me.g_focus_fld = txt_last_name.txtbox

        Call size_screen(Me)

        ' ---------------
        ' * Fill Dropdown
        ' ---------------
        Call Fill_Dropdown()

        ' -----------
        ' * Fill Grid
        ' -----------
        Call Fill_Grid()

        grd_display.Insert_Header_Row("Patient List - Use Arrows to Select Record")

        ' -------------------
        ' * Remove Add Button
        ' -------------------
        If Not (g_master Or g_admin) Then
            btn_physician.Visible = False
        End If

        ' ------------------------------------
        ' * Set To New From Patient Run Screen
        ' ------------------------------------
        If UCase(m_prev_form.Name) = "RUN_PATIENT" Then
            Call Process("NEW")
        Else
            If grd_display.DataRows.Count > 0 Then
                grd_display.SelectedRows.Add(grd_display.DataRows(0))
                grd_display.CurrentRow = grd_display.DataRows(0)
            End If
        End If
    End Sub
#End Region

#Region " Pre-Delete Check "
    Private Function delete_record() As Boolean
        Dim p_sql As String                 ' String To Hold SQL Statement
        Dim p_dataset As DataSet            ' Create DataSet Reference

        ' ========================
        ' * Delete Record Selected
        ' ========================

        ' Check That Item Was Selected
        If Trim(pnl_main.RecordID) = "" Then
            Exit Function
        End If

        ' =======================================
        ' * Check For Item ID In Related Table(s)
        ' =======================================
        ' --------------------------
        ' * Check CU Run for Patient
        ' --------------------------
        p_sql = "SELECT Distinct patient_id " & _
                "FROM pre_run_info " & _
                "Where patient_id = '" & pnl_main.RecordID & "'"
        p_dataset = g_framework.Get_Data(p_sql)

        If p_dataset.Tables(0).Rows.Count > 0 Then
            ' Dispose Of Dataset
            p_dataset.Dispose()

            Call message_box("Patient cannot be deleted; currently being processed.", 1, "Delete Cancelled")

            Return False
            Exit Function
        End If

        ' ------------------------------------------------
        ' * Check CU Run Data for Patient - For Error Info
        ' ------------------------------------------------
        p_sql = "SELECT Distinct patient_id " & _
                "FROM run_info_data " & _
                "Where patient_id = '" & pnl_main.RecordID & "'"
        p_dataset = g_framework.Get_Data(p_sql)

        If p_dataset.Tables(0).Rows.Count > 0 Then
            ' ----------------------------
            ' * Move To Processed Patients
            ' ----------------------------
            p_sql = "INSERT INTO processed_patients (patient_id, first_name, last_name, middle_initial, " & _
                    "physician_id, code, notes, date_added, user_added, date_lused, user_lused, processed) " & _
                    "Select patient_id, first_name, last_name, middle_initial, " & _
                    "physician_id, code, notes, date_added, user_added, date_lused, user_lused, getdate() " & _
                    "FROM patient_maint " & _
                    "WHERE patient_id = '" & pnl_main.RecordID & "'"
            Call g_framework.Execute_Query(p_sql)
        End If

        ' Dispose Of Dataset
        p_dataset.Dispose()

        Return True
    End Function
#End Region

#Region " Pre-Save Check "
    Private Function pre_save() As Boolean
        check_mandatory_fields(pnl_main)
        If verify_mandatory() = False Then
            Exit Function
        End If

        Dim p_sql As String                 ' String To Hold SQL Statement
        Dim p_data_set As DataSet           ' Create DataSet Reference

        ' ================================
        ' * Check for existing in add mode
        ' ================================
        p_sql = "Select Distinct " & pnl_main.DataSettings.IDField & _
                " FROM " & pnl_main.DataSettings.TableName & _
                " Where " & txt_first_name.Field_Name & " = " & return_parsed_single_quote_string(txt_first_name.TextBox_Properties.Text) & _
                " And " & txt_last_name.Field_Name & " = " & return_parsed_single_quote_string(txt_last_name.TextBox_Properties.Text) & _
                " And " & txt_mi.Field_Name & " = " & return_parsed_single_quote_string(txt_mi.TextBox_Properties.Text) & _
                " And " & txt_code.Field_Name & " = " & return_parsed_single_quote_string(txt_code.TextBox_Properties.Text)

        If Trim(pnl_main.RecordID) <> "" Then
            p_sql = p_sql & " And " & pnl_main.DataSettings.IDField & " <> '" & Trim(pnl_main.RecordID) & "'"
        End If

        p_data_set = g_framework.Get_Data(p_sql)

        ' ==================================
        ' * Check If Value Entered Was Found
        ' ==================================
        If p_data_set.Tables(0).Rows.Count > 0 Then
            Call message_box("The Patient entered already exists!", 1, "Message To User")

            ' Dispose of Dataset
            p_data_set.Dispose()

            Return False
            Exit Function
        End If

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        ' Dispose of Dataset
        p_data_set.Dispose()

        Return True
    End Function
#End Region

#Region " Print List "
    Private Sub print_list()
        If message_box("Continue printing list?", 2, "Confirm Print") = MsgBoxResult.No Then Exit Sub

        Try
            Dim p_print As New CUSPrint.DatasetPrinting(g_PrintPort)
            Dim p_sql As String
            Dim p_dataset As DataSet

            p_sql = "Select P1.last_name + ', ' + P1.first_name + ' ' + P1.middle_initial As Patient, " & _
                    "Case When PH1.prefix = '' Then '' Else PH1.prefix + ' ' End + " & _
                    "PH1.first_name + ' ' + Case When PH1.middle_initial = '' Then '' Else PH1.middle_initial + ' ' End " & _
                    "+ PH1.last_name + ' ' + PH1.suffix As Physician, " & _
                    "P1.date_added as [Date Entered] " & _
                    "FROM " & pnl_main.DataSettings.TableName & _
                    " P1 INNER JOIN physician_maint PH1 On PH1.physician_id = P1.physician_id " & _
                    " Order By P1.date_added, P1.last_name, P1.first_name, P1.middle_initial"
            p_dataset = g_framework.Get_Data(p_sql)

            With p_print
                .DataSetToPrint = p_dataset
                .ReportTitle = "Patient List"
                .Print()
            End With

        Catch
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Call message_box("Bad printer connection.", 4, "Print Error")
        End Try
    End Sub
#End Region

#Region " Process "
    Private Sub Process(ByVal p_type As String)
        If g_fill_screen Then Exit Sub

        Select Case UCase(p_type)
            Case "NEW"
                dba_new_record(pnl_main)
                Call set_toolbar_buttons("F", "T", "T", "F")
                grd_display.Enabled = False

            Case "SAVE"
                If pre_save() = False Then Exit Sub

                grd_display.Enabled = True
                If dba_save_record(pnl_main) Then
                    Call set_toolbar_buttons("T", "F", "F", "T")
                    Me.g_focus_fld.Focus()

                    ' ------------------------------
                    ' * Set Flag For Dropdown Reload
                    ' ------------------------------
                    If UCase(m_prev_form.Name) = "RUN_PATIENT" Then
                        g_reload_dd = True
                        g_pass_str2 = pnl_main.RecordID
                    End If
                End If

            Case "CANCEL"
                dba_cancel_record(pnl_main)

                grd_display.Enabled = True
                If pnl_main.RecordID <> "" Then
                    Call set_toolbar_buttons("T", "F", "F", "T")
                    Me.g_focus_fld.Focus()
                Else
                    Call set_toolbar_buttons("T", "F", "F", "F")
                    If grd_display.DataRows.Count > 0 Then
                        grd_display.SelectedRows.Add(grd_display.DataRows(0))
                        grd_display.CurrentRow = grd_display.DataRows(0)
                        grd_display.Focus()
                    End If
                End If

                If grd_display.DataRows.Count < 1 Then
                    pnl_main.Focus()
                End If

            Case "DELETE"
                If delete_record() = False Then Exit Sub

                If dba_delete_record(pnl_main) Then
                    Call Fill_Grid()
                    Call set_toolbar_buttons("T", "F", "F", "F")

                    ' ------------------------------
                    ' * Set Flag For Dropdown Reload
                    ' ------------------------------
                    If UCase(m_prev_form.Name) = "RUN_PATIENT" Then
                        g_reload_dd = True
                        g_pass_str2 = ""
                    End If
                End If

                If grd_display.DataRows.Count > 0 Then
                    grd_display.SelectedRows.Add(grd_display.DataRows(0))
                    grd_display.CurrentRow = grd_display.DataRows(0)
                    grd_display.Focus()
                Else
                    pnl_main.Focus()
                End If

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

            Case "PHYSICIAN"
                g_framework.g_forms(m_close_index + 1) = New physician(g_framework.g_db_name, Me, m_close_index + 1)
                g_framework.g_forms(m_close_index + 1).MdiParent = g_mdi_form
                g_framework.g_forms(m_close_index + 1).Show()

                Me.Hide()

            Case "PRINT"
                If grd_display.DataRows.Count = 0 Then Exit Sub
                Call print_list()
        End Select
    End Sub
#End Region

#Region " Set Buttons "
    Private Sub set_toolbar_buttons(ByVal p_add_status As String, ByVal p_save_status As String, _
        ByVal p_cancel_status As String, ByVal p_delete_status As String)

        ' =============================================
        ' * Enable/Disable Toolbar Buttons As Requested
        ' =============================================

        ' Set Add Button
        If p_add_status <> "" Then
            btn_new.Enabled = IIf(p_add_status = "T", True, False)
        End If

        ' Set Save Button
        If p_save_status <> "" Then
            btn_save.Enabled = IIf(p_save_status = "T", True, False)
        End If

        ' Set Cancel Button
        If p_cancel_status <> "" Then
            btn_cancel.Enabled = IIf(p_cancel_status = "T", True, False)
        End If

        ' Set Delete Button
        If p_delete_status <> "" Then
            btn_delete.Enabled = IIf(p_delete_status = "T", True, False)
        End If
    End Sub
#End Region

#Region " Screen Object Events "

#Region " Dropdown Events "
    Private Sub dd_physician_AfterItemSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dd_physician.AfterItemSelected
        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("", "T", "T", "")
    End Sub
#End Region

#Region " Grid Events "
    Private Sub grd_display_TabPressed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_display.TabPressed
        Me.g_focus_fld.Focus()
    End Sub
#End Region

#Region " Textbox Events "
    Private Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        txt_first_name.TextBox_TextChanged, txt_mi.TextBox_TextChanged, _
        txt_last_name.TextBox_TextChanged, txt_code.TextBox_TextChanged, _
        txt_notes.TextBox_TextChanged

        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("", "T", "T", "")
    End Sub
#End Region

#End Region

End Class
