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
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.txtLetterReplacement = New System.Windows.Forms.TextBox()
        Me.lblPrompt3 = New System.Windows.Forms.Label()
        Me.txtLetterReplace = New System.Windows.Forms.TextBox()
        Me.lblPrompt2 = New System.Windows.Forms.Label()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.lblPrompt1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(203, 251)
        Me.lblDisplay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(332, 37)
        Me.lblDisplay.TabIndex = 15
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(253, 205)
        Me.btnReplace.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(228, 38)
        Me.btnReplace.TabIndex = 14
        Me.btnReplace.Text = "Replace Letter"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'txtLetterReplacement
        '
        Me.txtLetterReplacement.Location = New System.Drawing.Point(424, 164)
        Me.txtLetterReplacement.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLetterReplacement.Name = "txtLetterReplacement"
        Me.txtLetterReplacement.Size = New System.Drawing.Size(111, 22)
        Me.txtLetterReplacement.TabIndex = 13
        '
        'lblPrompt3
        '
        Me.lblPrompt3.AutoSize = True
        Me.lblPrompt3.Location = New System.Drawing.Point(199, 173)
        Me.lblPrompt3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrompt3.Name = "lblPrompt3"
        Me.lblPrompt3.Size = New System.Drawing.Size(184, 17)
        Me.lblPrompt3.TabIndex = 12
        Me.lblPrompt3.Text = "Enter the replacement letter"
        '
        'txtLetterReplace
        '
        Me.txtLetterReplace.Location = New System.Drawing.Point(424, 130)
        Me.txtLetterReplace.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLetterReplace.Name = "txtLetterReplace"
        Me.txtLetterReplace.Size = New System.Drawing.Size(111, 22)
        Me.txtLetterReplace.TabIndex = 11
        '
        'lblPrompt2
        '
        Me.lblPrompt2.AutoSize = True
        Me.lblPrompt2.Location = New System.Drawing.Point(199, 133)
        Me.lblPrompt2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrompt2.Name = "lblPrompt2"
        Me.lblPrompt2.Size = New System.Drawing.Size(169, 17)
        Me.lblPrompt2.TabIndex = 10
        Me.lblPrompt2.Text = "Enter the letter to replace"
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(311, 91)
        Me.txtWord.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(224, 22)
        Me.txtWord.TabIndex = 9
        '
        'lblPrompt1
        '
        Me.lblPrompt1.AutoSize = True
        Me.lblPrompt1.Location = New System.Drawing.Point(199, 95)
        Me.lblPrompt1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrompt1.Name = "lblPrompt1"
        Me.lblPrompt1.Size = New System.Drawing.Size(88, 17)
        Me.lblPrompt1.TabIndex = 8
        Me.lblPrompt1.Text = "Enter a word"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.txtLetterReplacement)
        Me.Controls.Add(Me.lblPrompt3)
        Me.Controls.Add(Me.txtLetterReplace)
        Me.Controls.Add(Me.lblPrompt2)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.lblPrompt1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDisplay As Label
    Friend WithEvents btnReplace As Button
    Friend WithEvents txtLetterReplacement As TextBox
    Friend WithEvents lblPrompt3 As Label
    Friend WithEvents txtLetterReplace As TextBox
    Friend WithEvents lblPrompt2 As Label
    Friend WithEvents txtWord As TextBox
    Friend WithEvents lblPrompt1 As Label
End Class
