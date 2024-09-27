Public Class SystemOverrides
    Implements ICloneable

    Public wash_secs As Integer
    Public rinse_secs As Integer
    Public disinfect_secs As Integer
    Public lub_secs As Integer

    Public drain_30_secs As Integer
    Public drain_10_secs As Integer

    Public warwick_delay_secs As Integer
    Public float_delay_secs As Integer
    Public pressure_start_delay_secs As Integer
    Public pressure_error_delay_secs As Integer
    Public safety_delay_secs As Integer
    Public ultrasonics_delay_secs As Integer

    ' Temperature Settings
    Public min_temperature As Integer
    Public max_temperature As Integer
    Public min_start_temperature As Integer
    Public max_abort_temperature As Integer

    ' System 82 Specific
    Public dis_ultra_secs As Integer

    ' System 81 Specific
    Public spray_rinse_wait_secs As Integer
    Public spray_rinse_secs As Integer
    Public detergent_81_secs As Integer
    Public enzyme_secs As Integer
    Public soak_secs As Integer
    Public prerinse_secs As Integer
    Public reservoir_fill_secs As Integer

    ' System 83 Specific
    Public detergent_83_secs As Integer
    Public dry_heat_secs As Integer
    Public dry_cool_secs As Integer

    ' Delays
    Public fill_flow_secs As Integer
    Public fill_float_secs As Integer
    Public drain_float_secs As Integer
    Public drain_flow_secs As Integer
    Public float_abort_delay_secs As Long

    ' England Aborts
    Public fill_min_abort_secs As Integer
    Public fill_max_abort_secs As Integer
    Public drain_min_abort_secs As Integer
    Public drain_max_abort_secs As Integer

    Public Function Clone() As Object Implements System.ICloneable.Clone
        Dim cloneObj As SystemOverrides = Me.MemberwiseClone
        Return cloneObj
    End Function
End Class