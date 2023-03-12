<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaEdicionUsuario
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtp_ultimaFechaConexion = New System.Windows.Forms.DateTimePicker()
        Me.cb_rol = New System.Windows.Forms.ComboBox()
        Me.tb_nombre = New System.Windows.Forms.TextBox()
        Me.tb_importe = New System.Windows.Forms.TextBox()
        Me.tb_correo = New System.Windows.Forms.TextBox()
        Me.tb_apellidos = New System.Windows.Forms.TextBox()
        Me.chk_pagado = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_EstadoPagado = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_GuardarCambios = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtp_ultimaFechaConexion)
        Me.GroupBox1.Controls.Add(Me.cb_rol)
        Me.GroupBox1.Controls.Add(Me.tb_nombre)
        Me.GroupBox1.Controls.Add(Me.tb_importe)
        Me.GroupBox1.Controls.Add(Me.tb_correo)
        Me.GroupBox1.Controls.Add(Me.tb_apellidos)
        Me.GroupBox1.Controls.Add(Me.chk_pagado)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tb_EstadoPagado)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(548, 366)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'dtp_ultimaFechaConexion
        '
        Me.dtp_ultimaFechaConexion.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_ultimaFechaConexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_ultimaFechaConexion.Location = New System.Drawing.Point(173, 236)
        Me.dtp_ultimaFechaConexion.Name = "dtp_ultimaFechaConexion"
        Me.dtp_ultimaFechaConexion.Size = New System.Drawing.Size(345, 20)
        Me.dtp_ultimaFechaConexion.TabIndex = 21
        '
        'cb_rol
        '
        Me.cb_rol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_rol.FormattingEnabled = True
        Me.cb_rol.Location = New System.Drawing.Point(172, 186)
        Me.cb_rol.Name = "cb_rol"
        Me.cb_rol.Size = New System.Drawing.Size(346, 23)
        Me.cb_rol.TabIndex = 20
        '
        'tb_nombre
        '
        Me.tb_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nombre.Location = New System.Drawing.Point(172, 47)
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.Size = New System.Drawing.Size(346, 21)
        Me.tb_nombre.TabIndex = 19
        '
        'tb_importe
        '
        Me.tb_importe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_importe.Location = New System.Drawing.Point(172, 287)
        Me.tb_importe.Name = "tb_importe"
        Me.tb_importe.Size = New System.Drawing.Size(346, 21)
        Me.tb_importe.TabIndex = 18
        '
        'tb_correo
        '
        Me.tb_correo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_correo.Location = New System.Drawing.Point(172, 140)
        Me.tb_correo.Name = "tb_correo"
        Me.tb_correo.Size = New System.Drawing.Size(346, 21)
        Me.tb_correo.TabIndex = 15
        '
        'tb_apellidos
        '
        Me.tb_apellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_apellidos.Location = New System.Drawing.Point(172, 93)
        Me.tb_apellidos.Name = "tb_apellidos"
        Me.tb_apellidos.Size = New System.Drawing.Size(346, 21)
        Me.tb_apellidos.TabIndex = 14
        '
        'chk_pagado
        '
        Me.chk_pagado.AutoSize = True
        Me.chk_pagado.Location = New System.Drawing.Point(172, 335)
        Me.chk_pagado.Name = "chk_pagado"
        Me.chk_pagado.Size = New System.Drawing.Size(15, 14)
        Me.chk_pagado.TabIndex = 13
        Me.chk_pagado.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Ultima fecha de conexión"
        '
        'tb_EstadoPagado
        '
        Me.tb_EstadoPagado.AutoSize = True
        Me.tb_EstadoPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_EstadoPagado.Location = New System.Drawing.Point(15, 338)
        Me.tb_EstadoPagado.Name = "tb_EstadoPagado"
        Me.tb_EstadoPagado.Size = New System.Drawing.Size(50, 13)
        Me.tb_EstadoPagado.TabIndex = 5
        Me.tb_EstadoPagado.Text = "Pagado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Importe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Correo electrónico"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 192)
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
        'btn_GuardarCambios
        '
        Me.btn_GuardarCambios.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_GuardarCambios.Location = New System.Drawing.Point(656, 393)
        Me.btn_GuardarCambios.Name = "btn_GuardarCambios"
        Me.btn_GuardarCambios.Size = New System.Drawing.Size(107, 45)
        Me.btn_GuardarCambios.TabIndex = 4
        Me.btn_GuardarCambios.Text = "Guardar Cambios"
        Me.btn_GuardarCambios.UseVisualStyleBackColor = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_cerrar.Location = New System.Drawing.Point(501, 393)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(107, 45)
        Me.btn_cerrar.TabIndex = 5
        Me.btn_cerrar.Text = "Cerrar"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'PantallaEdicionUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_GuardarCambios)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PantallaEdicionUsuario"
        Me.Text = "PantallaEdicionUsuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chk_pagado As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tb_EstadoPagado As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_GuardarCambios As Button
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents tb_apellidos As TextBox
    Friend WithEvents cb_rol As ComboBox
    Friend WithEvents tb_nombre As TextBox
    Friend WithEvents tb_importe As TextBox
    Friend WithEvents tb_correo As TextBox
    Friend WithEvents dtp_ultimaFechaConexion As DateTimePicker
End Class
