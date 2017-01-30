Module Module1

    Const size = 3

    Sub printList(ByRef list() As String, ByVal l As Integer)

        For i = 0 To l - 1
            Console.Write(list(i) & " ")
        Next

        Console.WriteLine("")

    End Sub


    Sub recursiveBinary(ByRef list() As String, ByVal r As Integer)
        If r = size Then
            printList(list, size)
            Exit Sub
        End If

        list(r) = "0"
        recursiveBinary(list, r + 1)

        list(r) = "1"
        recursiveBinary(list, r + 1)

    End Sub

    Sub Main()

        Dim list(size - 1) As String

        recursiveBinary(list, 0)

    End Sub

End Module
