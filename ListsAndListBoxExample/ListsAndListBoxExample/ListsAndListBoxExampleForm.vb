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

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        DisplayListBox.Items.Add(TextBox1.Text)

    End Sub

    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged
        Me.Text = DisplayListBox.SelectedItem.ToString()
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
End Class
