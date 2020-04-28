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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbsoluteValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SquareRootToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(279, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MathToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.MainToolStripMenuItem.Text = "Main"
        '
        'MathToolStripMenuItem
        '
        Me.MathToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbsoluteValueToolStripMenuItem, Me.SquareRootToolStripMenuItem, Me.SignToolStripMenuItem, Me.RoundToolStripMenuItem})
        Me.MathToolStripMenuItem.Name = "MathToolStripMenuItem"
        Me.MathToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MathToolStripMenuItem.Text = "Math"
        '
        'AbsoluteValueToolStripMenuItem
        '
        Me.AbsoluteValueToolStripMenuItem.Name = "AbsoluteValueToolStripMenuItem"
        Me.AbsoluteValueToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AbsoluteValueToolStripMenuItem.Text = "Absolute Value"
        '
        'SquareRootToolStripMenuItem
        '
        Me.SquareRootToolStripMenuItem.Name = "SquareRootToolStripMenuItem"
        Me.SquareRootToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SquareRootToolStripMenuItem.Text = "Square Root"
        '
        'SignToolStripMenuItem
        '
        Me.SignToolStripMenuItem.Name = "SignToolStripMenuItem"
        Me.SignToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SignToolStripMenuItem.Text = "Sign"
        '
        'RoundToolStripMenuItem
        '
        Me.RoundToolStripMenuItem.Name = "RoundToolStripMenuItem"
        Me.RoundToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RoundToolStripMenuItem.Text = "Round"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter a Number"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(127, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'lblMain
        '
        Me.lblMain.Location = New System.Drawing.Point(12, 82)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(255, 108)
        Me.lblMain.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 212)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MainToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbsoluteValueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SquareRootToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SignToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RoundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblMain As Label
End Class
