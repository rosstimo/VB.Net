<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListsAndListBoxExampleForm
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
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemsComboBox = New System.Windows.Forms.ComboBox()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DisplayListBox
        '
        Me.DisplayListBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.DisplayListBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DisplayListBox.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 19
        Me.DisplayListBox.Location = New System.Drawing.Point(18, 78)
        Me.DisplayListBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(1162, 384)
        Me.DisplayListBox.TabIndex = 0
        Me.MainToolTip.SetToolTip(Me.DisplayListBox, "Select an item then right click for more options.")
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveContextMenuItem, Me.ClearAllContextMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(149, 68)
        '
        'RemoveContextMenuItem
        '
        Me.RemoveContextMenuItem.Name = "RemoveContextMenuItem"
        Me.RemoveContextMenuItem.Size = New System.Drawing.Size(148, 32)
        Me.RemoveContextMenuItem.Text = "Remove"
        '
        'ClearAllContextMenuItem
        '
        Me.ClearAllContextMenuItem.Name = "ClearAllContextMenuItem"
        Me.ClearAllContextMenuItem.Size = New System.Drawing.Size(148, 32)
        Me.ClearAllContextMenuItem.Text = "Clear All"
        '
        'ItemsComboBox
        '
        Me.ItemsComboBox.FormattingEnabled = True
        Me.ItemsComboBox.Location = New System.Drawing.Point(812, 474)
        Me.ItemsComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ItemsComboBox.Name = "ItemsComboBox"
        Me.ItemsComboBox.Size = New System.Drawing.Size(368, 28)
        Me.ItemsComboBox.TabIndex = 1
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(960, 575)
        Me.QuitButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(222, 98)
        Me.QuitButton.TabIndex = 2
        Me.QuitButton.Text = "&Quit"
        Me.MainToolTip.SetToolTip(Me.QuitButton, "Click to leave")
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(729, 575)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(222, 98)
        Me.AddButton.TabIndex = 3
        Me.AddButton.Text = "&Add"
        Me.MainToolTip.SetToolTip(Me.AddButton, "Add From Text Box")
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(18, 474)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(322, 26)
        Me.TextBox1.TabIndex = 4
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(1200, 35)
        Me.TopMenuStrip.TabIndex = 5
        Me.TopMenuStrip.Text = "MenuStrip1"
        Me.MainToolTip.SetToolTip(Me.TopMenuStrip, "Select an item then right click for more options.")
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 30)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(157, 34)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(157, 34)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 30)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(164, 34)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ListsAndListBoxExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.ItemsComboBox)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ListsAndListBoxExampleForm"
        Me.Text = "List Controls"
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents ItemsComboBox As ComboBox
    Friend WithEvents QuitButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents RemoveContextMenuItem As ToolStripMenuItem
    Friend WithEvents ClearAllContextMenuItem As ToolStripMenuItem
    Friend WithEvents MainToolTip As ToolTip
End Class
