Imports Microsoft.VisualBasic

Public Class frmConfiguracoes

    Public Sub New(ByVal opcao As eStatusForm)
        InitializeComponent()
        StatusDoForm = opcao
    End Sub

    Public Enum eStatusForm
        taxaDesconto
        Usuario
    End Enum
    Dim StatusDoForm As eStatusForm


    Private Sub mudar()
        If (StatusDoForm = eStatusForm.Usuario) Then
            lblUsuario.Text = "Nome de Usuário:"
            txtUsuario.Visible = True
            lblSenha.Text = "Senha de Acesso"
            cbxVendedores.Visible = False
            lblRepitaSenha.Visible = True
            txtSenha2.Visible = True
        ElseIf (StatusDoForm = eStatusForm.taxaDesconto) Then
            lblUsuario.Text = "Selecione o Vendedor:"
            txtUsuario.Visible = False
            lblSenha.Text = "Informe a porcentagem de desconto:"
            cbxVendedores.Visible = True
            lblRepitaSenha.Visible = False
            txtSenha2.Visible = False
        End If

    End Sub

    Private Sub frmConfiguracoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mudar()
        Dim objAdministradores As New clsAdministradores
        objAdministradores.Consulta()


    End Sub
End Class