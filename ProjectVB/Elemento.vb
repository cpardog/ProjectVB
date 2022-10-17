Imports Microsoft.VisualBasic

Public Class Elemento

    Private _idelemento As Integer
    Private _tipoElemento As String
    Private _fabricante As String
    Private _serial As String
    Private _color As String
    Private _estado As Boolean
    Public Sub New(tipo As String, mk As String, sn As String)
        _tipoElemento = tipo
        _fabricante = mk
        _serial = sn
        _color = "Blanco"
        _estado = True
    End Sub

    Public Sub New(id As Integer, tipo As String, mk As String, sn As String, color As String, estado As Boolean)
        _idelemento = id
        _tipoElemento = tipo
        _fabricante = mk
        _serial = sn
        _color = color
        _estado = estado
    End Sub
    Public Property IdElemento() As Integer
        Get
            Return _idelemento
        End Get
        Set(ByVal value As Integer)
            _idelemento = value
        End Set
    End Property
    Public Property TipoElemento() As String
        Get
            Return _tipoElemento
        End Get
        Set(ByVal value As String)
            _tipoElemento = value
        End Set
    End Property

    Public Property Fabricante() As String
        Get
            Return _fabricante
        End Get
        Set(ByVal value As String)
            _fabricante = value
        End Set
    End Property

    Public Property Serial() As String
        Get
            Return _serial
        End Get
        Set(ByVal value As String)
            _serial = value
        End Set
    End Property

    Public Property Color() As String
        Get
            Return _color
        End Get
        Set(ByVal value As String)
            _color = value
        End Set
    End Property

    Public Property Estado() As Boolean
        Get
            Return _estado
        End Get
        Set(ByVal value As Boolean)
            _estado = value
        End Set
    End Property


End Class
