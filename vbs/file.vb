'vbc file.vb && file.exe
Module file
    Sub main()
        FileOpen(1, "file.vb", OpenMode.Input)
        Dim cnt = 0
        Do While Not eof(1)
            cnt += 1
            console.writeline(cnt & ":" & LineInput(1))
        Loop
        FileClose(1)
    End Sub
End Module