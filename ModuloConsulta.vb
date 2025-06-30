Imports MySql.Data.MySqlClient
Module ModuloConsulta
    Public Function getModelos(filtro As String, pesquisa As String) As DataTable
        Try
            Dim dt As New DataTable()
            Dim sql As String = "SELECT tb_modelo.nome_modelo as MODELO, tb_marca.nome_marca AS MARCA, tb_modelo.cod_modelo AS CÓDIGO from tb_modelo inner join tb_marca on tb_modelo.id_marca = tb_marca.id_marca"
            If filtro <> "" Then
                If pesquisa = "marca" Then
                    sql &= " WHERE tb_marca.nome_marca LIKE '%" & filtro & "'"
                ElseIf pesquisa = "código" Then
                    sql &= " WHERE tb_modelo.cod_modelo LIKE '%" & filtro & "%'"
                Else
                    sql &= " WHERE tb_modelo.nome_modelo LIKE '%" & filtro & "%'"
                End If
            End If
            db.Open()
            Dim cmd As New MySqlCommand(sql, db)
            Using r As MySqlDataReader = cmd.ExecuteReader()
                dt.Load(r)
            End Using

            db.Close()
            Return dt
        Catch ex As Exception
            MsgBox("Erro ao carregar os modelos: " & ex.Message, MsgBoxStyle.Critical, "Erro")
            Return Nothing
        End Try
    End Function
    Public Function getManutencao(filtro As String, modelo As Integer) As DataTable
        Try
            Dim dt As New DataTable()
            Dim sql As String = "SELECT tb_tipo_servico.descricao AS TIPO, tb_manutencao.descricao AS DESCRIÇÃO, tb_manutencao.valor_final AS PREÇO, tb_manutencao.risco_tela AS 'RISCO DE TELA' from tb_manutencao inner join tb_tipo_servico on tb_manutencao.id_tipo = tb_tipo_servico.id_tipo where id_modelo = '" & modelo & "'"
            If filtro <> "" Then
                sql &= " and tb_tipo_servico.descricao LIKE '%" & filtro & "'"
            End If
            db.Open()
            Dim cmd As New MySqlCommand(sql, db)
            Using r As MySqlDataReader = cmd.ExecuteReader()
                dt.Load(r)
            End Using

            db.Close()
            Return dt
        Catch ex As Exception
            MsgBox("Erro ao carregar as manutenções: " & ex.Message, MsgBoxStyle.Critical, "Erro")
            Return Nothing
        End Try
    End Function
    Public Function adicionarModelo(modelo As String, marca As String, cod As String) As Boolean
        Dim c As Integer
        If marca = "SAMSUNG" Then
            c = 1
        ElseIf marca = "APPLE" Then
            c = 2
        ElseIf marca = "MOTOROLA" Then
            c = 3
        Else
            c = 4
        End If
        Try
            If verificarModeloExistente(modelo) Then
                MsgBox("Modelo já cadastrado!", MsgBoxStyle.Exclamation, "Atenção")
                Return False
            Else
                db.Open()
                Dim cmd As New MySqlCommand("INSERT INTO tb_modelo (nome_modelo,cod_modelo, id_marca) VALUES (@modelo, @cod, @marca)", db)
                cmd.Parameters.AddWithValue("@modelo", UCase(modelo))
                cmd.Parameters.AddWithValue("@cod", UCase(cod))
                cmd.Parameters.AddWithValue("@marca", c)
                cmd.ExecuteNonQuery()
                MsgBox("Modelo adicionado com sucesso!", MsgBoxStyle.Information, "Sucesso")
                db.Close()
                Return True
            End If
        Catch ex As Exception
            MsgBox("Erro ao adicionar modelo: " & ex.Message, MsgBoxStyle.Critical, "Erro")
            db.Close()
            Return False
        End Try
    End Function
    Public Function verificarModeloExistente(modelo As String) As Boolean
        Try
            db.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM tb_modelo WHERE nome_modelo = @modelo", db)
            cmd.Parameters.AddWithValue("@modelo", UCase(modelo))
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            db.Close()
            Return count > 0
        Catch ex As Exception
            MsgBox("Erro ao verificar modelo: " & ex.Message, MsgBoxStyle.Critical, "Erro")
            db.Close()
            Return False
        End Try
    End Function
End Module
