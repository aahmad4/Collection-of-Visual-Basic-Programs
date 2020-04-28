Public Class Form1
    Dim box As New Rectangle(100, 100, 25, 25)
    Private Sub PictureBox1_MouseClick(sender As System.Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        If box.Contains(e.X, e.Y) Then

        End If
        Static intCounter As Integer = 1
        lblCounter.Text = "Score: " & intCounter
        intCounter = intCounter + 1
        If intCounter = 100 Then
            Form2.Show()
            Me.hidE9
        End If
    End Sub
    Private Sub PictureBox1_MouseMove(sender As System.Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If box.Contains(e.X, e.Y) Then
            PictureBox1.BackColor = Color.LightYellow
        Else
            PictureBox1.BackColor = Color.LightCoral
        End If
    End Sub
End Class
