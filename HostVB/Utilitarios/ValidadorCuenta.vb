Public Class ValidadorCuenta
    Dim vecCta(0 To 9) As Integer
    Dim Ind As Integer

    Public Function Validar(ByVal Banco As String, ByVal Cuenta As String, Proceso As Operacion) As Boolean
        Select Case Banco
            Case "17"
                Return ValidarITAU(Cuenta, Proceso)
            Case Else
                Return True
        End Select
    End Function

    Private Function ValidarITAU(ByVal Cuenta As String, Proceso As Operacion) As Boolean

        If Cuenta.Length > 10 Then
            Return False
        End If

        'No se valida cuenta 1 en enviados
        If Proceso = Operacion.Enviado And Cuenta = "1" Then
            Return True
        End If

        If My.Application.Constantes.CUENTA_ADM_ITAU = Cuenta Then
            Return True
        End If


        Dim vector(0 To 9) As Integer
        Dim Ctatxt As String
        Dim Cnt As Integer
        Dim CGNro As String
        Dim Digtext As String
        Dim tot As Integer
        Dim X As Integer
        Dim Y As Integer
        Dim Res As Integer
        Dim Vali As Integer
        Dim DigVrf As Integer
        Dim CuentaOrigen = Cuenta.Substring(0, Cuenta.Length - 1)


        CGNro = CuentaOrigen

        vector(0) = 7
        vector(1) = 3
        vector(2) = 1
        vector(3) = 9
        vector(4) = 7
        vector(5) = 3
        vector(6) = 1
        vector(7) = 9
        vector(8) = 7
        vector(9) = 3

        CerarVector()
        Ctatxt = CGNro.ToString
        Ind = Ctatxt.Length
        'Ctatxt = Trim(Ctatxt)
        Ctatxt = Ctatxt.Substring(0, Ind)
        Ind = (9 - Ctatxt.Length) + 1
        Cnt = 0
        While Ind < 10
            'Ctatxt = Ctatxt
            Digtext = Ctatxt.Substring(Cnt, 1)
            vecCta(Ind) = CInt(Digtext)
            Ind = Ind + 1
            Cnt = Cnt + 1
        End While

        tot = 0
        Ind = 0
        While Ind < 10
            X = vector(Ind)
            Y = vecCta(Ind)
            Res = vector(Ind) * vecCta(Ind)

            If Res.ToString.Length > 1 Then

                Digtext = Res.ToString.Substring(1, 1)
                Vali = CInt(Digtext)
            Else
                Vali = Res

            End If
            tot = tot + Vali
            Ind = Ind + 1
        End While

        If tot.ToString.Length > 1 Then
            Digtext = tot.ToString.Substring(1, 1)
            Vali = CInt(Digtext)
        Else
            'Vali = 0
            Vali = tot
        End If

        If Vali = 0 Then
            DigVrf = 0
        Else
            DigVrf = 10 - Vali
        End If

        Return CuentaOrigen + DigVrf.ToString = Cuenta
    End Function
    Private Sub CerarVector()

        Ind = 0
        While Ind < 10
            vecCta(Ind) = 0
            Ind = Ind + 1

        End While

    End Sub

    'Dim vector(0 To 9) As Integer
    'Dim Ctatxt As String
    'Dim Cnt As Integer
    'Dim CGNro As String
    'Dim Digtext As String
    'Dim tot As Integer
    'Dim X As Integer
    'Dim Y As Integer
    'Dim Res As Integer
    'Dim Vali As Integer
    'Dim DigVrf As Integer
    'Dim CuentaOrigen = Cuenta.Substring(0, Cuenta.Length - 1)


    '    CGNro = CuentaOrigen

    '    vector(0) = 7
    '    vector(1) = 3
    '    vector(2) = 1
    '    vector(3) = 9
    '    vector(4) = 7
    '    vector(5) = 3
    '    vector(6) = 1
    '    vector(7) = 9
    '    vector(8) = 7
    '    vector(9) = 3

    '    CerarVector()
    '    Ctatxt = Trim(Str(CGNro))
    '    Ind = Len(Trim(Ctatxt))
    '    Ctatxt = Trim(Ctatxt)
    '    Ctatxt = Ctatxt.Substring(0, Ind)
    '    Ind = (9 - Len(Trim(Ctatxt))) + 1
    '    Cnt = 0
    '    While Ind < 10
    '        Ctatxt = Trim(Ctatxt)
    '        Digtext = Ctatxt.Substring(Cnt, 1)
    '        vecCta(Ind) = Val(Digtext)
    '        Ind = Ind + 1
    '        Cnt = Cnt + 1
    '    End While

    '    tot = 0
    '    Ind = 0
    '    While Ind < 10
    '        X = vector(Ind)
    '        Y = vecCta(Ind)
    '        Res = vector(Ind) * vecCta(Ind)

    '        If Len(Trim(Str(Res))) > 1 Then

    '            Digtext = Trim(Str(Res)).Substring(1, 1)
    '            Vali = Val(Digtext)
    '        Else
    '            Vali = Res

    '        End If
    '        tot = tot + Vali
    '        Ind = Ind + 1
    '    End While

    '    If Len(Trim(Str(tot))) > 1 Then
    '        Digtext = Trim(Str(tot)).Substring(1, 1)
    '        Vali = Val(Digtext)
    '    Else
    '        Vali = 0
    '    End If

    '    If Vali = 0 Then
    '        DigVrf = 0
    '    Else
    '        DigVrf = 10 - Vali
    '    End If
End Class
