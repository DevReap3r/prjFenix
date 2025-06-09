Imports System.Linq.Expressions
Imports Guna.UI2.WinForms

Module ModuloGeral
    Dim resp As String
    Public Sub deslogar()
        resp = MsgBox("Você deseja realmente deslogar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Sair")
        If resp = vbYes Then
            frmLogin.txtUsuario.Text = ""
            frmLogin.txtSenha.Text = ""
            frmLogin.txtUsuario.Focus()
            frmLogin.Show()
            frmAdm.Close()
        Else
            Return
        End If
    End Sub
    Public Sub fechar()
        resp = MsgBox("Você deseja realmente fechar o sistema?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Fechar")
        If resp = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Public Sub sidebar_responsividade(sidebar As Guna2CustomGradientPanel, exp As Boolean)
        If exp And sidebar.Width < sidebar.MaximumSize.Width Then
            sidebar.Width += 20
        ElseIf Not exp And sidebar.Width > sidebar.MinimumSize.Width Then
            sidebar.Width -= 20
        End If
    End Sub

End Module
