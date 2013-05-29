Public Class clsVenda
    Private _id As Integer
    Private _vendedores_id As Integer
    Private _data_venda As String
    Private _valor_total As String

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property vendedores_id() As Integer
        Get
            Return _vendedores_id
        End Get
        Set(value As Integer)
            _vendedores_id = value
        End Set
    End Property

    Public Property data_venda() As String
        Get
            Return _data_venda
        End Get
        Set(value As String)
            _data_venda = value
        End Set
    End Property

    Public Property valor_total() As String
        Get
            Return _valor_total
        End Get
        Set(value As String)
            _valor_total = value
        End Set
    End Property
End Class
