'Ali Ahmad
'CP Period 3
'4/8/2019

Public Class Form1
    Dim fact As String
    Private Sub AddFactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFactToolStripMenuItem.Click
        'This if statement asks for the yes or no for the messagebox
        If MessageBox.Show("Would you like to enter a fact?", "World War 2 facts", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            'For loop for the times you eneter a fax, must be 5
            For times As Integer = 0 To 5
                If (times = 5) Then
                    Exit For
                    'This makes the input box for the fact and prints in list box. 
                End If
                fact = InputBox("Enter a fact", "World War 2 facts")
                ListBox1.Items.Add(fact)
            Next
        End If
    End Sub

    Private Sub RemoveFactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveFactToolStripMenuItem.Click
        'if statement asks if you want to remove a fact
        If MessageBox.Show("Would you like to remove a fact?", "World War 2 facts", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            'make a new fact as well as remove previous fact. 
            fact = InputBox("Enter a fact", "World War 2 facts")
            ListBox1.Items.Remove(fact)
        End If
    End Sub

    Private Sub ClearListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearListToolStripMenuItem.Click
        'This acts to clear the list
        If MessageBox.Show("Would you like to clear the list?", "World War 2 facts", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            'this clears the list. 
            ListBox1.Items.Clear()
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        'closes form
        Application.Exit()
    End Sub
End Class
