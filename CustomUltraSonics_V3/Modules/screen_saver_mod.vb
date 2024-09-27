Module screen_saver_mod

#Region " Declarations "
    Public g_timer As System.Timers.Timer
#End Region

#Region " Initialize Timer "
    Public Sub initialize_timer()
        Dim p_dataset As DataSet
        Dim p_db_row As DataRow

        Dim p_interval As Integer
        Dim p_main_interval As Integer

        ' ---------------------------------------------
        ' * Get Screen Saver Seconds From Main Settings
        ' ---------------------------------------------
        p_dataset = g_framework.Get_Data("SELECT screen_saver_sec FROM settings_maint")

        If p_dataset.Tables(0).Rows.Count > 0 Then
            ' Get Row
            p_db_row = p_dataset.Tables(0).Rows(0)

            p_interval = p_db_row("screen_saver_sec").ToString
        Else
            p_interval = 600
        End If

        ' Dispose of Dataset
        p_dataset.Dispose()

        ' --------------------
        ' * Set Timer Defaults
        ' --------------------
        p_main_interval = p_interval * 1000

        ' Create Timer
        g_timer = New System.Timers.Timer(p_main_interval)

        ' Handle Timer Elapsed
        AddHandler g_timer.Elapsed, AddressOf ServiceTimer_Tick
    End Sub
#End Region

#Region " Reset Timer Interval "
    Public Sub reset_timer_interval(ByVal p_interval As Integer)
        ' ----------------------
        ' * Reset Timer Interval
        ' ----------------------
        g_timer.Stop()

        ' Reset Interval
        g_timer.Interval = p_interval * 1000

        Call set_timer()
    End Sub
#End Region

#Region " Restart Timer "
    Public Sub restart_timer()
        ' -------------
        ' * Reset Timer
        ' -------------
        g_timer.Stop()
        Call set_timer()
    End Sub

    Public Sub restart(ByVal sender As Object, ByVal e As System.EventArgs)
        Call restart_timer()
    End Sub
#End Region

#Region " Timer Tick "
    Private Sub ServiceTimer_Tick(ByVal sender As System.Object, ByVal e As System.Timers.ElapsedEventArgs)
        ' Stop Timer For Processing Check
        g_timer.Stop()

        If g_ss_disabled_flag Then Exit Sub

        ' -----------------------------------------------------
        ' * If Any Machines Are Running Then Abort Screen Saver
        ' -----------------------------------------------------
        Try
            For p_x As Integer = 0 To g_bay_count - 1
                If g_CUSMain.Machines(p_x).Bay_Running Then
                    Call set_timer()
                    Exit Sub
                ElseIf Not g_CUSMain.Machines(p_x).Finished And g_CUSMain.Machines(p_x).Processed Then
                    Call set_timer()
                    Exit Sub
                End If
            Next
        Catch
            Call set_timer()
            Exit Sub
        End Try

        ' ------------------
        ' * Show ScreenSaver
        ' ------------------
        Dim p_screensaver As New CUSNET.ScreenSaver
        AddHandler p_screensaver.AfterScreenSaverDone, AddressOf restart
        p_screensaver.RunScreenSaver()
    End Sub
#End Region

#Region " Set Timer "
    Public Sub set_timer()
        If g_ss_disabled_flag Then
            g_timer.Stop()
        Else
            g_timer.Start()
        End If
    End Sub
#End Region

End Module
