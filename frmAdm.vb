﻿Public Class frmAdm
    Dim expend As Boolean

    Private Sub frmAdm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActiveButton(btnConsulta, sidebarAdm)
        FormShow(frmConsultaHome, panel_forms)
    End Sub
    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        fechar()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        deslogar()
    End Sub

    Private Sub btnSidebar_Click(sender As Object, e As EventArgs) Handles btnSidebar.Click
        sidebarTimerAdm.Start()
        If sidebarAdm.Width = sidebarAdm.MinimumSize.Width Then
            expend = True
        ElseIf sidebarAdm.Width = sidebarAdm.MaximumSize.Width Then
            expend = False
        End If
    End Sub

    Private Sub sidebarTimerAdm_Tick(sender As Object, e As EventArgs) Handles sidebarTimerAdm.Tick
        sidebar_responsividade(sidebarAdm, expend)
    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        btnConsulta.FillColor = Color.OrangeRed
        btnUsuarios.FillColor = Color.Transparent
        btnOs.FillColor = Color.Transparent
        btnClientes.FillColor = Color.Transparent
        ActiveButton(btnConsulta, sidebarAdm)
        FormShow(frmConsultaHome, panel_forms)
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        btnUsuarios.FillColor = Color.OrangeRed
        btnConsulta.FillColor = Color.Transparent
        btnOs.FillColor = Color.Transparent
        btnClientes.FillColor = Color.Transparent
        ActiveButton(btnConsulta, sidebarAdm)
        FormShow(frmUsuarios, panel_forms)
    End Sub

    Private Sub btnOs_Click(sender As Object, e As EventArgs) Handles btnOs.Click
        btnOs.FillColor = Color.OrangeRed
        btnUsuarios.FillColor = Color.Transparent
        btnConsulta.FillColor = Color.Transparent
        btnClientes.FillColor = Color.Transparent
        ActiveButton(btnOs, sidebarAdm)
        FormShow(frmOs, panel_forms)
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        btnClientes.FillColor = Color.OrangeRed
        btnUsuarios.FillColor = Color.Transparent
        btnOs.FillColor = Color.Transparent
        btnConsulta.FillColor = Color.Transparent
        ActiveButton(btnClientes, sidebarAdm)
        FormShow(frmClientes, panel_forms)
    End Sub

    Private Sub panel_forms_Paint(sender As Object, e As PaintEventArgs) Handles panel_forms.Paint

    End Sub

    Private Sub sidebarAdm_Paint(sender As Object, e As PaintEventArgs) Handles sidebarAdm.Paint

    End Sub
End Class