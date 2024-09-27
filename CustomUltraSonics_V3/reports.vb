Public Class reports
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
    Friend WithEvents btn_reset As DBA.Library.DBA_Button
    Friend WithEvents lbl_filter As DBA.Library.DBA_Label
    Friend WithEvents lbl_F10 As DBA.Library.DBA_Label
    Friend WithEvents txt_detail As DBA.Library.DBA_TextBox
    Friend WithEvents btn_data As DBA.Library.DBA_Button
    Friend WithEvents btn_close As DBA.Library.DBA_Button
    Friend WithEvents pnl_filter As DBA.Library.DBA_Panel
    Friend WithEvents DbA_Panel2 As DBA.Library.DBA_Panel
    Friend WithEvents txt_total_head As DBA.Library.DBA_TextBox
    Friend WithEvents txt_total_prod As DBA.Library.DBA_TextBox
    Friend WithEvents lbl_F7 As DBA.Library.DBA_Label
    Friend WithEvents lbl_F5 As DBA.Library.DBA_Label
    Friend WithEvents GroupByRow1 As Xceed.Grid.GroupByRow
    Friend WithEvents ColumnManagerRow1 As Xceed.Grid.ColumnManagerRow
    Friend WithEvents dataRowTemplate1 As Xceed.Grid.DataRow
    Friend WithEvents grd_display As DBA.Library.DBA_StyleGrid
    Friend WithEvents dte_from As DBA.Library.DBA_DateBox
    Friend WithEvents dte_to As DBA.Library.DBA_DateBox
    Friend WithEvents dd_bay As DBA.Library.DBA_StyleComboBox
    Friend WithEvents dd_type As DBA.Library.DBA_StyleComboBox
    Friend WithEvents dd_instruments As DBA.Library.DBA_StyleComboBox
    Friend WithEvents dd_physician As DBA.Library.DBA_StyleComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reports))
        Me.pnl_main = New DBA.Library.DBA_Panel
        Me.grd_display = New DBA.Library.DBA_StyleGrid
        Me.dataRowTemplate1 = New Xceed.Grid.DataRow
        Me.GroupByRow1 = New Xceed.Grid.GroupByRow
        Me.ColumnManagerRow1 = New Xceed.Grid.ColumnManagerRow
        Me.lbl_F7 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_F5 = New DBA.Library.DBA_Label(Me.components)
        Me.DbA_Panel2 = New DBA.Library.DBA_Panel
        Me.txt_total_prod = New DBA.Library.DBA_TextBox
        Me.txt_total_head = New DBA.Library.DBA_TextBox
        Me.btn_reset = New DBA.Library.DBA_Button(Me.components)
        Me.pnl_filter = New DBA.Library.DBA_Panel
        Me.dd_physician = New DBA.Library.DBA_StyleComboBox
        Me.dd_instruments = New DBA.Library.DBA_StyleComboBox
        Me.dd_type = New DBA.Library.DBA_StyleComboBox
        Me.dd_bay = New DBA.Library.DBA_StyleComboBox
        Me.dte_to = New DBA.Library.DBA_DateBox
        Me.dte_from = New DBA.Library.DBA_DateBox
        Me.lbl_filter = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_F10 = New DBA.Library.DBA_Label(Me.components)
        Me.txt_detail = New DBA.Library.DBA_TextBox
        Me.btn_data = New DBA.Library.DBA_Button(Me.components)
        Me.btn_close = New DBA.Library.DBA_Button(Me.components)
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_main.SuspendLayout()
        CType(Me.grd_display, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataRowTemplate1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColumnManagerRow1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DbA_Panel2.SuspendLayout()
        Me.pnl_filter.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_main
        '
        Me.pnl_main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_main.Controls.Add(Me.grd_display)
        Me.pnl_main.Controls.Add(Me.lbl_F7)
        Me.pnl_main.Controls.Add(Me.lbl_F5)
        Me.pnl_main.Controls.Add(Me.DbA_Panel2)
        Me.pnl_main.Controls.Add(Me.btn_reset)
        Me.pnl_main.Controls.Add(Me.pnl_filter)
        Me.pnl_main.Controls.Add(Me.lbl_F10)
        Me.pnl_main.Controls.Add(Me.txt_detail)
        Me.pnl_main.Controls.Add(Me.btn_data)
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
        Me.pnl_main.Size = New System.Drawing.Size(750, 550)
        Me.pnl_main.TabIndex = 0
        '
        'grd_display
        '
        Me.grd_display.AllowCellNavigation = False
        Me.grd_display.AllowGrouping = False
        Me.grd_display.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.grd_display.AutoFitColumns = False
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
        Me.grd_display.LinkSettings.RecordContainer = Nothing
        Me.grd_display.Location = New System.Drawing.Point(7, 143)
        Me.grd_display.Name = "grd_display"
        Me.grd_display.ReadOnly = True
        Me.grd_display.SelectionMode = System.Windows.Forms.SelectionMode.One
        Me.grd_display.Size = New System.Drawing.Size(469, 372)
        Me.grd_display.SQL = Nothing
        Me.grd_display.TabIndex = 37
        Me.grd_display.UIStyle = Xceed.UI.UIStyle.ResourceAssembly
        '
        'GroupByRow1
        '
        Me.GroupByRow1.ReadOnly = True
        Me.GroupByRow1.Visible = False
        '
        'lbl_F7
        '
        Me.lbl_F7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_F7.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_F7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_F7.ForeColor = System.Drawing.Color.Black
        Me.lbl_F7.Location = New System.Drawing.Point(599, 30)
        Me.lbl_F7.Name = "lbl_F7"
        Me.lbl_F7.Size = New System.Drawing.Size(133, 17)
        Me.lbl_F7.TabIndex = 36
        Me.lbl_F7.Text = "F7 - Print Selected"
        Me.lbl_F7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_F7.UseMnemonic = False
        '
        'lbl_F5
        '
        Me.lbl_F5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_F5.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_F5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_F5.ForeColor = System.Drawing.Color.Black
        Me.lbl_F5.Location = New System.Drawing.Point(599, 10)
        Me.lbl_F5.Name = "lbl_F5"
        Me.lbl_F5.Size = New System.Drawing.Size(133, 17)
        Me.lbl_F5.TabIndex = 35
        Me.lbl_F5.Text = "F5 - Print All"
        Me.lbl_F5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_F5.UseMnemonic = False
        '
        'DbA_Panel2
        '
        Me.DbA_Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DbA_Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DbA_Panel2.Controls.Add(Me.txt_total_prod)
        Me.DbA_Panel2.Controls.Add(Me.txt_total_head)
        Me.DbA_Panel2.DataSettings.IDField = Nothing
        Me.DbA_Panel2.DataSettings.JoinData = Nothing
        Me.DbA_Panel2.DataSettings.LinkField = Nothing
        Me.DbA_Panel2.DataSettings.TableName = Nothing
        Me.DbA_Panel2.Gradient = False
        Me.DbA_Panel2.Location = New System.Drawing.Point(7, 110)
        Me.DbA_Panel2.Name = "DbA_Panel2"
        Me.DbA_Panel2.RecordID = Nothing
        Me.DbA_Panel2.Saved = False
        Me.DbA_Panel2.Size = New System.Drawing.Size(733, 31)
        Me.DbA_Panel2.TabIndex = 33
        '
        'txt_total_prod
        '
        Me.txt_total_prod.AllowNegative = False
        Me.txt_total_prod.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_total_prod.ColorCursor = False
        Me.txt_total_prod.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_total_prod.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_total_prod.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_total_prod.Field_Name = ""
        Me.txt_total_prod.GridBinding = Nothing
        Me.txt_total_prod.Label_On_Top = False
        Me.txt_total_prod.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_total_prod.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_prod.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_total_prod.Label_Properties.Text = "Total Procedures:"
        Me.txt_total_prod.Label_Properties.Width = 110
        Me.txt_total_prod.Location = New System.Drawing.Point(356, 2)
        Me.txt_total_prod.Mandatory = False
        Me.txt_total_prod.Name = "txt_total_prod"
        Me.txt_total_prod.Override_Modified = False
        Me.txt_total_prod.SaveLoadOrder = 0
        Me.txt_total_prod.Size = New System.Drawing.Size(294, 26)
        Me.txt_total_prod.TabIndex = 1
        Me.txt_total_prod.TabStop = False
        Me.txt_total_prod.TextBox_Properties.AcceptsReturn = False
        Me.txt_total_prod.TextBox_Properties.AcceptsTab = False
        Me.txt_total_prod.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_total_prod.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total_prod.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_total_prod.TextBox_Properties.Enabled = True
        Me.txt_total_prod.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_prod.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_total_prod.TextBox_Properties.MaximumValue = 999999
        Me.txt_total_prod.TextBox_Properties.MaxLength = 50
        Me.txt_total_prod.TextBox_Properties.MinimumValue = -999999
        Me.txt_total_prod.TextBox_Properties.MultiLine = False
        Me.txt_total_prod.TextBox_Properties.PasswordChar = Nothing
        Me.txt_total_prod.TextBox_Properties.ReadOnly = False
        Me.txt_total_prod.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_total_prod.TextBox_Properties.TabStop = False
        Me.txt_total_prod.TextBox_Properties.Text = ""
        Me.txt_total_prod.TextBox_Properties.WordWrap = True
        Me.txt_total_prod.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_total_head
        '
        Me.txt_total_head.AllowNegative = False
        Me.txt_total_head.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_total_head.ColorCursor = False
        Me.txt_total_head.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_total_head.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_total_head.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_total_head.Field_Name = ""
        Me.txt_total_head.GridBinding = Nothing
        Me.txt_total_head.Label_On_Top = False
        Me.txt_total_head.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_total_head.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_head.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_total_head.Label_Properties.Text = "Total Processes:"
        Me.txt_total_head.Label_Properties.Width = 100
        Me.txt_total_head.Location = New System.Drawing.Point(47, 2)
        Me.txt_total_head.Mandatory = False
        Me.txt_total_head.Name = "txt_total_head"
        Me.txt_total_head.Override_Modified = False
        Me.txt_total_head.SaveLoadOrder = 0
        Me.txt_total_head.Size = New System.Drawing.Size(283, 26)
        Me.txt_total_head.TabIndex = 0
        Me.txt_total_head.TabStop = False
        Me.txt_total_head.TextBox_Properties.AcceptsReturn = False
        Me.txt_total_head.TextBox_Properties.AcceptsTab = False
        Me.txt_total_head.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_total_head.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total_head.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_total_head.TextBox_Properties.Enabled = True
        Me.txt_total_head.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_head.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_total_head.TextBox_Properties.MaximumValue = 999999
        Me.txt_total_head.TextBox_Properties.MaxLength = 50
        Me.txt_total_head.TextBox_Properties.MinimumValue = -999999
        Me.txt_total_head.TextBox_Properties.MultiLine = False
        Me.txt_total_head.TextBox_Properties.PasswordChar = Nothing
        Me.txt_total_head.TextBox_Properties.ReadOnly = False
        Me.txt_total_head.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_total_head.TextBox_Properties.TabStop = False
        Me.txt_total_head.TextBox_Properties.Text = ""
        Me.txt_total_head.TextBox_Properties.WordWrap = True
        Me.txt_total_head.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_reset.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_reset.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_reset.DisplayText = ""
        Me.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_reset.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset.ForeColor = System.Drawing.Color.Black
        Me.btn_reset.Image = CType(resources.GetObject("btn_reset.Image"), System.Drawing.Image)
        Me.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reset.Location = New System.Drawing.Point(150, 7)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(123, 43)
        Me.btn_reset.TabIndex = 4
        Me.btn_reset.TabStop = False
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'pnl_filter
        '
        Me.pnl_filter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnl_filter.BackColor = System.Drawing.Color.PapayaWhip
        Me.pnl_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_filter.Controls.Add(Me.dd_physician)
        Me.pnl_filter.Controls.Add(Me.dd_instruments)
        Me.pnl_filter.Controls.Add(Me.dd_type)
        Me.pnl_filter.Controls.Add(Me.dd_bay)
        Me.pnl_filter.Controls.Add(Me.dte_to)
        Me.pnl_filter.Controls.Add(Me.dte_from)
        Me.pnl_filter.Controls.Add(Me.lbl_filter)
        Me.pnl_filter.DataSettings.IDField = Nothing
        Me.pnl_filter.DataSettings.JoinData = Nothing
        Me.pnl_filter.DataSettings.LinkField = Nothing
        Me.pnl_filter.DataSettings.TableName = Nothing
        Me.pnl_filter.Gradient = False
        Me.pnl_filter.Location = New System.Drawing.Point(7, 53)
        Me.pnl_filter.Name = "pnl_filter"
        Me.pnl_filter.RecordID = Nothing
        Me.pnl_filter.Saved = False
        Me.pnl_filter.Size = New System.Drawing.Size(733, 58)
        Me.pnl_filter.TabIndex = 0
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
        Me.dd_physician.DataType = DBA.Library.DBA_StyleComboBox.DBA_data_type.DBA_String
        Me.dd_physician.DisplayFieldName = Nothing
        Me.dd_physician.DisplayFieldSQL = Nothing
        Me.dd_physician.DisplayFieldTable = Nothing
        Me.dd_physician.DisplayFieldTableJoin = Nothing
        Me.dd_physician.Field_Name = Nothing
        Me.dd_physician.GridBinding = Nothing
        Me.dd_physician.ID_Column_Number = 0
        Me.dd_physician.ID_Value = Nothing
        Me.dd_physician.Label_On_Top = False
        Me.dd_physician.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.dd_physician.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dd_physician.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_physician.Label_Properties.Text = "Physician"
        Me.dd_physician.Label_Properties.Width = 75
        Me.dd_physician.Location = New System.Drawing.Point(390, 31)
        Me.dd_physician.Mandatory = False
        Me.dd_physician.Name = "dd_physician"
        Me.dd_physician.SaveLoadOrder = 0
        Me.dd_physician.SaveType = DBA.Library.DBA_StyleComboBox.DbA_SaveType.Text_Value
        Me.dd_physician.Size = New System.Drawing.Size(274, 26)
        Me.dd_physician.SQL_Statement = Nothing
        Me.dd_physician.TabIndex = 5
        '
        'dd_instruments
        '
        Me.dd_instruments.ColorCursor = True
        Me.dd_instruments.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dd_instruments.Column_To_Display = 1
        Me.dd_instruments.ComboBox_Properties.AllowFreeText = False
        Me.dd_instruments.ComboBox_Properties.ColumnWidthAdjustment = Xceed.Editors.ColumnWidthAdjustment.None
        Me.dd_instruments.ComboBox_Properties.CompareType = CType((Xceed.Editors.CompareType.CaseInsensitive Or Xceed.Editors.CompareType.AccentInsensitive), Xceed.Editors.CompareType)
        Me.dd_instruments.ComboBox_Properties.Cursor = System.Windows.Forms.Cursors.Default
        Me.dd_instruments.ComboBox_Properties.DropDownResizable = False
        Me.dd_instruments.ComboBox_Properties.Enabled = True
        Me.dd_instruments.ComboBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd_instruments.ComboBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_instruments.ComboBox_Properties.IntegralHeight = True
        Me.dd_instruments.ComboBox_Properties.MaxDropDownItems = 8
        Me.dd_instruments.ComboBox_Properties.Text = ""
        Me.dd_instruments.ComboBox_Properties.TextBoxArea_BackColor = System.Drawing.Color.White
        Me.dd_instruments.ComboBox_Properties.TextBoxArea_TabStop = True
        Me.dd_instruments.DataSet = Nothing
        Me.dd_instruments.DataType = DBA.Library.DBA_StyleComboBox.DBA_data_type.DBA_String
        Me.dd_instruments.DisplayFieldName = Nothing
        Me.dd_instruments.DisplayFieldSQL = Nothing
        Me.dd_instruments.DisplayFieldTable = Nothing
        Me.dd_instruments.DisplayFieldTableJoin = Nothing
        Me.dd_instruments.Field_Name = Nothing
        Me.dd_instruments.GridBinding = Nothing
        Me.dd_instruments.ID_Column_Number = 0
        Me.dd_instruments.ID_Value = Nothing
        Me.dd_instruments.Label_On_Top = False
        Me.dd_instruments.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.dd_instruments.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dd_instruments.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_instruments.Label_Properties.Text = "Instrument"
        Me.dd_instruments.Label_Properties.Width = 75
        Me.dd_instruments.Location = New System.Drawing.Point(72, 31)
        Me.dd_instruments.Mandatory = False
        Me.dd_instruments.Name = "dd_instruments"
        Me.dd_instruments.SaveLoadOrder = 0
        Me.dd_instruments.SaveType = DBA.Library.DBA_StyleComboBox.DbA_SaveType.Text_Value
        Me.dd_instruments.Size = New System.Drawing.Size(274, 26)
        Me.dd_instruments.SQL_Statement = Nothing
        Me.dd_instruments.TabIndex = 4
        '
        'dd_type
        '
        Me.dd_type.ColorCursor = True
        Me.dd_type.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dd_type.Column_To_Display = 0
        Me.dd_type.ComboBox_Properties.AllowFreeText = False
        Me.dd_type.ComboBox_Properties.ColumnWidthAdjustment = Xceed.Editors.ColumnWidthAdjustment.None
        Me.dd_type.ComboBox_Properties.CompareType = CType((Xceed.Editors.CompareType.CaseInsensitive Or Xceed.Editors.CompareType.AccentInsensitive), Xceed.Editors.CompareType)
        Me.dd_type.ComboBox_Properties.Cursor = System.Windows.Forms.Cursors.Default
        Me.dd_type.ComboBox_Properties.DropDownResizable = False
        Me.dd_type.ComboBox_Properties.Enabled = True
        Me.dd_type.ComboBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd_type.ComboBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_type.ComboBox_Properties.IntegralHeight = True
        Me.dd_type.ComboBox_Properties.MaxDropDownItems = 8
        Me.dd_type.ComboBox_Properties.Text = ""
        Me.dd_type.ComboBox_Properties.TextBoxArea_BackColor = System.Drawing.Color.White
        Me.dd_type.ComboBox_Properties.TextBoxArea_TabStop = True
        Me.dd_type.DataSet = Nothing
        Me.dd_type.DataType = DBA.Library.DBA_StyleComboBox.DBA_data_type.DBA_String
        Me.dd_type.DisplayFieldName = Nothing
        Me.dd_type.DisplayFieldSQL = Nothing
        Me.dd_type.DisplayFieldTable = Nothing
        Me.dd_type.DisplayFieldTableJoin = Nothing
        Me.dd_type.Field_Name = Nothing
        Me.dd_type.GridBinding = Nothing
        Me.dd_type.ID_Column_Number = 0
        Me.dd_type.ID_Value = Nothing
        Me.dd_type.Label_On_Top = False
        Me.dd_type.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.dd_type.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dd_type.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_type.Label_Properties.Text = "Type"
        Me.dd_type.Label_Properties.Width = 35
        Me.dd_type.Location = New System.Drawing.Point(568, 5)
        Me.dd_type.Mandatory = False
        Me.dd_type.Name = "dd_type"
        Me.dd_type.SaveLoadOrder = 0
        Me.dd_type.SaveType = DBA.Library.DBA_StyleComboBox.DbA_SaveType.Text_Value
        Me.dd_type.Size = New System.Drawing.Size(159, 26)
        Me.dd_type.SQL_Statement = Nothing
        Me.dd_type.TabIndex = 3
        '
        'dd_bay
        '
        Me.dd_bay.ColorCursor = True
        Me.dd_bay.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dd_bay.Column_To_Display = 0
        Me.dd_bay.ComboBox_Properties.AllowFreeText = False
        Me.dd_bay.ComboBox_Properties.ColumnWidthAdjustment = Xceed.Editors.ColumnWidthAdjustment.None
        Me.dd_bay.ComboBox_Properties.CompareType = CType((Xceed.Editors.CompareType.CaseInsensitive Or Xceed.Editors.CompareType.AccentInsensitive), Xceed.Editors.CompareType)
        Me.dd_bay.ComboBox_Properties.Cursor = System.Windows.Forms.Cursors.Default
        Me.dd_bay.ComboBox_Properties.DropDownResizable = False
        Me.dd_bay.ComboBox_Properties.Enabled = True
        Me.dd_bay.ComboBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd_bay.ComboBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_bay.ComboBox_Properties.IntegralHeight = True
        Me.dd_bay.ComboBox_Properties.MaxDropDownItems = 8
        Me.dd_bay.ComboBox_Properties.Text = ""
        Me.dd_bay.ComboBox_Properties.TextBoxArea_BackColor = System.Drawing.Color.White
        Me.dd_bay.ComboBox_Properties.TextBoxArea_TabStop = True
        Me.dd_bay.DataSet = Nothing
        Me.dd_bay.DataType = DBA.Library.DBA_StyleComboBox.DBA_data_type.DBA_String
        Me.dd_bay.DisplayFieldName = Nothing
        Me.dd_bay.DisplayFieldSQL = Nothing
        Me.dd_bay.DisplayFieldTable = Nothing
        Me.dd_bay.DisplayFieldTableJoin = Nothing
        Me.dd_bay.Field_Name = Nothing
        Me.dd_bay.GridBinding = Nothing
        Me.dd_bay.ID_Column_Number = 0
        Me.dd_bay.ID_Value = Nothing
        Me.dd_bay.Label_On_Top = False
        Me.dd_bay.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.dd_bay.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dd_bay.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_bay.Label_Properties.Text = "Bay"
        Me.dd_bay.Label_Properties.Width = 35
        Me.dd_bay.Location = New System.Drawing.Point(430, 5)
        Me.dd_bay.Mandatory = False
        Me.dd_bay.Name = "dd_bay"
        Me.dd_bay.SaveLoadOrder = 0
        Me.dd_bay.SaveType = DBA.Library.DBA_StyleComboBox.DbA_SaveType.Text_Value
        Me.dd_bay.Size = New System.Drawing.Size(121, 26)
        Me.dd_bay.SQL_Statement = Nothing
        Me.dd_bay.TabIndex = 2
        '
        'dte_to
        '
        Me.dte_to.BackColor = System.Drawing.Color.PapayaWhip
        Me.dte_to.Check_Century = False
        Me.dte_to.ColorCursor = True
        Me.dte_to.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dte_to.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.dte_to.DateBox_Properties.Cursor = System.Windows.Forms.Cursors.Default
        Me.dte_to.DateBox_Properties.DisplayFormatSpecifier = Nothing
        Me.dte_to.DateBox_Properties.EditFormatSpecifier = Nothing
        Me.dte_to.DateBox_Properties.Enabled = True
        Me.dte_to.DateBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dte_to.DateBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.dte_to.DateBox_Properties.NullDateString = ""
        Me.dte_to.DateBox_Properties.Text = ""
        Me.dte_to.DateBox_Properties.TextBoxArea_BackColor = System.Drawing.Color.White
        Me.dte_to.DateBox_Properties.TextBoxArea_ReadOnly = False
        Me.dte_to.DateBox_Properties.TextBoxArea_TabStop = True
        Me.dte_to.Field_Name = ""
        Me.dte_to.GridBinding = Nothing
        Me.dte_to.Label_On_Top = False
        Me.dte_to.Label_Properties.BackColor = System.Drawing.Color.Empty
        Me.dte_to.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dte_to.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.dte_to.Label_Properties.Text = "To"
        Me.dte_to.Label_Properties.Width = 45
        Me.dte_to.Location = New System.Drawing.Point(257, 5)
        Me.dte_to.Mandatory = False
        Me.dte_to.Name = "dte_to"
        Me.dte_to.SaveLoadOrder = 0
        Me.dte_to.Size = New System.Drawing.Size(154, 26)
        Me.dte_to.TabIndex = 1
        '
        'dte_from
        '
        Me.dte_from.BackColor = System.Drawing.Color.PapayaWhip
        Me.dte_from.Check_Century = False
        Me.dte_from.ColorCursor = True
        Me.dte_from.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dte_from.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.dte_from.DateBox_Properties.Cursor = System.Windows.Forms.Cursors.Default
        Me.dte_from.DateBox_Properties.DisplayFormatSpecifier = Nothing
        Me.dte_from.DateBox_Properties.EditFormatSpecifier = Nothing
        Me.dte_from.DateBox_Properties.Enabled = True
        Me.dte_from.DateBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dte_from.DateBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.dte_from.DateBox_Properties.NullDateString = ""
        Me.dte_from.DateBox_Properties.Text = ""
        Me.dte_from.DateBox_Properties.TextBoxArea_BackColor = System.Drawing.Color.White
        Me.dte_from.DateBox_Properties.TextBoxArea_ReadOnly = False
        Me.dte_from.DateBox_Properties.TextBoxArea_TabStop = True
        Me.dte_from.Field_Name = ""
        Me.dte_from.GridBinding = Nothing
        Me.dte_from.Label_On_Top = False
        Me.dte_from.Label_Properties.BackColor = System.Drawing.Color.Empty
        Me.dte_from.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dte_from.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.dte_from.Label_Properties.Text = "From"
        Me.dte_from.Label_Properties.Width = 45
        Me.dte_from.Location = New System.Drawing.Point(102, 5)
        Me.dte_from.Mandatory = False
        Me.dte_from.Name = "dte_from"
        Me.dte_from.SaveLoadOrder = 0
        Me.dte_from.Size = New System.Drawing.Size(154, 26)
        Me.dte_from.TabIndex = 0
        '
        'lbl_filter
        '
        Me.lbl_filter.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_filter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_filter.ForeColor = System.Drawing.Color.Black
        Me.lbl_filter.Location = New System.Drawing.Point(16, 13)
        Me.lbl_filter.Name = "lbl_filter"
        Me.lbl_filter.Size = New System.Drawing.Size(59, 32)
        Me.lbl_filter.TabIndex = 0
        Me.lbl_filter.Text = "Filter Criteria:"
        Me.lbl_filter.UseMnemonic = False
        '
        'lbl_F10
        '
        Me.lbl_F10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_F10.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_F10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_F10.ForeColor = System.Drawing.Color.Black
        Me.lbl_F10.Location = New System.Drawing.Point(445, 21)
        Me.lbl_F10.Name = "lbl_F10"
        Me.lbl_F10.Size = New System.Drawing.Size(133, 17)
        Me.lbl_F10.TabIndex = 32
        Me.lbl_F10.Text = "F10 - Access Main Grid"
        Me.lbl_F10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_F10.UseMnemonic = False
        '
        'txt_detail
        '
        Me.txt_detail.AllowNegative = False
        Me.txt_detail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txt_detail.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_detail.ColorCursor = False
        Me.txt_detail.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_detail.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_detail.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_detail.Field_Name = ""
        Me.txt_detail.GridBinding = Nothing
        Me.txt_detail.Label_On_Top = False
        Me.txt_detail.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_detail.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_detail.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_detail.Label_Properties.Text = "DBA"
        Me.txt_detail.Label_Properties.Width = 0
        Me.txt_detail.Location = New System.Drawing.Point(475, 141)
        Me.txt_detail.Mandatory = False
        Me.txt_detail.Name = "txt_detail"
        Me.txt_detail.Override_Modified = False
        Me.txt_detail.SaveLoadOrder = 0
        Me.txt_detail.Size = New System.Drawing.Size(265, 374)
        Me.txt_detail.TabIndex = 2
        Me.txt_detail.TabStop = False
        Me.txt_detail.Text = "DbA_TextBox1"
        Me.txt_detail.TextBox_Properties.AcceptsReturn = False
        Me.txt_detail.TextBox_Properties.AcceptsTab = False
        Me.txt_detail.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_detail.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_detail.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_detail.TextBox_Properties.Enabled = True
        Me.txt_detail.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_detail.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_detail.TextBox_Properties.MaximumValue = 999999
        Me.txt_detail.TextBox_Properties.MaxLength = 8000
        Me.txt_detail.TextBox_Properties.MinimumValue = -999999
        Me.txt_detail.TextBox_Properties.MultiLine = True
        Me.txt_detail.TextBox_Properties.PasswordChar = Nothing
        Me.txt_detail.TextBox_Properties.ReadOnly = True
        Me.txt_detail.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_detail.TextBox_Properties.TabStop = False
        Me.txt_detail.TextBox_Properties.Text = ""
        Me.txt_detail.TextBox_Properties.WordWrap = True
        Me.txt_detail.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'btn_data
        '
        Me.btn_data.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_data.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_data.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_data.DisplayText = ""
        Me.btn_data.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_data.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_data.ForeColor = System.Drawing.Color.Black
        Me.btn_data.Image = CType(resources.GetObject("btn_data.Image"), System.Drawing.Image)
        Me.btn_data.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_data.Location = New System.Drawing.Point(7, 7)
        Me.btn_data.Name = "btn_data"
        Me.btn_data.Size = New System.Drawing.Size(123, 43)
        Me.btn_data.TabIndex = 3
        Me.btn_data.TabStop = False
        Me.btn_data.Text = "Get Data"
        Me.btn_data.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_data.UseVisualStyleBackColor = False
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
        Me.btn_close.Location = New System.Drawing.Point(292, 7)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(123, 43)
        Me.btn_close.TabIndex = 5
        Me.btn_close.TabStop = False
        Me.btn_close.Text = "Close"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'reports
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(750, 550)
        Me.Controls.Add(Me.pnl_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reports"
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_main.ResumeLayout(False)
        CType(Me.grd_display, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataRowTemplate1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColumnManagerRow1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DbA_Panel2.ResumeLayout(False)
        Me.pnl_filter.ResumeLayout(False)
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
                Call Process("DATA")

            Case Keys.F2
                Call Process("RESET")

            Case Keys.F5
                If Not grd_display.DataSource Is Nothing Then
                    If grd_display.DataSource.Tables(0).Rows.Count > 0 Then
                        Call Process("PRINT_ALL")
                    End If
                End If

            Case Keys.F7
                If Trim(txt_detail.TextBox_Properties.Text) <> "" Then
                    Call Process("PRINT_ONE")
                End If

            Case Keys.F8
                Call close_form()

            Case Keys.F10
                grd_display.Focus()
        End Select

        Select Case keyCode
            Case Keys.F1, Keys.F2, Keys.F4, Keys.F5, _
                 Keys.F7, Keys.F8, Keys.F10
                Return True
        End Select
    End Function
#End Region

#Region " Declarations "
    Dim m_prev_form As Form
    Dim m_close_index As Integer
    Dim m_print As New ArrayList
#End Region

#Region " Button Events "
    Private Sub btn_data_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_data.Click
        Call Process("DATA")
    End Sub

    Private Sub btn_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset.Click
        Call Process("RESET")
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Call close_form()
    End Sub
#End Region

#Region " Check Dates "
    Private Function Check_Dates() As Boolean
        Dim p_flag As Boolean = True

        ' -------------
        ' * Check Dates
        ' -------------
        If Trim(dte_from.DateBox_Properties.Text) <> "" Then
            If Not dte_from.dba_date_validation Then p_flag = False
        End If

        If Trim(dte_to.DateBox_Properties.Text) <> "" Then
            If Not dte_to.dba_date_validation Then p_flag = False
        End If

        Check_Dates = p_flag
    End Function
#End Region

#Region " Close Form "
    Private Sub close_form()
        m_prev_form.Show()
        g_framework.g_forms(m_close_index) = Nothing
        Me.Close()
    End Sub
#End Region

#Region " Display Text "
    Private Sub display_text(ByVal p_id As String, ByVal p_row As Integer, _
        ByVal p_print_only As Boolean, ByVal p_add_space As Boolean, _
        ByRef p_ticket_count As Integer)
        Dim p_string As String

        ' ------------------
        ' * Get Process Data
        ' ------------------
        p_string = get_process_data(p_id, 0, False, IIf(p_print_only, "PRINT", "DISPLAY"), p_ticket_count)

        ' -----------------
        ' * Display Details
        ' -----------------
        If Not p_print_only And p_row = 1 Then
            txt_detail.TextBox_Properties.Text = p_string
        End If

        ' ------------
        ' * Print Data
        ' ------------
        If p_print_only Then
            m_print.Clear()
            m_print.Add(p_string)

            'Used to line feed
            m_print.Add("")
            If p_add_space Then
                m_print.Add("")
                m_print.Add("")
                m_print.Add("")
            End If
        End If
    End Sub
#End Region

#Region " Fill Dropdowns "
    Private Sub Fill_Dropdowns()
        Dim p_data_table As New DataTable
        Dim p_dataset As New DataSet
        Dim p_row As DataRow

        ' ------------------
        ' * Fill Queue Types
        ' ------------------
        '* Add Columns To Data Table
        p_data_table.Columns.Add(New DataColumn("Bay", GetType(String)))

        ' * Add Rows To Data Table
        p_row = p_data_table.NewRow
        p_row("Bay") = ""
        p_data_table.Rows.Add(p_row)

        For p_x As Integer = 1 To g_bay_count
            p_row = p_data_table.NewRow
            p_row("Bay") = p_x
            p_data_table.Rows.Add(p_row)
        Next

        p_dataset.Tables.Add(p_data_table)

        Me.dd_bay.DataSet = p_dataset

        ' -------------
        ' * Instruments
        ' -------------
        dd_instruments.SQL_Statement = "SELECT Distinct instrument_id, Instrument " & _
                                       "FROM instrument_maint " & _
                                       "UNION Select Null As instrument_id, '' As Instrument " & _
                                       "Order by instrument"
        g_framework.dba_load_drop_down(dd_instruments)

        ' -------------------------
        ' * Fill Physician Dropdown
        ' -------------------------
        Dim p_sql As String

        p_sql = "SELECT physician_id, " & _
                "last_name + Case When suffix = '' Then '' Else ' ' + suffix End + ', ' + " & _
                "Case When prefix = '' Then '' Else prefix + ' ' End + " & _
                "first_name + ' ' + middle_initial As Physician, last_name, first_name, middle_initial " & _
                "FROM physician_maint " & _
                "UNION Select Null As physician_id, '' As Physician, '' Aslast_name, '' Asfirst_name, '' Asmiddle_initial " & _
                "ORDER BY last_name, first_name, middle_initial"
        p_dataset = g_framework.Get_Data(p_sql)

        p_dataset.Tables(0).Columns.Remove("last_name")
        p_dataset.Tables(0).Columns.Remove("first_name")
        p_dataset.Tables(0).Columns.Remove("middle_initial")

        dd_physician.DataSet = p_dataset

        ' ------------
        ' * Fill Types
        ' ------------
        Call Fill_Types()
    End Sub

    Private Sub Fill_Types()
        Dim p_data_table As New DataTable
        Dim p_dataset As New DataSet
        Dim p_row As DataRow

        ' ------------------
        ' * Fill Queue Types
        ' ------------------
        '* Add Columns To Data Table
        p_data_table.Columns.Add(New DataColumn("Type", GetType(String)))

        ' * Add Rows To Data Table
        p_row = p_data_table.NewRow
        p_row("Type") = "Completed"
        p_data_table.Rows.Add(p_row)

        p_row = p_data_table.NewRow
        p_row("Type") = "Errors"
        p_data_table.Rows.Add(p_row)

        p_row = p_data_table.NewRow
        p_row("Type") = "Both"
        p_data_table.Rows.Add(p_row)

        p_dataset.Tables.Add(p_data_table)

        Me.dd_type.DataSet = p_dataset

        dd_type.ComboBox_Properties.Text = "Completed"
    End Sub
#End Region

#Region " Fill Grid "
    Private Sub Fill_Grid()
        Dim p_sql As String
        Dim p_sql2 As String
        Dim p_join As String
        Dim p_where As String = ""

        txt_detail.TextBox_Properties.Text = ""

        ' --------------
        ' * Get Run Data
        ' --------------
        p_sql = "SELECT a.run_header_id, CAST(a.start_time as varchar(20)) As Started, a.start_time, " & _
                "a.bay_number As [Bay #], a.button_text As [Info], " & _
                "Case When U1.employee_id Is Null Then U2.employee_id Else U1.employee_id End As employee_id " & _
                "FROM run_info_header a "

        ' ----------------
        ' * Get Error Data
        ' ----------------
        p_sql2 = "SELECT a.run_header_id, CAST(start_time as varchar(20)) As Started, a.start_time, " & _
                 "a.bay_number As [Bay #], Error As [Info], " & _
                 "Case When U1.employee_id Is Null Then U2.employee_id Else U1.employee_id End As employee_id " & _
                 "FROM run_info_header a "

        p_join = "LEFT JOIN Users U1 On U1.user_id = a.run_user_id " & _
                 "LEFT JOIN Users_Deleted U2 On U2.user_id = a.run_user_id "

        ' Check Bay Filter
        If Trim(dd_bay.ComboBox_Properties.Text) <> "" Then
            p_where &= "And bay_number = '" & dd_bay.ComboBox_Properties.Text & "' "
        End If

        ' Check Date Filters
        If dte_from.DateBox_Properties.Text <> "" Then
            p_where &= "And start_time >= '" & dte_from.DateBox_Properties.Text & " 00:00:00' "
        End If

        If dte_to.DateBox_Properties.Text <> "" Then
            p_where &= "And start_time <= '" & dte_to.DateBox_Properties.Text & " 23:59:59' "
        End If

        ' Check Instrument/Physician Filters
        If Trim(dd_instruments.ID_Value) <> "" Or Trim(dd_physician.ID_Value) <> "" Then
            p_join &= "INNER JOIN run_info_data b On b.run_header_id = a.run_header_id "

            If Trim(dd_instruments.ID_Value) <> "" Then
                p_where &= "And instrument_id = '" & dd_instruments.ID_Value & "' "
            End If
            If Trim(dd_physician.ID_Value) <> "" Then
                p_join &= "LEFT JOIN processed_patients c On c.patient_id = b.patient_id "
                p_join &= "LEFT JOIN patient_maint d On d.patient_id = b.patient_id "

                p_where &= "And (c.physician_id = '" & dd_physician.ID_Value & "' "
                p_where &= "Or d.physician_id = '" & dd_physician.ID_Value & "') "
            End If
        End If

        ' ----------
        ' * Get Data
        ' ----------
        Select Case UCase(dd_type.ComboBox_Properties.Text)
            Case "COMPLETED"
                ' Completed Only
                p_sql = p_sql & p_join & "WHERE a.error IS NULL AND a.demo_mode = 0 " & p_where

            Case "ERRORS"
                ' Errors Only
                p_sql = p_sql2 & p_join & "WHERE a.error IS Not NULL AND a.demo_mode = 0 " & p_where

            Case "BOTH"
                ' Both
                p_sql = p_sql & p_join & "WHERE a.error IS NULL AND a.demo_mode = 0 " & p_where

                p_sql &= "UNION ALL " & p_sql2 & p_join & _
                         "WHERE a.error IS Not NULL AND a.demo_mode = 0 " & p_where
        End Select

        ' Get Combined SQL
        p_sql = "Select T1.run_header_id, T1.Started, T1.[Bay #], T1.Info, Case When E1.employee_id Is Not Null Then E1.last_name + ', ' + E1.first_name + (Case When IsNull(E1.middle_initial, '') = '' Then '' Else ', ' + E1.middle_initial + ' ' End) " & _
                "When E2.employee_id Is Not Null Then E2.last_name + ', ' + E2.first_name + (Case When IsNull(E2.middle_initial, '') = '' Then '' Else ', ' + E2.middle_initial + ' ' End) Else 'CUS' End As [User] " & _
                "From ( " & p_sql & ") T1 " & _
                "LEFT JOIN Employee E1 On E1.employee_id = T1.employee_id " & _
                "LEFT JOIN Employees_Deleted E2 On E2.employee_id = T1.employee_id " & _
                "Order By T1.start_time desc"

        grd_display.SQL = p_sql

        ' Fill the grid
        Me.dba_fill_grid(grd_display)

        If grd_display.DataRows.Count > 0 Then
            grd_display.SelectedRows.Clear()
            grd_display.SelectedRows.Add(grd_display.DataRows(0))
            grd_display.CurrentRow = grd_display.DataRows(0)

            grd_display.Focus()
        Else
            pnl_main.Focus()
        End If
    End Sub
#End Region

#Region " Form Load "
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim p_excludes(3) As dba_RemoveControls
        p_excludes(0).Control = lbl_filter
        p_excludes(1).Control = lbl_F10
        p_excludes(2).Control = lbl_F5
        p_excludes(3).Control = lbl_F7

        Me.dba_init_form(pnl_main, True, p_excludes, g_is_internal)
        Me.g_focus_fld = dte_from

        Call size_screen(Me)

        ' ----------------
        ' * Fill Dropdowns
        ' ----------------
        Call Fill_Dropdowns()

        ' -----------
        ' * Set Dates
        ' -----------
        dte_from.DateBox_Properties.Text = DateTime.Now.ToShortDateString
        dte_to.DateBox_Properties.Text = DateTime.Now.ToShortDateString
    End Sub
#End Region

#Region " Get Counts "
    Private Sub Get_Counts()
        Dim p_sql As String
        Dim p_join As String = ""
        Dim p_where As String
        Dim p_dataset As DataSet

        ' -------------------------------
        ' * Get Total For Filter Criteria
        ' -------------------------------
        p_where = "WHERE a.error IS NULL AND a.demo_mode = 0 " & _
                  "And end_time Is Not Null "

        ' Check Bay Filter
        If Trim(dd_bay.ComboBox_Properties.Text) <> "" Then
            p_where &= "And bay_number = '" & dd_bay.ComboBox_Properties.Text & "' "
        End If

        ' Check Date Filters
        If dte_from.DateBox_Properties.Text <> "" Then
            p_where &= "And start_time >= '" & dte_from.DateBox_Properties.Text & " 00:00:00' "
        End If

        If dte_to.DateBox_Properties.Text <> "" Then
            p_where &= "And start_time <= '" & dte_to.DateBox_Properties.Text & " 23:59:59' "
        End If

        ' Check Instrument/Physician Filters
        If Trim(dd_instruments.ID_Value) <> "" Or Trim(dd_physician.ID_Value) <> "" Then
            p_join = "INNER JOIN run_info_data b On b.run_header_id = a.run_header_id "

            If Trim(dd_instruments.ID_Value) <> "" Then
                p_where &= "And instrument_id = '" & dd_instruments.ID_Value & "' "
            End If
            If Trim(dd_physician.ID_Value) <> "" Then
                p_join &= "LEFT JOIN processed_patients c On c.patient_id = b.patient_id "
                p_join &= "LEFT JOIN patient_maint d On d.patient_id = b.patient_id "

                p_where &= "And (c.physician_id = '" & dd_physician.ID_Value & "' "
                p_where &= "Or d.physician_id = '" & dd_physician.ID_Value & "') "
            End If
        End If

        ' Get Totals
        p_sql = "SELECT Count(*) FROM run_info_header a " & p_join & p_where & "; "

        p_sql &= "SELECT COUNT(*) FROM run_info_data " & _
                 "Where run_header_id In (SELECT a.run_header_id FROM run_info_header a " & p_join & p_where & _
                 ") And procedure_num Is Not Null; "

        p_dataset = g_framework.Get_Data(p_sql)

        ' -----------------
        ' * Display Results
        ' -----------------
        txt_total_head.TextBox_Properties.Text = p_dataset.Tables(0).Rows(0).Item(0)
        txt_total_prod.TextBox_Properties.Text = p_dataset.Tables(1).Rows(0).Item(0)

        ' Dispose of Dataset
        p_dataset.Dispose()
    End Sub
#End Region

#Region " Process "
    Private Sub Process(ByVal p_type As String)
        Select Case UCase(p_type)
            Case "DATA"
                If Check_Dates() Then
                    Call Fill_Grid()

                    If dd_type.ComboBox_Properties.Text = "Errors" Then
                        txt_total_head.TextBox_Properties.Text = ""
                        txt_total_prod.TextBox_Properties.Text = ""
                    Else
                        Call Get_Counts()
                    End If
                End If

            Case "RESET"
                ' -----------
                ' * Set Dates
                ' -----------
                dte_from.DateBox_Properties.Text = DateTime.Now.ToShortDateString
                dte_to.DateBox_Properties.Text = DateTime.Now.ToShortDateString

                dd_bay.ComboBox_Properties.Text = ""
                dd_type.ComboBox_Properties.Text = "Completed"

                dd_instruments.ComboBox_Properties.Text = ""
                dd_instruments.ID_Value = ""
                dd_physician.ComboBox_Properties.Text = ""
                dd_physician.ID_Value = ""

                txt_total_head.TextBox_Properties.Text = ""
                txt_total_prod.TextBox_Properties.Text = ""

                txt_detail.TextBox_Properties.Text = ""
                grd_display.DataSource = Nothing

                dte_from.Focus()

            Case "PRINT_ONE"
                If grd_display.DataRows.Count = 0 Then Exit Sub

                If message_box("Continue printing selected?", 2, "Confirm Print") = MsgBoxResult.No Then Exit Sub

                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

                Dim p_ticket_count As Integer
                Call display_text(CType(grd_display.CurrentRow, Xceed.Grid.DataRow).Cells(0).GetDisplayText, 1, True, True, p_ticket_count)

                Try
                    Dim p_print As New CUSPrint.TextPrinting(g_PrintPort)
                    p_print.Print(m_print)

                Catch
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Call message_box("Bad printer connection.", 4, "Print Error")
                End Try

                Me.Cursor = System.Windows.Forms.Cursors.Default

            Case "PRINT_ALL"
                If grd_display.DataRows.Count = 0 Then Exit Sub

                If message_box("Continue printing all?", 2, "Confirm Print") = MsgBoxResult.No Then Exit Sub

                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

                Dim p_total_rows As Long
                p_total_rows = grd_display.DataSource.Tables(0).Rows.Count

                ' ------------------
                ' * Show status form
                ' ------------------
                Dim p_form As print_status
                p_form = New print_status
                p_form.Show()

                p_form.lbl_status.Text = "Print Started ..."
                p_form.progress.Maximum = p_total_rows
                p_form.progress.Value = 0
                p_form.Refresh()

                Try
                    Dim p_db_row As DataRow
                    Dim p_print As New CUSPrint.TextPrinting(g_PrintPort)
                    Dim p_row As Long

                    For Each p_db_row In grd_display.DataSource.Tables(0).Rows
                        p_row += 1

                        p_form.lbl_status.Text = "... Row " & p_row & " - Sent to Printer ..."
                        p_form.Refresh()

                        ' -----------
                        ' * Print Row
                        ' -----------
                        Dim p_ticket_count As Integer
                        If p_row <> p_total_rows Then
                            Call display_text(p_db_row.Item(0).ToString, p_row, True, False, p_ticket_count)
                        Else
                            Call display_text(p_db_row.Item(0).ToString, p_row, True, True, p_ticket_count)
                        End If
                        p_print.Print(m_print)

                        ' Update Status
                        p_form.progress.Value = p_row
                        p_form.Refresh()

                        If p_row <> p_total_rows Then
                            ' Sleep for 30 second between prints
                            System.Threading.Thread.Sleep(30000 * p_ticket_count)
                        End If
                    Next

                Catch
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Call message_box("Bad printer connection.", 4, "Print Error")
                End Try

                '  Close Status Form
                p_form.Close()
                p_form = Nothing

                Me.Cursor = System.Windows.Forms.Cursors.Default
        End Select
    End Sub
#End Region

#Region " Screen Object Events "

#Region " Grid Events "
    Private Sub grd_display_AfterRowSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_display.AfterRowSelected
        grd_display.CancelActivate = True

        ' -------------------------
        ' * Display Record Selected
        ' -------------------------
        Dim p_ticket_count As Integer
        Call display_text(CType(grd_display.CurrentRow, Xceed.Grid.DataRow).Cells(0).GetDisplayText, 1, False, False, p_ticket_count)
    End Sub

    Private Sub grd_display_InitializeLayout(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_display.InitializeLayout
        With grd_display
            .Columns(1).Width = 120
            .Columns(2).Width = 35
            .Columns(3).Width = 155
            .Columns(4).Width = 122
        End With
    End Sub

    Private Sub grd_display_TabPressed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_display.TabPressed
        Me.g_focus_fld.Focus()
    End Sub
#End Region

#End Region

End Class
