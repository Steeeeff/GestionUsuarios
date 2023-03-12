<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.tb_correo = New System.Windows.Forms.TextBox()
        Me.tb_Contraseña = New System.Windows.Forms.TextBox()
        Me.btn_Acceder = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tb_correo
        '
        Me.tb_correo.Location = New System.Drawing.Point(106, 189)
        Me.tb_correo.Name = "tb_correo"
        Me.tb_correo.Size = New System.Drawing.Size(136, 20)
        Me.tb_correo.TabIndex = 0
        '
        'tb_Contraseña
        '
        Me.tb_Contraseña.Location = New System.Drawing.Point(106, 276)
        Me.tb_Contraseña.Name = "tb_Contraseña"
        Me.tb_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_Contraseña.Size = New System.Drawing.Size(136, 20)
        Me.tb_Contraseña.TabIndex = 1
        '
        'btn_Acceder
        '
        Me.btn_Acceder.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_Acceder.Location = New System.Drawing.Point(106, 353)
        Me.btn_Acceder.Name = "btn_Acceder"
        Me.btn_Acceder.Size = New System.Drawing.Size(136, 37)
        Me.btn_Acceder.TabIndex = 2
        Me.btn_Acceder.Text = "Acceder"
        Me.btn_Acceder.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(117, 425)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(113, 13)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Recuperar contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Correo electrónico"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contraseña"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 485)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btn_Acceder)
        Me.Controls.Add(Me.tb_Contraseña)
        Me.Controls.Add(Me.tb_correo)
        Me.Name = "login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_correo As TextBox
    Friend WithEvents tb_Contraseña As TextBox
    Friend WithEvents btn_Acceder As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
