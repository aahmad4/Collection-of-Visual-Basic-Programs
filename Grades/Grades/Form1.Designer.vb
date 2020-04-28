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
        Me.lblQ1Prompt = New System.Windows.Forms.Label()
        Me.lblQ2Prompt = New System.Windows.Forms.Label()
        Me.lblFEPrompt = New System.Windows.Forms.Label()
        Me.txtQ1Grade = New System.Windows.Forms.TextBox()
        Me.txtQ2Grade = New System.Windows.Forms.TextBox()
        Me.txtFEGrade = New System.Windows.Forms.TextBox()
        Me.lblGrades = New System.Windows.Forms.Label()
        Me.btnShowGrade = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblQ1Prompt
        '
        Me.lblQ1Prompt.AutoSize = True
        Me.lblQ1Prompt.Location = New System.Drawing.Point(12, 18)
        Me.lblQ1Prompt.Name = "lblQ1Prompt"
        Me.lblQ1Prompt.Size = New System.Drawing.Size(145, 13)
        Me.lblQ1Prompt.TabIndex = 0
        Me.lblQ1Prompt.Text = "Enter your Quarter 1 Average"
        '
        'lblQ2Prompt
        '
        Me.lblQ2Prompt.AutoSize = True
        Me.lblQ2Prompt.Location = New System.Drawing.Point(12, 49)
        Me.lblQ2Prompt.Name = "lblQ2Prompt"
        Me.lblQ2Prompt.Size = New System.Drawing.Size(145, 13)
        Me.lblQ2Prompt.TabIndex = 1
        Me.lblQ2Prompt.Text = "Enter your Quarter 2 Average"
        '
        'lblFEPrompt
        '
        Me.lblFEPrompt.AutoSize = True
        Me.lblFEPrompt.Location = New System.Drawing.Point(12, 79)
        Me.lblFEPrompt.Name = "lblFEPrompt"
        Me.lblFEPrompt.Size = New System.Drawing.Size(135, 13)
        Me.lblFEPrompt.TabIndex = 2
        Me.lblFEPrompt.Text = "Enter your final exam grade"
        '
        'txtQ1Grade
        '
        Me.txtQ1Grade.Location = New System.Drawing.Point(176, 15)
        Me.txtQ1Grade.Name = "txtQ1Grade"
        Me.txtQ1Grade.Size = New System.Drawing.Size(68, 20)
        Me.txtQ1Grade.TabIndex = 3
        '
        'txtQ2Grade
        '
        Me.txtQ2Grade.Location = New System.Drawing.Point(176, 46)
        Me.txtQ2Grade.Name = "txtQ2Grade"
        Me.txtQ2Grade.Size = New System.Drawing.Size(68, 20)
        Me.txtQ2Grade.TabIndex = 3
        '
        'txtFEGrade
        '
        Me.txtFEGrade.Location = New System.Drawing.Point(176, 76)
        Me.txtFEGrade.Name = "txtFEGrade"
        Me.txtFEGrade.Size = New System.Drawing.Size(68, 20)
        Me.txtFEGrade.TabIndex = 3
        '
        'lblGrades
        '
        Me.lblGrades.Location = New System.Drawing.Point(12, 116)
        Me.lblGrades.Name = "lblGrades"
        Me.lblGrades.Size = New System.Drawing.Size(232, 56)
        Me.lblGrades.TabIndex = 4
        '
        'btnShowGrade
        '
        Me.btnShowGrade.Location = New System.Drawing.Point(96, 179)
        Me.btnShowGrade.Name = "btnShowGrade"
        Me.btnShowGrade.Size = New System.Drawing.Size(75, 23)
        Me.btnShowGrade.TabIndex = 5
        Me.btnShowGrade.Text = "Your Grade"
        Me.btnShowGrade.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 216)
        Me.Controls.Add(Me.btnShowGrade)
        Me.Controls.Add(Me.lblGrades)
        Me.Controls.Add(Me.txtFEGrade)
        Me.Controls.Add(Me.txtQ2Grade)
        Me.Controls.Add(Me.txtQ1Grade)
        Me.Controls.Add(Me.lblFEPrompt)
        Me.Controls.Add(Me.lblQ2Prompt)
        Me.Controls.Add(Me.lblQ1Prompt)
        Me.Name = "Form1"
        Me.Text = "Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQ1Prompt As Label
    Friend WithEvents lblQ2Prompt As Label
    Friend WithEvents lblFEPrompt As Label
    Friend WithEvents txtQ1Grade As TextBox
    Friend WithEvents txtQ2Grade As TextBox
    Friend WithEvents txtFEGrade As TextBox
    Friend WithEvents lblGrades As Label
    Friend WithEvents btnShowGrade As Button
End Class
