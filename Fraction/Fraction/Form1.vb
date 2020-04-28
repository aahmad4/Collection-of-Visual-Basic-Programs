Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Numerator As Integer
        Dim Denominator As Integer

        Try
            Numerator = Convert.ToInt32(TextBox2.Text)
            Denominator = Convert.ToInt32(TextBox1.Text)

        Catch ex As Exception
            MessageBox.Show("Enter correct numerical values", "Error")
        End Try

        Dim Answer As Double = (Numerator / Denominator)

        lblAnswer.Text = Answer.ToString

    End Sub
End Class
