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

    ' Event Handlers Below
    Private Sub InventoryControlForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
        LoadInventoryFile()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
