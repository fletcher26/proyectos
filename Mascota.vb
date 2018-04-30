Imports System.Data
Imports System.Data.SqlClient
Public Class Mascota
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion2 As New SqlConnection _
         ("server=DESKTOP-RK0NKCP\LUIS; Integrated Security=true; database=VETERINARIA")
        Dim agregar As SqlCommand = New SqlCommand("INSERT INTO MASCOTA VALUES(?ID_MASC, ?NOM_MASC, ?ESPECIE, ?RAZA, ?SEXO)", conexion2)
        conexion2.Open()
        Dim cmd As New SqlCommand

        Try
            agregar.Parameters.Clear()
            cmd = New SqlCommand("SP_MASCOTA", conexion2)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID_MASC", id.Text)
            cmd.Parameters.AddWithValue("@NOM_MASC", nombre.Text)
            cmd.Parameters.AddWithValue("@ESPECIE", especie.Text)
            cmd.Parameters.AddWithValue("@RAZA", raza.Text)
            cmd.Parameters.AddWithValue("@SEXO", sexo.Text)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Datos Guardados")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        id.Text = ""
        nombre.Text = ""
        especie.Text = ""
        raza.Text = ""
        sexo.Text = ""
    End Sub

    Private Sub Mascota_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class