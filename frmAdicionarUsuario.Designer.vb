<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdicionarUsuario
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
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.cmbMarca = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSalvar = New Guna.UI2.WinForms.Guna2Button()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnFechar = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = Global.SmartOS.My.Resources.Resources.voltar
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(6, 8)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 8
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.cmbMarca)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2TextBox1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnCancelar)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnSalvar)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtEmail)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtUsuario)
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Gold
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Red
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(182, 54)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(321, 341)
        Me.Guna2CustomGradientPanel1.TabIndex = 7
        '
        'cmbMarca
        '
        Me.cmbMarca.AutoRoundedCorners = True
        Me.cmbMarca.BackColor = System.Drawing.Color.Transparent
        Me.cmbMarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMarca.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMarca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMarca.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbMarca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbMarca.ItemHeight = 30
        Me.cmbMarca.Items.AddRange(New Object() {"Administrador", "Técnico", "Atendente"})
        Me.cmbMarca.Location = New System.Drawing.Point(29, 159)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(262, 36)
        Me.cmbMarca.TabIndex = 7
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Animated = True
        Me.Guna2TextBox1.AutoRoundedCorners = True
        Me.Guna2TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(31, 117)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TextBox1.PlaceholderText = "Digite o telefone"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(262, 36)
        Me.Guna2TextBox1.TabIndex = 6
        '
        'btnCancelar
        '
        Me.btnCancelar.Animated = True
        Me.btnCancelar.AutoRoundedCorners = True
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancelar.FillColor = System.Drawing.Color.Transparent
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(31, 289)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(260, 45)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseTransparentBackground = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Animated = True
        Me.btnSalvar.AutoRoundedCorners = True
        Me.btnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSalvar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSalvar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSalvar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSalvar.FillColor = System.Drawing.Color.OrangeRed
        Me.btnSalvar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSalvar.ForeColor = System.Drawing.Color.White
        Me.btnSalvar.Location = New System.Drawing.Point(31, 238)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(260, 45)
        Me.btnSalvar.TabIndex = 4
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseTransparentBackground = True
        '
        'txtEmail
        '
        Me.txtEmail.Animated = True
        Me.txtEmail.AutoRoundedCorners = True
        Me.txtEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(31, 75)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtEmail.PlaceholderText = "Digite o email"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(262, 36)
        Me.txtEmail.TabIndex = 3
        '
        'txtUsuario
        '
        Me.txtUsuario.Animated = True
        Me.txtUsuario.AutoRoundedCorners = True
        Me.txtUsuario.BackColor = System.Drawing.Color.Transparent
        Me.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsuario.DefaultText = ""
        Me.txtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsuario.Location = New System.Drawing.Point(29, 33)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtUsuario.PlaceholderText = "Digite o usuário"
        Me.txtUsuario.SelectedText = ""
        Me.txtUsuario.Size = New System.Drawing.Size(262, 36)
        Me.txtUsuario.TabIndex = 2
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.Color.Transparent
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.FillColor = System.Drawing.Color.Transparent
        Me.btnFechar.Image = Global.SmartOS.My.Resources.Resources.fechar
        Me.btnFechar.ImageRotate = 0!
        Me.btnFechar.Location = New System.Drawing.Point(647, 8)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(24, 24)
        Me.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnFechar.TabIndex = 9
        Me.btnFechar.TabStop = False
        Me.btnFechar.UseTransparentBackground = True
        '
        'frmAdicionarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(677, 481)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Controls.Add(Me.btnFechar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAdicionarUsuario"
        Me.Text = "frmAdicionarUsuario"
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        CType(Me.btnFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents btnCancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSalvar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUsuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnFechar As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbMarca As Guna.UI2.WinForms.Guna2ComboBox
End Class
