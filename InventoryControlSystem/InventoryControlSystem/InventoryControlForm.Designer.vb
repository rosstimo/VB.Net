<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryControlForm
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
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.PartNumberLabel = New System.Windows.Forms.Label()
        Me.PartNumberTextBox = New System.Windows.Forms.TextBox()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.VendorLabel = New System.Windows.Forms.Label()
        Me.VendorTextBox = New System.Windows.Forms.TextBox()
        Me.ManufacturerLabel = New System.Windows.Forms.Label()
        Me.ManufacturerTextBox = New System.Windows.Forms.TextBox()
        Me.DataSheetLabel = New System.Windows.Forms.Label()
        Me.DataSheetTextBox = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.ButtonsGroupBox = New System.Windows.Forms.GroupBox()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.OptionsGroupBox = New System.Windows.Forms.GroupBox()
        Me.RecordInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.MainToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ButtonsGroupBox.SuspendLayout()
        Me.OptionsGroupBox.SuspendLayout()
        Me.RecordInfoGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(278, 25)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(130, 51)
        Me.ExitButton.TabIndex = 12
        Me.ExitButton.Text = "E&xit"
        Me.MainToolTip.SetToolTip(Me.ExitButton, "Click here to close")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(142, 25)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(130, 51)
        Me.ClearButton.TabIndex = 11
        Me.ClearButton.Text = "&Clear"
        Me.MainToolTip.SetToolTip(Me.ClearButton, "Click here to clear form")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Location = New System.Drawing.Point(5, 30)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(89, 20)
        Me.DescriptionLabel.TabIndex = 0
        Me.DescriptionLabel.Text = "Description"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(125, 30)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(187, 26)
        Me.DescriptionTextBox.TabIndex = 0
        '
        'PartNumberLabel
        '
        Me.PartNumberLabel.AutoSize = True
        Me.PartNumberLabel.Location = New System.Drawing.Point(5, 60)
        Me.PartNumberLabel.Name = "PartNumberLabel"
        Me.PartNumberLabel.Size = New System.Drawing.Size(51, 20)
        Me.PartNumberLabel.TabIndex = 1
        Me.PartNumberLabel.Text = "Part #"
        '
        'PartNumberTextBox
        '
        Me.PartNumberTextBox.Location = New System.Drawing.Point(125, 60)
        Me.PartNumberTextBox.Name = "PartNumberTextBox"
        Me.PartNumberTextBox.Size = New System.Drawing.Size(187, 26)
        Me.PartNumberTextBox.TabIndex = 1
        '
        'LocationLabel
        '
        Me.LocationLabel.AutoSize = True
        Me.LocationLabel.Location = New System.Drawing.Point(5, 90)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(70, 20)
        Me.LocationLabel.TabIndex = 2
        Me.LocationLabel.Text = "Location"
        '
        'LocationTextBox
        '
        Me.LocationTextBox.Location = New System.Drawing.Point(125, 90)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(187, 26)
        Me.LocationTextBox.TabIndex = 2
        '
        'VendorLabel
        '
        Me.VendorLabel.AutoSize = True
        Me.VendorLabel.Location = New System.Drawing.Point(5, 120)
        Me.VendorLabel.Name = "VendorLabel"
        Me.VendorLabel.Size = New System.Drawing.Size(61, 20)
        Me.VendorLabel.TabIndex = 3
        Me.VendorLabel.Text = "Vendor"
        '
        'VendorTextBox
        '
        Me.VendorTextBox.Location = New System.Drawing.Point(125, 120)
        Me.VendorTextBox.Name = "VendorTextBox"
        Me.VendorTextBox.Size = New System.Drawing.Size(187, 26)
        Me.VendorTextBox.TabIndex = 3
        '
        'ManufacturerLabel
        '
        Me.ManufacturerLabel.AutoSize = True
        Me.ManufacturerLabel.Location = New System.Drawing.Point(5, 150)
        Me.ManufacturerLabel.Name = "ManufacturerLabel"
        Me.ManufacturerLabel.Size = New System.Drawing.Size(104, 20)
        Me.ManufacturerLabel.TabIndex = 4
        Me.ManufacturerLabel.Text = "Manufacturer"
        '
        'ManufacturerTextBox
        '
        Me.ManufacturerTextBox.Location = New System.Drawing.Point(125, 150)
        Me.ManufacturerTextBox.Name = "ManufacturerTextBox"
        Me.ManufacturerTextBox.Size = New System.Drawing.Size(187, 26)
        Me.ManufacturerTextBox.TabIndex = 4
        '
        'DataSheetLabel
        '
        Me.DataSheetLabel.AutoSize = True
        Me.DataSheetLabel.Location = New System.Drawing.Point(5, 180)
        Me.DataSheetLabel.Name = "DataSheetLabel"
        Me.DataSheetLabel.Size = New System.Drawing.Size(87, 20)
        Me.DataSheetLabel.TabIndex = 5
        Me.DataSheetLabel.Text = "DataSheet"
        '
        'DataSheetTextBox
        '
        Me.DataSheetTextBox.Location = New System.Drawing.Point(125, 180)
        Me.DataSheetTextBox.Name = "DataSheetTextBox"
        Me.DataSheetTextBox.Size = New System.Drawing.Size(187, 26)
        Me.DataSheetTextBox.TabIndex = 5
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 25)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(116, 24)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(6, 56)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(116, 24)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(6, 89)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(116, 24)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 119)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(133, 24)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(6, 149)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(133, 24)
        Me.RadioButton5.TabIndex = 3
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "RadioButton5"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(6, 179)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(133, 24)
        Me.RadioButton6.TabIndex = 3
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "RadioButton6"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'ButtonsGroupBox
        '
        Me.ButtonsGroupBox.Controls.Add(Me.UpdateButton)
        Me.ButtonsGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonsGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonsGroupBox.Location = New System.Drawing.Point(372, 341)
        Me.ButtonsGroupBox.Name = "ButtonsGroupBox"
        Me.ButtonsGroupBox.Size = New System.Drawing.Size(418, 97)
        Me.ButtonsGroupBox.TabIndex = 2
        Me.ButtonsGroupBox.TabStop = False
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(6, 25)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(130, 51)
        Me.UpdateButton.TabIndex = 13
        Me.UpdateButton.Text = "&Update"
        Me.MainToolTip.SetToolTip(Me.UpdateButton, "Click here to clear form")
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'OptionsGroupBox
        '
        Me.OptionsGroupBox.Controls.Add(Me.CheckBox1)
        Me.OptionsGroupBox.Controls.Add(Me.CheckBox2)
        Me.OptionsGroupBox.Controls.Add(Me.RadioButton6)
        Me.OptionsGroupBox.Controls.Add(Me.CheckBox3)
        Me.OptionsGroupBox.Controls.Add(Me.RadioButton5)
        Me.OptionsGroupBox.Controls.Add(Me.RadioButton4)
        Me.OptionsGroupBox.Location = New System.Drawing.Point(372, 12)
        Me.OptionsGroupBox.Name = "OptionsGroupBox"
        Me.OptionsGroupBox.Size = New System.Drawing.Size(416, 323)
        Me.OptionsGroupBox.TabIndex = 1
        Me.OptionsGroupBox.TabStop = False
        Me.OptionsGroupBox.Text = "Options"
        '
        'RecordInfoGroupBox
        '
        Me.RecordInfoGroupBox.Controls.Add(Me.DataSheetLabel)
        Me.RecordInfoGroupBox.Controls.Add(Me.ManufacturerLabel)
        Me.RecordInfoGroupBox.Controls.Add(Me.VendorLabel)
        Me.RecordInfoGroupBox.Controls.Add(Me.LocationLabel)
        Me.RecordInfoGroupBox.Controls.Add(Me.PartNumberLabel)
        Me.RecordInfoGroupBox.Controls.Add(Me.DescriptionLabel)
        Me.RecordInfoGroupBox.Controls.Add(Me.DescriptionTextBox)
        Me.RecordInfoGroupBox.Controls.Add(Me.PartNumberTextBox)
        Me.RecordInfoGroupBox.Controls.Add(Me.LocationTextBox)
        Me.RecordInfoGroupBox.Controls.Add(Me.VendorTextBox)
        Me.RecordInfoGroupBox.Controls.Add(Me.ManufacturerTextBox)
        Me.RecordInfoGroupBox.Controls.Add(Me.DataSheetTextBox)
        Me.RecordInfoGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.RecordInfoGroupBox.Name = "RecordInfoGroupBox"
        Me.RecordInfoGroupBox.Size = New System.Drawing.Size(338, 323)
        Me.RecordInfoGroupBox.TabIndex = 0
        Me.RecordInfoGroupBox.TabStop = False
        Me.RecordInfoGroupBox.Text = "Record Info"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'InventoryControlForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RecordInfoGroupBox)
        Me.Controls.Add(Me.OptionsGroupBox)
        Me.Controls.Add(Me.ButtonsGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "InventoryControlForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parts Inventory"
        Me.ButtonsGroupBox.ResumeLayout(False)
        Me.OptionsGroupBox.ResumeLayout(False)
        Me.OptionsGroupBox.PerformLayout()
        Me.RecordInfoGroupBox.ResumeLayout(False)
        Me.RecordInfoGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents PartNumberTextBox As TextBox
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents VendorTextBox As TextBox
    Friend WithEvents ManufacturerTextBox As TextBox
    Friend WithEvents DataSheetTextBox As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents ButtonsGroupBox As GroupBox
    Friend WithEvents OptionsGroupBox As GroupBox
    Friend WithEvents RecordInfoGroupBox As GroupBox
    Friend WithEvents DataSheetLabel As Label
    Friend WithEvents ManufacturerLabel As Label
    Friend WithEvents VendorLabel As Label
    Friend WithEvents LocationLabel As Label
    Friend WithEvents PartNumberLabel As Label
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents MainToolTip As ToolTip
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents UpdateButton As Button
End Class
