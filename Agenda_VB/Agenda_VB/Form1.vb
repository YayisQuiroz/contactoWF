Public Class Form1
    Private length As Integer = 0
    Private index As Integer = 0
    Private valor As Integer
    Private array As Contacto()
    Private Sub txtNcontactos_TextChanged(ByVal sender As Object, ByVal e As EventArgs)

    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        valor = Integer.Parse(txtNcontactos.Text)
        index = valor
        array = New Contacto(index - 1) {}
        If length < index Then
            Dim x = New Contacto()
            x.Nombr = txtNombre.Text
            x.FechaNacimient = dtpFecha.Value
            x.Telefon = txtNumero.Text
            x.Corre = txtCorreo.Text
            array(length) = x
            length += 1
            Dim linea As String = x.ToString() + Environment.NewLine
            lblMostrar.Text = lblMostrar.Text & linea
            txtNombre.Clear()
            dtpFecha.Value = DateTime.Now
            txtNumero.Clear()
            txtCorreo.Clear()
        End If

        If length = index Then
            MessageBox.Show("se han registrado todos")
        End If
    End Sub
End Class
