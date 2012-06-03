 set sh = createobject("wscript.shell")
 set fso = createobject("scripting.filesystemobject")
 host = lcase(fso.getfilename(wscript.fullname ))
 set fso=nothing
 
 set env = sh.environment("system")
 if host="wscript.exe" and lcase(env("PROCESSOR_ARCHITECTURE"))="amd64" then
   sh.run "%windir%\syswow64\cscript "&wscript.scriptfullname,0,0 
   wscript.quit
 end if
 

Const Jet10 = 1
Const Jet11 = 2
Const Jet20 = 3
Const Jet3x = 4
Const Jet4x = 5
 

Sub CreateNewMDB(FileName, Format)
  Dim Catalog
  Set Catalog = CreateObject("ADOX.Catalog")
  Catalog.Create "Provider=Microsoft.Jet.OLEDB.4.0;" & _
     "Jet OLEDB:Engine Type=" & Format & _
    ";Data Source=" & FileName
End Sub
randomize()
'Create Access2000 database
 CreateNewMDB  int((1000*rnd())) & "a2000.mdb", Jet4x

