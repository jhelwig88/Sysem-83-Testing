Public Class run_patient
    Inherits DBA_Framework.DBA_Foundation_Class

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal p_db_name As String, ByVal p_form As Form, ByVal p_machine_index As Integer)
        MyBase.New(p_db_name, g_framework.g_version, g_framework.g_user_id)

        'set the webservice url
        MyBase.update_url(g_service_url)

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        m_prev_form = p_form
        m_machine_index = p_machine_index
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
    Friend WithEvents txt_bay As DBA.Library.DBA_TextBox
    Friend WithEvents btn_patient As DBA.Library.DBA_Button
    Friend WithEvents btn_instrument As DBA.Library.DBA_Button
    Friend WithEvents btn_delete As DBA.Library.DBA_Button
    Friend WithEvents btn_cancel As DBA.Library.DBA_Button
    Friend WithEvents btn_save As DBA.Library.DBA_Button
    Friend WithEvents btn_new As DBA.Library.DBA_Button
    Friend WithEvents btn_close As DBA.Library.DBA_Button
    Friend WithEvents lbl_F10 As DBA.Library.DBA_Label
    Friend WithEvents pnl_info As DBA.Library.DBA_Panel
    Friend WithEvents tlb_main As DBA.Library.DBA_StyleToolbar
    Friend WithEvents grd_display As DBA.Library.DBA_StyleGrid
    Friend WithEvents GroupByRow1 As Xceed.Grid.GroupByRow
    Friend WithEvents ColumnManagerRow1 As Xceed.Grid.ColumnManagerRow
    Friend WithEvents dataRowTemplate1 As Xceed.Grid.DataRow
    Friend WithEvents dd_patient As DBA.Library.DBA_StyleComboBox
    Friend WithEvents dd_instrument As DBA.Library.DBA_StyleComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(run_patient))
        Me.pnl_main = New DBA.Library.DBA_Panel
        Me.grd_display = New DBA.Library.DBA_StyleGrid
        Me.dataRowTemplate1 = New Xceed.Grid.DataRow
        Me.GroupByRow1 = New Xceed.Grid.GroupByRow
        Me.ColumnManagerRow1 = New Xceed.Grid.ColumnManagerRow
        Me.tlb_main = New DBA.Library.DBA_StyleToolbar
        Me.pnl_info = New DBA.Library.DBA_Panel
        Me.dd_instrument = New DBA.Library.DBA_StyleComboBox
        Me.dd_patient = New DBA.Library.DBA_StyleComboBox
        Me.lbl_F10 = New DBA.Library.DBA_Label(Me.components)
        Me.btn_patient = New DBA.Library.DBA_Button(Me.components)
        Me.txt_bay = New DBA.Library.DBA_TextBox
        Me.btn_instrument = New DBA.Library.DBA_Button(Me.components)
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
        Me.pnl_main.DataSettings.IDField = "pre_run_id"
        Me.pnl_main.DataSettings.JoinData = Nothing
        Me.pnl_main.DataSettings.LinkField = Nothing
        Me.pnl_main.DataSettings.TableName = "pre_run_info"
        Me.pnl_main.Gradient = False
        Me.pnl_main.Location = New System.Drawing.Point(0, 0)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.RecordID = Nothing
        Me.pnl_main.Saved = False
        Me.pnl_main.Size = New System.Drawing.Size(624, 440)
        Me.pnl_main.TabIndex = 0
        '
        'grd_display
        '
        Me.grd_display.AllowCellNavigation = False
        Me.grd_display.AllowGrouping = False
        Me.grd_display.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.grd_display.Location = New System.Drawing.Point(8, 212)
        Me.grd_display.Name = "grd_display"
        Me.grd_display.ReadOnly = True
        Me.grd_display.SelectionMode = System.Windows.Forms.SelectionMode.One
        Me.grd_display.Size = New System.Drawing.Size(608, 222)
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
        Me.tlb_main.TabIndex = 12
        Me.tlb_main.TabStop = False
        Me.tlb_main.ToolBarCustom = Nothing
        Me.tlb_main.ToolbarDisplayType = DBA.Library.DBA_StyleToolbar.DisplayType.IconsOnSide
        Me.tlb_main.ToolBarType = DBA.Library.DBA_StyleToolbar.DBA_ToolBarType.Normal
        Me.tlb_main.Visible = False
        '
        'pnl_info
        '
        Me.pnl_info.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnl_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_info.Controls.Add(Me.dd_instrument)
        Me.pnl_info.Controls.Add(Me.dd_patient)
        Me.pnl_info.Controls.Add(Me.lbl_F10)
        Me.pnl_info.Controls.Add(Me.btn_patient)
        Me.pnl_info.Controls.Add(Me.txt_bay)
        Me.pnl_info.Controls.Add(Me.btn_instrument)
        Me.pnl_info.DataSettings.IDField = Nothing
        Me.pnl_info.DataSettings.JoinData = Nothing
        Me.pnl_info.DataSettings.LinkField = Nothing
        Me.pnl_info.DataSettings.TableName = Nothing
        Me.pnl_info.Gradient = False
        Me.pnl_info.Location = New System.Drawing.Point(8, 54)
        Me.pnl_info.Name = "pnl_info"
        Me.pnl_info.RecordID = Nothing
        Me.pnl_info.Saved = False
        Me.pnl_info.Size = New System.Drawing.Size(608, 157)
        Me.pnl_info.TabIndex = 0
        '
        'dd_instrument
        '
        Me.dd_instrument.ColorCursor = True
        Me.dd_instrument.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dd_instrument.Column_To_Display = 1
        Me.dd_instrument.ComboBox_Properties.AllowFreeText = False
        Me.dd_instrument.ComboBox_Properties.ColumnWidthAdjustment = Xceed.Editors.ColumnWidthAdjustment.None
        Me.dd_instrument.ComboBox_Properties.CompareType = CType((Xceed.Editors.CompareType.CaseInsensitive Or Xceed.Editors.CompareType.AccentInsensitive), Xceed.Editors.CompareType)
        Me.dd_instrument.ComboBox_Properties.Cursor = System.Windows.Forms.Cursors.Default
        Me.dd_instrument.ComboBox_Properties.DropDownResizable = False
        Me.dd_instrument.ComboBox_Properties.Enabled = True
        Me.dd_instrument.ComboBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd_instrument.ComboBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_instrument.ComboBox_Properties.IntegralHeight = True
        Me.dd_instrument.ComboBox_Properties.MaxDropDownItems = 8
        Me.dd_instrument.ComboBox_Properties.Text = ""
        Me.dd_instrument.ComboBox_Properties.TextBoxArea_BackColor = System.Drawing.Color.White
        Me.dd_instrument.ComboBox_Properties.TextBoxArea_TabStop = True
        Me.dd_instrument.DataSet = Nothing
        Me.dd_instrument.DataType = DBA.Library.DBA_StyleComboBox.DBA_data_type.DBA_UID
        Me.dd_instrument.DisplayFieldName = Nothing
        Me.dd_instrument.DisplayFieldSQL = Nothing
        Me.dd_instrument.DisplayFieldTable = Nothing
        Me.dd_instrument.DisplayFieldTableJoin = Nothing
        Me.dd_instrument.Enabled = False
        Me.dd_instrument.Field_Name = "instrument_id"
        Me.dd_instrument.GridBinding = Me.grd_display
        Me.dd_instrument.ID_Column_Number = 0
        Me.dd_instrument.ID_Value = Nothing
        Me.dd_instrument.Label_On_Top = False
        Me.dd_instrument.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.dd_instrument.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.dd_instrument.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_instrument.Label_Properties.Text = "Instrument"
        Me.dd_instrument.Label_Properties.Width = 80
        Me.dd_instrument.Location = New System.Drawing.Point(27, 110)
        Me.dd_instrument.Mandatory = True
        Me.dd_instrument.Name = "dd_instrument"
        Me.dd_instrument.SaveLoadOrder = 0
        Me.dd_instrument.SaveType = DBA.Library.DBA_StyleComboBox.DbA_SaveType.UID
        Me.dd_instrument.Size = New System.Drawing.Size(405, 26)
        Me.dd_instrument.SQL_Statement = Nothing
        Me.dd_instrument.TabIndex = 2
        '
        'dd_patient
        '
        Me.dd_patient.ColorCursor = True
        Me.dd_patient.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dd_patient.Column_To_Display = 1
        Me.dd_patient.ComboBox_Properties.AllowFreeText = False
        Me.dd_patient.ComboBox_Properties.ColumnWidthAdjustment = Xceed.Editors.ColumnWidthAdjustment.None
        Me.dd_patient.ComboBox_Properties.CompareType = CType((Xceed.Editors.CompareType.CaseInsensitive Or Xceed.Editors.CompareType.AccentInsensitive), Xceed.Editors.CompareType)
        Me.dd_patient.ComboBox_Properties.Cursor = System.Windows.Forms.Cursors.Default
        Me.dd_patient.ComboBox_Properties.DropDownResizable = False
        Me.dd_patient.ComboBox_Properties.Enabled = True
        Me.dd_patient.ComboBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd_patient.ComboBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_patient.ComboBox_Properties.IntegralHeight = True
        Me.dd_patient.ComboBox_Properties.MaxDropDownItems = 8
        Me.dd_patient.ComboBox_Properties.Text = ""
        Me.dd_patient.ComboBox_Properties.TextBoxArea_BackColor = System.Drawing.Color.White
        Me.dd_patient.ComboBox_Properties.TextBoxArea_TabStop = True
        Me.dd_patient.DataSet = Nothing
        Me.dd_patient.DataType = DBA.Library.DBA_StyleComboBox.DBA_data_type.DBA_UID
        Me.dd_patient.DisplayFieldName = Nothing
        Me.dd_patient.DisplayFieldSQL = Nothing
        Me.dd_patient.DisplayFieldTable = Nothing
        Me.dd_patient.DisplayFieldTableJoin = Nothing
        Me.dd_patient.Enabled = False
        Me.dd_patient.Field_Name = "patient_id"
        Me.dd_patient.GridBinding = Me.grd_display
        Me.dd_patient.ID_Column_Number = 0
        Me.dd_patient.ID_Value = Nothing
        Me.dd_patient.Label_On_Top = False
        Me.dd_patient.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.dd_patient.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.dd_patient.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_patient.Label_Properties.Text = "Patient"
        Me.dd_patient.Label_Properties.Width = 50
        Me.dd_patient.Location = New System.Drawing.Point(57, 61)
        Me.dd_patient.Mandatory = True
        Me.dd_patient.Name = "dd_patient"
        Me.dd_patient.SaveLoadOrder = 0
        Me.dd_patient.SaveType = DBA.Library.DBA_StyleComboBox.DbA_SaveType.UID
        Me.dd_patient.Size = New System.Drawing.Size(375, 26)
        Me.dd_patient.SQL_Statement = Nothing
        Me.dd_patient.TabIndex = 1
        '
        'lbl_F10
        '
        Me.lbl_F10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_F10.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_F10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_F10.ForeColor = System.Drawing.Color.Black
        Me.lbl_F10.Location = New System.Drawing.Point(462, 13)
        Me.lbl_F10.Name = "lbl_F10"
        Me.lbl_F10.Size = New System.Drawing.Size(136, 22)
        Me.lbl_F10.TabIndex = 34
        Me.lbl_F10.Text = "F10 - Access Main Grid"
        Me.lbl_F10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_F10.UseMnemonic = False
        '
        'btn_patient
        '
        Me.btn_patient.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_patient.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_patient.DisplayText = "Add Patient"
        Me.btn_patient.Enabled = False
        Me.btn_patient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_patient.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_patient.ForeColor = System.Drawing.Color.Black
        Me.btn_patient.Image = CType(resources.GetObject("btn_patient.Image"), System.Drawing.Image)
        Me.btn_patient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient.Location = New System.Drawing.Point(445, 48)
        Me.btn_patient.Name = "btn_patient"
        Me.btn_patient.Size = New System.Drawing.Size(150, 42)
        Me.btn_patient.TabIndex = 3
        Me.btn_patient.TabStop = False
        Me.btn_patient.Text = "Add Patient (FM)"
        Me.btn_patient.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_patient.UseVisualStyleBackColor = False
        '
        'txt_bay
        '
        Me.txt_bay.AllowNegative = False
        Me.txt_bay.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_bay.ColorCursor = False
        Me.txt_bay.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_bay.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_bay.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_bay.Field_Name = "bay_number"
        Me.txt_bay.GridBinding = Nothing
        Me.txt_bay.Label_On_Top = False
        Me.txt_bay.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_bay.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bay.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_bay.Label_Properties.Text = "Bay #"
        Me.txt_bay.Label_Properties.Width = 40
        Me.txt_bay.Location = New System.Drawing.Point(67, 18)
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
        Me.txt_bay.TextBox_Properties.TabStop = False
        Me.txt_bay.TextBox_Properties.Text = ""
        Me.txt_bay.TextBox_Properties.WordWrap = True
        Me.txt_bay.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'btn_instrument
        '
        Me.btn_instrument.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_instrument.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_instrument.DisplayText = "Add Instrument"
        Me.btn_instrument.Enabled = False
        Me.btn_instrument.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_instrument.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_instrument.ForeColor = System.Drawing.Color.Black
        Me.btn_instrument.Image = CType(resources.GetObject("btn_instrument.Image"), System.Drawing.Image)
        Me.btn_instrument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_instrument.Location = New System.Drawing.Point(445, 101)
        Me.btn_instrument.Name = "btn_instrument"
        Me.btn_instrument.Size = New System.Drawing.Size(150, 42)
        Me.btn_instrument.TabIndex = 4
        Me.btn_instrument.TabStop = False
        Me.btn_instrument.Text = "Add Instrument (FM)"
        Me.btn_instrument.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_instrument.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.btn_delete.TabIndex = 10
        Me.btn_delete.TabStop = False
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_delete.UseVisualStyleBackColor = False
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
        Me.btn_cancel.Location = New System.Drawing.Point(258, 8)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(104, 43)
        Me.btn_cancel.TabIndex = 9
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
        Me.btn_save.Location = New System.Drawing.Point(133, 8)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(104, 43)
        Me.btn_save.TabIndex = 8
        Me.btn_save.TabStop = False
        Me.btn_save.Text = "Save"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_new
        '
        Me.btn_new.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.btn_new.TabIndex = 7
        Me.btn_new.TabStop = False
        Me.btn_new.Text = "New"
        Me.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new.UseVisualStyleBackColor = False
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
        Me.btn_close.Location = New System.Drawing.Point(512, 8)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(104, 43)
        Me.btn_close.TabIndex = 11
        Me.btn_close.TabStop = False
        Me.btn_close.Text = "Close"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'run_patient
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(624, 440)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "run_patient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "run_patient"
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
                If btn_patient.Enabled And btn_patient.Visible Then
                    Call Process("PATIENT")
                End If

            Case Keys.F7
                If btn_instrument.Enabled And btn_instrument.Visible Then
                    Call Process("INSTRUMENT")
                End If

            Case Keys.F8
                Call Process("CLOSE")

            Case Keys.F10
                grd_display.Focus()
        End Select

        Select Case keyCode
            Case Keys.F1, Keys.F2, Keys.F3, Keys.F4, _
                 Keys.F5, Keys.F7, Keys.F8, Keys.F10
                Return True
        End Select
    End Function
#End Region

#Region " Declarations "
    Dim m_machine_index As Integer
    Dim m_btn_key As String
    Dim m_prev_form As run_bay_detail
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

    Private Sub btn_patient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_patient.Click
        Call Process("PATIENT")
    End Sub

    Private Sub btn_instrument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_instrument.Click
        Call Process("INSTRUMENT")
    End Sub
#End Region

#Region " Close Form "
    Private Sub close_form()
        m_prev_form.Show()
        g_framework.g_forms(2) = Nothing
        Me.Close()
    End Sub
#End Region

#Region " Fill Dropdowns "
    Private Sub Fill_Dropdowns()
        ' ----------
        ' * Patients
        ' ----------
        dd_patient.SQL_Statement = "Select Null As patient_id, '' As Name " & _
                "UNION " & _
                "Select patient_id, last_name + ', ' + first_name + ' ' + middle_initial As Name " & _
                "FROM patient_maint " & _
                "Order By Name"
        g_framework.dba_load_drop_down(dd_patient)

        ' -------------
        ' * Instruments
        ' -------------
        dd_instrument.SQL_Statement = "SELECT Null As instrument_id, '' As Instrument " & _
                "UNION " & _
                "SELECT Distinct instrument_id, Instrument " & _
                "FROM instrument_maint " & _
                "Where stop_use <> 1 " & _
                "Order by Instrument"
        g_framework.dba_load_drop_down(dd_instrument)
    End Sub
#End Region

#Region " Fill Grid "
    Private Sub Fill_Grid()
        Dim p_sql As String                 ' String To Hold SQL Statement

        ' --------------------------
        ' * Load Bay Run Information
        ' --------------------------
        p_sql = "Select " & pnl_main.DataSettings.IDField & _
                ", P1.last_name + ', ' + P1.first_name + ' ' + P1.middle_initial As Patient, " & _
                "Case When PH1.prefix = '' Then '' Else PH1.prefix + ' ' End + " & _
                "PH1.first_name + ' ' + Case When PH1.middle_initial = '' Then '' Else PH1.middle_initial + ' ' End " & _
                "+ PH1.last_name + ' ' + PH1.suffix As Physician, Instrument " & _
                "FROM " & pnl_main.DataSettings.TableName & " T1 " & _
                "INNER JOIN instrument_maint I1 On I1.instrument_id = T1.instrument_id " & _
                "LEFT JOIN patient_maint P1 On P1.patient_id = T1.patient_id " & _
                "LEFT JOIN physician_maint PH1 On PH1.physician_id = P1.physician_id " & _
                "Where bay_number = '" & m_machine_index + 1 & _
                "' Order By P1.last_name, P1.first_name, P1.middle_initial, Instrument"
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

#Region " Form Activate "
    Private Sub Form_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        btn_close.Focus()
    End Sub
#End Region

#Region " Form AfterFillScreen "
    Private Sub Form_AfterFillScreen(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.AfterFillScreen
        Call set_toolbar_buttons("T", "F", "F", "T")
    End Sub
#End Region

#Region " Form Enter "
    Private Sub Form_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        If Not g_reload_dd Then Exit Sub

        Select Case UCase(m_btn_key)
            Case "PATIENT"
                dd_patient.ComboBox_Properties.Text = ""
                dd_patient.ID_Value = ""
                g_framework.dba_load_drop_down(dd_patient)

                ' Get New Patient
                dd_patient.Load_Item(dd_patient.ID_Column_Number, dd_patient.Column_To_Display, g_pass_str2.Replace("{", "").Replace("}", ""))

            Case "INSTRUMENT"
                dd_instrument.ComboBox_Properties.Text = ""
                dd_instrument.ID_Value = ""
                g_framework.dba_load_drop_down(dd_instrument)

                ' Get New Instrument
                dd_instrument.Load_Item(dd_instrument.ID_Column_Number, dd_instrument.Column_To_Display, g_pass_str2.Replace("{", "").Replace("}", ""))
        End Select

        m_btn_key = ""
        g_pass_str = ""
        g_pass_str2 = ""
        g_reload_dd = False
    End Sub
#End Region

#Region " Form Load "
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim p_excludes(6) As dba_RemoveControls
        p_excludes(0).Control = btn_close
        p_excludes(1).Control = txt_bay
        p_excludes(2).Control = lbl_F10

        p_excludes(3).Control = btn_new
        p_excludes(4).Control = btn_save
        p_excludes(5).Control = btn_cancel
        p_excludes(6).Control = btn_delete

        Me.dba_init_form(pnl_main, True, p_excludes, g_is_internal)
        Me.g_focus_fld = dd_patient

        Call size_screen(Me)

        ' ------------------------------
        ' * Add Special Insert for Bay #
        ' ------------------------------
        Dim p_inserts(0) As dba_special_data_inserts

        p_inserts(0).p_fld_name = "bay_number"
        p_inserts(0).p_fld_type = DBA_Framework.DBA_Foundation_Class.DBA_DataType.Number
        p_inserts(0).p_fld_value = m_machine_index + 1
        p_inserts(0).p_Panel_Binding = pnl_main.Name

        Me.g_special_data_inserts = p_inserts

        ' ------------
        ' * Set Screen
        ' ------------
        Call set_screen()

        ' -------------------
        ' * Remove Add Button
        ' -------------------
        If Not (g_master Or g_admin) Then
            btn_instrument.Visible = False
        End If

        ' ----------------
        ' * Fill Dropdowns
        ' ----------------
        Call Fill_Dropdowns()

        ' -----------
        ' * Fill Grid
        ' -----------
        Call Fill_Grid()

        grd_display.Insert_Header_Row("Patient List - Use Arrows to Select Record")

        If grd_display.DataRows.Count > 0 Then
            grd_display.SelectedRows.Add(grd_display.DataRows(0))
            grd_display.CurrentRow = grd_display.DataRows(0)
        End If
    End Sub
#End Region

#Region " Pre-Save Check "
    Private Function pre_save() As Boolean
        ' Check Mandatory
        check_mandatory_fields(pnl_main)
        If verify_mandatory() = False Then
            Return False
        End If

        Dim p_sql As String
        Dim p_dataset As DataSet

        ' ---------------------------------------------
        ' * Check That Patient Only Assigned to one bay
        ' ---------------------------------------------
        If dd_patient.Visible Then
            p_sql = "Select Count(*) FROM " & pnl_main.DataSettings.TableName & _
                    " Where patient_id = '" & dd_patient.ID_Value & "'"

            If pnl_main.RecordID <> "" Then
                p_sql &= " And pre_run_id <> '" & pnl_main.RecordID & "'"
            End If

            p_dataset = g_framework.Get_Data(p_sql)

            If p_dataset.Tables(0).Rows(0).Item(0) >= g_max_instrument Then
                Call message_box("Patient already assigned the max of " & g_max_instrument & " times for bay(s)!", 1)

                ' Dispose of Dataset
                p_dataset.Dispose()

                Return False
            End If
        End If

        ' ------------------------------------------------
        ' * Check That Instrument Only Assigned to one bay
        ' ------------------------------------------------
        ' Check Instrument
        p_sql = "Select " & pnl_main.DataSettings.IDField & _
                " FROM " & pnl_main.DataSettings.TableName & _
                " Where instrument_id = '" & dd_instrument.ID_Value & "'"

        If pnl_main.RecordID <> "" Then
            p_sql &= " And pre_run_id <> '" & pnl_main.RecordID & "'"
        End If

        p_dataset = g_framework.Get_Data(p_sql)

        If p_dataset.Tables(0).Rows.Count > 0 Then
            Call message_box("Instrument has already been assigned to a bay run! Please reselect Instrument.", 1)

            ' Dispose of Dataset
            p_dataset.Dispose()

            Return False
        End If

        ' ================================
        ' * Check for Max Instrument Count
        ' ================================
        If pnl_main.RecordID = "" Then
            p_sql = "Select Count(*) " & _
                    " FROM " & pnl_main.DataSettings.TableName & _
                    " Where bay_number = '" & txt_bay.TextBox_Properties.Text & "'"
            p_dataset = g_framework.Get_Data(p_sql)

            If p_dataset.Tables(0).Rows(0).Item(0) = g_max_instrument Then
                Call message_box("Bay may only contain a max of " & g_max_instrument & " Instruments!", 1)

                ' Dispose of Dataset
                p_dataset.Dispose()

                Return False
            End If
        End If

        ' Dispose of Dataset
        p_dataset.Dispose()

        Return True
    End Function
#End Region

#Region " Process "
    Private Sub Process(ByVal p_type As String)
        If g_fill_screen Then Exit Sub

        Select Case UCase(p_type)
            Case "NEW"
                dba_new_record(pnl_main)
                Call set_toolbar_buttons("F", "T", "T", "F")
                grd_display.Enabled = False

                txt_bay.txtbox.Focus()

                If dd_patient.Visible Then
                    dd_patient.Focus()
                Else
                    dd_instrument.Focus()
                End If

            Case "SAVE"
                ' ------------------------
                ' * Verify Bay Information
                ' ------------------------
                If pre_save() = False Then Exit Sub

                ' ----------------------
                ' * Save Bay Information
                ' ----------------------
                If dba_save_record(pnl_main) Then
                    m_prev_form.Fill_Grid()
                    Call set_toolbar_buttons("T", "F", "F", "T")
                    Me.g_focus_fld.Focus()
                End If

            Case "CANCEL"
                ' ----------------
                ' * Cancel Changes
                ' ----------------
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
                If dba_delete_record(pnl_main) Then
                    Call Fill_Grid()
                    m_prev_form.Fill_Grid()
                    Call set_toolbar_buttons("T", "F", "F", "F")
                End If

                If grd_display.DataRows.Count > 0 Then
                    grd_display.SelectedRows.Add(grd_display.DataRows(0))
                    grd_display.CurrentRow = grd_display.DataRows(0)
                    grd_display.Focus()
                Else
                    pnl_main.Focus()
                End If

            Case "CLOSE"
                ' --------------------------
                ' * Close Form Functionality
                ' --------------------------
                If btn_save.Enabled Then
                    If message_box("Do you want to save before exiting this screen?", 2, "Save before close") = MsgBoxResult.Yes Then
                        ' ------------------------
                        ' * Verify Bay Information
                        ' ------------------------
                        If pre_save() = False Then Exit Sub

                        ' ----------------------
                        ' * Save Bay Information
                        ' ----------------------
                        If dba_save_record(pnl_main) Then
                            m_prev_form.Fill_Grid()
                            Call close_form()
                        End If
                    Else
                        Call close_form()
                    End If
                Else
                    Call close_form()
                End If

            Case "PATIENT"
                m_btn_key = UCase(p_type)

                ' --------------------------------------
                ' * Load Patient File Maintenance Screen
                ' --------------------------------------
                g_framework.g_forms(2) = New patient(g_framework.g_db_name, Me, 2)
                g_framework.g_forms(2).MdiParent = g_mdi_form
                g_framework.g_forms(2).Show()

                Me.Hide()

            Case "INSTRUMENT"
                m_btn_key = UCase(p_type)

                ' -----------------------------------------
                ' * Load Instrument File Maintenance Screen
                ' -----------------------------------------
                g_pass_str = "INSTRUMENT"
                g_framework.g_forms(2) = New de_maint(g_framework.g_db_name, Me, 2)
                g_framework.g_forms(2).MdiParent = g_mdi_form
                g_framework.g_forms(2).Show()

                Me.Hide()
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

#Region " Set Screen "
    Private Sub set_screen()
        ' ----------------
        ' * Set Bay Number
        ' ----------------
        txt_bay.TextBox_Properties.Text = m_machine_index + 1

        ' -------------------------
        ' * Check If Patient Needed
        ' -------------------------
        Select Case g_CUSMain.Machines(m_machine_index).PinOut
            Case CUSNET.PCBStructs.SYSTEM_ID_DEF.S80, CUSNET.PCBStructs.SYSTEM_ID_DEF.S81
                ' Remove Patient Information
                dd_patient.Mandatory = False
                dd_patient.Visible = False
                btn_patient.Visible = False

                ' Move Instrument Information Up
                dd_instrument.Top = dd_patient.Top
                btn_instrument.Top = btn_patient.Top
        End Select
    End Sub
#End Region

#Region " Screen Object Events "

#Region " Dropdown Events "
    Private Sub Dropdown_AfterItemSelected(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        dd_patient.AfterItemSelected, dd_instrument.AfterItemSelected

        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("", "T", "T", "")
    End Sub
#End Region

#Region " Grid Events "
    Private Sub grd_display_TabPressed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_display.TabPressed
        Me.g_focus_fld.Focus()
    End Sub
#End Region

#End Region

End Class
