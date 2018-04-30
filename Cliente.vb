Imports System.Data
Imports System.Data.SqlClient
Public Class Cliente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion2 As New SqlConnection _
           ("server=DESKTOP-RK0NKCP\LUIS; Integrated Security=true; database=VETERINARIA")
        Dim agregar As SqlCommand = New SqlCommand("INSERT INTO CLIENTE VALUES(?ID_CLI, ?NOM_CLI, ?APE_CLI, ?DNI, ?SEXO, ?DIRECCION, ?TELEFONO)", conexion2)
        conexion2.Open()
        Dim cmd As New SqlCommand

        Try
            agregar.Parameters.Clear()
            cmd = New SqlCommand("SP_CLIENTE", conexion2)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID_CLI", id.Text)
            cmd.Parameters.AddWithValue("@NOM_CLI", nombre.Text)
            cmd.Parameters.AddWithValue("@APE_CLI", apellido.Text)
            cmd.Parameters.AddWithValue("@DNI", dni.Text)
            cmd.Parameters.AddWithValue("@SEXO", sexo.Text)
            cmd.Parameters.AddWithValue("@DIRECCION", direccion.Text)
            cmd.Parameters.AddWithValue("@TELEFONO", telefono.Text)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Datos Guardados")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        id.Text = ""
        nombre.Text = ""
        apellido.Text = ""
        dni.Text = ""
        sexo.Text = ""
        direccion.Text = ""
        telefono.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class