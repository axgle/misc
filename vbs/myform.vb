'vbc myform.vb
'vbc myform.vb  /t:winexe
'vbc myform.vb  /t:winexe /r:system.dll,system.windows.forms.dll
Imports System.Windows.Forms
Class myform
    Inherits Form
    Shared Sub main()
        Application.run(New myform)
    End Sub
    Sub myform_load() Handles MyBase.Load
        Me.text = "welcome"
    End Sub
End Class