'TODO 
'[ ] Add record
'[ ] Remove Record
'[ ] Update Record
Public Class InventoryControlForm

    Private inventoryItems As New List(Of String)
    Private fileName As String = "..\..\partsInventory.txt"

    Sub SetDefaults()
        RadioButton4.Checked = True
    End Sub

    Private Sub LoadInventoryFile()
        'Dim fileName As String = "..\..\partsInventory.txt"
        Dim fileNumber As Integer = FreeFile()
        Dim currentField As String = ""
        Dim currentRecord As String = ""

        Try
            FileOpen(fileNumber, Me.fileName, OpenMode.Input)
            Do Until EOF(fileNumber)
                For i = 0 To 6
                    Input(fileNumber, currentField)
                    currentRecord &= currentField & ","
                Next
                Me.inventoryItems.Add(currentRecord)
                currentRecord = ""
            Loop

        Catch ioException As IO.IOException
            With OpenFileDialog
                .Title = "Open File"
                .InitialDirectory = "..\..\"
                .FileName = ""
                .Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
                .FilterIndex = 1
                .RestoreDirectory = True
                .ShowDialog()
                'TODO check if user clicks OK or Cancel
                'then if OK update me.fileName
                Me.fileName = .FileName
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
        If ValidateUserInput() Then
            inventoryItems.Add($"{"12345"},{DescriptionTextBox.Text},{PartNumberTextBox.Text},{LocationTextBox.Text},{VendorTextBox.Text},{ManufacturerTextBox.Text},{DataSheetTextBox.Text}")
            'TODO add record to file
            'back up file first use of the day
            'work with new file or temp file
            '
        End If
    End Sub
End Class
