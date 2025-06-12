Public Class frmClientes
    Private Sub datagridModelos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridModelos.CellContentClick

    End Sub

    Private Sub Guna2VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles Guna2VScrollBar1.Scroll

    End Sub

    Private Sub btnPesquisaCPF_Click(sender As Object, e As EventArgs) Handles btnPesquisaCPF.Click
        txtPesquisa.PlaceholderText = "Digite o CPF do cliente"
    End Sub

    Private Sub btnPesquisaNome_Click(sender As Object, e As EventArgs) Handles btnPesquisaNome.Click
        txtPesquisa.PlaceholderText = "Digite o nome do cliente"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub
End Class