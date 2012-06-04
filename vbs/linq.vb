'vbc file.vb && file.exe
Imports System.linq
Module file
    Sub main()
        'vs 2010: VB Samples\Language Samples\LINQ Samples\SimpleLambdas
        Dim arr As String() = New String() {"aaa", "bbb", "ccc!"}
        Dim r = arr.where(Function(i) Len(i) = 4)
        For Each i As String In r
            console.Write(i)
        Next
        console.read()
    End Sub
    Sub main2()
        Dim filename = "file.vb"
        console.writeline(readALL(filename))

        FileOpen(1, filename, OpenMode.Input)
        Dim cnt = 0
        Do While Not eof(1)
            cnt += 1
            console.writeline(cnt & ":" & LineInput(1))
        Loop
        FileClose(1)

    End Sub
    Function readAll(ByVal filename)
        FileOpen(1, filename, OpenMode.Input)

        Dim d = inputString(1, LOF(1))

        FileClose(1)
        readAll = d
    End Function
End Module