<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOs
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
        Me.Guna2VScrollBar1 = New Guna.UI2.WinForms.Guna2VScrollBar()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.btnPesquisaOs = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPesquisaNome = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPesquisa = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.txtPesquisa = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.datagridOs = New ns1.BunifuCustomDataGrid()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridOs, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'datagridOs
        '
        Me.datagridOs.AllowUserToAddRows = False
        Me.datagridOs.AllowUserToDeleteRows = False
        Me.datagridOs.AllowUserToOrderColumns = True
        Me.datagridOs.AllowUserToResizeColumns = False
        Me.datagridOs.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.datagridOs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridOs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridOs.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.datagridOs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridOs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridOs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagridOs.ColumnHeadersHeight = 30
        Me.datagridOs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridOs.DefaultCellStyle = DataGridViewCellStyle3
        Me.datagridOs.DoubleBuffered = True
        Me.datagridOs.EnableHeadersVisualStyles = False
        Me.datagridOs.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.datagridOs.HeaderBgColor = System.Drawing.Color.OrangeRed
        Me.datagridOs.HeaderForeColor = System.Drawing.Color.White
        Me.datagridOs.Location = New System.Drawing.Point(62, 51)
        Me.datagridOs.MultiSelect = False
        Me.datagridOs.Name = "datagridOs"
        Me.datagridOs.ReadOnly = True
        Me.datagridOs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridOs.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datagridOs.RowHeadersVisible = False
        Me.datagridOs.RowHeadersWidth = 10
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.datagridOs.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.datagridOs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridOs.Size = New System.Drawing.Size(561, 411)
        Me.datagridOs.TabIndex = 16
        '
        'frmOs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(677, 481)
        Me.Controls.Add(Me.datagridOs)
        Me.Controls.Add(Me.Guna2VScrollBar1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOs"
        Me.Text = "frmOs"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridOs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2VScrollBar1 As Guna.UI2.WinForms.Guna2VScrollBar
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnPesquisaOs As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPesquisaNome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPesquisa As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents txtPesquisa As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents datagridOs As ns1.BunifuCustomDataGrid
End Class
