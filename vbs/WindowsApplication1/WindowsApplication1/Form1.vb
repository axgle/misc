Public Class Form1

    Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingSource1.CurrentChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“MsDataSet.test”中。您可以根据需要移动或删除它。
        ' Dim ds = Me.MsDataSet.Tables("test").DefaultView
        'ds.Sort = "id desc"
        'MsDataSet.testDataTable.
        Me.TestTableAdapter.Fill(Me.MsDataSet.test)

    End Sub

    Private Sub TestBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestBindingSource.CurrentChanged

    End Sub
 
End Class
