Public Class InventoryControlForm
    Sub SetDefaults()
        RadioButton4.Checked = True
    End Sub

    Private Sub LoadInventoryFile()
        Dim fileName As String = "partsInventory.txt"
        Dim fileNumber As Integer = FreeFile()

        Try
            FileOpen(fileNumber, fileName, OpenMode.Input)

        Catch ioException As IO.IOException
            With OpenFileDialog
                .Title = "Open File"
                .InitialDirectory = "..\..\"
                .FileName = ""
                .Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
                .FilterIndex = 1
                .RestoreDirectory = True
                .ShowDialog()
            End With
        Catch ex As Exception



        End Try



    End Sub

    Private Function ValidateUserInput(Optional ByRef message As String = "") As Boolean
        Dim isValid As Boolean = True

        For Each _TextBox As TextBox In RecordInfoGroupBox.Controls.OfType(Of TextBox)()
            If isValid Then
                _TextBox.Focus()
            End If
            If _TextBox.Text = "" Then
                isValid = False
                message &= Replace($"{_TextBox.Name} is required{vbCrLf}", "TextBox", "")
            End If
        Next
        'MsgBox(message)
        Return isValid
    End Function

    ' Event Handlers Below
    Private Sub InventoryControlForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
        LoadInventoryFile()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        ValidateUserInput()
    End Sub
End Class
