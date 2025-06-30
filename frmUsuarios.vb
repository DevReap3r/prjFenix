Imports MySql.Data.MySqlClient
Public Class frmUsuarios
    Dim tipo_pesquisa As String = "usuario"
    Dim resp As String
    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        fechar()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        navegacao(frmAdicionarUsuario)
    End Sub

    Private Sub btnPesquisaUsuario_Click(sender As Object, e As EventArgs) Handles btnPesquisaUsuario.Click
        datagridUsuarios.DataSource = GetUsuarios(txtPesquisa.Text, "usuario")
        txtPesquisa.PlaceholderText = "Digite o usuário"
        tipo_pesquisa = "usuario"
    End Sub

    Private Sub btnPesquisaCargo_Click(sender As Object, e As EventArgs) Handles btnPesquisaCargo.Click
        datagridUsuarios.DataSource = GetUsuarios(txtPesquisa.Text, "cargo")
        txtPesquisa.PlaceholderText = "Digite o cargo"
        tipo_pesquisa = "cargo"
    End Sub


    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If admin Then
            btnAdd.Visible = Visible
        End If
        datagridUsuarios.DataSource = GetUsuarios("", "")
    End Sub

    Private Sub btnPesquisa_Click(sender As Object, e As EventArgs) Handles btnPesquisa.Click
        datagridUsuarios.DataSource = GetUsuarios(txtPesquisa.Text, tipo_pesquisa)
    End Sub

    Private Sub datagridUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridUsuarios.CellDoubleClick
        frmAtualizarUsuario.usuario = datagridUsuarios.Rows(e.RowIndex).Cells(0).Value.ToString()
        navegacao(frmAtualizarUsuario)
    End Sub

    Private Sub datagridUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridUsuarios.CellContentClick

    End Sub
End Class