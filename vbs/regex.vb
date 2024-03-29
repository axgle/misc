Imports System.net
Imports System.text
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

        ' if page charset=utf-8
        'wc.Encoding = System.Text.Encoding.UTF8

        wc.Headers("user-agent") = "firefox"
        Dim data = wc.downloadstring(url)

        'if page charset=utf-8,convert to gb2312
        'data = UTF8ToGB2312(data)

        Dim reg = New Regex("<a.*?href=""([^>]+?)"".*?>([^>]+?)</a>")
        For Each m In reg.matches(data)
            Console.Write(m.groups(2).value + " = ")
            Console.WriteLine(m.groups(1).value)
        Next
        Console.WriteLine(wc.Encoding.ToString)
        wc.Dispose()
    End Sub
    Function UTF8ToGB2312(ByVal s As String)
        Dim enconde = New UTF8Encoding()
        Return enconde.GetString(encoding.Convert(Encoding.UTF8, Encoding.GetEncoding("gb2312"), enconde.GetBytes(s)))
    End Function
End Module