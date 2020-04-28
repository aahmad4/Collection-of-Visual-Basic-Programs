'Ali Ahmad
'CP Period 3
'1/27/2019

Public Class Form1
    Private Sub chkHWDone_CheckedChanged(sender As Object, e As EventArgs) Handles chkHWDone.CheckedChanged
        'Shows messagebox good job if you check the homework done checkbox
        MessageBox.Show("Good Job!")
        'The main label changes to homework is completed. 
        lblMain.Text &= “Homework is completed. ” & vbCrLf
        'This if statement or conditional assures that it's checked and then it shows great job in the message box. 
        If Me.chkHWDone.Checked Then
            MessageBox.Show("Great Job")
        End If
    End Sub

    Private Sub chkEatBreakfast_CheckedChanged(sender As Object, e As EventArgs) Handles chkEatBreakfast.CheckedChanged
        'Changes main label to you have eaten your breakfast since you checked that checkbox. 
        lblMain.Text &= “You have eaten your breakfast.  ” & vbCrLf
    End Sub

    Private Sub chkBrushTeeth_CheckedChanged(sender As Object, e As EventArgs) Handles chkBrushTeeth.CheckedChanged
        'Changes main label to you have brushed your teeth. 
        lblMain.Text &= “You have brushed your teeth. ” & vbCrLf
    End Sub

    Private Sub btnReady_Click(sender As Object, e As EventArgs) Handles btnReady.Click
        'If you click the ready button it shows ready for school in the label. 
        lblMain.Text = "Ready for School."
        'This if statement checks if the check boxes are checked or not, if they're not then it prints are you sure in a messagebox but if it is then it exits the application. 
        If Not (Me.chkHWDone.Checked And Me.chkEatBreakfast.Checked And Me.chkBrushTeeth.Checked) Then
            MessageBox.Show("Are you sure you are ready for school")
            lblMain.Text = ""
        Else
            Application.Exit()
        End If
    End Sub
End Class




