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

    Private Function ValidateUserInput() As Boolean
        Dim valid As Boolean = True
        Dim message As String
        'If DataSheetTextBox.Text = "" Then
        '    MsgBox("DataSheet is required")
        '    DataSheetTextBox.Focus()
        'End If

        'If ManufacturerTextBox.Text = "" Then
        '    MsgBox("Manufacturer is required")
        '    ManufacturerTextBox.Focus()
        'End If

        'If VendorTextBox.Text = "" Then
        '    MsgBox("Vendor is required")
        '    VendorTextBox.Focus()
        'End If

        For Each thingy As TextBox In RecordInfoGroupBox.Controls.OfType(Of TextBox)()
            MsgBox(thingy.ToString)
            If valid Then
                thingy.Focus()
            End If
            If thingy.Text = "" Then
                valid = False
                message &= $"{thingy.Name} is required{vbCrLf}"
            End If

        Next
        MsgBox(message)
        Return False
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
