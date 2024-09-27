Public Class run_notes
    Inherits DBA_Framework.DBA_Foundation_Class

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal p_db_name As String, ByVal p_form As run_bay_detail)
        MyBase.New(p_db_name, g_framework.g_version, g_framework.g_user_id)

        'set the webservice url
        MyBase.update_url(g_service_url)

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        m_prev_form = p_form
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
    Friend WithEvents txt_notes As DBA.Library.DBA_TextBox
    Friend WithEvents txt_prev_notes As DBA.Library.DBA_TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(run_notes))
        Me.pnl_main = New DBA.Library.DBA_Panel
        Me.txt_prev_notes = New DBA.Library.DBA_TextBox
        Me.txt_notes = New DBA.Library.DBA_TextBox
        Me.btn_cancel = New DBA.Library.DBA_Button(Me.components)
        Me.btn_save = New DBA.Library.DBA_Button(Me.components)
        Me.btn_close = New DBA.Library.DBA_Button(Me.components)
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_main
        '
        Me.pnl_main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_main.Controls.Add(Me.txt_prev_notes)
        Me.pnl_main.Controls.Add(Me.txt_notes)
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
        Me.pnl_main.Size = New System.Drawing.Size(491, 380)
        Me.pnl_main.TabIndex = 0
        '
        'txt_prev_notes
        '
        Me.txt_prev_notes.AllowNegative = False
        Me.txt_prev_notes.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_prev_notes.ColorCursor = True
        Me.txt_prev_notes.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_prev_notes.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_prev_notes.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_prev_notes.Field_Name = ""
        Me.txt_prev_notes.GridBinding = Nothing
        Me.txt_prev_notes.Label_On_Top = False
        Me.txt_prev_notes.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_prev_notes.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prev_notes.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_prev_notes.Label_Properties.Text = "Prev Notes"
        Me.txt_prev_notes.Label_Properties.Width = 0
        Me.txt_prev_notes.Location = New System.Drawing.Point(421, 17)
        Me.txt_prev_notes.Mandatory = False
        Me.txt_prev_notes.Name = "txt_prev_notes"
        Me.txt_prev_notes.Override_Modified = False
        Me.txt_prev_notes.SaveLoadOrder = 0
        Me.txt_prev_notes.Size = New System.Drawing.Size(58, 40)
        Me.txt_prev_notes.TabIndex = 8
        Me.txt_prev_notes.TabStop = False
        Me.txt_prev_notes.Tag = ""
        Me.txt_prev_notes.Text = "DbA_TextBox1"
        Me.txt_prev_notes.TextBox_Properties.AcceptsReturn = False
        Me.txt_prev_notes.TextBox_Properties.AcceptsTab = False
        Me.txt_prev_notes.TextBox_Properties.BackColor = System.Drawing.Color.Red
        Me.txt_prev_notes.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txt_prev_notes.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_prev_notes.TextBox_Properties.Enabled = True
        Me.txt_prev_notes.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prev_notes.TextBox_Properties.ForeColor = System.Drawing.Color.White
        Me.txt_prev_notes.TextBox_Properties.MaximumValue = 999999
        Me.txt_prev_notes.TextBox_Properties.MaxLength = 1200
        Me.txt_prev_notes.TextBox_Properties.MinimumValue = -999999
        Me.txt_prev_notes.TextBox_Properties.MultiLine = True
        Me.txt_prev_notes.TextBox_Properties.PasswordChar = Nothing
        Me.txt_prev_notes.TextBox_Properties.ReadOnly = False
        Me.txt_prev_notes.TextBox_Properties.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txt_prev_notes.TextBox_Properties.TabStop = True
        Me.txt_prev_notes.TextBox_Properties.Text = ""
        Me.txt_prev_notes.TextBox_Properties.WordWrap = True
        Me.txt_prev_notes.ValidationType = DBA.Library.DBA_TextBox.DBA_Validation_Type.DBA_None
        Me.txt_prev_notes.Visible = False
        '
        'txt_notes
        '
        Me.txt_notes.AllowNegative = False
        Me.txt_notes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_notes.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_notes.ColorCursor = True
        Me.txt_notes.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txt_notes.Control_BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_notes.DataType = DBA.Library.DBA_TextBox.DBA_data_type.DBA_String
        Me.txt_notes.Field_Name = ""
        Me.txt_notes.GridBinding = Nothing
        Me.txt_notes.Label_On_Top = True
        Me.txt_notes.Label_Properties.BackColor = System.Drawing.Color.PapayaWhip
        Me.txt_notes.Label_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_notes.Label_Properties.ForeColor = System.Drawing.Color.Black
        Me.txt_notes.Label_Properties.Text = "Notes"
        Me.txt_notes.Label_Properties.Width = 150
        Me.txt_notes.Location = New System.Drawing.Point(24, 73)
        Me.txt_notes.Mandatory = False
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.Override_Modified = False
        Me.txt_notes.SaveLoadOrder = 0
        Me.txt_notes.Size = New System.Drawing.Size(446, 281)
        Me.txt_notes.TabIndex = 0
        Me.txt_notes.TabStop = False
        Me.txt_notes.Tag = ""
        Me.txt_notes.Text = "DbA_TextBox1"
        Me.txt_notes.TextBox_Properties.AcceptsReturn = False
        Me.txt_notes.TextBox_Properties.AcceptsTab = False
        Me.txt_notes.TextBox_Properties.BackColor = System.Drawing.Color.White
        Me.txt_notes.TextBox_Properties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_notes.TextBox_Properties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_notes.TextBox_Properties.Enabled = True
        Me.txt_notes.TextBox_Properties.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_notes.TextBox_Properties.ForeColor = System.Drawing.Color.Black
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
        Me.btn_cancel.Location = New System.Drawing.Point(163, 14)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(104, 43)
        Me.btn_cancel.TabIndex = 6
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
        Me.btn_save.Location = New System.Drawing.Point(25, 14)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(105, 43)
        Me.btn_save.TabIndex = 5
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
        Me.btn_close.Location = New System.Drawing.Point(300, 14)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(100, 43)
        Me.btn_close.TabIndex = 7
        Me.btn_close.TabStop = False
        Me.btn_close.Text = "Close"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'run_notes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(491, 377)
        Me.Controls.Add(Me.pnl_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "run_notes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "run_notes"
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_main.ResumeLayout(False)
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
        End Select

        Select Case keyCode
            Case Keys.F2, Keys.F3, Keys.F4, Keys.F8
                Return True
        End Select
    End Function
#End Region

#Region " Declarations "
    Dim m_prev_form As run_bay_detail
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
        g_framework.g_forms(2) = Nothing
        Me.Close()
    End Sub
#End Region

#Region " Form Load "
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call size_screen(Me)

        ' Set Notes
        txt_prev_notes.TextBox_Properties.Text = m_prev_form.txt_notes.TextBox_Properties.Text
        txt_notes.TextBox_Properties.Text = txt_prev_notes.TextBox_Properties.Text

        Call set_toolbar_buttons("F", "F")
    End Sub
#End Region

#Region " Process "
    Private Sub Process(ByVal p_type As String)
        Select Case UCase(p_type)
            Case "SAVE"
                txt_prev_notes.TextBox_Properties.Text = txt_notes.TextBox_Properties.Text
                Call set_toolbar_buttons("F", "F")

                ' --------------------------------
                ' * Set Notes On Run Detail Screen
                ' --------------------------------
                m_prev_form.txt_notes.TextBox_Properties.Text = txt_notes.TextBox_Properties.Text

            Case "CANCEL"
                txt_notes.TextBox_Properties.Text = txt_prev_notes.TextBox_Properties.Text
                Call set_toolbar_buttons("F", "F")

            Case "CLOSE"
                ' --------------------------
                ' * Close Form Functionality
                ' --------------------------
                If btn_save.Enabled Then
                    If message_box("Do you want to save before exiting this screen?", 2, "Save before close") = MsgBoxResult.Yes Then
                        Call Process("SAVE")
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

#Region " Textbox Events "
    Private Sub txt_notes_TextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_notes.TextBox_TextChanged
        Call set_toolbar_buttons("T", "T")
    End Sub
#End Region

#End Region

End Class
