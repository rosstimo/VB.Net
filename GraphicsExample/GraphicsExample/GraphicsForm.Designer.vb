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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SizeToolStripMenuItem = New System.Windows.Forms.ToolStripTextBox()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawPictureBox = New System.Windows.Forms.PictureBox()
        Me.DrawWavesButton = New System.Windows.Forms.Button()
        Me.ContextMenuStrip.SuspendLayout()
        CType(Me.DrawPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorToolStripMenuItem, Me.ToolStripSeparator1, Me.ToolStripMenuItem1, Me.SizeToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(241, 101)
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ColorToolStripMenuItem.Text = "&Color"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(237, 6)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(240, 22)
        Me.ToolStripMenuItem1.Text = "Pen Size"
        '
        'SizeToolStripMenuItem
        '
        Me.SizeToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SizeToolStripMenuItem.Name = "SizeToolStripMenuItem"
        Me.SizeToolStripMenuItem.Size = New System.Drawing.Size(180, 23)
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'DrawPictureBox
        '
        Me.DrawPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawPictureBox.BackColor = System.Drawing.Color.White
        Me.DrawPictureBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.DrawPictureBox.Cursor = System.Windows.Forms.Cursors.Cross
        Me.DrawPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.DrawPictureBox.MinimumSize = New System.Drawing.Size(360, 200)
        Me.DrawPictureBox.Name = "DrawPictureBox"
        Me.DrawPictureBox.Size = New System.Drawing.Size(601, 257)
        Me.DrawPictureBox.TabIndex = 1
        Me.DrawPictureBox.TabStop = False
        '
        'DrawWavesButton
        '
        Me.DrawWavesButton.Location = New System.Drawing.Point(226, 287)
        Me.DrawWavesButton.Name = "DrawWavesButton"
        Me.DrawWavesButton.Size = New System.Drawing.Size(162, 64)
        Me.DrawWavesButton.TabIndex = 2
        Me.DrawWavesButton.Text = "Draw &Waves"
        Me.DrawWavesButton.UseVisualStyleBackColor = True
        '
        'GraphicsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(625, 363)
        Me.Controls.Add(Me.DrawWavesButton)
        Me.Controls.Add(Me.DrawPictureBox)
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "GraphicsForm"
        Me.Text = "Form1"
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.ContextMenuStrip.PerformLayout()
        CType(Me.DrawPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawPictureBox As PictureBox
    Friend WithEvents SizeToolStripMenuItem As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DrawWavesButton As Button
End Class
