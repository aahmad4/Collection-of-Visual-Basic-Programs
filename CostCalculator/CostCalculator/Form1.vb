'Ali Ahmad
'CP Period 3
'4/8/2019

Public Class Form1
    Dim strcost As String = ""
    Dim dblcost As Double
    Dim strnum As String = ""
    Dim dblnum As Double
    Dim total As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        strcost = txtCost.Text
        strnum = txtNumber.Text
        If Double.TryParse(strcost, dblcost) Then
            'This checks if they put in a cost for the items
            If Double.TryParse(strnum, dblnum) Then
                total = dblcost * dblnum
                'this calculates the total
                lblInfo.Text = "The total cost of your item is " & total.ToString("c")
                'this puts the total in the label
            Else
                lblInfo.Text = "Enter correct numeric values"
                'if they ddin't put in a number to the number of items this appeasr
            End If
        End If
    End Sub
End Class
