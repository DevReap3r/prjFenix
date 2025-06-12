Public Class frmAdicionarServicosModelo
    Dim resp As String
    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        resp = MsgBox("Você deseja sair sem salvar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Fechar")
        If resp = vbYes Then
            navegacao(frmConsultaModelo)
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
            navegacao(frmConsultaModelo)
        Else
            Return
        End If
    End Sub
End Class