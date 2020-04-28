'Ali Ahmad
'CP Period 3
'1/24/2019

Public Class grpChoices2
    Private Sub lblMessage_Click(sender As Object, e As EventArgs) Handles lblMessage.Click

    End Sub

    Private Sub btnHello_Click(sender As Object, e As EventArgs) Handles btnHello.Click
        lblMessage.Text = “Hello”
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub grpChoices_Enter(sender As Object, e As EventArgs) Handles grpChoices.Enter

    End Sub

    Private Sub radEnglish_CheckedChanged(sender As Object, e As EventArgs) Handles radEnglish.CheckedChanged
        lblMessage.Text = "Hello"
    End Sub

    Private Sub radFrench_CheckedChanged(sender As Object, e As EventArgs) Handles radFrench.CheckedChanged
        lblMessage.Text = "Bonjour"
    End Sub

    Private Sub radGerman_CheckedChanged(sender As Object, e As EventArgs) Handles radGerman.CheckedChanged
        lblMessage.Text = "Guten Tag"
    End Sub

    Private Sub chkEnglish_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnglish.CheckedChanged
        lblMessage.Text &= " Goodbye"
    End Sub

    Private Sub chkFrench_CheckedChanged(sender As Object, e As EventArgs) Handles chkFrench.CheckedChanged
        lblMessage.Text &= " Au Revoir"
    End Sub

    Private Sub chkGerman_CheckedChanged(sender As Object, e As EventArgs) Handles chkGerman.CheckedChanged
        lblMessage.Text &= " Auf wiedersehen"
    End Sub
End Class
