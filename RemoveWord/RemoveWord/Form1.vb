'Ali Ahmad
'CP Period 3
'4/17/29
Public Class Form1
    Dim strString As String
    Dim strWord As String
    Dim intIndex As Integer
    Dim strWordNew As String
    Dim strNew As String
    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        'The user types in their string and the word they want to remove. The computer determines the index position and the length of the removed word.
        'The new string is displayed in a label. 
        strString = txtString.Text
        strWord = txtWordRemove.Text
        intIndex = strString.IndexOf(strWord)
        strWordNew = strWord.Length
        strNew = strString.Remove(intIndex, strWordNew)
        lblDisplay.Text = strNew.ToString
    End Sub
End Class