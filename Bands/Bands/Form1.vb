'Ali Ahmad
'CP Period 3
'3/29/2019

Public Class Form1
    Private Sub TheBeatlesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TheBeatlesToolStripMenuItem.Click
        'This code shows the beatles band members when you click on that
        Me.lblBandInfo.Text = "Paul McCartney - Lead Singer" & vbCrLf & "John Lennon - Rhythm Guitar" & vbCrLf & "George Harrison - Lead Guitar" & vbCrLf & "Ringo Starr - Drums"
        'This code makes a messagebox show and ask end user if they like the beatles or not, if yes it shows that
        If MessageBox.Show("Do you like the Beatles?", "Beatles Survey", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("The Beatles are awesome.")
            'If end user clicks no then it prints this messagebox. 
        Else
            MessageBox.Show("Maybe you've never heard of The Beatles?")
        End If
    End Sub

    Private Sub TheWhoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TheWhoToolStripMenuItem.Click
        'Same thing but with the who band
        Me.lblBandInfo.Text = "Roger Daltrey - Lead Singer" & vbCrLf & "Pete Townsend - Guitar" & vbCrLf & "John Entwhistle - Bass Guitar" & vbCrLf & "Keith Moon – Drums”
        If MessageBox.Show("Do you like the Who?", "Who Survey", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            'same thing here
            MessageBox.Show("The Who are awesome.")
        Else
            'same thing here
            MessageBox.Show("Maybe you've never heard of The Who?")
        End If

    End Sub

    Private Sub TheDoorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TheDoorsToolStripMenuItem.Click
        Me.lblBandInfo.Text = "Jim Morrison - Lead Singer" & vbCrLf & "Robby Kreiger - Guitar" & vbCrLf & "Ray Manzarek - Keyboard" & vbCrLf & "John Densmore - Drums"
        'same thing
        If MessageBox.Show("Do you like the Doors?", "Doors Survey", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            'same thing
            MessageBox.Show("The Doors are awesome.")
        Else
            'same thing
            MessageBox.Show("Maybe you've never heard of The Doors?")
        End If

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        'closes the program if you click on the close menu option.
        Application.Exit()
    End Sub

    Private Sub lblBandInfo_Click(sender As Object, e As EventArgs) Handles lblBandInfo.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'shows the new form. 
        About.Show()
    End Sub
End Class
