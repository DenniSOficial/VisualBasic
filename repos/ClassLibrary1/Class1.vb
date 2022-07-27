Imports System.Data.SqlClient

Public Class Class1

    Dim cn As New SqlConnection("server=localhost;integrated security=true;Database=PRUEBA")

    Public Function Login(usuario As String, contrasenia As String) As DataTable

        Dim cmd As SqlCommand = New SqlCommand("sp_Login", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@usuario", usuario)
        cmd.Parameters.AddWithValue("@contrasenia", contrasenia)
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim tbl As DataTable = New DataTable()
        da.Fill(tbl)
        Return tbl

    End Function

    Public Function Listar() As DataTable

        Dim da As New SqlDataAdapter("sp_Listar", cn)
        Dim tbl As New DataTable
        da.Fill(tbl)
        Return tbl

    End Function

    Public Function ListarArea() As DataTable

        Dim da As New SqlDataAdapter("sp_ListarArea", cn)
        Dim tbl As New DataTable
        da.Fill(tbl)
        Return tbl

    End Function

    Public Function Insertar(nombre As String, direccion As String, area As String, ingreso As Date, termino As Date) As Integer

        Dim da As New SqlCommand("sp_Nuevo", cn)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@nombre", nombre)
        da.Parameters.AddWithValue("@direccion", direccion)
        da.Parameters.AddWithValue("@area", area)
        da.Parameters.AddWithValue("@ingreso", ingreso)
        da.Parameters.AddWithValue("@termino", termino)

        cn.Open()

        Dim rpta As Integer

        Try
            rpta = da.ExecuteNonQuery
            cn.Close()
        Catch ex As Exception
            MsgBox("Error al registrar usuario")
        End Try

        Return rpta

    End Function

    Public Function Eliminar(codigo As String) As Integer

        Dim da As New SqlCommand("sp_Eliminar", cn)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@codigo", codigo)

        cn.Open()

        Dim rpta As Integer

        Try
            rpta = da.ExecuteNonQuery
            cn.Close()
        Catch ex As Exception
            MsgBox("Error al registrar usuario")
        End Try

        Return rpta

    End Function

    Public Function Modificar(codigo As String, nombre As String, direccion As String, area As String, ingreso As Date, termino As Date) As Integer

        Dim da As New SqlCommand("sp_Actualizar", cn)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@codigo", codigo)
        da.Parameters.AddWithValue("@nombre", nombre)
        da.Parameters.AddWithValue("@direccion", direccion)
        da.Parameters.AddWithValue("@area", area)
        da.Parameters.AddWithValue("@ingreso", ingreso)
        da.Parameters.AddWithValue("@termino", termino)

        cn.Open()

        Dim rpta As Integer

        Try
            rpta = da.ExecuteNonQuery
            cn.Close()
        Catch ex As Exception
            MsgBox("Error al actualizar usuario")
        End Try

        Return rpta

    End Function

End Class
