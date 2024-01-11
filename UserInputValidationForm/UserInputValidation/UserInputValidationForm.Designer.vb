<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserInputValidationForm
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
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.ResultLabel = New System.Windows.Forms.Label()
        Me.ButtonGroupBox = New System.Windows.Forms.GroupBox()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.InputGroupBox.SuspendLayout()
        Me.OutputGroupBox.SuspendLayout()
        Me.ButtonGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.Location = New System.Drawing.Point(16, 20)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(35, 14)
        Me.FirstNameLabel.TabIndex = 0
        Me.FirstNameLabel.Text = "First"
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(384, 19)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(120, 74)
        Me.QuitButton.TabIndex = 1
        Me.QuitButton.Text = "E&xit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(57, 20)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(169, 20)
        Me.FirstNameTextBox.TabIndex = 2
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Controls.Add(Me.AgeLabel)
        Me.InputGroupBox.Controls.Add(Me.AgeTextBox)
        Me.InputGroupBox.Controls.Add(Me.LastNameLabel)
        Me.InputGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.InputGroupBox.Controls.Add(Me.FirstNameLabel)
        Me.InputGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.InputGroupBox.Location = New System.Drawing.Point(13, 35)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(282, 227)
        Me.InputGroupBox.TabIndex = 0
        Me.InputGroupBox.TabStop = False
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(16, 72)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(26, 13)
        Me.AgeLabel.TabIndex = 5
        Me.AgeLabel.Text = "Age"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(57, 72)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(169, 20)
        Me.AgeTextBox.TabIndex = 6
        '
        'LastNameLabel
        '
        Me.LastNameLabel.Location = New System.Drawing.Point(16, 46)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(35, 17)
        Me.LastNameLabel.TabIndex = 3
        Me.LastNameLabel.Text = "Last"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(57, 46)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(169, 20)
        Me.LastNameTextBox.TabIndex = 4
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.Controls.Add(Me.ResultLabel)
        Me.OutputGroupBox.Location = New System.Drawing.Point(301, 35)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Size = New System.Drawing.Size(226, 227)
        Me.OutputGroupBox.TabIndex = 4
        Me.OutputGroupBox.TabStop = False
        '
        'ResultLabel
        '
        Me.ResultLabel.Location = New System.Drawing.Point(6, 16)
        Me.ResultLabel.Name = "ResultLabel"
        Me.ResultLabel.Size = New System.Drawing.Size(209, 197)
        Me.ResultLabel.TabIndex = 6
        Me.ResultLabel.Text = "Result"
        '
        'ButtonGroupBox
        '
        Me.ButtonGroupBox.Controls.Add(Me.SummaryButton)
        Me.ButtonGroupBox.Controls.Add(Me.SubmitButton)
        Me.ButtonGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonGroupBox.Controls.Add(Me.QuitButton)
        Me.ButtonGroupBox.Location = New System.Drawing.Point(12, 268)
        Me.ButtonGroupBox.Name = "ButtonGroupBox"
        Me.ButtonGroupBox.Size = New System.Drawing.Size(515, 108)
        Me.ButtonGroupBox.TabIndex = 0
        Me.ButtonGroupBox.TabStop = False
        '
        'SummaryButton
        '
        Me.SummaryButton.Enabled = False
        Me.SummaryButton.Location = New System.Drawing.Point(132, 19)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(120, 74)
        Me.SummaryButton.TabIndex = 4
        Me.SummaryButton.Text = "&Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(6, 19)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(120, 74)
        Me.SubmitButton.TabIndex = 3
        Me.SubmitButton.Text = "S&ubmit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(258, 19)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(120, 74)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'UserInputValidationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 388)
        Me.Controls.Add(Me.ButtonGroupBox)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Name = "UserInputValidationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Validation"
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.OutputGroupBox.ResumeLayout(False)
        Me.ButtonGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents QuitButton As Button
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents InputGroupBox As GroupBox
    Friend WithEvents AgeLabel As Label
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents OutputGroupBox As GroupBox
    Friend WithEvents ResultLabel As Label
    Friend WithEvents ButtonGroupBox As GroupBox
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SummaryButton As Button
End Class
