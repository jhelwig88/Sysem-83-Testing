Public Class backup_view
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
    Friend WithEvents grd_display As DBA.Library.DBA_StyleGrid
    Friend WithEvents GroupByRow1 As Xceed.Grid.GroupByRow
    Friend WithEvents ColumnManagerRow1 As Xceed.Grid.ColumnManagerRow
    Friend WithEvents dataRowTemplate1 As Xceed.Grid.DataRow
    Friend WithEvents DbA_Panel1 As DBA.Library.DBA_Panel
    Friend WithEvents dte_to As DBA.Library.DBA_DateBox
    Friend WithEvents dte_from As DBA.Library.DBA_DateBox
    Friend WithEvents lbl_filter As DBA.Library.DBA_Label
    Friend WithEvents btn_reset As DBA.Library.DBA_Button
    Friend WithEvents btn_data As DBA.Library.DBA_Button
    Friend WithEvents btn_close As DBA.Library.DBA_Button
    Friend WithEvents lbl_screen As DBA.Library.DBA_Label
    Friend WithEvents lbl_F5 As DBA.Library.DBA_Label
    Friend WithEvents DbA_Panel2 As DBA.Library.DBA_Panel
    Friend WithEvents txt_total_prod As DBA.Library.DBA_TextBox
    Friend WithEvents txt_total_head As DBA.Library.DBA_TextBox
    Friend WithEvents lbl_F10 As DBA.Library.DBA_Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(backup_view))
        Me.pnl_main = New DBA.Library.DBA_Panel
        Me.lbl_F10 = New DBA.Library.DBA_Label(Me.components)
        Me.DbA_Panel2 = New DBA.Library.DBA_Panel
        Me.txt_total_prod = New DBA.Library.DBA_TextBox
        Me.txt_total_head = New DBA.Library.DBA_TextBox
        Me.lbl_screen = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_F5 = New DBA.Library.DBA_Label(Me.components)
        Me.DbA_Panel1 = New DBA.Library.DBA_Panel
        Me.dte_to = New DBA.Library.DBA_DateBox
        Me.dte_from = New DBA.Library.DBA_DateBox
        Me.lbl_filter = New DBA.Library.DBA_Label(Me.components)
        Me.btn_reset = New DBA.Library.DBA_Button(Me.components)
        Me.btn_data = New DBA.Library.DBA_Button(Me.components)
        Me.btn_close = New DBA.Library.DBA_Button(Me.components)
        Me.grd_display = New DBA.Library.DBA_StyleGrid
        Me.dataRowTemplate1 = New Xceed.Grid.DataRow
        Me.GroupByRow1 = New Xceed.Grid.GroupByRow
        Me.ColumnManagerRow1 = New Xceed.Grid.ColumnManagerRow
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_main.SuspendLayout()
        Me.DbA_Panel2.SuspendLayout()
        Me.DbA_Panel1.SuspendLayout()
        CType(Me.grd_display, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataRowTemplate1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColumnManagerRow1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_main
        '
        Me.pnl_main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_main.Controls.Add(Me.lbl_F10)
        Me.pnl_main.Controls.Add(Me.DbA_Panel2)
        Me.pnl_main.Controls.Add(Me.lbl_screen)
        Me.pnl_main.Controls.Add(Me.lbl_F5)
        Me.pnl_main.Controls.Add(Me.DbA_Panel1)
        Me.pnl_main.Controls.Add(Me.btn_reset)
        Me.pnl_main.Controls.Add(Me.btn_data)
        Me.pnl_main.Controls.Add(Me.btn_close)
        Me.pnl_main.Controls.Add(Me.grd_display)
        Me.pnl_main.DataSettings.IDField = "settings_id"
        Me.pnl_main.DataSettings.JoinData = Nothing
        Me.pnl_main.DataSettings.LinkField = Nothing
        Me.pnl_main.DataSettings.TableName = "settings_maint"
        Me.pnl_main.Gradient = False
        Me.pnl_main.Location = New System.Drawing.Point(0, 0)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.RecordID = Nothing
        Me.pnl_main.Saved = False
        Me.pnl_main.Size = New System.Drawing.Size(643, 553)
        Me.pnl_main.TabIndex = 0
        '
        'lbl_F10
        '
        Me.lbl_F10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_F10.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_F10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_F10.ForeColor = System.Drawing.Color.Black
        Me.lbl_F10.Location = New System.Drawing.Point(424, 37)
        Me.lbl_F10.Name = "lbl_F10"
        Me.lbl_F10.Size = New System.Drawing.Size(133, 17)
        Me.lbl_F10.TabIndex = 41
        Me.lbl_F10.Text = "F10 - Access Main Grid"
        Me.lbl_F10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_F10.UseMnemonic = False
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
        Me.DbA_Panel2.Location = New System.Drawing.Point(7, 103)
        Me.DbA_Panel2.Name = "DbA_Panel2"
        Me.DbA_Panel2.RecordID = Nothing
        Me.DbA_Panel2.Saved = False
        Me.DbA_Panel2.Size = New System.Drawing.Size(623, 31)
        Me.DbA_Panel2.TabIndex = 40
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
        Me.txt_total_prod.Label_Properties.Text = "Criteria Total:"
        Me.txt_total_prod.Label_Properties.Width = 105
        Me.txt_total_prod.Location = New System.Drawing.Point(313, 2)
        Me.txt_total_prod.Mandatory = False
        Me.txt_total_prod.Name = "txt_total_prod"
        Me.txt_total_prod.Override_Modified = False
        Me.txt_total_prod.SaveLoadOrder = 0
        Me.txt_total_prod.Size = New System.Drawing.Size(283, 26)
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
        Me.txt_total_head.Label_Properties.Text = "Overall Total:"
        Me.txt_total_head.Label_Properties.Width = 85
        Me.txt_total_head.Location = New System.Drawing.Point(9, 2)
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
        'lbl_screen
        '
        Me.lbl_screen.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_screen.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_screen.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_screen.ForeColor = System.Drawing.Color.Black
        Me.lbl_screen.Location = New System.Drawing.Point(427, 10)
        Me.lbl_screen.Name = "lbl_screen"
        Me.lbl_screen.Size = New System.Drawing.Size(199, 18)
        Me.lbl_screen.TabIndex = 37
        Me.lbl_screen.Text = "Backup Log"
        Me.lbl_screen.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl_screen.UseMnemonic = False
        '
        'lbl_F5
        '
        Me.lbl_F5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_F5.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_F5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_F5.ForeColor = System.Drawing.Color.Black
        Me.lbl_F5.Location = New System.Drawing.Point(566, 37)
        Me.lbl_F5.Name = "lbl_F5"
        Me.lbl_F5.Size = New System.Drawing.Size(60, 17)
        Me.lbl_F5.TabIndex = 38
        Me.lbl_F5.Text = "F5 - Print"
        Me.lbl_F5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_F5.UseMnemonic = False
        '
        'DbA_Panel1
        '
        Me.DbA_Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DbA_Panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.DbA_Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DbA_Panel1.Controls.Add(Me.dte_to)
        Me.DbA_Panel1.Controls.Add(Me.dte_from)
        Me.DbA_Panel1.Controls.Add(Me.lbl_filter)
        Me.DbA_Panel1.DataSettings.IDField = Nothing
        Me.DbA_Panel1.DataSettings.JoinData = Nothing
        Me.DbA_Panel1.DataSettings.LinkField = Nothing
        Me.DbA_Panel1.DataSettings.TableName = Nothing
        Me.DbA_Panel1.Gradient = False
        Me.DbA_Panel1.Location = New System.Drawing.Point(7, 59)
        Me.DbA_Panel1.Name = "DbA_Panel1"
        Me.DbA_Panel1.RecordID = Nothing
        Me.DbA_Panel1.Saved = False
        Me.DbA_Panel1.Size = New System.Drawing.Size(623, 45)
        Me.DbA_Panel1.TabIndex = 10
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
        Me.dte_to.Location = New System.Drawing.Point(288, 11)
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
        Me.dte_from.Location = New System.Drawing.Point(128, 11)
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
        Me.lbl_filter.Location = New System.Drawing.Point(16, 16)
        Me.lbl_filter.Name = "lbl_filter"
        Me.lbl_filter.Size = New System.Drawing.Size(94, 13)
        Me.lbl_filter.TabIndex = 0
        Me.lbl_filter.Text = "Filter Criteria:"
        Me.lbl_filter.UseMnemonic = False
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
        Me.btn_reset.Location = New System.Drawing.Point(150, 10)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(123, 43)
        Me.btn_reset.TabIndex = 3
        Me.btn_reset.TabStop = False
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_reset.UseVisualStyleBackColor = False
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
        Me.btn_data.Location = New System.Drawing.Point(7, 10)
        Me.btn_data.Name = "btn_data"
        Me.btn_data.Size = New System.Drawing.Size(123, 43)
        Me.btn_data.TabIndex = 2
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
        Me.btn_close.Location = New System.Drawing.Point(292, 10)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(123, 43)
        Me.btn_close.TabIndex = 4
        Me.btn_close.TabStop = False
        Me.btn_close.Text = "Close"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.UseVisualStyleBackColor = False
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
        Me.grd_display.Location = New System.Drawing.Point(7, 137)
        Me.grd_display.Name = "grd_display"
        Me.grd_display.ReadOnly = True
        Me.grd_display.SelectionMode = System.Windows.Forms.SelectionMode.One
        Me.grd_display.Size = New System.Drawing.Size(623, 378)
        Me.grd_display.SQL = Nothing
        Me.grd_display.TabIndex = 35
        Me.grd_display.UIStyle = Xceed.UI.UIStyle.ResourceAssembly
        '
        'GroupByRow1
        '
        Me.GroupByRow1.Visible = False
        '
        'backup_view
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(643, 550)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "backup_view"
        Me.Text = "backup_view"
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_main.ResumeLayout(False)
        Me.DbA_Panel2.ResumeLayout(False)
        Me.DbA_Panel1.ResumeLayout(False)
        CType(Me.grd_display, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataRowTemplate1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColumnManagerRow1, System.ComponentModel.ISupportInitialize).EndInit()
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
                Call Process("PRINT")

            Case Keys.F8
                Call close_form()

            Case Keys.F10
                grd_display.Focus()
        End Select

        Select Case keyCode
            Case Keys.F1, Keys.F2, Keys.F4, Keys.F5, Keys.F8, Keys.F10
                Return True
        End Select
    End Function
#End Region

#Region " Declarations "
    Dim m_prev_form As Form
    Dim m_close_index As Integer
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

#Region " Fill Grid "
    Private Sub Fill_Grid()
        Dim p_sql As String
        Dim p_where As String = ""

        ' -----------
        ' * Fill Grid
        ' -----------
        p_sql = "Select date_event As [Date], " & _
                "CASE WHEN backup_ok = 0 THEN 'N' WHEN backup_ok = 1 THEN 'Y' END As [Backup], " & _
                "CASE WHEN report_ok = 0 THEN 'N' WHEN report_ok = 1 THEN 'Y' END As [Reports], " & _
                "CASE WHEN update_ok = 0 THEN 'N' WHEN update_ok = 1 THEN 'Y' END As [Update] " & _
                "From System_Night "

        ' -------------------------
        ' * Use Date Range Selected
        ' -------------------------
        If dte_from.DateBox_Properties.Text <> "" Then
            p_where = Check_where(p_where)
            p_where &= "date_event >= '" & dte_from.DateBox_Properties.Text & " 00:00:00' "
        End If

        If dte_to.DateBox_Properties.Text <> "" Then
            p_where = Check_where(p_where)
            p_where &= "date_event <= '" & dte_to.DateBox_Properties.Text & " 23:59:59' "
        End If

        p_sql &= p_where & "Order by date_event desc"

        grd_display.SQL = p_sql
        Call dba_fill_grid(grd_display)

        ' Set Criteria Count
        Me.txt_total_prod.TextBox_Properties.Text = grd_display.DataRows.Count

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
        Dim p_excludes(2) As dba_RemoveControls
        p_excludes(0).Control = lbl_filter
        p_excludes(1).Control = lbl_screen
        p_excludes(2).Control = lbl_F5

        Me.dba_init_form(pnl_main, True, p_excludes, g_is_internal)
        Me.g_focus_fld = dte_from

        Call size_screen(Me)

        ' -----------
        ' * Set Dates
        ' -----------
        dte_from.DateBox_Properties.Text = DateAdd(DateInterval.Month, -1, DateTime.Now).ToShortDateString
        dte_to.DateBox_Properties.Text = DateTime.Now.ToShortDateString

        ' -------------------
        ' * Set Overall Count
        ' -------------------
        Call get_overall()
    End Sub
#End Region

#Region " Get Overall Count "
    Private Sub get_overall()
        Dim p_sql As String
        Dim p_dataset As DataSet

        ' --------------------------
        ' * Get Overall Backup Count
        ' --------------------------
        p_sql = "Select COUNT(*) From System_Night"
        p_dataset = g_framework.Get_Data(p_sql)

        txt_total_head.TextBox_Properties.Text = p_dataset.Tables(0).Rows(0).Item(0)

        ' Dispose of Dataset
        p_dataset.Dispose()
    End Sub
#End Region

#Region " Print Log "
    Private Sub print_log()
        If message_box("Continue printing log?", 2, "Confirm Print") = MsgBoxResult.No Then Exit Sub

        Try
            ' ------------------
            ' * Print Backup Log
            ' ------------------
            Dim p_print As New CUSPrint.DatasetPrinting(g_PrintPort)
            With p_print
                .DataSetToPrint = grd_display.DataSource
                .ReportTitle = "Backup Log"
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
        Select Case UCase(p_type)
            Case "DATA"
                If Check_Dates() Then Call Fill_Grid()

            Case "RESET"
                ' -----------
                ' * Set Dates
                ' -----------
                dte_from.DateBox_Properties.Text = DateAdd(DateInterval.Month, -1, DateTime.Now).ToShortDateString
                dte_to.DateBox_Properties.Text = DateTime.Now.ToShortDateString

                Me.txt_total_prod.TextBox_Properties.Text = ""

                grd_display.DataSource = Nothing

                dte_from.Focus()

            Case "PRINT"
                If grd_display.DataRows.Count = 0 Then Exit Sub
                Call print_log()
        End Select
    End Sub
#End Region

#Region " Screen Object Events "

#Region " Grid Events "
    Private Sub grd_display_AfterRowSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_display.AfterRowSelected
        grd_display.CancelActivate = True
    End Sub

    Private Sub grd_display_InitializeLayout(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_display.InitializeLayout
        With grd_display
            .Columns(0).Width = 180
            .Columns(1).Width = 135
            .Columns(2).Width = 135
            .Columns(3).Width = 135
        End With
    End Sub

    Private Sub grd_display_TabPressed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_display.TabPressed
        Me.g_focus_fld.Focus()
    End Sub
#End Region

#End Region

End Class

