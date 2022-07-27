Imports ClassLibrary1

Public Class Form2

    Dim obj As New Class1

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Dim dt As DataTable = obj.Login(txtUsuario.Text, txtContrasenia.Text)

        If dt.Rows.Count > 0 Then
            MsgBox("Bienvenido")
            Form1.ShowDialog()
        Else
            MsgBox("Usuario o contraseña invalido")
            LimpiarControles()
        End If

    End Sub

    Private Sub LimpiarControles()

        txtUsuario.Text = ""
        txtContrasenia.Text = ""

    End Sub

End Class