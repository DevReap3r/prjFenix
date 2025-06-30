Imports Guna.UI2.WinForms

Public Class frmConsultaHome
    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisa.TextChanged

    End Sub

    Private Sub frmConsultaHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagridModelos.DataSource = ModuloConsulta.getModelos("", "")
        If tipo_conta = 1 Then
            btnAdd.Visible = True
        End If
    End Sub

    Private Sub btnPesquisaModelo_Click(sender As Object, e As EventArgs) Handles btnPesquisaModelo.Click
        txtPesquisa.PlaceholderText = "Digite o modelo do dispositivo"
        datagridModelos.DataSource = ModuloConsulta.getModelos(txtPesquisa.Text, "modelo")
    End Sub

    Private Sub btnPesquisaMarca_Click(sender As Object, e As EventArgs) Handles btnPesquisaMarca.Click
        txtPesquisa.PlaceholderText = "Digite a marca do dispositivo"
        datagridModelos.DataSource = ModuloConsulta.getModelos(txtPesquisa.Text, "marca")
    End Sub

    Private Sub btnPesquisaCod_Click(sender As Object, e As EventArgs) Handles btnPesquisaCod.Click
        txtPesquisa.PlaceholderText = "Digite o código do dispositivo"
        datagridModelos.DataSource = ModuloConsulta.getModelos(txtPesquisa.Text, "código")
    End Sub

    Private Sub Guna2VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles Guna2VScrollBar1.Scroll

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        fechar()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        navegacao(frmAdicionarModelo)
    End Sub

    Private Sub btnPesquisa_Click(sender As Object, e As EventArgs) Handles btnPesquisa.Click
        datagridModelos.DataSource = ModuloConsulta.getModelos(txtPesquisa.Text, "")
    End Sub

    Private Sub datagridModelos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridModelos.CellDoubleClick
        frmConsultaModelo.modelo = datagridModelos.Rows(e.RowIndex).Cells(0).Value.ToString()
        navegacao(frmConsultaModelo)
    End Sub
End Class