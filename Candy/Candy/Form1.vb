'Ali Ahmad
'CP Period 3
'4/11/2019

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dims variables equal to the text boxes and final equation as well
        Dim favCandy As String = TextBox1.Text
        Dim numberofounces As UInteger = TextBox2.Text
        Dim price As UInteger = TextBox3.Text
        Dim finalprice As UInteger = price * numberofounces

        'This try catch also makes it so that you can't ender something random within the textboxes or else an ower wil pop up. 
        Try
            numberofounces = Convert.ToUInt32(TextBox2.Text)
            price = Convert.ToUInt32(TextBox3.Text)
        Catch ex As Exception
            MessageBox.Show("Enter correct parameters", "Error")
            lblMain.Text = "Error, read messagebox."
        End Try

        'Final labelmain.text makes the new label show all the variables in a sentence format. 

        lblMain.Text = numberofounces & " ounches of " & favCandy & " at a cost of " & price & " per oz. costs " & finalprice.ToString("c")


    End Sub
End Class
