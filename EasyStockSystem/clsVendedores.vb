﻿Public Class clsVendedores
    Private _id As String
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

    Private _endereco As String
    Public Property endereco() As String
        Get
            Return _endereco
        End Get
        Set(ByVal value As String)
            _endereco = value
        End Set
    End Property

    Private _cidade As String
    Public Property cidade() As String
        Get
            Return _cidade
        End Get
        Set(ByVal value As String)
            _cidade = value
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





End Class
