'vbc file.vb && file.exe
Module file
    Sub main()
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