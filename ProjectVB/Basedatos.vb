Imports ProjectVB
Public Class class1
    Public cn As SqlConnection
    Public sql As String
    Public Function conectar() As SqlConnection
        Dim cadena As String
        cadena = "aqui va la cadena"
        cn.ConnectionString = cadena
        conectar = New SqlConnection()
    End Function
    Public Function GetDataTable() As DataTable
        Dim conex As SqlConnection = conectar()
        Dim sql As String = "select * from elemento"
        Dim da As SqlDataAdapter = New SqlDataAdapter(sql, conex)
        Dim dt As DataTable
        da.Fill(dt)
        Return dt

    End Function
End Class
