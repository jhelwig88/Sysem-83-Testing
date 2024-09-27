Public Class minimum_overrides
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
    Friend WithEvents btn_cancel As DBA.Library.DBA_Button
    Friend WithEvents btn_save As DBA.Library.DBA_Button
    Friend WithEvents btn_close As DBA.Library.DBA_Button
    Friend WithEvents pnl_info As DBA.Library.DBA_Panel
    Friend WithEvents grpbx_83 As DBA.Library.DBA_StyleGroupBox
    Friend WithEvents txt_83_dry_heat_secs As DBA.Library.DBA_TextBox
    Friend WithEvents txt_83_dry_cool_secs As DBA.Library.DBA_TextBox
    Friend WithEvents txt_83_detergent_secs As DBA.Library.DBA_TextBox
    Friend WithEvents grpbx_81 As DBA.Library.DBA_StyleGroupBox
    Friend WithEvents txt_81_prewash_secs As DBA.Library.DBA_TextBox
    Friend WithEvents txt_81_reservoir_fill_secs As DBA.Library.DBA_TextBox
    Friend WithEvents txt_81_soak_secs As DBA.Library.DBA_TextBox
    Friend WithEvents txt_81_detergent_secs As DBA.Library.DBA_TextBox
    Friend WithEvents txt_81_enzyme_secs As DBA.Library.DBA_TextBox
    Friend WithEvents txt_81_rinse_secs As DBA.Library.DBA_TextBox
    Friend WithEvents txt_81_rinse_delay_secs As DBA.Library.DBA_TextBox
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
    Friend WithEvents grpbx_82 As DBA.Library.DBA_StyleGroupBox
    Friend WithEvents txt_82_ultra_disinfect_secs As DBA.Library.DBA_TextBox
    Friend WithEvents grpbx_temp As DBA.Library.DBA_StyleGroupBox
    Friend WithEvents txt_min_start_temp As DBA.Library.DBA_TextBox
    Friend WithEvents txt_max_abort_temp As DBA.Library.DBA_TextBox
    Friend WithEvents txt_heat_pad_on As DBA.Library.DBA_TextBox
    Friend WithEvents txt_heat_pad_off As DBA.Library.DBA_TextBox
    Friend WithEvents grpbx_delays As DBA.Library.DBA_StyleGroupBox
    Friend WithEvents txt_float_abort As DBA.Library.DBA_TextBox
    Friend WithEvents txt_drain_float As DBA.Library.DBA_TextBox
    Friend WithEvents txt_drain_flow As DBA.Library.DBA_TextBox
    Friend WithEvents txt_fill_float As DBA.Library.DBA_TextBox
    Friend WithEvents txt_fill_flow As DBA.Library.DBA_TextBox
    Friend WithEvents btn_reset As DBA.Library.DBA_Button
    Friend WithEvents grpbx_england_aborts As DBA.Library.DBA_StyleGroupBox
    Friend WithEvents txt_drain_max_abort As DBA.Library.DBA_TextBox
    Friend WithEvents txt_drain_min_abort As DBA.Library.DBA_TextBox
    Friend WithEvents txt_fill_max_abort As DBA.Library.DBA_TextBox
    Friend WithEvents txt_ultrasonics_abort As DBA.Library.DBA_TextBox
    Friend WithEvents txt_fill_min_abort As DBA.Library.DBA_TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(minimum_overrides))
        Me.pnl_main = New DBA.Library.DBA_Panel
        Me.btn_reset = New DBA.Library.DBA_Button(Me.components)
        Me.pnl_info = New DBA.Library.DBA_Panel
        Me.grpbx_england_aborts = New DBA.Library.DBA_StyleGroupBox
        Me.txt_drain_max_abort = New DBA.Library.DBA_TextBox
        Me.txt_drain_min_abort = New DBA.Library.DBA_TextBox
        Me.txt_fill_max_abort = New DBA.Library.DBA_TextBox
        Me.txt_fill_min_abort = New DBA.Library.DBA_TextBox
        Me.grpbx_delays = New DBA.Library.DBA_StyleGroupBox
        Me.txt_drain_float = New DBA.Library.DBA_TextBox
        Me.txt_drain_flow = New DBA.Library.DBA_TextBox
        Me.txt_fill_float = New DBA.Library.DBA_TextBox
        Me.txt_fill_flow = New DBA.Library.DBA_TextBox
        Me.grpbx_83 = New DBA.Library.DBA_StyleGroupBox
        Me.txt_83_dry_heat_secs = New DBA.Library.DBA_TextBox
        Me.txt_83_dry_cool_secs = New DBA.Library.DBA_TextBox
        Me.txt_83_detergent_secs = New DBA.Library.DBA_TextBox
        Me.grpbx_81 = New DBA.Library.DBA_StyleGroupBox
        Me.txt_81_reservoir_fill_secs = New DBA.Library.DBA_TextBox
        Me.txt_81_prewash_secs = New DBA.Library.DBA_TextBox
        Me.txt_81_soak_secs = New DBA.Library.DBA_TextBox
        Me.txt_81_enzyme_secs = New DBA.Library.DBA_TextBox
        Me.txt_81_detergent_secs = New DBA.Library.DBA_TextBox
        Me.txt_81_rinse_secs = New DBA.Library.DBA_TextBox
        Me.txt_81_rinse_delay_secs = New DBA.Library.DBA_TextBox
        Me.grpbx_temp = New DBA.Library.DBA_StyleGroupBox
        Me.txt_max_abort_temp = New DBA.Library.DBA_TextBox
        Me.txt_min_start_temp = New DBA.Library.DBA_TextBox
        Me.txt_heat_pad_on = New DBA.Library.DBA_TextBox
        Me.txt_heat_pad_off = New DBA.Library.DBA_TextBox
        Me.grpbx_general = New DBA.Library.DBA_StyleGroupBox
        Me.txt_ultrasonics_abort = New DBA.Library.DBA_TextBox
        Me.txt_float_abort = New DBA.Library.DBA_TextBox
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
        Me.grpbx_82 = New DBA.Library.DBA_StyleGroupBox
        Me.txt_82_ultra_disinfect_secs = New DBA.Library.DBA_TextBox
        Me.btn_cancel = New DBA.Library.DBA_Button(Me.components)
        Me.btn_save = New DBA.Library.DBA_Button(Me.components)
        Me.btn_close = New DBA.Library.DBA_Button(Me.components)
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_main.SuspendLayout()
        Me.pnl_info.SuspendLayout()
        Me.grpbx_england_aborts.SuspendLayout()
        Me.grpbx_delays.SuspendLayout()
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
        Me.pnl_main.Controls.Add(Me.btn_reset)
        Me.pnl_main.Controls.Add(Me.pnl_info)
        Me.pnl_main.Controls.Add(Me.btn_cancel)
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
        Me.pnl_main.Size = New System.Drawing.Size(750, 495)
        Me.pnl_main.TabIndex = 0
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_reset.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_reset.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_reset.DisplayText = ""
        Me.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_reset.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset.ForeColor = System.Drawing.Color.Black
        Me.btn_reset.Image = CType(resources.GetObject("btn_reset.Image"), System.Drawing.Image)
        Me.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reset.Location = New System.Drawing.Point(245, -9)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(160, 43)
        Me.btn_reset.TabIndex = 34
        Me.btn_reset.TabStop = False
        Me.btn_reset.Text = "Reset Defaults"
        Me.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'pnl_info
        '
        Me.pnl_info.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnl_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_info.Controls.Add(Me.grpbx_england_aborts)
        Me.pnl_info.Controls.Add(Me.grpbx_delays)
        Me.pnl_info.Controls.Add(Me.grpbx_83)
        Me.pnl_info.Controls.Add(Me.grpbx_81)
        Me.pnl_info.Controls.Add(Me.grpbx_temp)
        Me.pnl_info.Controls.Add(Me.grpbx_general)
        Me.pnl_info.Controls.Add(Me.grpbx_82)
        Me.pnl_info.DataSettings.IDField = Nothing
        Me.pnl_info.DataSettings.JoinData = Nothing
        Me.pnl_info.DataSettings.LinkField = Nothing
        Me.pnl_info.DataSettings.TableName = Nothing
        Me.pnl_info.Gradient = False
        Me.pnl_info.Location = New System.Drawing.Point(5, 38)
        Me.pnl_info.Name = "pnl_info"
        Me.pnl_info.RecordID = Nothing
        Me.pnl_info.Saved = False
        Me.pnl_info.Size = New System.Drawing.Size(739, 448)
        Me.pnl_info.TabIndex = 33
        '
        'grpbx_england_aborts
        '
        Me.grpbx_england_aborts.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpbx_england_aborts.Controls.Add(Me.txt_drain_max_abort)
        Me.grpbx_england_aborts.Controls.Add(Me.txt_drain_min_abort)
        Me.grpbx_england_aborts.Controls.Add(Me.txt_fill_max_abort)
        Me.grpbx_england_aborts.Controls.Add(Me.txt_fill_min_abort)
        Me.grpbx_england_aborts.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbx_england_aborts.ForeColor = System.Drawing.Color.Black
        Me.grpbx_england_aborts.LineColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grpbx_england_aborts.Location = New System.Drawing.Point(509, 320)
        Me.grpbx_england_aborts.Name = "grpbx_england_aborts"
        Me.grpbx_england_aborts.Size = New System.Drawing.Size(223, 120)
        Me.grpbx_england_aborts.TabIndex = 6
        Me.grpbx_england_aborts.Text = "England Aborts"
        '
        'txt_drain_max_abort
        '
        Me.txt_drain_max_abort.AllowNegative = False
        Me.txt_drain_max_abort.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_drain_max_abort.ColorCursor = True
        Me.txt_drain_max_abort.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_drain_max_abort.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_drain_max_abort.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_drain_max_abort.Field_Name = ""
        Me.txt_drain_max_abort.GridBinding = Nothing
        Me.txt_drain_max_abort.Label_On_Top = False
        Me.txt_drain_max_abort.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_drain_max_abort.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_drain_max_abort.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_drain_max_abort.Label_Properties.Text = "Drain Max (10 mins)"
        Me.txt_drain_max_abort.Label_Properties.Width = 150
        Me.txt_drain_max_abort.Location = New System.Drawing.Point(12, 89)
        Me.txt_drain_max_abort.Mandatory = False
        Me.txt_drain_max_abort.Name = "txt_drain_max_abort"
        Me.txt_drain_max_abort.Override_Modified = False
        Me.txt_drain_max_abort.SaveLoadOrder = 0
        Me.txt_drain_max_abort.Size = New System.Drawing.Size(201, 26)
        Me.txt_drain_max_abort.TabIndex = 3
        Me.txt_drain_max_abort.TabStop = False
        Me.txt_drain_max_abort.Tag = "drain_max_abort_secs"
        Me.txt_drain_max_abort.Text = "DbA_TextBox1"
        Me.txt_drain_max_abort.TextBox_Properties.AcceptsReturn = False
        Me.txt_drain_max_abort.TextBox_Properties.AcceptsTab = False
        Me.txt_drain_max_abort.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_drain_max_abort.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_drain_max_abort.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_drain_max_abort.TextBox_Properties.Enabled = True
        Me.txt_drain_max_abort.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_drain_max_abort.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_drain_max_abort.TextBox_Properties.MaximumValue = 999999
        Me.txt_drain_max_abort.TextBox_Properties.MaxLength = 3
        Me.txt_drain_max_abort.TextBox_Properties.MinimumValue = -999999
        Me.txt_drain_max_abort.TextBox_Properties.MultiLine = False
        Me.txt_drain_max_abort.TextBox_Properties.PasswordChar = Nothing
        Me.txt_drain_max_abort.TextBox_Properties.ReadOnly = False
        Me.txt_drain_max_abort.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_drain_max_abort.TextBox_Properties.TabStop = True
        Me.txt_drain_max_abort.TextBox_Properties.Text = ""
        Me.txt_drain_max_abort.TextBox_Properties.WordWrap = True
        Me.txt_drain_max_abort.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_drain_min_abort
        '
        Me.txt_drain_min_abort.AllowNegative = False
        Me.txt_drain_min_abort.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_drain_min_abort.ColorCursor = True
        Me.txt_drain_min_abort.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_drain_min_abort.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_drain_min_abort.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_drain_min_abort.Field_Name = ""
        Me.txt_drain_min_abort.GridBinding = Nothing
        Me.txt_drain_min_abort.Label_On_Top = False
        Me.txt_drain_min_abort.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_drain_min_abort.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_drain_min_abort.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_drain_min_abort.Label_Properties.Text = "Drain Min (30 secs)"
        Me.txt_drain_min_abort.Label_Properties.Width = 150
        Me.txt_drain_min_abort.Location = New System.Drawing.Point(12, 66)
        Me.txt_drain_min_abort.Mandatory = False
        Me.txt_drain_min_abort.Name = "txt_drain_min_abort"
        Me.txt_drain_min_abort.Override_Modified = False
        Me.txt_drain_min_abort.SaveLoadOrder = 0
        Me.txt_drain_min_abort.Size = New System.Drawing.Size(201, 26)
        Me.txt_drain_min_abort.TabIndex = 2
        Me.txt_drain_min_abort.TabStop = False
        Me.txt_drain_min_abort.Tag = "drain_min_abort_secs"
        Me.txt_drain_min_abort.Text = "DbA_TextBox1"
        Me.txt_drain_min_abort.TextBox_Properties.AcceptsReturn = False
        Me.txt_drain_min_abort.TextBox_Properties.AcceptsTab = False
        Me.txt_drain_min_abort.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_drain_min_abort.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_drain_min_abort.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_drain_min_abort.TextBox_Properties.Enabled = True
        Me.txt_drain_min_abort.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_drain_min_abort.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_drain_min_abort.TextBox_Properties.MaximumValue = 999999
        Me.txt_drain_min_abort.TextBox_Properties.MaxLength = 3
        Me.txt_drain_min_abort.TextBox_Properties.MinimumValue = -999999
        Me.txt_drain_min_abort.TextBox_Properties.MultiLine = False
        Me.txt_drain_min_abort.TextBox_Properties.PasswordChar = Nothing
        Me.txt_drain_min_abort.TextBox_Properties.ReadOnly = False
        Me.txt_drain_min_abort.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_drain_min_abort.TextBox_Properties.TabStop = True
        Me.txt_drain_min_abort.TextBox_Properties.Text = ""
        Me.txt_drain_min_abort.TextBox_Properties.WordWrap = True
        Me.txt_drain_min_abort.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_fill_max_abort
        '
        Me.txt_fill_max_abort.AllowNegative = False
        Me.txt_fill_max_abort.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_fill_max_abort.ColorCursor = True
        Me.txt_fill_max_abort.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_fill_max_abort.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_fill_max_abort.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_fill_max_abort.Field_Name = ""
        Me.txt_fill_max_abort.GridBinding = Nothing
        Me.txt_fill_max_abort.Label_On_Top = False
        Me.txt_fill_max_abort.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_fill_max_abort.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fill_max_abort.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_fill_max_abort.Label_Properties.Text = "Fill Max (10 mins)"
        Me.txt_fill_max_abort.Label_Properties.Width = 150
        Me.txt_fill_max_abort.Location = New System.Drawing.Point(12, 43)
        Me.txt_fill_max_abort.Mandatory = False
        Me.txt_fill_max_abort.Name = "txt_fill_max_abort"
        Me.txt_fill_max_abort.Override_Modified = False
        Me.txt_fill_max_abort.SaveLoadOrder = 0
        Me.txt_fill_max_abort.Size = New System.Drawing.Size(201, 26)
        Me.txt_fill_max_abort.TabIndex = 1
        Me.txt_fill_max_abort.TabStop = False
        Me.txt_fill_max_abort.Tag = "fill_max_abort_secs"
        Me.txt_fill_max_abort.Text = "DbA_TextBox1"
        Me.txt_fill_max_abort.TextBox_Properties.AcceptsReturn = False
        Me.txt_fill_max_abort.TextBox_Properties.AcceptsTab = False
        Me.txt_fill_max_abort.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_fill_max_abort.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fill_max_abort.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_fill_max_abort.TextBox_Properties.Enabled = True
        Me.txt_fill_max_abort.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fill_max_abort.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_fill_max_abort.TextBox_Properties.MaximumValue = 999999
        Me.txt_fill_max_abort.TextBox_Properties.MaxLength = 3
        Me.txt_fill_max_abort.TextBox_Properties.MinimumValue = -999999
        Me.txt_fill_max_abort.TextBox_Properties.MultiLine = False
        Me.txt_fill_max_abort.TextBox_Properties.PasswordChar = Nothing
        Me.txt_fill_max_abort.TextBox_Properties.ReadOnly = False
        Me.txt_fill_max_abort.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_fill_max_abort.TextBox_Properties.TabStop = True
        Me.txt_fill_max_abort.TextBox_Properties.Text = ""
        Me.txt_fill_max_abort.TextBox_Properties.WordWrap = True
        Me.txt_fill_max_abort.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_fill_min_abort
        '
        Me.txt_fill_min_abort.AllowNegative = False
        Me.txt_fill_min_abort.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_fill_min_abort.ColorCursor = True
        Me.txt_fill_min_abort.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_fill_min_abort.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_fill_min_abort.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_fill_min_abort.Field_Name = ""
        Me.txt_fill_min_abort.GridBinding = Nothing
        Me.txt_fill_min_abort.Label_On_Top = False
        Me.txt_fill_min_abort.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_fill_min_abort.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fill_min_abort.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_fill_min_abort.Label_Properties.Text = "Fill Min (30 secs)"
        Me.txt_fill_min_abort.Label_Properties.Width = 150
        Me.txt_fill_min_abort.Location = New System.Drawing.Point(12, 20)
        Me.txt_fill_min_abort.Mandatory = False
        Me.txt_fill_min_abort.Name = "txt_fill_min_abort"
        Me.txt_fill_min_abort.Override_Modified = False
        Me.txt_fill_min_abort.SaveLoadOrder = 0
        Me.txt_fill_min_abort.Size = New System.Drawing.Size(201, 26)
        Me.txt_fill_min_abort.TabIndex = 0
        Me.txt_fill_min_abort.TabStop = False
        Me.txt_fill_min_abort.Tag = "fill_min_abort_secs"
        Me.txt_fill_min_abort.Text = "DbA_TextBox1"
        Me.txt_fill_min_abort.TextBox_Properties.AcceptsReturn = False
        Me.txt_fill_min_abort.TextBox_Properties.AcceptsTab = False
        Me.txt_fill_min_abort.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_fill_min_abort.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fill_min_abort.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_fill_min_abort.TextBox_Properties.Enabled = True
        Me.txt_fill_min_abort.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fill_min_abort.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_fill_min_abort.TextBox_Properties.MaximumValue = 999999
        Me.txt_fill_min_abort.TextBox_Properties.MaxLength = 3
        Me.txt_fill_min_abort.TextBox_Properties.MinimumValue = -999999
        Me.txt_fill_min_abort.TextBox_Properties.MultiLine = False
        Me.txt_fill_min_abort.TextBox_Properties.PasswordChar = Nothing
        Me.txt_fill_min_abort.TextBox_Properties.ReadOnly = False
        Me.txt_fill_min_abort.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_fill_min_abort.TextBox_Properties.TabStop = True
        Me.txt_fill_min_abort.TextBox_Properties.Text = ""
        Me.txt_fill_min_abort.TextBox_Properties.WordWrap = True
        Me.txt_fill_min_abort.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'grpbx_delays
        '
        Me.grpbx_delays.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpbx_delays.Controls.Add(Me.txt_drain_float)
        Me.grpbx_delays.Controls.Add(Me.txt_drain_flow)
        Me.grpbx_delays.Controls.Add(Me.txt_fill_float)
        Me.grpbx_delays.Controls.Add(Me.txt_fill_flow)
        Me.grpbx_delays.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbx_delays.ForeColor = System.Drawing.Color.Black
        Me.grpbx_delays.LineColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grpbx_delays.Location = New System.Drawing.Point(5, 324)
        Me.grpbx_delays.Name = "grpbx_delays"
        Me.grpbx_delays.Size = New System.Drawing.Size(240, 116)
        Me.grpbx_delays.TabIndex = 1
        Me.grpbx_delays.Text = "Demo Mode Delays"
        '
        'txt_drain_float
        '
        Me.txt_drain_float.AllowNegative = False
        Me.txt_drain_float.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_drain_float.ColorCursor = True
        Me.txt_drain_float.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_drain_float.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_drain_float.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_drain_float.Field_Name = ""
        Me.txt_drain_float.GridBinding = Nothing
        Me.txt_drain_float.Label_On_Top = False
        Me.txt_drain_float.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_drain_float.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_drain_float.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_drain_float.Label_Properties.Text = "Drain Float (10 secs)"
        Me.txt_drain_float.Label_Properties.Width = 150
        Me.txt_drain_float.Location = New System.Drawing.Point(30, 89)
        Me.txt_drain_float.Mandatory = False
        Me.txt_drain_float.Name = "txt_drain_float"
        Me.txt_drain_float.Override_Modified = False
        Me.txt_drain_float.SaveLoadOrder = 0
        Me.txt_drain_float.Size = New System.Drawing.Size(201, 26)
        Me.txt_drain_float.TabIndex = 3
        Me.txt_drain_float.TabStop = False
        Me.txt_drain_float.Tag = "drain_float_secs"
        Me.txt_drain_float.Text = "DbA_TextBox1"
        Me.txt_drain_float.TextBox_Properties.AcceptsReturn = False
        Me.txt_drain_float.TextBox_Properties.AcceptsTab = False
        Me.txt_drain_float.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_drain_float.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_drain_float.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_drain_float.TextBox_Properties.Enabled = True
        Me.txt_drain_float.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_drain_float.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_drain_float.TextBox_Properties.MaximumValue = 999999
        Me.txt_drain_float.TextBox_Properties.MaxLength = 3
        Me.txt_drain_float.TextBox_Properties.MinimumValue = -999999
        Me.txt_drain_float.TextBox_Properties.MultiLine = False
        Me.txt_drain_float.TextBox_Properties.PasswordChar = Nothing
        Me.txt_drain_float.TextBox_Properties.ReadOnly = False
        Me.txt_drain_float.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_drain_float.TextBox_Properties.TabStop = True
        Me.txt_drain_float.TextBox_Properties.Text = ""
        Me.txt_drain_float.TextBox_Properties.WordWrap = True
        Me.txt_drain_float.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_drain_flow
        '
        Me.txt_drain_flow.AllowNegative = False
        Me.txt_drain_flow.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_drain_flow.ColorCursor = True
        Me.txt_drain_flow.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_drain_flow.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_drain_flow.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_drain_flow.Field_Name = ""
        Me.txt_drain_flow.GridBinding = Nothing
        Me.txt_drain_flow.Label_On_Top = False
        Me.txt_drain_flow.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_drain_flow.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_drain_flow.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_drain_flow.Label_Properties.Text = "Drain Flow (1 secs)"
        Me.txt_drain_flow.Label_Properties.Width = 150
        Me.txt_drain_flow.Location = New System.Drawing.Point(30, 66)
        Me.txt_drain_flow.Mandatory = False
        Me.txt_drain_flow.Name = "txt_drain_flow"
        Me.txt_drain_flow.Override_Modified = False
        Me.txt_drain_flow.SaveLoadOrder = 0
        Me.txt_drain_flow.Size = New System.Drawing.Size(201, 26)
        Me.txt_drain_flow.TabIndex = 2
        Me.txt_drain_flow.TabStop = False
        Me.txt_drain_flow.Tag = "drain_flow_secs"
        Me.txt_drain_flow.Text = "DbA_TextBox1"
        Me.txt_drain_flow.TextBox_Properties.AcceptsReturn = False
        Me.txt_drain_flow.TextBox_Properties.AcceptsTab = False
        Me.txt_drain_flow.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_drain_flow.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_drain_flow.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_drain_flow.TextBox_Properties.Enabled = True
        Me.txt_drain_flow.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_drain_flow.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_drain_flow.TextBox_Properties.MaximumValue = 999999
        Me.txt_drain_flow.TextBox_Properties.MaxLength = 3
        Me.txt_drain_flow.TextBox_Properties.MinimumValue = -999999
        Me.txt_drain_flow.TextBox_Properties.MultiLine = False
        Me.txt_drain_flow.TextBox_Properties.PasswordChar = Nothing
        Me.txt_drain_flow.TextBox_Properties.ReadOnly = False
        Me.txt_drain_flow.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_drain_flow.TextBox_Properties.TabStop = True
        Me.txt_drain_flow.TextBox_Properties.Text = ""
        Me.txt_drain_flow.TextBox_Properties.WordWrap = True
        Me.txt_drain_flow.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_fill_float
        '
        Me.txt_fill_float.AllowNegative = False
        Me.txt_fill_float.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_fill_float.ColorCursor = True
        Me.txt_fill_float.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_fill_float.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_fill_float.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_fill_float.Field_Name = ""
        Me.txt_fill_float.GridBinding = Nothing
        Me.txt_fill_float.Label_On_Top = False
        Me.txt_fill_float.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_fill_float.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fill_float.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_fill_float.Label_Properties.Text = "Fill Float (10 secs)"
        Me.txt_fill_float.Label_Properties.Width = 150
        Me.txt_fill_float.Location = New System.Drawing.Point(30, 43)
        Me.txt_fill_float.Mandatory = False
        Me.txt_fill_float.Name = "txt_fill_float"
        Me.txt_fill_float.Override_Modified = False
        Me.txt_fill_float.SaveLoadOrder = 0
        Me.txt_fill_float.Size = New System.Drawing.Size(201, 26)
        Me.txt_fill_float.TabIndex = 1
        Me.txt_fill_float.TabStop = False
        Me.txt_fill_float.Tag = "fill_float_secs"
        Me.txt_fill_float.Text = "DbA_TextBox1"
        Me.txt_fill_float.TextBox_Properties.AcceptsReturn = False
        Me.txt_fill_float.TextBox_Properties.AcceptsTab = False
        Me.txt_fill_float.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_fill_float.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fill_float.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_fill_float.TextBox_Properties.Enabled = True
        Me.txt_fill_float.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fill_float.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_fill_float.TextBox_Properties.MaximumValue = 999999
        Me.txt_fill_float.TextBox_Properties.MaxLength = 3
        Me.txt_fill_float.TextBox_Properties.MinimumValue = -999999
        Me.txt_fill_float.TextBox_Properties.MultiLine = False
        Me.txt_fill_float.TextBox_Properties.PasswordChar = Nothing
        Me.txt_fill_float.TextBox_Properties.ReadOnly = False
        Me.txt_fill_float.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_fill_float.TextBox_Properties.TabStop = True
        Me.txt_fill_float.TextBox_Properties.Text = ""
        Me.txt_fill_float.TextBox_Properties.WordWrap = True
        Me.txt_fill_float.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_fill_flow
        '
        Me.txt_fill_flow.AllowNegative = False
        Me.txt_fill_flow.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_fill_flow.ColorCursor = True
        Me.txt_fill_flow.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_fill_flow.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_fill_flow.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_fill_flow.Field_Name = ""
        Me.txt_fill_flow.GridBinding = Nothing
        Me.txt_fill_flow.Label_On_Top = False
        Me.txt_fill_flow.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_fill_flow.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fill_flow.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_fill_flow.Label_Properties.Text = "Fill Flow (1 secs)"
        Me.txt_fill_flow.Label_Properties.Width = 150
        Me.txt_fill_flow.Location = New System.Drawing.Point(30, 20)
        Me.txt_fill_flow.Mandatory = False
        Me.txt_fill_flow.Name = "txt_fill_flow"
        Me.txt_fill_flow.Override_Modified = False
        Me.txt_fill_flow.SaveLoadOrder = 0
        Me.txt_fill_flow.Size = New System.Drawing.Size(201, 26)
        Me.txt_fill_flow.TabIndex = 0
        Me.txt_fill_flow.TabStop = False
        Me.txt_fill_flow.Tag = "fill_flow_secs"
        Me.txt_fill_flow.Text = "DbA_TextBox1"
        Me.txt_fill_flow.TextBox_Properties.AcceptsReturn = False
        Me.txt_fill_flow.TextBox_Properties.AcceptsTab = False
        Me.txt_fill_flow.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_fill_flow.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fill_flow.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_fill_flow.TextBox_Properties.Enabled = True
        Me.txt_fill_flow.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fill_flow.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_fill_flow.TextBox_Properties.MaximumValue = 999999
        Me.txt_fill_flow.TextBox_Properties.MaxLength = 3
        Me.txt_fill_flow.TextBox_Properties.MinimumValue = -999999
        Me.txt_fill_flow.TextBox_Properties.MultiLine = False
        Me.txt_fill_flow.TextBox_Properties.PasswordChar = Nothing
        Me.txt_fill_flow.TextBox_Properties.ReadOnly = False
        Me.txt_fill_flow.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_fill_flow.TextBox_Properties.TabStop = True
        Me.txt_fill_flow.TextBox_Properties.Text = ""
        Me.txt_fill_flow.TextBox_Properties.WordWrap = True
        Me.txt_fill_flow.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'grpbx_83
        '
        Me.grpbx_83.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpbx_83.Controls.Add(Me.txt_83_dry_heat_secs)
        Me.grpbx_83.Controls.Add(Me.txt_83_dry_cool_secs)
        Me.grpbx_83.Controls.Add(Me.txt_83_detergent_secs)
        Me.grpbx_83.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbx_83.ForeColor = System.Drawing.Color.Black
        Me.grpbx_83.LineColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grpbx_83.Location = New System.Drawing.Point(251, 347)
        Me.grpbx_83.Name = "grpbx_83"
        Me.grpbx_83.Size = New System.Drawing.Size(255, 93)
        Me.grpbx_83.TabIndex = 5
        Me.grpbx_83.Text = "System 83 Settings"
        '
        'txt_83_dry_heat_secs
        '
        Me.txt_83_dry_heat_secs.AllowNegative = False
        Me.txt_83_dry_heat_secs.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_83_dry_heat_secs.ColorCursor = True
        Me.txt_83_dry_heat_secs.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_83_dry_heat_secs.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_83_dry_heat_secs.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_83_dry_heat_secs.Field_Name = ""
        Me.txt_83_dry_heat_secs.GridBinding = Nothing
        Me.txt_83_dry_heat_secs.Label_On_Top = False
        Me.txt_83_dry_heat_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_83_dry_heat_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_83_dry_heat_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_83_dry_heat_secs.Label_Properties.Text = "(a) Drying heat (180 secs)"
        Me.txt_83_dry_heat_secs.Label_Properties.Width = 160
        Me.txt_83_dry_heat_secs.Location = New System.Drawing.Point(34, 43)
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
        'txt_83_dry_cool_secs
        '
        Me.txt_83_dry_cool_secs.AllowNegative = False
        Me.txt_83_dry_cool_secs.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_83_dry_cool_secs.ColorCursor = True
        Me.txt_83_dry_cool_secs.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_83_dry_cool_secs.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_83_dry_cool_secs.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_83_dry_cool_secs.Field_Name = ""
        Me.txt_83_dry_cool_secs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_83_dry_cool_secs.ForeColor = System.Drawing.Color.Black
        Me.txt_83_dry_cool_secs.GridBinding = Nothing
        Me.txt_83_dry_cool_secs.Label_On_Top = False
        Me.txt_83_dry_cool_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_83_dry_cool_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_83_dry_cool_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_83_dry_cool_secs.Label_Properties.Text = "(a) Drying cool down (30 secs)"
        Me.txt_83_dry_cool_secs.Label_Properties.Width = 180
        Me.txt_83_dry_cool_secs.Location = New System.Drawing.Point(14, 67)
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
        'txt_83_detergent_secs
        '
        Me.txt_83_detergent_secs.AllowNegative = False
        Me.txt_83_detergent_secs.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_83_detergent_secs.ColorCursor = True
        Me.txt_83_detergent_secs.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_83_detergent_secs.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_83_detergent_secs.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_83_detergent_secs.Field_Name = ""
        Me.txt_83_detergent_secs.GridBinding = Nothing
        Me.txt_83_detergent_secs.Label_On_Top = False
        Me.txt_83_detergent_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_83_detergent_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_83_detergent_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_83_detergent_secs.Label_Properties.Text = "Detergent (30 secs)"
        Me.txt_83_detergent_secs.Label_Properties.Width = 160
        Me.txt_83_detergent_secs.Location = New System.Drawing.Point(34, 19)
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
        Me.grpbx_81.Controls.Add(Me.txt_81_reservoir_fill_secs)
        Me.grpbx_81.Controls.Add(Me.txt_81_prewash_secs)
        Me.grpbx_81.Controls.Add(Me.txt_81_soak_secs)
        Me.grpbx_81.Controls.Add(Me.txt_81_enzyme_secs)
        Me.grpbx_81.Controls.Add(Me.txt_81_detergent_secs)
        Me.grpbx_81.Controls.Add(Me.txt_81_rinse_secs)
        Me.grpbx_81.Controls.Add(Me.txt_81_rinse_delay_secs)
        Me.grpbx_81.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbx_81.ForeColor = System.Drawing.Color.Black
        Me.grpbx_81.LineColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grpbx_81.Location = New System.Drawing.Point(251, 118)
        Me.grpbx_81.Name = "grpbx_81"
        Me.grpbx_81.Size = New System.Drawing.Size(255, 182)
        Me.grpbx_81.TabIndex = 3
        Me.grpbx_81.Text = "System 81 Settings"
        '
        'txt_81_reservoir_fill_secs
        '
        Me.txt_81_reservoir_fill_secs.AllowNegative = False
        Me.txt_81_reservoir_fill_secs.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_reservoir_fill_secs.ColorCursor = True
        Me.txt_81_reservoir_fill_secs.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_81_reservoir_fill_secs.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_reservoir_fill_secs.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_81_reservoir_fill_secs.Field_Name = ""
        Me.txt_81_reservoir_fill_secs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_reservoir_fill_secs.ForeColor = System.Drawing.Color.Black
        Me.txt_81_reservoir_fill_secs.GridBinding = Nothing
        Me.txt_81_reservoir_fill_secs.Label_On_Top = False
        Me.txt_81_reservoir_fill_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_reservoir_fill_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_reservoir_fill_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_81_reservoir_fill_secs.Label_Properties.Text = "(p) Reservoir fill (30 secs)"
        Me.txt_81_reservoir_fill_secs.Label_Properties.Width = 160
        Me.txt_81_reservoir_fill_secs.Location = New System.Drawing.Point(34, 156)
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
        'txt_81_prewash_secs
        '
        Me.txt_81_prewash_secs.AllowNegative = False
        Me.txt_81_prewash_secs.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_prewash_secs.ColorCursor = True
        Me.txt_81_prewash_secs.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_81_prewash_secs.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_prewash_secs.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_81_prewash_secs.Field_Name = ""
        Me.txt_81_prewash_secs.GridBinding = Nothing
        Me.txt_81_prewash_secs.Label_On_Top = False
        Me.txt_81_prewash_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_prewash_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_prewash_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_81_prewash_secs.Label_Properties.Text = "(p, y, z) Prerinse (30 secs)"
        Me.txt_81_prewash_secs.Label_Properties.Width = 190
        Me.txt_81_prewash_secs.Location = New System.Drawing.Point(4, 133)
        Me.txt_81_prewash_secs.Mandatory = False
        Me.txt_81_prewash_secs.Name = "txt_81_prewash_secs"
        Me.txt_81_prewash_secs.Override_Modified = False
        Me.txt_81_prewash_secs.SaveLoadOrder = 0
        Me.txt_81_prewash_secs.Size = New System.Drawing.Size(241, 26)
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
        Me.txt_81_soak_secs.Field_Name = ""
        Me.txt_81_soak_secs.GridBinding = Nothing
        Me.txt_81_soak_secs.Label_On_Top = False
        Me.txt_81_soak_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_soak_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_soak_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_81_soak_secs.Label_Properties.Text = "(x) Soak (30 secs)"
        Me.txt_81_soak_secs.Label_Properties.Width = 120
        Me.txt_81_soak_secs.Location = New System.Drawing.Point(74, 110)
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
        Me.txt_81_enzyme_secs.Field_Name = ""
        Me.txt_81_enzyme_secs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_enzyme_secs.ForeColor = System.Drawing.Color.Black
        Me.txt_81_enzyme_secs.GridBinding = Nothing
        Me.txt_81_enzyme_secs.Label_On_Top = False
        Me.txt_81_enzyme_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_enzyme_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_enzyme_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_81_enzyme_secs.Label_Properties.Text = "(x) Enzyme (30 secs)"
        Me.txt_81_enzyme_secs.Label_Properties.Width = 130
        Me.txt_81_enzyme_secs.Location = New System.Drawing.Point(64, 87)
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
        'txt_81_detergent_secs
        '
        Me.txt_81_detergent_secs.AllowNegative = False
        Me.txt_81_detergent_secs.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_detergent_secs.ColorCursor = True
        Me.txt_81_detergent_secs.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_81_detergent_secs.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_detergent_secs.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_81_detergent_secs.Field_Name = ""
        Me.txt_81_detergent_secs.GridBinding = Nothing
        Me.txt_81_detergent_secs.Label_On_Top = False
        Me.txt_81_detergent_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_detergent_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_detergent_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_81_detergent_secs.Label_Properties.Text = "(x/y/z) detergent (30 secs)"
        Me.txt_81_detergent_secs.Label_Properties.Width = 165
        Me.txt_81_detergent_secs.Location = New System.Drawing.Point(29, 64)
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
        Me.txt_81_rinse_secs.Field_Name = ""
        Me.txt_81_rinse_secs.GridBinding = Nothing
        Me.txt_81_rinse_secs.Label_On_Top = False
        Me.txt_81_rinse_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_rinse_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_rinse_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_81_rinse_secs.Label_Properties.Text = "Spray rinse (30 secs)"
        Me.txt_81_rinse_secs.Label_Properties.Width = 130
        Me.txt_81_rinse_secs.Location = New System.Drawing.Point(64, 41)
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
        Me.txt_81_rinse_delay_secs.Field_Name = ""
        Me.txt_81_rinse_delay_secs.GridBinding = Nothing
        Me.txt_81_rinse_delay_secs.Label_On_Top = False
        Me.txt_81_rinse_delay_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_81_rinse_delay_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_81_rinse_delay_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_81_rinse_delay_secs.Label_Properties.Text = "Spray rinse delay (5 secs)"
        Me.txt_81_rinse_delay_secs.Label_Properties.Width = 160
        Me.txt_81_rinse_delay_secs.Location = New System.Drawing.Point(34, 18)
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
        Me.grpbx_temp.Location = New System.Drawing.Point(251, 4)
        Me.grpbx_temp.Name = "grpbx_temp"
        Me.grpbx_temp.Size = New System.Drawing.Size(254, 113)
        Me.grpbx_temp.TabIndex = 2
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
        Me.txt_max_abort_temp.Field_Name = ""
        Me.txt_max_abort_temp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_max_abort_temp.ForeColor = System.Drawing.Color.Black
        Me.txt_max_abort_temp.GridBinding = Nothing
        Me.txt_max_abort_temp.Label_On_Top = False
        Me.txt_max_abort_temp.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_max_abort_temp.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_max_abort_temp.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_max_abort_temp.Label_Properties.Text = "Max abort temperature (50 C)"
        Me.txt_max_abort_temp.Label_Properties.Width = 178
        Me.txt_max_abort_temp.Location = New System.Drawing.Point(16, 87)
        Me.txt_max_abort_temp.Mandatory = False
        Me.txt_max_abort_temp.Name = "txt_max_abort_temp"
        Me.txt_max_abort_temp.Override_Modified = False
        Me.txt_max_abort_temp.SaveLoadOrder = 0
        Me.txt_max_abort_temp.Size = New System.Drawing.Size(229, 26)
        Me.txt_max_abort_temp.TabIndex = 3
        Me.txt_max_abort_temp.TabStop = False
        Me.txt_max_abort_temp.Tag = "max_abort_temperature"
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
        Me.txt_min_start_temp.Field_Name = ""
        Me.txt_min_start_temp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_min_start_temp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_min_start_temp.GridBinding = Nothing
        Me.txt_min_start_temp.Label_On_Top = False
        Me.txt_min_start_temp.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_min_start_temp.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_min_start_temp.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_min_start_temp.Label_Properties.Text = "Minimum start (24 C)"
        Me.txt_min_start_temp.Label_Properties.Width = 130
        Me.txt_min_start_temp.Location = New System.Drawing.Point(64, 64)
        Me.txt_min_start_temp.Mandatory = False
        Me.txt_min_start_temp.Name = "txt_min_start_temp"
        Me.txt_min_start_temp.Override_Modified = False
        Me.txt_min_start_temp.SaveLoadOrder = 0
        Me.txt_min_start_temp.Size = New System.Drawing.Size(181, 26)
        Me.txt_min_start_temp.TabIndex = 2
        Me.txt_min_start_temp.TabStop = False
        Me.txt_min_start_temp.Tag = "min_start_temperature"
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
        Me.txt_heat_pad_on.Field_Name = ""
        Me.txt_heat_pad_on.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_heat_pad_on.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_heat_pad_on.GridBinding = Nothing
        Me.txt_heat_pad_on.Label_On_Top = False
        Me.txt_heat_pad_on.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_heat_pad_on.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_heat_pad_on.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_heat_pad_on.Label_Properties.Text = "Heat pad on (min) (25 C)"
        Me.txt_heat_pad_on.Label_Properties.Width = 160
        Me.txt_heat_pad_on.Location = New System.Drawing.Point(34, 41)
        Me.txt_heat_pad_on.Mandatory = False
        Me.txt_heat_pad_on.Name = "txt_heat_pad_on"
        Me.txt_heat_pad_on.Override_Modified = False
        Me.txt_heat_pad_on.SaveLoadOrder = 0
        Me.txt_heat_pad_on.Size = New System.Drawing.Size(211, 26)
        Me.txt_heat_pad_on.TabIndex = 1
        Me.txt_heat_pad_on.TabStop = False
        Me.txt_heat_pad_on.Tag = "min_temperature"
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
        Me.txt_heat_pad_off.Field_Name = ""
        Me.txt_heat_pad_off.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_heat_pad_off.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_heat_pad_off.GridBinding = Nothing
        Me.txt_heat_pad_off.Label_On_Top = False
        Me.txt_heat_pad_off.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_heat_pad_off.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_heat_pad_off.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_heat_pad_off.Label_Properties.Text = "Heat pad off (max) (28 C)"
        Me.txt_heat_pad_off.Label_Properties.Width = 160
        Me.txt_heat_pad_off.Location = New System.Drawing.Point(34, 18)
        Me.txt_heat_pad_off.Mandatory = False
        Me.txt_heat_pad_off.Name = "txt_heat_pad_off"
        Me.txt_heat_pad_off.Override_Modified = False
        Me.txt_heat_pad_off.SaveLoadOrder = 0
        Me.txt_heat_pad_off.Size = New System.Drawing.Size(211, 26)
        Me.txt_heat_pad_off.TabIndex = 0
        Me.txt_heat_pad_off.TabStop = False
        Me.txt_heat_pad_off.Tag = "max_temperature"
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
        Me.grpbx_general.Controls.Add(Me.txt_float_abort)
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
        Me.grpbx_general.Location = New System.Drawing.Point(5, 4)
        Me.grpbx_general.Name = "grpbx_general"
        Me.grpbx_general.Size = New System.Drawing.Size(240, 320)
        Me.grpbx_general.TabIndex = 0
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
        Me.txt_ultrasonics_abort.Field_Name = ""
        Me.txt_ultrasonics_abort.GridBinding = Nothing
        Me.txt_ultrasonics_abort.Label_On_Top = False
        Me.txt_ultrasonics_abort.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_ultrasonics_abort.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ultrasonics_abort.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_ultrasonics_abort.Label_Properties.Text = "Ultrasonics delay (2 secs)"
        Me.txt_ultrasonics_abort.Label_Properties.Width = 160
        Me.txt_ultrasonics_abort.Location = New System.Drawing.Point(20, 294)
        Me.txt_ultrasonics_abort.Mandatory = False
        Me.txt_ultrasonics_abort.Name = "txt_ultrasonics_abort"
        Me.txt_ultrasonics_abort.Override_Modified = False
        Me.txt_ultrasonics_abort.SaveLoadOrder = 0
        Me.txt_ultrasonics_abort.Size = New System.Drawing.Size(211, 26)
        Me.txt_ultrasonics_abort.TabIndex = 12
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
        'txt_float_abort
        '
        Me.txt_float_abort.AllowNegative = False
        Me.txt_float_abort.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_float_abort.ColorCursor = True
        Me.txt_float_abort.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_float_abort.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_float_abort.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_float_abort.Field_Name = ""
        Me.txt_float_abort.GridBinding = Nothing
        Me.txt_float_abort.Label_On_Top = False
        Me.txt_float_abort.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_float_abort.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_float_abort.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_float_abort.Label_Properties.Text = "Float Abort (4 hours)"
        Me.txt_float_abort.Label_Properties.Width = 150
        Me.txt_float_abort.Location = New System.Drawing.Point(30, 271)
        Me.txt_float_abort.Mandatory = False
        Me.txt_float_abort.Name = "txt_float_abort"
        Me.txt_float_abort.Override_Modified = False
        Me.txt_float_abort.SaveLoadOrder = 0
        Me.txt_float_abort.Size = New System.Drawing.Size(201, 26)
        Me.txt_float_abort.TabIndex = 11
        Me.txt_float_abort.TabStop = False
        Me.txt_float_abort.Tag = "float_abort_delay_secs"
        Me.txt_float_abort.Text = "DbA_TextBox1"
        Me.txt_float_abort.TextBox_Properties.AcceptsReturn = False
        Me.txt_float_abort.TextBox_Properties.AcceptsTab = False
        Me.txt_float_abort.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_float_abort.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_float_abort.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_float_abort.TextBox_Properties.Enabled = True
        Me.txt_float_abort.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_float_abort.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_float_abort.TextBox_Properties.MaximumValue = 999999
        Me.txt_float_abort.TextBox_Properties.MaxLength = 3
        Me.txt_float_abort.TextBox_Properties.MinimumValue = -999999
        Me.txt_float_abort.TextBox_Properties.MultiLine = False
        Me.txt_float_abort.TextBox_Properties.PasswordChar = Nothing
        Me.txt_float_abort.TextBox_Properties.ReadOnly = False
        Me.txt_float_abort.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_float_abort.TextBox_Properties.TabStop = True
        Me.txt_float_abort.TextBox_Properties.Text = ""
        Me.txt_float_abort.TextBox_Properties.WordWrap = True
        Me.txt_float_abort.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_safety_delay
        '
        Me.txt_safety_delay.AllowNegative = False
        Me.txt_safety_delay.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_safety_delay.ColorCursor = True
        Me.txt_safety_delay.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_safety_delay.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_safety_delay.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_Integer
        Me.txt_safety_delay.Field_Name = ""
        Me.txt_safety_delay.GridBinding = Nothing
        Me.txt_safety_delay.Label_On_Top = False
        Me.txt_safety_delay.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_safety_delay.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_safety_delay.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_safety_delay.Label_Properties.Text = "Safety delay (2 secs)"
        Me.txt_safety_delay.Label_Properties.Width = 130
        Me.txt_safety_delay.Location = New System.Drawing.Point(50, 248)
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
        Me.txt_pressure_error.Field_Name = ""
        Me.txt_pressure_error.GridBinding = Nothing
        Me.txt_pressure_error.Label_On_Top = False
        Me.txt_pressure_error.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_pressure_error.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pressure_error.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_pressure_error.Label_Properties.Text = "Pressure error delay (5 secs)"
        Me.txt_pressure_error.Label_Properties.Width = 178
        Me.txt_pressure_error.Location = New System.Drawing.Point(2, 225)
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
        Me.txt_pressure_start.Field_Name = ""
        Me.txt_pressure_start.GridBinding = Nothing
        Me.txt_pressure_start.Label_On_Top = False
        Me.txt_pressure_start.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_pressure_start.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pressure_start.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_pressure_start.Label_Properties.Text = "Pressure start delay (75 secs)"
        Me.txt_pressure_start.Label_Properties.Width = 178
        Me.txt_pressure_start.Location = New System.Drawing.Point(2, 202)
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
        Me.txt_float_delay.Field_Name = ""
        Me.txt_float_delay.GridBinding = Nothing
        Me.txt_float_delay.Label_On_Top = False
        Me.txt_float_delay.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_float_delay.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_float_delay.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_float_delay.Label_Properties.Text = "Float delay (1 secs)"
        Me.txt_float_delay.Label_Properties.Width = 140
        Me.txt_float_delay.Location = New System.Drawing.Point(40, 179)
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
        Me.txt_warwick_delay.Field_Name = ""
        Me.txt_warwick_delay.GridBinding = Nothing
        Me.txt_warwick_delay.Label_On_Top = False
        Me.txt_warwick_delay.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_warwick_delay.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_warwick_delay.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_warwick_delay.Label_Properties.Text = "Warwick delay (5 secs)"
        Me.txt_warwick_delay.Label_Properties.Width = 140
        Me.txt_warwick_delay.Location = New System.Drawing.Point(40, 156)
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
        Me.txt_drain2.Field_Name = ""
        Me.txt_drain2.GridBinding = Nothing
        Me.txt_drain2.Label_On_Top = False
        Me.txt_drain2.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_drain2.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_drain2.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_drain2.Label_Properties.Text = "Drain period 2nd (10 secs)"
        Me.txt_drain2.Label_Properties.Width = 155
        Me.txt_drain2.Location = New System.Drawing.Point(25, 133)
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
        Me.txt_drain1.Field_Name = ""
        Me.txt_drain1.GridBinding = Nothing
        Me.txt_drain1.Label_On_Top = False
        Me.txt_drain1.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_drain1.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_drain1.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_drain1.Label_Properties.Text = "Drain period 1st (30 secs)"
        Me.txt_drain1.Label_Properties.Width = 160
        Me.txt_drain1.Location = New System.Drawing.Point(20, 110)
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
        Me.txt_lubrication.Field_Name = ""
        Me.txt_lubrication.GridBinding = Nothing
        Me.txt_lubrication.Label_On_Top = False
        Me.txt_lubrication.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_lubrication.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lubrication.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_lubrication.Label_Properties.Text = "Lubrication (10 secs)"
        Me.txt_lubrication.Label_Properties.Width = 130
        Me.txt_lubrication.Location = New System.Drawing.Point(50, 87)
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
        Me.txt_chemical_immersion.Field_Name = ""
        Me.txt_chemical_immersion.GridBinding = Nothing
        Me.txt_chemical_immersion.Label_On_Top = False
        Me.txt_chemical_immersion.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_chemical_immersion.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_chemical_immersion.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_chemical_immersion.Label_Properties.Text = "Chemical immersion (20 mins)"
        Me.txt_chemical_immersion.Label_Properties.Width = 178
        Me.txt_chemical_immersion.Location = New System.Drawing.Point(2, 64)
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
        Me.txt_wash_rinse_secs.Field_Name = ""
        Me.txt_wash_rinse_secs.GridBinding = Nothing
        Me.txt_wash_rinse_secs.Label_On_Top = False
        Me.txt_wash_rinse_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_wash_rinse_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_wash_rinse_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_wash_rinse_secs.Label_Properties.Text = "Rinse (60 secs)"
        Me.txt_wash_rinse_secs.Label_Properties.Width = 100
        Me.txt_wash_rinse_secs.Location = New System.Drawing.Point(80, 41)
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
        Me.txt_wash_secs.Field_Name = ""
        Me.txt_wash_secs.GridBinding = Nothing
        Me.txt_wash_secs.Label_On_Top = False
        Me.txt_wash_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_wash_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_wash_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_wash_secs.Label_Properties.Text = "Wash (180 secs)"
        Me.txt_wash_secs.Label_Properties.Width = 100
        Me.txt_wash_secs.Location = New System.Drawing.Point(80, 18)
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
        'grpbx_82
        '
        Me.grpbx_82.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpbx_82.Controls.Add(Me.txt_82_ultra_disinfect_secs)
        Me.grpbx_82.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbx_82.ForeColor = System.Drawing.Color.Black
        Me.grpbx_82.LineColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grpbx_82.Location = New System.Drawing.Point(251, 301)
        Me.grpbx_82.Name = "grpbx_82"
        Me.grpbx_82.Size = New System.Drawing.Size(255, 44)
        Me.grpbx_82.TabIndex = 4
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
        Me.txt_82_ultra_disinfect_secs.Field_Name = ""
        Me.txt_82_ultra_disinfect_secs.GridBinding = Nothing
        Me.txt_82_ultra_disinfect_secs.Label_On_Top = False
        Me.txt_82_ultra_disinfect_secs.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_82_ultra_disinfect_secs.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_82_ultra_disinfect_secs.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_82_ultra_disinfect_secs.Label_Properties.Text = "Ultrasonics/disinfect (30 secs)"
        Me.txt_82_ultra_disinfect_secs.Label_Properties.Width = 180
        Me.txt_82_ultra_disinfect_secs.Location = New System.Drawing.Point(14, 18)
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
        Me.btn_cancel.Location = New System.Drawing.Point(125, -9)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(104, 43)
        Me.btn_cancel.TabIndex = 1
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
        Me.btn_save.Location = New System.Drawing.Point(5, -9)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(104, 43)
        Me.btn_save.TabIndex = 0
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
        Me.btn_close.Location = New System.Drawing.Point(421, -9)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(104, 43)
        Me.btn_close.TabIndex = 2
        Me.btn_close.TabStop = False
        Me.btn_close.Text = "Close"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'minimum_overrides
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(750, 496)
        Me.Controls.Add(Me.pnl_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "minimum_overrides"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minimum Overrides"
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_main.ResumeLayout(False)
        Me.pnl_info.ResumeLayout(False)
        Me.grpbx_england_aborts.ResumeLayout(False)
        Me.grpbx_delays.ResumeLayout(False)
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
            Case Keys.F2
                If btn_save.Enabled Then Call Process("SAVE")

            Case Keys.F3
                If btn_cancel.Enabled Then Call Process("CANCEL")

            Case Keys.F5
                Call Process("RESET")

            Case Keys.F8
                Call Process("CLOSE")
        End Select

        Select Case keyCode
            Case Keys.F2, Keys.F3, Keys.F4, Keys.F5, Keys.F8
                Return True
        End Select
    End Function
#End Region

#Region " Button Events "
    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Call Process("CLOSE")
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Call Process("CANCEL")
    End Sub

    Private Sub btn_save_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Call Process("SAVE")
    End Sub

    Private Sub btn_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset.Click
        Call Process("RESET")
    End Sub
#End Region

#Region " Close Form "
    Private Sub close_form()
        g_framework.g_forms(1).Show()
        g_framework.g_forms(2) = Nothing
        Me.Close()
    End Sub
#End Region

#Region " Form Load "
    Private Sub minimum_overrides_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim p_excludes(0) As dba_RemoveControls
        p_excludes(0).Control = btn_close

        Me.dba_init_form(pnl_main, True, p_excludes, g_is_internal)
        Call size_screen(Me)

        Me.dba_screen_state(pnl_main, DBA_Framework.DBA_Foundation_Class.SCREEN_BUTTON_MODE.New_Screen, DBA_Framework.DBA_Foundation_Class.ScreenLockMode.UNLOCK, False)

        If Not g_england_flag Then
            grpbx_england_aborts.Enabled = False
        End If

        ' ----------------------------
        ' * Disable Ultrasonics Sensor
        ' ----------------------------
        If Not g_us_usage Then
            txt_ultrasonics_abort.Visible = False
            txt_ultrasonics_abort.Tag = ""

            grpbx_general.Height = 297
        End If

        ' ----------------
        ' * Fill Overrides
        ' ----------------
        Call LoadScreen()

        Call set_toolbar_buttons("F", "F")
    End Sub
#End Region

#Region " Load Screen "
    Private Sub LoadScreen()
        Dim p_sql As String
        Dim p_dataset As DataSet
        Dim p_db_row As DataRow

        Dim varName As String
        Dim override As String
        Dim default_val As String
        Dim caption As String

        Me.g_fill_screen = True

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

        Me.g_fill_screen = False

        ' Dispose of Dataset
        p_dataset.Dispose()
    End Sub
#End Region

#Region " Load Textbox "
    Private Sub LoadTextbox(ByVal varName As String, ByVal caption As String, ByVal Override As String, ByVal Default_val As String)
        Dim p_filled As Boolean = False

        'General
        For Each pTxt As DBA.Library.DBA_TextBox In grpbx_general.Controls
            If UCase(pTxt.Tag) = UCase(varName) Then
                Select Case UCase(ptxt.Tag)
                    Case "DISINFECT_SECS"
                        pTxt.Label_Properties.Text = caption & " (" & Default_val & " " & IIf(Default_val > 1, "mins", "min") & ")"
                        pTxt.TextBox_Properties.Text = Override

                    Case "FLOAT_ABORT_DELAY_SECS"
                        pTxt.Label_Properties.Text = caption & " (" & Default_val & " " & IIf(Default_val > 1, "hrs", "hr") & ")"
                        pTxt.TextBox_Properties.Text = Override

                    Case Else
                        pTxt.Label_Properties.Text = caption & " (" & Default_val & " " & IIf(Default_val > 1, "secs", "sec") & ")"
                        pTxt.TextBox_Properties.Text = Override
                End Select

                p_filled = True
                Exit For
            End If
        Next
        If p_filled Then Exit Sub

        'Delays
        For Each pTxt As DBA.Library.DBA_TextBox In grpbx_delays.Controls
            If UCase(pTxt.Tag) = UCase(varName) Then
                pTxt.Label_Properties.Text = caption & " (" & Default_val & " " & IIf(Default_val > 1, "secs", "sec") & ")"
                pTxt.TextBox_Properties.Text = Override

                p_filled = True
                Exit For
            End If
        Next
        If p_filled Then Exit Sub

        'Temperature
        For Each pTxt As DBA.Library.DBA_TextBox In grpbx_temp.Controls
            If UCase(pTxt.Tag) = UCase(varName) Then
                pTxt.Label_Properties.Text = caption & " (" & Default_val & " C)"
                pTxt.TextBox_Properties.Text = Override

                p_filled = True
                Exit For
            End If
        Next
        If p_filled Then Exit Sub

        '81
        For Each pTxt As DBA.Library.DBA_TextBox In grpbx_81.Controls
            If UCase(pTxt.Tag) = UCase(varName) Then
                pTxt.Label_Properties.Text = caption & " (" & Default_val & " " & IIf(Default_val > 1, "secs", "sec") & ")"
                pTxt.TextBox_Properties.Text = Override

                p_filled = True
                Exit For
            End If
        Next
        If p_filled Then Exit Sub

        '82
        For Each pTxt As DBA.Library.DBA_TextBox In grpbx_82.Controls
            If UCase(pTxt.Tag) = UCase(varName) Then
                pTxt.Label_Properties.Text = caption & " (" & Default_val & " " & IIf(Default_val > 1, "secs", "sec") & ")"
                pTxt.TextBox_Properties.Text = Override

                p_filled = True
                Exit For
            End If
        Next
        If p_filled Then Exit Sub

        '83
        For Each pTxt As DBA.Library.DBA_TextBox In grpbx_83.Controls
            If UCase(pTxt.Tag) = UCase(varName) Then
                pTxt.Label_Properties.Text = caption & " (" & Default_val & " " & IIf(Default_val > 1, "secs", "sec") & ")"
                pTxt.TextBox_Properties.Text = Override

                p_filled = True
                Exit For
            End If
        Next
        If p_filled Then Exit Sub

        'England Aborts
        For Each pTxt As DBA.Library.DBA_TextBox In grpbx_england_aborts.Controls
            If UCase(pTxt.Tag) = UCase(varName) Then
                Select Case ptxt.Tag
                    Case "fill_max_abort_secs", "drain_max_abort_secs", _
                         "disinfect_return_max_abort_secs"
                        pTxt.Label_Properties.Text = caption & " (" & Default_val & " " & IIf(Default_val > 1, "mins", "min") & ")"
                        pTxt.TextBox_Properties.Text = Override

                    Case Else
                        pTxt.Label_Properties.Text = caption & " (" & Default_val & " " & IIf(Default_val > 1, "secs", "sec") & ")"
                        pTxt.TextBox_Properties.Text = Override
                End Select

                p_filled = True
                Exit For
            End If
        Next
        If p_filled Then Exit Sub
    End Sub
#End Region

#Region " Process "
    Private Sub Process(ByVal p_type As String)
        Select Case UCase(p_type)
            Case "SAVE"
                Call set_toolbar_buttons("F", "F")

                ' -----------------------------
                ' * Reset System Data Overrides
                ' -----------------------------
                Call reset_system_data_overrides()

                Call ProcessSave()

            Case "CANCEL"
                Call LoadScreen()
                Call set_toolbar_buttons("F", "F")

            Case "RESET"
                If message_box("Are you sure you want to reset to the defaults?", 2, "Reset Defaults") = MsgBoxResult.Yes Then
                    Call ResetDefaults()
                    Call LoadScreen()
                    Call set_toolbar_buttons("F", "F")
                End If

            Case "CLOSE"
                If btn_save.Enabled Then
                    If message_box("Do you want to save before exiting this screen?", 2, "Save before close") = MsgBoxResult.Yes Then
                        If ProcessSave() = True Then
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

#Region " Process Save "
    Private Function ProcessSave() As Boolean
        Dim p_sql As String = ""

        'Reload all the defaults
        For p_x As Integer = 0 To g_bay_count - 1
            g_CUSMain.Machines(p_x).Setup = False
        Next

        Try
            'General
            For Each pTxt As DBA.Library.DBA_TextBox In grpbx_general.Controls
                If pTxt.Tag <> "" Then
                    If Trim(pTxt.TextBox_Properties.Text) <> "" Then
                        p_sql &= "UPDATE minimum_overrides " & _
                                 "SET override = '" & pTxt.TextBox_Properties.Text & _
                                 "' WHERE var_name = '" & pTxt.Tag & "'; "
                    Else
                        p_sql &= "UPDATE minimum_overrides " & _
                                 "SET override = NULL " & _
                                 "WHERE var_name = '" & pTxt.Tag & "'; "
                    End If
                End If
            Next

            'Delays
            For Each pTxt As DBA.Library.DBA_TextBox In grpbx_delays.Controls
                If Trim(ptxt.TextBox_Properties.Text) <> "" Then
                    p_sql &= "UPDATE minimum_overrides " & _
                             "SET override = '" & pTxt.TextBox_Properties.Text & _
                             "' WHERE var_name = '" & pTxt.Tag & "'; "
                Else
                    p_sql &= "UPDATE minimum_overrides " & _
                             "SET override = NULL " & _
                             "WHERE var_name = '" & pTxt.Tag & "'; "
                End If
            Next

            'Temperature
            For Each pTxt As DBA.Library.DBA_TextBox In grpbx_temp.Controls
                If Trim(ptxt.TextBox_Properties.Text) <> "" Then
                    p_sql &= "UPDATE minimum_overrides " & _
                             "SET override = '" & pTxt.TextBox_Properties.Text & _
                             "' WHERE var_name = '" & pTxt.Tag & "'; "
                Else
                    p_sql &= "UPDATE minimum_overrides " & _
                             "SET override = NULL " & _
                             "WHERE var_name = '" & pTxt.Tag & "'; "
                End If
            Next

            '81
            For Each pTxt As DBA.Library.DBA_TextBox In grpbx_81.Controls
                If Trim(ptxt.TextBox_Properties.Text) <> "" Then
                    p_sql &= "UPDATE minimum_overrides " & _
                             "SET override = '" & pTxt.TextBox_Properties.Text & _
                             "' WHERE var_name = '" & pTxt.Tag & "'; "
                Else
                    p_sql &= "UPDATE minimum_overrides " & _
                             "SET override = NULL " & _
                             "WHERE var_name = '" & pTxt.Tag & "'; "
                End If
            Next

            '82
            For Each pTxt As DBA.Library.DBA_TextBox In grpbx_82.Controls
                If Trim(ptxt.TextBox_Properties.Text) <> "" Then
                    p_sql &= "UPDATE minimum_overrides " & _
                             "SET override = '" & pTxt.TextBox_Properties.Text & _
                             "' WHERE var_name = '" & pTxt.Tag & "'; "
                Else
                    p_sql &= "UPDATE minimum_overrides " & _
                             "SET override = NULL " & _
                             "WHERE var_name = '" & pTxt.Tag & "'; "
                End If
            Next

            '83
            For Each pTxt As DBA.Library.DBA_TextBox In grpbx_83.Controls
                If Trim(ptxt.TextBox_Properties.Text) <> "" Then
                    p_sql &= "UPDATE minimum_overrides " & _
                             "SET override = '" & pTxt.TextBox_Properties.Text & _
                             "' WHERE var_name = '" & pTxt.Tag & "'; "
                Else
                    p_sql &= "UPDATE minimum_overrides " & _
                             "SET override = NULL " & _
                             "WHERE var_name = '" & pTxt.Tag & "'; "
                End If
            Next

            'England Aborts
            For Each pTxt As DBA.Library.DBA_TextBox In grpbx_england_aborts.Controls
                If Trim(ptxt.TextBox_Properties.Text) <> "" Then
                    p_sql &= "UPDATE minimum_overrides " & _
                             "SET override = '" & pTxt.TextBox_Properties.Text & _
                             "' WHERE var_name = '" & pTxt.Tag & "'; "
                Else
                    p_sql &= "UPDATE minimum_overrides " & _
                             "SET override = NULL " & _
                             "WHERE var_name = '" & pTxt.Tag & "'; "
                End If
            Next

            g_framework.Execute_Query(p_sql)

            Return True

        Catch
            Return False
        End Try
    End Function
#End Region

#Region " Reset Defaults "
    Private Sub ResetDefaults()
        Dim p_sql As String

        ' -------------------
        ' * Clear All Changes
        ' -------------------
        p_sql = "UPDATE minimum_overrides " & _
                "SET override = NULL"
        g_framework.Execute_Query(p_sql)

        ' -----------------------------
        ' * Reset System Data Overrides
        ' -----------------------------
        Call reset_system_data_overrides()

        ' -------------------------
        ' * Reload all the defaults
        ' -------------------------
        For p_x As Integer = 0 To g_bay_count - 1
            g_CUSMain.Machines(p_x).Setup = False
        Next
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

#Region " TextChanged "
    Private Sub General_Settings_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        txt_wash_secs.TextBox_TextChanged, txt_wash_rinse_secs.TextBox_TextChanged, _
        txt_chemical_immersion.TextBox_TextChanged, txt_lubrication.TextBox_TextChanged, _
        txt_drain1.TextBox_TextChanged, txt_drain2.TextBox_TextChanged, _
        txt_warwick_delay.TextBox_TextChanged, txt_float_delay.TextBox_TextChanged, _
        txt_pressure_start.TextBox_TextChanged, txt_pressure_error.TextBox_TextChanged, _
        txt_safety_delay.TextBox_TextChanged, txt_ultrasonics_abort.TextBox_TextChanged

        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("T", "T")
    End Sub

    Private Sub Temperature_Settings_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        txt_heat_pad_off.TextBox_TextChanged, txt_heat_pad_on.TextBox_TextChanged, _
        txt_min_start_temp.TextBox_TextChanged, txt_max_abort_temp.TextBox_TextChanged

        If Me.g_fill_screen Then Exit Sub

        Call set_toolbar_buttons("T", "T")
    End Sub

    Private Sub Delays_Settings_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        txt_fill_flow.TextBox_TextChanged, txt_fill_float.TextBox_TextChanged, txt_drain_flow.TextBox_TextChanged, txt_drain_float.TextBox_TextChanged, txt_float_abort.TextBox_TextChanged

        If Me.g_fill_screen Then Exit Sub

        Call set_toolbar_buttons("T", "T")
    End Sub

    Private Sub Sys_81_82_Settings_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        txt_81_rinse_delay_secs.TextBox_TextChanged, txt_81_rinse_secs.TextBox_TextChanged, _
        txt_81_detergent_secs.TextBox_TextChanged, txt_81_enzyme_secs.TextBox_TextChanged, _
        txt_81_soak_secs.TextBox_TextChanged, txt_81_prewash_secs.TextBox_TextChanged, _
        txt_81_reservoir_fill_secs.TextBox_TextChanged, txt_82_ultra_disinfect_secs.TextBox_TextChanged

        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("T", "T")
    End Sub

    Private Sub Sys_83_Settings_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        txt_83_detergent_secs.TextBox_TextChanged, txt_83_dry_cool_secs.TextBox_TextChanged, _
        txt_83_dry_heat_secs.TextBox_TextChanged

        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("T", "T")
    End Sub

    Private Sub England_Aborts_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_fill_min_abort.TextBox_TextChanged, txt_fill_max_abort.TextBox_TextChanged, txt_drain_min_abort.TextBox_TextChanged, txt_drain_max_abort.TextBox_TextChanged

        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("T", "T")
    End Sub
#End Region

#End Region

#End Region

End Class
