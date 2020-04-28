'Ali Ahmad
'CP Period 3
'4/20/2019

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'first word is first textbox
        Dim word1 As String = TextBox1.Text
        'second word is second textbox
        Dim word2 As String = TextBox2.Text
        'If the subtraction is 0 then they're equal
        If String.Compare(word1, word2) = 0 Then
            lblMain.Text = word1 & " is equal to " & word2
            'If it's less than 0 then the first word is before the second word
        ElseIf String.Compare(word1, word2) < 0 Then
            lblMain.Text = word1 & " comes before " & word2
            'If it's greater than 0 then the first word is after the second word
        ElseIf String.Compare(word1, word2) > 0 Then
            lblMain.Text = word1 & " comes after " & word2
        End If
    End Sub
End Class
