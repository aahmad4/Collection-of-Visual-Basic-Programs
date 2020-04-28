'Ali Ahmad
'CP Period 3

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim intSide1 As UInteger = 0
        Dim intSide2 As UInteger = 0
        Dim intSide3 As UInteger = 0
        Dim intSide4 As UInteger = 0

        Try
            intSide1 = Convert.ToUInt32(TextBox1.Text)
            intSide2 = Convert.ToUInt32(TextBox2.Text)
            intSide3 = Convert.ToUInt32(TextBox3.Text)
            intSide4 = Convert.ToUInt32(TextBox4.Text)
        Catch ex As Exception
            lblMain.Text = "Please enter correct numeric values."
            MessageBox.Show("Incorrect values", "Error")
        End Try

        Dim intPerimeter As UInteger = intSide1 + intSide2 + intSide3 + intSide4
        lblMain.Text = intPerimeter

        If intSide1 > intSide3 Then
            lblMain.Text = "Side's 1 and 3 must be equal"
            MessageBox.Show("Improper rectangle", "Error")
        ElseIf intSide2 > intSide4 Then
            lblMain.Text = "Side's 2 and 4 must be equal"
            MessageBox.Show("Improper rectangle", "Error")
        ElseIf intSide1 < intSide3 Then
            lblMain.Text = "Side's 1 and 3 must be equal"
            MessageBox.Show("Improper rectangle", "Error")
        ElseIf intSide2 < intSide4 Then
            lblMain.Text = "Side's 2 and 4 must be equal"
            MessageBox.Show("Improper rectangle", "Error")
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        lblMain.Text = ""
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        lblMain.Text = ""
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        lblMain.Text = ""
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        lblMain.Text = ""
    End Sub
End Class


