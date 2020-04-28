'Ali Ahmad
'CP Period 3
'4/17/2019

Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim dblArray(4) As Double 'This creates the array with 5 values
        dblArray(0) = 2.3
        dblArray(1) = 2.2
        dblArray(2) = 2.0
        dblArray(3) = 2.1
        dblArray(4) = 2.4 'These give the elements their values

        lblLow.Text = "The lowest rate is : " & dblArray(2).ToString("#.00") & "%" 'This displays the text and the lowest value in the label
    End Sub
End Class
