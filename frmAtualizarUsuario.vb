Imports MySql.Data.MySqlClient
Public Class frmAtualizarUsuario
    Public usuario, resp As String
    Dim id_usuario As Integer
    Private Sub frmAtualizarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New MySqlCommand("select id_usuario,usuario,id_cargo,ativado from tb_usuario where usuario = @usuario", db)
        cmd.Parameters.AddWithValue("@usuario", UCase(usuario))
        Try
            db.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                id_usuario = Convert.ToInt32(reader("id_usuario"))
                txtUsuario.Text = reader("usuario").ToString()
                Dim id_cargo = Convert.ToInt32(reader("id_cargo"))
                If id_cargo = 1 Then
                    cmbCargo.SelectedIndex = 0 ' Administrador
                ElseIf id_cargo = 2 Then
                    cmbCargo.SelectedIndex = 1 ' Técnico
                Else
                    cmbCargo.SelectedIndex = 2 ' Atendente
                End If
                If Convert.ToBoolean(reader("ativado")) Then
                    cmbStatus.SelectedIndex = 0 ' Ativo
                Else
                    cmbStatus.SelectedIndex = 1 ' Inativo
                End If
                db.Close()
            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar os dados do usuário: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            db.Open()
            Dim cmd As New MySqlCommand("UPDATE tb_usuario SET usuario = @usuario, id_cargo = @cargo, ativado = @ativo WHERE id_usuario = @id_usuario", db)
            cmd.Parameters.AddWithValue("@usuario", UCase(txtUsuario.Text))
            Dim id_cargo As Integer = cmbCargo.SelectedIndex + 1
            cmd.Parameters.AddWithValue("@cargo", id_cargo)
            cmd.Parameters.AddWithValue("@ativo", cmbStatus.SelectedIndex = 0)
            cmd.Parameters.AddWithValue("@id_usuario", id_usuario)
            cmd.ExecuteNonQuery()
            db.Close()
            MsgBox("Usuário atualizado com sucesso!", MsgBoxStyle.Information, "Sucesso")
            navegacao(frmUsuarios)
        Catch ex As Exception
            MsgBox("Erro ao atualizar o usuário: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        fechar()
    End Sub

    Private Sub btnEsqueceuSenha_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnEsqueceuSenha.LinkClicked
        resp = MsgBox("Você deseja redefinir a senha do usuário " + txtUsuario.Text + "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Redefinir senha")
        If resp = vbYes Then
            Dim senha As String = gerarSenha()
            Try
                db.Open()
                Dim cmd As New MySqlCommand("UPDATE tb_usuario SET senha = @senha, senha_temporaria = 1 WHERE id_usuario = @id_usuario", db)
                cmd.Parameters.AddWithValue("@senha", CriptografarSenha(senha))
                cmd.Parameters.AddWithValue("@id_usuario", id_usuario)
                cmd.ExecuteNonQuery()
                db.Close()
                MsgBox("Senha redefinida com sucesso!" + vbNewLine + "A nova senha temporária é: " + senha, MsgBoxStyle.Information, "Sucesso")
                navegacao(frmUsuarios)
            Catch ex As Exception
                MsgBox("Erro ao redefinir a senha: " & ex.Message, MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        resp = MsgBox("Você deseja sair sem salvar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Fechar")
        If resp = vbYes Then
            navegacao(frmUsuarios)
        Else
            Return
        End If
    End Sub
End Class