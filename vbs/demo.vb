
Module demo
    Sub main()
        'http://msdn.microsoft.com/en-us/library/system.environment.is64bitprocess
        Console.WriteLine(Environment.Is64BitOperatingSystem)
        Dim ado = CreateObject("adodb.connection")

        dn = "Provider=microsoft.jet.oledb.4.0;data source=ms.mdb"
        ado.open(dn)

    End Sub
End Module