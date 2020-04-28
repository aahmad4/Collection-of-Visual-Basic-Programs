'Ali Ahmad
'CP Period 3
'4/25/2019

Public Class Form1
    Private Sub SquareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SquareToolStripMenuItem.Click
        'When square is clicked then background image turns into squares
        Me.BackgroundImage = My.Resources.Resource2.redSq
    End Sub

    Private Sub CircleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CircleToolStripMenuItem.Click
        'Background image turns into circles
        Me.BackgroundImage = My.Resources.Resource1.BlueCircle
    End Sub

    Private Sub StarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StarToolStripMenuItem.Click
        'Backgroud image turns into purple stars
        Me.BackgroundImage = My.Resources.Resource2.purpleStar
    End Sub

    Private Sub TriangleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TriangleToolStripMenuItem.Click
        'Background image turns into triangles
        Me.BackgroundImage = My.Resources.Resource2.greenTriangle
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
        'Closes the application
    End Sub
End Class
