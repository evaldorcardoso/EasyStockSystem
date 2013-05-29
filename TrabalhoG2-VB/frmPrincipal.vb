Public Class frmPrincipal

    
    Private Sub EstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstoqueToolStripMenuItem.Click
        Dim telaEstoque As New frmEstoque
        telaEstoque.MdiParent = Me
        telaEstoque.Show()

    End Sub

    Private Sub ProdutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutoToolStripMenuItem.Click
        Dim telaProdutos As New frmProdutos
        telaProdutos.MdiParent = Me
        telaProdutos.Show()
    End Sub

    Private Sub FornecedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedorToolStripMenuItem.Click
        Dim telaFornecedores As New frmFornecedores
        telaFornecedores.MdiParent = Me
        telaFornecedores.Show()
    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click

    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub VendedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendedorToolStripMenuItem.Click
        Dim telaVendedores As New frmVendedores
        telaVendedores.MdiParent = Me
        telaVendedores.Show()
    End Sub

    Private Sub VendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendasToolStripMenuItem.Click
        Dim telaVendas As New frmVendas
        telaVendas.MdiParent = Me
        telaVendas.Show()
    End Sub



    Private Sub rbtnVerEstoque_Click(sender As Object, e As EventArgs) Handles rbtnVerEstoque.Click
        Dim telaEstoque As New frmEstoque
        telaEstoque.MdiParent = Me
        telaEstoque.Show()
    End Sub

    Private Sub rbtnVender_Click(sender As Object, e As EventArgs) Handles rbtnVender.Click
        Dim telaVendas As New frmVendas
        telaVendas.MdiParent = Me
        telaVendas.Show()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Close()
    End Sub

    Private Sub rbtnProduto_Click(sender As Object, e As EventArgs) Handles rbtnProduto.Click
        Dim telaProdutos As New frmProdutos
        telaProdutos.MdiParent = Me
        telaProdutos.Show()
    End Sub

    Private Sub rbtnFornecedor_Click(sender As Object, e As EventArgs) Handles rbtnFornecedor.Click
        Dim telaFornecedores As New frmFornecedores
        telaFornecedores.MdiParent = Me
        telaFornecedores.Show()
    End Sub

    Private Sub rbtnVendedor_Click(sender As Object, e As EventArgs) Handles rbtnVendedor.Click
        Dim telaVendedores As New frmVendedores
        telaVendedores.MdiParent = Me
        telaVendedores.Show()
    End Sub

    Private Sub rbtnUsuarios_Click(sender As Object, e As EventArgs) Handles rbtnUsuarios.Click
        Dim telaConfiguracoes As New frmConfiguracoes("a")
        telaConfiguracoes.MdiParent = Me
        telaConfiguracoes.Show()
    End Sub

    Private Sub rbtnPorcDesconto_Click(sender As Object, e As EventArgs) Handles rbtnPorcDesconto.Click
        Dim telaConfiguracoes As New frmConfiguracoes("p")
        telaConfiguracoes.MdiParent = Me
        telaConfiguracoes.Show()
    End Sub
End Class