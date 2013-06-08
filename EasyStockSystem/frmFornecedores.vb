Public Class frmFornecedores
    Private Sub mudar(ByVal visibilidade As Boolean)
        lblNome.Visible = visibilidade
        txtNome.Visible = visibilidade
        lblCategoria.Visible = visibilidade
        cbxCategoria.Visible = visibilidade
        lblNomeRepresentante.Visible = visibilidade
        txtNomeRepresentante.Visible = visibilidade
        lblTelefone.Visible = visibilidade
        mskTelefone.Visible = visibilidade
        lblEmail.Visible = visibilidade
        txtEmail.Visible = visibilidade
        lblCidade.Visible = visibilidade
        txtCidade.Visible = visibilidade
        lblCNPJ.Visible = visibilidade
        mskCNPJ.Visible = visibilidade
        If (visibilidade) Then
            dgvFornecedores.Visible = False
        Else
            dgvFornecedores.Visible = True
        End If
    End Sub

    Private Sub frmFornecedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mudar(False)
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        mudar(True)
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        mudar(False)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        mudar(False)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        mudar(True)
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        mudar(False)
    End Sub
End Class