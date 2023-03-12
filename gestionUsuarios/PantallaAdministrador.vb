Public Class PantallaAdministrador
    Private Sub btn_CerrarSesion_Click(sender As Object, e As EventArgs) Handles btn_CerrarSesion.Click
        Dim salir As MsgBoxResult
        salir = MsgBox("¿Desea cerrar la sesión?", MsgBoxStyle.YesNo)
        If salir = MsgBoxResult.Yes Then
            Application.Exit()
            'Me.Close()

        End If
    End Sub
End Class