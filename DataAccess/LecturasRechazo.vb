Partial Public Class LecturasRechazo
    Private _Motivo
    Public Property Motivo As String
        Get
            If Not Me.MotivosRechazo Is Nothing Then
                _Motivo = Me.MotivosRechazo.Motivo
            End If
            Return _Motivo
        End Get
        Set(value As String)
            _Motivo = value
        End Set
    End Property

End Class