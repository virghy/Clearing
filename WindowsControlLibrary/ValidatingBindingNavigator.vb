Imports System.ComponentModel

Public Class ValidatingBindingNavigator
    Inherits BindingNavigator
    Sub New(ByVal container As IContainer)
        MyBase.New(container)
    End Sub


    Protected Overrides Sub WndProc(ByRef m As Message)

        If m.Msg = &H201 Then

            Dim args As CancelEventArgs = New CancelEventArgs()

            OnValidating(args)

            If (args.Cancel) Then
                Return
            End If
        End If
        MyBase.WndProc(m)

    End Sub



End Class
