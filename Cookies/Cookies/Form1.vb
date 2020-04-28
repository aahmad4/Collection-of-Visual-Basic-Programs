'Ali Ahmad
'CP Period 3
'1/25/2019



Public Class Form1
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        lblChoice.Text = "Order MORE Cookies."
    End Sub

    Private Sub radChocChip_CheckedChanged(sender As Object, e As EventArgs) Handles radChocChip.CheckedChanged
        lblChoice.Text = “You chose our chocolate chip cookies.”
    End Sub

    Private Sub radOatmeal_CheckedChanged(sender As Object, e As EventArgs) Handles radOatmeal.CheckedChanged
        lblChoice.Text = “You chose our oatmeal raison cookies.”
    End Sub

    Private Sub radPeanutButter_CheckedChanged(sender As Object, e As EventArgs) Handles radPeanutButter.CheckedChanged
        lblChoice.Text = “You chose our peanut butter cookies.”
    End Sub
End Class
