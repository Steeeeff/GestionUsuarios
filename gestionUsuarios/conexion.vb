Imports MySql.Data.MySqlClient
'Imports MySqLConnector


Public Class conexion
    Public conexionbbdd As MySqlConnection

    Dim server = "localhost"
    Dim usuario = "root"
    Dim pass = "1234"
    Dim db = "gestion_usuarios"
    Dim cadena = "server=" & server & ";Uid=" & usuario & ";pwd=" & pass & ";database=" & db & ";SslMode=none;"


    'METODO PARA CREAR CONEXION
    Public Sub Conexion()
        conexionbbdd = New MySqlConnection(cadena)
    End Sub
    'METODO PARA ESTABLECER CONEXION
    Public Sub EstablecerConexion()
        conexionbbdd.Open()
    End Sub
    'METODO PARA CERRAR CONEXION
    Public Sub Cerrarconexion()
        conexionbbdd.Close()
    End Sub
End Class
