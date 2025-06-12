<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAtendente
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
        Me.sidebarAtendente = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClientes = New Guna.UI2.WinForms.Guna2Button()
        Me.btnOs = New Guna.UI2.WinForms.Guna2Button()
        Me.btnConsulta = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnSidebar = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblClientes = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblOs = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblUsuarios = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.sidebarTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.panel_forms = New Guna.UI2.WinForms.Guna2Panel()
        Me.sidebarAtendente.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.btnSidebar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'sidebarAtendente
        '
        Me.sidebarAtendente.Controls.Add(Me.btnLogout)
        Me.sidebarAtendente.Controls.Add(Me.btnClientes)
        Me.sidebarAtendente.Controls.Add(Me.btnOs)
        Me.sidebarAtendente.Controls.Add(Me.btnConsulta)
        Me.sidebarAtendente.Controls.Add(Me.Guna2Panel1)
        Me.sidebarAtendente.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidebarAtendente.FillColor = System.Drawing.Color.Gold
        Me.sidebarAtendente.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sidebarAtendente.FillColor3 = System.Drawing.Color.Red
        Me.sidebarAtendente.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sidebarAtendente.Location = New System.Drawing.Point(0, 0)
        Me.sidebarAtendente.MaximumSize = New System.Drawing.Size(227, 0)
        Me.sidebarAtendente.MinimumSize = New System.Drawing.Size(59, 0)
        Me.sidebarAtendente.Name = "sidebarAtendente"
        Me.sidebarAtendente.Size = New System.Drawing.Size(59, 481)
        Me.sidebarAtendente.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Animated = True
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FillColor = System.Drawing.Color.Transparent
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = Global.SmartOS.My.Resources.Resources.opcao_de_sair
        Me.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnLogout.Location = New System.Drawing.Point(0, 432)
        Me.btnLogout.MinimumSize = New System.Drawing.Size(227, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(227, 49)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Sair"
        Me.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.UseTransparentBackground = True
        '
        'btnClientes
        '
        Me.btnClientes.Animated = True
        Me.btnClientes.BackColor = System.Drawing.Color.Transparent
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClientes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClientes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClientes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClientes.FillColor = System.Drawing.Color.Transparent
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.btnClientes.ForeColor = System.Drawing.Color.White
        Me.btnClientes.HoverState.Image = Global.SmartOS.My.Resources.Resources.cliente__2_
        Me.btnClientes.Image = Global.SmartOS.My.Resources.Resources.cliente__3_
        Me.btnClientes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnClientes.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnClientes.Location = New System.Drawing.Point(0, 158)
        Me.btnClientes.MinimumSize = New System.Drawing.Size(227, 0)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(227, 49)
        Me.btnClientes.TabIndex = 4
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnClientes.UseTransparentBackground = True
        '
        'btnOs
        '
        Me.btnOs.Animated = True
        Me.btnOs.BackColor = System.Drawing.Color.Transparent
        Me.btnOs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOs.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnOs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnOs.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnOs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnOs.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOs.FillColor = System.Drawing.Color.Transparent
        Me.btnOs.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.btnOs.ForeColor = System.Drawing.Color.White
        Me.btnOs.HoverState.Image = Global.SmartOS.My.Resources.Resources.servico_de_gerenciamento__3_
        Me.btnOs.Image = Global.SmartOS.My.Resources.Resources.servico_de_gerenciamento__2_
        Me.btnOs.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnOs.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnOs.Location = New System.Drawing.Point(0, 109)
        Me.btnOs.MinimumSize = New System.Drawing.Size(227, 0)
        Me.btnOs.Name = "btnOs"
        Me.btnOs.Size = New System.Drawing.Size(227, 49)
        Me.btnOs.TabIndex = 3
        Me.btnOs.Text = "Ordem de serviço"
        Me.btnOs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnOs.UseTransparentBackground = True
        '
        'btnConsulta
        '
        Me.btnConsulta.Animated = True
        Me.btnConsulta.BackColor = System.Drawing.Color.Transparent
        Me.btnConsulta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsulta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnConsulta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnConsulta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnConsulta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsulta.FillColor = System.Drawing.Color.OrangeRed
        Me.btnConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.btnConsulta.ForeColor = System.Drawing.Color.White
        Me.btnConsulta.HoverState.Image = Global.SmartOS.My.Resources.Resources.lupa__2_
        Me.btnConsulta.Image = Global.SmartOS.My.Resources.Resources.lupa__3_
        Me.btnConsulta.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnConsulta.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnConsulta.Location = New System.Drawing.Point(0, 60)
        Me.btnConsulta.MinimumSize = New System.Drawing.Size(227, 0)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(227, 49)
        Me.btnConsulta.TabIndex = 1
        Me.btnConsulta.Text = "Consulta"
        Me.btnConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnConsulta.UseTransparentBackground = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel1.Controls.Add(Me.btnSidebar)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Guna2Panel1.Size = New System.Drawing.Size(59, 60)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(75, 34)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(64, 18)
        Me.Guna2HtmlLabel4.TabIndex = 2
        Me.Guna2HtmlLabel4.Text = "Atendente"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(75, 10)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(90, 26)
        Me.Guna2HtmlLabel3.TabIndex = 1
        Me.Guna2HtmlLabel3.Text = "Atendente"
        '
        'btnSidebar
        '
        Me.btnSidebar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSidebar.Image = Global.SmartOS.My.Resources.Resources.recepcionista
        Me.btnSidebar.ImageRotate = 0!
        Me.btnSidebar.Location = New System.Drawing.Point(5, 5)
        Me.btnSidebar.Name = "btnSidebar"
        Me.btnSidebar.Size = New System.Drawing.Size(51, 50)
        Me.btnSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnSidebar.TabIndex = 0
        Me.btnSidebar.TabStop = False
        Me.btnSidebar.UseTransparentBackground = True
        '
        'lblClientes
        '
        Me.lblClientes.BackColor = System.Drawing.Color.Transparent
        Me.lblClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.ForeColor = System.Drawing.Color.White
        Me.lblClientes.Location = New System.Drawing.Point(58, 14)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(70, 26)
        Me.lblClientes.TabIndex = 6
        Me.lblClientes.Text = "Clientes"
        '
        'lblOs
        '
        Me.lblOs.BackColor = System.Drawing.Color.Transparent
        Me.lblOs.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOs.ForeColor = System.Drawing.Color.White
        Me.lblOs.Location = New System.Drawing.Point(58, 14)
        Me.lblOs.Name = "lblOs"
        Me.lblOs.Size = New System.Drawing.Size(158, 26)
        Me.lblOs.TabIndex = 5
        Me.lblOs.Text = "Ordens de serviço"
        '
        'lblUsuarios
        '
        Me.lblUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarios.ForeColor = System.Drawing.Color.White
        Me.lblUsuarios.Location = New System.Drawing.Point(57, 14)
        Me.lblUsuarios.Name = "lblUsuarios"
        Me.lblUsuarios.Size = New System.Drawing.Size(76, 26)
        Me.lblUsuarios.TabIndex = 4
        Me.lblUsuarios.Text = "Usuários"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(57, 15)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(119, 26)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "Administrador"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(58, 39)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(41, 18)
        Me.Guna2HtmlLabel2.TabIndex = 2
        Me.Guna2HtmlLabel2.Text = "Admin"
        '
        'sidebarTimer
        '
        Me.sidebarTimer.Interval = 1
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = Global.SmartOS.My.Resources.Resources.fechar_preto
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(707, 4)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2PictureBox2.TabIndex = 1
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'panel_forms
        '
        Me.panel_forms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_forms.Location = New System.Drawing.Point(59, 0)
        Me.panel_forms.Name = "panel_forms"
        Me.panel_forms.Size = New System.Drawing.Size(677, 481)
        Me.panel_forms.TabIndex = 2
        '
        'frmAtendente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 481)
        Me.Controls.Add(Me.panel_forms)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.sidebarAtendente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAtendente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAtendente"
        Me.sidebarAtendente.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.btnSidebar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents sidebarAtendente As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents lblClientes As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblOs As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblUsuarios As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnSidebar As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnConsulta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnClientes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnOs As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents sidebarTimer As Timer
    Friend WithEvents panel_forms As Guna.UI2.WinForms.Guna2Panel
End Class
