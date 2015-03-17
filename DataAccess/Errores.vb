Public Class Dic
    Shared _Errores As Dictionary(Of Integer, String)

    Public Shared ReadOnly Property Errores As Dictionary(Of Integer, String)
        Get
            If _Errores Is Nothing Then
                Cargar()
            End If
            Return _Errores
        End Get
    End Property

    Shared Sub Cargar()
        _Errores = New Dictionary(Of Integer, String)
        _Errores.Add(1, "Error 1")
        _Errores.Add(2, "Error 2")
        _Errores.Add(3, "Error 3")
        _Errores.Add(4, "Error 4")
        _Errores.Add(5, "Error 5")
        _Errores.Add(6, "Error 6")
        _Errores.Add(7, "Error 7")
        _Errores.Add(8, "Error 8")
        _Errores.Add(9, "Error 9")
        _Errores.Add(10, "Error 10")
        _Errores.Add(13, "La cuenta no es válida")
        _Errores.Add(15, "No se encuentra en el CHITCI.")
        _Errores.Add(17, "Monto no corresponde con el CHITCI.")
        _Errores.Add(19, "Cheque repetido.")
        _Errores.Add(20, "Longitud de cuenta mayor a lo establecido.")


    End Sub



End Class
