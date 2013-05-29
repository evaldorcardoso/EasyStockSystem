Imports System.Windows.Forms


Public Class frmVendas

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Close()
    End Sub

    Private Sub frmVendas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Deseja mesmo cancelar a venda?", "Toda a venda será perdida!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EasyStockSystemDataSet.venda' table. You can move, or remove it, as needed.
        Me.VendaTableAdapter.Fill(Me.EasyStockSystemDataSet.venda)

    End Sub
End Class