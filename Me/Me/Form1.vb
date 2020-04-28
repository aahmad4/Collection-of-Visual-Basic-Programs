'Ali Ahmad
'CP Period 3
'4/26/2019

Public Class Form1
    'Creates the graphics for the face. 
    Dim Face As Graphics = Me.CreateGraphics
    Dim FacePoints() As Point = {New Point(40, 114), New Point(80, 114), New Point(50, 134), New Point(70, 134)}
    Dim sbrownPen As New SolidBrush(Color.SaddleBrown)
    Dim goldPen As New SolidBrush(Color.Gold)
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        'Closes the applicatoin. 
        Application.Exit()
    End Sub

    Private Sub ShowMeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowMeToolStripMenuItem.Click
        'Makes the self portrait show. 
        PictureBox1.Show()
        PictureBox1.Image = My.Resources.Resource1.Face1Open
    End Sub

    Private Sub HideMeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideMeToolStripMenuItem.Click
        'Clears the self portrait. 
        PictureBox1.Hide()
    End Sub
End Class
