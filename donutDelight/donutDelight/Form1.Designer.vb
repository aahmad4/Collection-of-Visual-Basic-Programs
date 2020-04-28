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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHowMany = New System.Windows.Forms.TextBox()
        Me.grpTypes = New System.Windows.Forms.GroupBox()
        Me.radBlueberry = New System.Windows.Forms.RadioButton()
        Me.radLemon = New System.Windows.Forms.RadioButton()
        Me.radChocolate = New System.Windows.Forms.RadioButton()
        Me.radGlazed = New System.Windows.Forms.RadioButton()
        Me.lblChoices = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.grpTypes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How many doughnuts would you like?"
        '
        'txtHowMany
        '
        Me.txtHowMany.Location = New System.Drawing.Point(210, 17)
        Me.txtHowMany.Name = "txtHowMany"
        Me.txtHowMany.Size = New System.Drawing.Size(49, 20)
        Me.txtHowMany.TabIndex = 1
        '
        'grpTypes
        '
        Me.grpTypes.Controls.Add(Me.radBlueberry)
        Me.grpTypes.Controls.Add(Me.radLemon)
        Me.grpTypes.Controls.Add(Me.radChocolate)
        Me.grpTypes.Controls.Add(Me.radGlazed)
        Me.grpTypes.Location = New System.Drawing.Point(12, 58)
        Me.grpTypes.Name = "grpTypes"
        Me.grpTypes.Size = New System.Drawing.Size(256, 100)
        Me.grpTypes.TabIndex = 2
        Me.grpTypes.TabStop = False
        Me.grpTypes.Text = "Types of Doughnuts"
        '
        'radBlueberry
        '
        Me.radBlueberry.AutoSize = True
        Me.radBlueberry.Location = New System.Drawing.Point(151, 33)
        Me.radBlueberry.Name = "radBlueberry"
        Me.radBlueberry.Size = New System.Drawing.Size(96, 17)
        Me.radBlueberry.TabIndex = 3
        Me.radBlueberry.TabStop = True
        Me.radBlueberry.Text = "Blueberry $ .75"
        Me.radBlueberry.UseVisualStyleBackColor = True
        '
        'radLemon
        '
        Me.radLemon.AutoSize = True
        Me.radLemon.Location = New System.Drawing.Point(151, 56)
        Me.radLemon.Name = "radLemon"
        Me.radLemon.Size = New System.Drawing.Size(84, 17)
        Me.radLemon.TabIndex = 2
        Me.radLemon.TabStop = True
        Me.radLemon.Text = "Lemon $ .60"
        Me.radLemon.UseVisualStyleBackColor = True
        '
        'radChocolate
        '
        Me.radChocolate.AutoSize = True
        Me.radChocolate.Location = New System.Drawing.Point(33, 56)
        Me.radChocolate.Name = "radChocolate"
        Me.radChocolate.Size = New System.Drawing.Size(100, 17)
        Me.radChocolate.TabIndex = 1
        Me.radChocolate.TabStop = True
        Me.radChocolate.Text = "Chocolate $ .65"
        Me.radChocolate.UseVisualStyleBackColor = True
        '
        'radGlazed
        '
        Me.radGlazed.AutoSize = True
        Me.radGlazed.Location = New System.Drawing.Point(33, 33)
        Me.radGlazed.Name = "radGlazed"
        Me.radGlazed.Size = New System.Drawing.Size(85, 17)
        Me.radGlazed.TabIndex = 0
        Me.radGlazed.TabStop = True
        Me.radGlazed.Text = "Glazed $ .50"
        Me.radGlazed.UseVisualStyleBackColor = True
        '
        'lblChoices
        '
        Me.lblChoices.Location = New System.Drawing.Point(18, 171)
        Me.lblChoices.Name = "lblChoices"
        Me.lblChoices.Size = New System.Drawing.Size(247, 53)
        Me.lblChoices.TabIndex = 4
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(18, 239)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(106, 32)
        Me.btnOrder.TabIndex = 5
        Me.btnOrder.Text = "Your Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.Location = New System.Drawing.Point(144, 239)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(121, 32)
        Me.lblTotalCost.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 308)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.lblChoices)
        Me.Controls.Add(Me.grpTypes)
        Me.Controls.Add(Me.txtHowMany)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Donut Delight"
        Me.grpTypes.ResumeLayout(False)
        Me.grpTypes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtHowMany As TextBox
    Friend WithEvents grpTypes As GroupBox
    Friend WithEvents radBlueberry As RadioButton
    Friend WithEvents radLemon As RadioButton
    Friend WithEvents radChocolate As RadioButton
    Friend WithEvents radGlazed As RadioButton
    Friend WithEvents lblChoices As Label
    Friend WithEvents btnOrder As Button
    Friend WithEvents lblTotalCost As Label
End Class
