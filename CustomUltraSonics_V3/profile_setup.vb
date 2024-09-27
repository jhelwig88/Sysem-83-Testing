Public Class profile_setup
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
    Friend WithEvents btn_delete As DBA.Library.DBA_Button
    Friend WithEvents btn_cancel As DBA.Library.DBA_Button
    Friend WithEvents btn_save As DBA.Library.DBA_Button
    Friend WithEvents btn_new As DBA.Library.DBA_Button
    Friend WithEvents btn_close As DBA.Library.DBA_Button
    Friend WithEvents lbl_info As DBA.Library.DBA_Label
    Friend WithEvents grpbx_general As DBA.Library.DBA_StyleGroupBox
    Friend WithEvents txt_safety_delay As DBA.Library.DBA_TextBox
    Friend WithEvents txt_pressure_error As DBA.Library.DBA_TextBox
    Friend WithEvents txt_pressure_start As DBA.Library.DBA_TextBox
    Friend WithEvents txt_float_delay As DBA.Library.DBA_TextBox
    Friend WithEvents txt_warwick_delay As DBA.Library.DBA_TextBox
    Friend WithEvents txt_drain2 As DBA.Library.DBA_TextBox
    Friend WithEvents txt_drain1 As DBA.Library.DBA_TextBox
    Friend WithEvents txt_lubrication As DBA.Library.DBA_TextBox
    Friend WithEvents txt_chemical_immersion As DBA.Library.DBA_TextBox
    Friend WithEvents txt_wash_rinse_secs As DBA.Library.DBA_TextBox
    Friend WithEvents txt_wash_secs As DBA.Library.DBA_TextBox
    Friend WithEvents txt_profile_name As DBA.Library.DBA_TextBox
    Friend WithEvents grpbx_83 As DBA.Library.DBA_StyleGroupBox
    Friend WithEvents txt_83_dry_heat_secs As DBA.Library.DBA_TextBox
    Friend WithEvents txt_83_dry_cool_secs As DBA.Library.DBA_TextBox
    Friend WithEvents txt_83_detergent_secs As DBA.Library.DBA_TextBox
    Friend WithEvents grpbx_82 As DBA.Library.DBA_StyleGroupBox
    Friend WithEvents txt_82_ultra_disinfect_secs As DBA.Library.DBA_TextBox
    Friend WithEvents grpbx_81 As DBA.Library.DBA_StyleGroupBox
    Friend WithEvents txt_81_prewash_secs As DBA.Library.DBA_TextBox
    Friend WithEvents txt_81_reservoir_fill_secs As DBA.Library.DBA_TextBox
    Friend WithEvents txt_81_soak_secs As DBA.Library.DBA_TextBox
    Friend WithEvents txt_81_detergent_secs As DBA.Library.DBA_TextBox
    Friend WithEvents txt_81_enzyme_secs As DBA.Library.DBA_TextBox
    Friend WithEvents txt_81_rinse_secs As DBA.Library.DBA_TextBox
    Friend WithEvents txt_81_rinse_delay_secs As DBA.Library.DBA_TextBox
    Friend WithEvents grpbx_temp As DBA.Library.DBA_StyleGroupBox
    Friend WithEvents txt_min_start_temp As DBA.Library.DBA_TextBox
    Friend WithEvents txt_max_abort_temp As DBA.Library.DBA_TextBox
    Friend WithEvents txt_heat_pad_on As DBA.Library.DBA_TextBox
    Friend WithEvents txt_heat_pad_off As DBA.Library.DBA_TextBox
    Friend WithEvents btn_cycles As DBA.Library.DBA_Button
    Friend WithEvents lbl_F10 As DBA.Library.DBA_Label
    Friend WithEvents btn_sub_profiles As DBA.Library.DBA_Button
    Friend WithEvents txt_button_text As DBA.Library.DBA_TextBox
    Friend WithEvents pnl_info As DBA.Library.DBA_Panel
    Friend WithEvents tlb_main As DBA.Library.DBA_StyleToolbar
    Private WithEvents grd_profiles As DBA.Library.DBA_StyleGrid
    Private WithEvents GroupByRow1 As Xceed.Grid.GroupByRow
    Private WithEvents ColumnManagerRow1 As Xceed.Grid.ColumnManagerRow
    Private WithEvents dataRowTemplate1 As Xceed.Grid.DataRow
    Private WithEvents GroupByRow2 As Xceed.Grid.GroupByRow
    Private WithEvents ColumnManagerRow2 As Xceed.Grid.ColumnManagerRow
    Private WithEvents dataRowTemplate2 As Xceed.Grid.DataRow
    Private WithEvents grd_subs As DBA.Library.DBA_StyleGrid
    Private WithEvents DataRow1 As Xceed.Grid.DataRow
    Private WithEvents GroupByRow3 As Xceed.Grid.GroupByRow
    Private WithEvents ColumnManagerRow3 As Xceed.Grid.ColumnManagerRow
    Friend WithEvents txt_ultrasonics_abort As DBA.Library.DBA_TextBox
    Private WithEvents grd_cycles As DBA.Library.DBA_StyleGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(profile_setup))
        Me.pnl_main = New DBA.Library.DBA_Panel
        Me.grd_subs = New DBA.Library.DBA_StyleGrid
        Me.DataRow1 = New Xceed.Grid.DataRow
        Me.GroupByRow3 = New Xceed.Grid.GroupByRow
        Me.ColumnManagerRow3 = New Xceed.Grid.ColumnManagerRow
        Me.grd_cycles = New DBA.Library.DBA_StyleGrid
        Me.dataRowTemplate2 = New Xceed.Grid.DataRow
        Me.GroupByRow2 = New Xceed.Grid.GroupByRow
        Me.ColumnManagerRow2 = New Xceed.Grid.ColumnManagerRow
        Me.grd_profiles = New DBA.Library.DBA_StyleGrid
        Me.dataRowTemplate1 = New Xceed.Grid.DataRow
        Me.GroupByRow1 = New Xceed.Grid.GroupByRow
        Me.ColumnManagerRow1 = New Xceed.Grid.ColumnManagerRow
        Me.tlb_main = New DBA.Library.DBA_StyleToolbar
        Me.pnl_info = New DBA.Library.DBA_Panel
        Me.btn_sub_profiles = New DBA.Library.DBA_Button(Me.components)
        Me.btn_cycles = New DBA.Library.DBA_Button(Me.components)
        Me.grpbx_83 = New DBA.Library.DBA_StyleGroupBox
        Me.txt_83_dry_cool_secs = New DBA.Library.DBA_TextBox
        Me.txt_83_dry_heat_secs = New DBA.Library.DBA_TextBox
        Me.txt_83_detergent_secs = New DBA.Library.DBA_TextBox
        Me.grpbx_81 = New DBA.Library.DBA_StyleGroupBox
        Me.txt_81_prewash_secs = New DBA.Library.DBA_TextBox
        Me.txt_81_soak_secs = New DBA.Library.DBA_TextBox
        Me.txt_81_enzyme_secs = New DBA.Library.DBA_TextBox
        Me.txt_81_reservoir_fill_secs = New DBA.Library.DBA_TextBox
        Me.txt_81_detergent_secs = New DBA.Library.DBA_TextBox
        Me.txt_81_rinse_secs = New DBA.Library.DBA_TextBox
        Me.txt_81_rinse_delay_secs = New DBA.Library.DBA_TextBox
        Me.txt_profile_name = New DBA.Library.DBA_TextBox
        Me.grpbx_temp = New DBA.Library.DBA_StyleGroupBox
        Me.txt_max_abort_temp = New DBA.Library.DBA_TextBox
        Me.txt_min_start_temp = New DBA.Library.DBA_TextBox
        Me.txt_heat_pad_on = New DBA.Library.DBA_TextBox
        Me.txt_heat_pad_off = New DBA.Library.DBA_TextBox
        Me.grpbx_general = New DBA.Library.DBA_StyleGroupBox
        Me.txt_ultrasonics_abort = New DBA.Library.DBA_TextBox
        Me.txt_safety_delay = New DBA.Library.DBA_TextBox
        Me.txt_pressure_error = New DBA.Library.DBA_TextBox
        Me.txt_pressure_start = New DBA.Library.DBA_TextBox
        Me.txt_float_delay = New DBA.Library.DBA_TextBox
        Me.txt_warwick_delay = New DBA.Library.DBA_TextBox
        Me.txt_drain2 = New DBA.Library.DBA_TextBox
        Me.txt_drain1 = New DBA.Library.DBA_TextBox
        Me.txt_lubrication = New DBA.Library.DBA_TextBox
        Me.txt_chemical_immersion = New DBA.Library.DBA_TextBox
        Me.txt_wash_rinse_secs = New DBA.Library.DBA_TextBox
        Me.txt_wash_secs = New DBA.Library.DBA_TextBox
        Me.txt_button_text = New DBA.Library.DBA_TextBox
        Me.grpbx_82 = New DBA.Library.DBA_StyleGroupBox
        Me.txt_82_ultra_disinfect_secs = New DBA.Library.DBA_TextBox
        Me.lbl_info = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_F10 = New DBA.Library.DBA_Label(Me.components)
        Me.btn_delete = New DBA.Library.DBA_Button(Me.components)
        Me.btn_cancel = New DBA.Library.DBA_Button(Me.components)
        Me.btn_save = New DBA.Library.DBA_Button(Me.components)
        Me.btn_new = New DBA.Library.DBA_Button(Me.components)
        Me.btn_close = New DBA.Library.DBA_Button(Me.components)
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_main.SuspendLayout()
        CType(Me.grd_subs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataRow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColumnManagerRow3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_cycles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataRowTemplate2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColumnManagerRow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_profiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataRowTemplate1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColumnManagerRow1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_info.SuspendLayout()
        Me.grpbx_83.SuspendLayout()
        Me.grpbx_81.SuspendLayout()
        Me.grpbx_temp.SuspendLayout()
        Me.grpbx_general.SuspendLayout()
        Me.grpbx_82.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_main
        '
        Me.pnl_main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_main.Controls.Add(Me.grd_subs)
        Me.pnl_main.Controls.Add(Me.grd_cycles)
        Me.pnl_main.Controls.Add(Me.grd_profiles)
        Me.pnl_main.Controls.Add(Me.tlb_main)
        Me.pnl_main.Controls.Add(Me.pnl_info)
        Me.pnl_main.Controls.Add(Me.lbl_F10)
        Me.pnl_main.Controls.Add(Me.btn_delete)
        Me.pnl_main.Controls.Add(Me.btn_cancel)
        Me.pnl_main.Controls.Add(Me.btn_save)
        Me.pnl_main.Controls.Add(Me.btn_new)
        Me.pnl_main.Controls.Add(Me.btn_close)
        Me.pnl_main.DataSettings.IDField = "profile_id"
        Me.pnl_main.DataSettings.JoinData = Nothing
        Me.pnl_main.DataSettings.LinkField = Nothing
        Me.pnl_main.DataSettings.TableName = "profile_maint"
        Me.pnl_main.Gradient = False
        Me.pnl_main.Location = New System.Drawing.Point(0, 0)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.RecordID = Nothing
        Me.pnl_main.Saved = False
        Me.pnl_main.Size = New System.Drawing.Size(785, 553)
        Me.pnl_main.TabIndex = 0
        '
        'grd_subs
        '
        Me.grd_subs.AllowCellNavigation = False
        Me.grd_subs.AllowGrouping = False
        Me.grd_subs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grd_subs.AutoFitColumns = True
        Me.grd_subs.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grd_subs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grd_subs.DataRowTemplate = Me.DataRow1
        Me.grd_subs.DataSettings.IDField = Nothing
        Me.grd_subs.DataSettings.TableName = Nothing
        Me.grd_subs.DataSource = Nothing
        '
        '
        '
        Me.grd_subs.FixedColumnSplitter.Visible = False
        Me.grd_subs.FixedHeaderRows.Add(Me.GroupByRow3)
        Me.grd_subs.FixedHeaderRows.Add(Me.ColumnManagerRow3)
        Me.grd_subs.LinkSettings.RecordContainer = Nothing
        Me.grd_subs.Location = New System.Drawing.Point(143, 396)
        Me.grd_subs.Name = "grd_subs"
        Me.grd_subs.ReadOnly = True
        Me.grd_subs.SelectionMode = System.Windows.Forms.SelectionMode.One
        Me.grd_subs.Size = New System.Drawing.Size(138, 136)
        Me.grd_subs.SQL = Nothing
        Me.grd_subs.TabIndex = 32
        Me.grd_subs.TabStop = False
        Me.grd_subs.UIStyle = Xceed.UI.UIStyle.ResourceAssembly
        '
        'GroupByRow3
        '
        Me.GroupByRow3.Visible = False
        '
        'grd_cycles
        '
        Me.grd_cycles.AllowCellNavigation = False
        Me.grd_cycles.AllowGrouping = False
        Me.grd_cycles.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grd_cycles.AutoFitColumns = True
        Me.grd_cycles.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grd_cycles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grd_cycles.DataRowTemplate = Me.dataRowTemplate2
        Me.grd_cycles.DataSettings.IDField = Nothing
        Me.grd_cycles.DataSettings.TableName = Nothing
        Me.grd_cycles.DataSource = Nothing
        '
        '
        '
        Me.grd_cycles.FixedColumnSplitter.Visible = False
        Me.grd_cycles.FixedHeaderRows.Add(Me.GroupByRow2)
        Me.grd_cycles.FixedHeaderRows.Add(Me.ColumnManagerRow2)
        Me.grd_cycles.LinkSettings.RecordContainer = Nothing
        Me.grd_cycles.Location = New System.Drawing.Point(2, 396)
        Me.grd_cycles.Name = "grd_cycles"
        Me.grd_cycles.ReadOnly = True
        Me.grd_cycles.SelectionMode = System.Windows.Forms.SelectionMode.One
        Me.grd_cycles.Size = New System.Drawing.Size(138, 136)
        Me.grd_cycles.SQL = Nothing
        Me.grd_cycles.TabIndex = 31
        Me.grd_cycles.TabStop = False
        Me.grd_cycles.UIStyle = Xceed.UI.UIStyle.ResourceAssembly
        '
        'GroupByRow2
        '
        Me.GroupByRow2.Visible = False
        '
        'grd_profiles
        '
        Me.grd_profiles.AllowCellNavigation = False
        Me.grd_profiles.AllowGrouping = False
        Me.grd_profiles.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grd_profiles.AutoFitColumns = True
        Me.grd_profiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grd_profiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grd_profiles.DataRowTemplate = Me.dataRowTemplate1
        Me.grd_profiles.DataSettings.IDField = Nothing
        Me.grd_profiles.DataSettings.TableName = Nothing
        Me.grd_profiles.DataSource = Nothing
        '
        '
        '
        Me.grd_profiles.FixedColumnSplitter.Visible = False
        Me.grd_profiles.FixedHeaderRows.Add(Me.GroupByRow1)
        Me.grd_profiles.FixedHeaderRows.Add(Me.ColumnManagerRow1)
        Me.grd_profiles.LinkSettings.IsMainGrid = True
        Me.grd_profiles.LinkSettings.RecordContainer = Me.pnl_main
        Me.grd_profiles.Location = New System.Drawing.Point(2, 50)
        Me.grd_profiles.Name = "grd_profiles"
        Me.grd_profiles.ReadOnly = True
        Me.grd_profiles.SelectionMode = System.Windows.Forms.SelectionMode.One
        Me.grd_profiles.Size = New System.Drawing.Size(279, 345)
        Me.grd_profiles.SQL = Nothing
        Me.grd_profiles.TabIndex = 0
        Me.grd_profiles.UIStyle = Xceed.UI.UIStyle.ResourceAssembly
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
        Me.tlb_main.Size = New System.Drawing.Size(785, 1)
        Me.tlb_main.TabIndex = 29
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
        Me.pnl_info.Controls.Add(Me.btn_sub_profiles)
        Me.pnl_info.Controls.Add(Me.btn_cycles)
        Me.pnl_info.Controls.Add(Me.grpbx_83)
        Me.pnl_info.Controls.Add(Me.grpbx_81)
        Me.pnl_info.Controls.Add(Me.txt_profile_name)
        Me.pnl_info.Controls.Add(Me.grpbx_temp)
        Me.pnl_info.Controls.Add(Me.grpbx_general)
        Me.pnl_info.Controls.Add(Me.txt_button_text)
        Me.pnl_info.Controls.Add(Me.grpbx_82)
        Me.pnl_info.Controls.Add(Me.lbl_info)
        Me.pnl_info.DataSettings.IDField = Nothing
        Me.pnl_info.DataSettings.JoinData = Nothing
        Me.pnl_info.DataSettings.LinkField = Nothing
        Me.pnl_info.DataSettings.TableName = Nothing
        Me.pnl_info.Gradient = False
        Me.pnl_info.Location = New System.Drawing.Point(282, 50)
        Me.pnl_info.Name = "pnl_info"
        Me.pnl_info.RecordID = Nothing
        Me.pnl_info.Saved = False
        Me.pnl_info.Size = New System.Drawing.Size(491, 482)
        Me.pnl_info.TabIndex = 0
        '
        'btn_sub_profiles
        '
        Me.btn_sub_profiles.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_sub_profiles.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_sub_profiles.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_sub_profiles.DisplayText = ""
        Me.btn_sub_profiles.Enabled = False
        Me.btn_sub_profiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_sub_profiles.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sub_profiles.ForeColor = System.Drawing.Color.Black
        Me.btn_sub_profiles.Image = CType(resources.GetObject("btn_sub_profiles.Image"), System.Drawing.Image)
        Me.btn_sub_profiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sub_profiles.Location = New System.Drawing.Point(30, 394)
        Me.btn_sub_profiles.Name = "btn_sub_profiles"
        Me.btn_sub_profiles.Size = New System.Drawing.Size(180, 37)
        Me.btn_sub_profiles.TabIndex = 8
        Me.btn_sub_profiles.TabStop = False
        Me.btn_sub_profiles.Text = "Add/Edit Sub Profiles"
        Me.btn_sub_profiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_sub_profiles.UseVisualStyleBackColor = False
        '
        'btn_cycles
        '
        Me.btn_cycles.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_cycles.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_cycles.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_cycles.DisplayText = ""
        Me.btn_cycles.Enabled = False
        Me.btn_cycles.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cycles.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cycles.ForeColor = System.Drawing.Color.Black
        Me.btn_cycles.Image = CType(resources.GetObject("btn_cycles.Image"), System.Drawing.Image)
        Me.btn_cycles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cycles.Location = New System.Drawing.Point(30, 353)
        Me.btn_cycles.Name = "btn_cycles"
        Me.btn_cycles.Size = New System.Drawing.Size(180, 37)
        Me.btn_cycles.TabIndex = 7
        Me.btn_cycles.TabStop = False
        Me.btn_cycles.Text = "Add/Edit Cycles"
        Me.btn_cycles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cycles.UseVisualStyleBackColor = False
        '
        'grpbx_83
        '
        Me.grpbx_83.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpbx_83.Controls.Add(Me.txt_83_dry_cool_secs)
        Me.grpbx_83.Controls.Add(Me.txt_83_dry_heat_secs)
        Me.grpbx_83.Controls.Add(Me.txt_83_detergent_secs)
        Me.grpbx_83.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbx_83.ForeColor = System.Drawing.Color.Black
        Me.grpbx_83.LineColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grpbx_83.Location = New System.Drawing.Point(242, 387)
        Me.grpbx_83.Name = "grpbx_83"
        Me.grpbx_83.Size = New System.Drawing.Size(245, 89)
        Me.grpbx_83.TabIndex = 6
        Me.grpbx_83.Text = "System 83 Settings"
        '
        'txt_83_dry_cool_secs
        '
        Me.txt_83_dry_cool_secs.AllowNegative = False
        Me.txt_83_dry_cool_secs.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_83_dry_cool_secs.ColorCursor = True
        Me.txt_83_dry_cool_secs.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_83_dry_cool_secs.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_83_dry_cool_secs.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_83_dry_cool_secs.Enabled = False
        Me.txt_83_dry_cool_secs.Field_Name = "dry_cool_secs_83"
        Me.txt_83_dry_cool_secs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_83_dry_cool_secs.ForeColor = System.Drawing.Color.Black
        Me.txt_83_dry_cool_secs.GridBinding = Me.grd_profiles
        Me.txt_83_dry_cool_secs.Label_On_Top = False
        Me.txt_83_dry_cool_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_83_dry_cool_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_83_dry_cool_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_83_dry_cool_secs.Label_Properties.Text = "(a) Drying cool down (30 secs)"
        Me.txt_83_dry_cool_secs.Label_Properties.Width = 180
        Me.txt_83_dry_cool_secs.Location = New System.Drawing.Point(8, 63)
        Me.txt_83_dry_cool_secs.Mandatory = False
        Me.txt_83_dry_cool_secs.Name = "txt_83_dry_cool_secs"
        Me.txt_83_dry_cool_secs.Override_Modified = False
        Me.txt_83_dry_cool_secs.SaveLoadOrder = 0
        Me.txt_83_dry_cool_secs.Size = New System.Drawing.Size(231, 26)
        Me.txt_83_dry_cool_secs.TabIndex = 2
        Me.txt_83_dry_cool_secs.TabStop = False
        Me.txt_83_dry_cool_secs.Tag = "dry_cool_secs"
        Me.txt_83_dry_cool_secs.Text = "DbA_TextBox1"
        Me.txt_83_dry_cool_secs.TextBox_Properties.AcceptsReturn = False
        Me.txt_83_dry_cool_secs.TextBox_Properties.AcceptsTab = False
        Me.txt_83_dry_cool_secs.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_83_dry_cool_secs.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_83_dry_cool_secs.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_83_dry_cool_secs.TextBox_Properties.Enabled = True
        Me.txt_83_dry_cool_secs.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_83_dry_cool_secs.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_83_dry_cool_secs.TextBox_Properties.MaximumValue = 999999
        Me.txt_83_dry_cool_secs.TextBox_Properties.MaxLength = 3
        Me.txt_83_dry_cool_secs.TextBox_Properties.MinimumValue = -999999
        Me.txt_83_dry_cool_secs.TextBox_Properties.MultiLine = False
        Me.txt_83_dry_cool_secs.TextBox_Properties.PasswordChar = Nothing
        Me.txt_83_dry_cool_secs.TextBox_Properties.ReadOnly = False
        Me.txt_83_dry_cool_secs.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_83_dry_cool_secs.TextBox_Properties.TabStop = True
        Me.txt_83_dry_cool_secs.TextBox_Properties.Text = ""
        Me.txt_83_dry_cool_secs.TextBox_Properties.WordWrap = True
        Me.txt_83_dry_cool_secs.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_83_dry_heat_secs
        '
        Me.txt_83_dry_heat_secs.AllowNegative = False
        Me.txt_83_dry_heat_secs.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_83_dry_heat_secs.ColorCursor = True
        Me.txt_83_dry_heat_secs.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_83_dry_heat_secs.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_83_dry_heat_secs.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_83_dry_heat_secs.Enabled = False
        Me.txt_83_dry_heat_secs.Field_Name = "dry_heat_secs_83"
        Me.txt_83_dry_heat_secs.GridBinding = Me.grd_profiles
        Me.txt_83_dry_heat_secs.Label_On_Top = False
        Me.txt_83_dry_heat_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_83_dry_heat_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_83_dry_heat_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_83_dry_heat_secs.Label_Properties.Text = "(a) Drying heat (180 secs)"
        Me.txt_83_dry_heat_secs.Label_Properties.Width = 160
        Me.txt_83_dry_heat_secs.Location = New System.Drawing.Point(28, 40)
        Me.txt_83_dry_heat_secs.Mandatory = False
        Me.txt_83_dry_heat_secs.Name = "txt_83_dry_heat_secs"
        Me.txt_83_dry_heat_secs.Override_Modified = False
        Me.txt_83_dry_heat_secs.SaveLoadOrder = 0
        Me.txt_83_dry_heat_secs.Size = New System.Drawing.Size(211, 26)
        Me.txt_83_dry_heat_secs.TabIndex = 1
        Me.txt_83_dry_heat_secs.TabStop = False
        Me.txt_83_dry_heat_secs.Tag = "dry_heat_secs"
        Me.txt_83_dry_heat_secs.Text = "DbA_TextBox1"
        Me.txt_83_dry_heat_secs.TextBox_Properties.AcceptsReturn = False
        Me.txt_83_dry_heat_secs.TextBox_Properties.AcceptsTab = False
        Me.txt_83_dry_heat_secs.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_83_dry_heat_secs.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_83_dry_heat_secs.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_83_dry_heat_secs.TextBox_Properties.Enabled = True
        Me.txt_83_dry_heat_secs.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_83_dry_heat_secs.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_83_dry_heat_secs.TextBox_Properties.MaximumValue = 999999
        Me.txt_83_dry_heat_secs.TextBox_Properties.MaxLength = 3
        Me.txt_83_dry_heat_secs.TextBox_Properties.MinimumValue = -999999
        Me.txt_83_dry_heat_secs.TextBox_Properties.MultiLine = False
        Me.txt_83_dry_heat_secs.TextBox_Properties.PasswordChar = Nothing
        Me.txt_83_dry_heat_secs.TextBox_Properties.ReadOnly = False
        Me.txt_83_dry_heat_secs.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_83_dry_heat_secs.TextBox_Properties.TabStop = True
        Me.txt_83_dry_heat_secs.TextBox_Properties.Text = ""
        Me.txt_83_dry_heat_secs.TextBox_Properties.WordWrap = True
        Me.txt_83_dry_heat_secs.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_83_detergent_secs
        '
        Me.txt_83_detergent_secs.AllowNegative = False
        Me.txt_83_detergent_secs.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_83_detergent_secs.ColorCursor = True
        Me.txt_83_detergent_secs.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_83_detergent_secs.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_83_detergent_secs.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_83_detergent_secs.Enabled = False
        Me.txt_83_detergent_secs.Field_Name = "detergent_secs_83"
        Me.txt_83_detergent_secs.GridBinding = Me.grd_profiles
        Me.txt_83_detergent_secs.Label_On_Top = False
        Me.txt_83_detergent_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_83_detergent_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_83_detergent_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_83_detergent_secs.Label_Properties.Text = "Detergent (30 secs)"
        Me.txt_83_detergent_secs.Label_Properties.Width = 160
        Me.txt_83_detergent_secs.Location = New System.Drawing.Point(28, 17)
        Me.txt_83_detergent_secs.Mandatory = False
        Me.txt_83_detergent_secs.Name = "txt_83_detergent_secs"
        Me.txt_83_detergent_secs.Override_Modified = False
        Me.txt_83_detergent_secs.SaveLoadOrder = 0
        Me.txt_83_detergent_secs.Size = New System.Drawing.Size(211, 26)
        Me.txt_83_detergent_secs.TabIndex = 0
        Me.txt_83_detergent_secs.TabStop = False
        Me.txt_83_detergent_secs.Tag = "detergent_83_secs"
        Me.txt_83_detergent_secs.Text = "DbA_TextBox1"
        Me.txt_83_detergent_secs.TextBox_Properties.AcceptsReturn = False
        Me.txt_83_detergent_secs.TextBox_Properties.AcceptsTab = False
        Me.txt_83_detergent_secs.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_83_detergent_secs.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_83_detergent_secs.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_83_detergent_secs.TextBox_Properties.Enabled = True
        Me.txt_83_detergent_secs.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_83_detergent_secs.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_83_detergent_secs.TextBox_Properties.MaximumValue = 999999
        Me.txt_83_detergent_secs.TextBox_Properties.MaxLength = 3
        Me.txt_83_detergent_secs.TextBox_Properties.MinimumValue = -999999
        Me.txt_83_detergent_secs.TextBox_Properties.MultiLine = False
        Me.txt_83_detergent_secs.TextBox_Properties.PasswordChar = Nothing
        Me.txt_83_detergent_secs.TextBox_Properties.ReadOnly = False
        Me.txt_83_detergent_secs.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_83_detergent_secs.TextBox_Properties.TabStop = True
        Me.txt_83_detergent_secs.TextBox_Properties.Text = ""
        Me.txt_83_detergent_secs.TextBox_Properties.WordWrap = True
        Me.txt_83_detergent_secs.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'grpbx_81
        '
        Me.grpbx_81.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpbx_81.Controls.Add(Me.txt_81_prewash_secs)
        Me.grpbx_81.Controls.Add(Me.txt_81_soak_secs)
        Me.grpbx_81.Controls.Add(Me.txt_81_enzyme_secs)
        Me.grpbx_81.Controls.Add(Me.txt_81_reservoir_fill_secs)
        Me.grpbx_81.Controls.Add(Me.txt_81_detergent_secs)
        Me.grpbx_81.Controls.Add(Me.txt_81_rinse_secs)
        Me.grpbx_81.Controls.Add(Me.txt_81_rinse_delay_secs)
        Me.grpbx_81.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbx_81.ForeColor = System.Drawing.Color.Black
        Me.grpbx_81.LineColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grpbx_81.Location = New System.Drawing.Point(242, 160)
        Me.grpbx_81.Name = "grpbx_81"
        Me.grpbx_81.Size = New System.Drawing.Size(245, 183)
        Me.grpbx_81.TabIndex = 4
        Me.grpbx_81.Text = "System 81 Settings"
        '
        'txt_81_prewash_secs
        '
        Me.txt_81_prewash_secs.AllowNegative = False
        Me.txt_81_prewash_secs.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_prewash_secs.ColorCursor = True
        Me.txt_81_prewash_secs.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_81_prewash_secs.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_prewash_secs.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_81_prewash_secs.Enabled = False
        Me.txt_81_prewash_secs.Field_Name = "prerinse_secs_81"
        Me.txt_81_prewash_secs.GridBinding = Me.grd_profiles
        Me.txt_81_prewash_secs.Label_On_Top = False
        Me.txt_81_prewash_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_prewash_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_prewash_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_81_prewash_secs.Label_Properties.Text = "(p, y, z) Prerinse (30 secs)"
        Me.txt_81_prewash_secs.Label_Properties.Width = 160
        Me.txt_81_prewash_secs.Location = New System.Drawing.Point(29, 132)
        Me.txt_81_prewash_secs.Mandatory = False
        Me.txt_81_prewash_secs.Name = "txt_81_prewash_secs"
        Me.txt_81_prewash_secs.Override_Modified = False
        Me.txt_81_prewash_secs.SaveLoadOrder = 0
        Me.txt_81_prewash_secs.Size = New System.Drawing.Size(211, 26)
        Me.txt_81_prewash_secs.TabIndex = 5
        Me.txt_81_prewash_secs.TabStop = False
        Me.txt_81_prewash_secs.Tag = "prerinse_secs"
        Me.txt_81_prewash_secs.Text = "DbA_TextBox1"
        Me.txt_81_prewash_secs.TextBox_Properties.AcceptsReturn = False
        Me.txt_81_prewash_secs.TextBox_Properties.AcceptsTab = False
        Me.txt_81_prewash_secs.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_81_prewash_secs.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_81_prewash_secs.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_81_prewash_secs.TextBox_Properties.Enabled = True
        Me.txt_81_prewash_secs.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_prewash_secs.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_81_prewash_secs.TextBox_Properties.MaximumValue = 999999
        Me.txt_81_prewash_secs.TextBox_Properties.MaxLength = 3
        Me.txt_81_prewash_secs.TextBox_Properties.MinimumValue = -999999
        Me.txt_81_prewash_secs.TextBox_Properties.MultiLine = False
        Me.txt_81_prewash_secs.TextBox_Properties.PasswordChar = Nothing
        Me.txt_81_prewash_secs.TextBox_Properties.ReadOnly = False
        Me.txt_81_prewash_secs.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_81_prewash_secs.TextBox_Properties.TabStop = True
        Me.txt_81_prewash_secs.TextBox_Properties.Text = ""
        Me.txt_81_prewash_secs.TextBox_Properties.WordWrap = True
        Me.txt_81_prewash_secs.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_81_soak_secs
        '
        Me.txt_81_soak_secs.AllowNegative = False
        Me.txt_81_soak_secs.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_soak_secs.ColorCursor = True
        Me.txt_81_soak_secs.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_81_soak_secs.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_soak_secs.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_81_soak_secs.Enabled = False
        Me.txt_81_soak_secs.Field_Name = "soak_secs_81"
        Me.txt_81_soak_secs.GridBinding = Me.grd_profiles
        Me.txt_81_soak_secs.Label_On_Top = False
        Me.txt_81_soak_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_soak_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_soak_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_81_soak_secs.Label_Properties.Text = "(x) Soak (30 secs)"
        Me.txt_81_soak_secs.Label_Properties.Width = 120
        Me.txt_81_soak_secs.Location = New System.Drawing.Point(69, 109)
        Me.txt_81_soak_secs.Mandatory = False
        Me.txt_81_soak_secs.Name = "txt_81_soak_secs"
        Me.txt_81_soak_secs.Override_Modified = False
        Me.txt_81_soak_secs.SaveLoadOrder = 0
        Me.txt_81_soak_secs.Size = New System.Drawing.Size(171, 26)
        Me.txt_81_soak_secs.TabIndex = 4
        Me.txt_81_soak_secs.TabStop = False
        Me.txt_81_soak_secs.Tag = "soak_secs"
        Me.txt_81_soak_secs.Text = "DbA_TextBox1"
        Me.txt_81_soak_secs.TextBox_Properties.AcceptsReturn = False
        Me.txt_81_soak_secs.TextBox_Properties.AcceptsTab = False
        Me.txt_81_soak_secs.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_81_soak_secs.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_81_soak_secs.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_81_soak_secs.TextBox_Properties.Enabled = True
        Me.txt_81_soak_secs.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_soak_secs.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_81_soak_secs.TextBox_Properties.MaximumValue = 999999
        Me.txt_81_soak_secs.TextBox_Properties.MaxLength = 3
        Me.txt_81_soak_secs.TextBox_Properties.MinimumValue = -999999
        Me.txt_81_soak_secs.TextBox_Properties.MultiLine = False
        Me.txt_81_soak_secs.TextBox_Properties.PasswordChar = Nothing
        Me.txt_81_soak_secs.TextBox_Properties.ReadOnly = False
        Me.txt_81_soak_secs.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_81_soak_secs.TextBox_Properties.TabStop = True
        Me.txt_81_soak_secs.TextBox_Properties.Text = ""
        Me.txt_81_soak_secs.TextBox_Properties.WordWrap = True
        Me.txt_81_soak_secs.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_81_enzyme_secs
        '
        Me.txt_81_enzyme_secs.AllowNegative = False
        Me.txt_81_enzyme_secs.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_enzyme_secs.ColorCursor = True
        Me.txt_81_enzyme_secs.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_81_enzyme_secs.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_enzyme_secs.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_81_enzyme_secs.Enabled = False
        Me.txt_81_enzyme_secs.Field_Name = "enzyme_secs_81"
        Me.txt_81_enzyme_secs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_enzyme_secs.ForeColor = System.Drawing.Color.Black
        Me.txt_81_enzyme_secs.GridBinding = Me.grd_profiles
        Me.txt_81_enzyme_secs.Label_On_Top = False
        Me.txt_81_enzyme_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_enzyme_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_enzyme_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_81_enzyme_secs.Label_Properties.Text = "(x) Enzyme (30 secs)"
        Me.txt_81_enzyme_secs.Label_Properties.Width = 130
        Me.txt_81_enzyme_secs.Location = New System.Drawing.Point(59, 86)
        Me.txt_81_enzyme_secs.Mandatory = False
        Me.txt_81_enzyme_secs.Name = "txt_81_enzyme_secs"
        Me.txt_81_enzyme_secs.Override_Modified = False
        Me.txt_81_enzyme_secs.SaveLoadOrder = 0
        Me.txt_81_enzyme_secs.Size = New System.Drawing.Size(181, 26)
        Me.txt_81_enzyme_secs.TabIndex = 3
        Me.txt_81_enzyme_secs.TabStop = False
        Me.txt_81_enzyme_secs.Tag = "enzyme_secs"
        Me.txt_81_enzyme_secs.Text = "DbA_TextBox1"
        Me.txt_81_enzyme_secs.TextBox_Properties.AcceptsReturn = False
        Me.txt_81_enzyme_secs.TextBox_Properties.AcceptsTab = False
        Me.txt_81_enzyme_secs.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_81_enzyme_secs.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_81_enzyme_secs.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_81_enzyme_secs.TextBox_Properties.Enabled = True
        Me.txt_81_enzyme_secs.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_enzyme_secs.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_81_enzyme_secs.TextBox_Properties.MaximumValue = 999999
        Me.txt_81_enzyme_secs.TextBox_Properties.MaxLength = 3
        Me.txt_81_enzyme_secs.TextBox_Properties.MinimumValue = -999999
        Me.txt_81_enzyme_secs.TextBox_Properties.MultiLine = False
        Me.txt_81_enzyme_secs.TextBox_Properties.PasswordChar = Nothing
        Me.txt_81_enzyme_secs.TextBox_Properties.ReadOnly = False
        Me.txt_81_enzyme_secs.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_81_enzyme_secs.TextBox_Properties.TabStop = True
        Me.txt_81_enzyme_secs.TextBox_Properties.Text = ""
        Me.txt_81_enzyme_secs.TextBox_Properties.WordWrap = True
        Me.txt_81_enzyme_secs.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_81_reservoir_fill_secs
        '
        Me.txt_81_reservoir_fill_secs.AllowNegative = False
        Me.txt_81_reservoir_fill_secs.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_reservoir_fill_secs.ColorCursor = True
        Me.txt_81_reservoir_fill_secs.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_81_reservoir_fill_secs.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_reservoir_fill_secs.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_81_reservoir_fill_secs.Enabled = False
        Me.txt_81_reservoir_fill_secs.Field_Name = "reservoir_fill_secs_81"
        Me.txt_81_reservoir_fill_secs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_reservoir_fill_secs.ForeColor = System.Drawing.Color.Black
        Me.txt_81_reservoir_fill_secs.GridBinding = Me.grd_profiles
        Me.txt_81_reservoir_fill_secs.Label_On_Top = False
        Me.txt_81_reservoir_fill_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_reservoir_fill_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_reservoir_fill_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_81_reservoir_fill_secs.Label_Properties.Text = "(p) Reservoir fill (30 secs)"
        Me.txt_81_reservoir_fill_secs.Label_Properties.Width = 160
        Me.txt_81_reservoir_fill_secs.Location = New System.Drawing.Point(29, 156)
        Me.txt_81_reservoir_fill_secs.Mandatory = False
        Me.txt_81_reservoir_fill_secs.Name = "txt_81_reservoir_fill_secs"
        Me.txt_81_reservoir_fill_secs.Override_Modified = False
        Me.txt_81_reservoir_fill_secs.SaveLoadOrder = 0
        Me.txt_81_reservoir_fill_secs.Size = New System.Drawing.Size(211, 26)
        Me.txt_81_reservoir_fill_secs.TabIndex = 6
        Me.txt_81_reservoir_fill_secs.TabStop = False
        Me.txt_81_reservoir_fill_secs.Tag = "reservoir_fill_secs"
        Me.txt_81_reservoir_fill_secs.Text = "DbA_TextBox1"
        Me.txt_81_reservoir_fill_secs.TextBox_Properties.AcceptsReturn = False
        Me.txt_81_reservoir_fill_secs.TextBox_Properties.AcceptsTab = False
        Me.txt_81_reservoir_fill_secs.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_81_reservoir_fill_secs.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_81_reservoir_fill_secs.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_81_reservoir_fill_secs.TextBox_Properties.Enabled = True
        Me.txt_81_reservoir_fill_secs.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_reservoir_fill_secs.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_81_reservoir_fill_secs.TextBox_Properties.MaximumValue = 999999
        Me.txt_81_reservoir_fill_secs.TextBox_Properties.MaxLength = 3
        Me.txt_81_reservoir_fill_secs.TextBox_Properties.MinimumValue = -999999
        Me.txt_81_reservoir_fill_secs.TextBox_Properties.MultiLine = False
        Me.txt_81_reservoir_fill_secs.TextBox_Properties.PasswordChar = Nothing
        Me.txt_81_reservoir_fill_secs.TextBox_Properties.ReadOnly = False
        Me.txt_81_reservoir_fill_secs.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_81_reservoir_fill_secs.TextBox_Properties.TabStop = True
        Me.txt_81_reservoir_fill_secs.TextBox_Properties.Text = ""
        Me.txt_81_reservoir_fill_secs.TextBox_Properties.WordWrap = True
        Me.txt_81_reservoir_fill_secs.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_81_detergent_secs
        '
        Me.txt_81_detergent_secs.AllowNegative = False
        Me.txt_81_detergent_secs.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_detergent_secs.ColorCursor = True
        Me.txt_81_detergent_secs.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_81_detergent_secs.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_detergent_secs.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_81_detergent_secs.Enabled = False
        Me.txt_81_detergent_secs.Field_Name = "detergent_secs_81"
        Me.txt_81_detergent_secs.GridBinding = Me.grd_profiles
        Me.txt_81_detergent_secs.Label_On_Top = False
        Me.txt_81_detergent_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_detergent_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_detergent_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_81_detergent_secs.Label_Properties.Text = "(x/y/z) detergent (30 secs)"
        Me.txt_81_detergent_secs.Label_Properties.Width = 165
        Me.txt_81_detergent_secs.Location = New System.Drawing.Point(24, 63)
        Me.txt_81_detergent_secs.Mandatory = False
        Me.txt_81_detergent_secs.Name = "txt_81_detergent_secs"
        Me.txt_81_detergent_secs.Override_Modified = False
        Me.txt_81_detergent_secs.SaveLoadOrder = 0
        Me.txt_81_detergent_secs.Size = New System.Drawing.Size(216, 26)
        Me.txt_81_detergent_secs.TabIndex = 2
        Me.txt_81_detergent_secs.TabStop = False
        Me.txt_81_detergent_secs.Tag = "detergent_81_secs"
        Me.txt_81_detergent_secs.Text = "DbA_TextBox1"
        Me.txt_81_detergent_secs.TextBox_Properties.AcceptsReturn = False
        Me.txt_81_detergent_secs.TextBox_Properties.AcceptsTab = False
        Me.txt_81_detergent_secs.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_81_detergent_secs.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_81_detergent_secs.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_81_detergent_secs.TextBox_Properties.Enabled = True
        Me.txt_81_detergent_secs.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_detergent_secs.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_81_detergent_secs.TextBox_Properties.MaximumValue = 999999
        Me.txt_81_detergent_secs.TextBox_Properties.MaxLength = 3
        Me.txt_81_detergent_secs.TextBox_Properties.MinimumValue = -999999
        Me.txt_81_detergent_secs.TextBox_Properties.MultiLine = False
        Me.txt_81_detergent_secs.TextBox_Properties.PasswordChar = Nothing
        Me.txt_81_detergent_secs.TextBox_Properties.ReadOnly = False
        Me.txt_81_detergent_secs.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_81_detergent_secs.TextBox_Properties.TabStop = True
        Me.txt_81_detergent_secs.TextBox_Properties.Text = ""
        Me.txt_81_detergent_secs.TextBox_Properties.WordWrap = True
        Me.txt_81_detergent_secs.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_81_rinse_secs
        '
        Me.txt_81_rinse_secs.AllowNegative = False
        Me.txt_81_rinse_secs.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_rinse_secs.ColorCursor = True
        Me.txt_81_rinse_secs.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_81_rinse_secs.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_rinse_secs.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_81_rinse_secs.Enabled = False
        Me.txt_81_rinse_secs.Field_Name = "spray_rinse_secs_81"
        Me.txt_81_rinse_secs.GridBinding = Me.grd_profiles
        Me.txt_81_rinse_secs.Label_On_Top = False
        Me.txt_81_rinse_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_rinse_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_rinse_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_81_rinse_secs.Label_Properties.Text = "Spray rinse (30 secs)"
        Me.txt_81_rinse_secs.Label_Properties.Width = 130
        Me.txt_81_rinse_secs.Location = New System.Drawing.Point(59, 40)
        Me.txt_81_rinse_secs.Mandatory = False
        Me.txt_81_rinse_secs.Name = "txt_81_rinse_secs"
        Me.txt_81_rinse_secs.Override_Modified = False
        Me.txt_81_rinse_secs.SaveLoadOrder = 0
        Me.txt_81_rinse_secs.Size = New System.Drawing.Size(181, 26)
        Me.txt_81_rinse_secs.TabIndex = 1
        Me.txt_81_rinse_secs.TabStop = False
        Me.txt_81_rinse_secs.Tag = "spray_rinse_secs"
        Me.txt_81_rinse_secs.Text = "DbA_TextBox1"
        Me.txt_81_rinse_secs.TextBox_Properties.AcceptsReturn = False
        Me.txt_81_rinse_secs.TextBox_Properties.AcceptsTab = False
        Me.txt_81_rinse_secs.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_81_rinse_secs.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_81_rinse_secs.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_81_rinse_secs.TextBox_Properties.Enabled = True
        Me.txt_81_rinse_secs.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_rinse_secs.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_81_rinse_secs.TextBox_Properties.MaximumValue = 999999
        Me.txt_81_rinse_secs.TextBox_Properties.MaxLength = 3
        Me.txt_81_rinse_secs.TextBox_Properties.MinimumValue = -999999
        Me.txt_81_rinse_secs.TextBox_Properties.MultiLine = False
        Me.txt_81_rinse_secs.TextBox_Properties.PasswordChar = Nothing
        Me.txt_81_rinse_secs.TextBox_Properties.ReadOnly = False
        Me.txt_81_rinse_secs.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_81_rinse_secs.TextBox_Properties.TabStop = True
        Me.txt_81_rinse_secs.TextBox_Properties.Text = ""
        Me.txt_81_rinse_secs.TextBox_Properties.WordWrap = True
        Me.txt_81_rinse_secs.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_81_rinse_delay_secs
        '
        Me.txt_81_rinse_delay_secs.AllowNegative = False
        Me.txt_81_rinse_delay_secs.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_rinse_delay_secs.ColorCursor = True
        Me.txt_81_rinse_delay_secs.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_81_rinse_delay_secs.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_rinse_delay_secs.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_81_rinse_delay_secs.Enabled = False
        Me.txt_81_rinse_delay_secs.Field_Name = "spray_rinse_delay_81"
        Me.txt_81_rinse_delay_secs.GridBinding = Me.grd_profiles
        Me.txt_81_rinse_delay_secs.Label_On_Top = False
        Me.txt_81_rinse_delay_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_rinse_delay_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_rinse_delay_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_81_rinse_delay_secs.Label_Properties.Text = "Spray rinse delay (5 secs)"
        Me.txt_81_rinse_delay_secs.Label_Properties.Width = 160
        Me.txt_81_rinse_delay_secs.Location = New System.Drawing.Point(29, 17)
        Me.txt_81_rinse_delay_secs.Mandatory = False
        Me.txt_81_rinse_delay_secs.Name = "txt_81_rinse_delay_secs"
        Me.txt_81_rinse_delay_secs.Override_Modified = False
        Me.txt_81_rinse_delay_secs.SaveLoadOrder = 0
        Me.txt_81_rinse_delay_secs.Size = New System.Drawing.Size(211, 26)
        Me.txt_81_rinse_delay_secs.TabIndex = 0
        Me.txt_81_rinse_delay_secs.TabStop = False
        Me.txt_81_rinse_delay_secs.Tag = "spray_rinse_wait_secs"
        Me.txt_81_rinse_delay_secs.Text = "DbA_TextBox1"
        Me.txt_81_rinse_delay_secs.TextBox_Properties.AcceptsReturn = False
        Me.txt_81_rinse_delay_secs.TextBox_Properties.AcceptsTab = False
        Me.txt_81_rinse_delay_secs.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_81_rinse_delay_secs.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_81_rinse_delay_secs.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_81_rinse_delay_secs.TextBox_Properties.Enabled = True
        Me.txt_81_rinse_delay_secs.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_rinse_delay_secs.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_81_rinse_delay_secs.TextBox_Properties.MaximumValue = 999999
        Me.txt_81_rinse_delay_secs.TextBox_Properties.MaxLength = 3
        Me.txt_81_rinse_delay_secs.TextBox_Properties.MinimumValue = -999999
        Me.txt_81_rinse_delay_secs.TextBox_Properties.MultiLine = False
        Me.txt_81_rinse_delay_secs.TextBox_Properties.PasswordChar = Nothing
        Me.txt_81_rinse_delay_secs.TextBox_Properties.ReadOnly = False
        Me.txt_81_rinse_delay_secs.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_81_rinse_delay_secs.TextBox_Properties.TabStop = True
        Me.txt_81_rinse_delay_secs.TextBox_Properties.Text = ""
        Me.txt_81_rinse_delay_secs.TextBox_Properties.WordWrap = True
        Me.txt_81_rinse_delay_secs.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_profile_name
        '
        Me.txt_profile_name.AllowNegative = False
        Me.txt_profile_name.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_profile_name.ColorCursor = True
        Me.txt_profile_name.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_profile_name.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_profile_name.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_profile_name.Enabled = False
        Me.txt_profile_name.Field_Name = "profile_name"
        Me.txt_profile_name.GridBinding = Me.grd_profiles
        Me.txt_profile_name.Label_On_Top = True
        Me.txt_profile_name.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_profile_name.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_profile_name.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_profile_name.Label_Properties.Text = "Profile Name"
        Me.txt_profile_name.Label_Properties.Width = 200
        Me.txt_profile_name.Location = New System.Drawing.Point(13, 2)
        Me.txt_profile_name.Mandatory = True
        Me.txt_profile_name.Name = "txt_profile_name"
        Me.txt_profile_name.Override_Modified = False
        Me.txt_profile_name.SaveLoadOrder = 0
        Me.txt_profile_name.Size = New System.Drawing.Size(242, 40)
        Me.txt_profile_name.TabIndex = 0
        Me.txt_profile_name.TabStop = False
        Me.txt_profile_name.Text = "DbA_TextBox1"
        Me.txt_profile_name.TextBox_Properties.AcceptsReturn = False
        Me.txt_profile_name.TextBox_Properties.AcceptsTab = False
        Me.txt_profile_name.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_profile_name.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_profile_name.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_profile_name.TextBox_Properties.Enabled = True
        Me.txt_profile_name.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_profile_name.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_profile_name.TextBox_Properties.MaximumValue = 999999
        Me.txt_profile_name.TextBox_Properties.MaxLength = 50
        Me.txt_profile_name.TextBox_Properties.MinimumValue = -999999
        Me.txt_profile_name.TextBox_Properties.MultiLine = False
        Me.txt_profile_name.TextBox_Properties.PasswordChar = Nothing
        Me.txt_profile_name.TextBox_Properties.ReadOnly = False
        Me.txt_profile_name.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_profile_name.TextBox_Properties.TabStop = True
        Me.txt_profile_name.TextBox_Properties.Text = ""
        Me.txt_profile_name.TextBox_Properties.WordWrap = True
        Me.txt_profile_name.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'grpbx_temp
        '
        Me.grpbx_temp.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpbx_temp.Controls.Add(Me.txt_max_abort_temp)
        Me.grpbx_temp.Controls.Add(Me.txt_min_start_temp)
        Me.grpbx_temp.Controls.Add(Me.txt_heat_pad_on)
        Me.grpbx_temp.Controls.Add(Me.txt_heat_pad_off)
        Me.grpbx_temp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbx_temp.ForeColor = System.Drawing.Color.Black
        Me.grpbx_temp.LineColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grpbx_temp.Location = New System.Drawing.Point(242, 45)
        Me.grpbx_temp.Name = "grpbx_temp"
        Me.grpbx_temp.Size = New System.Drawing.Size(245, 110)
        Me.grpbx_temp.TabIndex = 3
        Me.grpbx_temp.Text = "Temperature Settings"
        '
        'txt_max_abort_temp
        '
        Me.txt_max_abort_temp.AllowNegative = False
        Me.txt_max_abort_temp.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_max_abort_temp.ColorCursor = True
        Me.txt_max_abort_temp.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_max_abort_temp.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_max_abort_temp.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_max_abort_temp.Enabled = False
        Me.txt_max_abort_temp.Field_Name = "max_abort_temp"
        Me.txt_max_abort_temp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_max_abort_temp.ForeColor = System.Drawing.Color.Black
        Me.txt_max_abort_temp.GridBinding = Me.grd_profiles
        Me.txt_max_abort_temp.Label_On_Top = False
        Me.txt_max_abort_temp.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_max_abort_temp.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_max_abort_temp.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_max_abort_temp.Label_Properties.Text = "Max abort temperature (50 C)"
        Me.txt_max_abort_temp.Label_Properties.Width = 178
        Me.txt_max_abort_temp.Location = New System.Drawing.Point(11, 85)
        Me.txt_max_abort_temp.Mandatory = False
        Me.txt_max_abort_temp.Name = "txt_max_abort_temp"
        Me.txt_max_abort_temp.Override_Modified = False
        Me.txt_max_abort_temp.SaveLoadOrder = 0
        Me.txt_max_abort_temp.Size = New System.Drawing.Size(229, 26)
        Me.txt_max_abort_temp.TabIndex = 3
        Me.txt_max_abort_temp.TabStop = False
        Me.txt_max_abort_temp.Tag = "max_abort_temperature"
        Me.txt_max_abort_temp.Text = "DbA_TextBox1"
        Me.txt_max_abort_temp.TextBox_Properties.AcceptsReturn = False
        Me.txt_max_abort_temp.TextBox_Properties.AcceptsTab = False
        Me.txt_max_abort_temp.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_max_abort_temp.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_max_abort_temp.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_max_abort_temp.TextBox_Properties.Enabled = True
        Me.txt_max_abort_temp.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_max_abort_temp.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_max_abort_temp.TextBox_Properties.MaximumValue = 999999
        Me.txt_max_abort_temp.TextBox_Properties.MaxLength = 3
        Me.txt_max_abort_temp.TextBox_Properties.MinimumValue = -999999
        Me.txt_max_abort_temp.TextBox_Properties.MultiLine = False
        Me.txt_max_abort_temp.TextBox_Properties.PasswordChar = Nothing
        Me.txt_max_abort_temp.TextBox_Properties.ReadOnly = False
        Me.txt_max_abort_temp.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_max_abort_temp.TextBox_Properties.TabStop = True
        Me.txt_max_abort_temp.TextBox_Properties.Text = ""
        Me.txt_max_abort_temp.TextBox_Properties.WordWrap = True
        Me.txt_max_abort_temp.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_min_start_temp
        '
        Me.txt_min_start_temp.AllowNegative = False
        Me.txt_min_start_temp.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_min_start_temp.ColorCursor = True
        Me.txt_min_start_temp.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_min_start_temp.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_min_start_temp.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_min_start_temp.Enabled = False
        Me.txt_min_start_temp.Field_Name = "min_start_temp"
        Me.txt_min_start_temp.GridBinding = Me.grd_profiles
        Me.txt_min_start_temp.Label_On_Top = False
        Me.txt_min_start_temp.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_min_start_temp.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_min_start_temp.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_min_start_temp.Label_Properties.Text = "Minimum start (24 C)"
        Me.txt_min_start_temp.Label_Properties.Width = 130
        Me.txt_min_start_temp.Location = New System.Drawing.Point(59, 62)
        Me.txt_min_start_temp.Mandatory = False
        Me.txt_min_start_temp.Name = "txt_min_start_temp"
        Me.txt_min_start_temp.Override_Modified = False
        Me.txt_min_start_temp.SaveLoadOrder = 0
        Me.txt_min_start_temp.Size = New System.Drawing.Size(181, 26)
        Me.txt_min_start_temp.TabIndex = 2
        Me.txt_min_start_temp.TabStop = False
        Me.txt_min_start_temp.Tag = "min_start_temperature"
        Me.txt_min_start_temp.Text = "DbA_TextBox1"
        Me.txt_min_start_temp.TextBox_Properties.AcceptsReturn = False
        Me.txt_min_start_temp.TextBox_Properties.AcceptsTab = False
        Me.txt_min_start_temp.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_min_start_temp.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_min_start_temp.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_min_start_temp.TextBox_Properties.Enabled = True
        Me.txt_min_start_temp.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_min_start_temp.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_min_start_temp.TextBox_Properties.MaximumValue = 999999
        Me.txt_min_start_temp.TextBox_Properties.MaxLength = 3
        Me.txt_min_start_temp.TextBox_Properties.MinimumValue = -999999
        Me.txt_min_start_temp.TextBox_Properties.MultiLine = False
        Me.txt_min_start_temp.TextBox_Properties.PasswordChar = Nothing
        Me.txt_min_start_temp.TextBox_Properties.ReadOnly = False
        Me.txt_min_start_temp.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_min_start_temp.TextBox_Properties.TabStop = True
        Me.txt_min_start_temp.TextBox_Properties.Text = ""
        Me.txt_min_start_temp.TextBox_Properties.WordWrap = True
        Me.txt_min_start_temp.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_heat_pad_on
        '
        Me.txt_heat_pad_on.AllowNegative = False
        Me.txt_heat_pad_on.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_heat_pad_on.ColorCursor = True
        Me.txt_heat_pad_on.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_heat_pad_on.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_heat_pad_on.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_heat_pad_on.Enabled = False
        Me.txt_heat_pad_on.Field_Name = "heat_pad_min"
        Me.txt_heat_pad_on.GridBinding = Me.grd_profiles
        Me.txt_heat_pad_on.Label_On_Top = False
        Me.txt_heat_pad_on.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_heat_pad_on.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_heat_pad_on.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_heat_pad_on.Label_Properties.Text = "Heat pad on (min) (25 C)"
        Me.txt_heat_pad_on.Label_Properties.Width = 160
        Me.txt_heat_pad_on.Location = New System.Drawing.Point(29, 39)
        Me.txt_heat_pad_on.Mandatory = False
        Me.txt_heat_pad_on.Name = "txt_heat_pad_on"
        Me.txt_heat_pad_on.Override_Modified = False
        Me.txt_heat_pad_on.SaveLoadOrder = 0
        Me.txt_heat_pad_on.Size = New System.Drawing.Size(211, 26)
        Me.txt_heat_pad_on.TabIndex = 1
        Me.txt_heat_pad_on.TabStop = False
        Me.txt_heat_pad_on.Tag = "min_temperature"
        Me.txt_heat_pad_on.Text = "DbA_TextBox1"
        Me.txt_heat_pad_on.TextBox_Properties.AcceptsReturn = False
        Me.txt_heat_pad_on.TextBox_Properties.AcceptsTab = False
        Me.txt_heat_pad_on.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_heat_pad_on.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_heat_pad_on.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_heat_pad_on.TextBox_Properties.Enabled = True
        Me.txt_heat_pad_on.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_heat_pad_on.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_heat_pad_on.TextBox_Properties.MaximumValue = 999999
        Me.txt_heat_pad_on.TextBox_Properties.MaxLength = 3
        Me.txt_heat_pad_on.TextBox_Properties.MinimumValue = -999999
        Me.txt_heat_pad_on.TextBox_Properties.MultiLine = False
        Me.txt_heat_pad_on.TextBox_Properties.PasswordChar = Nothing
        Me.txt_heat_pad_on.TextBox_Properties.ReadOnly = False
        Me.txt_heat_pad_on.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_heat_pad_on.TextBox_Properties.TabStop = True
        Me.txt_heat_pad_on.TextBox_Properties.Text = ""
        Me.txt_heat_pad_on.TextBox_Properties.WordWrap = True
        Me.txt_heat_pad_on.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_heat_pad_off
        '
        Me.txt_heat_pad_off.AllowNegative = False
        Me.txt_heat_pad_off.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_heat_pad_off.ColorCursor = True
        Me.txt_heat_pad_off.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_heat_pad_off.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_heat_pad_off.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_heat_pad_off.Enabled = False
        Me.txt_heat_pad_off.Field_Name = "heat_pad_max"
        Me.txt_heat_pad_off.GridBinding = Me.grd_profiles
        Me.txt_heat_pad_off.Label_On_Top = False
        Me.txt_heat_pad_off.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_heat_pad_off.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_heat_pad_off.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_heat_pad_off.Label_Properties.Text = "Heat pad off (max) (28 C)"
        Me.txt_heat_pad_off.Label_Properties.Width = 160
        Me.txt_heat_pad_off.Location = New System.Drawing.Point(29, 16)
        Me.txt_heat_pad_off.Mandatory = False
        Me.txt_heat_pad_off.Name = "txt_heat_pad_off"
        Me.txt_heat_pad_off.Override_Modified = False
        Me.txt_heat_pad_off.SaveLoadOrder = 0
        Me.txt_heat_pad_off.Size = New System.Drawing.Size(211, 26)
        Me.txt_heat_pad_off.TabIndex = 0
        Me.txt_heat_pad_off.TabStop = False
        Me.txt_heat_pad_off.Tag = "max_temperature"
        Me.txt_heat_pad_off.Text = "DbA_TextBox1"
        Me.txt_heat_pad_off.TextBox_Properties.AcceptsReturn = False
        Me.txt_heat_pad_off.TextBox_Properties.AcceptsTab = False
        Me.txt_heat_pad_off.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_heat_pad_off.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_heat_pad_off.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_heat_pad_off.TextBox_Properties.Enabled = True
        Me.txt_heat_pad_off.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_heat_pad_off.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_heat_pad_off.TextBox_Properties.MaximumValue = 999999
        Me.txt_heat_pad_off.TextBox_Properties.MaxLength = 3
        Me.txt_heat_pad_off.TextBox_Properties.MinimumValue = -999999
        Me.txt_heat_pad_off.TextBox_Properties.MultiLine = False
        Me.txt_heat_pad_off.TextBox_Properties.PasswordChar = Nothing
        Me.txt_heat_pad_off.TextBox_Properties.ReadOnly = False
        Me.txt_heat_pad_off.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_heat_pad_off.TextBox_Properties.TabStop = True
        Me.txt_heat_pad_off.TextBox_Properties.Text = ""
        Me.txt_heat_pad_off.TextBox_Properties.WordWrap = True
        Me.txt_heat_pad_off.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'grpbx_general
        '
        Me.grpbx_general.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpbx_general.Controls.Add(Me.txt_ultrasonics_abort)
        Me.grpbx_general.Controls.Add(Me.txt_safety_delay)
        Me.grpbx_general.Controls.Add(Me.txt_pressure_error)
        Me.grpbx_general.Controls.Add(Me.txt_pressure_start)
        Me.grpbx_general.Controls.Add(Me.txt_float_delay)
        Me.grpbx_general.Controls.Add(Me.txt_warwick_delay)
        Me.grpbx_general.Controls.Add(Me.txt_drain2)
        Me.grpbx_general.Controls.Add(Me.txt_drain1)
        Me.grpbx_general.Controls.Add(Me.txt_lubrication)
        Me.grpbx_general.Controls.Add(Me.txt_chemical_immersion)
        Me.grpbx_general.Controls.Add(Me.txt_wash_rinse_secs)
        Me.grpbx_general.Controls.Add(Me.txt_wash_secs)
        Me.grpbx_general.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbx_general.ForeColor = System.Drawing.Color.Black
        Me.grpbx_general.LineColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grpbx_general.Location = New System.Drawing.Point(4, 45)
        Me.grpbx_general.Name = "grpbx_general"
        Me.grpbx_general.Size = New System.Drawing.Size(237, 298)
        Me.grpbx_general.TabIndex = 2
        Me.grpbx_general.Text = "General Settings"
        '
        'txt_ultrasonics_abort
        '
        Me.txt_ultrasonics_abort.AllowNegative = False
        Me.txt_ultrasonics_abort.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_ultrasonics_abort.ColorCursor = True
        Me.txt_ultrasonics_abort.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_ultrasonics_abort.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_ultrasonics_abort.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_ultrasonics_abort.Enabled = False
        Me.txt_ultrasonics_abort.Field_Name = "ultrasonics_delay_secs"
        Me.txt_ultrasonics_abort.GridBinding = Me.grd_profiles
        Me.txt_ultrasonics_abort.Label_On_Top = False
        Me.txt_ultrasonics_abort.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_ultrasonics_abort.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ultrasonics_abort.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_ultrasonics_abort.Label_Properties.Text = "Ultrasonics delay (2 secs)"
        Me.txt_ultrasonics_abort.Label_Properties.Width = 160
        Me.txt_ultrasonics_abort.Location = New System.Drawing.Point(20, 272)
        Me.txt_ultrasonics_abort.Mandatory = False
        Me.txt_ultrasonics_abort.Name = "txt_ultrasonics_abort"
        Me.txt_ultrasonics_abort.Override_Modified = False
        Me.txt_ultrasonics_abort.SaveLoadOrder = 0
        Me.txt_ultrasonics_abort.Size = New System.Drawing.Size(211, 26)
        Me.txt_ultrasonics_abort.TabIndex = 11
        Me.txt_ultrasonics_abort.TabStop = False
        Me.txt_ultrasonics_abort.Tag = "ultrasonics_delay_secs"
        Me.txt_ultrasonics_abort.Text = "DbA_TextBox1"
        Me.txt_ultrasonics_abort.TextBox_Properties.AcceptsReturn = False
        Me.txt_ultrasonics_abort.TextBox_Properties.AcceptsTab = False
        Me.txt_ultrasonics_abort.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_ultrasonics_abort.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ultrasonics_abort.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_ultrasonics_abort.TextBox_Properties.Enabled = True
        Me.txt_ultrasonics_abort.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ultrasonics_abort.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_ultrasonics_abort.TextBox_Properties.MaximumValue = 999999
        Me.txt_ultrasonics_abort.TextBox_Properties.MaxLength = 3
        Me.txt_ultrasonics_abort.TextBox_Properties.MinimumValue = -999999
        Me.txt_ultrasonics_abort.TextBox_Properties.MultiLine = False
        Me.txt_ultrasonics_abort.TextBox_Properties.PasswordChar = Nothing
        Me.txt_ultrasonics_abort.TextBox_Properties.ReadOnly = False
        Me.txt_ultrasonics_abort.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_ultrasonics_abort.TextBox_Properties.TabStop = True
        Me.txt_ultrasonics_abort.TextBox_Properties.Text = ""
        Me.txt_ultrasonics_abort.TextBox_Properties.WordWrap = True
        Me.txt_ultrasonics_abort.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_safety_delay
        '
        Me.txt_safety_delay.AllowNegative = False
        Me.txt_safety_delay.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_safety_delay.ColorCursor = True
        Me.txt_safety_delay.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_safety_delay.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_safety_delay.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_safety_delay.Enabled = False
        Me.txt_safety_delay.Field_Name = "safety_delay_secs"
        Me.txt_safety_delay.GridBinding = Me.grd_profiles
        Me.txt_safety_delay.Label_On_Top = False
        Me.txt_safety_delay.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_safety_delay.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_safety_delay.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_safety_delay.Label_Properties.Text = "Safety delay (2 secs)"
        Me.txt_safety_delay.Label_Properties.Width = 130
        Me.txt_safety_delay.Location = New System.Drawing.Point(50, 249)
        Me.txt_safety_delay.Mandatory = False
        Me.txt_safety_delay.Name = "txt_safety_delay"
        Me.txt_safety_delay.Override_Modified = False
        Me.txt_safety_delay.SaveLoadOrder = 0
        Me.txt_safety_delay.Size = New System.Drawing.Size(181, 26)
        Me.txt_safety_delay.TabIndex = 10
        Me.txt_safety_delay.TabStop = False
        Me.txt_safety_delay.Tag = "safety_delay_secs"
        Me.txt_safety_delay.Text = "DbA_TextBox1"
        Me.txt_safety_delay.TextBox_Properties.AcceptsReturn = False
        Me.txt_safety_delay.TextBox_Properties.AcceptsTab = False
        Me.txt_safety_delay.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_safety_delay.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_safety_delay.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_safety_delay.TextBox_Properties.Enabled = True
        Me.txt_safety_delay.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_safety_delay.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_safety_delay.TextBox_Properties.MaximumValue = 999999
        Me.txt_safety_delay.TextBox_Properties.MaxLength = 3
        Me.txt_safety_delay.TextBox_Properties.MinimumValue = -999999
        Me.txt_safety_delay.TextBox_Properties.MultiLine = False
        Me.txt_safety_delay.TextBox_Properties.PasswordChar = Nothing
        Me.txt_safety_delay.TextBox_Properties.ReadOnly = False
        Me.txt_safety_delay.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_safety_delay.TextBox_Properties.TabStop = True
        Me.txt_safety_delay.TextBox_Properties.Text = ""
        Me.txt_safety_delay.TextBox_Properties.WordWrap = True
        Me.txt_safety_delay.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_pressure_error
        '
        Me.txt_pressure_error.AllowNegative = False
        Me.txt_pressure_error.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_pressure_error.ColorCursor = True
        Me.txt_pressure_error.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_pressure_error.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_pressure_error.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_pressure_error.Enabled = False
        Me.txt_pressure_error.Field_Name = "pressure_error_delay_secs"
        Me.txt_pressure_error.GridBinding = Me.grd_profiles
        Me.txt_pressure_error.Label_On_Top = False
        Me.txt_pressure_error.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_pressure_error.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pressure_error.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_pressure_error.Label_Properties.Text = "Pressure error delay (5 secs)"
        Me.txt_pressure_error.Label_Properties.Width = 178
        Me.txt_pressure_error.Location = New System.Drawing.Point(2, 226)
        Me.txt_pressure_error.Mandatory = False
        Me.txt_pressure_error.Name = "txt_pressure_error"
        Me.txt_pressure_error.Override_Modified = False
        Me.txt_pressure_error.SaveLoadOrder = 0
        Me.txt_pressure_error.Size = New System.Drawing.Size(229, 26)
        Me.txt_pressure_error.TabIndex = 9
        Me.txt_pressure_error.TabStop = False
        Me.txt_pressure_error.Tag = "pressure_error_delay_secs"
        Me.txt_pressure_error.Text = "DbA_TextBox1"
        Me.txt_pressure_error.TextBox_Properties.AcceptsReturn = False
        Me.txt_pressure_error.TextBox_Properties.AcceptsTab = False
        Me.txt_pressure_error.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_pressure_error.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pressure_error.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_pressure_error.TextBox_Properties.Enabled = True
        Me.txt_pressure_error.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pressure_error.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_pressure_error.TextBox_Properties.MaximumValue = 999999
        Me.txt_pressure_error.TextBox_Properties.MaxLength = 3
        Me.txt_pressure_error.TextBox_Properties.MinimumValue = -999999
        Me.txt_pressure_error.TextBox_Properties.MultiLine = False
        Me.txt_pressure_error.TextBox_Properties.PasswordChar = Nothing
        Me.txt_pressure_error.TextBox_Properties.ReadOnly = False
        Me.txt_pressure_error.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_pressure_error.TextBox_Properties.TabStop = True
        Me.txt_pressure_error.TextBox_Properties.Text = ""
        Me.txt_pressure_error.TextBox_Properties.WordWrap = True
        Me.txt_pressure_error.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_pressure_start
        '
        Me.txt_pressure_start.AllowNegative = False
        Me.txt_pressure_start.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_pressure_start.ColorCursor = True
        Me.txt_pressure_start.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_pressure_start.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_pressure_start.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_pressure_start.Enabled = False
        Me.txt_pressure_start.Field_Name = "pressure_start_delay_secs"
        Me.txt_pressure_start.GridBinding = Me.grd_profiles
        Me.txt_pressure_start.Label_On_Top = False
        Me.txt_pressure_start.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_pressure_start.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pressure_start.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_pressure_start.Label_Properties.Text = "Pressure start delay (75 secs)"
        Me.txt_pressure_start.Label_Properties.Width = 178
        Me.txt_pressure_start.Location = New System.Drawing.Point(2, 203)
        Me.txt_pressure_start.Mandatory = False
        Me.txt_pressure_start.Name = "txt_pressure_start"
        Me.txt_pressure_start.Override_Modified = False
        Me.txt_pressure_start.SaveLoadOrder = 0
        Me.txt_pressure_start.Size = New System.Drawing.Size(229, 26)
        Me.txt_pressure_start.TabIndex = 8
        Me.txt_pressure_start.TabStop = False
        Me.txt_pressure_start.Tag = "pressure_start_delay_secs"
        Me.txt_pressure_start.Text = "DbA_TextBox1"
        Me.txt_pressure_start.TextBox_Properties.AcceptsReturn = False
        Me.txt_pressure_start.TextBox_Properties.AcceptsTab = False
        Me.txt_pressure_start.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_pressure_start.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pressure_start.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_pressure_start.TextBox_Properties.Enabled = True
        Me.txt_pressure_start.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pressure_start.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_pressure_start.TextBox_Properties.MaximumValue = 999999
        Me.txt_pressure_start.TextBox_Properties.MaxLength = 3
        Me.txt_pressure_start.TextBox_Properties.MinimumValue = -999999
        Me.txt_pressure_start.TextBox_Properties.MultiLine = False
        Me.txt_pressure_start.TextBox_Properties.PasswordChar = Nothing
        Me.txt_pressure_start.TextBox_Properties.ReadOnly = False
        Me.txt_pressure_start.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_pressure_start.TextBox_Properties.TabStop = True
        Me.txt_pressure_start.TextBox_Properties.Text = ""
        Me.txt_pressure_start.TextBox_Properties.WordWrap = True
        Me.txt_pressure_start.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_float_delay
        '
        Me.txt_float_delay.AllowNegative = False
        Me.txt_float_delay.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_float_delay.ColorCursor = True
        Me.txt_float_delay.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_float_delay.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_float_delay.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_float_delay.Enabled = False
        Me.txt_float_delay.Field_Name = "float_delay_secs"
        Me.txt_float_delay.GridBinding = Me.grd_profiles
        Me.txt_float_delay.Label_On_Top = False
        Me.txt_float_delay.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_float_delay.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_float_delay.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_float_delay.Label_Properties.Text = "Float delay (1 secs)"
        Me.txt_float_delay.Label_Properties.Width = 140
        Me.txt_float_delay.Location = New System.Drawing.Point(40, 180)
        Me.txt_float_delay.Mandatory = False
        Me.txt_float_delay.Name = "txt_float_delay"
        Me.txt_float_delay.Override_Modified = False
        Me.txt_float_delay.SaveLoadOrder = 0
        Me.txt_float_delay.Size = New System.Drawing.Size(191, 26)
        Me.txt_float_delay.TabIndex = 7
        Me.txt_float_delay.TabStop = False
        Me.txt_float_delay.Tag = "float_delay_secs"
        Me.txt_float_delay.Text = "DbA_TextBox1"
        Me.txt_float_delay.TextBox_Properties.AcceptsReturn = False
        Me.txt_float_delay.TextBox_Properties.AcceptsTab = False
        Me.txt_float_delay.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_float_delay.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_float_delay.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_float_delay.TextBox_Properties.Enabled = True
        Me.txt_float_delay.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_float_delay.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_float_delay.TextBox_Properties.MaximumValue = 999999
        Me.txt_float_delay.TextBox_Properties.MaxLength = 3
        Me.txt_float_delay.TextBox_Properties.MinimumValue = -999999
        Me.txt_float_delay.TextBox_Properties.MultiLine = False
        Me.txt_float_delay.TextBox_Properties.PasswordChar = Nothing
        Me.txt_float_delay.TextBox_Properties.ReadOnly = False
        Me.txt_float_delay.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_float_delay.TextBox_Properties.TabStop = True
        Me.txt_float_delay.TextBox_Properties.Text = ""
        Me.txt_float_delay.TextBox_Properties.WordWrap = True
        Me.txt_float_delay.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_warwick_delay
        '
        Me.txt_warwick_delay.AllowNegative = False
        Me.txt_warwick_delay.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_warwick_delay.ColorCursor = True
        Me.txt_warwick_delay.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_warwick_delay.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_warwick_delay.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_warwick_delay.Enabled = False
        Me.txt_warwick_delay.Field_Name = "warwick_delay_secs"
        Me.txt_warwick_delay.GridBinding = Me.grd_profiles
        Me.txt_warwick_delay.Label_On_Top = False
        Me.txt_warwick_delay.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_warwick_delay.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_warwick_delay.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_warwick_delay.Label_Properties.Text = "Warwick delay (5 secs)"
        Me.txt_warwick_delay.Label_Properties.Width = 140
        Me.txt_warwick_delay.Location = New System.Drawing.Point(40, 157)
        Me.txt_warwick_delay.Mandatory = False
        Me.txt_warwick_delay.Name = "txt_warwick_delay"
        Me.txt_warwick_delay.Override_Modified = False
        Me.txt_warwick_delay.SaveLoadOrder = 0
        Me.txt_warwick_delay.Size = New System.Drawing.Size(191, 26)
        Me.txt_warwick_delay.TabIndex = 6
        Me.txt_warwick_delay.TabStop = False
        Me.txt_warwick_delay.Tag = "warwick_delay_secs"
        Me.txt_warwick_delay.Text = "DbA_TextBox1"
        Me.txt_warwick_delay.TextBox_Properties.AcceptsReturn = False
        Me.txt_warwick_delay.TextBox_Properties.AcceptsTab = False
        Me.txt_warwick_delay.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_warwick_delay.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_warwick_delay.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_warwick_delay.TextBox_Properties.Enabled = True
        Me.txt_warwick_delay.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_warwick_delay.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_warwick_delay.TextBox_Properties.MaximumValue = 999999
        Me.txt_warwick_delay.TextBox_Properties.MaxLength = 3
        Me.txt_warwick_delay.TextBox_Properties.MinimumValue = -999999
        Me.txt_warwick_delay.TextBox_Properties.MultiLine = False
        Me.txt_warwick_delay.TextBox_Properties.PasswordChar = Nothing
        Me.txt_warwick_delay.TextBox_Properties.ReadOnly = False
        Me.txt_warwick_delay.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_warwick_delay.TextBox_Properties.TabStop = True
        Me.txt_warwick_delay.TextBox_Properties.Text = ""
        Me.txt_warwick_delay.TextBox_Properties.WordWrap = True
        Me.txt_warwick_delay.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_drain2
        '
        Me.txt_drain2.AllowNegative = False
        Me.txt_drain2.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_drain2.ColorCursor = True
        Me.txt_drain2.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_drain2.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_drain2.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_drain2.Enabled = False
        Me.txt_drain2.Field_Name = "drain2_secs"
        Me.txt_drain2.GridBinding = Me.grd_profiles
        Me.txt_drain2.Label_On_Top = False
        Me.txt_drain2.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_drain2.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_drain2.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_drain2.Label_Properties.Text = "Drain period 2nd (10 secs)"
        Me.txt_drain2.Label_Properties.Width = 155
        Me.txt_drain2.Location = New System.Drawing.Point(25, 134)
        Me.txt_drain2.Mandatory = False
        Me.txt_drain2.Name = "txt_drain2"
        Me.txt_drain2.Override_Modified = False
        Me.txt_drain2.SaveLoadOrder = 0
        Me.txt_drain2.Size = New System.Drawing.Size(206, 26)
        Me.txt_drain2.TabIndex = 5
        Me.txt_drain2.TabStop = False
        Me.txt_drain2.Tag = "drain_10_secs"
        Me.txt_drain2.Text = "DbA_TextBox1"
        Me.txt_drain2.TextBox_Properties.AcceptsReturn = False
        Me.txt_drain2.TextBox_Properties.AcceptsTab = False
        Me.txt_drain2.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_drain2.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_drain2.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_drain2.TextBox_Properties.Enabled = True
        Me.txt_drain2.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_drain2.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_drain2.TextBox_Properties.MaximumValue = 999999
        Me.txt_drain2.TextBox_Properties.MaxLength = 3
        Me.txt_drain2.TextBox_Properties.MinimumValue = -999999
        Me.txt_drain2.TextBox_Properties.MultiLine = False
        Me.txt_drain2.TextBox_Properties.PasswordChar = Nothing
        Me.txt_drain2.TextBox_Properties.ReadOnly = False
        Me.txt_drain2.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_drain2.TextBox_Properties.TabStop = True
        Me.txt_drain2.TextBox_Properties.Text = ""
        Me.txt_drain2.TextBox_Properties.WordWrap = True
        Me.txt_drain2.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_drain1
        '
        Me.txt_drain1.AllowNegative = False
        Me.txt_drain1.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_drain1.ColorCursor = True
        Me.txt_drain1.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_drain1.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_drain1.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_drain1.Enabled = False
        Me.txt_drain1.Field_Name = "drain1_secs"
        Me.txt_drain1.GridBinding = Me.grd_profiles
        Me.txt_drain1.Label_On_Top = False
        Me.txt_drain1.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_drain1.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_drain1.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_drain1.Label_Properties.Text = "Drain period 1st (30 secs)"
        Me.txt_drain1.Label_Properties.Width = 160
        Me.txt_drain1.Location = New System.Drawing.Point(20, 111)
        Me.txt_drain1.Mandatory = False
        Me.txt_drain1.Name = "txt_drain1"
        Me.txt_drain1.Override_Modified = False
        Me.txt_drain1.SaveLoadOrder = 0
        Me.txt_drain1.Size = New System.Drawing.Size(211, 26)
        Me.txt_drain1.TabIndex = 4
        Me.txt_drain1.TabStop = False
        Me.txt_drain1.Tag = "drain_30_secs"
        Me.txt_drain1.Text = "DbA_TextBox1"
        Me.txt_drain1.TextBox_Properties.AcceptsReturn = False
        Me.txt_drain1.TextBox_Properties.AcceptsTab = False
        Me.txt_drain1.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_drain1.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_drain1.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_drain1.TextBox_Properties.Enabled = True
        Me.txt_drain1.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_drain1.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_drain1.TextBox_Properties.MaximumValue = 999999
        Me.txt_drain1.TextBox_Properties.MaxLength = 3
        Me.txt_drain1.TextBox_Properties.MinimumValue = -999999
        Me.txt_drain1.TextBox_Properties.MultiLine = False
        Me.txt_drain1.TextBox_Properties.PasswordChar = Nothing
        Me.txt_drain1.TextBox_Properties.ReadOnly = False
        Me.txt_drain1.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_drain1.TextBox_Properties.TabStop = True
        Me.txt_drain1.TextBox_Properties.Text = ""
        Me.txt_drain1.TextBox_Properties.WordWrap = True
        Me.txt_drain1.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_lubrication
        '
        Me.txt_lubrication.AllowNegative = False
        Me.txt_lubrication.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_lubrication.ColorCursor = True
        Me.txt_lubrication.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_lubrication.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_lubrication.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_lubrication.Enabled = False
        Me.txt_lubrication.Field_Name = "lubrication_secs"
        Me.txt_lubrication.GridBinding = Me.grd_profiles
        Me.txt_lubrication.Label_On_Top = False
        Me.txt_lubrication.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_lubrication.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lubrication.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_lubrication.Label_Properties.Text = "Lubrication (10 secs)"
        Me.txt_lubrication.Label_Properties.Width = 130
        Me.txt_lubrication.Location = New System.Drawing.Point(50, 88)
        Me.txt_lubrication.Mandatory = False
        Me.txt_lubrication.Name = "txt_lubrication"
        Me.txt_lubrication.Override_Modified = False
        Me.txt_lubrication.SaveLoadOrder = 0
        Me.txt_lubrication.Size = New System.Drawing.Size(181, 26)
        Me.txt_lubrication.TabIndex = 3
        Me.txt_lubrication.TabStop = False
        Me.txt_lubrication.Tag = "lub_secs"
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
        '
        'txt_chemical_immersion
        '
        Me.txt_chemical_immersion.AllowNegative = False
        Me.txt_chemical_immersion.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_chemical_immersion.ColorCursor = True
        Me.txt_chemical_immersion.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_chemical_immersion.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_chemical_immersion.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_chemical_immersion.Enabled = False
        Me.txt_chemical_immersion.Field_Name = "chemical_immersion"
        Me.txt_chemical_immersion.GridBinding = Me.grd_profiles
        Me.txt_chemical_immersion.Label_On_Top = False
        Me.txt_chemical_immersion.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_chemical_immersion.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_chemical_immersion.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_chemical_immersion.Label_Properties.Text = "Chemical immersion (10 mins)"
        Me.txt_chemical_immersion.Label_Properties.Width = 178
        Me.txt_chemical_immersion.Location = New System.Drawing.Point(2, 65)
        Me.txt_chemical_immersion.Mandatory = False
        Me.txt_chemical_immersion.Name = "txt_chemical_immersion"
        Me.txt_chemical_immersion.Override_Modified = False
        Me.txt_chemical_immersion.SaveLoadOrder = 0
        Me.txt_chemical_immersion.Size = New System.Drawing.Size(229, 26)
        Me.txt_chemical_immersion.TabIndex = 2
        Me.txt_chemical_immersion.TabStop = False
        Me.txt_chemical_immersion.Tag = "disinfect_secs"
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
        '
        'txt_wash_rinse_secs
        '
        Me.txt_wash_rinse_secs.AllowNegative = False
        Me.txt_wash_rinse_secs.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_wash_rinse_secs.ColorCursor = True
        Me.txt_wash_rinse_secs.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_wash_rinse_secs.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_wash_rinse_secs.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_wash_rinse_secs.Enabled = False
        Me.txt_wash_rinse_secs.Field_Name = "rinse_secs"
        Me.txt_wash_rinse_secs.GridBinding = Me.grd_profiles
        Me.txt_wash_rinse_secs.Label_On_Top = False
        Me.txt_wash_rinse_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_wash_rinse_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_wash_rinse_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_wash_rinse_secs.Label_Properties.Text = "Rinse (60 secs)"
        Me.txt_wash_rinse_secs.Label_Properties.Width = 100
        Me.txt_wash_rinse_secs.Location = New System.Drawing.Point(80, 42)
        Me.txt_wash_rinse_secs.Mandatory = False
        Me.txt_wash_rinse_secs.Name = "txt_wash_rinse_secs"
        Me.txt_wash_rinse_secs.Override_Modified = False
        Me.txt_wash_rinse_secs.SaveLoadOrder = 0
        Me.txt_wash_rinse_secs.Size = New System.Drawing.Size(151, 26)
        Me.txt_wash_rinse_secs.TabIndex = 1
        Me.txt_wash_rinse_secs.TabStop = False
        Me.txt_wash_rinse_secs.Tag = "rinse_secs"
        Me.txt_wash_rinse_secs.Text = "DbA_TextBox1"
        Me.txt_wash_rinse_secs.TextBox_Properties.AcceptsReturn = False
        Me.txt_wash_rinse_secs.TextBox_Properties.AcceptsTab = False
        Me.txt_wash_rinse_secs.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_wash_rinse_secs.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_wash_rinse_secs.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_wash_rinse_secs.TextBox_Properties.Enabled = True
        Me.txt_wash_rinse_secs.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_wash_rinse_secs.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_wash_rinse_secs.TextBox_Properties.MaximumValue = 999999
        Me.txt_wash_rinse_secs.TextBox_Properties.MaxLength = 3
        Me.txt_wash_rinse_secs.TextBox_Properties.MinimumValue = -999999
        Me.txt_wash_rinse_secs.TextBox_Properties.MultiLine = False
        Me.txt_wash_rinse_secs.TextBox_Properties.PasswordChar = Nothing
        Me.txt_wash_rinse_secs.TextBox_Properties.ReadOnly = False
        Me.txt_wash_rinse_secs.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_wash_rinse_secs.TextBox_Properties.TabStop = True
        Me.txt_wash_rinse_secs.TextBox_Properties.Text = ""
        Me.txt_wash_rinse_secs.TextBox_Properties.WordWrap = True
        Me.txt_wash_rinse_secs.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_wash_secs
        '
        Me.txt_wash_secs.AllowNegative = False
        Me.txt_wash_secs.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_wash_secs.ColorCursor = True
        Me.txt_wash_secs.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_wash_secs.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_wash_secs.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_wash_secs.Enabled = False
        Me.txt_wash_secs.Field_Name = "wash_secs"
        Me.txt_wash_secs.GridBinding = Me.grd_profiles
        Me.txt_wash_secs.Label_On_Top = False
        Me.txt_wash_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_wash_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_wash_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_wash_secs.Label_Properties.Text = "Wash (180 secs)"
        Me.txt_wash_secs.Label_Properties.Width = 100
        Me.txt_wash_secs.Location = New System.Drawing.Point(80, 19)
        Me.txt_wash_secs.Mandatory = False
        Me.txt_wash_secs.Name = "txt_wash_secs"
        Me.txt_wash_secs.Override_Modified = False
        Me.txt_wash_secs.SaveLoadOrder = 0
        Me.txt_wash_secs.Size = New System.Drawing.Size(151, 26)
        Me.txt_wash_secs.TabIndex = 0
        Me.txt_wash_secs.TabStop = False
        Me.txt_wash_secs.Tag = "wash_secs"
        Me.txt_wash_secs.Text = "DbA_TextBox1"
        Me.txt_wash_secs.TextBox_Properties.AcceptsReturn = False
        Me.txt_wash_secs.TextBox_Properties.AcceptsTab = False
        Me.txt_wash_secs.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_wash_secs.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_wash_secs.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_wash_secs.TextBox_Properties.Enabled = True
        Me.txt_wash_secs.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_wash_secs.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_wash_secs.TextBox_Properties.MaximumValue = 999999
        Me.txt_wash_secs.TextBox_Properties.MaxLength = 3
        Me.txt_wash_secs.TextBox_Properties.MinimumValue = -999999
        Me.txt_wash_secs.TextBox_Properties.MultiLine = False
        Me.txt_wash_secs.TextBox_Properties.PasswordChar = Nothing
        Me.txt_wash_secs.TextBox_Properties.ReadOnly = False
        Me.txt_wash_secs.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_wash_secs.TextBox_Properties.TabStop = True
        Me.txt_wash_secs.TextBox_Properties.Text = ""
        Me.txt_wash_secs.TextBox_Properties.WordWrap = True
        Me.txt_wash_secs.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_button_text
        '
        Me.txt_button_text.AllowNegative = False
        Me.txt_button_text.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_button_text.ColorCursor = True
        Me.txt_button_text.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_button_text.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_button_text.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_button_text.Enabled = False
        Me.txt_button_text.Field_Name = "button_text"
        Me.txt_button_text.GridBinding = Me.grd_profiles
        Me.txt_button_text.Label_On_Top = True
        Me.txt_button_text.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_button_text.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_button_text.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_button_text.Label_Properties.Text = "Function Button Text"
        Me.txt_button_text.Label_Properties.Width = 200
        Me.txt_button_text.Location = New System.Drawing.Point(268, 2)
        Me.txt_button_text.Mandatory = True
        Me.txt_button_text.Name = "txt_button_text"
        Me.txt_button_text.Override_Modified = False
        Me.txt_button_text.SaveLoadOrder = 0
        Me.txt_button_text.Size = New System.Drawing.Size(154, 40)
        Me.txt_button_text.TabIndex = 1
        Me.txt_button_text.TabStop = False
        Me.txt_button_text.Text = "DbA_TextBox1"
        Me.txt_button_text.TextBox_Properties.AcceptsReturn = False
        Me.txt_button_text.TextBox_Properties.AcceptsTab = False
        Me.txt_button_text.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_button_text.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_button_text.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_button_text.TextBox_Properties.Enabled = True
        Me.txt_button_text.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_button_text.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_button_text.TextBox_Properties.MaximumValue = 999999
        Me.txt_button_text.TextBox_Properties.MaxLength = 20
        Me.txt_button_text.TextBox_Properties.MinimumValue = -999999
        Me.txt_button_text.TextBox_Properties.MultiLine = False
        Me.txt_button_text.TextBox_Properties.PasswordChar = Nothing
        Me.txt_button_text.TextBox_Properties.ReadOnly = False
        Me.txt_button_text.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_button_text.TextBox_Properties.TabStop = True
        Me.txt_button_text.TextBox_Properties.Text = ""
        Me.txt_button_text.TextBox_Properties.WordWrap = True
        Me.txt_button_text.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'grpbx_82
        '
        Me.grpbx_82.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpbx_82.Controls.Add(Me.txt_82_ultra_disinfect_secs)
        Me.grpbx_82.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbx_82.ForeColor = System.Drawing.Color.Black
        Me.grpbx_82.LineColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grpbx_82.Location = New System.Drawing.Point(242, 343)
        Me.grpbx_82.Name = "grpbx_82"
        Me.grpbx_82.Size = New System.Drawing.Size(245, 43)
        Me.grpbx_82.TabIndex = 5
        Me.grpbx_82.Text = "System 82 Settings"
        '
        'txt_82_ultra_disinfect_secs
        '
        Me.txt_82_ultra_disinfect_secs.AllowNegative = False
        Me.txt_82_ultra_disinfect_secs.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_82_ultra_disinfect_secs.ColorCursor = True
        Me.txt_82_ultra_disinfect_secs.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_82_ultra_disinfect_secs.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_82_ultra_disinfect_secs.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_82_ultra_disinfect_secs.Enabled = False
        Me.txt_82_ultra_disinfect_secs.Field_Name = "ultrasonics_disinfect_secs_82"
        Me.txt_82_ultra_disinfect_secs.GridBinding = Me.grd_profiles
        Me.txt_82_ultra_disinfect_secs.Label_On_Top = False
        Me.txt_82_ultra_disinfect_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_82_ultra_disinfect_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_82_ultra_disinfect_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_82_ultra_disinfect_secs.Label_Properties.Text = "Ultrasonics/disinfect (30 secs)"
        Me.txt_82_ultra_disinfect_secs.Label_Properties.Width = 180
        Me.txt_82_ultra_disinfect_secs.Location = New System.Drawing.Point(9, 17)
        Me.txt_82_ultra_disinfect_secs.Mandatory = False
        Me.txt_82_ultra_disinfect_secs.Name = "txt_82_ultra_disinfect_secs"
        Me.txt_82_ultra_disinfect_secs.Override_Modified = False
        Me.txt_82_ultra_disinfect_secs.SaveLoadOrder = 0
        Me.txt_82_ultra_disinfect_secs.Size = New System.Drawing.Size(231, 26)
        Me.txt_82_ultra_disinfect_secs.TabIndex = 0
        Me.txt_82_ultra_disinfect_secs.TabStop = False
        Me.txt_82_ultra_disinfect_secs.Tag = "dis_ultra_secs"
        Me.txt_82_ultra_disinfect_secs.Text = "DbA_TextBox1"
        Me.txt_82_ultra_disinfect_secs.TextBox_Properties.AcceptsReturn = False
        Me.txt_82_ultra_disinfect_secs.TextBox_Properties.AcceptsTab = False
        Me.txt_82_ultra_disinfect_secs.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_82_ultra_disinfect_secs.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_82_ultra_disinfect_secs.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_82_ultra_disinfect_secs.TextBox_Properties.Enabled = True
        Me.txt_82_ultra_disinfect_secs.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_82_ultra_disinfect_secs.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_82_ultra_disinfect_secs.TextBox_Properties.MaximumValue = 999999
        Me.txt_82_ultra_disinfect_secs.TextBox_Properties.MaxLength = 3
        Me.txt_82_ultra_disinfect_secs.TextBox_Properties.MinimumValue = -999999
        Me.txt_82_ultra_disinfect_secs.TextBox_Properties.MultiLine = False
        Me.txt_82_ultra_disinfect_secs.TextBox_Properties.PasswordChar = Nothing
        Me.txt_82_ultra_disinfect_secs.TextBox_Properties.ReadOnly = False
        Me.txt_82_ultra_disinfect_secs.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_82_ultra_disinfect_secs.TextBox_Properties.TabStop = True
        Me.txt_82_ultra_disinfect_secs.TextBox_Properties.Text = ""
        Me.txt_82_ultra_disinfect_secs.TextBox_Properties.WordWrap = True
        Me.txt_82_ultra_disinfect_secs.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'lbl_info
        '
        Me.lbl_info.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_info.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_info.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info.ForeColor = System.Drawing.Color.Black
        Me.lbl_info.Location = New System.Drawing.Point(9, 438)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(229, 39)
        Me.lbl_info.TabIndex = 27
        Me.lbl_info.Text = "Enter to select record.  Use tab/arrow keys to move around."
        Me.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_info.UseMnemonic = False
        '
        'lbl_F10
        '
        Me.lbl_F10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_F10.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_F10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_F10.ForeColor = System.Drawing.Color.Black
        Me.lbl_F10.Location = New System.Drawing.Point(634, 13)
        Me.lbl_F10.Name = "lbl_F10"
        Me.lbl_F10.Size = New System.Drawing.Size(136, 22)
        Me.lbl_F10.TabIndex = 28
        Me.lbl_F10.Text = "F10 - Access Main Grid"
        Me.lbl_F10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_F10.UseMnemonic = False
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
        Me.btn_delete.Location = New System.Drawing.Point(380, 3)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(104, 43)
        Me.btn_delete.TabIndex = 25
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
        Me.btn_cancel.Location = New System.Drawing.Point(253, 3)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(104, 43)
        Me.btn_cancel.TabIndex = 24
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
        Me.btn_save.Location = New System.Drawing.Point(128, 3)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(104, 43)
        Me.btn_save.TabIndex = 23
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
        Me.btn_new.Location = New System.Drawing.Point(3, 3)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(104, 43)
        Me.btn_new.TabIndex = 22
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
        Me.btn_close.Location = New System.Drawing.Point(507, 3)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(104, 43)
        Me.btn_close.TabIndex = 26
        Me.btn_close.TabStop = False
        Me.btn_close.Text = "Close"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'profile_setup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(785, 550)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "profile_setup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "wash_setup"
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_main.ResumeLayout(False)
        CType(Me.grd_subs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataRow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColumnManagerRow3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_cycles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataRowTemplate2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColumnManagerRow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_profiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataRowTemplate1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColumnManagerRow1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_info.ResumeLayout(False)
        Me.grpbx_83.ResumeLayout(False)
        Me.grpbx_81.ResumeLayout(False)
        Me.grpbx_temp.ResumeLayout(False)
        Me.grpbx_general.ResumeLayout(False)
        Me.grpbx_82.ResumeLayout(False)
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

            Case Keys.F6
                If btn_cycles.Enabled Then Call Process("CYCLES")

            Case Keys.F7
                If btn_sub_profiles.Enabled Then Call Process("SUB")

            Case Keys.F8
                Call Process("CLOSE")

            Case Keys.F10
                grd_profiles.Focus()
        End Select

        Select Case keyCode
            Case Keys.F1, Keys.F2, Keys.F3, Keys.F4, _
                 Keys.F6, Keys.F7, Keys.F8, Keys.F10
                Return True
        End Select
    End Function
#End Region

#Region " Declarations "
    Dim m_temp_flag As Boolean
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

    Private Sub btn_cycles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cycles.Click
        Call Process("CYCLES")
    End Sub

    Private Sub btn_sub_profiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sub_profiles.Click
        Call Process("SUB")
    End Sub
#End Region

#Region " Close Form "
    Private Sub close_form()
        g_framework.g_forms(1).Show()
        g_framework.g_forms(2) = Nothing
        Me.Close()
    End Sub
#End Region

#Region " Fill Grids "
    Private Sub Fill_Profiles_Grid()
        Dim p_sql As String                 ' String To Hold SQL Statement

        ' ==========================
        ' * Get Dataset To Fill Grid
        ' ==========================
        p_sql = "Select " & pnl_main.DataSettings.IDField & ", " & txt_profile_name.Field_Name & " As [Profile]" & _
                " FROM " & pnl_main.DataSettings.TableName & _
                " Order By " & txt_profile_name.Field_Name

        grd_profiles.SQL = p_sql

        'fill the grid
        Me.dba_fill_grid(grd_profiles)

        If grd_profiles.DataRows.Count = 0 Then
            pnl_main.Focus()
        Else
            ' =======================================
            ' * Position Row Selector To Current Item
            ' =======================================
            If Trim(pnl_main.RecordID) <> "" Then
                grd_profiles.FindInGrid(0, Trim(pnl_main.RecordID).Replace("{", "").Replace("}", ""), False)
            End If
        End If
    End Sub

    Public Sub Fill_Cycles_Grid(ByVal p_record_id As String)
        Dim p_sql As String                 ' String To Hold SQL Statement

        ' ==========================
        ' * Get Dataset To Fill Grid
        ' ==========================
        p_sql = "Select cycle_name As [Cycle] " & _
                "FROM profile_cycles PC1 " & _
                "INNER JOIN cycles C1 On C1.cycle_id = PC1.cycle_id "

        If Trim(p_record_id) <> "" Then
            p_sql &= "Where profile_id = '" & p_record_id & _
                     "' Order By order_num"
        Else
            p_sql &= "Where profile_cycle_id Is Null"
        End If

        grd_cycles.SQL = p_sql

        'fill the grid
        Me.dba_fill_grid(grd_cycles)
    End Sub

    Public Sub Fill_Subs_Grid(ByVal p_record_id As String)
        Dim p_sql As String                 ' String To Hold SQL Statement

        ' ==========================
        ' * Get Dataset To Fill Grid
        ' ==========================
        p_sql = "Select profile_name As [Sub Profile] " & _
                "FROM profile_subs PS1 " & _
                "INNER JOIN profile_maint P1 On P1.profile_id = PS1.sub_profile_id "

        If Trim(p_record_id) <> "" Then
            p_sql &= "Where main_profile_id = '" & p_record_id & _
                     "' Order By order_num"
        Else
            p_sql &= "Where profile_link_id Is Null"
        End If

        grd_subs.SQL = p_sql

        'fill the grid
        Me.dba_fill_grid(grd_subs)
    End Sub
#End Region

#Region " Form AfterFillScreen "
    Private Sub Form_AfterFillScreen(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.AfterFillScreen
        ' ----------------------------------
        ' * Fill Cycles For Profile Selected
        ' ----------------------------------
        Call Fill_Cycles_Grid(CType(grd_profiles.CurrentRow, Xceed.Grid.DataRow).Cells(0).GetDisplayText)
        Call Fill_Subs_Grid(CType(grd_profiles.CurrentRow, Xceed.Grid.DataRow).Cells(0).GetDisplayText)

        Call set_toolbar_buttons("T", "F", "F", "T")
    End Sub
#End Region

#Region " Form Load "
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim p_excludes(6) As dba_RemoveControls
        p_excludes(0).Control = btn_close
        p_excludes(1).Control = lbl_info
        p_excludes(2).Control = lbl_F10

        p_excludes(3).Control = btn_new
        p_excludes(4).Control = btn_save
        p_excludes(5).Control = btn_cancel
        p_excludes(6).Control = btn_delete

        Me.dba_init_form(pnl_main, True, p_excludes, g_is_internal)
        Me.g_focus_fld = txt_profile_name.txtbox
        Call size_screen(Me)

        ' ----------------------------
        ' * Disable Ultrasonics Sensor
        ' ----------------------------
        If Not g_us_usage Then
            txt_ultrasonics_abort.Visible = False
            txt_ultrasonics_abort.Field_Name = ""
            txt_ultrasonics_abort.Tag = ""

            grpbx_general.Height = 275
        End If

        'Load the values and labels
        Call LoadLabels()

        ' -----------
        ' * Set Grids
        ' -----------
        Call Fill_Profiles_Grid()

        grd_profiles.Insert_Header_Row("Profile List - Use Arrows to Select")
        grd_cycles.Insert_Header_Row("Profile Cycles")
        grd_subs.Insert_Header_Row("Sub Profiles")

        If grd_profiles.DataRows.Count > 0 Then
            grd_profiles.SelectedRows.Add(grd_profiles.DataRows(0))
            grd_profiles.CurrentRow = grd_profiles.DataRows(0)
        End If
    End Sub
#End Region

#Region " Pre-Delete Check "
    Private Function pre_delete() As Boolean
        Dim p_sql As String                 ' String To Hold SQL Statement
        Dim p_dataset As DataSet            ' Create DataSet Reference

        ' ========================
        ' * Delete Record Selected
        ' ========================

        ' Check That Item Was Selected
        If Trim(pnl_main.RecordID) = "" Then
            Exit Function
        End If

        ' ---------------------------------------
        ' * Check For Item ID In Related Table(s)
        ' ---------------------------------------
        p_sql = "Select Distinct profile_id " & _
                "From bay_settings " & _
                "Where profile_id = '" & Trim(pnl_main.RecordID) & "'"

        ' Get Dataset
        p_dataset = g_framework.Get_Data(p_sql)

        If p_dataset.Tables(0).Rows.Count > 0 Then
            Call message_box("Profile Information still exists in Bay Settings section.", 1, "Delete Cancelled")

            ' Dispose Of Dataset
            p_dataset.Dispose()

            Return False
            Exit Function
        End If

        ' Dispose Of Dataset
        p_dataset.Dispose()

        ' -----------------------
        ' * Delete Profiles Links
        ' -----------------------
        p_sql = "DELETE FROM profile_cycles " & _
                "WHERE profile_id = '" & pnl_main.RecordID & "'; "

        p_sql &= "DELETE FROM profile_subs " & _
                 "WHERE main_profile_id = '" & pnl_main.RecordID & "'; "

        p_sql &= "DELETE FROM profile_subs " & _
                 "WHERE sub_profile_id = '" & pnl_main.RecordID & "'; "

        Call g_framework.Execute_Query(p_sql)

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
                " Where " & txt_profile_name.Field_Name & " = " & return_parsed_single_quote_string(txt_profile_name.TextBox_Properties.Text)

        If Trim(pnl_main.RecordID) <> "" Then
            p_sql = p_sql & " And " & pnl_main.DataSettings.IDField & " <> '" & Trim(pnl_main.RecordID) & "'"
        End If

        p_data_set = g_framework.Get_Data(p_sql)

        ' ==================================
        ' * Check If Value Entered Was Found
        ' ==================================
        If p_data_set.Tables(0).Rows.Count > 0 Then
            ' =====================================
            ' * If Value Found And Currently In Use
            ' * Then Don't Allow User To Add Value
            ' =====================================
            Call message_box("The Profile Name entered already exists!", 1)

            ' Dispose of Dataset
            p_data_set.Dispose()
            Return False
            Exit Function
        End If

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        ' ==================================
        ' * Check Entry Data Versus Defaults
        ' ==================================
        Dim p_ctrl As Control
        Dim p_textbox As DBA.Library.DBA_TextBox
        Dim p_invalid As String = ""

        ' ------------------------
        ' * Check General Settings
        ' ------------------------
        For Each p_ctrl In grpbx_general.Controls
            If TypeOf p_ctrl Is DBA.Library.DBA_TextBox Then
                p_textbox = p_ctrl
                If Trim(p_textbox.Tag) <> "" And Trim(p_textbox.TextBox_Properties.Text) <> "" Then
                    If Trim(p_textbox.TextBox_Properties.Text) < GetMinimum(Trim(p_textbox.Tag)) Then
                        p_invalid &= p_textbox.Label_Properties.Text & vbCrLf
                    End If
                End If
            End If
        Next

        ' ----------------------------
        ' * Check Temperature Settings
        ' ----------------------------
        For Each p_ctrl In grpbx_temp.Controls
            If TypeOf p_ctrl Is DBA.Library.DBA_TextBox Then
                p_textbox = p_ctrl
                If Trim(p_textbox.Tag) <> "" And Trim(p_textbox.TextBox_Properties.Text) <> "" Then
                    If Trim(p_textbox.TextBox_Properties.Text) < GetMinimum(Trim(p_textbox.Tag)) Then
                        p_invalid &= p_textbox.Label_Properties.Text & vbCrLf
                    End If
                End If
            End If
        Next

        ' --------------------------
        ' * Check System 81 Settings
        ' --------------------------
        For Each p_ctrl In grpbx_81.Controls
            If TypeOf p_ctrl Is DBA.Library.DBA_TextBox Then
                p_textbox = p_ctrl
                If Trim(p_textbox.Tag) <> "" And Trim(p_textbox.TextBox_Properties.Text) <> "" Then
                    If Trim(p_textbox.TextBox_Properties.Text) < GetMinimum(Trim(p_textbox.Tag)) Then
                        p_invalid &= p_textbox.Label_Properties.Text & vbCrLf
                    End If
                End If
            End If
        Next

        ' --------------------------
        ' * Check System 82 Settings
        ' --------------------------
        For Each p_ctrl In grpbx_82.Controls
            If TypeOf p_ctrl Is DBA.Library.DBA_TextBox Then
                p_textbox = p_ctrl
                If Trim(p_textbox.Tag) <> "" And Trim(p_textbox.TextBox_Properties.Text) <> "" Then
                    If Trim(p_textbox.TextBox_Properties.Text) < GetMinimum(Trim(p_textbox.Tag)) Then
                        p_invalid &= p_textbox.Label_Properties.Text & vbCrLf
                    End If
                End If
            End If
        Next

        ' --------------------------
        ' * Check System 83 Settings
        ' --------------------------
        For Each p_ctrl In grpbx_83.Controls
            If TypeOf p_ctrl Is DBA.Library.DBA_TextBox Then
                p_textbox = p_ctrl
                If Trim(p_textbox.Tag) <> "" And Trim(p_textbox.TextBox_Properties.Text) <> "" Then
                    If Trim(p_textbox.TextBox_Properties.Text) < GetMinimum(Trim(p_textbox.Tag)) Then
                        p_invalid &= p_textbox.Label_Properties.Text & vbCrLf
                    End If
                End If
            End If
        Next
        If Trim(p_invalid) <> "" Then
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Call message_box("Value(s) entered must be greater than or equal to the default." & vbCrLf & vbCrLf & _
                "Check Default(s): " & vbCrLf & vbCrLf & p_invalid, 1)

            Return False
            Exit Function
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default

        ' Dispose of Dataset
        p_data_set.Dispose()

        For p_x As Integer = 0 To g_bay_count - 1
            g_CUSMain.Machines(p_x).Setup = False
        Next

        Return True
    End Function
#End Region

#Region " Load Labels "
    Private Sub LoadLabels()
        Dim p_sql As String
        Dim p_dataset As DataSet
        Dim p_db_row As DataRow

        Dim varName As String
        Dim override As String
        Dim default_val As String
        Dim caption As String

        ' ---------------------------
        ' * Get Overrides Information
        ' ---------------------------
        p_sql = "SELECT * FROM minimum_overrides"
        p_dataset = g_framework.Get_Data(p_sql)

        For Each p_db_row In p_dataset.Tables(0).Rows
            varName = p_db_row("var_name").ToString
            override = p_db_row("override").ToString
            default_val = p_db_row("default_value").ToString
            caption = p_db_row("DisplayText").ToString

            Call LoadTextbox(varName, caption, override, default_val)
        Next

        ' Dispose of Dataset
        p_dataset.Dispose()
    End Sub
#End Region

#Region " Load Textbox "
    Private Sub LoadTextbox(ByVal varName As String, ByVal caption As String, ByVal Override As String, ByVal Default_val As String)
        Dim p_filled As Boolean = False
        Dim pVal As Integer

        'General
        For Each pTxt As DBA.Library.DBA_TextBox In grpbx_general.Controls
            If UCase(pTxt.Tag) = UCase(varName) Then
                pVal = IIf(Trim(Override) = "", Default_val, Override)

                Select Case UCase(pTxt.Tag)
                    Case "DISINFECT_SECS"
                        pTxt.Label_Properties.Text = caption & " (" & pVal & " " & IIf(pVal > 1, "mins", "min") & ")"

                    Case "FLOAT_ABORT_DELAY_SECS"
                        pTxt.Label_Properties.Text = caption & " (" & pVal & " " & IIf(pVal > 1, "hrs", "hr") & ")"

                    Case Else
                        pTxt.Label_Properties.Text = caption & " (" & pVal & " " & IIf(pVal > 1, "secs", "sec") & ")"
                End Select

                p_filled = True
                Exit For
            End If
        Next
        If p_filled Then Exit Sub

        'Temperature
        For Each pTxt As DBA.Library.DBA_TextBox In grpbx_temp.Controls
            If UCase(pTxt.Tag) = UCase(varName) Then
                pTxt.Label_Properties.Text = caption & " (" & IIf(Trim(Override) = "", Default_val, Override) & " C)"

                p_filled = True
                Exit For
            End If
        Next
        If p_filled Then Exit Sub

        '81
        For Each pTxt As DBA.Library.DBA_TextBox In grpbx_81.Controls
            If UCase(pTxt.Tag) = UCase(varName) Then
                pVal = IIf(Trim(Override) = "", Default_val, Override)
                pTxt.Label_Properties.Text = caption & " (" & pVal & " " & IIf(pVal > 1, "secs", "sec") & ")"

                p_filled = True
                Exit For
            End If
        Next
        If p_filled Then Exit Sub

        '82
        For Each pTxt As DBA.Library.DBA_TextBox In grpbx_82.Controls
            If UCase(pTxt.Tag) = UCase(varName) Then
                pVal = IIf(Trim(Override) = "", Default_val, Override)
                pTxt.Label_Properties.Text = caption & " (" & pVal & " " & IIf(pVal > 1, "secs", "sec") & ")"

                p_filled = True
                Exit For
            End If
        Next
        If p_filled Then Exit Sub

        '83
        For Each pTxt As DBA.Library.DBA_TextBox In grpbx_83.Controls
            If UCase(pTxt.Tag) = UCase(varName) Then
                pVal = IIf(Trim(Override) = "", Default_val, Override)
                pTxt.Label_Properties.Text = caption & " (" & pVal & " " & IIf(pVal > 1, "secs", "sec") & ")"

                p_filled = True
                Exit For
            End If
        Next
        If p_filled Then Exit Sub
    End Sub
#End Region

#Region " Process "
    Private Sub Process(ByVal p_type As String)
        If g_fill_screen Then Exit Sub

        Select Case UCase(p_type)
            Case "NEW"
                dba_new_record(pnl_main)
                grd_cycles.DataSource = Nothing
                grd_subs.DataSource = Nothing

                Call set_toolbar_buttons("F", "T", "T", "F")
                btn_cycles.Enabled = False
                btn_sub_profiles.Enabled = False

            Case "SAVE"
                If pre_save() = False Then Exit Sub

                ' -----------------------------
                ' * Reset System Data Overrides
                ' -----------------------------
                Call reset_system_data_overrides()

                If dba_save_record(pnl_main) Then
                    Call Fill_Profiles_Grid()

                    Call set_toolbar_buttons("T", "F", "F", "T")
                    btn_cycles.Enabled = True
                    btn_sub_profiles.Enabled = True

                    ' Reload Profile Settings
                    For p_x As Integer = 0 To g_bay_count - 1
                        g_CUSMain.Machines(p_x).Setup = False
                    Next

                    ' ------------------------------
                    ' * Check Temperature Monitoring
                    ' ------------------------------
                    If m_temp_flag Then
                        m_temp_flag = False
                        Call Check_Machines_Temp_Monitoring()
                    End If

                    Me.g_focus_fld.Focus()
                End If

            Case "CANCEL"
                dba_cancel_record(pnl_main)

                grd_profiles.Enabled = True
                If pnl_main.RecordID <> "" Then
                    Call set_toolbar_buttons("T", "F", "F", "T")
                    Me.g_focus_fld.Focus()
                Else
                    Call set_toolbar_buttons("T", "F", "F", "F")
                    If grd_profiles.DataRows.Count > 0 Then
                        grd_profiles.SelectedRows.Add(grd_profiles.DataRows(0))
                        grd_profiles.CurrentRow = grd_profiles.DataRows(0)
                        grd_profiles.Focus()
                    End If
                End If

                If grd_profiles.DataRows.Count < 1 Then
                    pnl_main.Focus()
                End If

            Case "DELETE"
                If pre_delete() = False Then Exit Sub

                If dba_delete_record(pnl_main) Then
                    ' ------------
                    ' * Set Screen
                    ' ------------
                    Call Fill_Profiles_Grid()
                    grd_cycles.DataSource = Nothing
                    grd_subs.DataSource = Nothing

                    Call set_toolbar_buttons("T", "F", "F", "F")
                End If

                If grd_profiles.DataRows.Count > 0 Then
                    grd_profiles.SelectedRows.Add(grd_profiles.DataRows(0))
                    grd_profiles.CurrentRow = grd_profiles.DataRows(0)
                    grd_profiles.Focus()
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

            Case "CYCLES"
                g_pass_str = pnl_main.RecordID
                g_pass_str2 = txt_profile_name.TextBox_Properties.Text

                g_framework.g_forms(3) = New profile_cycle_maint(g_framework.g_db_name)
                g_framework.g_forms(3).MdiParent = g_mdi_form
                g_framework.g_forms(3).Show()

                g_framework.g_forms(2).Hide()

            Case "SUB"
                g_pass_str = pnl_main.RecordID
                g_pass_str2 = txt_profile_name.TextBox_Properties.Text

                g_framework.g_forms(3) = New profile_subs_maint(g_framework.g_db_name)
                g_framework.g_forms(3).MdiParent = g_mdi_form
                g_framework.g_forms(3).Show()

                g_framework.g_forms(2).Hide()
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

#Region " Grid Events "
    Private Sub grd_profiles_TabPressed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_profiles.TabPressed
        Me.g_focus_fld.Focus()
    End Sub

    Private Sub grd_cycles_AfterRowSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_cycles.AfterRowSelected
        grd_cycles.CancelActivate = True
    End Sub

    Private Sub grd_subs_AfterRowSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_subs.AfterRowSelected
        grd_subs.CancelActivate = True
    End Sub
#End Region

#Region " Textbox Events "

#Region " TextChanged "
    Private Sub Main_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_profile_name.TextBox_TextChanged, txt_button_text.TextBox_TextChanged

        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("", "T", "T", "")
    End Sub

    Private Sub General_Settings_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_wash_secs.TextBox_TextChanged, txt_wash_rinse_secs.TextBox_TextChanged, txt_chemical_immersion.TextBox_TextChanged, txt_lubrication.TextBox_TextChanged, txt_drain1.TextBox_TextChanged, txt_drain2.TextBox_TextChanged, txt_warwick_delay.TextBox_TextChanged, txt_float_delay.TextBox_TextChanged, txt_pressure_start.TextBox_TextChanged, txt_pressure_error.TextBox_TextChanged, txt_safety_delay.TextBox_TextChanged, txt_ultrasonics_abort.TextBox_TextChanged

        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("", "T", "T", "")
    End Sub

    Private Sub Temperature_Settings_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_heat_pad_off.TextBox_TextChanged, txt_heat_pad_on.TextBox_TextChanged, txt_min_start_temp.TextBox_TextChanged, txt_max_abort_temp.TextBox_TextChanged

        If Me.g_fill_screen Then Exit Sub

        Call set_toolbar_buttons("", "T", "T", "")
        m_temp_flag = True
    End Sub

    Private Sub Sys_81_82_Settings_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_81_rinse_delay_secs.TextBox_TextChanged, txt_81_rinse_secs.TextBox_TextChanged, txt_81_detergent_secs.TextBox_TextChanged, txt_81_enzyme_secs.TextBox_TextChanged, txt_81_soak_secs.TextBox_TextChanged, txt_81_prewash_secs.TextBox_TextChanged, txt_81_reservoir_fill_secs.TextBox_TextChanged, txt_82_ultra_disinfect_secs.TextBox_TextChanged

        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("", "T", "T", "")
    End Sub

    Private Sub Sys_83_Settings_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_83_detergent_secs.TextBox_TextChanged, txt_83_dry_cool_secs.TextBox_TextChanged, txt_83_dry_heat_secs.TextBox_TextChanged

        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("", "T", "T", "")
    End Sub
#End Region

#End Region

#End Region

End Class
