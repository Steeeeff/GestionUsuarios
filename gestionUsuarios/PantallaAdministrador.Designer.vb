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
        Me.cmb_Tabla = New System.Windows.Forms.ComboBox()
        Me.cmb_Campo = New System.Windows.Forms.ComboBox()
        Me.OptIgual = New System.Windows.Forms.RadioButton()
        Me.tb_DatoBusqueda = New System.Windows.Forms.TextBox()
        Me.btn_Consulta = New System.Windows.Forms.Button()
        Me.tb_Select = New System.Windows.Forms.TextBox()
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
        'cmb_Tabla
        '
        Me.cmb_Tabla.FormattingEnabled = True
        Me.cmb_Tabla.Location = New System.Drawing.Point(24, 22)
        Me.cmb_Tabla.Name = "cmb_Tabla"
        Me.cmb_Tabla.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Tabla.TabIndex = 5
        '
        'cmb_Campo
        '
        Me.cmb_Campo.FormattingEnabled = True
        Me.cmb_Campo.Location = New System.Drawing.Point(152, 22)
        Me.cmb_Campo.Name = "cmb_Campo"
        Me.cmb_Campo.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Campo.TabIndex = 6
        '
        'OptIgual
        '
        Me.OptIgual.AutoSize = True
        Me.OptIgual.Location = New System.Drawing.Point(279, 26)
        Me.OptIgual.Name = "OptIgual"
        Me.OptIgual.Size = New System.Drawing.Size(48, 17)
        Me.OptIgual.TabIndex = 7
        Me.OptIgual.TabStop = True
        Me.OptIgual.Text = "LIKE"
        Me.OptIgual.UseVisualStyleBackColor = True
        '
        'tb_DatoBusqueda
        '
        Me.tb_DatoBusqueda.Location = New System.Drawing.Point(330, 22)
        Me.tb_DatoBusqueda.Name = "tb_DatoBusqueda"
        Me.tb_DatoBusqueda.Size = New System.Drawing.Size(332, 20)
        Me.tb_DatoBusqueda.TabIndex = 8
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
        'tb_Select
        '
        Me.tb_Select.Location = New System.Drawing.Point(24, 63)
        Me.tb_Select.Name = "tb_Select"
        Me.tb_Select.Size = New System.Drawing.Size(638, 20)
        Me.tb_Select.TabIndex = 10
        '
        'PantallaAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 500)
        Me.Controls.Add(Me.tb_Select)
        Me.Controls.Add(Me.btn_Consulta)
        Me.Controls.Add(Me.tb_DatoBusqueda)
        Me.Controls.Add(Me.OptIgual)
        Me.Controls.Add(Me.cmb_Campo)
        Me.Controls.Add(Me.cmb_Tabla)
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
    Friend WithEvents cmb_Tabla As ComboBox
    Friend WithEvents cmb_Campo As ComboBox
    Friend WithEvents OptIgual As RadioButton
    Friend WithEvents tb_DatoBusqueda As TextBox
    Friend WithEvents btn_Consulta As Button
    Friend WithEvents tb_Select As TextBox
End Class
