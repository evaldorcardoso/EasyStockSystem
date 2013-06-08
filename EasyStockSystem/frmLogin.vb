Public Class frmLogin

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        If (rdbVendedor.Checked = True) Then
            Dim objVendedores As New clsVendedores
            If (objVendedores.logar(txtLogin.Text, txtSenha.Text)) Then
                Dim telaPrincipal As New frmPrincipal(txtLogin.Text)
                telaPrincipal.Show()
                Me.Close()
            End If
        Else
            Dim objAdministradores As New clsAdministradores
            If (objAdministradores.logar(txtLogin.Text, txtSenha.Text)) Then
                Dim telaPrincipal As New frmPrincipal(txtLogin.Text)
                telaPrincipal.Show()
                Me.Close()
            End If
        End If


    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Close()
    End Sub

    Private Sub lblBancoDeDados_Click(sender As Object, e As EventArgs)
        Dim telaConexao As New frmConexao()
        telaConexao.Show()
    End Sub


End Class