Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim gradeOne As Double = 0
        Dim gradeTwo As Double = 0
        Dim gradeThree As Double = 0
        Dim gradeFour As Double = 0

        Try
            gradeOne = Convert.ToDouble(TextBox1.Text)
            gradeTwo = Convert.ToDouble(TextBox2.Text)
            gradeThree = Convert.ToDouble(TextBox3.Text)
            gradeFour = Convert.ToDouble(TextBox4.Text)

            If (gradeOne < 0 Or gradeTwo < 0 Or gradeThree < 0 Or gradeFour < 0) Then
                Throw New Exception
            End If

            Dim average As Double = (gradeOne + gradeTwo + gradeThree + gradeFour) / 4
            lblMain.Text = "Your average test grade is " & average.ToString("n") & "%"
        Catch ex As Exception
            MessageBox.Show("Enter correct numeric values", "Error")
            lblMain.Text = ""
        End Try
    End Sub
End Class
