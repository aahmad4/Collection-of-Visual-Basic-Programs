'Ali Ahmad
'CP Period 3
'4/23/19
Public Class Form1
    Dim Ship As Graphics = Me.CreateGraphics 'Ship graphic is created
    Dim ShipPoints() As Point = {New Point(40, 114), New Point(80, 114), New Point(50, 134), New Point(70, 134)}
    Dim sbrownPen As New SolidBrush(Color.SaddleBrown)
    Dim goldPen As New SolidBrush(Color.Gold)
    Dim river As New SolidBrush(Color.Blue)
    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        Ship.FillPie(sbrownPen, 45, 114, 200, 100, 0, 180) 'Boat
        Ship.DrawLine(Pens.Black, 143, 164, 143, 50) 'Pole
        Ship.FillPie(goldPen, 50, 0, 190, 100, 0, 90) 'Sail
        Ship.FillPie(river, 20, 20, 20, 20, 20, 20)
    End Sub
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit() 'Closes application
    End Sub
    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        Ship.Clear(Me.BackColor) 'Clears surface
    End Sub
End Class