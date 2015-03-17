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
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns


'Imports Equin.ApplicationFramework


'24-03-09 VG
'Grabar en ProcesarLectura, por si se haya modifica la secuencia

Public Class frmRecibido
    Dim dm As New Entities
    Dim MICR As MICR.CanonAPIbase
    Dim file As CEIIMAGEFILEINFO
    Dim Editado As Boolean = False
    Dim NroOrden As Integer = 1
    Dim WithEvents frmProgreso As New ProgresoScaneo
    Dim FilePath As String
    Dim ImagenPath As String
    Dim ListaLectura As List(Of Lecturas)

    Dim Asincrono As Boolean = True

    Dim ConfigFilePath As String

    Dim Val As New ValidadorCuenta
    '   Dim CabList As IQueryable(Of Lecturas)
    'Dim dxe As New Sorteable.FilteredBindingList(Of Lecturas)(dm)
    Dim dxe As New List(Of Lecturas)
    Dim dxChitci As List(Of CHITCI)
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
    Dim Bancos As List(Of Bancos) = dm.Bancos.Where(Function(p) p.Activo = True).OrderBy(Function(p) p.cod_banco).ToList
    Dim TipoDoc As List(Of Tipo_Documentos) = dm.Tipo_Documentos.OrderBy(Function(p) p.cod_tipdoc).ToList
    Dim Camaras As List(Of Camara) = dm.Camaras.OrderBy(Function(p) p.cod_camara).ToList
    Dim Sucursales As List(Of Sucursales)
    Dim msgBorrar As Boolean = True
    Dim confirmaBorrar As Boolean = True
    Dim Moneda As MICR.Moneda
    Dim configMICR As ConfigMICR
    Dim SubTotal As Decimal = 0
    Dim listaCREC As New List(Of CREC)
    Dim STCab As Decimal = 0
    Dim STDet As Decimal = 0
    Dim STErr As Integer = 0
    Dim StDif As Decimal = 0
    Dim StCabn As Integer
    Dim STDetn As Integer

    Dim lSucursales As ILookup(Of Integer, String)


    Private Const GridConfigFile As String = "GridConfigFile.xml"

    Sub ConfigScanner()
        ConfigFilePath = Path.Combine(My.Application.Info.DirectoryPath, CanonAPIbase.CONFIG_FILE)

        Dim NroOper As String = ""
        Select Case Oper
            Case Operacion.Devuelto
                NroOper = "1"
            Case Operacion.Enviado
                NroOper = "2"
            Case Operacion.Recibido
                NroOper = "3"
            Case Operacion.Rechazado
                NroOper = "4"
            Case Operacion.Interna
                NroOper = "5"
        End Select

        Dim NewConfigFile As String = Path.Combine(My.Application.Info.DirectoryPath, String.Concat("Canon", NroOper, ".ini"))

        Dim fi1 As New FileInfo(NewConfigFile)
        If fi1.Exists Then
            ConfigFilePath = NewConfigFile
        End If

    End Sub


    Sub New(ByVal Camara As String, ByVal Maquina As String, ByVal Operacion As Operacion)
        Me.New()
        Me.lnkFecha.Text = "Fecha Proceso: " + Me.Fecha.ToShortDateString()
        codBanco = My.MySettings.Default.IdEmpresa
        CodCamara = Camara
        Oper = Operacion

        ListaLectura = New List(Of Lecturas)
        Dim IdProceso As Integer = Oper
        Me.configMICR = dm.ConfigMICR.FirstOrDefault(Function(p) p.IdBanco = codBanco And p.IdProceso = IdProceso)

        'Me.LecturasDataGridView.AllowUserToAddRows = False
        Me.LecturasGridControl.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.False

        'Me.ConError.FilteringEnabled = True

        Me.Sucursales = dm.Sucursales.Where(Function(p) p.cod_banco = codBanco).OrderBy(Function(p) p.cod_sucursal).ToList()
        lSucursales = Me.Sucursales.ToLookup(Function(p) p.cod_sucursal, Function(p) p.nombre_sucusal)

        Me.ConfigScanner()

        Me.ConfigurarCREC()
        Try
            If My.MySettings.Default.LecturaAsincrona = "1" Then
                Me.Asincrono = True
            Else
                Me.Asincrono = False
            End If

        Catch ex As Exception

        End Try



    End Sub

    Function ConfigCarpetaImagen() As Boolean

        FilePath = My.Settings.CarpetaImagen
        If Not FilePath.StartsWith("\\") Then
            If FilePath.Substring(1, 1) <> ":" Then
                FilePath = Path.Combine(My.Application.Info.DirectoryPath, FilePath)
            End If

        End If

        ' MsgBox(FilePath)

        ImagenPath = Path.Combine(Me.Fecha.ToString("yyyyMMdd"), Me.Oper)

        FilePath = String.Concat(Path.Combine(FilePath, Me.ImagenPath))

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


        'Me.TableLayoutPanel3.RowStyles(3).SizeType = SizeType.AutoSize

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

        'VG 09/12/2010
        'Tambien recuperamos el nro_corrida
        'Usado para indicar la secuencia de las lecturas
        'Se muestra en la columna Orden

        Try

            'Dim MaxNroLote As Integer = (Aggregate c In dm.Lecturas _
            '           Where c.fecha_lectura = Fecha And c.cod_maquina = CodMaquina And c.cod_proceso = Operacion Into Max(c.nro_lote))
            Using dm.Connection.CreateConnectionScope
                'Dim UltimoNroLote 
                Dim dbReader = dm.CreateStoreCommand("Select Max(Nro_Lote),Max(Nro_corrida),Max(Paquete) as Paquete from lecturas where fecha_lectura = @Fecha and cod_maquina = @CodMaquina " _
                                                                 + " and cod_proceso = @Proceso and Cod_Moneda=@Moneda and cod_banco=@Banco", _
                                                                  New SqlClient.SqlParameter("Fecha", Fecha), _
                                                                   New SqlClient.SqlParameter("CodMaquina", CodMaquina), _
                                                                   New SqlClient.SqlParameter("Proceso", Oper), _
                                                                   New SqlClient.SqlParameter("Moneda", Moneda.CodMoneda), _
                                                                   New SqlClient.SqlParameter("Banco", Me.codBanco)).ExecuteReader

                If dbReader.Read() Then
                    If dbReader.IsDBNull(0) Then
                        NroLote = 0
                    Else
                        NroLote = dbReader.GetInt32(0)
                    End If
                    If dbReader.IsDBNull(1) Then
                        NroOrden = 0
                    Else

                        NroOrden = dbReader.GetInt32(1)
                    End If
                    '                    NroLote = IIf(dbReader.IsDBNull(0), 0, dbReader.GetInt32(0))

                End If



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
        data = "C0600E000088901002E05075741A" 'Cheque solo con el premagnetizado
        'data = "C2800E000007002902E12739513A@07@010000004345367@"
        'If data.Length > 0 Then
        mG = New MICRGeneral(data, Moneda, configMICR)
        Me.Grabar(mG, 2)
    End Sub

    Function IniciarLectura() As String
        '  iniciarLecturaPrueba()
        'Return

        'VG Simulamos que esta leyendo

        'Thread.Sleep(5000)
        'Return

        'Me.ToolStrip1.Enabled = False
        '  IO.Directory.SetCurrentDirectory("C:\Program Files\Canon Electronics\CR180")
        'If Me.LecturasDataGridView.InvokeRequired Then

        '    Dim newDelegate As New UIDelegate(AddressOf IniciarLectura)
        '    Me.LecturasDataGridView.Invoke(newDelegate)
        'Else
        Dim progressChunk As Integer = 0

        Dim ErrorLectura As Integer

        'Dim frmProgreso As New ProgresoScaneo
        'frmProgreso.Show()

        Dim result As Integer
        Dim Pagina As Integer = 0
        Dim data As String
        Dim mG As MICRGeneral = Nothing
        Dim NombreImagen As String
        Dim NroImagen As String = ""
        Dim proceso As Integer = Oper



        result = MICR.CsdProbe()

        If result <> 0 Then
            'Dim Stop1 = MICR.CsdStopScan()
            'Stop1 = MICR.CsdTerminate()
            'result = MICR.CsdProbe()
            Me.MostrarError(result)
            Return Nothing
        End If




        Dim img As MICR.CanonAPIbase.CEIIMAGEINFO
        img.cbSize = Len(img)

        'If result = 0 Then
        '    result = MICR.CanonAPI.CsdParSet(MICR.CanonAPI.CSDP_SAVE_CONFIG_FILE, ConfigFilePath)
        '    Me.MostrarError(result)
        'End If

        If result = 0 Then
            result = MICR.CsdParSet(CanonAPIbase.CSDP_LOAD_CONFIG_FILE, ConfigFilePath)
            If result <> 0 Then
                Me.MostrarError(result)
                Return Nothing
            End If

        End If

        'If result = 0 Then

        '    ' result = MICR.CsdParSet(CanonAPIbase.CSDP_AUTOSIZE, 1)
        '    ' Me.MostrarError(result)
        'End If

        'If result = 0 Then

        '    'result = MICR.SetCSDP_MODE(CSDP_MODEAttribute.CSD_GRAYSCALE)
        '    'Me.MostrarError(result)
        'End If

        If result = 0 Then
            result = MICR.CsdStartScan(Nothing, Nothing, Nothing)
            If result <> 0 Then
                Me.MostrarError(result)
                Return Nothing
            End If

        End If

        If result = 0 Then
            result = MICR.CsdReadPage(img)
            If result <> 0 Then
                Me.MostrarError(result)
                Return Nothing
            End If
        End If

        While result = CSD_OK And Worker.CancellationPending = False
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

                'VG 01/12/2010
                'Generamos el nombre el archivo mediante la aplicacion
                'y no la BD

                'NroImagen = Util.NEWID(dm, "NROIMAGEN")

                NroImagen = proceso.ToString.TrimEnd + Me.codBanco.TrimEnd + CodMaquina.ToString + Path.GetFileNameWithoutExtension(Path.GetRandomFileName())

                NombreImagen = "GF" + NroImagen + ".jpg"
            Else
                NombreImagen = "GR" + NroImagen + ".jpg"
            End If

            result = MICR.CsdSaveImageEx(img, file, Path.Combine(FilePath, NombreImagen))
            'Me.GrabarImagen(Pagina, img)
            If result <> 0 Then
                Me.MostrarError(result)
                Return Nothing
            End If

            result = MICR.CsdReleaseImage(img)
            If result <> 0 Then
                Me.MostrarError(result)
                Return Nothing
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

            result = MICR.CsdReadPage(img)
            If result <> 0 Then
                Me.MostrarError(result)
                ErrorLectura = result
                Exit While
            End If

            '   result = MICR.CanonAPI.CsdStartScan(Nothing, Nothing, Nothing)
        End While

        'result = MICR.CanonAPI.CsdParSet(MICR.CanonAPI.CSDP_DISPLAY_VIEW_FRONT, MICR.CanonAPI.VarPtr(img))




        If result = CanonAPIbase.CSD_OK Then
            result = MICR.CsdReleaseImage(img)
            If result <> 0 Then
                Me.MostrarError(result)
                ErrorLectura = result

            End If
        Else
            '''' Me.MostrarError(result)
        End If


        result = MICR.CsdTerminate()

        Return ErrorLectura

        '   End If
    End Function

    Sub IniciarLecturaAsync()
        If MICR Is Nothing Then
            MICR = My.Application.Scanner
        End If
        '  IO.Directory.SetCurrentDirectory("C:\Program Files\Canon Electronics\CR180")
        If Me.LecturasGridControl.InvokeRequired Then

            Dim newDelegate As New UIDelegate(AddressOf IniciarLectura)
            Me.LecturasGridControl.Invoke(newDelegate)
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
                result = MICR.CsdSaveImageEx(img, file, Path.Combine(FilePath + "\Images", NombreImagen))
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
            lectura.PAQUETE = Me.nudPaquete.Value

            lectura.audit_fecha = Date.Now
            ' lectura.audit_usuario = My.User.Name

            lectura.cod_banco = codBanco
            lectura.cod_moneda = Moneda.CodMoneda
            lectura.cod_sucursal = Me.cboSucursal.SelectedValue

            lectura.cajero = Me.cboCajero.SelectedValue

            lectura.CD = Me.chkCD.Checked
            
            lectura.CORREGIDO = True
            lectura.cod_proceso = Oper
            lectura.VERIFICADO = True
            'lectura.audit_usuario = My.User.Name

            'Asignamos el IdLectura Manualmente
            'VG 16/12/2009
            ' lectura.IdLectura = Util.NEWID(dm, "IdLectura")
            'VG 01/12/2010 - Quitamos de nuevo esta opcion por cuestiones
            ' de rendimiento

            If lectura.nro_corrida Is Nothing Then
                NroOrden += 1
                lectura.nro_corrida = NroOrden
            End If


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

                If mg.Cabecera.Imagen IsNot Nothing Then
                    lectura.imagen_frontal = Path.Combine(ImagenPath, mg.Cabecera.Imagen)
                End If

                If mg.Cabecera.Imagen1 IsNot Nothing Then
                    lectura.imagen_reverso = Path.Combine(ImagenPath, mg.Cabecera.Imagen1)
                End If

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

                '26/01/2011 
                'Agregar valor predeterminado

                If lectura.cod_camara Is Nothing OrElse lectura.cod_camara.Length = 0 Then
                    lectura.cod_camara = CodCamara
                End If

                '26/01/2011 
                'Agregar valor predeterminado PARA ENVIADOS
                If Oper = Operacion.Enviado Then
                    If lectura.cod_banco_emisor Is Nothing OrElse lectura.cod_banco_emisor.Length = 0 Then
                        lectura.cod_banco_emisor = codBanco
                    End If
                End If

                '17/03/2011 
                'Agregar valor predeterminado PARA ENVIADOS
                If Oper = Operacion.Recibido Then
                    If lectura.cod_banco_receptor Is Nothing OrElse lectura.cod_banco_receptor.Length = 0 Then
                        lectura.cod_banco_receptor = codBanco
                    End If
                End If


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

                If mg.Detalle.Imagen IsNot Nothing Then
                    lectura.imagen_frontal = Path.Combine(ImagenPath, mg.Detalle.Imagen)
                End If

                If mg.Detalle.Imagen1 IsNot Nothing Then
                    lectura.imagen_reverso = Path.Combine(ImagenPath, mg.Detalle.Imagen1)
                End If

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
            If Me.Asincrono Then
                Me.Worker.ReportProgress(pagina, lectura)
            Else
                Me.LecturasBindingSource.Add(lectura)

                '   Me.LecturaView.RefreshRow(Me.LecturasBindingSource.Count - 1)

            End If


            SaveXML(lectura)

            'SaveXML(lectura)

        Catch ex As Exception
            'If Not ex.InnerException Is Nothing Then
            '    MsgBox(ex.InnerException.Message)
            'Else
            'MsgBox(ex.Message)
            'End If
            Throw New Exception(Util.EnumErrors(ex))

            'MsgBox(Util.EnumErrors(ex))

        End Try
    End Sub
    Private Sub SaveXML(ByVal lect As Lecturas)
        'ListaLectura.Add(lect)
        'Dim ll As New System.Collections.ArrayList
        'll.Add(lect)
        'Dim _Xml As New CustomXmlSerializer
        ''_Xml.WriteFile(lect, My.Application.Info.DirectoryPath & "\Example.xml", False)
        '_Xml.WriteFile(ll, My.Application.Info.DirectoryPath & "\Example.xml", True)

        ClearingLogger.Logger.Grabar(lect)
        'ListaLectura = ClearingLogger.Logger.Leer()


    End Sub


    Private Sub GetXML()
        'Dim _Item As New Buyer


        Dim listaLect As List(Of Lecturas)
        listaLect = ClearingLogger.Logger.Leer()

        If listaLect.Count > 0 Then
            If MsgBox("Se ha recuperado registros no grabados. Desea agregar a su lista de lecturas?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                ClearingLogger.Logger.LimpiarLog()
                Return
            End If

        End If

        For Each s In listaLect
            If s.cod_proceso = Oper Then
                Me.LecturasBindingSource.Add(s)
            End If
        Next

        Me.Grabar()
        ClearingLogger.Logger.LimpiarLog()
        'Return _Item
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
        Dim tCabecera As Decimal = 0
        Dim tDetalle As Decimal = 0
        Dim CuentaDeposito As String = String.Empty
        Dim Cajero As String = Nothing
        Dim Cab As Lecturas = Nothing
        Dim Cheques As Integer = 0
        Dim ImporteCheques As Decimal = 0

        'LecturasBindingSource.Sort = "nro_lote ASC, cod_tipDoc DESC"
        ' LecturasBindingSource.ResetBindings(False)

        Dim lec As List(Of Lecturas) = (From s As Lecturas In dxe _
                                       Order By s.cod_maquina, s.PAQUETE, s.nro_lote, s.cod_tipdoc Descending, s.IdLectura _
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

                'VG 07/06/11
                'Contamos la cantidad de cheques en cada cabecera
                If Cab IsNot Nothing Then

                    If Cab.CantCheques Is Nothing OrElse Cab.CantCheques <> Cheques Then
                        Cab.CantCheques = Cheques
                    End If


                    Cab.MontoDetalle = ImporteCheques
                End If

                Cab = det
                Cheques = 0

                ImporteCheques = 0

                If Not det.monto Is Nothing Then
                    tCabecera += det.monto
                End If

                If Not det.cuenta_cheque Is Nothing Then
                    CuentaDeposito = det.cuenta_cheque.ToString.TrimEnd
                End If

                If det.cuenta_deposito IsNot Nothing Then
                    det.cuenta_deposito = Nothing
                End If


                'VG 02/05/2011
                'Preparamos para copiar el cajero de la cabecera
                If Not det.cajero Is Nothing Then
                    Cajero = det.cajero
                Else
                    Cajero = Nothing
                End If
            Else
                cDetalle += 1

                'VG 07/06/11
                'Sumamos la cantidad de cheques
                If Cab IsNot Nothing AndAlso (Cab.cod_maquina = det.cod_maquina And Cab.PAQUETE = det.PAQUETE And Cab.nro_lote = det.nro_lote) Then
                    Cheques += 1
                    If Not det.monto Is Nothing Then
                        ImporteCheques += det.monto
                    End If
                End If

                If Not det.monto Is Nothing Then
                    tDetalle += det.monto
                End If

                If det.cuenta_deposito Is Nothing OrElse det.cuenta_deposito.TrimEnd <> CuentaDeposito.TrimEnd Then
                    'VG 11/08/2010
                    'Asignar solamente cuando el proceso es Enviado
                    If Me.Oper = Operacion.Enviado Or Me.Oper = Operacion.Rechazado Or Me.Oper = Operacion.Interna Then
                        det.cuenta_deposito = CuentaDeposito
                    End If
                End If

                'VG 11/08/2010
                'Asignar solamente cuando el proceso es Enviado
                If Cab IsNot Nothing Then
                    If Cab.numero_cheque IsNot Nothing Then
                        If det.nro_boleta Is Nothing OrElse det.nro_boleta.TrimEnd <> Cab.numero_cheque.Value.ToString.TrimEnd Then
                            If Me.Oper = Operacion.Enviado Or Me.Oper = Operacion.Rechazado Or Me.Oper = Operacion.Interna Then
                                det.nro_boleta = Cab.numero_cheque.Value
                            End If
                        End If
                    End If
                End If



                'Asignamos la sucursal de la cuenta para el banco Familiar
                '20/08/2010
                If (Not det.EsCabecera) And Oper = Operacion.Recibido And (codBanco = "41" Or codBanco = "39") And det.cuenta_cheque.ToString.PadLeft(12, "0").Substring(0, 2) <> det.cod_sucursal Then
                    det.cod_sucursal = det.cuenta_cheque.ToString.PadLeft(12, "0").Substring(0, 2)
                End If

                'VG
                '02/05/2011
                'Asignamos el cajero a los cheques
                If Oper = Operacion.Interna Then
                    det.cajero = Cajero
                End If


                End If


        Next
        'VG 07/06/11
        'Contamos la cantidad de cheques en cada cabecera
        If Cab IsNot Nothing Then
            If Cab.CantCheques Is Nothing OrElse Cab.CantCheques <> Cheques Then
                Cab.CantCheques = Cheques
            End If
            Cab.MontoDetalle = ImporteCheques
        End If


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


        'Me.iniciarLecturaPrueba()

        ' Me.GetXML()

        ' dm.SaveChanges()


        'Me.CargarDatos()
    End Sub
    Delegate Sub UIDelegate()




    Sub CargarDatos(Optional ByVal SinFiltro = False)
        'CabList = From c In dm.Lecturas Select c _
        '            Where c.fecha_lectura = Fecha And c.cod_maquina = CodMaquina Order By c.nro_lote, c.cabecera
        '  dm.AcceptAllChanges()
        dxe.Clear()
        Dim proceso As Integer = Oper


        dm.Lecturas.MergeOption = Objects.MergeOption.AppendOnly

        'dxe.Load(From c In dm.Lecturas _
        '         Where c.cod_moneda = Moneda.CodMoneda And c.cod_banco = Me.codBanco And c.fecha_lectura = Fecha And c.cod_maquina = CodMaquina And c.cod_proceso = proceso _
        '            Order By c.nro_lote, c.cod_tipdoc Descending, c.cabecera _
        '            Select c)

        'Verificamos si se aplica el filtro de Maquina
        If SinFiltro Then
            dxe = dm.App_GetLecturas(Me.codBanco, Fecha, proceso, Moneda.CodMoneda, Nothing, nudPaquete.Value).ToList
        Else
            dxe = dm.App_GetLecturas(Me.codBanco, Fecha, proceso, Moneda.CodMoneda, CodMaquina, nudPaquete.Value).ToList
        End If
        'Dim lista = dm.App_GetLecturas(Me.codBanco, Fecha, proceso, Moneda.CodMoneda, CodMaquina, Nothing)

        'dxe.Load(lista)
        'dxe = lista.ToList()

        'Dim view As BindingListView(Of Lecturas) = New BindingListView(Of Lecturas)(dm.App_GetLecturas(Me.codBanco, Fecha, proceso, Moneda.CodMoneda, CodMaquina).ToList)
        Me.LecturaView.BeginSummaryUpdate()
        Me.LecturasBindingSource.DataSource = dxe
        Me.LecturaView.EndSummaryUpdate()
        ''Me.LecturasBindingSource.Sort = "cabecera"
        'Me.LecturaView.BestFitColumns()
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

    Sub FinalizarLectura()
        Me.Grabar()
        ClearingLogger.Logger.LimpiarLog()

        Me.HabilitarControles(True)

    End Sub

    Private Sub Worker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Worker.RunWorkerCompleted

        'CargarDatos()
        'Me.Grabar()
        'ClearingLogger.Logger.LimpiarLog()

        'Me.HabilitarControles(True)

        Me.FinalizarLectura()

        frmProgreso.Hide()

        If e.Error IsNot Nothing Then
            MsgBox(e.Error.Message)
        End If

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
        'Me.iniciarLecturaPrueba()
        'Me.Grabar()
        'Return


        If MICR Is Nothing Then
            MICR = My.Application.Scanner
        End If

        Me.HabilitarControles(False)

        If Not Me.ConfigCarpetaImagen() Then
            Return
        End If

        If Me.Asincrono Then
            Worker.RunWorkerAsync()
        Else
            Me.IniciarLectura()
            Me.FinalizarLectura()
        End If

        ''  Me.IniciarLectura()

        '  ProcesarLectura()

        '''''Me.Grabar()


        'Dim newThread As New Thread(AddressOf IniciarLectura)
        'newThread.Start()

        'Catch ex As Exception

        ' End Try
    End Sub

    Sub Editar()

        If Me.LecturaView.GetFocusedRow Is Nothing Then
            Return
        End If

        Dim l As New Lecturas
        Dim lc As Lecturas = CType(Me.LecturasBindingSource.Current, Lecturas)

        l.cadena_captura = lc.cadena_captura
        l.cod_banco_emisor = lc.cod_banco_emisor
        l.cod_banco_receptor = lc.cod_banco_receptor
        l.cod_camara = lc.cod_camara
        l.cod_tipdoc = lc.cod_tipdoc
        l.cuenta_cheque = lc.cuenta_cheque
        l.monto = lc.monto
        l.numero_cheque = lc.numero_cheque
        l.cabecera = lc.cabecera
        l.imagen_frontal = lc.imagen_frontal
        l.imagen_reverso = lc.imagen_reverso
        l.NroError = lc.NroError


        Dim frm As New FrmEditarDetalle(l)
        'Dim frm As FrmEditarDetalle = FrmEditarDetalle.Instancia(LecturasBindingSource)


        '    frm.LecturasBindingSource.DataSource = Me.CabList
        '   frm.LecturasBindingSource.Position = Me.LecturasBindingSource.Position
        'Me.LecturasDataGridView.BeginEdit(False)

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

            ' Me.LecturaView.BeginDataUpdate()

            LecturaView.SetRowCellValue(LecturaView.FocusedRowHandle, "monto", l.monto)
            LecturaView.SetRowCellValue(LecturaView.FocusedRowHandle, "cod_banco_emisor", l.cod_banco_emisor)
            LecturaView.SetRowCellValue(LecturaView.FocusedRowHandle, "cod_banco_receptor", l.cod_banco_receptor)
            LecturaView.SetRowCellValue(LecturaView.FocusedRowHandle, "cod_camara", l.cod_camara)
            LecturaView.SetRowCellValue(LecturaView.FocusedRowHandle, "cod_tipdoc", l.cod_tipdoc)
            LecturaView.SetRowCellValue(LecturaView.FocusedRowHandle, "cuenta_cheque", l.cuenta_cheque)
            LecturaView.SetRowCellValue(LecturaView.FocusedRowHandle, "numero_cheque", l.numero_cheque)
            LecturaView.SetRowCellValue(LecturaView.FocusedRowHandle, "Editado", True)
            'Me.LecturaView.EndDataUpdate()


            'frm.LecturasBindingSource.EndEdit()
            'Me.LecturasBindingSource.EndEdit()
            'Me.LecturasBindingSource.ResetCurrentItem()

            'TODO : Validar Item, aplicado
            ' Validador.ValidarItem(Me.LecturasDataGridView.CurrentRow)
            'Me.LecturaView.UpdateCurrentRow()
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
        'chkFiltraError_CheckedChanged(sender, e)

    End Sub

    Sub Insertar()
        'VG 08/10/2009
        'Si esta filtrando, llamamos al proceso de filtro para quitarlo, antes de insertar
        If chkFiltraError.Checked Then
            tsbErrores_Click(Nothing, Nothing)
        End If
        Me.LecturaView.ClearColumnsFilter()

        Dim lectura As New Lecturas
        'Dim frm As New FrmEditarDetalle(lectura)


        '    frm.LecturasBindingSource.DataSource = Me.CabList
        '   frm.LecturasBindingSource.Position = Me.LecturasBindingSource.Position

        ' frm.LecturasBindingSource = Me.LecturasBindingSource

        'Me.LecturasBindingSource.AddNew()
        '        lectura = Me.LecturasBindingSource.Current
        lectura.fecha_lectura = Fecha
        lectura.cod_maquina = CodMaquina

        lectura.audit_fecha = Date.Now
        '  lectura.audit_usuario = My.User.Name

        lectura.cod_banco = codBanco
        lectura.cod_camara = CodCamara
        lectura.CORREGIDO = True
        lectura.MANO = True
        lectura.VERIFICADO = True
        lectura.cabecera = lectura.nro_lote
        lectura.cod_proceso = Oper
        lectura.nro_lote = Me.nudLote.Value
        lectura.PAQUETE = Me.nudPaquete.Value
        lectura.cod_moneda = Moneda.CodMoneda
        lectura.cod_sucursal = Me.cboSucursal.SelectedValue

        lectura.CD = Me.chkCD.Checked

        lectura.cajero = Me.cboCajero.SelectedValue

        If Me.Oper = Operacion.Enviado Or Me.Oper = Operacion.Rechazado Then
            lectura.cod_banco_emisor = codBanco
        Else
            lectura.cod_banco_receptor = codBanco
        End If


        ' Me.LecturaView.BeginUpdate()
        Dim frm As New FrmEditarDetalle(lectura)
        '  Dim frm As FrmEditarDetalle = FrmEditarDetalle.Instancia(LecturasBindingSource)


        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

            ' lectura.IdLectura = Util.NEWID(dm, "IdLectura")

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
            Me.LecturasBindingSource.Add(lectura)
            grabar()
            'Me.ProcesarLectura()
        Else
            frm.LecturasBindingSource.CancelEdit()
        End If
        '  Me.LecturaView.EndUpdate()
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

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbInsertar.Click
        Me.Insertar()
    End Sub

    Sub Grabar()
        Try
            Me.ProcesarLectura()

            'dxe.SaveChanges("Lecturas")
            'dm.SaveChanges()
            ModificadoAttach()
            My.MyApplication.AbrirProceso(codBanco, Fecha, Moneda.CodMoneda, Oper, Me.nudPaquete.Value)

            ' Me.SumarSubTotales()

        Catch ex As Exception
            MsgBox(Util.EnumErrors(ex))
        End Try
    End Sub

    Sub ModificadoAttach()
        Try

            For Each item As Lecturas In dxe
                'If item.IdLectura <= 0 Then
                '    item.IdLectura = Util.NEWID(dm, "IdLectura")
                'End If


                'If item.IdMotivo IsNot Nothing Then

                '    'item.LecturasRechazos.Load(Objects.MergeOption.OverwriteChanges)
                '    If item.LecturasRechazos.Count = 0 Then
                '        item.LecturasRechazos.Add(New LecturasRechazo With {.IdMotivo = item.IdMotivo, .IdBanco = item.cod_banco, .Audit_Fecha = Date.Now, .Audit_Usuario = My.User.Name})

                '    End If
                'End If


                If item.nro_corrida Is Nothing Then
                    NroOrden += 1
                    item.nro_corrida = NroOrden
                End If


                If item.EntityState = EntityState.Detached Then
                    dm.AddObject("Lecturas", item)
                End If
                If item.EntityState = EntityState.Deleted Then
                    dm.DeleteObject(item)

                    'Try

                    'Catch ex As OptimisticConcurrencyException

                    'End Try

                End If
            Next


            If dxChitci IsNot Nothing Then
                For Each ch In dxChitci
                    If ch.EntityState = EntityState.Detached Then
                        If ch.Existe And ch.EstadoProceso Is Nothing Then

                            'VG
                            'Verificamos de que el registro no exista todavia en la BD
                            If dm.App_BuscarCHITCI(ch.CtaDeposito, ch.Agencia, ch.Comprobante, ch.Importe, codBanco, Moneda.CodMoneda, Fecha).ToList.Count = 0 Then
                                dm.AddToCHITCI(ch)
                            End If
                        End If
                    Else
                        If ch.EntityState = EntityState.Deleted Then
                            dm.DeleteObject(ch)
                        End If

                    End If
                Next
            End If

            'dm.SaveChanges()

            Try
                dm.SaveChanges()
            Catch ex As OptimisticConcurrencyException
                ' context.Refresh(RefreshMode.ClientWins, orders)

                '        If 
                '            If ex.StateEntries.FirstOrDefault() is TypeOf(dele Then



                '            End If
                '        If e.StateEntries.FirstOrDefault() is DeletingObject)
                'myContext.Detach(e.StateEntries.First()
                Dim l1 = ex.StateEntries.FirstOrDefault

                dm.Detach(l1.Entity)

                dm.SaveChanges()


            End Try

        Catch ex As Exception
            If MsgBox(HostVB.Util.EnumErrors(ex), MsgBoxStyle.RetryCancel) = MsgBoxResult.Retry Then
                ModificadoAttach()
            End If
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmRecibido_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    End Sub

    Private Sub frmRecibido_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' grabar()


        Me.LecturasGridControl.MainView.SaveLayoutToXml(My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData, frmRecibido.GridConfigFile))

        If Me.Worker.IsBusy Then
            e.Cancel = True
        End If
        frmProgreso.Dispose()


    End Sub

    Private Sub LecturasDataGridView_BindingContextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ' Continue only if the data source has been set.
        ' TODO: Cambiar
        'If Me.LecturasDataGridView.DataSource Is Nothing Then
        '    Return
        'End If

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

    Private Sub LecturasDataGridView_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        ' TODO: Cambiar
        If e.ColumnIndex = -1 AndAlso e.RowIndex = -1 Then
            SumarSubTotales()
        End If
    End Sub

  



    Private Sub LecturasDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        ' TODO: Cambiar
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



    Private Sub LecturasDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        ' TODO: Cambiar, no se aplica
        e.Cancel = True
    End Sub


    Private Sub LecturasDataGridView_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs)
        Return
        ' TODO: Cambiar, no se aplica
        'VG 20/08/2010
        'Si no hace insercion manual, no se requiere esto

        'Dim row As DataGridViewRow = _
        'LecturasDataGridView.Rows(e.RowIndex)
        'Dim LoteCell As DataGridViewCell = _
        'row.Cells(LecturasDataGridView.Columns("ColumnLote").Index)
        ''LoteCell.Value = 0



        'If LoteCell.Value IsNot Nothing AndAlso LoteCell.Value.ToString().Equals("0") Then
        '    Dim lectura As Lecturas = CType(row.DataBoundItem, Lecturas)
        '    If lectura Is Nothing Then
        '        Return
        '    End If


        '    lectura.IdLectura = Util.NEWID(dm, "IdLectura")

        '    If lectura.EsCabecera Then
        '        NroLote += 1
        '        lectura.nro_lote = NroLote
        '    Else

        '        lectura.nro_lote = NroLote

        '        If Oper = Operacion.Devuelto Or Oper = Operacion.Rechazado Then
        '            lectura.IdMotivo = Me.cboMotivo.SelectedValue
        '            AplicarComision(lectura, CType(cboMotivo.SelectedItem, MotivosRechazo))

        '        End If

        '    End If

        '    ' grabar()
        'End If
    End Sub



    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbValidar.Click
        validar(False)
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCargar.Click
        Me.CargarDatos()

        Me.ProcesarLectura()

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbDescargar.Click
        Me.dxe.Clear()
        Me.LecturasBindingSource.ResetBindings(False)
        Me.ProcesarLectura()
    End Sub

    Private Sub frmRecibido_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

    End Sub


    Private Sub frmRecibido_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Moneda = New Moneda(My.Application.Moneda.cod_moneda, My.Application.Moneda.decimales)

        Me.LecturasBindingSource.DataSource = dxe
        Me.cboBuscar.SelectedIndex = 0

        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData, frmRecibido.GridConfigFile)) Then
            Me.LecturasGridControl.ForceInitialize()
            Me.LecturasGridControl.MainView.RestoreLayoutFromXml(My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData, frmRecibido.GridConfigFile))
        End If

        Me.ToolStripButton4.Checked = Me.LecturaView.OptionsView.ShowGroupPanel
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
        If Oper = Operacion.Devuelto Or Oper = Operacion.Rechazado Or Oper = Operacion.Interna Then
            Me.MotivosRechazoBindingSource.DataSource = dm.MotivosRechazo.Where(Function(m) m.IdBanco = My.Application.Banco.cod_banco And m.Activo = True)
            If MotivosRechazoBindingSource.Count > 0 Then
                Me.txtMotivo.Text = Me.cboMotivo.SelectedValue
            End If
        End If

        Me.GetXML()

    End Sub

    Private Sub lnkBuscar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkBuscar.LinkClicked

        Buscar(cboBuscar.SelectedItem.ToString, txtBuscar.Text)
    End Sub

    Sub Buscar(ByVal Propiedad As String, ByVal Valor As String)
        Dim Campo As String = ""

        Select Case Propiedad
            Case "Importe"
                Campo = "monto"
                Me.SearchPanel1.SearchColumn = colmonto
            Case "Numero"
                Campo = "numero_cheque"
                Me.SearchPanel1.SearchColumn = colnumero_cheque
            Case "Cuenta"
                Campo = "cuenta_cheque"
                Me.SearchPanel1.SearchColumn = colcuenta_cheque
        End Select
        Me.SearchPanel1.SearchText = Valor
        Me.SearchPanel1.FocusNextRow(True)
        Return

        'Dim pos As Integer = Me.LecturasBindingSource.Find(Campo, CDec(Valor))
        'If pos > -1 Then
        '    LecturasBindingSource.Position = pos

        '    '   Me.LecturasDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        '    '  Me.LecturasDataGridView.Rows(pos).Selected = True
        'Else
        '    ' Me.LecturasDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect
        '    MsgBox("No se encuentra la informacion buscada.", MsgBoxStyle.Information)

        'End If

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
        Dim titulo As String = Util.NombreProceso(Oper)
        'Select Case Oper
        '    Case Operacion.Recibido
        '        titulo = "Recibidos "
        '    Case Operacion.Enviado
        '        titulo = "Enviados "
        '    Case Operacion.Rechazado
        '        titulo = "Rechazados "
        '    Case Operacion.Devuelto
        '        titulo = "Devueltos "

        'End Select

        Dim obj As Bancos = (From bc In Validador.Bancos Where bc.cod_banco = codBanco Select bc).FirstOrDefault
        If obj IsNot Nothing Then
            Me.Text = titulo + obj.nombre_banco
        Else
            MsgBox("No se encuentra el banco indicado", MsgBoxStyle.Information)
        End If


        'Me.Importe.DefaultCellStyle.Format = "N" + Moneda.Decimales.ToString
        Me.MontoEditor.Mask.EditMask = "N" + Moneda.Decimales.ToString
        Me.colImporte1.ColumnEdit = MontoEditor
        Me.colComprobante1.ColumnEdit = Edit8
        Me.colCtaDeposito1.ColumnEdit = Edit12

        'Aplicamos los formatos a la grilla CHERFI
        Me.colcfBoleta.ColumnEdit = Edit8
        Me.colcfCtaDep.ColumnEdit = Edit12
        Me.colcfCtaLibradora.ColumnEdit = Edit12
        Me.colcfImporte.ColumnEdit = MontoEditor
        Me.colcfSerie.ColumnEdit = Edit8


        'Solo hacemos visible si corresponde al proceso de Devuelto/Rechazado/Interna
        Me.PanelMotivoDevolucion.Visible = (Oper = Operacion.Devuelto Or Oper = Operacion.Rechazado)
        Me.colIdMotivo.Visible = (Oper = Operacion.Devuelto Or Oper = Operacion.Rechazado)

        Me.colcuenta_deposito.Visible = (Oper = Operacion.Devuelto)
        Me.colPAQUETE.Visible = (Oper = Operacion.Interna)
        Me.colcod_maquina.Visible = (Oper = Operacion.Interna)
        Me.lblPaquete.Visible = (Oper = Operacion.Interna)
        Me.LinkPaqueteAct.Visible = (Oper = Operacion.Interna)
        Me.nudPaquete.Visible = (Oper = Operacion.Interna)

        Me.chkCD.Visible = (Oper = Operacion.Enviado)

        If Oper = Operacion.Interna Then
            dxChitci = New List(Of CHITCI)
            CHITCIBindingSource.DataSource = dxChitci
        End If

        If Oper = Operacion.Devuelto Or Oper = Operacion.Rechazado Then
            'Ajustamos el panel de Devueltos

        Else
            Me.tfOpciones.Height = 216
        End If

        ' Me.LecturaView.BestFitColumns()
    End Sub

   

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        If MsgBox("Esta seguro que desea eliminar este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.LecturaView.DeleteSelectedRows()
            'Me.LecturasDataGridView.Rows.Remove(Me.LecturasDataGridView.Rows(Me.LecturasBindingSource.Position))
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
            'Me.LecturasBindingSource.Filter = ""
            Me.LecturaView.ActiveFilterString = ""

            Me.ProcesarLectura()
            LinkLabel1.Enabled = True
        Else
            'validar()

            validar(False)
            If Oper = Operacion.Recibido And chkValidarFiltrar.Checked Then
                ValidarCREC(True)
            End If
            'Me.LecturasBindingSource.Filter = "CORREGIDO=FALSE"


            Me.LecturaView.ActiveFilterString = "[ConError]=True and [NroError]<>7"
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
        validar(False)
    End Sub
    Private Sub validar(Cierre As Boolean)

        Me.LecturaView.BeginUpdate()
        Me.LecturaView.BeginSelection()
        'TODO : Activar Validacion
        'Dim Errores As Integer = Validador.ValidarLectura(Me.GridView1, Me.Oper, Me.Fecha, Me.dxe.OriginalList, Me.codBanco, Me.Moneda.CodMoneda, Me.Sucursales)
        'Me.txtErrores.Text = Errores.ToString("N0")

        'Me.LecturasDataGridView.Update()
        Me.LecturaView.ActiveFilterString = Me.LecturaView.ActiveFilterString.Replace("[NroError] = 19", "")
        '  Me.LecturaView.ActiveFilterEnabled = False
        Dim CabConError As Boolean = False
        Dim LotesConError As New List(Of ListaConError)
        Dim LoteActual As Integer = 0
        Dim FechaAnterior As Date
        'Buscamos la fecha anterior solo si es Devuelto o Rechazado
        If Oper = Operacion.Devuelto Or Oper = Operacion.Rechazado Then

            'Si es USD, en devueltos se busca 2 dias atras
            If Me.Moneda.CodMoneda = "USD" Then
                If Oper = Operacion.Devuelto Then
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

        Select Case Oper
            Case Operacion.Devuelto
                procesoRechazadoDevuelto = 2
            Case Operacion.Rechazado
                procesoRechazadoDevuelto = 3
        End Select


        Dim lcBancoCabecera As String = String.Empty
        Dim lcCuentaDeposito As String = String.Empty
        Dim ExisteError As Boolean = False

        ''Dim td = From c In dxe _
        ''                Where Not c.EsCabecera _
        ''        Group c By c.cod_maquina, c.PAQUETE, c.nro_lote _
        ''        Into Total = Sum(c.monto) _
        ''        Select cod_maquina, PAQUETE, nro_lote, Total


        'For Each item As DataGridViewRow In LecturasDataGridView.Rows
        '    item.ErrorText = ""
        '    item.Cells(5).ErrorText = ""

        '    item.Cells("tbcSerie").ErrorText = ""
        '    item.Cells(6).ErrorText = ""
        'Next

        Dim ini As DateTime
        Dim ValGrid As Double = 0
        Dim ValCab As Double = 0

        For i = 0 To Me.LecturaView.RowCount - 1
            lc = LecturaView.GetRow(i)

            If lc Is Nothing Then
                Continue For
            End If
            lc.NroError = 0

            ini = Date.Now

            ValidarGridView(lc, Cierre)

            ValGrid += Date.Now.Subtract(ini).TotalSeconds



            'Si ocurrio un error en la validacion de la clase
            ExisteError = Not lc.CORREGIDO

            'VG 14-10-11
            'Movemos la validacion en el registro.

            'If Not lc.EsCabecera And lc.numero_cheque = 0 Then
            '    '    r.Cells(5).ErrorText = "Nro de Cheque no valido."
            '    ExisteError = True
            '    lc.AgregarError(6, "Nro de Cheque no valido.")
            '    lc.AddError("numero_cheque", "Nro de Cheque no valido.")
            'End If

            ''18/06/2011
            ''Validamos cuenta con el algoritmo de cada empresa
            'If ((Oper = Operacion.Enviado Or Oper = Operacion.Interna) _
            'And lc.EsCabecera) Or ((Oper = Operacion.Recibido Or Oper = Operacion.Rechazado Or Oper = Operacion.Interna) And Not lc.EsCabecera) And (lc.cuenta_cheque IsNot Nothing) Then
            '    If Not Val.Validar(Me.codBanco, lc.cuenta_cheque.ToString) Then
            '        ExisteError = True
            '        lc.AgregarError(13, "La cuenta no es válida.")
            '        lc.AddError("cuenta_cheque", "La cuenta no es válida.")
            '    End If

            'End If



            'Validamos cada lote
            If lc.EsCabecera Then

                ' If chkFiltraError.Checked = False Then
                '     Dim Diferente = Aggregate word In td _
                '                  Where word.nro_lote = lc.nro_lote _
                'Into Any(word.Total <> lc.monto)
                ini = Date.Now
                Dim Suma As Decimal = 0

                '  Dim Suma = Aggregate word In td _
                '                  Where word.nro_lote = lc.nro_lote And word.cod_maquina = lc.cod_maquina _
                '                  And word.PAQUETE = lc.PAQUETE _
                'Into Sum(word.Total)

                ''For Each s In td
                ''    If s.nro_lote = lc.nro_lote And s.cod_maquina = lc.cod_maquina _
                ''        And s.PAQUETE = lc.PAQUETE Then

                ''        Suma = s.Total

                ''        Exit For
                ''    End If
                ''Next


                ValCab += Date.Now.Subtract(ini).TotalSeconds


                'If Diferente Then
                If lc.monto <> lc.MontoDetalle Then
                    '       r.ErrorText = String.Format("Existe una diferencia con la suma del detalle.{1} Cab={0:n2} {1} Det={2:n2} {1} Dif={3:n2}", lc.monto, Chr(13), Suma, lc.monto - Suma)
                    ExisteError = True
                    '                    lc.Errores.Add(New Errores(7, String.Format("Existe una diferencia con la suma del detalle. Cab={0:n2} Det={2:n2} Dif={3:n2}", lc.monto, Chr(13), Suma, lc.monto - Suma)))
                    lc.AgregarError(7, String.Format("Existe una diferencia con la suma del detalle. Cab={0:n2} Det={2:n2} Dif={3:n2}", lc.monto, Chr(13), lc.MontoDetalle, lc.monto - lc.MontoDetalle))
                    lc.AddError("monto", String.Format("Existe una diferencia con la suma del detalle. Cab={0:n2} Det={2:n2} Dif={3:n2}", lc.monto, Chr(13), lc.MontoDetalle, lc.monto - lc.MontoDetalle))
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

                '18/06/2011
                'Validamos cuenta 0
                If (Oper = Operacion.Enviado Or Oper = Operacion.Interna Or Oper = Operacion.Rechazado) And (lc.cuenta_cheque Is Nothing OrElse lc.cuenta_cheque = 0) Then
                    ExisteError = True
                    lc.AgregarError(13, "La cuenta de deposito debe ser mayor a 0.")
                    lc.AddError("cuenta_cheque", "La cuenta de deposito debe ser mayor a 0.")

                End If


                CabConError = ExisteError

            Else



                Dim ExisteCabecera = (From word In dxe _
             Where word.PAQUETE = lc.PAQUETE And word.nro_lote = lc.nro_lote And word.EsCabecera And word.cod_maquina = lc.cod_maquina).FirstOrDefault

                If ExisteCabecera Is Nothing Then
                    '      r.ErrorText = "El registro no tiene cabecera."
                    ExisteError = True
                    lc.AgregarError(9, "El registro no tiene cabecera.")
                    lc.AddError("nro_lote", "El registro no tiene cabecera.")
                Else
                    If (Oper = Operacion.Recibido) AndAlso ExisteCabecera.cod_banco_emisor <> lc.cod_banco_emisor Then
                        '          r.Cells(6).ErrorText = "El banco no corresponde a la cabecera."
                        ExisteError = True
                        lc.AgregarError(8, "El banco no corresponde a la cabecera.")
                        lc.AddError("cod_banco_emisor", "El banco no corresponde a la cabecera.")
                    End If

                End If


            End If

            'Validamos los sucursales
            If lc.cod_sucursal IsNot Nothing Then

                '    Dim ExisteSucursal = (Aggregate word In Sucursales _
                'Into Any(word.cod_sucursal = lc.cod_sucursal))

                Dim ExisteSucursal As Boolean = False
                ExisteSucursal = lSucursales.Contains(lc.cod_sucursal)

                'For Each s In Sucursales
                '    If s.cod_sucursal = lc.cod_sucursal Then
                '        ExisteSucursal = True
                '        Exit For
                '    End If
                'Next


                If Not ExisteSucursal Then
                    'r.ErrorText = "No existe la Sucursal indicada."
                    ExisteError = True
                    lc.AgregarError(14, "No existe la Sucursal indicada.")
                    lc.AddError("cod_sucursal", "No existe la Sucursal indicada.")
                End If

            End If


            'Validamos los bancos

            'Dim ExisteBanco1 = (Aggregate word In Bancos _
            'Into Any(word.cod_banco = lc.cod_banco_receptor))

            'Dim ExisteBanco = (Aggregate word In Bancos _
            'Into Any(word.cod_banco = lc.cod_banco_emisor))

            Dim ExisteBanco1 As Boolean = False
            Dim ExisteBanco As Boolean = False
            For Each s In Bancos
                If s.cod_banco = lc.cod_banco_receptor Then
                    ExisteBanco1 = True
                    Exit For
                End If
            Next

            For Each s In Bancos
                If s.cod_banco = lc.cod_banco_emisor Then
                    ExisteBanco = True
                    Exit For
                End If
            Next


            If Not ExisteBanco Then
                ' r.ErrorText = "No existe el banco indicado."
                ExisteError = True
                lc.AgregarError(10, "No existe el banco indicado.")
                lc.AddError("cod_banco_emisor", "No existe el banco indicado.")
            End If

            If Not ExisteBanco1 Then
                ' r.ErrorText = "No existe el banco indicado."
                ExisteError = True
                lc.AgregarError(10, "No existe el banco indicado.")
                lc.AddError("cod_banco_receptor", "No existe el banco indicado.")
            End If


            'Validamos el Tipo de documento
            'Dim ExisteDocumento = (Aggregate word In TipoDoc _
            'Into Any(word.cod_tipdoc = lc.cod_tipdoc))

            Dim ExisteDocumento As Boolean = False
            For Each s In TipoDoc
                If s.cod_tipdoc = lc.cod_tipdoc Then
                    ExisteDocumento = True
                    Exit For
                End If
            Next

            If Not ExisteDocumento Then
                'r.ErrorText = "No existe el tipo de documento indicado."
                ExisteError = True
                lc.AgregarError(11, "No existe el tipo de documento indicado.")
                lc.AddError("cod_tipdoc", "No existe el tipo de documento indicado.")
            End If

            'Validamos el Tipo de documento
            'Dim ExisteCamara = (Aggregate word In Camaras _
            'Into Any(word.cod_camara = lc.cod_camara))
            Dim ExisteCamara As Boolean = False
            For Each s In Camaras
                If s.cod_camara = lc.cod_camara Then
                    ExisteCamara = True
                    Exit For
                End If
            Next

            If Not ExisteCamara Then
                ' r.ErrorText = "No existe la camara indicada."
                ExisteError = True
                lc.AgregarError(12, "No existe la camara indicada.")
                lc.AddError("cod_camara", "No existe la camara indicada.")
            End If

            'Validamos los cheques Devueltos y Enviados
            If Not lc.EsCabecera And (lc.cod_proceso = 1 Or lc.cod_proceso = 4) Then

                Dim ExisteCheque = (From l In dm.Lecturas _
                                    Where (l.numero_cheque = lc.numero_cheque _
                And l.cod_banco_receptor = lc.cod_banco_receptor _
                And l.monto = lc.monto _
                And l.cuenta_cheque = lc.cuenta_cheque _
                And Not lc.EsCabecera _
                And l.IdLectura <> lc.IdLectura _
                And l.cod_banco = codBanco _
                And l.cod_moneda = Me.Moneda.CodMoneda And l.fecha_lectura = FechaAnterior And l.cod_proceso = procesoRechazadoDevuelto)).FirstOrDefault

                If ExisteCheque Is Nothing Then
                    'r.ErrorText = "El cheque no existe en el proceso anterior."
                    ExisteError = True
                    lc.AgregarError(13, "El cheque no existe en el proceso anterior.")
                    lc.AddError("numero_cheque", "El cheque no existe en el proceso anterior.")
                Else
                    If lc.cuenta_deposito Is Nothing OrElse lc.cuenta_deposito.TrimEnd.Length <= 1 Then
                        lc.cuenta_deposito = ExisteCheque.cuenta_deposito
                    End If
                End If

            End If

            'Validamos Cuenta 1 para devueltos
            If Not lc.EsCabecera And Oper = Operacion.Devuelto And lc.cuenta_deposito IsNot Nothing Then
                If lc.cuenta_deposito.TrimEnd() = "1" Then
                    'r.ErrorText = "La cuenta de deposito debe ser distinto a 1."
                    ExisteError = True
                    lc.AgregarError(18, "La cuenta de deposito debe ser distinto a 1.")
                    lc.AddError("cuenta_deposito", "La cuenta de deposito debe ser distinto a 1.")
                End If
            End If

            'Validamos Cuenta en cabecera en enviados
            'Para el banco 06-Citi
            If lc.cod_banco = "06" And lc.EsCabecera And Oper = Operacion.Enviado And lc.cuenta_cheque IsNot Nothing Then

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


            'LecturaView.UnselectRow(i)
            ''Se aplica solamente cuando el error es 7 - Diferencia de Cabecera


            lc.ConError = ExisteError
            lc.IB_MONTO = ExisteError

            If lc.NroError = 7 Then
                lc.CORREGIDO = True
                ' lc.ConError = False
            Else
                lc.CORREGIDO = Not ExisteError
            End If

            If ExisteError Then
                cErrores += 1
                'Me.LecturasDataGridView.UpdateCellValue
                ' Me.LecturasBindingSource.ResetCurrentItem()
                lc.monto = lc.monto
                LecturaView.SetRowCellValue(i, "CORREGIDO", lc.CORREGIDO)
            Else
                'If chkLotesConError.Checked And CabConError = False Then
                '    LecturaView.SelectRow(i)
                'End If
            End If

            If chkLotesConError.Checked AndAlso LoteActual <> lc.nro_lote Then
                If ExisteError Then
                    LotesConError.Add(New ListaConError With {.Lote = lc.nro_lote, .Paquete = lc.PAQUETE, .Maquina = lc.cod_maquina})
                    LoteActual = lc.nro_lote
                End If

            End If


            ExisteError = False




        Next

        If chkLotesConError.Checked Then
            ' LecturaView.DeleteSelectedRows()
            Dim Lote As Integer
            Dim Paquete As Integer
            Dim Maquina As Integer
            LecturaView.ClearSelection()
            For i = 0 To LecturaView.RowCount - 1
                Lote = LecturaView.GetRowCellValue(i, "nro_lote")
                Paquete = LecturaView.GetRowCellValue(i, "PAQUETE")
                Maquina = LecturaView.GetRowCellValue(i, "cod_maquina")

                If Not LotesConError.Exists(Function(t) t.Lote.Equals(Lote) And t.Paquete.Equals(Paquete) And t.Maquina.Equals(Maquina)) Then
                    LecturaView.SelectRow(i)
                End If
            Next
            LecturaView.DeleteSelectedRows()

        End If

        Me.LecturaView.EndSelection()

        Me.LecturaView.EndUpdate()

        Me.txtErrores.Text = cErrores.ToString("N0")


        'Dim st As New System.Text.StringBuilder
        'st.AppendFormat("Validar Grid {0}", ValGrid.ToString)
        'st.AppendFormat("Validar Cab {0}", ValCab.ToString)



        'MsgBox(st.ToString)

        Me.Grabar()

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

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEditar.Click
        EditarToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub cmnuInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuInsertar.Click
        Me.Insertar()
    End Sub

    Private Sub InsertarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Insertar()
    End Sub



    Private Sub lnkReasignar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkReasignar.LinkClicked
        'For Each dr As DataGridViewRow In Me.GridView1.sel.SelectedRows
        '    CType(dr.DataBoundItem, Lecturas).nro_lote = Me.nudLote.Value
        'Next

        Me.LecturaView.BeginUpdate()
        Dim lista = Me.LecturaView.GetSelectedRows()

        For i = 0 To Me.LecturaView.SelectedRowsCount - 1
            Me.LecturaView.SetRowCellValue(lista(i), "nro_lote", Me.nudLote.Value)
        Next

        Me.Grabar()
        Me.LecturaView.EndUpdate()

    End Sub

    Private Sub LecturasBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles LecturasBindingSource.AddingNew
        Dim lectura As New Lecturas
        lectura.fecha_lectura = Fecha
        lectura.cod_maquina = CodMaquina

        lectura.audit_fecha = Date.Now
        '   lectura.audit_usuario = My.User.Name

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

        Dim ini As DateTime = Date.Now
        CargarDatos()
        'Dim td = From c In dxe _
        '                 Where Not c.EsCabecera _
        '         Group c By c.nro_lote _
        '         Into Total = Sum(c.monto) _
        '         Select nro_lote, Total

        Dim dxeFull As List(Of Lecturas) = (From c In dm.Lecturas _
                         Where c.cod_moneda = Moneda.CodMoneda And c.cod_banco = Me.codBanco And c.fecha_lectura = Fecha And c.cod_proceso = proceso _
                            Select c _
                            Order By c.cod_maquina, c.nro_lote, c.cod_tipdoc Descending, c.cabecera).ToList


        'For Each item As DataGridViewRow In LecturasDataGridView.Rows
        '    item.ErrorText = ""
        '    item.Cells("tbcSerie").ErrorText = ""
        'Next

        LecturaView.ClearColumnErrors()


        '        For Each item As DataGridViewRow In LecturasDataGridView.Rows
        For i = 0 To LecturaView.RowCount - 1
            'validar(item)
            'Dim r As DataGridViewRow = item
            lc = CType(LecturaView.GetRow(i), Lecturas)

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

            'Dim listaRepetido As List(Of Lecturas) = (From l In dm.Lecturas _
            '                    Where l.numero_cheque = lc.numero_cheque _
            'And l.cod_banco_receptor = lc.cod_banco_receptor _
            'And l.cuenta_cheque = lc.cuenta_cheque _
            'And Not lc.EsCabecera _
            'And l.IdLectura <> lc.IdLectura _
            'And l.cod_banco = Me.codBanco _
            'And l.cod_moneda = Moneda.CodMoneda And l.fecha_lectura = Fecha And l.cod_proceso = proceso _
            'Select l).ToList
            If Not lc.EsCabecera Then
                'Dim listaRepetido = dm.App_VerificaRepetido(lc.numero_cheque, lc.cod_banco_receptor _
                ', lc.cuenta_cheque _
                ', lc.IdLectura _
                ', Me.codBanco _
                ', Moneda.CodMoneda, Fecha, proceso).FirstOrDefault

                'If listaRepetido IsNot Nothing Then
                '    Me.LecturaView.SetColumnError(Me.colnumero_cheque, String.Format("El cheque esta repetido en fecha {0}, Maquina {1} ", listaRepetido.fecha_lectura.Value.ToShortDateString, listaRepetido.cod_maquina))
                '    '                r.Cells("tbcSerie").ErrorText = String.Format("El cheque esta repetido en fecha {0}, Maquina {1} ", listaRepetido(0).fecha_lectura.Value.ToShortDateString, listaRepetido(0).cod_maquina)
                '    lc.AddError("numero_cheque", String.Format("El cheque esta repetido en fecha {0}, Maquina {1} ", listaRepetido.fecha_lectura.Value.ToShortDateString, listaRepetido.cod_maquina))
                '    LecturaView.FocusedRowHandle = i
                '    LecturaView.UpdateCurrentRow()
                'End If

                For Each l As Lecturas In dxeFull

                    If l.numero_cheque = lc.numero_cheque _
                And l.cod_banco_receptor = lc.cod_banco_receptor _
                And l.cuenta_cheque = lc.cuenta_cheque _
                And Not lc.EsCabecera _
                And l.IdLectura <> lc.IdLectura _
                And l.cod_banco = Me.codBanco _
                And l.cod_moneda = Moneda.CodMoneda And l.fecha_lectura = Fecha And l.cod_proceso = proceso Then

                        Me.LecturaView.SetColumnError(Me.colnumero_cheque, String.Format("El cheque esta repetido en fecha {0}, Maquina {1} ", l.fecha_lectura.Value.ToShortDateString, l.cod_maquina))
                        '                r.Cells("tbcSerie").ErrorText = String.Format("El cheque esta repetido en fecha {0}, Maquina {1} ", listaRepetido(0).fecha_lectura.Value.ToShortDateString, listaRepetido(0).cod_maquina)
                        lc.AddError("numero_cheque", String.Format("El cheque esta repetido en fecha {0}, Maquina {1} ", l.fecha_lectura.Value.ToShortDateString, l.cod_maquina))
                        lc.AgregarError(19, String.Format("El cheque esta repetido en fecha {0}, Maquina {1} ", l.fecha_lectura.Value.ToShortDateString, l.cod_maquina))
                        lc.CORREGIDO = False
                        lc.ConError = lc.Errores.Count > 0
                        LecturaView.FocusedRowHandle = i
                        LecturaView.UpdateCurrentRow()

                        Exit For
                    End If

                Next

            End If

           

            'If repetido Then
            '    '                r.ErrorText = String.Format("El cheque esta repetido en la secuencia {0}", CType(item.DataBoundItem, Lecturas).cabecera)
            '    r.Cells("tbcSerie").ErrorText = "El cheque esta repetido en la secuencia "
            'End If



        Next
        Me.LecturaView.ActiveFilterString = "[NroError]=19"
        '   MsgBox(Date.Now.Subtract(ini).TotalSeconds.ToString)

    End Sub

    Private Sub lnkSucursal_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkSucursal.LinkClicked
        'For Each dr As DataGridViewRow In Me.LecturasDataGridView.SelectedRows
        '    CType(dr.DataBoundItem, Lecturas).cod_sucursal = Me.cboSucursal.SelectedValue
        'Next

        Me.LecturaView.BeginUpdate()
        Dim lista = Me.LecturaView.GetSelectedRows()
        For i = 0 To LecturaView.SelectedRowsCount - 1
            LecturaView.SetRowCellValue(lista(i), "cod_sucursal", Me.cboSucursal.SelectedValue)
        Next

        Me.Grabar()
        Me.LecturaView.EndUpdate()

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
        MICR.CsdAbortScan()
        MICR.CsdTerminate()

        Select Case NroError
            Case 2
                MsgBox("No se ha hallado el Scanner. Compruebe el cable. Error: " + NroError.ToString, MsgBoxStyle.Critical)
            Case 6
                'No mostrar error cuando no hay cheque
            Case 7
                MsgBox("Papel atascado en el scanner, extraiga el papel y continue. Error: " + NroError.ToString, MsgBoxStyle.Critical)
            Case 18
                MsgBox("Error desconocido al acceder al Scanner. Error: " + NroError.ToString, MsgBoxStyle.Critical)
            Case Else
                MsgBox("Error no controlado al acceder al Scanner. Error: " + NroError.ToString, MsgBoxStyle.Critical)
        End Select


    End Sub


    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Try
            Dim Archivo As String = Path.Combine(My.Settings.Carpeta, "Lecturas.xls")
            Me.LecturaView.ExportToXls(Archivo)
            Process.Start(Archivo)
        Catch ex As Exception
            MessageBox.Show(Util.EnumErrors(ex))
        End Try
        
        'Util.Exportar(Me.LecturasDataGridView)
        'Me.GridView2.ExportToXls(
    End Sub
    Sub HabilitarControles(ByVal Habilitado As Boolean)
        Me.tsbCargar.Enabled = Habilitado
        Me.tsbDescargar.Enabled = Habilitado
        Me.tpOpciones.Enabled = Habilitado
        Me.tsbIniciarCaptura.Enabled = Habilitado


        Me.tsbErrores.Enabled = Habilitado
        Me.tsEliminar.Enabled = Habilitado
        Me.tsbValidar.Enabled = Habilitado
        Me.tsbEditar.Enabled = Habilitado
        Me.tsbInsertar.Enabled = Habilitado
        Me.tsbCierre.Enabled = Habilitado


        'Me.LecturasDataGridView.AllowUserToAddRows = Habilitado
        If Habilitado Then
            frmProgreso.Label1.Text = ""
            frmProgreso.Hide()

        Else
            ' frmProgreso.MdiParent = Me
            Me.LecturaView.ClearColumnsFilter()
            Me.LecturaView.ClearGrouping()
            Me.LecturaView.ClearSorting()

            If Me.Asincrono Then
                frmProgreso.Show()
            End If


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
        validar(False)
    End Sub

    Private Sub FiltrarErroresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FiltrarErroresToolStripMenuItem.Click
        tsbErrores_Click(sender, e)
    End Sub

    Private Sub IniciarCapturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IniciarCapturaToolStripMenuItem.Click
        ToolStripButton1_Click(sender, e)
    End Sub

    Sub SumarSubTotales()
        Return


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

        Me.txtSubTotalCab.Text = SubTotalCab.ToString("N" + Moneda.Decimales.ToString)
        Me.txtSubTotalDet.Text = SubTotalDet.ToString("N" + Moneda.Decimales.ToString)
        Me.lblSubTotalCab.Text = String.Format("Cab ({0:N0})", cCab)
        Me.lblSubTotalDet.Text = String.Format("Det ({0:N0})", cDet)
        Me.txtErrores.Text = cErrores.ToString("N0")
        Me.txtSubDif.Text = (SubTotalCab - SubTotalDet).ToString("N" + Moneda.Decimales.ToString)

    End Sub

    Private Sub LecturasBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LecturasBindingSource.CurrentChanged
        LecturasBindingSource_CurrentItemChanged(Nothing, Nothing)
    End Sub

    Private Sub LecturasBindingSource_CurrentItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LecturasBindingSource.CurrentItemChanged
        If ToolWindow1.DockState <> Telerik.WinControls.UI.Docking.DockState.Hidden Then
            If LecturasBindingSource.Current IsNot Nothing Then
                If Me.ImagenBase1.NombreImagen <> CType(LecturasBindingSource.Current, Lecturas).imagen_frontal Then
                    Me.ImagenBase1.NombreImagen = CType(LecturasBindingSource.Current, Lecturas).imagen_frontal
                End If
                If Me.ImagenBase1.NombreImagen1 <> CType(LecturasBindingSource.Current, Lecturas).imagen_reverso Then
                    Me.ImagenBase1.NombreImagen1 = CType(LecturasBindingSource.Current, Lecturas).imagen_reverso
                End If

            End If

        End If
        'If Me.TaskPane2.TaskFrames(0).IsExpanded Then
        'End If
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


    Private Sub TaskPane2_FrameCollapsed(ByVal sender As Object, ByVal e As WindowsControlLibrary.TaskPaneEventArgs)

        'TaskPane2.Height = 22
        CalcularAltoTaskPane()
    End Sub

    Private Sub TaskPane2_FrameExpanded(ByVal sender As Object, ByVal e As WindowsControlLibrary.TaskPaneEventArgs)
        'TaskPane2.Height = e.TaskFrame.Height + 22
        CalcularAltoTaskPane()
        LecturasBindingSource_CurrentItemChanged(Nothing, Nothing)
    End Sub
    Sub CalcularAltoTaskPane()
        Dim Alto As Double = 0

        'For Each tp As TaskFrame In TaskPane2.TaskFrames
        '    If tp.IsExpanded Then
        '        Alto += tp.Height + 22
        '    Else
        '        Alto += 22
        '    End If

        'Next

        'TaskPane2.Height = Alto

    End Sub

    Private Sub ImagenBase1_CambiarImagen()
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
        'For Each dr As DataGridViewRow In Me.LecturasDataGridView.SelectedRows
        '    lectura = CType(dr.DataBoundItem, Lecturas)
        '    lectura.IdMotivo = Me.cboMotivo.SelectedValue
        '    AplicarComision(lectura, cboMotivo.SelectedItem)
        'Next

        Me.LecturaView.BeginUpdate()
        Dim lista = Me.LecturaView.GetSelectedRows()
        For i = 0 To Me.LecturaView.SelectedRowsCount - 1
            lectura = CType(LecturaView.GetRow(lista(i)), Lecturas)
            lectura.IdMotivo = Me.cboMotivo.SelectedValue
            AplicarComision(lectura, cboMotivo.SelectedItem)

        Next

        Me.Grabar()
        Me.LecturaView.EndUpdate()
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

        If MessageBox.Show("Esta seguro que desea eliminar los registros seleccionados?", "Clearing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim lista() = Me.LecturaView.GetSelectedRows()
            For i = 0 To Me.LecturaView.SelectedRowsCount - 1
                dm.DeleteObject(CType(Me.LecturaView.GetRow(lista(i)), Lecturas))
            Next

            Me.LecturaView.DeleteSelectedRows()
            Me.Grabar()
            Me.ProcesarLectura()

        End If

        'For Each dr As DataGridViewRow In Me.LecturasDataGridView.SelectedRows
        'Me.LecturasDataGridView

        'Next

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
            'ElseIf Me.Oper = Operacion.Interna Then
            'Aqui va las opciones de camara interna
        Else

            Me.tfValidar.Height = 80
            Me.lnkValidarCREC.Visible = False
            Me.cmdImportar.Visible = False
            Me.tfCREC.Visible = False
            Me.RadDock1.RemoveWindow(Me.tfCREC)

            '    Me.TaskPane2.TaskFrames.Remove(Me.tfCREC)
        End If

        If Not Me.Oper = Operacion.Interna Then
            Me.tfCHERFII.Visible = False
            Me.tfCHITCI.Visible = False

            'TODO: Verificar

            Me.RadDock1.RemoveWindow(Me.tfCHERFII)
            Me.RadDock1.RemoveWindow(Me.tfCHITCI)
            'Me.TaskPane2.TaskFrames.Remove(Me.tfCHERFII)
            'Me.TaskPane2.TaskFrames.Remove(Me.tfCHITCI)

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
        'Dim dxCREC As New Sorteable.FilteredBindingList(Of CRECDet)(dm)
        'Me.DataGridViewTextBoxColumn2.FilteringEnabled = True
        'Me.Existe.FilteringEnabled = True
        'dxCREC.Load(det)
        Me.CRECDetBindingSource.DataSource = Nothing
        Me.CRECDetBindingSource.DataSource = det



        Dim lc As Lecturas
        '  For Each item As DataGridViewRow In Me.LecturasDataGridView.Rows

        'TODO : Mostrar errores de CREC
        For i = 0 To LecturaView.RowCount - 1
            'item.ErrorText = ""
            'Me.GridView1.ClearColumnErrors()
            'Dim item = Me.GridView1
            ExisteError = False
            lc = CType(LecturaView.GetRow(i), Lecturas)

            If Not lc.EsCabecera Then

                'Dim Existe = (Aggregate word In det _
                '            Into Any(word.Numero = lc.numero_cheque _
                '            And word.IdBanco = lc.cod_banco_emisor))
                Dim Existe = (From s In det Where s.IdBanco = lc.cod_banco_emisor _
                             And s.Numero = lc.numero_cheque).FirstOrDefault

                If Existe Is Nothing Then

                    lc.AgregarError(15, "No se encuentra en el CREC.")
                    lc.AddError("numero_cheque", "No se encuentra en el CREC.")
                    ExisteError = True
                Else
                    'Solo Aplicar la correccion cuando el monto es igual a 0
                    If Existe.Cuenta = lc.cuenta_cheque And lc.monto = 0 And ChkCorregir.Checked Then
                        'lc.monto = Existe.Importe
                        LecturaView.SetRowCellValue(i, "monto", Existe.Importe)
                    End If
                    Existe = (From s In det Where s.IdBanco = lc.cod_banco_emisor _
                             And s.Numero = lc.numero_cheque And s.Cuenta = lc.cuenta_cheque).FirstOrDefault

                    If Existe Is Nothing Then
                        '       item.ErrorText = "Nro de Cuenta no corresponde con el CREC."
                        lc.AgregarError(16, "Nro de Cuenta no corresponde con el CREC.")
                        lc.AddError("cuenta_cheque", "Nro de Cuenta no corresponde con el CREC.")
                        ExisteError = True
                    Else

                        If Existe.Importe <> lc.monto Then
                            '  item.ErrorText = "Monto no corresponde con el CREC."
                            lc.AgregarError(17, "Monto no corresponde con el CREC.")
                            lc.AddError("monto", "Monto no corresponde con el CREC.")
                            ExisteError = True
                            'End If
                        End If
                    End If
                End If
            End If

            lc.ConError = ExisteError
            lc.IB_MONTO = ExisteError
            lc.CORREGIDO = Not ExisteError
        Next

        'Analizamos el CREC para detectar registros que no se hayan leido
        Dim cdet As CRECDet
        'Dim listaLectura As FilteredBindingList(Of Lecturas)
        Dim listaLectura As List(Of Lecturas)
        listaLectura = LecturasBindingSource.List
        'listaLectura = Me.LecturasDataGridView.Rows
        Dim ExisteCREC As Boolean
        Dim RowCounts As Integer = Me.GridView2.RowCount
        For i = 0 To Me.GridView2.RowCount - 1
            cdet = CType(Me.GridView2.GetRow(i), CRECDet)
            ExisteCREC = (Aggregate word In listaLectura _
                Into Any(word.numero_cheque = cdet.Numero))
            cdet.Existe = IIf(ExisteCREC, "Si", "No")


        Next


        '        For Each item As DataGridViewRow In Me.GridView2
        '            cdet = CType(item.DataBoundItem, CRECDet)
        '            ExisteCREC = (Aggregate word In listaLectura _
        'Into Any(word.numero_cheque = cdet.Numero))
        '            cdet.Existe = IIf(ExisteCREC, "Si", "No")
        '        Next
        '        det.Clear()
        '       det = Nothing
        listaLectura = Nothing


        '      Me.LecturasDataGridView.Update()
        If ChkCorregir.Checked Then
            grabar()
        End If
    End Sub


    Private Sub CRECDetDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        e.Cancel = True
    End Sub



    Private Sub GridView1_ColumnFilterChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LecturaView.ColumnFilterChanged

    End Sub

    Private Sub GridView1_CustomSummaryCalculate(ByVal sender As Object, ByVal e As DevExpress.Data.CustomSummaryEventArgs) Handles LecturaView.CustomSummaryCalculate
        ' Get the summary ID. 
        Dim summaryID As Integer = Convert.ToInt32(CType(e.Item, GridSummaryItem).Tag)
        Dim View As GridView = CType(sender, GridView)
        ' Initialization 
        If e.SummaryProcess = CustomSummaryProcess.Start Then
            STCab = 0
            STDet = 0
            STErr = 0
            StDif = 0
            StCabn = 0
            STDetn = 0
        End If
        ' Calculation 
        If e.SummaryProcess = CustomSummaryProcess.Calculate Then
            Dim esCabecera As Boolean = CBool(View.GetRowCellValue(e.RowHandle, "EsCabecera"))
            Dim conError As Boolean = CBool(View.GetRowCellValue(e.RowHandle, "ConError"))
            Select Case summaryID
                Case 1 ' The total summary calculated against the 'UnitPrice' column. 
                    '                    If Not esCabecera Then STCab += Convert.ToDecimal(e.FieldValue)
                    If esCabecera Then
                        StCabn += 1
                    Else
                        STDetn += 1
                    End If
                    If esCabecera Then STCab += Convert.ToDecimal(e.FieldValue)

                    If Not esCabecera Then STDet += Convert.ToDecimal(e.FieldValue)

                    If conError Then STErr += 1

                Case 2 ' The group summary. 
                    If Not esCabecera Then STDet += Convert.ToDecimal(e.FieldValue)
                Case 3 ' The group summary. 
                    If esCabecera Then
                        StDif += Convert.ToDecimal(e.FieldValue)
                    Else
                        StDif -= Convert.ToDecimal(e.FieldValue)
                    End If


            End Select


        End If
        ' Finalization 
        If e.SummaryProcess = CustomSummaryProcess.Finalize Then
            Select Case summaryID
                Case 1
                    e.TotalValue = STCab
                    txtSubTotalCab.Text = STCab.ToString("N" + My.Application.Moneda.decimales.ToString)
                    txtSubTotalDet.Text = STDet.ToString("N" + My.Application.Moneda.decimales.ToString)
                    txtErrores.Text = STErr.ToString("N0")
                    txtSubDif.Text = (STCab - STDet).ToString("N" + My.Application.Moneda.decimales.ToString)
                    Me.lblSubTotalCab.Text = String.Format("Cab ({0:N0})", StCabn)
                    Me.lblSubTotalDet.Text = String.Format("Det ({0:N0})", STDetn)

                Case 2
                    e.TotalValue = STDet
                Case 3
                    e.TotalValue = StDif

            End Select
        End If
    End Sub

    Private Sub LecturaView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles LecturaView.FocusedRowChanged
        Dim currentView As GridView = CType(sender, GridView)
        ' The group row's handle. 
        Dim groupRowHandle As Integer
        If (e.FocusedRowHandle > 0) Then
            groupRowHandle = currentView.GetParentRowHandle(e.FocusedRowHandle)
        Else
            groupRowHandle = e.FocusedRowHandle
        End If
        If Not currentView.IsGroupRow(groupRowHandle) Then Return

        ' Get group summary values. 
        Dim ht As Hashtable = currentView.GetGroupSummaryValues(groupRowHandle)
        Text = ""
        ' Iterate through group summaries. 
        Dim entry As DictionaryEntry
        For Each entry In ht
            Dim sumItem As GridGroupSummaryItem = entry.Key
            Dim val As Object = entry.Value
            ' Get the summry item's Tag property and summary value. 
            Text += sumItem.Tag.ToString() + ": " + val.ToString() + "\t"
        Next

    End Sub

    Private Sub LecturaView_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles LecturaView.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction

    End Sub




    Private Sub GridView1_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles LecturaView.ValidateRow
        ' Dim view As ColumnView = CType(sender, ColumnView)

        Me.ValidarGridView(CType(e.Row, Lecturas), False)



        'If l.cod_tipdoc = "@@" Then
        '    'e.Valid = False
        '    view.SetColumnError(colcod_tipdoc, "El tipo de doc no es valido")
        'End If

        If Me.Editado Then
            CType(e.Row, Lecturas).Editado = True
            LecturaView.UpdateCurrentRow()
            grabar()
            Editado = False
        End If
    End Sub

    Private Sub LecturaView_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles LecturaView.ValidatingEditor
        Me.Editado = True


    End Sub
    Sub ValidarGridView(ByVal lc As Lecturas, Cierre As Boolean)
        'Dim lc As Lecturas
        lc.Errores.Clear()
        lc.ClearError()
        lc.CORREGIDO = True
        If lc.monto <= 0 Then
            lc.CORREGIDO = False
            lc.AgregarError(1, "El Importe debe ser Mayor a 0")
            ' results.AddResult(New ValidationResult("El Importe debe ser Mayor a 0", GetType(Lecturas), "monto", "", Nothing))
            lc.AddError("monto", "El Importe debe ser Mayor a 0")
        End If

        If lc.cadena_captura IsNot Nothing AndAlso lc.cadena_captura.Length > 100 Then
            lc.CORREGIDO = False
            ' results.AddResult(New ValidationResult("La cadena de Captura es mayor a lo requerido.", GetType(Lecturas), "cadena_captura", "", Nothing))
        End If

        'Se realiza solo para los cheques y no para las cabeceras
        If Not lc.EsCabecera Then

            If lc.cod_proceso = 2 Or lc.cod_proceso = 1 Then
                If lc.cod_banco_emisor = lc.cod_banco_receptor Then ''Enviado y Devuelto
                    lc.CORREGIDO = False
                    lc.AgregarError(2, "El banco emisor no puede ser igual a receptor")
                    '  results.AddResult(New ValidationResult("El banco emisor no puede ser igual a receptor", GetType(Lecturas), "cod_banco_receptor", "", Nothing))
                    lc.AddError("cod_banco_receptor", "El banco emisor no puede ser igual a receptor")
                End If
                'If Me.cod_proceso = 2 Or Me.cod_proceso = 1 Then
                If lc.cod_banco <> lc.cod_banco_emisor Then
                    lc.CORREGIDO = False
                    lc.AgregarError(3, "El banco receptor debe ser igual al banco actual")
                    'results.AddResult(New ValidationResult("El banco receptor debe ser igual al banco actual", GetType(Lecturas), "cod_banco_emisor", "", Nothing))
                    lc.AddError("cod_banco_emisor", "El banco receptor debe ser igual al banco actual")
                End If
            End If


            If lc.cod_proceso = 3 Or lc.cod_proceso = 4 Then
                If lc.cod_banco <> lc.cod_banco_receptor Then
                    lc.CORREGIDO = False
                    lc.AgregarError(4, "El banco emisor debe ser igual al banco actual")
                    'results.AddResult(New ValidationResult("El banco emisor debe ser igual al banco actual", GetType(Lecturas), "cod_banco_receptor", "", Nothing))
                    lc.AddError("cod_banco_receptor", "El banco emisor debe ser igual al banco actual")
                End If
                If lc.cod_banco = lc.cod_banco_emisor Then
                    lc.CORREGIDO = False
                    lc.AgregarError(5, "El banco receptor no puede ser igual al banco actual")

                    'results.AddResult(New ValidationResult("El banco receptor no puede ser igual al banco actual", GetType(Lecturas), "cod_banco_emisor", "", Nothing))
                    '_errors.Add("cod_banco_emisor", "El banco emisor no puede ser igual a receptor.")
                    lc.AddError("cod_banco_emisor", "El banco receptor no puede ser igual al banco actual")
                End If
            End If

            If lc.cuenta_cheque <= 0 Then
                lc.CORREGIDO = False
                lc.AgregarError(13, "El Nro de Cuenta no puede ser 0.")
                'results.AddResult(New ValidationResult("El Nro de Cuenta no puede ser 0.", GetType(Lecturas), "cuenta_cheque", "", Nothing))
                lc.AddError("cuenta_cheque", "El Nro de Cuenta no puede ser 0.")
            End If

            If Not lc.EsCabecera And lc.numero_cheque = 0 Then
                '    r.Cells(5).ErrorText = "Nro de Cheque no valido."
                lc.CORREGIDO = False
                lc.AgregarError(6, "Nro de Cheque no valido.")
                lc.AddError("numero_cheque", "Nro de Cheque no valido.")
            End If

        End If

        '18/06/2011
        'Validamos cuenta con el algoritmo de cada empresa
        '10-11-11
        'Validamos la cuenta cuando no es cierre

        If Not Cierre Then
            If ((Oper = Operacion.Enviado Or Oper = Operacion.Interna) _
            And lc.EsCabecera) Or ((Oper = Operacion.Recibido Or Oper = Operacion.Rechazado Or Oper = Operacion.Interna) And Not lc.EsCabecera) And (lc.cuenta_cheque IsNot Nothing) Then
                If Not Val.Validar(Me.codBanco, lc.cuenta_cheque.ToString, Oper) Then
                    lc.CORREGIDO = False
                    lc.AgregarError("cuenta_cheque", 13)
                    'lc.AgregarError(13, "La cuenta no es válida.")
                    'lc.AddError("cuenta_cheque", "La cuenta no es válida.")
                End If

                If lc.cuenta_cheque.ToString.Length > My.Application.Constantes.LONGITUD_CUENTA Then
                    lc.CORREGIDO = False
                    lc.AgregarError("cuenta_cheque", 20)
                    'results.AddResult(New ValidationResult("El Nro de Cuenta no puede ser 0.", GetType(Lecturas), "cuenta_cheque", "", Nothing))
                    'lc.AddError("cuenta_cheque", "El Nro de Cuenta no puede ser 0.")
                End If


            End If
        End If

        If Cierre And Not lc.EsCabecera Then
            For Each l As Lecturas In dxe

                If Not l.EsCabecera Then

                    If l.numero_cheque = lc.numero_cheque _
                AndAlso l.cuenta_cheque = lc.cuenta_cheque _
                AndAlso l.cod_banco_receptor = lc.cod_banco_receptor _
                AndAlso l.IdLectura <> lc.IdLectura Then
                        '                And l.cod_banco = Me.codBanco _
                        '               And l.cod_moneda = Moneda.CodMoneda And l.fecha_lectura = Fecha And l.cod_proceso = Oper Then

                        'Me.LecturaView.SetColumnError(Me.colnumero_cheque, String.Format("El cheque esta repetido en fecha {0}, Maquina {1} ", l.fecha_lectura.Value.ToShortDateString, l.cod_maquina))
                        '                r.Cells("tbcSerie").ErrorText = String.Format("El cheque esta repetido en fecha {0}, Maquina {1} ", listaRepetido(0).fecha_lectura.Value.ToShortDateString, listaRepetido(0).cod_maquina)
                        lc.AddError("numero_cheque", String.Format("El cheque esta repetido en fecha {0}, Maquina {1} ", l.fecha_lectura.Value.ToShortDateString, l.cod_maquina))
                        lc.AgregarError(19, String.Format("El cheque esta repetido en fecha {0}, Maquina {1} ", l.fecha_lectura.Value.ToShortDateString, l.cod_maquina))
                        lc.CORREGIDO = False
                        'lc.ConError = lc.Errores.Count > 0
                        'LecturaView.FocusedRowHandle = i
                        'LecturaView.UpdateCurrentRow()

                        Exit For
                    End If
                End If
            Next


        End If


        lc.ConError = lc.Errores.Count > 0
    End Sub

    Private Sub GridView2_ColumnFilterChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView2.ColumnFilterChanged
        Dim existe As Boolean = False
        For i = 0 To GridView2.ActiveFilter.Count - 1
            If GridView2.ActiveFilter(i).Filter.FilterString.Contains("IdBanco") Then
                Dim DateFilter As ColumnFilterInfo

                DateFilter = New ColumnFilterInfo(GridView2.ActiveFilter(i).Filter.FilterString.Replace("IdBanco", "cod_banco_emisor"))
                colcod_banco_emisor.FilterInfo = DateFilter
                existe = True
            End If
        Next
        If Not existe Then
            colcod_banco_emisor.ClearFilter()
        End If

    End Sub

    Private Sub Edit8_Spin(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.SpinEventArgs) Handles Edit8.Spin
        e.Handled = True
    End Sub

    Private Sub Edit12_Spin(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.SpinEventArgs) Handles Edit12.Spin
        e.Handled = True
    End Sub

    Private Sub MontoEditor_Spin(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.SpinEventArgs) Handles MontoEditor.Spin
        e.Handled = True
    End Sub

    Private Sub nudLote_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudLote.ValueChanged

    End Sub

    'Cargar CHITCI
    Private Sub LinkLabel8_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        Try
            Dim FileName As String

            If CHITCIBindingSource.List.Count > 0 Then
                If MsgBox("Ya existen datos del CHITCI. Desea eliminarlos para volver a cargar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    CHITCIBindingSource.Clear()
                Else
                    Return
                End If

            End If

            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                FileName = OpenFileDialog1.FileName
                Dim txt As StreamReader = New StreamReader(FileName)
                Dim Cadena As String = String.Empty
                Cadena = txt.ReadLine()
                If Cadena.Length > 0 Then
                    'If Cadena.Substring(0, 10) <> "CHERFII" Then
                    '    MsgBox("El archivo no corresponde al proceso")
                    '    Return
                    'Else
                    '    CargarCabecera(Cadena)
                    'End If
                    CargarCHITCI(Cadena)
                End If

                Cadena = txt.ReadLine()
                While Cadena IsNot Nothing
                    CargarCHITCI(Cadena)
                    Cadena = txt.ReadLine()
                End While

                txt.Close()
                grabar()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Sub CargarCHERFII(ByVal Cadena As String)
        Dim dd As Integer
        Dim mm As Integer
        Dim aaaa As Integer


        Dim cd As New DataAccess.CHERFII
        cd.CtaLibradora = Cadena.Substring(0, 9)
        cd.NroCheque = CInt(Cadena.Substring(9, 7))
        cd.Comprobante = CInt(Cadena.Substring(16, 7))
        cd.AgenciaCR = Cadena.Substring(23, 2)
        cd.Usuario = Cadena.Substring(25, 10)
        cd.Importe = CDec(Cadena.Substring(35, 15))
        dd = CInt(Cadena.Substring(50, 2))
        mm = CInt(Cadena.Substring(52, 2))
        aaaa = CInt(Cadena.Substring(54, 4))

        If dd > 0 Then
            cd.FechaProc = New Date(aaaa, mm, dd)
        End If

        'cd.HoraProc = Cadena.Substring(58, 6)
        cd.CtaDeposito = CInt(Cadena.Substring(64, 9))
        Me.CHERFIIBindingSource.Add(cd)
        ' Me.CHERFIIBindingSource.
    End Sub
    Sub CargarCHITCI(ByVal Cadena As String)
        Dim cd As New DataAccess.CHITCI
        Dim dd As Integer
        Dim mm As Integer
        Dim aaaa As Integer
        'cd.IdBanco = CInt(Cadena.Substring(0, 4))
        cd.Usuario = Cadena.Substring(0, 10)
        cd.NroMovUsuario = CInt(Cadena.Substring(10, 4))
        aaaa = CInt(Cadena.Substring(14, 4))
        mm = CInt(Cadena.Substring(18, 2))
        dd = CInt(Cadena.Substring(20, 2))
        cd.FechaMov = New Date(aaaa, mm, dd)
        cd.CtaDeposito = Cadena.Substring(22, 9)
        cd.Moneda = Cadena.Substring(31, 2)
        cd.Agencia = Cadena.Substring(33, 2)
        cd.TipoUsuario = Cadena.Substring(35, 1)
        cd.Comprobante = CInt(Cadena.Substring(36, 7))
        cd.Importe = CDec(Cadena.Substring(43, 12))
        cd.CantCheques = CInt(Cadena.Substring(57, 4))
        'cd.HoraMov = Cadena.Substring(61, 6)
        'cd.EstadoProceso = Cadena.Substring(67, 1)
        cd.IdBanco = Me.codBanco
        cd.IdMoneda = Me.Moneda.CodMoneda
        cd.Existe = False
        Me.CHITCIBindingSource.Add(cd)
    End Sub
    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Try

            If CHERFIIBindingSource.List.Count > 0 Then
                If MsgBox("Ya existen datos del CHERFII. Desea eliminarlos para volver a cargar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    CHERFIIBindingSource.Clear()
                Else
                    Return
                End If

            End If

            Dim FileName As String
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                FileName = OpenFileDialog1.FileName
                Dim txt As StreamReader = New StreamReader(FileName)
                Dim Cadena As String = String.Empty
                Cadena = txt.ReadLine()

                'If Cadena.Length > 0 Then
                '    'If Cadena.Substring(0, 10) <> "CHERFII" Then
                '    '    MsgBox("El archivo no corresponde al proceso")
                '    '    Return
                '    'Else
                '    '    CargarCabecera(Cadena)
                '    'End If
                '    CargarCHERFII(Cadena)
                'End If
                'Cadena = txt.ReadLine()

                While Cadena IsNot Nothing
                    CargarCHERFII(Cadena)
                    Cadena = txt.ReadLine()
                End While

                txt.Close()
                grabar()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub LinkPaqueteAct_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkPaqueteAct.LinkClicked
        Me.LecturaView.BeginUpdate()
        Dim lista = Me.LecturaView.GetSelectedRows()

        For i = 0 To Me.LecturaView.SelectedRowsCount - 1
            Me.LecturaView.SetRowCellValue(lista(i), "PAQUETE", Me.nudPaquete.Value)
        Next

        Me.Grabar()
        Me.LecturaView.EndUpdate()

    End Sub

    Class ListaConError
        Public Maquina As Integer
        Public Lote As Integer
        Public Paquete As Integer
    End Class

    
    Private Sub LinkLabel9_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        VerificarCHITCI()
    End Sub

    Sub VerificarCHITCI(Optional ByVal Simple As Boolean = False)

        Dim ExisteError As Boolean = False

        If CHITCIBindingSource.Count = 0 Then
            If Not Simple Then
                MsgBox("Debe cargar primeramente el archivo CHITCI para realizar esta validacion")
            End If
            Return

        End If

        ' VG 26/04/2011
        ' Reiniciamos los valores para validar todos
        For Each s As CHITCI In CHITCIBindingSource.List
            s.IdLectura = Nothing
            s.Existe = False
        Next


        '07/02/2011
        'VG Cargamos los cheques de todas las maquinas
        CargarDatos(True)

        Dim lc As Lecturas



        For i = 0 To LecturaView.RowCount - 1


            ExisteError = True
            lc = CType(LecturaView.GetRow(i), Lecturas)

            lc.ClearError()
            lc.Errores.Clear()
            lc.ConError = False
            lc.IB_MONTO = False
            lc.CORREGIDO = True
            lc.VERIFICADO = True


            If lc.EsCabecera And lc.PAQUETE = nudPaquete.Value Then

                lc.ExisteCHITCI = False

                '---------------1ra Pasada: Validamos Cuenta, Serie, Monto y Sucursal
                '
                For Each s As CHITCI In CHITCIBindingSource.List

                    If s.IdLectura Is Nothing Then

                        If lc.numero_cheque = s.Comprobante And lc.cuenta_cheque = s.CtaDeposito _
                            And lc.cod_sucursal = CInt(s.Agencia) Then

                            'VG 29/04/2011
                            'Asignamos el cajero que vino en el archivo
                            lc.cajero = s.Usuario
                            s.IdLectura = lc.IdLectura

                            lc.ExisteCHITCI = True

                            If lc.monto = s.Importe Then

                                ExisteError = False
                                lc.VERIFICADO = True

                                Exit For

                            Else
                                'lc.AgregarError(17, "Monto no corresponde con el CHITCI.")
                                'lc.AddError("monto", "Monto no corresponde con el CHITCI.")

                                lc.AgregarError("monto", 17)

                                If chkFiltrarErrorCHITCI.Checked Then
                                    Me.MarcarDetalle(lc.cod_maquina, lc.nro_lote, 17, "")
                                End If

                                Exit For

                            End If
                        End If
                    End If
                Next


                '-------------2da. Pasada, Validamos Cuenta, Sucursal y Monto
                If Not lc.ExisteCHITCI Then
                    For Each s As CHITCI In CHITCIBindingSource.List

                        If s.IdLectura Is Nothing Then
                            If lc.cuenta_cheque = s.CtaDeposito _
                            And lc.cod_sucursal = CInt(s.Agencia) And lc.monto = s.Importe Then

                                'VG 29/04/2011
                                'Asignamos el cajero que vino en el archivo
                                lc.cajero = s.Usuario
                                s.IdLectura = lc.IdLectura

                                lc.ExisteCHITCI = True

                                ExisteError = False
                                lc.VERIFICADO = True

                                Exit For

                            End If
                        End If
                    Next

                End If


                '---------------3ra. Pasada, Verificamos Cuenta, Sucursal y Monto
                If Not lc.ExisteCHITCI Then
                    For Each s As CHITCI In CHITCIBindingSource.List

                        If s.IdLectura Is Nothing Then
                            If lc.numero_cheque = s.Comprobante _
                            And lc.cod_sucursal = CInt(s.Agencia) And lc.monto = s.Importe Then

                                If chkCorregirCHITCI.Checked And lc.cuenta_cheque <> s.CtaDeposito Then
                                    'Corregimos la cuenta del Deposito si esta marcado para hacerlo
                                    lc.cuenta_cheque = s.CtaDeposito

                                    lc.cajero = s.Usuario
                                    s.IdLectura = lc.IdLectura


                                    ExisteError = False
                                    lc.VERIFICADO = True
                                    Exit For
                                End If


                            End If
                        End If
                    Next
                End If



                If ExisteError Then

                    'lc.AgregarError(15, "No se encuentra en el CHITCI.")
                    'lc.AddError("numero_cheque", "No se encuentra en el CHITCI.")

                    lc.AgregarError("numero_cheque", 15)

                    If chkFiltrarErrorCHITCI.Checked Then
                        Me.MarcarDetalle(lc.cod_maquina, lc.nro_lote, 15, "")
                    End If

                Else

                End If

                lc.ConError = ExisteError
                lc.IB_MONTO = ExisteError
                lc.CORREGIDO = Not ExisteError
                lc.VERIFICADO = Not ExisteError





            End If


        Next





        'Analizamos el CHITCI para detectar registros que no se hayan leido
        Dim cdet As CHITCI

        Dim listaLectura As List(Of Lecturas)
        listaLectura = LecturasBindingSource.List


        For i = 0 To Me.gridCHITCI.RowCount - 1
            cdet = CType(Me.gridCHITCI.GetRow(i), CHITCI)

            ExisteError = True

        
            If cdet.IdLectura Is Nothing Then
                ExisteError = True
            Else
                ExisteError = False
            End If

            If ExisteError Then
                ExisteError = dm.App_BuscarCHITCI(cdet.CtaDeposito, cdet.Agencia, cdet.Comprobante, cdet.Importe, codBanco, Moneda.CodMoneda, Fecha).ToList.Count = 0
                If Not ExisteError Then
                    cdet.EstadoProceso = "P"
                End If
            End If

            Me.gridCHITCI.SetRowCellValue(i, "Existe", Not ExisteError)

        Next


        listaLectura = Nothing
        grabar()

        If chkFiltrarErrorCHITCI.Checked Then
            Me.LecturaView.ActiveFilterString = "[NroError]=17 or [NroError]=15"
            Me.gridCHITCI.ActiveFilterString = "[Existe]=False"

        End If


    End Sub
    Sub VerificarCHITCI1(Optional ByVal Simple As Boolean = False)

        Dim ExisteError As Boolean = False
        'If listaCREC.Count = 0 Then
        '    listaCREC = (dm.CREC.Include("CRECDet").Where(Function(p) p.Fecha = Fecha And p.CodBanco = codBanco)).ToList()
        'End If

        If CHITCIBindingSource.Count = 0 Then
            If Not Simple Then
                MsgBox("Debe cargar primeramente el archivo CHITCI para realizar esta validacion")
            End If
            Return

        End If

        ' VG 26/04/2011
        ' Reiniciamos los valores para validar todos
        For Each s As CHITCI In CHITCIBindingSource.List
            s.IdLectura = Nothing
            s.Existe = False
        Next


        '07/02/2011
        'VG Cargamos los cheques de todas las maquinas
        CargarDatos(True)

        Dim lc As Lecturas

        '---------------1ra Pasada

        For i = 0 To LecturaView.RowCount - 1
            'item.ErrorText = ""
            'Me.GridView1.ClearColumnErrors()
            'Dim item = Me.GridView1


            ExisteError = True
            lc = CType(LecturaView.GetRow(i), Lecturas)

            '           lc.Errores.Clear()

            lc.ClearError()
            lc.Errores.Clear()
            lc.ConError = False
            lc.IB_MONTO = False
            lc.CORREGIDO = True
            lc.VERIFICADO = True


            If lc.EsCabecera And lc.PAQUETE = nudPaquete.Value Then


                lc.ExisteCHITCI = False

                'Dim Existe = (Aggregate word In det _
                '            Into Any(word.Numero = lc.numero_cheque _
                '            And word.IdBanco = lc.cod_banco_emisor))


                For Each s As CHITCI In CHITCIBindingSource.List

                    If s.IdLectura Is Nothing Then

                        If lc.numero_cheque = s.Comprobante And lc.cuenta_cheque = s.CtaDeposito _
                            And lc.cod_sucursal = CInt(s.Agencia) Then

                            s.IdLectura = lc.IdLectura

                            'VG 29/04/2011
                            'Asignamos el cajero que vino en el archivo
                            lc.cajero = s.Usuario
                            lc.ExisteCHITCI = True

                            If lc.monto = s.Importe Then

                                ExisteError = False
                                lc.VERIFICADO = True

                                Exit For

                            Else
                                lc.AgregarError(17, "Monto no corresponde con el CHITCI.")
                                lc.AddError("monto", "Monto no corresponde con el CHITCI.")
                                Exit For

                            End If
                        End If
                    End If
                Next




            End If

            'lc.ConError = ExisteError
            'lc.IB_MONTO = ExisteError
            'lc.CORREGIDO = Not ExisteError
        Next



        For i = 0 To LecturaView.RowCount - 1
            'item.ErrorText = ""
            'Me.GridView1.ClearColumnErrors()
            'Dim item = Me.GridView1


            ExisteError = True
            lc = CType(LecturaView.GetRow(i), Lecturas)

            '           lc.Errores.Clear()
            '           lc.ClearError()

            If lc.ExisteCHITCI = False Then


                If lc.EsCabecera And lc.PAQUETE = nudPaquete.Value Then

                    'Dim Existe = (Aggregate word In det _
                    '            Into Any(word.Numero = lc.numero_cheque _
                    '            And word.IdBanco = lc.cod_banco_emisor))




                    For Each s As CHITCI In CHITCIBindingSource.List

                        If s.IdLectura Is Nothing Then
                            If lc.cuenta_cheque = s.CtaDeposito _
                            And lc.cod_sucursal = CInt(s.Agencia) And lc.monto = s.Importe Then

                                'VG 29/04/2011
                                'Asignamos el cajero que vino en el archivo
                                lc.cajero = s.Usuario


                                ExisteError = False
                                s.IdLectura = lc.IdLectura
                                lc.VERIFICADO = True
                                Exit For

                            End If
                        End If
                    Next




                    If ExisteError Then
                        lc.AgregarError(15, "No se encuentra en el CHITCI.")
                        lc.AddError("numero_cheque", "No se encuentra en el CHITCI.")
                    Else

                    End If

                    lc.ConError = ExisteError
                    lc.IB_MONTO = ExisteError
                    lc.CORREGIDO = Not ExisteError
                    lc.VERIFICADO = Not ExisteError

                End If


            End If
        Next

        '14/10/11
        'A pedido de Andrea, se agrega una verificacion adicional
        'Para la correccion de cuentas
        For i = 0 To LecturaView.RowCount - 1

            ExisteError = True
            lc = CType(LecturaView.GetRow(i), Lecturas)

            If lc.ExisteCHITCI = False Then


                If lc.EsCabecera And lc.PAQUETE = nudPaquete.Value Then

                    For Each s As CHITCI In CHITCIBindingSource.List

                        If s.IdLectura Is Nothing Then
                            If lc.numero_cheque = s.Comprobante _
                            And lc.cod_sucursal = CInt(s.Agencia) And lc.monto = s.Importe Then

                                If chkCorregirCHITCI.Checked And lc.cuenta_cheque <> s.CtaDeposito Then
                                    'Corregimos la cuenta del Deposito si esta marcado para hacerlo
                                    lc.cuenta_cheque = s.CtaDeposito

                                    lc.cajero = s.Usuario


                                    ExisteError = False
                                    s.IdLectura = lc.IdLectura
                                    lc.VERIFICADO = True
                                    Exit For
                                End If


                            End If
                        End If
                    Next




                    If ExisteError Then
                        lc.AgregarError(15, "No se encuentra en el CHITCI.")
                        lc.AddError("numero_cheque", "No se encuentra en el CHITCI.")
                    Else

                    End If

                    lc.ConError = ExisteError
                    lc.IB_MONTO = ExisteError
                    lc.CORREGIDO = Not ExisteError
                    lc.VERIFICADO = Not ExisteError

                End If


            End If
        Next



        'Analizamos el CHITCI para detectar registros que no se hayan leido
        Dim cdet As CHITCI
        'Dim listaLectura As FilteredBindingList(Of Lecturas)
        Dim listaLectura As List(Of Lecturas)
        listaLectura = LecturasBindingSource.List
        'listaLectura = Me.LecturasDataGridView.Rows
        ' Dim ExisteCREC As Boolean

        'Dim RowCounts As Integer = Me.GridView2.RowCount


        For i = 0 To Me.gridCHITCI.RowCount - 1
            cdet = CType(Me.gridCHITCI.GetRow(i), CHITCI)

            ExisteError = True

            'ExisteCREC = (Aggregate word In listaLectura _
            '    Into Any(word.numero_cheque = cdet.Comprobante And word.PAQUETE = nudPaquete.Value))

            If cdet.IdLectura Is Nothing Then
                ExisteError = True
            Else
                ExisteError = False
            End If

            'For Each l As Lecturas In listaLectura
            '    If l.numero_cheque = cdet.Comprobante And l.cuenta_cheque = cdet.CtaDeposito _
            '        And l.cod_sucursal = cdet.Agencia And l.monto = cdet.Importe Then
            '        ExisteError = False
            '        Exit For

            '    Else

            '        If l.cuenta_cheque = cdet.CtaDeposito _
            '        And l.cod_sucursal = cdet.Agencia And l.monto = cdet.Importe Then
            '            ExisteError = False
            '            Exit For

            '        End If
            '    End If
            'Next

            If ExisteError Then
                ExisteError = dm.App_BuscarCHITCI(cdet.CtaDeposito, cdet.Agencia, cdet.Comprobante, cdet.Importe, codBanco, Moneda.CodMoneda, Fecha).ToList.Count = 0
                If Not ExisteError Then
                    cdet.EstadoProceso = "P"
                End If
            End If

            Me.gridCHITCI.SetRowCellValue(i, "Existe", Not ExisteError)




        Next

        listaLectura = Nothing
        grabar()

    End Sub

    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        ProcesarCHERFI()
    End Sub
    Sub ProcesarCHERFI()
        Dim ExisteError As Boolean = False
        'If listaCREC.Count = 0 Then
        '    listaCREC = (dm.CREC.Include("CRECDet").Where(Function(p) p.Fecha = Fecha And p.CodBanco = codBanco)).ToList()
        'End If

        If CHERFIIBindingSource.Count = 0 Then

            MsgBox("Debe cargar primeramente el archivo CHERFII para realizar este proceso.")
            Return

        End If

       
        'Analizamos el CREC para detectar registros que no se hayan leido
        Dim cdet As CHERFII
        Dim lc As Lecturas
        '  For Each item As DataGridViewRow In Me.LecturasDataGridView.Rows

        'TODO : Mostrar errores de CREC
        For x = 0 To Me.gridCHERFII.RowCount - 1
            cdet = CType(Me.gridCHERFII.GetRow(x), CHERFII)

            For i = 0 To LecturaView.RowCount - 1

                ExisteError = False
                lc = CType(LecturaView.GetRow(i), Lecturas)

                If Not lc.EsCabecera Then
                    If lc.cuenta_cheque = cdet.CtaLibradora And lc.numero_cheque = cdet.NroCheque Then
                        'lc.IdMotivo = My.Application.Constantes.CodigoCHERFII
                        LecturaView.SetRowCellValue(i, "IdMotivo", My.Application.Constantes.CodigoCHERFII)

                        lc.LecturasRechazos.Add(New LecturasRechazo With {.IdMotivo = My.Application.Constantes.CodigoCHERFII, .IdBanco = lc.cod_banco, .Audit_Fecha = Date.Now, .Audit_Usuario = My.User.Name})
                    End If
                End If
            Next
        Next




        '      Me.LecturasDataGridView.Update()
        grabar()
        MessageBox.Show("Proceso Finalizado.")

    End Sub

    Private Sub ToolStripButton4_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        Me.LecturaView.OptionsView.ShowGroupPanel = ToolStripButton4.Checked
    End Sub



    Sub MarcarDetalle(IdMaquina As Integer, IdLote As Integer, NroError As Integer, Campo As String)
        Dim i As Integer

        For i = 0 To dxe.Count - 1
            If dxe(i).cod_maquina = IdMaquina And dxe(i).nro_lote = IdLote Then
                dxe(i).AgregarError(Campo, NroError)
            End If
        Next

    End Sub

    'Private Function td() As Object
    '    Throw New NotImplementedException
    'End Function


    Private Sub tsbCierre_Click(sender As System.Object, e As System.EventArgs) Handles tsbCierre.Click
        Dim ini As DateTime = Date.Now

        Me.chkLotesConError.Checked = True

        '21-01-2013
        'Quitamos la marca de filtro con error, porque puede cerrar con errores
        Me.chkFiltraError.Checked = False


        CargarDatos(True)

        Me.ProcesarLectura()

        Dim cCabecera As String
        Dim cDetalle As String
        Dim tCabecera As String
        Dim tDetalle As String
        Dim lDif As String

        cCabecera = Me.lblCAB.Text
        cDetalle = Me.lblCHQ.Text
        tCabecera = Me.lblCABCant.Text
        tDetalle = Me.lblCHQCant.Text
        lDif = Me.lblDIF.Text

        validar(True)

        'MsgBox(Date.Now.Subtract(ini).TotalSeconds.ToString)
        Dim Errores As Integer = CInt(Me.txtErrores.Text)
        If Errores > 0 Then

            My.MyApplication.AbrirProceso(codBanco, Fecha, Moneda.CodMoneda, Oper, Me.nudPaquete.Value)
            MsgBox("No se pudo completar el proceso de cierre. Verifique los errores y vuelva a intentar", MsgBoxStyle.Exclamation)
        Else

            My.MyApplication.CerrarProceso(codBanco, Fecha, Moneda.CodMoneda, Oper, Me.nudPaquete.Value)

            MsgBox("El proceso de cierre se ha realizado correctamente", MsgBoxStyle.Information)
            Me.lblCAB.Text = cCabecera
            Me.lblCHQ.Text = cDetalle
            Me.lblCABCant.Text = tCabecera
            Me.lblCHQCant.Text = tDetalle
            Me.lblDIF.Text = lDif
        End If


    End Sub


    Private Sub chkCD_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCD.CheckedChanged
        If chkCD.Checked Then
            If MsgBox("Esta seguro que desea cambiar a Compensación Directa?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                chkCD.Checked = False
            End If
        End If

    End Sub


End Class


