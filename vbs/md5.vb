Imports System.Security.Cryptography
Imports System.Text

Module demo
    Sub main()
        echo(getMd5("1"))

    End Sub
    Sub qq(ByVal s,Optional ss as date=Nothing)

    End Sub
    Sub echo(ByVal s)
        console.WriteLine(s)
    End Sub
    'http://www.lob.cn/sl/sxzf/2062.shtml
    Private Function getMd5(ByVal InPutString As String) As String
        Dim Key As MD5 = MD5.Create
        Dim Bytes() As Byte = Key.ComputeHash(Encoding.Default.GetBytes(InPutString))
        Dim Sbuilter As New StringBuilder
        For i As Integer = 0 To Bytes.Length - 1
            Sbuilter.Append(Bytes(i).ToString("x2"))
        Next
        Return Sbuilter.ToString
    End Function
End Module