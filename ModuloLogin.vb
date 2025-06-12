Module ModuloLogin
    Public tipo_conta As Integer
    Public Sub login(user As String, senha As String)
        If user = "admin" And senha = "1234" Then
            tipo_conta = 1
            frmAdm.Show()
            frmLogin.Hide()
        ElseIf user = "tecnico" And senha = "1234" Then
            tipo_conta = 2
            frmTecnico.Show()
            frmLogin.Hide()
        ElseIf user = "atendente" And senha = "1234" Then
            tipo_conta = 3
            frmAtendente.Show()
            frmLogin.Hide()
        Else
            MsgBox("Usuário ou senha incorretos!", MsgBoxStyle.Critical, "Erro")
        End If
    End Sub
End Module
