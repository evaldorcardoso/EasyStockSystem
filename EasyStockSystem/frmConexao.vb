Public Class frmConexao

    Dim objConexao As New clsConexao

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        objConexao.sNomeBase = (txtNomeBD.Text)
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        objConexao.CloseDB()
    End Sub
End Class