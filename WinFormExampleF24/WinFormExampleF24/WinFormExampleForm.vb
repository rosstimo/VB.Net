Public Class WinFormExampleForm

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ActionButton_Click(sender As Object, e As EventArgs) Handles ActionButton.Click
        Dim names As New List(Of String)

        Me.Text = ExampleTextBox.Text

        names.Add("Jimmy")
        names.Add("Mary")
        names.Add("Bill")
        names.Add("Bob")

        'For Each _name In names
        '    Console.WriteLine(_name)
        'Next

        Console.WriteLine(names.IndexOf("Bill"))
        Console.WriteLine(names.Item(1))



        names.Remove("Bill")

        Console.Read()

    End Sub

    Private Sub WinFormExampleForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        RadioButton1.Checked = True
    End Sub
End Class
