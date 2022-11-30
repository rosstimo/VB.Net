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
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.DrawPictureBox = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.DrawPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorToolStripMenuItem, Me.SizeToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(104, 70)
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ColorToolStripMenuItem.Text = "&Color"
        '
        'SizeToolStripMenuItem
        '
        Me.SizeToolStripMenuItem.Name = "SizeToolStripMenuItem"
        Me.SizeToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SizeToolStripMenuItem.Text = "&Size"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PositionStatusLabel, Me.ColorStatusLabel, Me.MouseButtonStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 599)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(827, 22)
        Me.StatusStrip.TabIndex = 1
        '
        'PositionStatusLabel
        '
        Me.PositionStatusLabel.Name = "PositionStatusLabel"
        Me.PositionStatusLabel.Size = New System.Drawing.Size(50, 17)
        Me.PositionStatusLabel.Text = "Position"
        '
        'ColorStatusLabel
        '
        Me.ColorStatusLabel.Name = "ColorStatusLabel"
        Me.ColorStatusLabel.Size = New System.Drawing.Size(36, 17)
        Me.ColorStatusLabel.Text = "Color"
        '
        'MouseButtonStatusLabel
        '
        Me.MouseButtonStatusLabel.Name = "MouseButtonStatusLabel"
        Me.MouseButtonStatusLabel.Size = New System.Drawing.Size(79, 17)
        Me.MouseButtonStatusLabel.Text = "MouseButton"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(2, 599)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'DrawPictureBox
        '
        Me.DrawPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DrawPictureBox.Cursor = System.Windows.Forms.Cursors.Cross
        Me.DrawPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.DrawPictureBox.Name = "DrawPictureBox"
        Me.DrawPictureBox.Size = New System.Drawing.Size(803, 584)
        Me.DrawPictureBox.TabIndex = 3
        Me.DrawPictureBox.TabStop = False
        '
        'GraphicsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 621)
        Me.Controls.Add(Me.DrawPictureBox)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Name = "GraphicsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.DrawPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents DrawPictureBox As PictureBox
End Class
