Public Class ProgresoScaneo
    Public Event Cancelar()
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RaiseEvent Cancelar()
    End Sub
End Class