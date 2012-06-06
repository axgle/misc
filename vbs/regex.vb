Imports System.net
Imports System.Text.RegularExpressions
Module main
    Sub main()
        Dim wc As New WebClient
        Dim url = "http://php.net"
        Dim args = Environment.GetCommandLineArgs
        'regex.exe [url]
        If args.length = 2 Then
            url = args(1)
        End If
        wc.Headers("user-agent") = "firefox"
        Dim data = wc.downloadstring(url)
        Dim reg = New Regex("<a.*?href=""([^>]+?)"".*?>([^>]+?)</a>")
        For Each m In reg.matches(data)
            Console.Write(m.groups(2).value + " = ")
            Console.WriteLine(m.groups(1).value)
        Next
        wc.Dispose()
    End Sub
End Module