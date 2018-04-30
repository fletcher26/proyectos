Imports System.Data
Imports System.Data.SqlClient
Public Class InformacionProductos
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As New SqlConnection _
    ("server=DESKTOP-RK0NKCP\LUIS; Integrated Security=true; database=VETERINARIA")
        Dim Comando As New SqlDataAdapter("SELECT * FROM PRODUCTO GO", conexion)
        Dim ds As New DataSet
        Try
            Comando.Fill(ds, "PRODUCTO")
            DataGridView1.DataSource = ds.Tables("PRODUCTO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
            conexion.Dispose()
            Comando.Dispose()
            ds.Dispose()
        End Try
    End Sub

    Private Sub InformacionProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class