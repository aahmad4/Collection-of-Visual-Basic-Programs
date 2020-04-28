'Ali Ahmad, Naim Odi, Carl-Dwaine Bernarte, Connor Dewey
'CP Period 3
'5/6/2019
Public Class Form1
    'Public variable to be used in the button private sub
    Dim factClick As Integer = 0
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Form2.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Every time you click on this button
        factClick += 1
        'This select case is to keep track of how many times the button is clicked
        Select Case factClick
            'Case 1 adds the inventor fact when button is clicked
            Case 1
                factClick = 1
                ListBox1.Items.Add("The Inventor is Gene Amdahl & Fred Brooks")
            'Case 2 adds the date of the invention fact when button is clicked the second time
            Case 2
                factClick = 2
                ListBox1.Items.Add("The Date of the invention is  April 7, 1964")
            'Case 3 adds the cost at the time of the invention fact when the button is clicked the third time
            Case 3
                factClick = 3
                ListBox1.Items.Add("At the time, the cost of the invention was $100,000")
            'Case 4 adds the type of language used when the button is clicked on for the fourth time
            Case 4
                factClick = 4
                ListBox1.Items.Add("It uses the binary language")
            'Case 5 adds the operation procedures fact when the button is clicked a fifth time
            Case 5
                factClick = 5
                ListBox1.Items.Add("Different operators such as the various controls ")
            'Case 6 adds the components when button is clicked on six times
            Case 6
                factClick = 6
                ListBox1.Items.Add("Some componenets were visual output devices. ")
            'Case 7 adds the microprocessers when the button is clicked on seven times
            Case 7
                factClick = 7
                ListBox1.Items.Add("Microprocessors were integrated circruit and magnetic storage devices")
            'Case 8 adds the similiraties and differences fact when clicked on eight times. 
            Case 8
                factClick = 8
                ListBox1.Items.Add("Likewise other computers, the IBM System 360 was one of the first mainframes")
            'Case 9 adds the first programmer fact when clicked on for a ninth time
            Case 9
                factClick = 9
                ListBox1.Items.Add("Herman Hollerith, developed an electromechanical punch card tabulator to assist in summarizing information")
            'Case 10 checks to see if you added all the facts, it shows a message box, then hides the button for no more facts to be added
            Case 10
                factClick = 10
                MessageBox.Show("You have added all the facts already!")
                Button1.Hide()
        End Select
    End Sub

    Private Sub CloseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem1.Click
        'Closes the project
        Application.Exit()
    End Sub
End Class
