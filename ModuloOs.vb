Imports MySql.Data.MySqlClient

Module ModuloOs
    Public Function GetOrdem(filtro As String, pesquisa As String) As DataTable
        Try
            Dim dt As New DataTable()
            Dim sql As String = "select id_os as 'ORDEM DE SERVIÇO', tb_cliente.nome_cliente AS CLIENTE, tb_status_os.descricao AS STATUS from tb_os inner join tb_cliente on tb_os.id_cliente = tb_cliente.id_cliente inner join tb_status_os on tb_os.id_status = tb_status_os.id_status"
            If filtro <> "" Then
                If pesquisa = "nome" Then
                    sql &= " WHERE tb_cliente.nome_cliente LIKE '%" & filtro & "'"
                Else
                    sql &= " WHERE id_os LIKE '%" & filtro & "%'"
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
            MsgBox("Erro ao carregar as ordens de serviço: " & ex.Message, MsgBoxStyle.Critical, "Erro")
            Return Nothing
        End Try
    End Function
End Module
