<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraphicsExampleForm
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
        Me.DrawingPictureBox = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackGroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.WaveButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DrawingPictureBox
        '
        Me.DrawingPictureBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.DrawingPictureBox.Cursor = System.Windows.Forms.Cursors.Cross
        Me.DrawingPictureBox.Location = New System.Drawing.Point(12, 22)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(523, 259)
        Me.DrawingPictureBox.TabIndex = 0
        Me.DrawingPictureBox.TabStop = False
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorToolStripMenuItem, Me.BackGroundColorToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(175, 48)
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'BackGroundColorToolStripMenuItem
        '
        Me.BackGroundColorToolStripMenuItem.Name = "BackGroundColorToolStripMenuItem"
        Me.BackGroundColorToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.BackGroundColorToolStripMenuItem.Text = "Back Ground Color"
        '
        'GroupBox
        '
        Me.GroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox.Controls.Add(Me.WaveButton)
        Me.GroupBox.Controls.Add(Me.ClearButton)
        Me.GroupBox.Controls.Add(Me.ExitButton)
        Me.GroupBox.Location = New System.Drawing.Point(367, 342)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(257, 78)
        Me.GroupBox.TabIndex = 1
        Me.GroupBox.TabStop = False
        '
        'WaveButton
        '
        Me.WaveButton.Location = New System.Drawing.Point(17, 19)
        Me.WaveButton.Name = "WaveButton"
        Me.WaveButton.Size = New System.Drawing.Size(75, 43)
        Me.WaveButton.TabIndex = 2
        Me.WaveButton.Text = "&Wave"
        Me.WaveButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(97, 19)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 43)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(177, 19)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 43)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.TopMenuStrip.Size = New System.Drawing.Size(544, 16)
        Me.TopMenuStrip.TabIndex = 2
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveTopMenuItem, Me.OpenTopMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 14)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveTopMenuItem
        '
        Me.SaveTopMenuItem.Name = "SaveTopMenuItem"
        Me.SaveTopMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SaveTopMenuItem.Text = "&Save"
        '
        'OpenTopMenuItem
        '
        Me.OpenTopMenuItem.Name = "OpenTopMenuItem"
        Me.OpenTopMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenTopMenuItem.Text = "&Open"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 14)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'GraphicsExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 600)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "GraphicsExampleForm"
        Me.Text = "Form1"
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.GroupBox.ResumeLayout(False)
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackGroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WaveButton As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveTopMenuItem As ToolStripMenuItem
    Friend WithEvents OpenTopMenuItem As ToolStripMenuItem
End Class
