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
        Me.grpChoices1 = New System.Windows.Forms.GroupBox()
        Me.radHybrid = New System.Windows.Forms.RadioButton()
        Me.radMountain = New System.Windows.Forms.RadioButton()
        Me.radRoad = New System.Windows.Forms.RadioButton()
        Me.grpChoices2 = New System.Windows.Forms.GroupBox()
        Me.chkSeat = New System.Windows.Forms.CheckBox()
        Me.chkFrame = New System.Windows.Forms.CheckBox()
        Me.chkPaint = New System.Windows.Forms.CheckBox()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.grpChoices1.SuspendLayout()
        Me.grpChoices2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpChoices1
        '
        Me.grpChoices1.Controls.Add(Me.radHybrid)
        Me.grpChoices1.Controls.Add(Me.radMountain)
        Me.grpChoices1.Controls.Add(Me.radRoad)
        Me.grpChoices1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpChoices1.Location = New System.Drawing.Point(12, 12)
        Me.grpChoices1.Name = "grpChoices1"
        Me.grpChoices1.Size = New System.Drawing.Size(242, 154)
        Me.grpChoices1.TabIndex = 0
        Me.grpChoices1.TabStop = False
        Me.grpChoices1.Text = "Type of Bike"
        '
        'radHybrid
        '
        Me.radHybrid.AutoSize = True
        Me.radHybrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radHybrid.Location = New System.Drawing.Point(24, 77)
        Me.radHybrid.Name = "radHybrid"
        Me.radHybrid.Size = New System.Drawing.Size(72, 24)
        Me.radHybrid.TabIndex = 2
        Me.radHybrid.TabStop = True
        Me.radHybrid.Text = "Hybrid"
        Me.radHybrid.UseVisualStyleBackColor = True
        '
        'radMountain
        '
        Me.radMountain.AutoSize = True
        Me.radMountain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMountain.Location = New System.Drawing.Point(24, 54)
        Me.radMountain.Name = "radMountain"
        Me.radMountain.Size = New System.Drawing.Size(93, 24)
        Me.radMountain.TabIndex = 1
        Me.radMountain.TabStop = True
        Me.radMountain.Text = "Mountain"
        Me.radMountain.UseVisualStyleBackColor = True
        '
        'radRoad
        '
        Me.radRoad.AutoSize = True
        Me.radRoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRoad.Location = New System.Drawing.Point(24, 31)
        Me.radRoad.Name = "radRoad"
        Me.radRoad.Size = New System.Drawing.Size(66, 24)
        Me.radRoad.TabIndex = 0
        Me.radRoad.TabStop = True
        Me.radRoad.Text = "Road"
        Me.radRoad.UseVisualStyleBackColor = True
        '
        'grpChoices2
        '
        Me.grpChoices2.Controls.Add(Me.chkSeat)
        Me.grpChoices2.Controls.Add(Me.chkFrame)
        Me.grpChoices2.Controls.Add(Me.chkPaint)
        Me.grpChoices2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpChoices2.Location = New System.Drawing.Point(295, 12)
        Me.grpChoices2.Name = "grpChoices2"
        Me.grpChoices2.Size = New System.Drawing.Size(242, 154)
        Me.grpChoices2.TabIndex = 1
        Me.grpChoices2.TabStop = False
        Me.grpChoices2.Text = "Extras"
        '
        'chkSeat
        '
        Me.chkSeat.AutoSize = True
        Me.chkSeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeat.Location = New System.Drawing.Point(25, 77)
        Me.chkSeat.Name = "chkSeat"
        Me.chkSeat.Size = New System.Drawing.Size(123, 24)
        Me.chkSeat.TabIndex = 2
        Me.chkSeat.Text = "Comfort Seat"
        Me.chkSeat.UseVisualStyleBackColor = True
        '
        'chkFrame
        '
        Me.chkFrame.AutoSize = True
        Me.chkFrame.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFrame.Location = New System.Drawing.Point(25, 54)
        Me.chkFrame.Name = "chkFrame"
        Me.chkFrame.Size = New System.Drawing.Size(159, 24)
        Me.chkFrame.TabIndex = 1
        Me.chkFrame.Text = "Heavy Duty Frame"
        Me.chkFrame.UseVisualStyleBackColor = True
        '
        'chkPaint
        '
        Me.chkPaint.AutoSize = True
        Me.chkPaint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPaint.Location = New System.Drawing.Point(25, 31)
        Me.chkPaint.Name = "chkPaint"
        Me.chkPaint.Size = New System.Drawing.Size(123, 24)
        Me.chkPaint.TabIndex = 0
        Me.chkPaint.Text = "Custom Paint"
        Me.chkPaint.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(12, 172)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(525, 65)
        Me.btnAbout.TabIndex = 3
        Me.btnAbout.Text = "About the Bike Shop"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(12, 252)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(525, 189)
        Me.lbl1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 450)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.grpChoices2)
        Me.Controls.Add(Me.grpChoices1)
        Me.Name = "Form1"
        Me.Text = "Bikes"
        Me.grpChoices1.ResumeLayout(False)
        Me.grpChoices1.PerformLayout()
        Me.grpChoices2.ResumeLayout(False)
        Me.grpChoices2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpChoices1 As GroupBox
    Friend WithEvents grpChoices2 As GroupBox
    Friend WithEvents radHybrid As RadioButton
    Friend WithEvents radMountain As RadioButton
    Friend WithEvents radRoad As RadioButton
    Friend WithEvents chkSeat As CheckBox
    Friend WithEvents chkFrame As CheckBox
    Friend WithEvents chkPaint As CheckBox
    Friend WithEvents btnAbout As Button
    Friend WithEvents lbl1 As Label
End Class
