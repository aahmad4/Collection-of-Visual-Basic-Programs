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
        Me.grpTasks = New System.Windows.Forms.GroupBox()
        Me.chkHWDone = New System.Windows.Forms.CheckBox()
        Me.chkEatBreakfast = New System.Windows.Forms.CheckBox()
        Me.chkBrushTeeth = New System.Windows.Forms.CheckBox()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.btnReady = New System.Windows.Forms.Button()
        Me.grpTasks.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTasks
        '
        Me.grpTasks.Controls.Add(Me.chkBrushTeeth)
        Me.grpTasks.Controls.Add(Me.chkEatBreakfast)
        Me.grpTasks.Controls.Add(Me.chkHWDone)
        Me.grpTasks.Location = New System.Drawing.Point(12, 12)
        Me.grpTasks.Name = "grpTasks"
        Me.grpTasks.Size = New System.Drawing.Size(200, 100)
        Me.grpTasks.TabIndex = 0
        Me.grpTasks.TabStop = False
        Me.grpTasks.Text = "Morning Tasks"
        '
        'chkHWDone
        '
        Me.chkHWDone.AutoSize = True
        Me.chkHWDone.Location = New System.Drawing.Point(15, 23)
        Me.chkHWDone.Name = "chkHWDone"
        Me.chkHWDone.Size = New System.Drawing.Size(106, 17)
        Me.chkHWDone.TabIndex = 0
        Me.chkHWDone.Text = "Homework Done"
        Me.chkHWDone.UseVisualStyleBackColor = True
        '
        'chkEatBreakfast
        '
        Me.chkEatBreakfast.AutoSize = True
        Me.chkEatBreakfast.Location = New System.Drawing.Point(15, 46)
        Me.chkEatBreakfast.Name = "chkEatBreakfast"
        Me.chkEatBreakfast.Size = New System.Drawing.Size(90, 17)
        Me.chkEatBreakfast.TabIndex = 1
        Me.chkEatBreakfast.Text = "Eat Breakfast"
        Me.chkEatBreakfast.UseVisualStyleBackColor = True
        '
        'chkBrushTeeth
        '
        Me.chkBrushTeeth.AutoSize = True
        Me.chkBrushTeeth.Location = New System.Drawing.Point(15, 69)
        Me.chkBrushTeeth.Name = "chkBrushTeeth"
        Me.chkBrushTeeth.Size = New System.Drawing.Size(84, 17)
        Me.chkBrushTeeth.TabIndex = 2
        Me.chkBrushTeeth.Text = "Brush Teeth"
        Me.chkBrushTeeth.UseVisualStyleBackColor = True
        '
        'lblMain
        '
        Me.lblMain.Location = New System.Drawing.Point(12, 118)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(200, 130)
        Me.lblMain.TabIndex = 1
        '
        'btnReady
        '
        Me.btnReady.Location = New System.Drawing.Point(55, 179)
        Me.btnReady.Name = "btnReady"
        Me.btnReady.Size = New System.Drawing.Size(111, 37)
        Me.btnReady.TabIndex = 2
        Me.btnReady.Text = "Ready"
        Me.btnReady.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 232)
        Me.Controls.Add(Me.btnReady)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.grpTasks)
        Me.Name = "Form1"
        Me.Text = "Ready For School"
        Me.grpTasks.ResumeLayout(False)
        Me.grpTasks.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpTasks As GroupBox
    Friend WithEvents chkBrushTeeth As CheckBox
    Friend WithEvents chkEatBreakfast As CheckBox
    Friend WithEvents chkHWDone As CheckBox
    Friend WithEvents lblMain As Label
    Friend WithEvents btnReady As Button
End Class
