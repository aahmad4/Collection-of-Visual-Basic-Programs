Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim runnerOne As Double = 0
        Dim runnerTwo As Double = 0
        Dim runnerThree As Double = 0
        Dim runnerFour As Double = 0

        Try
            runnerOne = Convert.ToDouble(TextBox1.Text)
            runnerTwo = Convert.ToDouble(TextBox4.Text)
            runnerThree = Convert.ToDouble(TextBox3.Text)
            runnerFour = Convert.ToDouble(TextBox2.Text)
            If (runnerOne < 0 Or runnerTwo < 0 Or runnerThree < 0 Or runnerFour < 0) Then
                Throw New Exception
            End If
            Dim totalTime As Double = runnerOne + runnerTwo + runnerThree + runnerFour
            lblMain.Text = totalTime.ToString("n")
        Catch ex As Exception
            MessageBox.Show("Enter numeric values")
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        lblMain.Text = ""
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        lblMain.Text = ""
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        lblMain.Text = ""
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        lblMain.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub
End Class
