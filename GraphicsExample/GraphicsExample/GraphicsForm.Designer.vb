<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraphicsForm
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
        Me.components = New System.ComponentModel.Container()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.PositionStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ColorStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MouseButtonStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ContextMenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorToolStripMenuItem, Me.SizeToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(146, 118)
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(145, 38)
        Me.ColorToolStripMenuItem.Text = "&Color"
        '
        'SizeToolStripMenuItem
        '
        Me.SizeToolStripMenuItem.Name = "SizeToolStripMenuItem"
        Me.SizeToolStripMenuItem.Size = New System.Drawing.Size(145, 38)
        Me.SizeToolStripMenuItem.Text = "&Size"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(145, 38)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PositionStatusLabel, Me.ColorStatusLabel, Me.MouseButtonStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 823)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1600, 42)
        Me.StatusStrip.TabIndex = 1
        '
        'PositionStatusLabel
        '
        Me.PositionStatusLabel.Name = "PositionStatusLabel"
        Me.PositionStatusLabel.Size = New System.Drawing.Size(98, 32)
        Me.PositionStatusLabel.Text = "Position"
        '
        'ColorStatusLabel
        '
        Me.ColorStatusLabel.Name = "ColorStatusLabel"
        Me.ColorStatusLabel.Size = New System.Drawing.Size(71, 32)
        Me.ColorStatusLabel.Text = "Color"
        '
        'MouseButtonStatusLabel
        '
        Me.MouseButtonStatusLabel.Name = "MouseButtonStatusLabel"
        Me.MouseButtonStatusLabel.Size = New System.Drawing.Size(159, 32)
        Me.MouseButtonStatusLabel.Text = "MouseButton"
        '
        'GraphicsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1600, 865)
        Me.Controls.Add(Me.StatusStrip)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "GraphicsForm"
        Me.Text = "Form1"
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents PositionStatusLabel As ToolStripStatusLabel
    Friend WithEvents ColorStatusLabel As ToolStripStatusLabel
    Friend WithEvents MouseButtonStatusLabel As ToolStripStatusLabel
End Class
