Imports System.Data.SqlClient

Public Class frmProdutos

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Close()
    End Sub

    Private Sub frmProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EasyStockSystemDataSet.produtos' table. You can move, or remove it, as needed.
        Me.ProdutosTableAdapter.Fill(Me.EasyStockSystemDataSet.produtos)
    End Sub

    Public Function validaCampos() As Boolean
        If (txtNome.Text = "") Then
            MessageBox.Show("O produto precisa ter um nome")
            Return False
        ElseIf (cbxFornecedor.Text = "") Then
            MessageBox.Show("O produto precisa ter um fornecedor")
            Return False
        ElseIf (Not (IsNumeric(txtValorCusto.Text))) Then
            MessageBox.Show("Valor de custo inválido")
            Return False
        ElseIf (Not (IsNumeric(txtValorVenda.Text))) Then
            MessageBox.Show("Valor de venda inválido")
            Return False
        ElseIf (Not (IsNumeric(txtQuantidade.Text))) Then
            MessageBox.Show("Quantidade inválida")
            Return False
        ElseIf (IsNumeric(txtQuantidade.Text)) Then
            If (CInt(txtQuantidade.Text) <= 0) Then
                MessageBox.Show("Para cadastrar um produto e preciso no mínimo ter 1 unidade em quantidade")
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If (validaCampos()) Then
            MessageBox.Show("All right")
        End If
        Me.ProdutosTableAdapter.Fill(Me.EasyStockSystemDataSet.produtos)
    End Sub

    Public Sub insert(ByVal idFornecedor As Integer, ByVal nomeProduto As String, ByVal quantidade As Integer, ByVal categoria As String, ByVal estoqueMinimo As Integer, ByVal valorCusto As Integer, ByVal valorVenda As Integer)
        Dim sqlInclui As String
        Dim strCon As String
        Dim reg As Integer

        strCon = "Data Source=EVALDORC;Initial Catalog=EasyStockSystem;Integrated Security=True"
        sqlInclui = "INSERT INTO PRODUTOS VALUES(" & idFornecedor & ",'" & nomeProduto & "','" & quantidade &
            "','" & categoria & "','" & estoqueMinimo & "','" & valorCusto & "','" & valorVenda & "')"
        Dim connBD As New SqlConnection(strCon)
        Dim sqlComando = New SqlCommand(sqlInclui, connBD)
        Dim DA As New SqlDataAdapter
        DA.InsertCommand = sqlComando
        Try
            connBD.Open()
            reg = sqlComando.ExecuteNonQuery
            If (reg > 0) Then
                MessageBox.Show("Produto incluido com sucesso!")
            Else
                MessageBox.Show("Não foi possível inserir")
            End If
        Catch ex As Exception
            MessageBox.Show("Erro:" & vbCrLf & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connBD.Close()
        End Try

    End Sub

End Class