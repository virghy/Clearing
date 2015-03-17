Public Class Logger
    Private Const NombreArchivo As String = "Registro.xml"
    Private Shared _dt1 As New ClearingDs.LecturasDataTable

    Private Shared ReadOnly Property dt1 As ClearingDs.LecturasDataTable
        Get
            If _dt1 Is Nothing Then
                _dt1 = New ClearingDs.LecturasDataTable
            End If
            Return _dt1
        End Get
    End Property

    Public Shared Sub LimpiarLog()
        Dim o As New ClearingDs.LecturasDataTable
        o.WriteXml(IO.Path.Combine(My.Application.Info.DirectoryPath, NombreArchivo))
        dt1.Clear()
    End Sub

    Public Shared Function Leer() As List(Of DataAccess.Lecturas)
        Dim list As New List(Of DataAccess.Lecturas)

        If Not IO.File.Exists(IO.Path.Combine(My.Application.Info.DirectoryPath, NombreArchivo)) Then
            Return list
        End If

        Dim o As New ClearingDs.LecturasDataTable
        o.ReadXml(IO.Path.Combine(My.Application.Info.DirectoryPath, NombreArchivo))

        For Each l As ClearingDs.LecturasRow In o.Rows
            Dim r As New DataAccess.Lecturas
            r.fecha_lectura = l.fecha_lectura
            r.nro_lote = l.nro_lote
            r.cod_camara = l.cod_camara
            r.cod_banco = l.cod_banco

            If Not l.Iscod_sucursalNull Then
                r.cod_sucursal = l.cod_sucursal
            End If

            r.cod_tipdoc = l.cod_tipdoc

            If Not l.Iscuenta_chequeNull Then
                r.cuenta_cheque = l.cuenta_cheque
            End If

            If Not l.Isnumero_chequeNull Then
                r.numero_cheque = l.numero_cheque
            End If

            If Not l.Iscod_banco_receptorNull Then
                r.cod_banco_receptor = l.cod_banco_receptor
            End If

            If Not l.Iscod_banco_emisorNull Then
                r.cod_banco_emisor = l.cod_banco_emisor
            End If

            If Not l.Iscuenta_depositoNull Then
                r.cuenta_deposito = l.cuenta_deposito
            End If

            If Not l.IsmontoNull Then
                r.monto = l.monto
            End If

            If Not l.Isimagen_frontalNull Then
                r.imagen_frontal = l.imagen_frontal
            End If

            If Not l.Isimagen_reversoNull Then
                r.imagen_reverso = l.imagen_reverso
            End If


            If Not l.IscabeceraNull Then
                r.cabecera = l.cabecera
            End If

            r.VERIFICADO = l.VERIFICADO

            'r.IB_SER = l.IB_SER
            'r.IB_MONTO = l.IB_MONTO

            r.CORREGIDO = l.CORREGIDO

            If Not l.IsPAQUETENull Then
                r.PAQUETE = l.PAQUETE
            End If

            r.ENVIADO = l.ENVIADO
            r.MANO = l.MANO

            If Not l.Iscod_maquinaNull Then
                r.cod_maquina = l.cod_maquina
            End If

            If Not l.Isnro_corridaNull Then
                r.nro_corrida = l.nro_corrida
            End If

            If Not l.Isnro_bolsilloNull Then
                r.nro_bolsillo = l.nro_bolsillo
            End If

            r.cadena_captura = l.cadena_captura

            If Not l.Isaudit_usuarioNull Then
                r.audit_usuario = l.audit_usuario
            End If

            r.audit_fecha = l.audit_fecha

            If Not l.Iscod_procesoNull Then
                r.cod_proceso = l.cod_proceso
            End If

            If Not l.IscajeroNull Then
                r.cajero = l.cajero
            End If


            If Not l.IsoperadorNull Then
                r.operador = l.operador
            End If

            If Not l.IsobservacionesNull Then
                r.observaciones = l.observaciones
            End If

            If Not l.Isnro_boletaNull Then
                r.nro_boleta = l.nro_boleta
            End If

            r.cod_moneda = l.cod_moneda

            If Not l.IsIdMotivoNull Then
                r.IdMotivo = l.IdMotivo
            End If

            If Not l.IsMontoComisionNull Then
                r.MontoComision = l.MontoComision
            End If

            If Not l.IsMontoIVANull Then
                r.MontoIVA = l.MontoIVA
            End If

            If Not l.IsCodTransComisionNull Then
                r.CodTransComision = l.CodTransComision
            End If

            If Not l.IsCodTransIVANull Then
                r.CodTransIVA = l.CodTransIVA
            End If

            If Not l.IsIdClasificacionNull Then
                r.IdClasificacion = l.IdClasificacion
            End If

            If Not l.IsEditadoNull Then
                r.Editado = l.Editado
            End If

            If Not l.IsCantChequesNull Then
                r.CantCheques = l.CantCheques
            End If

            If Not l.IsCDNull Then
                r.CD = l.CD
            End If

            list.Add(r)

        Next
        Return list
    End Function



    Public Shared Sub Grabar(l As DataAccess.Lecturas)
        'CrearDT()

        'If dt Is Nothing Then
        '    dt = New ClearingDs.LecturasDataTable
        'End If

        Dim r As ClearingDs.LecturasRow = dt1.NewLecturasRow

        r.fecha_lectura = l.fecha_lectura
        r.nro_lote = l.nro_lote
        r.cod_camara = l.cod_camara
        r.cod_banco = l.cod_banco

        If l.cod_sucursal.HasValue Then
            r.cod_sucursal = l.cod_sucursal
        End If

        r.cod_tipdoc = l.cod_tipdoc

        If l.cuenta_cheque.HasValue Then
            r.cuenta_cheque = l.cuenta_cheque
        End If

        If l.numero_cheque.HasValue Then
            r.numero_cheque = l.numero_cheque
        End If

        r.cod_banco_receptor = l.cod_banco_receptor
        r.cod_banco_emisor = l.cod_banco_emisor
        r.cuenta_deposito = l.cuenta_deposito

        If l.monto.HasValue Then
            r.monto = l.monto
        End If

        r.imagen_frontal = l.imagen_frontal
        r.imagen_reverso = l.imagen_reverso

        If l.cabecera.HasValue Then
            r.cabecera = l.cabecera
        End If

        r.VERIFICADO = l.VERIFICADO
        r.IB_SER = l.IB_SER
        r.IB_MONTO = l.IB_MONTO
        r.CORREGIDO = l.CORREGIDO

        If l.PAQUETE.HasValue Then
            r.PAQUETE = l.PAQUETE
        End If

        r.ENVIADO = l.ENVIADO
        r.MANO = l.MANO

        If l.cod_maquina.HasValue Then
            r.cod_maquina = l.cod_maquina
        End If

        If l.nro_corrida.HasValue Then
            r.nro_corrida = l.nro_corrida
        End If

        If l.nro_bolsillo.HasValue Then
            r.nro_bolsillo = l.nro_bolsillo
        End If

        r.cadena_captura = l.cadena_captura

        If l.audit_usuario.HasValue Then
            r.audit_usuario = l.audit_usuario
        End If

        r.audit_fecha = l.audit_fecha

        If l.cod_proceso.HasValue Then
            r.cod_proceso = l.cod_proceso
        End If

        r.cajero = l.cajero

        If l.operador.HasValue Then
            r.operador = l.operador
        End If

        r.observaciones = l.observaciones
        r.nro_boleta = l.nro_boleta
        r.cod_moneda = l.cod_moneda
        r.IdMotivo = l.IdMotivo

        If l.MontoComision Then
            r.MontoComision = l.MontoComision
        End If

        If l.MontoIVA Then
            r.MontoIVA = l.MontoIVA
        End If

        r.CodTransComision = l.CodTransComision

        r.CodTransIVA = l.CodTransIVA
        If l.IdClasificacion.HasValue Then
            r.IdClasificacion = l.IdClasificacion
        End If

        If l.Editado.HasValue Then
            r.Editado = l.Editado
        End If

        If l.CantCheques.HasValue Then
            r.CantCheques = l.CantCheques
        End If

        If l.CD.HasValue Then
            r.CD = l.CD
        End If

        dt1.AddLecturasRow(r)

        dt1.WriteXml(IO.Path.Combine(My.Application.Info.DirectoryPath, NombreArchivo))

    End Sub
 

End Class
