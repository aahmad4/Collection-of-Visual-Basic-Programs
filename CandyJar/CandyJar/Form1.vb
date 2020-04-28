'Ali Ahmad
'Cp Period 3
'4/8/2019

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim guess As UInteger = 0
        'this generates a random number between 1 and 100
        Dim gen As New System.Random()
        Static randomnumber As Integer = gen.Next(300)
        'this is a set of conditionals that determines the difference between the users guess and the real number. 
        Try
            'try catch
            guess = Convert.ToUInt32(TextBox1.Text)
        Catch ex As Exception
            MessageBox.Show("Enter correct numeric values", "Error")
            lblMain.Text = "Error"
            'used to make sure only numeric values are entered. 
        End Try
        If guess > randomnumber Then
            lblMain.Text = "Too High"
        ElseIf guess < randomnumber Then
            lblMain.Text = "Too Low"
        Else
            'If the number isn't less than or greater than the previous one, it shows the messagebox
            MessageBox.Show("Great Job! You Guessed it.")
            'Using the variable intTries, it can detect how many tries it took u and it prints it inside this label. 
        End If
    End Sub
End Class
