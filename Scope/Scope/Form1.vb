Public Class Form1
    Dim x As Integer = 10
    Private Sub btnLocal_Click(sender As Object, e As EventArgs) Handles btnLocal.Click
        Dim x As Integer = 5
        lblScopeAnswer.Text = x
    End Sub

    Private Sub btnGlobal_Click(sender As Object, e As EventArgs) Handles btnGlobal.Click
        lblScopeAnswer.Text = x
    End Sub
End Class
