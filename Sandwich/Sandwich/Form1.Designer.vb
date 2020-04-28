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
        Me.lblMainChoice = New System.Windows.Forms.Label()
        Me.lblChoice1 = New System.Windows.Forms.Label()
        Me.lblChoice2 = New System.Windows.Forms.Label()
        Me.lblChoice3 = New System.Windows.Forms.Label()
        Me.grpMain = New System.Windows.Forms.GroupBox()
        Me.radTurkey = New System.Windows.Forms.RadioButton()
        Me.radHam = New System.Windows.Forms.RadioButton()
        Me.grpChoices = New System.Windows.Forms.GroupBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.chkMustard = New System.Windows.Forms.CheckBox()
        Me.chkMayo = New System.Windows.Forms.CheckBox()
        Me.grpMain.SuspendLayout()
        Me.grpChoices.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMainChoice
        '
        Me.lblMainChoice.AutoSize = True
        Me.lblMainChoice.Location = New System.Drawing.Point(9, 237)
        Me.lblMainChoice.Name = "lblMainChoice"
        Me.lblMainChoice.Size = New System.Drawing.Size(0, 13)
        Me.lblMainChoice.TabIndex = 0
        '
        'lblChoice1
        '
        Me.lblChoice1.AutoSize = True
        Me.lblChoice1.Location = New System.Drawing.Point(229, 237)
        Me.lblChoice1.Name = "lblChoice1"
        Me.lblChoice1.Size = New System.Drawing.Size(0, 13)
        Me.lblChoice1.TabIndex = 1
        '
        'lblChoice2
        '
        Me.lblChoice2.AutoSize = True
        Me.lblChoice2.Location = New System.Drawing.Point(9, 277)
        Me.lblChoice2.Name = "lblChoice2"
        Me.lblChoice2.Size = New System.Drawing.Size(0, 13)
        Me.lblChoice2.TabIndex = 2
        '
        'lblChoice3
        '
        Me.lblChoice3.AutoSize = True
        Me.lblChoice3.Location = New System.Drawing.Point(229, 277)
        Me.lblChoice3.Name = "lblChoice3"
        Me.lblChoice3.Size = New System.Drawing.Size(0, 13)
        Me.lblChoice3.TabIndex = 3
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.radTurkey)
        Me.grpMain.Controls.Add(Me.radHam)
        Me.grpMain.Location = New System.Drawing.Point(112, 12)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(229, 100)
        Me.grpMain.TabIndex = 4
        Me.grpMain.TabStop = False
        Me.grpMain.Text = "Main Choice"
        '
        'radTurkey
        '
        Me.radTurkey.AutoSize = True
        Me.radTurkey.Location = New System.Drawing.Point(3, 51)
        Me.radTurkey.Name = "radTurkey"
        Me.radTurkey.Size = New System.Drawing.Size(58, 17)
        Me.radTurkey.TabIndex = 1
        Me.radTurkey.TabStop = True
        Me.radTurkey.Text = "Turkey"
        Me.radTurkey.UseVisualStyleBackColor = True
        '
        'radHam
        '
        Me.radHam.AutoSize = True
        Me.radHam.Location = New System.Drawing.Point(3, 28)
        Me.radHam.Name = "radHam"
        Me.radHam.Size = New System.Drawing.Size(47, 17)
        Me.radHam.TabIndex = 0
        Me.radHam.TabStop = True
        Me.radHam.Text = "Ham"
        Me.radHam.UseVisualStyleBackColor = True
        '
        'grpChoices
        '
        Me.grpChoices.Controls.Add(Me.chkCheese)
        Me.grpChoices.Controls.Add(Me.chkMustard)
        Me.grpChoices.Controls.Add(Me.chkMayo)
        Me.grpChoices.Location = New System.Drawing.Point(112, 118)
        Me.grpChoices.Name = "grpChoices"
        Me.grpChoices.Size = New System.Drawing.Size(226, 100)
        Me.grpChoices.TabIndex = 2
        Me.grpChoices.TabStop = False
        Me.grpChoices.Text = "Condiments"
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(0, 74)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(62, 17)
        Me.chkCheese.TabIndex = 2
        Me.chkCheese.Text = "Cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'chkMustard
        '
        Me.chkMustard.AutoSize = True
        Me.chkMustard.Location = New System.Drawing.Point(0, 51)
        Me.chkMustard.Name = "chkMustard"
        Me.chkMustard.Size = New System.Drawing.Size(64, 17)
        Me.chkMustard.TabIndex = 1
        Me.chkMustard.Text = "Mustard"
        Me.chkMustard.UseVisualStyleBackColor = True
        '
        'chkMayo
        '
        Me.chkMayo.AutoSize = True
        Me.chkMayo.Location = New System.Drawing.Point(0, 28)
        Me.chkMayo.Name = "chkMayo"
        Me.chkMayo.Size = New System.Drawing.Size(83, 17)
        Me.chkMayo.TabIndex = 0
        Me.chkMayo.Text = "Mayonnaise"
        Me.chkMayo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 324)
        Me.Controls.Add(Me.grpChoices)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.lblChoice3)
        Me.Controls.Add(Me.lblChoice2)
        Me.Controls.Add(Me.lblChoice1)
        Me.Controls.Add(Me.lblMainChoice)
        Me.Name = "Form1"
        Me.Text = "Sandwich Shop"
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.grpChoices.ResumeLayout(False)
        Me.grpChoices.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMainChoice As Label
    Friend WithEvents lblChoice1 As Label
    Friend WithEvents lblChoice2 As Label
    Friend WithEvents lblChoice3 As Label
    Friend WithEvents grpMain As GroupBox
    Friend WithEvents radTurkey As RadioButton
    Friend WithEvents radHam As RadioButton
    Friend WithEvents grpChoices As GroupBox
    Friend WithEvents chkCheese As CheckBox
    Friend WithEvents chkMustard As CheckBox
    Friend WithEvents chkMayo As CheckBox
End Class
