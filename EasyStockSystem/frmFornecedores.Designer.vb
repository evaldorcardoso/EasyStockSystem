<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFornecedores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFornecedores))
        Me.lblFornecedores = New System.Windows.Forms.Label()
        Me.gpxAcoes = New System.Windows.Forms.GroupBox()
        Me.gpxAlteracoes = New System.Windows.Forms.GroupBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.cbxCategoria = New System.Windows.Forms.ComboBox()
        Me.mskCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.mskTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.txtNomeRepresentante = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblCNPJ = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.lblNomeRepresentante = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.dgvFornecedores = New System.Windows.Forms.DataGridView()
        Me.gpxBotoes = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gpxAcoes.SuspendLayout()
        Me.gpxAlteracoes.SuspendLayout()
        CType(Me.dgvFornecedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxBotoes.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFornecedores
        '
        Me.lblFornecedores.AutoSize = True
        Me.lblFornecedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFornecedores.Location = New System.Drawing.Point(18, 2)
        Me.lblFornecedores.Name = "lblFornecedores"
        Me.lblFornecedores.Size = New System.Drawing.Size(145, 20)
        Me.lblFornecedores.TabIndex = 1
        Me.lblFornecedores.Text = "FORNECEDORES"
        '
        'gpxAcoes
        '
        Me.gpxAcoes.Controls.Add(Me.btnExcluir)
        Me.gpxAcoes.Controls.Add(Me.btnEditar)
        Me.gpxAcoes.Controls.Add(Me.btnNovo)
        Me.gpxAcoes.Location = New System.Drawing.Point(180, 1)
        Me.gpxAcoes.Name = "gpxAcoes"
        Me.gpxAcoes.Size = New System.Drawing.Size(376, 90)
        Me.gpxAcoes.TabIndex = 2
        Me.gpxAcoes.TabStop = False
        '
        'gpxAlteracoes
        '
        Me.gpxAlteracoes.Controls.Add(Me.txtNome)
        Me.gpxAlteracoes.Controls.Add(Me.cbxCategoria)
        Me.gpxAlteracoes.Controls.Add(Me.mskCNPJ)
        Me.gpxAlteracoes.Controls.Add(Me.mskTelefone)
        Me.gpxAlteracoes.Controls.Add(Me.txtNomeRepresentante)
        Me.gpxAlteracoes.Controls.Add(Me.txtCidade)
        Me.gpxAlteracoes.Controls.Add(Me.txtEmail)
        Me.gpxAlteracoes.Controls.Add(Me.lblCNPJ)
        Me.gpxAlteracoes.Controls.Add(Me.lblCidade)
        Me.gpxAlteracoes.Controls.Add(Me.lblEmail)
        Me.gpxAlteracoes.Controls.Add(Me.lblTelefone)
        Me.gpxAlteracoes.Controls.Add(Me.lblNomeRepresentante)
        Me.gpxAlteracoes.Controls.Add(Me.lblCategoria)
        Me.gpxAlteracoes.Controls.Add(Me.lblNome)
        Me.gpxAlteracoes.Controls.Add(Me.dgvFornecedores)
        Me.gpxAlteracoes.Location = New System.Drawing.Point(12, 97)
        Me.gpxAlteracoes.Name = "gpxAlteracoes"
        Me.gpxAlteracoes.Size = New System.Drawing.Size(544, 232)
        Me.gpxAlteracoes.TabIndex = 3
        Me.gpxAlteracoes.TabStop = False
        '
        'txtNome
        '
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(10, 44)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(452, 19)
        Me.txtNome.TabIndex = 7
        '
        'cbxCategoria
        '
        Me.cbxCategoria.FormattingEnabled = True
        Me.cbxCategoria.Location = New System.Drawing.Point(10, 97)
        Me.cbxCategoria.Name = "cbxCategoria"
        Me.cbxCategoria.Size = New System.Drawing.Size(184, 21)
        Me.cbxCategoria.TabIndex = 13
        '
        'mskCNPJ
        '
        Me.mskCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskCNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCNPJ.Location = New System.Drawing.Point(290, 191)
        Me.mskCNPJ.Mask = "00.000.000/0000-00"
        Me.mskCNPJ.Name = "mskCNPJ"
        Me.mskCNPJ.Size = New System.Drawing.Size(172, 19)
        Me.mskCNPJ.TabIndex = 12
        '
        'mskTelefone
        '
        Me.mskTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskTelefone.Location = New System.Drawing.Point(10, 192)
        Me.mskTelefone.Mask = "(99) 0000-0000"
        Me.mskTelefone.Name = "mskTelefone"
        Me.mskTelefone.Size = New System.Drawing.Size(184, 19)
        Me.mskTelefone.TabIndex = 11
        '
        'txtNomeRepresentante
        '
        Me.txtNomeRepresentante.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomeRepresentante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeRepresentante.Location = New System.Drawing.Point(10, 145)
        Me.txtNomeRepresentante.Name = "txtNomeRepresentante"
        Me.txtNomeRepresentante.Size = New System.Drawing.Size(184, 19)
        Me.txtNomeRepresentante.TabIndex = 10
        '
        'txtCidade
        '
        Me.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidade.Location = New System.Drawing.Point(290, 145)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(172, 19)
        Me.txtCidade.TabIndex = 9
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(290, 97)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(172, 19)
        Me.txtEmail.TabIndex = 8
        '
        'lblCNPJ
        '
        Me.lblCNPJ.AutoSize = True
        Me.lblCNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCNPJ.ForeColor = System.Drawing.Color.White
        Me.lblCNPJ.Location = New System.Drawing.Point(286, 168)
        Me.lblCNPJ.Name = "lblCNPJ"
        Me.lblCNPJ.Size = New System.Drawing.Size(53, 20)
        Me.lblCNPJ.TabIndex = 6
        Me.lblCNPJ.Text = "CNPJ:"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCidade.ForeColor = System.Drawing.Color.White
        Me.lblCidade.Location = New System.Drawing.Point(286, 121)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(65, 22)
        Me.lblCidade.TabIndex = 5
        Me.lblCidade.Text = "Cidade:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(286, 73)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(52, 20)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email:"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefone.ForeColor = System.Drawing.Color.White
        Me.lblTelefone.Location = New System.Drawing.Point(6, 168)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(75, 20)
        Me.lblTelefone.TabIndex = 3
        Me.lblTelefone.Text = "Telefone:"
        '
        'lblNomeRepresentante
        '
        Me.lblNomeRepresentante.AutoSize = True
        Me.lblNomeRepresentante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeRepresentante.ForeColor = System.Drawing.Color.White
        Me.lblNomeRepresentante.Location = New System.Drawing.Point(6, 121)
        Me.lblNomeRepresentante.Name = "lblNomeRepresentante"
        Me.lblNomeRepresentante.Size = New System.Drawing.Size(188, 20)
        Me.lblNomeRepresentante.TabIndex = 2
        Me.lblNomeRepresentante.Text = "Nome do Representante:"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.ForeColor = System.Drawing.Color.White
        Me.lblCategoria.Location = New System.Drawing.Point(6, 73)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(82, 20)
        Me.lblCategoria.TabIndex = 1
        Me.lblCategoria.Text = "Categoria:"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.ForeColor = System.Drawing.Color.White
        Me.lblNome.Location = New System.Drawing.Point(6, 20)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(55, 20)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Nome:"
        '
        'dgvFornecedores
        '
        Me.dgvFornecedores.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFornecedores.Location = New System.Drawing.Point(20, 20)
        Me.dgvFornecedores.Name = "dgvFornecedores"
        Me.dgvFornecedores.Size = New System.Drawing.Size(503, 206)
        Me.dgvFornecedores.TabIndex = 14
        '
        'gpxBotoes
        '
        Me.gpxBotoes.Controls.Add(Me.btnCancelar)
        Me.gpxBotoes.Controls.Add(Me.btnConfirmar)
        Me.gpxBotoes.Location = New System.Drawing.Point(12, 336)
        Me.gpxBotoes.Name = "gpxBotoes"
        Me.gpxBotoes.Size = New System.Drawing.Size(544, 113)
        Me.gpxBotoes.TabIndex = 4
        Me.gpxBotoes.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Red
        Me.btnCancelar.Location = New System.Drawing.Point(10, 65)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(531, 34)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnConfirmar.FlatAppearance.BorderSize = 0
        Me.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ForeColor = System.Drawing.Color.Green
        Me.btnConfirmar.Location = New System.Drawing.Point(10, 20)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(531, 34)
        Me.btnConfirmar.TabIndex = 0
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.SlateGray
        Me.btnExcluir.BackgroundImage = Global.EasyStockSystem.My.Resources.Resources.fornecedor_delete
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Location = New System.Drawing.Point(262, 11)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(108, 66)
        Me.btnExcluir.TabIndex = 2
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.SlateGray
        Me.btnEditar.BackgroundImage = Global.EasyStockSystem.My.Resources.Resources.fornecedor_edit
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(134, 13)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(114, 66)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.SlateGray
        Me.btnNovo.BackgroundImage = Global.EasyStockSystem.My.Resources.Resources.fornecedor_add
        Me.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.Location = New System.Drawing.Point(9, 13)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(106, 66)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EasyStockSystem.My.Resources.Resources.fornecedor2
        Me.PictureBox1.Location = New System.Drawing.Point(40, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmFornecedores
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.gpxBotoes)
        Me.Controls.Add(Me.gpxAlteracoes)
        Me.Controls.Add(Me.gpxAcoes)
        Me.Controls.Add(Me.lblFornecedores)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmFornecedores"
        Me.Text = "Fornecedores"
        Me.gpxAcoes.ResumeLayout(False)
        Me.gpxAlteracoes.ResumeLayout(False)
        Me.gpxAlteracoes.PerformLayout()
        CType(Me.dgvFornecedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxBotoes.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblFornecedores As System.Windows.Forms.Label
    Friend WithEvents gpxAcoes As System.Windows.Forms.GroupBox
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents gpxAlteracoes As System.Windows.Forms.GroupBox
    Friend WithEvents gpxBotoes As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents lblCNPJ As System.Windows.Forms.Label
    Friend WithEvents lblCidade As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblTelefone As System.Windows.Forms.Label
    Friend WithEvents lblNomeRepresentante As System.Windows.Forms.Label
    Friend WithEvents lblCategoria As System.Windows.Forms.Label
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents cbxCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents mskCNPJ As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtNomeRepresentante As System.Windows.Forms.TextBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents dgvFornecedores As System.Windows.Forms.DataGridView
End Class
