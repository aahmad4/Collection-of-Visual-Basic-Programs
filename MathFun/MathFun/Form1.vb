'Ali Ahmad
'CP Period 3
'4/19/2019

Public Class Form1
    'This variable will be used throughout
    Dim number As Double
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        'This will close the application
        Application.Exit()
    End Sub

    Private Sub AbsoluteValueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbsoluteValueToolStripMenuItem.Click
        'Try catch only allows numerical values
        Try
            'Sets number variable = to the text box value
            number = Convert.ToDouble(TextBox1.Text)
            'Determines absolute value of the number and prints it in label
            Dim absValue As Double = Math.Abs(number)
            lblMain.Text = "The absolute value of " & number & " is " & absValue
        Catch ex As Exception
            lblMain.Text = "Please enter correct numerical values."
            MessageBox.Show("Enter Correct Numerical Values", "401 Error")
        End Try
    End Sub

    Private Sub SquareRootToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SquareRootToolStripMenuItem.Click
        'This one determines square root of the number and prints it in the label. 
        Try
            number = Convert.ToDouble(TextBox1.Text)
            Dim sqrRoot As Double = Math.Sqrt(number)
            lblMain.Text = "The square root of " & number & " is " & sqrRoot
        Catch ex As Exception
            lblMain.Text = "Please enter correct numerical values."
            MessageBox.Show("Enter Correct Numerical Values", "401 Error")
        End Try
    End Sub

    Private Sub SignToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignToolStripMenuItem.Click
        'Determines the sign value of the numbers and it's going to print that value in label. 
        Try
            number = Convert.ToDouble(TextBox1.Text)
            Dim sign As Double = Math.Sign(number)
            lblMain.Text = sign
        Catch ex As Exception
            lblMain.Text = "Please enter correct numerical values."
            MessageBox.Show("Enter Correct Numerical Values", "401 Error")
        End Try
    End Sub

    Private Sub RoundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoundToolStripMenuItem.Click
        'This one allows you to round a number by a certain number of decimal places. 
        Try
            number = Convert.ToDouble(TextBox1.Text)
            Dim inputthing As Integer
            inputthing = InputBox("Enter the number of decimal places to round by: ")
            Dim finalrounding As Double = Math.Round(number, inputthing)
            lblMain.Text = number & " rounded to " & inputthing & " decimal places is " & finalrounding
        Catch ex As Exception
            lblMain.Text = "Please enter correct numerical values. "
            MessageBox.Show("Enter Correct Numerical Values", "401 Error")
        End Try
    End Sub
End Class
