Imports MICR
Imports MICR.CanonAPIbase
Imports DataAccess
Imports System.Threading
'Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Validation
Imports Microsoft.Practices.EnterpriseLibrary.Validation.Validators
Imports Microsoft.Data.Extensions
Imports Sorteable
Imports System.IO
Imports WindowsControlLibrary

'Imports Equin.ApplicationFramework


'24-03-09 VG
'Grabar en ProcesarLectura, por si se haya modifica la secuencia

Public Class frmRecibido
    Dim dm As New Entities
    Dim MICR As MICR.CanonAPIbase
    Dim file As CEIIMAGEFILEINFO
    Dim Editado As Boolean = False
    Dim WithEvents frmProgreso As New ProgresoScaneo
    Dim FilePath As String
    Dim ConfigFilePath As String = IO.Path.Combine(My.Application.Info.DirectoryPath, CanonAPIbase.CONFIG_FILE)
    '   Dim CabList As IQueryable(Of Lecturas)
    Dim dxe As New Sorteable.FilteredBindingList(Of Lecturas)(dm)
    '   Dim oCabecera As DataAccess.Cabeceras
    '  Dim oDet As DataAccess.Detalle_Cheques
    'Dim CabList As List(Of Cabeceras)
    'Dim DetList As List(Of Detalle_Cheques)
    Dim _NroLote As Integer = 0
    Dim Fecha As Date = Date.Today
    Dim CodMaquina As Integer = My.MySettings.Default.Maquina
    Dim CodCamara As String = HostVB.My.MySettings.Default.Camara
    Dim codBanco As String = "05"
    Dim Oper As Operacion = HostVB.Operacion.Recibido
    Dim validator As Validator(Of Lecturas) = ValidationFactory.CreateValidator(Of Lecturas)()
    Dim results As ValidationResults
    'Dim Bancos As List(Of Bancos) = dm.Bancos.Where(Function(p) p.Activo = True).ToList
    'Dim TipoDoc As List(Of Tipo_Documentos) = dm.Tipo_Documentos.ToList
    'Dim Camaras As List(Of Camara) = dm.Camaras.ToList
    Dim Sucursales As List(Of Sucursales)
    Dim msgBorrar As Boolean = True
    Dim confirmaBorrar As Boolean = True
    Dim Moneda As MICR.Moneda
    Dim configMICR As ConfigMICR
    Dim SubTotal As Decimal = 0
    Dim listaCREC As New List(Of CREC)



    Sub New(ByVal Camara As String, ByVal Maquina As String, ByVal Operacion As Operacion)
        Me.New()
        Me.lnkFecha.Text = "Fecha Proceso: " + Me.Fecha.ToShortDateString()
        codBanco = My.MySettings.Default.IdEmpresa
        CodCamara = Camara
        Oper = Operacion

        Dim IdProceso As Integer = Oper
        Me.configMICR = dm.ConfigMICR.FirstOrDefault(Function(p) p.IdBanco = codBanco And p.IdProceso = IdProceso)

        Me.ColumnLote.FilteringEnabled = True
        Me.clBanco.FilteringEnabled = True
        Me.DataGridViewTextBoxColumn4.FilteringEnabled = True
        Me.DataGridViewTextBoxColumn5.FilteringEnabled = True
        Me.tbcSerie.FilteringEnabled = True
        Me.clReceptor.FilteringEnabled = True
        Me.DataGridViewTextBoxColumn8.FilteringEnabled = True
        Me.Importe.FilteringEnabled = True
        Me.cod_sucursal.FilteringEnabled = True
        Me.DataGridViewTextBoxColumn12.FilteringEnabled = True
        Me.IdMotivo.FilteringEnabled = True
        Me.cuenta_deposito.FilteringEnabled = True

        Me.LecturasDataGridView.AllowUserToAddRows = False

        'Me.ConError.FilteringEnabled = True

        Me.Sucursales = dm.Sucursales.Where(Function(p) p.cod_banco = codBanco).ToList()
        Me.ConfigurarCREC()

    End Sub

    Function ConfigCarpetaImagen() As Boolean

        FilePath = My.Settings.CarpetaImagen
        If Not FilePath.StartsWith("\\") Then
            If FilePath.Substring(1, 1) <> ":" Then
                FilePath = Path.Combine(My.Application.Info.DirectoryPath, FilePath)
            End If

        End If
        ' MsgBox(FilePath)
        Dim di As DirectoryInfo = New DirectoryInfo(FilePath)
        Try
            ' Determine whether the directory exists.
            If di.Exists Then
                ' Indicate that it already exists.
                Return True
            End If

            ' Try to create the directory.
            di.Create()
            'Console.WriteLine("The directory was created successfully.")

            '' Delete the directory.
            'di.Delete()
            'Console.WriteLine("The directory was deleted successfully.")

        Catch e As Exception
            MsgBox(String.Format("No se pudo crear o acceder a la carpeta: {0}", FilePath), MsgBoxStyle.Exclamation)
            Return False
        End Try

        Return True
    End Function

    Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        SetearImagen()
        Me.TableLayoutPanel3.RowStyles(3).SizeType = SizeType.AutoSize

        'MICR.CanonAPI.CsdStartScan()
        '        'Seguir la secuencia

        '1. Call the CsdProbe function in the "Initialize" category.
        '2. Call functions in the "Set scanner mode" or "Monitor scanner mode" category.
        '3. Call the CsdStartScan function in the "Scan" category.
        '4. Call the CsdReadPage function in the "Read page" category. Repeat this step until the function returns CSD_NOPAPER. (See the "List of error codes" section for details.)
        'To obtain information of a document such as MICR data, use the CsdParGet function after calling the CsdReadPage function.
        '5. Call the CsdTerminate function in the “Terminate” category.

        'Me.CabeceraBindingSource.DataSource = dm.Cabeceras

        'If dm.Cabeceras.Count > 0 Then
        '    Dim cab = CType(Me.CabeceraBindingSource.Item(0), Cabeceras)
        '    cab.Detalle_Cheques.Load()
        '    Me.Detalle_ChequesBindingSource.DataSource = cab.Detalle_Cheques
        'End If

        'Me.CabecerasBindingSource.DataSource = dm.Cabeceras
        'Me.Detalle_ChequesDataGridView.DataSource = Me.CabeceraBindingSource
        ' Me.Detalle_ChequesDataGridView.DataMember = "Detalle_Cheques"

        'Inicializamos el Nro de Lote




        'Me.CargarDatos()

        '   Me.LecturasBindingSource.Sort = "Nro_Lote ASC, Cabecera ASC"
        'Me.ProcesarLectura()
    End Sub

    Sub AsignarLote()
        Try

            'Dim MaxNroLote As Integer = (Aggregate c In dm.Lecturas _
            '           Where c.fecha_lectura = Fecha And c.cod_maquina = CodMaquina And c.cod_proceso = Operacion Into Max(c.nro_lote))
            Using dm.Connection.CreateConnectionScope
                Dim UltimoNroLote = dm.CreateStoreCommand("Select Max(Nro_Lote) from lecturas where fecha_lectura = @Fecha and cod_maquina = @CodMaquina " _
                                                                 + " and cod_proceso = @Proceso and Cod_Moneda=@Moneda and cod_banco=@Banco", _
                                                                  New SqlClient.SqlParameter("Fecha", Fecha), _
                                                                   New SqlClient.SqlParameter("CodMaquina", CodMaquina), _
                                                                   New SqlClient.SqlParameter("Proceso", Oper), _
                                                                   New SqlClient.SqlParameter("Moneda", Moneda.CodMoneda), _
                                                                   New SqlClient.SqlParameter("Banco", Me.codBanco)).ExecuteScalar


                NroLote = IIf(UltimoNroLote Is Nothing, 0, UltimoNroLote)

            End Using

        Catch ex As Exception

        End Try
    End Sub

    Sub iniciarLecturaPrueba()
        Dim data As String
        Dim mG As MICRGeneral = Nothing
        data = "C3900E000000156523E03512752A050100000000149312B"    'Cheques con longitud mayor
        data = "C3900E0900050147E00822399A210100000003000000B" 'Cheques con longitud menor en cuenta
        'data = "C4190E000000979665E00000042A00000010000000B"       'Cabecera con Nro de Boleta
        'data = "C0590E000003181008E00000007945326B"                 'Cabecera sin Nro de boleta
        'data = "C0600E000038050028E00012134A00000001000000@" 'Cheque magnetizado sin banco y camara
        data = "C3900E000900050147E00822399A210100000003000000" 'Cheques SIN TERMINADOR
        data = "E000900050147E00822399A210100000003000000" 'Cheques SIN TIPO DE DOCUMENTO
        data = "C0790E10029118@841E00000001035190B" 'Cabecera BBVA
        'data = "C0790E010072111969E070100000091766636B" 'Cabecera Walter
        'data = "C@0800E000151316892E00955643A07010000000249539@" 'Cheque con longitud mayor 
        data = "C0800E000151316892E00955643A070100000002495390B" 'Cheque correcto
        'data = "C2800E000007002902E12739513A@07@010000004345367@"
        'If data.Length > 0 Then
        mG = New MICRGeneral(data, Moneda, configMICR)
        Me.Grabar(mG, 2)
    End Sub

    Sub IniciarLectura()
        'iniciarLecturaPrueba()
        'Return

        'Me.ToolStrip1.Enabled = False
        '  IO.Directory.SetCurrentDirectory("C:\Program Files\Canon Electronics\CR180")
        'If Me.LecturasDataGridView.InvokeRequired Then

        '    Dim newDelegate As New UIDelegate(AddressOf IniciarLectura)
        '    Me.LecturasDataGridView.Invoke(newDelegate)
        'Else
        Dim progressChunk As Integer = 0


        'Dim frmProgreso As New ProgresoScaneo
        'frmProgreso.Show()

        Dim result As Integer
        Dim Pagina As Integer = 0
        Dim data As String
        Dim mG As MICRGeneral = Nothing
        Dim NombreImagen As String
        Dim NroImagen As Integer
        result = MICR.CsdProbe()

        If result <> 0 Then Me.MostrarError(result)


        Dim img As MICR.CanonAPIbase.CEIIMAGEINFO
        img.cbSize = Len(img)

        'If result = 0 Then
        '    result = MICR.CanonAPI.CsdParSet(MICR.CanonAPI.CSDP_SAVE_CONFIG_FILE, ConfigFilePath)
        '    Me.MostrarError(result)
        'End If

        If result = 0 Then
            result = MICR.CsdParSet(CanonAPIbase.CSDP_LOAD_CONFIG_FILE, ConfigFilePath)
            If result <> 0 Then Me.MostrarError(result)
        End If
        If result = 0 Then

            ' result = MICR.CsdParSet(CanonAPIbase.CSDP_AUTOSIZE, 1)
            ' Me.MostrarError(result)
        End If

        If result = 0 Then

            'result = MICR.SetCSDP_MODE(CSDP_MODEAttribute.CSD_GRAYSCALE)
            'Me.MostrarError(result)
        End If

        If result = 0 Then
            result = MICR.CsdStartScan(Nothing, Nothing, Nothing)
            If result <> 0 Then Me.MostrarError(result)
        End If

        If result = 0 Then
            result = MICR.CsdReadPage(img)
        End If

        While result = CSD_OK
            Pagina = Pagina + 1

            progressChunk += 1

            'If (progressChunk > 5) Then
            '    System.Threading.Thread.Sleep(100)
            '    progressChunk = 0
            'End If


            'Lee la imagen

            'Lee los datos solo para los valores impares
            If System.Decimal.Remainder(Pagina, 2) <> 0 Then
                data = Me.LeerMICR()
                ' MsgBox(Me.LeerOCR)
                'data = "C1100E000001731904E06184058A050100000001283027B"
                'If data.Length > 0 Then
                mG = New MICRGeneral(data, Moneda, configMICR)
                'End If
                NroImagen = Util.NEWID(dm, "NROIMAGEN")
                NombreImagen = "GF" + NroImagen.ToString + ".jpg"
            Else
                NombreImagen = "GR" + NroImagen.ToString + ".jpg"
            End If
            result = MICR.CsdSaveImageEx(img, file, IO.Path.Combine(FilePath, NombreImagen))
            'Me.GrabarImagen(Pagina, img)
            MICR.CsdReleaseImage(img)

            'Movemos aca la verificacion 
            If result = 0 Then
                result = MICR.CsdReadPage(img)
            Else
                Me.MostrarError(result)
                Exit While
            End If

            If Not mG Is Nothing Then
                mG.AsignarImagen(NombreImagen)
                If mG.Tipo = TipoMICR.Cabecera Then
                    ' Worker.ReportProgress(Pagina)
                End If

            End If

            If System.Decimal.Remainder(Pagina, 2) = 0 Then
                Me.Grabar(mG, Pagina)
            End If



            '   result = MICR.CanonAPI.CsdStartScan(Nothing, Nothing, Nothing)
        End While

        'result = MICR.CanonAPI.CsdParSet(MICR.CanonAPI.CSDP_DISPLAY_VIEW_FRONT, MICR.CanonAPI.VarPtr(img))




        If result = CanonAPIbase.CSD_OK Then
            result = MICR.CsdReleaseImage(img)
        Else
            Me.MostrarError(result)
        End If
        result = MICR.CsdTerminate()

        '   End If
    End Sub
    Sub IniciarLecturaAsync()
        If MICR Is Nothing Then
            MICR = My.Application.Scanner
        End If
        '  IO.Directory.SetCurrentDirectory("C:\Program Files\Canon Electronics\CR180")
        If Me.LecturasDataGridView.InvokeRequired Then

            Dim newDelegate As New UIDelegate(AddressOf IniciarLectura)
            Me.LecturasDataGridView.Invoke(newDelegate)
        Else

            Dim frmProgreso As New ProgresoScaneo
            frmProgreso.Show()

            Dim result As Integer
            Dim Pagina As Integer = 0
            Dim data As String
            Dim mG As MICRGeneral = Nothing
            Dim NombreImagen As String
            Dim NroImagen As Integer
            result = MICR.CsdProbe()

            Me.MostrarError(result)

            Dim img As MICR.CanonAPIbase.CEIIMAGEINFO
            img.cbSize = Len(img)

            'If result = 0 Then
            '    result = MICR.CanonAPI.CsdParSet(MICR.CanonAPI.CSDP_SAVE_CONFIG_FILE, ConfigFilePath)
            '    Me.MostrarError(result)
            'End If

            If result = 0 Then
                result = MICR.CsdParSet(CanonAPIbase.CSDP_LOAD_CONFIG_FILE, ConfigFilePath)
                Me.MostrarError(result)
            End If
            If result = 0 Then

                ' result = MICR.CsdParSet(CanonAPIbase.CSDP_AUTOSIZE, 1)
                Me.MostrarError(result)
            End If

            If result = 0 Then

                'result = MICR.SetCSDP_MODE(CSDP_MODEAttribute.CSD_GRAYSCALE)
                Me.MostrarError(result)
            End If

            If result = 0 Then
                result = MICR.CsdStartScan(Nothing, Nothing, Nothing)
                Me.MostrarError(result)
            End If

            If result = 0 Then
                result = MICR.CsdReadPage(img)
            End If

            While result = CSD_OK
                Pagina = Pagina + 1
                frmProgreso.Label1.Text = String.Format("Escaneando {0}", (Pagina / 2).ToString("N0"))
                frmProgreso.Refresh()

                'Lee la imagen

                'Lee los datos solo para los valores impares
                If System.Decimal.Remainder(Pagina, 2) <> 0 Then
                    data = Me.LeerMICR()
                    'data = "C1100E000001731904E06184058A050100000001283027B"
                    'If data.Length > 0 Then
                    mG = New MICRGeneral(data, Moneda, configMICR)
                    'End If
                    NroImagen = Util.NEWID(dm, "NROIMAGEN")
                    NombreImagen = "GF" + NroImagen.ToString + ".jpg"
                Else
                    NombreImagen = "GR" + NroImagen.ToString + ".jpg"
                End If
                result = MICR.CsdSaveImageEx(img, file, IO.Path.Combine(FilePath + "\Images", NombreImagen))
                'Me.GrabarImagen(Pagina, img)

                'Movemos aca la verificacion 
                If result = 0 Then
                    result = MICR.CsdReadPage(img)
                Else
                    Me.MostrarError(result)
                    Exit While
                End If

                If Not mG Is Nothing Then
                    mG.AsignarImagen(NombreImagen)
                    If mG.Tipo = TipoMICR.Cabecera Then
                        ' Worker.ReportProgress(Pagina)
                    End If

                End If

                If System.Decimal.Remainder(Pagina, 2) = 0 Then
                    Me.Grabar(mG, Pagina)
                End If



                '   result = MICR.CanonAPI.CsdStartScan(Nothing, Nothing, Nothing)
            End While

            'result = MICR.CanonAPI.CsdParSet(MICR.CanonAPI.CSDP_DISPLAY_VIEW_FRONT, MICR.CanonAPI.VarPtr(img))




            If result = CanonAPIbase.CSD_OK Then
                result = MICR.CsdReleaseImage(img)
            Else
                Me.MostrarError(result)
            End If
            result = MICR.CsdTerminate()
            frmProgreso.Hide()
            frmProgreso.Dispose()
        End If
    End Sub

    Sub grabar(ByVal mg As MICRGeneral, ByVal pagina As Integer)
        Try


            Dim lectura As New Lecturas

            'Los datos comunes
            lectura.fecha_lectura = Fecha
            lectura.cod_maquina = CodMaquina
            lectura.audit_fecha = Date.Now
            lectura.cod_banco = codBanco
            lectura.cod_moneda = Moneda.CodMoneda
            lectura.cod_sucursal = Me.cboSucursal.SelectedValue
            lectura.cajero = Me.cboCajero.SelectedValue

            lectura.CORREGIDO = True
            lectura.cod_proceso = Oper
            lectura.VERIFICADO = True
            'lectura.audit_usuario = My.User.Name

            'Asignamos el IdLectura Manualmente
            'VG 16/12/2009
            lectura.IdLectura = Util.NEWID(dm, "IdLectura")



            If mg.Tipo = TipoMICR.Cabecera Then
                NroLote += 1
                ' lectura.cabecera = NroLote
                'Me.nudLote.Value += 1
                lectura.nro_lote = NroLote
                lectura.cod_banco_receptor = mg.Cabecera.Banco
                lectura.cod_camara = CodCamara
                lectura.numero_cheque = mg.Cabecera.Cheque

                'Verificamos si vino la sucursal en la cabecera
                If mg.Cabecera.Sucursal IsNot Nothing Then
                    lectura.cod_sucursal = mg.Cabecera.Sucursal
                    Me.cboSucursal.SelectedValue = lectura.cod_sucursal
                End If

                If Oper = Operacion.Recibido Then
                    lectura.cod_banco_emisor = codBanco
                Else
                    lectura.cod_banco_emisor = mg.Cabecera.Banco
                End If

                lectura.cod_tipdoc = mg.Cabecera.Cpbt
                lectura.cuenta_cheque = mg.Cabecera.Cuenta
                lectura.cadena_captura = mg.Cabecera.Cadena
                lectura.monto = mg.Cabecera.Importe
                lectura.imagen_frontal = mg.Cabecera.Imagen

                ' Me.LecturasDataGridView.Refresh()

                'CabList.Add(oCabecera)
                'dm.AddToCabeceras(oCabecera)

                'Me.LecturasDataGridView.Rows.Add()

                'CType(Me.CabeceraBindingSource.DataSource, List(Of Cabeceras)).Add(oCabecera)
                '  Me.CabecerasDataGridView.Refresh()

            Else
                lectura.cabecera = NroLote
                lectura.nro_lote = NroLote

                lectura.cod_banco_receptor = mg.Detalle.BancoE
                lectura.cod_banco_emisor = mg.Detalle.BancoR
                lectura.cod_camara = mg.Detalle.Camara

                'Guardamos el codigo del motivo de rechazo.
                'VG 05/11/09
                If Oper = Operacion.Devuelto Then
                    Dim motivo As MotivosRechazo = Me.cboMotivo.SelectedItem
                    lectura.IdMotivo = motivo.IdMotivo
                    AplicarComision(lectura, motivo)
                End If

                'If Oper = Operacion.Recibido Then
                '    lectura.cod_banco_receptor = mg.Detalle.BancoE
                '    lectura.cod_banco_emisor = mg.Detalle.BancoR
                'End If

                'If Oper = Operacion.Enviado Then
                '    lectura.cod_banco_receptor = mg.Detalle.BancoE
                '    lectura.cod_banco_emisor = mg.Detalle.BancoR
                'End If




                lectura.cod_tipdoc = mg.Detalle.Cpbt
                lectura.cuenta_cheque = mg.Detalle.Cuenta
                lectura.numero_cheque = mg.Detalle.Cheque
                lectura.monto = mg.Detalle.Importe
                lectura.imagen_frontal = mg.Detalle.Imagen
                lectura.imagen_reverso = mg.Detalle.Imagen1
                lectura.cadena_captura = mg.Detalle.CadenaDet
                'dm.AddToDetalle_Cheques(oDet)
                'oCabecera.Detalle_Cheques.Add(oDet)
                'DetList.Add(oDet)
                ' Me.Detalle_ChequesDataGridView.Refresh()

            End If
            If lectura.cadena_captura.IndexOf("@") >= 0 Then
                lectura.CORREGIDO = False
            End If

            ' Me.LecturasBindingSource.Add(lectura)
            Me.Worker.ReportProgress(pagina, lectura)

        Catch ex As Exception
            'If Not ex.InnerException Is Nothing Then
            '    MsgBox(ex.InnerException.Message)
            'Else
            'MsgBox(ex.Message)
            'End If

            MsgBox(Util.EnumErrors(ex))

        End Try
    End Sub

    'Sub grabarOriginal(ByVal mg As MICRGeneral)
    '    Try
    '        If mg.Tipo = TipoMICR.Cabecera Then

    '            NroLote += 1

    '            oCabecera = New DataAccess.Cabeceras

    '            oCabecera.fecha_lectura = Fecha
    '            oCabecera.cod_maquina = CodMaquina
    '            oCabecera.nro_lote = NroLote
    '            oCabecera.cod_banco_receptor = mg.Cabecera.Banco
    '            oCabecera.cod_tipdoc = mg.Cabecera.Cpbt
    '            oCabecera.cuenta_deposito = mg.Cabecera.Cuenta
    '            oCabecera.cadena_captura = mg.Cabecera.Cadena
    '            oCabecera.monto_total = mg.Cabecera.Importe
    '            oCabecera.imagen_frontal = mg.Cabecera.Imagen
    '            Me.LecturasBindingSource.Add(New Lecturas)

    '            ' Me.LecturasDataGridView.Refresh()

    '            'CabList.Add(oCabecera)
    '            'dm.AddToCabeceras(oCabecera)

    '            'Me.LecturasDataGridView.Rows.Add()

    '            'CType(Me.CabeceraBindingSource.DataSource, List(Of Cabeceras)).Add(oCabecera)
    '            '  Me.CabecerasDataGridView.Refresh()

    '        Else
    '            If oCabecera Is Nothing Then
    '                oCabecera = New DataAccess.Cabeceras
    '                oCabecera.fecha_lectura = Fecha
    '                oCabecera.cod_maquina = CodMaquina
    '                oCabecera.nro_lote = NroLote
    '                oCabecera.cod_tipdoc = "90"
    '                'CabList.Add(oCabecera)
    '                Me.LecturasBindingSource.Add(New Lecturas)

    '                '   dm.AddToCabeceras(oCabecera)
    '            End If

    '            oDet = New DataAccess.Detalle_Cheques
    '            oDet.cod_banco_emisor = mg.Detalle.BancoE
    '            oDet.cod_banco_receptor = mg.Detalle.BancoR
    '            oDet.cod_tipdoc = mg.Detalle.Cpbt
    '            oDet.numero_cuenta_librador = mg.Detalle.Cuenta
    '            oDet.numero_cheque = mg.Detalle.Cheque
    '            oDet.monto_cheque = mg.Detalle.Importe
    '            oDet.imagen_frontal_ch = mg.Detalle.Imagen
    '            oDet.imagen_reverso_ch = mg.Detalle.Imagen1
    '            oDet.cadena_captura = mg.Detalle.CadenaDet
    '            'dm.AddToDetalle_Cheques(oDet)
    '            'oCabecera.Detalle_Cheques.Add(oDet)
    '            'DetList.Add(oDet)
    '            ' Me.Detalle_ChequesDataGridView.Refresh()

    '        End If



    '    Catch ex As Exception
    '        If Not ex.InnerException Is Nothing Then
    '            MsgBox(ex.InnerException.Message)
    '        Else
    '            MsgBox(ex.Message)
    '        End If

    '    End Try
    'End Sub

    Sub SetearImagen()
        file.cbSize = Len(file)
        file.nFileType = CanonAPIbase.CSD_JPEG_FILE
        file.nCompType = CanonAPIbase.CSD_COMP_JPEG
        file.nJpegQuality = 70
    End Sub

    Function GrabarImagen(ByVal pagina, ByVal img) As String
        ''Para grabar en disco la imagen
        Dim result As Int32

        Dim FileName As String

        FileName = FilePath + "\Images" + pagina.ToString.Trim + ".jpg"
        result = MICR.CsdSaveImageEx(img, file, FileName)
        Return FileName

        'Try
        '    If Me.PictureBox1.Image Is Nothing Then
        '        Me.PictureBox1.Image = Image.FromFile(FileName)
        '    Else
        '        Me.PictureBox2.Image = Image.FromFile(FileName)


        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try



    End Function

    'Private Function LeerCabecera() As MICR.MICRCabecera
    '    Dim data As String = LeerMICR()
    '    Dim MC As MICRCabecera = Nothing
    '    If data.Length > 0 Then
    '        MC = New MICRCabecera(data)
    '    End If
    '    Return MC
    'End Function
    'Private Function LeerDetalle() As MICR.MICRCabecera
    '    Dim data As String = LeerMICR()
    '    Dim MC As MICRCabecera = Nothing
    '    If data.Length > 0 Then
    '        MC = New MICRCabecera(data)
    '    End If
    '    Return MC
    'End Function


    Private Function LeerMICR() As String
        Dim result As Int32
        Dim MicrLength As Long
        result = MICR.CsdParGet(CSDP_MICRDATALEN, MicrLength)
        Dim MicrData As String
        MicrData = Space(MicrLength)

        result = MICR.CsdParGet(CSDP_MICRDATA, MicrData)

        Return MicrData
    End Function
    Private Function LeerOCR() As String
        Dim result As Int32
        Dim MicrLength As Long
        result = MICR.CsdParGet(CSDP_OCRDATALEN, MicrLength)
        Dim MicrData As String
        MicrData = Space(MicrLength)

        result = MICR.CsdParGet(CSDP_OCRDATA, MicrData)

        Return MicrData
    End Function

    Sub ProcesarLectura()
        Dim cCabecera As Integer = 0
        Dim cDetalle As Integer = 0
        Dim tCabecera As Double = 0
        Dim tDetalle As Double = 0
        Dim CuentaDeposito As String = String.Empty

        'LecturasBindingSource.Sort = "nro_lote ASC, cod_tipDoc DESC"
        ' LecturasBindingSource.ResetBindings(False)

        Dim lec As List(Of Lecturas) = (From s As Lecturas In dxe _
                                       Order By s.nro_lote, s.cod_tipdoc Descending, s.IdLectura _
                                       Select s).ToList






        Dim secuencia As Integer = 1
        For Each det As Lecturas In lec

            If det.cabecera Is Nothing OrElse det.cabecera <> secuencia Then
                det.cabecera = secuencia
            End If

            secuencia += 1
            'If det.cod_tipdoc <> "00" And det.cod_tipdoc <> "02" Then
            'If det.cod_tipdoc <> "00" And det.cod_tipdoc <> "01" And det.cod_tipdoc <> "02" Then
            If det.EsCabecera Then
                cCabecera += 1


                If Not det.monto Is Nothing Then
                    tCabecera += det.monto
                End If

                If Not det.cuenta_cheque Is Nothing Then
                    CuentaDeposito = det.cuenta_cheque.ToString.TrimEnd
                End If
            Else
                cDetalle += 1

                If Not det.monto Is Nothing Then
                    tDetalle += det.monto
                End If
                If det.cuenta_deposito Is Nothing OrElse det.cuenta_deposito.TrimEnd <> CuentaDeposito.TrimEnd Then
                    'VG 11/08/2010
                    'Asignar solamente cuando el proceso es Enviado
                    If Me.Oper = Operacion.Enviado Or Me.Oper = Operacion.Rechazado Then
                        det.cuenta_deposito = CuentaDeposito
                    End If
                End If

                'Asignamos la sucursal de la cuenta para el banco Familiar
                '20/08/2010
                If (Not det.EsCabecera) And Oper = Operacion.Recibido And codBanco = "41" And det.cuenta_cheque.ToString.PadLeft(12, "0").Substring(0, 2) <> det.cod_sucursal Then
                    det.cod_sucursal = det.cuenta_cheque.ToString.PadLeft(12, "0").Substring(0, 2)
                End If


                End If
        Next

        'dm.SaveChanges()    '23/03/2009

        'Me.txtcCabecera.Text = cCabecera
        'Me.txttCabecera.Text = tCabecera.ToString("N" + Moneda.Decimales.ToString)
        'Me.txtcDetalle.Text = cDetalle
        'Me.txttDetalle.Text = tDetalle.ToString("N" + Moneda.Decimales.ToString)
        'Me.txtDiferencia.Text = (tCabecera - tDetalle).ToString("N" + Moneda.Decimales.ToString)


        Me.lblCAB.Text = String.Format("CAB({0})", cCabecera)
        Me.lblCHQ.Text = String.Format("CHQ({0})", cDetalle)
        Me.lblCABCant.Text = tCabecera.ToString("N" + Moneda.Decimales.ToString)
        Me.lblCHQCant.Text = tDetalle.ToString("N" + Moneda.Decimales.ToString)
        Me.lblDIF.Text = (tCabecera - tDetalle).ToString("N" + Moneda.Decimales.ToString)

        Me.lblDIF.ForeColor = Color.Black
        If tCabecera - tDetalle > 0 Then
            Me.lblDIF.ForeColor = Color.Green
        End If

        If tCabecera - tDetalle < 0 Then
            Me.lblDIF.ForeColor = Color.Red
        End If
        lec = Nothing


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ' Worker.RunWorkerAsync()
            Me.IniciarLectura()
            ProcesarLectura()
            dm.SaveChanges()
            'Dim newThread As New Thread(AddressOf IniciarLectura)
            'newThread.Start()

        Catch ex As Exception

        End Try

    End Sub


    Private Sub Worker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Worker.DoWork
        'Me.Enabled = False

        Me.IniciarLectura()
        ' dm.SaveChanges()


        'Me.CargarDatos()
    End Sub
    Delegate Sub UIDelegate()




    Sub CargarDatos()
        'CabList = From c In dm.Lecturas Select c _
        '            Where c.fecha_lectura = Fecha And c.cod_maquina = CodMaquina Order By c.nro_lote, c.cabecera
        '  dm.AcceptAllChanges()
        dxe.Clear()
        Dim proceso As Integer = Oper


        'dxe.Load(From c In dm.Lecturas _
        '         Where c.cod_moneda = Moneda.CodMoneda And c.cod_banco = Me.codBanco And c.fecha_lectura = Fecha And c.cod_maquina = CodMaquina And c.cod_proceso = proceso _
        '            Order By c.nro_lote, c.cod_tipdoc Descending, c.cabecera _
        '            Select c)
        Dim lista As List(Of Lecturas) = dm.App_GetLecturas(Me.codBanco, Fecha, proceso, Moneda.CodMoneda, CodMaquina).ToList

        dxe.Load(lista)

        'Dim view As BindingListView(Of Lecturas) = New BindingListView(Of Lecturas)(dm.App_GetLecturas(Me.codBanco, Fecha, proceso, Moneda.CodMoneda, CodMaquina).ToList)

        Me.LecturasBindingSource.DataSource = dxe
        ''Me.LecturasBindingSource.Sort = "cabecera"

        Me.SumarSubTotales()
        'LecturasDataGridView.AutoResizeColumns()

    End Sub

    Private Sub Worker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles Worker.ProgressChanged
        ' CargarDatos()
        ' Me.CabecerasDataGridView.Rows.Add()
        frmProgreso.Label1.Text = String.Format("Escaneando {0}", (e.ProgressPercentage / 2).ToString("N0"))
        frmProgreso.Refresh()
        If e.UserState IsNot Nothing Then
            'Me.LecturasBindingSource = e.UserState

            Me.LecturasBindingSource.Add(e.UserState)

        End If

    End Sub


    Private Sub Worker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Worker.RunWorkerCompleted
        'CargarDatos()
        Me.Grabar()
        Me.HabilitarControles(True)
        frmProgreso.Hide()
        'frmProgreso.Dispose()
        '   ' Me.ToolStrip1.Enabled = True
        'Me.Enabled = True
        '  Me.LecturasDataGridView.Refresh()
        'Me.LecturasDataGridView.Update()
        'Me.CabecerasDataGridView.Refresh()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbIniciarCaptura.Click
        '  Try
        'Para Probar la cadena sin tener el scanner
        Me.iniciarLecturaPrueba()
        'Me.Grabar()
        Return


        If MICR Is Nothing Then
            MICR = My.Application.Scanner
        End If
        Me.HabilitarControles(False)

        If Not Me.ConfigCarpetaImagen() Then
            Return
        End If
        Worker.RunWorkerAsync()





        ''  Me.IniciarLectura()

        '  ProcesarLectura()
        Me.Grabar()
        'Dim newThread As New Thread(AddressOf IniciarLectura)
        'newThread.Start()

        'Catch ex As Exception

        ' End Try
    End Sub

    Sub Editar()

        If Me.LecturasDataGridView.CurrentRow Is Nothing Then
            Return
        End If

        Dim frm As New FrmEditarDetalle(Me.LecturasBindingSource)
        'Dim frm As FrmEditarDetalle = FrmEditarDetalle.Instancia(LecturasBindingSource)


        '    frm.LecturasBindingSource.DataSource = Me.CabList
        '   frm.LecturasBindingSource.Position = Me.LecturasBindingSource.Position
        Me.LecturasDataGridView.BeginEdit(False)
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            frm.LecturasBindingSource.EndEdit()
            Me.LecturasBindingSource.EndEdit()
            Me.LecturasBindingSource.ResetCurrentItem()

            Validador.ValidarItem(Me.LecturasDataGridView.CurrentRow)
            Me.Grabar()
            'Me.ProcesarLectura()
        Else
            frm.LecturasBindingSource.CancelEdit()
            Me.LecturasBindingSource.CancelEdit()
        End If

        frm = Nothing




    End Sub
    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        Editar()

    End Sub

    Private Sub tsbErrores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbErrores.Click
        'TODO : Filtrar errores

        ' tsbErrores.Checked = Not tsbErrores.Checked
        chkFiltraError.Checked = Not chkFiltraError.Checked
        chkFiltraError_CheckedChanged(sender, e)

    End Sub

    Sub Insertar()
        'VG 08/10/2009
        'Si esta filtrando, llamamos al proceso de filtro para quitarlo, antes de insertar
        If chkFiltraError.Checked Then
            tsbErrores_Click(Nothing, Nothing)
        End If

        Dim lectura As Lecturas
        'Dim frm As New FrmEditarDetalle(lectura)


        '    frm.LecturasBindingSource.DataSource = Me.CabList
        '   frm.LecturasBindingSource.Position = Me.LecturasBindingSource.Position

        ' frm.LecturasBindingSource = Me.LecturasBindingSource
        Me.LecturasBindingSource.AddNew()
        lectura = Me.LecturasBindingSource.Current
        lectura.fecha_lectura = Fecha
        lectura.cod_maquina = CodMaquina
        lectura.audit_fecha = Date.Now
        lectura.cod_banco = codBanco
        lectura.cod_camara = CodCamara
        lectura.CORREGIDO = True
        lectura.MANO = True
        lectura.VERIFICADO = True
        lectura.cabecera = lectura.nro_lote
        lectura.cod_proceso = Oper
        lectura.nro_lote = Me.nudLote.Value
        lectura.cod_moneda = Moneda.CodMoneda
        lectura.cod_sucursal = Me.cboSucursal.SelectedValue
        lectura.cajero = Me.cboCajero.SelectedValue

        If Me.Oper = Operacion.Enviado Or Me.Oper = Operacion.Rechazado Then
            lectura.cod_banco_emisor = codBanco
        Else
            lectura.cod_banco_receptor = codBanco
        End If


        Dim frm As New FrmEditarDetalle(LecturasBindingSource)
        '  Dim frm As FrmEditarDetalle = FrmEditarDetalle.Instancia(LecturasBindingSource)


        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

            lectura.IdLectura = Util.NEWID(dm, "IdLectura")

            If lectura.EsCabecera Then
                NroLote += 1
                lectura.nro_lote = NroLote
            Else
                'If Not Me.LecturasBindingSource.Current Is Nothing Then
                '    lectura.nro_lote = CType(Me.LecturasBindingSource.Current, Lecturas).nro_lote
                'End If
                lectura.nro_lote = NroLote

                If Oper = Operacion.Devuelto Or Oper = Operacion.Rechazado Then
                    lectura.IdMotivo = Me.cboMotivo.SelectedValue
                    AplicarComision(lectura, CType(cboMotivo.SelectedItem, MotivosRechazo))

                End If

            End If
            'Los datos comunes


            'Me.LecturasBindingSource.Insert(Me.LecturasBindingSource.Position + 1, lectura)
            grabar()
            'Me.ProcesarLectura()
        Else
            frm.LecturasBindingSource.CancelEdit()
        End If
    End Sub

    Sub AplicarComision(ByVal lectura As Lecturas, ByVal motivo As MotivosRechazo)
        If motivo.AplicaComision And Me.Oper = Operacion.Devuelto Then
            lectura.MontoComision = My.Application.Constantes.Comision
            lectura.MontoIVA = My.Application.Constantes.ComisionIVA
            lectura.CodTransComision = My.Application.Constantes.CodigoComision
            lectura.CodTransIVA = My.Application.Constantes.CodigoComisionIVA
        Else
            lectura.MontoComision = Nothing
            lectura.MontoIVA = Nothing
            lectura.CodTransComision = Nothing
            lectura.CodTransIVA = Nothing
        End If

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Insertar()
    End Sub

    Sub Grabar()
        Try
            Me.ProcesarLectura()

            dxe.SaveChanges("Lecturas")

            My.MyApplication.AbrirProceso(codBanco, Fecha, Moneda.CodMoneda, Oper)

            Me.SumarSubTotales()

        Catch ex As Exception
            MsgBox(Util.EnumErrors(ex))
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmRecibido_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' grabar()
        If Me.Worker.IsBusy Then
            e.Cancel = True
        End If
        frmProgreso.Dispose()
    End Sub

    Private Sub LecturasDataGridView_BindingContextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LecturasDataGridView.BindingContextChanged
        ' Continue only if the data source has been set.
        If Me.LecturasDataGridView.DataSource Is Nothing Then
            Return
        End If

        ' Add the AutoFilter header cell to each column.
        'For Each col As DataGridViewColumn In Me.LecturasDataGridView.Columns
        '    col.HeaderCell = New DataGridViewAutoFilterColumnHeaderCell(col.HeaderCell)

        'Next

        ' Resize the columns to fit their contents.
        ' LecturasDataGridView.AutoResizeColumns()
    End Sub



    Private Sub LecturasDataGridView_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs)


        '   If Me.LecturasDataGridView.Columns("Importe").Index = _
        ' e.ColumnIndex AndAlso e.RowIndex >= 0 Then

        '       Dim dr As DataGridViewRow = Me.LecturasDataGridView.Rows(e.RowIndex)
        '       Dim dc As DataGridViewCell = dr.Cells("Importe")
        '       ' Calculate the correct color:
        '       Dim textColor As Color = dc.Style.ForeColor
        '       If (dr.Selected) Then
        '           textColor = dc.Style.SelectionForeColor
        '       End If

        '       Const HORIZONTALOFFSET As Integer = 1
        '       Const SPACER As Integer = 4

        '       Dim fnt As Font = Me.Importe.InheritedStyle.Font

        '       ' Get the text to draw and calculate its width:
        '       Dim cellText As String = dr.Cells("Importe").Value.ToString() + "VG"
        '       Dim textSize As SizeF = _
        'e.Graphics.MeasureString(cellText, fnt)

        '       ' Calculate where text would start:
        '       Dim textStart As PointF = _
        '        New PointF( _
        '        HORIZONTALOFFSET + SPACER, _
        '       textSize.Height / 2)
        '       '     (dc.ContentBounds.Height - textSize.Height) / 2)

        '       Using brush As New SolidBrush(textColor)
        '           e.Graphics.DrawString(cellText, fnt, brush, _
        '             dc.ContentBounds.X + textStart.X, _
        '       dc.ContentBounds.Y + textStart.Y)
        '       End Using

        '       Dim newRect As New Rectangle(e.CellBounds.X + 1, e.CellBounds.Y + 1, _
        '           e.CellBounds.Width - 4, e.CellBounds.Height - 4)
        '       Dim backColorBrush As New SolidBrush(e.CellStyle.BackColor)
        '       Dim gridBrush As New SolidBrush(Me.LecturasDataGridView.GridColor)
        '       Dim gridLinePen As New Pen(gridBrush)
        '       ' Erase the cell.
        '       e.Graphics.FillRectangle(backColorBrush, e.CellBounds)


        '       If Not (e.Value Is Nothing) Then
        '           e.Graphics.DrawString(CStr(e.Value), e.CellStyle.Font, _
        '           Brushes.Crimson, e.CellBounds.X + 2, e.CellBounds.Y + 2, _
        '           StringFormat.GenericDefault)
        '       End If
        '       e.Handled = True
        '       '  e.Handled = True
        '   End If
        'Para Dibujar la celda en forma manual

        '  If Me.LecturasDataGridView.Columns("Importe").Index = _
        'e.ColumnIndex AndAlso e.RowIndex >= 0 Then

        '      Dim newRect As New Rectangle(e.CellBounds.X + 1, e.CellBounds.Y + 1, _
        '          e.CellBounds.Width - 4, e.CellBounds.Height - 4)
        '      Dim backColorBrush As New SolidBrush(e.CellStyle.BackColor)
        '      Dim gridBrush As New SolidBrush(Me.LecturasDataGridView.GridColor)
        '      Dim gridLinePen As New Pen(gridBrush)

        '      Try

        '          ' Erase the cell.
        '          e.Graphics.FillRectangle(backColorBrush, e.CellBounds)

        '          ' Draw the grid lines (only the right and bottom lines;
        '          ' DataGridView takes care of the others).
        '          e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, _
        '              e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, _
        '              e.CellBounds.Bottom - 1)
        '          e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, _
        '              e.CellBounds.Top, e.CellBounds.Right - 1, _
        '              e.CellBounds.Bottom)

        '          ' Draw the inset highlight box.
        '          e.Graphics.DrawRectangle(Pens.Blue, newRect)

        '          ' Draw the text content of the cell, ignoring alignment.
        '          If Not (e.Value Is Nothing) Then
        '              e.Graphics.DrawString(CStr(e.Value), e.CellStyle.Font, _
        '              Brushes.Crimson, e.CellBounds.X + 2, e.CellBounds.Y + 2, _
        '              StringFormat.GenericDefault)
        '          End If
        '          e.Handled = True

        '      Finally
        '          gridLinePen.Dispose()
        '          gridBrush.Dispose()
        '          backColorBrush.Dispose()
        '      End Try

        '  End If

    End Sub

    Private Sub LecturasDataGridView_ColumnWidthChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewColumnEventArgs)
        'Me.UbicarTotales()
    End Sub

    'Private Sub LecturasDataGridView_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs)
    '    '    String filterStatus = DataGridViewAutoFilterColumnHeaderCell
    '    '        .GetFilterStatus(dataGridView1);
    '    'If (String.IsNullOrEmpty(filterStatus)) Then
    '    '    {
    '    '        showAllLabel.Visible = false;
    '    '        filterStatusLabel.Visible = false;
    '    '    }
    '    'Else
    '    '    {
    '    '        showAllLabel.Visible = true;
    '    '        filterStatusLabel.Visible = true;
    '    '        filterStatusLabel.Text = filterStatus;
    '    '    }



    'End Sub


    'Private Sub LecturasDataGridView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LecturasDataGridView.KeyDown
    '    If e.Control And e.KeyCode = Keys.C Then
    '        Dim d As DataObject = Me.LecturasDataGridView.GetClipboardContent
    '        Clipboard.SetDataObject(d)
    '        e.Handled = True
    '    End If

    'End Sub

    'Private Sub LecturasDataGridView_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LecturasDataGridView.KeyUp
    '    If e.Control And e.KeyCode = Keys.C Then
    '        Dim d As DataObject = Me.LecturasDataGridView.GetClipboardContent
    '        Clipboard.SetDataObject(d)
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub LecturasDataGridView_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs)
        If e.IsLastVisibleRow Then
            'Me.LecturasDataGridView.Rows(e.RowIndex).Height = 40
            'Me.LecturasDataGridView.Rows(e.RowIndex).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
            'Me.LecturasDataGridView.Rows(e.RowIndex).Cells("Importe").Style.Alignment = DataGridViewContentAlignment.TopRight
            ''Me.LecturasDataGridView.Rows(e.RowIndex).Cells("Importe")




            'Dim newRect As New Rectangle(e.RowBounds.X + e.RowBounds.Width + 1, e.RowBounds.Y + 1, _
            '    e.RowBounds.Width - 4, e.RowBounds.Height - 4)
            'Dim backColorBrush As New SolidBrush(Color.Beige)
            'Dim gridBrush As New SolidBrush(Color.BlueViolet)
            'Dim gridLinePen As New Pen(gridBrush)

            'Try

            '    ' Erase the cell.
            '    e.Graphics.FillRectangle(backColorBrush, newRect)

            '    ' Draw the grid lines (only the right and bottom lines;
            '    ' DataGridView takes care of the others).
            '    e.Graphics.DrawLine(gridLinePen, e.RowBounds.Left, _
            '        e.RowBounds.Bottom + e.RowBounds.Width, e.RowBounds.Right - 1, _
            '        e.RowBounds.Bottom - 1 + e.RowBounds.Width)
            '    e.Graphics.DrawLine(gridLinePen, e.RowBounds.Right - 1, _
            '        e.RowBounds.Top, e.RowBounds.Right - 1, _
            '        e.RowBounds.Bottom)

            '    ' Draw the inset highlight box.
            '    e.Graphics.DrawRectangle(Pens.Blue, newRect)

            '    '' Draw the text content of the cell, ignoring alignment.
            '    'If Not (e.Value Is Nothing) Then
            '    '    e.Graphics.DrawString(CStr(e.Value), e.CellStyle.Font, _
            '    '    Brushes.Crimson, e.CellBounds.X + 2, e.CellBounds.Y + 2, _
            '    '    StringFormat.GenericDefault)
            '    'End If
            '    'e.Handled = True

            'Finally
            '    gridLinePen.Dispose()
            '    gridBrush.Dispose()
            '    backColorBrush.Dispose()
            'End Try

        End If
    End Sub

    Private Sub LecturasDataGridView_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LecturasDataGridView.CellContentDoubleClick
        If e.ColumnIndex = -1 AndAlso e.RowIndex = -1 Then
            SumarSubTotales()
        End If
    End Sub

    Private Sub LecturasDataGridView_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles LecturasDataGridView.CellFormatting
        If e.RowIndex >= 0 And Me.LecturasBindingSource.Count >= e.RowIndex + 1 Then
            'If e.RowIndex >= 0 And Me.LecturasBindingSource.Count > 0 Then
            ' TODO: Cambiar Color de Cabecera


            If CType(Me.LecturasBindingSource.Item(e.RowIndex), Lecturas).EsCabecera Then
                e.CellStyle.BackColor = Color.LightBlue
            End If

            'If CType(Me.LecturasBindingSource.Item(e.RowIndex), ObjectView(Of Lecturas)).Object.EsCabecera Then
            '    e.CellStyle.BackColor = Color.LightBlue
            'End If

        End If
    End Sub

    Private Sub LecturasDataGridView_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles LecturasDataGridView.CellValidating

    End Sub

    Private Sub LecturasDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LecturasDataGridView.CellValueChanged
        If e.RowIndex >= 0 Then
            Editado = True
        End If
    End Sub

    




    '' ''Private Sub LecturasDataGridView_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles LecturasDataGridView.DataBindingComplete

    '' ''    If e.ListChangedType = System.ComponentModel.ListChangedType.ItemChanged Then
    '' ''        '     SumarSubTotales()
    '' ''    End If

    '' ''    If e.ListChangedType = System.ComponentModel.ListChangedType.Reset Then
    '' ''        '     SumarSubTotales()
    '' ''    End If


    '' ''End Sub



    Private Sub LecturasDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles LecturasDataGridView.DataError
        e.Cancel = True
    End Sub

    Private Sub LecturasDataGridView_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LecturasDataGridView.RowValidated
        If Me.Editado Then

            grabar()
            Editado = False
        End If

    End Sub

    Private Sub LecturasDataGridView_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles LecturasDataGridView.RowValidating
        Return
        'VG 20/08/2010
        'Si no hace insercion manual, no se requiere esto

        Dim row As DataGridViewRow = _
        LecturasDataGridView.Rows(e.RowIndex)
        Dim LoteCell As DataGridViewCell = _
        row.Cells(LecturasDataGridView.Columns("ColumnLote").Index)
        'LoteCell.Value = 0



        If LoteCell.Value IsNot Nothing AndAlso LoteCell.Value.ToString().Equals("0") Then
            Dim lectura As Lecturas = CType(row.DataBoundItem, Lecturas)
            If lectura Is Nothing Then
                Return
            End If

           
            lectura.IdLectura = Util.NEWID(dm, "IdLectura")

            If lectura.EsCabecera Then
                NroLote += 1
                lectura.nro_lote = NroLote
            Else

                lectura.nro_lote = NroLote

                If Oper = Operacion.Devuelto Or Oper = Operacion.Rechazado Then
                    lectura.IdMotivo = Me.cboMotivo.SelectedValue
                    AplicarComision(lectura, CType(cboMotivo.SelectedItem, MotivosRechazo))

                End If

            End If

            ' grabar()
        End If
    End Sub


    Private Sub LecturasDataGridView_UserDeletedRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles LecturasDataGridView.UserDeletedRow
        Me.Grabar()
        Me.ProcesarLectura()
        Me.confirmaBorrar = True
        Me.msgBorrar = True
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        validar()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCargar.Click
        Me.CargarDatos()

        Me.ProcesarLectura()

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbDescargar.Click
        Me.dxe.Clear()
        Me.ProcesarLectura()
    End Sub

    Private Sub LecturasDataGridView_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles LecturasDataGridView.UserDeletingRow
        If confirmaBorrar = False Then
            Return
        End If
        If msgBorrar Then
            msgBorrar = False
            If MsgBox("Esta seguro que desea eliminar este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                e.Cancel = True
                confirmaBorrar = False
            Else
                confirmaBorrar = True
            End If
        End If


    End Sub

    Private Sub frmRecibido_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.LecturasBindingSource.DataSource = dxe
        Me.cboBuscar.SelectedIndex = 0
        Me.Moneda = New Moneda(My.Application.Moneda.cod_moneda, My.Application.Moneda.decimales)
        PonerTitulos()
        Me.AsignarLote()

        'Dim ts As New Label
        'ts.Text = "Importe"
        'ts.Visible = True
        'ts.Dock = DockStyle.Bottom
        '   Me.LecturasDataGridView.Controls.Add(ts)
        My.Application.Banco.Sucursales.Load()
        Me.SucursalesBindingSource.DataSource = My.Application.Banco.Sucursales.OrderBy(Function(p) p.nombre_sucusal)
        If SucursalesBindingSource.Count > 0 Then
            Me.txtSucursal.Text = Me.cboSucursal.SelectedValue
        End If

        Me.MotivosRechazoBindingSource.DataSource = dm.MotivosRechazo.Where(Function(m) m.IdBanco = My.Application.Banco.cod_banco And m.Activo = True)
        If MotivosRechazoBindingSource.Count > 0 Then
            Me.txtMotivo.Text = Me.cboMotivo.SelectedValue
        End If

    End Sub

    Private Sub lnkBuscar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkBuscar.LinkClicked

        Buscar(cboBuscar.SelectedItem.ToString, txtBuscar.Text)
    End Sub

    Sub Buscar(ByVal Propiedad As String, ByVal Valor As String)
        Dim Campo As String = ""

        Select Case Propiedad
            Case "Importe"
                Campo = "monto"
            Case "Numero"
                Campo = "numero_cheque"
            Case "Cuenta"
                Campo = "cuenta_cheque"
        End Select

        Dim pos As Integer = Me.LecturasBindingSource.Find(Campo, CDec(Valor))
        If pos > -1 Then
            LecturasBindingSource.Position = pos

            '   Me.LecturasDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            '  Me.LecturasDataGridView.Rows(pos).Selected = True
        Else
            ' Me.LecturasDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect
            MsgBox("No se encuentra la informacion buscada.", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If (Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar))) Then
            ' de igual forma se podría comprobar si es caracter: e.KeyChar.IsLetter
            ' si es un caracter minusculas: e.KeyChar.IsLower ...etc
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True ' esto invalida la tecla pulsada
            End If
        End If

    End Sub

    Sub PonerTitulos()
        Dim titulo As String = ""
        Select Case Oper
            Case Operacion.Recibido
                titulo = "Recibidos "
            Case Operacion.Enviado
                titulo = "Enviados "
            Case Operacion.Rechazado
                titulo = "Rechazados "
            Case Operacion.Devuelto
                titulo = "Devueltos "

        End Select
        Dim obj As Bancos = (From bc In Validador.Bancos Where bc.cod_banco = codBanco Select bc).FirstOrDefault
        If obj IsNot Nothing Then
            Me.Text = titulo + obj.nombre_banco
        Else
            MsgBox("No se encuentra el banco indicado", MsgBoxStyle.Information)
        End If


        Me.Importe.DefaultCellStyle.Format = "N" + Moneda.Decimales.ToString

        'Solo hacemos visible si corresponde al proceso de Devuelto/Rechazado
        Me.PanelMotivoDevolucion.Visible = (Oper = Operacion.Devuelto Or Oper = Operacion.Rechazado)
        Me.IdMotivo.Visible = (Oper = Operacion.Devuelto Or Oper = Operacion.Rechazado)
        Me.cuenta_deposito.Visible = (Oper = Operacion.Devuelto)
    End Sub

    Sub UbicarTotales()
        Me.txtSubTotalCab.Left = Me.LecturasDataGridView.Left
        For Each dc As DataGridViewColumn In Me.LecturasDataGridView.Columns
            If dc.Name = "Importe" Then
                Me.txtSubTotalCab.Width = dc.Width
                Exit For
            End If
            Me.txtSubTotalCab.Left += dc.Width
            Me.txtSubTotalCab.Text = 0

        Next

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        If MsgBox("Esta seguro que desea eliminar este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.LecturasDataGridView.Rows.Remove(Me.LecturasDataGridView.Rows(Me.LecturasBindingSource.Position))
            Me.Grabar()

        End If
    End Sub

    Private Sub chkFiltraError_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltraError.CheckedChanged
        'Mientras tanto Validamos tambien al salir, pq cambio el datasource
        'Se debe implementar el Filter al dxe
        '   Me.LecturasBindingSource.Filter = "cod_banco_receptor='05'"
        '  Return
        'TODO : Filtrar Errores 2

        Me.tsbErrores.Checked = chkFiltraError.Checked
        If Not chkFiltraError.CheckState = CheckState.Checked Then
            'Me.LecturasBindingSource.DataSource = dxe
            Me.LecturasBindingSource.Filter = ""
            Me.ProcesarLectura()
            LinkLabel1.Enabled = True
        Else
            'validar()
            validar()
            If Oper = Operacion.Recibido Then
                ValidarCREC(True)
            End If
            Me.LecturasBindingSource.Filter = "CORREGIDO=FALSE"
            LinkLabel1.Enabled = False
            'Me.LecturasBindingSource.Filter = "CORREGIDO=FALSE, VERIFICADO=FALSE"

            'Me.LecturasBindingSource.DataSource = dxe.Where(Function(p) p.CORREGIDO = False)

            'Me.LecturasBindingSource.Filter = "Corregido = 0"
            End If
            'validar()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        '  Dim validator As Validator(Of Lecturas) = ValidationFactory.CreateValidator(Of Lecturas)("Enviados")
        ' Dim results As ValidationResults = validator.Validate(CType(Me.LecturasBindingSource.Current, Lecturas))
        '        DisplayValidationResults(results, customerResultsTreeView)
        '    Me.LecturasDataGridView.Rows(1).ErrorText = "No valido"
        '   Dim re = ValidateChildren()
        validar()
    End Sub
    Private Sub validar()

        Dim Errores As Integer = Validador.ValidarLectura(Me.LecturasDataGridView, Me.Oper, Me.Fecha, Me.dxe.OriginalList, Me.codBanco, Me.Moneda.CodMoneda, Me.Sucursales)
        Me.txtErrores.Text = Errores.ToString("N0")
        Me.LecturasDataGridView.Update()

        Return


    End Sub



    'Private Sub validar()
    '    'limpiamos todos los errores primero
    '    Dim Errores As Integer = Validador.ValidarLectura(Me.LecturasDataGridView, Me.Oper, Me.Fecha, Me.dxe.OriginalList, Me.codBanco, Me.Moneda.CodMoneda, Me.Sucursales)
    '    Me.txtErrores.Text = Errores.ToString("N0")
    '    Me.LecturasDataGridView.Update()

    '    Return



    '    Dim FechaAnterior As Date
    '    'Buscamos la fecha anterior solo si es Devuelto o Rechazado
    '    If Me.Oper = Operacion.Devuelto Or Me.Oper = Operacion.Rechazado Then

    '        'Si es USD, en devueltos se busca 2 dias atras
    '        If Me.Moneda.CodMoneda = "USD" Then
    '            If Me.Oper = Operacion.Devuelto Then
    '                FechaAnterior = Util.DiaProceso(Me.Fecha, 2)
    '            Else
    '                FechaAnterior = Me.Fecha
    '            End If
    '        Else
    '            FechaAnterior = Util.DiaProceso(Me.Fecha, 1)
    '        End If
    '    End If


    '    Dim cErrores As Double = 0
    '    Dim lc As Lecturas

    '    Dim procesoRechazadoDevuelto As Integer

    '    Select Case Me.Oper
    '        Case Operacion.Devuelto
    '            procesoRechazadoDevuelto = 2
    '        Case Operacion.Rechazado
    '            procesoRechazadoDevuelto = 3
    '    End Select


    '    Dim lcBancoCabecera As String = String.Empty
    '    Dim lcCuentaDeposito As String = String.Empty
    '    Dim ExisteError As Boolean = False
    '    Dim td = From c In dxe _
    '                    Where Not c.EsCabecera _
    '            Group c By c.nro_lote _
    '            Into Total = Sum(c.monto) _
    '            Select nro_lote, Total

    '    'For Each item As DataGridViewRow In LecturasDataGridView.Rows
    '    '    item.ErrorText = ""
    '    '    item.Cells(5).ErrorText = ""

    '    '    item.Cells("tbcSerie").ErrorText = ""
    '    '    item.Cells(6).ErrorText = ""
    '    'Next


    '    For Each item As DataGridViewRow In LecturasDataGridView.Rows
    '        If item.DataBoundItem Is Nothing Then
    '            Continue For
    '        End If
    '        item.ErrorText = ""
    '        item.Cells(5).ErrorText = ""

    '        item.Cells("tbcSerie").ErrorText = ""
    '        item.Cells(6).ErrorText = ""


    '        validar(item)


    '        Dim r As DataGridViewRow = item
    '        lc = CType(item.DataBoundItem, Lecturas)

    '        'Si ocurrio un error en la validacion de la clase
    '        ExisteError = Not lc.VERIFICADO

    '        If Not lc.EsCabecera And lc.numero_cheque = 0 Then
    '            r.Cells(5).ErrorText = "Nro de Cheque no valido."
    '            ExisteError = True
    '            lc.AgregarError(6, "Nro de Cheque no valido.")

    '        End If


    '        'Validamos cada lote
    '        If lc.EsCabecera Then

    '            If chkFiltraError.Checked = False Then
    '                Dim Diferente = Aggregate word In td _
    '                             Where word.nro_lote = lc.nro_lote _
    '           Into Any(word.Total <> lc.monto)

    '                Dim Suma = Aggregate word In td _
    '                                Where word.nro_lote = lc.nro_lote _
    '              Into Sum(word.Total)

    '                'If Diferente Then
    '                If lc.monto <> Suma Then
    '                    r.ErrorText = String.Format("Existe una diferencia con la suma del detalle.{1} Cab={0:n2} {1} Det={2:n2} {1} Dif={3:n2}", lc.monto, Chr(13), Suma, lc.monto - Suma)
    '                    ExisteError = True
    '                    '                    lc.Errores.Add(New Errores(7, String.Format("Existe una diferencia con la suma del detalle. Cab={0:n2} Det={2:n2} Dif={3:n2}", lc.monto, Chr(13), Suma, lc.monto - Suma)))
    '                    lc.AgregarError(7, String.Format("Existe una diferencia con la suma del detalle. Cab={0:n2} Det={2:n2} Dif={3:n2}", lc.monto, Chr(13), Suma, lc.monto - Suma))
    '                    ' r.Cells(2).ErrorText = "Existe una diferencia con la suma del detalle"
    '                End If
    '            End If

    '            '  Dim Diferente = Aggregate word In td _
    '            '                  Where word.nro_lote = lc.nro_lote _
    '            'Into Any(word.Total <> lc.monto)
    '            '  If Diferente Then
    '            '      r.ErrorText = "Existe una diferencia con la suma del detalle."
    '            '      ' r.Cells(2).ErrorText = "Existe una diferencia con la suma del detalle"
    '            '  End If
    '            lcBancoCabecera = lc.cod_banco_emisor

    '            If lc.cod_sucursal IsNot Nothing Then

    '                Dim ExisteSucursal = (Aggregate word In Sucursales _
    '            Into Any(word.cod_sucursal = lc.cod_sucursal))

    '                If Not ExisteSucursal Then
    '                    r.ErrorText = "No existe la Sucursal indicada."
    '                    ExisteError = True
    '                    lc.AgregarError(14, "No existe la Sucursal indicada.")

    '                End If

    '            End If


    '        Else
    '            If (Oper = Operacion.Recibido) AndAlso lcBancoCabecera <> lc.cod_banco_emisor Then
    '                r.Cells(6).ErrorText = "El banco no corresponde a la cabecera."
    '                ExisteError = True
    '                lc.AgregarError(8, "El banco no corresponde a la cabecera.")

    '            End If

    '            Dim ExisteCabecera = (Aggregate word In dxe _
    '        Into Any(word.nro_lote = lc.nro_lote And word.EsCabecera))

    '            If Not ExisteCabecera Then
    '                r.ErrorText = "El registro no tiene cabecera."
    '                ExisteError = True
    '                lc.AgregarError(9, "El registro no tiene cabecera.")

    '            End If


    '        End If
    '        'Validamos los bancos

    '        Dim ExisteBanco = (Aggregate word In Bancos _
    '        Into Any(word.cod_banco = lc.cod_banco_receptor)) And _
    '        (Aggregate word In Bancos _
    '        Into Any(word.cod_banco = lc.cod_banco_emisor))

    '        If Not ExisteBanco Then
    '            r.ErrorText = "No existe el banco indicado."
    '            ExisteError = True
    '            lc.AgregarError(10, "No existe el banco indicado.")

    '        End If

    '        'Validamos el Tipo de documento
    '        Dim ExisteDocumento = (Aggregate word In TipoDoc _
    '        Into Any(word.cod_tipdoc = lc.cod_tipdoc))

    '        If Not ExisteDocumento Then
    '            r.ErrorText = "No existe el tipo de documento indicado."
    '            ExisteError = True
    '            lc.AgregarError(11, "No existe el tipo de documento indicado.")

    '        End If

    '        'Validamos el Tipo de documento
    '        Dim ExisteCamara = (Aggregate word In Camaras _
    '        Into Any(word.cod_camara = lc.cod_camara))

    '        If Not ExisteCamara Then
    '            r.ErrorText = "No existe la camara indicada."
    '            ExisteError = True
    '            lc.AgregarError(12, "No existe la camara indicada.")

    '        End If

    '        'Validamos los cheques Devueltos y Enviados
    '        If Not lc.EsCabecera And (lc.cod_proceso = 1 Or lc.cod_proceso = 4) Then

    '            Dim ExisteCheque = (From l In dm.Lecturas _
    '                                Where (l.numero_cheque = lc.numero_cheque _
    '            And l.cod_banco_receptor = lc.cod_banco_receptor _
    '            And Not lc.EsCabecera _
    '            And l.IdLectura <> lc.IdLectura _
    '            And l.cod_banco = Me.codBanco _
    '            And l.cod_moneda = Moneda.CodMoneda And l.fecha_lectura = FechaAnterior And l.cod_proceso = procesoRechazadoDevuelto)).FirstOrDefault

    '            If ExisteCheque Is Nothing Then
    '                r.ErrorText = "El cheque no existe en el proceso anterior."
    '                ExisteError = True
    '                lc.AgregarError(13, "El cheque no existe en el proceso anterior.")
    '            Else
    '                If lc.cuenta_deposito Is Nothing OrElse lc.cuenta_deposito.TrimEnd.Length <= 1 Then
    '                    lc.cuenta_deposito = ExisteCheque.cuenta_deposito
    '                End If
    '            End If

    '        End If
    '        'Validamos Cuenta 1 para devueltos
    '        If Not lc.EsCabecera And Me.Oper = Operacion.Devuelto And lc.cuenta_deposito IsNot Nothing Then
    '            If lc.cuenta_deposito.TrimEnd() = "1" Then
    '                r.ErrorText = "La cuenta de deposito debe ser distinto a 1."
    '                ExisteError = True
    '                lc.AgregarError(15, "La cuenta de deposito debe ser distinto a 1.")
    '            End If
    '        End If



    '        ''Se aplica solamente cuando el error es 7 - Diferencia de Cabecera
    '        If lc.NroError = 7 Then
    '            lc.CORREGIDO = True
    '        Else
    '            lc.CORREGIDO = Not ExisteError
    '        End If

    '        lc.ConError = ExisteError
    '        lc.IB_MONTO = ExisteError
    '        If ExisteError Then
    '            cErrores += 1
    '            'Me.LecturasDataGridView.UpdateCellValue
    '            ' Me.LecturasBindingSource.ResetCurrentItem()


    '        End If


    '        ExisteError = False


    '        'VG 28/10/2008 No validamos por la cuenta, solo el nro. de cheque
    '        'And CType(s.DataBoundItem, Lecturas).cuenta_cheque = CType(r.DataBoundItem, Lecturas).cuenta_cheque _

    '        'Dim o As List(Of DataGridViewRow) = (From s As DataGridViewRow In LecturasDataGridView.Rows _
    '        '                         Where CType(s.DataBoundItem, Lecturas).numero_cheque = lc.numero_cheque _
    '        'And CType(s.DataBoundItem, Lecturas).cod_banco_receptor = lc.cod_banco_receptor _
    '        '                         And CType(s.DataBoundItem, Lecturas).IdLectura <> lc.IdLectura _
    '        '                         And Not lc.EsCabecera _
    '        '                                     Select s).ToList
    '        'If o.Count > 0 Then
    '        '    o(0).ErrorText = String.Format("El cheque esta repetido en la secuencia {0}", CType(item.DataBoundItem, Lecturas).cabecera)
    '        'End If

    '        'Dim repetido As Boolean = Aggregate l In dm.Lecturas _
    '        '                    Where l.numero_cheque = lc.numero_cheque _
    '        'And l.cod_banco_receptor = lc.cod_banco_receptor _
    '        'And Not lc.EsCabecera _
    '        'Into Any(l.IdLectura <> lc.IdLectura)

    '        ' ''Dim listaRepetido As List(Of Lecturas) = (From l In dm.Lecturas _
    '        ' ''                    Where l.numero_cheque = lc.numero_cheque _
    '        ' ''And l.cod_banco_receptor = lc.cod_banco_receptor _
    '        ' ''And Not lc.EsCabecera _
    '        ' ''And l.IdLectura <> lc.IdLectura _
    '        ' ''And l.cod_banco = Me.codBanco _
    '        ' ''And l.cod_moneda = Moneda.CodMoneda And l.fecha_lectura = Fecha And l.cod_proceso = proceso _
    '        ' ''Select l).ToList

    '        ' ''If listaRepetido.Count > 0 Then
    '        ' ''    r.Cells("tbcSerie").ErrorText = String.Format("El cheque esta repetido en fecha {0}, Maquina {1} ", listaRepetido(0).fecha_lectura.Value.ToShortDateString, listaRepetido(0).cod_maquina)
    '        ' ''    End If

    '        'If repetido Then
    '        '    '                r.ErrorText = String.Format("El cheque esta repetido en la secuencia {0}", CType(item.DataBoundItem, Lecturas).cabecera)
    '        '    r.Cells("tbcSerie").ErrorText = "El cheque esta repetido en la secuencia "
    '        'End If



    '    Next
    '    Me.txtErrores.Text = cErrores.ToString("N0")
    '    Me.LecturasDataGridView.Update()
    'End Sub

    'Sub Validar(ByVal item As DataGridViewRow)
    '    'Validar not null
    '    'VG 07/05/08 
    '    'Puede venir un item null, si es que se hace clic afuera de la grilla
    '    'cuando se esta editando

    '    If item Is Nothing OrElse item.DataBoundItem Is Nothing Then
    '        Return
    '    End If

    '    results = validator.Validate(item.DataBoundItem)

    '    'Limpiamos el Error al editar el registro
    '    item.ErrorText = ""
    '    If Not results.IsValid Then
    '        For Each result As ValidationResult In results
    '            item.ErrorText = item.ErrorText + "-" + result.Message
    '        Next
    '    End If
    '    CType(item.DataBoundItem, Lecturas).VERIFICADO = results.IsValid

    '    ' CType(item.DataBoundItem, Lecturas).CORREGIDO = results.IsValid

    'End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        EditarToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub cmnuInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuInsertar.Click
        Me.Insertar()
    End Sub

    Private Sub InsertarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Insertar()
    End Sub



    Private Sub lnkReasignar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkReasignar.LinkClicked
        For Each dr As DataGridViewRow In Me.LecturasDataGridView.SelectedRows
            CType(dr.DataBoundItem, Lecturas).nro_lote = Me.nudLote.Value
        Next
        Me.Grabar()

    End Sub

    Private Sub LecturasBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles LecturasBindingSource.AddingNew
        Dim lectura As New Lecturas
        lectura.fecha_lectura = Fecha
        lectura.cod_maquina = CodMaquina
        lectura.audit_fecha = Date.Now
        lectura.cod_banco = codBanco
        lectura.cod_camara = CodCamara
        lectura.CORREGIDO = True
        lectura.MANO = True
        lectura.VERIFICADO = True
        'lectura.cabecera = lectura.nro_lote
        lectura.cabecera = 0
        lectura.cod_proceso = Oper
        'lectura.nro_lote = Me.nudLote.Value
        lectura.nro_lote = 0
        lectura.cod_moneda = Moneda.CodMoneda
        lectura.cod_sucursal = Me.cboSucursal.SelectedValue
        lectura.cajero = Me.cboCajero.SelectedValue

        If Me.Oper = Operacion.Enviado Or Me.Oper = Operacion.Rechazado Then
            lectura.cod_banco_emisor = codBanco
        Else
            lectura.cod_banco_receptor = codBanco
        End If
        e.NewObject = lectura
    End Sub


    Private Sub LecturasBindingSource_BindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.BindingCompleteEventArgs) Handles LecturasBindingSource.BindingComplete
        If e.BindingCompleteContext = BindingCompleteContext.DataSourceUpdate _
     AndAlso e.Exception Is Nothing Then
            'e.Binding.BindingManagerBase.EndCurrentEdit()
        End If

    End Sub
    Public Property NroLote() As Integer
        Get
            Return _NroLote
        End Get
        Set(ByVal value As Integer)

            'Por si haya aumentado el lote manualmente
            'entonces usamos el valor manual
            If value <= Me.nudLote.Value Then
                Me.nudLote.Value += 1
                _NroLote = Me.nudLote.Value
            Else
                _NroLote = value
                Me.nudLote.Value = value

            End If
        End Set
    End Property

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        validarRepetidos()
    End Sub

    Private Sub validarRepetidos()
        'limpiamos todos los errores primero
        Dim lc As Lecturas
        Dim proceso As Integer = Oper


        Dim td = From c In dxe _
                         Where Not c.EsCabecera _
                 Group c By c.nro_lote _
                 Into Total = Sum(c.monto) _
                 Select nro_lote, Total



        For Each item As DataGridViewRow In LecturasDataGridView.Rows
            item.ErrorText = ""
            item.Cells("tbcSerie").ErrorText = ""
        Next


        For Each item As DataGridViewRow In LecturasDataGridView.Rows
            'validar(item)
            Dim r As DataGridViewRow = item
            lc = CType(item.DataBoundItem, Lecturas)

            'Validamos cada lote
            If lc.EsCabecera Then
                Dim Diferente = Aggregate word In td _
                                Where word.nro_lote = lc.nro_lote _
              Into Any(word.Total <> lc.monto)
                If Diferente Then
                    r.ErrorText = "Existe una diferencia con la suma del detalle."
                    ' r.Cells(2).ErrorText = "Existe una diferencia con la suma del detalle"
                End If

            End If
            'Validamos los bancos
            'Dim ExisteBanco = (Aggregate word In Bancos _
            'Into Any(word.cod_banco = lc.cod_banco_receptor)) And _
            '(Aggregate word In Bancos _
            'Into Any(word.cod_banco = lc.cod_banco_emisor))

            'If Not ExisteBanco Then
            '    r.ErrorText = "No existe el banco indicado."
            'End If



            'VG 28/10/2008 No validamos por la cuenta, solo el nro. de cheque
            'And CType(s.DataBoundItem, Lecturas).cuenta_cheque = CType(r.DataBoundItem, Lecturas).cuenta_cheque _

            'Dim o As List(Of DataGridViewRow) = (From s As DataGridViewRow In LecturasDataGridView.Rows _
            '                         Where CType(s.DataBoundItem, Lecturas).numero_cheque = lc.numero_cheque _
            'And CType(s.DataBoundItem, Lecturas).cod_banco_receptor = lc.cod_banco_receptor _
            '                         And CType(s.DataBoundItem, Lecturas).IdLectura <> lc.IdLectura _
            '                         And Not lc.EsCabecera _
            '                                     Select s).ToList
            'If o.Count > 0 Then
            '    o(0).ErrorText = String.Format("El cheque esta repetido en la secuencia {0}", CType(item.DataBoundItem, Lecturas).cabecera)
            'End If

            'Dim repetido As Boolean = Aggregate l In dm.Lecturas _
            '                    Where l.numero_cheque = lc.numero_cheque _
            'And l.cod_banco_receptor = lc.cod_banco_receptor _
            'And Not lc.EsCabecera _
            'Into Any(l.IdLectura <> lc.IdLectura)

            Dim listaRepetido As List(Of Lecturas) = (From l In dm.Lecturas _
                                Where l.numero_cheque = lc.numero_cheque _
            And l.cod_banco_receptor = lc.cod_banco_receptor _
            And l.cuenta_cheque = lc.cuenta_cheque _
            And Not lc.EsCabecera _
            And l.IdLectura <> lc.IdLectura _
            And l.cod_banco = Me.codBanco _
            And l.cod_moneda = Moneda.CodMoneda And l.fecha_lectura = Fecha And l.cod_proceso = proceso _
            Select l).ToList

            If listaRepetido.Count > 0 Then
                r.Cells("tbcSerie").ErrorText = String.Format("El cheque esta repetido en fecha {0}, Maquina {1} ", listaRepetido(0).fecha_lectura.Value.ToShortDateString, listaRepetido(0).cod_maquina)
            End If

            'If repetido Then
            '    '                r.ErrorText = String.Format("El cheque esta repetido en la secuencia {0}", CType(item.DataBoundItem, Lecturas).cabecera)
            '    r.Cells("tbcSerie").ErrorText = "El cheque esta repetido en la secuencia "
            'End If



        Next


    End Sub

    Private Sub lnkSucursal_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkSucursal.LinkClicked
        For Each dr As DataGridViewRow In Me.LecturasDataGridView.SelectedRows
            CType(dr.DataBoundItem, Lecturas).cod_sucursal = Me.cboSucursal.SelectedValue
        Next
        Me.Grabar()

    End Sub

    Private Sub txtSucursal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSucursal.KeyDown
        If e.KeyData = Keys.Enter Then
            Dim actual As Control = Me.ActiveControl
            Me.SelectNextControl(actual, True, True, True, True)
            e.Handled = True
        End If


    End Sub






    Private Sub txtSucursal_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSucursal.Validating
        Try
            Dim oldId As Integer = Me.cboSucursal.SelectedValue
            Me.cboSucursal.SelectedValue = CInt(txtSucursal.Text)
            If Me.cboSucursal.SelectedItem Is Nothing Then
                MsgBox("Sucursal no valido.", MsgBoxStyle.Exclamation)
                Me.cboSucursal.SelectedValue = oldId
            End If
            Me.cboSucursal.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.txtSucursal.Text = Me.cboSucursal.SelectedValue
        End Try
    End Sub

    Private Sub cboSucursal_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSucursal.SelectedIndexChanged
        Me.txtSucursal.Text = Me.cboSucursal.SelectedValue
    End Sub

    Private Sub MostrarError(ByVal NroError As Integer)
        frmProgreso.Hide()
        Select Case NroError
            Case 2
                MsgBox("No se ha hallado el Scanner. Compruebe el cable.", MsgBoxStyle.Critical)
            Case 7
                MsgBox("Papel atascado en el scanner, extraiga el papel y continue.", MsgBoxStyle.Critical)
            Case 18
                MsgBox("Error desconocido al acceder al Scanner.", MsgBoxStyle.Critical)

        End Select

    End Sub


    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Util.Exportar(Me.LecturasDataGridView)
    End Sub
    Sub HabilitarControles(ByVal Habilitado As Boolean)
        Me.tsbCargar.Enabled = Habilitado
        Me.tsbDescargar.Enabled = Habilitado
        Me.TaskPane1.Enabled = Habilitado
        Me.tsbIniciarCaptura.Enabled = Habilitado
        'Me.LecturasDataGridView.AllowUserToAddRows = Habilitado
        If Habilitado Then
            frmProgreso.Label1.Text = ""
            frmProgreso.Hide()
        Else
            ' frmProgreso.MdiParent = Me
            frmProgreso.Show()
        End If


    End Sub

    Private Sub Cancel() Handles frmProgreso.Cancelar
        MICR.CsdStopScan()
    End Sub


    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Me.Insertar()
    End Sub

    Private Sub EditarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem1.Click
        Editar()
    End Sub

    Private Sub ValidarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidarToolStripMenuItem.Click
        validar()
    End Sub

    Private Sub FiltrarErroresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FiltrarErroresToolStripMenuItem.Click
        tsbErrores_Click(sender, e)
    End Sub

    Private Sub IniciarCapturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IniciarCapturaToolStripMenuItem.Click
        ToolStripButton1_Click(sender, e)
    End Sub

    Sub SumarSubTotales()



        Debug.Assert(True, "Sumando")
        Dim SubTotalCab As Double = 0
        Dim SubTotalDet As Double = 0
        Dim cCab As Double = 0
        Dim cDet As Double = 0
        Dim lec As Lecturas
        Dim cErrores As Double = 0



        For Each lec In dxe
            If lec.ConError Then
                cErrores += 1
            End If
            If lec.EsCabecera Then
                cCab += 1
                If lec.monto IsNot Nothing Then
                    SubTotalCab += lec.monto
                End If

            Else
                cDet += 1
                If lec.monto IsNot Nothing Then
                    SubTotalDet += lec.monto
                End If
            End If
        Next


        'For Each it As DataGridViewRow In LecturasDataGridView.Rows
        '    lec = CType(it.DataBoundItem, Lecturas)
        '    If lec.EsCabecera Then
        '        cCab += 1
        '        If lec.monto IsNot Nothing Then
        '            SubTotalCab += lec.monto
        '        End If

        '    Else
        '        cDet += 1
        '        If lec.monto IsNot Nothing Then
        '            SubTotalDet += CType(it.DataBoundItem, Lecturas).monto
        '        End If
        '    End If

        'Next

        Me.txtSubTotalCab.Text = SubTotalCab.ToString("N0")
        Me.txtSubTotalDet.Text = SubTotalDet.ToString("N0")
        Me.lblSubTotalCab.Text = String.Format("Cab ({0:N0})", cCab)
        Me.lblSubTotalDet.Text = String.Format("Det ({0:N0})", cDet)
        Me.txtErrores.Text = cErrores.ToString("N0")
        Me.txtSubDif.Text = (SubTotalCab - SubTotalDet).ToString("N0")

    End Sub

    Private Sub LecturasBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LecturasBindingSource.CurrentChanged
        LecturasBindingSource_CurrentItemChanged(Nothing, Nothing)
    End Sub

    Private Sub LecturasBindingSource_CurrentItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LecturasBindingSource.CurrentItemChanged
        If Me.TaskPane2.TaskFrames(0).IsExpanded Then
            If LecturasBindingSource.Current IsNot Nothing Then

                Me.ImagenBase1.NombreImagen = CType(LecturasBindingSource.Current, Lecturas).imagen_frontal
            End If
        End If
    End Sub





    '' ''Private Sub LecturasBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles LecturasBindingSource.ListChanged
    '' ''    If e.ListChangedType = System.ComponentModel.ListChangedType.ItemAdded Then

    '' ''    End If

    '' ''End Sub


    'Private Sub ErroresBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ErroresBindingSource.CurrentChanged
    '    Dim alto As Integer = Me.DataRepeater1.ItemTemplate.Height
    '    Me.DataRepeater1.Height = (alto * ErroresBindingSource.Count) + 10
    'End Sub

    'Private Sub ErroresBindingSource_CurrentItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ErroresBindingSource.CurrentItemChanged

    'End Sub


    Private Sub TaskPane2_FrameCollapsed(ByVal sender As Object, ByVal e As WindowsControlLibrary.TaskPaneEventArgs) Handles TaskPane2.FrameCollapsed

        'TaskPane2.Height = 22
        CalcularAltoTaskPane()
    End Sub

    Private Sub TaskPane2_FrameExpanded(ByVal sender As Object, ByVal e As WindowsControlLibrary.TaskPaneEventArgs) Handles TaskPane2.FrameExpanded
        'TaskPane2.Height = e.TaskFrame.Height + 22
        CalcularAltoTaskPane()
        LecturasBindingSource_CurrentItemChanged(Nothing, Nothing)
    End Sub
    Sub CalcularAltoTaskPane()
        Dim Alto As Double = 0

        For Each tp As TaskFrame In TaskPane2.TaskFrames
            If tp.IsExpanded Then
                Alto += tp.Height + 22
            Else
                Alto += 22
            End If

        Next

        TaskPane2.Height = Alto

    End Sub

    Private Sub ImagenBase1_CambiarImagen() Handles ImagenBase1.CambiarImagen
        If ImagenBase1.NombreImagen IsNot Nothing Then
            If Me.ImagenBase1.NombreImagen.StartsWith("GF") Then
                Me.ImagenBase1.NombreImagen = (CType(LecturasBindingSource.Current, Lecturas).imagen_reverso)
            Else
                Me.ImagenBase1.NombreImagen = (CType(LecturasBindingSource.Current, Lecturas).imagen_frontal)
            End If
        End If



    End Sub

    Private Sub cboMotivo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMotivo.SelectedIndexChanged
        Me.txtMotivo.Text = Me.cboMotivo.SelectedValue
    End Sub

    Private Sub txtMotivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMotivo.KeyDown
        If e.KeyData = Keys.Enter Then
            Dim actual As Control = Me.ActiveControl
            Me.SelectNextControl(actual, True, True, True, True)
            e.Handled = True
        End If
    End Sub

    Private Sub txtMotivo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMotivo.Validating
        Try
            Dim oldId As String = Me.cboMotivo.SelectedValue
            Me.cboMotivo.SelectedValue = txtMotivo.Text.PadRight(3)
            If Me.cboMotivo.SelectedItem Is Nothing Then
                MsgBox("Motivo no valido.", MsgBoxStyle.Exclamation)
                Me.cboMotivo.SelectedValue = oldId
            End If
            Me.cboMotivo.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.txtMotivo.Text = Me.cboMotivo.SelectedValue
        End Try
    End Sub

    Private Sub lnkMotivo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkMotivo.LinkClicked
        Dim lectura As Lecturas
        For Each dr As DataGridViewRow In Me.LecturasDataGridView.SelectedRows
            lectura = CType(dr.DataBoundItem, Lecturas)
            lectura.IdMotivo = Me.cboMotivo.SelectedValue
            AplicarComision(lectura, cboMotivo.SelectedItem)
        Next
        Me.Grabar()
    End Sub

    Private Sub lnkFecha_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkFecha.LinkClicked
        Dim frmOk As New frmMiniLogin
        frmOk.ShowDialog()
        If frmOk.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim frm As New frmCambiarFecha
            frm.DateTimePicker1.Text = Me.Fecha
            frm.ShowDialog()
            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                Me.Fecha = frm.DateTimePicker1.Text
                Me.lnkFecha.Text = "Fecha Proceso: " + Me.Fecha.ToShortDateString()
            End If
        End If
    End Sub

    Private Sub tsEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsEliminar.Click

        For Each dr As DataGridViewRow In Me.LecturasDataGridView.SelectedRows
            'Me.LecturasDataGridView
        Next

    End Sub

    Private Sub cmdImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImportar.Click
        Dim frm As New frmCREC(Fecha, codBanco)
        frm.Show()
        listaCREC.Clear()
    End Sub

    Sub ConfigurarCREC()
        If Me.Oper = Operacion.Recibido Then
            Me.tfValidar.Height = 80
            Me.lnkValidarCREC.Visible = True
            Me.cmdImportar.Visible = True
            'Me.tfCREC.Visible = False
        Else
            Me.tfValidar.Height = 60
            Me.lnkValidarCREC.Visible = False
            Me.cmdImportar.Visible = False
            Me.tfCREC.Visible = False
            Me.TaskPane2.TaskFrames.Remove(Me.tfCREC)
        End If


    End Sub

    Private Sub lnkValidarCREC_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkValidarCREC.LinkClicked
        ValidarCREC()
    End Sub

    Sub ValidarCREC(Optional ByVal Simple As Boolean = False)

        Dim ExisteError As Boolean = False
        If listaCREC.Count = 0 Then
            listaCREC = (dm.CREC.Include("CRECDet").Where(Function(p) p.Fecha = Fecha And p.CodBanco = codBanco)).ToList()
        End If

        If listaCREC.Count = 0 Then
            If Not Simple Then
                MsgBox("Debe cargar primeramente el archivo CREC para realizar esta validacion")
            End If
            Return

        End If

        Dim det = listaCREC(0).CRECDet.OrderBy(Function(p) p.Secuencia).ToList
        Dim dxCREC As New Sorteable.FilteredBindingList(Of CRECDet)(dm)
        Me.DataGridViewTextBoxColumn2.FilteringEnabled = True
        Me.Existe.FilteringEnabled = True
        dxCREC.Load(det)
        Me.CRECDetBindingSource.DataSource = Nothing
        Me.CRECDetBindingSource.DataSource = dxCREC



        Dim lc As Lecturas
        For Each item As DataGridViewRow In Me.LecturasDataGridView.Rows
            item.ErrorText = ""
            ExisteError = False
            lc = CType(item.DataBoundItem, Lecturas)

            If Not lc.EsCabecera Then

                'Dim Existe = (Aggregate word In det _
                '            Into Any(word.Numero = lc.numero_cheque _
                '            And word.IdBanco = lc.cod_banco_emisor))
                Dim Existe = (From s In det Where s.IdBanco = lc.cod_banco_emisor _
                             And s.Numero = lc.numero_cheque).FirstOrDefault

                If Existe Is Nothing Then
                    item.ErrorText = "No se encuentra en el CREC."
                    lc.AgregarError(15, "No se encuentra en el CREC.")
                    ExisteError = True
                Else
                    'Solo Aplicar la correccion cuando el monto es igual a 0
                    If Existe.Cuenta = lc.cuenta_cheque And lc.monto = 0 And ChkCorregir.Checked Then
                        lc.monto = Existe.Importe
                    End If

                    If Existe.Cuenta <> lc.cuenta_cheque Then
                        item.ErrorText = "Nro de Cuenta no corresponde con el CREC."
                        lc.AgregarError(16, "Nro de Cuenta no corresponde con el CREC.")
                        ExisteError = True


                End If
                    If Existe.Importe <> lc.monto Then
                            item.ErrorText = "Monto no corresponde con el CREC."
                        lc.AgregarError(17, "Monto no corresponde con el CREC.")
                        ExisteError = True
                        'End If
                End If
                End If
            End If

            lc.ConError = ExisteError
            lc.IB_MONTO = ExisteError
            lc.CORREGIDO = Not ExisteError
        Next

        'Analizamos el CREC para detectar registros que no se hayan leido
        Dim cdet As CRECDet
        Dim listaLectura As Sorteable.FilteredBindingList(Of Lecturas)
        listaLectura = LecturasBindingSource.List
        'listaLectura = Me.LecturasDataGridView.Rows
        Dim ExisteCREC As Boolean
        For Each item As DataGridViewRow In Me.CRECDetDataGridView.Rows
            cdet = CType(item.DataBoundItem, CRECDet)
            ExisteCREC = (Aggregate word In listaLectura _
Into Any(word.numero_cheque = cdet.Numero))
            cdet.Existe = IIf(ExisteCREC, "Si", "No")
        Next
        det.Clear()
        det = Nothing
        listaLectura = Nothing


        Me.LecturasDataGridView.Update()
        If ChkCorregir.Checked Then
            grabar()
        End If
    End Sub


    Private Sub CRECDetDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles CRECDetDataGridView.DataError
        e.Cancel = True
    End Sub
End Class


