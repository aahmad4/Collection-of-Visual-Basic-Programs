<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class grpChoices2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnHello = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.grpChoices = New System.Windows.Forms.GroupBox()
        Me.radEnglish = New System.Windows.Forms.RadioButton()
        Me.radFrench = New System.Windows.Forms.RadioButton()
        Me.radGerman = New System.Windows.Forms.RadioButton()
        Me.grpChoicesTwo = New System.Windows.Forms.GroupBox()
        Me.chkEnglish = New System.Windows.Forms.CheckBox()
        Me.chkGerman = New System.Windows.Forms.CheckBox()
        Me.chkFrench = New System.Windows.Forms.CheckBox()
        Me.grpChoices.SuspendLayout()
        Me.grpChoicesTwo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHello
        '
        Me.btnHello.Location = New System.Drawing.Point(206, 233)
        Me.btnHello.Name = "btnHello"
        Me.btnHello.Size = New System.Drawing.Size(75, 23)
        Me.btnHello.TabIndex = 0
        Me.btnHello.Text = "Hello"
        Me.btnHello.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.BackColor = System.Drawing.Color.White
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(18, 20)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 37)
        Me.lblMessage.TabIndex = 1
        '
        'grpChoices
        '
        Me.grpChoices.Controls.Add(Me.radGerman)
        Me.grpChoices.Controls.Add(Me.radFrench)
        Me.grpChoices.Controls.Add(Me.radEnglish)
        Me.grpChoices.Location = New System.Drawing.Point(12, 110)
        Me.grpChoices.Name = "grpChoices"
        Me.grpChoices.Size = New System.Drawing.Size(200, 100)
        Me.grpChoices.TabIndex = 2
        Me.grpChoices.TabStop = False
        Me.grpChoices.Text = "Language Hello"
        '
        'radEnglish
        '
        Me.radEnglish.AutoSize = True
        Me.radEnglish.Location = New System.Drawing.Point(2, 31)
        Me.radEnglish.Name = "radEnglish"
        Me.radEnglish.Size = New System.Drawing.Size(59, 17)
        Me.radEnglish.TabIndex = 0
        Me.radEnglish.TabStop = True
        Me.radEnglish.Text = "English"
        Me.radEnglish.UseVisualStyleBackColor = True
        '
        'radFrench
        '
        Me.radFrench.AutoSize = True
        Me.radFrench.Location = New System.Drawing.Point(3, 54)
        Me.radFrench.Name = "radFrench"
        Me.radFrench.Size = New System.Drawing.Size(58, 17)
        Me.radFrench.TabIndex = 1
        Me.radFrench.TabStop = True
        Me.radFrench.Text = "French"
        Me.radFrench.UseVisualStyleBackColor = True
        '
        'radGerman
        '
        Me.radGerman.AutoSize = True
        Me.radGerman.Location = New System.Drawing.Point(3, 77)
        Me.radGerman.Name = "radGerman"
        Me.radGerman.Size = New System.Drawing.Size(62, 17)
        Me.radGerman.TabIndex = 2
        Me.radGerman.TabStop = True
        Me.radGerman.Text = "German"
        Me.radGerman.UseVisualStyleBackColor = True
        '
        'grpChoicesTwo
        '
        Me.grpChoicesTwo.Controls.Add(Me.chkFrench)
        Me.grpChoicesTwo.Controls.Add(Me.chkGerman)
        Me.grpChoicesTwo.Controls.Add(Me.chkEnglish)
        Me.grpChoicesTwo.Location = New System.Drawing.Point(270, 110)
        Me.grpChoicesTwo.Name = "grpChoicesTwo"
        Me.grpChoicesTwo.Size = New System.Drawing.Size(200, 100)
        Me.grpChoicesTwo.TabIndex = 3
        Me.grpChoicesTwo.TabStop = False
        Me.grpChoicesTwo.Text = "Language Goodbye"
        '
        'chkEnglish
        '
        Me.chkEnglish.AutoSize = True
        Me.chkEnglish.Location = New System.Drawing.Point(6, 31)
        Me.chkEnglish.Name = "chkEnglish"
        Me.chkEnglish.Size = New System.Drawing.Size(60, 17)
        Me.chkEnglish.TabIndex = 0
        Me.chkEnglish.Text = "English"
        Me.chkEnglish.UseVisualStyleBackColor = True
        '
        'chkGerman
        '
        Me.chkGerman.AutoSize = True
        Me.chkGerman.Location = New System.Drawing.Point(6, 77)
        Me.chkGerman.Name = "chkGerman"
        Me.chkGerman.Size = New System.Drawing.Size(63, 17)
        Me.chkGerman.TabIndex = 1
        Me.chkGerman.Text = "German"
        Me.chkGerman.UseVisualStyleBackColor = True
        '
        'chkFrench
        '
        Me.chkFrench.AutoSize = True
        Me.chkFrench.Location = New System.Drawing.Point(6, 54)
        Me.chkFrench.Name = "chkFrench"
        Me.chkFrench.Size = New System.Drawing.Size(59, 17)
        Me.chkFrench.TabIndex = 2
        Me.chkFrench.Text = "French"
        Me.chkFrench.UseVisualStyleBackColor = True
        '
        'grpChoices2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 268)
        Me.Controls.Add(Me.grpChoicesTwo)
        Me.Controls.Add(Me.grpChoices)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnHello)
        Me.Name = "grpChoices2"
        Me.Text = "Language Goodbye"
        Me.grpChoices.ResumeLayout(False)
        Me.grpChoices.PerformLayout()
        Me.grpChoicesTwo.ResumeLayout(False)
        Me.grpChoicesTwo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHello As Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents grpChoices As GroupBox
    Friend WithEvents radGerman As RadioButton
    Friend WithEvents radFrench As RadioButton
    Friend WithEvents radEnglish As RadioButton
    Friend WithEvents grpChoicesTwo As GroupBox
    Friend WithEvents chkFrench As CheckBox
    Friend WithEvents chkGerman As CheckBox
    Friend WithEvents chkEnglish As CheckBox
End Class
