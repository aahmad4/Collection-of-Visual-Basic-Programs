Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Shows picture
        PictureBox1.Image = My.Resources.Resource1.Binary2Decimal
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Changes picture
        PictureBox1.Image = My.Resources.Resource1.Binary2Hexa
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Changes picture
        PictureBox1.Image = My.Resources.Resource1.hexacheeseidk

    End Sub
End Class

