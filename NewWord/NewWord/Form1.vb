'Ali Ahmad
'CP Period 3
'4/17/19
Public Class Form1
    Dim strA As String
    Dim strB As String
    Dim strNew As String
    Dim strWord As String
    Private Sub btnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplace.Click
        'The user types the word and the letters they want to replace. 
        'The new word is displayed in the label. 
        strWord = txtWord.Text
        strA = txtLetterReplace.Text
        strB = txtLetterReplacement.Text
        strNew = strWord.Replace(strA, strB)
        lblDisplay.Text = "The new word is " & strNew
    End Sub
End Class
