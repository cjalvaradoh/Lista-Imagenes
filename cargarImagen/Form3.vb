Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex >= 0 AndAlso ListBox1.SelectedIndex < ListBox1.Items.Count Then
            Dim imagePath As String = ListBox1.SelectedItem.ToString()
            Dim image As Image = Image.FromFile(imagePath)

            PictureBox1.Image = image
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub
End Class