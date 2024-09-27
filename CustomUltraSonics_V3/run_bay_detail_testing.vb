Public Class run_bay_detail_testing
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
    Friend WithEvents DbA_Label2 As DBA.Library.DBA_Label
    Friend WithEvents DbA_Label4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_bay_temp_dis As DBA.Library.DBA_Label
    Friend WithEvents prog_bay_temp As DBA.Library.DBA_ProgressBar
    Friend WithEvents lbl_res_temp_dis As DBA.Library.DBA_Label
    Friend WithEvents prog_res_temp As DBA.Library.DBA_ProgressBar
    Friend WithEvents lbl_left As DBA.Library.DBA_Label
    Friend WithEvents lbl_completed As DBA.Library.DBA_Label
    Friend WithEvents lbl_stage As DBA.Library.DBA_Label
    Friend WithEvents prog_overall As DBA.Library.DBA_ProgressBar
    Friend WithEvents btn_close As DBA.Library.DBA_Button
    Friend WithEvents lbl_ultrasonics As DBA.Library.DBA_Label
    Friend WithEvents lbl_drain_pump As DBA.Library.DBA_Label
    Friend WithEvents lbl_drain_valve As DBA.Library.DBA_Label
    Friend WithEvents lbl_res_pump As DBA.Library.DBA_Label
    Friend WithEvents lbl_res_feed As DBA.Library.DBA_Label
    Friend WithEvents lbl_res_return As DBA.Library.DBA_Label
    Friend WithEvents lbl_residual_drain As DBA.Library.DBA_Label
    Friend WithEvents lbl_air As DBA.Library.DBA_Label
    Friend WithEvents lbl_lub_pump As DBA.Library.DBA_Label
    Friend WithEvents lbl_spray_rinse As DBA.Library.DBA_Label
    Friend WithEvents lbl_detergent_pump As DBA.Library.DBA_Label
    Friend WithEvents lbl_enzyme_pump As DBA.Library.DBA_Label
    Friend WithEvents lbl_input_flow As DBA.Library.DBA_Label
    Friend WithEvents lbl_input_float As DBA.Library.DBA_Label
    Friend WithEvents lbl_input_water As DBA.Library.DBA_Label
    Friend WithEvents lbl_input_safety As DBA.Library.DBA_Label
    Friend WithEvents lbl_additional As DBA.Library.DBA_Label
    Friend WithEvents lbl_osc_pump As DBA.Library.DBA_Label
    Friend WithEvents lbl_water_valve As DBA.Library.DBA_Label
    Friend WithEvents grpbx_outputs As DBA.Library.DBA_StyleGroupBox
    Friend WithEvents grpbx_inputs As DBA.Library.DBA_StyleGroupBox
    Friend WithEvents grpbx_res_temp As DBA.Library.DBA_StyleGroupBox
    Friend WithEvents grpbx_bay_temp As DBA.Library.DBA_StyleGroupBox
    Friend WithEvents chk_lub As DBA.Library.DBA_CheckBox
    Friend WithEvents lbl_dry_heat As DBA.Library.DBA_Label
    Friend WithEvents lbl_machine_name As DBA.Library.DBA_Label
    Friend WithEvents btn_sub2 As DBA.Library.DBA_Button
    Friend WithEvents btn_sub1 As DBA.Library.DBA_Button
    Friend WithEvents btn_main As DBA.Library.DBA_Button
    Friend WithEvents btn_return As DBA.Library.DBA_Button
    Friend WithEvents btn_purge As DBA.Library.DBA_Button
    Friend WithEvents btn_empty As DBA.Library.DBA_Button
    Friend WithEvents btn_system As DBA.Library.DBA_Button
    Friend WithEvents btn_patient As DBA.Library.DBA_Button
    Friend WithEvents btn_additional As DBA.Library.DBA_Button
    Friend WithEvents lbl_lub As DBA.Library.DBA_Label
    Friend WithEvents pnl_additional As DBA.Library.DBA_Panel
    Friend WithEvents pnl_main_buttons As DBA.Library.DBA_Panel
    Friend WithEvents btn_print As DBA.Library.DBA_Button
    Friend WithEvents btn_finish As DBA.Library.DBA_Button
    Friend WithEvents btn_cancel As DBA.Library.DBA_Button
    Friend WithEvents prog_run As DBA.Library.DBA_ProgressBar
    Friend WithEvents lbl_error As DBA.Library.DBA_Label
    Friend WithEvents txt_notes As DBA.Library.DBA_TextBox
    Friend WithEvents lbl_info As DBA.Library.DBA_Label
    Friend WithEvents lbl_count As DBA.Library.DBA_Label
    Friend WithEvents GroupByRow1 As Xceed.Grid.GroupByRow
    Friend WithEvents ColumnManagerRow1 As Xceed.Grid.ColumnManagerRow
    Friend WithEvents dataRowTemplate1 As Xceed.Grid.DataRow
    Friend WithEvents grd_display As DBA.Library.DBA_StyleGrid
    Friend WithEvents lbl_disinfect_lot As DBA.Library.DBA_Label
    Friend WithEvents lbl_info1 As DBA.Library.DBA_Label
    Friend WithEvents lbl_process_num As DBA.Library.DBA_Label
    Friend WithEvents lbl_input_ultrasonics As DBA.Library.DBA_Label
    Friend WithEvents lbl_info2 As DBA.Library.DBA_Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(run_bay_detail_testing))
        Me.pnl_main = New DBA.Library.DBA_Panel
        Me.lbl_disinfect_lot = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_process_num = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_count = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_info = New DBA.Library.DBA_Label(Me.components)
        Me.txt_notes = New DBA.Library.DBA_TextBox
        Me.lbl_machine_name = New DBA.Library.DBA_Label(Me.components)
        Me.prog_run = New DBA.Library.DBA_ProgressBar
        Me.btn_close = New DBA.Library.DBA_Button(Me.components)
        Me.grpbx_outputs = New DBA.Library.DBA_StyleGroupBox
        Me.lbl_dry_heat = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_enzyme_pump = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_detergent_pump = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_spray_rinse = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_lub_pump = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_air = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_residual_drain = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_res_return = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_res_feed = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_res_pump = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_osc_pump = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_water_valve = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_drain_valve = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_drain_pump = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_ultrasonics = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_additional = New DBA.Library.DBA_Label(Me.components)
        Me.grpbx_bay_temp = New DBA.Library.DBA_StyleGroupBox
        Me.lbl_bay_temp_dis = New DBA.Library.DBA_Label(Me.components)
        Me.prog_bay_temp = New DBA.Library.DBA_ProgressBar
        Me.grpbx_res_temp = New DBA.Library.DBA_StyleGroupBox
        Me.lbl_res_temp_dis = New DBA.Library.DBA_Label(Me.components)
        Me.prog_res_temp = New DBA.Library.DBA_ProgressBar
        Me.lbl_left = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_completed = New DBA.Library.DBA_Label(Me.components)
        Me.DbA_Label4 = New DBA.Library.DBA_Label(Me.components)
        Me.DbA_Label2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_stage = New DBA.Library.DBA_Label(Me.components)
        Me.prog_overall = New DBA.Library.DBA_ProgressBar
        Me.pnl_main_buttons = New DBA.Library.DBA_Panel
        Me.chk_lub = New DBA.Library.DBA_CheckBox
        Me.btn_sub2 = New DBA.Library.DBA_Button(Me.components)
        Me.btn_sub1 = New DBA.Library.DBA_Button(Me.components)
        Me.btn_main = New DBA.Library.DBA_Button(Me.components)
        Me.btn_return = New DBA.Library.DBA_Button(Me.components)
        Me.btn_purge = New DBA.Library.DBA_Button(Me.components)
        Me.btn_empty = New DBA.Library.DBA_Button(Me.components)
        Me.btn_system = New DBA.Library.DBA_Button(Me.components)
        Me.btn_patient = New DBA.Library.DBA_Button(Me.components)
        Me.pnl_additional = New DBA.Library.DBA_Panel
        Me.grd_display = New DBA.Library.DBA_StyleGrid
        Me.dataRowTemplate1 = New Xceed.Grid.DataRow
        Me.GroupByRow1 = New Xceed.Grid.GroupByRow
        Me.ColumnManagerRow1 = New Xceed.Grid.ColumnManagerRow
        Me.btn_finish = New DBA.Library.DBA_Button(Me.components)
        Me.btn_print = New DBA.Library.DBA_Button(Me.components)
        Me.btn_additional = New DBA.Library.DBA_Button(Me.components)
        Me.btn_cancel = New DBA.Library.DBA_Button(Me.components)
        Me.lbl_lub = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_error = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_info2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_info1 = New DBA.Library.DBA_Label(Me.components)
        Me.grpbx_inputs = New DBA.Library.DBA_StyleGroupBox
        Me.lbl_input_ultrasonics = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_input_safety = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_input_float = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_input_water = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_input_flow = New DBA.Library.DBA_Label(Me.components)
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_main.SuspendLayout()
        Me.grpbx_outputs.SuspendLayout()
        Me.grpbx_bay_temp.SuspendLayout()
        Me.grpbx_res_temp.SuspendLayout()
        Me.pnl_main_buttons.SuspendLayout()
        Me.pnl_additional.SuspendLayout()
        CType(Me.grd_display, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataRowTemplate1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColumnManagerRow1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbx_inputs.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_main
        '
        Me.pnl_main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_main.Controls.Add(Me.lbl_disinfect_lot)
        Me.pnl_main.Controls.Add(Me.lbl_process_num)
        Me.pnl_main.Controls.Add(Me.lbl_count)
        Me.pnl_main.Controls.Add(Me.lbl_info)
        Me.pnl_main.Controls.Add(Me.txt_notes)
        Me.pnl_main.Controls.Add(Me.lbl_machine_name)
        Me.pnl_main.Controls.Add(Me.prog_run)
        Me.pnl_main.Controls.Add(Me.btn_close)
        Me.pnl_main.Controls.Add(Me.grpbx_outputs)
        Me.pnl_main.Controls.Add(Me.grpbx_bay_temp)
        Me.pnl_main.Controls.Add(Me.grpbx_res_temp)
        Me.pnl_main.Controls.Add(Me.lbl_left)
        Me.pnl_main.Controls.Add(Me.lbl_completed)
        Me.pnl_main.Controls.Add(Me.DbA_Label4)
        Me.pnl_main.Controls.Add(Me.DbA_Label2)
        Me.pnl_main.Controls.Add(Me.lbl_stage)
        Me.pnl_main.Controls.Add(Me.prog_overall)
        Me.pnl_main.Controls.Add(Me.pnl_main_buttons)
        Me.pnl_main.Controls.Add(Me.pnl_additional)
        Me.pnl_main.Controls.Add(Me.lbl_info2)
        Me.pnl_main.Controls.Add(Me.lbl_info1)
        Me.pnl_main.Controls.Add(Me.grpbx_inputs)
        Me.pnl_main.DataSettings.IDField = Nothing
        Me.pnl_main.DataSettings.JoinData = Nothing
        Me.pnl_main.DataSettings.LinkField = Nothing
        Me.pnl_main.DataSettings.TableName = Nothing
        Me.pnl_main.Gradient = False
        Me.pnl_main.Location = New System.Drawing.Point(0, 0)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.RecordID = Nothing
        Me.pnl_main.Saved = False
        Me.pnl_main.Size = New System.Drawing.Size(778, 503)
        Me.pnl_main.TabIndex = 0
        '
        'lbl_disinfect_lot
        '
        Me.lbl_disinfect_lot.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_disinfect_lot.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_disinfect_lot.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_disinfect_lot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_disinfect_lot.Location = New System.Drawing.Point(647, 158)
        Me.lbl_disinfect_lot.Name = "lbl_disinfect_lot"
        Me.lbl_disinfect_lot.Size = New System.Drawing.Size(105, 21)
        Me.lbl_disinfect_lot.TabIndex = 30
        Me.lbl_disinfect_lot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_disinfect_lot.UseMnemonic = False
        '
        'lbl_process_num
        '
        Me.lbl_process_num.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_process_num.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_process_num.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_process_num.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_process_num.Location = New System.Drawing.Point(647, 124)
        Me.lbl_process_num.Name = "lbl_process_num"
        Me.lbl_process_num.Size = New System.Drawing.Size(105, 21)
        Me.lbl_process_num.TabIndex = 32
        Me.lbl_process_num.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_process_num.UseMnemonic = False
        '
        'lbl_count
        '
        Me.lbl_count.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_count.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_count.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_count.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_count.Location = New System.Drawing.Point(349, 323)
        Me.lbl_count.Name = "lbl_count"
        Me.lbl_count.Size = New System.Drawing.Size(166, 21)
        Me.lbl_count.TabIndex = 29
        Me.lbl_count.Text = "0 - Procedure(s) Entered"
        Me.lbl_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_count.UseMnemonic = False
        '
        'lbl_info
        '
        Me.lbl_info.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_info.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_info.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info.ForeColor = System.Drawing.Color.Black
        Me.lbl_info.Location = New System.Drawing.Point(18, 323)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(160, 21)
        Me.lbl_info.TabIndex = 28
        Me.lbl_info.Text = "Press N key to Enter Notes."
        Me.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_info.UseMnemonic = False
        '
        'txt_notes
        '
        Me.txt_notes.AllowNegative = False
        Me.txt_notes.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_notes.ColorCursor = True
        Me.txt_notes.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_notes.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_notes.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_notes.Field_Name = ""
        Me.txt_notes.GridBinding = Nothing
        Me.txt_notes.Label_On_Top = False
        Me.txt_notes.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_notes.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_notes.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_notes.Label_Properties.Text = "Prev Notes"
        Me.txt_notes.Label_Properties.Width = 0
        Me.txt_notes.Location = New System.Drawing.Point(726, 322)
        Me.txt_notes.Mandatory = False
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.Override_Modified = False
        Me.txt_notes.SaveLoadOrder = 0
        Me.txt_notes.Size = New System.Drawing.Size(43, 26)
        Me.txt_notes.TabIndex = 26
        Me.txt_notes.TabStop = False
        Me.txt_notes.Tag = ""
        Me.txt_notes.Text = "DbA_TextBox1"
        Me.txt_notes.TextBox_Properties.AcceptsReturn = False
        Me.txt_notes.TextBox_Properties.AcceptsTab = False
        Me.txt_notes.TextBox_Properties.BackColor = System.Drawing.Color.Red
        Me.txt_notes.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txt_notes.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_notes.TextBox_Properties.Enabled = True
        Me.txt_notes.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_notes.TextBox_Properties.ForeColor = System.Drawing.Color.White
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
        Me.txt_notes.Visible = False
        '
        'lbl_machine_name
        '
        Me.lbl_machine_name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_machine_name.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_machine_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_machine_name.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_machine_name.ForeColor = System.Drawing.Color.Black
        Me.lbl_machine_name.Location = New System.Drawing.Point(16, 0)
        Me.lbl_machine_name.Name = "lbl_machine_name"
        Me.lbl_machine_name.Size = New System.Drawing.Size(740, 40)
        Me.lbl_machine_name.TabIndex = 24
        Me.lbl_machine_name.Text = "Machine Name"
        Me.lbl_machine_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_machine_name.UseMnemonic = False
        '
        'prog_run
        '
        Me.prog_run.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.prog_run.Border = System.Windows.Forms.BorderStyle.FixedSingle
        Me.prog_run.BorderColor = System.Drawing.Color.Black
        Me.prog_run.Bounce = False
        Me.prog_run.DisplayPercentText = False
        Me.prog_run.Location = New System.Drawing.Point(136, 80)
        Me.prog_run.Maximum = 100
        Me.prog_run.Minimum = 0
        Me.prog_run.Name = "prog_run"
        Me.prog_run.PercentTextColor = System.Drawing.Color.White
        Me.prog_run.PercentTextFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prog_run.ProgressBarColor = System.Drawing.Color.Blue
        Me.prog_run.Size = New System.Drawing.Size(493, 15)
        Me.prog_run.TabIndex = 12
        Me.prog_run.Text = "DbA_ProgressBar1"
        Me.prog_run.Value = 0
        Me.prog_run.VerticalDirection = False
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
        Me.btn_close.Location = New System.Drawing.Point(640, 49)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(111, 43)
        Me.btn_close.TabIndex = 11
        Me.btn_close.TabStop = False
        Me.btn_close.Text = "Close"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'grpbx_outputs
        '
        Me.grpbx_outputs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpbx_outputs.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpbx_outputs.Controls.Add(Me.lbl_dry_heat)
        Me.grpbx_outputs.Controls.Add(Me.lbl_enzyme_pump)
        Me.grpbx_outputs.Controls.Add(Me.lbl_detergent_pump)
        Me.grpbx_outputs.Controls.Add(Me.lbl_spray_rinse)
        Me.grpbx_outputs.Controls.Add(Me.lbl_lub_pump)
        Me.grpbx_outputs.Controls.Add(Me.lbl_air)
        Me.grpbx_outputs.Controls.Add(Me.lbl_residual_drain)
        Me.grpbx_outputs.Controls.Add(Me.lbl_res_return)
        Me.grpbx_outputs.Controls.Add(Me.lbl_res_feed)
        Me.grpbx_outputs.Controls.Add(Me.lbl_res_pump)
        Me.grpbx_outputs.Controls.Add(Me.lbl_osc_pump)
        Me.grpbx_outputs.Controls.Add(Me.lbl_water_valve)
        Me.grpbx_outputs.Controls.Add(Me.lbl_drain_valve)
        Me.grpbx_outputs.Controls.Add(Me.lbl_drain_pump)
        Me.grpbx_outputs.Controls.Add(Me.lbl_ultrasonics)
        Me.grpbx_outputs.Controls.Add(Me.lbl_additional)
        Me.grpbx_outputs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbx_outputs.ForeColor = System.Drawing.Color.Black
        Me.grpbx_outputs.LineColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grpbx_outputs.Location = New System.Drawing.Point(136, 223)
        Me.grpbx_outputs.Name = "grpbx_outputs"
        Me.grpbx_outputs.Size = New System.Drawing.Size(619, 100)
        Me.grpbx_outputs.TabIndex = 10
        Me.grpbx_outputs.TabStop = False
        Me.grpbx_outputs.Text = "Outputs"
        '
        'lbl_dry_heat
        '
        Me.lbl_dry_heat.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_dry_heat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_dry_heat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dry_heat.ForeColor = System.Drawing.Color.Black
        Me.lbl_dry_heat.Location = New System.Drawing.Point(489, 73)
        Me.lbl_dry_heat.Name = "lbl_dry_heat"
        Me.lbl_dry_heat.Size = New System.Drawing.Size(115, 22)
        Me.lbl_dry_heat.TabIndex = 37
        Me.lbl_dry_heat.Text = "Drying Heat"
        Me.lbl_dry_heat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_dry_heat.UseMnemonic = False
        Me.lbl_dry_heat.Visible = False
        '
        'lbl_enzyme_pump
        '
        Me.lbl_enzyme_pump.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_enzyme_pump.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_enzyme_pump.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_enzyme_pump.ForeColor = System.Drawing.Color.Black
        Me.lbl_enzyme_pump.Location = New System.Drawing.Point(371, 73)
        Me.lbl_enzyme_pump.Name = "lbl_enzyme_pump"
        Me.lbl_enzyme_pump.Size = New System.Drawing.Size(115, 22)
        Me.lbl_enzyme_pump.TabIndex = 35
        Me.lbl_enzyme_pump.Text = "Enzyme Pump"
        Me.lbl_enzyme_pump.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_enzyme_pump.UseMnemonic = False
        Me.lbl_enzyme_pump.Visible = False
        '
        'lbl_detergent_pump
        '
        Me.lbl_detergent_pump.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_detergent_pump.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_detergent_pump.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_detergent_pump.ForeColor = System.Drawing.Color.Black
        Me.lbl_detergent_pump.Location = New System.Drawing.Point(253, 73)
        Me.lbl_detergent_pump.Name = "lbl_detergent_pump"
        Me.lbl_detergent_pump.Size = New System.Drawing.Size(115, 22)
        Me.lbl_detergent_pump.TabIndex = 34
        Me.lbl_detergent_pump.Text = "Detergent Pump"
        Me.lbl_detergent_pump.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_detergent_pump.UseMnemonic = False
        Me.lbl_detergent_pump.Visible = False
        '
        'lbl_spray_rinse
        '
        Me.lbl_spray_rinse.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_spray_rinse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_spray_rinse.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_spray_rinse.ForeColor = System.Drawing.Color.Black
        Me.lbl_spray_rinse.Location = New System.Drawing.Point(135, 73)
        Me.lbl_spray_rinse.Name = "lbl_spray_rinse"
        Me.lbl_spray_rinse.Size = New System.Drawing.Size(115, 22)
        Me.lbl_spray_rinse.TabIndex = 33
        Me.lbl_spray_rinse.Text = "Spray Rinse"
        Me.lbl_spray_rinse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_spray_rinse.UseMnemonic = False
        Me.lbl_spray_rinse.Visible = False
        '
        'lbl_lub_pump
        '
        Me.lbl_lub_pump.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_lub_pump.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_lub_pump.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lub_pump.ForeColor = System.Drawing.Color.Black
        Me.lbl_lub_pump.Location = New System.Drawing.Point(17, 73)
        Me.lbl_lub_pump.Name = "lbl_lub_pump"
        Me.lbl_lub_pump.Size = New System.Drawing.Size(115, 22)
        Me.lbl_lub_pump.TabIndex = 32
        Me.lbl_lub_pump.Text = "Lubrication Pump"
        Me.lbl_lub_pump.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_lub_pump.UseMnemonic = False
        Me.lbl_lub_pump.Visible = False
        '
        'lbl_air
        '
        Me.lbl_air.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_air.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_air.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_air.ForeColor = System.Drawing.Color.Black
        Me.lbl_air.Location = New System.Drawing.Point(489, 48)
        Me.lbl_air.Name = "lbl_air"
        Me.lbl_air.Size = New System.Drawing.Size(115, 22)
        Me.lbl_air.TabIndex = 31
        Me.lbl_air.Text = "Air"
        Me.lbl_air.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_air.UseMnemonic = False
        '
        'lbl_residual_drain
        '
        Me.lbl_residual_drain.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_residual_drain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_residual_drain.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_residual_drain.ForeColor = System.Drawing.Color.Black
        Me.lbl_residual_drain.Location = New System.Drawing.Point(371, 48)
        Me.lbl_residual_drain.Name = "lbl_residual_drain"
        Me.lbl_residual_drain.Size = New System.Drawing.Size(115, 22)
        Me.lbl_residual_drain.TabIndex = 30
        Me.lbl_residual_drain.Text = "Residual Drain"
        Me.lbl_residual_drain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_residual_drain.UseMnemonic = False
        '
        'lbl_res_return
        '
        Me.lbl_res_return.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_res_return.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_res_return.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_res_return.ForeColor = System.Drawing.Color.Black
        Me.lbl_res_return.Location = New System.Drawing.Point(253, 48)
        Me.lbl_res_return.Name = "lbl_res_return"
        Me.lbl_res_return.Size = New System.Drawing.Size(115, 22)
        Me.lbl_res_return.TabIndex = 29
        Me.lbl_res_return.Text = "Reservoir Return"
        Me.lbl_res_return.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_res_return.UseMnemonic = False
        '
        'lbl_res_feed
        '
        Me.lbl_res_feed.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_res_feed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_res_feed.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_res_feed.ForeColor = System.Drawing.Color.Black
        Me.lbl_res_feed.Location = New System.Drawing.Point(135, 48)
        Me.lbl_res_feed.Name = "lbl_res_feed"
        Me.lbl_res_feed.Size = New System.Drawing.Size(115, 22)
        Me.lbl_res_feed.TabIndex = 28
        Me.lbl_res_feed.Text = "Reservoir Feed"
        Me.lbl_res_feed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_res_feed.UseMnemonic = False
        '
        'lbl_res_pump
        '
        Me.lbl_res_pump.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_res_pump.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_res_pump.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_res_pump.ForeColor = System.Drawing.Color.Black
        Me.lbl_res_pump.Location = New System.Drawing.Point(17, 48)
        Me.lbl_res_pump.Name = "lbl_res_pump"
        Me.lbl_res_pump.Size = New System.Drawing.Size(115, 22)
        Me.lbl_res_pump.TabIndex = 27
        Me.lbl_res_pump.Text = "Reservoir Pump"
        Me.lbl_res_pump.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_res_pump.UseMnemonic = False
        '
        'lbl_osc_pump
        '
        Me.lbl_osc_pump.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_osc_pump.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_osc_pump.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_osc_pump.ForeColor = System.Drawing.Color.Black
        Me.lbl_osc_pump.Location = New System.Drawing.Point(489, 23)
        Me.lbl_osc_pump.Name = "lbl_osc_pump"
        Me.lbl_osc_pump.Size = New System.Drawing.Size(115, 22)
        Me.lbl_osc_pump.TabIndex = 26
        Me.lbl_osc_pump.Text = "Oscillating Pump"
        Me.lbl_osc_pump.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_osc_pump.UseMnemonic = False
        '
        'lbl_water_valve
        '
        Me.lbl_water_valve.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_water_valve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_water_valve.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_water_valve.ForeColor = System.Drawing.Color.Black
        Me.lbl_water_valve.Location = New System.Drawing.Point(371, 23)
        Me.lbl_water_valve.Name = "lbl_water_valve"
        Me.lbl_water_valve.Size = New System.Drawing.Size(115, 22)
        Me.lbl_water_valve.TabIndex = 25
        Me.lbl_water_valve.Text = "Water Valve"
        Me.lbl_water_valve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_water_valve.UseMnemonic = False
        '
        'lbl_drain_valve
        '
        Me.lbl_drain_valve.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_drain_valve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_drain_valve.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_drain_valve.ForeColor = System.Drawing.Color.Black
        Me.lbl_drain_valve.Location = New System.Drawing.Point(253, 23)
        Me.lbl_drain_valve.Name = "lbl_drain_valve"
        Me.lbl_drain_valve.Size = New System.Drawing.Size(115, 22)
        Me.lbl_drain_valve.TabIndex = 24
        Me.lbl_drain_valve.Text = "Drain Valve"
        Me.lbl_drain_valve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_drain_valve.UseMnemonic = False
        '
        'lbl_drain_pump
        '
        Me.lbl_drain_pump.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_drain_pump.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_drain_pump.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_drain_pump.ForeColor = System.Drawing.Color.Black
        Me.lbl_drain_pump.Location = New System.Drawing.Point(135, 23)
        Me.lbl_drain_pump.Name = "lbl_drain_pump"
        Me.lbl_drain_pump.Size = New System.Drawing.Size(115, 22)
        Me.lbl_drain_pump.TabIndex = 23
        Me.lbl_drain_pump.Text = "Drain Pump"
        Me.lbl_drain_pump.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_drain_pump.UseMnemonic = False
        '
        'lbl_ultrasonics
        '
        Me.lbl_ultrasonics.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_ultrasonics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ultrasonics.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ultrasonics.ForeColor = System.Drawing.Color.Black
        Me.lbl_ultrasonics.Location = New System.Drawing.Point(17, 23)
        Me.lbl_ultrasonics.Name = "lbl_ultrasonics"
        Me.lbl_ultrasonics.Size = New System.Drawing.Size(115, 22)
        Me.lbl_ultrasonics.TabIndex = 22
        Me.lbl_ultrasonics.Text = "Ultrasonics"
        Me.lbl_ultrasonics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_ultrasonics.UseMnemonic = False
        '
        'lbl_additional
        '
        Me.lbl_additional.BackColor = System.Drawing.Color.Green
        Me.lbl_additional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_additional.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_additional.ForeColor = System.Drawing.Color.White
        Me.lbl_additional.Location = New System.Drawing.Point(371, 73)
        Me.lbl_additional.Name = "lbl_additional"
        Me.lbl_additional.Size = New System.Drawing.Size(233, 22)
        Me.lbl_additional.TabIndex = 36
        Me.lbl_additional.Text = "Additional"
        Me.lbl_additional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_additional.UseMnemonic = False
        Me.lbl_additional.Visible = False
        '
        'grpbx_bay_temp
        '
        Me.grpbx_bay_temp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpbx_bay_temp.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpbx_bay_temp.Controls.Add(Me.lbl_bay_temp_dis)
        Me.grpbx_bay_temp.Controls.Add(Me.prog_bay_temp)
        Me.grpbx_bay_temp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbx_bay_temp.ForeColor = System.Drawing.Color.Black
        Me.grpbx_bay_temp.LineColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grpbx_bay_temp.Location = New System.Drawing.Point(536, 418)
        Me.grpbx_bay_temp.Name = "grpbx_bay_temp"
        Me.grpbx_bay_temp.Size = New System.Drawing.Size(221, 66)
        Me.grpbx_bay_temp.TabIndex = 8
        Me.grpbx_bay_temp.TabStop = False
        Me.grpbx_bay_temp.Text = "Bay Temperature (°C)"
        Me.grpbx_bay_temp.Visible = False
        '
        'lbl_bay_temp_dis
        '
        Me.lbl_bay_temp_dis.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_bay_temp_dis.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bay_temp_dis.ForeColor = System.Drawing.Color.Black
        Me.lbl_bay_temp_dis.Location = New System.Drawing.Point(10, 24)
        Me.lbl_bay_temp_dis.Name = "lbl_bay_temp_dis"
        Me.lbl_bay_temp_dis.Size = New System.Drawing.Size(201, 16)
        Me.lbl_bay_temp_dis.TabIndex = 5
        Me.lbl_bay_temp_dis.Text = "-"
        Me.lbl_bay_temp_dis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_bay_temp_dis.UseMnemonic = False
        '
        'prog_bay_temp
        '
        Me.prog_bay_temp.Border = System.Windows.Forms.BorderStyle.FixedSingle
        Me.prog_bay_temp.BorderColor = System.Drawing.Color.Black
        Me.prog_bay_temp.Bounce = False
        Me.prog_bay_temp.DisplayPercentText = False
        Me.prog_bay_temp.Location = New System.Drawing.Point(10, 44)
        Me.prog_bay_temp.Maximum = 100
        Me.prog_bay_temp.Minimum = 0
        Me.prog_bay_temp.Name = "prog_bay_temp"
        Me.prog_bay_temp.PercentTextColor = System.Drawing.Color.White
        Me.prog_bay_temp.PercentTextFont = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.prog_bay_temp.ProgressBarColor = System.Drawing.Color.Blue
        Me.prog_bay_temp.Size = New System.Drawing.Size(201, 16)
        Me.prog_bay_temp.TabIndex = 4
        Me.prog_bay_temp.Text = "DbA_ProgressBar3"
        Me.prog_bay_temp.Value = 0
        Me.prog_bay_temp.VerticalDirection = False
        '
        'grpbx_res_temp
        '
        Me.grpbx_res_temp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpbx_res_temp.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpbx_res_temp.Controls.Add(Me.lbl_res_temp_dis)
        Me.grpbx_res_temp.Controls.Add(Me.prog_res_temp)
        Me.grpbx_res_temp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbx_res_temp.ForeColor = System.Drawing.Color.Black
        Me.grpbx_res_temp.LineColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grpbx_res_temp.Location = New System.Drawing.Point(536, 340)
        Me.grpbx_res_temp.Name = "grpbx_res_temp"
        Me.grpbx_res_temp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpbx_res_temp.Size = New System.Drawing.Size(221, 66)
        Me.grpbx_res_temp.TabIndex = 7
        Me.grpbx_res_temp.TabStop = False
        Me.grpbx_res_temp.Text = "Reservoir Temperature (°C)"
        Me.grpbx_res_temp.Visible = False
        '
        'lbl_res_temp_dis
        '
        Me.lbl_res_temp_dis.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_res_temp_dis.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_res_temp_dis.ForeColor = System.Drawing.Color.Black
        Me.lbl_res_temp_dis.Location = New System.Drawing.Point(10, 24)
        Me.lbl_res_temp_dis.Name = "lbl_res_temp_dis"
        Me.lbl_res_temp_dis.Size = New System.Drawing.Size(201, 16)
        Me.lbl_res_temp_dis.TabIndex = 3
        Me.lbl_res_temp_dis.Text = "-"
        Me.lbl_res_temp_dis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_res_temp_dis.UseMnemonic = False
        '
        'prog_res_temp
        '
        Me.prog_res_temp.Border = System.Windows.Forms.BorderStyle.FixedSingle
        Me.prog_res_temp.BorderColor = System.Drawing.Color.Black
        Me.prog_res_temp.Bounce = False
        Me.prog_res_temp.DisplayPercentText = False
        Me.prog_res_temp.Location = New System.Drawing.Point(10, 44)
        Me.prog_res_temp.Maximum = 100
        Me.prog_res_temp.Minimum = 0
        Me.prog_res_temp.Name = "prog_res_temp"
        Me.prog_res_temp.PercentTextColor = System.Drawing.Color.White
        Me.prog_res_temp.PercentTextFont = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.prog_res_temp.ProgressBarColor = System.Drawing.Color.Blue
        Me.prog_res_temp.Size = New System.Drawing.Size(201, 16)
        Me.prog_res_temp.TabIndex = 0
        Me.prog_res_temp.Text = "DbA_ProgressBar2"
        Me.prog_res_temp.Value = 0
        Me.prog_res_temp.VerticalDirection = False
        '
        'lbl_left
        '
        Me.lbl_left.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_left.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_left.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_left.ForeColor = System.Drawing.Color.Black
        Me.lbl_left.Location = New System.Drawing.Point(552, 112)
        Me.lbl_left.Name = "lbl_left"
        Me.lbl_left.Size = New System.Drawing.Size(80, 37)
        Me.lbl_left.TabIndex = 6
        Me.lbl_left.Text = "-"
        Me.lbl_left.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_left.UseMnemonic = False
        '
        'lbl_completed
        '
        Me.lbl_completed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_completed.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_completed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_completed.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_completed.ForeColor = System.Drawing.Color.Black
        Me.lbl_completed.Location = New System.Drawing.Point(328, 111)
        Me.lbl_completed.Name = "lbl_completed"
        Me.lbl_completed.Size = New System.Drawing.Size(80, 37)
        Me.lbl_completed.TabIndex = 5
        Me.lbl_completed.Text = "-"
        Me.lbl_completed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_completed.UseMnemonic = False
        '
        'DbA_Label4
        '
        Me.DbA_Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DbA_Label4.BackColor = System.Drawing.Color.PapayaWhip
        Me.DbA_Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DbA_Label4.ForeColor = System.Drawing.Color.Black
        Me.DbA_Label4.Location = New System.Drawing.Point(424, 111)
        Me.DbA_Label4.Name = "DbA_Label4"
        Me.DbA_Label4.Size = New System.Drawing.Size(122, 37)
        Me.DbA_Label4.TabIndex = 4
        Me.DbA_Label4.Text = "Cycles Left"
        Me.DbA_Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DbA_Label4.UseMnemonic = False
        '
        'DbA_Label2
        '
        Me.DbA_Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DbA_Label2.BackColor = System.Drawing.Color.PapayaWhip
        Me.DbA_Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DbA_Label2.ForeColor = System.Drawing.Color.Black
        Me.DbA_Label2.Location = New System.Drawing.Point(144, 110)
        Me.DbA_Label2.Name = "DbA_Label2"
        Me.DbA_Label2.Size = New System.Drawing.Size(190, 37)
        Me.DbA_Label2.TabIndex = 2
        Me.DbA_Label2.Text = "Cycles Completed"
        Me.DbA_Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DbA_Label2.UseMnemonic = False
        '
        'lbl_stage
        '
        Me.lbl_stage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_stage.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_stage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_stage.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_stage.ForeColor = System.Drawing.Color.Black
        Me.lbl_stage.Location = New System.Drawing.Point(136, 49)
        Me.lbl_stage.Name = "lbl_stage"
        Me.lbl_stage.Size = New System.Drawing.Size(493, 30)
        Me.lbl_stage.TabIndex = 1
        Me.lbl_stage.Text = "Current Cycle"
        Me.lbl_stage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_stage.UseMnemonic = False
        '
        'prog_overall
        '
        Me.prog_overall.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.prog_overall.Border = System.Windows.Forms.BorderStyle.FixedSingle
        Me.prog_overall.BorderColor = System.Drawing.Color.Black
        Me.prog_overall.Bounce = False
        Me.prog_overall.DisplayPercentText = True
        Me.prog_overall.Location = New System.Drawing.Point(16, 48)
        Me.prog_overall.Maximum = 100
        Me.prog_overall.Minimum = 0
        Me.prog_overall.Name = "prog_overall"
        Me.prog_overall.PercentTextColor = System.Drawing.Color.White
        Me.prog_overall.PercentTextFont = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prog_overall.ProgressBarColor = System.Drawing.Color.Blue
        Me.prog_overall.Size = New System.Drawing.Size(105, 274)
        Me.prog_overall.TabIndex = 0
        Me.prog_overall.Text = "DbA_ProgressBar1"
        Me.prog_overall.Value = 0
        Me.prog_overall.VerticalDirection = True
        '
        'pnl_main_buttons
        '
        Me.pnl_main_buttons.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnl_main_buttons.Controls.Add(Me.chk_lub)
        Me.pnl_main_buttons.Controls.Add(Me.btn_sub2)
        Me.pnl_main_buttons.Controls.Add(Me.btn_sub1)
        Me.pnl_main_buttons.Controls.Add(Me.btn_main)
        Me.pnl_main_buttons.Controls.Add(Me.btn_return)
        Me.pnl_main_buttons.Controls.Add(Me.btn_purge)
        Me.pnl_main_buttons.Controls.Add(Me.btn_empty)
        Me.pnl_main_buttons.Controls.Add(Me.btn_system)
        Me.pnl_main_buttons.Controls.Add(Me.btn_patient)
        Me.pnl_main_buttons.DataSettings.IDField = Nothing
        Me.pnl_main_buttons.DataSettings.JoinData = Nothing
        Me.pnl_main_buttons.DataSettings.LinkField = Nothing
        Me.pnl_main_buttons.DataSettings.TableName = Nothing
        Me.pnl_main_buttons.Gradient = False
        Me.pnl_main_buttons.Location = New System.Drawing.Point(8, 336)
        Me.pnl_main_buttons.Name = "pnl_main_buttons"
        Me.pnl_main_buttons.RecordID = Nothing
        Me.pnl_main_buttons.Saved = False
        Me.pnl_main_buttons.Size = New System.Drawing.Size(511, 152)
        Me.pnl_main_buttons.TabIndex = 22
        '
        'chk_lub
        '
        Me.chk_lub.BackColor = System.Drawing.Color.PapayaWhip
        Me.chk_lub.Caption = "DBA"
        Me.chk_lub.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chk_lub.Field_Name = ""
        Me.chk_lub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_lub.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chk_lub.ForeColor = System.Drawing.Color.Black
        Me.chk_lub.GridBinding = Nothing
        Me.chk_lub.Location = New System.Drawing.Point(367, 20)
        Me.chk_lub.Mandatory = False
        Me.chk_lub.Name = "chk_lub"
        Me.chk_lub.SaveLoadOrder = 0
        Me.chk_lub.Size = New System.Drawing.Size(121, 19)
        Me.chk_lub.TabIndex = 30
        Me.chk_lub.Text = "With &Lubrication"
        Me.chk_lub.UseVisualStyleBackColor = False
        Me.chk_lub.Visible = False
        '
        'btn_sub2
        '
        Me.btn_sub2.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_sub2.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_sub2.DisplayText = ""
        Me.btn_sub2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_sub2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sub2.ForeColor = System.Drawing.Color.Black
        Me.btn_sub2.Image = CType(resources.GetObject("btn_sub2.Image"), System.Drawing.Image)
        Me.btn_sub2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sub2.Location = New System.Drawing.Point(341, 102)
        Me.btn_sub2.Name = "btn_sub2"
        Me.btn_sub2.Size = New System.Drawing.Size(164, 43)
        Me.btn_sub2.TabIndex = 29
        Me.btn_sub2.TabStop = False
        Me.btn_sub2.Text = "Sub2"
        Me.btn_sub2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_sub2.UseVisualStyleBackColor = False
        Me.btn_sub2.Visible = False
        '
        'btn_sub1
        '
        Me.btn_sub1.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_sub1.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_sub1.DisplayText = ""
        Me.btn_sub1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_sub1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sub1.ForeColor = System.Drawing.Color.Black
        Me.btn_sub1.Image = CType(resources.GetObject("btn_sub1.Image"), System.Drawing.Image)
        Me.btn_sub1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sub1.Location = New System.Drawing.Point(173, 102)
        Me.btn_sub1.Name = "btn_sub1"
        Me.btn_sub1.Size = New System.Drawing.Size(164, 43)
        Me.btn_sub1.TabIndex = 28
        Me.btn_sub1.TabStop = False
        Me.btn_sub1.Text = "Sub1"
        Me.btn_sub1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_sub1.UseVisualStyleBackColor = False
        Me.btn_sub1.Visible = False
        '
        'btn_main
        '
        Me.btn_main.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_main.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_main.DisplayText = ""
        Me.btn_main.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_main.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_main.ForeColor = System.Drawing.Color.Black
        Me.btn_main.Image = CType(resources.GetObject("btn_main.Image"), System.Drawing.Image)
        Me.btn_main.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_main.Location = New System.Drawing.Point(5, 102)
        Me.btn_main.Name = "btn_main"
        Me.btn_main.Size = New System.Drawing.Size(164, 43)
        Me.btn_main.TabIndex = 27
        Me.btn_main.TabStop = False
        Me.btn_main.Text = "Main"
        Me.btn_main.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_main.UseVisualStyleBackColor = False
        '
        'btn_return
        '
        Me.btn_return.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_return.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_return.DisplayText = ""
        Me.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_return.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_return.ForeColor = System.Drawing.Color.Black
        Me.btn_return.Image = CType(resources.GetObject("btn_return.Image"), System.Drawing.Image)
        Me.btn_return.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_return.Location = New System.Drawing.Point(341, 55)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(164, 43)
        Me.btn_return.TabIndex = 26
        Me.btn_return.TabStop = False
        Me.btn_return.Text = "Return Disinfectant"
        Me.btn_return.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_return.UseVisualStyleBackColor = False
        '
        'btn_purge
        '
        Me.btn_purge.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_purge.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_purge.DisplayText = ""
        Me.btn_purge.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_purge.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_purge.ForeColor = System.Drawing.Color.Black
        Me.btn_purge.Image = CType(resources.GetObject("btn_purge.Image"), System.Drawing.Image)
        Me.btn_purge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_purge.Location = New System.Drawing.Point(173, 55)
        Me.btn_purge.Name = "btn_purge"
        Me.btn_purge.Size = New System.Drawing.Size(164, 43)
        Me.btn_purge.TabIndex = 25
        Me.btn_purge.TabStop = False
        Me.btn_purge.Text = "Purge System"
        Me.btn_purge.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_purge.UseVisualStyleBackColor = False
        '
        'btn_empty
        '
        Me.btn_empty.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_empty.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_empty.DisplayText = ""
        Me.btn_empty.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_empty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_empty.ForeColor = System.Drawing.Color.Black
        Me.btn_empty.Image = CType(resources.GetObject("btn_empty.Image"), System.Drawing.Image)
        Me.btn_empty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_empty.Location = New System.Drawing.Point(5, 55)
        Me.btn_empty.Name = "btn_empty"
        Me.btn_empty.Size = New System.Drawing.Size(164, 43)
        Me.btn_empty.TabIndex = 24
        Me.btn_empty.TabStop = False
        Me.btn_empty.Text = "Empty Chamber"
        Me.btn_empty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_empty.UseVisualStyleBackColor = False
        '
        'btn_system
        '
        Me.btn_system.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_system.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_system.DisplayText = ""
        Me.btn_system.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_system.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_system.ForeColor = System.Drawing.Color.Black
        Me.btn_system.Image = CType(resources.GetObject("btn_system.Image"), System.Drawing.Image)
        Me.btn_system.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_system.Location = New System.Drawing.Point(173, 8)
        Me.btn_system.Name = "btn_system"
        Me.btn_system.Size = New System.Drawing.Size(164, 43)
        Me.btn_system.TabIndex = 23
        Me.btn_system.TabStop = False
        Me.btn_system.Text = "System Data"
        Me.btn_system.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_system.UseVisualStyleBackColor = False
        '
        'btn_patient
        '
        Me.btn_patient.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_patient.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_patient.DisplayText = ""
        Me.btn_patient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_patient.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_patient.ForeColor = System.Drawing.Color.Black
        Me.btn_patient.Image = CType(resources.GetObject("btn_patient.Image"), System.Drawing.Image)
        Me.btn_patient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_patient.Location = New System.Drawing.Point(5, 8)
        Me.btn_patient.Name = "btn_patient"
        Me.btn_patient.Size = New System.Drawing.Size(164, 43)
        Me.btn_patient.TabIndex = 22
        Me.btn_patient.TabStop = False
        Me.btn_patient.Text = "Patient/Instrument"
        Me.btn_patient.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_patient.UseVisualStyleBackColor = False
        '
        'pnl_additional
        '
        Me.pnl_additional.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnl_additional.Controls.Add(Me.grd_display)
        Me.pnl_additional.Controls.Add(Me.btn_finish)
        Me.pnl_additional.Controls.Add(Me.btn_print)
        Me.pnl_additional.Controls.Add(Me.btn_additional)
        Me.pnl_additional.Controls.Add(Me.btn_cancel)
        Me.pnl_additional.Controls.Add(Me.lbl_lub)
        Me.pnl_additional.Controls.Add(Me.lbl_error)
        Me.pnl_additional.DataSettings.IDField = Nothing
        Me.pnl_additional.DataSettings.JoinData = Nothing
        Me.pnl_additional.DataSettings.LinkField = Nothing
        Me.pnl_additional.DataSettings.TableName = Nothing
        Me.pnl_additional.Gradient = False
        Me.pnl_additional.Location = New System.Drawing.Point(8, 336)
        Me.pnl_additional.Name = "pnl_additional"
        Me.pnl_additional.RecordID = Nothing
        Me.pnl_additional.Saved = False
        Me.pnl_additional.Size = New System.Drawing.Size(513, 153)
        Me.pnl_additional.TabIndex = 25
        Me.pnl_additional.Visible = False
        '
        'grd_display
        '
        Me.grd_display.AllowCellNavigation = False
        Me.grd_display.AllowGrouping = False
        Me.grd_display.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.grd_display.Location = New System.Drawing.Point(5, 56)
        Me.grd_display.Name = "grd_display"
        Me.grd_display.ReadOnly = True
        Me.grd_display.SelectionMode = System.Windows.Forms.SelectionMode.One
        Me.grd_display.Size = New System.Drawing.Size(500, 90)
        Me.grd_display.SQL = Nothing
        Me.grd_display.TabIndex = 6
        Me.grd_display.UIStyle = Xceed.UI.UIStyle.ResourceAssembly
        Me.grd_display.Visible = False
        '
        'GroupByRow1
        '
        Me.GroupByRow1.Visible = False
        '
        'btn_finish
        '
        Me.btn_finish.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_finish.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_finish.DisplayText = ""
        Me.btn_finish.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_finish.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_finish.ForeColor = System.Drawing.Color.Black
        Me.btn_finish.Image = CType(resources.GetObject("btn_finish.Image"), System.Drawing.Image)
        Me.btn_finish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_finish.Location = New System.Drawing.Point(341, 8)
        Me.btn_finish.Name = "btn_finish"
        Me.btn_finish.Size = New System.Drawing.Size(164, 43)
        Me.btn_finish.TabIndex = 26
        Me.btn_finish.TabStop = False
        Me.btn_finish.Text = "Finished"
        Me.btn_finish.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_finish.UseVisualStyleBackColor = False
        Me.btn_finish.Visible = False
        '
        'btn_print
        '
        Me.btn_print.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_print.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_print.DisplayText = ""
        Me.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_print.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ForeColor = System.Drawing.Color.Black
        Me.btn_print.Image = CType(resources.GetObject("btn_print.Image"), System.Drawing.Image)
        Me.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_print.Location = New System.Drawing.Point(173, 8)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(164, 43)
        Me.btn_print.TabIndex = 25
        Me.btn_print.TabStop = False
        Me.btn_print.Text = "Print Results"
        Me.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_print.UseVisualStyleBackColor = False
        Me.btn_print.Visible = False
        '
        'btn_additional
        '
        Me.btn_additional.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_additional.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_additional.DisplayText = ""
        Me.btn_additional.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_additional.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_additional.ForeColor = System.Drawing.Color.Black
        Me.btn_additional.Image = CType(resources.GetObject("btn_additional.Image"), System.Drawing.Image)
        Me.btn_additional.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_additional.Location = New System.Drawing.Point(5, 8)
        Me.btn_additional.Name = "btn_additional"
        Me.btn_additional.Size = New System.Drawing.Size(223, 43)
        Me.btn_additional.TabIndex = 23
        Me.btn_additional.TabStop = False
        Me.btn_additional.Text = "Additional"
        Me.btn_additional.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_additional.UseVisualStyleBackColor = False
        Me.btn_additional.Visible = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_cancel.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_cancel.DisplayText = ""
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(231, 8)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(143, 43)
        Me.btn_cancel.TabIndex = 24
        Me.btn_cancel.TabStop = False
        Me.btn_cancel.Text = "Cancel process"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancel.UseVisualStyleBackColor = False
        Me.btn_cancel.Visible = False
        '
        'lbl_lub
        '
        Me.lbl_lub.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_lub.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lub.ForeColor = System.Drawing.Color.Black
        Me.lbl_lub.Location = New System.Drawing.Point(384, 22)
        Me.lbl_lub.Name = "lbl_lub"
        Me.lbl_lub.Size = New System.Drawing.Size(107, 17)
        Me.lbl_lub.TabIndex = 24
        Me.lbl_lub.Text = "With Lubrication"
        Me.lbl_lub.UseMnemonic = False
        Me.lbl_lub.Visible = False
        '
        'lbl_error
        '
        Me.lbl_error.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_error.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_error.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_error.ForeColor = System.Drawing.Color.Black
        Me.lbl_error.Location = New System.Drawing.Point(5, 65)
        Me.lbl_error.Name = "lbl_error"
        Me.lbl_error.Size = New System.Drawing.Size(501, 83)
        Me.lbl_error.TabIndex = 27
        Me.lbl_error.UseMnemonic = False
        '
        'lbl_info2
        '
        Me.lbl_info2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_info2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_info2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info2.ForeColor = System.Drawing.Color.Black
        Me.lbl_info2.Location = New System.Drawing.Point(647, 107)
        Me.lbl_info2.Name = "lbl_info2"
        Me.lbl_info2.Size = New System.Drawing.Size(73, 21)
        Me.lbl_info2.TabIndex = 33
        Me.lbl_info2.Text = "Process #:"
        Me.lbl_info2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_info2.UseMnemonic = False
        '
        'lbl_info1
        '
        Me.lbl_info1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_info1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_info1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info1.ForeColor = System.Drawing.Color.Black
        Me.lbl_info1.Location = New System.Drawing.Point(647, 141)
        Me.lbl_info1.Name = "lbl_info1"
        Me.lbl_info1.Size = New System.Drawing.Size(100, 21)
        Me.lbl_info1.TabIndex = 31
        Me.lbl_info1.Text = "Disinfect Lot #:"
        Me.lbl_info1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_info1.UseMnemonic = False
        Me.lbl_info1.Visible = False
        '
        'grpbx_inputs
        '
        Me.grpbx_inputs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpbx_inputs.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpbx_inputs.Controls.Add(Me.lbl_input_ultrasonics)
        Me.grpbx_inputs.Controls.Add(Me.lbl_input_safety)
        Me.grpbx_inputs.Controls.Add(Me.lbl_input_float)
        Me.grpbx_inputs.Controls.Add(Me.lbl_input_water)
        Me.grpbx_inputs.Controls.Add(Me.lbl_input_flow)
        Me.grpbx_inputs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbx_inputs.ForeColor = System.Drawing.Color.Black
        Me.grpbx_inputs.LineColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.grpbx_inputs.Location = New System.Drawing.Point(136, 166)
        Me.grpbx_inputs.Name = "grpbx_inputs"
        Me.grpbx_inputs.Size = New System.Drawing.Size(619, 48)
        Me.grpbx_inputs.TabIndex = 9
        Me.grpbx_inputs.TabStop = False
        Me.grpbx_inputs.Text = "Inputs"
        '
        'lbl_input_ultrasonics
        '
        Me.lbl_input_ultrasonics.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_input_ultrasonics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_input_ultrasonics.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_input_ultrasonics.ForeColor = System.Drawing.Color.Black
        Me.lbl_input_ultrasonics.Location = New System.Drawing.Point(489, 22)
        Me.lbl_input_ultrasonics.Name = "lbl_input_ultrasonics"
        Me.lbl_input_ultrasonics.Size = New System.Drawing.Size(115, 22)
        Me.lbl_input_ultrasonics.TabIndex = 34
        Me.lbl_input_ultrasonics.Text = "Ultrasonics"
        Me.lbl_input_ultrasonics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_input_ultrasonics.UseMnemonic = False
        '
        'lbl_input_safety
        '
        Me.lbl_input_safety.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_input_safety.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_input_safety.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_input_safety.ForeColor = System.Drawing.Color.Black
        Me.lbl_input_safety.Location = New System.Drawing.Point(253, 22)
        Me.lbl_input_safety.Name = "lbl_input_safety"
        Me.lbl_input_safety.Size = New System.Drawing.Size(115, 22)
        Me.lbl_input_safety.TabIndex = 32
        Me.lbl_input_safety.Text = "Safety"
        Me.lbl_input_safety.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_input_safety.UseMnemonic = False
        '
        'lbl_input_float
        '
        Me.lbl_input_float.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_input_float.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_input_float.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_input_float.ForeColor = System.Drawing.Color.Black
        Me.lbl_input_float.Location = New System.Drawing.Point(135, 22)
        Me.lbl_input_float.Name = "lbl_input_float"
        Me.lbl_input_float.Size = New System.Drawing.Size(115, 22)
        Me.lbl_input_float.TabIndex = 31
        Me.lbl_input_float.Text = "Float"
        Me.lbl_input_float.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_input_float.UseMnemonic = False
        '
        'lbl_input_water
        '
        Me.lbl_input_water.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_input_water.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_input_water.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_input_water.ForeColor = System.Drawing.Color.Black
        Me.lbl_input_water.Location = New System.Drawing.Point(371, 22)
        Me.lbl_input_water.Name = "lbl_input_water"
        Me.lbl_input_water.Size = New System.Drawing.Size(115, 22)
        Me.lbl_input_water.TabIndex = 33
        Me.lbl_input_water.Text = "Water Channel"
        Me.lbl_input_water.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_input_water.UseMnemonic = False
        '
        'lbl_input_flow
        '
        Me.lbl_input_flow.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_input_flow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_input_flow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_input_flow.ForeColor = System.Drawing.Color.Black
        Me.lbl_input_flow.Location = New System.Drawing.Point(17, 22)
        Me.lbl_input_flow.Name = "lbl_input_flow"
        Me.lbl_input_flow.Size = New System.Drawing.Size(115, 22)
        Me.lbl_input_flow.TabIndex = 30
        Me.lbl_input_flow.Text = "Flow"
        Me.lbl_input_flow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_input_flow.UseMnemonic = False
        '
        'run_bay_detail
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(778, 500)
        Me.Controls.Add(Me.pnl_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "run_bay_detail"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "run_bay_detail"
        Me.TopMost = True
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_main.ResumeLayout(False)
        Me.grpbx_outputs.ResumeLayout(False)
        Me.grpbx_bay_temp.ResumeLayout(False)
        Me.grpbx_res_temp.ResumeLayout(False)
        Me.pnl_main_buttons.ResumeLayout(False)
        Me.pnl_additional.ResumeLayout(False)
        CType(Me.grd_display, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataRowTemplate1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColumnManagerRow1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbx_inputs.ResumeLayout(False)
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
            Case Keys.L  ' Set Lubrication Checkbox
                If pnl_main_buttons.Visible And chk_lub.Visible Then
                    chk_lub.Focus()
                End If

            Case Keys.F1  ' F1 Button - Patient / Stop Maintenance / Disinfect Check
                If pnl_main_buttons.Visible Then
                    Call Process("PATIENT")

                ElseIf pnl_additional.Visible Then
                    If btn_additional.Visible Then
                        Select Case UCase(btn_additional.Tag)
                            Case "PATIENT"
                                Call Process("PATIENT")

                            Case "ERROR"
                                Call Process("ERROR")

                            Case Else
                                Call Process("EXTRA")
                        End Select
                    End If
                End If

            Case Keys.F2  ' F2 Button - System Data
                If pnl_main_buttons.Visible Then Call Process("SYSTEM_DATA")

            Case Keys.F3  ' F3 Button - Empty Chamber / Print Results
                If pnl_main_buttons.Visible Then
                    Call Process("EMPTY")

                ElseIf pnl_additional.Visible Then
                    If btn_print.Visible And g_CUSMain.Machines(m_machine_index).Bay_Running = False Then
                        Call Process("PRINT")
                    End If
                End If

            Case Keys.F4  ' F4 Button - Purge System
                If pnl_main_buttons.Visible Then Call Process("PURGE")

            Case Keys.F5  ' F5 Button - Reservoir Return / Finished
                If pnl_main_buttons.Visible Then
                    Call Process("RETURN")

                ElseIf pnl_additional.Visible Then
                    If btn_finish.Visible And g_CUSMain.Machines(m_machine_index).Bay_Running = False Then
                        Call Process("FINISH")
                    End If
                End If

            Case Keys.F6  ' F6 Button - Main Profile
                If pnl_main_buttons.Visible Then Call Process("MAIN")

            Case Keys.F7  ' F7 Button - Sub1 Profile
                If pnl_main_buttons.Visible Then Call Process("SUB1")

            Case Keys.F8  ' F8 Button - Close
                If btn_close.Enabled Then Call Process("CLOSE")

            Case Keys.F9  ' F9 Button - Sub2 Profile
                If pnl_main_buttons.Visible Then Call Process("SUB2")

            Case Keys.F10 ' F10 Button - Cancel Disinfect
                If pnl_additional.Visible And btn_cancel.Visible Then
                    Call Process("CANCEL")
                End If

            Case Keys.N
                Call Process("NOTES")
        End Select

        Select Case keyCode
            Case Keys.L, Keys.F1, Keys.F2, Keys.F3,
                 Keys.F4, Keys.F5, Keys.F6, Keys.F7,
                 Keys.F8, Keys.F9, Keys.F10, Keys.N
                Return True
        End Select
    End Function
#End Region

#Region " Declarations "
    Public m_lbl_array As ArrayList
    Public m_machine_index As Integer

    Dim m_prev_function As String
    Dim m_button As String
    Dim m_run_header_id As String
    Dim m_run_user_id As String
    Dim m_update_flag As Boolean
#End Region

#Region " Button Clicks "

#Region " Main Buttons "
    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Call Process("CLOSE")
    End Sub

    Private Sub btn_patient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_patient.Click
        Call Process("PATIENT")
    End Sub

    Private Sub btn_system_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_system.Click
        Call Process("SYSTEM_DATA")
    End Sub

    Private Sub btn_empty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_empty.Click
        Call Process("EMPTY")
    End Sub

    Private Sub btn_purge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_purge.Click
        Call Process("PURGE")
    End Sub

    Private Sub btn_return_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_return.Click
        Call Process("RETURN")
    End Sub

    Private Sub btn_main_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_main.Click
        Call Process("MAIN")
    End Sub

    Private Sub btn_sub1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sub1.Click
        Call Process("SUB1")
    End Sub

    Private Sub btn_sub2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sub2.Click
        Call Process("SUB2")
    End Sub
#End Region

#Region " Additional Buttons "
    Private Sub btn_additional_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_additional.Click
        Select Case UCase(btn_additional.Tag)
            Case "PATIENT"
                Call Process("PATIENT")

            Case "ERROR"
                Call Process("ERROR")

            Case Else
                Call Process("EXTRA")
        End Select
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Call Process("CANCEL")
    End Sub

    Private Sub btn_print_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_print.Click
        If g_CUSMain.Machines(m_machine_index).Bay_Running = False Then
            Call Process("PRINT")
        End If
    End Sub

    Private Sub btn_finish_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_finish.Click
        If g_CUSMain.Machines(m_machine_index).Bay_Running = False Then
            Call Process("FINISH")
        End If
    End Sub
#End Region

#End Region

#Region " Do Output File "
    Private Sub do_output_file()
        Dim p_File As System.IO.TextWriter = Nothing

        Try
            ' ---------------------------
            ' * Check Network Path Format
            ' ---------------------------
            If g_file_output_path <> "" Then
                If Mid(g_file_output_path, Len(g_file_output_path), 1) <> "\" Then
                    g_file_output_path &= "\"
                End If
            End If

            ' --------------------------------
            ' * Create Output File for Process
            ' --------------------------------
            Dim p_string As String
            Dim p_bay As String = ""

            Dim p_path As String

            ' Get Data
            p_string = get_process_data_csv_file(m_run_header_id, p_bay)

            ' ------------------
            ' * Create File Path
            ' ------------------
            If Not System.IO.Directory.Exists(g_file_output_path & p_bay) Then
                System.IO.Directory.CreateDirectory(g_file_output_path & p_bay)
            End If

            p_path = g_file_output_path & p_bay & "\" & lbl_process_num.Text & ".csv"

            ' Open TextWriter
            p_File = System.IO.File.CreateText(p_path)

            'Write Out Data
            p_File.WriteLine(p_string)

        Catch
            ' ---------------------------
            ' * Catch File Creation Error
            ' ---------------------------
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Call message_box("Output File couldn't be created for process.", 4, "Output File Creation Error")

        Finally
            If Not p_File Is Nothing Then p_File.Close()
        End Try
    End Sub
#End Region

#Region " Fill Grid "
    Public Sub Fill_Grid()
        Dim p_sql As String                 ' String To Hold SQL Statement

        ' --------------------------
        ' * Load Bay Run Information
        ' --------------------------
        p_sql = "Select pre_run_id, P1.last_name + ', ' + P1.first_name + ' ' + P1.middle_initial As [Patient], " &
                "Case When PH1.prefix = '' Then '' Else PH1.prefix + ' ' End + " &
                "PH1.first_name + ' ' + Case When PH1.middle_initial = '' Then '' Else PH1.middle_initial + ' ' End " &
                "+ PH1.last_name + ' ' + PH1.suffix As [Physician], Instrument " &
                "FROM pre_run_info T1 " &
                "INNER JOIN instrument_maint I1 On I1.instrument_id = T1.instrument_id " &
                "LEFT JOIN patient_maint P1 On P1.patient_id = T1.patient_id " &
                "LEFT JOIN physician_maint PH1 On PH1.physician_id = P1.physician_id " &
                "Where bay_number = '" & m_machine_index + 1 &
                "' Order By P1.last_name, P1.first_name, P1.middle_initial, Instrument"
        grd_display.SQL = p_sql

        'fill the grid
        Me.dba_fill_grid(grd_display)

        If grd_display.DataRows.Count > 0 Then
            lbl_count.Text = grd_display.DataRows.Count & " - Procedures Entered"
        Else
            lbl_count.Text = "0 - Procedures Entered"
        End If
    End Sub
#End Region

#Region " Form Deactivate "
    Private Sub Form_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        If Not g_CUSMain.Machines(m_machine_index) Is Nothing Then
            If g_CUSMain.Machines(m_machine_index).Bay_Running Then
                prog_run.Bounce = False
            End If
        End If
    End Sub
#End Region

#Region " Form Activate/Enter "
    Private Sub Form_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated, MyBase.Enter
        pnl_main.Focus()
        If Not g_CUSMain.Machines(m_machine_index) Is Nothing Then
            If g_CUSMain.Machines(m_machine_index).Bay_Running Then
                prog_run.Bounce = True
            End If
        End If
    End Sub
#End Region

#Region " Form Load "
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' -----------------------
        ' * Display Disinfect Lot
        ' -----------------------
        If g_england_flag Then
            lbl_info1.Visible = True

            Select Case m_machine_index
                Case 0
                    lbl_disinfect_lot.Text = g_disinfect_lot1
                Case 1
                    lbl_disinfect_lot.Text = g_disinfect_lot2
                Case 2
                    lbl_disinfect_lot.Text = g_disinfect_lot3
                Case 3
                    lbl_disinfect_lot.Text = g_disinfect_lot4
            End Select
        End If

        ' ----------------------------
        ' * Disable Ultrasonics Sensor
        ' ----------------------------
        If Not g_us_usage Then
            lbl_input_ultrasonics.Visible = False
            grpbx_inputs.Width = 502
        End If

        ' -------------------
        ' * Disable F7 Button
        ' -------------------
        If g_hide_F7_flag Then
            btn_sub1.Visible = False
        End If

        ' ----------------------------
        ' * Disable F1 Button and Grid
        ' ----------------------------
        If g_override_patient_entry_flag Then
            btn_patient.Visible = False
            grd_display.Visible = False
            lbl_count.Visible = False

            btn_system.Left = btn_patient.Left
        End If

        ' -----------------------------
        ' * Get Temperature Information
        ' -----------------------------
        Call initialize_Temperature()

        ' --------------------
        ' * Get IO Information
        ' --------------------
        If Not g_demo_mode_flag Then
            Call initialize_IO()
        End If
    End Sub
#End Region

#Region " Get Demo Temperatures "
    Private Sub get_demo_temps(ByVal p_value As String, ByVal p_value2 As String)
        ' -----------------------
        ' * Get Demo Temperatures
        ' -----------------------
        lbl_res_temp_dis.Text = p_value
        prog_res_temp.Value = p_value

        lbl_bay_temp_dis.Text = p_value2
        prog_bay_temp.Value = p_value2

        lbl_res_temp_dis.Refresh()
        prog_res_temp.Refresh()

        lbl_bay_temp_dis.Refresh()
        prog_bay_temp.Refresh()
    End Sub
#End Region

#Region " Get Numbering "
    Private Sub get_process_num(ByVal p_mode As String)
        Dim p_sql As String
        Dim p_dataset As DataSet
        Dim p_count As Integer

        ' ==============================
        ' * Get Last Completed Process #
        ' ==============================
        p_sql = "SELECT IsNull(Max(process_num), 0) " &
                "FROM run_info_header " &
                "WHERE error IS NULL AND demo_mode = 0 " &
                "And end_time Is Not Null " &
                "And run_header_id <> '" & m_run_header_id & "'; "

        ' ===========================
        ' * Get Running Process Count
        ' ===========================
        If p_mode = "START" Then
            p_sql &= "SELECT Count(*) " &
                     "FROM run_info_header " &
                     "WHERE error IS NULL " &
                     "And start_time Is Not Null And end_time Is Null " &
                     "And run_header_id <> '" & m_run_header_id & "'; "
        End If

        p_dataset = g_framework.Get_Data(p_sql)

        ' ----------------
        ' * Get Count Info
        ' ----------------
        p_count = p_dataset.Tables(0).Rows(0).Item(0)
        If p_mode = "START" Then
            p_count += p_dataset.Tables(1).Rows(0).Item(0)
        End If

        ' -----------------
        ' * Display Results
        ' -----------------
        lbl_process_num.Text = p_count + 1

        ' Dispose of Dataset
        p_dataset.Dispose()
    End Sub

    Private Function get_procedure_num() As Integer
        Dim p_sql As String
        Dim p_dataset As DataSet
        Dim p_count As Integer

        ' =============================
        ' * Get Completed Process Count
        ' =============================
        p_sql = "SELECT IsNull(Max(procedure_num), 0) " &
                "FROM run_info_data"
        p_dataset = g_framework.Get_Data(p_sql)

        ' ----------------
        ' * Get Count Info
        ' ----------------
        p_count = p_dataset.Tables(0).Rows(0).Item(0)

        ' Dispose of Dataset
        p_dataset.Dispose()

        get_procedure_num = p_count + 1
    End Function
#End Region

#Region " Get Process Data "
    Public Function get_process_data_csv_file(ByVal p_id As String, ByRef p_bay_title As String) As String
        Dim p_sql As String
        Dim p_dataset As DataSet
        Dim p_db_row As DataRow
        Dim p_db_row2 As DataRow

        Dim p_results As String = ""
        Dim p_prev_id As String

        ' =====================
        ' * Get Process Details
        ' =====================
        p_sql = "Select a.bay_number, title, detergent, liquid_sterilant, lub_secs, " &
                "final_disinfect_temp " &
                "From run_info_header a " &
                "INNER JOIN bay_settings b On b.bay_number = a.bay_number " &
                "Where run_header_id = '" & p_id & "';"

        p_sql &= "Select cycle_name, secs " &
                 "From run_info_detail " &
                 "Where run_header_id = '" & p_id &
                 "' Order by run_order;"

        p_dataset = g_framework.Get_Data(p_sql)

        p_db_row = p_dataset.Tables(0).Rows(0)

        ' ---------------
        ' * Get Bay Title
        ' ---------------
        p_bay_title = p_db_row.Item("title").ToString & "  BAY " & p_db_row.Item("bay_number").ToString

        ' ----------------
        ' * Get Run Cycles
        ' ----------------
        If p_dataset.Tables(1).Rows.Count > 0 Then
            p_prev_id = ""
            For p_x As Integer = 0 To p_dataset.Tables(1).Rows.Count - 1
                p_db_row2 = p_dataset.Tables(1).Rows(p_x)
                Select Case p_db_row2.Item("cycle_name").ToString
                    Case "DISINFECT"
                        If Trim(p_db_row.Item("liquid_sterilant").ToString) <> "" Then
                            p_results &= "Exposed to " & p_db_row.Item("liquid_sterilant").ToString
                        Else
                            p_results &= "Exposed to N/A"
                        End If

                        p_results &= " for " & CInt(p_db_row2.Item("secs") / 60) & " mins "

                        If Trim(p_db_row.Item("final_disinfect_temp").ToString) <> "" Then
                            p_results &= "at " & p_db_row.Item("final_disinfect_temp").ToString & " C"
                        End If

                        p_results &= ","

                    Case "DRAIN"
                        p_results &= "Drain for " & p_db_row2.Item("secs") & " secs,"

                    Case "DRY"
                        p_results &= "Dry for " & p_db_row2.Item("secs") & " secs,"

                    Case "FILL"
                        p_results &= "Fill for " & p_db_row2.Item("secs") & " secs,"

                    Case "PRE-RINSE"
                        p_results &= "Pre-Rinse for " & p_db_row2.Item("secs") & " secs,"

                    Case "RINSE"
                        p_results &= "Rinse for " & p_db_row2.Item("secs") & " secs"

                        If Trim(p_db_row.Item("lub_Secs").ToString) <> "" Then
                            If UCase(p_prev_id) = "WASH" _
                                Or p_x = p_dataset.Tables(1).Rows.Count - 1 Then
                                ' Rinse After Wash / Last Rinse Of Process
                                p_results &= " with " & p_db_row.Item("lub_Secs") & " secs of metered lubrication"
                            End If
                        End If

                        p_results &= ","

                    Case "SOAK"
                        p_results &= "Soak for " & p_db_row2.Item("secs") & " secs,"

                    Case "WASH"
                        p_results &= "Ultrasonics Wash for " & p_db_row2.Item("secs") & " secs"

                        If Trim(p_db_row.Item("detergent").ToString) <> "" Then
                            p_results &= " with " & p_db_row.Item("detergent").ToString
                        Else
                            p_results &= " with N/A"
                        End If

                        p_results &= ","
                End Select

                ' Get Previous Cycle
                p_prev_id = p_db_row2.Item("cycle_name").ToString
            Next
        End If
        p_prev_id = ""

        ' Dispose of Dataset
        p_dataset.Dispose()

        ' Return Data
        get_process_data_csv_file = p_results
    End Function
#End Region

#Region " Initialize "
    Private Sub initialize_Temperature()
        If prog_res_temp.Visible And prog_bay_temp.Value = 0 Then
            If g_demo_mode_flag Then
                Select Case g_CUSMain.Machines(m_machine_index).ReservoirTemperature
                    Case Is <= 0
                        Call get_demo_temps("30", "27")
                        Exit Sub

                    Case 308 ' Old PCI Cards
                        Call get_demo_temps("31", "28")
                        Exit Sub
                End Select
            End If

            ' ---------------------------------------------
            ' * Get Temperatures On Form Load; If Necessary
            ' ---------------------------------------------
            lbl_res_temp_dis.Text = g_CUSMain.Machines(m_machine_index).ReservoirTemperature
            prog_res_temp.Value = g_CUSMain.Machines(m_machine_index).ReservoirTemperature

            lbl_bay_temp_dis.Text = g_CUSMain.Machines(m_machine_index).BayTemperature
            prog_bay_temp.Value = g_CUSMain.Machines(m_machine_index).BayTemperature

            lbl_res_temp_dis.Refresh()
            prog_res_temp.Refresh()

            lbl_bay_temp_dis.Refresh()
            prog_bay_temp.Refresh()
        End If
    End Sub

    Private Sub initialize_IO()
        Dim p_lbl As BitCheck

        'Update the detail screen
        For Each p_lbl In m_lbl_array
            If g_CUSMain.Machines(m_machine_index).Bits(p_lbl.p_bit_name).State Then
                If p_lbl.p_label.Tag <> "ON" Then
                    p_lbl.p_label.BackColor = System.Drawing.Color.Green
                    p_lbl.p_label.ForeColor = System.Drawing.Color.White

                    p_lbl.p_label.Tag = "ON"
                End If
            Else
                If p_lbl.p_label.Tag = "ON" Then
                    p_lbl.p_label.BackColor = System.Drawing.Color.PapayaWhip
                    p_lbl.p_label.ForeColor = System.Drawing.Color.Black

                    p_lbl.p_label.Tag = "OFF"
                End If
            End If
        Next

        Me.Refresh()
    End Sub
#End Region

#Region " Load Label Array "
    Public Sub Load_Label_Array()
        Dim p_bit As BitCheck
        m_lbl_array = New ArrayList

        ' ========
        ' * INPUTS
        ' ========
        p_bit = New BitCheck
        p_bit.p_label = Me.lbl_input_flow
        p_bit.p_bit_name = "I_FLOW"
        m_lbl_array.Add(p_bit)

        p_bit = New BitCheck
        p_bit.p_label = Me.lbl_input_float
        p_bit.p_bit_name = "I_FLOAT"
        m_lbl_array.Add(p_bit)

        p_bit = New BitCheck
        p_bit.p_label = Me.lbl_input_safety
        p_bit.p_bit_name = "I_SAFETY"
        m_lbl_array.Add(p_bit)

        p_bit = New BitCheck
        p_bit.p_label = Me.lbl_input_water
        p_bit.p_bit_name = "I_PRESSURE"
        m_lbl_array.Add(p_bit)

        p_bit = New BitCheck
        p_bit.p_label = Me.lbl_input_ultrasonics
        p_bit.p_bit_name = "I_ULTRASONICS"
        m_lbl_array.Add(p_bit)

        ' =========
        ' * OUTPUTS
        ' =========
        p_bit = New BitCheck
        p_bit.p_label = Me.lbl_air
        p_bit.p_bit_name = "O_AIR"
        m_lbl_array.Add(p_bit)

        p_bit = New BitCheck
        p_bit.p_label = Me.lbl_bay_temp_dis
        p_bit.p_bit_name = "O_BAY_H"
        m_lbl_array.Add(p_bit)

        p_bit = New BitCheck
        p_bit.p_label = Me.lbl_detergent_pump
        p_bit.p_bit_name = "O_DET_81_P"
        m_lbl_array.Add(p_bit)

        p_bit = New BitCheck
        p_bit.p_label = Me.lbl_res_feed
        p_bit.p_bit_name = "O_DIS_F_V"
        m_lbl_array.Add(p_bit)

        p_bit = New BitCheck
        p_bit.p_label = Me.lbl_res_pump
        p_bit.p_bit_name = "O_DIS_P"
        m_lbl_array.Add(p_bit)

        p_bit = New BitCheck
        p_bit.p_label = Me.lbl_res_return
        p_bit.p_bit_name = "O_DIS_R_V"
        m_lbl_array.Add(p_bit)

        p_bit = New BitCheck
        p_bit.p_label = Me.lbl_drain_pump
        p_bit.p_bit_name = "O_DRAIN_P"
        m_lbl_array.Add(p_bit)

        p_bit = New BitCheck
        p_bit.p_label = Me.lbl_drain_valve
        p_bit.p_bit_name = "O_DRAIN_V"
        m_lbl_array.Add(p_bit)

        p_bit = New BitCheck
        p_bit.p_label = Me.lbl_enzyme_pump
        p_bit.p_bit_name = "O_ENZ_P"
        m_lbl_array.Add(p_bit)

        p_bit = New BitCheck
        p_bit.p_label = Me.lbl_lub_pump
        p_bit.p_bit_name = "O_LUB_P"
        m_lbl_array.Add(p_bit)

        p_bit = New BitCheck
        p_bit.p_label = Me.lbl_osc_pump
        p_bit.p_bit_name = "O_OSC_P"
        m_lbl_array.Add(p_bit)

        p_bit = New BitCheck
        p_bit.p_label = Me.lbl_residual_drain
        p_bit.p_bit_name = "O_RES_D"
        m_lbl_array.Add(p_bit)

        p_bit = New BitCheck
        p_bit.p_label = Me.lbl_res_temp_dis
        p_bit.p_bit_name = "O_RES_H"
        m_lbl_array.Add(p_bit)

        p_bit = New BitCheck
        p_bit.p_label = Me.lbl_spray_rinse
        p_bit.p_bit_name = "O_RINSE_S"
        m_lbl_array.Add(p_bit)

        p_bit = New BitCheck
        p_bit.p_label = Me.lbl_ultrasonics
        p_bit.p_bit_name = "O_ULTRA"
        m_lbl_array.Add(p_bit)

        p_bit = New BitCheck
        p_bit.p_label = Me.lbl_water_valve
        p_bit.p_bit_name = "O_WATER_V"
        m_lbl_array.Add(p_bit)

        ' Extra Outputs 83a
        p_bit = New BitCheck
        p_bit.p_label = Me.lbl_dry_heat
        p_bit.p_bit_name = "O_RES_H"
        m_lbl_array.Add(p_bit)
    End Sub
#End Region

#Region " Load Machine Cycles "
    Private Sub load_machine_cycles(ByVal p_profile_id As String)
        Dim p_sql As String
        Dim p_dataset As DataSet
        Dim p_db_row As DataRow
        Dim p_cycle As CUSNET.Cycle

        ' Remove Previous Cycles
        g_CUSMain.Machines(m_machine_index).Cycles.Clear()
        g_CUSMain.Machines(m_machine_index).Has_Disinfect = False

        ' --------------------
        ' * Load up the cycles
        ' --------------------
        p_sql = "SELECT cycle_number, cycle_name, default_override " &
                "FROM profile_cycles PC1 " &
                "INNER JOIN cycles C1 ON C1.cycle_id = PC1.cycle_id " &
                "WHERE PC1.profile_id = '" & p_profile_id &
                "' ORDER BY PC1.order_num"
        p_dataset = g_framework.Get_Data(p_sql)

        For Each p_db_row In p_dataset.Tables(0).Rows
            'Insert the cycles
            p_cycle = New CUSNET.Cycle(p_db_row("cycle_number").ToString)
            p_cycle.SystemOverrides = g_CUSMain.Machines(m_machine_index).SystemOverrides.Clone

            ' ======================
            ' * Load Cycle Overrides
            ' ======================
            If p_db_row("default_override").ToString <> "" Then
                Call set_cycle_overrides(p_db_row("cycle_name").ToString, p_cycle, p_db_row("default_override"))
            End If

            ' =============================
            ' * Apply System Data Overrides
            ' =============================
            If p_cycle.Cycle = CUSNET.PCBStructs.CYCLES.DISINFECT Then
                g_CUSMain.Machines(m_machine_index).Has_Disinfect = True

                ' ----------------
                ' * Disinfect Time
                ' ----------------
                If g_disinfect_overrides(m_machine_index) <> 0 Then
                    ' Convert Minutes to Secs
                    Dim p_val As Integer
                    p_val = g_disinfect_overrides(m_machine_index) * 60

                    ' Set Cycle Secs
                    p_cycle.SystemOverrides.disinfect_secs = p_val
                End If
            End If

            ' ------------------
            ' * Lubrication Time
            ' ------------------
            If g_lubrication_overrides(m_machine_index) <> 0 Then
                p_cycle.SystemOverrides.lub_secs = g_lubrication_overrides(m_machine_index)
            End If

            ' ===========
            ' * Add Cycle
            ' ===========
            g_CUSMain.Machines(m_machine_index).Cycles.Add(p_cycle)
        Next

        ' Dispose of Dataset
        p_dataset.Dispose()
    End Sub
#End Region

#Region " Process "
    Private Sub Process(ByVal type As String)
        Select Case UCase(type)
            Case "CLOSE"  ' Close Detail Screen
                If g_bay_count = 1 Then
                    If g_CUSMain.Machines(0).Bay_Running Then
                        Call message_box("Bay is still running!", 1, "Close Cancelled")

                        pnl_main.Focus()
                        Exit Sub

                    ElseIf Not g_CUSMain.Machines(0).Finished And g_CUSMain.Machines(0).Processed Then
                        Call message_box("Bay needs to be finalized!", 1, "Close Cancelled")

                        pnl_main.Focus()
                        Exit Sub
                    End If

                    ' ------------------
                    ' * Cleanup Run Data
                    ' ------------------
                    Call cleanup_run_data()

                    ' ----------------------------------
                    ' * Stop Input Monitoring (Non Demo)
                    ' ----------------------------------
                    If Not g_demo_mode_flag Then
                        Call set_monitoring(False)
                    End If

                    ' Remove any existing handlers
                    Dim tmpFrm As run_main = g_framework.g_forms(1)
                    tmpFrm.RemoveHandlers()

                    g_framework.g_forms(1) = Nothing
                    g_framework.g_forms(0).Show()

                    Me.Close()
                Else
                    Me.Visible = False
                    g_framework.g_forms(1).Show()
                End If

                ' ==============
                ' * Main Buttons
                ' ==============
            Case "PATIENT"  ' Load Run Patient Screen
                g_framework.g_forms(2) = New run_patient(g_framework.g_db_name, Me, m_machine_index)

                g_framework.g_forms(2).MdiParent = g_mdi_form
                g_framework.g_forms(2).Show()

                Me.Visible = False

            Case "SYSTEM_DATA"  ' Load Run System Data Screen
                g_framework.g_forms(2) = New run_system_data(g_framework.g_db_name, Me)

                g_framework.g_forms(2).MdiParent = g_mdi_form
                g_framework.g_forms(2).Show()

                Me.Visible = False

            Case "EMPTY"  ' Do Empty Chamber
                If message_box("Proceed with Empty Chamber?", 2, "Continue Empty Chamber") = MsgBoxResult.No Then
                    Exit Sub
                End If

                ' ------------
                ' * Set Screen
                ' ------------
                With btn_additional
                    .Tag = "MAINT"
                    .Text = "stop maintenance"
                    .Visible = True
                End With

                lbl_stage.Text = "Empty Chamber"
                lbl_additional.Text = "Empty Chamber"
                lbl_additional.Visible = True

                pnl_main_buttons.Visible = False
                pnl_additional.Visible = True

                ' ---------------------
                ' * Start Empty Process
                ' ---------------------
                With g_CUSMain.Machines(m_machine_index)
                    .Bay_Running = True
                    .empty_process()
                End With

                Call set_maint_run(True, lbl_additional.Text)

            Case "PURGE"  ' Do System Purge
                If message_box("Proceed with Purge System?", 2, "Continue Purge System") = MsgBoxResult.No Then
                    Exit Sub
                End If

                ' ------------------
                ' * Get User Purging
                ' ------------------
                Dim p_form As run_login

                g_pass_str2 = ""
                If g_england_flag Then
                    g_pass_str3 = "PURGE_ENG"
                Else
                    g_pass_str3 = "PURGE"
                End If

                p_form = New run_login(g_framework.g_db_name)
                p_form.ShowDialog()

                ' Cancel Purge If Login Invalid
                If Trim(g_pass_str2) = "" Then
                    Exit Sub
                Else
                    ' -----------------------------
                    ' * Insert Purge History Record
                    ' -----------------------------
                    Dim p_sql As String

                    p_sql = "INSERT INTO purge_history (user_id, bay_number, purge_started, new_disinfect_lot) " &
                            "Values ('" & g_pass_str2 & "', " & m_machine_index + 1 & ", getdate(), " & Me.return_parsed_single_quote_string(g_pass_str3) & "); "

                    If g_england_flag Then
                        Select Case m_machine_index
                            Case 0
                                g_disinfect_lot1 = g_pass_str3

                                p_sql &= "UPDATE settings_maint " &
                                         "Set disinfect_lot_1 = " & Me.return_parsed_single_quote_string(g_pass_str3) & "; "

                            Case 1
                                g_disinfect_lot2 = g_pass_str3

                                p_sql &= "UPDATE settings_maint " &
                                         "Set disinfect_lot_2 = " & Me.return_parsed_single_quote_string(g_pass_str3) & "; "

                            Case 2
                                g_disinfect_lot3 = g_pass_str3

                                p_sql &= "UPDATE settings_maint " &
                                         "Set disinfect_lot_3 = " & Me.return_parsed_single_quote_string(g_pass_str3) & "; "

                            Case 3
                                g_disinfect_lot4 = g_pass_str3

                                p_sql &= "UPDATE settings_maint " &
                                         "Set disinfect_lot_4 = " & Me.return_parsed_single_quote_string(g_pass_str3) & "; "
                        End Select
                    End If

                    Call g_framework.Execute_Query(p_sql)

                    ' Reset Disinfect Lot #
                    lbl_disinfect_lot.Text = g_pass_str3

                    g_pass_str2 = ""
                End If

                g_pass_str3 = ""

                ' ------------
                ' * Set Screen
                ' ------------
                With btn_additional
                    .Tag = "MAINT"
                    .Text = "stop maintenance"
                    .Visible = True
                End With

                lbl_stage.Text = "Purge System"
                lbl_additional.Text = "Purge System"
                lbl_additional.Visible = True

                pnl_main_buttons.Visible = False
                pnl_additional.Visible = True

                ' ---------------------
                ' * Start Purge Process
                ' ---------------------
                With g_CUSMain.Machines(m_machine_index)
                    .Bay_Running = True
                    .Start_Maintenance("PURGE")
                End With

                Call set_maint_run(True, lbl_additional.Text)

            Case "RETURN"  ' Do Reservoir Return
                If message_box("Proceed with Reservoir Return?", 2, "Continue Reservoir Return") = MsgBoxResult.No Then
                    Exit Sub
                End If

                ' ------------
                ' * Set Screen
                ' ------------
                With btn_additional
                    .Tag = "MAINT"
                    .Text = "stop maintenance"
                    .Visible = True
                End With

                lbl_stage.Text = "Reservoir Return"
                lbl_additional.Text = "Reservoir Return"
                lbl_additional.Visible = True

                pnl_main_buttons.Visible = False
                pnl_additional.Visible = True

                ' ----------------------
                ' * Start Return Process
                ' ----------------------
                With g_CUSMain.Machines(m_machine_index)
                    .Bay_Running = True
                    .Start_Maintenance("RETURN")
                End With

                Call set_maint_run(True, lbl_additional.Text)

            Case "MAIN"  ' Run Main Profile
                If message_box("Proceed with " & btn_main.Text.Replace("&&", "&") & "?", 2, "Continue Process") = MsgBoxResult.No Then
                    Exit Sub
                End If

                Call run_machine("MAIN", btn_main)

            Case "SUB1"  ' Run Sub-Profile 1
                If message_box("Proceed with " & btn_sub1.Text.Replace("&&", "&") & "?", 2, "Continue Process") = MsgBoxResult.No Then
                    Exit Sub
                End If

                Call run_machine("SUB1", btn_sub1)

            Case "SUB2"  ' Run Sub-Profile 2
                If message_box("Proceed with " & btn_sub2.Text.Replace("&&", "&") & "?", 2, "Continue Process") = MsgBoxResult.No Then
                    Exit Sub
                End If

                Call run_machine("SUB2", btn_sub2)

                ' ====================
                ' * Additional Buttons
                ' ====================
            Case "CANCEL"
                If message_box("Cancel current process?", 2, "Cancel Processing") = vbYes Then
                    ' --------------
                    ' * Reset Screen
                    ' --------------
                    btn_close.Enabled = True
                    Call reset_detail()
                End If

            Case "ERROR"
                ' ---------------------
                ' * Reset Detail Screen
                ' ---------------------
                btn_close.Enabled = True

                lbl_error.Text = ""

                Call reset_detail()
                Call reset_main()

            Case "EXTRA"  ' Do Additional F1 Button functionality
                Select Case UCase(btn_additional.Tag)
                    Case "DIS"
                        ' ---------------
                        ' * Start Machine
                        ' ---------------
                        btn_close.Enabled = True
                        Call run_setup()

                    Case "MAINT"
                        ' ------------------
                        ' * Stop Maintenance
                        ' ------------------
                        With g_CUSMain.Machines(m_machine_index)
                            .Bay_Running = False
                            .Stop_Maintenance()
                            .TurnOffAllBits()
                        End With

                        btn_additional.Visible = False
                        lbl_additional.Visible = False
                        pnl_additional.Visible = False
                        pnl_main_buttons.Visible = True

                        ' --------------
                        ' * Reset Screen
                        ' --------------
                        lbl_stage.Text = "Current Cycle"
                        Call reset_detail_labels()

                        Call set_maint_run(False, "")
                End Select

            Case "FINISH"
                Dim p_sql As String
                Dim p_dataset As DataSet = Nothing

                ' --------------
                ' * Finalize Run
                ' --------------

                If Not g_override_patient_entry_flag Then
                    ' ------------------------------------------------
                    ' * Check That Patient Information Entered For Run
                    ' ------------------------------------------------
                    p_sql = "Select pre_run_id " &
                            " FROM pre_run_info " &
                            " Where bay_number = " & m_machine_index + 1
                    p_dataset = g_framework.Get_Data(p_sql)

                    If p_dataset.Tables(0).Rows.Count = 0 Then
                        Call message_box("Patient/Instrument information must be assigned before finishing!", 1)
                        pnl_main.Focus()

                        ' Dispose of Dataset
                        p_dataset.Dispose()

                        Exit Sub
                    End If
                End If

                ' ------------
                ' * Save Notes
                ' ------------
                p_sql = ""
                If Trim(txt_notes.TextBox_Properties.Text) <> "" Then
                    Dim p_notes As String
                    p_notes = return_parsed_single_quote_string(Trim(txt_notes.TextBox_Properties.Text))

                    p_sql = "Update run_info_header " &
                            "Set notes = " & p_notes &
                            " Where run_header_id = '" & m_run_header_id & "'; "
                End If

                ' ========================================
                ' * If Not Already Printed Get Finish Info
                ' ========================================
                If Not m_update_flag Then
                    ' --------------------------------------
                    ' * Get User Unloading - England Machine
                    ' --------------------------------------
                    If g_england_flag Then
                        Dim p_form As run_login
                        g_pass_str2 = "UNLOADING"

                        p_form = New run_login(g_framework.g_db_name)
                        p_form.ShowDialog()

                        ' Cancel Finish If Login Invalid
                        If Trim(g_pass_str2) = "" Then
                            Exit Sub
                        Else
                            ' ---------------------
                            ' * Get Final Process #
                            ' ---------------------
                            Call get_process_num("FINISH")

                            ' ----------------------------------------------
                            ' * Update Unload User, Disinfect Lot, Process #
                            ' ----------------------------------------------
                            p_sql &= "Update run_info_header " &
                                     "Set unload_user_id = '" & g_pass_str2 &
                                     "', disinfect_lot = " & Me.return_parsed_single_quote_string(lbl_disinfect_lot.Text) &
                                     ", process_num = '" & lbl_process_num.Text &
                                     "' Where run_header_id = '" & m_run_header_id & "'; "

                            g_pass_str2 = ""
                        End If
                    Else
                        ' ---------------------
                        ' * Get Final Process #
                        ' ---------------------
                        Call get_process_num("FINISH")

                        ' ------------------
                        ' * Update Process #
                        ' ------------------
                        p_sql &= "Update run_info_header " &
                                 "Set process_num = '" & lbl_process_num.Text &
                                 "' Where run_header_id = '" & m_run_header_id & "'; "
                    End If
                End If

                If Not g_override_patient_entry_flag Then
                    ' ------------------------------
                    ' * Move Patient/Instrument Data
                    ' ------------------------------
                    p_sql &= "INSERT INTO run_info_data (run_header_id, patient_id, instrument_id) " &
                             "Select '" & m_run_header_id & "', patient_id, instrument_id " &
                             "FROM pre_run_info Where bay_number = " & m_machine_index + 1 & "; "
                End If

                If p_sql <> "" Then
                    Call g_framework.Execute_Query(p_sql)
                End If

                ' ====================================
                ' * Perform Main Completion Procedures
                ' ====================================
                Dim p_db_row As DataRow

                If m_prev_function = "MAIN" And g_override_patient_entry_flag = False Then
                    Dim p_dataset2 As DataSet = Nothing

                    ' --------------------------------------
                    ' * Check If Patient Should Be Processed
                    ' --------------------------------------
                    p_sql = "Select Distinct patient_id " &
                            "FROM pre_run_info " &
                            "Where bay_number = " & m_machine_index + 1
                    p_dataset = g_framework.Get_Data(p_sql)

                    For Each p_db_row In p_dataset.Tables(0).Rows
                        ' -------------------------------------------
                        ' * Check If Patient Procedure In Another Bay
                        ' -------------------------------------------
                        p_sql = "Select pre_run_id FROM pre_run_info " &
                                "Where bay_number <> " & m_machine_index + 1 &
                                " And patient_id = '" & p_db_row.Item(0).ToString & "'"
                        p_dataset2 = g_framework.Get_Data(p_sql)

                        If p_dataset2.Tables(0).Rows.Count = 0 Then
                            ' -------------------------
                            ' * Move Processed Patients
                            ' -------------------------
                            p_sql = "INSERT INTO processed_patients (patient_id, first_name, last_name, middle_initial, " &
                                    "physician_id, code, notes, date_added, user_added, date_lused, user_lused, processed) " &
                                    "Select patient_id, first_name, last_name, middle_initial, " &
                                    "physician_id, code, notes, date_added, user_added, date_lused, user_lused, getdate() " &
                                    "FROM patient_maint " &
                                    "WHERE patient_id = '" & p_db_row.Item(0).ToString & "'; "

                            p_sql &= "DELETE FROM patient_maint " &
                                     "WHERE patient_id = '" & p_db_row.Item(0).ToString & "'; "

                            Call g_framework.Execute_Query(p_sql)
                        End If
                    Next

                    ' Dispose of Dataset
                    If Not p_dataset2 Is Nothing Then p_dataset2.Dispose()
                End If

                If Not g_override_patient_entry_flag Then
                    ' --------------------------------
                    ' * Update Procedure # Information
                    ' --------------------------------
                    p_sql = "Select Distinct run_data_id " &
                            "FROM run_info_data " &
                            "Where run_header_id = '" & m_run_header_id & "'"
                    p_dataset = g_framework.Get_Data(p_sql)

                    For Each p_db_row In p_dataset.Tables(0).Rows
                        p_sql = "Update run_info_data " &
                                "Set procedure_num = " & get_procedure_num() &
                                " Where run_data_id = '" & p_db_row.Item(0).ToString & "'"
                        Call g_framework.Execute_Query(p_sql)
                    Next
                End If

                ' Dispose of Dataset
                If Not p_dataset Is Nothing Then p_dataset.Dispose()

                'Else
                '' ---------------------------
                '' * 4/13/2006 by RM - Removed
                '' ---------------------------
                '' * Remove Demo Header/Data
                '' ---------------------------
                'p_sql = "DELETE FROM run_info_detail Where run_header_id = '" & m_run_header_id & "';"
                'p_sql &= "DELETE FROM run_info_header Where run_header_id = '" & m_run_header_id & "';"

                'Call g_framework.Execute_Query(p_sql)
                'End If

                ' --------------
                ' * Finalize Bay
                ' --------------
                g_CUSMain.Machines(m_machine_index).Finished = True

                ' ----------------
                ' * Do File Output
                ' ----------------
                If g_enable_file_output_flag Then
                    Call do_output_file()
                End If

                ' ---------------------
                ' * Clear Pre-run Table
                ' ---------------------
                Call g_framework.Execute_Query("DELETE FROM pre_run_info Where bay_number = " & m_machine_index + 1)

                ' Reset Screen
                Call reset_detail()
                Call reset_main()

            Case "PRINT"  ' Print Results
                Dim p_sql As String

                If Not g_override_patient_entry_flag Then
                    Dim p_dataset As DataSet

                    ' --------------------------------
                    ' * Check That Patient Information 
                    ' * Entered For Run
                    ' --------------------------------
                    p_sql = "Select pre_run_id " &
                            " FROM pre_run_info " &
                            " Where bay_number = " & m_machine_index + 1
                    p_dataset = g_framework.Get_Data(p_sql)

                    If p_dataset.Tables(0).Rows.Count = 0 Then
                        Call message_box("Patient/Instrument information must be assigned before running bay!", 1)
                        pnl_main.Focus()

                        ' Dispose of Dataset
                        p_dataset.Dispose()

                        Exit Sub
                    End If

                    ' Dispose of Dataset
                    p_dataset.Dispose()
                End If

                ' ========================================
                ' * If Not Already Printed Get Finish Info
                ' ========================================
                If Not m_update_flag Then
                    ' --------------------------------------
                    ' * Get User Unloading - England Machine
                    ' --------------------------------------
                    If g_england_flag Then
                        Dim p_form As run_login
                        g_pass_str2 = "UNLOADING"

                        p_form = New run_login(g_framework.g_db_name)
                        p_form.ShowDialog()

                        ' Cancel Finish If Login Invalid
                        If Trim(g_pass_str2) = "" Then
                            Exit Sub
                        Else
                            ' ---------------------
                            ' * Get Final Process #
                            ' ---------------------
                            Call get_process_num("FINISH")

                            ' ----------------------------------------------
                            ' * Update Unload User, Disinfect Lot, Process #
                            ' ----------------------------------------------
                            p_sql = "Update run_info_header " &
                                    "Set unload_user_id = '" & g_pass_str2 &
                                    "', disinfect_lot = " & Me.return_parsed_single_quote_string(lbl_disinfect_lot.Text) &
                                    ", process_num = '" & lbl_process_num.Text &
                                    "' Where run_header_id = '" & m_run_header_id & "'"
                            Call g_framework.Execute_Query(p_sql)

                            g_pass_str2 = ""
                        End If
                    Else
                        ' ---------------------
                        ' * Get Final Process #
                        ' ---------------------
                        Call get_process_num("FINISH")

                        ' ------------------
                        ' * Update Process #
                        ' ------------------
                        p_sql = "Update run_info_header " &
                                "Set process_num = '" & lbl_process_num.Text &
                                "' Where run_header_id = '" & m_run_header_id & "'"
                        Call g_framework.Execute_Query(p_sql)
                    End If

                    ' Update Flag
                    m_update_flag = True
                End If

                If message_box("Continue printing results?", 5, "Confirm Print") = MsgBoxResult.No Then Exit Sub

                If Trim(txt_notes.TextBox_Properties.Text) <> "" Then
                    Dim p_notes As String

                    ' ------------
                    ' * Save Notes
                    ' ------------
                    p_notes = return_parsed_single_quote_string(Trim(txt_notes.TextBox_Properties.Text))
                    p_sql = "Update run_info_header " &
                            "Set notes = " & p_notes &
                            " Where run_header_id = '" & m_run_header_id & "'"
                    Call g_framework.Execute_Query(p_sql)
                End If

                Dim p_string As String
                Dim p_print As New ArrayList

                ' ------------------
                ' * Get Process Data
                ' ------------------
                Dim p_ticket_count As Integer
                p_string = get_process_data(m_run_header_id, m_machine_index + 1, True, "PRINT", p_ticket_count)

                ' ------------
                ' * Print Data
                ' ------------
                p_print.Clear()
                p_print.Add(p_string)

                'Used to line feeds
                p_print.Add("")
                p_print.Add("")
                p_print.Add("")
                p_print.Add("")

                Try
                    ' Print Results
                    Dim p_printing As New CUSPrint.TextPrinting(g_PrintPort)
                    p_printing.Print(p_print)

                Catch
                    ' ----------------------------------------------------------
                    ' * Catch Possible Printer Error and Display Message to User
                    ' ----------------------------------------------------------
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Call message_box("Bad printer connection press F5 to finalize and save data for later printing.", 4, "Print Error")
                End Try

            Case "NOTES"  ' Load Run Notes Screen
                g_framework.g_forms(2) = New run_notes(g_framework.g_db_name, Me)

                g_framework.g_forms(2).MdiParent = g_mdi_form
                g_framework.g_forms(2).Show()

                Me.Visible = False
        End Select
    End Sub

    Private Sub set_maint_run(ByVal p_mode As Boolean, ByVal p_function As String)
        prog_run.Bounce = p_mode

        Dim p_form As run_main
        p_form = g_framework.g_forms(1)

        If g_bay_count > 1 Then
            Call p_form.set_run_progress(g_CUSMain.Machines(m_machine_index), p_mode)
            Call p_form.set_special_function(g_CUSMain.Machines(m_machine_index).Name, g_CUSMain.Machines(m_machine_index).BayNumber, p_function)
        End If
    End Sub

    Private Sub reset_detail_labels()
        ' ----------------------------
        ' * Make Sure All Labels Reset
        ' ----------------------------
        Dim p_lbl As BitCheck

        If g_demo_mode_flag Then
            For Each p_lbl In m_lbl_array
                p_lbl.p_label.BackColor = System.Drawing.Color.PapayaWhip
                p_lbl.p_label.ForeColor = System.Drawing.Color.Black

                p_lbl.p_label.Tag = "OFF"
            Next
        Else
            For Each p_lbl In m_lbl_array
                Select Case UCase(p_lbl.p_bit_name)
                    Case "I_FLOW", "I_FLOAT", "I_SAFETY", "I_PRESSURE", "I_ULTRASONICS", "O_RES_H"
                    Case Else
                        p_lbl.p_label.BackColor = System.Drawing.Color.PapayaWhip
                        p_lbl.p_label.ForeColor = System.Drawing.Color.Black

                        p_lbl.p_label.Tag = "OFF"
                End Select
            Next
        End If
    End Sub
#End Region

#Region " Reset Detail Screen "
    Private Sub reset_detail()
        ' Reset Buttons
        With btn_additional
            .Tag = ""
            .Text = "Additional"
            .Width = 223
        End With
        btn_cancel.Visible = False
        btn_print.Visible = False
        btn_finish.Visible = False

        ' Reset Panels
        pnl_additional.Visible = False
        pnl_main_buttons.Visible = True

        Call reset_other()
    End Sub

    Private Sub reset_other()
        ' Reset Labels
        lbl_stage.Text = "Current Cycle"
        lbl_completed.Text = "-"
        lbl_left.Text = "-"
        prog_run.Bounce = False
        prog_run.Value = 0
        prog_overall.Value = 0

        lbl_process_num.Text = ""

        lbl_count.Text = "0 - Procedures Entered"
        lbl_additional.Visible = False
        Call reset_detail_labels()
        grd_display.Visible = False

        ' Reset IDs
        m_run_header_id = ""
        m_run_user_id = ""
        m_update_flag = False

        ' Reset Notes
        txt_notes.TextBox_Properties.Text = ""
    End Sub
#End Region

#Region " Reset Main Screen "
    Private Sub reset_main()
        Dim p_form As run_main

        p_form = g_framework.g_forms(1)
        p_form.reset_bay_info(m_machine_index)
    End Sub
#End Region

#Region " Run Machine "
    Private Sub run_machine(ByVal p_type As String, ByVal btn As DBA.Library.DBA_Button)
        ' -----------------------
        ' * Get User Starting Run
        ' -----------------------
        Dim p_form As run_login
        g_pass_str2 = ""

        p_form = New run_login(g_framework.g_db_name)
        p_form.ShowDialog()

        ' Cancel Run If No Login Provided
        If Trim(g_pass_str2) = "" Then
            Exit Sub
        Else
            ' Get Run User
            m_run_user_id = g_pass_str2
            g_pass_str2 = ""
        End If

        ' ---------------------
        ' * Load Profile Cycles
        ' ---------------------
        Call load_machine_cycles(btn.Tag)
        m_prev_function = UCase(p_type)
        m_button = UCase(btn.Text)

        ' ------------------------------
        ' * Set Provide Lubrication Flag
        ' ------------------------------
        g_CUSMain.Machines(m_machine_index).Lubrication = chk_lub.Checked

        ' ------------------------------------------
        ' * Set For Disinfect Check Or Start Machine
        ' ------------------------------------------
        If g_CUSMain.Machines(m_machine_index).Has_Disinfect Then
            pnl_additional.Location = pnl_main_buttons.Location
            pnl_additional.Visible = True
            pnl_main_buttons.Visible = False

            With btn_additional
                .Tag = "DIS"
                .Text = "Check Reservoir level, continue"
                .Visible = True
            End With
            btn_cancel.Tag = "DIS"

            btn_cancel.Visible = True
            btn_close.Enabled = False
        Else
            Call run_setup()
        End If
    End Sub

    Private Sub run_setup()
        If Not g_override_patient_entry_flag Then
            ' Set Additional Button
            With btn_additional
                .Tag = "PATIENT"
                .Text = "Patient/Instrument"
                .Visible = True
                .Width = btn_patient.Width
            End With

            ' Fill Patient Data
            Call Fill_Grid()
            grd_display.Visible = True
        Else
            ' Make Sure Additional Button Not Visible - Could turn into Error Button
            btn_additional.Visible = False
        End If

        ' Set Buttons
        btn_cancel.Visible = False

        btn_print.Visible = True
        btn_finish.Visible = True

        ' Set Panels
        pnl_main_buttons.Visible = False
        pnl_additional.Visible = True

        ' -------------------
        ' * Create Run Header
        ' -------------------
        Call create_run_header()

        ' ---------------
        ' * Get Process #
        ' ---------------
        Call get_process_num("START")

        ' ---------------
        ' * Start Machine
        ' ---------------
        prog_run.Bounce = True
        g_CUSMain.Machines(m_machine_index).RunMachine()
    End Sub

    Private Sub create_run_header()
        ' ------------------------------------------------
        ' * actually save the information into board_count
        ' ------------------------------------------------
        Dim p_up_dataset As New DataSet
        Dim p_datatable As New DataTable
        Dim p_table As String

        ' Reset Run Header ID
        m_run_header_id = ""
        g_CUSMain.Machines(m_machine_index).Run_Header_ID = ""

        p_up_dataset = g_framework.create_up_tbl()
        p_datatable = p_up_dataset.Tables(0)
        p_table = "run_info_header"

        ' Add Record To Run Header Table
        g_framework.dba_Add_Row_To_DataTable(p_datatable, "run_header_id", "", "U", p_table)
        g_framework.dba_Add_Row_To_DataTable(p_datatable, "run_user_id", m_run_user_id, "U", p_table)
        g_framework.dba_Add_Row_To_DataTable(p_datatable, "bay_number", m_machine_index + 1, "N", p_table)
        g_framework.dba_Add_Row_To_DataTable(p_datatable, "start_time", Get_Server_Date, "D", p_table)
        g_framework.dba_Add_Row_To_DataTable(p_datatable, "detergent", g_CUSMain.Machines(m_machine_index).detergent, "S", p_table)
        g_framework.dba_Add_Row_To_DataTable(p_datatable, "liquid_sterilant", g_CUSMain.Machines(m_machine_index).liquid_sterilant, "S", p_table)

        ' ----------------------------------------------------------------------------
        ' * 4/13/2006 by RM - Allows Demo Processes not to be deleted during Demo Mode
        ' ----------------------------------------------------------------------------
        'g_framework.dba_Add_Row_To_DataTable(p_datatable, "demo_mode", g_demo_mode_flag, "L", p_table)
        g_framework.dba_Add_Row_To_DataTable(p_datatable, "demo_mode", 0, "L", p_table)

        If g_CUSMain.Machines(m_machine_index).Lubrication Then
            g_framework.dba_Add_Row_To_DataTable(p_datatable, "lub_secs", g_CUSMain.Machines(m_machine_index).SystemOverrides.lub_secs, "N", p_table)
        End If

        g_framework.dba_Add_Row_To_DataTable(p_datatable, "complete", False, "L", p_table)
        g_framework.dba_Add_Row_To_DataTable(p_datatable, "button_text", m_button.Replace("&&", "&"), "S", p_table)

        ' Get Run Header ID
        m_run_header_id = g_framework.Save_Data(p_up_dataset)
        g_CUSMain.Machines(m_machine_index).Run_Header_ID = m_run_header_id
    End Sub
#End Region

#Region " Set For Finalize "
    Public Sub setup_finish()
        ' Set Screen For Finalize
        prog_run.Bounce = False
        prog_overall.Value = 100

        lbl_stage.Text = "Completed"
        Call reset_detail_labels()

        pnl_additional.Refresh()
        Me.Refresh()
    End Sub
#End Region

#Region " Set Screen "
    Public Sub set_screen(ByVal p_pinout As CUSNET.PCBStructs.SYSTEM_ID_DEF,
        ByVal p_profile_id As String)

        ' -----------------------
        ' * Set Screen For Pinout
        ' -----------------------
        Select Case p_pinout
            Case CUSNET.PCBStructs.SYSTEM_ID_DEF.S80

            Case CUSNET.PCBStructs.SYSTEM_ID_DEF.S81
                chk_lub.Visible = True

                ' Set Outputs
                lbl_lub_pump.Visible = True
                lbl_spray_rinse.Visible = True

            Case CUSNET.PCBStructs.SYSTEM_ID_DEF.S81P
                ' Set Outputs
                lbl_residual_drain.Visible = False
                lbl_lub_pump.Visible = True
                lbl_spray_rinse.Visible = True
                lbl_detergent_pump.Visible = True

                lbl_air.Location = lbl_residual_drain.Location

                ' Set Button
                btn_return.Text = "Return to Reservoir"

            Case CUSNET.PCBStructs.SYSTEM_ID_DEF.S81X
                chk_lub.Visible = True

                ' Set Outputs
                lbl_res_pump.Visible = False
                lbl_res_feed.Visible = False
                lbl_res_return.Visible = False

                lbl_lub_pump.Visible = True
                lbl_spray_rinse.Visible = True
                lbl_detergent_pump.Visible = True
                lbl_enzyme_pump.Visible = True

                lbl_residual_drain.Location = lbl_res_pump.Location
                lbl_air.Location = lbl_res_feed.Location
                lbl_enzyme_pump.Location = lbl_res_return.Location

                ' Set Buttons
                btn_purge.Visible = False
                btn_return.Visible = False

            Case CUSNET.PCBStructs.SYSTEM_ID_DEF.S81Y
                chk_lub.Visible = True

                ' Set Outputs
                lbl_res_pump.Visible = False
                lbl_res_feed.Visible = False
                lbl_res_return.Visible = False

                lbl_lub_pump.Visible = True
                lbl_spray_rinse.Visible = True
                lbl_detergent_pump.Visible = True

                lbl_lub_pump.Location = lbl_res_pump.Location
                lbl_spray_rinse.Location = lbl_res_feed.Location
                lbl_detergent_pump.Location = lbl_res_return.Location

                ' Set Buttons
                btn_purge.Visible = False
                btn_return.Visible = False

            Case CUSNET.PCBStructs.SYSTEM_ID_DEF.S81Z
                chk_lub.Visible = True

                ' Set Outputs
                lbl_lub_pump.Visible = True
                lbl_spray_rinse.Visible = True
                lbl_detergent_pump.Visible = True

            Case CUSNET.PCBStructs.SYSTEM_ID_DEF.S82,
                 CUSNET.PCBStructs.SYSTEM_ID_DEF.S83,
                 CUSNET.PCBStructs.SYSTEM_ID_DEF.S83R

            Case CUSNET.PCBStructs.SYSTEM_ID_DEF.S83A
                chk_lub.Visible = True

                ' Set Outputs
                lbl_res_pump.Visible = False
                lbl_res_feed.Visible = False
                lbl_res_return.Visible = False
                lbl_residual_drain.Visible = False

                lbl_lub_pump.Visible = True
                lbl_detergent_pump.Visible = True
                lbl_dry_heat.Visible = True

                lbl_air.Location = lbl_residual_drain.Location
                lbl_lub_pump.Location = lbl_res_pump.Location
                lbl_detergent_pump.Location = lbl_res_return.Location
                lbl_dry_heat.Location = lbl_res_feed.Location

                ' Set Buttons
                btn_purge.Visible = False
                btn_return.Visible = False

            Case CUSNET.PCBStructs.SYSTEM_ID_DEF.S83D
                ' Set Outputs
                lbl_lub_pump.Visible = True
                lbl_lub_pump.Text = "Detergent Pump"

            Case CUSNET.PCBStructs.SYSTEM_ID_DEF.S83DT
                ' Set Outputs
                lbl_lub_pump.Visible = True
                lbl_lub_pump.Text = "Detergent Pump"

            Case CUSNET.PCBStructs.SYSTEM_ID_DEF.S83S
                ' Set Outputs
                lbl_res_pump.Visible = False
                lbl_res_feed.Text = "Sterox Valve"
                lbl_res_return.Text = "Sterox Water Val."

                lbl_detergent_pump.Location = lbl_res_pump.Location
                lbl_detergent_pump.Visible = True

                ' Set Buttons
                btn_purge.Visible = False
                btn_return.Visible = False
        End Select

        ' --------------------------
        ' * Set Temperature Readings
        ' --------------------------
        If g_CUSMain.Machines(m_machine_index).MonitorResTemperature Then
            grpbx_res_temp.Visible = True
            grpbx_bay_temp.Visible = True
        End If

        ' -------------------
        ' * Set Cycle Buttons
        ' -------------------
        Call Set_Cycle_Buttons(p_profile_id)
    End Sub

    Public Sub set_screen_for_error()
        ' ----------------------
        ' * Set Screen For Error
        ' ----------------------
        lbl_process_num.Text = ""

        btn_close.Enabled = False

        prog_run.Bounce = False
        prog_run.Value = 0

        ' Reset Labels
        Call reset_detail_labels()

        With btn_additional
            .Tag = "ERROR"
            .Text = "Clear Error"
            .Visible = True
            .Width = btn_patient.Width
        End With
        btn_cancel.Visible = False
        btn_print.Visible = False
        btn_finish.Visible = False
        grd_display.Visible = False

        ' Display Error
        lbl_error.Text = g_CUSMain.Machines(m_machine_index).Error_Message
    End Sub
#End Region

#Region " Set Cycle Buttons "
    Private Sub Set_Cycle_Buttons(ByVal p_profile_id As String)
        If Trim(p_profile_id) = "" Then
            btn_main.Visible = False
            Exit Sub
        Else
            btn_main.Visible = True
        End If

        Dim p_sql As String
        Dim p_dataset As DataSet
        Dim p_db_row As DataRow

        ' -------------------
        ' * Set Cycle Buttons
        ' -------------------
        p_sql = "Select button_text, profile_id From profile_maint " &
                "Where profile_id = '" & p_profile_id &
                "'; Select button_text, profile_id " &
                "From profile_maint P1 " &
                "INNER JOIN profile_subs S1 On S1.sub_profile_id = P1.profile_id " &
                "Where main_profile_id = '" & p_profile_id &
                "' Order by order_num;"
        p_dataset = g_framework.Get_Data(p_sql)

        ' Set Main Cycle Button
        p_db_row = p_dataset.Tables(0).Rows(0)
        btn_main.Text = main.validate(p_db_row.Item(0).ToString)
        btn_main.Tag = p_db_row.Item(1).ToString

        ' Set Sub Cycle Buttons
        If p_dataset.Tables(1).Rows.Count > 0 Then
            ' Set Sub1
            p_db_row = p_dataset.Tables(1).Rows(0)

            With btn_sub1
                .Text = main.validate(p_db_row.Item(0).ToString)
                .Tag = p_db_row.Item(1).ToString
                .Visible = True
            End With

            ' Set Sub2
            If p_dataset.Tables(1).Rows.Count > 1 Then
                p_db_row = p_dataset.Tables(1).Rows(1)

                With btn_sub2
                    .Text = main.validate(p_db_row.Item(0).ToString)
                    .Tag = p_db_row.Item(1).ToString
                    .Visible = True
                End With
            End If
        End If

        ' DIspose of Dataset
        p_dataset.Dispose()
    End Sub
#End Region

#Region " Set Cycle Overrides "
    Private Sub set_cycle_overrides(ByVal p_type As String, ByRef p_cycle As CUSNET.Cycle,
        ByVal p_override As Integer)

        ' ---------------------
        ' * Set Cycle Overrides
        ' ---------------------
        Select Case UCase(p_type)
            Case "DISINFECT"
                If p_cycle.SystemOverrides.disinfect_secs < p_override * 60 Then
                    p_cycle.SystemOverrides.disinfect_secs = p_override * 60 'minutes to seconds
                End If

            Case "DRY"
                If p_cycle.SystemOverrides.dry_heat_secs < p_override Then
                    p_cycle.SystemOverrides.dry_heat_secs = p_override
                End If

            Case "PRE-RINSE"
                If p_cycle.SystemOverrides.prerinse_secs < p_override Then
                    p_cycle.SystemOverrides.prerinse_secs = p_override
                End If

            Case "RINSE"
                If p_cycle.SystemOverrides.rinse_secs < p_override Then
                    p_cycle.SystemOverrides.rinse_secs = p_override
                End If

            Case "SOAK"
                If p_cycle.SystemOverrides.soak_secs < p_override Then
                    p_cycle.SystemOverrides.soak_secs = p_override
                End If

            Case "WASH"
                If p_cycle.SystemOverrides.wash_secs < p_override Then
                    p_cycle.SystemOverrides.wash_secs = p_override
                End If
        End Select
    End Sub
#End Region

#Region " Screen Object Events "

#Region " Checkbox Events "
    Private Sub chk_lub_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_lub.CheckedChanged
        lbl_lub.Visible = chk_lub.Checked
    End Sub
#End Region

#Region " Grid Events "
    Private Sub grd_display_AfterRowSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_display.AfterRowSelected
        grd_display.CancelActivate = True
    End Sub

    Private Sub grd_display_InitializeLayout(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_display.InitializeLayout
        With grd_display
            .Columns(1).Width = 160
            .Columns(2).Width = 160
            .Columns(3).Width = 160
        End With
    End Sub
#End Region

#End Region

End Class
