<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mstPrincipal = New System.Windows.Forms.MenuStrip()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorcDeDescontoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtalhosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EasyStockSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblConectadoComo = New System.Windows.Forms.Label()
        Me.mstPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'mstPrincipal
        '
        Me.mstPrincipal.BackColor = System.Drawing.Color.CadetBlue
        Me.mstPrincipal.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.mstPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.EstoqueToolStripMenuItem, Me.VendasToolStripMenuItem, Me.RelatóriosToolStripMenuItem, Me.ConfiguraçõesToolStripMenuItem, Me.SobreToolStripMenuItem})
        Me.mstPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mstPrincipal.Name = "mstPrincipal"
        Me.mstPrincipal.Size = New System.Drawing.Size(1008, 29)
        Me.mstPrincipal.TabIndex = 2
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProdutosToolStripMenuItem, Me.FornecedoresToolStripMenuItem, Me.VendedoresToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Image = Global.EasyStockSystem.My.Resources.Resources._15
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(100, 25)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.ProdutosToolStripMenuItem.Text = "Produtos"
        '
        'FornecedoresToolStripMenuItem
        '
        Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        Me.FornecedoresToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.FornecedoresToolStripMenuItem.Text = "Fornecedores"
        '
        'VendedoresToolStripMenuItem
        '
        Me.VendedoresToolStripMenuItem.Name = "VendedoresToolStripMenuItem"
        Me.VendedoresToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.VendedoresToolStripMenuItem.Text = "Vendedores"
        '
        'EstoqueToolStripMenuItem
        '
        Me.EstoqueToolStripMenuItem.Image = Global.EasyStockSystem.My.Resources.Resources._35
        Me.EstoqueToolStripMenuItem.Name = "EstoqueToolStripMenuItem"
        Me.EstoqueToolStripMenuItem.Size = New System.Drawing.Size(121, 25)
        Me.EstoqueToolStripMenuItem.Text = "Ver Estoque"
        '
        'VendasToolStripMenuItem
        '
        Me.VendasToolStripMenuItem.Image = Global.EasyStockSystem.My.Resources.Resources._80
        Me.VendasToolStripMenuItem.Name = "VendasToolStripMenuItem"
        Me.VendasToolStripMenuItem.Size = New System.Drawing.Size(135, 25)
        Me.VendasToolStripMenuItem.Text = "Efetuar Venda"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.Image = Global.EasyStockSystem.My.Resources.Resources._44
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(108, 25)
        Me.RelatóriosToolStripMenuItem.Text = "Relatórios"
        '
        'ConfiguraçõesToolStripMenuItem
        '
        Me.ConfiguraçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuáriosToolStripMenuItem, Me.PorcDeDescontoToolStripMenuItem})
        Me.ConfiguraçõesToolStripMenuItem.Image = Global.EasyStockSystem.My.Resources.Resources._84
        Me.ConfiguraçõesToolStripMenuItem.Name = "ConfiguraçõesToolStripMenuItem"
        Me.ConfiguraçõesToolStripMenuItem.Size = New System.Drawing.Size(138, 25)
        Me.ConfiguraçõesToolStripMenuItem.Text = "Configurações"
        '
        'UsuáriosToolStripMenuItem
        '
        Me.UsuáriosToolStripMenuItem.Name = "UsuáriosToolStripMenuItem"
        Me.UsuáriosToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.UsuáriosToolStripMenuItem.Text = "Usuários"
        '
        'PorcDeDescontoToolStripMenuItem
        '
        Me.PorcDeDescontoToolStripMenuItem.Name = "PorcDeDescontoToolStripMenuItem"
        Me.PorcDeDescontoToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.PorcDeDescontoToolStripMenuItem.Text = "Taxa de Desconto"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtalhosToolStripMenuItem, Me.EasyStockSystemToolStripMenuItem})
        Me.SobreToolStripMenuItem.Image = Global.EasyStockSystem.My.Resources.Resources._65
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(88, 25)
        Me.SobreToolStripMenuItem.Text = "Sobre..."
        '
        'AtalhosToolStripMenuItem
        '
        Me.AtalhosToolStripMenuItem.Name = "AtalhosToolStripMenuItem"
        Me.AtalhosToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.AtalhosToolStripMenuItem.Text = "Atalhos"
        '
        'EasyStockSystemToolStripMenuItem
        '
        Me.EasyStockSystemToolStripMenuItem.Name = "EasyStockSystemToolStripMenuItem"
        Me.EasyStockSystemToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.EasyStockSystemToolStripMenuItem.Text = "EasyStockSystem..."
        '
        'lblConectadoComo
        '
        Me.lblConectadoComo.AutoSize = True
        Me.lblConectadoComo.BackColor = System.Drawing.Color.Transparent
        Me.lblConectadoComo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblConectadoComo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConectadoComo.ForeColor = System.Drawing.Color.Black
        Me.lblConectadoComo.Location = New System.Drawing.Point(0, 670)
        Me.lblConectadoComo.Name = "lblConectadoComo"
        Me.lblConectadoComo.Size = New System.Drawing.Size(118, 17)
        Me.lblConectadoComo.TabIndex = 4
        Me.lblConectadoComo.Text = "Conectado como:"
        '
        'frmPrincipal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.BackgroundImage = Global.EasyStockSystem.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 687)
        Me.Controls.Add(Me.lblConectadoComo)
        Me.Controls.Add(Me.mstPrincipal)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mstPrincipal
        Me.MinimumSize = New System.Drawing.Size(1024, 726)
        Me.Name = "frmPrincipal"
        Me.Text = "EasyStockSystem"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mstPrincipal.ResumeLayout(False)
        Me.mstPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mstPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstoqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuáriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorcDeDescontoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AtalhosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EasyStockSystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblConectadoComo As System.Windows.Forms.Label

End Class
