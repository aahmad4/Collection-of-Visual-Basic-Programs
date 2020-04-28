'Ali Ahmad
'CP Period 3
'4/17/2019


Public Class Form1
    Private Sub addGPA(ByRef dblGpaArray() As Double)
        dblGpaArray(0) = Convert.ToDouble(InputBox("Please enter the first GPA.", "GPAs"))
        dblGpaArray(1) = Convert.ToDouble(InputBox("Please enter the second GPA.", "GPAs"))
        dblGpaArray(2) = Convert.ToDouble(InputBox("Please enter the third GPA", "GPAs"))
        dblGpaArray(3) = Convert.ToDouble(InputBox("Please enter the fourth GPA", "GPAs"))
        dblGpaArray(4) = Convert.ToDouble(InputBox("Please enter the fifth GPA", "GPAs"))

    End Sub

    Private Sub displayGpa(ByVal dblGpaArray() As Double)
        Array.Sort(dblGpaArray)
        For Each i In dblGpaArray
            lstDisplay.Items.Add("GPA #" & " is " & i)
        Next i
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim dblGpaArray(4) As Double
        Call addGPA(dblGpaArray)
        Call displayGpa(dblGpaArray)
    End Sub

End Class
