'Ali Ahmad
'CP Period 3
'4/27/2019
Public Class Form1
    'I have to dim this variable for making the different options change numebrs
    Dim wins As Integer = 0
    Dim losses As Integer = 0
    Dim draws As Integer = 0
    Dim userchoice As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'This makes a random number generate to be used with the variables
        Dim computerChoice As Integer = CInt(Int((3 * Rnd()) + 1))
        'If it's = 1 then I hard code the rock factor in it
        If computerChoice = 1 Then
            lblComputerChoice.Text = "The CPU Chose Rock"
        ElseIf computerChoice = 2 Then
            lblComputerChoice.Text = "The CPU Chose Paper"
        ElseIf computerChoice = 3 Then
            lblComputerChoice.Text = "The CPU Chose Scissors"
        End If
        If userchoice = 1 And computerChoice = 3 Then
            MessageBox.Show("You win!")
            wins += 1
            lblMain.Text = "Wins: " & wins & vbCrLf & "Draws: " & draws & vbCrLf & "Losses: " & losses
        ElseIf userchoice = 2 And computerChoice = 1 Then
            MessageBox.Show("You win!")
            wins += 1
            lblMain.Text = "Wins: " & wins & vbCrLf & "Draws: " & draws & vbCrLf & "Losses: " & losses
        ElseIf userchoice = 3 And computerChoice = 2 Then
            MessageBox.Show("You win!")
            wins += 1
            lblMain.Text = "Wins: " & wins & vbCrLf & "Draws: " & draws & vbCrLf & "Losses: " & losses
        ElseIf userchoice = computerChoice Then
            MessageBox.Show("It's a draw!")
            draws += 1
            lblMain.Text = "Wins: " & wins & vbCrLf & "Draws: " & draws & vbCrLf & "Losses: " & losses
        ElseIf userchoice = 3 And computerChoice = 1 Then
            MessageBox.Show("You loose!")
            losses += 1
            lblMain.Text = "Wins: " & wins & vbCrLf & "Draws: " & draws & vbCrLf & "Losses: " & losses
        ElseIf userchoice = 2 And computerChoice = 3 Then
            MessageBox.Show("You loose!")
            losses += 1
            lblMain.Text = "Wins: " & wins & vbCrLf & "Draws: " & draws & vbCrLf & "Losses: " & losses
        ElseIf userchoice = 1 And computerChoice = 2 Then
            MessageBox.Show("You loose!")
            losses += 1
            lblMain.Text = "Wins: " & wins & vbCrLf & "Draws: " & draws & vbCrLf & "Losses: " & losses
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        userchoice = 1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        userchoice = 2
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        userchoice = 3
    End Sub
End Class
