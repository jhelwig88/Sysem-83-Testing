Imports System.Windows.Forms
Imports System.Drawing

Public Class ScreenSaver

#Region " SSForm Class "
    Friend Class SSForm
        Inherits System.Windows.Forms.Form

        Private _ssobj As ScreenSaver

#Region " New "
        Friend Sub New(ByVal SS As ScreenSaver)
            _ssobj = SS
        End Sub
#End Region

#Region " Overrides "
        Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
            Call stopSS()
        End Function

        'Private Sub SSForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        '    Call stopSS()
        'End Sub
#End Region

#Region " Stop Screen Saver "
        Private Sub stopSS()
            If _ssobj.running = True Then
                _ssobj.StopScreenSaver()
            End If
        End Sub
#End Region

    End Class

#End Region

#Region " Public Events "
    Public Event BeforeScreenSaverActivated As EventHandler
    Public Event AfterScreenSaverDone As EventHandler
#End Region

#Region " Private Declarations "
    Private SSFormObj As SSForm
    Private SSPicture As PictureBox
    Private SSTimer As Timer

    Private speed As Integer = 2

    Private minx As Integer = 5
    Private miny As Integer = 5
    Private rx, ry As Integer
    Private maxx As Integer
    Private maxy As Integer
    Private xoffset As Integer = 1
    Private yoffset As Integer = 1
    Private x As Integer
    Private y As Integer

    Friend running As Boolean
#End Region

#Region " Sub New "
    Public Sub New()
        SSFormObj = New SSForm(Me)
        SSPicture = New PictureBox
        SSTimer = New Timer

        running = False
    End Sub
#End Region

#Region " Create Screen Saver "
    Private Sub CreateScreenSaver()
        x = 50
        y = 50
        rx = 1
        ry = 1

        'Create the form
        SSFormObj.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        SSFormObj.WindowState = Windows.Forms.FormWindowState.Maximized
        SSFormObj.Text = "Custom Ultra Sonics"
        SSFormObj.TopMost = True
        SSFormObj.ControlBox = False
        SSFormObj.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
        SSFormObj.BackColor = System.Drawing.Color.Black
        SSFormObj.ShowInTaskbar = False

        'Load the logo image
        Dim ssBitmap As New Bitmap(Me.GetType().Assembly.GetManifestResourceStream("CUSNET.newlogo.gif"))
        SSPicture.Image = ssBitmap
        SSPicture.SizeMode = PictureBoxSizeMode.AutoSize
        SSPicture.Location = New Point(minx, miny)

        'Add the picture to the form
        SSFormObj.Controls.Add(SSPicture)

        AddHandler SSTimer.Tick, AddressOf Timer1Tick
        SSTimer.Interval = 1
        SSTimer.Enabled = True
        running = True

        SSFormObj.ShowDialog()
    End Sub
#End Region

#Region " Run Screen Saver "
    Public Sub RunScreenSaver()
        RaiseEvent BeforeScreenSaverActivated(Me, New System.EventArgs)

        Call CreateScreenSaver()
    End Sub
#End Region

#Region " Stop Screen Saver "
    Friend Sub StopScreenSaver()

        SSTimer.Enabled = False
        SSTimer.Dispose()
        SSFormObj.Close()
        SSFormObj.Dispose()
        SSPicture = Nothing

        running = False

        'Raise the after screen saver event
        RaiseEvent AfterScreenSaverDone(Me, New System.EventArgs)
    End Sub
#End Region

#Region " Timer1Tick "
    Private Sub Timer1Tick(ByVal sender As Object, ByVal e As EventArgs)
        maxx = SSFormObj.Width - SSPicture.Width - 5
        maxy = SSFormObj.Height - SSPicture.Height - 5
        SSFormObj.Focus()

        If x >= maxx Then
            rx = -speed
        ElseIf x <= minx Then
            rx = speed
        End If

        If y >= maxy Then
            ry = -speed
        ElseIf y <= miny Then
            ry = speed
        End If

        x += rx
        y += ry

        SSPicture.Location = New Point(x, y)
        SSPicture.Refresh()
    End Sub
#End Region

End Class

