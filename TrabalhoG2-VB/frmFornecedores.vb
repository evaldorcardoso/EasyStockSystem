Public Class frmFornecedores

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Close()
    End Sub

    Private Sub mskTelefone_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskTelefone.MaskInputRejected

    End Sub

    Private Sub frmFornecedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EasyStockSystemDataSet.fornecedores' table. You can move, or remove it, as needed.
        Me.FornecedoresTableAdapter.Fill(Me.EasyStockSystemDataSet.fornecedores)

    End Sub
End Class