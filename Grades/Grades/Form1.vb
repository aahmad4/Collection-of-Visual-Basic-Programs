'Ali Ahmad
'CP Period 3
'1/26/2019


Public Class Form1
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtFEGrade.TextChanged
        If txtFEGrade.Text > 100 Then
            MessageBox.Show("Error, must 100 or less")
            Me.Close()
        End If

    End Sub

    Private Sub btnShowGrade_Click(sender As Object, e As EventArgs) Handles btnShowGrade.Click
        Dim intQ1 As Double
        intQ1 = txtQ1Grade.Text

        Dim intQ2 As Double
        intQ2 = txtQ2Grade.Text

        Dim intFE As Double
        intFE = txtFEGrade.Text

        Dim grade As Double
        grade = (0.4 * intQ1) + (0.4 * intQ2) + (0.2 * intFE)

        lblGrades.Text = grade
    End Sub

    Private Sub txtQ1Grade_TextChanged(sender As Object, e As EventArgs) Handles txtQ1Grade.TextChanged
        If txtQ1Grade.Text > 100 Then
            MessageBox.Show("Error, must 100 or less")
            Me.Close()
        End If
    End Sub

    Private Sub txtQ2Grade_TextChanged(sender As Object, e As EventArgs) Handles txtQ2Grade.TextChanged
        If txtQ2Grade.Text > 100 Then
            MessageBox.Show("Error, must 100 or less")
            Me.Close()
        End If
    End Sub
End Class
