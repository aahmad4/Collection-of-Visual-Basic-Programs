'Ali Ahmad
'CP Period 3
'2/7/2019

Public Class Form1
    Private Sub btnArea_Click(sender As Object, e As EventArgs) Handles btnArea.Click
        Dim userArea As Double
        userArea = txtArea.Text

        lblArea.Text = userArea ^ 2
    End Sub
End Class


