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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.FirstLabel = New System.Windows.Forms.Label()
        Me.FirstTextBox = New System.Windows.Forms.TextBox()
        Me.LastTextBox = New System.Windows.Forms.TextBox()
        Me.LastLabel = New System.Windows.Forms.Label()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.UpperRadioButton = New System.Windows.Forms.RadioButton()
        Me.LowerRadioButton = New System.Windows.Forms.RadioButton()
        Me.FirstLastRadioButton = New System.Windows.Forms.RadioButton()
        Me.LastFirstRadioButton = New System.Windows.Forms.RadioButton()
        Me.CaseGroupBox = New System.Windows.Forms.GroupBox()
        Me.FormatGroupBox = New System.Windows.Forms.GroupBox()
        Me.ReverseCheckBox = New System.Windows.Forms.CheckBox()
        Me.WhiteSpaceCheckBox = New System.Windows.Forms.CheckBox()
        Me.RandomCheckBox = New System.Windows.Forms.CheckBox()
        Me.DataListBox = New System.Windows.Forms.ListBox()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.CaseGroupBox.SuspendLayout()
        Me.FormatGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(594, 348)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(164, 91)
        Me.ExitButton.TabIndex = 10
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(424, 348)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(164, 91)
        Me.UpdateButton.TabIndex = 9
        Me.UpdateButton.Text = "&Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'FirstLabel
        '
        Me.FirstLabel.AutoSize = True
        Me.FirstLabel.Location = New System.Drawing.Point(2, 35)
        Me.FirstLabel.Name = "FirstLabel"
        Me.FirstLabel.Size = New System.Drawing.Size(86, 20)
        Me.FirstLabel.TabIndex = 2
        Me.FirstLabel.Text = "First Name"
        '
        'FirstTextBox
        '
        Me.FirstTextBox.Location = New System.Drawing.Point(93, 32)
        Me.FirstTextBox.Name = "FirstTextBox"
        Me.FirstTextBox.Size = New System.Drawing.Size(241, 26)
        Me.FirstTextBox.TabIndex = 0
        '
        'LastTextBox
        '
        Me.LastTextBox.Location = New System.Drawing.Point(93, 65)
        Me.LastTextBox.Name = "LastTextBox"
        Me.LastTextBox.Size = New System.Drawing.Size(241, 26)
        Me.LastTextBox.TabIndex = 1
        '
        'LastLabel
        '
        Me.LastLabel.AutoSize = True
        Me.LastLabel.Location = New System.Drawing.Point(2, 68)
        Me.LastLabel.Name = "LastLabel"
        Me.LastLabel.Size = New System.Drawing.Size(86, 20)
        Me.LastLabel.TabIndex = 4
        Me.LastLabel.Text = "Last Name"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(93, 97)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(91, 26)
        Me.AgeTextBox.TabIndex = 2
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(50, 100)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(38, 20)
        Me.AgeLabel.TabIndex = 6
        Me.AgeLabel.Text = "Age"
        '
        'UpperRadioButton
        '
        Me.UpperRadioButton.AutoSize = True
        Me.UpperRadioButton.Location = New System.Drawing.Point(6, 25)
        Me.UpperRadioButton.Name = "UpperRadioButton"
        Me.UpperRadioButton.Size = New System.Drawing.Size(119, 24)
        Me.UpperRadioButton.TabIndex = 11
        Me.UpperRadioButton.TabStop = True
        Me.UpperRadioButton.Text = "Upper Case"
        Me.UpperRadioButton.UseVisualStyleBackColor = True
        '
        'LowerRadioButton
        '
        Me.LowerRadioButton.AutoSize = True
        Me.LowerRadioButton.Location = New System.Drawing.Point(6, 55)
        Me.LowerRadioButton.Name = "LowerRadioButton"
        Me.LowerRadioButton.Size = New System.Drawing.Size(118, 24)
        Me.LowerRadioButton.TabIndex = 12
        Me.LowerRadioButton.TabStop = True
        Me.LowerRadioButton.Text = "Lower Case"
        Me.LowerRadioButton.UseVisualStyleBackColor = True
        '
        'FirstLastRadioButton
        '
        Me.FirstLastRadioButton.AutoSize = True
        Me.FirstLastRadioButton.Location = New System.Drawing.Point(6, 25)
        Me.FirstLastRadioButton.Name = "FirstLastRadioButton"
        Me.FirstLastRadioButton.Size = New System.Drawing.Size(100, 24)
        Me.FirstLastRadioButton.TabIndex = 13
        Me.FirstLastRadioButton.TabStop = True
        Me.FirstLastRadioButton.Text = "First Last"
        Me.FirstLastRadioButton.UseVisualStyleBackColor = True
        '
        'LastFirstRadioButton
        '
        Me.LastFirstRadioButton.AutoSize = True
        Me.LastFirstRadioButton.Location = New System.Drawing.Point(6, 55)
        Me.LastFirstRadioButton.Name = "LastFirstRadioButton"
        Me.LastFirstRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.LastFirstRadioButton.TabIndex = 14
        Me.LastFirstRadioButton.TabStop = True
        Me.LastFirstRadioButton.Text = "Last, First"
        Me.LastFirstRadioButton.UseVisualStyleBackColor = True
        '
        'CaseGroupBox
        '
        Me.CaseGroupBox.Controls.Add(Me.UpperRadioButton)
        Me.CaseGroupBox.Controls.Add(Me.LowerRadioButton)
        Me.CaseGroupBox.Location = New System.Drawing.Point(93, 129)
        Me.CaseGroupBox.Name = "CaseGroupBox"
        Me.CaseGroupBox.Size = New System.Drawing.Size(148, 102)
        Me.CaseGroupBox.TabIndex = 3
        Me.CaseGroupBox.TabStop = False
        Me.CaseGroupBox.Text = "Case"
        '
        'FormatGroupBox
        '
        Me.FormatGroupBox.Controls.Add(Me.FirstLastRadioButton)
        Me.FormatGroupBox.Controls.Add(Me.LastFirstRadioButton)
        Me.FormatGroupBox.Location = New System.Drawing.Point(248, 129)
        Me.FormatGroupBox.Name = "FormatGroupBox"
        Me.FormatGroupBox.Size = New System.Drawing.Size(148, 102)
        Me.FormatGroupBox.TabIndex = 4
        Me.FormatGroupBox.TabStop = False
        Me.FormatGroupBox.Text = "Format"
        '
        'ReverseCheckBox
        '
        Me.ReverseCheckBox.AutoSize = True
        Me.ReverseCheckBox.Location = New System.Drawing.Point(93, 238)
        Me.ReverseCheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ReverseCheckBox.Name = "ReverseCheckBox"
        Me.ReverseCheckBox.Size = New System.Drawing.Size(94, 24)
        Me.ReverseCheckBox.TabIndex = 5
        Me.ReverseCheckBox.Text = "Reverse"
        Me.ReverseCheckBox.UseVisualStyleBackColor = True
        '
        'WhiteSpaceCheckBox
        '
        Me.WhiteSpaceCheckBox.AutoSize = True
        Me.WhiteSpaceCheckBox.Location = New System.Drawing.Point(93, 274)
        Me.WhiteSpaceCheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WhiteSpaceCheckBox.Name = "WhiteSpaceCheckBox"
        Me.WhiteSpaceCheckBox.Size = New System.Drawing.Size(126, 24)
        Me.WhiteSpaceCheckBox.TabIndex = 6
        Me.WhiteSpaceCheckBox.Text = "White Space"
        Me.WhiteSpaceCheckBox.UseVisualStyleBackColor = True
        '
        'RandomCheckBox
        '
        Me.RandomCheckBox.AutoSize = True
        Me.RandomCheckBox.Location = New System.Drawing.Point(93, 309)
        Me.RandomCheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RandomCheckBox.Name = "RandomCheckBox"
        Me.RandomCheckBox.Size = New System.Drawing.Size(96, 24)
        Me.RandomCheckBox.TabIndex = 7
        Me.RandomCheckBox.Text = "Random"
        Me.RandomCheckBox.UseVisualStyleBackColor = True
        '
        'DataListBox
        '
        Me.DataListBox.FormattingEnabled = True
        Me.DataListBox.ItemHeight = 20
        Me.DataListBox.Location = New System.Drawing.Point(402, 32)
        Me.DataListBox.Name = "DataListBox"
        Me.DataListBox.Size = New System.Drawing.Size(356, 284)
        Me.DataListBox.TabIndex = 11
        Me.DataListBox.TabStop = False
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(254, 346)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(164, 91)
        Me.RemoveButton.TabIndex = 8
        Me.RemoveButton.Text = "&Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'WinFormExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 449)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.DataListBox)
        Me.Controls.Add(Me.RandomCheckBox)
        Me.Controls.Add(Me.WhiteSpaceCheckBox)
        Me.Controls.Add(Me.ReverseCheckBox)
        Me.Controls.Add(Me.FormatGroupBox)
        Me.Controls.Add(Me.CaseGroupBox)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Me.AgeLabel)
        Me.Controls.Add(Me.LastTextBox)
        Me.Controls.Add(Me.LastLabel)
        Me.Controls.Add(Me.FirstTextBox)
        Me.Controls.Add(Me.FirstLabel)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "WinFormExampleForm"
        Me.Text = "Windows Form Example"
        Me.CaseGroupBox.ResumeLayout(False)
        Me.CaseGroupBox.PerformLayout()
        Me.FormatGroupBox.ResumeLayout(False)
        Me.FormatGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents FirstLabel As Label
    Friend WithEvents FirstTextBox As TextBox
    Friend WithEvents LastTextBox As TextBox
    Friend WithEvents LastLabel As Label
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents AgeLabel As Label
    Friend WithEvents UpperRadioButton As RadioButton
    Friend WithEvents LowerRadioButton As RadioButton
    Friend WithEvents FirstLastRadioButton As RadioButton
    Friend WithEvents LastFirstRadioButton As RadioButton
    Friend WithEvents CaseGroupBox As GroupBox
    Friend WithEvents FormatGroupBox As GroupBox
    Friend WithEvents ReverseCheckBox As CheckBox
    Friend WithEvents WhiteSpaceCheckBox As CheckBox
    Friend WithEvents RandomCheckBox As CheckBox
    Friend WithEvents DataListBox As ListBox
    Friend WithEvents RemoveButton As Button
End Class
