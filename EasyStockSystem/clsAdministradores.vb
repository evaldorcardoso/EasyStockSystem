Imports System.Data.SqlClient


Public Class clsAdministradores

    Dim objConexao As New clsConexao
    'Dim nomeDoBanco As String

#Region "Propertys"
    Private _id As Integer
    Public Property id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
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

    Private _login As String
    Public Property login() As String
        Get
            Return _login
        End Get
        Set(ByVal value As String)
            _login = value
        End Set
    End Property

    Private _senha As String
    Public Property senha() As String
        Get
            Return _senha
        End Get
        Set(ByVal value As String)
            _senha = value
        End Set
    End Property

    Private _telefone As String
    Public Property telefone() As String
        Get
            Return _telefone
        End Get
        Set(ByVal value As String)
            _telefone = value
        End Set
    End Property

    Private _email As String
    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

#End Region

    Public Function Consulta() As DataSet
        Dim dsClientes As New DataSet


        Try
            objConexao.OpenDB()
            Dim da As SqlDataAdapter = New SqlDataAdapter("select * from administradores", objConexao.Conn)
            da.Fill(dsClientes, "BuscaAdministradores")
        Catch ex As Exception
            MsgBox("Problemas ao executar a busca no banco de dados: " & ex.Message, MsgBoxStyle.Information)
        End Try

        For i = 0 To dsClientes.Tables("BuscaAdministradores").Rows.Count - 1
            MsgBox("Nome:" & dsClientes.Tables("BuscaAdministradores").Rows(0)("nome").ToString())
        Next

        Return dsClientes
    End Function

    Public Function logar(ByVal login As String, ByVal senha As String) As Boolean
        Dim dsAdministradores As New DataSet
        Dim loginBanco As String = ""
        Dim senhaBanco As String = ""

        Try
            objConexao.OpenDB()
            Dim da As SqlDataAdapter = New SqlDataAdapter("select * from administradores where login ='" & login & "'", objConexao.Conn)
            da.Fill(dsAdministradores, "LoginAdministradores")
            
        Catch ex As Exception
            MsgBox("Problemas ao executar a busca no banco de dados: " & ex.Message, MsgBoxStyle.Information)
        End Try

        Try
            loginBanco = (dsAdministradores.Tables("LoginAdministradores").Rows(0)("login").ToString())
            senhaBanco = (dsAdministradores.Tables("LoginAdministradores").Rows(0)("senha").ToString())
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
