Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class Ventas
    Dim strcomando As String
    Dim conexion As String
    Dim adapter As SqlDataAdapter
    Dim data As DataSet
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion2 As New SqlConnection _
         ("server=DESKTOP-RK0NKCP\LUIS;Integrated Security=true; database=VETERINARIA")
        Dim agregar As SqlCommand = New SqlCommand("INSERT INTO VENTAS VALUES(?ID_VENTAS, ?ID_EMP, ?ID_PRO, ?TIPO_PRODUCTO, ?CANTIDAD, ?PRECIO, ?HORA_VENTA)", conexion2)
        conexion2.Open()
        Dim cmd As New SqlCommand

        Try
            agregar.Parameters.Clear()
            cmd = New SqlCommand("SP_VENTAS", conexion2)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID_VENTAS", venta.Text)
            cmd.Parameters.AddWithValue("@ID_EMP", emp.Text)
            cmd.Parameters.AddWithValue("@ID_PRO", pro.Text)
            cmd.Parameters.AddWithValue("@TIPO_PRODUCTO", producto.Text)
            cmd.Parameters.AddWithValue("@CANTIDAD", cantidad.Text)
            cmd.Parameters.AddWithValue("@PRECIO", precio.Text)
            cmd.Parameters.AddWithValue("@HORA_VENTA", fecha.Text)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Datos Guardados")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        venta.Text = ""
        emp.Text = ""
        pro.Text = ""
        producto.Text = ""
        cantidad.Text = ""
        precio.Text = ""
        fecha.Text = ""
    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = ("server=DESKTOP-RK0NKCP\LUIS; Integrated Security=true; database=VETERINARIA")
        strcomando = "Select * From PRODUCTO"
        adapter = New System.Data.SqlClient.SqlDataAdapter(strcomando, conexion)
        data = New DataSet
        adapter.Fill(data)
        producto.DataSource = data.Tables(0)
        producto.DisplayMember = "TIPO_PRODUCTO_REGISTRADO"
        producto.ValueMember = "ID_PRO"
    End Sub

    Private Sub producto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles producto.SelectedIndexChanged
    End Sub
End Class