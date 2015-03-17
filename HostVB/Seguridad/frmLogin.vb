Imports System.Web.Security
Imports System.Web.ClientServices.Providers
Imports System.Web.Profile
Public Class frmLogin

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim samplePrincipal As New SampleIPrincipal(Me.UsernameTextBox.Text, Me.PasswordTextBox.Text)
        My.User.CurrentPrincipal = samplePrincipal

        If (Not My.User.IsAuthenticated) Then
            'Check to see if the username and password are correct using My.User
            Me.UsernameTextBox.Text = String.Empty
            Me.PasswordTextBox.Text = String.Empty
            MessageBox.Show("Username or password are incorrect")
        Else
            ' The username and password are correct, so display the main form.
            My.MySettings.Default.Moneda = Me.ComboBox2.SelectedValue
            My.MySettings.Default.Save()
            Me.Visible = False
            My.Forms.frmPrincipal.Show()

            Me.Close()

        End If
    End Sub


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Try
        '    Membership.CreateUser("Admin", "Admin01@")
        'Catch ex As MembershipCreateUserException
        '    MsgBox(ex.Message)
        'End Try
        ' Membership.CreateUser(
        'Dim userprofile As ProfileBase


        Dim dm As New DataAccess.Entities
        Me.MonedasBindingSource.DataSource = dm.Monedas
        Me.ComboBox1.SelectedItem = My.MySettings.Default.Proceso
        Me.ComboBox2.SelectedValue = My.MySettings.Default.Moneda

        If (My.User.IsAuthenticated) Then
            ' The user is already authenticated, so just display the main form.
            ' The user has not been authenticated, so enable custom authentication and authorization
            Me.Close()
            My.Forms.frmPrincipal.Show()
        End If
    End Sub


    'Public Function GetCredentials() As  _
    'ClientFormsAuthenticationCredentials Implements _
    'IClientFormsAuthenticationCredentialsProvider.GetCredentials

    '    If Me.ShowDialog() = DialogResult.OK Then
    '        Return New ClientFormsAuthenticationCredentials( _
    '            UsernameTextBox.Text, PasswordTextBox.Text, _
    '            True)
    '    Else
    '        Return Nothing
    '    End If

    'End Function

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        My.MySettings.Default.Proceso = ComboBox1.SelectedItem
        Select Case ComboBox1.SelectedItem
            Case "Enviados"
                My.Application.IdProceso = Operacion.Enviado
            Case "Recibidos"
                My.Application.IdProceso = Operacion.Recibido
            Case "Devueltos"
                My.Application.IdProceso = Operacion.Devuelto
            Case "Rechazados"
                My.Application.IdProceso = Operacion.Rechazado
            Case "Cam. Interna"
                My.Application.IdProceso = Operacion.Interna
        End Select

    End Sub
End Class
