Imports System.Data
Imports System.Data.SqlClient

Public Class Empleado
    Private Sub Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        id.Text = ""
        nombre.Text = ""
        apellido.Text = ""
        sexo.Text = ""
        dni.Text = ""
        direccion.Text = ""
        telefono.Text = ""
        email.Text = ""
        turno.Text = ""
        fecha.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion2 As New SqlConnection _
            ("server=DESKTOP-RK0NKCP\LUIS; Integrated Security=true; database=VETERINARIA")
        Dim agregar As SqlCommand = New SqlCommand("INSERT INTO EMPLEADO VALUES(?ID_EMP, ?NOM_EMP, ?APELLIDOS, ?SEXO, ?DNI, ?DIRECCION, ?TELEFONO, ?EMAIL, ?TURNO, ?FECHA_CONTRATA)", conexion2)
        conexion2.Open()
        Dim cmd As New SqlCommand

        Try
            agregar.Parameters.Clear()
            cmd = New SqlCommand("SP_EMPLEADO", conexion2)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID_EMP", id.Text)
            cmd.Parameters.AddWithValue("@NOM_EMP", nombre.Text)
            cmd.Parameters.AddWithValue("@APELLIDOS", apellido.Text)
            cmd.Parameters.AddWithValue("@SEXO", sexo.Text)
            cmd.Parameters.AddWithValue("@DNI", dni.Text)
            cmd.Parameters.AddWithValue("@DIRECCION", direccion.Text)
            cmd.Parameters.AddWithValue("@TELEFONO", telefono.Text)
            cmd.Parameters.AddWithValue("@EMAIL", email.Text)
            cmd.Parameters.AddWithValue("@TURNO", turno.Text)
            cmd.Parameters.AddWithValue("@FECHA_CONTRATA", fecha.Text)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Datos Guardados")
        End Try
    End Sub
End Class
