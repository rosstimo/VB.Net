<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExampleForm
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
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.UserInputLabel = New System.Windows.Forms.Label()
        Me.UserInputTextBox = New System.Windows.Forms.TextBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.FilterGroupBox = New System.Windows.Forms.GroupBox()
        Me.LengthCheckBox = New System.Windows.Forms.CheckBox()
        Me.RecordsComboBox = New System.Windows.Forms.ComboBox()
        Me.RemoveSpacesCheckBox = New System.Windows.Forms.CheckBox()
        Me.ReverseCheckBox = New System.Windows.Forms.CheckBox()
        Me.LowerCaseRadioButton = New System.Windows.Forms.RadioButton()
        Me.UpperCaseRadioButton = New System.Windows.Forms.RadioButton()
        Me.NoChangeRadioButton = New System.Windows.Forms.RadioButton()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.CustomerInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SubmitContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.StreetLabel = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.ButtonsGroupBox = New System.Windows.Forms.GroupBox()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.MainToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubmitTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.FilterGroupBox.SuspendLayout()
        Me.CustomerInfoGroupBox.SuspendLayout()
        Me.ContextMenuStrip.SuspendLayout()
        Me.ButtonsGroupBox.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubmitButton
        '
        Me.SubmitButton.Enabled = False
        Me.SubmitButton.Location = New System.Drawing.Point(214, 25)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(197, 93)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "&Submit"
        Me.MainToolTip.SetToolTip(Me.SubmitButton, "Add Record (Enter, Alt+S)")
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'UserInputLabel
        '
        Me.UserInputLabel.AutoSize = True
        Me.UserInputLabel.Location = New System.Drawing.Point(47, 28)
        Me.UserInputLabel.Name = "UserInputLabel"
        Me.UserInputLabel.Size = New System.Drawing.Size(84, 20)
        Me.UserInputLabel.TabIndex = 0
        Me.UserInputLabel.Text = "User Input"
        '
        'UserInputTextBox
        '
        Me.UserInputTextBox.Location = New System.Drawing.Point(137, 25)
        Me.UserInputTextBox.Name = "UserInputTextBox"
        Me.UserInputTextBox.Size = New System.Drawing.Size(252, 26)
        Me.UserInputTextBox.TabIndex = 0
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(417, 25)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(197, 93)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "E&xit"
        Me.MainToolTip.SetToolTip(Me.ExitButton, "Alt+x")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'FilterGroupBox
        '
        Me.FilterGroupBox.Controls.Add(Me.LengthCheckBox)
        Me.FilterGroupBox.Controls.Add(Me.RecordsComboBox)
        Me.FilterGroupBox.Controls.Add(Me.RemoveSpacesCheckBox)
        Me.FilterGroupBox.Controls.Add(Me.ReverseCheckBox)
        Me.FilterGroupBox.Controls.Add(Me.LowerCaseRadioButton)
        Me.FilterGroupBox.Controls.Add(Me.UpperCaseRadioButton)
        Me.FilterGroupBox.Controls.Add(Me.NoChangeRadioButton)
        Me.FilterGroupBox.Controls.Add(Me.UserInputTextBox)
        Me.FilterGroupBox.Controls.Add(Me.UserInputLabel)
        Me.FilterGroupBox.Location = New System.Drawing.Point(466, 52)
        Me.FilterGroupBox.Name = "FilterGroupBox"
        Me.FilterGroupBox.Size = New System.Drawing.Size(400, 329)
        Me.FilterGroupBox.TabIndex = 1
        Me.FilterGroupBox.TabStop = False
        Me.MainToolTip.SetToolTip(Me.FilterGroupBox, "Manipulate Text Here")
        '
        'LengthCheckBox
        '
        Me.LengthCheckBox.AutoSize = True
        Me.LengthCheckBox.Location = New System.Drawing.Point(203, 118)
        Me.LengthCheckBox.Name = "LengthCheckBox"
        Me.LengthCheckBox.Size = New System.Drawing.Size(116, 24)
        Me.LengthCheckBox.TabIndex = 3
        Me.LengthCheckBox.Text = "Get Length"
        Me.LengthCheckBox.UseVisualStyleBackColor = True
        '
        'RecordsComboBox
        '
        Me.RecordsComboBox.FormattingEnabled = True
        Me.RecordsComboBox.Location = New System.Drawing.Point(6, 275)
        Me.RecordsComboBox.Name = "RecordsComboBox"
        Me.RecordsComboBox.Size = New System.Drawing.Size(252, 28)
        Me.RecordsComboBox.TabIndex = 5
        Me.RecordsComboBox.TabStop = False
        '
        'RemoveSpacesCheckBox
        '
        Me.RemoveSpacesCheckBox.AutoSize = True
        Me.RemoveSpacesCheckBox.Location = New System.Drawing.Point(203, 88)
        Me.RemoveSpacesCheckBox.Name = "RemoveSpacesCheckBox"
        Me.RemoveSpacesCheckBox.Size = New System.Drawing.Size(152, 24)
        Me.RemoveSpacesCheckBox.TabIndex = 2
        Me.RemoveSpacesCheckBox.Text = "Remove Spaces"
        Me.RemoveSpacesCheckBox.UseVisualStyleBackColor = True
        '
        'ReverseCheckBox
        '
        Me.ReverseCheckBox.AutoSize = True
        Me.ReverseCheckBox.Location = New System.Drawing.Point(203, 57)
        Me.ReverseCheckBox.Name = "ReverseCheckBox"
        Me.ReverseCheckBox.Size = New System.Drawing.Size(94, 24)
        Me.ReverseCheckBox.TabIndex = 1
        Me.ReverseCheckBox.Text = "Reverse"
        Me.ReverseCheckBox.UseVisualStyleBackColor = True
        '
        'LowerCaseRadioButton
        '
        Me.LowerCaseRadioButton.AutoSize = True
        Me.LowerCaseRadioButton.Location = New System.Drawing.Point(51, 117)
        Me.LowerCaseRadioButton.Name = "LowerCaseRadioButton"
        Me.LowerCaseRadioButton.Size = New System.Drawing.Size(118, 24)
        Me.LowerCaseRadioButton.TabIndex = 0
        Me.LowerCaseRadioButton.Text = "Lower Case"
        Me.LowerCaseRadioButton.UseVisualStyleBackColor = True
        '
        'UpperCaseRadioButton
        '
        Me.UpperCaseRadioButton.AutoSize = True
        Me.UpperCaseRadioButton.Location = New System.Drawing.Point(51, 87)
        Me.UpperCaseRadioButton.Name = "UpperCaseRadioButton"
        Me.UpperCaseRadioButton.Size = New System.Drawing.Size(119, 24)
        Me.UpperCaseRadioButton.TabIndex = 0
        Me.UpperCaseRadioButton.Text = "Upper Case"
        Me.UpperCaseRadioButton.UseVisualStyleBackColor = True
        '
        'NoChangeRadioButton
        '
        Me.NoChangeRadioButton.AutoSize = True
        Me.NoChangeRadioButton.Location = New System.Drawing.Point(51, 57)
        Me.NoChangeRadioButton.Name = "NoChangeRadioButton"
        Me.NoChangeRadioButton.Size = New System.Drawing.Size(72, 24)
        Me.NoChangeRadioButton.TabIndex = 0
        Me.NoChangeRadioButton.TabStop = True
        Me.NoChangeRadioButton.Text = "None"
        Me.NoChangeRadioButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Location = New System.Drawing.Point(11, 25)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(197, 93)
        Me.ClearButton.TabIndex = 8
        Me.ClearButton.TabStop = False
        Me.ClearButton.Text = "&Clear"
        Me.MainToolTip.SetToolTip(Me.ClearButton, "Clear Form (Esc, Alt+C)")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CustomerInfoGroupBox
        '
        Me.CustomerInfoGroupBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.CustomerInfoGroupBox.Controls.Add(Me.IDTextBox)
        Me.CustomerInfoGroupBox.Controls.Add(Me.IDLabel)
        Me.CustomerInfoGroupBox.Controls.Add(Me.ZipTextBox)
        Me.CustomerInfoGroupBox.Controls.Add(Me.ZipLabel)
        Me.CustomerInfoGroupBox.Controls.Add(Me.StateTextBox)
        Me.CustomerInfoGroupBox.Controls.Add(Me.StateLabel)
        Me.CustomerInfoGroupBox.Controls.Add(Me.CityTextBox)
        Me.CustomerInfoGroupBox.Controls.Add(Me.CityLabel)
        Me.CustomerInfoGroupBox.Controls.Add(Me.StreetTextBox)
        Me.CustomerInfoGroupBox.Controls.Add(Me.StreetLabel)
        Me.CustomerInfoGroupBox.Controls.Add(Me.EmailTextBox)
        Me.CustomerInfoGroupBox.Controls.Add(Me.EmailLabel)
        Me.CustomerInfoGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.CustomerInfoGroupBox.Controls.Add(Me.FirstNameLabel)
        Me.CustomerInfoGroupBox.Controls.Add(Me.PhoneTextBox)
        Me.CustomerInfoGroupBox.Controls.Add(Me.PhoneLabel)
        Me.CustomerInfoGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.CustomerInfoGroupBox.Controls.Add(Me.LastNameLabel)
        Me.CustomerInfoGroupBox.Location = New System.Drawing.Point(12, 52)
        Me.CustomerInfoGroupBox.Name = "CustomerInfoGroupBox"
        Me.CustomerInfoGroupBox.Size = New System.Drawing.Size(397, 329)
        Me.CustomerInfoGroupBox.TabIndex = 0
        Me.CustomerInfoGroupBox.TabStop = False
        Me.MainToolTip.SetToolTip(Me.CustomerInfoGroupBox, "Enter Customer Data Here")
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubmitContextMenuItem, Me.ClearContextMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(142, 68)
        '
        'SubmitContextMenuItem
        '
        Me.SubmitContextMenuItem.Name = "SubmitContextMenuItem"
        Me.SubmitContextMenuItem.Size = New System.Drawing.Size(141, 32)
        Me.SubmitContextMenuItem.Text = "Submit"
        '
        'ClearContextMenuItem
        '
        Me.ClearContextMenuItem.Name = "ClearContextMenuItem"
        Me.ClearContextMenuItem.Size = New System.Drawing.Size(141, 32)
        Me.ClearContextMenuItem.Text = "Clear"
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(73, 25)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(252, 26)
        Me.IDTextBox.TabIndex = 0
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Location = New System.Drawing.Point(14, 31)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(35, 20)
        Me.IDLabel.TabIndex = 18
        Me.IDLabel.Text = "ID#"
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(73, 250)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(252, 26)
        Me.ZipTextBox.TabIndex = 7
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Location = New System.Drawing.Point(14, 256)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(31, 20)
        Me.ZipLabel.TabIndex = 16
        Me.ZipLabel.Text = "Zip"
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(73, 218)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(252, 26)
        Me.StateTextBox.TabIndex = 6
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(14, 224)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(48, 20)
        Me.StateLabel.TabIndex = 14
        Me.StateLabel.Text = "State"
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(73, 186)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(252, 26)
        Me.CityTextBox.TabIndex = 5
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(14, 192)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(35, 20)
        Me.CityLabel.TabIndex = 12
        Me.CityLabel.Text = "City"
        '
        'StreetTextBox
        '
        Me.StreetTextBox.Location = New System.Drawing.Point(73, 154)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(252, 26)
        Me.StreetTextBox.TabIndex = 4
        '
        'StreetLabel
        '
        Me.StreetLabel.AutoSize = True
        Me.StreetLabel.Location = New System.Drawing.Point(14, 160)
        Me.StreetLabel.Name = "StreetLabel"
        Me.StreetLabel.Size = New System.Drawing.Size(53, 20)
        Me.StreetLabel.TabIndex = 10
        Me.StreetLabel.Text = "Street"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(73, 282)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(252, 26)
        Me.EmailTextBox.TabIndex = 8
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(14, 288)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(46, 20)
        Me.EmailLabel.TabIndex = 8
        Me.EmailLabel.Text = "email"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(73, 57)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(252, 26)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(14, 63)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(40, 20)
        Me.FirstNameLabel.TabIndex = 6
        Me.FirstNameLabel.Text = "First"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(73, 122)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(252, 26)
        Me.PhoneTextBox.TabIndex = 3
        '
        'PhoneLabel
        '
        Me.PhoneLabel.AutoSize = True
        Me.PhoneLabel.Location = New System.Drawing.Point(14, 128)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(55, 20)
        Me.PhoneLabel.TabIndex = 4
        Me.PhoneLabel.Text = "Phone"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(73, 89)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(252, 26)
        Me.LastNameTextBox.TabIndex = 2
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(14, 95)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(40, 20)
        Me.LastNameLabel.TabIndex = 2
        Me.LastNameLabel.Text = "Last"
        '
        'ButtonsGroupBox
        '
        Me.ButtonsGroupBox.Controls.Add(Me.SubmitButton)
        Me.ButtonsGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonsGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonsGroupBox.Location = New System.Drawing.Point(241, 598)
        Me.ButtonsGroupBox.Name = "ButtonsGroupBox"
        Me.ButtonsGroupBox.Size = New System.Drawing.Size(625, 134)
        Me.ButtonsGroupBox.TabIndex = 2
        Me.ButtonsGroupBox.TabStop = False
        '
        'DisplayListBox
        '
        Me.DisplayListBox.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 19
        Me.DisplayListBox.Location = New System.Drawing.Point(12, 414)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(854, 156)
        Me.DisplayListBox.TabIndex = 4
        Me.DisplayListBox.TabStop = False
        Me.MainToolTip.SetToolTip(Me.DisplayListBox, "Custmer Data")
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(884, 33)
        Me.TopMenuStrip.TabIndex = 6
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubmitTopMenuItem, Me.ClearTopMenuItem, Me.ExitTopMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SubmitTopMenuItem
        '
        Me.SubmitTopMenuItem.Name = "SubmitTopMenuItem"
        Me.SubmitTopMenuItem.Size = New System.Drawing.Size(171, 34)
        Me.SubmitTopMenuItem.Text = "&Submit"
        '
        'ClearTopMenuItem
        '
        Me.ClearTopMenuItem.Name = "ClearTopMenuItem"
        Me.ClearTopMenuItem.Size = New System.Drawing.Size(171, 34)
        Me.ClearTopMenuItem.Text = "&Clear"
        '
        'ExitTopMenuItem
        '
        Me.ExitTopMenuItem.Name = "ExitTopMenuItem"
        Me.ExitTopMenuItem.Size = New System.Drawing.Size(171, 34)
        Me.ExitTopMenuItem.Text = "E&xit"
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
        'ExampleForm
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(884, 761)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.ButtonsGroupBox)
        Me.Controls.Add(Me.CustomerInfoGroupBox)
        Me.Controls.Add(Me.FilterGroupBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.MinimumSize = New System.Drawing.Size(900, 800)
        Me.Name = "ExampleForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows Form Example"
        Me.FilterGroupBox.ResumeLayout(False)
        Me.FilterGroupBox.PerformLayout()
        Me.CustomerInfoGroupBox.ResumeLayout(False)
        Me.CustomerInfoGroupBox.PerformLayout()
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.ButtonsGroupBox.ResumeLayout(False)
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SubmitButton As Button
    Friend WithEvents UserInputLabel As Label
    Friend WithEvents UserInputTextBox As TextBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents FilterGroupBox As GroupBox
    Friend WithEvents LowerCaseRadioButton As RadioButton
    Friend WithEvents UpperCaseRadioButton As RadioButton
    Friend WithEvents NoChangeRadioButton As RadioButton
    Friend WithEvents LengthCheckBox As CheckBox
    Friend WithEvents RemoveSpacesCheckBox As CheckBox
    Friend WithEvents ReverseCheckBox As CheckBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents CustomerInfoGroupBox As GroupBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents PhoneLabel As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents ButtonsGroupBox As GroupBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents RecordsComboBox As ComboBox
    Friend WithEvents MainToolTip As ToolTip
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubmitTopMenuItem As ToolStripMenuItem
    Friend WithEvents ClearTopMenuItem As ToolStripMenuItem
    Friend WithEvents ExitTopMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents SubmitContextMenuItem As ToolStripMenuItem
    Friend WithEvents ClearContextMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents StateLabel As Label
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents CityLabel As Label
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents StreetLabel As Label
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents ZipLabel As Label
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents IDLabel As Label
End Class
