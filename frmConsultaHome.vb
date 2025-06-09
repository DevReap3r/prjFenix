Public Class frmConsultaHome
    Dim tipo_pesquisa As Integer
    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisa.TextChanged

    End Sub

    Private Sub frmConsultaHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPesquisaModelo_Click(sender As Object, e As EventArgs) Handles btnPesquisaModelo.Click
        txtPesquisa.PlaceholderText = "Digite o modelo do dispositivo"
        tipo_pesquisa = 0
    End Sub

    Private Sub btnPesquisaMarca_Click(sender As Object, e As EventArgs) Handles btnPesquisaMarca.Click
        txtPesquisa.PlaceholderText = "Digite a marca do dispositivo"
        tipo_pesquisa = 1
    End Sub

    Private Sub btnPesquisaCod_Click(sender As Object, e As EventArgs) Handles btnPesquisaCod.Click
        txtPesquisa.PlaceholderText = "Digite o código do dispositivo"
        tipo_pesquisa = 2
    End Sub
End Class