Public Class frmLogin

   

    Private Sub frmLogin_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        txtLogin.SelectAll()
    End Sub


    Private Sub kbtnEntrar_Click(sender As Object, e As EventArgs) Handles kbtnEntrar.Click
        Dim telaPrincipal As New frmPrincipal()
        telaPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub kbtnSair_Click(sender As Object, e As EventArgs) Handles kbtnSair.Click
        Close()
    End Sub
End Class
