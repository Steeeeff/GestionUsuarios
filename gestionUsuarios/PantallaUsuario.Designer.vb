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
        Me.chk_pagado = New System.Windows.Forms.CheckBox()
        Me.Lbl_importe = New System.Windows.Forms.Label()
        Me.Lbl_ultimaFechaConexion = New System.Windows.Forms.Label()
        Me.Lbl_rol = New System.Windows.Forms.Label()
        Me.Lbl_correo = New System.Windows.Forms.Label()
        Me.Lbl_apellidos = New System.Windows.Forms.Label()
        Me.Lbl_nombre = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_EstadoPagado = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.GroupBox1.Controls.Add(Me.chk_pagado)
        Me.GroupBox1.Controls.Add(Me.Lbl_importe)
        Me.GroupBox1.Controls.Add(Me.Lbl_ultimaFechaConexion)
        Me.GroupBox1.Controls.Add(Me.Lbl_rol)
        Me.GroupBox1.Controls.Add(Me.Lbl_correo)
        Me.GroupBox1.Controls.Add(Me.Lbl_apellidos)
        Me.GroupBox1.Controls.Add(Me.Lbl_nombre)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tb_EstadoPagado)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 281)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'chk_pagado
        '
        Me.chk_pagado.AutoSize = True
        Me.chk_pagado.Enabled = False
        Me.chk_pagado.Location = New System.Drawing.Point(182, 224)
        Me.chk_pagado.Name = "chk_pagado"
        Me.chk_pagado.Size = New System.Drawing.Size(15, 14)
        Me.chk_pagado.TabIndex = 13
        Me.chk_pagado.UseVisualStyleBackColor = True
        '
        'Lbl_importe
        '
        Me.Lbl_importe.AutoSize = True
        Me.Lbl_importe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_importe.Location = New System.Drawing.Point(179, 197)
        Me.Lbl_importe.Margin = New System.Windows.Forms.Padding(25, 0, 3, 0)
        Me.Lbl_importe.Name = "Lbl_importe"
        Me.Lbl_importe.Size = New System.Drawing.Size(75, 13)
        Me.Lbl_importe.TabIndex = 12
        Me.Lbl_importe.Text = "asdsadsadasd"
        '
        'Lbl_ultimaFechaConexion
        '
        Me.Lbl_ultimaFechaConexion.AutoSize = True
        Me.Lbl_ultimaFechaConexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ultimaFechaConexion.Location = New System.Drawing.Point(179, 167)
        Me.Lbl_ultimaFechaConexion.Margin = New System.Windows.Forms.Padding(25, 0, 3, 0)
        Me.Lbl_ultimaFechaConexion.Name = "Lbl_ultimaFechaConexion"
        Me.Lbl_ultimaFechaConexion.Size = New System.Drawing.Size(70, 13)
        Me.Lbl_ultimaFechaConexion.TabIndex = 11
        Me.Lbl_ultimaFechaConexion.Text = "asdasdasdad"
        '
        'Lbl_rol
        '
        Me.Lbl_rol.AutoSize = True
        Me.Lbl_rol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_rol.Location = New System.Drawing.Point(179, 137)
        Me.Lbl_rol.Margin = New System.Windows.Forms.Padding(25, 0, 3, 0)
        Me.Lbl_rol.Name = "Lbl_rol"
        Me.Lbl_rol.Size = New System.Drawing.Size(58, 13)
        Me.Lbl_rol.TabIndex = 10
        Me.Lbl_rol.Text = "asdasdasd"
        '
        'Lbl_correo
        '
        Me.Lbl_correo.AutoSize = True
        Me.Lbl_correo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_correo.Location = New System.Drawing.Point(179, 107)
        Me.Lbl_correo.Margin = New System.Windows.Forms.Padding(25, 0, 3, 0)
        Me.Lbl_correo.Name = "Lbl_correo"
        Me.Lbl_correo.Size = New System.Drawing.Size(58, 13)
        Me.Lbl_correo.TabIndex = 9
        Me.Lbl_correo.Text = "asdsadsad"
        '
        'Lbl_apellidos
        '
        Me.Lbl_apellidos.AutoSize = True
        Me.Lbl_apellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_apellidos.Location = New System.Drawing.Point(179, 77)
        Me.Lbl_apellidos.Margin = New System.Windows.Forms.Padding(25, 0, 3, 0)
        Me.Lbl_apellidos.Name = "Lbl_apellidos"
        Me.Lbl_apellidos.Size = New System.Drawing.Size(58, 13)
        Me.Lbl_apellidos.TabIndex = 8
        Me.Lbl_apellidos.Text = "asdsadasd"
        '
        'Lbl_nombre
        '
        Me.Lbl_nombre.AutoSize = True
        Me.Lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_nombre.Location = New System.Drawing.Point(179, 47)
        Me.Lbl_nombre.Margin = New System.Windows.Forms.Padding(25, 0, 3, 0)
        Me.Lbl_nombre.Name = "Lbl_nombre"
        Me.Lbl_nombre.Size = New System.Drawing.Size(58, 13)
        Me.Lbl_nombre.TabIndex = 7
        Me.Lbl_nombre.Text = "asdsadasd"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Ultima fecha de conexión"
        '
        'tb_EstadoPagado
        '
        Me.tb_EstadoPagado.AutoSize = True
        Me.tb_EstadoPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_EstadoPagado.Location = New System.Drawing.Point(15, 227)
        Me.tb_EstadoPagado.Name = "tb_EstadoPagado"
        Me.tb_EstadoPagado.Size = New System.Drawing.Size(50, 13)
        Me.tb_EstadoPagado.TabIndex = 5
        Me.tb_EstadoPagado.Text = "Pagado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Importe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Correo electrónico"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo de usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(25, 0, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
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
    Friend WithEvents Label7 As Label
    Friend WithEvents tb_EstadoPagado As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents chk_pagado As CheckBox
    Friend WithEvents Lbl_importe As Label
    Friend WithEvents Lbl_ultimaFechaConexion As Label
    Friend WithEvents Lbl_rol As Label
    Friend WithEvents Lbl_correo As Label
    Friend WithEvents Lbl_apellidos As Label
    Friend WithEvents Lbl_nombre As Label
End Class
