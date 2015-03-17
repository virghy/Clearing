Imports MICR
Imports MICR.CanonAPIbase
Imports DataAccess
Imports System.Threading
Imports Microsoft.Practices.EnterpriseLibrary.Validation
Imports Microsoft.Practices.EnterpriseLibrary.Validation.Validators
Imports Microsoft.Data.Extensions
Imports Sorteable
Imports System.Text



'24-03-09 VG
'Grabar en ProcesarLectura, por si se haya modifica la secuencia

Public Class frmCierre
    Dim dm As New Entities


    Dim file As CEIIMAGEFILEINFO
    Dim FilePath As String = My.Application.Info.DirectoryPath '"c:\sistemas\ch"
    Dim ConfigFilePath As String = FilePath + "\CanonCrop.ini"
    '   Dim CabList As IQueryable(Of Lecturas)
    Dim dxe As New Sorteable.FilteredBindingList(Of Lecturas)(dm)
    '   Dim oCabecera As DataAccess.Cabeceras
    '  Dim oDet As DataAccess.Detalle_Cheques
    'Dim CabList As List(Of Cabeceras)
    'Dim DetList As List(Of Detalle_Cheques)
    Dim _NroLote As Integer
    Dim Fecha As Date = Date.Today
    Dim CodMaquina As Integer = My.MySettings.Default.Maquina
    Dim CodCamara As String = HostVB.My.MySettings.Default.Camara
    Dim codBanco As String = "05"
    Dim Oper As Operacion = HostVB.Operacion.Recibido
    'Dim validator As Validator(Of Lecturas) = ValidationFactory.CreateValidator(Of Lecturas)()
    'Dim results As ValidationResults
    'Dim Bancos As List(Of Bancos) = dm.Bancos.Where(Function(p) p.Activo = True).ToList
    'Dim TipoDoc As List(Of Tipo_Documentos) = dm.Tipo_Documentos.ToList
    Dim Sucursales As List(Of Sucursales)
    Dim Moneda As MICR.Moneda
    Dim configMICR As ConfigMICR


    Sub New(ByVal Camara As String, ByVal Maquina As String, ByVal Operacion As Operacion)
        Me.New()
        codBanco = My.MySettings.Default.IdEmpresa
        CodCamara = Camara
        Oper = Operacion

        Dim IdProceso As Integer = Oper
        Me.configMICR = dm.ConfigMICR.FirstOrDefault(Function(p) p.IdBanco = codBanco And p.IdProceso = IdProceso)
        Me.Sucursales = dm.Sucursales.Where(Function(p) p.cod_banco = codBanco).ToList()
    End Sub


    Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        SetearImagen()
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

    'Sub AsignarLote()
    '    Try

    '        'Dim MaxNroLote As Integer = (Aggregate c In dm.Lecturas _
    '        '           Where c.fecha_lectura = Fecha And c.cod_maquina = CodMaquina And c.cod_proceso = Operacion Into Max(c.nro_lote))
    '        Using dm.Connection.CreateConnectionScope
    '            NroLote = dm.CreateStoreCommand("Select Max(Nro_Lote) from lecturas where fecha_lectura = @Fecha and cod_maquina = @CodMaquina " _
    '                                                             + " and cod_proceso = @Proceso and Cod_Moneda=@Moneda", _
    '                                                              New SqlClient.SqlParameter("Fecha", Fecha), _
    '                                                               New SqlClient.SqlParameter("CodMaquina", CodMaquina), _
    '                                                               New SqlClient.SqlParameter("Proceso", Oper), _
    '                                                               New SqlClient.SqlParameter("Moneda", Moneda.CodMoneda)).ExecuteScalar
    '            Me.nudLote.Value = NroLote
    '        End Using

    '    Catch ex As Exception

    '    End Try
    'End Sub

    Sub iniciarLecturaPrueba()
        Dim data As String
        Dim mG As MICRGeneral = Nothing
        'data = "C1100E000001731904E06184058A050100000001283027B"    'Cheques
        'data = "C4190E000000979665E00000042A00000010000000B"       'Cabecera con Nro de Boleta
        data = "C0590E000003181008E00000007945326B"                 'Cabecera sin Nro de boleta
        'If data.Length > 0 Then
        mG = New MICRGeneral(data, Moneda, configMICR)
    End Sub

    'Sub IniciarLectura()

    '    If Me.LecturasDataGridView.InvokeRequired Then

    '        Dim newDelegate As New UIDelegate(AddressOf IniciarLectura)
    '        Me.LecturasDataGridView.Invoke(newDelegate)
    '    Else

    '        Dim frmProgreso As New ProgresoScaneo
    '        frmProgreso.Show()

    '        Dim result As Integer
    '        Dim Pagina As Integer = 0
    '        Dim data As String
    '        Dim mG As MICRGeneral = Nothing
    '        Dim NombreImagen As String
    '        Dim NroImagen As Integer
    '        result = MICR.CanonAPI.CsdProbe()

    '        Me.MostrarError(result)

    '        Dim img As MICR.CanonAPI.CEIIMAGEINFO
    '        img.cbSize = Len(img)

    '        If result = 0 Then
    '            result = MICR.CanonAPI.CsdParSet(MICR.CanonAPI.CSDP_LOAD_CONFIG_FILE, ConfigFilePath)
    '            Me.MostrarError(result)
    '        End If
    '        If result = 0 Then

    '            result = MICR.CanonAPI.CsdParSet(MICR.CanonAPI.CSDP_AUTOSIZE, 1)
    '            Me.MostrarError(result)
    '        End If

    '        If result = 0 Then

    '            result = MICR.CanonAPI.SetCSDP_MODE(CSDP_MODEAttribute.CSD_GRAYSCALE)
    '            Me.MostrarError(result)
    '        End If

    '        If result = 0 Then
    '            result = MICR.CanonAPI.CsdStartScan(Nothing, Nothing, Nothing)
    '            Me.MostrarError(result)
    '        End If

    '        If result = 0 Then
    '            result = MICR.CanonAPI.CsdReadPage(img)
    '        End If

    '        While result = CSD_OK
    '            Pagina = Pagina + 1
    '            frmProgreso.Label1.Text = String.Format("Escaneando {0}", (Pagina / 2).ToString("N0"))
    '            frmProgreso.Refresh()

    '            'Lee la imagen

    '            'Lee los datos solo para los valores impares
    '            If System.Decimal.Remainder(Pagina, 2) <> 0 Then
    '                data = Me.LeerMICR()
    '                'data = "C1100E000001731904E06184058A050100000001283027B"
    '                'If data.Length > 0 Then
    '                mG = New MICRGeneral(data, Moneda, configMICR)
    '                'End If
    '                NroImagen = Util.NEWID(dm, "NROIMAGEN")
    '                NombreImagen = "GF" + NroImagen.ToString + ".jpg"
    '            Else
    '                NombreImagen = "GR" + NroImagen.ToString + ".jpg"
    '            End If
    '            result = CsdSaveImageEx(img, file, IO.Path.Combine(FilePath + "\Images", NombreImagen))
    '            'Me.GrabarImagen(Pagina, img)

    '            If Not mG Is Nothing Then
    '                mG.AsignarImagen(NombreImagen)
    '                If mG.Tipo = TipoMICR.Cabecera Then
    '                    Worker.ReportProgress(Pagina)
    '                End If

    '            End If

    '            If System.Decimal.Remainder(Pagina, 2) = 0 Then
    '                Me.Grabar(mG)
    '            End If

    '            If result = 0 Then
    '                result = MICR.CanonAPI.CsdReadPage(img)
    '            Else
    '                Me.MostrarError(result)
    '            End If

    '            '   result = MICR.CanonAPI.CsdStartScan(Nothing, Nothing, Nothing)
    '        End While

    '        'result = MICR.CanonAPI.CsdParSet(MICR.CanonAPI.CSDP_DISPLAY_VIEW_FRONT, MICR.CanonAPI.VarPtr(img))




    '        If result = MICR.CanonAPI.CSD_OK Then
    '            result = MICR.CanonAPI.CsdReleaseImage(img)
    '        Else
    '            Me.MostrarError(result)
    '        End If
    '        result = MICR.CanonAPI.CsdTerminate()
    '        frmProgreso.Hide()
    '        frmProgreso.Dispose()
    '    End If
    'End Sub


    'Sub grabar(ByVal mg As MICRGeneral)
    '    Try


    '        Dim lectura As New Lecturas

    '        'Los datos comunes
    '        lectura.fecha_lectura = Fecha
    '        lectura.cod_maquina = CodMaquina
    '        lectura.audit_fecha = Date.Now
    '        lectura.cod_banco = codBanco
    '        lectura.cod_moneda = Moneda.CodMoneda
    '        lectura.cod_sucursal = Me.cboSucursal.SelectedValue
    '        lectura.cajero = Me.cboCajero.SelectedValue

    '        lectura.CORREGIDO = True
    '        lectura.cod_proceso = Oper
    '        'lectura.audit_usuario = My.User.Name

    '        If mg.Tipo = TipoMICR.Cabecera Then
    '            NroLote += 1
    '            ' lectura.cabecera = NroLote
    '            'Me.nudLote.Value += 1
    '            lectura.nro_lote = NroLote
    '            lectura.cod_banco_receptor = mg.Cabecera.Banco
    '            lectura.cod_camara = CodCamara
    '            lectura.numero_cheque = mg.Cabecera.Cheque

    '            If Oper = Operacion.Recibido Then
    '                lectura.cod_banco_emisor = codBanco
    '            Else
    '                lectura.cod_banco_emisor = mg.Cabecera.Banco
    '            End If

    '            lectura.cod_tipdoc = mg.Cabecera.Cpbt
    '            lectura.cuenta_cheque = mg.Cabecera.Cuenta
    '            lectura.cadena_captura = mg.Cabecera.Cadena
    '            lectura.monto = mg.Cabecera.Importe
    '            lectura.imagen_frontal = mg.Cabecera.Imagen

    '            ' Me.LecturasDataGridView.Refresh()

    '            'CabList.Add(oCabecera)
    '            'dm.AddToCabeceras(oCabecera)

    '            'Me.LecturasDataGridView.Rows.Add()

    '            'CType(Me.CabeceraBindingSource.DataSource, List(Of Cabeceras)).Add(oCabecera)
    '            '  Me.CabecerasDataGridView.Refresh()

    '        Else
    '            lectura.cabecera = Me.nudLote.Value
    '            lectura.nro_lote = Me.nudLote.Value

    '            lectura.cod_banco_receptor = mg.Detalle.BancoE
    '            lectura.cod_banco_emisor = mg.Detalle.BancoR
    '            lectura.cod_camara = mg.Detalle.Camara

    '            'If Oper = Operacion.Recibido Then
    '            '    lectura.cod_banco_receptor = mg.Detalle.BancoE
    '            '    lectura.cod_banco_emisor = mg.Detalle.BancoR
    '            'End If

    '            'If Oper = Operacion.Enviado Then
    '            '    lectura.cod_banco_receptor = mg.Detalle.BancoE
    '            '    lectura.cod_banco_emisor = mg.Detalle.BancoR
    '            'End If




    '            lectura.cod_tipdoc = mg.Detalle.Cpbt
    '            lectura.cuenta_cheque = mg.Detalle.Cuenta
    '            lectura.numero_cheque = mg.Detalle.Cheque
    '            lectura.monto = mg.Detalle.Importe
    '            lectura.imagen_frontal = mg.Detalle.Imagen
    '            lectura.imagen_reverso = mg.Detalle.Imagen1
    '            lectura.cadena_captura = mg.Detalle.CadenaDet
    '            'dm.AddToDetalle_Cheques(oDet)
    '            'oCabecera.Detalle_Cheques.Add(oDet)
    '            'DetList.Add(oDet)
    '            ' Me.Detalle_ChequesDataGridView.Refresh()

    '        End If
    '        If lectura.cadena_captura.IndexOf("@") >= 0 Then
    '            lectura.CORREGIDO = False
    '        End If

    '        Me.LecturasBindingSource.Add(lectura)

    '    Catch ex As Exception
    '        If Not ex.InnerException Is Nothing Then
    '            MsgBox(ex.InnerException.Message)
    '        Else
    '            MsgBox(ex.Message)
    '        End If

    '    End Try
    'End Sub

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
        file.nFileType = MICR.CanonAPIbase.CSD_JPEG_FILE
        file.nCompType = MICR.CanonAPIbase.CSD_COMP_JPEG
        file.nJpegQuality = 70
    End Sub



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




    Sub ProcesarLectura()
        Dim cCabecera As Integer = 0
        Dim cDetalle As Integer = 0
        Dim tCabecera As Double = 0
        Dim tDetalle As Double = 0

        'LecturasBindingSource.Sort = "nro_lote ASC, cod_tipDoc DESC"
        ' LecturasBindingSource.ResetBindings(False)

        Dim lec As List(Of Lecturas) = (From s As Lecturas In Me.LecturasBindingSource _
                                       Order By s.nro_lote, s.cod_tipdoc Descending _
                                       Select s).ToList






        Dim secuencia As Integer = 1
        For Each det As Lecturas In lec
            'Verificamos si hubo cambios en la secuencia
            'det.cabecera = secuencia
            If det.cabecera Is Nothing OrElse det.cabecera <> secuencia Then
                det.cabecera = secuencia
            End If


            secuencia += 1
            'If det.cod_tipdoc <> "00" And det.cod_tipdoc <> "02" Then
            If det.cod_tipdoc <> "00" And det.cod_tipdoc <> "01" And det.cod_tipdoc <> "02" Then
                cCabecera += 1
                tCabecera += det.monto
            Else
                cDetalle += 1
                tDetalle += det.monto
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



    End Sub




    Private Sub Worker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Worker.DoWork
        '  Me.IniciarLectura()
        dm.SaveChanges()


        'Me.CargarDatos()
    End Sub
    Delegate Sub UIDelegate()

    Sub CargarDatos()
        'CabList = From c In dm.Lecturas Select c _
        '            Where c.fecha_lectura = Fecha And c.cod_maquina = CodMaquina Order By c.nro_lote, c.cabecera
        '  dm.AcceptAllChanges()
        dxe.Clear()
        Dim proceso As Integer = Oper
        Dim Paquete As Integer = Me.nudPaquete.Value

        dxe.Load(From c In dm.Lecturas _
                 Where c.cod_moneda = Moneda.CodMoneda And c.cod_banco = Me.codBanco And c.fecha_lectura = Fecha And c.cod_proceso = proceso And c.PAQUETE = Paquete _
                    Select c _
                    Order By c.cod_maquina, c.nro_lote, c.cod_tipdoc Descending, c.cabecera)
        Me.LecturasBindingSource.DataSource = dxe
    End Sub

    Private Sub Worker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles Worker.ProgressChanged
        ' CargarDatos()
        ' Me.CabecerasDataGridView.Rows.Add()
    End Sub


    Private Sub Worker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Worker.RunWorkerCompleted
        CargarDatos()


        'Me.CabecerasDataGridView.Refresh()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  Try
        ' Worker.RunWorkerAsync()




        'Para Probar la cadena sin tener el scanner
        '  Me.iniciarLecturaPrueba()
        ' Return

        '   Me.IniciarLectura()

        ProcesarLectura()
        Me.Grabar()
        'Dim newThread As New Thread(AddressOf IniciarLectura)
        'newThread.Start()

        'Catch ex As Exception

        ' End Try
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        Dim frm As New FrmEditarDetalle(Me.LecturasBindingSource.Current)
        '    frm.LecturasBindingSource.DataSource = Me.CabList
        '   frm.LecturasBindingSource.Position = Me.LecturasBindingSource.Position
        Me.LecturasDataGridView.BeginEdit(False)
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            frm.LecturasBindingSource.EndEdit()
            Me.LecturasBindingSource.EndEdit()
            Me.Grabar()
            Me.ProcesarLectura()
        Else
            frm.LecturasBindingSource.CancelEdit()
            Me.LecturasBindingSource.CancelEdit()
        End If

        'Me.validar(Me.LecturasDataGridView.CurrentRow)

    End Sub




    Sub Grabar()
        Try

            Me.ProcesarLectura()
            dxe.SaveChanges("Lecturas")
            My.MyApplication.AbrirProceso(codBanco, Fecha, Moneda.CodMoneda, Oper, Me.nudPaquete.Value)
            Me.validar()
            '   dm.SaveChanges()
        Catch ex As Exception
            MsgBox(Util.EnumErrors(ex))
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmRecibido_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub LecturasDataGridView_BindingContextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LecturasDataGridView.BindingContextChanged
        ' Continue only if the data source has been set.
        If Me.LecturasDataGridView.DataSource Is Nothing Then
            Return
        End If

        ' Add the AutoFilter header cell to each column.
        For Each col As DataGridViewColumn In Me.LecturasDataGridView.Columns
            'col.HeaderCell = New DataGridViewAutoFilterColumnHeaderCell(col.HeaderCell)

        Next

        ' Resize the columns to fit their contents.
        LecturasDataGridView.AutoResizeColumns()
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

    Private Sub LecturasDataGridView_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs)
        '    String filterStatus = DataGridViewAutoFilterColumnHeaderCell
        '        .GetFilterStatus(dataGridView1);
        'If (String.IsNullOrEmpty(filterStatus)) Then
        '    {
        '        showAllLabel.Visible = false;
        '        filterStatusLabel.Visible = false;
        '    }
        'Else
        '    {
        '        showAllLabel.Visible = true;
        '        filterStatusLabel.Visible = true;
        '        filterStatusLabel.Text = filterStatus;
        '    }



    End Sub


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

    Private Sub LecturasDataGridView_UserDeletedRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles LecturasDataGridView.UserDeletedRow
        Me.Grabar()
        Me.ProcesarLectura()
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        validar()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.CargarDatos()
        Me.ProcesarLectura()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.dxe.Clear()
        Me.ProcesarLectura()
    End Sub

    Private Sub LecturasDataGridView_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles LecturasDataGridView.UserDeletingRow

        If MsgBox("Esta seguro que desea eliminar este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
        End If

    End Sub

    Private Sub frmRecibido_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.LecturasBindingSource.DataSource = dxe
        '   Me.cboBuscar.SelectedIndex = 0
        Me.Moneda = New Moneda(My.Application.Moneda.cod_moneda, My.Application.Moneda.decimales)
        PonerTitulos()
        '  Me.AsignarLote()

        Dim ts As New Label
        ts.Text = "Importe"
        ts.Visible = True
        ts.Dock = DockStyle.Bottom
        '   Me.LecturasDataGridView.Controls.Add(ts)
        My.Application.Banco.Sucursales.Load()
        Me.SucursalesBindingSource.DataSource = My.Application.Banco.Sucursales.OrderBy(Function(p) p.nombre_sucusal)

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

    Private Sub txtBuscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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
        End Select
        Dim obj As List(Of Bancos) = (From bc In dm.Bancos Where bc.cod_banco = codBanco Select bc).ToList
        Me.Text = titulo + obj(0).nombre_banco
        Me.Importe.DefaultCellStyle.Format = "N" + Moneda.Decimales.ToString

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
        If Not chkFiltraError.CheckState = CheckState.Checked Then
            'Me.LecturasBindingSource.DataSource = dxe
            Me.LecturasBindingSource.Filter = ""
        Else
            'validar()
            Me.LecturasBindingSource.Filter = "CORREGIDO = FALSE"
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
        Try
            Dim st As New StringBuilder
            Dim Ini As DateTime = Date.Now
            ' st.Append(Ini.ToShortTimeString)
            Me.Panel1.Visible = True

            Me.CargarDatos()

            'st.AppendLine()
            st.AppendFormat("Carga Datos {0}", Date.Now.Subtract(Ini).TotalSeconds.ToString)
            Ini = Date.Now

            Me.ProgressBar1.Value = 0
            Me.ProgressBar1.Maximum = Me.dxe.Count
            Me.ProcesarLectura()

            st.AppendLine()
            st.AppendFormat("Procesar Lectura {0}", Date.Now.Subtract(Ini).TotalSeconds.ToString)
            Ini = Date.Now



            st.AppendLine()

            st.AppendFormat("{0}", validar())
            MsgBox(st.ToString)
        Catch ex As Exception
            MsgBox(Util.EnumErrors(ex))
        End Try

    End Sub

    Private Function validar() As String
        Dim ini As DateTime = Date.Now
        Dim st As New StringBuilder
        Dim Errores As Integer = Validador.ValidarLectura(Me.LecturasDataGridView, Me.Oper, Me.Fecha, Me.dxe.OriginalList, Me.codBanco, Me.Moneda.CodMoneda, Me.Sucursales)
        st.AppendFormat("Validar {0}", Date.Now.Subtract(ini).TotalSeconds.ToString)
        ini = Date.Now
        st.AppendLine()
        '   Me.txtErrores.Text = Errores.ToString("N0")
        Errores += validarRepetidos()
        st.AppendFormat("Validar Repetido {0}", Date.Now.Subtract(ini).TotalSeconds.ToString)
        ini = Date.Now
        Me.LecturasDataGridView.Update()
        st.AppendLine()
        st.AppendFormat("Update Grilla {0}", Date.Now.Subtract(ini).TotalSeconds.ToString)
        ini = Date.Now

        dxe.SaveChanges("Lecturas")
        st.AppendLine()
        st.AppendFormat("Grabar {0}", Date.Now.Subtract(ini).TotalSeconds.ToString)


        If Errores > 0 Then
            My.MyApplication.AbrirProceso(codBanco, Fecha, Moneda.CodMoneda, Oper, Me.nudPaquete.Value)
            MsgBox("No se pudo completar el proceso de cierre. Verifique los errores y vuelva a intentar", MsgBoxStyle.Exclamation)
        Else
            My.MyApplication.CerrarProceso(codBanco, Fecha, Moneda.CodMoneda, Oper, Me.nudPaquete.Value)
            MsgBox("El proceso de cierre se ha realizado correctamente", MsgBoxStyle.Information)
        End If
        Return st.ToString

        ''limpiamos todos los errores primero
        'Dim lc As Lecturas
        'Dim proceso As Integer = Oper
        'Dim ExisteError As Boolean = False
        'Dim lcBancoCabecera As String = String.Empty

        'Dim td = From c In dxe _
        '                 Where Not c.EsCabecera _
        '         Group c By c.cod_maquina, c.nro_lote _
        '         Into Total = Sum(c.monto) _
        '         Select cod_maquina, nro_lote, Total

        'For Each item As DataGridViewRow In LecturasDataGridView.Rows
        '    item.ErrorText = ""
        '    item.Cells(5).ErrorText = ""

        '    item.Cells("tbcSerie").ErrorText = ""
        'Next

        'Me.ProgressBar1.Value = 0

        'For Each item As DataGridViewRow In LecturasDataGridView.Rows
        '    Me.ProgressBar1.Value += 1
        '    ExisteError = ExisteError Or Not validar(item)

        '    Dim r As DataGridViewRow = item
        '    lc = CType(item.DataBoundItem, Lecturas)

        '    If lc.numero_cheque = 0 And Not lc.EsCabecera Then
        '        r.Cells(6).ErrorText = "Nro de Cheque no valido."
        '        ExisteError = True
        '    End If

        '    'Validamos cada lote
        '    If lc.EsCabecera Then
        '        Dim Diferente = Aggregate word In td _
        '                        Where word.nro_lote = lc.nro_lote And word.cod_maquina = lc.cod_maquina _
        '      Into Any(word.Total <> lc.monto)

        '        Dim Suma = Aggregate word In td _
        '                        Where word.nro_lote = lc.nro_lote And word.cod_maquina = lc.cod_maquina _
        '      Into Sum(word.Total)

        '        'If Diferente Then
        '        If lc.monto <> Suma Then
        '            r.ErrorText = "Existe una diferencia con la suma del detalle."
        '            ' r.Cells(2).ErrorText = "Existe una diferencia con la suma del detalle"
        '            ExisteError = True
        '        End If

        '        lcBancoCabecera = lc.cod_banco_emisor

        '    Else
        '        If Oper = Operacion.Recibido AndAlso lcBancoCabecera <> lc.cod_banco_emisor Then
        '            r.Cells(6).ErrorText = "El banco no corresponde a la cabecera."
        '            ExisteError = True
        '        End If

        '        Dim ExisteCabecera = (Aggregate word In dxe _
        '    Into Any(word.nro_lote = lc.nro_lote And word.EsCabecera))

        '        If Not ExisteCabecera Then
        '            r.ErrorText = "El registro no tiene cabecera."
        '            ExisteError = True
        '        End If

        '    End If
        '    'Validamos los bancos
        '    Dim ExisteBanco = (Aggregate word In Bancos _
        '    Into Any(word.cod_banco = lc.cod_banco_receptor)) And _
        '    (Aggregate word In Bancos _
        '    Into Any(word.cod_banco = lc.cod_banco_emisor))

        '    If Not ExisteBanco Then
        '        r.ErrorText = "No existe el banco indicado."
        '        ExisteError = True
        '    End If

        '    'Validamos el Tipo de documento
        '    Dim ExisteDocumento = (Aggregate word In TipoDoc _
        '    Into Any(word.cod_tipdoc = lc.cod_tipdoc))

        '    If Not ExisteDocumento Then
        '        r.ErrorText = "No existe el tipo de documento indicado."
        '        ExisteError = True
        '    End If

        '    Dim listaRepetido As List(Of Lecturas) = (From l In dxe _
        '                     Where l.numero_cheque = lc.numero_cheque _
        '                     And l.cuenta_cheque = lc.cuenta_cheque _
        ' And l.cod_banco_receptor = lc.cod_banco_receptor _
        ' And Not lc.EsCabecera _
        ' And l.IdLectura <> lc.IdLectura _
        ' And l.cod_banco = Me.codBanco _
        ' And l.cod_moneda = Moneda.CodMoneda And l.fecha_lectura = Fecha And l.cod_proceso = proceso _
        ' Select l).ToList

        '    If listaRepetido.Count > 0 Then
        '        r.Cells("tbcSerie").ErrorText = String.Format("El cheque esta repetido en fecha {0}, Maquina {1} ", listaRepetido(0).fecha_lectura.Value.ToShortDateString, listaRepetido(0).cod_maquina)
        '        ExisteError = True
        '    End If


        'Next

        'If ExisteError Then
        '    My.MyApplication.AbrirProceso(codBanco, Fecha, Moneda.CodMoneda, Oper)
        '    MsgBox("No se pudo completar el proceso de cierre. Verifique los errores y vuelva a intentar", MsgBoxStyle.Exclamation)
        'Else
        '    My.MyApplication.CerrarProceso(codBanco, Fecha, Moneda.CodMoneda, Oper)
        '    MsgBox("El proceso de cierre se ha realizado correctamente", MsgBoxStyle.Information)
        'End If

        'dxe.SaveChanges("Lecturas")



    End Function

    'Function Validar(ByVal item As DataGridViewRow) As Boolean
    '    'Validar not null
    '    'VG 07/05/08 
    '    'Puede venir un item null, si es que se hace clic afuera de la grilla
    '    'cuando se esta editando
    '    If item Is Nothing Then
    '        Return True
    '    End If

    '    results = validator.Validate(item.DataBoundItem)
    '    ' item.ErrorText = ""
    '    If Not results.IsValid Then
    '        For Each result As ValidationResult In results
    '            item.ErrorText = item.ErrorText + "-" + result.Message
    '        Next
    '    End If
    '    Return results.IsValid

    'End Function

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub






    Private Sub LecturasBindingSource_BindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.BindingCompleteEventArgs) Handles LecturasBindingSource.BindingComplete
        If e.BindingCompleteContext = BindingCompleteContext.DataSourceUpdate _
     AndAlso e.Exception Is Nothing Then
            'e.Binding.BindingManagerBase.EndCurrentEdit()
        End If
    End Sub


    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        validarRepetidos()
    End Sub

    Private Function validarRepetidos() As Integer
        'limpiamos todos los errores primero
        ' Dim tic1 As DateTime = Date.Now
        Dim lc As Lecturas
        Dim proceso As Integer = Oper
        Dim repetidos As Integer = 0
        Dim UltimaEdicionIni As DateTime = My.MyApplication.ProcesoUltimaEdicion(Me.codBanco, Me.Fecha, Me.Moneda.CodMoneda, proceso)

        'Dim td = From c In dxe _
        '                 Where Not c.EsCabecera _
        '         Group c By c.nro_lote _
        '         Into Total = Sum(c.monto) _
        '         Select nro_lote, Total



        'For Each item As DataGridViewRow In LecturasDataGridView.Rows
        '    item.ErrorText = ""
        '    item.Cells("tbcSerie").ErrorText = ""
        'Next


        For Each item As DataGridViewRow In LecturasDataGridView.Rows
            '  Validar(item)
            Dim r As DataGridViewRow = item
            lc = CType(item.DataBoundItem, Lecturas)

            'Validamos cada lote
            If Not lc.EsCabecera Then
                ''Validamos los bancos
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

                'Validamos la cuenta tambien 30/07/2010 
                'A pedido de laura
                'Dim listaRepetido = dm.App_VerificaRepetido(lc.numero_cheque, lc.cod_banco_receptor _
                ', lc.cuenta_cheque _
                ', lc.IdLectura _
                ', Me.codBanco _
                ', Moneda.CodMoneda, Fecha, proceso).FirstOrDefault

                'Dim listaRepetido As Lecturas = (From l In dxe _
                '                    Where l.numero_cheque = lc.numero_cheque _
                'And l.cod_banco_receptor = lc.cod_banco_receptor _
                'And l.cuenta_cheque = lc.cuenta_cheque _
                'And Not lc.EsCabecera _
                'And l.IdLectura <> lc.IdLectura _
                'And l.cod_banco = Me.codBanco _
                'And l.cod_moneda = Moneda.CodMoneda And l.fecha_lectura = Fecha And l.cod_proceso = proceso _
                'Select l).FirstOrDefault

                For Each l As Lecturas In dxe

                    If l.numero_cheque = lc.numero_cheque _
                And l.cod_banco_receptor = lc.cod_banco_receptor _
                And l.cuenta_cheque = lc.cuenta_cheque _
                And Not lc.EsCabecera _
                And l.IdLectura <> lc.IdLectura _
                And l.cod_banco = Me.codBanco _
                And l.cod_moneda = Moneda.CodMoneda And l.fecha_lectura = Fecha And l.cod_proceso = proceso Then

                        r.Cells("tbcSerie").ErrorText = String.Format("El cheque esta repetido en fecha {0}, Maquina {1} ", l.fecha_lectura.Value.ToShortDateString, l.cod_maquina)
                        repetidos += 1
                        Exit For

                    End If

                Next


                'If listaRepetido IsNot Nothing Then
                '    r.Cells("tbcSerie").ErrorText = String.Format("El cheque esta repetido en fecha {0}, Maquina {1} ", listaRepetido.fecha_lectura.Value.ToShortDateString, listaRepetido.cod_maquina)
                '    repetidos += 1
                'End If

                'If repetido Then
                '    '                r.ErrorText = String.Format("El cheque esta repetido en la secuencia {0}", CType(item.DataBoundItem, Lecturas).cabecera)
                '    r.Cells("tbcSerie").ErrorText = "El cheque esta repetido en la secuencia "
                'End If
            End If


        Next

        'Dim tic2 As DateTime = Date.Now
        'Dim Diff As TimeSpan = tic2.Subtract(tic1)
        'MsgBox(Diff.TotalSeconds)

        Dim UltimaEdicionFin As DateTime = My.MyApplication.ProcesoUltimaEdicion(Me.codBanco, Me.Fecha, Me.Moneda.CodMoneda, proceso)

        If UltimaEdicionIni <> UltimaEdicionFin Then
            MsgBox("Los datos fueron modificados mientras se validaba. Favor validar nuevamente", MsgBoxStyle.Information)
            repetidos = IIf(repetidos > 0, repetidos, 1)
        End If

        Return repetidos

    End Function






    Private Sub MostrarError(ByVal NroError As Integer)
        Select Case NroError
            Case 2
                MsgBox("No se ha hallado el Scanner. Compruebe el cable.", MsgBoxStyle.Critical)
            Case 7
                MsgBox("Papel atascado en el scanner, extraiga el papel y continue.", MsgBoxStyle.Critical)
            Case 18
                MsgBox("Error desconocido al acceder al Scanner.", MsgBoxStyle.Critical)

        End Select

    End Sub

End Class
