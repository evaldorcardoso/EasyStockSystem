Public Class clsProdutos
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _nome As String
    Public Property nome() As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value
        End Set
    End Property

    Private _quantidade As String
    Public Property quantidade() As String
        Get
            Return _quantidade
        End Get
        Set(ByVal value As String)
            _quantidade = value
        End Set
    End Property

    Private _categoria As String
    Public Property categoria() As String
        Get
            Return _categoria
        End Get
        Set(ByVal value As String)
            _categoria = value
        End Set
    End Property

    Private _estoque_minimo As Double
    Public Property estoque_minimo() As Double
        Get
            Return _estoque_minimo
        End Get
        Set(ByVal value As Double)
            _estoque_minimo = value
        End Set
    End Property

    Private _valor_custo As Double
    Public Property valor_custo() As Double
        Get
            Return _valor_custo
        End Get
        Set(ByVal value As Double)
            _valor_custo = value
        End Set
    End Property

    Private _valor_venda As Double
    Public Property valor_venda() As Double
        Get
            Return _valor_venda
        End Get
        Set(ByVal value As Double)
            _valor_venda = value
        End Set
    End Property



End Class
