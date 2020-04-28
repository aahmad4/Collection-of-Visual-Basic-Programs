'Ali Ahmad
'3/25/2019
'CP Period 3 Lockamy

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'This is the variable which holds the total cost, it will be the one getting added on ti. 
        Dim total_cost As Double = 0

        'This conditional checks if the first checkbox is checked, if it is then it adds 9.95 to the total cost variable, otherwise nothing.
        If CheckBox1.Checked Then
            total_cost += 9.95
        End If
        'This conditional is the same but for checkbox2
        If CheckBox2.Checked Then
            total_cost += 3.95
        End If
        'Same for checkbox 3
        If CheckBox3.Checked Then
            total_cost += 5.95
        End If
        'Same for the last checkbox
        If CheckBox4.Checked Then
            total_cost += 2.95
        End If
        'This prints the total cost in the label and .tostring makes it into a currency. 
        lblMain.Text = "Total Cost: " & total_cost.ToString("c")
    End Sub
End Class
