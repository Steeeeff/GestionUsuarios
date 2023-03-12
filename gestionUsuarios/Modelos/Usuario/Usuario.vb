'Modelo del Usuario
Public Class Usuario

    Public IdUsuario As Int32
    Public Nombre As String
    Public Correo As String
    Public Apellidos As String
    Public Password As String
    Public Rol As Rol
    Public UtilmaFechaConexion As String
    Public Borrado As Boolean

    Public Sub New(ByVal dataRow As DataRow)
        IdUsuario = dataRow(0)
        Nombre = dataRow(1)
        Correo = dataRow(2)
        Apellidos = dataRow(3)
        Password = dataRow(4)
        Rol = [Enum].Parse(GetType(Rol), dataRow(5))
        UtilmaFechaConexion = dataRow(6)
        Borrado = dataRow(7)
    End Sub

End Class

'Rol del usuario
Public Enum Rol
    administrador = 0
    propietario = 1
    usuario = 2
End Enum
