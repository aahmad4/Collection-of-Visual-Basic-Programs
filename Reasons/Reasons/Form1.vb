'Ali Ahmad
'CP Period 3
'4/10/2019

Public Class Form1

    'Creatinv this private sub makes the showReasons sub show the label show reasons. 
    Private Sub showReasons()
        'This is what is in the showReaons sub
        Label1.Text = "CS teaches critical thinking." & vbCrLf & "CS touches everyone, everyday" & vbCrLf & "Computing jobs are in high demand."
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'When the button gets clicked the showReasons sub gets shown which as seen above makes the label show. 
        showReasons()
    End Sub

End Class
