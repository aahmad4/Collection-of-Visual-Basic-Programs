'Ali Ahmad
'CP Period 3
'3/29/2018

Public Class Form1
    'Declaring all variables, either as double or string depending
    Dim dblCost As Double
    'Variable
    Dim drinkcost As Double
    'Variable
    Dim tax As Double = 0.07
    'Variable
    Dim finalentree As String = ""
    'Vairble
    Dim drinkchoice As String = "Tea"
    'Variable
    Dim drinksize As String = ""
    'Variable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'This is detecting the salad selected, makes double based on that. 
        If Me.ListBox1.SelectedItem = "Chef Salad" Then
            dblCost = 3.99
            finalentree = "Chef Salad"
            'This detects if the salad was selected and then it makes the price based on that. 
        ElseIf Me.ListBox1.SelectedItem = "Garden Salad" Then
            dblCost = 2.99
            finalentree = "Garden Salad"
            'This is detecting the salad selected, makes double based on that. 
        ElseIf Me.ListBox1.SelectedItem = "Hamburger" Then
            dblCost = 2.99
            finalentree = "Hamburger"
            'This is detecting the salad selected, makes double based on that. 
        ElseIf Me.ListBox1.SelectedItem = "Cheeseburger" Then
            dblCost = 3.49
            finalentree = "Cheeseburger"
            'This is detecting the salad selected, makes double based on that. 
        ElseIf Me.ListBox1.SelectedItem = "Chicken Sandwich" Then
            dblCost = 3.99
            finalentree = "Chicken Sandwich"
            'This is detecting the salad selected, makes double based on that. 
        End If
        'This is detecting the size selected, makes double based on that. 
        If Me.ComboBox2.SelectedItem = "Small" Then
            drinkcost = 0.99
            drinksize = "Small"
            'This is detecting the size selected, makes double based on that. 
        ElseIf Me.ComboBox2.SelectedItem = "Medium" Then
            drinkcost = 1.49
            drinksize = "Medium"
            'This is detecting the size selected, makes double based on that. 
        ElseIf Me.ComboBox2.SelectedItem = "Large" Then
            drinkcost = 1.99
            drinksize = "Large"
        End If

        'Declaring the final cost based on math calculatinls
        Dim totalcost As Double = (dblCost + drinkcost) + (dblCost + drinkcost) * tax

        'Makes final label which shows all orders. 
        lblMain.Text = "You ordered: " & finalentree & vbCrLf & "Your drink is: " & drinkchoice & vbCrLf & "Drink Size: " & drinksize & vbCrLf & "Total Cost: " & totalcost.ToString("c")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'Clears label
        lblMain.Text = ""
        'If you click on a salad it shows the messageboxes. 
        If Me.ListBox1.SelectedItem = "Chef Salad" Then
            MessageBox.Show(“We only use the freshest ingredients in our salads.”)
            'This code makes it so that this salad as well as the previous salad makes the messagebox show that says you use fresh ingredients in your salad. 
        ElseIf Me.ListBox1.SelectedItem = "Garden Salad" Then
            MessageBox.Show(“We only use the freshest ingredients in our salads.”)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Clears label
        lblMain.Text = ""
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        'Clears label
        lblMain.Text = ""
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        'Closes the application if you select close menu optin.
        Application.Exit()
    End Sub
End Class
