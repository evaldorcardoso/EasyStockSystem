﻿Public Class clsProdutosVenda
    Private _produtos_id As Integer
    Public Property produtos_id() As Integer
        Get
            Return _produtos_id
        End Get
        Set(ByVal value As Integer)
            _produtos_id = value
        End Set
    End Property

    Private _venda_id As Integer
    Public Property venda_id() As Integer
        Get
            Return _venda_id
        End Get
        Set(ByVal value As Integer)
            _venda_id = value
        End Set
    End Property



End Class
