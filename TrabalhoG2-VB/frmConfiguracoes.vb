Public Class frmConfiguracoes

    Public Sub New(ByVal opcao As Char)
        InitializeComponent()
        If (opcao = "a") Then
            gpxPorcentagem.Visible = False
            lblPorcentagemDesconto.Visible = False
            txtPorcentagem.Visible = False
            gpxDadosAcesso.Visible = True
            lblLogin.Visible = True
            lblSenha.Visible = True
            txtLogin.Visible = True
            txtSenha.Visible = True
        ElseIf (opcao = "p") Then
            gpxPorcentagem.Visible = True
            lblPorcentagemDesconto.Visible = True
            txtPorcentagem.Visible = True
            gpxDadosAcesso.Visible = False
            lblLogin.Visible = False
            lblSenha.Visible = False
            txtLogin.Visible = False
            txtSenha.Visible = False
        Else
            Me.Close()
        End If
    End Sub


    Private Sub btnSalvarDadosAcesso_Click(sender As Object, e As EventArgs) Handles btnSalvarDadosAcesso.Click

    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Close()
    End Sub
End Class