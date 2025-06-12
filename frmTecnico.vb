Public Class frmTecnico
    Dim expend As Boolean
    Private Sub btnSidebar_Click(sender As Object, e As EventArgs) Handles btnSidebar.Click
        sidebarTimer.Start()
        If sidebarTecnico.Width = sidebarTecnico.MinimumSize.Width Then
            expend = True
        ElseIf sidebarTecnico.Width = sidebarTecnico.MaximumSize.Width Then
            expend = False
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        deslogar()
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs)
        fechar()
    End Sub

    Private Sub sidebarTimer_Tick(sender As Object, e As EventArgs) Handles sidebarTimer.Tick
        sidebar_responsividade(sidebarTecnico, expend)
    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        btnConsulta.FillColor = Color.OrangeRed
        btnOs.FillColor = Color.Transparent
        btnClientes.FillColor = Color.Transparent
    End Sub

    Private Sub btnOs_Click(sender As Object, e As EventArgs) Handles btnOs.Click
        btnOs.FillColor = Color.OrangeRed
        btnConsulta.FillColor = Color.Transparent
        btnClientes.FillColor = Color.Transparent
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        btnClientes.FillColor = Color.OrangeRed
        btnOs.FillColor = Color.Transparent
        btnConsulta.FillColor = Color.Transparent
    End Sub

    Private Sub frmTecnico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActiveButton(btnConsulta, sidebarTecnico)
        FormShow(frmConsultaHome, panel_forms)
    End Sub

End Class