'Ali Ahmad
'CP Period 3
'4/26/2019

Public Class Form1
    'This variable is set to 1
    Dim kicksCount As Integer = 1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Select Case kicksCount
            Case 1
                'Select case makes the first case have the left foot up picture. 
                PictureBox1.Image = My.Resources.Resource1.stand
                kicksCount += 1
            Case 2
                'This select case makes the second case be standing
                PictureBox1.Image = My.Resources.Resource1.rtFootUp
                kicksCount += 1
            Case 3
                'This select case 3 makes the right foot up. 
                PictureBox1.Image = My.Resources.Resource1.leftFootUp
                kicksCount = 1
                'It's set equal to 1 to it keeps looping
        End Select
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'This makes the entire timer process start when you click on the picture box. 
        Timer1.Start()
    End Sub
End Class
