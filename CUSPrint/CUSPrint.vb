
#Region " Text Printing "

Public Class TextPrinting

#Region " Declarations "
    Private _portName As String
#End Region

#Region " Constructor "
    Public Sub New(ByVal PortName As String)
        _portName = PortName
    End Sub
#End Region

#Region " Main Print Function "
    Public Sub Print(ByVal PrintText As ArrayList)
        Dim p_string As String = ""

        'Write each line in the array
        For Each pStr As String In PrintText
            p_string &= pStr & vbCrLf
        Next

        ' Send Text to Printer
        RawPrinterHelper.SendStringToPrinter("Generic / Text Only", p_string)
    End Sub
#End Region

End Class

#End Region

#Region " Dataset Printing "

Public Class DatasetPrinting

#Region " Declarations "
    Private _DataSetToPrint As DataSet
    Private _ReportTitle As String = ""
    Private _cusPrint As TextPrinting
#End Region

#Region " Constructor Code "
    Public Sub New(ByVal PortName As String)
        _cusPrint = New TextPrinting(PortName)
    End Sub
#End Region

#Region " Class Properties "
    Public WriteOnly Property ReportTitle() As String
        ' Allows setting the title to be used for the report.
        Set(ByVal theValue As String)
            _ReportTitle = theValue
        End Set
    End Property

    Public WriteOnly Property DataSetToPrint() As DataSet

        ' Sets the dataset whose content is to be printed.
        Set(ByVal theValue As DataSet)
            Try
                _DataSetToPrint = theValue
            Catch e As Exception
                Throw New Exception("Error initializing the print data.", e)
            End Try
        End Set
    End Property
#End Region

#Region " Print "
    Public Sub Print()
        Try
            ' Get out if no dataset was passed in.
            If _DataSetToPrint Is Nothing Then Exit Sub
            If _DataSetToPrint.Tables(0).Rows.Count = 0 Then Exit Sub

            Dim aLines As Integer = _DataSetToPrint.Tables(0).Rows.Count

            '========================
            'Do the printing
            '========================
            _cusPrint.Print(BuildPrintList)

        Catch e As Exception
            Throw New Exception("Unable to print report.", e)
        End Try

    End Sub

#End Region

#Region " Build Print List "
    Private Function BuildPrintList() As ArrayList
        Dim tmpList As New ArrayList
        Dim CharWidth As Integer = 40
        Dim rowCount As Integer = 0

        'Build the Report Header==========================
        tmpList.Add(Format(DateTime.Now, "ddd MMM d yyyy h:mm:ss tt"))
        If Trim(_ReportTitle) <> "" Then
            tmpList.Add("Report: " & _ReportTitle)
        End If
        tmpList.Add("---------------------------------------")
        '=================================================

        If _DataSetToPrint.Tables(0).Columns.Count = 1 Then
            For Each pCol As DataColumn In _DataSetToPrint.Tables(0).Columns
                tmpList.Add(pCol.Caption & ":")

                For Each pRow As DataRow In _DataSetToPrint.Tables(0).Rows
                    tmpList.Add("  " & pRow.Item(pCol))
                Next
            Next
        Else
            For Each pRow As DataRow In _DataSetToPrint.Tables(0).Rows
                For Each pCol As DataColumn In _DataSetToPrint.Tables(0).Columns
                    tmpList.Add(pCol.Caption & ":")
                    tmpList.Add("  " & pRow.Item(pCol))
                Next
                rowCount += 1
                If rowCount < _DataSetToPrint.Tables(0).Rows.Count Then
                    tmpList.Add("----                               ----")
                End If
            Next
        End If

        'Used to line feed
        tmpList.Add("")
        tmpList.Add("")
        tmpList.Add("")
        tmpList.Add("")
        '================

        Return tmpList
    End Function
#End Region

End Class

#End Region