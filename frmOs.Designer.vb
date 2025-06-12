<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOs
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2VScrollBar1 = New Guna.UI2.WinForms.Guna2VScrollBar()
        Me.datagridModelos = New ns1.BunifuCustomDataGrid()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.btnPesquisaOs = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPesquisaNome = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPesquisa = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.txtPesquisa = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.coluna_numOs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coluna_nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coluna_status = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.datagridModelos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Guna2VScrollBar1
        '
        Me.Guna2VScrollBar1.AutoRoundedCorners = True
        Me.Guna2VScrollBar1.BindingContainer = Me.datagridModelos
        Me.Guna2VScrollBar1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2VScrollBar1.BorderRadius = 6
        Me.Guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2VScrollBar1.InUpdate = False
        Me.Guna2VScrollBar1.LargeChange = 10
        Me.Guna2VScrollBar1.Location = New System.Drawing.Point(605, 82)
        Me.Guna2VScrollBar1.Minimum = 1
        Me.Guna2VScrollBar1.Name = "Guna2VScrollBar1"
        Me.Guna2VScrollBar1.ScrollbarSize = 14
        Me.Guna2VScrollBar1.Size = New System.Drawing.Size(14, 380)
        Me.Guna2VScrollBar1.TabIndex = 14
        Me.Guna2VScrollBar1.ThumbColor = System.Drawing.Color.OrangeRed
        Me.Guna2VScrollBar1.Value = 1
        '
        'datagridModelos
        '
        Me.datagridModelos.AllowUserToAddRows = False
        Me.datagridModelos.AllowUserToDeleteRows = False
        Me.datagridModelos.AllowUserToOrderColumns = True
        Me.datagridModelos.AllowUserToResizeColumns = False
        Me.datagridModelos.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.datagridModelos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.datagridModelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridModelos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.datagridModelos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridModelos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridModelos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.datagridModelos.ColumnHeadersHeight = 30
        Me.datagridModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datagridModelos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coluna_numOs, Me.coluna_nome, Me.coluna_status})
        Me.datagridModelos.DoubleBuffered = True
        Me.datagridModelos.EnableHeadersVisualStyles = False
        Me.datagridModelos.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.datagridModelos.HeaderBgColor = System.Drawing.Color.OrangeRed
        Me.datagridModelos.HeaderForeColor = System.Drawing.Color.White
        Me.datagridModelos.Location = New System.Drawing.Point(58, 47)
        Me.datagridModelos.Name = "datagridModelos"
        Me.datagridModelos.ReadOnly = True
        Me.datagridModelos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagridModelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridModelos.Size = New System.Drawing.Size(565, 415)
        Me.datagridModelos.TabIndex = 13
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
        Me.btnAdd.Location = New System.Drawing.Point(625, 427)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnAdd.Size = New System.Drawing.Size(40, 40)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Visible = False
        '
        'btnPesquisaOs
        '
        Me.btnPesquisaOs.Animated = True
        Me.btnPesquisaOs.AutoRoundedCorners = True
        Me.btnPesquisaOs.BorderColor = System.Drawing.Color.OrangeRed
        Me.btnPesquisaOs.BorderThickness = 2
        Me.btnPesquisaOs.CustomizableEdges.BottomRight = False
        Me.btnPesquisaOs.CustomizableEdges.TopRight = False
        Me.btnPesquisaOs.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPesquisaOs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPesquisaOs.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPesquisaOs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPesquisaOs.FillColor = System.Drawing.Color.Transparent
        Me.btnPesquisaOs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesquisaOs.ForeColor = System.Drawing.Color.White
        Me.btnPesquisaOs.HoverState.FillColor = System.Drawing.Color.OrangeRed
        Me.btnPesquisaOs.Location = New System.Drawing.Point(458, 5)
        Me.btnPesquisaOs.Name = "btnPesquisaOs"
        Me.btnPesquisaOs.Size = New System.Drawing.Size(95, 30)
        Me.btnPesquisaOs.TabIndex = 7
        Me.btnPesquisaOs.Text = "Número OS"
        Me.btnPesquisaOs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnPesquisaNome
        '
        Me.btnPesquisaNome.Animated = True
        Me.btnPesquisaNome.AutoRoundedCorners = True
        Me.btnPesquisaNome.BorderColor = System.Drawing.Color.OrangeRed
        Me.btnPesquisaNome.BorderThickness = 2
        Me.btnPesquisaNome.CustomizableEdges.BottomLeft = False
        Me.btnPesquisaNome.CustomizableEdges.TopLeft = False
        Me.btnPesquisaNome.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPesquisaNome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPesquisaNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPesquisaNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPesquisaNome.FillColor = System.Drawing.Color.Transparent
        Me.btnPesquisaNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesquisaNome.ForeColor = System.Drawing.Color.White
        Me.btnPesquisaNome.HoverState.FillColor = System.Drawing.Color.OrangeRed
        Me.btnPesquisaNome.Location = New System.Drawing.Point(554, 5)
        Me.btnPesquisaNome.Name = "btnPesquisaNome"
        Me.btnPesquisaNome.Size = New System.Drawing.Size(69, 30)
        Me.btnPesquisaNome.TabIndex = 6
        Me.btnPesquisaNome.Text = "Nome"
        Me.btnPesquisaNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.btnPesquisa.Location = New System.Drawing.Point(351, 3)
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
        Me.txtPesquisa.Location = New System.Drawing.Point(58, 2)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtPesquisa.PlaceholderText = "Digite o numero da ordem de serviço"
        Me.txtPesquisa.SelectedText = ""
        Me.txtPesquisa.Size = New System.Drawing.Size(287, 36)
        Me.txtPesquisa.TabIndex = 1
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.btnPesquisaOs)
        Me.Guna2Panel1.Controls.Add(Me.btnPesquisaNome)
        Me.Guna2Panel1.Controls.Add(Me.btnPesquisa)
        Me.Guna2Panel1.Controls.Add(Me.txtPesquisa)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(677, 41)
        Me.Guna2Panel1.TabIndex = 12
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
        'coluna_numOs
        '
        Me.coluna_numOs.HeaderText = "Número de OS"
        Me.coluna_numOs.Name = "coluna_numOs"
        Me.coluna_numOs.ReadOnly = True
        '
        'coluna_nome
        '
        Me.coluna_nome.HeaderText = "Nome do cliente"
        Me.coluna_nome.Name = "coluna_nome"
        Me.coluna_nome.ReadOnly = True
        '
        'coluna_status
        '
        Me.coluna_status.HeaderText = "Status"
        Me.coluna_status.Name = "coluna_status"
        Me.coluna_status.ReadOnly = True
        '
        'frmOs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(677, 481)
        Me.Controls.Add(Me.Guna2VScrollBar1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.datagridModelos)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOs"
        Me.Text = "frmOs"
        CType(Me.datagridModelos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2VScrollBar1 As Guna.UI2.WinForms.Guna2VScrollBar
    Friend WithEvents datagridModelos As ns1.BunifuCustomDataGrid
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnPesquisaOs As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPesquisaNome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPesquisa As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents txtPesquisa As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents coluna_numOs As DataGridViewTextBoxColumn
    Friend WithEvents coluna_nome As DataGridViewTextBoxColumn
    Friend WithEvents coluna_status As DataGridViewComboBoxColumn
End Class
