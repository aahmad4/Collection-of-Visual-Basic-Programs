'Ali Ahmad
'CP Period 3
'3/29/2019

Public Class Form1
    'Declaring the amount of turns as 0 when the program just starts. 
    Dim turns As Integer = 0
    Dim resteraunt As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'asks if you have a favorite resteraunt. 
        If MessageBox.Show("Do you have a favorite restaurant you like to go to on your birthday?", "Resteraunt Survey", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            resteraunt = InputBox("Enter the name of the resteraunt")
            'prints messagebox based on resteraunt. 
            MessageBox.Show("You will go to " & resteraunt)
        End If
        'Makes turns go up by 1 everytime you click
        turns += 1
        'Declaring all present variables
        Dim present As String
        Dim present2 As String
        Dim present3 As String
        Dim present4 As String
        Dim present5 As String
        'If you aren't out of turns then it keeps asking for presents. 
        If turns < 6 Then
            present = InputBox("Enter a present")
            Label1.Text = present
            present2 = InputBox("Enter a present")
            Label1.Text = present & vbCrLf & present2
            present3 = InputBox("Enter a present")
            Label1.Text = present & vbCrLf & present2 & vbCrLf & present3
            present4 = InputBox("Enter a present")
            Label1.Text = present & vbCrLf & present2 & vbCrLf & present3 & vbCrLf & present4
            present5 = InputBox("Enter a present")
            Label1.Text = present & vbCrLf & present2 & vbCrLf & present3 & vbCrLf & present4 & vbCrLf & present5
            'If you go past the limit messagebox shows and it closes the application. 
        ElseIf turns > 6 Then
            MessageBox.Show("You can only ask for 5 things.")
            Application.Exit()
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        'This closes the application if you hit the close menu.
        Application.Exit()
    End Sub
End Class
