Public Class frmAdicionarModelo
    Dim resp As String
    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        resp = MsgBox("Você deseja sair sem salvar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Fechar")
        If resp = vbYes Then
            navegacao(frmConsultaHome)
        Else
            Return
        End If
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        fechar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        resp = MsgBox("Você deseja cancelar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Fechar")
        If resp = vbYes Then
            navegacao(frmConsultaHome)
        Else
            Return
        End If
    End Sub

    Private Sub frmAdicionarModelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtModelo.Text = "" Or cmbMarca.SelectedIndex = -1 Then
            MsgBox("Preencha os campos de modelo e marca!", MsgBoxStyle.Exclamation, "Atenção")
            Return
        Else
            adicionarModelo(txtModelo.Text, cmbMarca.ToString(), txtCod.Text)
            navegacao(frmConsultaHome)
        End If
    End Sub
End Class