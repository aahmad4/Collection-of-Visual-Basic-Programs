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
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.txtWordRemove = New System.Windows.Forms.TextBox()
        Me.lblPrompt2 = New System.Windows.Forms.Label()
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.lblPrompt1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(21, 177)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(305, 35)
        Me.btnRemove.TabIndex = 11
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(34, 82)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(268, 74)
        Me.lblDisplay.TabIndex = 10
        '
        'txtWordRemove
        '
        Me.txtWordRemove.Location = New System.Drawing.Point(132, 38)
        Me.txtWordRemove.Name = "txtWordRemove"
        Me.txtWordRemove.Size = New System.Drawing.Size(188, 20)
        Me.txtWordRemove.TabIndex = 9
        '
        'lblPrompt2
        '
        Me.lblPrompt2.AutoSize = True
        Me.lblPrompt2.Location = New System.Drawing.Point(18, 45)
        Me.lblPrompt2.Name = "lblPrompt2"
        Me.lblPrompt2.Size = New System.Drawing.Size(108, 13)
        Me.lblPrompt2.TabIndex = 8
        Me.lblPrompt2.Text = "Enter word to remove"
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(93, 12)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(228, 20)
        Me.txtString.TabIndex = 7
        '
        'lblPrompt1
        '
        Me.lblPrompt1.AutoSize = True
        Me.lblPrompt1.Location = New System.Drawing.Point(18, 15)
        Me.lblPrompt1.Name = "lblPrompt1"
        Me.lblPrompt1.Size = New System.Drawing.Size(69, 13)
        Me.lblPrompt1.TabIndex = 6
        Me.lblPrompt1.Text = "Enter a string"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 234)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.txtWordRemove)
        Me.Controls.Add(Me.lblPrompt2)
        Me.Controls.Add(Me.txtString)
        Me.Controls.Add(Me.lblPrompt1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRemove As Button
    Friend WithEvents lblDisplay As Label
    Friend WithEvents txtWordRemove As TextBox
    Friend WithEvents lblPrompt2 As Label
    Friend WithEvents txtString As TextBox
    Friend WithEvents lblPrompt1 As Label
End Class
