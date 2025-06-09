<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultaHome
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtPesquisa = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnPesquisa = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.btnPesquisaMarca = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPesquisaModelo = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPesquisaCod = New Guna.UI2.WinForms.Guna2Button()
        Me.BunifuCustomDataGrid1 = New ns1.BunifuCustomDataGrid()
        Me.coluna_marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coluna_modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coluna_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2VScrollBar1 = New Guna.UI2.WinForms.Guna2VScrollBar()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2Panel1.Controls.Add(Me.btnPesquisaCod)
        Me.Guna2Panel1.Controls.Add(Me.btnPesquisaModelo)
        Me.Guna2Panel1.Controls.Add(Me.btnPesquisaMarca)
        Me.Guna2Panel1.Controls.Add(Me.btnPesquisa)
        Me.Guna2Panel1.Controls.Add(Me.txtPesquisa)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(800, 41)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.SmartOS.My.Resources.Resources.fechar
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(774, 2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
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
        Me.txtPesquisa.Location = New System.Drawing.Point(42, 2)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtPesquisa.PlaceholderText = "Digite o modelo do dispositivo"
        Me.txtPesquisa.SelectedText = ""
        Me.txtPesquisa.Size = New System.Drawing.Size(318, 36)
        Me.txtPesquisa.TabIndex = 1
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
        Me.btnPesquisa.Location = New System.Drawing.Point(366, 2)
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnPesquisa.Size = New System.Drawing.Size(35, 35)
        Me.btnPesquisa.TabIndex = 2
        '
        'btnPesquisaMarca
        '
        Me.btnPesquisaMarca.Animated = True
        Me.btnPesquisaMarca.AutoRoundedCorners = True
        Me.btnPesquisaMarca.BorderColor = System.Drawing.Color.OrangeRed
        Me.btnPesquisaMarca.BorderThickness = 2
        Me.btnPesquisaMarca.CustomizableEdges.BottomLeft = False
        Me.btnPesquisaMarca.CustomizableEdges.BottomRight = False
        Me.btnPesquisaMarca.CustomizableEdges.TopLeft = False
        Me.btnPesquisaMarca.CustomizableEdges.TopRight = False
        Me.btnPesquisaMarca.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPesquisaMarca.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPesquisaMarca.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPesquisaMarca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPesquisaMarca.FillColor = System.Drawing.Color.Transparent
        Me.btnPesquisaMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesquisaMarca.ForeColor = System.Drawing.Color.White
        Me.btnPesquisaMarca.HoverState.FillColor = System.Drawing.Color.OrangeRed
        Me.btnPesquisaMarca.Location = New System.Drawing.Point(586, 5)
        Me.btnPesquisaMarca.Name = "btnPesquisaMarca"
        Me.btnPesquisaMarca.Size = New System.Drawing.Size(69, 30)
        Me.btnPesquisaMarca.TabIndex = 3
        Me.btnPesquisaMarca.Text = "Marca"
        Me.btnPesquisaMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnPesquisaModelo
        '
        Me.btnPesquisaModelo.Animated = True
        Me.btnPesquisaModelo.AutoRoundedCorners = True
        Me.btnPesquisaModelo.BorderColor = System.Drawing.Color.OrangeRed
        Me.btnPesquisaModelo.BorderThickness = 2
        Me.btnPesquisaModelo.CustomizableEdges.BottomRight = False
        Me.btnPesquisaModelo.CustomizableEdges.TopRight = False
        Me.btnPesquisaModelo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPesquisaModelo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPesquisaModelo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPesquisaModelo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPesquisaModelo.FillColor = System.Drawing.Color.Transparent
        Me.btnPesquisaModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesquisaModelo.ForeColor = System.Drawing.Color.White
        Me.btnPesquisaModelo.HoverState.FillColor = System.Drawing.Color.OrangeRed
        Me.btnPesquisaModelo.Location = New System.Drawing.Point(505, 5)
        Me.btnPesquisaModelo.Name = "btnPesquisaModelo"
        Me.btnPesquisaModelo.Size = New System.Drawing.Size(80, 30)
        Me.btnPesquisaModelo.TabIndex = 4
        Me.btnPesquisaModelo.Text = "Modelo"
        Me.btnPesquisaModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnPesquisaCod
        '
        Me.btnPesquisaCod.Animated = True
        Me.btnPesquisaCod.AutoRoundedCorners = True
        Me.btnPesquisaCod.BorderColor = System.Drawing.Color.OrangeRed
        Me.btnPesquisaCod.BorderThickness = 2
        Me.btnPesquisaCod.CustomizableEdges.BottomLeft = False
        Me.btnPesquisaCod.CustomizableEdges.TopLeft = False
        Me.btnPesquisaCod.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPesquisaCod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPesquisaCod.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPesquisaCod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPesquisaCod.FillColor = System.Drawing.Color.Transparent
        Me.btnPesquisaCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesquisaCod.ForeColor = System.Drawing.Color.White
        Me.btnPesquisaCod.HoverState.FillColor = System.Drawing.Color.OrangeRed
        Me.btnPesquisaCod.Location = New System.Drawing.Point(656, 5)
        Me.btnPesquisaCod.Name = "btnPesquisaCod"
        Me.btnPesquisaCod.Size = New System.Drawing.Size(72, 30)
        Me.btnPesquisaCod.TabIndex = 5
        Me.btnPesquisaCod.Text = "Código"
        Me.btnPesquisaCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BunifuCustomDataGrid1
        '
        Me.BunifuCustomDataGrid1.AllowUserToAddRows = False
        Me.BunifuCustomDataGrid1.AllowUserToDeleteRows = False
        Me.BunifuCustomDataGrid1.AllowUserToOrderColumns = True
        Me.BunifuCustomDataGrid1.AllowUserToResizeColumns = False
        Me.BunifuCustomDataGrid1.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.BunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.BunifuCustomDataGrid1.ColumnHeadersHeight = 30
        Me.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.BunifuCustomDataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coluna_marca, Me.coluna_modelo, Me.coluna_codigo})
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.OrangeRed
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(42, 47)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.ReadOnly = True
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(686, 391)
        Me.BunifuCustomDataGrid1.TabIndex = 1
        '
        'coluna_marca
        '
        Me.coluna_marca.HeaderText = "Marca"
        Me.coluna_marca.Name = "coluna_marca"
        Me.coluna_marca.ReadOnly = True
        '
        'coluna_modelo
        '
        Me.coluna_modelo.HeaderText = "Modelo"
        Me.coluna_modelo.Name = "coluna_modelo"
        Me.coluna_modelo.ReadOnly = True
        '
        'coluna_codigo
        '
        Me.coluna_codigo.HeaderText = "Código"
        Me.coluna_codigo.Name = "coluna_codigo"
        Me.coluna_codigo.ReadOnly = True
        '
        'Guna2VScrollBar1
        '
        Me.Guna2VScrollBar1.AutoRoundedCorners = True
        Me.Guna2VScrollBar1.BindingContainer = Me.BunifuCustomDataGrid1
        Me.Guna2VScrollBar1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2VScrollBar1.BorderRadius = 6
        Me.Guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2VScrollBar1.InUpdate = False
        Me.Guna2VScrollBar1.LargeChange = 10
        Me.Guna2VScrollBar1.Location = New System.Drawing.Point(713, 78)
        Me.Guna2VScrollBar1.Minimum = 1
        Me.Guna2VScrollBar1.Name = "Guna2VScrollBar1"
        Me.Guna2VScrollBar1.ScrollbarSize = 15
        Me.Guna2VScrollBar1.Size = New System.Drawing.Size(15, 360)
        Me.Guna2VScrollBar1.TabIndex = 2
        Me.Guna2VScrollBar1.ThumbColor = System.Drawing.Color.OrangeRed
        Me.Guna2VScrollBar1.Value = 1
        '
        'frmConsultaHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Guna2VScrollBar1)
        Me.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConsultaHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsultaHome"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtPesquisa As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnPesquisa As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents btnPesquisaMarca As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPesquisaModelo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPesquisaCod As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BunifuCustomDataGrid1 As ns1.BunifuCustomDataGrid
    Friend WithEvents coluna_marca As DataGridViewTextBoxColumn
    Friend WithEvents coluna_modelo As DataGridViewTextBoxColumn
    Friend WithEvents coluna_codigo As DataGridViewTextBoxColumn
    Friend WithEvents Guna2VScrollBar1 As Guna.UI2.WinForms.Guna2VScrollBar
End Class
