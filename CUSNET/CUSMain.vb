Public Class CUSMain

#Region " Public Declarations "
    Public Machines As MachineArray
    Public Active_Bays As Integer
#End Region

#Region " Private Declarations "
    Private _ADBoard As MccDaq.MccBoard
    Private _running As Boolean

    Private _tempMonitor As TempMonitor
#End Region

#Region " Public Properties "
    Public ReadOnly Property Temp_Monitor_Status() As Boolean
        Get
            Return _tempMonitor.MonitoringState
        End Get
    End Property
#End Region

#Region " Friend Properties "
    Friend ReadOnly Property ADBoard() As MccDaq.MccBoard
        Get
            Return _ADBoard
        End Get
    End Property

    Friend Property Running() As Boolean
        Get
            Return _running
        End Get
        Set(ByVal Value As Boolean)

            If Value <> _running Then
                _running = Value
            End If

        End Set
    End Property
#End Region

#Region " Sub New "
    Public Sub New(ByVal ADBoardNumber As Integer)
        _running = False

        'create a new machine array
        Machines = New MachineArray

        'Load the AD Board reference
        _ADBoard = New MccDaq.MccBoard(ADBoardNumber)

        'Initialize the board
        Call InitADBoard()
    End Sub
#End Region

#Region " Add Machine "
    Public Function AddMachine(ByVal MachineName As String, ByVal BoardNumber As Integer, ByVal BayNumber As Integer, _
        ByVal DemoMode As Boolean, ByVal EnglandMode As Boolean) As Integer
        Dim _tmpName As String
        Dim _index As Integer

        'Assign a unique name to the machine
        _tmpName = Guid.NewGuid.ToString

        'Add the machine
        _index = HandleAddMachine(_tmpName, BoardNumber, BayNumber, DemoMode, EnglandMode)

        Return _index
    End Function
#End Region

#Region " Handle Add Machine "
    Private Function HandleAddMachine(ByVal tmpName As String, ByVal BoardNumber As Integer, ByVal BayNumber As Integer, _
        ByVal DemoMode As Boolean, ByVal EnglandMode As Boolean) As Integer
        Dim _index As Integer

        'Create a new Machine
        Dim _tmpMachine As New Machine(tmpName, BoardNumber, BayNumber, Me, DemoMode, EnglandMode)

        'Add the machine
        _index = Machines.Add(_tmpMachine)

        Return _index
    End Function
#End Region

#Region " Initialize AD Board "
    Private Sub InitADBoard()
        Dim UsesEXPs As Integer
        Dim ULStat As MccDaq.ErrorInfo

        ULStat = MccDaq.MccService.DeclareRevision(MccDaq.MccService.CurrentRevNum)

        ULStat = MccDaq.MccService.ErrHandling(MccDaq.ErrorReporting.DontPrint, MccDaq.ErrorHandling.DontStop)

        ' Determine if the board uses EXP boards for temperature measurements
        UsesEXPs = 0
        ULStat = _ADBoard.BoardConfig.GetUsesExps(UsesEXPs)
        If (ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors) Then UsesEXPs = 0
    End Sub
#End Region

#Region " Start Temperature Monitoring "
    Public Sub Start_Temp_Monitor()
        'Start Temperature Monitoring
        _tempMonitor = New TempMonitor(Me)
        _tempMonitor.StartMonitoring()
    End Sub
#End Region

#Region " Stop Temperature Monitoring "
    Public Sub Stop_Temp_Monitor()
        If Not _tempMonitor Is Nothing Then
            _tempMonitor.StopMonitoring()
        End If
    End Sub
#End Region

End Class
