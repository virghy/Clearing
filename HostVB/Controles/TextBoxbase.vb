Imports System

Public Class TextBoxBase
    Inherits TextBox
    Private Sub TextBoxBase_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.SelectNextControl(Me, True, True, True, True)
            e.Handled = True
        End If
        MyBase.OnKeyDown(e)

    End Sub
End Class
