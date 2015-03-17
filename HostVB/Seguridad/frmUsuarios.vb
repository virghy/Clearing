Imports System.Web.Security
Imports System.Web.Profile
Public Class frmUsuarios
    Dim profile As ProfileBase
    Private Sub frmUsuarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.MembershipUserBindingSource.DataSource = Membership.GetAllUsers()
    End Sub

    Private Sub MembershipUserBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MembershipUserBindingSource.CurrentChanged
        profile = System.Web.Profile.DefaultProfile.Create(CType(Me.MembershipUserBindingSource.Current, MembershipUser).UserName, True)
        '   Me.lblUser.Text = My.User.Name

        Me.txtNombre.Text = profile.GetPropertyValue("FirstName")
        Me.txtApellido.Text = profile.GetPropertyValue("LastName")
        ' Membership.CreateUser(
    End Sub

    Private Sub cmdAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddUser.Click
        Dim frm As New frmAddUser
        frm.Owner = Me
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.MembershipUserBindingSource.DataSource = Membership.GetAllUsers()
        End If
    End Sub
End Class