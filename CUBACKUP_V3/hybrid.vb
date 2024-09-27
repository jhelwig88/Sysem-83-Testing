Imports System.IO
Imports System.Reflection

Module HYBRED

#Region " Declarations "
    Public g_UpdateHybrid As Boolean

    Dim myAppDomain As AppDomain 'holds the hybrid dll
    Dim pObj As Object 'the instance of the hybrid dll
    Dim pAsm As [Assembly]

    Dim myZipDomain As AppDomain 'holds the dznet dll
    Dim pZip As Object 'the instance of the dznet dll
    Dim zAsm As [Assembly]
#End Region

#Region " Convert Functions "
    Public Function StringToArray(ByVal vString As String) As Byte()
        Return System.Text.Encoding.Unicode.GetBytes(vString)
    End Function

    Public Function ArrayToString(ByVal vArray() As Byte) As String
        Return System.Text.Encoding.Unicode.GetString(vArray)
    End Function
#End Region

#Region " Download Updates "
    Private Function download_updates(ByVal p_form As backup_frm) As Integer
        Dim pHybrid As Object = pObj
        Dim handle_internal As Boolean = False

        Try
            p_form.lbox_status.Items.Add(">>> Retrieving Local File List ...")
            p_form.Refresh()


            'get a list of local files 
            pHybrid.get_local_files()

            If pHybrid.version_check(0) = True Then ' dbaVersionType.CoreDLL
                p_form.lbox_status.Items.Add(">>> Downloading Updates ...")
                p_form.Refresh()


                'an update needs to be made so download the files
                pHybrid.download_files(0) ' dbaVersionType.CoreDLL

                If InStr(ArrayToString(pHybrid.pBytes), "ERROR:") Then
                    MsgBox(ArrayToString(pHybrid.pBytes))
                    download_updates = -1
                End If

                'check to see if the hybrid has to be updated.
                Dim i As Integer
                For i = 0 To pHybrid.pChangedFiles.length - 1
                    If UCase(pHybrid.pChangedFiles(i)) = "DBA HYBRID.DLL" Then
                        handle_internal = True
                    End If
                Next

                p_form.lbox_status.Items.Add(">>> Applying Changes ...")
                p_form.Refresh()

                If handle_internal = True Then
                    'handle the changes
                    pHybrid.handle_dll(True)

                    'create the trigger file
                    Dim objReader As StreamWriter
                    Dim pStream As String
                    pStream = "pFile=" & pHybrid.pFile & vbNewLine & "pDir=" & pHybrid.pDir
                    objReader = New StreamWriter(System.AppDomain.CurrentDomain.BaseDirectory & "hybrid.dat")
                    objReader.Write(pStream)
                    objReader.Close()

                    End
                Else
                    'handle the changes
                    pHybrid.handle_dll()
                End If
                download_updates = 1
                p_form.lbox_status.Items.Add(">>> Changes Applied ...")
                p_form.Refresh()

            Else
                p_form.lbox_status.Items.Add(">>> No Updates Found ...")
                p_form.Refresh()
            End If

            'get the main dll name
            pHybrid.get_main_dll_name()
        Catch
            download_updates = -1
        End Try

    End Function
#End Region

#Region " UnZip "
    Public Sub unZip()
        Dim pDir As String
        Dim pFile As String

        pDir = pObj.pDir
        pFile = pObj.pFile

        'unload the hybrid appdomain=======
        pObj = Nothing
        pAsm = Nothing

        System.AppDomain.Unload(myAppDomain)
        '==================================

        'load the dll
        load_zip_dll()

        Dim duz1 As Object
        duz1 = pZip

        duz1.ZIPFile = pDir & "\" & pFile
        duz1.Filespec = "*.*"
        duz1.Destination = pDir
        duz1.RecurseFlag = False
        duz1.AllQuiet = True
        'duz1.AllQuiet = False
        duz1.MessageCallbackFlag = True
        duz1.NoDirectoryNamesFlag = True
        duz1.OverwriteFlag = True
        duz1.NoDirectoryItemsFlag = True
        duz1.UnzipSubOptions = 1 'pZip.UNZIPSUBOPTION.USO_OVERWRITE_RO

        duz1.ActionDZ = 8 'pZip.DUZACTION.UNZIP_EXTRACT

        If duz1.ErrorCode <> 0 Then 'pZip.UNZIPRESPONSE.UE_OK Then
            Debug.WriteLine("UnZIP Error: " & duz1.ErrorCode & " - " + duz1.ErrorCode.ToString())
        Else
            Debug.WriteLine("UnZIP OK")
        End If


        'unload the zip domain==============
        pZip = Nothing
        System.AppDomain.Unload(myZipDomain)
        '===================================

        'reload the hybrid dll
        load_hybrid_dll() 'possibly change to true 
    End Sub
#End Region

#Region " Load Hybrid DLL "
    Private Function load_hybrid_dll() As Integer
        Dim pAsmName As String
        Dim pFullPath As String
        Dim mySetup As New AppDomainSetup

        Try
            pFullPath = System.AppDomain.CurrentDomain.BaseDirectory

            mySetup.ApplicationBase = pFullPath

            Dim file As New FileInfo(pFullPath & "DBA Hybrid.dll")

            'get the assembly name
            pAsmName = file.Name.Replace(file.Extension, "")

            'Create the app domain
            myAppDomain = System.AppDomain.CreateDomain("HybridDomain", Nothing, mySetup)

            'load the assembly
            pAsm = myAppDomain.Load(pAsmName)

            'Get the Form from the assembly
            Dim formtype As Type = pAsm.GetType("DBA.Hybrid.dbaHybrid")

            'creates an instance of the dll so that the repot will run
            Dim pArgs(0) As Object
            pArgs(0) = False
            pObj = Activator.CreateInstance(formtype, pArgs)
            load_hybrid_dll = 1
        Catch
            load_hybrid_dll = 0
        End Try
    End Function
#End Region

#Region " Load Zip DLL "
    Private Sub load_zip_dll()
        Dim pAsmName As String
        Dim pFullPath As String

        pFullPath = System.AppDomain.CurrentDomain.BaseDirectory

        Dim file As New FileInfo(pFullPath & "dznet.dll")

        'get the assembly name
        pAsmName = file.Name.Replace(file.Extension, "")

        'create the new application domain
        Dim mySetup As New AppDomainSetup
        mySetup.ApplicationBase = pFullPath

        'Create the app domain
        myZipDomain = System.AppDomain.CreateDomain("ZipDomain", Nothing, mySetup)

        'load the assembly
        zAsm = myZipDomain.Load(pAsmName)

        'Get the Form from the assembly
        Dim formtype As Type = zAsm.GetType("CDUnZipNET")

        'creates an instance of the dll so that the repot will run
        pZip = Activator.CreateInstance(formtype)
    End Sub
#End Region

#Region " Execute_Updater "
    Public Function execute_updater(ByVal p_form As backup_frm) As Integer
        'loads the hybrid dll into an appdomain so it is still updatable
        If load_hybrid_dll() = 0 Then
            execute_updater = -1
        End If

        'do the download
        execute_updater = download_updates(p_form)
    End Function
#End Region

#Region " END UPDATE "
    Private Sub ENDUPDATE()
        'unload the hybrid appdomain=======
        pObj = Nothing
        pAsm = Nothing

        System.AppDomain.Unload(myAppDomain)
        '==================================
    End Sub
#End Region

End Module

