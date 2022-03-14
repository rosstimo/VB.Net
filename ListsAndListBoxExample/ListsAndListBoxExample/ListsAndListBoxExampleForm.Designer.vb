<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListsAndListBoxExampleForm
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
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.Location = New System.Drawing.Point(12, 12)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(776, 290)
        Me.DisplayListBox.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(541, 308)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(247, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(640, 374)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(148, 64)
        Me.QuitButton.TabIndex = 2
        Me.QuitButton.Text = "&Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(486, 374)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(148, 64)
        Me.AddButton.TabIndex = 3
        Me.AddButton.Text = "&Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 308)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(216, 20)
        Me.TextBox1.TabIndex = 4
        '
        'ListsAndListBoxExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Name = "ListsAndListBoxExampleForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents QuitButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents TextBox1 As TextBox
End Class
