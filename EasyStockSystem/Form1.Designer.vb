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
        Me.EstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mstPrincipal.BackColor = System.Drawing.Color.LightSeaGreen
        Me.mstPrincipal.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.mstPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.EstoqueToolStripMenuItem, Me.VendasToolStripMenuItem, Me.RelatóriosToolStripMenuItem, Me.ConfiguraçõesToolStripMenuItem, Me.SobreToolStripMenuItem})
        Me.mstPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mstPrincipal.Name = "mstPrincipal"
        Me.mstPrincipal.Size = New System.Drawing.Size(1008, 29)
        Me.mstPrincipal.TabIndex = 2
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.Image = Global.EasyStockSystem.My.Resources.Resources._15
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(100, 25)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'EstoqueToolStripMenuItem
        '
        Me.EstoqueToolStripMenuItem.Image = Global.EasyStockSystem.My.Resources.Resources._35
        Me.EstoqueToolStripMenuItem.Name = "EstoqueToolStripMenuItem"
        Me.EstoqueToolStripMenuItem.Size = New System.Drawing.Size(93, 25)
        Me.EstoqueToolStripMenuItem.Text = "Estoque"
        '
        'VendasToolStripMenuItem
        '
        Me.VendasToolStripMenuItem.Image = Global.EasyStockSystem.My.Resources.Resources._80
        Me.VendasToolStripMenuItem.Name = "VendasToolStripMenuItem"
        Me.VendasToolStripMenuItem.Size = New System.Drawing.Size(89, 25)
        Me.VendasToolStripMenuItem.Text = "Vendas"
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
        Me.ConfiguraçõesToolStripMenuItem.Image = Global.EasyStockSystem.My.Resources.Resources._84
        Me.ConfiguraçõesToolStripMenuItem.Name = "ConfiguraçõesToolStripMenuItem"
        Me.ConfiguraçõesToolStripMenuItem.Size = New System.Drawing.Size(138, 25)
        Me.ConfiguraçõesToolStripMenuItem.Text = "Configurações"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Image = Global.EasyStockSystem.My.Resources.Resources._65
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(88, 25)
        Me.SobreToolStripMenuItem.Text = "Sobre..."
        '
        'frmPrincipal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.BackgroundImage = Global.EasyStockSystem.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 687)
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

End Class
