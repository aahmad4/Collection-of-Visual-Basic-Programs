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
        Me.btnDimVariable = New System.Windows.Forms.Button()
        Me.btnStaticVariable = New System.Windows.Forms.Button()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDimVariable
        '
        Me.btnDimVariable.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDimVariable.Location = New System.Drawing.Point(12, 12)
        Me.btnDimVariable.Name = "btnDimVariable"
        Me.btnDimVariable.Size = New System.Drawing.Size(114, 43)
        Me.btnDimVariable.TabIndex = 0
        Me.btnDimVariable.Text = "Dim Variable"
        Me.btnDimVariable.UseVisualStyleBackColor = True
        '
        'btnStaticVariable
        '
        Me.btnStaticVariable.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaticVariable.Location = New System.Drawing.Point(139, 12)
        Me.btnStaticVariable.Name = "btnStaticVariable"
        Me.btnStaticVariable.Size = New System.Drawing.Size(114, 43)
        Me.btnStaticVariable.TabIndex = 1
        Me.btnStaticVariable.Text = "Static Variable"
        Me.btnStaticVariable.UseVisualStyleBackColor = True
        '
        'lblCounter
        '
        Me.lblCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter.Location = New System.Drawing.Point(12, 67)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(241, 55)
        Me.lblCounter.TabIndex = 2
        Me.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 144)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.btnStaticVariable)
        Me.Controls.Add(Me.btnDimVariable)
        Me.Name = "Form1"
        Me.Text = "Counting"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDimVariable As Button
    Friend WithEvents btnStaticVariable As Button
    Friend WithEvents lblCounter As Label
End Class
