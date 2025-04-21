<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuperVideoStopForm
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
        Me.InfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.ButtonsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DataGroupBox = New System.Windows.Forms.GroupBox()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.SelectComboBox = New System.Windows.Forms.ComboBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.LastLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.StreetLabel = New System.Windows.Forms.Label()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIDLabel = New System.Windows.Forms.Label()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.InfoGroupBox.SuspendLayout()
        Me.ButtonsGroupBox.SuspendLayout()
        Me.DataGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'InfoGroupBox
        '
        Me.InfoGroupBox.Controls.Add(Me.CustomerIDLabel)
        Me.InfoGroupBox.Controls.Add(Me.CustomerIDTextBox)
        Me.InfoGroupBox.Controls.Add(Me.EmailLabel)
        Me.InfoGroupBox.Controls.Add(Me.EmailTextBox)
        Me.InfoGroupBox.Controls.Add(Me.PhoneLabel)
        Me.InfoGroupBox.Controls.Add(Me.PhoneTextBox)
        Me.InfoGroupBox.Controls.Add(Me.ZipLabel)
        Me.InfoGroupBox.Controls.Add(Me.ZipTextBox)
        Me.InfoGroupBox.Controls.Add(Me.StateLabel)
        Me.InfoGroupBox.Controls.Add(Me.StateTextBox)
        Me.InfoGroupBox.Controls.Add(Me.CityLabel)
        Me.InfoGroupBox.Controls.Add(Me.CityTextBox)
        Me.InfoGroupBox.Controls.Add(Me.StreetLabel)
        Me.InfoGroupBox.Controls.Add(Me.StreetTextBox)
        Me.InfoGroupBox.Controls.Add(Me.LastLabel)
        Me.InfoGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.InfoGroupBox.Controls.Add(Me.FirstNameLabel)
        Me.InfoGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.InfoGroupBox.Location = New System.Drawing.Point(37, 28)
        Me.InfoGroupBox.Name = "InfoGroupBox"
        Me.InfoGroupBox.Size = New System.Drawing.Size(491, 441)
        Me.InfoGroupBox.TabIndex = 0
        Me.InfoGroupBox.TabStop = False
        '
        'ButtonsGroupBox
        '
        Me.ButtonsGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonsGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonsGroupBox.Controls.Add(Me.UpdateButton)
        Me.ButtonsGroupBox.Location = New System.Drawing.Point(37, 475)
        Me.ButtonsGroupBox.Name = "ButtonsGroupBox"
        Me.ButtonsGroupBox.Size = New System.Drawing.Size(1229, 177)
        Me.ButtonsGroupBox.TabIndex = 1
        Me.ButtonsGroupBox.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(1062, 48)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(161, 105)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(895, 48)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(161, 105)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(728, 48)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(161, 105)
        Me.UpdateButton.TabIndex = 0
        Me.UpdateButton.Text = "&Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'DataGroupBox
        '
        Me.DataGroupBox.Controls.Add(Me.SearchButton)
        Me.DataGroupBox.Controls.Add(Me.SearchTextBox)
        Me.DataGroupBox.Controls.Add(Me.RadioButton2)
        Me.DataGroupBox.Controls.Add(Me.RadioButton1)
        Me.DataGroupBox.Controls.Add(Me.DisplayListBox)
        Me.DataGroupBox.Controls.Add(Me.SelectComboBox)
        Me.DataGroupBox.Location = New System.Drawing.Point(534, 28)
        Me.DataGroupBox.Name = "DataGroupBox"
        Me.DataGroupBox.Size = New System.Drawing.Size(732, 441)
        Me.DataGroupBox.TabIndex = 2
        Me.DataGroupBox.TabStop = False
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 20
        Me.DisplayListBox.Location = New System.Drawing.Point(211, 57)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(515, 364)
        Me.DisplayListBox.TabIndex = 1
        '
        'SelectComboBox
        '
        Me.SelectComboBox.FormattingEnabled = True
        Me.SelectComboBox.Location = New System.Drawing.Point(211, 25)
        Me.SelectComboBox.Name = "SelectComboBox"
        Me.SelectComboBox.Size = New System.Drawing.Size(294, 28)
        Me.SelectComboBox.TabIndex = 0
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(119, 32)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(340, 26)
        Me.FirstNameTextBox.TabIndex = 0
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(18, 38)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(40, 20)
        Me.FirstNameLabel.TabIndex = 1
        Me.FirstNameLabel.Text = "First"
        '
        'LastLabel
        '
        Me.LastLabel.AutoSize = True
        Me.LastLabel.Location = New System.Drawing.Point(18, 70)
        Me.LastLabel.Name = "LastLabel"
        Me.LastLabel.Size = New System.Drawing.Size(40, 20)
        Me.LastLabel.TabIndex = 3
        Me.LastLabel.Text = "Last"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(119, 64)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(340, 26)
        Me.LastNameTextBox.TabIndex = 2
        '
        'StreetLabel
        '
        Me.StreetLabel.AutoSize = True
        Me.StreetLabel.Location = New System.Drawing.Point(18, 102)
        Me.StreetLabel.Name = "StreetLabel"
        Me.StreetLabel.Size = New System.Drawing.Size(53, 20)
        Me.StreetLabel.TabIndex = 5
        Me.StreetLabel.Text = "Street"
        '
        'StreetTextBox
        '
        Me.StreetTextBox.Location = New System.Drawing.Point(119, 96)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(340, 26)
        Me.StreetTextBox.TabIndex = 4
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(18, 134)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(35, 20)
        Me.CityLabel.TabIndex = 7
        Me.CityLabel.Text = "City"
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(119, 128)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(340, 26)
        Me.CityTextBox.TabIndex = 6
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(18, 166)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(48, 20)
        Me.StateLabel.TabIndex = 9
        Me.StateLabel.Text = "State"
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(119, 160)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(340, 26)
        Me.StateTextBox.TabIndex = 8
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Location = New System.Drawing.Point(18, 198)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(31, 20)
        Me.ZipLabel.TabIndex = 11
        Me.ZipLabel.Text = "Zip"
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(119, 192)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(340, 26)
        Me.ZipTextBox.TabIndex = 10
        '
        'PhoneLabel
        '
        Me.PhoneLabel.AutoSize = True
        Me.PhoneLabel.Location = New System.Drawing.Point(18, 230)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(55, 20)
        Me.PhoneLabel.TabIndex = 13
        Me.PhoneLabel.Text = "Phone"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(119, 224)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(340, 26)
        Me.PhoneTextBox.TabIndex = 12
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(18, 262)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(48, 20)
        Me.EmailLabel.TabIndex = 15
        Me.EmailLabel.Text = "Email"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(119, 256)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(340, 26)
        Me.EmailTextBox.TabIndex = 14
        '
        'CustomerIDLabel
        '
        Me.CustomerIDLabel.AutoSize = True
        Me.CustomerIDLabel.Location = New System.Drawing.Point(18, 294)
        Me.CustomerIDLabel.Name = "CustomerIDLabel"
        Me.CustomerIDLabel.Size = New System.Drawing.Size(99, 20)
        Me.CustomerIDLabel.TabIndex = 17
        Me.CustomerIDLabel.Text = "Customer ID"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(119, 288)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(340, 26)
        Me.CustomerIDTextBox.TabIndex = 16
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(24, 59)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(133, 24)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(24, 89)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(133, 24)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(511, 25)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(166, 26)
        Me.SearchTextBox.TabIndex = 18
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(683, 25)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(43, 26)
        Me.SearchButton.TabIndex = 3
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'SuperVideoStopForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 664)
        Me.Controls.Add(Me.DataGroupBox)
        Me.Controls.Add(Me.ButtonsGroupBox)
        Me.Controls.Add(Me.InfoGroupBox)
        Me.Name = "SuperVideoStopForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Super Video Stop"
        Me.InfoGroupBox.ResumeLayout(False)
        Me.InfoGroupBox.PerformLayout()
        Me.ButtonsGroupBox.ResumeLayout(False)
        Me.DataGroupBox.ResumeLayout(False)
        Me.DataGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InfoGroupBox As GroupBox
    Friend WithEvents ButtonsGroupBox As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DataGroupBox As GroupBox
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents SelectComboBox As ComboBox
    Friend WithEvents CustomerIDLabel As Label
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PhoneLabel As Label
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents ZipLabel As Label
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents StateLabel As Label
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents CityLabel As Label
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StreetLabel As Label
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents LastLabel As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents SearchButton As Button
    Friend WithEvents SearchTextBox As TextBox
End Class
