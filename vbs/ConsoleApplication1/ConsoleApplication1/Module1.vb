Imports System.Data
Imports ADODB


Module Module1

    Sub Main()
        Dim conn As ADODB.Connection = CreateObject("adodb.connection")
        Dim dsn As String = "provider=microsoft.jet.oledb.4.0;data source=C:\Users\sony\Desktop\github\misc\vbs\ms.mdb"
        conn.Open(dsn)
        Try
            conn.Execute("create table test(id autoincrement,name text)")
        Catch
        End Try

        conn.Execute("insert into test(name) values('" & DateTime.Now() & "')")
        Dim rs As ADODB.Recordset = CreateObject("adodb.recordset")

        rs.Open("select * from test order by id desc", conn, 1, 1)
        Dim ext As String
        Do

            Console.WriteLine(rs("id").Value & ":" & rs("name").Value)
            rs.MoveNext()
            Dim s As String

            ext = Console.ReadLine()

        Loop Until ext = "q" Or rs.EOF
        Console.Write(AppDomain.CurrentDomain.BaseDirectory)
    
    End Sub

End Module
