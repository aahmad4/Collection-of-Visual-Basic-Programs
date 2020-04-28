'Ali Ahmad
'CP Period 3
'4/25/2019

Public Class Form1
    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        'This makes the picturebox change to the red stop light picture. 
        PictureBox1.Image = My.Resources.Resource1.stopLightRed
    End Sub

    Private Sub btnYellow_Click(sender As Object, e As EventArgs) Handles btnYellow.Click
        'This makes the picturebox change to the yellow stop light picture. 
        PictureBox1.Image = My.Resources.Resource1.stopLightYellow
    End Sub

    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        'This makes the picturebox change to the green stop light picture. 
        PictureBox1.Image = My.Resources.Resource1.stopLightGreen
    End Sub
End Class
