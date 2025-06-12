<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btnEsqueceuSenha = New System.Windows.Forms.LinkLabel()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.chkMostarSenha = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.btnFechar = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtSenha = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.msbLogin = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        CType(Me.btnFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.TargetForm = Me
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnEsqueceuSenha)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnLogin)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.chkMostarSenha)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnFechar)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtSenha)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtUsuario)
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Gold
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Red
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(455, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(312, 483)
        Me.Guna2CustomGradientPanel1.TabIndex = 1
        '
        'btnEsqueceuSenha
        '
        Me.btnEsqueceuSenha.AutoSize = True
        Me.btnEsqueceuSenha.BackColor = System.Drawing.Color.Transparent
        Me.btnEsqueceuSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEsqueceuSenha.LinkColor = System.Drawing.Color.White
        Me.btnEsqueceuSenha.Location = New System.Drawing.Point(80, 447)
        Me.btnEsqueceuSenha.Name = "btnEsqueceuSenha"
        Me.btnEsqueceuSenha.Size = New System.Drawing.Size(154, 18)
        Me.btnEsqueceuSenha.TabIndex = 6
        Me.btnEsqueceuSenha.TabStop = True
        Me.btnEsqueceuSenha.Text = "Esqueceu sua senha?"
        '
        'btnLogin
        '
        Me.btnLogin.Animated = True
        Me.btnLogin.AutoRoundedCorners = True
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BorderColor = System.Drawing.Color.Transparent
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.Color.White
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.btnLogin.ForeColor = System.Drawing.Color.Red
        Me.btnLogin.Location = New System.Drawing.Point(20, 288)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(272, 34)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Entrar"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(49, 236)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(101, 18)
        Me.Guna2HtmlLabel1.TabIndex = 4
        Me.Guna2HtmlLabel1.Text = "Mostrar senha"
        '
        'chkMostarSenha
        '
        Me.chkMostarSenha.BackColor = System.Drawing.Color.Transparent
        Me.chkMostarSenha.CheckedState.BorderColor = System.Drawing.Color.White
        Me.chkMostarSenha.CheckedState.BorderRadius = 2
        Me.chkMostarSenha.CheckedState.BorderThickness = 0
        Me.chkMostarSenha.CheckedState.FillColor = System.Drawing.Color.Silver
        Me.chkMostarSenha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkMostarSenha.Location = New System.Drawing.Point(28, 237)
        Me.chkMostarSenha.Name = "chkMostarSenha"
        Me.chkMostarSenha.Size = New System.Drawing.Size(16, 16)
        Me.chkMostarSenha.TabIndex = 3
        Me.chkMostarSenha.Text = "Guna2CustomCheckBox1"
        Me.chkMostarSenha.UncheckedState.BorderColor = System.Drawing.Color.White
        Me.chkMostarSenha.UncheckedState.BorderRadius = 2
        Me.chkMostarSenha.UncheckedState.BorderThickness = 0
        Me.chkMostarSenha.UncheckedState.FillColor = System.Drawing.Color.White
        Me.chkMostarSenha.UseTransparentBackground = True
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.Color.Transparent
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.FillColor = System.Drawing.Color.Transparent
        Me.btnFechar.Image = Global.SmartOS.My.Resources.Resources.fechar
        Me.btnFechar.ImageRotate = 0!
        Me.btnFechar.Location = New System.Drawing.Point(283, 5)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(24, 24)
        Me.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnFechar.TabIndex = 2
        Me.btnFechar.TabStop = False
        Me.btnFechar.UseTransparentBackground = True
        '
        'txtSenha
        '
        Me.txtSenha.Animated = True
        Me.txtSenha.AutoRoundedCorners = True
        Me.txtSenha.BackColor = System.Drawing.Color.Transparent
        Me.txtSenha.BorderColor = System.Drawing.Color.White
        Me.txtSenha.BorderThickness = 0
        Me.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSenha.DefaultText = ""
        Me.txtSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSenha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSenha.ForeColor = System.Drawing.Color.Black
        Me.txtSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSenha.IconLeft = Global.SmartOS.My.Resources.Resources.cadeado
        Me.txtSenha.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtSenha.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtSenha.Location = New System.Drawing.Point(20, 192)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtSenha.PlaceholderText = "Senha"
        Me.txtSenha.SelectedText = ""
        Me.txtSenha.Size = New System.Drawing.Size(272, 36)
        Me.txtSenha.TabIndex = 1
        '
        'txtUsuario
        '
        Me.txtUsuario.Animated = True
        Me.txtUsuario.AutoRoundedCorners = True
        Me.txtUsuario.BackColor = System.Drawing.Color.Transparent
        Me.txtUsuario.BorderColor = System.Drawing.Color.White
        Me.txtUsuario.BorderThickness = 0
        Me.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsuario.DefaultText = ""
        Me.txtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUsuario.ForeColor = System.Drawing.Color.Black
        Me.txtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsuario.IconLeft = Global.SmartOS.My.Resources.Resources.sombra_de_usuario_masculino
        Me.txtUsuario.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtUsuario.Location = New System.Drawing.Point(20, 135)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtUsuario.PlaceholderText = "Usúario"
        Me.txtUsuario.SelectedText = ""
        Me.txtUsuario.Size = New System.Drawing.Size(272, 36)
        Me.txtUsuario.TabIndex = 0
        '
        'msbLogin
        '
        Me.msbLogin.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.msbLogin.Caption = Nothing
        Me.msbLogin.Icon = Guna.UI2.WinForms.MessageDialogIcon.None
        Me.msbLogin.Parent = Nothing
        Me.msbLogin.Style = Guna.UI2.WinForms.MessageDialogStyle.[Default]
        Me.msbLogin.Text = Nothing
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Image = Global.SmartOS.My.Resources.Resources._7610204_flying_phoenix_firebird_abstrato_logo_design_vector_template_vetor
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(1, -62)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(454, 480)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 2
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(768, 484)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        CType(Me.btnFechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents txtUsuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents txtSenha As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnFechar As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents chkMostarSenha As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEsqueceuSenha As LinkLabel
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents msbLogin As Guna.UI2.WinForms.Guna2MessageDialog
End Class
