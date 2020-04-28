'Ali Ahmad
'3/25/2019
'CP Period 3 Lockamy

Public Class Form1
    'Declare global variable to hold total cost by checks
    Dim total_cost As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Set of conditionals that adds cost based on it being checked. 
        If chkHamburger.Checked Then
            total_cost += 2.95
        End If
        'Set of conditionals that adds cost based on it being checked. 
        If chkCheese.Checked Then
            total_cost += 3.95
        End If
        'Set of conditionals that adds cost based on it being checked. 
        If chkFries.Checked Then
            total_cost += 1.95
        End If
        'Set of conditionals that adds cost based on it being checked. 
        If chkOnion.Checked Then
            total_cost += 2.5
        End If
        'This declared variable is a random number that doesn't change between 100 and 1000. 
        Dim gen As New System.Random()
        Static ordernumber As Integer = gen.Next(100, 1001)
        'This makes the order label show the order number. 
        lblOrderNumber.Text = "Order # " & ordernumber
        'This dims the tax variable making the total cost have 7% tax
        Dim tax As Double = total_cost * 0.07
        'this makes the absolute final cost by adding total cost and tax
        Dim final_cost As Double = tax + total_cost
        'prints the final cost in the label and .tostring to make it currency. 
        lblPleasepay.Text = "Please pay: " & final_cost.ToString("c")

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'adds 2 to the total cost. 
        total_cost += 2
    End Sub

    Private Sub chkHamburger_CheckedChanged(sender As Object, e As EventArgs) Handles chkHamburger.CheckedChanged

    End Sub

    Private Sub chkFries_CheckedChanged(sender As Object, e As EventArgs) Handles chkFries.CheckedChanged

    End Sub

    Private Sub chkCheese_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheese.CheckedChanged

    End Sub

    Private Sub chkOnion_CheckedChanged(sender As Object, e As EventArgs) Handles chkOnion.CheckedChanged

    End Sub
End Class
