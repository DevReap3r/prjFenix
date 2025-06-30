<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsuarios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2ShadowForm2 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnPesquisaUsuario = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPesquisaCargo = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPesquisa = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.txtPesquisa = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2VScrollBar1 = New Guna.UI2.WinForms.Guna2VScrollBar()
        Me.datagridUsuarios = New ns1.BunifuCustomDataGrid()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.btnPesquisaUsuario)
        Me.Guna2Panel1.Controls.Add(Me.btnPesquisaCargo)
        Me.Guna2Panel1.Controls.Add(Me.btnPesquisa)
        Me.Guna2Panel1.Controls.Add(Me.txtPesquisa)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(677, 41)
        Me.Guna2Panel1.TabIndex = 4
        '
        'btnPesquisaUsuario
        '
        Me.btnPesquisaUsuario.Animated = True
        Me.btnPesquisaUsuario.AutoRoundedCorners = True
        Me.btnPesquisaUsuario.BorderColor = System.Drawing.Color.OrangeRed
        Me.btnPesquisaUsuario.BorderThickness = 2
        Me.btnPesquisaUsuario.CustomizableEdges.BottomRight = False
        Me.btnPesquisaUsuario.CustomizableEdges.TopRight = False
        Me.btnPesquisaUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPesquisaUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPesquisaUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPesquisaUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPesquisaUsuario.FillColor = System.Drawing.Color.Transparent
        Me.btnPesquisaUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesquisaUsuario.ForeColor = System.Drawing.Color.White
        Me.btnPesquisaUsuario.HoverState.FillColor = System.Drawing.Color.OrangeRed
        Me.btnPesquisaUsuario.Location = New System.Drawing.Point(476, 8)
        Me.btnPesquisaUsuario.Name = "btnPesquisaUsuario"
        Me.btnPesquisaUsuario.Size = New System.Drawing.Size(80, 30)
        Me.btnPesquisaUsuario.TabIndex = 7
        Me.btnPesquisaUsuario.Text = "Usuário"
        Me.btnPesquisaUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnPesquisaCargo
        '
        Me.btnPesquisaCargo.Animated = True
        Me.btnPesquisaCargo.AutoRoundedCorners = True
        Me.btnPesquisaCargo.BorderColor = System.Drawing.Color.OrangeRed
        Me.btnPesquisaCargo.BorderThickness = 2
        Me.btnPesquisaCargo.CustomizableEdges.BottomLeft = False
        Me.btnPesquisaCargo.CustomizableEdges.TopLeft = False
        Me.btnPesquisaCargo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPesquisaCargo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPesquisaCargo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPesquisaCargo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPesquisaCargo.FillColor = System.Drawing.Color.Transparent
        Me.btnPesquisaCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesquisaCargo.ForeColor = System.Drawing.Color.White
        Me.btnPesquisaCargo.HoverState.FillColor = System.Drawing.Color.OrangeRed
        Me.btnPesquisaCargo.Location = New System.Drawing.Point(557, 8)
        Me.btnPesquisaCargo.Name = "btnPesquisaCargo"
        Me.btnPesquisaCargo.Size = New System.Drawing.Size(69, 30)
        Me.btnPesquisaCargo.TabIndex = 6
        Me.btnPesquisaCargo.Text = "Cargo"
        Me.btnPesquisaCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnPesquisa
        '
        Me.btnPesquisa.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPesquisa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPesquisa.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPesquisa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPesquisa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPesquisa.FillColor = System.Drawing.Color.Red
        Me.btnPesquisa.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPesquisa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPesquisa.ForeColor = System.Drawing.Color.White
        Me.btnPesquisa.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnPesquisa.Image = Global.SmartOS.My.Resources.Resources.lupa__3_
        Me.btnPesquisa.ImageOffset = New System.Drawing.Point(1, 0)
        Me.btnPesquisa.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnPesquisa.Location = New System.Drawing.Point(303, 5)
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnPesquisa.Size = New System.Drawing.Size(35, 35)
        Me.btnPesquisa.TabIndex = 2
        '
        'txtPesquisa
        '
        Me.txtPesquisa.Animated = True
        Me.txtPesquisa.AutoRoundedCorners = True
        Me.txtPesquisa.BorderColor = System.Drawing.Color.OrangeRed
        Me.txtPesquisa.BorderThickness = 2
        Me.txtPesquisa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPesquisa.DefaultText = ""
        Me.txtPesquisa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPesquisa.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPesquisa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPesquisa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPesquisa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPesquisa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPesquisa.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPesquisa.Location = New System.Drawing.Point(58, 4)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtPesquisa.PlaceholderText = "Digite o usuário"
        Me.txtPesquisa.SelectedText = ""
        Me.txtPesquisa.Size = New System.Drawing.Size(239, 36)
        Me.txtPesquisa.TabIndex = 1
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.SmartOS.My.Resources.Resources.fechar
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(650, 4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Guna2VScrollBar1
        '
        Me.Guna2VScrollBar1.AutoRoundedCorners = True
        Me.Guna2VScrollBar1.BindingContainer = Me.datagridUsuarios
        Me.Guna2VScrollBar1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2VScrollBar1.BorderRadius = 8
        Me.Guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2VScrollBar1.InUpdate = False
        Me.Guna2VScrollBar1.LargeChange = 10
        Me.Guna2VScrollBar1.Location = New System.Drawing.Point(608, 47)
        Me.Guna2VScrollBar1.Minimum = 1
        Me.Guna2VScrollBar1.Name = "Guna2VScrollBar1"
        Me.Guna2VScrollBar1.ScrollbarSize = 18
        Me.Guna2VScrollBar1.Size = New System.Drawing.Size(18, 411)
        Me.Guna2VScrollBar1.TabIndex = 6
        Me.Guna2VScrollBar1.ThumbColor = System.Drawing.Color.OrangeRed
        Me.Guna2VScrollBar1.Value = 1
        '
        'datagridUsuarios
        '
        Me.datagridUsuarios.AllowUserToAddRows = False
        Me.datagridUsuarios.AllowUserToDeleteRows = False
        Me.datagridUsuarios.AllowUserToOrderColumns = True
        Me.datagridUsuarios.AllowUserToResizeColumns = False
        Me.datagridUsuarios.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.datagridUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.datagridUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagridUsuarios.ColumnHeadersHeight = 30
        Me.datagridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridUsuarios.DefaultCellStyle = DataGridViewCellStyle3
        Me.datagridUsuarios.DoubleBuffered = True
        Me.datagridUsuarios.EnableHeadersVisualStyles = False
        Me.datagridUsuarios.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.datagridUsuarios.HeaderBgColor = System.Drawing.Color.OrangeRed
        Me.datagridUsuarios.HeaderForeColor = System.Drawing.Color.White
        Me.datagridUsuarios.Location = New System.Drawing.Point(65, 47)
        Me.datagridUsuarios.MultiSelect = False
        Me.datagridUsuarios.Name = "datagridUsuarios"
        Me.datagridUsuarios.ReadOnly = True
        Me.datagridUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datagridUsuarios.RowHeadersVisible = False
        Me.datagridUsuarios.RowHeadersWidth = 10
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.datagridUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.datagridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridUsuarios.Size = New System.Drawing.Size(561, 411)
        Me.datagridUsuarios.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Animated = True
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.FillColor = System.Drawing.Color.Red
        Me.btnAdd.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Image = Global.SmartOS.My.Resources.Resources.adicionar
        Me.btnAdd.Location = New System.Drawing.Point(625, 429)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnAdd.Size = New System.Drawing.Size(40, 40)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Visible = False
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(677, 481)
        Me.Controls.Add(Me.Guna2VScrollBar1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.datagridUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUsuarios"
        Me.Text = "frmUsuarios"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2ShadowForm2 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2VScrollBar1 As Guna.UI2.WinForms.Guna2VScrollBar
    Friend WithEvents datagridUsuarios As ns1.BunifuCustomDataGrid
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnPesquisa As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents txtPesquisa As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents btnPesquisaUsuario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPesquisaCargo As Guna.UI2.WinForms.Guna2Button
End Class
