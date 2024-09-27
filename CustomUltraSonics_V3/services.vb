Public Class services
    Inherits DBA_Framework.DBA_Foundation_Class

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal p_db_name As String, ByVal p_prev_form As Form, ByVal p_close_index As Integer)
        MyBase.New(p_db_name, g_framework.g_version, g_framework.g_user_id)

        'set the webservice url
        MyBase.update_url(g_service_url)

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        m_prev_form = p_prev_form
        m_close_index = p_close_index
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        g_framework.HandleClose(Me.Name)
        g_framework.handle_windows()
    End Sub

    Protected Overrides Sub OnActivated(ByVal e As System.EventArgs)
        g_framework.handle_windows(Me.Text)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents pnl_main As DBA.Library.DBA_Panel
    Friend WithEvents lbl_info As DBA.Library.DBA_Label
    Friend WithEvents btn_close As DBA.Library.DBA_Button
    Friend WithEvents lbl_flow As DBA.Library.DBA_Label
    Friend WithEvents lbl_float As DBA.Library.DBA_Label
    Friend WithEvents lbl_safety As DBA.Library.DBA_Label
    Friend WithEvents lbl_wcp As DBA.Library.DBA_Label
    Friend WithEvents btn_print As DBA.Library.DBA_Button
    Friend WithEvents btn_us As DBA.Library.DBA_Button
    Friend WithEvents btn_dp As DBA.Library.DBA_Button
    Friend WithEvents btn_dv As DBA.Library.DBA_Button
    Friend WithEvents btn_wv As DBA.Library.DBA_Button
    Friend WithEvents btn_op As DBA.Library.DBA_Button
    Friend WithEvents btn_rp As DBA.Library.DBA_Button
    Friend WithEvents btn_rf As DBA.Library.DBA_Button
    Friend WithEvents btn_rr As DBA.Library.DBA_Button
    Friend WithEvents btn_rd As DBA.Library.DBA_Button
    Friend WithEvents btn_rh As DBA.Library.DBA_Button
    Friend WithEvents btn_sr As DBA.Library.DBA_Button
    Friend WithEvents btn_ep As DBA.Library.DBA_Button
    Friend WithEvents lbl_us_1 As DBA.Library.DBA_Label
    Friend WithEvents lbl_us_4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_us_3 As DBA.Library.DBA_Label
    Friend WithEvents lbl_us_2 As DBA.Library.DBA_Label
    Friend WithEvents lbl_dv_4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_dv_3 As DBA.Library.DBA_Label
    Friend WithEvents lbl_dv_2 As DBA.Library.DBA_Label
    Friend WithEvents lbl_dv_1 As DBA.Library.DBA_Label
    Friend WithEvents lbl_dp_4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_dp_3 As DBA.Library.DBA_Label
    Friend WithEvents lbl_dp_2 As DBA.Library.DBA_Label
    Friend WithEvents lbl_dp_1 As DBA.Library.DBA_Label
    Friend WithEvents lbl_rp_4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_rp_3 As DBA.Library.DBA_Label
    Friend WithEvents lbl_rp_2 As DBA.Library.DBA_Label
    Friend WithEvents lbl_rp_1 As DBA.Library.DBA_Label
    Friend WithEvents lbl_op_4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_op_3 As DBA.Library.DBA_Label
    Friend WithEvents lbl_op_2 As DBA.Library.DBA_Label
    Friend WithEvents lbl_op_1 As DBA.Library.DBA_Label
    Friend WithEvents lbl_wv_4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_wv_3 As DBA.Library.DBA_Label
    Friend WithEvents lbl_wv_2 As DBA.Library.DBA_Label
    Friend WithEvents lbl_wv_1 As DBA.Library.DBA_Label
    Friend WithEvents lbl_rf_4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_rf_3 As DBA.Library.DBA_Label
    Friend WithEvents lbl_rf_2 As DBA.Library.DBA_Label
    Friend WithEvents lbl_rf_1 As DBA.Library.DBA_Label
    Friend WithEvents lbl_rr_4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_rr_3 As DBA.Library.DBA_Label
    Friend WithEvents lbl_rr_2 As DBA.Library.DBA_Label
    Friend WithEvents lbl_rr_1 As DBA.Library.DBA_Label
    Friend WithEvents lbl_bh_4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_bh_3 As DBA.Library.DBA_Label
    Friend WithEvents lbl_bh_2 As DBA.Library.DBA_Label
    Friend WithEvents lbl_bh_1 As DBA.Library.DBA_Label
    Friend WithEvents lbl_rh_4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_rh_3 As DBA.Library.DBA_Label
    Friend WithEvents lbl_rh_2 As DBA.Library.DBA_Label
    Friend WithEvents lbl_rh_1 As DBA.Library.DBA_Label
    Friend WithEvents lbl_rd_4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_rd_3 As DBA.Library.DBA_Label
    Friend WithEvents lbl_rd_2 As DBA.Library.DBA_Label
    Friend WithEvents lbl_rd_1 As DBA.Library.DBA_Label
    Friend WithEvents lbl_sr_4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_sr_3 As DBA.Library.DBA_Label
    Friend WithEvents lbl_sr_2 As DBA.Library.DBA_Label
    Friend WithEvents lbl_sr_1 As DBA.Library.DBA_Label
    Friend WithEvents lbl_wc_4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_wc_3 As DBA.Library.DBA_Label
    Friend WithEvents lbl_wc_2 As DBA.Library.DBA_Label
    Friend WithEvents lbl_wc_1 As DBA.Library.DBA_Label
    Friend WithEvents btn_off As DBA.Library.DBA_Button
    Friend WithEvents lbl_ep_4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_ep_3 As DBA.Library.DBA_Label
    Friend WithEvents lbl_ep_2 As DBA.Library.DBA_Label
    Friend WithEvents lbl_ep_1 As DBA.Library.DBA_Label
    Friend WithEvents lbl_de_4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_de_3 As DBA.Library.DBA_Label
    Friend WithEvents lbl_de_2 As DBA.Library.DBA_Label
    Friend WithEvents lbl_de_1 As DBA.Library.DBA_Label
    Friend WithEvents lbl_lb_4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_lb_3 As DBA.Library.DBA_Label
    Friend WithEvents lbl_lb_2 As DBA.Library.DBA_Label
    Friend WithEvents lbl_lb_1 As DBA.Library.DBA_Label
    Friend WithEvents lbl_ar_4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_ar_3 As DBA.Library.DBA_Label
    Friend WithEvents lbl_ar_2 As DBA.Library.DBA_Label
    Friend WithEvents lbl_ar_1 As DBA.Library.DBA_Label
    Friend WithEvents btn_de_pmp As DBA.Library.DBA_Button
    Friend WithEvents btn_lb As DBA.Library.DBA_Button
    Friend WithEvents btn_ar As DBA.Library.DBA_Button
    Friend WithEvents btn_bh As DBA.Library.DBA_Button
    Friend WithEvents lbl_sy_4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_sy_3 As DBA.Library.DBA_Label
    Friend WithEvents lbl_sy_2 As DBA.Library.DBA_Label
    Friend WithEvents lbl_sy_1 As DBA.Library.DBA_Label
    Friend WithEvents lbl_ft_4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_ft_3 As DBA.Library.DBA_Label
    Friend WithEvents lbl_ft_2 As DBA.Library.DBA_Label
    Friend WithEvents lbl_ft_1 As DBA.Library.DBA_Label
    Friend WithEvents lbl_fw_4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_fw_3 As DBA.Library.DBA_Label
    Friend WithEvents lbl_fw_2 As DBA.Library.DBA_Label
    Friend WithEvents lbl_fw_1 As DBA.Library.DBA_Label
    Friend WithEvents lbl_ba_1 As DBA.Library.DBA_Label
    Friend WithEvents lbl_by_2 As DBA.Library.DBA_Label
    Friend WithEvents lbl_by_3 As DBA.Library.DBA_Label
    Friend WithEvents lbl_by_4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_ba_2 As DBA.Library.DBA_Label
    Friend WithEvents lbl_ba_3 As DBA.Library.DBA_Label
    Friend WithEvents lbl_ba_4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_ultrasonics As DBA.Library.DBA_Label
    Friend WithEvents lbl_ui_1 As DBA.Library.DBA_Label
    Friend WithEvents lbl_ui_2 As DBA.Library.DBA_Label
    Friend WithEvents lbl_ui_4 As DBA.Library.DBA_Label
    Friend WithEvents lbl_ui_3 As DBA.Library.DBA_Label
    Friend WithEvents lbl_by_1 As DBA.Library.DBA_Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(services))
        Me.pnl_main = New DBA.Library.DBA_Panel
        Me.lbl_ui_4 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_ui_3 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_ui_2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_ui_1 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_ultrasonics = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_ba_4 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_ba_3 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_ba_2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_by_4 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_by_3 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_by_2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_ba_1 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_by_1 = New DBA.Library.DBA_Label(Me.components)
        Me.btn_off = New DBA.Library.DBA_Button(Me.components)
        Me.lbl_wc_4 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_wc_3 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_wc_2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_wc_1 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_sy_4 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_sy_3 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_sy_2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_sy_1 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_ft_4 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_ft_3 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_ft_2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_ft_1 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_fw_4 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_fw_3 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_fw_2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_fw_1 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_ep_4 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_ep_3 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_ep_2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_ep_1 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_de_4 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_de_3 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_de_2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_de_1 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_sr_4 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_sr_3 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_sr_2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_sr_1 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_bh_4 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_bh_3 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_bh_2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_bh_1 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_rh_4 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_rh_3 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_rh_2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_rh_1 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_lb_4 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_lb_3 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_lb_2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_lb_1 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_ar_4 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_ar_3 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_ar_2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_ar_1 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_rd_4 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_rd_3 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_rd_2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_rd_1 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_rr_4 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_rr_3 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_rr_2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_rr_1 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_rf_4 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_rf_3 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_rf_2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_rf_1 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_rp_4 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_rp_3 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_rp_2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_rp_1 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_op_4 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_op_3 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_op_2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_op_1 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_wv_4 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_wv_3 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_wv_2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_wv_1 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_dv_4 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_dv_3 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_dv_2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_dv_1 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_dp_4 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_dp_3 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_dp_2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_dp_1 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_us_4 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_us_3 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_us_2 = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_us_1 = New DBA.Library.DBA_Label(Me.components)
        Me.btn_ep = New DBA.Library.DBA_Button(Me.components)
        Me.btn_de_pmp = New DBA.Library.DBA_Button(Me.components)
        Me.btn_sr = New DBA.Library.DBA_Button(Me.components)
        Me.btn_bh = New DBA.Library.DBA_Button(Me.components)
        Me.btn_rh = New DBA.Library.DBA_Button(Me.components)
        Me.btn_lb = New DBA.Library.DBA_Button(Me.components)
        Me.btn_ar = New DBA.Library.DBA_Button(Me.components)
        Me.btn_rd = New DBA.Library.DBA_Button(Me.components)
        Me.btn_rr = New DBA.Library.DBA_Button(Me.components)
        Me.btn_rf = New DBA.Library.DBA_Button(Me.components)
        Me.btn_rp = New DBA.Library.DBA_Button(Me.components)
        Me.btn_op = New DBA.Library.DBA_Button(Me.components)
        Me.btn_wv = New DBA.Library.DBA_Button(Me.components)
        Me.btn_dv = New DBA.Library.DBA_Button(Me.components)
        Me.btn_dp = New DBA.Library.DBA_Button(Me.components)
        Me.btn_print = New DBA.Library.DBA_Button(Me.components)
        Me.lbl_wcp = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_safety = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_float = New DBA.Library.DBA_Label(Me.components)
        Me.lbl_flow = New DBA.Library.DBA_Label(Me.components)
        Me.btn_us = New DBA.Library.DBA_Button(Me.components)
        Me.lbl_info = New DBA.Library.DBA_Label(Me.components)
        Me.btn_close = New DBA.Library.DBA_Button(Me.components)
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_main
        '
        Me.pnl_main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_main.Controls.Add(Me.lbl_ui_4)
        Me.pnl_main.Controls.Add(Me.lbl_ui_3)
        Me.pnl_main.Controls.Add(Me.lbl_ui_2)
        Me.pnl_main.Controls.Add(Me.lbl_ui_1)
        Me.pnl_main.Controls.Add(Me.lbl_ultrasonics)
        Me.pnl_main.Controls.Add(Me.lbl_ba_4)
        Me.pnl_main.Controls.Add(Me.lbl_ba_3)
        Me.pnl_main.Controls.Add(Me.lbl_ba_2)
        Me.pnl_main.Controls.Add(Me.lbl_by_4)
        Me.pnl_main.Controls.Add(Me.lbl_by_3)
        Me.pnl_main.Controls.Add(Me.lbl_by_2)
        Me.pnl_main.Controls.Add(Me.lbl_ba_1)
        Me.pnl_main.Controls.Add(Me.lbl_by_1)
        Me.pnl_main.Controls.Add(Me.btn_off)
        Me.pnl_main.Controls.Add(Me.lbl_wc_4)
        Me.pnl_main.Controls.Add(Me.lbl_wc_3)
        Me.pnl_main.Controls.Add(Me.lbl_wc_2)
        Me.pnl_main.Controls.Add(Me.lbl_wc_1)
        Me.pnl_main.Controls.Add(Me.lbl_sy_4)
        Me.pnl_main.Controls.Add(Me.lbl_sy_3)
        Me.pnl_main.Controls.Add(Me.lbl_sy_2)
        Me.pnl_main.Controls.Add(Me.lbl_sy_1)
        Me.pnl_main.Controls.Add(Me.lbl_ft_4)
        Me.pnl_main.Controls.Add(Me.lbl_ft_3)
        Me.pnl_main.Controls.Add(Me.lbl_ft_2)
        Me.pnl_main.Controls.Add(Me.lbl_ft_1)
        Me.pnl_main.Controls.Add(Me.lbl_fw_4)
        Me.pnl_main.Controls.Add(Me.lbl_fw_3)
        Me.pnl_main.Controls.Add(Me.lbl_fw_2)
        Me.pnl_main.Controls.Add(Me.lbl_fw_1)
        Me.pnl_main.Controls.Add(Me.lbl_ep_4)
        Me.pnl_main.Controls.Add(Me.lbl_ep_3)
        Me.pnl_main.Controls.Add(Me.lbl_ep_2)
        Me.pnl_main.Controls.Add(Me.lbl_ep_1)
        Me.pnl_main.Controls.Add(Me.lbl_de_4)
        Me.pnl_main.Controls.Add(Me.lbl_de_3)
        Me.pnl_main.Controls.Add(Me.lbl_de_2)
        Me.pnl_main.Controls.Add(Me.lbl_de_1)
        Me.pnl_main.Controls.Add(Me.lbl_sr_4)
        Me.pnl_main.Controls.Add(Me.lbl_sr_3)
        Me.pnl_main.Controls.Add(Me.lbl_sr_2)
        Me.pnl_main.Controls.Add(Me.lbl_sr_1)
        Me.pnl_main.Controls.Add(Me.lbl_bh_4)
        Me.pnl_main.Controls.Add(Me.lbl_bh_3)
        Me.pnl_main.Controls.Add(Me.lbl_bh_2)
        Me.pnl_main.Controls.Add(Me.lbl_bh_1)
        Me.pnl_main.Controls.Add(Me.lbl_rh_4)
        Me.pnl_main.Controls.Add(Me.lbl_rh_3)
        Me.pnl_main.Controls.Add(Me.lbl_rh_2)
        Me.pnl_main.Controls.Add(Me.lbl_rh_1)
        Me.pnl_main.Controls.Add(Me.lbl_lb_4)
        Me.pnl_main.Controls.Add(Me.lbl_lb_3)
        Me.pnl_main.Controls.Add(Me.lbl_lb_2)
        Me.pnl_main.Controls.Add(Me.lbl_lb_1)
        Me.pnl_main.Controls.Add(Me.lbl_ar_4)
        Me.pnl_main.Controls.Add(Me.lbl_ar_3)
        Me.pnl_main.Controls.Add(Me.lbl_ar_2)
        Me.pnl_main.Controls.Add(Me.lbl_ar_1)
        Me.pnl_main.Controls.Add(Me.lbl_rd_4)
        Me.pnl_main.Controls.Add(Me.lbl_rd_3)
        Me.pnl_main.Controls.Add(Me.lbl_rd_2)
        Me.pnl_main.Controls.Add(Me.lbl_rd_1)
        Me.pnl_main.Controls.Add(Me.lbl_rr_4)
        Me.pnl_main.Controls.Add(Me.lbl_rr_3)
        Me.pnl_main.Controls.Add(Me.lbl_rr_2)
        Me.pnl_main.Controls.Add(Me.lbl_rr_1)
        Me.pnl_main.Controls.Add(Me.lbl_rf_4)
        Me.pnl_main.Controls.Add(Me.lbl_rf_3)
        Me.pnl_main.Controls.Add(Me.lbl_rf_2)
        Me.pnl_main.Controls.Add(Me.lbl_rf_1)
        Me.pnl_main.Controls.Add(Me.lbl_rp_4)
        Me.pnl_main.Controls.Add(Me.lbl_rp_3)
        Me.pnl_main.Controls.Add(Me.lbl_rp_2)
        Me.pnl_main.Controls.Add(Me.lbl_rp_1)
        Me.pnl_main.Controls.Add(Me.lbl_op_4)
        Me.pnl_main.Controls.Add(Me.lbl_op_3)
        Me.pnl_main.Controls.Add(Me.lbl_op_2)
        Me.pnl_main.Controls.Add(Me.lbl_op_1)
        Me.pnl_main.Controls.Add(Me.lbl_wv_4)
        Me.pnl_main.Controls.Add(Me.lbl_wv_3)
        Me.pnl_main.Controls.Add(Me.lbl_wv_2)
        Me.pnl_main.Controls.Add(Me.lbl_wv_1)
        Me.pnl_main.Controls.Add(Me.lbl_dv_4)
        Me.pnl_main.Controls.Add(Me.lbl_dv_3)
        Me.pnl_main.Controls.Add(Me.lbl_dv_2)
        Me.pnl_main.Controls.Add(Me.lbl_dv_1)
        Me.pnl_main.Controls.Add(Me.lbl_dp_4)
        Me.pnl_main.Controls.Add(Me.lbl_dp_3)
        Me.pnl_main.Controls.Add(Me.lbl_dp_2)
        Me.pnl_main.Controls.Add(Me.lbl_dp_1)
        Me.pnl_main.Controls.Add(Me.lbl_us_4)
        Me.pnl_main.Controls.Add(Me.lbl_us_3)
        Me.pnl_main.Controls.Add(Me.lbl_us_2)
        Me.pnl_main.Controls.Add(Me.lbl_us_1)
        Me.pnl_main.Controls.Add(Me.btn_ep)
        Me.pnl_main.Controls.Add(Me.btn_de_pmp)
        Me.pnl_main.Controls.Add(Me.btn_sr)
        Me.pnl_main.Controls.Add(Me.btn_bh)
        Me.pnl_main.Controls.Add(Me.btn_rh)
        Me.pnl_main.Controls.Add(Me.btn_lb)
        Me.pnl_main.Controls.Add(Me.btn_ar)
        Me.pnl_main.Controls.Add(Me.btn_rd)
        Me.pnl_main.Controls.Add(Me.btn_rr)
        Me.pnl_main.Controls.Add(Me.btn_rf)
        Me.pnl_main.Controls.Add(Me.btn_rp)
        Me.pnl_main.Controls.Add(Me.btn_op)
        Me.pnl_main.Controls.Add(Me.btn_wv)
        Me.pnl_main.Controls.Add(Me.btn_dv)
        Me.pnl_main.Controls.Add(Me.btn_dp)
        Me.pnl_main.Controls.Add(Me.btn_print)
        Me.pnl_main.Controls.Add(Me.lbl_wcp)
        Me.pnl_main.Controls.Add(Me.lbl_safety)
        Me.pnl_main.Controls.Add(Me.lbl_float)
        Me.pnl_main.Controls.Add(Me.lbl_flow)
        Me.pnl_main.Controls.Add(Me.btn_us)
        Me.pnl_main.Controls.Add(Me.lbl_info)
        Me.pnl_main.Controls.Add(Me.btn_close)
        Me.pnl_main.DataSettings.IDField = Nothing
        Me.pnl_main.DataSettings.JoinData = Nothing
        Me.pnl_main.DataSettings.LinkField = Nothing
        Me.pnl_main.DataSettings.TableName = Nothing
        Me.pnl_main.Gradient = False
        Me.pnl_main.Location = New System.Drawing.Point(0, 0)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.RecordID = Nothing
        Me.pnl_main.Saved = False
        Me.pnl_main.Size = New System.Drawing.Size(678, 544)
        Me.pnl_main.TabIndex = 0
        '
        'lbl_ui_4
        '
        Me.lbl_ui_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ui_4.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_ui_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ui_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ui_4.ForeColor = System.Drawing.Color.Black
        Me.lbl_ui_4.Location = New System.Drawing.Point(452, 178)
        Me.lbl_ui_4.Name = "lbl_ui_4"
        Me.lbl_ui_4.Size = New System.Drawing.Size(20, 20)
        Me.lbl_ui_4.TabIndex = 178
        Me.lbl_ui_4.UseMnemonic = False
        Me.lbl_ui_4.Visible = False
        '
        'lbl_ui_3
        '
        Me.lbl_ui_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ui_3.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_ui_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ui_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ui_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_ui_3.Location = New System.Drawing.Point(425, 178)
        Me.lbl_ui_3.Name = "lbl_ui_3"
        Me.lbl_ui_3.Size = New System.Drawing.Size(20, 20)
        Me.lbl_ui_3.TabIndex = 177
        Me.lbl_ui_3.UseMnemonic = False
        Me.lbl_ui_3.Visible = False
        '
        'lbl_ui_2
        '
        Me.lbl_ui_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ui_2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_ui_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ui_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ui_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_ui_2.Location = New System.Drawing.Point(398, 178)
        Me.lbl_ui_2.Name = "lbl_ui_2"
        Me.lbl_ui_2.Size = New System.Drawing.Size(20, 20)
        Me.lbl_ui_2.TabIndex = 176
        Me.lbl_ui_2.UseMnemonic = False
        Me.lbl_ui_2.Visible = False
        '
        'lbl_ui_1
        '
        Me.lbl_ui_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ui_1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_ui_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ui_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ui_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_ui_1.Location = New System.Drawing.Point(371, 178)
        Me.lbl_ui_1.Name = "lbl_ui_1"
        Me.lbl_ui_1.Size = New System.Drawing.Size(20, 20)
        Me.lbl_ui_1.TabIndex = 175
        Me.lbl_ui_1.UseMnemonic = False
        Me.lbl_ui_1.Visible = False
        '
        'lbl_ultrasonics
        '
        Me.lbl_ultrasonics.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ultrasonics.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_ultrasonics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ultrasonics.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ultrasonics.ForeColor = System.Drawing.Color.Black
        Me.lbl_ultrasonics.Location = New System.Drawing.Point(489, 177)
        Me.lbl_ultrasonics.Name = "lbl_ultrasonics"
        Me.lbl_ultrasonics.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_ultrasonics.Size = New System.Drawing.Size(164, 22)
        Me.lbl_ultrasonics.TabIndex = 68
        Me.lbl_ultrasonics.Text = "Ultrasonics"
        Me.lbl_ultrasonics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_ultrasonics.UseMnemonic = False
        '
        'lbl_ba_4
        '
        Me.lbl_ba_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ba_4.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_ba_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ba_4.ForeColor = System.Drawing.Color.Black
        Me.lbl_ba_4.Location = New System.Drawing.Point(456, 58)
        Me.lbl_ba_4.Name = "lbl_ba_4"
        Me.lbl_ba_4.Size = New System.Drawing.Size(16, 15)
        Me.lbl_ba_4.TabIndex = 186
        Me.lbl_ba_4.Text = "4"
        Me.lbl_ba_4.UseMnemonic = False
        Me.lbl_ba_4.Visible = False
        '
        'lbl_ba_3
        '
        Me.lbl_ba_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ba_3.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_ba_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ba_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_ba_3.Location = New System.Drawing.Point(429, 58)
        Me.lbl_ba_3.Name = "lbl_ba_3"
        Me.lbl_ba_3.Size = New System.Drawing.Size(16, 15)
        Me.lbl_ba_3.TabIndex = 185
        Me.lbl_ba_3.Text = "3"
        Me.lbl_ba_3.UseMnemonic = False
        Me.lbl_ba_3.Visible = False
        '
        'lbl_ba_2
        '
        Me.lbl_ba_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ba_2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_ba_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ba_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_ba_2.Location = New System.Drawing.Point(403, 58)
        Me.lbl_ba_2.Name = "lbl_ba_2"
        Me.lbl_ba_2.Size = New System.Drawing.Size(16, 15)
        Me.lbl_ba_2.TabIndex = 184
        Me.lbl_ba_2.Text = "2"
        Me.lbl_ba_2.UseMnemonic = False
        Me.lbl_ba_2.Visible = False
        '
        'lbl_by_4
        '
        Me.lbl_by_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_by_4.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_by_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_by_4.ForeColor = System.Drawing.Color.Black
        Me.lbl_by_4.Location = New System.Drawing.Point(292, 58)
        Me.lbl_by_4.Name = "lbl_by_4"
        Me.lbl_by_4.Size = New System.Drawing.Size(16, 15)
        Me.lbl_by_4.TabIndex = 183
        Me.lbl_by_4.Text = "4"
        Me.lbl_by_4.UseMnemonic = False
        Me.lbl_by_4.Visible = False
        '
        'lbl_by_3
        '
        Me.lbl_by_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_by_3.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_by_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_by_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_by_3.Location = New System.Drawing.Point(265, 58)
        Me.lbl_by_3.Name = "lbl_by_3"
        Me.lbl_by_3.Size = New System.Drawing.Size(16, 15)
        Me.lbl_by_3.TabIndex = 182
        Me.lbl_by_3.Text = "3"
        Me.lbl_by_3.UseMnemonic = False
        Me.lbl_by_3.Visible = False
        '
        'lbl_by_2
        '
        Me.lbl_by_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_by_2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_by_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_by_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_by_2.Location = New System.Drawing.Point(239, 58)
        Me.lbl_by_2.Name = "lbl_by_2"
        Me.lbl_by_2.Size = New System.Drawing.Size(16, 15)
        Me.lbl_by_2.TabIndex = 181
        Me.lbl_by_2.Text = "2"
        Me.lbl_by_2.UseMnemonic = False
        Me.lbl_by_2.Visible = False
        '
        'lbl_ba_1
        '
        Me.lbl_ba_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ba_1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_ba_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ba_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_ba_1.Location = New System.Drawing.Point(376, 58)
        Me.lbl_ba_1.Name = "lbl_ba_1"
        Me.lbl_ba_1.Size = New System.Drawing.Size(16, 15)
        Me.lbl_ba_1.TabIndex = 180
        Me.lbl_ba_1.Text = "1"
        Me.lbl_ba_1.UseMnemonic = False
        Me.lbl_ba_1.Visible = False
        '
        'lbl_by_1
        '
        Me.lbl_by_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_by_1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_by_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_by_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_by_1.Location = New System.Drawing.Point(212, 58)
        Me.lbl_by_1.Name = "lbl_by_1"
        Me.lbl_by_1.Size = New System.Drawing.Size(16, 15)
        Me.lbl_by_1.TabIndex = 179
        Me.lbl_by_1.Text = "1"
        Me.lbl_by_1.UseMnemonic = False
        Me.lbl_by_1.Visible = False
        '
        'btn_off
        '
        Me.btn_off.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_off.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_off.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_off.DisplayText = ""
        Me.btn_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_off.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_off.ForeColor = System.Drawing.Color.Black
        Me.btn_off.Image = CType(resources.GetObject("btn_off.Image"), System.Drawing.Image)
        Me.btn_off.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_off.Location = New System.Drawing.Point(27, 9)
        Me.btn_off.Name = "btn_off"
        Me.btn_off.Size = New System.Drawing.Size(130, 43)
        Me.btn_off.TabIndex = 16
        Me.btn_off.TabStop = False
        Me.btn_off.Text = "Reset All"
        Me.btn_off.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_off.UseVisualStyleBackColor = False
        '
        'lbl_wc_4
        '
        Me.lbl_wc_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_wc_4.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_wc_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_wc_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_wc_4.ForeColor = System.Drawing.Color.Black
        Me.lbl_wc_4.Location = New System.Drawing.Point(452, 152)
        Me.lbl_wc_4.Name = "lbl_wc_4"
        Me.lbl_wc_4.Size = New System.Drawing.Size(20, 20)
        Me.lbl_wc_4.TabIndex = 174
        Me.lbl_wc_4.UseMnemonic = False
        Me.lbl_wc_4.Visible = False
        '
        'lbl_wc_3
        '
        Me.lbl_wc_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_wc_3.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_wc_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_wc_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_wc_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_wc_3.Location = New System.Drawing.Point(425, 152)
        Me.lbl_wc_3.Name = "lbl_wc_3"
        Me.lbl_wc_3.Size = New System.Drawing.Size(20, 20)
        Me.lbl_wc_3.TabIndex = 173
        Me.lbl_wc_3.UseMnemonic = False
        Me.lbl_wc_3.Visible = False
        '
        'lbl_wc_2
        '
        Me.lbl_wc_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_wc_2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_wc_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_wc_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_wc_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_wc_2.Location = New System.Drawing.Point(398, 152)
        Me.lbl_wc_2.Name = "lbl_wc_2"
        Me.lbl_wc_2.Size = New System.Drawing.Size(20, 20)
        Me.lbl_wc_2.TabIndex = 172
        Me.lbl_wc_2.UseMnemonic = False
        Me.lbl_wc_2.Visible = False
        '
        'lbl_wc_1
        '
        Me.lbl_wc_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_wc_1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_wc_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_wc_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_wc_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_wc_1.Location = New System.Drawing.Point(371, 152)
        Me.lbl_wc_1.Name = "lbl_wc_1"
        Me.lbl_wc_1.Size = New System.Drawing.Size(20, 20)
        Me.lbl_wc_1.TabIndex = 171
        Me.lbl_wc_1.UseMnemonic = False
        Me.lbl_wc_1.Visible = False
        '
        'lbl_sy_4
        '
        Me.lbl_sy_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_sy_4.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_sy_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_sy_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sy_4.ForeColor = System.Drawing.Color.Black
        Me.lbl_sy_4.Location = New System.Drawing.Point(452, 126)
        Me.lbl_sy_4.Name = "lbl_sy_4"
        Me.lbl_sy_4.Size = New System.Drawing.Size(20, 20)
        Me.lbl_sy_4.TabIndex = 170
        Me.lbl_sy_4.UseMnemonic = False
        Me.lbl_sy_4.Visible = False
        '
        'lbl_sy_3
        '
        Me.lbl_sy_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_sy_3.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_sy_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_sy_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sy_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_sy_3.Location = New System.Drawing.Point(425, 126)
        Me.lbl_sy_3.Name = "lbl_sy_3"
        Me.lbl_sy_3.Size = New System.Drawing.Size(20, 20)
        Me.lbl_sy_3.TabIndex = 169
        Me.lbl_sy_3.UseMnemonic = False
        Me.lbl_sy_3.Visible = False
        '
        'lbl_sy_2
        '
        Me.lbl_sy_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_sy_2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_sy_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_sy_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sy_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_sy_2.Location = New System.Drawing.Point(398, 126)
        Me.lbl_sy_2.Name = "lbl_sy_2"
        Me.lbl_sy_2.Size = New System.Drawing.Size(20, 20)
        Me.lbl_sy_2.TabIndex = 168
        Me.lbl_sy_2.UseMnemonic = False
        Me.lbl_sy_2.Visible = False
        '
        'lbl_sy_1
        '
        Me.lbl_sy_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_sy_1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_sy_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_sy_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sy_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_sy_1.Location = New System.Drawing.Point(371, 126)
        Me.lbl_sy_1.Name = "lbl_sy_1"
        Me.lbl_sy_1.Size = New System.Drawing.Size(20, 20)
        Me.lbl_sy_1.TabIndex = 167
        Me.lbl_sy_1.UseMnemonic = False
        Me.lbl_sy_1.Visible = False
        '
        'lbl_ft_4
        '
        Me.lbl_ft_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ft_4.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_ft_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ft_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ft_4.ForeColor = System.Drawing.Color.Black
        Me.lbl_ft_4.Location = New System.Drawing.Point(452, 100)
        Me.lbl_ft_4.Name = "lbl_ft_4"
        Me.lbl_ft_4.Size = New System.Drawing.Size(20, 20)
        Me.lbl_ft_4.TabIndex = 166
        Me.lbl_ft_4.UseMnemonic = False
        Me.lbl_ft_4.Visible = False
        '
        'lbl_ft_3
        '
        Me.lbl_ft_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ft_3.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_ft_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ft_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ft_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_ft_3.Location = New System.Drawing.Point(425, 100)
        Me.lbl_ft_3.Name = "lbl_ft_3"
        Me.lbl_ft_3.Size = New System.Drawing.Size(20, 20)
        Me.lbl_ft_3.TabIndex = 165
        Me.lbl_ft_3.UseMnemonic = False
        Me.lbl_ft_3.Visible = False
        '
        'lbl_ft_2
        '
        Me.lbl_ft_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ft_2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_ft_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ft_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ft_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_ft_2.Location = New System.Drawing.Point(398, 100)
        Me.lbl_ft_2.Name = "lbl_ft_2"
        Me.lbl_ft_2.Size = New System.Drawing.Size(20, 20)
        Me.lbl_ft_2.TabIndex = 164
        Me.lbl_ft_2.UseMnemonic = False
        Me.lbl_ft_2.Visible = False
        '
        'lbl_ft_1
        '
        Me.lbl_ft_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ft_1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_ft_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ft_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ft_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_ft_1.Location = New System.Drawing.Point(371, 100)
        Me.lbl_ft_1.Name = "lbl_ft_1"
        Me.lbl_ft_1.Size = New System.Drawing.Size(20, 20)
        Me.lbl_ft_1.TabIndex = 163
        Me.lbl_ft_1.UseMnemonic = False
        Me.lbl_ft_1.Visible = False
        '
        'lbl_fw_4
        '
        Me.lbl_fw_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_fw_4.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_fw_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_fw_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fw_4.ForeColor = System.Drawing.Color.Black
        Me.lbl_fw_4.Location = New System.Drawing.Point(452, 74)
        Me.lbl_fw_4.Name = "lbl_fw_4"
        Me.lbl_fw_4.Size = New System.Drawing.Size(20, 20)
        Me.lbl_fw_4.TabIndex = 162
        Me.lbl_fw_4.UseMnemonic = False
        Me.lbl_fw_4.Visible = False
        '
        'lbl_fw_3
        '
        Me.lbl_fw_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_fw_3.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_fw_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_fw_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fw_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_fw_3.Location = New System.Drawing.Point(425, 74)
        Me.lbl_fw_3.Name = "lbl_fw_3"
        Me.lbl_fw_3.Size = New System.Drawing.Size(20, 20)
        Me.lbl_fw_3.TabIndex = 161
        Me.lbl_fw_3.UseMnemonic = False
        Me.lbl_fw_3.Visible = False
        '
        'lbl_fw_2
        '
        Me.lbl_fw_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_fw_2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_fw_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_fw_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fw_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_fw_2.Location = New System.Drawing.Point(398, 74)
        Me.lbl_fw_2.Name = "lbl_fw_2"
        Me.lbl_fw_2.Size = New System.Drawing.Size(20, 20)
        Me.lbl_fw_2.TabIndex = 160
        Me.lbl_fw_2.UseMnemonic = False
        Me.lbl_fw_2.Visible = False
        '
        'lbl_fw_1
        '
        Me.lbl_fw_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_fw_1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_fw_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_fw_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fw_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_fw_1.Location = New System.Drawing.Point(371, 74)
        Me.lbl_fw_1.Name = "lbl_fw_1"
        Me.lbl_fw_1.Size = New System.Drawing.Size(20, 20)
        Me.lbl_fw_1.TabIndex = 159
        Me.lbl_fw_1.UseMnemonic = False
        Me.lbl_fw_1.Visible = False
        '
        'lbl_ep_4
        '
        Me.lbl_ep_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ep_4.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_ep_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ep_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ep_4.ForeColor = System.Drawing.Color.Black
        Me.lbl_ep_4.Location = New System.Drawing.Point(288, 476)
        Me.lbl_ep_4.Name = "lbl_ep_4"
        Me.lbl_ep_4.Size = New System.Drawing.Size(20, 20)
        Me.lbl_ep_4.TabIndex = 158
        Me.lbl_ep_4.UseMnemonic = False
        Me.lbl_ep_4.Visible = False
        '
        'lbl_ep_3
        '
        Me.lbl_ep_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ep_3.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_ep_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ep_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ep_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_ep_3.Location = New System.Drawing.Point(261, 476)
        Me.lbl_ep_3.Name = "lbl_ep_3"
        Me.lbl_ep_3.Size = New System.Drawing.Size(20, 20)
        Me.lbl_ep_3.TabIndex = 157
        Me.lbl_ep_3.UseMnemonic = False
        Me.lbl_ep_3.Visible = False
        '
        'lbl_ep_2
        '
        Me.lbl_ep_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ep_2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_ep_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ep_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ep_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_ep_2.Location = New System.Drawing.Point(234, 476)
        Me.lbl_ep_2.Name = "lbl_ep_2"
        Me.lbl_ep_2.Size = New System.Drawing.Size(20, 20)
        Me.lbl_ep_2.TabIndex = 156
        Me.lbl_ep_2.UseMnemonic = False
        Me.lbl_ep_2.Visible = False
        '
        'lbl_ep_1
        '
        Me.lbl_ep_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ep_1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_ep_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ep_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ep_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_ep_1.Location = New System.Drawing.Point(207, 476)
        Me.lbl_ep_1.Name = "lbl_ep_1"
        Me.lbl_ep_1.Size = New System.Drawing.Size(20, 20)
        Me.lbl_ep_1.TabIndex = 155
        Me.lbl_ep_1.UseMnemonic = False
        Me.lbl_ep_1.Visible = False
        '
        'lbl_de_4
        '
        Me.lbl_de_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_de_4.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_de_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_de_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_de_4.ForeColor = System.Drawing.Color.Black
        Me.lbl_de_4.Location = New System.Drawing.Point(288, 449)
        Me.lbl_de_4.Name = "lbl_de_4"
        Me.lbl_de_4.Size = New System.Drawing.Size(20, 20)
        Me.lbl_de_4.TabIndex = 154
        Me.lbl_de_4.UseMnemonic = False
        Me.lbl_de_4.Visible = False
        '
        'lbl_de_3
        '
        Me.lbl_de_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_de_3.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_de_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_de_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_de_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_de_3.Location = New System.Drawing.Point(261, 449)
        Me.lbl_de_3.Name = "lbl_de_3"
        Me.lbl_de_3.Size = New System.Drawing.Size(20, 20)
        Me.lbl_de_3.TabIndex = 153
        Me.lbl_de_3.UseMnemonic = False
        Me.lbl_de_3.Visible = False
        '
        'lbl_de_2
        '
        Me.lbl_de_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_de_2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_de_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_de_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_de_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_de_2.Location = New System.Drawing.Point(234, 449)
        Me.lbl_de_2.Name = "lbl_de_2"
        Me.lbl_de_2.Size = New System.Drawing.Size(20, 20)
        Me.lbl_de_2.TabIndex = 152
        Me.lbl_de_2.UseMnemonic = False
        Me.lbl_de_2.Visible = False
        '
        'lbl_de_1
        '
        Me.lbl_de_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_de_1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_de_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_de_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_de_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_de_1.Location = New System.Drawing.Point(207, 449)
        Me.lbl_de_1.Name = "lbl_de_1"
        Me.lbl_de_1.Size = New System.Drawing.Size(20, 20)
        Me.lbl_de_1.TabIndex = 151
        Me.lbl_de_1.UseMnemonic = False
        Me.lbl_de_1.Visible = False
        '
        'lbl_sr_4
        '
        Me.lbl_sr_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_sr_4.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_sr_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_sr_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sr_4.ForeColor = System.Drawing.Color.Black
        Me.lbl_sr_4.Location = New System.Drawing.Point(288, 422)
        Me.lbl_sr_4.Name = "lbl_sr_4"
        Me.lbl_sr_4.Size = New System.Drawing.Size(20, 20)
        Me.lbl_sr_4.TabIndex = 150
        Me.lbl_sr_4.UseMnemonic = False
        Me.lbl_sr_4.Visible = False
        '
        'lbl_sr_3
        '
        Me.lbl_sr_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_sr_3.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_sr_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_sr_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sr_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_sr_3.Location = New System.Drawing.Point(261, 422)
        Me.lbl_sr_3.Name = "lbl_sr_3"
        Me.lbl_sr_3.Size = New System.Drawing.Size(20, 20)
        Me.lbl_sr_3.TabIndex = 149
        Me.lbl_sr_3.UseMnemonic = False
        Me.lbl_sr_3.Visible = False
        '
        'lbl_sr_2
        '
        Me.lbl_sr_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_sr_2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_sr_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_sr_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sr_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_sr_2.Location = New System.Drawing.Point(234, 422)
        Me.lbl_sr_2.Name = "lbl_sr_2"
        Me.lbl_sr_2.Size = New System.Drawing.Size(20, 20)
        Me.lbl_sr_2.TabIndex = 148
        Me.lbl_sr_2.UseMnemonic = False
        Me.lbl_sr_2.Visible = False
        '
        'lbl_sr_1
        '
        Me.lbl_sr_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_sr_1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_sr_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_sr_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sr_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_sr_1.Location = New System.Drawing.Point(207, 422)
        Me.lbl_sr_1.Name = "lbl_sr_1"
        Me.lbl_sr_1.Size = New System.Drawing.Size(20, 20)
        Me.lbl_sr_1.TabIndex = 147
        Me.lbl_sr_1.UseMnemonic = False
        Me.lbl_sr_1.Visible = False
        '
        'lbl_bh_4
        '
        Me.lbl_bh_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_bh_4.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_bh_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_bh_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bh_4.ForeColor = System.Drawing.Color.Black
        Me.lbl_bh_4.Location = New System.Drawing.Point(288, 395)
        Me.lbl_bh_4.Name = "lbl_bh_4"
        Me.lbl_bh_4.Size = New System.Drawing.Size(20, 20)
        Me.lbl_bh_4.TabIndex = 146
        Me.lbl_bh_4.UseMnemonic = False
        Me.lbl_bh_4.Visible = False
        '
        'lbl_bh_3
        '
        Me.lbl_bh_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_bh_3.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_bh_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_bh_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bh_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_bh_3.Location = New System.Drawing.Point(261, 395)
        Me.lbl_bh_3.Name = "lbl_bh_3"
        Me.lbl_bh_3.Size = New System.Drawing.Size(20, 20)
        Me.lbl_bh_3.TabIndex = 145
        Me.lbl_bh_3.UseMnemonic = False
        Me.lbl_bh_3.Visible = False
        '
        'lbl_bh_2
        '
        Me.lbl_bh_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_bh_2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_bh_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_bh_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bh_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_bh_2.Location = New System.Drawing.Point(234, 395)
        Me.lbl_bh_2.Name = "lbl_bh_2"
        Me.lbl_bh_2.Size = New System.Drawing.Size(20, 20)
        Me.lbl_bh_2.TabIndex = 144
        Me.lbl_bh_2.UseMnemonic = False
        Me.lbl_bh_2.Visible = False
        '
        'lbl_bh_1
        '
        Me.lbl_bh_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_bh_1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_bh_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_bh_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bh_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_bh_1.Location = New System.Drawing.Point(207, 395)
        Me.lbl_bh_1.Name = "lbl_bh_1"
        Me.lbl_bh_1.Size = New System.Drawing.Size(20, 20)
        Me.lbl_bh_1.TabIndex = 143
        Me.lbl_bh_1.UseMnemonic = False
        Me.lbl_bh_1.Visible = False
        '
        'lbl_rh_4
        '
        Me.lbl_rh_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_rh_4.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_rh_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_rh_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rh_4.ForeColor = System.Drawing.Color.Black
        Me.lbl_rh_4.Location = New System.Drawing.Point(288, 368)
        Me.lbl_rh_4.Name = "lbl_rh_4"
        Me.lbl_rh_4.Size = New System.Drawing.Size(20, 20)
        Me.lbl_rh_4.TabIndex = 142
        Me.lbl_rh_4.UseMnemonic = False
        Me.lbl_rh_4.Visible = False
        '
        'lbl_rh_3
        '
        Me.lbl_rh_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_rh_3.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_rh_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_rh_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rh_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_rh_3.Location = New System.Drawing.Point(261, 368)
        Me.lbl_rh_3.Name = "lbl_rh_3"
        Me.lbl_rh_3.Size = New System.Drawing.Size(20, 20)
        Me.lbl_rh_3.TabIndex = 141
        Me.lbl_rh_3.UseMnemonic = False
        Me.lbl_rh_3.Visible = False
        '
        'lbl_rh_2
        '
        Me.lbl_rh_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_rh_2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_rh_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_rh_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rh_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_rh_2.Location = New System.Drawing.Point(234, 368)
        Me.lbl_rh_2.Name = "lbl_rh_2"
        Me.lbl_rh_2.Size = New System.Drawing.Size(20, 20)
        Me.lbl_rh_2.TabIndex = 140
        Me.lbl_rh_2.UseMnemonic = False
        Me.lbl_rh_2.Visible = False
        '
        'lbl_rh_1
        '
        Me.lbl_rh_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_rh_1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_rh_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_rh_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rh_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_rh_1.Location = New System.Drawing.Point(207, 368)
        Me.lbl_rh_1.Name = "lbl_rh_1"
        Me.lbl_rh_1.Size = New System.Drawing.Size(20, 20)
        Me.lbl_rh_1.TabIndex = 139
        Me.lbl_rh_1.UseMnemonic = False
        Me.lbl_rh_1.Visible = False
        '
        'lbl_lb_4
        '
        Me.lbl_lb_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_lb_4.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_lb_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_lb_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lb_4.ForeColor = System.Drawing.Color.Black
        Me.lbl_lb_4.Location = New System.Drawing.Point(288, 340)
        Me.lbl_lb_4.Name = "lbl_lb_4"
        Me.lbl_lb_4.Size = New System.Drawing.Size(20, 20)
        Me.lbl_lb_4.TabIndex = 138
        Me.lbl_lb_4.UseMnemonic = False
        Me.lbl_lb_4.Visible = False
        '
        'lbl_lb_3
        '
        Me.lbl_lb_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_lb_3.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_lb_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_lb_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lb_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_lb_3.Location = New System.Drawing.Point(261, 340)
        Me.lbl_lb_3.Name = "lbl_lb_3"
        Me.lbl_lb_3.Size = New System.Drawing.Size(20, 20)
        Me.lbl_lb_3.TabIndex = 137
        Me.lbl_lb_3.UseMnemonic = False
        Me.lbl_lb_3.Visible = False
        '
        'lbl_lb_2
        '
        Me.lbl_lb_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_lb_2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_lb_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_lb_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lb_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_lb_2.Location = New System.Drawing.Point(234, 340)
        Me.lbl_lb_2.Name = "lbl_lb_2"
        Me.lbl_lb_2.Size = New System.Drawing.Size(20, 20)
        Me.lbl_lb_2.TabIndex = 136
        Me.lbl_lb_2.UseMnemonic = False
        Me.lbl_lb_2.Visible = False
        '
        'lbl_lb_1
        '
        Me.lbl_lb_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_lb_1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_lb_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_lb_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lb_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_lb_1.Location = New System.Drawing.Point(207, 340)
        Me.lbl_lb_1.Name = "lbl_lb_1"
        Me.lbl_lb_1.Size = New System.Drawing.Size(20, 20)
        Me.lbl_lb_1.TabIndex = 135
        Me.lbl_lb_1.UseMnemonic = False
        Me.lbl_lb_1.Visible = False
        '
        'lbl_ar_4
        '
        Me.lbl_ar_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ar_4.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_ar_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ar_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ar_4.ForeColor = System.Drawing.Color.Black
        Me.lbl_ar_4.Location = New System.Drawing.Point(288, 313)
        Me.lbl_ar_4.Name = "lbl_ar_4"
        Me.lbl_ar_4.Size = New System.Drawing.Size(20, 20)
        Me.lbl_ar_4.TabIndex = 134
        Me.lbl_ar_4.UseMnemonic = False
        Me.lbl_ar_4.Visible = False
        '
        'lbl_ar_3
        '
        Me.lbl_ar_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ar_3.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_ar_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ar_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ar_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_ar_3.Location = New System.Drawing.Point(261, 313)
        Me.lbl_ar_3.Name = "lbl_ar_3"
        Me.lbl_ar_3.Size = New System.Drawing.Size(20, 20)
        Me.lbl_ar_3.TabIndex = 133
        Me.lbl_ar_3.UseMnemonic = False
        Me.lbl_ar_3.Visible = False
        '
        'lbl_ar_2
        '
        Me.lbl_ar_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ar_2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_ar_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ar_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ar_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_ar_2.Location = New System.Drawing.Point(234, 313)
        Me.lbl_ar_2.Name = "lbl_ar_2"
        Me.lbl_ar_2.Size = New System.Drawing.Size(20, 20)
        Me.lbl_ar_2.TabIndex = 132
        Me.lbl_ar_2.UseMnemonic = False
        Me.lbl_ar_2.Visible = False
        '
        'lbl_ar_1
        '
        Me.lbl_ar_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ar_1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_ar_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ar_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ar_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_ar_1.Location = New System.Drawing.Point(207, 313)
        Me.lbl_ar_1.Name = "lbl_ar_1"
        Me.lbl_ar_1.Size = New System.Drawing.Size(20, 20)
        Me.lbl_ar_1.TabIndex = 131
        Me.lbl_ar_1.UseMnemonic = False
        Me.lbl_ar_1.Visible = False
        '
        'lbl_rd_4
        '
        Me.lbl_rd_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_rd_4.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_rd_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_rd_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rd_4.ForeColor = System.Drawing.Color.Black
        Me.lbl_rd_4.Location = New System.Drawing.Point(288, 286)
        Me.lbl_rd_4.Name = "lbl_rd_4"
        Me.lbl_rd_4.Size = New System.Drawing.Size(20, 20)
        Me.lbl_rd_4.TabIndex = 130
        Me.lbl_rd_4.UseMnemonic = False
        Me.lbl_rd_4.Visible = False
        '
        'lbl_rd_3
        '
        Me.lbl_rd_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_rd_3.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_rd_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_rd_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rd_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_rd_3.Location = New System.Drawing.Point(261, 286)
        Me.lbl_rd_3.Name = "lbl_rd_3"
        Me.lbl_rd_3.Size = New System.Drawing.Size(20, 20)
        Me.lbl_rd_3.TabIndex = 129
        Me.lbl_rd_3.UseMnemonic = False
        Me.lbl_rd_3.Visible = False
        '
        'lbl_rd_2
        '
        Me.lbl_rd_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_rd_2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_rd_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_rd_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rd_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_rd_2.Location = New System.Drawing.Point(234, 286)
        Me.lbl_rd_2.Name = "lbl_rd_2"
        Me.lbl_rd_2.Size = New System.Drawing.Size(20, 20)
        Me.lbl_rd_2.TabIndex = 128
        Me.lbl_rd_2.UseMnemonic = False
        Me.lbl_rd_2.Visible = False
        '
        'lbl_rd_1
        '
        Me.lbl_rd_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_rd_1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_rd_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_rd_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rd_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_rd_1.Location = New System.Drawing.Point(207, 286)
        Me.lbl_rd_1.Name = "lbl_rd_1"
        Me.lbl_rd_1.Size = New System.Drawing.Size(20, 20)
        Me.lbl_rd_1.TabIndex = 127
        Me.lbl_rd_1.UseMnemonic = False
        Me.lbl_rd_1.Visible = False
        '
        'lbl_rr_4
        '
        Me.lbl_rr_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_rr_4.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_rr_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_rr_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rr_4.ForeColor = System.Drawing.Color.Black
        Me.lbl_rr_4.Location = New System.Drawing.Point(288, 259)
        Me.lbl_rr_4.Name = "lbl_rr_4"
        Me.lbl_rr_4.Size = New System.Drawing.Size(20, 20)
        Me.lbl_rr_4.TabIndex = 126
        Me.lbl_rr_4.UseMnemonic = False
        Me.lbl_rr_4.Visible = False
        '
        'lbl_rr_3
        '
        Me.lbl_rr_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_rr_3.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_rr_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_rr_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rr_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_rr_3.Location = New System.Drawing.Point(261, 259)
        Me.lbl_rr_3.Name = "lbl_rr_3"
        Me.lbl_rr_3.Size = New System.Drawing.Size(20, 20)
        Me.lbl_rr_3.TabIndex = 125
        Me.lbl_rr_3.UseMnemonic = False
        Me.lbl_rr_3.Visible = False
        '
        'lbl_rr_2
        '
        Me.lbl_rr_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_rr_2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_rr_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_rr_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rr_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_rr_2.Location = New System.Drawing.Point(234, 259)
        Me.lbl_rr_2.Name = "lbl_rr_2"
        Me.lbl_rr_2.Size = New System.Drawing.Size(20, 20)
        Me.lbl_rr_2.TabIndex = 124
        Me.lbl_rr_2.UseMnemonic = False
        Me.lbl_rr_2.Visible = False
        '
        'lbl_rr_1
        '
        Me.lbl_rr_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_rr_1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_rr_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_rr_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rr_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_rr_1.Location = New System.Drawing.Point(207, 259)
        Me.lbl_rr_1.Name = "lbl_rr_1"
        Me.lbl_rr_1.Size = New System.Drawing.Size(20, 20)
        Me.lbl_rr_1.TabIndex = 123
        Me.lbl_rr_1.UseMnemonic = False
        Me.lbl_rr_1.Visible = False
        '
        'lbl_rf_4
        '
        Me.lbl_rf_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_rf_4.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_rf_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_rf_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rf_4.ForeColor = System.Drawing.Color.Black
        Me.lbl_rf_4.Location = New System.Drawing.Point(288, 232)
        Me.lbl_rf_4.Name = "lbl_rf_4"
        Me.lbl_rf_4.Size = New System.Drawing.Size(20, 20)
        Me.lbl_rf_4.TabIndex = 122
        Me.lbl_rf_4.UseMnemonic = False
        Me.lbl_rf_4.Visible = False
        '
        'lbl_rf_3
        '
        Me.lbl_rf_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_rf_3.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_rf_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_rf_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rf_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_rf_3.Location = New System.Drawing.Point(261, 232)
        Me.lbl_rf_3.Name = "lbl_rf_3"
        Me.lbl_rf_3.Size = New System.Drawing.Size(20, 20)
        Me.lbl_rf_3.TabIndex = 121
        Me.lbl_rf_3.UseMnemonic = False
        Me.lbl_rf_3.Visible = False
        '
        'lbl_rf_2
        '
        Me.lbl_rf_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_rf_2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_rf_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_rf_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rf_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_rf_2.Location = New System.Drawing.Point(234, 232)
        Me.lbl_rf_2.Name = "lbl_rf_2"
        Me.lbl_rf_2.Size = New System.Drawing.Size(20, 20)
        Me.lbl_rf_2.TabIndex = 120
        Me.lbl_rf_2.UseMnemonic = False
        Me.lbl_rf_2.Visible = False
        '
        'lbl_rf_1
        '
        Me.lbl_rf_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_rf_1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_rf_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_rf_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rf_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_rf_1.Location = New System.Drawing.Point(207, 232)
        Me.lbl_rf_1.Name = "lbl_rf_1"
        Me.lbl_rf_1.Size = New System.Drawing.Size(20, 20)
        Me.lbl_rf_1.TabIndex = 119
        Me.lbl_rf_1.UseMnemonic = False
        Me.lbl_rf_1.Visible = False
        '
        'lbl_rp_4
        '
        Me.lbl_rp_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_rp_4.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_rp_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_rp_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rp_4.ForeColor = System.Drawing.Color.Black
        Me.lbl_rp_4.Location = New System.Drawing.Point(288, 205)
        Me.lbl_rp_4.Name = "lbl_rp_4"
        Me.lbl_rp_4.Size = New System.Drawing.Size(20, 20)
        Me.lbl_rp_4.TabIndex = 118
        Me.lbl_rp_4.UseMnemonic = False
        Me.lbl_rp_4.Visible = False
        '
        'lbl_rp_3
        '
        Me.lbl_rp_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_rp_3.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_rp_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_rp_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rp_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_rp_3.Location = New System.Drawing.Point(261, 205)
        Me.lbl_rp_3.Name = "lbl_rp_3"
        Me.lbl_rp_3.Size = New System.Drawing.Size(20, 20)
        Me.lbl_rp_3.TabIndex = 117
        Me.lbl_rp_3.UseMnemonic = False
        Me.lbl_rp_3.Visible = False
        '
        'lbl_rp_2
        '
        Me.lbl_rp_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_rp_2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_rp_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_rp_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rp_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_rp_2.Location = New System.Drawing.Point(234, 205)
        Me.lbl_rp_2.Name = "lbl_rp_2"
        Me.lbl_rp_2.Size = New System.Drawing.Size(20, 20)
        Me.lbl_rp_2.TabIndex = 116
        Me.lbl_rp_2.UseMnemonic = False
        Me.lbl_rp_2.Visible = False
        '
        'lbl_rp_1
        '
        Me.lbl_rp_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_rp_1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_rp_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_rp_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rp_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_rp_1.Location = New System.Drawing.Point(207, 205)
        Me.lbl_rp_1.Name = "lbl_rp_1"
        Me.lbl_rp_1.Size = New System.Drawing.Size(20, 20)
        Me.lbl_rp_1.TabIndex = 115
        Me.lbl_rp_1.UseMnemonic = False
        Me.lbl_rp_1.Visible = False
        '
        'lbl_op_4
        '
        Me.lbl_op_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_op_4.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_op_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_op_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_op_4.ForeColor = System.Drawing.Color.Black
        Me.lbl_op_4.Location = New System.Drawing.Point(288, 178)
        Me.lbl_op_4.Name = "lbl_op_4"
        Me.lbl_op_4.Size = New System.Drawing.Size(20, 20)
        Me.lbl_op_4.TabIndex = 114
        Me.lbl_op_4.UseMnemonic = False
        Me.lbl_op_4.Visible = False
        '
        'lbl_op_3
        '
        Me.lbl_op_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_op_3.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_op_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_op_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_op_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_op_3.Location = New System.Drawing.Point(261, 178)
        Me.lbl_op_3.Name = "lbl_op_3"
        Me.lbl_op_3.Size = New System.Drawing.Size(20, 20)
        Me.lbl_op_3.TabIndex = 113
        Me.lbl_op_3.UseMnemonic = False
        Me.lbl_op_3.Visible = False
        '
        'lbl_op_2
        '
        Me.lbl_op_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_op_2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_op_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_op_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_op_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_op_2.Location = New System.Drawing.Point(234, 178)
        Me.lbl_op_2.Name = "lbl_op_2"
        Me.lbl_op_2.Size = New System.Drawing.Size(20, 20)
        Me.lbl_op_2.TabIndex = 112
        Me.lbl_op_2.UseMnemonic = False
        Me.lbl_op_2.Visible = False
        '
        'lbl_op_1
        '
        Me.lbl_op_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_op_1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_op_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_op_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_op_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_op_1.Location = New System.Drawing.Point(207, 178)
        Me.lbl_op_1.Name = "lbl_op_1"
        Me.lbl_op_1.Size = New System.Drawing.Size(20, 20)
        Me.lbl_op_1.TabIndex = 111
        Me.lbl_op_1.UseMnemonic = False
        Me.lbl_op_1.Visible = False
        '
        'lbl_wv_4
        '
        Me.lbl_wv_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_wv_4.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_wv_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_wv_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_wv_4.ForeColor = System.Drawing.Color.Black
        Me.lbl_wv_4.Location = New System.Drawing.Point(288, 152)
        Me.lbl_wv_4.Name = "lbl_wv_4"
        Me.lbl_wv_4.Size = New System.Drawing.Size(20, 20)
        Me.lbl_wv_4.TabIndex = 110
        Me.lbl_wv_4.UseMnemonic = False
        Me.lbl_wv_4.Visible = False
        '
        'lbl_wv_3
        '
        Me.lbl_wv_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_wv_3.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_wv_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_wv_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_wv_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_wv_3.Location = New System.Drawing.Point(261, 152)
        Me.lbl_wv_3.Name = "lbl_wv_3"
        Me.lbl_wv_3.Size = New System.Drawing.Size(20, 20)
        Me.lbl_wv_3.TabIndex = 109
        Me.lbl_wv_3.UseMnemonic = False
        Me.lbl_wv_3.Visible = False
        '
        'lbl_wv_2
        '
        Me.lbl_wv_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_wv_2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_wv_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_wv_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_wv_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_wv_2.Location = New System.Drawing.Point(234, 152)
        Me.lbl_wv_2.Name = "lbl_wv_2"
        Me.lbl_wv_2.Size = New System.Drawing.Size(20, 20)
        Me.lbl_wv_2.TabIndex = 108
        Me.lbl_wv_2.UseMnemonic = False
        Me.lbl_wv_2.Visible = False
        '
        'lbl_wv_1
        '
        Me.lbl_wv_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_wv_1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_wv_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_wv_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_wv_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_wv_1.Location = New System.Drawing.Point(207, 152)
        Me.lbl_wv_1.Name = "lbl_wv_1"
        Me.lbl_wv_1.Size = New System.Drawing.Size(20, 20)
        Me.lbl_wv_1.TabIndex = 107
        Me.lbl_wv_1.UseMnemonic = False
        Me.lbl_wv_1.Visible = False
        '
        'lbl_dv_4
        '
        Me.lbl_dv_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_dv_4.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_dv_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_dv_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dv_4.ForeColor = System.Drawing.Color.Black
        Me.lbl_dv_4.Location = New System.Drawing.Point(288, 126)
        Me.lbl_dv_4.Name = "lbl_dv_4"
        Me.lbl_dv_4.Size = New System.Drawing.Size(20, 20)
        Me.lbl_dv_4.TabIndex = 106
        Me.lbl_dv_4.UseMnemonic = False
        Me.lbl_dv_4.Visible = False
        '
        'lbl_dv_3
        '
        Me.lbl_dv_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_dv_3.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_dv_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_dv_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dv_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_dv_3.Location = New System.Drawing.Point(261, 126)
        Me.lbl_dv_3.Name = "lbl_dv_3"
        Me.lbl_dv_3.Size = New System.Drawing.Size(20, 20)
        Me.lbl_dv_3.TabIndex = 105
        Me.lbl_dv_3.UseMnemonic = False
        Me.lbl_dv_3.Visible = False
        '
        'lbl_dv_2
        '
        Me.lbl_dv_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_dv_2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_dv_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_dv_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dv_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_dv_2.Location = New System.Drawing.Point(234, 126)
        Me.lbl_dv_2.Name = "lbl_dv_2"
        Me.lbl_dv_2.Size = New System.Drawing.Size(20, 20)
        Me.lbl_dv_2.TabIndex = 104
        Me.lbl_dv_2.UseMnemonic = False
        Me.lbl_dv_2.Visible = False
        '
        'lbl_dv_1
        '
        Me.lbl_dv_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_dv_1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_dv_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_dv_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dv_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_dv_1.Location = New System.Drawing.Point(207, 126)
        Me.lbl_dv_1.Name = "lbl_dv_1"
        Me.lbl_dv_1.Size = New System.Drawing.Size(20, 20)
        Me.lbl_dv_1.TabIndex = 103
        Me.lbl_dv_1.UseMnemonic = False
        Me.lbl_dv_1.Visible = False
        '
        'lbl_dp_4
        '
        Me.lbl_dp_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_dp_4.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_dp_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_dp_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dp_4.ForeColor = System.Drawing.Color.Black
        Me.lbl_dp_4.Location = New System.Drawing.Point(288, 100)
        Me.lbl_dp_4.Name = "lbl_dp_4"
        Me.lbl_dp_4.Size = New System.Drawing.Size(20, 20)
        Me.lbl_dp_4.TabIndex = 102
        Me.lbl_dp_4.UseMnemonic = False
        Me.lbl_dp_4.Visible = False
        '
        'lbl_dp_3
        '
        Me.lbl_dp_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_dp_3.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_dp_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_dp_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dp_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_dp_3.Location = New System.Drawing.Point(261, 100)
        Me.lbl_dp_3.Name = "lbl_dp_3"
        Me.lbl_dp_3.Size = New System.Drawing.Size(20, 20)
        Me.lbl_dp_3.TabIndex = 101
        Me.lbl_dp_3.UseMnemonic = False
        Me.lbl_dp_3.Visible = False
        '
        'lbl_dp_2
        '
        Me.lbl_dp_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_dp_2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_dp_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_dp_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dp_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_dp_2.Location = New System.Drawing.Point(234, 100)
        Me.lbl_dp_2.Name = "lbl_dp_2"
        Me.lbl_dp_2.Size = New System.Drawing.Size(20, 20)
        Me.lbl_dp_2.TabIndex = 100
        Me.lbl_dp_2.UseMnemonic = False
        Me.lbl_dp_2.Visible = False
        '
        'lbl_dp_1
        '
        Me.lbl_dp_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_dp_1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_dp_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_dp_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dp_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_dp_1.Location = New System.Drawing.Point(207, 100)
        Me.lbl_dp_1.Name = "lbl_dp_1"
        Me.lbl_dp_1.Size = New System.Drawing.Size(20, 20)
        Me.lbl_dp_1.TabIndex = 99
        Me.lbl_dp_1.UseMnemonic = False
        Me.lbl_dp_1.Visible = False
        '
        'lbl_us_4
        '
        Me.lbl_us_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_us_4.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_us_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_us_4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_us_4.ForeColor = System.Drawing.Color.Black
        Me.lbl_us_4.Location = New System.Drawing.Point(288, 74)
        Me.lbl_us_4.Name = "lbl_us_4"
        Me.lbl_us_4.Size = New System.Drawing.Size(20, 20)
        Me.lbl_us_4.TabIndex = 98
        Me.lbl_us_4.UseMnemonic = False
        Me.lbl_us_4.Visible = False
        '
        'lbl_us_3
        '
        Me.lbl_us_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_us_3.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_us_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_us_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_us_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_us_3.Location = New System.Drawing.Point(261, 74)
        Me.lbl_us_3.Name = "lbl_us_3"
        Me.lbl_us_3.Size = New System.Drawing.Size(20, 20)
        Me.lbl_us_3.TabIndex = 97
        Me.lbl_us_3.UseMnemonic = False
        Me.lbl_us_3.Visible = False
        '
        'lbl_us_2
        '
        Me.lbl_us_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_us_2.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_us_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_us_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_us_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_us_2.Location = New System.Drawing.Point(234, 74)
        Me.lbl_us_2.Name = "lbl_us_2"
        Me.lbl_us_2.Size = New System.Drawing.Size(20, 20)
        Me.lbl_us_2.TabIndex = 96
        Me.lbl_us_2.UseMnemonic = False
        Me.lbl_us_2.Visible = False
        '
        'lbl_us_1
        '
        Me.lbl_us_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_us_1.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_us_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_us_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_us_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_us_1.Location = New System.Drawing.Point(207, 74)
        Me.lbl_us_1.Name = "lbl_us_1"
        Me.lbl_us_1.Size = New System.Drawing.Size(20, 20)
        Me.lbl_us_1.TabIndex = 95
        Me.lbl_us_1.UseMnemonic = False
        Me.lbl_us_1.Visible = False
        '
        'btn_ep
        '
        Me.btn_ep.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_ep.BackColor = System.Drawing.Color.Transparent
        Me.btn_ep.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_ep.DisplayText = ""
        Me.btn_ep.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ep.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ep.ForeColor = System.Drawing.Color.Black
        Me.btn_ep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ep.Location = New System.Drawing.Point(27, 475)
        Me.btn_ep.Name = "btn_ep"
        Me.btn_ep.Size = New System.Drawing.Size(164, 22)
        Me.btn_ep.TabIndex = 15
        Me.btn_ep.Text = "Enzyme pump (81)"
        Me.btn_ep.UseVisualStyleBackColor = False
        '
        'btn_de_pmp
        '
        Me.btn_de_pmp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_de_pmp.BackColor = System.Drawing.Color.Transparent
        Me.btn_de_pmp.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_de_pmp.DisplayText = ""
        Me.btn_de_pmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_de_pmp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_de_pmp.ForeColor = System.Drawing.Color.Black
        Me.btn_de_pmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_de_pmp.Location = New System.Drawing.Point(27, 448)
        Me.btn_de_pmp.Name = "btn_de_pmp"
        Me.btn_de_pmp.Size = New System.Drawing.Size(164, 22)
        Me.btn_de_pmp.TabIndex = 14
        Me.btn_de_pmp.Text = "Detegent pump (81)"
        Me.btn_de_pmp.UseVisualStyleBackColor = False
        '
        'btn_sr
        '
        Me.btn_sr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_sr.BackColor = System.Drawing.Color.Transparent
        Me.btn_sr.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_sr.DisplayText = ""
        Me.btn_sr.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_sr.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sr.ForeColor = System.Drawing.Color.Black
        Me.btn_sr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sr.Location = New System.Drawing.Point(27, 421)
        Me.btn_sr.Name = "btn_sr"
        Me.btn_sr.Size = New System.Drawing.Size(164, 22)
        Me.btn_sr.TabIndex = 13
        Me.btn_sr.Text = "Spray rinse (81)"
        Me.btn_sr.UseVisualStyleBackColor = False
        '
        'btn_bh
        '
        Me.btn_bh.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_bh.BackColor = System.Drawing.Color.Transparent
        Me.btn_bh.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_bh.DisplayText = ""
        Me.btn_bh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_bh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bh.ForeColor = System.Drawing.Color.Black
        Me.btn_bh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_bh.Location = New System.Drawing.Point(27, 394)
        Me.btn_bh.Name = "btn_bh"
        Me.btn_bh.Size = New System.Drawing.Size(164, 22)
        Me.btn_bh.TabIndex = 12
        Me.btn_bh.Text = "Bay heat"
        Me.btn_bh.UseVisualStyleBackColor = False
        '
        'btn_rh
        '
        Me.btn_rh.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_rh.BackColor = System.Drawing.Color.Transparent
        Me.btn_rh.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_rh.DisplayText = ""
        Me.btn_rh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_rh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rh.ForeColor = System.Drawing.Color.Black
        Me.btn_rh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_rh.Location = New System.Drawing.Point(27, 367)
        Me.btn_rh.Name = "btn_rh"
        Me.btn_rh.Size = New System.Drawing.Size(164, 22)
        Me.btn_rh.TabIndex = 11
        Me.btn_rh.Text = "Reservoir heat"
        Me.btn_rh.UseVisualStyleBackColor = False
        '
        'btn_lb
        '
        Me.btn_lb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_lb.BackColor = System.Drawing.Color.Transparent
        Me.btn_lb.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_lb.DisplayText = ""
        Me.btn_lb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_lb.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_lb.ForeColor = System.Drawing.Color.Black
        Me.btn_lb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_lb.Location = New System.Drawing.Point(27, 339)
        Me.btn_lb.Name = "btn_lb"
        Me.btn_lb.Size = New System.Drawing.Size(164, 22)
        Me.btn_lb.TabIndex = 10
        Me.btn_lb.Text = "Lubrication (83 det)"
        Me.btn_lb.UseVisualStyleBackColor = False
        '
        'btn_ar
        '
        Me.btn_ar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_ar.BackColor = System.Drawing.Color.Transparent
        Me.btn_ar.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_ar.DisplayText = ""
        Me.btn_ar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ar.ForeColor = System.Drawing.Color.Black
        Me.btn_ar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ar.Location = New System.Drawing.Point(27, 312)
        Me.btn_ar.Name = "btn_ar"
        Me.btn_ar.Size = New System.Drawing.Size(164, 22)
        Me.btn_ar.TabIndex = 9
        Me.btn_ar.Text = "Air"
        Me.btn_ar.UseVisualStyleBackColor = False
        '
        'btn_rd
        '
        Me.btn_rd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_rd.BackColor = System.Drawing.Color.Transparent
        Me.btn_rd.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_rd.DisplayText = ""
        Me.btn_rd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_rd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rd.ForeColor = System.Drawing.Color.Black
        Me.btn_rd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_rd.Location = New System.Drawing.Point(27, 285)
        Me.btn_rd.Name = "btn_rd"
        Me.btn_rd.Size = New System.Drawing.Size(164, 22)
        Me.btn_rd.TabIndex = 8
        Me.btn_rd.Text = "Residual drain"
        Me.btn_rd.UseVisualStyleBackColor = False
        '
        'btn_rr
        '
        Me.btn_rr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_rr.BackColor = System.Drawing.Color.Transparent
        Me.btn_rr.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_rr.DisplayText = ""
        Me.btn_rr.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_rr.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rr.ForeColor = System.Drawing.Color.Black
        Me.btn_rr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_rr.Location = New System.Drawing.Point(27, 258)
        Me.btn_rr.Name = "btn_rr"
        Me.btn_rr.Size = New System.Drawing.Size(164, 22)
        Me.btn_rr.TabIndex = 7
        Me.btn_rr.Text = "Reservoir return"
        Me.btn_rr.UseVisualStyleBackColor = False
        '
        'btn_rf
        '
        Me.btn_rf.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_rf.BackColor = System.Drawing.Color.Transparent
        Me.btn_rf.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_rf.DisplayText = ""
        Me.btn_rf.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_rf.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rf.ForeColor = System.Drawing.Color.Black
        Me.btn_rf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_rf.Location = New System.Drawing.Point(27, 231)
        Me.btn_rf.Name = "btn_rf"
        Me.btn_rf.Size = New System.Drawing.Size(164, 22)
        Me.btn_rf.TabIndex = 6
        Me.btn_rf.Text = "Reservoir feed"
        Me.btn_rf.UseVisualStyleBackColor = False
        '
        'btn_rp
        '
        Me.btn_rp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_rp.BackColor = System.Drawing.Color.Transparent
        Me.btn_rp.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_rp.DisplayText = ""
        Me.btn_rp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_rp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rp.ForeColor = System.Drawing.Color.Black
        Me.btn_rp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_rp.Location = New System.Drawing.Point(27, 204)
        Me.btn_rp.Name = "btn_rp"
        Me.btn_rp.Size = New System.Drawing.Size(164, 22)
        Me.btn_rp.TabIndex = 5
        Me.btn_rp.Text = "Reservoir pump"
        Me.btn_rp.UseVisualStyleBackColor = False
        '
        'btn_op
        '
        Me.btn_op.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_op.BackColor = System.Drawing.Color.Transparent
        Me.btn_op.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_op.DisplayText = ""
        Me.btn_op.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_op.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_op.ForeColor = System.Drawing.Color.Black
        Me.btn_op.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_op.Location = New System.Drawing.Point(27, 177)
        Me.btn_op.Name = "btn_op"
        Me.btn_op.Size = New System.Drawing.Size(164, 22)
        Me.btn_op.TabIndex = 4
        Me.btn_op.Text = "Oscillating pump"
        Me.btn_op.UseVisualStyleBackColor = False
        '
        'btn_wv
        '
        Me.btn_wv.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_wv.BackColor = System.Drawing.Color.Transparent
        Me.btn_wv.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_wv.DisplayText = ""
        Me.btn_wv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_wv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_wv.ForeColor = System.Drawing.Color.Black
        Me.btn_wv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_wv.Location = New System.Drawing.Point(27, 151)
        Me.btn_wv.Name = "btn_wv"
        Me.btn_wv.Size = New System.Drawing.Size(164, 22)
        Me.btn_wv.TabIndex = 3
        Me.btn_wv.Text = "Water valve"
        Me.btn_wv.UseVisualStyleBackColor = False
        '
        'btn_dv
        '
        Me.btn_dv.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_dv.BackColor = System.Drawing.Color.Transparent
        Me.btn_dv.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_dv.DisplayText = ""
        Me.btn_dv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_dv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dv.ForeColor = System.Drawing.Color.Black
        Me.btn_dv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dv.Location = New System.Drawing.Point(27, 125)
        Me.btn_dv.Name = "btn_dv"
        Me.btn_dv.Size = New System.Drawing.Size(164, 22)
        Me.btn_dv.TabIndex = 2
        Me.btn_dv.Text = "Drain valve"
        Me.btn_dv.UseVisualStyleBackColor = False
        '
        'btn_dp
        '
        Me.btn_dp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_dp.BackColor = System.Drawing.Color.Transparent
        Me.btn_dp.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_dp.DisplayText = ""
        Me.btn_dp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_dp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dp.ForeColor = System.Drawing.Color.Black
        Me.btn_dp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dp.Location = New System.Drawing.Point(27, 99)
        Me.btn_dp.Name = "btn_dp"
        Me.btn_dp.Size = New System.Drawing.Size(164, 22)
        Me.btn_dp.TabIndex = 1
        Me.btn_dp.Text = "Drain pump"
        Me.btn_dp.UseVisualStyleBackColor = False
        '
        'btn_print
        '
        Me.btn_print.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_print.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_print.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_print.DisplayText = ""
        Me.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_print.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ForeColor = System.Drawing.Color.Black
        Me.btn_print.Image = CType(resources.GetObject("btn_print.Image"), System.Drawing.Image)
        Me.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_print.Location = New System.Drawing.Point(164, 9)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(130, 43)
        Me.btn_print.TabIndex = 17
        Me.btn_print.TabStop = False
        Me.btn_print.Text = "Print Test"
        Me.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'lbl_wcp
        '
        Me.lbl_wcp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_wcp.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_wcp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_wcp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_wcp.ForeColor = System.Drawing.Color.Black
        Me.lbl_wcp.Location = New System.Drawing.Point(489, 151)
        Me.lbl_wcp.Name = "lbl_wcp"
        Me.lbl_wcp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_wcp.Size = New System.Drawing.Size(164, 22)
        Me.lbl_wcp.TabIndex = 66
        Me.lbl_wcp.Text = "Water channel pressure"
        Me.lbl_wcp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_wcp.UseMnemonic = False
        '
        'lbl_safety
        '
        Me.lbl_safety.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_safety.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_safety.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_safety.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_safety.ForeColor = System.Drawing.Color.Black
        Me.lbl_safety.Location = New System.Drawing.Point(489, 125)
        Me.lbl_safety.Name = "lbl_safety"
        Me.lbl_safety.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_safety.Size = New System.Drawing.Size(164, 22)
        Me.lbl_safety.TabIndex = 64
        Me.lbl_safety.Text = "Safety"
        Me.lbl_safety.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_safety.UseMnemonic = False
        '
        'lbl_float
        '
        Me.lbl_float.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_float.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_float.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_float.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_float.ForeColor = System.Drawing.Color.Black
        Me.lbl_float.Location = New System.Drawing.Point(489, 99)
        Me.lbl_float.Name = "lbl_float"
        Me.lbl_float.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_float.Size = New System.Drawing.Size(164, 22)
        Me.lbl_float.TabIndex = 62
        Me.lbl_float.Text = "Float"
        Me.lbl_float.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_float.UseMnemonic = False
        '
        'lbl_flow
        '
        Me.lbl_flow.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_flow.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_flow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_flow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_flow.ForeColor = System.Drawing.Color.Black
        Me.lbl_flow.Location = New System.Drawing.Point(489, 73)
        Me.lbl_flow.Name = "lbl_flow"
        Me.lbl_flow.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_flow.Size = New System.Drawing.Size(164, 22)
        Me.lbl_flow.TabIndex = 60
        Me.lbl_flow.Text = "Flow"
        Me.lbl_flow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_flow.UseMnemonic = False
        '
        'btn_us
        '
        Me.btn_us.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_us.BackColor = System.Drawing.Color.Transparent
        Me.btn_us.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_us.DisplayText = ""
        Me.btn_us.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_us.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_us.ForeColor = System.Drawing.Color.Black
        Me.btn_us.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_us.Location = New System.Drawing.Point(27, 73)
        Me.btn_us.Name = "btn_us"
        Me.btn_us.Size = New System.Drawing.Size(164, 22)
        Me.btn_us.TabIndex = 0
        Me.btn_us.Text = "Ultrasonics"
        Me.btn_us.UseVisualStyleBackColor = False
        '
        'lbl_info
        '
        Me.lbl_info.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_info.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_info.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info.ForeColor = System.Drawing.Color.Black
        Me.lbl_info.Location = New System.Drawing.Point(8, 512)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(656, 17)
        Me.lbl_info.TabIndex = 10
        Me.lbl_info.Text = "Use arrow keys to highlight function and press # key to active/deactive function." & _
            ""
        Me.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_info.UseMnemonic = False
        '
        'btn_close
        '
        Me.btn_close.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_close.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_close.ButtonType = DBA.Library.DBA_Button.DBA_Button_type.Normal
        Me.btn_close.DisplayText = ""
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.Black
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_close.Location = New System.Drawing.Point(302, 9)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(104, 43)
        Me.btn_close.TabIndex = 18
        Me.btn_close.TabStop = False
        Me.btn_close.Text = "Close"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'services
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(678, 541)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "services"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "services"
        CType(Me.ControlTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_main.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Overrides "
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Dim keyCode As Keys = CType((msg.WParam.ToInt32 And Keys.KeyCode), Keys)

        ' ----------------------------
        ' * Restart Screen Saver Timer
        ' ----------------------------
        Call restart_timer()

        ' -------------------
        ' * Process Keystokes
        ' -------------------
        Select Case keyCode
            Case Keys.F2
                Call Reset_All()

            Case Keys.F4
                Call print_list()

            Case Keys.F8
                Call close_form()

            Case Keys.D1, Keys.NumPad1
                If g_bay_count > 0 Then Call Process("1")

            Case Keys.D2, Keys.NumPad2
                If g_bay_count > 1 Then Call Process("2")

            Case Keys.D3, Keys.NumPad3
                If g_bay_count > 2 Then Call Process("3")

            Case Keys.D4, Keys.NumPad4
                If g_bay_count > 3 Then Call Process("4")
        End Select

        Select Case keyCode
            Case Keys.F2, Keys.F4, Keys.F8
                Return True
        End Select
    End Function
#End Region

#Region " Declarations "
    Dim m_max_bays As Integer
    Dim m_inputs(4, 1) As String
    Dim m_temp_monitor(3, 0) As Boolean

    Dim m_prev_form As Form
    Dim m_close_index As Integer
#End Region

#Region " Button Events "
    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Call close_form()
    End Sub

    Private Sub btn_print_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_print.Click
        Call print_list()
    End Sub

    Private Sub btn_off_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_off.Click
        Call Reset_All()
    End Sub
#End Region

#Region " Close Form "
    Private Sub close_form()
        ' ----------------
        ' * Reset Machines
        ' ----------------
        Call set_monitoring(False)
        Call reset_temp_monitoring()
        Call reset_cards()

        ' Load Previous Screen
        m_prev_form.Show()
        g_framework.g_forms(m_close_index) = Nothing
        Me.Close()
    End Sub
#End Region

#Region " Form Load "
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call size_screen(Me)

        Call set_screen()

        ' ----------------------------
        ' * Disable Ultrasonics Sensor
        ' ----------------------------
        If Not g_us_usage Then
            lbl_ultrasonics.Visible = False
            lbl_ui_1.Visible = False
            lbl_ui_2.Visible = False
            lbl_ui_3.Visible = False
            lbl_ui_4.Visible = False
        End If

        ' ------------
        ' * Set Inputs
        ' ------------
        m_inputs(0, 0) = "I_FLOW"
        m_inputs(0, 1) = "fw"
        m_inputs(1, 0) = "I_FLOAT"
        m_inputs(1, 1) = "ft"
        m_inputs(2, 0) = "I_SAFETY"
        m_inputs(2, 1) = "sy"
        m_inputs(3, 0) = "I_PRESSURE"
        m_inputs(3, 1) = "wc"
        m_inputs(4, 0) = "I_ULTRASONICS"
        m_inputs(4, 1) = "ui"

        ' ---------------------------
        ' * Set Demo Mode of Machines
        ' ---------------------------
        For p_x As Integer = 0 To g_bay_count - 1
            g_CUSMain.Machines(p_x).DemoMode = False

            m_temp_monitor(p_x, 0) = g_CUSMain.Machines(p_x).MonitorResTemperature

            RemoveHandler g_CUSMain.Machines(p_x).BitStatesChanged, AddressOf BitStatesChanged
            AddHandler g_CUSMain.Machines(p_x).BitStatesChanged, AddressOf BitStatesChanged
        Next

        ' ------------------
        ' * Start Monitoring
        ' ------------------
        Call set_monitoring(True)
    End Sub
#End Region

#Region " Get Label "
    Private Function get_label(ByVal p_name As String) As DBA.Library.DBA_Label
        get_label = Nothing

        For Each p_ctrl As Control In pnl_main.Controls
            If TypeOf p_ctrl Is DBA.Library.DBA_Label Then
                If p_ctrl.Name = p_name Then
                    get_label = p_ctrl
                End If
            End If
        Next
    End Function
#End Region

#Region " Handle Functions "
    Private Sub BitStatesChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim p_machine As CUSNET.Machine = sender
        Dim p_label As DBA.Library.DBA_Label

        Try
            For p_x As Integer = 0 To 4
                p_label = get_label("lbl_" & m_inputs(p_x, 1) & "_" & p_machine.BayNumber)

                If Not p_label Is Nothing Then
                    If p_machine.Bits(m_inputs(p_x, 0)).State Then
                        If p_label.Tag <> "ON" Then
                            p_label.BackColor = System.Drawing.Color.Green
                            p_label.ForeColor = System.Drawing.Color.White

                            p_label.Tag = "ON"
                        End If
                    Else
                        If p_label.Tag = "ON" Then
                            p_label.BackColor = System.Drawing.Color.PapayaWhip
                            p_label.ForeColor = System.Drawing.Color.Black

                            p_label.Tag = "OFF"
                        End If
                    End If
                End If
            Next
        Catch
        End Try
    End Sub
#End Region

#Region " Print List "
    Private Sub print_list()
        If message_box("Continue print test?", 2, "Confirm Print") = MsgBoxResult.No Then Exit Sub

        Try
            Dim p_print As New CUSPrint.DatasetPrinting(g_PrintPort)
            Dim p_sql As String
            Dim p_dataset As DataSet

            p_sql = "Select 'Printed fine' As Test"
            p_dataset = g_framework.Get_Data(p_sql)

            With p_print
                .DataSetToPrint = p_dataset
                .ReportTitle = "Print Test"
                .Print()
            End With

        Catch
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Call message_box("Bad printer connection.", 4, "Print Error")
        End Try
    End Sub
#End Region

#Region " Process "
    Private Sub Process(ByVal p_type As String)
        Dim p_name As String
        Dim p_ctrl As DBA.Library.DBA_Label

        ' -------------------------
        ' * Set Coloring of Control
        ' -------------------------
        p_name = Mid(Me.ActiveControl.Name, 5, 2)
        p_ctrl = get_label("lbl_" & p_name & "_" & p_type)

        If p_ctrl Is Nothing Then Exit Sub

        Select Case p_ctrl.Tag
            Case "ON"
                p_ctrl.BackColor = System.Drawing.Color.PapayaWhip
                p_ctrl.ForeColor = System.Drawing.Color.Black
                p_ctrl.Tag = "OFF"

                Call set_card(p_name, Val(p_type), False)

            Case Else
                p_ctrl.BackColor = System.Drawing.Color.Green
                p_ctrl.ForeColor = System.Drawing.Color.White
                p_ctrl.Tag = "ON"

                Call set_card(p_name, Val(p_type), True)
        End Select
    End Sub

    Private Sub set_card(ByVal p_name As String, ByVal p_index As Integer, _
        ByVal p_state As Boolean)

        Dim p_value As String = ""

        Select Case p_name
            Case "us"
                p_value = "O_ULTRA"

            Case "dp"
                p_value = "O_DRAIN_P"

            Case "dv"
                p_value = "O_DRAIN_V"

            Case "wv"
                p_value = "O_WATER_V"

            Case "op"
                p_value = "O_OSC_P"

            Case "rp"
                p_value = "O_DIS_P"

            Case "rf"
                p_value = "O_DIS_F_V"

            Case "rr"
                p_value = "O_DIS_R_V"

            Case "rd"
                p_value = "O_RES_D"

            Case "ar"
                p_value = "O_AIR"

            Case "lb"
                p_value = "O_LUB_P"

            Case "rh"
                p_value = "O_RES_H"

            Case "bh"
                p_value = "O_BAY_H"

            Case "sr"
                p_value = "O_RINSE_S"

            Case "de"
                p_value = "O_DET_81_P"

            Case "ep"
                p_value = "O_ENZ_P"
        End Select

        ' -----------
        ' * Set Label
        ' -----------
        If p_value <> "" Then
            Call g_CUSMain.Machines(p_index - 1).set_bit(p_value, p_state)
        End If

        ' ----------------------------
        ' * Set Temperature Monitoring
        ' ----------------------------
        Select Case UCase(p_value)
            Case "O_RES_H"
                If p_state Then
                    g_CUSMain.Machines(p_index - 1).MonitorResTemperature = False
                Else
                    g_CUSMain.Machines(p_index - 1).MonitorResTemperature = m_temp_monitor(p_index - 1, 0)
                End If

            Case "O_BAY_H"
                g_CUSMain.Machines(p_index - 1).ServiceBayTemp = p_state
        End Select
    End Sub
#End Region

#Region " Reset All "
    Private Sub Reset_All()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Refresh()

        ' ----------------
        ' * Reset Machines
        ' ----------------
        Call reset_temp_monitoring()
        Call reset_cards()

        ' --------------
        ' * Reset Screen
        ' --------------
        For Each p_ctrl As Control In pnl_main.Controls
            If TypeOf p_ctrl Is DBA.library.DBA_Label Then
                Select Case Mid(p_ctrl.Name, 1, 6)
                    Case "lbl_fw", "lbl_ft", "lbl_sy", "lbl_wc", "lbl_ui" ' Skip Inputs
                    Case Else
                        If p_ctrl.Tag = "ON" Then
                            p_ctrl.BackColor = System.Drawing.Color.PapayaWhip
                            p_ctrl.ForeColor = System.Drawing.Color.Black

                            p_ctrl.Tag = "OFF"
                        End If
                End Select
            End If
        Next

        btn_us.Focus()

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub reset_cards()
        For p_x As Integer = 0 To g_bay_count - 1
            g_CUSMain.Machines(p_x).TurnOffAllBits()
        Next
    End Sub
#End Region

#Region " Reset Temperature Monitoring "
    Private Sub reset_temp_monitoring()
        ' ------------------------------------------
        ' * Reset Temperature Monitoring Of Machines
        ' ------------------------------------------
        For p_x As Integer = 0 To g_bay_count - 1
            g_CUSMain.Machines(p_x).MonitorResTemperature = m_temp_monitor(p_x, 0)
            g_CUSMain.Machines(p_x).ServiceBayTemp = False
        Next
    End Sub
#End Region

#Region " Set Screen "
    Private Sub set_screen()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Refresh()

        For Each p_ctrl As Control In pnl_main.Controls
            If TypeOf p_ctrl Is DBA.library.DBA_Label Then
                If Len(p_ctrl.Name) = 8 Then
                    Select Case Val(Mid(p_ctrl.Name, 8, 1))
                        Case Is <= g_bay_count
                            p_ctrl.Visible = True
                    End Select
                End If
            End If
        Next

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
#End Region

End Class