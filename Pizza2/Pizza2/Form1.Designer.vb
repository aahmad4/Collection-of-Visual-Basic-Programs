<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTopping1Prompt = New System.Windows.Forms.Label()
        Me.lblCrustPrompt = New System.Windows.Forms.Label()
        Me.lblTopping2Prompt = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtTopping2 = New System.Windows.Forms.TextBox()
        Me.txtCrust = New System.Windows.Forms.TextBox()
        Me.txtTopping3 = New System.Windows.Forms.TextBox()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.btnYourOrder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTopping1Prompt
        '
        Me.lblTopping1Prompt.AutoSize = True
        Me.lblTopping1Prompt.Location = New System.Drawing.Point(12, 46)
        Me.lblTopping1Prompt.Name = "lblTopping1Prompt"
        Me.lblTopping1Prompt.Size = New System.Drawing.Size(147, 13)
        Me.lblTopping1Prompt.TabIndex = 0
        Me.lblTopping1Prompt.Text = "Enter your first topping choice"
        '
        'lblCrustPrompt
        '
        Me.lblCrustPrompt.AutoSize = True
        Me.lblCrustPrompt.Location = New System.Drawing.Point(12, 19)
        Me.lblCrustPrompt.Name = "lblCrustPrompt"
        Me.lblCrustPrompt.Size = New System.Drawing.Size(128, 13)
        Me.lblCrustPrompt.TabIndex = 1
        Me.lblCrustPrompt.Text = "Enter your choice of crust"
        '
        'lblTopping2Prompt
        '
        Me.lblTopping2Prompt.AutoSize = True
        Me.lblTopping2Prompt.Location = New System.Drawing.Point(12, 72)
        Me.lblTopping2Prompt.Name = "lblTopping2Prompt"
        Me.lblTopping2Prompt.Size = New System.Drawing.Size(166, 13)
        Me.lblTopping2Prompt.TabIndex = 2
        Me.lblTopping2Prompt.Text = "Enter your second topping choice"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(184, 69)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'txtTopping2
        '
        Me.txtTopping2.Location = New System.Drawing.Point(184, 42)
        Me.txtTopping2.Name = "txtTopping2"
        Me.txtTopping2.Size = New System.Drawing.Size(100, 20)
        Me.txtTopping2.TabIndex = 3
        '
        'txtCrust
        '
        Me.txtCrust.Location = New System.Drawing.Point(184, 16)
        Me.txtCrust.Name = "txtCrust"
        Me.txtCrust.Size = New System.Drawing.Size(100, 20)
        Me.txtCrust.TabIndex = 3
        '
        'txtTopping3
        '
        Me.txtTopping3.Location = New System.Drawing.Point(184, 69)
        Me.txtTopping3.Name = "txtTopping3"
        Me.txtTopping3.Size = New System.Drawing.Size(100, 20)
        Me.txtTopping3.TabIndex = 3
        '
        'lblOrder
        '
        Me.lblOrder.Location = New System.Drawing.Point(12, 101)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(272, 51)
        Me.lblOrder.TabIndex = 4
        '
        'btnYourOrder
        '
        Me.btnYourOrder.Location = New System.Drawing.Point(113, 155)
        Me.btnYourOrder.Name = "btnYourOrder"
        Me.btnYourOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnYourOrder.TabIndex = 5
        Me.btnYourOrder.Text = "Your Order"
        Me.btnYourOrder.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 197)
        Me.Controls.Add(Me.btnYourOrder)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.txtCrust)
        Me.Controls.Add(Me.txtTopping2)
        Me.Controls.Add(Me.txtTopping3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblTopping2Prompt)
        Me.Controls.Add(Me.lblCrustPrompt)
        Me.Controls.Add(Me.lblTopping1Prompt)
        Me.Name = "Form1"
        Me.Text = "Pizza2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTopping1Prompt As Label
    Friend WithEvents lblCrustPrompt As Label
    Friend WithEvents lblTopping2Prompt As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtTopping2 As TextBox
    Friend WithEvents txtCrust As TextBox
    Friend WithEvents lblOrder As Label
    Friend WithEvents btnYourOrder As Button
    Friend WithEvents txtTopping3 As TextBox
End Class
