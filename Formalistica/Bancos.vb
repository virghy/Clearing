Public Class ValidarBancos
    Shared _Bancos As List(Of DataAccess.Bancos)
    Shared ReadOnly Property Bancos As List(Of DataAccess.Bancos)
        Get
            If _Bancos Is Nothing Then
                Dim dm As New DataAccess.Entities
                _Bancos = dm.Bancos.OrderBy(Function(t) t.cod_banco).Where(Function(k) k.Activo = True).ToList
            End If
            Return _Bancos
        End Get
    End Property
    Shared Function Existe(Banco As String) As Boolean
        For Each b In Bancos
            If b.cod_banco = Banco Then
                Return True
            End If
        Next
        Return False
    End Function
End Class
