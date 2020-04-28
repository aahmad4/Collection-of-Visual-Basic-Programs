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
        Me.TheBeatlesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TheWhoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TheDoorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblBandInfo = New System.Windows.Forms.Label()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(294, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TheBeatlesToolStripMenuItem, Me.TheWhoToolStripMenuItem, Me.TheDoorsToolStripMenuItem, Me.AboutToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.MainToolStripMenuItem.Text = "Main"
        '
        'TheBeatlesToolStripMenuItem
        '
        Me.TheBeatlesToolStripMenuItem.Name = "TheBeatlesToolStripMenuItem"
        Me.TheBeatlesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TheBeatlesToolStripMenuItem.Text = "The Beatles"
        '
        'TheWhoToolStripMenuItem
        '
        Me.TheWhoToolStripMenuItem.Name = "TheWhoToolStripMenuItem"
        Me.TheWhoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TheWhoToolStripMenuItem.Text = "The Who"
        '
        'TheDoorsToolStripMenuItem
        '
        Me.TheDoorsToolStripMenuItem.Name = "TheDoorsToolStripMenuItem"
        Me.TheDoorsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TheDoorsToolStripMenuItem.Text = "The Doors"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'lblBandInfo
        '
        Me.lblBandInfo.Location = New System.Drawing.Point(13, 43)
        Me.lblBandInfo.Name = "lblBandInfo"
        Me.lblBandInfo.Size = New System.Drawing.Size(270, 132)
        Me.lblBandInfo.TabIndex = 1
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 184)
        Me.Controls.Add(Me.lblBandInfo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Classic Bands"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MainToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TheBeatlesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TheWhoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TheDoorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblBandInfo As Label
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
