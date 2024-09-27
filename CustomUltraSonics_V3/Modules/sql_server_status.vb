Imports Microsoft.SqlServer.Management.Smo.Wmi

Module sql_server_status

#Region " Check SQL Server Status "
    Public Function Check_SQL_Server_Status() As Boolean
        ' Default Return Value
        Check_SQL_Server_Status = False

        Try
            ' ========================================================================================================
            ' * Declare and create an instance of the ManagedComputer object that represents the WMI Provider services
            ' ========================================================================================================
            Dim mc As ManagedComputer
            mc = New ManagedComputer()

            ' ============================================
            ' * Reference the Microsoft SQL Server service
            ' ============================================
            Dim svc As Service
            svc = mc.Services("MSSQL$SQLEXPRESS")

            ' ------------------------------------------------------------------
            ' * Check SQL Server Service Start Mode - Set to Automatic If Needed
            ' ------------------------------------------------------------------
            If svc.StartMode <> ServiceStartMode.Auto Then
                svc.StartMode = ServiceStartMode.Auto
                svc.Alter()
            End If

            ' ================================
            ' * Check SQL Server Service State
            ' ================================
            Select Case svc.ServiceState
                Case ServiceState.Running
                Case ServiceState.Stopped
                    Dim p_count As Integer

                    ' ---------------------------------------------------------
                    ' * Start the service and check to see when finally running
                    ' ---------------------------------------------------------
                    svc.Start()

                    Do Until String.Format("{0}", svc.ServiceState) = "Running"
                        If p_count > 20 Then
                            'Exit if Service Doesn't Start After 20 Times
                            Exit Function
                        End If

                        p_count += 1
                        System.Threading.Thread.Sleep(1000)

                        svc.Refresh()
                    Loop

                    ' -------------------------------------------------------------------
                    ' * Allow Time between Service Start and Database Calls by Webservice
                    ' -------------------------------------------------------------------
                    System.Threading.Thread.Sleep(3000)

                Case ServiceState.Paused
                    Dim p_count As Integer

                    ' ----------------------------------------------------------
                    ' * Resume the service and check to see when finally running
                    ' ----------------------------------------------------------
                    svc.Resume()

                    Do Until String.Format("{0}", svc.ServiceState) = "Running"
                        If p_count > 20 Then
                            'Exit if Service Doesn't Start After 20 Times
                            Exit Function
                        End If

                        p_count += 1
                        System.Threading.Thread.Sleep(1000)

                        svc.Refresh()
                    Loop

                    ' -------------------------------------------------------------------
                    ' * Allow Time between Service Start and Database Calls by Webservice
                    ' -------------------------------------------------------------------
                    System.Threading.Thread.Sleep(3000)

                Case Else
                    Exit Function
            End Select

            Check_SQL_Server_Status = True

        Catch ex As Exception
            Call message_box(ex.Message, 1)
        End Try
    End Function
#End Region

End Module
