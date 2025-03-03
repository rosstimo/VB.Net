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
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(594, 347)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(163, 91)
        Me.ExitButton.TabIndex = 10
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(425, 347)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(163, 91)
        Me.UpdateButton.TabIndex = 9
        Me.UpdateButton.Text = "&Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'FirstLabel
        '
        Me.FirstLabel.AutoSize = True
        Me.FirstLabel.Location = New System.Drawing.Point(1, 36)
        Me.FirstLabel.Name = "FirstLabel"
        Me.FirstLabel.Size = New System.Drawing.Size(86, 20)
        Me.FirstLabel.TabIndex = 2
        Me.FirstLabel.Text = "First Name"
        '
        'FirstTextBox
        '
        Me.FirstTextBox.Location = New System.Drawing.Point(93, 33)
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
        Me.LastLabel.Location = New System.Drawing.Point(1, 68)
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
        Me.AgeLabel.Location = New System.Drawing.Point(49, 100)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(38, 20)
        Me.AgeLabel.TabIndex = 6
        Me.AgeLabel.Text = "Age"
        '
        'WinFormExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 450)
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
End Class
