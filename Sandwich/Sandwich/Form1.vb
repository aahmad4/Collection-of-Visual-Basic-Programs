'Ali Ahmad
'CP Period 3
'1/25/2019

Public Class Form1
    Private Sub radHam_CheckedChanged(sender As Object, e As EventArgs) Handles radHam.CheckedChanged
        lblMainChoice.Text = "You chose the ham sandwich."
    End Sub

    Private Sub radTurkey_CheckedChanged(sender As Object, e As EventArgs) Handles radTurkey.CheckedChanged
        lblMainChoice.Text = "You chose the turkey sandwich."
    End Sub

    Private Sub chkMayo_CheckedChanged(sender As Object, e As EventArgs) Handles chkMayo.CheckedChanged
        lblChoice1.Text = “You would like mayonnaise.”
    End Sub

    Private Sub chkMustard_CheckedChanged(sender As Object, e As EventArgs) Handles chkMustard.CheckedChanged
        lblChoice2.Text = “You would like mustard.”
    End Sub

    Private Sub chkCheese_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheese.CheckedChanged
        lblChoice3.Text = “You would like cheese.”
    End Sub
End Class
