'Ali Ahmad
'CP Period 3
'3/25/2019

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Creating the variable that keeps track of user input
        Dim grade As Integer = TextBox1.Text

        'using select case to associate integer grades to the letter
        Select Case grade
            '93-100% resolves the label to an A
            Case 93 To 100 : lblMain.Text = "You made an A."
            '85-92% resolves the label to a B
            Case 85 To 92 : lblMain.Text = "You made a B."
            '77-84% resolves the label to a C
            Case 77 To 84 : lblMain.Text = "You made a C."
            '70-76% resolves the label to a D
            Case 70 To 76 : lblMain.Text = "You made a D."
            '0-69% resolves the label to saying to study more
            Case 0 To 69 : lblMain.Text = "Study More."
        End Select
    End Sub
End Class
