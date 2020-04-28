'Ali Ahmad
'CP Period 3
'1/30/2019  

Public Class Form1
    Private Sub btnDimVariable_Click(sender As Object, e As EventArgs) Handles btnDimVariable.Click
        Dim intCounter As Integer = 1
        intCounter = intCounter + 1
        lblCounter.Text = intCounter
    End Sub

    Private Sub btnStaticVariable_Click(sender As Object, e As EventArgs) Handles btnStaticVariable.Click
        Static intCounter As Integer = 1
        intCounter = intCounter + 1
        lblCounter.Text = intCounter
    End Sub
End Class




