Imports System.Data
Imports System.Data.SqlClient
Public Class MascotaCliente
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As New SqlConnection _
   ("server=DESKTOP-RK0NKCP\LUIS; Integrated Security=true; database=VETERINARIA")
        Dim Comando As New SqlDataAdapter("SELECT a.ID_CLI, a.NOM_CLI, a.DNI, a.TELEFONO, b.NOM_MASC, b.ID_MASC
FROM CLIENTE a inner join MASCOTA b ON a.ID_CLI = b.ID_MASC", conexion)
        Dim ds As New DataSet
        Try
            Comando.Fill(ds, "CLIENTE")
            DataGridView1.DataSource = ds.Tables("CLIENTE")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
            conexion.Dispose()
            Comando.Dispose()
            ds.Dispose()
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) 
    End Sub

    Private Sub MascotaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class