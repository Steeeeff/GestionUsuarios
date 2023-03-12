Imports MySql.Data.MySqlClient

Public Class Login

    Private _mySqlConnection As New MySqlConnection

    'Este metodo se ejecuta la primera vez que se muestra esta vista.
    Private Sub IniciarSesionVistaPrimeraAparicion(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim conexionbbdd = New ConexionBBDD
            _mySqlConnection = conexionbbdd.EstablecerConexion()
        Catch ex As Exception
            MsgBox("Parece que ha ocurrido un error al establecer la conexión con la base de datos, por favor contacte con su Administrador.")
        End Try
    End Sub

    'Este metodo se ejecuta cuando se hace click el boton de inciar sesion.
    Private Sub BotonIniciarSesionClicked(sender As Object, e As EventArgs) Handles btn_Acceder.Click
        Dim _usarioLogueado As Usuario
        Dim _fechaConexion = Now.Date

        If tb_correo.Text <> "" And tb_Contraseña.Text <> "" Then
            Dim _queryObtencionUsario As String
            Dim _listaDeFilasObtenidas As List(Of DataRow)

            _queryObtencionUsario = "SELECT * FROM usuario where correo='" & tb_correo.Text & "'and userPassword='" & tb_Contraseña.Text & "'"
            Dim adaptador = New MySqlDataAdapter(_queryObtencionUsario, _mySqlConnection)
            Dim datos = New DataSet

            adaptador.Fill(datos, "usuario")

            _listaDeFilasObtenidas = datos.Tables("usuario").Rows.OfType(Of DataRow).ToList()

            If _listaDeFilasObtenidas IsNot Nothing And _listaDeFilasObtenidas.Count = 1 Then
                _usarioLogueado = New Usuario(_listaDeFilasObtenidas.FirstOrDefault)
            End If
        End If

        If _usarioLogueado IsNot Nothing Then
            Dim _queryInsertarFechaConexion As String
            _queryInsertarFechaConexion = "UPDATE usuario SET ult_fecha_conexion  ='" & _fechaConexion.ToString("yyyy/MM/dd") & "' WHERE id_usuario = " + _usarioLogueado.IdUsuario.ToString()

            Dim _comandoInsertarFecha = New MySqlCommand(_queryInsertarFechaConexion, _mySqlConnection)
            Dim columnasAfectadas = _comandoInsertarFecha.ExecuteNonQuery()
            If columnasAfectadas = 1 Then
                If _usarioLogueado.Rol = Rol.usuario Then
                    AbrirPantallaDeUsuario(_usarioLogueado)
                Else
                    AbrirPantallaDeAdministracion(_usarioLogueado)
                End If
            Else
                MsgBox("Intentelo de nuevo")
            End If

        Else
            MsgBox("El usuario no se encuentra en la base de datos.")
        End If
    End Sub

    Private Sub AbrirPantallaDeUsuario(usuario As Usuario)
        Dim pantallaUsuario = New PantallaUsuario With {
            .Usuario = usuario
        }
        pantallaUsuario.Show()
        tb_Contraseña.Clear()
        tb_correo.Clear()
        Hide()
    End Sub

    Private Sub AbrirPantallaDeAdministracion(usuario As Usuario)
        Dim pantallaDeAdministracion = New PantallaAdministrador With {
            .Usuario = usuario
        }
        pantallaDeAdministracion.Show()
        tb_Contraseña.Clear()
        tb_correo.Clear()
        Hide()
    End Sub

End Class

