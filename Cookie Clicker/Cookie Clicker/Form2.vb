Public Class Form2

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Static intCounter As Integer = 100
        intCounter = intCounter + 1
        lblCounter.Text = "Score: " & intCounter
        If intCounter = 500 Then
            Form3.Show()
            Me.Hide()
        End If
    End Sub
End Class
