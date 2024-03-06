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
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.UserInputLabel = New System.Windows.Forms.Label()
        Me.UserInputTextBox = New System.Windows.Forms.TextBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LengthCheckBox = New System.Windows.Forms.CheckBox()
        Me.RemoveSpacesCheckBox = New System.Windows.Forms.CheckBox()
        Me.ReverseCheckBox = New System.Windows.Forms.CheckBox()
        Me.LowerCaseRadioButton = New System.Windows.Forms.RadioButton()
        Me.UpperCaseRadioButton = New System.Windows.Forms.RadioButton()
        Me.NoChangeRadioButton = New System.Windows.Forms.RadioButton()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.RecordsComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(214, 25)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(197, 93)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "&Submit"
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
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LengthCheckBox)
        Me.GroupBox2.Controls.Add(Me.RemoveSpacesCheckBox)
        Me.GroupBox2.Controls.Add(Me.ReverseCheckBox)
        Me.GroupBox2.Controls.Add(Me.LowerCaseRadioButton)
        Me.GroupBox2.Controls.Add(Me.UpperCaseRadioButton)
        Me.GroupBox2.Controls.Add(Me.NoChangeRadioButton)
        Me.GroupBox2.Controls.Add(Me.UserInputTextBox)
        Me.GroupBox2.Controls.Add(Me.UserInputLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(416, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 179)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
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
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(Me.EmailLabel)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Controls.Add(Me.FirstNameLabel)
        Me.GroupBox1.Controls.Add(Me.AgeTextBox)
        Me.GroupBox1.Controls.Add(Me.AgeLabel)
        Me.GroupBox1.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox1.Controls.Add(Me.LastNameLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 179)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(52, 115)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(252, 26)
        Me.EmailTextBox.TabIndex = 7
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(6, 121)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(46, 20)
        Me.EmailLabel.TabIndex = 8
        Me.EmailLabel.Text = "email"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(52, 16)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(252, 26)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(6, 22)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(40, 20)
        Me.FirstNameLabel.TabIndex = 6
        Me.FirstNameLabel.Text = "First"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(52, 81)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(47, 26)
        Me.AgeTextBox.TabIndex = 3
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(6, 87)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(38, 20)
        Me.AgeLabel.TabIndex = 4
        Me.AgeLabel.Text = "Age"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(52, 48)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(252, 26)
        Me.LastNameTextBox.TabIndex = 2
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(6, 54)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(40, 20)
        Me.LastNameLabel.TabIndex = 2
        Me.LastNameLabel.Text = "Last"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SubmitButton)
        Me.GroupBox3.Controls.Add(Me.ExitButton)
        Me.GroupBox3.Controls.Add(Me.ClearButton)
        Me.GroupBox3.Location = New System.Drawing.Point(191, 443)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(625, 134)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 20
        Me.DisplayListBox.Location = New System.Drawing.Point(13, 247)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(803, 184)
        Me.DisplayListBox.TabIndex = 4
        Me.DisplayListBox.TabStop = False
        '
        'RecordsComboBox
        '
        Me.RecordsComboBox.FormattingEnabled = True
        Me.RecordsComboBox.Location = New System.Drawing.Point(65, 213)
        Me.RecordsComboBox.Name = "RecordsComboBox"
        Me.RecordsComboBox.Size = New System.Drawing.Size(252, 28)
        Me.RecordsComboBox.TabIndex = 5
        Me.RecordsComboBox.TabStop = False
        '
        'ExampleForm
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(828, 589)
        Me.Controls.Add(Me.RecordsComboBox)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "ExampleForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows Form Example"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SubmitButton As Button
    Friend WithEvents UserInputLabel As Label
    Friend WithEvents UserInputTextBox As TextBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LowerCaseRadioButton As RadioButton
    Friend WithEvents UpperCaseRadioButton As RadioButton
    Friend WithEvents NoChangeRadioButton As RadioButton
    Friend WithEvents LengthCheckBox As CheckBox
    Friend WithEvents RemoveSpacesCheckBox As CheckBox
    Friend WithEvents ReverseCheckBox As CheckBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents AgeLabel As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents RecordsComboBox As ComboBox
End Class
