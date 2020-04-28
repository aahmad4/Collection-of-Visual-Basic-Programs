'Ali Ahmad
'3/25/2019
'Period 3 Locakmy
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'These bottom four lines are assigning variables. First one is double, remaining 3 are integer. 
        Dim One As Double
        Dim Two As Integer
        Dim Three As Integer
        Dim Four As Integer
        'This makes the variable One a random double between 0 and 1.0
        One = CDbl((1.0 * Rnd()) + 0)
        'This makes the variable Two a random intger between 0 and 2147483647
        Two = Int((2147483647 * Rnd()) + 0)
        'This makes the variable Three a random integer between 0 and 100
        Three = Int((100 * Rnd()) + 0)
        'This makes the variable Four a random integer between 10 and 50
        Four = Int((50 * Rnd()) + 10)
        'This prints all the four randomized numbers on seperate lines in the label. 
        Label1.Text = One & vbCrLf & Two & vbCrLf & Three & vbCrLf & Four & vbCrLf
    End Sub
End Class
