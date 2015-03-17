Imports System.Web.Security
Imports System.Web.Profile
Public Class frmAddUser

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Dim estado As MembershipCreateStatus
        Dim usuario As MembershipUser
        If Me.txtPass.Text = Me.txtConfirmPass.Text Then

            usuario = Membership.CreateUser(Me.txtUsuario.Text, Me.txtPass.Text, Me.txtEmail.Text, _
                                  Me.txtPregunta.Text, Me.txtRespuesta.Text, True, estado)

            If usuario Is Nothing Then
                MsgBox(GetErrorMessage(estado))
            Else
                MsgBox("Usuario Creado")
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        Else
            MsgBox("El password y la confirmacion del password no coinciden")
        End If


    End Sub

    Public Function GetErrorMessage(ByVal status As MembershipCreateStatus) As String

        Select Case status

            Case MembershipCreateStatus.DuplicateUserName
                Return "Username already exists. Please enter a different user name."

            Case MembershipCreateStatus.DuplicateEmail
                Return "A username for that e-mail address already exists. Please enter a different e-mail address."

            Case MembershipCreateStatus.InvalidPassword
                Return "The password provided is invalid. Please enter a valid password value."

            Case MembershipCreateStatus.InvalidEmail
                Return "The e-mail address provided is invalid. Please check the value and try again."

            Case MembershipCreateStatus.InvalidAnswer
                Return "The password retrieval answer provided is invalid. Please check the value and try again."

            Case MembershipCreateStatus.InvalidQuestion
                Return "The password retrieval question provided is invalid. Please check the value and try again."

            Case MembershipCreateStatus.InvalidUserName
                Return "The user name provided is invalid. Please check the value and try again."

            Case MembershipCreateStatus.ProviderError
                Return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator."

            Case MembershipCreateStatus.UserRejected
                Return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator."

            Case Else
                Return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator."
        End Select

    End Function

End Class