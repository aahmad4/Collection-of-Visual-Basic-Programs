Public Class Form1
    Dim intQ1 As Integer
    Dim intQ2 As Integer
    Dim intQ3 As Integer
    Dim intQ4 As Integer
    Dim intTotal As Integer


    Private Sub calcTotal(ByRef intTotal As Integer, ByVal intQ1 As Integer, ByVal intQ2 As Integer, ByVal intQ3 As Integer, ByVal intQ4 As Integer)
        Try
            intQ1 = Convert.ToInt32(txtQ1.Text)
            intQ2 = Convert.ToInt32(txtQ2.Text)
            intQ3 = Convert.ToInt32(txtQ3.Text)
            intQ4 = Convert.ToInt32(txtQ4.Text) 'This and the above code collects the input from the text boxes, converts them into integers, then makes them equal to the variables

        Catch ex As Exception
            MessageBox.Show("Enter valid values.")
        End Try

        intTotal = (intQ1 + intQ2 + intQ3 + intQ4)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call calcTotal(intTotal, intQ1, intQ2, intQ3, intQ4)
        lblTotalPoints.Text = "The total number of points is " & intTotal & "."
    End Sub
End Class
