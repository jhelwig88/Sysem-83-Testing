Public Class user_maint
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
    Friend WithEvents chk_administrator As DBA.Library.DBA_CheckBox
    Friend WithEvents lbl_display_name As DBA.Library.DBA_TextBox
    Friend WithEvents txt_password As DBA.Library.DBA_TextBox
    Friend WithEvents txt_user_name As DBA.Library.DBA_TextBox
    Friend WithEvents btn_delete As DBA.Library.DBA_Button
    Friend WithEvents btn_cancel As DBA.Library.DBA_Button
    Friend WithEvents btn_save As DBA.Library.DBA_Button
    Friend WithEvents btn_new As DBA.Library.DBA_Button
    Friend WithEvents btn_close As DBA.Library.DBA_Button
    Friend WithEvents chk_inactive As DBA.Library.DBA_CheckBox
    Friend WithEvents grpbx_info As DBA.Library.DBA_StyleGroupBox
    Friend WithEvents lbl_F10 As DBA.Library.DBA_Label
    Friend WithEvents chk_master As DBA.Library.DBA_CheckBox
    Friend WithEvents tlb_main As DBA.Library.DBA_StyleToolbar
    Friend WithEvents GroupByRow1 As Xceed.Grid.GroupByRow
    Friend WithEvents ColumnManagerRow1 As Xceed.Grid.ColumnManagerRow
    Friend WithEvents dataRowTemplate1 As Xceed.Grid.DataRow
    Friend WithEvents grd_display As DBA.Library.DBA_StyleGrid
    Friend WithEvents dd_employee As DBA.Library.DBA_StyleComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(user_maint))
        Me.pnl_main = New DBA.Library.DBA_Panel
        Me.grd_display = New DBA.Library.DBA_StyleGrid
        Me.dataRowTemplate1 = New Xceed.Grid.DataRow
        Me.GroupByRow1 = New Xceed.Grid.GroupByRow
        Me.ColumnManagerRow1 = New Xceed.Grid.ColumnManagerRow
        Me.tlb_main = New DBA.Library.DBA_StyleToolbar
        Me.btn_delete = New DBA.Library.DBA_Button(Me.components)
        Me.btn_cancel = New DBA.Library.DBA_Button(Me.components)
        Me.btn_save = New DBA.Library.DBA_Button(Me.components)
        Me.btn_new = New DBA.Library.DBA_Button(Me.components)
        Me.btn_close = New DBA.Library.DBA_Button(Me.components)
        Me.grpbx_info = New DBA.Library.DBA_StyleGroupBox
        Me.chk_master = New DBA.Library.DBA_CheckBox
        Me.chk_administrator = New DBA.Library.DBA_CheckBox
        Me.lbl_display_name = New DBA.Library.DBA_TextBox
        Me.chk_inactive = New DBA.Library.DBA_CheckBox
        Me.txt_password = New DBA.Library.DBA_TextBox
        Me.txt_user_name = New DBA.Library.DBA_TextBox
        Me.lbl_F10 = New DBA.Library.DBA_Label(Me.components)
        Me.dd_employee = New DBA.Library.DBA_StyleComboBox
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_main.SuspendLayout()
        CType(Me.grd_display, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataRowTemplate1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColumnManagerRow1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbx_info.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_main
        '
        Me.pnl_main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_main.Controls.Add(Me.grd_display)
        Me.pnl_main.Controls.Add(Me.tlb_main)
        Me.pnl_main.Controls.Add(Me.btn_delete)
        Me.pnl_main.Controls.Add(Me.btn_cancel)
        Me.pnl_main.Controls.Add(Me.btn_save)
        Me.pnl_main.Controls.Add(Me.btn_new)
        Me.pnl_main.Controls.Add(Me.btn_close)
        Me.pnl_main.Controls.Add(Me.grpbx_info)
        Me.pnl_main.DataSettings.IDField = "user_id"
        Me.pnl_main.DataSettings.JoinData = Nothing
        Me.pnl_main.DataSettings.LinkField = Nothing
        Me.pnl_main.DataSettings.TableName = "Users"
        Me.pnl_main.Gradient = False
        Me.pnl_main.Location = New System.Drawing.Point(0, 0)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.RecordID = Nothing
        Me.pnl_main.Saved = False
        Me.pnl_main.Size = New System.Drawing.Size(644, 440)
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
        Me.grd_display.LinkSettings.IsMainGrid = True
        Me.grd_display.LinkSettings.RecordContainer = Me.pnl_main
        Me.grd_display.Location = New System.Drawing.Point(8, 65)
        Me.grd_display.Name = "grd_display"
        Me.grd_display.ReadOnly = True
        Me.grd_display.SelectionMode = System.Windows.Forms.SelectionMode.One
        Me.grd_display.Size = New System.Drawing.Size(293, 339)
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
        Me.tlb_main.Size = New System.Drawing.Size(644, 1)
        Me.tlb_main.TabIndex = 26
        Me.tlb_main.TabStop = False
        Me.tlb_main.ToolBarCustom = Nothing
        Me.tlb_main.ToolbarDisplayType = DBA.Library.DBA_StyleToolbar.DisplayType.IconsOnSide
        Me.tlb_main.ToolBarType = DBA.Library.DBA_StyleToolbar.DBA_ToolBarType.Normal
        Me.tlb_main.Visible = False
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_delete.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_delete.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_delete.DisplayText = ""
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_delete.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Image = CType(resources.GetObject("btn_delete.Image"), System.Drawing.Image)
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.Location = New System.Drawing.Point(385, 8)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(104, 43)
        Me.btn_delete.TabIndex = 24
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
        Me.btn_cancel.TabIndex = 23
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
        Me.btn_save.TabIndex = 22
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
        Me.btn_new.TabIndex = 21
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
        Me.btn_close.TabIndex = 25
        Me.btn_close.TabStop = False
        Me.btn_close.Text = "Close"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'grpbx_info
        '
        Me.grpbx_info.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grpbx_info.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpbx_info.Controls.Add(Me.chk_master)
        Me.grpbx_info.Controls.Add(Me.chk_administrator)
        Me.grpbx_info.Controls.Add(Me.lbl_display_name)
        Me.grpbx_info.Controls.Add(Me.chk_inactive)
        Me.grpbx_info.Controls.Add(Me.txt_password)
        Me.grpbx_info.Controls.Add(Me.txt_user_name)
        Me.grpbx_info.Controls.Add(Me.lbl_F10)
        Me.grpbx_info.Controls.Add(Me.dd_employee)
        Me.grpbx_info.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbx_info.ForeColor = System.Drawing.Color.Black
        Me.grpbx_info.LineColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grpbx_info.Location = New System.Drawing.Point(308, 62)
        Me.grpbx_info.Name = "grpbx_info"
        Me.grpbx_info.Size = New System.Drawing.Size(309, 226)
        Me.grpbx_info.TabIndex = 0
        Me.grpbx_info.Text = "User Information"
        '
        'chk_master
        '
        Me.chk_master.BackColor = System.Drawing.Color.PapayaWhip
        Me.chk_master.Caption = "Master"
        Me.chk_master.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chk_master.Enabled = False
        Me.chk_master.Field_Name = "master"
        Me.chk_master.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_master.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chk_master.ForeColor = System.Drawing.Color.Black
        Me.chk_master.GridBinding = Me.grd_display
        Me.chk_master.Location = New System.Drawing.Point(224, 174)
        Me.chk_master.Mandatory = False
        Me.chk_master.Name = "chk_master"
        Me.chk_master.SaveLoadOrder = 0
        Me.chk_master.Size = New System.Drawing.Size(72, 24)
        Me.chk_master.TabIndex = 31
        Me.chk_master.Text = "Master"
        Me.chk_master.UseVisualStyleBackColor = False
        Me.chk_master.Visible = False
        '
        'chk_administrator
        '
        Me.chk_administrator.BackColor = System.Drawing.Color.PapayaWhip
        Me.chk_administrator.Caption = "Administrator"
        Me.chk_administrator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chk_administrator.Enabled = False
        Me.chk_administrator.Field_Name = "administrator"
        Me.chk_administrator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_administrator.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chk_administrator.ForeColor = System.Drawing.Color.Black
        Me.chk_administrator.GridBinding = Me.grd_display
        Me.chk_administrator.Location = New System.Drawing.Point(93, 158)
        Me.chk_administrator.Mandatory = False
        Me.chk_administrator.Name = "chk_administrator"
        Me.chk_administrator.SaveLoadOrder = 0
        Me.chk_administrator.Size = New System.Drawing.Size(130, 24)
        Me.chk_administrator.TabIndex = 4
        Me.chk_administrator.Text = "Administrator"
        Me.chk_administrator.UseVisualStyleBackColor = False
        '
        'lbl_display_name
        '
        Me.lbl_display_name.AllowNegative = False
        Me.lbl_display_name.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_display_name.ColorCursor = False
        Me.lbl_display_name.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lbl_display_name.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_display_name.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.lbl_display_name.Enabled = False
        Me.lbl_display_name.Field_Name = ""
        Me.lbl_display_name.GridBinding = Nothing
        Me.lbl_display_name.Label_On_Top = False
        Me.lbl_display_name.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_display_name.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_display_name.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.lbl_display_name.Label_Properties.Text = "Employee"
        Me.lbl_display_name.Label_Properties.Width = 70
        Me.lbl_display_name.Location = New System.Drawing.Point(20, 47)
        Me.lbl_display_name.Mandatory = False
        Me.lbl_display_name.Name = "lbl_display_name"
        Me.lbl_display_name.Override_Modified = False
        Me.lbl_display_name.SaveLoadOrder = 0
        Me.lbl_display_name.Size = New System.Drawing.Size(248, 26)
        Me.lbl_display_name.TabIndex = 0
        Me.lbl_display_name.TabStop = False
        Me.lbl_display_name.Text = "DbA_TextBox3"
        Me.lbl_display_name.TextBox_Properties.AcceptsReturn = False
        Me.lbl_display_name.TextBox_Properties.AcceptsTab = False
        Me.lbl_display_name.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.lbl_display_name.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_display_name.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_display_name.TextBox_Properties.Enabled = True
        Me.lbl_display_name.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_display_name.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.lbl_display_name.TextBox_Properties.MaximumValue = 999999
        Me.lbl_display_name.TextBox_Properties.MaxLength = 50
        Me.lbl_display_name.TextBox_Properties.MinimumValue = -999999
        Me.lbl_display_name.TextBox_Properties.MultiLine = False
        Me.lbl_display_name.TextBox_Properties.PasswordChar = Nothing
        Me.lbl_display_name.TextBox_Properties.ReadOnly = True
        Me.lbl_display_name.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.lbl_display_name.TextBox_Properties.TabStop = True
        Me.lbl_display_name.TextBox_Properties.Text = ""
        Me.lbl_display_name.TextBox_Properties.WordWrap = True
        Me.lbl_display_name.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'chk_inactive
        '
        Me.chk_inactive.BackColor = System.Drawing.Color.PapayaWhip
        Me.chk_inactive.Caption = "Inactive"
        Me.chk_inactive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chk_inactive.Enabled = False
        Me.chk_inactive.Field_Name = "inactive"
        Me.chk_inactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_inactive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chk_inactive.ForeColor = System.Drawing.Color.Black
        Me.chk_inactive.GridBinding = Me.grd_display
        Me.chk_inactive.Location = New System.Drawing.Point(93, 187)
        Me.chk_inactive.Mandatory = False
        Me.chk_inactive.Name = "chk_inactive"
        Me.chk_inactive.SaveLoadOrder = 0
        Me.chk_inactive.Size = New System.Drawing.Size(72, 24)
        Me.chk_inactive.TabIndex = 5
        Me.chk_inactive.Text = "Inactive"
        Me.chk_inactive.UseVisualStyleBackColor = False
        '
        'txt_password
        '
        Me.txt_password.AllowNegative = False
        Me.txt_password.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_password.ColorCursor = True
        Me.txt_password.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_password.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_password.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_password.Enabled = False
        Me.txt_password.Field_Name = "password"
        Me.txt_password.GridBinding = Me.grd_display
        Me.txt_password.Label_On_Top = False
        Me.txt_password.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_password.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_password.Label_Properties.Text = "Password"
        Me.txt_password.Label_Properties.Width = 70
        Me.txt_password.Location = New System.Drawing.Point(20, 111)
        Me.txt_password.Mandatory = True
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Override_Modified = False
        Me.txt_password.SaveLoadOrder = 0
        Me.txt_password.Size = New System.Drawing.Size(248, 26)
        Me.txt_password.TabIndex = 3
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
        Me.txt_password.TextBox_Properties.MaxLength = 20
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
        'txt_user_name
        '
        Me.txt_user_name.AllowNegative = False
        Me.txt_user_name.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_user_name.ColorCursor = True
        Me.txt_user_name.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_user_name.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_user_name.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_user_name.Enabled = False
        Me.txt_user_name.Field_Name = "user_name"
        Me.txt_user_name.GridBinding = Me.grd_display
        Me.txt_user_name.Label_On_Top = False
        Me.txt_user_name.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_user_name.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user_name.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_user_name.Label_Properties.Text = "User Name"
        Me.txt_user_name.Label_Properties.Width = 70
        Me.txt_user_name.Location = New System.Drawing.Point(20, 79)
        Me.txt_user_name.Mandatory = True
        Me.txt_user_name.Name = "txt_user_name"
        Me.txt_user_name.Override_Modified = False
        Me.txt_user_name.SaveLoadOrder = 0
        Me.txt_user_name.Size = New System.Drawing.Size(248, 26)
        Me.txt_user_name.TabIndex = 2
        Me.txt_user_name.TabStop = False
        Me.txt_user_name.Text = "DbA_TextBox1"
        Me.txt_user_name.TextBox_Properties.AcceptsReturn = False
        Me.txt_user_name.TextBox_Properties.AcceptsTab = False
        Me.txt_user_name.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_user_name.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_user_name.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_user_name.TextBox_Properties.Enabled = True
        Me.txt_user_name.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user_name.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_user_name.TextBox_Properties.MaximumValue = 999999
        Me.txt_user_name.TextBox_Properties.MaxLength = 20
        Me.txt_user_name.TextBox_Properties.MinimumValue = -999999
        Me.txt_user_name.TextBox_Properties.MultiLine = False
        Me.txt_user_name.TextBox_Properties.PasswordChar = Nothing
        Me.txt_user_name.TextBox_Properties.ReadOnly = False
        Me.txt_user_name.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_user_name.TextBox_Properties.TabStop = True
        Me.txt_user_name.TextBox_Properties.Text = ""
        Me.txt_user_name.TextBox_Properties.WordWrap = True
        Me.txt_user_name.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'lbl_F10
        '
        Me.lbl_F10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_F10.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_F10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_F10.ForeColor = System.Drawing.Color.Black
        Me.lbl_F10.Location = New System.Drawing.Point(167, 20)
        Me.lbl_F10.Name = "lbl_F10"
        Me.lbl_F10.Size = New System.Drawing.Size(136, 22)
        Me.lbl_F10.TabIndex = 30
        Me.lbl_F10.Text = "F10 - Access Main Grid"
        Me.lbl_F10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_F10.UseMnemonic = False
        '
        'dd_employee
        '
        Me.dd_employee.ColorCursor = True
        Me.dd_employee.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dd_employee.Column_To_Display = 1
        Me.dd_employee.ComboBox_Properties.AllowFreeText = False
        Me.dd_employee.ComboBox_Properties.ColumnWidthAdjustment = Xceed.Editors.ColumnWidthAdjustment.None
        Me.dd_employee.ComboBox_Properties.CompareType = CType((Xceed.Editors.CompareType.CaseInsensitive Or Xceed.Editors.CompareType.AccentInsensitive), Xceed.Editors.CompareType)
        Me.dd_employee.ComboBox_Properties.Cursor = System.Windows.Forms.Cursors.Default
        Me.dd_employee.ComboBox_Properties.DropDownResizable = False
        Me.dd_employee.ComboBox_Properties.Enabled = True
        Me.dd_employee.ComboBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd_employee.ComboBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_employee.ComboBox_Properties.IntegralHeight = True
        Me.dd_employee.ComboBox_Properties.MaxDropDownItems = 8
        Me.dd_employee.ComboBox_Properties.Text = ""
        Me.dd_employee.ComboBox_Properties.TextBoxArea_BackColor = System.Drawing.Color.White
        Me.dd_employee.ComboBox_Properties.TextBoxArea_TabStop = True
        Me.dd_employee.DataSet = Nothing
        Me.dd_employee.DataType = DBA.Library.DBA_StyleComboBox.DBA_data_type.DBA_UID
        Me.dd_employee.DisplayFieldName = Nothing
        Me.dd_employee.DisplayFieldSQL = Nothing
        Me.dd_employee.DisplayFieldTable = Nothing
        Me.dd_employee.DisplayFieldTableJoin = Nothing
        Me.dd_employee.Enabled = False
        Me.dd_employee.Field_Name = "employee_id"
        Me.dd_employee.GridBinding = Me.grd_display
        Me.dd_employee.ID_Column_Number = 0
        Me.dd_employee.ID_Value = Nothing
        Me.dd_employee.Label_On_Top = False
        Me.dd_employee.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.dd_employee.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dd_employee.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.dd_employee.Label_Properties.Text = "Employee"
        Me.dd_employee.Label_Properties.Width = 70
        Me.dd_employee.Location = New System.Drawing.Point(20, 47)
        Me.dd_employee.Mandatory = False
        Me.dd_employee.Name = "dd_employee"
        Me.dd_employee.SaveLoadOrder = 0
        Me.dd_employee.SaveType = DBA.Library.DBA_StyleComboBox.DbA_SaveType.UID
        Me.dd_employee.Size = New System.Drawing.Size(266, 26)
        Me.dd_employee.SQL_Statement = Nothing
        Me.dd_employee.TabIndex = 1
        Me.dd_employee.Visible = False
        '
        'user_maint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(644, 440)
        Me.Controls.Add(Me.pnl_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "user_maint"
        Me.ShowInTaskbar = False
        Me.Text = "User Entry Screen"
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_main.ResumeLayout(False)
        CType(Me.grd_display, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataRowTemplate1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColumnManagerRow1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbx_info.ResumeLayout(False)
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

            Case Keys.F8
                Call Process("CLOSE")

            Case Keys.F10
                grd_display.Focus()
        End Select

        Select Case keyCode
            Case Keys.F1, Keys.F2, Keys.F3, _
                 Keys.F4, Keys.F8, Keys.F10
                Return True
        End Select
    End Function
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
#End Region

#Region " Close Form "
    Private Sub close_form()
        g_framework.g_forms(1).Show()
        g_framework.g_forms(2) = Nothing
        Me.Close()
    End Sub
#End Region

#Region " Fill Dropdown "
    Private Sub Fill_Employee()
        Dim p_sql As String
        Dim p_dataset As DataSet

        ' ---------------------------
        ' * Set Employee Dropdown SQL
        ' ---------------------------
        p_sql = "SELECT employee_id, " & _
                "last_name + ', ' + first_name + (Case When middle_initial is Null or middle_initial = '' " & _
                "Then '' Else ' ' + middle_initial End) As Employee " & _
                "From Employee " & _
                "Where employee_id Not In (Select Distinct employee_id From Users Where employee_id Is Not Null" & _
                ") ORDER BY last_name, first_name, middle_initial"
        p_dataset = g_framework.Get_Data(p_sql)

        If p_dataset.Tables(0).Rows.Count > 0 Then
            dd_employee.DataSet = p_dataset
        Else
            dd_employee.Enabled = False
        End If
    End Sub
#End Region

#Region " Fill Grid "
    Private Sub Fill_Grid()
        Dim p_sql As String

        ' -----------------
        ' * Fill Users Grid
        ' -----------------
        p_sql = "Select user_id, last_name + ', ' + first_name + Case When middle_initial is Null or middle_initial = '' " & _
                "Then '' Else ', ' + middle_initial + ' ' End As Name, " & _
                "user_name As [User Name], Inactive, Administrator " & _
                "FROM Users U1 " & _
                "LEFT JOIN Employee E1 On E1.employee_id = U1.employee_id " & _
                "Where master = 0 " & _
                "Order By last_name, first_name, middle_initial, user_name"
        grd_display.SQL = p_sql

        ' Fill Grid
        Me.dba_fill_grid(grd_display)

        If grd_display.DataRows.Count = 0 Then pnl_main.Focus()
    End Sub
#End Region

#Region " Form AfterFillScreen "
    Private Sub Form_AfterFillScreen(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.AfterFillScreen
        Dim p_sql As String
        Dim p_dataset As DataSet

        'find the current record
        grd_display.FindInGrid(0, pnl_main.RecordID, False)

        p_sql = "SELECT first_name + (Case When middle_initial is Null or middle_initial = '' " & _
                "Then ' ' Else ' ' + middle_initial + ' ' End) + last_name As Display_Name " & _
                "FROM Users a " & _
                "INNER JOIN Employee b ON b.employee_id = a.employee_id " & _
                "Where user_id = '" & dba_format_unique_identifier_value(pnl_main.RecordID) & "'"
        p_dataset = g_framework.Get_Data(p_sql)

        If p_dataset.Tables(0).Rows.Count > 0 Then
            lbl_display_name.TextBox_Properties.Text = p_dataset.Tables(0).Rows(0).Item(0).ToString
        End If

        ' Dispose of Dataset 
        p_dataset.Dispose()

        ' --------------
        ' * Reset Screen
        ' --------------
        Call Set_For_Edit()
        Me.dba_screen_state(pnl_main, DBA_Framework.DBA_Foundation_Class.SCREEN_BUTTON_MODE.FirstLoad, DBA_Framework.DBA_Foundation_Class.ScreenLockMode.UNLOCK, False)

        Call set_toolbar_buttons("T", "F", "F", "T")
    End Sub
#End Region

#Region " Form Load "
    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim p_excludes(5) As dba_RemoveControls
        p_excludes(0).Control = btn_close
        p_excludes(1).Control = lbl_F10

        p_excludes(2).Control = btn_new
        p_excludes(3).Control = btn_save
        p_excludes(4).Control = btn_cancel
        p_excludes(5).Control = btn_delete

        Me.dba_init_form(pnl_main, True, p_excludes, g_is_internal)
        Me.g_focus_fld = txt_user_name.txtbox

        Call size_screen(Me)

        ' -----------
        ' * Fill Grid
        ' -----------
        Call Fill_Grid()

        grd_display.Insert_Header_Row("User List - Use Arrows to Select")

        If grd_display.DataRows.Count > 0 Then
            grd_display.SelectedRows.Add(grd_display.DataRows(0))
            grd_display.CurrentRow = grd_display.DataRows(0)
        End If
    End Sub
#End Region

#Region " Pre-Delete Check "
    Private Function delete_record() As Boolean
        ' ========================
        ' * Delete Record Selected
        ' ========================

        ' Check That Item Was Selected
        If Trim(pnl_main.RecordID) = "" Then
            Exit Function
        End If

        If chk_master.Checked Then
            Call message_box("Master User can't be deleted!", 1)
            Return False
            Exit Function
        End If

        ' ================================================================
        ' * Check That Program Has At Least One Active Administrative User
        ' ================================================================
        Dim p_sql As String                 ' String To Hold SQL Statement
        Dim p_dataset As DataSet           ' Create DataSet Reference

        p_sql = "Select user_id FROM " & pnl_main.DataSettings.TableName & _
                " Where administrator = 1 And master = 0 " & _
                "And inactive = 0"

        If Trim(pnl_main.RecordID) <> "" Then
            p_sql = p_sql & " And " & pnl_main.DataSettings.IDField & " <> '" & Trim(pnl_main.RecordID) & "'"
        End If

        p_dataset = g_framework.Get_Data(p_sql)

        ' ==================================
        ' * Check If Value Entered Was Found
        ' ==================================
        If p_dataset.Tables(0).Rows.Count = 0 Then
            Call message_box("Another Active Administrator must be setup before deleting this User.", 1, "Delete Cancelled")

            ' Dispose of Dataset
            p_dataset.Dispose()

            Return False
            Exit Function
        End If

        ' Dispose of Dataset
        p_dataset.Dispose()

        ' ---------------------------------------
        ' * Check For Item ID In Related Table(s)
        ' ---------------------------------------
        p_sql = "INSERT INTO Users_Deleted " & _
                "Select * From Users " & _
                "Where user_id = '" & Trim(pnl_main.RecordID) & "'"
        Call g_framework.Execute_Query(p_sql)

        Return True
    End Function
#End Region

#Region " Pre-Save Check "
    Private Function pre_save() As Boolean
        ' Check Mandatory
        check_mandatory_fields(pnl_main)
        If verify_mandatory() = False Then
            Return False
            Exit Function
        End If

        Dim p_sql As String                 ' String To Hold SQL Statement
        Dim p_data_set As DataSet           ' Create DataSet Reference

        ' ================================
        ' * Check for existing in add mode
        ' ================================
        p_sql = "Select Distinct " & pnl_main.DataSettings.IDField & _
                " FROM " & pnl_main.DataSettings.TableName & _
                " Where user_name = " & return_parsed_single_quote_string(txt_user_name.TextBox_Properties.Text)

        If Trim(pnl_main.RecordID) <> "" Then
            p_sql = p_sql & " And " & pnl_main.DataSettings.IDField & " <> '" & Trim(pnl_main.RecordID) & "'"
        End If

        p_data_set = g_framework.Get_Data(p_sql)

        ' ==================================
        ' * Check If Value Entered Was Found
        ' ==================================
        If p_data_set.Tables(0).Rows.Count > 0 Then
            Call message_box("The User Name entered already exists! Please reenter.", 1, "Message To User")

            ' Dispose of Dataset
            p_data_set.Dispose()
            Return False
            Exit Function
        End If

        ' Reset Dataset 
        p_data_set.Reset()

        ' ================================================================
        ' * Check That Program Has At Least One Active Administrative User
        ' ================================================================
        If Me.chk_administrator.Checked = False Or Me.chk_inactive.Checked = True Then
            p_sql = "Select user_id FROM " & pnl_main.DataSettings.TableName & _
                    " Where administrator = 1 And master = 0 " & _
                    "And inactive = 0"

            If Trim(pnl_main.RecordID) <> "" Then
                p_sql = p_sql & " And " & pnl_main.DataSettings.IDField & " <> '" & Trim(pnl_main.RecordID) & "'"
            End If

            p_data_set = g_framework.Get_Data(p_sql)

            ' ==================================
            ' * Check If Value Entered Was Found
            ' ==================================
            If p_data_set.Tables(0).Rows.Count = 0 Then
                Call message_box("No Active Administrator found; please setup Administrator before adding/editing Users.", 1)

                ' Dispose of Dataset
                p_data_set.Dispose()
                Return False
                Exit Function
            End If
        End If

        ' Dispose of Dataset
        p_data_set.Dispose()

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
                Me.grd_display.Enabled = False

                Call Fill_Employee()
                Call Set_For_New()

            Case "SAVE"
                If pre_save() = False Then Exit Sub

                Me.grd_display.Enabled = True
                If dba_save_record(pnl_main) Then
                    Call set_toolbar_buttons("T", "F", "F", "T")
                    Me.g_focus_fld.Focus()
                End If

            Case "CANCEL"
                dba_cancel_record(pnl_main)

                Me.grd_display.Enabled = True
                Call Set_For_Edit()

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
                    ' ============
                    ' * Set Screen
                    ' ============
                    Call Fill_Grid()
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

#Region " Screen Settings "
    Private Sub Set_For_Edit()
        With dd_employee
            .Field_Name = ""
            .Mandatory = False

            ' Needed to Close before Invisible
            .ComboBox.CloseDropDown()
            .Visible = False
        End With

        lbl_display_name.Visible = True
    End Sub

    Private Sub Set_For_New()
        lbl_display_name.Visible = False

        With dd_employee
            .Field_Name = "employee_id"
            .Mandatory = True
            .Visible = True
        End With

        dd_employee.TabStop = True
        dd_employee.Focus()
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

#Region " Checkbox Events "
    Private Sub Checkbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        chk_administrator.CheckedChanged, chk_inactive.CheckedChanged

        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("", "T", "T", "")
    End Sub
#End Region

#Region " Dropdown Events "
    Private Sub dd_employee_AfterItemSelected(ByVal sender As Object, ByVal e As System.EventArgs) Handles dd_employee.AfterItemSelected
        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("", "T", "T", "")
    End Sub
#End Region

#Region " Grid Events "
    Private Sub grd_display_InitializeLayout(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_display.InitializeLayout
        With grd_display
            .Columns(1).Width = 139
            .Columns(2).Width = 135
            .Columns(3).Visible = False
            .Columns(4).Visible = False
        End With
    End Sub

    Private Sub grd_display_TabPressed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_display.TabPressed
        Me.g_focus_fld.Focus()
    End Sub
#End Region

#Region " Textbox Events "
    Private Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        txt_user_name.TextBox_TextChanged, txt_password.TextBox_TextChanged

        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("", "T", "T", "")
    End Sub
#End Region

#End Region

End Class
