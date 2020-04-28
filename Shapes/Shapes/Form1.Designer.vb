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
        Me.ShapeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CircleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SquareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TriangleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShapeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(493, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ShapeToolStripMenuItem
        '
        Me.ShapeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CircleToolStripMenuItem, Me.StarToolStripMenuItem, Me.SquareToolStripMenuItem, Me.TriangleToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.ShapeToolStripMenuItem.Name = "ShapeToolStripMenuItem"
        Me.ShapeToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.ShapeToolStripMenuItem.Text = "Shape"
        '
        'CircleToolStripMenuItem
        '
        Me.CircleToolStripMenuItem.Name = "CircleToolStripMenuItem"
        Me.CircleToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CircleToolStripMenuItem.Text = "Circle"
        '
        'StarToolStripMenuItem
        '
        Me.StarToolStripMenuItem.Name = "StarToolStripMenuItem"
        Me.StarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StarToolStripMenuItem.Text = "Star"
        '
        'SquareToolStripMenuItem
        '
        Me.SquareToolStripMenuItem.Name = "SquareToolStripMenuItem"
        Me.SquareToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SquareToolStripMenuItem.Text = "Square"
        '
        'TriangleToolStripMenuItem
        '
        Me.TriangleToolStripMenuItem.Name = "TriangleToolStripMenuItem"
        Me.TriangleToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TriangleToolStripMenuItem.Text = "Triangle"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 419)
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
    Friend WithEvents ShapeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CircleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SquareToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TriangleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
End Class
