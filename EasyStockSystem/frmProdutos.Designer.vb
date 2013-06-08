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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProdutos))
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.lblEstoqueMinimo = New System.Windows.Forms.Label()
        Me.lblValorVenda = New System.Windows.Forms.Label()
        Me.lblValorCusto = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.txtEstoqueMinimo = New System.Windows.Forms.TextBox()
        Me.txtValorCusto = New System.Windows.Forms.TextBox()
        Me.txtValorVenda = New System.Windows.Forms.TextBox()
        Me.cbxCategoria = New System.Windows.Forms.ComboBox()
        Me.cbxFornecedor = New System.Windows.Forms.ComboBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.gpxAcoes = New System.Windows.Forms.GroupBox()
        Me.gpxAlteracoes = New System.Windows.Forms.GroupBox()
        Me.lblProdutos = New System.Windows.Forms.Label()
        Me.gpxBotoes = New System.Windows.Forms.GroupBox()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.pbxProduto = New System.Windows.Forms.PictureBox()
        Me.gpxAlteracoes.SuspendLayout()
        Me.gpxBotoes.SuspendLayout()
        CType(Me.pbxProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.ForeColor = System.Drawing.Color.White
        Me.lblNome.Location = New System.Drawing.Point(13, 112)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(76, 20)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Desrição:"
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantidade.ForeColor = System.Drawing.Color.White
        Me.lblQuantidade.Location = New System.Drawing.Point(367, 64)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(96, 20)
        Me.lblQuantidade.TabIndex = 1
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.ForeColor = System.Drawing.Color.White
        Me.lblCategoria.Location = New System.Drawing.Point(13, 161)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(82, 20)
        Me.lblCategoria.TabIndex = 2
        Me.lblCategoria.Text = "Categoria:"
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFornecedor.ForeColor = System.Drawing.Color.White
        Me.lblFornecedor.Location = New System.Drawing.Point(1, 120)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(95, 20)
        Me.lblFornecedor.TabIndex = 3
        Me.lblFornecedor.Text = "Fornecedor:"
        '
        'lblEstoqueMinimo
        '
        Me.lblEstoqueMinimo.AutoSize = True
        Me.lblEstoqueMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstoqueMinimo.ForeColor = System.Drawing.Color.White
        Me.lblEstoqueMinimo.Location = New System.Drawing.Point(367, 120)
        Me.lblEstoqueMinimo.Name = "lblEstoqueMinimo"
        Me.lblEstoqueMinimo.Size = New System.Drawing.Size(127, 20)
        Me.lblEstoqueMinimo.TabIndex = 4
        Me.lblEstoqueMinimo.Text = "Estoque Mínimo:"
        '
        'lblValorVenda
        '
        Me.lblValorVenda.AutoSize = True
        Me.lblValorVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorVenda.ForeColor = System.Drawing.Color.White
        Me.lblValorVenda.Location = New System.Drawing.Point(367, 176)
        Me.lblValorVenda.Name = "lblValorVenda"
        Me.lblValorVenda.Size = New System.Drawing.Size(123, 20)
        Me.lblValorVenda.TabIndex = 5
        Me.lblValorVenda.Text = "Valor de Venda:"
        '
        'lblValorCusto
        '
        Me.lblValorCusto.AutoSize = True
        Me.lblValorCusto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorCusto.ForeColor = System.Drawing.Color.White
        Me.lblValorCusto.Location = New System.Drawing.Point(1, 176)
        Me.lblValorCusto.Name = "lblValorCusto"
        Me.lblValorCusto.Size = New System.Drawing.Size(118, 20)
        Me.lblValorCusto.TabIndex = 6
        Me.lblValorCusto.Text = "Valor de Custo:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(16, 136)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(491, 20)
        Me.txtNome.TabIndex = 7
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(371, 90)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(72, 20)
        Me.txtQuantidade.TabIndex = 8
        '
        'txtEstoqueMinimo
        '
        Me.txtEstoqueMinimo.Location = New System.Drawing.Point(371, 148)
        Me.txtEstoqueMinimo.Name = "txtEstoqueMinimo"
        Me.txtEstoqueMinimo.Size = New System.Drawing.Size(72, 20)
        Me.txtEstoqueMinimo.TabIndex = 9
        '
        'txtValorCusto
        '
        Me.txtValorCusto.Location = New System.Drawing.Point(4, 199)
        Me.txtValorCusto.Name = "txtValorCusto"
        Me.txtValorCusto.Size = New System.Drawing.Size(100, 20)
        Me.txtValorCusto.TabIndex = 10
        '
        'txtValorVenda
        '
        Me.txtValorVenda.Location = New System.Drawing.Point(371, 199)
        Me.txtValorVenda.Name = "txtValorVenda"
        Me.txtValorVenda.Size = New System.Drawing.Size(100, 20)
        Me.txtValorVenda.TabIndex = 11
        '
        'cbxCategoria
        '
        Me.cbxCategoria.FormattingEnabled = True
        Me.cbxCategoria.Location = New System.Drawing.Point(16, 186)
        Me.cbxCategoria.Name = "cbxCategoria"
        Me.cbxCategoria.Size = New System.Drawing.Size(177, 21)
        Me.cbxCategoria.TabIndex = 12
        '
        'cbxFornecedor
        '
        Me.cbxFornecedor.FormattingEnabled = True
        Me.cbxFornecedor.Location = New System.Drawing.Point(16, 244)
        Me.cbxFornecedor.Name = "cbxFornecedor"
        Me.cbxFornecedor.Size = New System.Drawing.Size(177, 21)
        Me.cbxFornecedor.TabIndex = 13
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelar.ForeColor = System.Drawing.Color.Red
        Me.btnCancelar.Location = New System.Drawing.Point(16, 405)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(532, 34)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnConfirmar.FlatAppearance.BorderSize = 0
        Me.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnConfirmar.ForeColor = System.Drawing.Color.Green
        Me.btnConfirmar.Location = New System.Drawing.Point(5, 19)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(531, 34)
        Me.btnConfirmar.TabIndex = 15
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'gpxAcoes
        '
        Me.gpxAcoes.Location = New System.Drawing.Point(180, 1)
        Me.gpxAcoes.Name = "gpxAcoes"
        Me.gpxAcoes.Size = New System.Drawing.Size(376, 90)
        Me.gpxAcoes.TabIndex = 20
        Me.gpxAcoes.TabStop = False
        '
        'gpxAlteracoes
        '
        Me.gpxAlteracoes.Controls.Add(Me.lblQuantidade)
        Me.gpxAlteracoes.Controls.Add(Me.txtQuantidade)
        Me.gpxAlteracoes.Controls.Add(Me.lblFornecedor)
        Me.gpxAlteracoes.Controls.Add(Me.lblEstoqueMinimo)
        Me.gpxAlteracoes.Controls.Add(Me.txtEstoqueMinimo)
        Me.gpxAlteracoes.Controls.Add(Me.lblValorCusto)
        Me.gpxAlteracoes.Controls.Add(Me.txtValorCusto)
        Me.gpxAlteracoes.Controls.Add(Me.lblValorVenda)
        Me.gpxAlteracoes.Controls.Add(Me.txtValorVenda)
        Me.gpxAlteracoes.Location = New System.Drawing.Point(12, 97)
        Me.gpxAlteracoes.Name = "gpxAlteracoes"
        Me.gpxAlteracoes.Size = New System.Drawing.Size(544, 232)
        Me.gpxAlteracoes.TabIndex = 21
        Me.gpxAlteracoes.TabStop = False
        '
        'lblProdutos
        '
        Me.lblProdutos.AutoSize = True
        Me.lblProdutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdutos.Location = New System.Drawing.Point(36, 2)
        Me.lblProdutos.Name = "lblProdutos"
        Me.lblProdutos.Size = New System.Drawing.Size(99, 20)
        Me.lblProdutos.TabIndex = 22
        Me.lblProdutos.Text = "PRODUTOS"
        '
        'gpxBotoes
        '
        Me.gpxBotoes.Controls.Add(Me.btnConfirmar)
        Me.gpxBotoes.Location = New System.Drawing.Point(12, 336)
        Me.gpxBotoes.Name = "gpxBotoes"
        Me.gpxBotoes.Size = New System.Drawing.Size(544, 113)
        Me.gpxBotoes.TabIndex = 23
        Me.gpxBotoes.TabStop = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.SlateGray
        Me.btnExcluir.BackgroundImage = Global.EasyStockSystem.My.Resources.Resources._40
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Location = New System.Drawing.Point(427, 15)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(121, 66)
        Me.btnExcluir.TabIndex = 19
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.SlateGray
        Me.btnEditar.BackgroundImage = Global.EasyStockSystem.My.Resources.Resources._36Edit
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(305, 14)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(116, 66)
        Me.btnEditar.TabIndex = 18
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btNovo
        '
        Me.btNovo.BackColor = System.Drawing.Color.SlateGray
        Me.btNovo.BackgroundImage = Global.EasyStockSystem.My.Resources.Resources._41
        Me.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btNovo.FlatAppearance.BorderSize = 0
        Me.btNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btNovo.Location = New System.Drawing.Point(187, 13)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(112, 66)
        Me.btNovo.TabIndex = 17
        Me.btNovo.Text = "Novo"
        Me.btNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btNovo.UseVisualStyleBackColor = False
        '
        'pbxProduto
        '
        Me.pbxProduto.Image = Global.EasyStockSystem.My.Resources.Resources._36
        Me.pbxProduto.Location = New System.Drawing.Point(40, 25)
        Me.pbxProduto.Name = "pbxProduto"
        Me.pbxProduto.Size = New System.Drawing.Size(91, 66)
        Me.pbxProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxProduto.TabIndex = 16
        Me.pbxProduto.TabStop = False
        '
        'frmProdutos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.lblProdutos)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btNovo)
        Me.Controls.Add(Me.pbxProduto)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.cbxFornecedor)
        Me.Controls.Add(Me.cbxCategoria)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.gpxAcoes)
        Me.Controls.Add(Me.gpxAlteracoes)
        Me.Controls.Add(Me.gpxBotoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 500)
        Me.Name = "frmProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Produtos"
        Me.gpxAlteracoes.ResumeLayout(False)
        Me.gpxAlteracoes.PerformLayout()
        Me.gpxBotoes.ResumeLayout(False)
        CType(Me.pbxProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents lblCategoria As System.Windows.Forms.Label
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents lblEstoqueMinimo As System.Windows.Forms.Label
    Friend WithEvents lblValorVenda As System.Windows.Forms.Label
    Friend WithEvents lblValorCusto As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents txtEstoqueMinimo As System.Windows.Forms.TextBox
    Friend WithEvents txtValorCusto As System.Windows.Forms.TextBox
    Friend WithEvents txtValorVenda As System.Windows.Forms.TextBox
    Friend WithEvents cbxCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents cbxFornecedor As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents pbxProduto As System.Windows.Forms.PictureBox
    Friend WithEvents btNovo As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents gpxAcoes As System.Windows.Forms.GroupBox
    Friend WithEvents gpxAlteracoes As System.Windows.Forms.GroupBox
    Friend WithEvents lblProdutos As System.Windows.Forms.Label
    Friend WithEvents gpxBotoes As System.Windows.Forms.GroupBox
End Class
