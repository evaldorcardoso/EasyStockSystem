<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProdutos))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.gpxProduto = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.cbxFornecedor = New System.Windows.Forms.ComboBox()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.txtValorVenda = New System.Windows.Forms.TextBox()
        Me.txtValorCusto = New System.Windows.Forms.TextBox()
        Me.lblValorVenda = New System.Windows.Forms.Label()
        Me.lblValorCusto = New System.Windows.Forms.Label()
        Me.txtEstoqueMinimo = New System.Windows.Forms.TextBox()
        Me.lblEstoqueMinimo = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.cbxCategoria = New System.Windows.Forms.ComboBox()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.EasyStockSystemDataSet = New TrabalhoG2_VB.EasyStockSystemDataSet()
        Me.ProdutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdutosTableAdapter = New TrabalhoG2_VB.EasyStockSystemDataSetTableAdapters.produtosTableAdapter()
        Me.TableAdapterManager = New TrabalhoG2_VB.EasyStockSystemDataSetTableAdapters.TableAdapterManager()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FornecedoresidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstoqueminimoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorcustoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorvendaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxProduto.SuspendLayout()
        CType(Me.EasyStockSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FornecedoresidDataGridViewTextBoxColumn, Me.NomeDataGridViewTextBoxColumn, Me.QuantidadeDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.EstoqueminimoDataGridViewTextBoxColumn, Me.ValorcustoDataGridViewTextBoxColumn, Me.ValorvendaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProdutosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(79, 136)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(702, 413)
        Me.DataGridView1.TabIndex = 0
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.White
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(13, 43)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(228, 19)
        Me.txtNome.TabIndex = 2
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(9, 20)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(137, 20)
        Me.lblNome.TabIndex = 3
        Me.lblNome.Text = "Nome do Produto:"
        '
        'gpxProduto
        '
        Me.gpxProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpxProduto.Controls.Add(Me.btnCancelar)
        Me.gpxProduto.Controls.Add(Me.btnSalvar)
        Me.gpxProduto.Controls.Add(Me.cbxFornecedor)
        Me.gpxProduto.Controls.Add(Me.lblFornecedor)
        Me.gpxProduto.Controls.Add(Me.txtValorVenda)
        Me.gpxProduto.Controls.Add(Me.txtValorCusto)
        Me.gpxProduto.Controls.Add(Me.lblValorVenda)
        Me.gpxProduto.Controls.Add(Me.lblValorCusto)
        Me.gpxProduto.Controls.Add(Me.txtEstoqueMinimo)
        Me.gpxProduto.Controls.Add(Me.lblEstoqueMinimo)
        Me.gpxProduto.Controls.Add(Me.lblCategoria)
        Me.gpxProduto.Controls.Add(Me.cbxCategoria)
        Me.gpxProduto.Controls.Add(Me.txtQuantidade)
        Me.gpxProduto.Controls.Add(Me.lblQuantidade)
        Me.gpxProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpxProduto.ForeColor = System.Drawing.Color.White
        Me.gpxProduto.Location = New System.Drawing.Point(2, 2)
        Me.gpxProduto.Name = "gpxProduto"
        Me.gpxProduto.Size = New System.Drawing.Size(779, 128)
        Me.gpxProduto.TabIndex = 4
        Me.gpxProduto.TabStop = False
        Me.gpxProduto.Text = "Adicionar Produto"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(593, 72)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(60, 50)
        Me.btnCancelar.TabIndex = 13
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
        Me.btnSalvar.Location = New System.Drawing.Point(593, 10)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(60, 50)
        Me.btnSalvar.TabIndex = 12
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'cbxFornecedor
        '
        Me.cbxFornecedor.BackColor = System.Drawing.Color.White
        Me.cbxFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxFornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFornecedor.FormattingEnabled = True
        Me.cbxFornecedor.Location = New System.Drawing.Point(265, 98)
        Me.cbxFornecedor.Name = "cbxFornecedor"
        Me.cbxFornecedor.Size = New System.Drawing.Size(147, 24)
        Me.cbxFornecedor.TabIndex = 11
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFornecedor.ForeColor = System.Drawing.Color.Black
        Me.lblFornecedor.Location = New System.Drawing.Point(262, 78)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(95, 20)
        Me.lblFornecedor.TabIndex = 10
        Me.lblFornecedor.Text = "Fornecedor:"
        '
        'txtValorVenda
        '
        Me.txtValorVenda.BackColor = System.Drawing.Color.White
        Me.txtValorVenda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValorVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorVenda.Location = New System.Drawing.Point(432, 98)
        Me.txtValorVenda.Name = "txtValorVenda"
        Me.txtValorVenda.Size = New System.Drawing.Size(119, 19)
        Me.txtValorVenda.TabIndex = 9
        '
        'txtValorCusto
        '
        Me.txtValorCusto.BackColor = System.Drawing.Color.White
        Me.txtValorCusto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValorCusto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorCusto.Location = New System.Drawing.Point(432, 41)
        Me.txtValorCusto.Name = "txtValorCusto"
        Me.txtValorCusto.Size = New System.Drawing.Size(119, 19)
        Me.txtValorCusto.TabIndex = 8
        '
        'lblValorVenda
        '
        Me.lblValorVenda.AutoSize = True
        Me.lblValorVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorVenda.ForeColor = System.Drawing.Color.Black
        Me.lblValorVenda.Location = New System.Drawing.Point(428, 75)
        Me.lblValorVenda.Name = "lblValorVenda"
        Me.lblValorVenda.Size = New System.Drawing.Size(123, 20)
        Me.lblValorVenda.TabIndex = 7
        Me.lblValorVenda.Text = "Valor de Venda:"
        '
        'lblValorCusto
        '
        Me.lblValorCusto.AutoSize = True
        Me.lblValorCusto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorCusto.ForeColor = System.Drawing.Color.Black
        Me.lblValorCusto.Location = New System.Drawing.Point(428, 18)
        Me.lblValorCusto.Name = "lblValorCusto"
        Me.lblValorCusto.Size = New System.Drawing.Size(118, 20)
        Me.lblValorCusto.TabIndex = 6
        Me.lblValorCusto.Text = "Valor de Custo:"
        '
        'txtEstoqueMinimo
        '
        Me.txtEstoqueMinimo.BackColor = System.Drawing.Color.White
        Me.txtEstoqueMinimo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEstoqueMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstoqueMinimo.Location = New System.Drawing.Point(116, 98)
        Me.txtEstoqueMinimo.Name = "txtEstoqueMinimo"
        Me.txtEstoqueMinimo.Size = New System.Drawing.Size(123, 19)
        Me.txtEstoqueMinimo.TabIndex = 5
        '
        'lblEstoqueMinimo
        '
        Me.lblEstoqueMinimo.AutoSize = True
        Me.lblEstoqueMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstoqueMinimo.ForeColor = System.Drawing.Color.Black
        Me.lblEstoqueMinimo.Location = New System.Drawing.Point(112, 75)
        Me.lblEstoqueMinimo.Name = "lblEstoqueMinimo"
        Me.lblEstoqueMinimo.Size = New System.Drawing.Size(127, 20)
        Me.lblEstoqueMinimo.TabIndex = 4
        Me.lblEstoqueMinimo.Text = "Estoque Mínimo:"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.ForeColor = System.Drawing.Color.Black
        Me.lblCategoria.Location = New System.Drawing.Point(261, 18)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(82, 20)
        Me.lblCategoria.TabIndex = 3
        Me.lblCategoria.Text = "Categoria:"
        '
        'cbxCategoria
        '
        Me.cbxCategoria.BackColor = System.Drawing.Color.White
        Me.cbxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxCategoria.FormattingEnabled = True
        Me.cbxCategoria.Location = New System.Drawing.Point(265, 41)
        Me.cbxCategoria.Name = "cbxCategoria"
        Me.cbxCategoria.Size = New System.Drawing.Size(146, 24)
        Me.cbxCategoria.TabIndex = 2
        '
        'txtQuantidade
        '
        Me.txtQuantidade.BackColor = System.Drawing.Color.White
        Me.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidade.Location = New System.Drawing.Point(11, 98)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(87, 19)
        Me.txtQuantidade.TabIndex = 1
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantidade.ForeColor = System.Drawing.Color.Black
        Me.lblQuantidade.Location = New System.Drawing.Point(10, 75)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(96, 20)
        Me.lblQuantidade.TabIndex = 0
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnVoltar.BackgroundImage = CType(resources.GetObject("btnVoltar.BackgroundImage"), System.Drawing.Image)
        Me.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVoltar.FlatAppearance.BorderSize = 0
        Me.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltar.Location = New System.Drawing.Point(13, 352)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(60, 60)
        Me.btnVoltar.TabIndex = 7
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
        Me.btnExcluir.Location = New System.Drawing.Point(13, 286)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(60, 60)
        Me.btnExcluir.TabIndex = 6
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEditar.BackgroundImage = CType(resources.GetObject("btnEditar.BackgroundImage"), System.Drawing.Image)
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Location = New System.Drawing.Point(13, 220)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(60, 60)
        Me.btnEditar.TabIndex = 5
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAdicionar.BackgroundImage = CType(resources.GetObject("btnAdicionar.BackgroundImage"), System.Drawing.Image)
        Me.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdicionar.FlatAppearance.BorderSize = 0
        Me.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionar.Location = New System.Drawing.Point(13, 154)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(60, 60)
        Me.btnAdicionar.TabIndex = 1
        Me.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnAdicionar.UseVisualStyleBackColor = False
        '
        'EasyStockSystemDataSet
        '
        Me.EasyStockSystemDataSet.DataSetName = "EasyStockSystemDataSet"
        Me.EasyStockSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProdutosBindingSource
        '
        Me.ProdutosBindingSource.DataMember = "produtos"
        Me.ProdutosBindingSource.DataSource = Me.EasyStockSystemDataSet
        '
        'ProdutosTableAdapter
        '
        Me.ProdutosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.administradoresTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.fornecedoresTableAdapter = Nothing
        Me.TableAdapterManager.produtos_has_vendaTableAdapter = Nothing
        Me.TableAdapterManager.produtosTableAdapter = Me.ProdutosTableAdapter
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
        'FornecedoresidDataGridViewTextBoxColumn
        '
        Me.FornecedoresidDataGridViewTextBoxColumn.DataPropertyName = "fornecedores_id"
        Me.FornecedoresidDataGridViewTextBoxColumn.HeaderText = "fornecedores_id"
        Me.FornecedoresidDataGridViewTextBoxColumn.Name = "FornecedoresidDataGridViewTextBoxColumn"
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "nome"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        '
        'QuantidadeDataGridViewTextBoxColumn
        '
        Me.QuantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade"
        Me.QuantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade"
        Me.QuantidadeDataGridViewTextBoxColumn.Name = "QuantidadeDataGridViewTextBoxColumn"
        '
        'CategoriaDataGridViewTextBoxColumn
        '
        Me.CategoriaDataGridViewTextBoxColumn.DataPropertyName = "categoria"
        Me.CategoriaDataGridViewTextBoxColumn.HeaderText = "categoria"
        Me.CategoriaDataGridViewTextBoxColumn.Name = "CategoriaDataGridViewTextBoxColumn"
        '
        'EstoqueminimoDataGridViewTextBoxColumn
        '
        Me.EstoqueminimoDataGridViewTextBoxColumn.DataPropertyName = "estoque_minimo"
        Me.EstoqueminimoDataGridViewTextBoxColumn.HeaderText = "estoque_minimo"
        Me.EstoqueminimoDataGridViewTextBoxColumn.Name = "EstoqueminimoDataGridViewTextBoxColumn"
        '
        'ValorcustoDataGridViewTextBoxColumn
        '
        Me.ValorcustoDataGridViewTextBoxColumn.DataPropertyName = "valor_custo"
        Me.ValorcustoDataGridViewTextBoxColumn.HeaderText = "valor_custo"
        Me.ValorcustoDataGridViewTextBoxColumn.Name = "ValorcustoDataGridViewTextBoxColumn"
        '
        'ValorvendaDataGridViewTextBoxColumn
        '
        Me.ValorvendaDataGridViewTextBoxColumn.DataPropertyName = "valor_venda"
        Me.ValorvendaDataGridViewTextBoxColumn.HeaderText = "valor_venda"
        Me.ValorvendaDataGridViewTextBoxColumn.Name = "ValorvendaDataGridViewTextBoxColumn"
        '
        'frmProdutos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.gpxProduto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(700, 480)
        Me.Name = "frmProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Produtos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxProduto.ResumeLayout(False)
        Me.gpxProduto.PerformLayout()
        CType(Me.EasyStockSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents gpxProduto As System.Windows.Forms.GroupBox
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents cbxFornecedor As System.Windows.Forms.ComboBox
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents txtValorVenda As System.Windows.Forms.TextBox
    Friend WithEvents txtValorCusto As System.Windows.Forms.TextBox
    Friend WithEvents lblValorVenda As System.Windows.Forms.Label
    Friend WithEvents lblValorCusto As System.Windows.Forms.Label
    Friend WithEvents txtEstoqueMinimo As System.Windows.Forms.TextBox
    Friend WithEvents lblEstoqueMinimo As System.Windows.Forms.Label
    Friend WithEvents lblCategoria As System.Windows.Forms.Label
    Friend WithEvents cbxCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
    Friend WithEvents EasyStockSystemDataSet As TrabalhoG2_VB.EasyStockSystemDataSet
    Friend WithEvents ProdutosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProdutosTableAdapter As TrabalhoG2_VB.EasyStockSystemDataSetTableAdapters.produtosTableAdapter
    Friend WithEvents TableAdapterManager As TrabalhoG2_VB.EasyStockSystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FornecedoresidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantidadeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstoqueminimoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorcustoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorvendaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
