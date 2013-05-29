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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFornecedores))
        Me.gpxFornecedor = New System.Windows.Forms.GroupBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cbxCategoria = New System.Windows.Forms.ComboBox()
        Me.mskTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.mskCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.txtNomeRepresentante = New System.Windows.Forms.TextBox()
        Me.txtNomeFornecedor = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.lblCNPJ = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblNomeRepresentante = New System.Windows.Forms.Label()
        Me.lblNomeFornecedor = New System.Windows.Forms.Label()
        Me.dgvFornecedores = New System.Windows.Forms.DataGridView()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.EasyStockSystemDataSet = New TrabalhoG2_VB.EasyStockSystemDataSet()
        Me.FornecedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FornecedoresTableAdapter = New TrabalhoG2_VB.EasyStockSystemDataSetTableAdapters.fornecedoresTableAdapter()
        Me.TableAdapterManager = New TrabalhoG2_VB.EasyStockSystemDataSetTableAdapters.TableAdapterManager()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomerepresentanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefone2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CnpjDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpxFornecedor.SuspendLayout()
        CType(Me.dgvFornecedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EasyStockSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornecedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpxFornecedor
        '
        Me.gpxFornecedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpxFornecedor.Controls.Add(Me.txtCidade)
        Me.gpxFornecedor.Controls.Add(Me.txtEmail)
        Me.gpxFornecedor.Controls.Add(Me.cbxCategoria)
        Me.gpxFornecedor.Controls.Add(Me.mskTelefone)
        Me.gpxFornecedor.Controls.Add(Me.mskCNPJ)
        Me.gpxFornecedor.Controls.Add(Me.txtNomeRepresentante)
        Me.gpxFornecedor.Controls.Add(Me.txtNomeFornecedor)
        Me.gpxFornecedor.Controls.Add(Me.btnCancelar)
        Me.gpxFornecedor.Controls.Add(Me.btnSalvar)
        Me.gpxFornecedor.Controls.Add(Me.lblCNPJ)
        Me.gpxFornecedor.Controls.Add(Me.lblCidade)
        Me.gpxFornecedor.Controls.Add(Me.lblEmail)
        Me.gpxFornecedor.Controls.Add(Me.lblTelefone)
        Me.gpxFornecedor.Controls.Add(Me.lblCategoria)
        Me.gpxFornecedor.Controls.Add(Me.lblNomeRepresentante)
        Me.gpxFornecedor.Controls.Add(Me.lblNomeFornecedor)
        Me.gpxFornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpxFornecedor.ForeColor = System.Drawing.Color.White
        Me.gpxFornecedor.Location = New System.Drawing.Point(2, 2)
        Me.gpxFornecedor.Name = "gpxFornecedor"
        Me.gpxFornecedor.Size = New System.Drawing.Size(679, 151)
        Me.gpxFornecedor.TabIndex = 0
        Me.gpxFornecedor.TabStop = False
        Me.gpxFornecedor.Text = "Adicionar Fornecedor"
        '
        'txtCidade
        '
        Me.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidade.Location = New System.Drawing.Point(419, 80)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(168, 19)
        Me.txtCidade.TabIndex = 15
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(419, 39)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(168, 19)
        Me.txtEmail.TabIndex = 14
        '
        'cbxCategoria
        '
        Me.cbxCategoria.FormattingEnabled = True
        Me.cbxCategoria.Location = New System.Drawing.Point(14, 120)
        Me.cbxCategoria.Name = "cbxCategoria"
        Me.cbxCategoria.Size = New System.Drawing.Size(227, 24)
        Me.cbxCategoria.TabIndex = 13
        '
        'mskTelefone
        '
        Me.mskTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskTelefone.Location = New System.Drawing.Point(263, 80)
        Me.mskTelefone.Mask = "(00)0000-0000"
        Me.mskTelefone.Name = "mskTelefone"
        Me.mskTelefone.Size = New System.Drawing.Size(150, 19)
        Me.mskTelefone.TabIndex = 12
        '
        'mskCNPJ
        '
        Me.mskCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskCNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCNPJ.Location = New System.Drawing.Point(262, 40)
        Me.mskCNPJ.Mask = "00.000.000/0000-00"
        Me.mskCNPJ.Name = "mskCNPJ"
        Me.mskCNPJ.Size = New System.Drawing.Size(151, 19)
        Me.mskCNPJ.TabIndex = 11
        '
        'txtNomeRepresentante
        '
        Me.txtNomeRepresentante.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomeRepresentante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeRepresentante.Location = New System.Drawing.Point(13, 80)
        Me.txtNomeRepresentante.Name = "txtNomeRepresentante"
        Me.txtNomeRepresentante.Size = New System.Drawing.Size(228, 19)
        Me.txtNomeRepresentante.TabIndex = 10
        '
        'txtNomeFornecedor
        '
        Me.txtNomeFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomeFornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeFornecedor.Location = New System.Drawing.Point(13, 39)
        Me.txtNomeFornecedor.Name = "txtNomeFornecedor"
        Me.txtNomeFornecedor.Size = New System.Drawing.Size(228, 19)
        Me.txtNomeFornecedor.TabIndex = 9
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(610, 86)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(60, 50)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSalvar.BackgroundImage = CType(resources.GetObject("btnSalvar.BackgroundImage"), System.Drawing.Image)
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Location = New System.Drawing.Point(610, 19)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(60, 50)
        Me.btnSalvar.TabIndex = 7
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'lblCNPJ
        '
        Me.lblCNPJ.AutoSize = True
        Me.lblCNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCNPJ.ForeColor = System.Drawing.Color.Black
        Me.lblCNPJ.Location = New System.Drawing.Point(259, 20)
        Me.lblCNPJ.Name = "lblCNPJ"
        Me.lblCNPJ.Size = New System.Drawing.Size(53, 20)
        Me.lblCNPJ.TabIndex = 6
        Me.lblCNPJ.Text = "CNPJ:"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCidade.ForeColor = System.Drawing.Color.Black
        Me.lblCidade.Location = New System.Drawing.Point(415, 61)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(63, 20)
        Me.lblCidade.TabIndex = 5
        Me.lblCidade.Text = "Cidade:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.Location = New System.Drawing.Point(415, 19)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(57, 20)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "E-mail:"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefone.ForeColor = System.Drawing.Color.Black
        Me.lblTelefone.Location = New System.Drawing.Point(259, 62)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(75, 20)
        Me.lblTelefone.TabIndex = 3
        Me.lblTelefone.Text = "Telefone:"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.ForeColor = System.Drawing.Color.Black
        Me.lblCategoria.Location = New System.Drawing.Point(10, 100)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(82, 20)
        Me.lblCategoria.TabIndex = 2
        Me.lblCategoria.Text = "Categoria:"
        '
        'lblNomeRepresentante
        '
        Me.lblNomeRepresentante.AutoSize = True
        Me.lblNomeRepresentante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeRepresentante.ForeColor = System.Drawing.Color.Black
        Me.lblNomeRepresentante.Location = New System.Drawing.Point(10, 60)
        Me.lblNomeRepresentante.Name = "lblNomeRepresentante"
        Me.lblNomeRepresentante.Size = New System.Drawing.Size(188, 20)
        Me.lblNomeRepresentante.TabIndex = 1
        Me.lblNomeRepresentante.Text = "Nome do Representante:"
        '
        'lblNomeFornecedor
        '
        Me.lblNomeFornecedor.AutoSize = True
        Me.lblNomeFornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeFornecedor.ForeColor = System.Drawing.Color.Black
        Me.lblNomeFornecedor.Location = New System.Drawing.Point(9, 20)
        Me.lblNomeFornecedor.Name = "lblNomeFornecedor"
        Me.lblNomeFornecedor.Size = New System.Drawing.Size(163, 20)
        Me.lblNomeFornecedor.TabIndex = 0
        Me.lblNomeFornecedor.Text = "Nome do Fornecedor:"
        '
        'dgvFornecedores
        '
        Me.dgvFornecedores.AllowUserToAddRows = False
        Me.dgvFornecedores.AllowUserToDeleteRows = False
        Me.dgvFornecedores.AllowUserToResizeColumns = False
        Me.dgvFornecedores.AllowUserToResizeRows = False
        Me.dgvFornecedores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFornecedores.AutoGenerateColumns = False
        Me.dgvFornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFornecedores.BackgroundColor = System.Drawing.Color.White
        Me.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFornecedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NomeDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.NomerepresentanteDataGridViewTextBoxColumn, Me.TelefoneDataGridViewTextBoxColumn, Me.Telefone2DataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.CidadeDataGridViewTextBoxColumn, Me.CnpjDataGridViewTextBoxColumn})
        Me.dgvFornecedores.DataSource = Me.FornecedoresBindingSource
        Me.dgvFornecedores.Location = New System.Drawing.Point(79, 168)
        Me.dgvFornecedores.Name = "dgvFornecedores"
        Me.dgvFornecedores.RowHeadersVisible = False
        Me.dgvFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFornecedores.Size = New System.Drawing.Size(602, 269)
        Me.dgvFornecedores.TabIndex = 5
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnVoltar.BackgroundImage = CType(resources.GetObject("btnVoltar.BackgroundImage"), System.Drawing.Image)
        Me.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVoltar.FlatAppearance.BorderSize = 0
        Me.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltar.Location = New System.Drawing.Point(12, 366)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(60, 60)
        Me.btnVoltar.TabIndex = 4
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.SteelBlue
        Me.btnExcluir.BackgroundImage = CType(resources.GetObject("btnExcluir.BackgroundImage"), System.Drawing.Image)
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Location = New System.Drawing.Point(12, 300)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(60, 60)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = CType(resources.GetObject("btnEditar.BackgroundImage"), System.Drawing.Image)
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Location = New System.Drawing.Point(12, 234)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(60, 60)
        Me.btnEditar.TabIndex = 2
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAdicionar.BackgroundImage = CType(resources.GetObject("btnAdicionar.BackgroundImage"), System.Drawing.Image)
        Me.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdicionar.FlatAppearance.BorderSize = 0
        Me.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionar.Location = New System.Drawing.Point(12, 168)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(60, 60)
        Me.btnAdicionar.TabIndex = 1
        Me.btnAdicionar.UseVisualStyleBackColor = False
        '
        'EasyStockSystemDataSet
        '
        Me.EasyStockSystemDataSet.DataSetName = "EasyStockSystemDataSet"
        Me.EasyStockSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FornecedoresBindingSource
        '
        Me.FornecedoresBindingSource.DataMember = "fornecedores"
        Me.FornecedoresBindingSource.DataSource = Me.EasyStockSystemDataSet
        '
        'FornecedoresTableAdapter
        '
        Me.FornecedoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.administradoresTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.fornecedoresTableAdapter = Me.FornecedoresTableAdapter
        Me.TableAdapterManager.produtos_has_vendaTableAdapter = Nothing
        Me.TableAdapterManager.produtosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TrabalhoG2_VB.EasyStockSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vendaTableAdapter = Nothing
        Me.TableAdapterManager.vendedoresTableAdapter = Nothing
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "nome"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        '
        'CategoriaDataGridViewTextBoxColumn
        '
        Me.CategoriaDataGridViewTextBoxColumn.DataPropertyName = "categoria"
        Me.CategoriaDataGridViewTextBoxColumn.HeaderText = "categoria"
        Me.CategoriaDataGridViewTextBoxColumn.Name = "CategoriaDataGridViewTextBoxColumn"
        '
        'NomerepresentanteDataGridViewTextBoxColumn
        '
        Me.NomerepresentanteDataGridViewTextBoxColumn.DataPropertyName = "nome_representante"
        Me.NomerepresentanteDataGridViewTextBoxColumn.HeaderText = "nome_representante"
        Me.NomerepresentanteDataGridViewTextBoxColumn.Name = "NomerepresentanteDataGridViewTextBoxColumn"
        '
        'TelefoneDataGridViewTextBoxColumn
        '
        Me.TelefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone"
        Me.TelefoneDataGridViewTextBoxColumn.HeaderText = "telefone"
        Me.TelefoneDataGridViewTextBoxColumn.Name = "TelefoneDataGridViewTextBoxColumn"
        '
        'Telefone2DataGridViewTextBoxColumn
        '
        Me.Telefone2DataGridViewTextBoxColumn.DataPropertyName = "telefone2"
        Me.Telefone2DataGridViewTextBoxColumn.HeaderText = "telefone2"
        Me.Telefone2DataGridViewTextBoxColumn.Name = "Telefone2DataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'CidadeDataGridViewTextBoxColumn
        '
        Me.CidadeDataGridViewTextBoxColumn.DataPropertyName = "cidade"
        Me.CidadeDataGridViewTextBoxColumn.HeaderText = "cidade"
        Me.CidadeDataGridViewTextBoxColumn.Name = "CidadeDataGridViewTextBoxColumn"
        '
        'CnpjDataGridViewTextBoxColumn
        '
        Me.CnpjDataGridViewTextBoxColumn.DataPropertyName = "cnpj"
        Me.CnpjDataGridViewTextBoxColumn.HeaderText = "cnpj"
        Me.CnpjDataGridViewTextBoxColumn.Name = "CnpjDataGridViewTextBoxColumn"
        '
        'frmFornecedores
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(684, 441)
        Me.Controls.Add(Me.dgvFornecedores)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.gpxFornecedor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(700, 480)
        Me.Name = "frmFornecedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Fornecedores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gpxFornecedor.ResumeLayout(False)
        Me.gpxFornecedor.PerformLayout()
        CType(Me.dgvFornecedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EasyStockSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornecedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpxFornecedor As System.Windows.Forms.GroupBox
    Friend WithEvents lblCidade As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblTelefone As System.Windows.Forms.Label
    Friend WithEvents lblCategoria As System.Windows.Forms.Label
    Friend WithEvents lblNomeRepresentante As System.Windows.Forms.Label
    Friend WithEvents lblNomeFornecedor As System.Windows.Forms.Label
    Friend WithEvents lblCNPJ As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents txtNomeFornecedor As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeRepresentante As System.Windows.Forms.TextBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents cbxCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents mskTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskCNPJ As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
    Friend WithEvents dgvFornecedores As System.Windows.Forms.DataGridView
    Friend WithEvents EasyStockSystemDataSet As TrabalhoG2_VB.EasyStockSystemDataSet
    Friend WithEvents FornecedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FornecedoresTableAdapter As TrabalhoG2_VB.EasyStockSystemDataSetTableAdapters.fornecedoresTableAdapter
    Friend WithEvents TableAdapterManager As TrabalhoG2_VB.EasyStockSystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomerepresentanteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefone2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CidadeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CnpjDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
