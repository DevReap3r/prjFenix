﻿Public Class frmOs
    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        fechar()
    End Sub

    Private Sub frmOs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If admin Then
            btnAdd.Visible = True
        Else
            btnAdd.Visible = False
        End If
        datagridOs.DataSource = ModuloOs.GetOrdem("", "")

    End Sub
End Class