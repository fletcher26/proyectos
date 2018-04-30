Imports System.Data
Imports System.Data.SqlClient
Public Class Servicio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion2 As New SqlConnection _
          ("server=DESKTOP-RK0NKCP\LUIS; Integrated Security=true; database=VETERINARIA")
        Dim agregar As SqlCommand = New SqlCommand("INSERT INTO SERVICIO VALUES(?ID_SERV, ?ID_EMP, ?ID_CLI, ?ID_MASC, ?TIPO_SERV, ?PRECIO_SERV, ?FECHA_REGISTRO)", conexion2)
        conexion2.Open()
        Dim cmd As New SqlCommand

        Try
            agregar.Parameters.Clear()
            cmd = New SqlCommand("SP_SERVICIO", conexion2)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID_SERV", id.Text)
            cmd.Parameters.AddWithValue("@ID_EMP", emp.Text)
            cmd.Parameters.AddWithValue("@ID_CLI", cli.Text)
            cmd.Parameters.AddWithValue("@ID_MASC", masc.Text)
            cmd.Parameters.AddWithValue("@TIPO_SERV", tipo.Text)
            cmd.Parameters.AddWithValue("@PRECIO_SERV", precio.Text)
            cmd.Parameters.AddWithValue("@FECHA_REGISTRO", fecha.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Datos Guardados")

        Catch ex As Exception
            MessageBox.Show("Error" + ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        id.Text = ""
        emp.Text = ""
        cli.Text = ""
        masc.Text = ""
        tipo.Text = ""
        precio.Text = ""
        fecha.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub Servicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class