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

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        fechar()
    End Sub

    Private Sub sidebarTimer_Tick(sender As Object, e As EventArgs) Handles sidebarTimer.Tick
        sidebar_responsividade(sidebarTecnico, expend)
    End Sub
End Class