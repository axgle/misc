Imports system.console
'http://msdn.microsoft.com/en-us/library/ms172879
Delegate Sub run(ByVal s As String)
module main
 sub main()
        echo(Sub(s)
                 WriteLine(s)
             End Sub)
    End Sub
    Sub echo(ByVal r As run)
        r("google!")
    End Sub
End Module