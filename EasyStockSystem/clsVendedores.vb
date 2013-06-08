Imports System.Data.SqlClient

Public Class clsVendedores

    Dim objConexao As New clsConexao

    Private _id As String
    Private _nome As String
    Private _login As String
    Private _senha As String
    Private _endereco As String
    Private _cidade As String
    Private _telefone As String
    Private _email As String
#Region "Propertys"

    Public Property id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Public Property nome() As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value
        End Set
    End Property

    Public Property login() As String
        Get
            Return _login
        End Get
        Set(ByVal value As String)
            _login = value
        End Set
    End Property

    Public Property senha() As String
        Get
            Return _senha
        End Get
        Set(ByVal value As String)
            _senha = value
        End Set
    End Property

    Public Property endereco() As String
        Get
            Return _endereco
        End Get
        Set(ByVal value As String)
            _endereco = value
        End Set
    End Property

    Public Property cidade() As String
        Get
            Return _cidade
        End Get
        Set(ByVal value As String)
            _cidade = value
        End Set
    End Property

    Public Property telefone() As String
        Get
            Return _telefone
        End Get
        Set(ByVal value As String)
            _telefone = value
        End Set
    End Property

    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

#End Region

    Public Function logar(ByVal login As String, ByVal senha As String)
        Dim dsVendedores As New DataSet
        Dim loginBanco As String = ""
        Dim senhaBanco As String = ""

        Try
            objConexao.OpenDB()
            Dim da As SqlDataAdapter = New SqlDataAdapter("select * from vendedores where login ='" & login & "'", objConexao.Conn)
            da.Fill(dsVendedores, "LoginAdministradores")

        Catch ex As Exception
            MsgBox("Problemas ao executar a busca no banco de dados: " & ex.Message, MsgBoxStyle.Information)
        End Try

        Try
            loginBanco = (dsVendedores.Tables("LoginAdministradores").Rows(0)("login").ToString())
            senhaBanco = (dsVendedores.Tables("LoginAdministradores").Rows(0)("senha").ToString())
        Catch ex As Exception

        End Try


        If (login = loginBanco) Then
            If (senha = senhaBanco) Then
                Return True
            Else
                MsgBox("Senha Errada")
                Return False
            End If
        Else
            MsgBox("Usuario Invalido")
            Return False
        End If
    End Function


End Class
