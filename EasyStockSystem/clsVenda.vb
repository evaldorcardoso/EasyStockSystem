Public Class clsVenda

#Region "Propertys"
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _data_venda As String
    Public Property data_venda() As String
        Get
            Return _data_venda
        End Get
        Set(ByVal value As String)
            _data_venda = value
        End Set
    End Property

    Private _valor_total As Double
    Public Property valor_total() As Double
        Get
            Return _valor_total
        End Get
        Set(ByVal value As Double)
            _valor_total = value
        End Set
    End Property
#End Region



End Class
