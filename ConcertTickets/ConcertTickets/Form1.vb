'Ali Ahmad
'3/31/2019
'CP Period 3
Public Class Form1
    Private Sub DisplayCostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayCostToolStripMenuItem.Click
        'Declaring Variable That Holds Value Of Amt of Tickets
        Dim intNumTickets As Integer
        'Holds Value For The Selected Musical
        Dim dblEventCost As Double
        'Makes Variable Equal To ComboBox Value
        intNumTickets = Convert.ToInt16(Me.ComboBox1.Text)
        'If they select conert, price is 49.99
        If Me.ListBox1.SelectedItem = "Concert" Then
            dblEventCost = 49.99
            'If they select orchestra, price is 35.99
        ElseIf Me.ListBox1.SelectedItem = "Orchestra" Then
            dblEventCost = 35.99
            'If they select play, price is 24.99
        ElseIf Me.ListBox1.SelectedItem = "Play" Then
            dblEventCost = 24.99
            'If they select musical, then the price will be 29.99
        ElseIf Me.ListBox1.SelectedItem = "Musical" Then
            dblEventCost = 29.99
        End If
        'When you click the display cost option is shows the total cost. 
        lblMain.Text = "Your total cost of your Musical is " & (dblEventCost * intNumTickets).ToString("c")
    End Sub
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        'Closes application if you select close on the menu option. 
        Application.Exit()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'Clears label if you click on this afterwards. 
        lblMain.Text = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Clears label if you click on this afterwards. 
        lblMain.Text = ""
    End Sub
End Class
