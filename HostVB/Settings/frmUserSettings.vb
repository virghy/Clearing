Public Class frmUserSettings
    Dim mus As My.MySettings
    Private Sub frmUserSettings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        mus.Save()
    End Sub

    Private Sub frmUserSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mus = New My.MySettings
        PropertyGrid1.SelectedObject = mus
        ' Attribute for the user-scope settings.
        Dim userAttr As New System.Configuration.UserScopedSettingAttribute
        Dim attrs As New System.ComponentModel.AttributeCollection(userAttr)
        PropertyGrid1.BrowsableAttributes = attrs

    End Sub
End Class