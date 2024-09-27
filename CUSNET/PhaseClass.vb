'-Phase Array Class 
'-Phase Class

#Region " Phase Array Class "

Public Class PhaseArray
    Inherits CollectionBase

    Default Public Property Item(ByVal Index As Integer) As Phase
        Get
            Return CType(list.Item(Index), Phase)
        End Get
        Set(ByVal Value As Phase)
            list.Item(Index) = Value
        End Set
    End Property

    Default Public Property Item(ByVal Phase As Phase) As Phase
        Get
            For Each pObj As Phase In list
                If pObj Is Phase Then
                    Return pObj
                End If
            Next

            Return Nothing
        End Get
        Set(ByVal Value As Phase)
            For Each pObj As Phase In list
                If pObj Is Phase Then
                    pObj = Value
                End If
            Next
        End Set
    End Property

    'Adds an item to the collection 
    Public Function Add(ByVal Item As Phase) As Integer
        Return list.Add(Item)
    End Function

    Public Sub Remove(ByVal Item As Phase)
        list.Remove(Item)
    End Sub

End Class

#End Region

#Region " Phase Class "

Public Class Phase
    Friend _phaseTime As Decimal

    Private _phase As PCBStructs.PHASES
    Private _startTime As DateTime
    Private _stopTime As DateTime

    Public Sub New(ByVal Phase As PCBStructs.PHASES)
        _startTime = New DateTime
        _phase = Phase
    End Sub

    'This sets up the phase timing based off of a System Override
    Public Sub AssignTimeInfo(ByVal PinOut As PCBStructs.SYSTEM_ID_DEF, ByVal Settings As SystemOverrides)
        Select Case _phase
            Case PCBStructs.PHASES.DISINFECT
                _phaseTime = Settings.disinfect_secs

            Case PCBStructs.PHASES.DRAIN
                _phaseTime = 0

            Case PCBStructs.PHASES.DRY
                _phaseTime = Settings.dry_cool_secs
                _phaseTime += Settings.dry_heat_secs

            Case PCBStructs.PHASES.FILL
                _phaseTime = 0

            Case PCBStructs.PHASES.PRERINSE
                _phaseTime = Settings.prerinse_secs

            Case PCBStructs.PHASES.RINSE
                _phaseTime = Settings.rinse_secs

            Case PCBStructs.PHASES.SOAK
                _phaseTime = Settings.soak_secs

            Case PCBStructs.PHASES.WASH
                _phaseTime = Settings.wash_secs
        End Select
    End Sub

#Region " Public Properties "
    Public ReadOnly Property PhaseTime() As Decimal
        Get
            Return _phaseTime
        End Get
    End Property

    Public ReadOnly Property Phase() As PCBStructs.PHASES
        Get
            Return _phase
        End Get
    End Property

    Public Property StartTime() As DateTime
        Get
            Return _startTime
        End Get
        Set(ByVal Value As DateTime)
            _startTime = Value
        End Set
    End Property

    Public Property StopTime() As DateTime
        Get
            Return _stopTime
        End Get
        Set(ByVal Value As DateTime)
            _stopTime = Value
        End Set
    End Property
#End Region

End Class

#End Region
