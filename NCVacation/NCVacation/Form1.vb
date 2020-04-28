'Ali Ahmad
'CP Period 3
'2/7/2019

Public Class Form1
    Private Sub chkBeach_CheckedChanged(sender As Object, e As EventArgs) Handles chkBeach.CheckedChanged
        lblStuff.Text = "Sandy Beaches"
    End Sub

    Private Sub chkMountains_CheckedChanged(sender As Object, e As EventArgs) Handles chkMountains.CheckedChanged
        lblsecond.Text = "Great Skiing"
    End Sub

    Private Sub chkNC_CheckedChanged(sender As Object, e As EventArgs) Handles chkNC.CheckedChanged
        lblLast.Text = "NC has it all!"
    End Sub
End Class
