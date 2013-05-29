<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendas))
        Me.lblDataVenda = New System.Windows.Forms.Label()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.lblValorUnitario = New System.Windows.Forms.Label()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.dtpDataVenda = New System.Windows.Forms.DateTimePicker()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.txtProduto = New System.Windows.Forms.TextBox()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.txtValorUnitario = New System.Windows.Forms.TextBox()
        Me.txtValorTotal = New System.Windows.Forms.TextBox()
        Me.dgvVenda = New System.Windows.Forms.DataGridView()
        Me.gpxFinalizarVenda = New System.Windows.Forms.GroupBox()
        Me.btnFinalizarVenda = New System.Windows.Forms.Button()
        Me.txtTotalVenda = New System.Windows.Forms.TextBox()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.txtQuantidadeItens = New System.Windows.Forms.TextBox()
        Me.lblValorTotalVenda = New System.Windows.Forms.Label()
        Me.lblDesconto = New System.Windows.Forms.Label()
        Me.lblQuantidadeItens = New System.Windows.Forms.Label()
        Me.btnExcluirProduto = New System.Windows.Forms.Button()
        Me.btnEditarProduto = New System.Windows.Forms.Button()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.btnLocalizarProduto = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.EasyStockSystemDataSet = New TrabalhoG2_VB.EasyStockSystemDataSet()
        Me.VendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendaTableAdapter = New TrabalhoG2_VB.EasyStockSystemDataSetTableAdapters.vendaTableAdapter()
        Me.TableAdapterManager = New TrabalhoG2_VB.EasyStockSystemDataSetTableAdapters.TableAdapterManager()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendedoresidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatavendaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValortotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxFinalizarVenda.SuspendLayout()
        CType(Me.EasyStockSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDataVenda
        '
        Me.lblDataVenda.AutoSize = True
        Me.lblDataVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataVenda.Location = New System.Drawing.Point(6, 13)
        Me.lblDataVenda.Name = "lblDataVenda"
        Me.lblDataVenda.Size = New System.Drawing.Size(121, 20)
        Me.lblDataVenda.TabIndex = 0
        Me.lblDataVenda.Text = "Data da Venda:"
        '
        'lblVendedor
        '
        Me.lblVendedor.AutoSize = True
        Me.lblVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendedor.Location = New System.Drawing.Point(297, 11)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(83, 20)
        Me.lblVendedor.TabIndex = 1
        Me.lblVendedor.Text = "Vendedor:"
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduto.Location = New System.Drawing.Point(9, 58)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(166, 20)
        Me.lblProduto.TabIndex = 2
        Me.lblProduto.Text = "Descrição do Produto:"
        '
        'lblValorUnitario
        '
        Me.lblValorUnitario.AutoSize = True
        Me.lblValorUnitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorUnitario.Location = New System.Drawing.Point(554, 11)
        Me.lblValorUnitario.Name = "lblValorUnitario"
        Me.lblValorUnitario.Size = New System.Drawing.Size(109, 20)
        Me.lblValorUnitario.TabIndex = 3
        Me.lblValorUnitario.Text = "Valor Unitário:"
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantidade.Location = New System.Drawing.Point(456, 11)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(96, 20)
        Me.lblQuantidade.TabIndex = 4
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'lblValorTotal
        '
        Me.lblValorTotal.AutoSize = True
        Me.lblValorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorTotal.Location = New System.Drawing.Point(554, 60)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(89, 20)
        Me.lblValorTotal.TabIndex = 5
        Me.lblValorTotal.Text = "Valor Total:"
        '
        'dtpDataVenda
        '
        Me.dtpDataVenda.Enabled = False
        Me.dtpDataVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataVenda.Location = New System.Drawing.Point(10, 30)
        Me.dtpDataVenda.Name = "dtpDataVenda"
        Me.dtpDataVenda.Size = New System.Drawing.Size(269, 23)
        Me.dtpDataVenda.TabIndex = 6
        '
        'txtVendedor
        '
        Me.txtVendedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVendedor.Enabled = False
        Me.txtVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVendedor.Location = New System.Drawing.Point(301, 30)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.Size = New System.Drawing.Size(149, 19)
        Me.txtVendedor.TabIndex = 7
        '
        'txtProduto
        '
        Me.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduto.Location = New System.Drawing.Point(10, 79)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(512, 19)
        Me.txtProduto.TabIndex = 8
        '
        'txtQuantidade
        '
        Me.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidade.Location = New System.Drawing.Point(460, 30)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(62, 19)
        Me.txtQuantidade.TabIndex = 9
        Me.txtQuantidade.Text = "1"
        Me.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtValorUnitario
        '
        Me.txtValorUnitario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValorUnitario.Enabled = False
        Me.txtValorUnitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorUnitario.Location = New System.Drawing.Point(558, 30)
        Me.txtValorUnitario.Name = "txtValorUnitario"
        Me.txtValorUnitario.Size = New System.Drawing.Size(100, 19)
        Me.txtValorUnitario.TabIndex = 10
        Me.txtValorUnitario.Text = "0,00"
        Me.txtValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtValorTotal
        '
        Me.txtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValorTotal.Enabled = False
        Me.txtValorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotal.Location = New System.Drawing.Point(558, 79)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(100, 19)
        Me.txtValorTotal.TabIndex = 11
        Me.txtValorTotal.Text = "0,00"
        Me.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvVenda
        '
        Me.dgvVenda.AllowUserToAddRows = False
        Me.dgvVenda.AllowUserToDeleteRows = False
        Me.dgvVenda.AllowUserToResizeColumns = False
        Me.dgvVenda.AllowUserToResizeRows = False
        Me.dgvVenda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvVenda.AutoGenerateColumns = False
        Me.dgvVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVenda.BackgroundColor = System.Drawing.Color.White
        Me.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVenda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.VendedoresidDataGridViewTextBoxColumn, Me.DatavendaDataGridViewTextBoxColumn, Me.ValortotalDataGridViewTextBoxColumn, Me.QuantidadeDataGridViewTextBoxColumn})
        Me.dgvVenda.DataSource = Me.VendaBindingSource
        Me.dgvVenda.Location = New System.Drawing.Point(83, 133)
        Me.dgvVenda.Name = "dgvVenda"
        Me.dgvVenda.RowHeadersVisible = False
        Me.dgvVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVenda.Size = New System.Drawing.Size(672, 285)
        Me.dgvVenda.TabIndex = 12
        '
        'gpxFinalizarVenda
        '
        Me.gpxFinalizarVenda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpxFinalizarVenda.Controls.Add(Me.btnFinalizarVenda)
        Me.gpxFinalizarVenda.Controls.Add(Me.txtTotalVenda)
        Me.gpxFinalizarVenda.Controls.Add(Me.txtDesconto)
        Me.gpxFinalizarVenda.Controls.Add(Me.txtQuantidadeItens)
        Me.gpxFinalizarVenda.Controls.Add(Me.lblValorTotalVenda)
        Me.gpxFinalizarVenda.Controls.Add(Me.lblDesconto)
        Me.gpxFinalizarVenda.Controls.Add(Me.lblQuantidadeItens)
        Me.gpxFinalizarVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpxFinalizarVenda.ForeColor = System.Drawing.Color.White
        Me.gpxFinalizarVenda.Location = New System.Drawing.Point(4, 425)
        Me.gpxFinalizarVenda.Name = "gpxFinalizarVenda"
        Me.gpxFinalizarVenda.Size = New System.Drawing.Size(751, 133)
        Me.gpxFinalizarVenda.TabIndex = 15
        Me.gpxFinalizarVenda.TabStop = False
        Me.gpxFinalizarVenda.Text = "Finalizar Venda:"
        '
        'btnFinalizarVenda
        '
        Me.btnFinalizarVenda.BackColor = System.Drawing.Color.SteelBlue
        Me.btnFinalizarVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFinalizarVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnFinalizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizarVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizarVenda.Image = CType(resources.GetObject("btnFinalizarVenda.Image"), System.Drawing.Image)
        Me.btnFinalizarVenda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFinalizarVenda.Location = New System.Drawing.Point(600, 15)
        Me.btnFinalizarVenda.Name = "btnFinalizarVenda"
        Me.btnFinalizarVenda.Size = New System.Drawing.Size(145, 109)
        Me.btnFinalizarVenda.TabIndex = 6
        Me.btnFinalizarVenda.Text = "Finalizar Venda"
        Me.btnFinalizarVenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFinalizarVenda.UseCompatibleTextRendering = True
        Me.btnFinalizarVenda.UseVisualStyleBackColor = False
        '
        'txtTotalVenda
        '
        Me.txtTotalVenda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalVenda.Enabled = False
        Me.txtTotalVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalVenda.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTotalVenda.Location = New System.Drawing.Point(353, 54)
        Me.txtTotalVenda.Name = "txtTotalVenda"
        Me.txtTotalVenda.Size = New System.Drawing.Size(148, 46)
        Me.txtTotalVenda.TabIndex = 5
        Me.txtTotalVenda.Text = "0,00"
        Me.txtTotalVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesconto
        '
        Me.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDesconto.Location = New System.Drawing.Point(191, 56)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(115, 19)
        Me.txtDesconto.TabIndex = 4
        Me.txtDesconto.Text = "0"
        Me.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtQuantidadeItens
        '
        Me.txtQuantidadeItens.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQuantidadeItens.Enabled = False
        Me.txtQuantidadeItens.Location = New System.Drawing.Point(21, 54)
        Me.txtQuantidadeItens.Name = "txtQuantidadeItens"
        Me.txtQuantidadeItens.Size = New System.Drawing.Size(100, 19)
        Me.txtQuantidadeItens.TabIndex = 3
        Me.txtQuantidadeItens.Text = "0"
        Me.txtQuantidadeItens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblValorTotalVenda
        '
        Me.lblValorTotalVenda.AutoSize = True
        Me.lblValorTotalVenda.ForeColor = System.Drawing.Color.Black
        Me.lblValorTotalVenda.Location = New System.Drawing.Point(350, 33)
        Me.lblValorTotalVenda.Name = "lblValorTotalVenda"
        Me.lblValorTotalVenda.Size = New System.Drawing.Size(48, 20)
        Me.lblValorTotalVenda.TabIndex = 2
        Me.lblValorTotalVenda.Text = "Total:"
        '
        'lblDesconto
        '
        Me.lblDesconto.AutoSize = True
        Me.lblDesconto.ForeColor = System.Drawing.Color.Black
        Me.lblDesconto.Location = New System.Drawing.Point(188, 33)
        Me.lblDesconto.Name = "lblDesconto"
        Me.lblDesconto.Size = New System.Drawing.Size(110, 20)
        Me.lblDesconto.TabIndex = 1
        Me.lblDesconto.Text = "Desconto: (%)"
        '
        'lblQuantidadeItens
        '
        Me.lblQuantidadeItens.AutoSize = True
        Me.lblQuantidadeItens.ForeColor = System.Drawing.Color.Black
        Me.lblQuantidadeItens.Location = New System.Drawing.Point(18, 33)
        Me.lblQuantidadeItens.Name = "lblQuantidadeItens"
        Me.lblQuantidadeItens.Size = New System.Drawing.Size(131, 20)
        Me.lblQuantidadeItens.TabIndex = 0
        Me.lblQuantidadeItens.Text = "Numero de Itens:"
        '
        'btnExcluirProduto
        '
        Me.btnExcluirProduto.BackColor = System.Drawing.Color.SteelBlue
        Me.btnExcluirProduto.BackgroundImage = CType(resources.GetObject("btnExcluirProduto.BackgroundImage"), System.Drawing.Image)
        Me.btnExcluirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExcluirProduto.FlatAppearance.BorderSize = 0
        Me.btnExcluirProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluirProduto.Location = New System.Drawing.Point(13, 283)
        Me.btnExcluirProduto.Name = "btnExcluirProduto"
        Me.btnExcluirProduto.Size = New System.Drawing.Size(60, 60)
        Me.btnExcluirProduto.TabIndex = 19
        Me.btnExcluirProduto.UseVisualStyleBackColor = False
        '
        'btnEditarProduto
        '
        Me.btnEditarProduto.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEditarProduto.BackgroundImage = CType(resources.GetObject("btnEditarProduto.BackgroundImage"), System.Drawing.Image)
        Me.btnEditarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEditarProduto.FlatAppearance.BorderSize = 0
        Me.btnEditarProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnEditarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarProduto.Location = New System.Drawing.Point(12, 214)
        Me.btnEditarProduto.Name = "btnEditarProduto"
        Me.btnEditarProduto.Size = New System.Drawing.Size(60, 60)
        Me.btnEditarProduto.TabIndex = 18
        Me.btnEditarProduto.UseVisualStyleBackColor = False
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnVoltar.BackgroundImage = CType(resources.GetObject("btnVoltar.BackgroundImage"), System.Drawing.Image)
        Me.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVoltar.FlatAppearance.BorderSize = 0
        Me.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltar.Location = New System.Drawing.Point(13, 359)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(60, 60)
        Me.btnVoltar.TabIndex = 17
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'btnLocalizarProduto
        '
        Me.btnLocalizarProduto.BackColor = System.Drawing.Color.SteelBlue
        Me.btnLocalizarProduto.BackgroundImage = CType(resources.GetObject("btnLocalizarProduto.BackgroundImage"), System.Drawing.Image)
        Me.btnLocalizarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLocalizarProduto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLocalizarProduto.FlatAppearance.BorderSize = 0
        Me.btnLocalizarProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnLocalizarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLocalizarProduto.Location = New System.Drawing.Point(12, 143)
        Me.btnLocalizarProduto.Name = "btnLocalizarProduto"
        Me.btnLocalizarProduto.Size = New System.Drawing.Size(60, 60)
        Me.btnLocalizarProduto.TabIndex = 16
        Me.btnLocalizarProduto.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(669, 69)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(60, 50)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAdicionar.BackgroundImage = CType(resources.GetObject("btnAdicionar.BackgroundImage"), System.Drawing.Image)
        Me.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdicionar.FlatAppearance.BorderSize = 0
        Me.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionar.Location = New System.Drawing.Point(669, 12)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(60, 50)
        Me.btnAdicionar.TabIndex = 13
        Me.btnAdicionar.UseVisualStyleBackColor = False
        '
        'EasyStockSystemDataSet
        '
        Me.EasyStockSystemDataSet.DataSetName = "EasyStockSystemDataSet"
        Me.EasyStockSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VendaBindingSource
        '
        Me.VendaBindingSource.DataMember = "venda"
        Me.VendaBindingSource.DataSource = Me.EasyStockSystemDataSet
        '
        'VendaTableAdapter
        '
        Me.VendaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.administradoresTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.fornecedoresTableAdapter = Nothing
        Me.TableAdapterManager.produtos_has_vendaTableAdapter = Nothing
        Me.TableAdapterManager.produtosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TrabalhoG2_VB.EasyStockSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vendaTableAdapter = Me.VendaTableAdapter
        Me.TableAdapterManager.vendedoresTableAdapter = Nothing
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VendedoresidDataGridViewTextBoxColumn
        '
        Me.VendedoresidDataGridViewTextBoxColumn.DataPropertyName = "vendedores_id"
        Me.VendedoresidDataGridViewTextBoxColumn.HeaderText = "vendedores_id"
        Me.VendedoresidDataGridViewTextBoxColumn.Name = "VendedoresidDataGridViewTextBoxColumn"
        '
        'DatavendaDataGridViewTextBoxColumn
        '
        Me.DatavendaDataGridViewTextBoxColumn.DataPropertyName = "data_venda"
        Me.DatavendaDataGridViewTextBoxColumn.HeaderText = "data_venda"
        Me.DatavendaDataGridViewTextBoxColumn.Name = "DatavendaDataGridViewTextBoxColumn"
        '
        'ValortotalDataGridViewTextBoxColumn
        '
        Me.ValortotalDataGridViewTextBoxColumn.DataPropertyName = "valor_total"
        Me.ValortotalDataGridViewTextBoxColumn.HeaderText = "valor_total"
        Me.ValortotalDataGridViewTextBoxColumn.Name = "ValortotalDataGridViewTextBoxColumn"
        '
        'QuantidadeDataGridViewTextBoxColumn
        '
        Me.QuantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade"
        Me.QuantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade"
        Me.QuantidadeDataGridViewTextBoxColumn.Name = "QuantidadeDataGridViewTextBoxColumn"
        '
        'frmVendas
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(764, 561)
        Me.Controls.Add(Me.btnExcluirProduto)
        Me.Controls.Add(Me.btnEditarProduto)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.btnLocalizarProduto)
        Me.Controls.Add(Me.gpxFinalizarVenda)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.dgvVenda)
        Me.Controls.Add(Me.txtValorTotal)
        Me.Controls.Add(Me.txtValorUnitario)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.txtProduto)
        Me.Controls.Add(Me.txtVendedor)
        Me.Controls.Add(Me.dtpDataVenda)
        Me.Controls.Add(Me.lblValorTotal)
        Me.Controls.Add(Me.lblQuantidade)
        Me.Controls.Add(Me.lblValorUnitario)
        Me.Controls.Add(Me.lblProduto)
        Me.Controls.Add(Me.lblVendedor)
        Me.Controls.Add(Me.lblDataVenda)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(780, 600)
        Me.Name = "frmVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmVendas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxFinalizarVenda.ResumeLayout(False)
        Me.gpxFinalizarVenda.PerformLayout()
        CType(Me.EasyStockSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDataVenda As System.Windows.Forms.Label
    Friend WithEvents lblVendedor As System.Windows.Forms.Label
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents lblValorUnitario As System.Windows.Forms.Label
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents lblValorTotal As System.Windows.Forms.Label
    Friend WithEvents dtpDataVenda As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
    Friend WithEvents txtProduto As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents txtValorUnitario As System.Windows.Forms.TextBox
    Friend WithEvents txtValorTotal As System.Windows.Forms.TextBox
    Friend WithEvents dgvVenda As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents gpxFinalizarVenda As System.Windows.Forms.GroupBox
    Friend WithEvents btnLocalizarProduto As System.Windows.Forms.Button
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
    Friend WithEvents btnFinalizarVenda As System.Windows.Forms.Button
    Friend WithEvents txtTotalVenda As System.Windows.Forms.TextBox
    Friend WithEvents txtDesconto As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantidadeItens As System.Windows.Forms.TextBox
    Friend WithEvents lblValorTotalVenda As System.Windows.Forms.Label
    Friend WithEvents lblDesconto As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeItens As System.Windows.Forms.Label
    Friend WithEvents btnEditarProduto As System.Windows.Forms.Button
    Friend WithEvents btnExcluirProduto As System.Windows.Forms.Button
    Friend WithEvents EasyStockSystemDataSet As TrabalhoG2_VB.EasyStockSystemDataSet
    Friend WithEvents VendaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VendaTableAdapter As TrabalhoG2_VB.EasyStockSystemDataSetTableAdapters.vendaTableAdapter
    Friend WithEvents TableAdapterManager As TrabalhoG2_VB.EasyStockSystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VendedoresidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatavendaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValortotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantidadeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
