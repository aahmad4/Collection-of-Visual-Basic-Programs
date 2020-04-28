'Ali Ahmad
'3/25/2019
'CP Period 3 Lockamy

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'This variable holds the value of the user input
        Dim fee As Integer = TextBox1.Text
        'This variable declares the minutes_cost
        Dim minutes_cost As Double
        'This select case basically associates the user input to a minute cost value, based on cents
        Select Case fee
            Case 0 To 200 : minutes_cost = 0
            Case 201 To 300 : minutes_cost = 0.17
            Case 300 To 500 : minutes_cost = 0.15
            Case 500 To 1000000000 : minutes_cost = 0.12
        End Select
        'This variable is the total minute cost meaning user input multiplied by the associated value
        Dim total_minutes As Double = fee * minutes_cost
        'This is a constant value for the month
        Dim regular_fee As Double = 9.95
        'This is the amount of taxes, which is 7 percent of the first two variables
        Dim taxes_cost As Double = (9.95 + total_minutes) * 0.07
        'This variable is the total cost meaning everything added together. 
        Dim total_cost As Double = total_minutes + regular_fee + taxes_cost
        'This prints all the costs on the bottom label and I used .tostring so it shows as a currency. 
        lblMain.Text = "Regular Fee: " & regular_fee.ToString("c") & vbCrLf & "Minutes Cost: " & total_minutes.ToString("c") & vbCrLf & "Taxes: " & taxes_cost.ToString("c") & vbCrLf & "Total Charge: " & total_cost.ToString("c")
    End Sub
End Class
