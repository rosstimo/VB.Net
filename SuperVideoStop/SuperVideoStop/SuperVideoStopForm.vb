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
        Dim currentID As Integer = 699
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
                        WriteToFile(temp(0)) 'first name
                        WriteToFile(temp(1)) 'last name
                        WriteToFile("") 'place holder for street
                        WriteToFile(temp(2))  'City
                        WriteToFile("ID") 'state
                        WriteToFile("") 'zip
                        WriteToFile("") 'phone
                        WriteToFile(temp(3)) 'email
                        WriteToFile($"000631{currentID}", True) 'customer ID, add a new line at the last record for each customer
                        currentID += 1
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

    Sub WriteToFile(newRecord As String, Optional insertNewLine As Boolean = False)
        Dim filePath As String = "..\..\CustomerData.txt"
        Dim fileNumber As Integer = FreeFile()

        Try
            FileOpen(fileNumber, filePath, OpenMode.Append)
            Write(fileNumber, newRecord)
            If insertNewLine Then
                WriteLine(fileNumber)
            End If

            FileClose(fileNumber)
        Catch ex As Exception
            MsgBox($"Error writing to {filePath}")
        End Try

    End Sub

    Sub LoadCustomerData()
        Dim filePath As String = "..\..\CustomerDataX.dat"
        Dim fileNumber As Integer = FreeFile()
        Dim currentRecord As String
        Dim InvalidFileName As Boolean = True
        Dim customers(NumberOfCustomers(filePath) - 1, 8) As String ' array for customer data
        Dim currentCustomer As Integer = 0

        Do
            Try
                FileOpen(fileNumber, filePath, OpenMode.Input)
                InvalidFileName = False
                Do Until EOF(fileNumber)
                    Input(fileNumber, currentRecord)
                    customers(currentCustomer, 0) = currentRecord 'first name
                    Input(fileNumber, currentRecord)
                    customers(currentCustomer, 1) = currentRecord 'last name
                    Input(fileNumber, currentRecord)
                    customers(currentCustomer, 2) = currentRecord
                    Input(fileNumber, currentRecord)
                    customers(currentCustomer, 3) = currentRecord
                    Input(fileNumber, currentRecord)
                    customers(currentCustomer, 4) = currentRecord
                    Input(fileNumber, currentRecord)
                    customers(currentCustomer, 5) = currentRecord
                    Input(fileNumber, currentRecord)
                    customers(currentCustomer, 6) = currentRecord
                    Input(fileNumber, currentRecord)
                    customers(currentCustomer, 7) = currentRecord
                    Input(fileNumber, currentRecord)
                    customers(currentCustomer, 8) = currentRecord
                    Input(fileNumber, currentRecord) 'empty, discard

                    currentCustomer += 1
                Loop
                FileClose(fileNumber)
                'MsgBox($"there are {NumberOfCustomers(filePath)} customers")
            Catch noFile As FileNotFoundException
                InvalidFileName = True
                OpenFileDialog.FileName = ""
                OpenFileDialog.InitialDirectory = "L:\github\VB.Net\SuperVideoStop\SuperVideoStop"
                OpenFileDialog.Filter = "dat files (*.dat)|*.dat|All files (*.*)|*.*"
                OpenFileDialog.ShowDialog()
                filePath = OpenFileDialog.FileName
                MsgBox($"The current file is {filePath}")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Loop While InvalidFileName

    End Sub

    Function NumberOfCustomers(fileName As String) As Integer
        Dim count As Integer = 0
        Dim fileNumber As Integer = FreeFile()

        Try
            FileOpen(fileNumber, fileName, OpenMode.Input)
            Do Until EOF(fileNumber)
                LineInput(fileNumber)
                count += 1
            Loop

            FileClose(fileNumber)
        Catch ex As Exception
            'pass
            'maybe set count to -1 to indicate error
        End Try

        Return count
    End Function


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

    Private Sub OpenTopMenuItem_Click(sender As Object, e As EventArgs) Handles OpenTopMenuItem.Click
        LoadCustomerData()
    End Sub

End Class
