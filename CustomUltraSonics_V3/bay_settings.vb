Public Class bay_settings
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
    Friend WithEvents txt_title As DBA.Library.DBA_TextBox
    Friend WithEvents btn_cancel As DBA.Library.DBA_Button
    Friend WithEvents btn_save As DBA.Library.DBA_Button
    Friend WithEvents btn_close As DBA.Library.DBA_Button
    Friend WithEvents txt_bay As DBA.Library.DBA_TextBox
    Friend WithEvents lbl_info As DBA.Library.DBA_Label
    Friend WithEvents lbl_F10 As DBA.Library.DBA_Label
    Friend WithEvents chk_heat As DBA.Library.DBA_CheckBox
    Friend WithEvents pnl_info As DBA.Library.DBA_Panel
    Private WithEvents grd_bays As DBA.Library.DBA_StyleGrid
    Private WithEvents GroupByRow1 As Xceed.Grid.GroupByRow
    Private WithEvents ColumnManagerRow1 As Xceed.Grid.ColumnManagerRow
    Private WithEvents dataRowTemplate1 As Xceed.Grid.DataRow
    Friend WithEvents tlb_main As DBA.Library.DBA_StyleToolbar
    Friend WithEvents dd_pinouts As DBA.Library.DBA_StyleComboBox
    Friend WithEvents dd_detergent As DBA.Library.DBA_StyleComboBox
    Friend WithEvents dd_liquid As DBA.Library.DBA_StyleComboBox
    Friend WithEvents dd_profiles As DBA.Library.DBA_StyleComboBox
    Friend WithEvents dd_guidelines As DBA.Library.DBA_StyleComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bay_settings))
        Me.pnl_main = New DBA.Library.DBA_Panel
        Me.tlb_main = New DBA.Library.DBA_StyleToolbar
        Me.grd_bays = New DBA.Library.DBA_StyleGrid
        Me.dataRowTemplate1 = New Xceed.Grid.DataRow
        Me.GroupByRow1 = New Xceed.Grid.GroupByRow
        Me.ColumnManagerRow1 = New Xceed.Grid.ColumnManagerRow
        Me.pnl_info = New DBA.Library.DBA_Panel
        Me.dd_guidelines = New DBA.Library.DBA_StyleComboBox
        Me.dd_profiles = New DBA.Library.DBA_StyleComboBox
        Me.dd_liquid = New DBA.Library.DBA_StyleComboBox
        Me.dd_detergent = New DBA.Library.DBA_StyleComboBox
        Me.dd_pinouts = New DBA.Library.DBA_StyleComboBox
        Me.txt_title = New DBA.Library.DBA_TextBox
        Me.chk_heat = New DBA.Library.DBA_CheckBox
        Me.txt_bay = New DBA.Library.DBA_TextBox
        Me.lbl_F10 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_info = New DBA.Library.DBA_Label(Me.components)
        Me.btn_cancel = New DBA.Library.DBA_Button(Me.components)
        Me.btn_save = New DBA.Library.DBA_Button(Me.components)
        Me.btn_close = New DBA.Library.DBA_Button(Me.components)
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_main.SuspendLayout()
        CType(Me.grd_bays, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnl_main.Controls.Add(Me.tlb_main)
        Me.pnl_main.Controls.Add(Me.grd_bays)
        Me.pnl_main.Controls.Add(Me.pnl_info)
        Me.pnl_main.Controls.Add(Me.lbl_F10)
        Me.pnl_main.Controls.Add(Me.lbl_info)
        Me.pnl_main.Controls.Add(Me.btn_cancel)
        Me.pnl_main.Controls.Add(Me.btn_save)
        Me.pnl_main.Controls.Add(Me.btn_close)
        Me.pnl_main.DataSettings.IDField = "bay_settings_id"
        Me.pnl_main.DataSettings.JoinData = Nothing
        Me.pnl_main.DataSettings.LinkField = Nothing
        Me.pnl_main.DataSettings.TableName = "bay_settings"
        Me.pnl_main.Gradient = False
        Me.pnl_main.Location = New System.Drawing.Point(0, 0)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.RecordID = Nothing
        Me.pnl_main.Saved = False
        Me.pnl_main.Size = New System.Drawing.Size(624, 443)
        Me.pnl_main.TabIndex = 0
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
        Me.tlb_main.TabIndex = 30
        Me.tlb_main.TabStop = False
        Me.tlb_main.ToolBarCustom = Nothing
        Me.tlb_main.ToolbarDisplayType = DBA.Library.DBA_StyleToolbar.DisplayType.IconsOnSide
        Me.tlb_main.ToolBarType = DBA.Library.DBA_StyleToolbar.DBA_ToolBarType.Normal
        Me.tlb_main.Visible = False
        '
        'grd_bays
        '
        Me.grd_bays.AllowCellNavigation = False
        Me.grd_bays.AllowGrouping = False
        Me.grd_bays.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grd_bays.AutoFitColumns = True
        Me.grd_bays.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grd_bays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grd_bays.DataRowTemplate = Me.dataRowTemplate1
        Me.grd_bays.DataSettings.IDField = Nothing
        Me.grd_bays.DataSettings.TableName = Nothing
        Me.grd_bays.DataSource = Nothing
        '
        '
        '
        Me.grd_bays.FixedColumnSplitter.Visible = False
        Me.grd_bays.FixedHeaderRows.Add(Me.GroupByRow1)
        Me.grd_bays.FixedHeaderRows.Add(Me.ColumnManagerRow1)
        Me.grd_bays.LinkSettings.IsMainGrid = True
        Me.grd_bays.LinkSettings.RecordContainer = Me.pnl_main
        Me.grd_bays.Location = New System.Drawing.Point(10, 66)
        Me.grd_bays.Name = "grd_bays"
        Me.grd_bays.ReadOnly = True
        Me.grd_bays.SelectionMode = System.Windows.Forms.SelectionMode.One
        Me.grd_bays.Size = New System.Drawing.Size(144, 325)
        Me.grd_bays.SQL = Nothing
        Me.grd_bays.TabIndex = 0
        Me.grd_bays.UIStyle = Xceed.UI.UIStyle.ResourceAssembly
        '
        'GroupByRow1
        '
        Me.GroupByRow1.Visible = False
        '
        'pnl_info
        '
        Me.pnl_info.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnl_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_info.Controls.Add(Me.dd_guidelines)
        Me.pnl_info.Controls.Add(Me.dd_profiles)
        Me.pnl_info.Controls.Add(Me.dd_liquid)
        Me.pnl_info.Controls.Add(Me.dd_detergent)
        Me.pnl_info.Controls.Add(Me.dd_pinouts)
        Me.pnl_info.Controls.Add(Me.txt_title)
        Me.pnl_info.Controls.Add(Me.chk_heat)
        Me.pnl_info.Controls.Add(Me.txt_bay)
        Me.pnl_info.DataSettings.IDField = Nothing
        Me.pnl_info.DataSettings.JoinData = Nothing
        Me.pnl_info.DataSettings.LinkField = Nothing
        Me.pnl_info.DataSettings.TableName = Nothing
        Me.pnl_info.Gradient = False
        Me.pnl_info.Location = New System.Drawing.Point(156, 66)
        Me.pnl_info.Name = "pnl_info"
        Me.pnl_info.RecordID = Nothing
        Me.pnl_info.Saved = False
        Me.pnl_info.Size = New System.Drawing.Size(459, 325)
        Me.pnl_info.TabIndex = 1
        '
        'dd_guidelines
        '
        Me.dd_guidelines.ColorCursor = True
        Me.dd_guidelines.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dd_guidelines.Column_To_Display = 1
        Me.dd_guidelines.ComboBox_Properties.AllowFreeText = False
        Me.dd_guidelines.ComboBox_Properties.ColumnWidthAdjustment = Xceed.Editors.ColumnWidthAdjustment.None
        Me.dd_guidelines.ComboBox_Properties.CompareType = CType((Xceed.Editors.CompareType.CaseInsensitive Or Xceed.Editors.CompareType.AccentInsensitive), Xceed.Editors.CompareType)
        Me.dd_guidelines.ComboBox_Properties.Cursor = System.Windows.Forms.Cursors.Default
        Me.dd_guidelines.ComboBox_Properties.DropDownResizable = False
        Me.dd_guidelines.ComboBox_Properties.Enabled = True
        Me.dd_guidelines.ComboBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd_guidelines.ComboBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_guidelines.ComboBox_Properties.IntegralHeight = True
        Me.dd_guidelines.ComboBox_Properties.MaxDropDownItems = 8
        Me.dd_guidelines.ComboBox_Properties.Text = ""
        Me.dd_guidelines.ComboBox_Properties.TextBoxArea_BackColor = System.Drawing.Color.White
        Me.dd_guidelines.ComboBox_Properties.TextBoxArea_TabStop = True
        Me.dd_guidelines.DataSet = Nothing
        Me.dd_guidelines.DataType = DBA.Library.DBA_StyleComboBox.DBA_data_type.DBA_UID
        Me.dd_guidelines.DisplayFieldName = Nothing
        Me.dd_guidelines.DisplayFieldSQL = Nothing
        Me.dd_guidelines.DisplayFieldTable = Nothing
        Me.dd_guidelines.DisplayFieldTableJoin = Nothing
        Me.dd_guidelines.Enabled = False
        Me.dd_guidelines.Field_Name = "guideline_id"
        Me.dd_guidelines.GridBinding = Me.grd_bays
        Me.dd_guidelines.ID_Column_Number = 0
        Me.dd_guidelines.ID_Value = Nothing
        Me.dd_guidelines.Label_On_Top = False
        Me.dd_guidelines.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.dd_guidelines.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.dd_guidelines.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_guidelines.Label_Properties.Text = "Guideline"
        Me.dd_guidelines.Label_Properties.Width = 60
        Me.dd_guidelines.Location = New System.Drawing.Point(46, 275)
        Me.dd_guidelines.Mandatory = True
        Me.dd_guidelines.Name = "dd_guidelines"
        Me.dd_guidelines.SaveLoadOrder = 0
        Me.dd_guidelines.SaveType = DBA.Library.DBA_StyleComboBox.DbA_SaveType.UID
        Me.dd_guidelines.Size = New System.Drawing.Size(391, 26)
        Me.dd_guidelines.SQL_Statement = Nothing
        Me.dd_guidelines.TabIndex = 7
        '
        'dd_profiles
        '
        Me.dd_profiles.ColorCursor = True
        Me.dd_profiles.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dd_profiles.Column_To_Display = 1
        Me.dd_profiles.ComboBox_Properties.AllowFreeText = False
        Me.dd_profiles.ComboBox_Properties.ColumnWidthAdjustment = Xceed.Editors.ColumnWidthAdjustment.None
        Me.dd_profiles.ComboBox_Properties.CompareType = CType((Xceed.Editors.CompareType.CaseInsensitive Or Xceed.Editors.CompareType.AccentInsensitive), Xceed.Editors.CompareType)
        Me.dd_profiles.ComboBox_Properties.Cursor = System.Windows.Forms.Cursors.Default
        Me.dd_profiles.ComboBox_Properties.DropDownResizable = False
        Me.dd_profiles.ComboBox_Properties.Enabled = True
        Me.dd_profiles.ComboBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd_profiles.ComboBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_profiles.ComboBox_Properties.IntegralHeight = True
        Me.dd_profiles.ComboBox_Properties.MaxDropDownItems = 8
        Me.dd_profiles.ComboBox_Properties.Text = ""
        Me.dd_profiles.ComboBox_Properties.TextBoxArea_BackColor = System.Drawing.Color.White
        Me.dd_profiles.ComboBox_Properties.TextBoxArea_TabStop = True
        Me.dd_profiles.DataSet = Nothing
        Me.dd_profiles.DataType = DBA.Library.DBA_StyleComboBox.DBA_data_type.DBA_UID
        Me.dd_profiles.DisplayFieldName = Nothing
        Me.dd_profiles.DisplayFieldSQL = Nothing
        Me.dd_profiles.DisplayFieldTable = Nothing
        Me.dd_profiles.DisplayFieldTableJoin = Nothing
        Me.dd_profiles.Enabled = False
        Me.dd_profiles.Field_Name = "profile_id"
        Me.dd_profiles.GridBinding = Me.grd_bays
        Me.dd_profiles.ID_Column_Number = 0
        Me.dd_profiles.ID_Value = Nothing
        Me.dd_profiles.Label_On_Top = False
        Me.dd_profiles.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.dd_profiles.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.dd_profiles.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_profiles.Label_Properties.Text = "Profile"
        Me.dd_profiles.Label_Properties.Width = 45
        Me.dd_profiles.Location = New System.Drawing.Point(61, 228)
        Me.dd_profiles.Mandatory = True
        Me.dd_profiles.Name = "dd_profiles"
        Me.dd_profiles.SaveLoadOrder = 0
        Me.dd_profiles.SaveType = DBA.Library.DBA_StyleComboBox.DbA_SaveType.UID
        Me.dd_profiles.Size = New System.Drawing.Size(376, 26)
        Me.dd_profiles.SQL_Statement = Nothing
        Me.dd_profiles.TabIndex = 6
        '
        'dd_liquid
        '
        Me.dd_liquid.ColorCursor = True
        Me.dd_liquid.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dd_liquid.Column_To_Display = 1
        Me.dd_liquid.ComboBox_Properties.AllowFreeText = False
        Me.dd_liquid.ComboBox_Properties.ColumnWidthAdjustment = Xceed.Editors.ColumnWidthAdjustment.None
        Me.dd_liquid.ComboBox_Properties.CompareType = CType((Xceed.Editors.CompareType.CaseInsensitive Or Xceed.Editors.CompareType.AccentInsensitive), Xceed.Editors.CompareType)
        Me.dd_liquid.ComboBox_Properties.Cursor = System.Windows.Forms.Cursors.Default
        Me.dd_liquid.ComboBox_Properties.DropDownResizable = False
        Me.dd_liquid.ComboBox_Properties.Enabled = True
        Me.dd_liquid.ComboBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd_liquid.ComboBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_liquid.ComboBox_Properties.IntegralHeight = True
        Me.dd_liquid.ComboBox_Properties.MaxDropDownItems = 8
        Me.dd_liquid.ComboBox_Properties.Text = ""
        Me.dd_liquid.ComboBox_Properties.TextBoxArea_BackColor = System.Drawing.Color.White
        Me.dd_liquid.ComboBox_Properties.TextBoxArea_TabStop = True
        Me.dd_liquid.DataSet = Nothing
        Me.dd_liquid.DataType = DBA.Library.DBA_StyleComboBox.DBA_data_type.DBA_UID
        Me.dd_liquid.DisplayFieldName = "liquid_sterilant"
        Me.dd_liquid.DisplayFieldSQL = Nothing
        Me.dd_liquid.DisplayFieldTable = "liquid_sterilant_maint"
        Me.dd_liquid.DisplayFieldTableJoin = Nothing
        Me.dd_liquid.Enabled = False
        Me.dd_liquid.Field_Name = "liquid_sterilant_id"
        Me.dd_liquid.GridBinding = Me.grd_bays
        Me.dd_liquid.ID_Column_Number = 0
        Me.dd_liquid.ID_Value = Nothing
        Me.dd_liquid.Label_On_Top = False
        Me.dd_liquid.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.dd_liquid.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.dd_liquid.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_liquid.Label_Properties.Text = "Liquid Sterilant"
        Me.dd_liquid.Label_Properties.Width = 100
        Me.dd_liquid.Location = New System.Drawing.Point(6, 181)
        Me.dd_liquid.Mandatory = True
        Me.dd_liquid.Name = "dd_liquid"
        Me.dd_liquid.SaveLoadOrder = 0
        Me.dd_liquid.SaveType = DBA.Library.DBA_StyleComboBox.DbA_SaveType.UID
        Me.dd_liquid.Size = New System.Drawing.Size(431, 26)
        Me.dd_liquid.SQL_Statement = Nothing
        Me.dd_liquid.TabIndex = 5
        '
        'dd_detergent
        '
        Me.dd_detergent.ColorCursor = True
        Me.dd_detergent.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dd_detergent.Column_To_Display = 1
        Me.dd_detergent.ComboBox_Properties.AllowFreeText = False
        Me.dd_detergent.ComboBox_Properties.ColumnWidthAdjustment = Xceed.Editors.ColumnWidthAdjustment.None
        Me.dd_detergent.ComboBox_Properties.CompareType = CType((Xceed.Editors.CompareType.CaseInsensitive Or Xceed.Editors.CompareType.AccentInsensitive), Xceed.Editors.CompareType)
        Me.dd_detergent.ComboBox_Properties.Cursor = System.Windows.Forms.Cursors.Default
        Me.dd_detergent.ComboBox_Properties.DropDownResizable = False
        Me.dd_detergent.ComboBox_Properties.Enabled = True
        Me.dd_detergent.ComboBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd_detergent.ComboBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_detergent.ComboBox_Properties.IntegralHeight = True
        Me.dd_detergent.ComboBox_Properties.MaxDropDownItems = 8
        Me.dd_detergent.ComboBox_Properties.Text = ""
        Me.dd_detergent.ComboBox_Properties.TextBoxArea_BackColor = System.Drawing.Color.White
        Me.dd_detergent.ComboBox_Properties.TextBoxArea_TabStop = True
        Me.dd_detergent.DataSet = Nothing
        Me.dd_detergent.DataType = DBA.Library.DBA_StyleComboBox.DBA_data_type.DBA_UID
        Me.dd_detergent.DisplayFieldName = "detergent"
        Me.dd_detergent.DisplayFieldSQL = Nothing
        Me.dd_detergent.DisplayFieldTable = "detergent_maint"
        Me.dd_detergent.DisplayFieldTableJoin = Nothing
        Me.dd_detergent.Enabled = False
        Me.dd_detergent.Field_Name = "detergent_id"
        Me.dd_detergent.GridBinding = Me.grd_bays
        Me.dd_detergent.ID_Column_Number = 0
        Me.dd_detergent.ID_Value = Nothing
        Me.dd_detergent.Label_On_Top = False
        Me.dd_detergent.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.dd_detergent.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.dd_detergent.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_detergent.Label_Properties.Text = "Detergent"
        Me.dd_detergent.Label_Properties.Width = 75
        Me.dd_detergent.Location = New System.Drawing.Point(31, 120)
        Me.dd_detergent.Mandatory = True
        Me.dd_detergent.Name = "dd_detergent"
        Me.dd_detergent.SaveLoadOrder = 0
        Me.dd_detergent.SaveType = DBA.Library.DBA_StyleComboBox.DbA_SaveType.UID
        Me.dd_detergent.Size = New System.Drawing.Size(406, 26)
        Me.dd_detergent.SQL_Statement = Nothing
        Me.dd_detergent.TabIndex = 3
        '
        'dd_pinouts
        '
        Me.dd_pinouts.ColorCursor = True
        Me.dd_pinouts.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dd_pinouts.Column_To_Display = 1
        Me.dd_pinouts.ComboBox_Properties.AllowFreeText = False
        Me.dd_pinouts.ComboBox_Properties.ColumnWidthAdjustment = Xceed.Editors.ColumnWidthAdjustment.None
        Me.dd_pinouts.ComboBox_Properties.CompareType = CType((Xceed.Editors.CompareType.CaseInsensitive Or Xceed.Editors.CompareType.AccentInsensitive), Xceed.Editors.CompareType)
        Me.dd_pinouts.ComboBox_Properties.Cursor = System.Windows.Forms.Cursors.Default
        Me.dd_pinouts.ComboBox_Properties.DropDownResizable = False
        Me.dd_pinouts.ComboBox_Properties.Enabled = True
        Me.dd_pinouts.ComboBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd_pinouts.ComboBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_pinouts.ComboBox_Properties.IntegralHeight = True
        Me.dd_pinouts.ComboBox_Properties.MaxDropDownItems = 8
        Me.dd_pinouts.ComboBox_Properties.Text = ""
        Me.dd_pinouts.ComboBox_Properties.TextBoxArea_BackColor = System.Drawing.Color.White
        Me.dd_pinouts.ComboBox_Properties.TextBoxArea_TabStop = True
        Me.dd_pinouts.DataSet = Nothing
        Me.dd_pinouts.DataType = DBA.Library.DBA_StyleComboBox.DBA_data_type.DBA_UID
        Me.dd_pinouts.DisplayFieldName = Nothing
        Me.dd_pinouts.DisplayFieldSQL = Nothing
        Me.dd_pinouts.DisplayFieldTable = Nothing
        Me.dd_pinouts.DisplayFieldTableJoin = Nothing
        Me.dd_pinouts.Enabled = False
        Me.dd_pinouts.Field_Name = "pinout_id"
        Me.dd_pinouts.GridBinding = Me.grd_bays
        Me.dd_pinouts.ID_Column_Number = 0
        Me.dd_pinouts.ID_Value = Nothing
        Me.dd_pinouts.Label_On_Top = False
        Me.dd_pinouts.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.dd_pinouts.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.dd_pinouts.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_pinouts.Label_Properties.Text = "Pin Out"
        Me.dd_pinouts.Label_Properties.Width = 50
        Me.dd_pinouts.Location = New System.Drawing.Point(277, 74)
        Me.dd_pinouts.Mandatory = True
        Me.dd_pinouts.Name = "dd_pinouts"
        Me.dd_pinouts.SaveLoadOrder = 0
        Me.dd_pinouts.SaveType = DBA.Library.DBA_StyleComboBox.DbA_SaveType.UID
        Me.dd_pinouts.Size = New System.Drawing.Size(160, 26)
        Me.dd_pinouts.SQL_Statement = Nothing
        Me.dd_pinouts.TabIndex = 2
        '
        'txt_title
        '
        Me.txt_title.AllowNegative = False
        Me.txt_title.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_title.ColorCursor = True
        Me.txt_title.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_title.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_title.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_title.Enabled = False
        Me.txt_title.Field_Name = "title"
        Me.txt_title.GridBinding = Me.grd_bays
        Me.txt_title.Label_On_Top = False
        Me.txt_title.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_title.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_title.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_title.Label_Properties.Text = "Title"
        Me.txt_title.Label_Properties.Width = 45
        Me.txt_title.Location = New System.Drawing.Point(61, 74)
        Me.txt_title.Mandatory = True
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Override_Modified = False
        Me.txt_title.SaveLoadOrder = 0
        Me.txt_title.Size = New System.Drawing.Size(212, 26)
        Me.txt_title.TabIndex = 1
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
        Me.txt_title.TextBox_Properties.ReadOnly = False
        Me.txt_title.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_title.TextBox_Properties.TabStop = True
        Me.txt_title.TextBox_Properties.Text = ""
        Me.txt_title.TextBox_Properties.WordWrap = True
        Me.txt_title.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'chk_heat
        '
        Me.chk_heat.BackColor = System.Drawing.Color.PapayaWhip
        Me.chk_heat.Caption = "DBA"
        Me.chk_heat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chk_heat.Enabled = False
        Me.chk_heat.Field_Name = "heating"
        Me.chk_heat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_heat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chk_heat.ForeColor = System.Drawing.Color.Black
        Me.chk_heat.GridBinding = Me.grd_bays
        Me.chk_heat.Location = New System.Drawing.Point(108, 145)
        Me.chk_heat.Mandatory = False
        Me.chk_heat.Name = "chk_heat"
        Me.chk_heat.SaveLoadOrder = 0
        Me.chk_heat.Size = New System.Drawing.Size(156, 18)
        Me.chk_heat.TabIndex = 4
        Me.chk_heat.Text = "Reservoir/Bay Heating"
        Me.chk_heat.UseVisualStyleBackColor = False
        '
        'txt_bay
        '
        Me.txt_bay.AllowNegative = False
        Me.txt_bay.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_bay.ColorCursor = False
        Me.txt_bay.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_bay.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_bay.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_bay.Enabled = False
        Me.txt_bay.Field_Name = "bay_number"
        Me.txt_bay.GridBinding = Me.grd_bays
        Me.txt_bay.Label_On_Top = False
        Me.txt_bay.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_bay.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bay.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_bay.Label_Properties.Text = "Bay #"
        Me.txt_bay.Label_Properties.Width = 40
        Me.txt_bay.Location = New System.Drawing.Point(66, 27)
        Me.txt_bay.Mandatory = False
        Me.txt_bay.Name = "txt_bay"
        Me.txt_bay.Override_Modified = False
        Me.txt_bay.SaveLoadOrder = 0
        Me.txt_bay.Size = New System.Drawing.Size(148, 26)
        Me.txt_bay.TabIndex = 0
        Me.txt_bay.TabStop = False
        Me.txt_bay.Text = "DbA_TextBox1"
        Me.txt_bay.TextBox_Properties.AcceptsReturn = False
        Me.txt_bay.TextBox_Properties.AcceptsTab = False
        Me.txt_bay.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_bay.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bay.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_bay.TextBox_Properties.Enabled = True
        Me.txt_bay.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bay.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_bay.TextBox_Properties.MaximumValue = 999999
        Me.txt_bay.TextBox_Properties.MaxLength = 50
        Me.txt_bay.TextBox_Properties.MinimumValue = -999999
        Me.txt_bay.TextBox_Properties.MultiLine = False
        Me.txt_bay.TextBox_Properties.PasswordChar = Nothing
        Me.txt_bay.TextBox_Properties.ReadOnly = True
        Me.txt_bay.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_bay.TextBox_Properties.TabStop = True
        Me.txt_bay.TextBox_Properties.Text = ""
        Me.txt_bay.TextBox_Properties.WordWrap = True
        Me.txt_bay.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'lbl_F10
        '
        Me.lbl_F10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_F10.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_F10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_F10.ForeColor = System.Drawing.Color.Black
        Me.lbl_F10.Location = New System.Drawing.Point(469, 23)
        Me.lbl_F10.Name = "lbl_F10"
        Me.lbl_F10.Size = New System.Drawing.Size(136, 22)
        Me.lbl_F10.TabIndex = 29
        Me.lbl_F10.Text = "F10 - Access Main Grid"
        Me.lbl_F10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_F10.UseMnemonic = False
        '
        'lbl_info
        '
        Me.lbl_info.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_info.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_info.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info.ForeColor = System.Drawing.Color.Black
        Me.lbl_info.Location = New System.Drawing.Point(14, 406)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(602, 22)
        Me.lbl_info.TabIndex = 28
        Me.lbl_info.Text = "Enter to select record.  Use tab/arrow keys to move around.  Press spacebar for checkbox edit."
        Me.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_info.UseMnemonic = False
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
        Me.btn_cancel.Location = New System.Drawing.Point(135, 12)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(104, 43)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.TabStop = False
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancel.UseVisualStyleBackColor = False
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
        Me.btn_save.Location = New System.Drawing.Point(11, 12)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(104, 43)
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
        Me.btn_close.Location = New System.Drawing.Point(259, 12)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(104, 43)
        Me.btn_close.TabIndex = 4
        Me.btn_close.TabStop = False
        Me.btn_close.Text = "Close"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'bay_settings
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(624, 440)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "bay_settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "bay_settings"
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_main.ResumeLayout(False)
        CType(Me.grd_bays, System.ComponentModel.ISupportInitialize).EndInit()
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
            Case Keys.F2
                If btn_save.Enabled Then Call Process("SAVE")

            Case Keys.F3
                If btn_cancel.Enabled Then Call Process("CANCEL")

            Case Keys.F8
                Call Process("CLOSE")

            Case Keys.F10
                grd_bays.Focus()
        End Select

        Select Case keyCode
            Case Keys.F2, Keys.F3, Keys.F4, Keys.F8, Keys.F10
                Return True
        End Select
    End Function
#End Region

#Region " Declarations "
    Dim m_res_temp_flag As Boolean
    Dim m_prev_form As Form
    Dim m_close_index As Integer
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
        g_framework.g_forms(m_close_index) = Nothing
        Me.Close()
    End Sub
#End Region

#Region " Fill Dropdowns "
    Private Sub Fill_Dropdowns()
        ' ---------
        ' * Pinouts
        ' ---------
        dd_pinouts.SQL_Statement = "SELECT Distinct pinout_id, Pinout " & _
                                   "FROM pinouts " & _
                                   "Order by pinout"
        g_framework.dba_load_drop_down(dd_pinouts)

        ' ------------
        ' * Detergents
        ' ------------
        dd_detergent.SQL_Statement = "SELECT Distinct detergent_id, Detergent " & _
                                     "FROM detergent_maint " & _
                                     "Where stop_use <> 1 " & _
                                     "Order by detergent"
        g_framework.dba_load_drop_down(dd_detergent)

        ' -------------------
        ' * Liquid Sterilants
        ' -------------------
        dd_liquid.SQL_Statement = "SELECT Distinct liquid_sterilant_id, liquid_sterilant As [Liquid Sterilant] " & _
                                  "FROM liquid_sterilant_maint " & _
                                  "Where stop_use <> 1 " & _
                                  "Order by liquid_sterilant"
        g_framework.dba_load_drop_down(dd_liquid)

        ' ------------
        ' * Guidelines
        ' ------------
        dd_guidelines.SQL_Statement = "SELECT Distinct guideline_id, Guideline " & _
                                      "FROM guideline_maint " & _
                                      "Order by guideline"
        g_framework.dba_load_drop_down(dd_guidelines)

        ' ----------
        ' * Profiles
        ' ----------
        dd_profiles.SQL_Statement = "SELECT Distinct profile_id, profile_name As [Profile] " & _
                                   "FROM profile_maint " & _
                                   "Order by profile_name"
        g_framework.dba_load_drop_down(dd_profiles)
    End Sub
#End Region

#Region " Fill Grid "
    Private Sub Fill_Grid()
        Dim p_sql As String                 ' String To Hold SQL Statement
        Dim p_dataset As DataSet

        p_sql = "Select num_of_systems From settings_maint"
        p_dataset = g_framework.Get_Data(p_sql)

        If p_dataset.Tables(0).Rows.Count > 0 Then
            ' ==========================
            ' * Get Dataset To Fill Grid
            ' ==========================
            p_sql = "Select (Select bay_settings_id From bay_settings where bay_number = 1) As id, 1 As [Bay #] "

            For p_x As Integer = 2 To p_dataset.Tables(0).Rows(0).Item(0)
                p_sql &= "UNION Select (Select bay_settings_id From bay_settings " & _
                         "Where bay_number = " & p_x & ") As id, " & p_x & " As [Bay #] "
            Next
            p_sql &= " Order By [Bay #]"

            grd_bays.SQL = p_sql

            'fill the grid
            Me.dba_fill_grid(grd_bays)

            ' =======================================
            ' * Position Row Selector To Current Item
            ' =======================================
            If Trim(pnl_main.RecordID) <> "" Then
                grd_bays.FindInGrid(0, Trim(pnl_main.RecordID.Replace("{", "").Replace("}", "")), False)
            End If
        End If

        ' Dispose of Dataset
        p_dataset.Dispose()
    End Sub
#End Region

#Region " Form AfterFillScreen "
    Private Sub Form_AfterFillScreen(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.AfterFillScreen
        Call set_toolbar_buttons("F", "F")
    End Sub
#End Region

#Region " Form Load "
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim p_excludes(4) As dba_RemoveControls
        p_excludes(0).Control = btn_close
        p_excludes(1).Control = lbl_info
        p_excludes(2).Control = lbl_F10

        p_excludes(3).Control = btn_save
        p_excludes(4).Control = btn_cancel

        Me.dba_init_form(pnl_main, True, p_excludes, g_is_internal)
        Me.g_focus_fld = txt_title.txtbox

        Call size_screen(Me)

        ' ----------------
        ' * Fill Dropdowns
        ' ----------------
        Call Fill_Dropdowns()

        ' -----------
        ' * Fill Grid
        ' -----------
        Call Fill_Grid()

        grd_bays.Insert_Header_Row("Bay List")

        ' ----------------------
        ' * Set Screen For Admin
        ' ----------------------
        If g_admin And Not g_master Then
            dd_pinouts.Visible = False
            chk_heat.Visible = False
            dd_profiles.Visible = False
            dd_guidelines.Visible = False
        End If

        If grd_bays.DataRows.Count > 0 Then
            grd_bays.SelectedRows.Add(grd_bays.DataRows(0))
            grd_bays.CurrentRow = grd_bays.DataRows(0)
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
                    Me.g_focus_fld.Focus()

                    For p_x As Integer = 0 To g_bay_count - 1
                        g_CUSMain.Machines(p_x).Setup = False
                    Next

                    ' ------------------------------
                    ' * Check Temperature Monitoring
                    ' ------------------------------
                    If m_res_temp_flag Then
                        m_res_temp_flag = False
                        Call Check_Machines_Temp_Monitoring()
                    End If
                End If

            Case "CANCEL"
                dba_cancel_record(pnl_main)

                grd_bays.Enabled = True
                If pnl_main.RecordID <> "" Then
                    Call set_toolbar_buttons("F", "F")
                    Me.g_focus_fld.Focus()
                Else
                    Call set_toolbar_buttons("F", "F")
                    If grd_bays.DataRows.Count > 0 Then
                        grd_bays.SelectedRows.Add(grd_bays.DataRows(0))
                        grd_bays.CurrentRow = grd_bays.DataRows(0)
                        grd_bays.Focus()
                    End If
                End If

                If grd_bays.DataRows.Count < 1 Then
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

#Region " Checkbox Events "
    Private Sub chk_heat_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_heat.CheckedChanged
        If Me.g_fill_screen Then Exit Sub

        Call set_toolbar_buttons("T", "T")
        m_res_temp_flag = True
    End Sub
#End Region

#Region " Dropdown Events "
    Private Sub Dropdown_AfterItemSelected(ByVal sender As Object, ByVal e As System.EventArgs) Handles dd_pinouts.AfterItemSelected, dd_detergent.AfterItemSelected, dd_liquid.AfterItemSelected, dd_guidelines.AfterItemSelected, dd_profiles.AfterItemSelected

        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("T", "T")
    End Sub
#End Region

#Region " Grid Events "
    Private Sub grd_bays_AfterRowSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_bays.AfterRowSelected
        If Me.g_fill_screen Then Exit Sub

        If CType(grd_bays.CurrentRow, Xceed.Grid.DataRow).Cells(0).GetDisplayText = "" Then
            grd_bays.CancelActivate = True
            Dim p_bay As String
            p_bay = CType(grd_bays.CurrentRow, Xceed.Grid.DataRow).Cells(1).GetDisplayText

            ' Set Screen
            dba_new_record(pnl_main)
            pnl_main.RecordID = ""
            btn_save.Enabled = False
            btn_cancel.Enabled = True

            ' Get Bay #
            txt_bay.TextBox_Properties.Text = p_bay
        Else
            grd_bays.CancelActivate = False
        End If
    End Sub

    Private Sub grd_bays_TabPressed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_bays.TabPressed
        Me.g_focus_fld.Focus()
    End Sub
#End Region

#Region " Textbox Events "
    Private Sub txt_title_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_title.TextBox_TextChanged
        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("T", "T")
    End Sub
#End Region

#End Region

End Class
