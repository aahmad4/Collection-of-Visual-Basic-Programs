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
        Me.btnGenerateNum = New System.Windows.Forms.Button()
        Me.btnShowHigh = New System.Windows.Forms.Button()
        Me.btnShowLow = New System.Windows.Forms.Button()
        Me.lstNumbers = New System.Windows.Forms.ListBox()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGenerateNum
        '
        Me.btnGenerateNum.Location = New System.Drawing.Point(190, 42)
        Me.btnGenerateNum.Name = "btnGenerateNum"
        Me.btnGenerateNum.Size = New System.Drawing.Size(363, 31)
        Me.btnGenerateNum.TabIndex = 0
        Me.btnGenerateNum.Text = "Generate Number"
        Me.btnGenerateNum.UseVisualStyleBackColor = True
        '
        'btnShowHigh
        '
        Me.btnShowHigh.Location = New System.Drawing.Point(190, 93)
        Me.btnShowHigh.Name = "btnShowHigh"
        Me.btnShowHigh.Size = New System.Drawing.Size(167, 28)
        Me.btnShowHigh.TabIndex = 1
        Me.btnShowHigh.Text = "Show High"
        Me.btnShowHigh.UseVisualStyleBackColor = True
        '
        'btnShowLow
        '
        Me.btnShowLow.Location = New System.Drawing.Point(386, 93)
        Me.btnShowLow.Name = "btnShowLow"
        Me.btnShowLow.Size = New System.Drawing.Size(167, 28)
        Me.btnShowLow.TabIndex = 2
        Me.btnShowLow.Text = "Show Low"
        Me.btnShowLow.UseVisualStyleBackColor = True
        '
        'lstNumbers
        '
        Me.lstNumbers.FormattingEnabled = True
        Me.lstNumbers.ItemHeight = 16
        Me.lstNumbers.Location = New System.Drawing.Point(190, 140)
        Me.lstNumbers.Name = "lstNumbers"
        Me.lstNumbers.Size = New System.Drawing.Size(374, 180)
        Me.lstNumbers.TabIndex = 3
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Location = New System.Drawing.Point(190, 347)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(0, 17)
        Me.lblNum.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.lstNumbers)
        Me.Controls.Add(Me.btnShowLow)
        Me.Controls.Add(Me.btnShowHigh)
        Me.Controls.Add(Me.btnGenerateNum)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerateNum As Button
    Friend WithEvents btnShowHigh As Button
    Friend WithEvents btnShowLow As Button
    Friend WithEvents lstNumbers As ListBox
    Friend WithEvents lblNum As Label
End Class
