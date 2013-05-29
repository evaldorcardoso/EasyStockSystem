Public Class frmVendedores

    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Close()
    End Sub

    Private Sub frmVendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EasyStockSystemDataSet.vendedores' table. You can move, or remove it, as needed.
        Me.VendedoresTableAdapter.Fill(Me.EasyStockSystemDataSet.vendedores)

    End Sub
End Class