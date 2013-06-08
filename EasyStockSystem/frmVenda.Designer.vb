<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenda
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
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.lblDataDaVenda = New System.Windows.Forms.Label()
        Me.dtpDataVenda = New System.Windows.Forms.DateTimePicker()
        Me.lblvalorTotal = New System.Windows.Forms.Label()
        Me.txtValorTotal = New System.Windows.Forms.TextBox()
        Me.dgvProdutosVenda = New System.Windows.Forms.DataGridView()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gpxBotoes = New System.Windows.Forms.GroupBox()
        Me.gpxAdicionarProduto = New System.Windows.Forms.GroupBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.lblDesconto = New System.Windows.Forms.Label()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        CType(Me.dgvProdutosVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxBotoes.SuspendLayout()
        Me.gpxAdicionarProduto.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblVendedor
        '
        Me.lblVendedor.AutoSize = True
        Me.lblVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendedor.ForeColor = System.Drawing.Color.White
        Me.lblVendedor.Location = New System.Drawing.Point(198, 9)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(83, 20)
        Me.lblVendedor.TabIndex = 0
        Me.lblVendedor.Text = "Vendedor:"
        '
        'txtVendedor
        '
        Me.txtVendedor.Enabled = False
        Me.txtVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVendedor.Location = New System.Drawing.Point(199, 28)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.Size = New System.Drawing.Size(100, 26)
        Me.txtVendedor.TabIndex = 1
        '
        'lblDataDaVenda
        '
        Me.lblDataDaVenda.AutoSize = True
        Me.lblDataDaVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataDaVenda.ForeColor = System.Drawing.Color.White
        Me.lblDataDaVenda.Location = New System.Drawing.Point(338, 9)
        Me.lblDataDaVenda.Name = "lblDataDaVenda"
        Me.lblDataDaVenda.Size = New System.Drawing.Size(121, 20)
        Me.lblDataDaVenda.TabIndex = 2
        Me.lblDataDaVenda.Text = "Data da Venda:"
        '
        'dtpDataVenda
        '
        Me.dtpDataVenda.Enabled = False
        Me.dtpDataVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataVenda.Location = New System.Drawing.Point(341, 28)
        Me.dtpDataVenda.Name = "dtpDataVenda"
        Me.dtpDataVenda.Size = New System.Drawing.Size(315, 26)
        Me.dtpDataVenda.TabIndex = 3
        '
        'lblvalorTotal
        '
        Me.lblvalorTotal.AutoSize = True
        Me.lblvalorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvalorTotal.ForeColor = System.Drawing.Color.White
        Me.lblvalorTotal.Location = New System.Drawing.Point(573, 368)
        Me.lblvalorTotal.Name = "lblvalorTotal"
        Me.lblvalorTotal.Size = New System.Drawing.Size(83, 31)
        Me.lblvalorTotal.TabIndex = 4
        Me.lblvalorTotal.Text = "Total:"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Enabled = False
        Me.txtValorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotal.ForeColor = System.Drawing.Color.Red
        Me.txtValorTotal.Location = New System.Drawing.Point(658, 355)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(100, 44)
        Me.txtValorTotal.TabIndex = 5
        '
        'dgvProdutosVenda
        '
        Me.dgvProdutosVenda.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvProdutosVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutosVenda.Location = New System.Drawing.Point(199, 66)
        Me.dgvProdutosVenda.Name = "dgvProdutosVenda"
        Me.dgvProdutosVenda.Size = New System.Drawing.Size(559, 283)
        Me.dgvProdutosVenda.TabIndex = 6
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnConfirmar.FlatAppearance.BorderSize = 0
        Me.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ForeColor = System.Drawing.Color.Green
        Me.btnConfirmar.Location = New System.Drawing.Point(6, 17)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(727, 34)
        Me.btnConfirmar.TabIndex = 7
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Red
        Me.btnCancelar.Location = New System.Drawing.Point(6, 59)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(727, 34)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'gpxBotoes
        '
        Me.gpxBotoes.Controls.Add(Me.btnCancelar)
        Me.gpxBotoes.Controls.Add(Me.btnConfirmar)
        Me.gpxBotoes.Location = New System.Drawing.Point(13, 406)
        Me.gpxBotoes.Name = "gpxBotoes"
        Me.gpxBotoes.Size = New System.Drawing.Size(739, 100)
        Me.gpxBotoes.TabIndex = 9
        Me.gpxBotoes.TabStop = False
        '
        'gpxAdicionarProduto
        '
        Me.gpxAdicionarProduto.Controls.Add(Me.txtDescricao)
        Me.gpxAdicionarProduto.Controls.Add(Me.lblDescricao)
        Me.gpxAdicionarProduto.Controls.Add(Me.btnAdicionar)
        Me.gpxAdicionarProduto.Controls.Add(Me.txtQuantidade)
        Me.gpxAdicionarProduto.Controls.Add(Me.lblQuantidade)
        Me.gpxAdicionarProduto.Controls.Add(Me.btnPesquisar)
        Me.gpxAdicionarProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpxAdicionarProduto.ForeColor = System.Drawing.Color.White
        Me.gpxAdicionarProduto.Location = New System.Drawing.Point(4, 13)
        Me.gpxAdicionarProduto.Name = "gpxAdicionarProduto"
        Me.gpxAdicionarProduto.Size = New System.Drawing.Size(188, 336)
        Me.gpxAdicionarProduto.TabIndex = 10
        Me.gpxAdicionarProduto.TabStop = False
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(38, 208)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(96, 20)
        Me.lblQuantidade.TabIndex = 1
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQuantidade.Location = New System.Drawing.Point(37, 231)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(100, 19)
        Me.txtQuantidade.TabIndex = 2
        Me.txtQuantidade.Text = "1"
        Me.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(50, 95)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(84, 20)
        Me.lblDescricao.TabIndex = 4
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtDescricao
        '
        Me.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescricao.Location = New System.Drawing.Point(7, 117)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(175, 88)
        Me.txtDescricao.TabIndex = 5
        Me.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnAdicionar.BackgroundImage = Global.EasyStockSystem.My.Resources.Resources._97
        Me.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdicionar.FlatAppearance.BorderSize = 0
        Me.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionar.Location = New System.Drawing.Point(4, 256)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(180, 74)
        Me.btnAdicionar.TabIndex = 3
        Me.btnAdicionar.Text = "Adicionar à lista"
        Me.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdicionar.UseVisualStyleBackColor = False
        '
        'btnPesquisar
        '
        Me.btnPesquisar.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnPesquisar.BackgroundImage = Global.EasyStockSystem.My.Resources.Resources._16
        Me.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPesquisar.FlatAppearance.BorderSize = 0
        Me.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesquisar.Location = New System.Drawing.Point(4, 26)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(180, 61)
        Me.btnPesquisar.TabIndex = 0
        Me.btnPesquisar.Text = "Pesquisar Item"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.UseVisualStyleBackColor = False
        '
        'lblDesconto
        '
        Me.lblDesconto.AutoSize = True
        Me.lblDesconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesconto.ForeColor = System.Drawing.Color.White
        Me.lblDesconto.Location = New System.Drawing.Point(278, 378)
        Me.lblDesconto.Name = "lblDesconto"
        Me.lblDesconto.Size = New System.Drawing.Size(110, 26)
        Me.lblDesconto.TabIndex = 11
        Me.lblDesconto.Text = "Desconto:"
        '
        'txtDesconto
        '
        Me.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDesconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesconto.Location = New System.Drawing.Point(395, 378)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(100, 25)
        Me.txtDesconto.TabIndex = 12
        '
        'frmVenda
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(764, 511)
        Me.Controls.Add(Me.txtDesconto)
        Me.Controls.Add(Me.lblDesconto)
        Me.Controls.Add(Me.gpxAdicionarProduto)
        Me.Controls.Add(Me.dgvProdutosVenda)
        Me.Controls.Add(Me.txtValorTotal)
        Me.Controls.Add(Me.lblvalorTotal)
        Me.Controls.Add(Me.dtpDataVenda)
        Me.Controls.Add(Me.lblDataDaVenda)
        Me.Controls.Add(Me.txtVendedor)
        Me.Controls.Add(Me.lblVendedor)
        Me.Controls.Add(Me.gpxBotoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmVenda"
        Me.Text = "Venda"
        CType(Me.dgvProdutosVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxBotoes.ResumeLayout(False)
        Me.gpxAdicionarProduto.ResumeLayout(False)
        Me.gpxAdicionarProduto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblVendedor As System.Windows.Forms.Label
    Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
    Friend WithEvents lblDataDaVenda As System.Windows.Forms.Label
    Friend WithEvents dtpDataVenda As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblvalorTotal As System.Windows.Forms.Label
    Friend WithEvents txtValorTotal As System.Windows.Forms.TextBox
    Friend WithEvents dgvProdutosVenda As System.Windows.Forms.DataGridView
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents gpxBotoes As System.Windows.Forms.GroupBox
    Friend WithEvents gpxAdicionarProduto As System.Windows.Forms.GroupBox
    Friend WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents lblDesconto As System.Windows.Forms.Label
    Friend WithEvents txtDesconto As System.Windows.Forms.TextBox
End Class
