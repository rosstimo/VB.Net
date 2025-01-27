<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinFormExampleForm
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ExampleTextBox = New System.Windows.Forms.TextBox()
        Me.ExampleLabel = New System.Windows.Forms.Label()
        Me.ActionButton = New System.Windows.Forms.Button()
        Me.MainToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DisplayPictureBox = New System.Windows.Forms.PictureBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MainListBox = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ActionContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainComboBox = New System.Windows.Forms.ComboBox()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplashTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(502, 28)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(242, 78)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "E&xit"
        Me.MainToolTip.SetToolTip(Me.ExitButton, "Close The Program...")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ExampleTextBox
        '
        Me.ExampleTextBox.Location = New System.Drawing.Point(82, 55)
        Me.ExampleTextBox.Name = "ExampleTextBox"
        Me.ExampleTextBox.Size = New System.Drawing.Size(354, 26)
        Me.ExampleTextBox.TabIndex = 0
        '
        'ExampleLabel
        '
        Me.ExampleLabel.AutoSize = True
        Me.ExampleLabel.Location = New System.Drawing.Point(6, 62)
        Me.ExampleLabel.Name = "ExampleLabel"
        Me.ExampleLabel.Size = New System.Drawing.Size(70, 20)
        Me.ExampleLabel.TabIndex = 0
        Me.ExampleLabel.Text = "Example"
        Me.MainToolTip.SetToolTip(Me.ExampleLabel, "Enter text here")
        '
        'ActionButton
        '
        Me.ActionButton.Location = New System.Drawing.Point(255, 28)
        Me.ActionButton.Name = "ActionButton"
        Me.ActionButton.Size = New System.Drawing.Size(242, 78)
        Me.ActionButton.TabIndex = 3
        Me.ActionButton.Text = "&Action"
        Me.MainToolTip.SetToolTip(Me.ActionButton, "Update top bar text!")
        Me.ActionButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Example"
        Me.MainToolTip.SetToolTip(Me.Label1, "Enter text here")
        '
        'DisplayPictureBox
        '
        Me.DisplayPictureBox.BackgroundImage = Global.WinFormExampleF24.My.Resources.Resources.kitten
        Me.DisplayPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DisplayPictureBox.Cursor = System.Windows.Forms.Cursors.Cross
        Me.DisplayPictureBox.Location = New System.Drawing.Point(10, 94)
        Me.DisplayPictureBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DisplayPictureBox.Name = "DisplayPictureBox"
        Me.DisplayPictureBox.Size = New System.Drawing.Size(428, 266)
        Me.DisplayPictureBox.TabIndex = 14
        Me.DisplayPictureBox.TabStop = False
        Me.MainToolTip.SetToolTip(Me.DisplayPictureBox, "I like Kittens...")
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(8, 28)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(242, 78)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "&Clear"
        Me.MainToolTip.SetToolTip(Me.ClearButton, "Update top bar text!")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.OutputTextBox)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 380)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 205)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(184, 152)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(116, 24)
        Me.CheckBox3.TabIndex = 4
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(184, 123)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(116, 24)
        Me.CheckBox2.TabIndex = 3
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(184, 92)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(116, 24)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'OutputTextBox
        '
        Me.OutputTextBox.Location = New System.Drawing.Point(100, 25)
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.Size = New System.Drawing.Size(204, 26)
        Me.OutputTextBox.TabIndex = 0
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(24, 152)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(133, 24)
        Me.RadioButton3.TabIndex = 1
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(24, 122)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(133, 24)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(24, 92)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(133, 24)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ClearButton)
        Me.GroupBox2.Controls.Add(Me.ExitButton)
        Me.GroupBox2.Controls.Add(Me.ActionButton)
        Me.GroupBox2.Location = New System.Drawing.Point(537, 449)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(753, 135)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'MainListBox
        '
        Me.MainListBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.MainListBox.FormattingEnabled = True
        Me.MainListBox.ItemHeight = 20
        Me.MainListBox.Location = New System.Drawing.Point(496, 94)
        Me.MainListBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MainListBox.Name = "MainListBox"
        Me.MainListBox.Size = New System.Drawing.Size(792, 264)
        Me.MainListBox.TabIndex = 16
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActionContextMenuItem, Me.ClearContextMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(136, 68)
        '
        'ActionContextMenuItem
        '
        Me.ActionContextMenuItem.Name = "ActionContextMenuItem"
        Me.ActionContextMenuItem.Size = New System.Drawing.Size(135, 32)
        Me.ActionContextMenuItem.Text = "&Action"
        '
        'ClearContextMenuItem
        '
        Me.ClearContextMenuItem.Name = "ClearContextMenuItem"
        Me.ClearContextMenuItem.Size = New System.Drawing.Size(135, 32)
        Me.ClearContextMenuItem.Text = "&Clear"
        '
        'MainComboBox
        '
        Me.MainComboBox.FormattingEnabled = True
        Me.MainComboBox.Location = New System.Drawing.Point(496, 57)
        Me.MainComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MainComboBox.Name = "MainComboBox"
        Me.MainComboBox.Size = New System.Drawing.Size(792, 28)
        Me.MainComboBox.TabIndex = 17
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(1308, 33)
        Me.TopMenuStrip.TabIndex = 18
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ActionToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(165, 34)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(165, 34)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'ActionToolStripMenuItem
        '
        Me.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem"
        Me.ActionToolStripMenuItem.Size = New System.Drawing.Size(165, 34)
        Me.ActionToolStripMenuItem.Text = "&Action"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(165, 34)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(164, 34)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'SplashTimer
        '
        Me.SplashTimer.Interval = 2000
        '
        'WinFormExampleForm
        '
        Me.AcceptButton = Me.ActionButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(1308, 606)
        Me.Controls.Add(Me.MainComboBox)
        Me.Controls.Add(Me.MainListBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DisplayPictureBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ExampleLabel)
        Me.Controls.Add(Me.ExampleTextBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "WinFormExampleForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forms Are Cool!"
        Me.MainToolTip.SetToolTip(Me, "This is the form")
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents ExampleTextBox As TextBox
    Friend WithEvents ExampleLabel As Label
    Friend WithEvents ActionButton As Button
    Friend WithEvents MainToolTip As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OutputTextBox As TextBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents DisplayPictureBox As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MainListBox As ListBox
    Friend WithEvents MainComboBox As ComboBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ActionContextMenuItem As ToolStripMenuItem
    Friend WithEvents ClearContextMenuItem As ToolStripMenuItem
    Friend WithEvents SplashTimer As Timer
End Class
