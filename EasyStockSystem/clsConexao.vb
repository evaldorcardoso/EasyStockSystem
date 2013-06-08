Imports System.Data.SqlClient

Public Class clsConexao

    Public sNomeBase As String = "EasyStockSystem"
    Public Conn As New SqlConnection

    Public Function OpenDB() As Boolean
        Try
            Dim strConexao As String
            strConexao = "data source=.;" & _
                        "initial catalog=" & sNomeBase & ";" & _
                        "integrated security=SSPI;"

            Conn.ConnectionString = strConexao
            Conn.Open()

            If Conn.State = ConnectionState.Open Then
                'MsgBox("Conexão com o banco de dados OK!")
                Return True
            End If
        Catch ex As Exception
            MsgBox("Verifique a conexão com o banco de dados!")
            Return False
        End Try
    End Function

    Public Function CloseDB() As Boolean
        Try
            Conn.Close()
            If Conn.State = ConnectionState.Closed Then
                MsgBox("Conexão com banco de dados fechada com sucesso!")
                Return True
            End If
        Catch ex As Exception
            MsgBox("Não foi possivel fechar a conexão com banco de dados!")
            Return False
        End Try
    End Function


End Class
