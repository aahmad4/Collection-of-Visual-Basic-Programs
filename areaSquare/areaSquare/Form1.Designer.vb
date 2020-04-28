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
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.btnArea = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the length of the side"
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(152, 16)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(55, 20)
        Me.txtArea.TabIndex = 1
        '
        'lblArea
        '
        Me.lblArea.Location = New System.Drawing.Point(68, 60)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(100, 38)
        Me.lblArea.TabIndex = 2
        Me.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnArea
        '
        Me.btnArea.Location = New System.Drawing.Point(80, 123)
        Me.btnArea.Name = "btnArea"
        Me.btnArea.Size = New System.Drawing.Size(75, 23)
        Me.btnArea.TabIndex = 3
        Me.btnArea.Text = "Area"
        Me.btnArea.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(233, 158)
        Me.Controls.Add(Me.btnArea)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Area of a Square"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtArea As TextBox
    Friend WithEvents lblArea As Label
    Friend WithEvents btnArea As Button
End Class
