Public Class MenuPrincipal
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub ClienteToolStripMenuItem1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub ProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub MascotaToolStripMenuItem1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub ServicioToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub InformaciónDeLosServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs)
    End Sub

    Private Sub Label1_Click_3(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick_2(sender As Object, e As EventArgs)
    End Sub

    Private Sub Timer1_Tick_3(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label2.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub GananciasToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub EmpleadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem1.Click
        Empleado.Show()
        Me.Hide()
    End Sub

    Private Sub ClienteToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem1.Click
        Cliente.Show()
        Me.Hide()
    End Sub

    Private Sub MascotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MascotaToolStripMenuItem.Click
        Mascota.Show()
        Me.Hide()
    End Sub

    Private Sub ServicioToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ServicioToolStripMenuItem.Click
        Servicio.Show()
        Me.Hide()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        InformacionDeEmpleados.Show()
        Me.Hide()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        MascotaCliente.Show()
        Me.Hide()
    End Sub

    Private Sub ServicosRealizadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServicosRealizadosToolStripMenuItem.Click
        ServiciosRealizados.Show()
        Me.Hide()
    End Sub

    Private Sub AnimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnimeToolStripMenuItem.Click
        foto.Show()
        Me.Hide()
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        Producto.Show()
        Me.Hide()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        InformacionProductos.Show()
        Me.Hide()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Ventas.Show()
        Me.Hide()
    End Sub

    Private Sub RegistroVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroVentasToolStripMenuItem.Click
        InformacionVenta.Show()
        Me.Hide()
    End Sub
End Class