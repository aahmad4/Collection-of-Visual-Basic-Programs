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
        Me.btnGame1 = New System.Windows.Forms.Button()
        Me.btnGame2 = New System.Windows.Forms.Button()
        Me.btnGame3 = New System.Windows.Forms.Button()
        Me.btnGame4 = New System.Windows.Forms.Button()
        Me.lblGameInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGame1
        '
        Me.btnGame1.Location = New System.Drawing.Point(12, 12)
        Me.btnGame1.Name = "btnGame1"
        Me.btnGame1.Size = New System.Drawing.Size(108, 23)
        Me.btnGame1.TabIndex = 0
        Me.btnGame1.Text = "Rocket Leauge"
        Me.btnGame1.UseVisualStyleBackColor = True
        '
        'btnGame2
        '
        Me.btnGame2.Location = New System.Drawing.Point(12, 41)
        Me.btnGame2.Name = "btnGame2"
        Me.btnGame2.Size = New System.Drawing.Size(108, 23)
        Me.btnGame2.TabIndex = 1
        Me.btnGame2.Text = "NBA 2k19"
        Me.btnGame2.UseVisualStyleBackColor = True
        '
        'btnGame3
        '
        Me.btnGame3.Location = New System.Drawing.Point(139, 12)
        Me.btnGame3.Name = "btnGame3"
        Me.btnGame3.Size = New System.Drawing.Size(108, 23)
        Me.btnGame3.TabIndex = 2
        Me.btnGame3.Text = "Roblox"
        Me.btnGame3.UseVisualStyleBackColor = True
        '
        'btnGame4
        '
        Me.btnGame4.Location = New System.Drawing.Point(139, 41)
        Me.btnGame4.Name = "btnGame4"
        Me.btnGame4.Size = New System.Drawing.Size(108, 23)
        Me.btnGame4.TabIndex = 3
        Me.btnGame4.Text = "Madden NFL 19"
        Me.btnGame4.UseVisualStyleBackColor = True
        '
        'lblGameInfo
        '
        Me.lblGameInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameInfo.Location = New System.Drawing.Point(9, 84)
        Me.lblGameInfo.Name = "lblGameInfo"
        Me.lblGameInfo.Size = New System.Drawing.Size(244, 77)
        Me.lblGameInfo.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 170)
        Me.Controls.Add(Me.lblGameInfo)
        Me.Controls.Add(Me.btnGame4)
        Me.Controls.Add(Me.btnGame3)
        Me.Controls.Add(Me.btnGame2)
        Me.Controls.Add(Me.btnGame1)
        Me.Name = "Form1"
        Me.Text = "Video Games"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGame1 As Button
    Friend WithEvents btnGame2 As Button
    Friend WithEvents btnGame3 As Button
    Friend WithEvents btnGame4 As Button
    Friend WithEvents lblGameInfo As Label
End Class
