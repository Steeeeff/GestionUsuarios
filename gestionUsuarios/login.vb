Imports MySql.Data.MySqlClient


Public Class login
    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            conexion.ConnectionString = "server=localhost;user=root;password=1234;database=gestion_usuarios"


            conexion.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_Acceder_Click(sender As Object, e As EventArgs) Handles btn_Acceder.Click

        Dim consulta As String
        Dim lista As List(Of DataRow)
        Dim comprobar_permisos As String 'para poner una pantalla distinta a administrador
        Dim fecha_conexion As Date
        Dim insertar_fechaconexion As String
        fecha_conexion = Now.Date
        Dim usuarioLogueado As DataRow

        If tb_correo.Text <> "" And tb_Contraseña.Text <> "" Then
            consulta = "SELECT * FROM usuario where correo='" & tb_correo.Text & "'and contraseña='" & tb_Contraseña.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "usuario")
            lista = datos.Tables("usuario").Rows.OfType(Of DataRow).ToList()
            usuarioLogueado = lista.FirstOrDefault
        End If

        If usuarioLogueado IsNot Nothing Then
            MsgBox("Bienvenido")
            insertar_fechaconexion = "UPDATE usuario SET ult_fecha_conexion = '" & fecha_conexion.ToString("yyyy-MM-dd") & "' WHERE id_usuario = " + usuarioLogueado(0).ToString
            Dim command = New MySqlCommand(insertar_fechaconexion, conexion)
            Dim adap = New MySqlDataAdapter(command)
            command.ExecuteNonQuery()
            'Dim updateAdapter = New MySqlDataAdapter(insertar_fechaconexion, conexion)


            PantallaAdministrador.Show()
        Else
            MsgBox("Intentelo de nuevo")
        End If



    End Sub
End Class
