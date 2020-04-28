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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.lblRadius = New System.Windows.Forms.Label()
        Me.btnArea = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the radius"
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(99, 17)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(100, 20)
        Me.txtRadius.TabIndex = 1
        '
        'lblRadius
        '
        Me.lblRadius.Location = New System.Drawing.Point(12, 49)
        Me.lblRadius.Name = "lblRadius"
        Me.lblRadius.Size = New System.Drawing.Size(187, 49)
        Me.lblRadius.TabIndex = 2
        '
        'btnArea
        '
        Me.btnArea.Location = New System.Drawing.Point(57, 111)
        Me.btnArea.Name = "btnArea"
        Me.btnArea.Size = New System.Drawing.Size(96, 23)
        Me.btnArea.TabIndex = 3
        Me.btnArea.Text = "Show the Area"
        Me.btnArea.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(217, 154)
        Me.Controls.Add(Me.btnArea)
        Me.Controls.Add(Me.lblRadius)
        Me.Controls.Add(Me.txtRadius)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Area of a circle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtRadius As TextBox
    Friend WithEvents lblRadius As Label
    Friend WithEvents btnArea As Button
End Class
