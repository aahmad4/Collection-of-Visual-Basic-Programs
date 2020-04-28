'Ali Ahmad
'CP Period 3
'1/25/2019

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub chkPepperoni_CheckedChanged(sender As Object, e As EventArgs) Handles chkPepperoni.CheckedChanged
        lblChoice1.Text = “You chose to add Pepperoni.”
    End Sub

    Private Sub chkCheese_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheese.CheckedChanged
        lblChoice2.Text = “You chose to add Cheese.”
    End Sub

    Private Sub chkMushrooms_CheckedChanged(sender As Object, e As EventArgs) Handles chkMushrooms.CheckedChanged
        lblChoice3.Text = “You chose to add Mushrooms.”
    End Sub
End Class
