Public Class WinFormExampleForm

    'TODO
    ' [ ] add textbox.text to listbox/combobox
    ' [ ] remove item
    ' [ ] sycnronize listbox/combobox content
    ' [ ] syncronized list/combobox selextions


    Sub GetSelection()
        'Try
        If MainListBox.SelectedItem IsNot Nothing Then
            OutputTextBox.Text = MainListBox.SelectedItem.ToString
        End If

        'Catch ex As Exception

        ' End Try

    End Sub

    ' Event handlers below here
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click,
                                                                           ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ActionButton_Click(sender As Object, e As EventArgs) Handles ActionButton.Click,
                                                                             ActionToolStripMenuItem.Click,
                                                                             ActionContextMenuItem.Click

        MainListBox.Items.Add(ExampleTextBox.Text)
        MainComboBox.Items.Add(ExampleTextBox.Text)
        ExampleTextBox.Text = ""


    End Sub

    Private Sub WinFormExampleForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        RadioButton1.Checked = True
    End Sub

    Private Sub MainListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MainListBox.SelectedIndexChanged
        ' Me.Text = MainListBox.SelectedIndex.ToString
        MainComboBox.SelectedIndex = MainListBox.SelectedIndex
        GetSelection()

    End Sub

    Private Sub MainComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MainComboBox.SelectedIndexChanged
        MainListBox.SelectedIndex = MainComboBox.SelectedIndex
        GetSelection()
        ' Console.WriteLine("hit")
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click,
                                                                            ClearToolStripMenuItem.Click,
                                                                            ClearContextMenuItem.Click
        MainListBox.Items.Clear()
        Dim _index As Integer = MainListBox.SelectedIndex
        MainListBox.Items.RemoveAt(_index)
        MainComboBox.Items.RemoveAt(_index)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        AboutForm.Show()
    End Sub
End Class
