<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaAdministrador
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
        Me.DataGridUsuarios = New System.Windows.Forms.DataGridView()
        Me.btn_Añadir = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_CerrarSesion = New System.Windows.Forms.Button()
        Me.btn_Consulta = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridUsuarios
        '
        Me.DataGridUsuarios.AllowUserToAddRows = False
        Me.DataGridUsuarios.AllowUserToDeleteRows = False
        Me.DataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridUsuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridUsuarios.Location = New System.Drawing.Point(24, 130)
        Me.DataGridUsuarios.Name = "DataGridUsuarios"
        Me.DataGridUsuarios.ReadOnly = True
        Me.DataGridUsuarios.Size = New System.Drawing.Size(638, 345)
        Me.DataGridUsuarios.TabIndex = 0
        '
        'btn_Añadir
        '
        Me.btn_Añadir.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_Añadir.Location = New System.Drawing.Point(691, 63)
        Me.btn_Añadir.Name = "btn_Añadir"
        Me.btn_Añadir.Size = New System.Drawing.Size(75, 23)
        Me.btn_Añadir.TabIndex = 1
        Me.btn_Añadir.Text = "Añadir"
        Me.btn_Añadir.UseVisualStyleBackColor = False
        '
        'btn_Modificar
        '
        Me.btn_Modificar.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_Modificar.Location = New System.Drawing.Point(691, 130)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Modificar.TabIndex = 2
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.UseVisualStyleBackColor = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_Eliminar.Location = New System.Drawing.Point(691, 190)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Eliminar.TabIndex = 3
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_CerrarSesion
        '
        Me.btn_CerrarSesion.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_CerrarSesion.Location = New System.Drawing.Point(691, 425)
        Me.btn_CerrarSesion.Name = "btn_CerrarSesion"
        Me.btn_CerrarSesion.Size = New System.Drawing.Size(93, 50)
        Me.btn_CerrarSesion.TabIndex = 4
        Me.btn_CerrarSesion.Text = "Cerrar sesión"
        Me.btn_CerrarSesion.UseVisualStyleBackColor = False
        '
        'btn_Consulta
        '
        Me.btn_Consulta.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_Consulta.Location = New System.Drawing.Point(691, 22)
        Me.btn_Consulta.Name = "btn_Consulta"
        Me.btn_Consulta.Size = New System.Drawing.Size(75, 23)
        Me.btn_Consulta.TabIndex = 9
        Me.btn_Consulta.Text = "Buscar"
        Me.btn_Consulta.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(24, 38)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Label1"
        '
        'PantallaAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 500)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btn_Consulta)
        Me.Controls.Add(Me.btn_CerrarSesion)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_Añadir)
        Me.Controls.Add(Me.DataGridUsuarios)
        Me.Name = "PantallaAdministrador"
        Me.Text = "PantallaAdministrador"
        CType(Me.DataGridUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridUsuarios As DataGridView
    Friend WithEvents btn_Añadir As Button
    Friend WithEvents btn_Modificar As Button
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents btn_CerrarSesion As Button
    Friend WithEvents btn_Consulta As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
End Class
