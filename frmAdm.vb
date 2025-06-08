Public Class frmAdm
    Dim expend As Boolean
    Private Sub frmAdm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnConsulta_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        fechar()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        deslogar()
    End Sub

    Private Sub btnSidebar_Click(sender As Object, e As EventArgs) Handles btnSidebar.Click
        sidebarTimerAdm.Start()
        If sidebarAdm.Width = sidebarAdm.MinimumSize.Width Then
            expend = True
        ElseIf sidebarAdm.Width = sidebarAdm.MaximumSize.Width Then
            expend = False
        End If
    End Sub

    Private Sub sidebarTimerAdm_Tick(sender As Object, e As EventArgs) Handles sidebarTimerAdm.Tick
        sidebar_responsividade(sidebarAdm, expend)
    End Sub
End Class