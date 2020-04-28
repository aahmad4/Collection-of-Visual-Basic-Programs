Public Class Form1
    Dim dbl1 As Double
    Dim dbl2 As Double
    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        dbl1 = Convert.ToDouble(InputBox("Please Enter a Number", "First Number Value")) 'This gets input from the user through an input box then converts the input into a double, then sets the double equal to the variable dbl1
        dbl2 = Convert.ToDouble(InputBox("Please Enter Another Number", "Second Number Value")) 'This gets input from the user through an input box then converts the input into a double, then set the double equal to the variable dbl2
        Call sortNum(dbl1, dbl2)
    End Sub

    Private Sub sortNum(ByRef dbl1 As Double, ByRef dbl2 As Double)
        If dbl1 > dbl2 Then
            lblDisplay.Text = "The low number is " & dbl2 & " and the high number is " & dbl1 'This makes it so it displays this message in the label if dbl1 is greater than dbl2
        ElseIf dbl2 > dbl1 Then
            lblDisplay.Text = "The low number is " & dbl1 & " and the high number is " & dbl2 'This makes it so it displays this message in the label if dbl2 is greater than dbl2
        ElseIf dbl1 = dbl2 Then
            lblDisplay.Text = "Your numbers are equal." 'This makes it so it displays this message in the label if the numbers are equal
        End If
    End Sub

End Class
