
module main
 Const Jet10 = 1
Const Jet11 = 2
Const Jet20 = 3
Const Jet3x = 4
Const Jet4x = 5

sub main()


'CreateObject("wscript.shell").run("cmd /c set path=%path%;%windir%\system32")


randomize()
'Create Access2000 database
 'CreateNewMDB(  int((1000*rnd())) & "a2000.mdb", Jet4x)
 CreateDatabase()
 
  dim sh = createobject("shell.application") 
  sh.filerun()
  'console.writeline("google"&  "ookkkk")
 end sub
 
 Sub CreateDatabase()
 
   Dim cat As New ADOX.Catalog
   cat.Create("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=new.mdb")
 
End Sub


 Sub CreateNewMDB(FileName, Format)
   
  dim Catalog = CreateObject("ADOX.Catalog")
  Catalog.Create("Provider=Microsoft.Jet.OLEDB.4.0;" & _
     "Jet OLEDB:Engine Type=" & Format & _
    ";Data Source=" & FileName)
End Sub

end module