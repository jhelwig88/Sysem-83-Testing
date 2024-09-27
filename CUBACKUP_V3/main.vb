Module main

#Region " Declarations "
    ' CU Local Machine
    Public g_framework As New DBA_Framework.DBA_Foundation_Class("CU", "", "")
    Public g_service_url As String = "http://localhost/dba_xzip_webservice/service.asmx"

    ' DBA INTERNAL
    'Public g_framework As New DBA_Framework.DBA_Foundation_Class("CU_DBA", "", "")
    'Public g_service_url As String = "http://localhost/dba_xzip_webservice/service.asmx"

    ' CUS EXTERNAL
    'Public g_framework As New DBA_Framework.DBA_Foundation_Class("CU_TEST", "", "")
    'Public g_service_url As String = "http://71.162.146.2/dba_xzip_webservice/service.asmx"

    ' England EXTERNAL
    'Public g_framework As New DBA_Framework.DBA_Foundation_Class("CU_ENGLAND", "", "")
    'Public g_service_url As String = "http://71.162.146.2/dba_xzip_webservice/service.asmx"
#End Region

#Region " Sub Main "
    Public Sub main()
        ' -----------------------------------------------------------------
        ' * Check for a previous instance of the program is already running
        ' -----------------------------------------------------------------
        g_framework.update_url(g_service_url)

        ' Load Back Drop
        Dim p_form As backup_frm
        p_form = New backup_frm(g_framework.g_db_name)
        p_form.ShowDialog()
    End Sub
#End Region

End Module
