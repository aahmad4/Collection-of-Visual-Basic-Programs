'Ali Ahmad
'3/30/2019
'CP Period 3

Public Class Form1
    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        'This code makes the background color red when you select the red option
        BackColor = Color.Red()
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        'This code makes the background color blue when you select blue option
        BackColor = Color.Blue()
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        'This code makes the background color green when you select that option
        BackColor = Color.Green()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        'This code closes the application when you select the close option.
        Me.Close()
    End Sub
End Class
