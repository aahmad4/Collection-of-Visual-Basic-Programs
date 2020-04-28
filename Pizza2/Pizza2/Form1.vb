'Ali Ahmad
'CP Period 3
'1/31/2019

Public Class Form1
    Private Sub btnYourOrder_Click(sender As Object, e As EventArgs) Handles btnYourOrder.Click
        Dim crust As String
        crust = txtCrust.Text

        Dim topping1 As String
        topping1 = txtTopping2.Text

        Dim topping2 As String
        topping2 = txtTopping3.Text

        lblOrder.Text = "Your choice of crust is " & crust & ". Your first topping choice is " & topping1 & ". Your second topping choice is " & topping2 & ". That's your final order."


    End Sub

    Private Sub txtCrust_TextChanged(sender As Object, e As EventArgs) Handles txtCrust.TextChanged
        lblOrder.Text = ""
        txtTopping2.Text = ""
        txtTopping3.Text = ""
    End Sub

    Private Sub txtTopping2_TextChanged(sender As Object, e As EventArgs) Handles txtTopping2.TextChanged
        lblOrder.Text = ""
    End Sub

    Private Sub txtTopping3_TextChanged(sender As Object, e As EventArgs) Handles txtTopping3.TextChanged
        lblOrder.Text = ""
    End Sub
End Class
