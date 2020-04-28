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
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCards = New System.Windows.Forms.Label()
        Me.txtDraws = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDraw
        '
        Me.btnDraw.Location = New System.Drawing.Point(111, 53)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(359, 41)
        Me.btnDraw.TabIndex = 0
        Me.btnDraw.Text = "Draw Card"
        Me.btnDraw.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "How many draws?"
        '
        'lblCards
        '
        Me.lblCards.AutoSize = True
        Me.lblCards.Location = New System.Drawing.Point(108, 177)
        Me.lblCards.Name = "lblCards"
        Me.lblCards.Size = New System.Drawing.Size(0, 17)
        Me.lblCards.TabIndex = 2
        '
        'txtDraws
        '
        Me.txtDraws.Location = New System.Drawing.Point(236, 118)
        Me.txtDraws.Name = "txtDraws"
        Me.txtDraws.Size = New System.Drawing.Size(234, 22)
        Me.txtDraws.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtDraws)
        Me.Controls.Add(Me.lblCards)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDraw)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDraw As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCards As Label
    Friend WithEvents txtDraws As TextBox
End Class
