'Ali Ahmad
'CP Period 3
'4/16/19
Public Class Form1
    Dim intCardCount() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0} 'Variable for the count is created
    Public Sub drawCards(ByRef intCardCount() As Integer, ByVal intTimes As Integer)
        Dim gen As New Random 'Makes a random number generator
        Dim intCard As Integer ' Intcard is the variable for the card # amount
        For i As Integer = 0 To intTimes ' Number generator is set to intCard
            intCard = gen.Next(2, 11) 'Generates a number from 2 to 10
            Select Case intCard
                Case 2 'The computer selects which card was drawn and tallies them. 

                    intCardCount(0) += 1
                Case 3 'The computer selects which card was drawn and tallies them. 

                    intCardCount(1) += 1
                Case 4 'The computer selects which card was drawn and tallies them. 

                    intCardCount(2) += 1
                Case 5 'The computer selects which card was drawn and tallies them. 

                    intCardCount(3) += 1
                Case 6 'The computer selects which card was drawn and tallies them. 

                    intCardCount(4) += 1
                Case 7 'The computer selects which card was drawn and tallies them. 

                    intCardCount(5) += 1
                Case 8 'The computer selects which card was drawn and tallies them. 

                    intCardCount(6) += 1
                Case 9 'The computer selects which card was drawn and tallies them. 

                    intCardCount(7) += 1
                Case 10 'The computer selects which card was drawn and tallies them. 
                    intCardCount(8) += 1
            End Select
        Next i
    End Sub
    Public Sub showCards(ByVal intCardCount() As Integer)
        lblCards.Text = "Card #2 was drawn " & intCardCount(0) & " times." & vbCrLf 'The total amount of draws are displayed in a label. 
        lblCards.Text &= "Card #3 was drawn " & intCardCount(1) & " times." & vbCrLf 'The total amount of draws are displayed in a label. 
        lblCards.Text &= "Card #3 was drawn " & intCardCount(1) & " times." & vbCrLf 'The total amount of draws are displayed in a label. 
        lblCards.Text &= "Card #4 was drawn " & intCardCount(2) & " times." & vbCrLf 'The total amount of draws are displayed in a label.
        lblCards.Text &= "Card #5 was drawn " & intCardCount(3) & " times." & vbCrLf 'The total amount of draws are displayed in a label.
        lblCards.Text &= "Card #6 was drawn " & intCardCount(4) & " times." & vbCrLf 'The total amount of draws are displayed in a label.
        lblCards.Text &= "Card #7 was drawn " & intCardCount(5) & " times." & vbCrLf 'The total amount of draws are displayed in a label.
        lblCards.Text &= "Card #8 was drawn " & intCardCount(6) & " times." & vbCrLf 'The total amount of draws are displayed in a label.
        lblCards.Text &= "Card #9 was drawn " & intCardCount(7) & " times." & vbCrLf 'The total amount of draws are displayed in a label.
        lblCards.Text &= "Card #10 was drawn " & intCardCount(8) & " times." & vbCrLf 'The total amount of draws are displayed in a label.
    End Sub
    Private Sub btnDraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDraw.Click
        'When the user clicks the button, the computer draws the cards and tallies them up in a label. 
        Dim intTimes As Integer = txtDraws.Text
        drawCards(intCardCount, intTimes)
        showCards(intCardCount)
    End Sub
End Class