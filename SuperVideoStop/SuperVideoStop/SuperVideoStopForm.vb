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

                If currentRecord <> "" Then 'ignore blank records
                    temp = Split(currentRecord, ",")

                    'DisplayListBox.Items.Add(currentRecord) 'add the record to the list box

                    If temp.Length = 4 Then ' ignore malformed records
                        temp(0) = Replace(temp(0), "$", "") 'clean first name
                        DisplayListBox.Items.Add(temp(0))
                        WriteToFile(temp(0))
                        WriteToFile(temp(1))
                        WriteToFile(temp(2))
                        WriteToFile(temp(3))
                        WriteToFile(vbNewLine)


                    End If


                End If
            Loop


            FileClose(fileNumber)
        Catch bob As FileNotFoundException

            MsgBox("Bob is sad...")

        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace & vbNewLine)


        End Try

    End Sub

    Sub WriteToFile(newRecord As String)
        Dim filePath As String = "..\..\CustomerData.txt"
        Dim fileNumber As Integer = FreeFile()

        Try
            FileOpen(fileNumber, filePath, OpenMode.Append)
            Write(fileNumber, newRecord)
            FileClose(fileNumber)
        Catch ex As Exception
            MsgBox($"Error writing to {filePath}")
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
