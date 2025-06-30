Imports MySql.Data.MySqlClient
Module ModuloUsuario
    Public Function GetUsuarios(filtro As String, pesquisa As String) As DataTable
        Try
            Dim dt As New DataTable()
            Dim sql As String = "SELECT tb_usuario.usuario as USUARIO, tb_cargo.nome_cargo AS CARGO,tb_usuario.ativado AS ATIVADO,tb_usuario.senha_temporaria AS 'SENHA TEMPORÁRIA' FROM tb_usuario inner join tb_cargo on tb_usuario.id_cargo = tb_cargo.id_cargo"
            If filtro <> "" Then
                If pesquisa = "cargo" Then
                    sql &= " WHERE tb_cargo.nome_cargo LIKE '%" & filtro & "'"
                Else
                    sql &= " WHERE tb_usuario.usuario LIKE '%" & filtro & "%'"
                End If
            End If
            db.Open()
            Dim cmd As New MySqlCommand(sql, db)
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                dt.Load(reader)
            End Using
            db.Close()
            Return dt
        Catch ex As Exception
            MsgBox("Erro ao carregar os usuários: " & ex.Message, MsgBoxStyle.Critical, "Erro")
            Return Nothing
        End Try
    End Function
    Public Function gerarSenha() As String
        Dim chars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim senha As New System.Text.StringBuilder()
        Dim rand As New Random()
        For i As Integer = 1 To 8
            senha.Append(chars(rand.Next(chars.Length)))
        Next
        Return senha.ToString()
    End Function
    Public Function adicionarUsuario(usuario As String, cargo As String, senha As String) As Boolean
        Dim c As Integer
        If cargo = "ADMINISTRADOR" Then
            c = 1
        ElseIf cargo = "TÉCNICO" Then
            c = 2
        Else
            c = 3
        End If
        Try
            If verificarUsuarioExistente(usuario) Then
                MsgBox("Usuário já existe!", MsgBoxStyle.Exclamation, "Atenção")
                Return False
            Else
                db.Open()
                Dim cmd As New MySqlCommand("INSERT INTO tb_usuario (usuario, id_cargo, senha, ativado, senha_temporaria) VALUES (@usuario, @cargo, @senha, 1, 1)", db)
                cmd.Parameters.AddWithValue("@usuario", UCase(usuario))
                cmd.Parameters.AddWithValue("@cargo", c)
                cmd.Parameters.AddWithValue("@senha", CriptografarSenha(senha))
                cmd.ExecuteNonQuery()
                MsgBox("Usuário adicionado com sucesso!" + vbNewLine + "A senha temporária é: " + senha, MsgBoxStyle.Information, "Sucesso")
                db.Close()
                Return True
            End If
        Catch ex As Exception
            MsgBox("Erro ao adicionar usuário: " & ex.Message, MsgBoxStyle.Critical, "Erro")
            db.Close()
            Return False
        End Try
    End Function
    Public Function verificarUsuarioExistente(usuario As String) As Boolean
        Try
            db.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM tb_usuario WHERE usuario = @usuario", db)
            cmd.Parameters.AddWithValue("@usuario", UCase(usuario))
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            db.Close()
            Return count > 0
        Catch ex As Exception
            MsgBox("Erro ao verificar usuário: " & ex.Message, MsgBoxStyle.Critical, "Erro")
            db.Close()
            Return False
        End Try
    End Function


End Module
