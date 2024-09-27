Public Class backdrop
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'backdrop
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(520, 422)
        Me.ControlBox = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.Name = "backdrop"
        Me.ShowInTaskbar = False
        Me.Text = "Custom Ultrasonics Inc.  © Copyright 1991-"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Overrides "
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Dim keyCode As Keys = CType((msg.WParam.ToInt32 And Keys.KeyCode), Keys)

        Select Case keyCode
            Case Keys.F4
                Return True
        End Select
    End Function
#End Region

#Region " Form Load "
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' ---------------------
        ' * Get Program Caption
        ' ---------------------
        Call get_mdi_caption()

        ' ------------------
        ' * Initialize Timer
        ' ------------------
        Call initialize_timer()

        ' -------------
        ' * Start Timer
        ' -------------
        g_timer.AutoReset = True
        g_timer.Enabled = True

        Call set_timer()

        ' -------------------
        ' * Load Login Screen
        ' -------------------
        g_login = New login(g_framework.g_db_name)
        g_login.MdiParent = g_mdi_form
        g_login.Show()
    End Sub
#End Region

End Class
