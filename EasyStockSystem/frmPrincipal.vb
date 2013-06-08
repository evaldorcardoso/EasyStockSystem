Public Class frmPrincipal



    Public Sub New(ByVal user As String)
        InitializeComponent()
        lblConectadoComo.Text = "Conectado como:   " & user

    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        Dim telaProdutos As New frmProdutos()
        telaProdutos.MdiParent = Me
        telaProdutos.Show()
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem.Click
        Dim telaFornecedores As New frmFornecedores()
        telaFornecedores.MdiParent = Me
        telaFornecedores.Show()
    End Sub

    Private Sub VendedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendedoresToolStripMenuItem.Click
        Dim telaVendedores As New frmVendedores()
        telaVendedores.MdiParent = Me
        telaVendedores.Show()
    End Sub

    Private Sub EstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstoqueToolStripMenuItem.Click
        Dim telaEstoque As New frmEstoque()
        telaEstoque.MdiParent = Me
        telaEstoque.Show()
    End Sub

    Private Sub VendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendasToolStripMenuItem.Click
        Dim telaVenda As New frmVenda()
        telaVenda.MdiParent = Me
        telaVenda.Show()
    End Sub

    Private Sub UsuáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuáriosToolStripMenuItem.Click
        Dim telaConfiguracoes As New frmConfiguracoes(frmConfiguracoes.eStatusForm.Usuario)
        telaConfiguracoes.MdiParent = Me
        telaConfiguracoes.Show()
    End Sub


    Private Sub PorcDeDescontoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorcDeDescontoToolStripMenuItem.Click
        Dim telaConfiguracoes As New frmConfiguracoes(frmConfiguracoes.eStatusForm.taxaDesconto)
        telaConfiguracoes.MdiParent = Me
        telaConfiguracoes.Show()
    End Sub

    Private Sub EasyStockSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EasyStockSystemToolStripMenuItem.Click
        MessageBox.Show("EasyStockSystem" & vbCrLf & "Versão 1.0.0" & vbCrLf & "Desenvolvido por: EvaldoRC", "Sobre...", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    
End Class
