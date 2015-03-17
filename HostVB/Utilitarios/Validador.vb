Imports DataAccess
Imports Microsoft.Practices.EnterpriseLibrary.Validation

Public Class Validador
    ' Dim Oper As Operacion
    Shared dm As New Entities

#Region " Listas "
    Shared _Bancos As List(Of Bancos)
    Shared _TipoDoc As List(Of Tipo_Documentos)
    Shared _Camaras As List(Of Camara)
    Shared _validator As Validator(Of Lecturas)
    Public Shared ReadOnly Property Bancos() As List(Of Bancos)
        Get
            If _Bancos Is Nothing Then
                _Bancos = dm.Bancos.Where(Function(p) p.Activo = True).ToList
            End If
            Return _Bancos
        End Get
    End Property


    Public Shared ReadOnly Property Camaras() As List(Of Camara)
        Get
            If _Camaras Is Nothing Then
                _Camaras = dm.Camaras.ToList
            End If
            Return _Camaras
        End Get
    End Property
    Public Shared ReadOnly Property TipoDoc() As List(Of Tipo_Documentos)
        Get
            If _TipoDoc Is Nothing Then
                _TipoDoc = dm.Tipo_Documentos.ToList
            End If
            Return _TipoDoc
        End Get
    End Property
    Public Shared ReadOnly Property Validator() As Validator(Of Lecturas)
        Get
            If _validator Is Nothing Then
                _validator = ValidationFactory.CreateValidator(Of Lecturas)()
            End If
            Return _validator
        End Get
    End Property
#End Region

#Region " Validacion "


    Shared Function ValidarLectura(ByVal dg As DataGridView, ByVal oper As Operacion, ByVal Fecha As Date, ByVal dxe As List(Of Lecturas), ByVal codBanco As String, ByVal CodMoneda As String, _
                            ByVal Sucursales As List(Of Sucursales)) As Integer

        Dim FechaAnterior As Date
        'Buscamos la fecha anterior solo si es Devuelto o Rechazado
        If oper = Operacion.Devuelto Or oper = Operacion.Rechazado Then

            'Si es USD, en devueltos se busca 2 dias atras
            If CodMoneda = "USD" Then
                If oper = Operacion.Devuelto Then
                    FechaAnterior = Util.DiaProceso(Fecha, 2)
                Else
                    FechaAnterior = Fecha
                End If
            Else
                FechaAnterior = Util.DiaProceso(Fecha, 1)
            End If
        End If


        Dim cErrores As Double = 0
        Dim lc As Lecturas

        Dim procesoRechazadoDevuelto As Integer

        Select Case oper
            Case Operacion.Devuelto
                procesoRechazadoDevuelto = 2
            Case Operacion.Rechazado
                procesoRechazadoDevuelto = 3
        End Select


        Dim lcBancoCabecera As String = String.Empty
        Dim lcCuentaDeposito As String = String.Empty
        Dim ExisteError As Boolean = False

        Dim td = From c In dxe _
                        Where Not c.EsCabecera _
                Group c By c.cod_maquina, c.nro_lote _
                Into Total = Sum(c.monto) _
                Select cod_maquina, nro_lote, Total
        

        'For Each item As DataGridViewRow In LecturasDataGridView.Rows
        '    item.ErrorText = ""
        '    item.Cells(5).ErrorText = ""

        '    item.Cells("tbcSerie").ErrorText = ""
        '    item.Cells(6).ErrorText = ""
        'Next


        For Each item As DataGridViewRow In dg.Rows
            If item.DataBoundItem Is Nothing Then
                Continue For
            End If
            item.ErrorText = ""
            item.Cells(5).ErrorText = ""

            item.Cells("tbcSerie").ErrorText = ""
            item.Cells(6).ErrorText = ""


            ValidarItem(item)


            Dim r As DataGridViewRow = item
            lc = CType(item.DataBoundItem, Lecturas)

            'Si ocurrio un error en la validacion de la clase
            ExisteError = Not lc.CORREGIDO

            If Not lc.EsCabecera And lc.numero_cheque = 0 Then
                r.Cells(5).ErrorText = "Nro de Cheque no valido."
                ExisteError = True
                lc.AgregarError(6, "Nro de Cheque no valido.")

            End If


            'Validamos cada lote
            If lc.EsCabecera Then

                ' If chkFiltraError.Checked = False Then
                '     Dim Diferente = Aggregate word In td _
                '                  Where word.nro_lote = lc.nro_lote _
                'Into Any(word.Total <> lc.monto)

                Dim Suma = Aggregate word In td _
                                Where word.nro_lote = lc.nro_lote And word.cod_maquina = lc.cod_maquina _
              Into Sum(word.Total)

                'If Diferente Then
                If lc.monto <> Suma Then
                    r.ErrorText = String.Format("Existe una diferencia con la suma del detalle.{1} Cab={0:n2} {1} Det={2:n2} {1} Dif={3:n2}", lc.monto, Chr(13), Suma, lc.monto - Suma)
                    ExisteError = True
                    '                    lc.Errores.Add(New Errores(7, String.Format("Existe una diferencia con la suma del detalle. Cab={0:n2} Det={2:n2} Dif={3:n2}", lc.monto, Chr(13), Suma, lc.monto - Suma)))
                    lc.AgregarError(7, String.Format("Existe una diferencia con la suma del detalle. Cab={0:n2} Det={2:n2} Dif={3:n2}", lc.monto, Chr(13), Suma, lc.monto - Suma))
                    ' r.Cells(2).ErrorText = "Existe una diferencia con la suma del detalle"
                End If
                ' End If

                '  Dim Diferente = Aggregate word In td _
                '                  Where word.nro_lote = lc.nro_lote _
                'Into Any(word.Total <> lc.monto)
                '  If Diferente Then
                '      r.ErrorText = "Existe una diferencia con la suma del detalle."
                '      ' r.Cells(2).ErrorText = "Existe una diferencia con la suma del detalle"
                '  End If
                lcBancoCabecera = lc.cod_banco_emisor

                If lc.VERIFICADO = False Then
                    r.ErrorText = String.Format("No Existe en el CHITCI")
                    ExisteError = True
                    '                    lc.Errores.Add(New Errores(7, String.Format("Existe una diferencia con la suma del detalle. Cab={0:n2} Det={2:n2} Dif={3:n2}", lc.monto, Chr(13), Suma, lc.monto - Suma)))
                    lc.AgregarError(15, "No Existe en el CHITCI")

                End If


            Else
                

                Dim ExisteCabecera = (From word In dxe _
             Where word.nro_lote = lc.nro_lote And word.EsCabecera And word.cod_maquina = lc.cod_maquina).FirstOrDefault

                If ExisteCabecera Is Nothing Then
                    r.ErrorText = "El registro no tiene cabecera."
                    ExisteError = True
                    lc.AgregarError(9, "El registro no tiene cabecera.")
                Else
                    If (oper = Operacion.Recibido) AndAlso ExisteCabecera.cod_banco_emisor <> lc.cod_banco_emisor Then
                        r.Cells(6).ErrorText = "El banco no corresponde a la cabecera."
                        ExisteError = True
                        lc.AgregarError(8, "El banco no corresponde a la cabecera.")

                    End If

                End If


            End If

            'Validamos los sucursales
            If lc.cod_sucursal IsNot Nothing Then

                Dim ExisteSucursal = (Aggregate word In Sucursales _
            Into Any(word.cod_sucursal = lc.cod_sucursal))


                If Not ExisteSucursal Then
                    r.ErrorText = "No existe la Sucursal indicada."
                    ExisteError = True
                    lc.AgregarError(14, "No existe la Sucursal indicada.")

                End If

            End If


            'Validamos los bancos

            Dim ExisteBanco = (Aggregate word In Bancos _
            Into Any(word.cod_banco = lc.cod_banco_receptor)) And _
            (Aggregate word In Bancos _
            Into Any(word.cod_banco = lc.cod_banco_emisor))

            If Not ExisteBanco Then
                r.ErrorText = "No existe el banco indicado."
                ExisteError = True
                lc.AgregarError(10, "No existe el banco indicado.")

            End If

            'Validamos el Tipo de documento
            Dim ExisteDocumento = (Aggregate word In TipoDoc _
            Into Any(word.cod_tipdoc = lc.cod_tipdoc))

            If Not ExisteDocumento Then
                r.ErrorText = "No existe el tipo de documento indicado."
                ExisteError = True
                lc.AgregarError(11, "No existe el tipo de documento indicado.")

            End If

            'Validamos el Tipo de documento
            Dim ExisteCamara = (Aggregate word In Camaras _
            Into Any(word.cod_camara = lc.cod_camara))

            If Not ExisteCamara Then
                r.ErrorText = "No existe la camara indicada."
                ExisteError = True
                lc.AgregarError(12, "No existe la camara indicada.")

            End If

            'Validamos los cheques Devueltos y Enviados
            If Not lc.EsCabecera And (lc.cod_proceso = 1 Or lc.cod_proceso = 4) Then

                Dim ExisteCheque = (From l In dm.Lecturas _
                                    Where (l.numero_cheque = lc.numero_cheque _
                And l.cod_banco_receptor = lc.cod_banco_receptor _
                And Not lc.EsCabecera _
                And l.IdLectura <> lc.IdLectura _
                And l.cod_banco = codBanco _
                And l.cod_moneda = CodMoneda And l.fecha_lectura = FechaAnterior And l.cod_proceso = procesoRechazadoDevuelto)).FirstOrDefault

                If ExisteCheque Is Nothing Then
                    r.ErrorText = "El cheque no existe en el proceso anterior."
                    ExisteError = True
                    lc.AgregarError(13, "El cheque no existe en el proceso anterior.")
                Else
                    If lc.cuenta_deposito Is Nothing OrElse lc.cuenta_deposito.TrimEnd.Length <= 1 Then
                        lc.cuenta_deposito = ExisteCheque.cuenta_deposito
                    End If
                End If

            End If

            'Validamos Cuenta 1 para devueltos
            If Not lc.EsCabecera And oper = Operacion.Devuelto And lc.cuenta_deposito IsNot Nothing Then
                If lc.cuenta_deposito.TrimEnd() = "1" Then
                    r.ErrorText = "La cuenta de deposito debe ser distinto a 1."
                    ExisteError = True
                    lc.AgregarError(15, "La cuenta de deposito debe ser distinto a 1.")
                End If
            End If

            'Validamos Cuenta en cabecera en enviados
            'Para el banco 06-Citi
            If lc.cod_banco = "06" And lc.EsCabecera And oper = Operacion.Enviado And lc.cuenta_cheque IsNot Nothing Then

                If lc.cuenta_cheque <= 0 Then
                    'r.ErrorText = "La cuenta de deposito debe ser distinto a 1."
                    ExisteError = True
                    lc.AgregarError(13, "La cuenta de deposito debe ser mayor a 0.")
                    lc.AddError("cuenta_cheque", "La cuenta de deposito debe ser mayor a 0.")
                End If

                If lc.numero_cheque <= 0 Then
                    'r.ErrorText = "La cuenta de deposito debe ser distinto a 1."
                    ExisteError = True
                    lc.AgregarError(6, "El Nro de Serie debe ser mayor a 0.")
                    lc.AddError("numero_cheque", "El Nro de Serie debe ser mayor a 0.")
                End If

            End If


            ''Se aplica solamente cuando el error es 7 - Diferencia de Cabecera
            If lc.NroError = 7 Then
                lc.CORREGIDO = True
            Else
                lc.CORREGIDO = Not ExisteError
            End If

            lc.ConError = ExisteError
            lc.IB_MONTO = ExisteError

            If ExisteError Then
                cErrores += 1
                'Me.LecturasDataGridView.UpdateCellValue
                ' Me.LecturasBindingSource.ResetCurrentItem()
            End If

            ExisteError = False




        Next
        Return cErrores
    End Function

    Shared Sub ValidarItem(ByVal item As DataGridViewRow)
        'Validar not null
        'VG 07/05/08 
        'Puede venir un item null, si es que se hace clic afuera de la grilla
        'cuando se esta editando
        If item Is Nothing OrElse item.DataBoundItem Is Nothing Then
            Return
        End If
        Dim results As ValidationResults
        results = Validator.Validate(item.DataBoundItem)

        'Limpiamos el Error al editar el registro
        item.ErrorText = ""
        If Not results.IsValid Then
            For Each result As ValidationResult In results
                item.ErrorText = item.ErrorText + "-" + result.Message
            Next
        End If
        CType(item.DataBoundItem, Lecturas).CORREGIDO = results.IsValid

        ' CType(item.DataBoundItem, Lecturas).CORREGIDO = results.IsValid

    End Sub
#End Region
End Class
