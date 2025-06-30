Imports MySql.Data.MySqlClient
Public Class frmConsultaModelo
    Public modelo As String
    Dim idModelo As Integer
    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        fechar()
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        navegacao(frmConsultaHome)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        navegacao(frmAdicionarServicosModelo)
    End Sub

    Private Sub frmConsultaModelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cmd As New MySqlCommand("select id_modelo from tb_modelo where nome_modelo = @modelo", db)
            cmd.Parameters.AddWithValue("@modelo", modelo)
            db.Open()
            idModelo = Convert.ToInt32(cmd.ExecuteScalar())
            db.Close()
            datagridServicos.DataSource = ModuloConsulta.getManutencao("", idModelo)
        Catch ex As Exception
            MsgBox("Erro ao carregar os serviços do modelo: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub btnPesquisa_Click(sender As Object, e As EventArgs) Handles btnPesquisa.Click
        datagridServicos.DataSource = ModuloConsulta.getManutencao(txtPesquisa.Text, idModelo)
    End Sub
End Class