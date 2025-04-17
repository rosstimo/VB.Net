Option Strict On
Option Explicit On
'header

Imports System.IO

Public Class SuperVideoStopForm

    Sub ReadFromFile()
        Dim filePath As String = "..\..\UserData.txt"
        Dim fileNumber As Integer = FreeFile()
        Dim currentRecord As String = ""
        Dim temp() As String ' use for splitting customer data
        Try
            FileOpen(fileNumber, filePath, OpenMode.Input)

            Do Until EOF(fileNumber)
                Input(fileNumber, currentRecord) ' read exactly one record
                If currentRecord <> "" Then

                    DisplayListBox.Items.Add(currentRecord) 'add the record to the list box



                End If
            Loop


            FileClose(fileNumber)
        Catch bob As FileNotFoundException

            MsgBox("Bob is sad...")

        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace & vbNewLine)


        End Try

    End Sub



    ' Event handlers below here ***********************************************

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        ReadFromFile()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayListBox.Items.Clear()
    End Sub
End Class
