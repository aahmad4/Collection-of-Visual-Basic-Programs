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
        Me.grpChoices = New System.Windows.Forms.GroupBox()
        Me.chkBeach = New System.Windows.Forms.CheckBox()
        Me.chkMountains = New System.Windows.Forms.CheckBox()
        Me.chkNC = New System.Windows.Forms.CheckBox()
        Me.lblStuff = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblsecond = New System.Windows.Forms.Label()
        Me.grpChoices.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpChoices
        '
        Me.grpChoices.Controls.Add(Me.chkNC)
        Me.grpChoices.Controls.Add(Me.chkMountains)
        Me.grpChoices.Controls.Add(Me.chkBeach)
        Me.grpChoices.Location = New System.Drawing.Point(5, 12)
        Me.grpChoices.Name = "grpChoices"
        Me.grpChoices.Size = New System.Drawing.Size(200, 110)
        Me.grpChoices.TabIndex = 0
        Me.grpChoices.TabStop = False
        Me.grpChoices.Text = "What to do in NC?"
        '
        'chkBeach
        '
        Me.chkBeach.AutoSize = True
        Me.chkBeach.Location = New System.Drawing.Point(20, 31)
        Me.chkBeach.Name = "chkBeach"
        Me.chkBeach.Size = New System.Drawing.Size(92, 17)
        Me.chkBeach.TabIndex = 0
        Me.chkBeach.Text = "At The Beach"
        Me.chkBeach.UseVisualStyleBackColor = True
        '
        'chkMountains
        '
        Me.chkMountains.AutoSize = True
        Me.chkMountains.Location = New System.Drawing.Point(20, 54)
        Me.chkMountains.Name = "chkMountains"
        Me.chkMountains.Size = New System.Drawing.Size(109, 17)
        Me.chkMountains.TabIndex = 1
        Me.chkMountains.Text = "In The Mountains"
        Me.chkMountains.UseVisualStyleBackColor = True
        '
        'chkNC
        '
        Me.chkNC.AutoSize = True
        Me.chkNC.Location = New System.Drawing.Point(20, 77)
        Me.chkNC.Name = "chkNC"
        Me.chkNC.Size = New System.Drawing.Size(93, 17)
        Me.chkNC.TabIndex = 2
        Me.chkNC.Text = "North Carolina"
        Me.chkNC.UseVisualStyleBackColor = True
        '
        'lblStuff
        '
        Me.lblStuff.Location = New System.Drawing.Point(12, 137)
        Me.lblStuff.Name = "lblStuff"
        Me.lblStuff.Size = New System.Drawing.Size(187, 21)
        Me.lblStuff.TabIndex = 1
        Me.lblStuff.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLast
        '
        Me.lblLast.Location = New System.Drawing.Point(12, 179)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(187, 21)
        Me.lblLast.TabIndex = 2
        Me.lblLast.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblsecond
        '
        Me.lblsecond.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblsecond.Location = New System.Drawing.Point(12, 158)
        Me.lblsecond.Name = "lblsecond"
        Me.lblsecond.Size = New System.Drawing.Size(187, 21)
        Me.lblsecond.TabIndex = 3
        Me.lblsecond.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(211, 224)
        Me.Controls.Add(Me.lblsecond)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblStuff)
        Me.Controls.Add(Me.grpChoices)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "North Carolina"
        Me.grpChoices.ResumeLayout(False)
        Me.grpChoices.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpChoices As GroupBox
    Friend WithEvents chkBeach As CheckBox
    Friend WithEvents chkNC As CheckBox
    Friend WithEvents chkMountains As CheckBox
    Friend WithEvents lblStuff As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents lblsecond As Label
End Class
