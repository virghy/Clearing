Public Class frmGrupos

    Private Sub Aspnet_gruposBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aspnet_gruposBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Aspnet_gruposBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsSeguridad)
    End Sub

    Private Sub frmGrupos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsSeguridad.aspnet_sistemas' table. You can move, or remove it, as needed.
        Me.Aspnet_sistemasTableAdapter.Fill(Me.DsSeguridad.aspnet_sistemas)
        'TODO: This line of code loads data into the 'DsSeguridad.aspnet_permisos' table. You can move, or remove it, as needed.
        '        Me.Aspnet_permisosTableAdapter.Fill(Me.DsSeguridad.aspnet_permisos)
        'TODO: This line of code loads data into the 'DsSeguridad.aspnet_grupoUsuario' table. You can move, or remove it, as needed.
        '       Me.Aspnet_grupoUsuarioTableAdapter.Fill(Me.DsSeguridad.aspnet_grupoUsuario)
        'TODO: This line of code loads data into the 'DsSeguridad.aspnet_grupos' table. You can move, or remove it, as needed.
        Me.Aspnet_gruposTableAdapter.Fill(Me.DsSeguridad.aspnet_grupos)

    End Sub

    Private Sub Aspnet_gruposBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Aspnet_gruposBindingSource.PositionChanged

        Dim IdGrupo As Integer
        IdGrupo = CType(Me.Aspnet_gruposBindingSource.Current, DataRowView)("IdGrupo")
        Me.Aspnet_permisosTableAdapter.Fill(Me.DsSeguridad.aspnet_permisos, IdGrupo)
        Me.Aspnet_grupoUsuarioTableAdapter.Fill(Me.DsSeguridad.aspnet_grupoUsuario, IdGrupo)
    End Sub

    Private Sub frmGrupos_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Validating
        e.Cancel = True
    End Sub

    Private Sub Aspnet_gruposBindingNavigator_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Aspnet_gruposBindingNavigator.Validating
        e.Cancel = True
    End Sub
End Class