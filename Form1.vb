﻿Imports System.Web.UI.WebControls

Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSenha.UseSystemPasswordChar = True
        chkMostarSenha.Checked = False
    End Sub
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        fechar()
    End Sub
    Private Sub chkMostarSenha_Click(sender As Object, e As EventArgs) Handles chkMostarSenha.Click
        If chkMostarSenha.Checked Then
            txtSenha.UseSystemPasswordChar = False
        Else
            txtSenha.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub btnEsqueceuSenha_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnEsqueceuSenha.LinkClicked
        MsgBox("Contacte o administrador do sistema.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Recuperação de senha")
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            db.Open()
        Catch ex As Exception
            MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If txtSenha.Text = "" Or txtUsuario.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation, "Atenção")
            Return
        Else
            Try
                login(txtUsuario.Text, txtSenha.Text)
                chkMostarSenha.Checked = False
                txtSenha.UseSystemPasswordChar = True
            Catch ex As Exception

            End Try
        End If
    End Sub


End Class
