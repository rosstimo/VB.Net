<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileIOForm
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ReadFileButton = New System.Windows.Forms.Button()
        Me.AppendFileButton = New System.Windows.Forms.Button()
        Me.OverWriteButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.SaveFileButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(218, 51)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(359, 277)
        Me.ListBox1.TabIndex = 0
        '
        'ReadFileButton
        '
        Me.ReadFileButton.Location = New System.Drawing.Point(130, 383)
        Me.ReadFileButton.Name = "ReadFileButton"
        Me.ReadFileButton.Size = New System.Drawing.Size(112, 55)
        Me.ReadFileButton.TabIndex = 1
        Me.ReadFileButton.Text = "Read File"
        Me.ReadFileButton.UseVisualStyleBackColor = True
        '
        'AppendFileButton
        '
        Me.AppendFileButton.Location = New System.Drawing.Point(248, 383)
        Me.AppendFileButton.Name = "AppendFileButton"
        Me.AppendFileButton.Size = New System.Drawing.Size(112, 55)
        Me.AppendFileButton.TabIndex = 2
        Me.AppendFileButton.Text = "Append File"
        Me.AppendFileButton.UseVisualStyleBackColor = True
        '
        'OverWriteButton
        '
        Me.OverWriteButton.Location = New System.Drawing.Point(366, 383)
        Me.OverWriteButton.Name = "OverWriteButton"
        Me.OverWriteButton.Size = New System.Drawing.Size(112, 55)
        Me.OverWriteButton.TabIndex = 3
        Me.OverWriteButton.Text = "Write File"
        Me.OverWriteButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(484, 383)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(112, 55)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(6, 29)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(170, 20)
        Me.FirstNameTextBox.TabIndex = 5
        Me.FirstNameTextBox.Text = "First"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(6, 55)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(170, 20)
        Me.LastNameTextBox.TabIndex = 6
        Me.LastNameTextBox.Text = "Last"
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(6, 107)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(41, 20)
        Me.StateTextBox.TabIndex = 8
        Me.StateTextBox.Text = "State"
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(6, 133)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(72, 20)
        Me.ZipTextBox.TabIndex = 9
        Me.ZipTextBox.Text = "Zip"
        '
        'SaveFileButton
        '
        Me.SaveFileButton.Location = New System.Drawing.Point(12, 383)
        Me.SaveFileButton.Name = "SaveFileButton"
        Me.SaveFileButton.Size = New System.Drawing.Size(112, 55)
        Me.SaveFileButton.TabIndex = 10
        Me.SaveFileButton.Text = "Save File"
        Me.SaveFileButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.emailTextBox)
        Me.GroupBox1.Controls.Add(Me.ZipTextBox)
        Me.GroupBox1.Controls.Add(Me.StateTextBox)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox1.Controls.Add(Me.CityTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 208)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'emailTextBox
        '
        Me.emailTextBox.Location = New System.Drawing.Point(6, 159)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(72, 20)
        Me.emailTextBox.TabIndex = 10
        Me.emailTextBox.Text = "email"
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(6, 81)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(170, 20)
        Me.CityTextBox.TabIndex = 7
        Me.CityTextBox.Text = "City"
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(12, 273)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(112, 55)
        Me.UpdateButton.TabIndex = 12
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(616, 24)
        Me.TopMenuStrip.TabIndex = 13
        Me.TopMenuStrip.Text = "TopMenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripTopMenuItem, Me.SaveToolStripTopMenuItem, Me.SaveAsToolStripTopMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenToolStripTopMenuItem
        '
        Me.OpenToolStripTopMenuItem.Name = "OpenToolStripTopMenuItem"
        Me.OpenToolStripTopMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.OpenToolStripTopMenuItem.Text = "&Open"
        '
        'SaveToolStripTopMenuItem
        '
        Me.SaveToolStripTopMenuItem.Name = "SaveToolStripTopMenuItem"
        Me.SaveToolStripTopMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SaveToolStripTopMenuItem.Text = "&Save"
        '
        'SaveAsToolStripTopMenuItem
        '
        Me.SaveAsToolStripTopMenuItem.Name = "SaveAsToolStripTopMenuItem"
        Me.SaveAsToolStripTopMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SaveAsToolStripTopMenuItem.Text = "Save &As"
        '
        'FileIOForm
        '
        Me.AcceptButton = Me.UpdateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(616, 450)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SaveFileButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.OverWriteButton)
        Me.Controls.Add(Me.AppendFileButton)
        Me.Controls.Add(Me.ReadFileButton)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "FileIOForm"
        Me.Text = "`File Stuff"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ReadFileButton As Button
    Friend WithEvents AppendFileButton As Button
    Friend WithEvents OverWriteButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents SaveFileButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents UpdateButton As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripTopMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripTopMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripTopMenuItem As ToolStripMenuItem
End Class
