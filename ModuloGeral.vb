Imports System.Linq.Expressions
Imports Guna.UI2.WinForms

Module ModuloGeral
    Dim resp As String
    Private frmAtivo As Form
    Public Sub deslogar()
        resp = MsgBox("Você deseja realmente deslogar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Sair")
        If resp = vbYes Then
            frmLogin.txtUsuario.Text = ""
            frmLogin.txtSenha.Text = ""
            frmLogin.txtUsuario.Focus()
            frmLogin.Show()
            frmAdm.Close()
            tipo_conta = 0
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
    Public Sub FormShow(frm As Form, sidebar As Guna2Panel)
        If frm IsNot frmAtivo Then
            ActiveFormClose()
        End If
        frmAtivo = frm
        frm.TopLevel = False
        sidebar.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub
    Public Sub ActiveFormClose()
        If frmAtivo IsNot Nothing Then
            frmAtivo.Close()
        End If
    End Sub
    Public Sub ActiveButton(frmAtivo As Guna2Button, sidebar As Guna2CustomGradientPanel)
        For Each ctrl As Control In sidebar.Controls
            ctrl.BackColor = Color.Transparent
        Next
        frmAtivo.BackColor = Color.OrangeRed
    End Sub

    Public Sub navegacao(frm As Form)
        Select Case tipo_conta
            Case 1 ' adm
                FormShow(frm, frmAdm.panel_forms)
            Case 2 ' tecnico
                FormShow(frm, frmTecnico.panel_forms)
            Case 3 ' atendente
                FormShow(frm, frmAtendente.panel_forms)
        End Select
    End Sub
End Module
