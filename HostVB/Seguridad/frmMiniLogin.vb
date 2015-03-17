Imports System.Windows.Forms
Imports System.Web.Security
Public Class frmMiniLogin

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Membership.ValidateUser(Me.UsernameTextBox.Text, Me.PasswordTextBox.Text) = True Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            'Me.UsernameTextBox.Text = String.Empty
            Me.PasswordTextBox.Text = String.Empty
            MessageBox.Show("Username or password are incorrect")
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
