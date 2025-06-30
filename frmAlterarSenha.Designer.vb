<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlterarSenha
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.txtSenha = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSalvar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.chkMostarSenha = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.btnFechar = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtConfSenha = New Guna.UI2.WinForms.Guna2TextBox()
        Me.msbAlterarSenha = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        CType(Me.btnFechar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtSenha)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnSalvar)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.chkMostarSenha)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnFechar)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtConfSenha)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Gold
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Red
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(311, 484)
        Me.Guna2CustomGradientPanel1.TabIndex = 1
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
        Me.txtSenha.Location = New System.Drawing.Point(20, 141)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txtSenha.PlaceholderText = "Nova senha"
        Me.txtSenha.SelectedText = ""
        Me.txtSenha.Size = New System.Drawing.Size(272, 36)
        Me.txtSenha.TabIndex = 1
        '
        'btnSalvar
        '
        Me.btnSalvar.Animated = True
        Me.btnSalvar.AutoRoundedCorners = True
        Me.btnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.BorderColor = System.Drawing.Color.Transparent
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSalvar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSalvar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSalvar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSalvar.FillColor = System.Drawing.Color.White
        Me.btnSalvar.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.btnSalvar.ForeColor = System.Drawing.Color.Red
        Me.btnSalvar.Location = New System.Drawing.Point(20, 288)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(272, 34)
        Me.btnSalvar.TabIndex = 3
        Me.btnSalvar.Text = "Salvar"
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
        'txtConfSenha
        '
        Me.txtConfSenha.Animated = True
        Me.txtConfSenha.AutoRoundedCorners = True
        Me.txtConfSenha.BackColor = System.Drawing.Color.Transparent
        Me.txtConfSenha.BorderColor = System.Drawing.Color.White
        Me.txtConfSenha.BorderThickness = 0
        Me.txtConfSenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfSenha.DefaultText = ""
        Me.txtConfSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfSenha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConfSenha.ForeColor = System.Drawing.Color.Black
        Me.txtConfSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfSenha.IconLeft = Global.SmartOS.My.Resources.Resources.cadeado
        Me.txtConfSenha.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtConfSenha.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtConfSenha.Location = New System.Drawing.Point(20, 192)
        Me.txtConfSenha.Name = "txtConfSenha"
        Me.txtConfSenha.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txtConfSenha.PlaceholderText = "Confirme a senha"
        Me.txtConfSenha.SelectedText = ""
        Me.txtConfSenha.Size = New System.Drawing.Size(272, 36)
        Me.txtConfSenha.TabIndex = 2
        '
        'msbAlterarSenha
        '
        Me.msbAlterarSenha.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.msbAlterarSenha.Caption = Nothing
        Me.msbAlterarSenha.Icon = Guna.UI2.WinForms.MessageDialogIcon.None
        Me.msbAlterarSenha.Parent = Nothing
        Me.msbAlterarSenha.Style = Guna.UI2.WinForms.MessageDialogStyle.[Default]
        Me.msbAlterarSenha.Text = Nothing
        '
        'frmAlterarSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(311, 484)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAlterarSenha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        CType(Me.btnFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents txtConfSenha As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnFechar As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents chkMostarSenha As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnSalvar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents msbAlterarSenha As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents txtSenha As Guna.UI2.WinForms.Guna2TextBox
End Class
