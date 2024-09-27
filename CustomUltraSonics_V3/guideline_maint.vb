Public Class guideline_maint
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
    Friend WithEvents txt_guidelines As DBA.Library.DBA_TextBox
    Friend WithEvents lbl_info As DBA.Library.DBA_Label
    Friend WithEvents lbl_F10 As DBA.Library.DBA_Label
    Friend WithEvents pnl_info As DBA.Library.DBA_Panel
    Friend WithEvents btn_delete As DBA.Library.DBA_Button
    Friend WithEvents btn_cancel As DBA.Library.DBA_Button
    Friend WithEvents btn_save As DBA.Library.DBA_Button
    Friend WithEvents btn_new As DBA.Library.DBA_Button
    Friend WithEvents btn_close As DBA.Library.DBA_Button
    Friend WithEvents txt_guideline As DBA.Library.DBA_TextBox
    Friend WithEvents tlb_main As DBA.Library.DBA_StyleToolbar
    Friend WithEvents grd_display As DBA.Library.DBA_StyleGrid
    Friend WithEvents GroupByRow1 As Xceed.Grid.GroupByRow
    Friend WithEvents ColumnManagerRow1 As Xceed.Grid.ColumnManagerRow
    Friend WithEvents dataRowTemplate1 As Xceed.Grid.DataRow
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(guideline_maint))
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
        Me.pnl_info = New DBA.Library.DBA_Panel
        Me.txt_guideline = New DBA.Library.DBA_TextBox
        Me.txt_guidelines = New DBA.Library.DBA_TextBox
        Me.lbl_F10 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_info = New DBA.Library.DBA_Label(Me.components)
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
        Me.pnl_main.Controls.Add(Me.btn_delete)
        Me.pnl_main.Controls.Add(Me.btn_cancel)
        Me.pnl_main.Controls.Add(Me.btn_save)
        Me.pnl_main.Controls.Add(Me.btn_new)
        Me.pnl_main.Controls.Add(Me.btn_close)
        Me.pnl_main.Controls.Add(Me.pnl_info)
        Me.pnl_main.Controls.Add(Me.lbl_info)
        Me.pnl_main.DataSettings.IDField = "guideline_id"
        Me.pnl_main.DataSettings.JoinData = Nothing
        Me.pnl_main.DataSettings.LinkField = Nothing
        Me.pnl_main.DataSettings.TableName = "guideline_maint"
        Me.pnl_main.Gradient = False
        Me.pnl_main.Location = New System.Drawing.Point(0, 0)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.RecordID = Nothing
        Me.pnl_main.Saved = False
        Me.pnl_main.Size = New System.Drawing.Size(652, 467)
        Me.pnl_main.TabIndex = 1
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
        Me.grd_display.LinkSettings.IsMainGrid = True
        Me.grd_display.LinkSettings.RecordContainer = Me.pnl_main
        Me.grd_display.Location = New System.Drawing.Point(7, 56)
        Me.grd_display.Name = "grd_display"
        Me.grd_display.ReadOnly = True
        Me.grd_display.SelectionMode = System.Windows.Forms.SelectionMode.One
        Me.grd_display.Size = New System.Drawing.Size(116, 347)
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
        Me.tlb_main.Size = New System.Drawing.Size(652, 1)
        Me.tlb_main.TabIndex = 31
        Me.tlb_main.TabStop = False
        Me.tlb_main.ToolBarCustom = Nothing
        Me.tlb_main.ToolbarDisplayType = DBA.Library.DBA_StyleToolbar.DisplayType.IconsOnSide
        Me.tlb_main.ToolBarType = DBA.Library.DBA_StyleToolbar.DBA_ToolBarType.Normal
        Me.tlb_main.Visible = False
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
        Me.btn_delete.Location = New System.Drawing.Point(400, 8)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(104, 43)
        Me.btn_delete.TabIndex = 5
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
        Me.btn_cancel.Location = New System.Drawing.Point(269, 8)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(104, 43)
        Me.btn_cancel.TabIndex = 4
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
        Me.btn_save.Location = New System.Drawing.Point(138, 8)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(104, 43)
        Me.btn_save.TabIndex = 3
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
        Me.btn_new.TabIndex = 2
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
        Me.btn_close.Location = New System.Drawing.Point(529, 8)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(104, 43)
        Me.btn_close.TabIndex = 6
        Me.btn_close.TabStop = False
        Me.btn_close.Text = "Close"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'pnl_info
        '
        Me.pnl_info.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnl_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_info.Controls.Add(Me.txt_guideline)
        Me.pnl_info.Controls.Add(Me.txt_guidelines)
        Me.pnl_info.Controls.Add(Me.lbl_F10)
        Me.pnl_info.DataSettings.IDField = Nothing
        Me.pnl_info.DataSettings.JoinData = Nothing
        Me.pnl_info.DataSettings.LinkField = Nothing
        Me.pnl_info.DataSettings.TableName = Nothing
        Me.pnl_info.Gradient = False
        Me.pnl_info.Location = New System.Drawing.Point(125, 56)
        Me.pnl_info.Name = "pnl_info"
        Me.pnl_info.RecordID = Nothing
        Me.pnl_info.Saved = False
        Me.pnl_info.Size = New System.Drawing.Size(508, 347)
        Me.pnl_info.TabIndex = 1
        '
        'txt_guideline
        '
        Me.txt_guideline.AllowNegative = False
        Me.txt_guideline.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_guideline.ColorCursor = True
        Me.txt_guideline.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_guideline.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_guideline.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_guideline.Enabled = False
        Me.txt_guideline.Field_Name = "guideline"
        Me.txt_guideline.GridBinding = Me.grd_display
        Me.txt_guideline.Label_On_Top = False
        Me.txt_guideline.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_guideline.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_guideline.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_guideline.Label_Properties.Text = "Guideline"
        Me.txt_guideline.Label_Properties.Width = 75
        Me.txt_guideline.Location = New System.Drawing.Point(5, 10)
        Me.txt_guideline.Mandatory = True
        Me.txt_guideline.Name = "txt_guideline"
        Me.txt_guideline.Override_Modified = False
        Me.txt_guideline.SaveLoadOrder = 0
        Me.txt_guideline.Size = New System.Drawing.Size(341, 26)
        Me.txt_guideline.TabIndex = 0
        Me.txt_guideline.TabStop = False
        Me.txt_guideline.Text = "DbA_TextBox1"
        Me.txt_guideline.TextBox_Properties.AcceptsReturn = False
        Me.txt_guideline.TextBox_Properties.AcceptsTab = False
        Me.txt_guideline.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_guideline.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_guideline.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_guideline.TextBox_Properties.Enabled = True
        Me.txt_guideline.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_guideline.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_guideline.TextBox_Properties.MaximumValue = 999999
        Me.txt_guideline.TextBox_Properties.MaxLength = 100
        Me.txt_guideline.TextBox_Properties.MinimumValue = -999999
        Me.txt_guideline.TextBox_Properties.MultiLine = False
        Me.txt_guideline.TextBox_Properties.PasswordChar = Nothing
        Me.txt_guideline.TextBox_Properties.ReadOnly = False
        Me.txt_guideline.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_guideline.TextBox_Properties.TabStop = True
        Me.txt_guideline.TextBox_Properties.Text = ""
        Me.txt_guideline.TextBox_Properties.WordWrap = True
        Me.txt_guideline.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'txt_guidelines
        '
        Me.txt_guidelines.AllowNegative = False
        Me.txt_guidelines.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_guidelines.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_guidelines.ColorCursor = False
        Me.txt_guidelines.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_guidelines.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_guidelines.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_guidelines.Enabled = False
        Me.txt_guidelines.Field_Name = "guidelines"
        Me.txt_guidelines.GridBinding = Me.grd_display
        Me.txt_guidelines.Label_On_Top = False
        Me.txt_guidelines.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_guidelines.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_guidelines.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_guidelines.Label_Properties.Text = "Guidelines"
        Me.txt_guidelines.Label_Properties.Width = 0
        Me.txt_guidelines.Location = New System.Drawing.Point(3, 39)
        Me.txt_guidelines.Mandatory = True
        Me.txt_guidelines.Name = "txt_guidelines"
        Me.txt_guidelines.Override_Modified = False
        Me.txt_guidelines.SaveLoadOrder = 0
        Me.txt_guidelines.Size = New System.Drawing.Size(500, 301)
        Me.txt_guidelines.TabIndex = 1
        Me.txt_guidelines.TabStop = False
        Me.txt_guidelines.Text = "DbA_TextBox1"
        Me.txt_guidelines.TextBox_Properties.AcceptsReturn = True
        Me.txt_guidelines.TextBox_Properties.AcceptsTab = False
        Me.txt_guidelines.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_guidelines.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_guidelines.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_guidelines.TextBox_Properties.Enabled = True
        Me.txt_guidelines.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_guidelines.TextBox_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_guidelines.TextBox_Properties.MaximumValue = 999999
        Me.txt_guidelines.TextBox_Properties.MaxLength = 8000
        Me.txt_guidelines.TextBox_Properties.MinimumValue = -999999
        Me.txt_guidelines.TextBox_Properties.MultiLine = True
        Me.txt_guidelines.TextBox_Properties.PasswordChar = Nothing
        Me.txt_guidelines.TextBox_Properties.ReadOnly = False
        Me.txt_guidelines.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_guidelines.TextBox_Properties.TabStop = True
        Me.txt_guidelines.TextBox_Properties.Text = ""
        Me.txt_guidelines.TextBox_Properties.WordWrap = True
        Me.txt_guidelines.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        '
        'lbl_F10
        '
        Me.lbl_F10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_F10.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_F10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_F10.ForeColor = System.Drawing.Color.Black
        Me.lbl_F10.Location = New System.Drawing.Point(360, 9)
        Me.lbl_F10.Name = "lbl_F10"
        Me.lbl_F10.Size = New System.Drawing.Size(136, 22)
        Me.lbl_F10.TabIndex = 32
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
        Me.lbl_info.Location = New System.Drawing.Point(11, 412)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(624, 22)
        Me.lbl_info.TabIndex = 30
        Me.lbl_info.Text = "Use tab/arrow keys to move around.  Use shift key with arrow keys to select multi" & _
            "ple lines."
        Me.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_info.UseMnemonic = False
        '
        'guideline_maint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(644, 440)
        Me.Controls.Add(Me.pnl_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "guideline_maint"
        Me.Text = "guideline_maint"
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

#Region " Fill Grid "
    Private Sub Fill_Grid()
        ' ----------------------
        ' * Fill Guidelines Grid
        ' ----------------------
        grd_display.SQL = "Select guideline_id, Guideline " & _
                        "FROM guideline_maint " & _
                        " Order By guideline"
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

#Region " Form Load "
    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim p_excludes(6) As dba_RemoveControls
        p_excludes(0).Control = btn_close
        p_excludes(1).Control = lbl_info
        p_excludes(2).Control = lbl_F10

        p_excludes(3).Control = btn_new
        p_excludes(4).Control = btn_save
        p_excludes(5).Control = btn_cancel
        p_excludes(6).Control = btn_delete

        Me.dba_init_form(pnl_main, True, p_excludes, g_is_internal)
        Me.g_focus_fld = txt_guideline.txtbox

        Call size_screen(Me)

        ' -----------
        ' * Fill Grid
        ' -----------
        Call Fill_Grid()

        grd_display.Insert_Header_Row("Guidelines List")

        If grd_display.DataRows.Count > 0 Then
            grd_display.SelectedRows.Add(grd_display.DataRows(0))
            grd_display.CurrentRow = grd_display.DataRows(0)
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

        ' ---------------------------------------
        ' * Check For Item ID In Related Table(s)
        ' ---------------------------------------
        ' Check Bay Settings For Guideline
        p_sql = "SELECT Distinct guideline_id " & _
                "FROM bay_settings " & _
                "Where guideline_id = '" & pnl_main.RecordID & "'"
        p_dataset = g_framework.Get_Data(p_sql)

        If p_dataset.Tables(0).Rows.Count > 0 Then
            ' Dispose Of Dataset
            p_dataset.Dispose()

            Call message_box("Guideline cannot be deleted; currently used under Bay Settings.", 1, "Delete Cancelled")

            Return False
            Exit Function
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
                " Where " & txt_guideline.Field_Name & " = " & return_parsed_single_quote_string(txt_guideline.TextBox_Properties.Text)

        If Trim(pnl_main.RecordID) <> "" Then
            p_sql = p_sql & " And " & pnl_main.DataSettings.IDField & " <> '" & Trim(pnl_main.RecordID) & "'"
        End If

        p_data_set = g_framework.Get_Data(p_sql)

        ' ==================================
        ' * Check If Value Entered Was Found
        ' ==================================
        If p_data_set.Tables(0).Rows.Count > 0 Then
            Call message_box("The Guideline entered already exists!", 1, "Message To User")

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

                    ' Guidelines Change
                    For p_x As Integer = 0 To g_bay_count - 1
                        g_CUSMain.Machines(p_x).Setup = False
                    Next
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
    Private Sub grd_display_InitializeLayout(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_display.InitializeLayout
        grd_display.Columns(1).Width = 95
    End Sub

    Private Sub grd_display_TabPressed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_display.TabPressed
        Me.g_focus_fld.Focus()
    End Sub
#End Region

#Region " Textbox Events "
    Private Sub guidelines_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        txt_guideline.TextBox_TextChanged, txt_guidelines.TextBox_TextChanged

        If Me.g_fill_screen Then Exit Sub
        Call set_toolbar_buttons("", "T", "T", "")
    End Sub
#End Region

#End Region

End Class
