Imports System.Web.Profile

Public Class frmUserProfile
    Dim profile As ProfileBase
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Try
            profile.SetPropertyValue("FirstName", Me.txtNombre.Text)
            profile.SetPropertyValue("LastName", Me.txtApellido.Text)
            profile.SetPropertyValue("ProfileVersion", 1)
            profile.Save()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmUserProfile_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        profile = System.Web.Profile.DefaultProfile.Create(My.User.Name, True)
        Me.lblUser.Text = My.User.Name

        Me.txtNombre.Text = profile.GetPropertyValue("FirstName")
        Me.txtApellido.Text = profile.GetPropertyValue("LastName")
    End Sub

    Private Sub cmdCambiarPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCambiarPass.Click
        Dim frm As New frmChangePass
        frm.ShowDialog()
    End Sub
End Class