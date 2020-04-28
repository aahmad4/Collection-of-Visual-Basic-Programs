'Ali Ahmad
'CP Period 3
'4/20/2019

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Full name is the variable for the textbox 
        Dim fullname As String = TextBox1.Text
        'This variable is the very first letter you input
        Dim firstInitial As String = fullname.Chars(0)
        'space is assigned an integer value based on where the space is
        Dim space As Integer = fullname.IndexOf(" ")
        'I add 1 to the value of the space to find the last initial
        Dim lastInitial As String = fullname.Chars(space + 1)
        'This makes the label show the initials and the .toupper make them both uppercased
        lblMain.Text = "Your initials are: " & firstInitial.ToUpper & "  " & lastInitial.ToUpper
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        'This closes the applicaton. 
        Application.Exit()
    End Sub
End Class
