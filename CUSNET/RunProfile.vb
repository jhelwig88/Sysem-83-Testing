Public Structure RunProfile
    '=============PROCESS SPECIFIC VALUES=============
    Dim current_cycle As Cycle
    Dim current_phase As Phase
    Dim cycles_completed As Integer
    Dim phases_completed As Integer

    'holds a structure of the bits
    Dim bits As BitArray

    Dim res_temperature As Integer
    Dim bay_temperature As Integer

    Dim error_message As String
    Dim run_header_id As String
    '=================================================
End Structure
