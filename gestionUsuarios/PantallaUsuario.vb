Public Class PantallaUsuario

    'La instancia del usuario logueado previamente
    Public Usuario As Usuario


    'La carga de los datos del usuario logueado
    Private Sub PantallaUsuarioVistaAparece(sender As Object, e As EventArgs) Handles MyBase.Shown
        If Usuario IsNot Nothing Then
            Lbl_nombre.Text = Usuario.Nombre
            Lbl_apellidos.Text = Usuario.Apellidos
            Lbl_correo.Text = Usuario.Correo
            Lbl_rol.Text = Usuario.Rol.ToString
            Lbl_ultimaFechaConexion.Text = Usuario.UtilmaFechaConexion
            Lbl_importe.Text = Usuario.Importe
            chk_pagado.Checked = Usuario.Pagado
        End If
    End Sub

    'Metodo que se ejecuta al pulsar el boton de cerrar sesion.
    Private Sub BotonCerrarSesionClick(sender As Object, e As EventArgs) Handles btn_CerrarSesion.Click
        Usuario = Nothing
        Dim salir As MsgBoxResult
        salir = MsgBox("¿Desea cerrar la sesión?", MsgBoxStyle.YesNo)
        If salir = MsgBoxResult.Yes Then
            Hide()
        End If
    End Sub


End Class