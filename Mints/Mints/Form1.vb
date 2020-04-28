Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numberofmints As UInteger

        Try
            numberofmints = Convert.ToUInt32(TextBox1.Text)
        Catch ex As Exception
            MessageBox.Show("Invalid input", "Error")
        End Try

        lblLOL.Text = numberofmints \ 3

        labelIDK.Text = numberofmints Mod 3


    End Sub
End Class
