'Ali Ahmad
'CP Period 3
'4/16/19
Public Class Form1
    Dim randomNUM As Random = New Random() ' Random Number generator variable is created
    Dim intNumArray(9) As Integer ' The array is created
    Private Sub btnGenerateNum_Click(sender As Object, e As EventArgs) Handles btnGenerateNum.Click 'when the button is clecked the Generate sub is performed
        Generate()
        Display()
    End Sub
    Private Sub btnShowHigh_Click(sender As Object, e As EventArgs) Handles btnShowHigh.Click 'when the button is clecked the FindHigh sub is performed
        FindHigh()
    End Sub
    Private Sub btnShowLow_Click(sender As Object, e As EventArgs) Handles btnShowLow.Click 'when the button is clecked the FindLow sub is performed
        FindLow()
    End Sub
    Public Sub Generate()
        For i = 0 To 9
            intNumArray(i) = randomNUM.Next(1, 101) 'generates a number from 0-9
        Next
    End Sub
    Public Sub Display()
        lstNumbers.Items.Clear() 'The listbox values are cleared
        lblNum.Text = "" 'Label value is cleared
        For i = 0 To 9
            lstNumbers.Items.Add(intNumArray(i)) 'adds the numbers to the listbox
        Next
    End Sub
    Public Sub FindLow()
        lblNum.Text = "The Low Number is " & intNumArray.Min ' The min number is displayed in a label   
    End Sub
    Public Sub FindHigh()
        lblNum.Text = "The High Number is " & intNumArray.Max ' The max number is displayed in a label
    End Sub
End Class