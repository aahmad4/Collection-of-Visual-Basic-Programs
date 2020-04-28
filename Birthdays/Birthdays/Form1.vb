'Ali Ahmad
'CP Period 3
'4/15/19
Public Class Form1
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Dim strArray(3) As String
        Dim datBirthArray(3) As Date 'This line and the above line create the arrays

        For i As Integer = 0 To strArray.Length - 1
            strArray(i) = InputBox("Please enter the names of the people", "People")
        Next i
        For i As Integer = 0 To datBirthArray.Length - 1
            datBirthArray(i) = InputBox("Please enter the birthdate of the people in order of names inputted.", "Birthdates")
        Next i
        'The above loops will display input boxes to fill the arrays first with the names then the birthdates of those people

        lstDisplay.Items.Add(strArray(0) & "," & datBirthArray(0))
        lstDisplay.Items.Add(strArray(1) & "," & datBirthArray(1))
        lstDisplay.Items.Add(strArray(2) & "," & datBirthArray(2))
        lstDisplay.Items.Add(strArray(3) & "," & datBirthArray(3))
        'These will display the names and birthdates of the corresponding person into the list
    End Sub
End Class
