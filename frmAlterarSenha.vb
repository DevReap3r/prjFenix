Imports MySql.Data.MySqlClient
Public Class frmAlterarSenha
    Public id_usuario As Integer
    Public cargo As String
    Private Sub frmAlterarSenha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSenha.UseSystemPasswordChar = True
        txtConfSenha.UseSystemPasswordChar = True
        chkMostarSenha.Checked = False
    End Sub

    Private Sub chkMostarSenha_Click(sender As Object, e As EventArgs) Handles chkMostarSenha.Click
        If chkMostarSenha.Checked Then
            txtSenha.UseSystemPasswordChar = False
            txtConfSenha.UseSystemPasswordChar = False
        Else
            txtSenha.UseSystemPasswordChar = True
            txtConfSenha.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        fechar()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtSenha.Text = "" Or txtConfSenha.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation, "Atenção")
            Return
        ElseIf txtSenha.Text <> txtConfSenha.Text Then
            MsgBox("As senhas não coincidem!", MsgBoxStyle.Exclamation, "Atenção")
            Return
        ElseIf txtSenha.Text.Length < 8 Then
            MsgBox("A senha deve ter pelo menos 8 caracteres!", MsgBoxStyle.Exclamation, "Atenção")
            Return
        Else
            Try
                db.Open()
                Dim cmd As New MySqlCommand("UPDATE tb_usuario SET senha = @senha, senha_temporaria = 0 WHERE id_usuario = @id_usuario", db)
                cmd.Parameters.AddWithValue("@senha", ModuloCriptografia.CriptografarSenha(txtSenha.Text))
                cmd.Parameters.AddWithValue("@id_usuario", id_usuario)
                cmd.ExecuteNonQuery()
                MsgBox("Senha alterada com sucesso!", MsgBoxStyle.Information, "Sucesso")
                db.Close()
                acesso(cargo)
                Me.Close()
            Catch ex As Exception
                MsgBox("Erro ao alterar a senha: " & ex.Message, MsgBoxStyle.Critical, "Erro")
                db.Close()
            End Try
        End If
    End Sub
End Class