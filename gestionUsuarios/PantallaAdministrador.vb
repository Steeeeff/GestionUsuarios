Imports MySql
Imports MySql.Data.MySqlClient
Imports Mysqlx.Datatypes

Public Class PantallaAdministrador

    'La instancia del usuario logueado previamente
    Public Usuario As Usuario

    Private _mySqlConnection As MySqlConnection
    Private _tablaUsuarios As DataTable

    'La carga de los datos del usuario logueado
    Private Sub PantallaAdministradorVistaAparece(sender As Object, e As EventArgs) Handles MyBase.Shown

        If Usuario IsNot Nothing Then

            _mySqlConnection = New ConexionBBDD().EstablecerConexion()
            btn_Eliminar.Visible = Usuario.Rol = Rol.administrador
            ObtenerListaDeUsuarios()
        End If
    End Sub

    'Metodo que se ejecuta al pulsar sobre el boton de cerrar sesion
    Private Sub BotonCerrarSesionClick(sender As Object, e As EventArgs) Handles btn_CerrarSesion.Click
        Dim salir As MsgBoxResult
        salir = MsgBox("¿Desea cerrar la sesión?", MsgBoxStyle.YesNo)
        If salir = MsgBoxResult.Yes Then
            Hide()
            Login.Show()
        End If
    End Sub

    'Metodo que se ejecuta al pulsar sobre el boton de eliminar usuario
    Private Sub BotonEliminarClick(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        Dim currentRow = DataGridUsuarios.CurrentRow.Index
        Dim usuarioParaBorrar = New Usuario(_tablaUsuarios.Rows(currentRow))
        Dim _queryInsertarFechaConexion As String
        _queryInsertarFechaConexion = "UPDATE usuario SET borrado  =" & True & " WHERE id_usuario = " + usuarioParaBorrar.IdUsuario.ToString()

        Dim salir As MsgBoxResult
        salir = MsgBox("Se va a borrar el usuario " + usuarioParaBorrar.Nombre + " ¿Desea continuar?", MsgBoxStyle.YesNo)
        If salir = MsgBoxResult.Yes Then
            Hide()
            Login.Show()

            Dim _comandoInsertarFecha = New MySqlCommand(_queryInsertarFechaConexion, _mySqlConnection)
            Dim columnasAfectadas = _comandoInsertarFecha.ExecuteNonQuery()
            If columnasAfectadas = 1 Then
                ObtenerListaDeUsuarios()
                MsgBox("Se borro al usuario " + usuarioParaBorrar.Nombre)
            Else
                MsgBox("Hubo un error al borrar al usuario " + usuarioParaBorrar.Nombre)
            End If
        End If
    End Sub

    'Metodo que se ejecuta al pulsar sobre el boton de moficar usuario
    Private Sub BotonModificarClick(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        Dim currentRow = DataGridUsuarios.CurrentRow.Index
        Dim usuarioEditar = New Usuario(_tablaUsuarios.Rows(currentRow))
        Dim pantallaModificar = New PantallaEdicionUsuario With {
            .Usuario = usuarioEditar,
            .UsuarioLogueado = Usuario
        }
        Hide()
        pantallaModificar.Show()
    End Sub

    'Obtiene la lista de usuarios
    Public Sub ObtenerListaDeUsuarios()
        Dim _queryObtencionTodosLosDatos As String

        _queryObtencionTodosLosDatos = "SELECT * FROM usuario WHERE borrado = false"
        Dim adaptador = New MySqlDataAdapter(_queryObtencionTodosLosDatos, _mySqlConnection)
        _tablaUsuarios = New DataTable()
        adaptador.Fill(_tablaUsuarios)
        DataGridUsuarios.DataSource = _tablaUsuarios
    End Sub

End Class