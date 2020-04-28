'Ali Ahmad
'CP Period 3
'4/26/2019
Public Class Form1
    'Variable controls animation
    Dim faceChange As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        'Starts the timer animation
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Stops the timer animation and clears label. 
        Timer1.Stop()
        lblMain.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'This select case if for animating
        Select Case faceChange
            Case 1
                'This makes the guy make it look like he talks as he says study
                faceChange += 1
                PictureBox1.Image = My.Resources.Resource1.Face1Open
                lblMain.Text += "Study "
            Case 2
                'This makes the guy close his face so it still looks like he talks and such. 
                PictureBox1.Image = My.Resources.Resource1.Face2Close
                faceChange = 1
        End Select
    End Sub
End Class
