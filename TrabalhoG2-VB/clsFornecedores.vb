Public Class clsFornecedores
    Private _id As Integer
    Private _nome As String
    Private _categoria As String
    Private _nome_representante As String
    Private _telefone As String
    Private _telefone2 As String
    Private _email As String
    Private _cidade As String
    Private _cnpj As String

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
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

    Public Property categoria() As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property

    Public Property nome_representante As String
        Get
            Return _nome_representante
        End Get
        Set(value As String)
            _nome_representante = value
        End Set
    End Property

    Public Property telefone() As String
        Get
            Return _telefone
        End Get
        Set(value As String)
            _telefone = value
        End Set
    End Property

    Public Property email() As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property cidade() As String
        Get
            Return _cidade
        End Get
        Set(value As String)
            _cidade = value
        End Set
    End Property

    Public Property cnpj As String
        Get
            Return _cnpj
        End Get
        Set(value As String)
            _cnpj = value
        End Set
    End Property

End Class
