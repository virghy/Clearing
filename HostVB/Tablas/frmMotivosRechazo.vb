Imports Microsoft.Win32
Public Class frmMotivosRechazo
    Dim _dc As New ClearingDA.ClearingDataContext


    Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.DC = _dc

        Me.BindingSource.DataSource = _dc.MotivosRechazos.Where(Function(m) m.IdBanco = My.Application.Banco.cod_banco)
       

    End Sub


    Private Sub frmBanco_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub

    Private Sub AgregandoMotivo(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles BindingSource.AddingNew
        Dim Motivo As New ClearingDA.MotivosRechazo
        Motivo.IdBanco = My.Application.Banco.cod_banco
        Motivo.Activo = True
        Motivo.Audit_Fecha = Date.Now
        Motivo.Audit_Usuario = My.User.Name
        e.NewObject = Motivo
    End Sub


   


    Private Sub frmMotivosRechazo_Validar(ByRef Cancel As Boolean, ByVal ListaCambios As System.Data.Linq.ChangeSet) Handles Me.Validar
        For Each modif As ClearingDA.MotivosRechazo In ListaCambios.Updates
            modif.Audit_Usuario = My.User.Name
            modif.Audit_Fecha = Date.Now
        Next
    End Sub
End Class