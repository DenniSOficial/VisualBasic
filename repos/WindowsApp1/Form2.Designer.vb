<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContrasenia = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(35, 78)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 0
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(26, 26)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'txtContrasenia
        '
        Me.txtContrasenia.Location = New System.Drawing.Point(26, 52)
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.Size = New System.Drawing.Size(100, 20)
        Me.txtContrasenia.TabIndex = 2
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(158, 124)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.btnIngresar)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIngresar As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContrasenia As TextBox
End Class
