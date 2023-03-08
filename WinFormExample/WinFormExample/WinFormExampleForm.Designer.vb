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
        Me.GoButton = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FIleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(858, 460)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(249, 128)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip.SetToolTip(Me.ExitButton, "Click here to quit")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(18, 460)
        Me.GoButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(249, 128)
        Me.GoButton.TabIndex = 4
        Me.GoButton.Text = "&Go"
        Me.ToolTip.SetToolTip(Me.GoButton, "Click to submit")
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(26, 54)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(51, 20)
        Me.NameLabel.TabIndex = 2
        Me.NameLabel.Text = "Name"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(87, 49)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(354, 26)
        Me.NameTextBox.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.NameTextBox, "Enter Name Here")
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(87, 89)
        Me.AgeTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(354, 26)
        Me.AgeTextBox.TabIndex = 1
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(26, 94)
        Me.AgeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(38, 20)
        Me.AgeLabel.TabIndex = 4
        Me.AgeLabel.Text = "Age"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(87, 129)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(133, 24)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(87, 165)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(133, 24)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(231, 131)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(116, 24)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(231, 166)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(116, 24)
        Me.CheckBox2.TabIndex = 4
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StateTextBox)
        Me.GroupBox1.Controls.Add(Me.StateLabel)
        Me.GroupBox1.Controls.Add(Me.CityTextBox)
        Me.GroupBox1.Controls.Add(Me.CityLabel)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 199)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(474, 225)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.ToolTip.SetToolTip(Me.GroupBox1, "Location Info")
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(81, 69)
        Me.StateTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(354, 26)
        Me.StateTextBox.TabIndex = 1
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(20, 74)
        Me.StateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(48, 20)
        Me.StateLabel.TabIndex = 16
        Me.StateLabel.Text = "State"
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(81, 29)
        Me.CityTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(354, 26)
        Me.CityTextBox.TabIndex = 0
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(20, 34)
        Me.CityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(35, 20)
        Me.CityLabel.TabIndex = 14
        Me.CityLabel.Text = "City"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(183, 182)
        Me.CheckBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(116, 24)
        Me.CheckBox3.TabIndex = 4
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(183, 146)
        Me.CheckBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(116, 24)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "CheckBox4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(39, 180)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(133, 24)
        Me.RadioButton3.TabIndex = 10
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(39, 145)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(133, 24)
        Me.RadioButton4.TabIndex = 2
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton9)
        Me.GroupBox2.Controls.Add(Me.RadioButton10)
        Me.GroupBox2.Controls.Add(Me.RadioButton7)
        Me.GroupBox2.Controls.Add(Me.RadioButton8)
        Me.GroupBox2.Controls.Add(Me.RadioButton5)
        Me.GroupBox2.Controls.Add(Me.RadioButton6)
        Me.GroupBox2.Location = New System.Drawing.Point(501, 49)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(180, 377)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.ToolTip.SetToolTip(Me.GroupBox2, "Select Image")
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(9, 215)
        Me.RadioButton9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(133, 24)
        Me.RadioButton9.TabIndex = 14
        Me.RadioButton9.Text = "RadioButton9"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(9, 180)
        Me.RadioButton10.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(142, 24)
        Me.RadioButton10.TabIndex = 13
        Me.RadioButton10.Text = "RadioButton10"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(9, 145)
        Me.RadioButton7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(133, 24)
        Me.RadioButton7.TabIndex = 12
        Me.RadioButton7.Text = "RadioButton7"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(9, 109)
        Me.RadioButton8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(133, 24)
        Me.RadioButton8.TabIndex = 11
        Me.RadioButton8.Text = "RadioButton8"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(9, 74)
        Me.RadioButton5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(133, 24)
        Me.RadioButton5.TabIndex = 10
        Me.RadioButton5.Text = "RadioButton5"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(9, 38)
        Me.RadioButton6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(133, 24)
        Me.RadioButton6.TabIndex = 9
        Me.RadioButton6.Text = "RadioButton6"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WinFormExample.My.Resources.Resources.img_BLOG___Found_Kittens_C_19__4_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(690, 54)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(417, 372)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        Me.ToolTip.SetToolTip(Me.PictureBox1, "image display")
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIleToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(1140, 33)
        Me.TopMenuStrip.TabIndex = 9
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FIleToolStripMenuItem
        '
        Me.FIleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FIleToolStripMenuItem.Name = "FIleToolStripMenuItem"
        Me.FIleToolStripMenuItem.Size = New System.Drawing.Size(55, 29)
        Me.FIleToolStripMenuItem.Text = "&FIle"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(58, 29)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'GoToolStripMenuItem
        '
        Me.GoToolStripMenuItem.Name = "GoToolStripMenuItem"
        Me.GoToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.GoToolStripMenuItem.Text = "&Go"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'WinFormExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 606)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Me.AgeLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "WinFormExampleForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hello"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents GoButton As Button
    Friend WithEvents NameLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents AgeLabel As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents StateLabel As Label
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents CityLabel As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FIleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
