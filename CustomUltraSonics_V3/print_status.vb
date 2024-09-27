Public Class print_status
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
    Friend WithEvents progress As DBA.Library.DBA_ProgressBar
    Friend WithEvents lbl_status As DBA.Library.DBA_Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.progress = New DBA.Library.DBA_ProgressBar
        Me.lbl_status = New DBA.Library.DBA_Label(Me.components)
        Me.SuspendLayout()
        '
        'progress
        '
        Me.progress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.progress.Border = System.Windows.Forms.BorderStyle.FixedSingle
        Me.progress.BorderColor = System.Drawing.Color.Black
        Me.progress.Bounce = False
        Me.progress.DisplayPercentText = False
        Me.progress.Location = New System.Drawing.Point(3, 4)
        Me.progress.Maximum = 100
        Me.progress.Minimum = 0
        Me.progress.Name = "progress"
        Me.progress.PercentTextColor = System.Drawing.Color.White
        Me.progress.PercentTextFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.progress.ProgressBarColor = System.Drawing.Color.Blue
        Me.progress.Size = New System.Drawing.Size(518, 21)
        Me.progress.TabIndex = 14
        Me.progress.Text = "DbA_ProgressBar1"
        Me.progress.Value = 0
        Me.progress.VerticalDirection = False
        '
        'lbl_status
        '
        Me.lbl_status.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_status.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_status.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.ForeColor = System.Drawing.Color.Black
        Me.lbl_status.Location = New System.Drawing.Point(6, 31)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(518, 16)
        Me.lbl_status.TabIndex = 15
        Me.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'print_status
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(524, 47)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.progress)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "print_status"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Status"
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
