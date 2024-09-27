Imports System.IO

Public Class backup_frm
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents backup_timer As System.Windows.Forms.Timer
    Friend WithEvents MCDB As AxMCDBURNERCONLib.AxMCDBurner
    Friend WithEvents lbox_status As System.Windows.Forms.ListBox
    Friend WithEvents ct_box As System.Windows.Forms.PictureBox
    Friend WithEvents btn_manual As System.Windows.Forms.Button
    Friend WithEvents btn_now As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_delay As System.Windows.Forms.Button
    Friend WithEvents pnl_filter As DBA.Library.DBA_Panel
    Friend WithEvents dd_physician As DBA.Library.DBA_StyleComboBox
    Friend WithEvents dd_instruments As DBA.Library.DBA_StyleComboBox
    Friend WithEvents dd_type As DBA.Library.DBA_StyleComboBox
    Friend WithEvents dd_bay As DBA.Library.DBA_StyleComboBox
    Friend WithEvents dte_to As DBA.Library.DBA_DateBox
    Friend WithEvents dte_from As DBA.Library.DBA_DateBox
    Friend WithEvents lbl_filter As DBA.Library.DBA_Label
    Friend WithEvents btn_reports As System.Windows.Forms.Button
    Friend WithEvents btn_export_csv As System.Windows.Forms.Button
    Friend WithEvents pnl_main As DBA.Library.DBA_Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(backup_frm))
        Me.backup_timer = New System.Windows.Forms.Timer(Me.components)
        Me.btn_reports = New System.Windows.Forms.Button
        Me.pnl_filter = New DBA.Library.DBA_Panel
        Me.dd_physician = New DBA.Library.DBA_StyleComboBox
        Me.dd_instruments = New DBA.Library.DBA_StyleComboBox
        Me.dd_type = New DBA.Library.DBA_StyleComboBox
        Me.dd_bay = New DBA.Library.DBA_StyleComboBox
        Me.dte_to = New DBA.Library.DBA_DateBox
        Me.dte_from = New DBA.Library.DBA_DateBox
        Me.lbl_filter = New DBA.Library.DBA_Label(Me.components)
        Me.btn_manual = New System.Windows.Forms.Button
        Me.btn_now = New System.Windows.Forms.Button
        Me.btn_close = New System.Windows.Forms.Button
        Me.btn_delay = New System.Windows.Forms.Button
        Me.MCDB = New AxMCDBURNERCONLib.AxMCDBurner
        Me.lbox_status = New System.Windows.Forms.ListBox
        Me.ct_box = New System.Windows.Forms.PictureBox
        Me.pnl_main = New DBA.Library.DBA_Panel
        Me.btn_export_csv = New System.Windows.Forms.Button
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_filter.SuspendLayout()
        CType(Me.MCDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ct_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'backup_timer
        '
        '
        'btn_reports
        '
        Me.btn_reports.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_reports.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reports.Image = CType(resources.GetObject("btn_reports.Image"), System.Drawing.Image)
        Me.btn_reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reports.Location = New System.Drawing.Point(298, 80)
        Me.btn_reports.Name = "btn_reports"
        Me.btn_reports.Size = New System.Drawing.Size(138, 47)
        Me.btn_reports.TabIndex = 4
        Me.btn_reports.TabStop = False
        Me.btn_reports.Text = "Reports Only"
        Me.btn_reports.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.pnl_filter.Location = New System.Drawing.Point(7, 140)
        Me.pnl_filter.Name = "pnl_filter"
        Me.pnl_filter.RecordID = Nothing
        Me.pnl_filter.Saved = False
        Me.pnl_filter.Size = New System.Drawing.Size(725, 67)
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
        Me.dd_physician.Location = New System.Drawing.Point(390, 35)
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
        Me.dd_instruments.Location = New System.Drawing.Point(72, 35)
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
        Me.dd_type.Location = New System.Drawing.Point(568, 7)
        Me.dd_type.Mandatory = False
        Me.dd_type.Name = "dd_type"
        Me.dd_type.SaveLoadOrder = 0
        Me.dd_type.SaveType = DBA.Library.DBA_StyleComboBox.DbA_SaveType.Text_Value
        Me.dd_type.Size = New System.Drawing.Size(151, 26)
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
        Me.dd_bay.Location = New System.Drawing.Point(430, 7)
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
        Me.dte_to.Location = New System.Drawing.Point(257, 7)
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
        Me.dte_from.Location = New System.Drawing.Point(102, 7)
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
        Me.lbl_filter.Location = New System.Drawing.Point(11, 12)
        Me.lbl_filter.Name = "lbl_filter"
        Me.lbl_filter.Size = New System.Drawing.Size(59, 39)
        Me.lbl_filter.TabIndex = 0
        Me.lbl_filter.Text = "Report Filter Criteria:"
        Me.lbl_filter.UseMnemonic = False
        '
        'btn_manual
        '
        Me.btn_manual.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_manual.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_manual.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manual.Image = CType(resources.GetObject("btn_manual.Image"), System.Drawing.Image)
        Me.btn_manual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_manual.Location = New System.Drawing.Point(445, 80)
        Me.btn_manual.Name = "btn_manual"
        Me.btn_manual.Size = New System.Drawing.Size(139, 47)
        Me.btn_manual.TabIndex = 5
        Me.btn_manual.TabStop = False
        Me.btn_manual.Text = "Manual Update"
        Me.btn_manual.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_now
        '
        Me.btn_now.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_now.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_now.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_now.Image = CType(resources.GetObject("btn_now.Image"), System.Drawing.Image)
        Me.btn_now.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_now.Location = New System.Drawing.Point(7, 80)
        Me.btn_now.Name = "btn_now"
        Me.btn_now.Size = New System.Drawing.Size(134, 47)
        Me.btn_now.TabIndex = 2
        Me.btn_now.TabStop = False
        Me.btn_now.Text = "Now:  Backup/Reports"
        Me.btn_now.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_close
        '
        Me.btn_close.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_close.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_close.Location = New System.Drawing.Point(621, 7)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(111, 43)
        Me.btn_close.TabIndex = 1
        Me.btn_close.TabStop = False
        Me.btn_close.Text = "Close"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_delay
        '
        Me.btn_delay.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_delay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_delay.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delay.Image = CType(resources.GetObject("btn_delay.Image"), System.Drawing.Image)
        Me.btn_delay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delay.Location = New System.Drawing.Point(150, 80)
        Me.btn_delay.Name = "btn_delay"
        Me.btn_delay.Size = New System.Drawing.Size(139, 47)
        Me.btn_delay.TabIndex = 3
        Me.btn_delay.TabStop = False
        Me.btn_delay.Text = "Delay:  Backup/Reports"
        Me.btn_delay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MCDB
        '
        Me.MCDB.Enabled = True
        Me.MCDB.Location = New System.Drawing.Point(311, 12)
        Me.MCDB.Name = "MCDB"
        Me.MCDB.OcxState = CType(resources.GetObject("MCDB.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MCDB.Size = New System.Drawing.Size(32, 32)
        Me.MCDB.TabIndex = 41
        '
        'lbox_status
        '
        Me.lbox_status.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lbox_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbox_status.Location = New System.Drawing.Point(7, 221)
        Me.lbox_status.Name = "lbox_status"
        Me.lbox_status.Size = New System.Drawing.Size(725, 288)
        Me.lbox_status.TabIndex = 6
        Me.lbox_status.TabStop = False
        '
        'ct_box
        '
        Me.ct_box.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ct_box.BackColor = System.Drawing.Color.White
        Me.ct_box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ct_box.Image = CType(resources.GetObject("ct_box.Image"), System.Drawing.Image)
        Me.ct_box.Location = New System.Drawing.Point(7, 7)
        Me.ct_box.Name = "ct_box"
        Me.ct_box.Size = New System.Drawing.Size(257, 58)
        Me.ct_box.TabIndex = 39
        Me.ct_box.TabStop = False
        '
        'pnl_main
        '
        Me.pnl_main.Controls.Add(Me.btn_export_csv)
        Me.pnl_main.Controls.Add(Me.ct_box)
        Me.pnl_main.Controls.Add(Me.MCDB)
        Me.pnl_main.Controls.Add(Me.btn_close)
        Me.pnl_main.Controls.Add(Me.btn_manual)
        Me.pnl_main.Controls.Add(Me.btn_reports)
        Me.pnl_main.Controls.Add(Me.btn_delay)
        Me.pnl_main.Controls.Add(Me.btn_now)
        Me.pnl_main.Controls.Add(Me.lbox_status)
        Me.pnl_main.Controls.Add(Me.pnl_filter)
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
        Me.pnl_main.Size = New System.Drawing.Size(742, 516)
        Me.pnl_main.TabIndex = 40
        '
        'btn_export_csv
        '
        Me.btn_export_csv.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_export_csv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_export_csv.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_export_csv.Image = CType(resources.GetObject("btn_export_csv.Image"), System.Drawing.Image)
        Me.btn_export_csv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_export_csv.Location = New System.Drawing.Point(593, 80)
        Me.btn_export_csv.Name = "btn_export_csv"
        Me.btn_export_csv.Size = New System.Drawing.Size(139, 47)
        Me.btn_export_csv.TabIndex = 6
        Me.btn_export_csv.TabStop = False
        Me.btn_export_csv.Text = "CSV Export"
        Me.btn_export_csv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'backup_frm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(742, 516)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_main)
        Me.Name = "backup_frm"
        Me.ShowInTaskbar = False
        Me.Text = "Custom Ultrasonics Backup"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_filter.ResumeLayout(False)
        CType(Me.MCDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ct_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_main.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Overrides "
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Dim keyCode As Keys = CType((msg.WParam.ToInt32 And Keys.KeyCode), Keys)

        ' -------------------
        ' * Process Keystokes
        ' -------------------
        Select Case keyCode
            Case Keys.F1    ' F1 Button - Backup/Reports Now
                Call Process("NOW")

            Case Keys.F2    ' F2 Button - Backup/Reports Delay
                Call Process("DELAY")

            Case Keys.F3    ' F3 Button - Reports Only
                Call Process("REPORTS")

            Case Keys.F4    ' F4 Button - Manual Update
                Call Process("MANUAL")

            Case Keys.F5    ' F5 Button - CSV Export
                Call Process("CSV_EXPORT")

            Case Keys.F8    ' F8 Button - Close
                Call Process("CLOSE")
        End Select
    End Function
#End Region

#Region " Declarations "
    Dim g_bu_file_path As String = "C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\BACKUP\CustomUltraSonics\"

    Private g_end As Boolean = True
    Private g_backup As BackupInfo
    Private g_event As EventInfo
    Private g_bay_count As Integer
    Private g_cdrom_reports_only As Boolean

    Private Structure BackupInfo
        Dim bu_local As Boolean
        Dim drive_letter As String
        Dim drive_type As String
        Dim network_path As String
        Dim time As String
        Dim england As Boolean
    End Structure

    Private Structure EventInfo
        Dim e_backup As Integer
        Dim e_date As Date
        Dim e_report As Integer
        Dim e_update As Integer
    End Structure

    ' ------
    ' * APIs
    ' ------
    Declare Function ShowCursor& Lib "user32" (ByVal bShow As Long)
#End Region

#Region " Backup Functions "

#Region " Backup CD-ROM "
    Private Sub Backup_CDROM(ByVal p_type As String)
        Dim p_cd_dir As String
        Dim p_flag As Boolean
        Dim p_result As Boolean

        Try
            ' ------------------
            ' * Get CD-ROM Drive
            ' ------------------
            Select Case g_backup.drive_letter
                Case "D"
                    MCDB.SelectDevice(0)
                Case "E"
                    MCDB.SelectDevice(1)
                Case "F"
                    MCDB.SelectDevice(2)
                Case "G"
                    MCDB.SelectDevice(3)
            End Select

            ' --------------------
            ' * Check CD-ROM Space
            ' --------------------
            If can_it_fit_on_cd(p_type) = False Then
                lbox_status.Items.Add("<<< Error:  CD is Full ...")
                Me.Refresh()

                MsgBox("Your CD is full.  Please Change with new CD.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Please be advised")

                Exit Sub
            End If

            ' ------------
            ' * Start Burn
            ' ------------
            p_cd_dir = "FILES_" & Format(DateTime.Now, "yyyyMMdd_hhmmss")
            lbox_status.Items.Add("<<< CD has enough free space ...")
            lbox_status.Items.Add(">>>")
            Me.Refresh()

            MCDB.ReplaceFile = False

            p_flag = MCDB.ImportSession(0, "\")
            p_flag = MCDB.CreateDir("\", p_cd_dir)

            If p_type = "ALL" Then
                g_cdrom_reports_only = False
                p_flag = MCDB.InsertDirW("\" & p_cd_dir, g_bu_file_path, "*.*", True, False)
            Else
                g_cdrom_reports_only = True
                p_flag = MCDB.InsertDirW("\" & p_cd_dir, g_bu_file_path, "*.txt", True, False)
            End If

            MCDB.Prepare()
            p_result = MCDB.Burn()

            If p_result Then
                lbox_status.Items.Add("<<< Burning CD .... ")
                Me.Refresh()
            Else
                lbox_status.Items.Add("<<< Error:  Burning Failed.")
                lbox_status.Items.Add("<<< " & MCDB.GetErrorStringW())
                lbox_status.Items.Add(">>> Error: " & MCDB.GetErrorStringW)
                Me.Refresh()

                Dim p_string As String
                p_string = "CD BURN FAILED!.  Please contact Custom Ultrasonics."

                MsgBox(p_string, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Please be advised")
            End If

        Catch
            g_event.e_backup = 0
        End Try
    End Sub
#End Region

#Region " Backup to Path "
    Private Sub Backup_To_Path(ByVal p_type As String)
        ' -------------------
        ' * Check Drive Space
        ' -------------------
        If can_it_fit_on_drive(p_type) = False Then
            lbox_status.Items.Add("<<<")
            lbox_status.Items.Add("<<< Error:  Drive is Full ...")
            Me.Refresh()

            If g_backup.bu_local Then
                MsgBox(g_backup.drive_letter & " drive is full.  Please free up space on drive and try again.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Please be advised")
            Else
                MsgBox("Network Path drive is full.  Please free up space on drive and try again.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Please be advised")
            End If

            g_event.e_backup = 0

            Exit Sub
        End If

        Dim p_dir2 As String
        Dim p_file_type As String
        Dim p_dir As DirectoryInfo = New DirectoryInfo(g_bu_file_path)

        ' -------------------
        ' * Set Backup Folder
        ' -------------------
        If g_backup.bu_local Then
            ' Local Drive
            p_dir2 = g_backup.drive_letter & ":\FILES_" & Format(DateTime.Now, "yyyyMMdd_hhmmss") & "\"
        Else
            ' Network Path
            p_dir2 = g_backup.network_path & "FILES_" & Format(DateTime.Now, "yyyyMMdd_hhmmss") & "\"
        End If

        ' ----------------------------
        ' * Get Types of Files to Copy
        ' ----------------------------
        If p_type = "ALL" Then
            p_file_type = "*.*"
        Else
            p_file_type = "*.txt"
        End If

        Try
            ' ---------------------------------------------
            ' * Check to see if CU SQL Backup folder exists
            ' ---------------------------------------------
            If p_dir.Exists = False Then
                lbox_status.Items.Add("<<< Error:  Default Backup Directory was not found ...")
                Me.Refresh()
            Else
                Dim p_file As System.IO.FileInfo
                Dim p_file1 As String
                Dim p_file2 As String

                ' Get Files and Copy
                For Each p_file In p_dir.GetFiles(p_file_type)
                    p_file1 = p_file.FullName
                    p_file2 = p_dir2 & p_file.Name

                    If System.IO.Directory.Exists(p_dir2) = False Then
                        System.IO.Directory.CreateDirectory(p_dir2)
                    End If

                    File.Copy(p_file1, p_file2, True)
                Next
            End If

            lbox_status.Items.Add("<<<")
            lbox_status.Items.Add(">>> File Copy complete.")
            Me.Refresh()

            If p_type = "REPORTS" Then
                g_event.e_backup = 0
            Else
                g_event.e_backup = 1
            End If

            ' Update Window to Complete
            lbox_status.Items.Add("<<<")
            lbox_status.Items.Add(">>> Processing Complete.")
            Me.Refresh()

        Catch
            lbox_status.Items.Add("<<< Error:  File Copy failed ...")
            Me.Refresh()

            g_event.e_backup = 0
        End Try

        ' Clean Up
        Call write_out_status()
        Call delete_report_files()

        ' End if Delay
        If g_end Then
            Shell("customultrasonics.exe")
            End
        Else
            lbox_status.Items.Add("<<<")
            lbox_status.Items.Add(">>> Close to return to Main Program.")
            Me.Refresh()
        End If
    End Sub
#End Region

#Region " MCDB EVENTS "
    Private Sub MCDB_OnWriteDone(ByVal sender As System.Object, ByVal e As AxMCDBURNERCONLib._DMCDBurnerEvents_OnWriteDoneEvent) Handles MCDB.OnWriteDone
        lbox_status.Items.Add("<<<")
        lbox_status.Items.Add(">>> CD Write Complete...")
        Me.Refresh()

        If e.failed Then
            lbox_status.Items.Add(">>> Error: " & MCDB.GetErrorStringW)
            Me.Refresh()

            g_event.e_backup = 0
        Else
            ' Check to see if the backup wrote correctly
            'MCDB.LoadMedium()
            'If System.IO.Directory.Exists(g_backup.drive_letter & ":\" & g_cd_dir & "\") = False Then
            'lbox_status.Items.Add(">>> ERROR: " & MCDB.GetErrorStringW)
            'p_string = "BACKUP FAILED!.  Please contact Custom Ultrasonics."
            'g_event.e_backup = 0
            'Else
            lbox_status.Items.Add("<<<")
            lbox_status.Items.Add(">>> CD Burn Complete...")
            Me.Refresh()

            If g_cdrom_reports_only Then
                g_event.e_backup = 0
            Else
                g_event.e_backup = 1
            End If

            'End If
        End If

        ' Clean Up
        Call write_out_status()
        Call delete_report_files()

        ' Update Window to Complete
        lbox_status.Items.Add("<<<")
        lbox_status.Items.Add(">>> Processing Complete.")
        Me.Refresh()

        ' End if Delay
        If g_end Then
            Shell("customultrasonics.exe")
            End
        Else
            lbox_status.Items.Add("<<<")
            lbox_status.Items.Add(">>> Close to return to Main Program.")
            Me.Refresh()
        End If
    End Sub
#End Region

#Region " CAN IT FIT ON CD "
    Private Function can_it_fit_on_cd(ByVal p_type As String) As Boolean
        Dim p_ext As String
        Dim p_total As Long

        ' =================================
        ' * Check Space Remaining on CD-ROM
        ' =================================

        ' --------------------
        ' * File Type to Write
        ' --------------------
        If p_type = "ALL" Then
            p_ext = "*.*"
        Else
            p_ext = "*.txt"
        End If

        ' ----------------
        ' * Get File Sizes
        ' ----------------
        lbox_status.Items.Add(">>> Final Scan for CD Free Space ...")
        Me.Refresh()

        Dim p_dir As DirectoryInfo = New DirectoryInfo(g_bu_file_path)
        Dim p_file As System.IO.FileInfo

        For Each p_file In p_dir.GetFiles(p_ext)
            p_total += p_file.Length
        Next

        If (MCDB.FreeBlocksOnDisc * 2048) < p_total Then
            can_it_fit_on_cd = False
        Else
            can_it_fit_on_cd = True
        End If

        p_file = Nothing
        p_dir = Nothing
    End Function
#End Region

#Region " CAN IT FIT ON DRIVE "
    Private Function can_it_fit_on_drive(ByVal p_type As String) As Boolean
        Dim p_path As String
        Dim p_ext As String
        Dim p_total As Long
        Dim p_space As Long

        ' ================================
        ' * Check Space Remaining on Drive
        ' ================================

        ' -------------------
        ' * Set Backup Folder
        ' -------------------
        If g_backup.bu_local Then
            ' Local Drive
            p_path = g_backup.drive_letter & ":\"
        Else
            ' Network Path
            p_path = g_backup.network_path

            ' Create Directory, If Needed
            If System.IO.Directory.Exists(p_path) = False Then
                System.IO.Directory.CreateDirectory(p_path)
            End If
        End If

        ' --------------------
        ' * File Type to Write
        ' --------------------
        If p_type = "ALL" Then
            p_ext = "*.*"
        Else
            p_ext = "*.txt"
        End If

        ' ----------------
        ' * Get File Sizes
        ' ----------------
        lbox_status.Items.Add(">>> Final Scan for Drive Free Space ...")
        Me.Refresh()

        Dim p_dir As DirectoryInfo = New DirectoryInfo(g_bu_file_path)
        Dim p_file As System.IO.FileInfo

        For Each p_file In p_dir.GetFiles(p_ext)
            p_total += p_file.Length
        Next

        ' -------------------------
        ' * Get Free Space On Drive
        ' -------------------------
        Dim drive As New System.IO.DriveInfo(p_path)
        p_space = drive.TotalFreeSpace

        If p_space < p_total Then
            can_it_fit_on_drive = False
        Else
            can_it_fit_on_drive = True
        End If

        p_file = Nothing
        p_dir = Nothing
    End Function
#End Region

#End Region

#Region " Button Events "
    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Call Process("CLOSE")
    End Sub

    Private Sub btn_now_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_now.Click
        Call Process("NOW")
    End Sub

    Private Sub btn_delay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delay.Click
        Call Process("DELAY")
    End Sub

    Private Sub btn_reports_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_reports.Click
        Call Process("REPORTS")
    End Sub

    Private Sub btn_manual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_manual.Click
        Call Process("MANUAL")
    End Sub
#End Region

#Region " Create Reports "
    Private Sub create_reports()
        ' Check Directory Exists
        If System.IO.Directory.Exists(g_bu_file_path) = False Then
            System.IO.Directory.CreateDirectory(g_bu_file_path)
        End If

        ' =========================
        ' * Delete Previous Reports
        ' =========================
        Call delete_report_files()

        ' =====================
        ' * Create Where Clause
        ' =====================
        Dim p_where As String
        p_where = get_where()

        ' ----------
        ' * CSV File
        ' ----------
        Call create_comma_file(p_where)
        lbox_status.Items.Add("<<<")
        Me.Refresh()

        ' --------------------
        ' * Detail Report File
        ' --------------------
        Call create_report_file(p_where)

        ' Update Window to Complete
        lbox_status.Items.Add("<<<")
        lbox_status.Items.Add(">>> Report Files Created.")
        Me.Refresh()
    End Sub

    Private Function get_where() As String
        Dim p_sql As String
        Dim p_sql2 As String
        Dim p_join As String
        Dim p_where As String = ""

        ' --------------
        ' * Get Run Data
        ' --------------
        p_sql = "SELECT a.run_header_id FROM run_info_header a "

        ' ----------------
        ' * Get Error Data
        ' ----------------
        p_sql2 = "SELECT a.run_header_id FROM run_info_header a "

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
        p_sql = "Select T1.run_header_id " & _
                "From ( " & p_sql & ") T1 "

        Return p_sql
    End Function

    Private Sub create_comma_file(ByVal p_where As String)
        Dim p_sql, p_sql2 As String
        Dim p_dataset As DataSet = Nothing
        Dim p_dataset2 As DataSet = Nothing
        Dim p_db_row, p_db_row2 As DataRow

        Dim p_file As String
        Dim p_write_out As String = ""
        Dim p_header As String
        Dim p_patient_info As String

        Dim objreader As StreamWriter = Nothing

        Try
            ' Detail Information Script
            p_sql2 = "Select T1.patient_id, code, P1.first_name + Case When IsNull(P1.middle_initial, '') <> '' Then ' ' + P1.middle_initial Else '' End + ' ' + P1.last_name As Patient, " & _
                     "Case When PH1.prefix = '' Then '' Else PH1.prefix + ' ' End + " & _
                     "PH1.first_name + ' ' + Case When PH1.middle_initial = '' Then '' Else PH1.middle_initial + ' ' End " & _
                     "+ PH1.last_name + ' ' + PH1.suffix As Physician, Instrument, P1.last_name, P1.first_name, P1.middle_initial "

            ' Setup the File
            p_file = g_bu_file_path & "CSV_" & Now.ToString("s") & ".txt"
            p_file = p_file.Replace(":", "")
            p_file = Mid(p_file, 1, 1) & ":" & Mid(p_file, 2)

            lbox_status.Items.Add(">>> Creating Comma Delimited File ...")
            Me.Refresh()

            ' -------------------
            ' * Get Processed Run
            ' -------------------
            p_sql = "Select a.run_header_id, g.title, a.bay_number, a.start_time, a.end_time, a.detergent, a.liquid_sterilant, " & _
                    "a.lub_secs, a.final_disinfect_temp, a.error, a.button_text, a.notes, " & _
                    "a.disinfect_lot, a.process_num, " & _
                    "Case When U1.employee_id Is Null Then U2.employee_id Else U1.employee_id End As employee_id, " & _
                    "Case When U3.employee_id Is Null Then U4.employee_id Else U3.employee_id End As unload_employee_id " & _
                    "FROM run_info_header a " & _
                    "LEFT JOIN bay_settings g On g.bay_number = a.bay_number " & _
                    "LEFT JOIN Users U1 On U1.user_id = a.run_user_id " & _
                    "LEFT JOIN Users_Deleted U2 On U2.user_id = a.run_user_id " & _
                    "LEFT JOIN Users U3 On U3.user_id = a.unload_user_id " & _
                    "LEFT JOIN Users_Deleted U4 On U4.user_id = a.unload_user_id " & _
                    "Where a.run_header_id IN (" & p_where & _
                    ") Order by a.start_time, a.bay_number"
            p_dataset = g_framework.Get_Data(p_sql)

            ' Loop through the Dataset
            For Each p_db_row In p_dataset.Tables(0).Rows
                ' Bay Info
                p_header = p_db_row.Item("title").ToString.Replace(",", "") & " BAY " & p_db_row.Item("bay_number").ToString.Replace(",", "")

                ' Process
                p_header &= "," & p_db_row.Item("button_text").ToString.Replace(",", "")

                ' Process #
                If p_db_row.Item("process_num").ToString <> "" Then
                    p_header &= "," & p_db_row.Item("process_num").ToString.Replace(",", "")
                Else
                    p_header &= ","
                End If

                ' England, Lot #
                If g_backup.england Then
                    p_header &= "," & p_db_row.Item("disinfect_lot").ToString.Replace(",", "")
                Else
                    p_header &= ","
                End If

                ' --------------
                ' * Get Run User
                ' --------------
                If p_db_row.Item("employee_id").ToString = "" Then
                    p_header &= ",CUS"
                Else
                    p_sql = "Select first_name + ' ' + Case When middle_initial = '' Then '' Else middle_initial + ' ' End " & _
                            "+ last_name As [User] " & _
                            "FROM Employee " & _
                            "Where employee_id = '" & p_db_row.Item("employee_id").ToString & _
                            "' UNION " & _
                            "Select first_name + ' ' + Case When middle_initial = '' Then '' Else middle_initial + ' ' End " & _
                            "+ last_name As [User] " & _
                            "FROM Employees_Deleted " & _
                            "Where employee_id = '" & p_db_row.Item("employee_id").ToString & "'"
                    p_dataset2 = g_framework.Get_Data(p_sql)

                    p_header &= "," & p_dataset2.Tables(0).Rows(0).Item(0).ToString.Replace(",", "")

                    p_dataset2.Reset()
                End If

                ' -----------------
                ' * Get Unload User
                ' -----------------
                If g_backup.england And (Not IsDBNull(p_db_row.Item("end_time"))) Then
                    If p_db_row.Item("unload_id").ToString <> "" Then
                        p_sql = "Select first_name + ' ' + Case When middle_initial = '' Then '' Else middle_initial + ' ' End " & _
                                "+ last_name As [User] " & _
                                "FROM Employee " & _
                                "Where employee_id = '" & p_db_row.Item("unload_id").ToString & _
                                "' UNION " & _
                                "Select first_name + ' ' + Case When middle_initial = '' Then '' Else middle_initial + ' ' End " & _
                                "+ last_name As [User] " & _
                                "FROM Employees_Deleted " & _
                                "Where employee_id = '" & p_db_row.Item("unload_id").ToString & "'"
                        p_dataset2 = g_framework.Get_Data(p_sql)

                        p_header &= "," & p_dataset2.Tables(0).Rows(0).Item(0).ToString.Replace(",", "")

                        p_dataset2.Reset()
                    Else
                        p_header &= ","
                    End If
                Else
                    p_header &= ","
                End If

                ' --------------------
                ' * Get Process Timing
                ' --------------------
                ' Start Time
                p_header &= "," & Format(p_db_row.Item("start_time"), "MM/dd/yyyy h:mm:ss tt")

                If IsDBNull(p_db_row.Item("end_time")) Then
                    p_header &= ",,"
                Else
                    ' End Time
                    p_header &= "," & Format(p_db_row.Item("end_time"), "MM/dd/yyyy h:mm:ss tt")

                    ' Get Duration
                    p_header &= ","

                    Dim p_seconds As Long
                    Dim p_int As Long
                    p_seconds = DateDiff(DateInterval.Second, p_db_row.Item("start_time"), p_db_row.Item("end_time"))

                    ' Get Hours
                    If p_seconds >= 3600 Then
                        p_int = Fix(p_seconds / 3600)
                        p_header &= p_int & IIf(p_int > 1, " hrs ", " hr ")
                        p_seconds = p_seconds - (p_int * 3600)
                    End If

                    ' Get Minutes
                    If p_seconds >= 60 Then
                        p_int = Fix(p_seconds / 60)
                        p_header &= p_int & IIf(p_int > 1, " mins ", " min ")
                        p_seconds = p_seconds - (p_int * 60)
                    End If

                    ' Get Minutes
                    If p_seconds > 0 Then
                        p_header &= p_seconds & IIf(p_seconds > 1, " secs", " sec")
                    End If
                End If

                ' -----------------------
                ' * Add Error Information
                ' -----------------------
                If Not IsDBNull(p_db_row.Item("error")) Then
                    p_header &= "," & p_db_row.Item("error").replace(Chr(10), "").replace(Chr(13), "").Replace(",", "")
                Else
                    p_header &= ","
                End If

                ' -----------
                ' * Add Notes
                ' -----------
                If Not IsDBNull(p_db_row.Item("notes")) Then
                    p_header &= "," & p_db_row.Item("notes").replace(Chr(10), " ").replace(Chr(13), "").Replace(",", "")
                Else
                    p_header &= ","
                End If

                ' =============
                ' * Get Details
                ' =============
                ' Detail
                p_sql = "Select Null As patient_id, '' As code, '' As Patient, " & _
                        "'' As Physician, Instrument, '' As last_name, '' As first_name, '' As middle_initial " & _
                        "FROM run_info_data T1 " & _
                        "INNER JOIN instrument_maint I1 On I1.instrument_id = T1.instrument_id " & _
                        "Where run_header_id = '" & p_db_row.Item("run_header_id").ToString & "' And patient_id Is Null " & _
                        "UNION " & _
                        p_sql2 & "FROM run_info_data T1 " & _
                        "INNER JOIN instrument_maint I1 On I1.instrument_id = T1.instrument_id " & _
                        "INNER JOIN patient_maint P1 On P1.patient_id = T1.patient_id " & _
                        "INNER JOIN physician_maint PH1 On PH1.physician_id = P1.physician_id " & _
                        "Where run_header_id = '" & p_db_row.Item("run_header_id").ToString & _
                        "' UNION " & _
                        p_sql2 & "FROM run_info_data T1 " & _
                        "INNER JOIN instrument_maint I1 On I1.instrument_id = T1.instrument_id " & _
                        "INNER JOIN processed_patients P1 On P1.patient_id = T1.patient_id " & _
                        "INNER JOIN physician_maint PH1 On PH1.physician_id = P1.physician_id " & _
                        "Where run_header_id = '" & p_db_row.Item("run_header_id").ToString & _
                        "' Order By last_name, first_name, middle_initial, Instrument"
                p_dataset2 = g_framework.Get_Data(p_sql)

                ' ---------------------------------
                ' * Get Run Patient/Instrument Info
                ' ---------------------------------
                If p_dataset2.Tables(0).Rows.Count > 0 Then
                    For Each p_db_row2 In p_dataset2.Tables(0).Rows
                        ' Patient
                        If p_db_row2.Item("Patient").ToString <> "" Then
                            p_patient_info = "," & p_db_row2.Item("Patient").ToString.Replace(",", "")
                        Else
                            p_patient_info = ","
                        End If

                        ' Code
                        If p_db_row2.Item("code").ToString <> "" Then
                            p_patient_info &= "," & p_db_row2.Item("code").ToString.Replace(",", "")
                        Else
                            p_patient_info &= ","
                        End If

                        ' Physician
                        If p_db_row2.Item("Physician").ToString <> "" Then
                            p_patient_info &= "," & p_db_row2.Item("Physician").ToString.Replace(",", "")
                        Else
                            p_patient_info &= ","
                        End If

                        ' Instrument
                        If p_db_row2.Item("Instrument").ToString <> "" Then
                            p_patient_info &= "," & p_db_row2.Item("Instrument").ToString.Replace(",", "")
                        Else
                            p_patient_info &= ","
                        End If

                        ' Combine Results
                        p_write_out &= p_header & p_patient_info & Environment.NewLine
                    Next
                Else
                    ' Combine Results
                    p_write_out &= p_header & ",,,," & Environment.NewLine
                End If

                ' Reset Dataset
                p_dataset2.Reset()
            Next

            ' ---------------
            ' * Writeout File
            ' ---------------
            objreader = New StreamWriter(p_file, False)
            objreader.Write(p_write_out)

            g_event.e_report = 1
            lbox_status.Items.Add("<<< Comma Delimited File Created ...")
            Me.Refresh()

        Catch
            g_event.e_report = 0
            lbox_status.Items.Add("<<< Error:  Problem Creating CSV File ...")
            Me.Refresh()

        Finally
            If Not objreader Is Nothing Then objreader.Close()

            ' Dispose of Datasets
            If Not p_dataset Is Nothing Then p_dataset.Dispose()
            If Not p_dataset2 Is Nothing Then p_dataset2.Dispose()
        End Try
    End Sub

    Private Sub create_report_file(ByVal p_where As String)
        Dim p_sql, p_sql2 As String
        Dim p_dataset As DataSet = Nothing
        Dim p_dataset2 As DataSet = Nothing
        Dim p_db_row, p_db_row2 As DataRow

        Dim p_file As String
        Dim p_write_out As String = ""

        Dim p_header As String
        Dim p_cycle_info As String = ""
        Dim p_prev_id As String
        Dim p_patient_info As String = ""
        Dim p_patient_count As Integer = 0

        Dim objreader As StreamWriter = Nothing

        Try
            ' Detail Information Script
            p_sql2 = "Select T1.patient_id, code, P1.last_name + ', ' + P1.first_name + Case When IsNull(P1.middle_initial, '') <> '' Then ' ' + P1.middle_initial Else '' End As Patient, " & _
                     "Case When PH1.prefix = '' Then '' Else PH1.prefix + ' ' End + " & _
                     "PH1.first_name + ' ' + Case When PH1.middle_initial = '' Then '' Else PH1.middle_initial + ' ' End " & _
                     "+ PH1.last_name + ' ' + PH1.suffix As Physician, Instrument, P1.last_name, P1.first_name, P1.middle_initial "

            ' Setup the File
            p_file = g_bu_file_path & "Info_" & Now.ToString("s") & ".txt"
            p_file = p_file.Replace(":", "")
            p_file = Mid(p_file, 1, 1) & ":" & Mid(p_file, 2)

            lbox_status.Items.Add(">>> Creating Process Detail File ...")
            Me.Refresh()

            ' -------------------
            ' * Get Processed Run
            ' -------------------
            p_sql = "Select a.run_header_id, g.title, a.bay_number, a.start_time, a.end_time, a.detergent, a.liquid_sterilant, " & _
                    "a.lub_secs, a.final_disinfect_temp, a.error, a.button_text, a.notes, " & _
                    "a.disinfect_lot, a.process_num, " & _
                    "Case When U1.employee_id Is Null Then U2.employee_id Else U1.employee_id End As employee_id, " & _
                    "Case When U3.employee_id Is Null Then U4.employee_id Else U3.employee_id End As unload_employee_id " & _
                    "FROM run_info_header a " & _
                    "LEFT JOIN bay_settings g On g.bay_number = a.bay_number " & _
                    "LEFT JOIN Users U1 On U1.user_id = a.run_user_id " & _
                    "LEFT JOIN Users_Deleted U2 On U2.user_id = a.run_user_id " & _
                    "LEFT JOIN Users U3 On U3.user_id = a.unload_user_id " & _
                    "LEFT JOIN Users_Deleted U4 On U4.user_id = a.unload_user_id " & _
                    "Where a.run_header_id IN (" & p_where & _
                    ") Order by a.start_time, a.bay_number"
            p_dataset = g_framework.Get_Data(p_sql)

            ' Loop through the Dataset
            For Each p_db_row In p_dataset.Tables(0).Rows
                p_header = "__________________________________________________________________________________________________________"
                p_header &= Environment.NewLine

                p_header &= p_db_row.Item("title").ToString & " BAY " & p_db_row.Item("bay_number").ToString & vbTab
                p_header &= Environment.NewLine

                p_header &= "Process: " & p_db_row.Item("button_text").ToString & vbTab & vbTab

                If p_db_row.Item("process_num").ToString <> "" Then
                    p_header &= "Process#: " & p_db_row.Item("process_num").ToString & vbTab & vbTab
                End If

                If g_backup.england Then
                    p_header &= "Lot#: " & p_db_row.Item("disinfect_lot").ToString
                End If
                p_header &= Environment.NewLine

                ' --------------
                ' * Get Run User
                ' --------------
                If p_db_row.Item("employee_id").ToString = "" Then
                    p_header &= "Load: CUS"
                Else
                    p_sql = "Select first_name + ' ' + Case When middle_initial = '' Then '' Else middle_initial + ' ' End " & _
                            "+ last_name As [User] " & _
                            "FROM Employee " & _
                            "Where employee_id = '" & p_db_row.Item("employee_id").ToString & _
                            "' UNION " & _
                            "Select first_name + ' ' + Case When middle_initial = '' Then '' Else middle_initial + ' ' End " & _
                            "+ last_name As [User] " & _
                            "FROM Employees_Deleted " & _
                            "Where employee_id = '" & p_db_row.Item("employee_id").ToString & "'"
                    p_dataset2 = g_framework.Get_Data(p_sql)

                    p_header &= "Load: " & p_dataset2.Tables(0).Rows(0).Item(0).ToString

                    p_dataset2.Reset()
                End If
                p_header &= vbTab & vbTab

                ' -----------------
                ' * Get Unload User
                ' -----------------
                If g_backup.england And (Not IsDBNull(p_db_row.Item("end_time"))) Then
                    If p_db_row.Item("unload_id").ToString <> "" Then
                        p_sql = "Select first_name + ' ' + Case When middle_initial = '' Then '' Else middle_initial + ' ' End " & _
                                "+ last_name As [User] " & _
                                "FROM Employee " & _
                                "Where employee_id = '" & p_db_row.Item("unload_id").ToString & _
                                "' UNION " & _
                                "Select first_name + ' ' + Case When middle_initial = '' Then '' Else middle_initial + ' ' End " & _
                                "+ last_name As [User] " & _
                                "FROM Employees_Deleted " & _
                                "Where employee_id = '" & p_db_row.Item("unload_id").ToString & "'"
                        p_dataset2 = g_framework.Get_Data(p_sql)

                        p_header &= "Unload: " & p_dataset2.Tables(0).Rows(0).Item(0).ToString & vbTab

                        p_dataset2.Reset()
                    End If
                End If
                p_header &= Environment.NewLine

                ' --------------------
                ' * Get Process Timing
                ' --------------------
                p_header &= "Started:   " & Format(p_db_row.Item("start_time"), "ddd MMM d yyyy h:mm:ss tt") & vbTab

                If IsDBNull(p_db_row.Item("end_time")) Then
                    p_header &= "Completed: " & vbTab
                    p_header &= "Duration: " & vbTab
                Else
                    p_header &= "Completed: " & Format(p_db_row.Item("end_time"), "ddd MMM d yyyy h:mm:ss tt") & vbTab

                    ' Get Duration
                    p_header &= "Duration: "

                    Dim p_seconds As Long
                    Dim p_int As Long
                    p_seconds = DateDiff(DateInterval.Second, p_db_row.Item("start_time"), p_db_row.Item("end_time"))

                    ' Get Hours
                    If p_seconds >= 3600 Then
                        p_int = Fix(p_seconds / 3600)
                        p_header &= p_int & IIf(p_int > 1, " hrs ", " hr ")
                        p_seconds = p_seconds - (p_int * 3600)
                    End If

                    ' Get Minutes
                    If p_seconds >= 60 Then
                        p_int = Fix(p_seconds / 60)
                        p_header &= p_int & IIf(p_int > 1, " mins ", " min ")
                        p_seconds = p_seconds - (p_int * 60)
                    End If

                    ' Get Minutes
                    If p_seconds > 0 Then
                        p_header &= p_seconds & IIf(p_seconds > 1, " secs", " sec")
                    End If

                    p_header &= vbTab
                End If
                p_header &= Environment.NewLine

                ' -----------------------
                ' * Add Error Information
                ' -----------------------
                If Not IsDBNull(p_db_row.Item("error")) Then
                    p_header &= "Error:  " & p_db_row.Item("error").replace(Chr(10), "").replace(Chr(13), "") & Environment.NewLine
                End If

                ' -----------
                ' * Add Notes
                ' -----------
                If Not IsDBNull(p_db_row.Item("notes")) Then
                    p_header &= "Notes:  " & p_db_row.Item("notes").replace(Chr(10), " ").replace(Chr(13), "") & Environment.NewLine
                End If

                ' =============
                ' * Get Details
                ' =============
                ' Patient/Instrument Detail
                p_sql = "Select Null As patient_id, '' As code, '' As Patient, " & _
                        "'' As Physician, Instrument, '' As last_name, '' As first_name, '' As middle_initial " & _
                        "FROM run_info_data T1 " & _
                        "INNER JOIN instrument_maint I1 On I1.instrument_id = T1.instrument_id " & _
                        "Where run_header_id = '" & p_db_row.Item("run_header_id").ToString & "' And patient_id Is Null " & _
                        "UNION " & _
                        p_sql2 & "FROM run_info_data T1 " & _
                        "INNER JOIN instrument_maint I1 On I1.instrument_id = T1.instrument_id " & _
                        "INNER JOIN patient_maint P1 On P1.patient_id = T1.patient_id " & _
                        "INNER JOIN physician_maint PH1 On PH1.physician_id = P1.physician_id " & _
                        "Where run_header_id = '" & p_db_row.Item("run_header_id").ToString & _
                        "' UNION " & _
                        p_sql2 & "FROM run_info_data T1 " & _
                        "INNER JOIN instrument_maint I1 On I1.instrument_id = T1.instrument_id " & _
                        "INNER JOIN processed_patients P1 On P1.patient_id = T1.patient_id " & _
                        "INNER JOIN physician_maint PH1 On PH1.physician_id = P1.physician_id " & _
                        "Where run_header_id = '" & p_db_row.Item("run_header_id").ToString & _
                        "' Order By last_name, first_name, middle_initial, Instrument;"

                ' Run Detail
                p_sql &= "Select cycle_name, secs " & _
                         "From run_info_detail " & _
                         "Where run_header_id = '" & p_db_row.Item("run_header_id").ToString & _
                         "' Order by run_order;"

                p_dataset2 = g_framework.Get_Data(p_sql)

                If p_dataset2.Tables(1).Rows.Count > 0 Then
                    p_cycle_info = "Description:" & Environment.NewLine

                    p_prev_id = ""
                    For p_x As Integer = 0 To p_dataset2.Tables(1).Rows.Count - 1
                        p_db_row2 = p_dataset2.Tables(1).Rows(p_x)
                        Select Case p_db_row2.Item("cycle_name").ToString
                            Case "DISINFECT"
                                If Trim(p_db_row.Item("liquid_sterilant").ToString) <> "" Then
                                    p_cycle_info &= "Exposed to " & p_db_row.Item("liquid_sterilant").ToString
                                Else
                                    p_cycle_info &= "Exposed to N/A"
                                End If

                                p_cycle_info &= Environment.NewLine & "for " & CInt(p_db_row2.Item("secs") / 60) & " mins "

                                If Trim(p_db_row.Item("final_disinfect_temp").ToString) <> "" Then
                                    p_cycle_info &= "at " & p_db_row.Item("final_disinfect_temp").ToString & " C"
                                End If

                                p_cycle_info &= Environment.NewLine

                            Case "DRY"
                                p_cycle_info &= "Dry for " & p_db_row2.Item("secs") & " secs" & Environment.NewLine

                            Case "PRE-RINSE"
                                p_cycle_info &= "Pre-Rinse for " & p_db_row2.Item("secs") & " secs" & Environment.NewLine

                            Case "RINSE"
                                p_cycle_info &= "Rinse for " & p_db_row2.Item("secs") & " secs"

                                If Trim(p_db_row.Item("lub_Secs").ToString) <> "" Then
                                    If UCase(p_prev_id) = "WASH" _
                                        Or p_x = p_dataset2.Tables(1).Rows.Count - 1 Then
                                        ' Rinse After Wash / Last Rinse Of Process
                                        p_cycle_info &= " with " & p_db_row.Item("lub_Secs") & " secs" & Environment.NewLine
                                        p_cycle_info &= "of metered lubrication"
                                    End If
                                End If

                                p_cycle_info &= Environment.NewLine

                            Case "SOAK"
                                p_cycle_info &= "Soak for " & p_db_row2.Item("secs") & " secs" & Environment.NewLine

                            Case "WASH"
                                p_cycle_info &= "Ultrasonics Wash for " & p_db_row2.Item("secs") & " secs" & Environment.NewLine
                                If Trim(p_db_row.Item("detergent").ToString) <> "" Then
                                    p_cycle_info &= "with " & p_db_row.Item("detergent").ToString
                                Else
                                    p_cycle_info &= "with N/A"
                                End If

                                p_cycle_info &= Environment.NewLine
                        End Select

                        ' Get Previous Cycle
                        p_prev_id = p_db_row2.Item("cycle_name").ToString
                    Next
                End If
                p_prev_id = ""

                ' ---------------------------------
                ' * Get Run Patient/Instrument Info
                ' ---------------------------------
                If p_dataset2.Tables(0).Rows.Count > 0 Then
                    p_patient_count = 0

                    For Each p_db_row2 In p_dataset2.Tables(0).Rows
                        If Not IsDBNull(p_db_row2.Item("patient_id")) Then
                            p_patient_count += 1
                        End If
                    Next

                    If p_patient_count > 0 Then
                        ' ----------------------------
                        ' * Output Patient Information
                        ' ----------------------------
                        For Each p_db_row2 In p_dataset2.Tables(0).Rows
                            If UCase(p_prev_id) <> UCase(p_db_row2.Item("patient_id").ToString) Then
                                If Trim(p_prev_id) <> "" Then
                                    ' Combine Results
                                    p_write_out &= p_header & p_patient_info & Environment.NewLine & Environment.NewLine & p_cycle_info
                                    p_patient_info = Environment.NewLine & "Patient/ID/Physician/Instrument(s):"
                                Else
                                    p_patient_info = Environment.NewLine & "Patient/ID/Physician/Instrument(s):"
                                End If

                                p_prev_id = p_db_row2.Item("patient_id").ToString

                                p_patient_info &= Environment.NewLine
                                p_patient_info &= p_db_row2.Item("Patient").ToString
                                If Trim(p_db_row2.Item("code").ToString) <> "" Then
                                    p_patient_info &= " / " & p_db_row2.Item("code").ToString
                                End If
                                p_patient_info &= " / " & p_db_row2.Item("Physician").ToString
                            End If

                            ' Output Instrument
                            p_patient_info &= " / " & p_db_row2.Item("Instrument").ToString
                        Next

                        p_patient_info &= Environment.NewLine & Environment.NewLine
                    Else
                        ' -------------------------------
                        ' * Output Instrument Information
                        ' -------------------------------
                        p_patient_info = Environment.NewLine & "Instrument(s):" & Environment.NewLine

                        For Each p_db_row2 In p_dataset2.Tables(0).Rows
                            p_patient_info &= p_db_row2.Item("Instrument").ToString & Environment.NewLine
                        Next
                        p_patient_info &= Environment.NewLine
                    End If
                End If

                p_dataset2.Reset()

                ' Combine Results
                p_write_out &= p_header & p_patient_info & p_cycle_info
            Next

            ' ---------------
            ' * Writeout File
            ' ---------------
            objreader = New StreamWriter(p_file, False)
            objreader.Write(p_write_out)

            g_event.e_report = 1
            lbox_status.Items.Add("<<< Process Detail File Created ...")
            Me.Refresh()

        Catch
            g_event.e_report = 0
            lbox_status.Items.Add("<<< Error:  Problem Creating Process Detail File ...")
            Me.Refresh()

        Finally
            If Not objreader Is Nothing Then objreader.close()

            ' Dispose of Datasets
            If Not p_dataset Is Nothing Then p_dataset.Dispose()
            If Not p_dataset2 Is Nothing Then p_dataset2.Dispose()
        End Try
    End Sub
#End Region

#Region " Delete Report Files "
    Private Sub delete_report_files()
        ' ---------------------------
        ' * Remove Any Existing Files
        ' ---------------------------
        Dim p_files() As String = System.IO.Directory.GetFiles(g_bu_file_path, "*.txt")
        Dim fl As String
        For Each fl In p_files
            Try
                System.IO.File.Delete(fl)
            Catch
            End Try
        Next
    End Sub
#End Region

#Region " Fill Dropdowns "
    Private Sub Fill_Dropdowns()
        Dim p_data_table As New DataTable
        Dim p_sql As String
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
        p_sql = "SELECT Distinct instrument_id, Instrument " & _
                "FROM instrument_maint " & _
                "UNION Select Null As instrument_id, '' As Instrument " & _
                "Order by instrument"
        p_dataset = g_framework.Get_Data(p_sql)

        dd_instruments.DataSet = p_dataset

        ' -------------------------
        ' * Fill Physician Dropdown
        ' -------------------------
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

#Region " Form Activated "
    Private Sub Form_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        dte_from.Focus()
    End Sub
#End Region

#Region " Form GotFocus "
    Private Sub Form_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        dte_from.Focus()
    End Sub
#End Region

#Region " Form Load "
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dba_init_form(pnl_main, False, Nothing, True)

        ' ---------------------
        ' * Remove MousePointer
        ' ---------------------
        ShowCursor(False)

        ' Update Webservice URL
        g_webservice.Url = g_service_url

        ' -------------
        ' * Get Version
        ' -------------
        Dim p_vertemp As String
        p_vertemp = RTrim(LTrim(Str(System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMajorPart))) & _
                            "." & RTrim(LTrim(Str(System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMinorPart))) & _
                            "." & RTrim(LTrim(Str(System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileBuildPart)))

        Me.Text &= " - Version " & p_vertemp

        ' ----------
        ' * Set Date
        ' ----------
        dte_from.DateBox_Properties.Text = DateTime.Now.ToShortDateString

        ' --------------
        ' * Get Settings
        ' --------------
        Call get_backup_info()

        ' ----------------
        ' * Fill Dropdowns
        ' ----------------
        Call Fill_Dropdowns()
    End Sub
#End Region

#Region " Get Backup Info "
    Private Sub get_backup_info()
        Dim p_sql As String
        Dim p_dataset As DataSet

        ' Setup Backup Variables
        With g_backup
            .bu_local = False
            .drive_letter = ""
            .drive_type = ""
            .network_path = ""
            .time = ""
            .england = False
        End With

        ' ==============
        ' * Get Settings
        ' ==============
        p_sql = "Select backup_drive_letter, back_location, back_time, " & _
                "back_cdrom, england_settings, num_of_systems " & _
                "From settings_maint"
        p_dataset = g_framework.Get_Data(p_sql)

        If p_dataset.Tables(0).Rows.Count > 0 Then
            g_bay_count = p_dataset.Tables(0).Rows(0).Item("num_of_systems")

            g_backup.bu_local = p_dataset.Tables(0).Rows(0).Item("back_cdrom")
            g_backup.drive_letter = p_dataset.Tables(0).Rows(0).Item("backup_drive_letter")
            g_backup.network_path = p_dataset.Tables(0).Rows(0).Item("back_location")

            ' Format Network Path, if needed
            If g_backup.network_path <> "" Then
                If Mid(g_backup.network_path, Len(g_backup.network_path), 1) <> "\" Then
                    g_backup.network_path &= "\"
                End If
            End If

            g_backup.time = p_dataset.Tables(0).Rows(0).Item("back_time")
            g_backup.england = p_dataset.Tables(0).Rows(0).Item("england_settings")

            ' Get Drive Type
            Dim drive As New System.IO.DriveInfo(g_backup.drive_letter)
            g_backup.drive_type = drive.DriveType.ToString
        End If

        ' Dispose of Dataset
        p_dataset.Dispose()
    End Sub
#End Region

#Region " Process "
    Private Sub Process(ByVal type As String)
        Select Case UCase(type)
            Case "CLOSE"
                ' ---------------------
                ' * Reload CU and Close
                ' ---------------------
                backup_timer.Enabled = False

                Shell("customultrasonics.exe")

                End

            Case "DELAY"
                ' -------------------------
                ' * Start Backup with Delay
                ' -------------------------
                lbox_status.Items.Clear()
                g_event.e_date = DateTime.Now

                If execute_updater(Me) = -1 Then
                    'lbox_status.Items.Add(">>> Error:  Update Failed ...")
                    g_event.e_update = 0
                Else
                    lbox_status.Items.Add(">>> Update Successful ...")
                    Me.Refresh()

                    g_event.e_update = 1
                End If

                If g_backup.drive_type.ToUpper = "CDROM" Then
                    If can_it_fit_on_cd("ALL") = False Then
                        lbox_status.Items.Add("<<<")
                        lbox_status.Items.Add(">>> First Scan Failed.  Replace CD ...")
                        Me.Refresh()

                        MsgBox("Your CD is full.  Please insert new CD and try again.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Please be advised")

                        g_event.e_backup = 0

                        Exit Sub
                    End If
                Else
                    If can_it_fit_on_drive("ALL") = False Then
                        lbox_status.Items.Add("<<<")
                        lbox_status.Items.Add(">>> First Scan Failed.  Drive is Full ...")
                        Me.Refresh()

                        If g_backup.bu_local Then
                            MsgBox(g_backup.drive_letter & " drive is full.  Please free up space on drive and try again.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Please be advised")
                        Else
                            MsgBox("Network Path drive is full.  Please free up space on drive and try again.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Please be advised")
                        End If

                        g_event.e_backup = 0

                        Exit Sub
                    End If
                End If

                g_end = True
                lbox_status.Items.Add(">>> Backup Service Started. Waiting for " & g_backup.time & " ...")
                Me.Refresh()

                backup_timer.Interval = 2000
                backup_timer.Enabled = True

            Case "NOW"
                ' -----------------------
                ' * Start Backup with Now
                ' -----------------------
                backup_timer.Enabled = False

                lbox_status.Items.Clear()
                g_event.e_date = DateTime.Now

                If execute_updater(Me) = -1 Then
                    'lbox_status.Items.Add(">>> Error:  Update Failed ...")
                    g_event.e_update = 0
                Else
                    lbox_status.Items.Add(">>> Update Successful ...")
                    Me.Refresh()

                    g_event.e_update = 1
                End If

                g_end = False
                lbox_status.Items.Add("<<<")
                lbox_status.Items.Add(">>> Backup Now ...")
                lbox_status.Items.Add("<<<")
                Me.Refresh()

                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

                ' ------------
                ' * Run Backup
                ' ------------
                Call run_backup()

                Me.Cursor = System.Windows.Forms.Cursors.Default

            Case "REPORTS"
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

                g_end = False
                lbox_status.Items.Clear()
                g_event.e_date = DateTime.Now

                lbox_status.Items.Add("<<<")
                lbox_status.Items.Add(">>> Reports Only ...")
                lbox_status.Items.Add("<<<")
                Me.Refresh()

                ' ----------------
                ' * Backup Reports
                ' ----------------
                Call exports_backup()

                Me.Cursor = System.Windows.Forms.Cursors.Default

            Case "MANUAL"
                ' ====================================================================
                ' * Update System Files and/or SQL Database via File(s) on Local Drive
                ' ====================================================================
                lbox_status.Items.Clear()
                lbox_status.Items.Add("<<<")
                lbox_status.Items.Add(">>> Manual Update ...")
                lbox_status.Items.Add("<<<")
                Me.Refresh()

                ' ---------------------------------------------------------------------
                ' * Check to see if the CU_UPDATE folder is found, update program files
                ' ---------------------------------------------------------------------
                Dim p_dir As DirectoryInfo = New DirectoryInfo(g_backup.drive_letter & ":\CU_UPDATE")

                If p_dir.Exists = False Then
                    lbox_status.Items.Add(">>> No file updates found on " & g_backup.drive_letter & " Drive ...")
                    lbox_status.Items.Add("<<<")
                    Me.Refresh()
                Else
                    If p_dir.GetFiles.Count = 0 Then
                        lbox_status.Items.Add(">>> No file updates found on " & g_backup.drive_letter & " Drive ...")
                        lbox_status.Items.Add("<<<")
                        Me.Refresh()
                    Else
                        lbox_status.Items.Add(">>> File updates found on " & g_backup.drive_letter & " Drive ...")
                        lbox_status.Items.Add("<<<")
                        Me.Refresh()

                        lbox_status.Items.Add(">>> Copying Files from " & g_backup.drive_letter & " Drive ...")
                        lbox_status.Items.Add("<<<")
                        Me.Refresh()

                        Dim p_file As System.IO.FileInfo
                        For Each p_file In p_dir.GetFiles()
                            p_file.CopyTo(System.AppDomain.CurrentDomain.BaseDirectory & p_file.Name, True)
                            File.SetAttributes(System.AppDomain.CurrentDomain.BaseDirectory & p_file.Name, FileAttributes.Normal)
                        Next

                        lbox_status.Items.Add(">>> File updates completed! ...")
                        lbox_status.Items.Add("<<<")
                        Me.Refresh()
                    End If
                End If

                ' -----------------------------------------------------------------
                ' * Check to see if CU_DATA_UPDATE folder is found, run SQL Scripts
                ' -----------------------------------------------------------------
                p_dir = New DirectoryInfo(g_backup.drive_letter & ":\CU_DATA_UPDATE")

                If p_dir.Exists = False Then
                    lbox_status.Items.Add(">>> No data updates found on " & g_backup.drive_letter & " Drive ...")
                    lbox_status.Items.Add("<<<")
                    Me.Refresh()
                Else
                    If p_dir.GetFiles.Count = 0 Then
                        lbox_status.Items.Add(">>> No data updates found on " & g_backup.drive_letter & " Drive ...")
                        lbox_status.Items.Add("<<<")
                        Me.Refresh()
                    Else
                        Dim p_file As System.IO.FileInfo
                        For Each p_file In p_dir.GetFiles()
                            Select Case p_file.Name.ToString.ToUpper
                                Case "SQLUPDATE.SQL"
                                    lbox_status.Items.Add(">>> Data updates found on " & g_backup.drive_letter & " Drive ...")
                                    lbox_status.Items.Add("<<<")
                                    Me.Refresh()

                                    Call process_sql(p_file, "INSERT")
                            
                                Case "CHKUPDATE.SQL"
                                    lbox_status.Items.Add(">>> Data updates found on " & g_backup.drive_letter & " Drive ...")
                                    lbox_status.Items.Add("<<<")
                                    Me.Refresh()

                                    Call process_sql(p_file, "CHECK")
                            End Select
                        Next
                    End If
                End If

                ' ---------------------------------------------------------------------
                ' * Check to see if CU_CSV_IMPORT folder is found, import CSV file data
                ' ---------------------------------------------------------------------
                p_dir = New DirectoryInfo(g_backup.drive_letter & ":\CU_CSV_IMPORT")

                If p_dir.Exists = False Then
                    lbox_status.Items.Add(">>> No CSV import files found on " & g_backup.drive_letter & " Drive ...")
                    lbox_status.Items.Add("<<<")
                    Me.Refresh()
                Else
                    If p_dir.GetFiles.Count = 0 Then
                        lbox_status.Items.Add(">>> No CSV import files found on " & g_backup.drive_letter & " Drive ...")
                        lbox_status.Items.Add("<<<")
                        Me.Refresh()
                    Else
                        Dim p_file As System.IO.FileInfo
                        For Each p_file In p_dir.GetFiles()
                            Select Case p_file.Name.ToString.ToUpper
                                Case "DETERGENT.CSV"
                                    lbox_status.Items.Add(">>> Detergent.csv file found on " & g_backup.drive_letter & " Drive ...")
                                    lbox_status.Items.Add("<<<")
                                    Me.Refresh()

                                    Call process_csv_import(p_file, "DETERGENT")

                                Case "INSTRUMENT.CSV"
                                    lbox_status.Items.Add(">>> Instrument.csv file found on " & g_backup.drive_letter & " Drive ...")
                                    lbox_status.Items.Add("<<<")
                                    Me.Refresh()

                                    Call process_csv_import(p_file, "INSTRUMENT")

                                Case "LIQUID_STERILANT.CSV"
                                    lbox_status.Items.Add(">>> Liquid_Sterilant.csv file found on " & g_backup.drive_letter & " Drive ...")
                                    lbox_status.Items.Add("<<<")
                                    Me.Refresh()

                                    Call process_csv_import(p_file, "LIQUID_STERILANT")

                                Case "EMPLOYEE_USER.CSV"
                                    lbox_status.Items.Add(">>> Employee_User.csv file found on " & g_backup.drive_letter & " Drive ...")
                                    lbox_status.Items.Add("<<<")
                                    Me.Refresh()

                                    Call process_csv_import(p_file, "EMPLOYEE_USER")

                                Case "PHYSICIAN.CSV"
                                    lbox_status.Items.Add(">>> Physician.csv file found on " & g_backup.drive_letter & " Drive ...")
                                    lbox_status.Items.Add("<<<")
                                    Me.Refresh()

                                    Call process_csv_import(p_file, "PHYSICIAN")

                                Case "PATIENT.CSV"
                                    lbox_status.Items.Add(">>> Patient.csv file found on " & g_backup.drive_letter & " Drive ...")
                                    lbox_status.Items.Add("<<<")
                                    Me.Refresh()

                                    Call process_csv_import(p_file, "PATIENT")
                            End Select
                        Next
                    End If
                End If

                ' Update Window to Complete
                lbox_status.Items.Add("<<<")
                lbox_status.Items.Add(">>> Processing Complete.")
                Me.Refresh()

                lbox_status.Items.Add("<<<")
                lbox_status.Items.Add(">>> Close to return to Main Program.")
                Me.Refresh()

            Case "CSV_EXPORT"
                ' ------------------------------------------------
                ' * Create CU_CSV_IMPORT folder and CSV data files
                ' ------------------------------------------------
                lbox_status.Items.Clear()
                lbox_status.Items.Add("<<<")
                lbox_status.Items.Add(">>> CSV Export ...")
                lbox_status.Items.Add("<<<")
                Me.Refresh()

                Call process_csv_export()

                ' Update Window to Complete
                lbox_status.Items.Add("<<<")
                lbox_status.Items.Add(">>> Processing Complete.")
                Me.Refresh()

                lbox_status.Items.Add("<<<")
                lbox_status.Items.Add(">>> Close to return to Main Program.")
                Me.Refresh()
        End Select
    End Sub
#End Region

#Region " Process CSV Export "
    Private Sub process_csv_export()
        Dim p_path As String = g_backup.drive_letter & ":\CU_CSV_IMPORT"
        Dim p_sql As String
        Dim p_dataset As DataSet

        Try
            ' -----------------------------
            ' * Create Directory, If Needed
            ' -----------------------------
            If System.IO.Directory.Exists(p_path) = False Then
                System.IO.Directory.CreateDirectory(p_path)
            End If

            ' --------------------
            ' * Get Data To Export
            ' --------------------
            p_sql = "Select detergent, notes " & _
                    "From detergent_maint " & _
                    "Where stop_use = 0 " & _
                    "Order By detergent; "

            p_sql &= "Select last_name, first_name, middle_initial, user_name, password, " & _
                     "Case When administrator = 1 Then 'T' Else 'F' End As [Flag] " & _
                     "From Employee E1 " & _
                     "INNER JOIN Users U1 On U1.employee_id = E1.employee_id " & _
                     "Where U1.inactive = 0 And U1.user_name <> 'cus' " & _
                     "Order By last_name, first_name, middle_initial; "

            p_sql &= "Select instrument, notes " & _
                     "From instrument_maint " & _
                     "Where stop_use = 0 " & _
                     "Order By instrument; "

            p_sql &= "Select liquid_sterilant, notes " & _
                     "From liquid_sterilant_maint " & _
                     "Where stop_use = 0 " & _
                     "Order By liquid_sterilant; "

            p_sql &= "Select prefix, last_name, first_name, middle_initial, suffix, notes " & _
                     "From physician_maint " & _
                     "Where stop_use = 0 " & _
                     "Order By last_name, first_name, middle_initial; "

            p_dataset = g_framework.Get_Data(p_sql)

            ' -------------------
            ' * Export Detergents
            ' -------------------
            If p_dataset.Tables(0).Rows.Count > 0 Then
                ' Create CSV File
                My.Computer.FileSystem.WriteAllText(p_path & "\DETERGENT.CSV", write_line(p_dataset.Tables(0)), False)

                lbox_status.Items.Add(">>> DETERGENT.CSV file was created - " & p_dataset.Tables(0).Rows.Count & " records ...")
                lbox_status.Items.Add("<<<")
                Me.Refresh()
            Else
                lbox_status.Items.Add(">>> DETERGENT.CSV file was not created ...")
                lbox_status.Items.Add("<<<")
                Me.Refresh()
            End If

            ' ----------------------
            ' * Export Employee/User
            ' ----------------------
            If p_dataset.Tables(1).Rows.Count > 0 Then
                ' Create CSV File
                My.Computer.FileSystem.WriteAllText(p_path & "\EMPLOYEE_USER.CSV", write_line(p_dataset.Tables(1)), False)

                lbox_status.Items.Add(">>> EMPLOYEE_USER.CSV file was created - " & p_dataset.Tables(1).Rows.Count & " records ...")
                lbox_status.Items.Add("<<<")
                Me.Refresh()
            Else
                lbox_status.Items.Add(">>> EMPLOYEE_USER.CSV file was not created ...")
                lbox_status.Items.Add("<<<")
                Me.Refresh()
            End If

            ' --------------------
            ' * Export Instruments
            ' --------------------
            If p_dataset.Tables(2).Rows.Count > 0 Then
                ' Create CSV File
                My.Computer.FileSystem.WriteAllText(p_path & "\INSTRUMENT.CSV", write_line(p_dataset.Tables(2)), False)

                lbox_status.Items.Add(">>> INSTRUMENT.CSV file was created - " & p_dataset.Tables(2).Rows.Count & " records ...")
                lbox_status.Items.Add("<<<")
                Me.Refresh()
            Else
                lbox_status.Items.Add(">>> INSTRUMENT.CSV file was not created ...")
                lbox_status.Items.Add("<<<")
                Me.Refresh()
            End If

            ' -------------------------
            ' * Export Liquid Sterilant
            ' -------------------------
            If p_dataset.Tables(3).Rows.Count > 0 Then
                ' Create CSV File
                My.Computer.FileSystem.WriteAllText(p_path & "\LIQUID_STERILANT.CSV", write_line(p_dataset.Tables(3)), False)

                lbox_status.Items.Add(">>> LIQUID_STERILANT.CSV file was created - " & p_dataset.Tables(3).Rows.Count & " records ...")
                lbox_status.Items.Add("<<<")
                Me.Refresh()
            Else
                lbox_status.Items.Add(">>> LIQUID_STERILANT.CSV file was not created ...")
                lbox_status.Items.Add("<<<")
                Me.Refresh()
            End If

            ' -------------------
            ' * Export Physicians
            ' -------------------
            If p_dataset.Tables(4).Rows.Count > 0 Then
                ' Create CSV File
                My.Computer.FileSystem.WriteAllText(p_path & "\PHYSICIAN.CSV", write_line(p_dataset.Tables(4)), False)

                lbox_status.Items.Add(">>> PHYSICIAN.CSV file was created - " & p_dataset.Tables(4).Rows.Count & " records ...")
                lbox_status.Items.Add("<<<")
                Me.Refresh()
            Else
                lbox_status.Items.Add(">>> PHYSICIAN.CSV file was not created ...")
                lbox_status.Items.Add("<<<")
                Me.Refresh()
            End If

        Catch
            lbox_status.Items.Add(">>> CSV file export failed ...")
            lbox_status.Items.Add("<<<")
            Me.Refresh()
        End Try
    End Sub

    Private Function write_line(ByVal p_table As DataTable) As String
        Dim p_row_count As Integer = 0
        Dim p_col_count As Integer = 0
        Dim p_db_row As DataRow

        write_line = ""

        ' --------------
        ' * Process Data
        ' --------------
        For Each p_db_row In p_table.Rows
            For Each field As Object In p_db_row.ItemArray
                write_line &= field.ToString.Replace(",", "")
                p_col_count += 1

                If p_col_count <> p_db_row.ItemArray.Count Then
                    write_line &= ","
                End If
            Next

            p_row_count += 1

            If p_row_count <> p_table.Rows.Count Then
                write_line &= vbNewLine
            End If

            p_col_count = 0
        Next
    End Function
#End Region

#Region " Process CSV Import "
    Private Sub process_csv_import(ByVal p_file As System.IO.FileInfo, ByVal p_mode As String)
        Dim p_value As String = ""
        Dim p_exists As Integer = 0
        Dim p_added As Integer = 0
        Dim p_failed As Integer = 0

        Dim p_value2 As String = ""
        Dim p_exists2 As Integer = 0
        Dim p_added2 As Integer = 0
        Dim p_failed2 As Integer = 0
        Dim tmpstream As StreamReader = Nothing

        Try
            Dim p_strlines() As String
            Dim p_strline() As String
            Dim p_rows As Integer
            Dim p_cols As Integer
            Dim p_strarray(,) As String
            Dim p_x As Integer
            Dim p_y As Integer

            Dim p_sql As String
            Dim p_dataset As DataSet

            ' =======================
            ' * Process CSV File Data
            ' =======================
            tmpstream = p_file.OpenText

            ' ----------------------------------------
            ' * Load content of file to strLines array 
            ' ----------------------------------------
            p_strlines = tmpstream.ReadToEnd().Split(Environment.NewLine)

            ' -----------------------------------------------
            ' * Get Row/Column Counts From First Line In File
            ' -----------------------------------------------
            p_rows = UBound(p_strlines)
            p_strline = p_strlines(0).Split(",")
            p_cols = UBound(p_strline)

            ' -------------------
            ' * Check Column Size
            ' -------------------
            Select Case p_mode
                Case "DETERGENT", "LIQUID_STERILANT", "INSTRUMENT"
                    If p_cols <> 1 Then
                        lbox_status.Items.Add(">>> " & p_mode & ".csv file contains invalid data structure ...")
                        lbox_status.Items.Add("<<<")
                        Me.Refresh()

                        Exit Sub
                    End If

                Case "EMPLOYEE_USER"
                    If p_cols <> 5 Then
                        lbox_status.Items.Add(">>> " & p_mode & ".csv file contains invalid data structure ...")
                        lbox_status.Items.Add("<<<")
                        Me.Refresh()

                        Exit Sub
                    End If

                Case "PHYSICIAN"
                    If p_cols <> 5 Then
                        lbox_status.Items.Add(">>> " & p_mode & ".csv file contains invalid data structure ...")
                        lbox_status.Items.Add("<<<")
                        Me.Refresh()

                        Exit Sub
                    End If

                Case "PATIENT"
                    If p_cols <> 7 Then
                        lbox_status.Items.Add(">>> " & p_mode & ".csv file contains invalid data structure ...")
                        lbox_status.Items.Add("<<<")
                        Me.Refresh()

                        Exit Sub
                    End If
            End Select

            lbox_status.Items.Add(">>>      " & p_rows + 1 & " record" & IIf(p_rows + 1 > 1, "s", "") & " to be processed ...")
            lbox_status.Items.Add("<<<")
            Me.Refresh()

            ' ------------------------------
            ' * Copy the data into the array 
            ' ------------------------------
            ReDim p_strarray(p_rows, p_cols)

            For p_x = 0 To p_rows
                p_strline = p_strlines(p_x).Split(",")

                For p_y = 0 To p_cols
                    p_strarray(p_x, p_y) = p_strline(p_y)
                Next
            Next

            ' --------------
            ' * Process Data 
            ' --------------
            Select Case p_mode
                Case "DETERGENT", "LIQUID_STERILANT", "INSTRUMENT"
                    For p_x = 0 To p_rows
                        ' ---------------------------------------------------------------
                        ' * Check If Record Has Mandatory Field Data / Valid Data Lengths
                        ' ---------------------------------------------------------------
                        If p_strarray(p_x, 0).Trim = "" Or Len(p_strarray(p_x, 0).Trim) > 100 Or Len(p_strarray(p_x, 1).Trim) > 1200 Then
                            p_failed += 1
                        Else
                            ' --------------------------------
                            ' * Check If Record Already Exists
                            ' --------------------------------
                            p_sql = "Select * From " & p_mode & "_maint " & _
                                    "Where LTrim(RTrim(" & p_mode & ")) = " & return_parsed_single_quote_string(p_strarray(p_x, 0).Trim)
                            p_dataset = g_framework.Get_Data(p_sql)

                            If p_dataset.Tables(0).Rows.Count > 0 Then
                                If p_dataset.Tables(0).Rows(0).Item("stop_use") = False Then
                                    p_exists += 1
                                Else
                                    ' ===========================================================
                                    ' * Remove Stop Use And Update Record So It Can Be Used Again
                                    ' ===========================================================
                                    p_sql = "Update " & p_mode & "_maint " & _
                                            "Set stop_use = 0, notes = " & return_parsed_single_quote_string(p_strarray(p_x, 1).Trim) & _
                                            ", date_lused = getdate() " & _
                                            "WHERE " & p_mode & "_id = '" & p_dataset.Tables(0).Rows(0).Item(p_mode & "_id").ToString & "'"

                                    If g_framework.Execute_Query(p_sql) Then
                                        p_added += 1
                                    Else
                                        p_failed += 1
                                    End If
                                End If
                            Else
                                ' ------------
                                ' * Add Record
                                ' ------------
                                p_sql = "INSERT INTO " & p_mode & "_maint (" & p_mode & ", notes, stop_use, date_added) Values ("

                                For p_y = 0 To p_cols
                                    p_sql &= return_parsed_single_quote_string(p_strarray(p_x, p_y).Trim) & ", "
                                Next

                                p_sql &= "0, getdate())"

                                If g_framework.Execute_Query(p_sql) Then
                                    p_added += 1
                                Else
                                    p_failed += 1
                                End If
                            End If

                            ' Reset Dataset
                            p_dataset.Reset()
                        End If
                    Next

                Case "EMPLOYEE_USER"
                    Dim p_employee_id As String
                    Dim p_emp_bad As Boolean

                    p_value = " Employee"
                    p_value2 = " User"

                    For p_x = 0 To p_rows
                        p_employee_id = ""
                        p_emp_bad = False

                        ' ---------------------------------------------------------------
                        ' * Check If Record Has Mandatory Field Data / Valid Data Lengths
                        ' ---------------------------------------------------------------
                        If p_strarray(p_x, 0).Trim = "" Or p_strarray(p_x, 1).Trim = "" Or p_strarray(p_x, 3).Trim = "" Or p_strarray(p_x, 4).Trim = "" Or _
                            Len(p_strarray(p_x, 0).Trim) > 50 Or Len(p_strarray(p_x, 1).Trim) > 50 Or Len(p_strarray(p_x, 2).Trim) > 2 Or _
                            Len(p_strarray(p_x, 3).Trim) > 20 Or Len(p_strarray(p_x, 4).Trim) > 20 Or Len(p_strarray(p_x, 5).Trim) > 1 Then

                            p_failed += 1
                            p_failed2 += 1
                        Else
                            ' -----------------------------------------
                            ' * Check If Employee Record Already Exists
                            ' -----------------------------------------
                            p_sql = "Select * From Employee " & _
                                    "Where LTrim(RTrim(first_name)) = " & return_parsed_single_quote_string(p_strarray(p_x, 1).Trim) & _
                                    " And LTrim(RTrim(last_name)) = " & return_parsed_single_quote_string(p_strarray(p_x, 0).Trim) & _
                                    " And LTrim(RTrim(middle_initial)) = " & return_parsed_single_quote_string(p_strarray(p_x, 2).Trim)
                            p_dataset = g_framework.Get_Data(p_sql)

                            If p_dataset.Tables(0).Rows.Count > 0 Then
                                p_exists += 1

                                ' Get Employee ID
                                p_employee_id = p_dataset.Tables(0).Rows(0).Item("employee_id").ToString
                            Else
                                ' Create ID
                                p_employee_id = Guid.NewGuid.ToString

                                ' ------------
                                ' * Add Record
                                ' ------------
                                p_sql = "INSERT INTO Employee (employee_id, last_name, first_name, middle_initial, date_added) " & _
                                        "Values ('" & p_employee_id & "', "

                                For p_y = 0 To 2
                                    p_sql &= return_parsed_single_quote_string(p_strarray(p_x, p_y).Trim) & ", "
                                Next

                                p_sql &= "getdate())"

                                If g_framework.Execute_Query(p_sql) Then
                                    p_added += 1
                                Else
                                    p_failed += 1
                                    p_emp_bad = True
                                End If
                            End If

                            ' Reset Dataset
                            p_dataset.Reset()

                            If p_employee_id <> "" And p_emp_bad = False Then
                                If p_strarray(p_x, 3).Trim.ToUpper = "CUS" Then
                                    ' --------------------------------------
                                    ' * Username Is Reserved For CU Use Only
                                    ' --------------------------------------
                                    p_failed2 += 1
                                Else
                                    ' --------------------------------------------------------------------------------------------
                                    ' * Check If Username Exists For Another Employee Already / Check If Employee Already Has User
                                    ' --------------------------------------------------------------------------------------------
                                    p_sql = "Select * From Users " & _
                                            "Where employee_id <> '" & p_employee_id & _
                                            "' And LTrim(RTrim(user_name)) = " & return_parsed_single_quote_string(p_strarray(p_x, 3).Trim) & "; "

                                    p_sql &= "Select * From Users " & _
                                             "Where employee_id = '" & p_employee_id & "'; "

                                    p_dataset = g_framework.Get_Data(p_sql)

                                    If p_dataset.Tables(0).Rows.Count > 0 Then
                                        ' ----------------------------------------------
                                        ' * Username Already Exists For Another Employee
                                        ' ----------------------------------------------
                                        p_failed2 += 1
                                    Else
                                        If p_dataset.Tables(1).Rows.Count > 0 Then
                                            ' -----------------------------
                                            ' * Update Existing User Record
                                            ' -----------------------------
                                            p_sql = "Update Users " & _
                                                    "Set user_name = " & return_parsed_single_quote_string(p_strarray(p_x, 3).Trim) & _
                                                    ", password = " & return_parsed_single_quote_string(p_strarray(p_x, 4).Trim) & _
                                                    ", inactive = 0, date_lused = getdate() " & _
                                                    "WHERE user_id = '" & p_dataset.Tables(1).Rows(0).Item("user_id").ToString & "'"

                                            If g_framework.Execute_Query(p_sql) Then
                                                p_exists2 += 1
                                            Else
                                                p_failed2 += 1
                                            End If
                                        Else
                                            ' -----------------
                                            ' * Add User Record
                                            ' -----------------
                                            p_sql = "INSERT INTO Users (employee_id, user_name, password, administrator, inactive, date_added) " & _
                                                    "Values ('" & p_employee_id & "', " & return_parsed_single_quote_string(p_strarray(p_x, 3).Trim) & _
                                                    ", " & return_parsed_single_quote_string(p_strarray(p_x, 4).Trim) & ", "

                                            If p_strarray(p_x, 5).Trim <> "T" Then
                                                p_sql &= "0, "
                                            Else
                                                p_sql &= "1, "
                                            End If

                                            p_sql &= "0, getdate())"

                                            If g_framework.Execute_Query(p_sql) Then
                                                p_added2 += 1
                                            Else
                                                p_failed2 += 1
                                            End If
                                        End If
                                    End If

                                    ' Reset Dataset
                                    p_dataset.Reset()
                                End If
                            End If
                        End If
                    Next

                Case "PHYSICIAN"
                    For p_x = 0 To p_rows
                        ' ---------------------------------------------------------------
                        ' * Check If Record Has Mandatory Field Data / Valid Data Lengths
                        ' ---------------------------------------------------------------
                        If p_strarray(p_x, 1).Trim = "" Or p_strarray(p_x, 2).Trim = "" Or _
                            Len(p_strarray(p_x, 0).Trim) > 5 Or Len(p_strarray(p_x, 1).Trim) > 50 Or Len(p_strarray(p_x, 2).Trim) > 50 Or _
                            Len(p_strarray(p_x, 3).Trim) > 2 Or Len(p_strarray(p_x, 4).Trim) > 5 Or Len(p_strarray(p_x, 5).Trim) > 1200 Then

                            p_failed += 1
                        Else
                            ' --------------------------------
                            ' * Check If Record Already Exists
                            ' --------------------------------
                            p_sql = "Select * From " & p_mode & "_maint " & _
                                    "Where LTrim(RTrim(first_name)) = " & return_parsed_single_quote_string(p_strarray(p_x, 2).Trim) & _
                                    " And LTrim(RTrim(last_name)) = " & return_parsed_single_quote_string(p_strarray(p_x, 1).Trim) & _
                                    " And LTrim(RTrim(middle_initial)) = " & return_parsed_single_quote_string(p_strarray(p_x, 3).Trim)
                            p_dataset = g_framework.Get_Data(p_sql)

                            If p_dataset.Tables(0).Rows.Count > 0 Then
                                If p_dataset.Tables(0).Rows(0).Item("stop_use") = False Then
                                    p_exists += 1
                                Else
                                    ' ===========================================================
                                    ' * Remove Stop Use And Update Record So It Can Be Used Again
                                    ' ===========================================================
                                    p_sql = "Update " & p_mode & "_maint " & _
                                            "Set stop_use = 0, prefix = " & return_parsed_single_quote_string(p_strarray(p_x, 0).Trim) & _
                                            ", suffix = " & return_parsed_single_quote_string(p_strarray(p_x, 4).Trim) & _
                                            ", notes = " & return_parsed_single_quote_string(p_strarray(p_x, 5).Trim) & _
                                            ", date_lused = getdate() " & _
                                            "WHERE " & p_mode & "_id = '" & p_dataset.Tables(0).Rows(0).Item(p_mode & "_id").ToString & "'"

                                    If g_framework.Execute_Query(p_sql) Then
                                        p_added += 1
                                    Else
                                        p_failed += 1
                                    End If
                                End If
                            Else
                                ' ------------
                                ' * Add Record
                                ' ------------
                                p_sql = "INSERT INTO " & p_mode & "_maint (prefix, last_name, first_name, middle_initial, suffix, notes, stop_use, date_added) Values ("

                                For p_y = 0 To p_cols
                                    p_sql &= return_parsed_single_quote_string(p_strarray(p_x, p_y).Trim) & ", "
                                Next

                                p_sql &= "0, getdate())"

                                If g_framework.Execute_Query(p_sql) Then
                                    p_added += 1
                                Else
                                    p_failed += 1
                                End If
                            End If

                            ' Reset Dataset
                            p_dataset.Reset()
                        End If
                    Next

                Case "PATIENT"
                    Dim p_physician_id As String
                    Dim p_physician_bad As Boolean

                    p_value = " Physician"
                    p_value2 = " Patient"

                    For p_x = 0 To p_rows
                        p_physician_id = ""
                        p_physician_bad = False

                        ' ---------------------------------------------------------------
                        ' * Check If Record Has Mandatory Field Data / Valid Data Lengths
                        ' ---------------------------------------------------------------
                        If p_strarray(p_x, 0).Trim = "" Or p_strarray(p_x, 1).Trim = "" Or p_strarray(p_x, 3).Trim = "" Or p_strarray(p_x, 4).Trim = "" Or p_strarray(p_x, 6).Trim = "" Or _
                            Len(p_strarray(p_x, 0).Trim) > 50 Or Len(p_strarray(p_x, 1).Trim) > 50 Or Len(p_strarray(p_x, 2).Trim) > 2 Or _
                            Len(p_strarray(p_x, 3).Trim) > 50 Or Len(p_strarray(p_x, 4).Trim) > 50 Or Len(p_strarray(p_x, 5).Trim) > 2 Or _
                            Len(p_strarray(p_x, 6).Trim) > 50 Or Len(p_strarray(p_x, 7).Trim) > 1200 Then

                            p_failed += 1
                            p_failed2 += 1
                        Else
                            ' ------------------------------------------
                            ' * Check If Physician Record Already Exists
                            ' ------------------------------------------
                            p_sql = "Select * From physician_maint " & _
                                    "Where LTrim(RTrim(first_name)) = " & return_parsed_single_quote_string(p_strarray(p_x, 4).Trim) & _
                                    " And LTrim(RTrim(last_name)) = " & return_parsed_single_quote_string(p_strarray(p_x, 3).Trim) & _
                                    " And LTrim(RTrim(middle_initial)) = " & return_parsed_single_quote_string(p_strarray(p_x, 5).Trim)
                            p_dataset = g_framework.Get_Data(p_sql)

                            If p_dataset.Tables(0).Rows.Count > 0 Then
                                ' Get Physician ID
                                p_physician_id = p_dataset.Tables(0).Rows(0).Item("physician_id").ToString()

                                If p_dataset.Tables(0).Rows(0).Item("stop_use") = False Then
                                    p_exists += 1
                                Else
                                    ' ===========================================================
                                    ' * Remove Stop Use And Update Record So It Can Be Used Again
                                    ' ===========================================================
                                    p_sql = "Update physician_maint " & _
                                            "Set stop_use = 0, date_lused = getdate() " & _
                                            "WHERE physician_id = '" & p_physician_id & "'"

                                    If g_framework.Execute_Query(p_sql) Then
                                        p_added += 1
                                    Else
                                        p_failed += 1
                                        p_physician_bad = True
                                    End If
                                End If
                            Else
                                ' Create ID
                                p_physician_id = Guid.NewGuid.ToString

                                ' ------------
                                ' * Add Record
                                ' ------------
                                p_sql = "INSERT INTO physician_maint (physician_id, last_name, first_name, middle_initial, stop_use, date_added) " & _
                                        "Values ('" & p_physician_id & "', "

                                For p_y = 3 To 5
                                    p_sql &= return_parsed_single_quote_string(p_strarray(p_x, p_y).Trim) & ", "
                                Next

                                p_sql &= "0, getdate())"

                                If g_framework.Execute_Query(p_sql) Then
                                    p_added += 1
                                Else
                                    p_failed += 1
                                    p_physician_bad = True
                                End If
                            End If

                            ' Reset Dataset
                            p_dataset.Reset()

                            If p_physician_id <> "" And p_physician_bad = False Then
                                ' ----------------------------------------
                                ' * Check If Patient Record Already Exists
                                ' ----------------------------------------
                                p_sql = "Select * From patient_maint " & _
                                        "Where LTrim(RTrim(first_name)) = " & return_parsed_single_quote_string(p_strarray(p_x, 1).Trim) & _
                                        " And LTrim(RTrim(last_name)) = " & return_parsed_single_quote_string(p_strarray(p_x, 0).Trim) & _
                                        " And LTrim(RTrim(middle_initial)) = " & return_parsed_single_quote_string(p_strarray(p_x, 2).Trim) & _
                                        " And LTrim(RTrim(code)) = " & return_parsed_single_quote_string(p_strarray(p_x, 6).Trim)
                                p_dataset = g_framework.Get_Data(p_sql)

                                If p_dataset.Tables(0).Rows.Count > 0 Then
                                    ' ------------------------------------------------
                                    ' * Update Physician ID of Existing Patient Record
                                    ' ------------------------------------------------
                                    p_sql = "Update patient_maint " & _
                                            "Set physician_id = '" & p_physician_id & "', date_lused = getdate() " & _
                                            "WHERE patient_id = '" & p_dataset.Tables(0).Rows(0).Item("patient_id").ToString & "'"

                                    If g_framework.Execute_Query(p_sql) Then
                                        p_exists2 += 1
                                    Else
                                        p_failed2 += 1
                                    End If
                                Else
                                    ' --------------------
                                    ' * Add Patient Record
                                    ' --------------------
                                    p_sql = "INSERT INTO patient_maint (physician_id, last_name, first_name, middle_initial, code, notes, date_added) " & _
                                            "Values ('" & p_physician_id & "', "

                                    For p_y = 0 To 2
                                        p_sql &= return_parsed_single_quote_string(p_strarray(p_x, p_y).Trim) & ", "
                                    Next

                                    p_sql &= return_parsed_single_quote_string(p_strarray(p_x, 6).Trim) & ", " & return_parsed_single_quote_string(p_strarray(p_x, 7).Trim) & _
                                             ", getdate())"

                                    If g_framework.Execute_Query(p_sql) Then
                                        p_added2 += 1
                                    Else
                                        p_failed2 += 1
                                    End If
                                End If

                                ' Reset Dataset
                                p_dataset.Reset()
                            End If
                        End If
                    Next
            End Select

        Catch
            lbox_status.Items.Add(">>> " & p_mode & ".csv file was not proceed successfully ...")
            lbox_status.Items.Add("<<<")
            Me.Refresh()

        Finally
            If Not tmpstream Is Nothing Then tmpstream.Close()

            ' ----------------------------------
            ' * Report Processing Detail, If Any
            ' ----------------------------------
            If p_exists <> 0 Or p_added <> 0 Or p_failed <> 0 Then
                If p_exists <> 0 Then
                    lbox_status.Items.Add(">>>      " & p_exists & p_value & " record" & IIf(p_exists > 1, "s", "") & " already exist ...")
                    lbox_status.Items.Add("<<<")
                    Me.Refresh()
                End If

                If p_added <> 0 Then
                    lbox_status.Items.Add(">>>      " & p_added & p_value & " record" & IIf(p_added > 1, "s", "") & " added ...")
                    lbox_status.Items.Add("<<<")
                    Me.Refresh()
                End If

                If p_failed <> 0 Then
                    lbox_status.Items.Add(">>>      " & p_failed & p_value & " record" & IIf(p_failed > 1, "s", "") & " failed to process ...")
                    lbox_status.Items.Add("<<<")
                    Me.Refresh()
                End If
            End If

            If p_exists2 <> 0 Or p_added2 <> 0 Or p_failed2 <> 0 Then
                If p_exists2 <> 0 Then
                    lbox_status.Items.Add(">>>      " & p_exists2 & p_value2 & " record" & IIf(p_exists2 > 1, "s", "") & " already exist ...")
                    lbox_status.Items.Add("<<<")
                    Me.Refresh()
                End If

                If p_added2 <> 0 Then
                    lbox_status.Items.Add(">>>      " & p_added2 & p_value2 & " record" & IIf(p_added2 > 1, "s", "") & " added ...")
                    lbox_status.Items.Add("<<<")
                    Me.Refresh()
                End If

                If p_failed2 <> 0 Then
                    lbox_status.Items.Add(">>>      " & p_failed2 & p_value2 & " record" & IIf(p_failed2 > 1, "s", "") & " failed to process ...")
                    lbox_status.Items.Add("<<<")
                    Me.Refresh()
                End If
            End If
        End Try
    End Sub
#End Region

#Region " Process SQL "
    Private Sub process_sql(ByVal p_file As System.IO.FileInfo, ByVal p_mode As String)
        Dim objStreamReader As StreamReader = Nothing

        Try
            'open the file
            objStreamReader = New StreamReader(p_file.FullName)

            'Read the file storing it in the readfile string
            Dim readfile As String = objStreamReader.ReadToEnd()

            'Place the string into a web control
            If p_mode = "INSERT" Then
                Call g_framework.Execute_Query(readfile)

                lbox_status.Items.Add(">>> Data updates processed ...")
                Me.Refresh()
            Else
                Dim p_dataset As DataSet

                p_dataset = g_framework.Get_Data(readfile)

                If p_dataset.Tables(0).Rows.Count = 0 Then
                    lbox_status.Items.Add(">>> Error:  Data updates FAILED! ...")
                    Me.Refresh()
                Else
                    If p_dataset.Tables(0).Rows(0).Item(0).ToString = "1" Then
                        lbox_status.Items.Add(">>> Data updates successful ...")
                    Else
                        lbox_status.Items.Add(">>> Error:  Data updates FAILED! ...")
                    End If
                    Me.Refresh()
                End If

                ' Dispose of Dataset
                p_dataset.Dispose()
            End If

        Finally
            'close the StreamReader class
            If Not objStreamReader Is Nothing Then objStreamReader.Close()
        End Try
    End Sub
#End Region

#Region " Run Backup "
    Private Sub run_backup()
        ' Disable Timer
        backup_timer.Enabled = False

        ' ----------------
        ' * Create Reports
        ' ----------------
        Call create_reports()

        lbox_status.Items.Add("<<<")
        Me.Refresh()

        ' --------------------------------------------------------
        ' * Backup Data/Reports to CD, Local Drive or Network Path
        ' --------------------------------------------------------
        If g_backup.bu_local Then
            If g_backup.drive_type.ToUpper = "CDROM" Then
                Call Backup_CDROM("ALL")
            Else
                Call Backup_To_Path("ALL")
            End If
        Else
            If g_backup.network_path.ToUpper = "" Then
                lbox_status.Items.Add(">>> Files left in Default Backup Directory - Network Path not set ...")
                Me.Refresh()
            Else
                Call Backup_To_Path("ALL")
            End If
        End If
    End Sub

    Private Sub exports_backup()
        ' ----------------
        ' * Create Reports
        ' ----------------
        Call create_reports()

        lbox_status.Items.Add("<<<")
        Me.Refresh()

        ' ---------------------------------------------------
        ' * Backup Reports to CD, Local Drive or Network Path
        ' ---------------------------------------------------
        If g_backup.bu_local Then
            If g_backup.drive_type.ToUpper = "CDROM" Then
                Call Backup_CDROM("REPORTS")
            Else
                Call Backup_To_Path("REPORTS")
            End If
        Else
            If g_backup.network_path.ToUpper = "" Then
                lbox_status.Items.Add(">>> Files left in Default Backup Directory - Network Path not set ...")
                Me.Refresh()
            Else
                Call Backup_To_Path("REPORTS")
            End If
        End If
    End Sub
#End Region

#Region " Timer Events "
    Private Sub backup_timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles backup_timer.Tick
        ' Check the Time
        'MsgBox(g_backup.time & " - " & Now.ToString)

        If CDate(g_backup.time) <= CDate(DateTime.Now.ToShortTimeString) Then
            Call run_backup()
        End If
    End Sub
#End Region

#Region " Write Out Status "
    Private Sub write_out_status()
        Dim p_sql As String
        p_sql = "INSERT SYSTEM_NIGHT(date_event, backup_ok, report_ok, update_ok) " & _
                "VALUES ('" & g_event.e_date & "', '" & g_event.e_backup.ToString & _
                "', '" & g_event.e_report.ToString & "', '" & g_event.e_update.ToString & "')"
        Call g_framework.Execute_Query(p_sql)
    End Sub
#End Region

End Class
