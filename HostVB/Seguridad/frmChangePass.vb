Imports System.Web.Security

Public Class frmChangePass

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If Not Me.txtNewPass.Text = Me.txtConfirmPass.Text Then
            MsgBox("La confirmacion del password no coincide")
            Return
        End If
        Try

            Dim user As MembershipUser

            user = Membership.GetUser(My.User.Name)
            'user.ResetPassword
            If user.ChangePassword(Me.txtOldPass.Text, Me.txtNewPass.Text) Then
                MessageBox.Show("Password Cambiado.")
                Me.Close()
            Else
                MessageBox.Show("No se pudo cambiar el Password." + Chr(13) + "Verifique que su password anterior sea correcto.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
End Class