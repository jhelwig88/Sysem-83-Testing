Imports System
Imports System.Collections

#Region " Bit Array "

Public Class BitArray
    Inherits CollectionBase

    Default Public ReadOnly Property Item(ByVal p_name As String) As Bit
        Get
            For Each pObj As Bit In list
                If pObj.Name = p_name Then
                    Return pObj
                    Exit Property
                End If
            Next

            Return Nothing
        End Get

    End Property

    Friend Function Add(ByVal Item As Bit) As Integer
        Return list.Add(Item)
    End Function
End Class

#End Region

#Region " Bit Class "

Public Class Bit

#Region " Private Declarations "
    Private _name As String
    Private _bit_state As Boolean
    Private _port_type As MccDaq.DigitalPortType
    Private _port_number As Integer
#End Region

#Region " Public Properties "
    Public ReadOnly Property Name() As String
        Get
            Return _name
        End Get
    End Property

    Public ReadOnly Property PortType() As MccDaq.DigitalPortType
        Get
            Return _port_type
        End Get
    End Property

    Public ReadOnly Property PortNum() As Integer
        Get
            Return _port_number
        End Get
    End Property

    Public Property State() As Boolean
        Get
            Return _bit_state
        End Get
        Set(ByVal Value As Boolean)
            _bit_state = Value
        End Set
    End Property
#End Region

#Region " Sub New "
    Public Sub New(ByVal p_name As String, ByVal p_port_type As MccDaq.DigitalPortType, _
        ByVal p_port_num As Integer)
        _name = p_name
        _bit_state = False
        _port_type = p_port_type
        _port_number = p_port_num
    End Sub
#End Region

End Class

#End Region


