Imports System.Data
Imports System.Data.SqlClient
Public Class Producto
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion2 As New SqlConnection _
           ("server=DESKTOP-RK0NKCP\LUIS; Integrated Security=true; database=VETERINARIA")
        Dim agregar As SqlCommand = New SqlCommand("INSERT INTO PRODUCTO VALUES(?ID_PRO, ?TIPO_PRODUCTO_REGISTRADO, ?CANTIDAD, ?PRECIO, ?FECHA_REGISTRO)", conexion2)
        conexion2.Open()
        Dim cmd As New SqlCommand

        Try
            agregar.Parameters.Clear()
            cmd = New SqlCommand("SP_PRODUCTO", conexion2)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID_PRO", id.Text)
            cmd.Parameters.AddWithValue("@TIPO_PRODUCTO_REGISTRADO", productos.Text)
            cmd.Parameters.AddWithValue("@CANTIDAD", cantidad.Text)
            cmd.Parameters.AddWithValue("@PRECIO", precio.Text)
            cmd.Parameters.AddWithValue("@FECHA_REGISTRO", fecha.Text)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Datos Guardados")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        id.Text = ""
        productos.Text = ""
        cantidad.Text = ""
        fecha.Text = ""
    End Sub

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class