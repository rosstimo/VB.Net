<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Me.AboutLabel = New System.Windows.Forms.Label()
        Me.AboutOKButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AboutLabel
        '
        Me.AboutLabel.Location = New System.Drawing.Point(11, 9)
        Me.AboutLabel.Name = "AboutLabel"
        Me.AboutLabel.Size = New System.Drawing.Size(374, 158)
        Me.AboutLabel.TabIndex = 0
        Me.AboutLabel.Text = "ISU Crayon Application" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tim Rossiter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ACME Software LLC." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Spring 2025"
        '
        'AboutOKButton
        '
        Me.AboutOKButton.Location = New System.Drawing.Point(310, 189)
        Me.AboutOKButton.Name = "AboutOKButton"
        Me.AboutOKButton.Size = New System.Drawing.Size(75, 23)
        Me.AboutOKButton.TabIndex = 1
        Me.AboutOKButton.Text = "&OK"
        Me.AboutOKButton.UseVisualStyleBackColor = True
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 224)
        Me.Controls.Add(Me.AboutOKButton)
        Me.Controls.Add(Me.AboutLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AboutForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About ISU Crayon"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AboutLabel As Label
    Friend WithEvents AboutOKButton As Button
End Class
