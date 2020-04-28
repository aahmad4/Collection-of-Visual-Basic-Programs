'Ali Ahmad
'CP Period 3
'4/12/2019

Public Class Form1
    'Creating this sub makes the showinsult show random labels depending on the random number. 
    Public Sub showInsult(ByVal insult)
        If insult = 1 Then
            Label1.Text = "I think he be transformed into a beast; for I can nowhere find him like a man"
        ElseIf insult = 2 Then
            Label1.Text = "Lets meet as little as we can"
        ElseIf insult = 3 Then
            Label1.Text = "I desire that we be better strangers"
        ElseIf insult = 4 Then
            Label1.Text = "Boys, apes, braggarts, jacks, milksops!"
        ElseIf insult = 5 Then
            Label1.Text = "This is the silliest stuff that I ever heard"
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'When you click on the button it generates a random number and shows that. 
        Dim gen As New System.Random()
        Dim insult As Integer = gen.Next(1, 6)
        showInsult(insult)
    End Sub
End Class
