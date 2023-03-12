<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_CerrarSesion = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_EstadoPagado = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_nombre = New System.Windows.Forms.TextBox()
        Me.tb_apellidos = New System.Windows.Forms.TextBox()
        Me.tb_correo = New System.Windows.Forms.TextBox()
        Me.tb_tipoUsuario = New System.Windows.Forms.TextBox()
        Me.tb_ultConexion = New System.Windows.Forms.TextBox()
        Me.tb_importe = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_CerrarSesion
        '
        Me.btn_CerrarSesion.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_CerrarSesion.Location = New System.Drawing.Point(659, 361)
        Me.btn_CerrarSesion.Name = "btn_CerrarSesion"
        Me.btn_CerrarSesion.Size = New System.Drawing.Size(107, 45)
        Me.btn_CerrarSesion.TabIndex = 1
        Me.btn_CerrarSesion.Text = "Cerrar sesión"
        Me.btn_CerrarSesion.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.tb_importe)
        Me.GroupBox1.Controls.Add(Me.tb_ultConexion)
        Me.GroupBox1.Controls.Add(Me.tb_tipoUsuario)
        Me.GroupBox1.Controls.Add(Me.tb_correo)
        Me.GroupBox1.Controls.Add(Me.tb_apellidos)
        Me.GroupBox1.Controls.Add(Me.tb_nombre)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tb_EstadoPagado)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 281)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellidos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Correo electrónico:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo de usuario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Importe:"
        '
        'tb_EstadoPagado
        '
        Me.tb_EstadoPagado.AutoSize = True
        Me.tb_EstadoPagado.Location = New System.Drawing.Point(44, 209)
        Me.tb_EstadoPagado.Name = "tb_EstadoPagado"
        Me.tb_EstadoPagado.Size = New System.Drawing.Size(83, 13)
        Me.tb_EstadoPagado.TabIndex = 5
        Me.tb_EstadoPagado.Text = "Estado Pagado:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Ultima fecha de conexión:"
        '
        'tb_nombre
        '
        Me.tb_nombre.Location = New System.Drawing.Point(143, 27)
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.Size = New System.Drawing.Size(169, 20)
        Me.tb_nombre.TabIndex = 7
        '
        'tb_apellidos
        '
        Me.tb_apellidos.Location = New System.Drawing.Point(143, 57)
        Me.tb_apellidos.Name = "tb_apellidos"
        Me.tb_apellidos.Size = New System.Drawing.Size(169, 20)
        Me.tb_apellidos.TabIndex = 8
        '
        'tb_correo
        '
        Me.tb_correo.Location = New System.Drawing.Point(143, 85)
        Me.tb_correo.Name = "tb_correo"
        Me.tb_correo.Size = New System.Drawing.Size(169, 20)
        Me.tb_correo.TabIndex = 9
        '
        'tb_tipoUsuario
        '
        Me.tb_tipoUsuario.Location = New System.Drawing.Point(143, 119)
        Me.tb_tipoUsuario.Name = "tb_tipoUsuario"
        Me.tb_tipoUsuario.Size = New System.Drawing.Size(169, 20)
        Me.tb_tipoUsuario.TabIndex = 10
        '
        'tb_ultConexion
        '
        Me.tb_ultConexion.Location = New System.Drawing.Point(143, 148)
        Me.tb_ultConexion.Name = "tb_ultConexion"
        Me.tb_ultConexion.Size = New System.Drawing.Size(169, 20)
        Me.tb_ultConexion.TabIndex = 11
        '
        'tb_importe
        '
        Me.tb_importe.Location = New System.Drawing.Point(143, 178)
        Me.tb_importe.Name = "tb_importe"
        Me.tb_importe.Size = New System.Drawing.Size(169, 20)
        Me.tb_importe.TabIndex = 12
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(143, 209)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(169, 20)
        Me.TextBox7.TabIndex = 13
        '
        'PantallaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_CerrarSesion)
        Me.Name = "PantallaUsuario"
        Me.Text = "PantallaUsuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_CerrarSesion As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents tb_importe As TextBox
    Friend WithEvents tb_ultConexion As TextBox
    Friend WithEvents tb_tipoUsuario As TextBox
    Friend WithEvents tb_correo As TextBox
    Friend WithEvents tb_apellidos As TextBox
    Friend WithEvents tb_nombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tb_EstadoPagado As Label
    Friend WithEvents Label5 As Label
End Class
