Public Class Form1
    Private NorthwindDataContext1 As New DataAccess.ClearingDataContext

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dc As New DataAccess.ClearingDataContext
        Me.RegionBindingSource.DataSource = NorthwindDataContext1.Region


    End Sub

   

    Private Sub RegionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegionBindingNavigatorSaveItem.Click
        Try
            NorthwindDataContext1.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
