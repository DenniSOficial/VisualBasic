Imports ClassLibrary1

Public Class Form1

    Dim obj As New Class1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboArea.DataSource = obj.ListarArea
        cboArea.DisplayMember = "AREA"
        cboArea.ValueMember = "ID"
        dgvDatos.DataSource = obj.Listar

    End Sub

    Private Sub dgvDatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellContentClick

        lblCodigo.Text = dgvDatos.Item(0, e.RowIndex).Value
        txtNombre.Text = dgvDatos.Item(1, e.RowIndex).Value
        txtDireccion.Text = dgvDatos.Item(2, e.RowIndex).Value
        txtArea.Text = dgvDatos.Item(3, e.RowIndex).Value
        cboArea.SelectedValue = dgvDatos.Item(3, e.RowIndex).Value
        dtpIngreso.Text = dgvDatos.Item(4, e.RowIndex).Value
        dtpTermino.Text = dgvDatos.Item(5, e.RowIndex).Value

    End Sub

    Private Sub tsmRegistrar_Click(sender As Object, e As EventArgs) Handles tsmRegistrar.Click

        Try
            obj.Insertar(txtNombre.Text, txtDireccion.Text, cboArea.SelectedValue, (CDate(dtpIngreso.Value)), (CDate(dtpTermino.Value)))
            dgvDatos.DataSource = obj.Listar
            MsgBox("Se registro el usuario: " + txtNombre.Text)
            LimpiarControles()
        Catch ex As Exception
            MsgBox("Error")
        End Try

    End Sub

    Private Sub LimpiarControles()

        lblCodigo.Text = "E0000"
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtArea.Text = ""
        cboArea.SelectedIndex = 0
        dtpIngreso.Value = DateTime.Now
        dtpTermino.Value = DateTime.Now

    End Sub

    Private Sub tsmModificar_Click(sender As Object, e As EventArgs) Handles tsmModificar.Click

        Try
            obj.Modificar(lblCodigo.Text, txtNombre.Text, txtDireccion.Text, cboArea.SelectedValue, (CDate(dtpIngreso.Value)), (CDate(dtpTermino.Value)))
            dgvDatos.DataSource = obj.Listar
            MsgBox("Se modifico el usuario con código: " + lblCodigo.Text)
            LimpiarControles()
        Catch ex As Exception
            MsgBox("Error")
        End Try

    End Sub

    Private Sub tsmEliminar_Click(sender As Object, e As EventArgs) Handles tsmEliminar.Click

        Try
            obj.Eliminar(lblCodigo.Text)
            dgvDatos.DataSource = obj.Listar
            MsgBox("Se elimino el usuario con código: " + lblCodigo.Text)
            LimpiarControles()
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub tsmNuevo_Click(sender As Object, e As EventArgs) Handles tsmNuevo.Click
        LimpiarControles()
    End Sub

End Class
