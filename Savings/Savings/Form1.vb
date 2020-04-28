Public Class Form1
    Dim dblSavings As Double
    Dim intMonths As Integer
    Dim dblTotal As Double

    Private Sub calcDeposit(ByRef dblTotal As Double, ByVal dblSavings As Double, ByVal intMonths As Integer)
        Try
            dblSavings = Convert.ToDouble(txtSavings.Text)
            intMonths = Convert.ToInt32(txtMonths.Text) 'This and the above texts takes the input from the text boxes, converts them into integers, and sets them equivalent to the variables
        Catch ex As Exception
            MessageBox.Show("Enter a valid value.")
        End Try
        dblTotal = (dblSavings * intMonths) 'This calculates your total savings after the saving period by multiplying the months of saving and the deposit 
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Call calcDeposit(dblTotal, dblSavings, intMonths) 'This calls the private sub calcDeposit
        lblTotal.Text = "You deposited a total of " & dblTotal.ToString("c") & "."
    End Sub
End Class
