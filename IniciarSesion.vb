Public Class IniciarSesion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If usuario.Text = "lucas" And contraseña.Text = "1234" Then
            MsgBox("Bienvenido al Sistema")
            MenuPrincipal.Show()
            Me.Hide()
        Else
            MsgBox("Información Incorrecta")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub contraseña_TextChanged(sender As Object, e As EventArgs) Handles contraseña.TextChanged
        contraseña.PasswordChar = "*"
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Ayuda.Show()
        Me.Hide()
    End Sub

    Private Sub IniciarSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
