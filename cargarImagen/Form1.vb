Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim buscarFoto As New OpenFileDialog() 'Nos permite abrir el dialogo para buscar un archivo'
        buscarFoto.Filter = "Archivos de Imagen | *.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*"
        If buscarFoto.ShowDialog = DialogResult.OK Then
            Dim ubicacionFoto As String = buscarFoto.FileName 'Obtener / almacenar la ruta de la foto'
            mostrarFoto(ubicacionFoto)
        End If
    End Sub

    Private Sub mostrarFoto(ubicacionFoto As String)
        Dim nuevaImagen As Image = Image.FromFile(ubicacionFoto)
        PictureBox1.Image = nuevaImagen 'insercion de la imagen'
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom 'Amplia la imagen de la foto'
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim formu As New Form 'Se crea un nuevo formulario'
        'formu.FormBorderStyle = FormBorderStyle.None' 'Si el formulario tiene borde '
        formu.SetDesktopLocation(500, 500) 'Size del Formulario'
        formu.Show() 'Que se muestre el formulario'
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
