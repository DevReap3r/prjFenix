Module ModuloLogin
    Public Sub login(user As String, senha As String)
        If user = "admin" And senha = "1234" Then
            frmAdm.Show()
            frmLogin.Hide()
        ElseIf user = "tecnico" And senha = "1234" Then
            frmTecnico.Show()
            frmLogin.Hide()
        ElseIf user = "atendente" And senha = "1234" Then
            frmAtendente.Show()
            frmLogin.Hide()
        Else
            MsgBox("Usuário ou senha incorretos!", MsgBoxStyle.Critical, "Erro")
        End If
    End Sub
End Module
