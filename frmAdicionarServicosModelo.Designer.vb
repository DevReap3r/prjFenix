<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdicionarServicosModelo
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
        Me.btnFechar = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btnCancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSalvar = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbTipo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtPreco = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDesc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.btnFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
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
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.Color.Transparent
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.FillColor = System.Drawing.Color.Transparent
        Me.btnFechar.Image = Global.SmartOS.My.Resources.Resources.fechar
        Me.btnFechar.ImageRotate = 0!
        Me.btnFechar.Location = New System.Drawing.Point(641, 9)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(24, 24)
        Me.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnFechar.TabIndex = 9
        Me.btnFechar.TabStop = False
        Me.btnFechar.UseTransparentBackground = True
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = Global.SmartOS.My.Resources.Resources.voltar
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(12, 9)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 8
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnCancelar)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnSalvar)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.cmbTipo)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtPreco)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtDesc)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Gold
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Red
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(182, 55)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(321, 341)
        Me.Guna2CustomGradientPanel1.TabIndex = 7
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
        Me.btnSalvar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.Color.White
        Me.btnSalvar.Location = New System.Drawing.Point(31, 238)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(260, 45)
        Me.btnSalvar.TabIndex = 4
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseTransparentBackground = True
        '
        'cmbTipo
        '
        Me.cmbTipo.AutoRoundedCorners = True
        Me.cmbTipo.BackColor = System.Drawing.Color.Transparent
        Me.cmbTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbTipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbTipo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbTipo.ItemHeight = 30
        Me.cmbTipo.Location = New System.Drawing.Point(29, 72)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(262, 36)
        Me.cmbTipo.TabIndex = 0
        '
        'txtPreco
        '
        Me.txtPreco.Animated = True
        Me.txtPreco.AutoRoundedCorners = True
        Me.txtPreco.BackColor = System.Drawing.Color.Transparent
        Me.txtPreco.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPreco.DefaultText = ""
        Me.txtPreco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPreco.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPreco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPreco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPreco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPreco.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPreco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPreco.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPreco.Location = New System.Drawing.Point(29, 181)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtPreco.PlaceholderText = "Digite o preço do serviço"
        Me.txtPreco.SelectedText = ""
        Me.txtPreco.Size = New System.Drawing.Size(262, 36)
        Me.txtPreco.TabIndex = 3
        '
        'txtDesc
        '
        Me.txtDesc.Animated = True
        Me.txtDesc.AutoRoundedCorners = True
        Me.txtDesc.BackColor = System.Drawing.Color.Transparent
        Me.txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDesc.DefaultText = ""
        Me.txtDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDesc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDesc.Location = New System.Drawing.Point(29, 124)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtDesc.PlaceholderText = "Digite a descrição do serviço"
        Me.txtDesc.SelectedText = ""
        Me.txtDesc.Size = New System.Drawing.Size(262, 36)
        Me.txtDesc.TabIndex = 2
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(31, 39)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(150, 27)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "Tipo do serviço"
        '
        'frmAdicionarServicosModelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(677, 481)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAdicionarServicosModelo"
        Me.Text = "frmAdicionarServicosModelo"
        CType(Me.btnFechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents btnFechar As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents btnCancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSalvar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbTipo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtPreco As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDesc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
