'Ali Ahmad
'CP Period 3
'2/5/2019
Public Class Form1
    Dim decPrice As Decimal
    Dim intQuantity As Integer
    Private Sub radGlazed_CheckedChanged(sender As Object, e As EventArgs) Handles radGlazed.CheckedChanged
        lblChoices.Text = ("You chose the Glazed doughnut." & vbCrLf & "They are only $0.50 each.")
        decPrice = 0.5
    End Sub

    Private Sub radChoc_CheckedChanged(sender As Object, e As EventArgs) Handles radChocolate.CheckedChanged
        lblChoices.Text = "You chose the Chocolate doughnut." & vbCrLf & "They are only $0.65 each."
        decPrice = 0.65
    End Sub

    Private Sub radBlueberry_CheckedChanged(sender As Object, e As EventArgs) Handles radBlueberry.CheckedChanged
        lblChoices.Text = "You chose the Blueberry doughnut." & vbCrLf & "They are only $0.75 each."
        decPrice = 0.75
    End Sub

    Private Sub radLemon_CheckedChanged(sender As Object, e As EventArgs) Handles radLemon.CheckedChanged
        lblChoices.Text = "You chose the Lemon doughnut." & vbCrLf & "They are only $0.60 each."
        decPrice = 0.6
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        intQuantity = txtHowMany.Text
        lblTotalCost.Text = "Your total cost is, " & (intQuantity * decPrice).ToString("C")
        MessageBox.Show("Have A Great Day!")
    End Sub
End Class