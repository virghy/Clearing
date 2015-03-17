Public Class frmCuentasEspeciales
    Dim _dc As New ClearingDA.ClearingDataContext
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.DC = _dc
        Me.BindingSource.DataSource = Me._dc.CuentasEspeciales.Where(Function(p) p.IdBanco = My.Application.Banco.cod_banco)
    End Sub
    Private Sub AgregandoCuenta(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles BindingSource.AddingNew
        Dim Cuenta As New ClearingDA.CuentasEspeciales
        Cuenta.IdBanco = My.Application.Banco.cod_banco
        Cuenta.Activo = True
        Cuenta.Audit_Fecha = Date.Now
        Cuenta.Audit_Usuario = My.User.Name
        e.NewObject = Cuenta

    End Sub
    Private Sub frmCuentasEspeciales_Validar(ByRef Cancel As Boolean, ByVal ListaCambios As System.Data.Linq.ChangeSet) Handles Me.Validar
        For Each modif As ClearingDA.CuentasEspeciales In ListaCambios.Updates
            modif.Audit_Usuario = My.User.Name
            modif.Audit_Fecha = Date.Now
        Next
    End Sub
End Class