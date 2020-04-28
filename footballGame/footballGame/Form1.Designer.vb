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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalPoints = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtQ1 = New System.Windows.Forms.TextBox()
        Me.txtQ2 = New System.Windows.Forms.TextBox()
        Me.txtQ3 = New System.Windows.Forms.TextBox()
        Me.txtQ4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(222, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the first quarter points:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(199, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter the second quarter points:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(217, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter the third quarter points:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(208, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Enter the fourth quarter points:"
        '
        'lblTotalPoints
        '
        Me.lblTotalPoints.Location = New System.Drawing.Point(202, 295)
        Me.lblTotalPoints.Name = "lblTotalPoints"
        Me.lblTotalPoints.Size = New System.Drawing.Size(315, 68)
        Me.lblTotalPoints.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(202, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(315, 51)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Compute the total number of points"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtQ1
        '
        Me.txtQ1.Location = New System.Drawing.Point(417, 119)
        Me.txtQ1.Name = "txtQ1"
        Me.txtQ1.Size = New System.Drawing.Size(100, 22)
        Me.txtQ1.TabIndex = 6
        '
        'txtQ2
        '
        Me.txtQ2.Location = New System.Drawing.Point(417, 147)
        Me.txtQ2.Name = "txtQ2"
        Me.txtQ2.Size = New System.Drawing.Size(100, 22)
        Me.txtQ2.TabIndex = 7
        '
        'txtQ3
        '
        Me.txtQ3.Location = New System.Drawing.Point(417, 175)
        Me.txtQ3.Name = "txtQ3"
        Me.txtQ3.Size = New System.Drawing.Size(100, 22)
        Me.txtQ3.TabIndex = 8
        '
        'txtQ4
        '
        Me.txtQ4.Location = New System.Drawing.Point(417, 203)
        Me.txtQ4.Name = "txtQ4"
        Me.txtQ4.Size = New System.Drawing.Size(100, 22)
        Me.txtQ4.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtQ4)
        Me.Controls.Add(Me.txtQ3)
        Me.Controls.Add(Me.txtQ2)
        Me.Controls.Add(Me.txtQ1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTotalPoints)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalPoints As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtQ1 As TextBox
    Friend WithEvents txtQ2 As TextBox
    Friend WithEvents txtQ3 As TextBox
    Friend WithEvents txtQ4 As TextBox
End Class
