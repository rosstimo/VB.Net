Public Class ListsAndListBoxExampleForm
    Private Sub ListsAndListBoxExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        DrawColumns()

    End Sub

    Sub listExample()
        Dim names As New List(Of String)

        names.Add("Bob")
        names.Add("Fred")
        names.Add("Mary")
        names.Add("Jill")
        names.Add("Jim")

        'Console.WriteLine(names.Item(2))
        'Console.WriteLine(names.IndexOf("Mary"))

        For Each Name As String In names
            Console.WriteLine(Name)
        Next

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click, AddToolStripMenuItem.Click
        DisplayListBox.Items.Add(TextBox1.Text)

    End Sub

    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged
        Try
            Me.Text = DisplayListBox.SelectedItem.ToString()
        Catch ex As Exception
            Me.Text = DisplayListBox.SelectedIndex.ToString()
        End Try
    End Sub

    Sub DrawColumns()
        Dim line As String
        For i = 90 To 110
            For j = 990 To 1010
                line &= Str(i).PadLeft(5)
            Next
            'these display different. why??
            DisplayListBox.Items.Add(line)
            Console.WriteLine(line)
            line = ""
        Next

    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click, CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub RemoveContextMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveContextMenuItem.Click
        Try
            DisplayListBox.Items.RemoveAt(DisplayListBox.SelectedIndex())
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ClearAllContextMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllContextMenuItem.Click
        DisplayListBox.Items.Clear()
    End Sub

End Class
