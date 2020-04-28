'Ali Ahmad
'CP Period 3
'1/25/2019

Public Class Form1
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        lbl1.Text = "This bike shop has been located here for over 10 years. We specialize in custom bikes built just for you!"
    End Sub

    Private Sub radRoad_CheckedChanged(sender As Object, e As EventArgs) Handles radRoad.CheckedChanged
        lbl1.Text = "You chose the road bike."
        bikeType = 1
    End Sub

    Private Sub radMountain_CheckedChanged(sender As Object, e As EventArgs) Handles radMountain.CheckedChanged
        lbl1.Text = "You chose the mountain bike."
        bikeType = 2
    End Sub

    Private Sub radHybrid_CheckedChanged(sender As Object, e As EventArgs) Handles radHybrid.CheckedChanged
        lbl1.Text = "You chose the hybrid bike."
        bikeType = 3
    End Sub

    Private Sub chkPaint_CheckedChanged(sender As Object, e As EventArgs) Handles chkPaint.CheckedChanged
        If chkPaint.Checked = True Then
            lbl1.Text &= " You would like to add custom paint. "
        ElseIf bikeType = 1 Then
            lbl1.Text = "You chose the road bike. "
        ElseIf bikeType = 2 Then
            lbl1.Text = "You chose the mountain bike. "
        Else bikeType = 3
            lbl1.Text = "You chose the hybrid bike. "
        End If


    End Sub

    Private Sub chkFrame_CheckedChanged(sender As Object, e As EventArgs) Handles chkFrame.CheckedChanged
        If chkFrame.Checked = True Then
            lbl1.Text &= " You would like a heavy duty frame. "
        ElseIf bikeType = 1 Then
            lbl1.Text = "You chose the road bike. "
        ElseIf bikeType = 2 Then
            lbl1.Text = "You chose the mountain bike. "
        Else bikeType = 3
            lbl1.Text = "You chose the hybrid bike. "
        End If
    End Sub

    Private Sub chkSeat_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeat.CheckedChanged
        If chkSeat.Checked = True Then
            lbl1.Text &= " You would like a comfort seat. "
        ElseIf bikeType = 1 Then
            lbl1.Text = "You chose the road bike. "
        ElseIf bikeType = 2 Then
            lbl1.Text = "You chose the mountain bike. "
        Else bikeType = 3
            lbl1.Text = "You chose the hybrid bike. "
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radRoad.AutoCheck = True
        radMountain.AutoCheck = True
        radHybrid.AutoCheck = True
    End Sub

    Dim bikeType As Byte
End Class
