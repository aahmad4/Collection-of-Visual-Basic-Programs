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
        Me.lblScopeAnswer = New System.Windows.Forms.Label()
        Me.btnLocal = New System.Windows.Forms.Button()
        Me.btnGlobal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblScopeAnswer
        '
        Me.lblScopeAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScopeAnswer.Location = New System.Drawing.Point(78, 24)
        Me.lblScopeAnswer.Name = "lblScopeAnswer"
        Me.lblScopeAnswer.Size = New System.Drawing.Size(100, 73)
        Me.lblScopeAnswer.TabIndex = 0
        Me.lblScopeAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLocal
        '
        Me.btnLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocal.Location = New System.Drawing.Point(80, 100)
        Me.btnLocal.Name = "btnLocal"
        Me.btnLocal.Size = New System.Drawing.Size(98, 40)
        Me.btnLocal.TabIndex = 1
        Me.btnLocal.Text = "Local"
        Me.btnLocal.UseVisualStyleBackColor = True
        '
        'btnGlobal
        '
        Me.btnGlobal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGlobal.Location = New System.Drawing.Point(80, 160)
        Me.btnGlobal.Name = "btnGlobal"
        Me.btnGlobal.Size = New System.Drawing.Size(98, 42)
        Me.btnGlobal.TabIndex = 2
        Me.btnGlobal.Text = "Global"
        Me.btnGlobal.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 225)
        Me.Controls.Add(Me.btnGlobal)
        Me.Controls.Add(Me.btnLocal)
        Me.Controls.Add(Me.lblScopeAnswer)
        Me.Name = "Form1"
        Me.Text = "Variable Scope"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblScopeAnswer As Label
    Friend WithEvents btnLocal As Button
    Friend WithEvents btnGlobal As Button
End Class
