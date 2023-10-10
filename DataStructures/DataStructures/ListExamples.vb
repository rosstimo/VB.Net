Module ListExamples

    Sub Main()
        Dim names As New List(Of String)
        'add seven names to my list
        names.Add("Jimmy")
        names.Add("John")
        names.Add("Joan")
        names.Add("Jill")
        names.Add("Jack")
        names.Add("Jenny")

        'print out the list
        For Each name As String In names
            Console.WriteLine(name)
        Next

        'use an interpolated string to print out the 3rd name and the number of names in the list
        Console.WriteLine($"The 3rd name is {names(2)} and there are {names.Count} names in the list")

        'find Jill and print out the index number
        Console.WriteLine($"Jill is at index {names.IndexOf("Jill")}")

        'sort the list
        names.Sort()

        'print the name and index number of each name in the list
        For i = 0 To names.Count - 1
            Console.WriteLine($"Name: {names(i)} Index: {i}")
        Next

        'insert the name sally 3 times at random
        For i = 0 To 2
            names.Insert(RandomNumber(0, names.Count), "Sally")
        Next

        'print the list
        For Each name As String In names
            Console.WriteLine(name)
        Next

        'count how many times sally appears in the list
        Dim count As Integer = 0
        For Each name As String In names
            If name = "Sally" Then
                count += 1
            End If
        Next
        Console.WriteLine($"Sally appears {count} times in the list")

        'remove jack and jill then print the list
        names.Remove("Jack")
        names.Remove("Jill")
        For Each name As String In names
            Console.WriteLine(name)
        Next


        Console.Read()
    End Sub

    Function RandomNumber(ByVal min As Integer, ByVal max As Integer) As Integer
        Static random As New Random()
        Return random.Next(min, max)
    End Function

End Module
