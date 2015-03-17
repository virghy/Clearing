Imports DataAccess

Public Class TestNewId
    Dim dm As New DataAccess.Entities
    Dim dxe As New List(Of DataAccess.PruebaNewId)
    Private Sub TestNewId_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PruebaNewIdBindingSource.DataSource = dxe
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            Dim limite As Integer = Me.txtLimite.Text
            For i = 1 To limite
                Dim o As New DataAccess.PruebaNewId()
                o.Nro = HostVB.Util.NEWID(dm, "Lecturas")
                o.Instancia = CInt(Me.txtInstancia.Text)
                PruebaNewIdBindingSource.Add(o)
            Next
            Grabar()
        Catch ex As Exception
            MsgBox(HostVB.Util.EnumErrors(ex))
        End Try

    End Sub

    Sub Grabar()
        Try

            For Each item As PruebaNewId In dxe
                If item.Nro <= 0 Then
                    item.Nro = HostVB.Util.NEWID(dm, "Lecturas")
                End If
                If item.EntityState = EntityState.Detached Then
                    dm.AddObject("PruebaNewId", item)
                End If
                If item.EntityState = EntityState.Deleted Then
                    dm.DeleteObject(item)
                End If
            Next
            dm.SaveChanges()
        Catch ex As Exception
            If MsgBox(HostVB.Util.EnumErrors(ex), MsgBoxStyle.RetryCancel) = MsgBoxResult.Retry Then
                Grabar()
            End If
        End Try

    End Sub
End Class