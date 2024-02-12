Option Explicit On
Option Strict On
'see: https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.filesystem.writeline?view=netframework-4.8

Module FileIOConsoleExample

    Sub Main()

        'WriteAsOutPut()
        'WriteAsOutPut()
        'WriteAsOutPut()
        'WriteAsOutPut()
        'AppendToExistingFile()
        'ReadOneRecordFromFile()
        'ReadAllRecordsFromFile()
        ReadCustomerData()
        Console.Read()
    End Sub

    Sub WriteAsOutPut()
        'if file exists it gets overwritten... Destroyed!

        FileOpen(1, "S24Junk.txt", OpenMode.Output)
        For i = 1 To 10
            Write(1, "hello to my file")
        Next
        FileClose(1)

    End Sub

    Sub AppendToExistingFile()
        'append record to the end of an existing file
        'creates it if it does not exist
        FileOpen(1, "..\..\AppendMe.txt", OpenMode.Append)
        'Write(1, "Follow the white rabbit...")
        Write(1, False)
        Write(1, True)
        Write(1, DateTime.Now)
        Write(1, 42)
        Write(1, 0.12345)


        FileClose(1)

    End Sub

    Sub ReadOneRecordFromFile()
        Dim currentRecord As String
        Try

            FileOpen(1, "ShinyNewFile.txt", OpenMode.Input)
            Input(1, currentRecord)

            Console.WriteLine(currentRecord)
            FileClose(1)

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace.ToString())
            Console.WriteLine(ex.Message)

        End Try
    End Sub

    Sub ReadAllRecordsFromFile()
        Dim currentRecord As String
        Try

            FileOpen(1, "..\..\AppendMe.txt", OpenMode.Input) '"ShinyNewFile.txt"

            Do Until EOF(1)
                Input(1, currentRecord)
                Console.WriteLine(currentRecord)
            Loop

            FileClose(1)

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace.ToString())
            Console.WriteLine(ex.Message)

        End Try
    End Sub


    Sub ReadCustomerData()
        Dim currentRecord As String
        Dim firstName$, lastName$, city$, email$
        Dim temp() As String

        Try
            FileOpen(1, "..\..\email.txt", OpenMode.Input)

            Do Until EOF(1)
                Input(1, firstName)
                Input(1, lastName)
                Input(1, city)
                Input(1, email)
                'Input(1, currentRecord)
                'currentRecord = LineInput(1)
                'Console.WriteLine(currentRecord)

                'temp = Split(firstName, "$$")
                'firstName = temp(1)

                Console.WriteLine($"First Name: {firstName}")
                Console.WriteLine($"Last Name: {lastName}")
                Console.WriteLine($"City: {city}")
                Console.WriteLine($"Email: {email}")
                Console.ReadLine()
            Loop

            FileClose(1)
        Catch ex As Exception

        End Try

    End Sub


End Module
