Imports System.Management.Instrumentation
Imports MySql.Data.MySqlClient

Public Class PantallaEdicionUsuario
    'La instancia del usuario logueado previamente
    Public Usuario As Usuario
    Public UsuarioLogueado As Usuario
    Private _mySqlConnection As MySqlConnection

    'La carga de los datos del usuario logueado
    Private Sub PantallaAdministradorVistaAparece(sender As Object, e As EventArgs) Handles MyBase.Shown

        If Usuario IsNot Nothing Then
            Dim roles = New List(Of String) From {
                Rol.administrador.ToString,
                Rol.usuario.ToString,
                Rol.propietario.ToString
            }

            _mySqlConnection = New ConexionBBDD().EstablecerConexion()

            tb_nombre.Text = Usuario.Nombre
            tb_apellidos.Text = Usuario.Apellidos
            tb_correo.Text = Usuario.Correo
            cb_rol.DataSource = roles
            cb_rol.SelectedItem = Usuario.Rol.ToString
            dtp_ultimaFechaConexion.Text = Usuario.UtilmaFechaConexion
            tb_importe.Text = Usuario.Importe
            chk_pagado.Checked = Usuario.Pagado

        End If
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        AbrirPantallaAdministracion()
    End Sub

    Private Sub btn_GuardarCambios_Click(sender As Object, e As EventArgs) Handles btn_GuardarCambios.Click
        Dim _queryModificarUsuario As String
        _queryModificarUsuario = $"UPDATE usuario SET borrado = {False}, nombre = '{tb_nombre.Text}', correo = '{tb_correo.Text}', apellidos = '{tb_apellidos.Text}', tipo_usuario = '{cb_rol.SelectedValue}', ult_fecha_conexion = '{dtp_ultimaFechaConexion.Value.ToString("yyyy/MM/dd")}', importe = '{tb_importe.Text}', pagado = {chk_pagado.Checked} WHERE id_usuario = {Usuario.IdUsuario.ToString()}"
        Dim _comandoInsertarFecha = New MySqlCommand(_queryModificarUsuario, _mySqlConnection)
        Dim columnasAfectadas = _comandoInsertarFecha.ExecuteNonQuery()
        If columnasAfectadas = 1 Then
            MsgBox($"El usuario {Usuario.Nombre} se modifico correctamente")
        Else
            MsgBox("Hubo un error al modificar al usuario " + Usuario.Nombre)
        End If
        AbrirPantallaAdministracion()
    End Sub

    Private Sub AbrirPantallaAdministracion()
        Hide()
        Dim pantallaAdministrador = New PantallaAdministrador()
        pantallaAdministrador.Usuario = UsuarioLogueado
        pantallaAdministrador.Show()
    End Sub

End Class