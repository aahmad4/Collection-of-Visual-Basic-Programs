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
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.lblChoice = New System.Windows.Forms.Label()
        Me.grpChoices = New System.Windows.Forms.GroupBox()
        Me.radChocChip = New System.Windows.Forms.RadioButton()
        Me.radOatmeal = New System.Windows.Forms.RadioButton()
        Me.radPeanutButter = New System.Windows.Forms.RadioButton()
        Me.grpChoices.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(113, 118)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnOrder.TabIndex = 0
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'lblChoice
        '
        Me.lblChoice.AutoSize = True
        Me.lblChoice.Location = New System.Drawing.Point(12, 158)
        Me.lblChoice.Name = "lblChoice"
        Me.lblChoice.Size = New System.Drawing.Size(0, 13)
        Me.lblChoice.TabIndex = 1
        '
        'grpChoices
        '
        Me.grpChoices.Controls.Add(Me.radPeanutButter)
        Me.grpChoices.Controls.Add(Me.radOatmeal)
        Me.grpChoices.Controls.Add(Me.radChocChip)
        Me.grpChoices.Location = New System.Drawing.Point(59, 12)
        Me.grpChoices.Name = "grpChoices"
        Me.grpChoices.Size = New System.Drawing.Size(200, 100)
        Me.grpChoices.TabIndex = 2
        Me.grpChoices.TabStop = False
        Me.grpChoices.Text = "Your Choices"
        '
        'radChocChip
        '
        Me.radChocChip.AutoSize = True
        Me.radChocChip.Location = New System.Drawing.Point(3, 16)
        Me.radChocChip.Name = "radChocChip"
        Me.radChocChip.Size = New System.Drawing.Size(97, 17)
        Me.radChocChip.TabIndex = 0
        Me.radChocChip.TabStop = True
        Me.radChocChip.Text = "Chocolate Chip"
        Me.radChocChip.UseVisualStyleBackColor = True
        '
        'radOatmeal
        '
        Me.radOatmeal.AutoSize = True
        Me.radOatmeal.Location = New System.Drawing.Point(54, 39)
        Me.radOatmeal.Name = "radOatmeal"
        Me.radOatmeal.Size = New System.Drawing.Size(100, 17)
        Me.radOatmeal.TabIndex = 1
        Me.radOatmeal.TabStop = True
        Me.radOatmeal.Text = "Oatmeal Raison"
        Me.radOatmeal.UseVisualStyleBackColor = True
        '
        'radPeanutButter
        '
        Me.radPeanutButter.AutoSize = True
        Me.radPeanutButter.Location = New System.Drawing.Point(104, 62)
        Me.radPeanutButter.Name = "radPeanutButter"
        Me.radPeanutButter.Size = New System.Drawing.Size(90, 17)
        Me.radPeanutButter.TabIndex = 2
        Me.radPeanutButter.TabStop = True
        Me.radPeanutButter.Text = "Peanut Butter"
        Me.radPeanutButter.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 242)
        Me.Controls.Add(Me.grpChoices)
        Me.Controls.Add(Me.lblChoice)
        Me.Controls.Add(Me.btnOrder)
        Me.Name = "Form1"
        Me.Text = "Cookie Shop"
        Me.grpChoices.ResumeLayout(False)
        Me.grpChoices.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOrder As Button
    Friend WithEvents lblChoice As Label
    Friend WithEvents grpChoices As GroupBox
    Friend WithEvents radPeanutButter As RadioButton
    Friend WithEvents radOatmeal As RadioButton
    Friend WithEvents radChocChip As RadioButton
End Class
