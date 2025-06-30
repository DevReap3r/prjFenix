Imports MySql.Data.MySqlClient
Module ModuloLogin
    Public tipo_conta As Integer
    Public admin As Boolean = False
    Public Sub login(user As String, senha As String)
        Dim cmd = New MySqlCommand("select tb_usuario.id_usuario,tb_cargo.nome_cargo,tb_usuario.ativado,tb_usuario.senha_temporaria from tb_usuario inner join tb_cargo on tb_usuario.id_cargo = tb_cargo.id_cargo where usuario = @usuario and senha = @senha", db)
        cmd.Parameters.AddWithValue("usuario", UCase(user))
        cmd.Parameters.AddWithValue("senha", CriptografarSenha(senha))
        reader = cmd.ExecuteReader()
        If reader.Read Then
            If Not reader("ativado") Then
                MsgBox("Usuário Bloqueado, contate o administrador do sistema!", MsgBoxStyle.Exclamation, "Atenção")
                db.Close()
                Return
            Else
                If reader("senha_temporaria") Then
                    MsgBox("Você está logando com uma senha temporária, por favor altere sua senha!", MsgBoxStyle.Information, "Atenção")
                    frmAlterarSenha.Show()
                    frmAlterarSenha.id_usuario = reader("id_usuario")
                    frmAlterarSenha.cargo = reader("nome_cargo")
                    db.Close()
                    frmLogin.Hide()
                Else
                    acesso(reader("nome_cargo"))
                    frmLogin.Hide()
                End If
            End If
            Return
        Else
            MsgBox("Usuário ou senha inválidos!", MsgBoxStyle.Exclamation, "Atenção")
            db.Close()
        End If
    End Sub

    Public Sub acesso(cargo As String)
        db.Close()
        If cargo = "Adm" Then
            tipo_conta = 1
            admin = True
            frmAdm.Show()
        ElseIf cargo = "Técnico" Then
            tipo_conta = 2
            frmTecnico.Show()
        Else
            tipo_conta = 3
            frmAtendente.Show()
        End If
    End Sub
End Module
