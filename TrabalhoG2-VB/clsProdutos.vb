Public Class clsProdutos
    Private _id As Integer
    Private _fornecedores_id As Integer
    Private _nome As String
    Private _quantidade As String
    Private _categoria As String
    Private _estoqueMinimo As String
    Private _valorCusto As String
    Private _valorVenda As String

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property fornecedores_id() As Integer
        Get
            Return _fornecedores_id
        End Get
        Set(value As Integer)
            _fornecedores_id = value
        End Set
    End Property

    Public Property nome() As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property

    Public Property quantidade() As String
        Get
            Return _quantidade
        End Get
        Set(value As String)
            _quantidade = value
        End Set
    End Property

    Public Property categoria() As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property

    Public Property estoqueMinimo() As String
        Get
            Return _estoqueMinimo
        End Get
        Set(value As String)
            _estoqueMinimo = value
        End Set
    End Property

    Public Property valorCusto() As String
        Get
            Return _valorCusto
        End Get
        Set(value As String)
            _valorCusto = value
        End Set
    End Property

    Public Property valorVenda As String
        Get
            Return _valorVenda
        End Get
        Set(value As String)
            _valorVenda = value
        End Set
    End Property

End Class
