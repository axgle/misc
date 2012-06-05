Imports System.Diagnostics
Imports System.Linq
Module main
    Sub main()
        For Each p In From pp In Process.GetProcesses() Order By pp.id Descending
            console.Write(p.id)
            console.WriteLine(" : " & p.processName)
        Next
        Dim line = console.Readline.trim
        If line="" Then
            Return
        End If
        Dim pid = CInt(line)
        'msgbox(pid)
        With Process.GetProcessById(pid)

            console.WriteLine(.ProcessName())
            If pid > 0 Then
                .kill()
            End If

        End With
    End Sub
End Module