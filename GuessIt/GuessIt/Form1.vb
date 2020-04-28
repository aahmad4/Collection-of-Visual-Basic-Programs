'Ali Ahmad
'3/25/2019
'CP Period 3 Lockamy
Public Class Form1
    'Must declare as global so it can be used in the private sub before the actual button gets clicked. 
    Dim intTries As Integer = 0
    'this generates a random number between 1 and 100
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'makes the tries go up by 1 every time you click on the button. 
        intTries += 1
        Dim guess As Integer = TextBox1.Text

        'This variable is for the end users input
        Dim gen As New System.Random()

        Static randomnumber As Integer = gen.Next(100)

        'this is a set of conditionals that determines the difference between the users guess and the real number. 
        If guess > randomnumber Then
            lblMain.Text = "Too High"
        ElseIf guess < randomnumber Then
            lblMain.Text = "Too Low"
        Else
            'If the number isn't less than or greater than the previous one, it shows the messagebox
            MessageBox.Show("Great Job! You Guessed it.")
            'Using the variable intTries, it can detect how many tries it took u and it prints it inside this label. 
            lblMain.Text = "You took" & intTries & " tries."
        End If
    End Sub
    Private Sub showHint()
        Dim gen As New System.Random()
        Dim guess As Integer = TextBox1.Text
        Static randomnumber As Integer = gen.Next(100)
        If guess > randomnumber Then
            lblMain.Text = "Too High"
        ElseIf guess < randomnumber Then
            lblMain.Text = "Too Low"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        showHint()
    End Sub
End Class
