'Ali Ahmad
'CP Period 3
'1/31/2019

Public Class Form1
    Private Sub lblHello_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnHello_Click(sender As Object, e As EventArgs) Handles btnHello.Click
        Dim name As String
        name = txtName.Text
        MessageBox.Show("Hello, " & name)
    End Sub
End Class




