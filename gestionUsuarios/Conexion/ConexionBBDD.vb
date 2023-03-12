Imports MySql.Data.MySqlClient

'Clase que nos permite establecer conexión con la BBDD
Public Class ConexionBBDD

    'Instancia de la conexion a la BBDD de MySql    
    Private _mySqlConnection As MySqlConnection

    Dim server = "localhost"
    Dim usuario = "root"
    Dim pass = "1234"
    Dim db = "gestion_usuarios"
    Dim cadena = "server=" & server & ";Uid=" & usuario & ";pwd=" & pass & ";database=" & db & ";SslMode=none;"

    'Metodo para crear la instancia de MySqlConnection
    'Este metodo es privado ya que no nos interesa crear la conexion en cada paso,
    'esto lo manejara el metodo de Establecer conexion
    Private Sub CrearConexion()
        _mySqlConnection = New MySqlConnection(cadena)
    End Sub

    'Metodo que crea y  abre la conexion de la instancia de MySqlConnection
    Public Function EstablecerConexion() As MySqlConnection
        CrearConexion()
        _mySqlConnection.Open()
        Return _mySqlConnection
    End Function

    'Metodo para cerrar la conexion de la instancia de MySqlConnection
    Public Sub Cerrarconexion()
        _mySqlConnection.Close()
    End Sub

End Class
