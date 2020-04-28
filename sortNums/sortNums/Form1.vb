Public Class Form1
    Dim input1 As Integer
    Dim input2 As Integer
    Dim intbigger As Integer
    Private Sub sortNum()
        input1 = InputBox("Enter a number")
        input2 = InputBox("Enter another number")
        If input1 > input2 Then
            intbigger = input1
        ElseIf input2 > input1 Then

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub
End Class
