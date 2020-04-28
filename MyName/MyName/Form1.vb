'Ali Ahmad
'CP Period 3
'4/20/2019

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'This variable holds value for first input box
        Dim firstName As String = InputBox("Enter your first name")
        'Second input box
        Dim lastName As String = InputBox("Enter your last name")
        'Adding a space after the first name
        firstName = firstName & " "
        'Removing any spaces from the last name. 
        Dim strNew2 As String = lastName.Trim()
        'This variable combines the frist and last name. 
        Dim strCombined As String = String.Concat(firstName, strNew2)
        'Finally this prints the full name on to the label. 
        lblMain.Text = "Hello " & strCombined
    End Sub
End Class
