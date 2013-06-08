Public Class frmVendedores
    Private Sub mudar(ByVal visibilidade As Boolean)
        lblNome.Visible = visibilidade
        txtNome.Visible = visibilidade
        lblEndereco.Visible = visibilidade
        txtEndereco.Visible = visibilidade
        lblCidade.Visible = visibilidade
        txtCidade.Visible = visibilidade
        lblTelefone.Visible = visibilidade
        mskTelefone.Visible = visibilidade
        lblEmail.Visible = visibilidade
        txtEmail.Visible = visibilidade
        lblLogin.Visible = visibilidade
        txtLogin.Visible = visibilidade
        lblSenha1.Visible = visibilidade
        txtSenha.Visible = visibilidade
        lblSenha2.Visible = visibilidade
        txtSenha2.Visible = visibilidade
        If (visibilidade) Then
            dgvVendedores.Visible = False
        Else
            dgvVendedores.Visible = True
        End If
    End Sub

    Private Sub frmVendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mudar(False)
        Dim objVendedor As New clsVendedores

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        mudar(True)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        mudar(True)
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        mudar(False)
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        mudar(False)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mudar(False)
    End Sub
End Class