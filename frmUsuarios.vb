Public Class frmUsuarios
    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        fechar()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        navegacao(frmAdicionarUsuario)
    End Sub

    Private Sub btnPesquisaUsuario_Click(sender As Object, e As EventArgs) Handles btnPesquisaUsuario.Click
        txtPesquisa.PlaceholderText = "Digite o usuário"
    End Sub

    Private Sub btnPesquisaCargo_Click(sender As Object, e As EventArgs) Handles btnPesquisaCargo.Click
        txtPesquisa.PlaceholderText = "Digite o cargo"
    End Sub

    Private Sub btnPesquisaEmail_Click(sender As Object, e As EventArgs) Handles btnPesquisaEmail.Click
        txtPesquisa.PlaceholderText = "Digite o email"
    End Sub
End Class