'-Cycle Array Class 
'-Cycle Class

#Region " Cycle Array Class "

Public Class CycleArray
    Inherits CollectionBase

    Default Public Property Item(ByVal Index As Integer) As Cycle
        Get
            Return CType(list.Item(Index), Cycle)
        End Get
        Set(ByVal Value As Cycle)
            list.Item(Index) = Value
        End Set
    End Property

    Default Public Property Item(ByVal Cycle As Cycle) As Cycle
        Get
            For Each pObj As Cycle In list
                If pObj Is Cycle Then
                    Return pObj
                End If
            Next

            Return Nothing
        End Get
        Set(ByVal Value As Cycle)
            For Each pObj As Cycle In list
                If pObj Is Cycle Then
                    pObj = Value
                End If
            Next
        End Set
    End Property
    Public Function Find(ByVal Name As String) As Integer
        Dim i As Integer

        For i = 0 To list.Count - 1
            If UCase(list.Item(i).Name) = UCase(Name) Then
                Return i
                Exit Function
            End If
        Next

        Return -1
    End Function

    'Adds an item to the collection 
    Public Function Add(ByVal Item As Cycle) As Integer
        Return list.Add(Item)
    End Function

    Public Sub Remove(ByVal Item As Cycle)
        list.Remove(Item)
    End Sub

End Class

#End Region

#Region " Cycle Class "

Public Class Cycle

    Private _cycle As PCBStructs.CYCLES
    Private _startTime As DateTime
    Private _stopTime As DateTime

    Public SystemOverrides As SystemOverrides
    Public Phases As PhaseArray


    Public Sub New(ByVal Cycle As PCBStructs.CYCLES)
        SystemOverrides = New SystemOverrides
        Phases = New PhaseArray
        _startTime = New DateTime

        _cycle = Cycle

        'Build the phases that make up the cycle
        Call BuildPhases()
    End Sub

    Public Property Cycle() As PCBStructs.CYCLES
        Get
            Return _cycle
        End Get
        Set(ByVal Value As PCBStructs.CYCLES)
            _cycle = Value
        End Set
    End Property

    Friend Property StartTime() As DateTime
        Get
            Return _startTime
        End Get
        Set(ByVal Value As DateTime)
            _startTime = Value
        End Set
    End Property

    Friend Property StopTime() As DateTime
        Get
            Return _stopTime
        End Get
        Set(ByVal Value As DateTime)
            _stopTime = Value
        End Set
    End Property

    Private Sub BuildPhases()
        Select Case _cycle
            Case PCBStructs.CYCLES.DISINFECT
                Phases.Add(New Phase(PCBStructs.PHASES.FILL))         'Fill Phase
                Phases.Add(New Phase(PCBStructs.PHASES.DISINFECT))    'Disinfect Phase
                Phases.Add(New Phase(PCBStructs.PHASES.DRAIN))        'Drain Phase

            Case PCBStructs.CYCLES.DRY
                Phases.Add(New Phase(PCBStructs.PHASES.DRY))          'Dry Phase

            Case PCBStructs.CYCLES.PRERINSE
                Phases.Add(New Phase(PCBStructs.PHASES.PRERINSE))     'Prerinse Phase
                Phases.Add(New Phase(PCBStructs.PHASES.DRAIN))        'Drain Phase

            Case PCBStructs.CYCLES.RINSE
                Phases.Add(New Phase(PCBStructs.PHASES.FILL))         'Fill Phase
                Phases.Add(New Phase(PCBStructs.PHASES.RINSE))        'Rinse Phase
                Phases.Add(New Phase(PCBStructs.PHASES.DRAIN))        'Drain Phase

            Case PCBStructs.CYCLES.SOAK
                Phases.Add(New Phase(PCBStructs.PHASES.FILL))         'Fill Phase
                Phases.Add(New Phase(PCBStructs.PHASES.SOAK))         'Soak Phase
                Phases.Add(New Phase(PCBStructs.PHASES.DRAIN))        'Drain Phase

            Case PCBStructs.CYCLES.WASH
                Phases.Add(New Phase(PCBStructs.PHASES.FILL))         'Fill Phase
                Phases.Add(New Phase(PCBStructs.PHASES.WASH))         'Wash Phase
                Phases.Add(New Phase(PCBStructs.PHASES.DRAIN))        'Drain Phase
        End Select
    End Sub

End Class

#End Region
