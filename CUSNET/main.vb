Module main

#Const IO_TYPE = "USB"
    '#Const IO_TYPE = "PCI"

#Region " Declarations "
    'Ultrasonics Sensor Usage
    Public g_us_usage As Boolean = True

    ' I/O Card Type
#If IO_TYPE = "USB" Then
    Public g_io_usb As Boolean = True

#ElseIf IO_TYPE = "PCI" Then
    Public g_io_usb As Boolean = False
#End If

#End Region

#Region " Public Constants "
    ' Add FirstPortA Items
    Public Const O_ULTRA = "O_ULTRA"
    Public Const O_DRAIN_P = "O_DRAIN_P"
    Public Const O_DRAIN_V = "O_DRAIN_V"
    Public Const O_WATER_V = "O_WATER_V"
    Public Const O_OSC_P = "O_OSC_P"
    Public Const O_DIS_P = "O_DIS_P"
    Public Const O_DIS_F_V = "O_DIS_F_V"
    Public Const O_DIS_R_V = "O_DIS_R_V"

    ' Add FirstPortCL Items
    Public Const O_RES_D = "O_RES_D"
    Public Const O_AIR = "O_AIR"
    Public Const O_LUB_P = "O_LUB_P"
    Public Const O_RES_H = "O_RES_H"

    ' Add FirstPortCH Items
    Public Const O_BAY_H = "O_BAY_H"
    Public Const O_RINSE_S = "O_RINSE_S"
    Public Const O_DET_81_P = "O_DET_81_P"
    Public Const O_ENZ_P = "O_ENZ_P"

    ' Add FirstPortB Items
    Public Const I_FLOW = "I_FLOW"
    Public Const I_FLOAT = "I_FLOAT"
    Public Const I_SAFETY = "I_SAFETY"
    Public Const I_PRESSURE = "I_PRESSURE"
    Public Const I_ULTRASONICS = "I_ULTRASONICS"
#End Region

End Module
