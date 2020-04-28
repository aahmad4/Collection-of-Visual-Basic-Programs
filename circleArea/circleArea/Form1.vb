'Ali Ahmad
'CP Period 3
'1/26/2019

Public Class Form1
    Private Sub btnArea_Click(sender As Object, e As EventArgs) Handles btnArea.Click
        Dim radius As Double


        Const dblPI As Double = 3.1457

        Dim area As Double
        Try
            radius = Convert.ToDouble(txtRadius.Text)
            area = dblPI * radius ^ 2
            lblRadius.Text = area
        Catch ex As Exception
            MessageBox.Show(“Enter a radius that is numeric”)
        End Try


    End Sub

    Private Sub txtRadius_TextChanged(sender As Object, e As EventArgs) Handles txtRadius.TextChanged
        lblRadius.Text = ""
    End Sub
End Class

