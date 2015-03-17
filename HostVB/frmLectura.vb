Imports MICR
Imports MICR.CanonAPI
Imports DataAccess
Public Class frmLectura
    Dim dm As New Entities

    Dim file As CEIIMAGEFILEINFO
    Dim FilePath As String = "c:\sistemas\ch"
    Dim oCabecera As DataAccess.Cabeceras
    Dim oDet As DataAccess.Detalle_Cheques
    'Dim CabList As List(Of Cabeceras)
    'Dim DetList As List(Of Detalle_Cheques)
    Dim NroLote As Integer
    Dim Fecha As Date = Date.Today
    Dim CodMaquina As Integer = 1


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
        Try

            Dim MaxNroLote As Integer = (Aggregate c In dm.Cabeceras _
                       Where c.fecha_lectura = Fecha And c.cod_maquina = CodMaquina Into Max(c.nro_lote))
            NroLote = MaxNroLote

        Catch ex As Exception

        End Try
        Me.CargarDatos()
    End Sub


    Sub IniciarLectura()
        Dim frmProgreso As New ProgresoScaneo
        frmProgreso.Show()
        
        Dim result As Integer
        Dim Pagina As Integer = 0
        Dim data As String
        Dim mG As MICRGeneral = Nothing
        Dim NombreImagen As String
        MICR.CanonAPI.CsdProbe()

        Dim img As MICR.CanonAPI.CEIIMAGEINFO
        img.cbSize = Len(img)
        result = MICR.CanonAPI.CsdParSet(MICR.CanonAPI.CSDP_LOAD_CONFIG_FILE, "c:\sistemas\CanonCrop.ini")
        result = MICR.CanonAPI.CsdParSet(MICR.CanonAPI.CSDP_AUTOSIZE, 1)
        result = MICR.CanonAPI.SetCSDP_MODE(CSDP_MODEAttribute.CSD_GRAYSCALE)
        result = MICR.CanonAPI.CsdStartScan(Nothing, Nothing, Nothing)
        result = MICR.CanonAPI.CsdReadPage(img)

        While result = CSD_OK
            Pagina = Pagina + 1
            frmProgreso.Label1.Text = String.Format("Escaneando {0}", Pagina / 2)
            frmProgreso.Refresh()
            'Lee la imagen
            NombreImagen = Me.GrabarImagen(Pagina, img)
            'Lee los datos solo para los valores impares
            If System.Decimal.Remainder(Pagina, 2) <> 0 Then
                data = Me.LeerMICR()
                If data.Length > 0 Then
                    mG = New MICRGeneral(data)
                End If
            End If
            If Not mG Is Nothing Then
                mG.AsignarImagen(NombreImagen)
            End If
            If System.Decimal.Remainder(Pagina, 2) = 0 Then
                Me.grabar(mG)
            End If

            If mG.Tipo = TipoMICR.Cabecera Then
                Worker.ReportProgress(Pagina)
            End If

            result = MICR.CanonAPI.CsdReadPage(img)
            '   result = MICR.CanonAPI.CsdStartScan(Nothing, Nothing, Nothing)
        End While

        'result = MICR.CanonAPI.CsdParSet(MICR.CanonAPI.CSDP_DISPLAY_VIEW_FRONT, MICR.CanonAPI.VarPtr(img))




        If result = MICR.CanonAPI.CSD_OK Then
            result = MICR.CanonAPI.CsdReleaseImage(img)
        End If
        result = MICR.CanonAPI.CsdTerminate()
        frmProgreso.Hide()
        frmProgreso.Dispose()

    End Sub


    Sub grabar(ByVal mg As MICRGeneral)
        Try
            If mg.Tipo = TipoMICR.Cabecera Then

                NroLote += 1

                oCabecera = New DataAccess.Cabeceras

                oCabecera.fecha_lectura = Fecha
                oCabecera.cod_maquina = CodMaquina
                oCabecera.nro_lote = NroLote
                oCabecera.cod_banco_receptor = mg.Cabecera.Banco
                oCabecera.cod_tipdoc = mg.Cabecera.Cpbt
                oCabecera.cuenta_deposito = mg.Cabecera.Cuenta
                oCabecera.cadena_captura = mg.Cabecera.Cadena
                oCabecera.monto_total = mg.Cabecera.Importe
                oCabecera.imagen_frontal = mg.Cabecera.Imagen
                'CabList.Add(oCabecera)
                dm.AddToCabeceras(oCabecera)

                'CType(Me.CabeceraBindingSource.DataSource, List(Of Cabeceras)).Add(oCabecera)
                '  Me.CabecerasDataGridView.Refresh()

            Else
                If oCabecera Is Nothing Then
                    oCabecera = New DataAccess.Cabeceras
                    oCabecera.fecha_lectura = Fecha
                    oCabecera.cod_maquina = CodMaquina
                    oCabecera.nro_lote = NroLote
                    oCabecera.cod_tipdoc = "90"
                    'CabList.Add(oCabecera)

                    dm.AddToCabeceras(oCabecera)
                End If

                oDet = New DataAccess.Detalle_Cheques
                oDet.cod_banco_emisor = mg.Detalle.BancoE
                oDet.cod_banco_receptor = mg.Detalle.BancoR
                oDet.cod_tipdoc = mg.Detalle.Cpbt
                oDet.numero_cuenta_librador = mg.Detalle.Cuenta
                oDet.numero_cheque = mg.Detalle.Cheque
                oDet.monto_cheque = mg.Detalle.Importe
                oDet.imagen_frontal_ch = mg.Detalle.Imagen
                oDet.imagen_reverso_ch = mg.Detalle.Imagen1
                oDet.cadena_captura = mg.Detalle.CadenaDet
                'dm.AddToDetalle_Cheques(oDet)
                oCabecera.Detalle_Cheques.Add(oDet)
                'DetList.Add(oDet)
                ' Me.Detalle_ChequesDataGridView.Refresh()

            End If



        Catch ex As Exception
            If Not ex.InnerException Is Nothing Then
                MsgBox(ex.InnerException.Message)
            Else
                MsgBox(ex.Message)
            End If

        End Try
    End Sub
    Sub SetearImagen()
        file.cbSize = Len(file)
        file.nFileType = MICR.CanonAPI.CSD_JPEG_FILE
        file.nCompType = MICR.CanonAPI.CSD_COMP_JPEG
        file.nJpegQuality = 70
    End Sub

    Function GrabarImagen(ByVal pagina, ByVal img) As String
        ''Para grabar en disco la imagen
        Dim result As Int32

        Dim FileName As String

        FileName = FilePath + pagina.ToString.Trim + ".jpg"
        result = CsdSaveImageEx(img, file, FileName)
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

    Private Function LeerCabecera() As MICR.MICRCabecera
        Dim data As String = LeerMICR()
        Dim MC As MICRCabecera = Nothing
        If data.Length > 0 Then
            MC = New MICRCabecera(data)
        End If
        Return MC
    End Function
    Private Function LeerDetalle() As MICR.MICRCabecera
        Dim data As String = LeerMICR()
        Dim MC As MICRCabecera = Nothing
        If data.Length > 0 Then
            MC = New MICRCabecera(data)
        End If
        Return MC
    End Function


    Private Function LeerMICR() As String
        Dim result As Int32
        Dim MicrLength As Long
        result = CsdParGet(CSDP_MICRDATALEN, MicrLength)
        Dim MicrData As String
        MicrData = Space(MicrLength)

        result = CsdParGet(CSDP_MICRDATA, MicrData)
        
        Return MicrData
    End Function

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Worker.RunWorkerAsync()
    End Sub

    Private Sub Worker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Worker.DoWork
        Me.IniciarLectura()
        dm.SaveChanges()
        'Me.CargarDatos()
    End Sub

  

    Private Sub CabecerasDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CabecerasDataGridView.CellEnter
        ' CabecerasDataGridView_CellClick(sender, e)
    End Sub

    Private Sub CabecerasDataGridView_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CabecerasDataGridView.RowEnter
        Dim Cab = CType(Me.CabecerasDataGridView.Rows(e.RowIndex).DataBoundItem, DataAccess.Cabeceras)

        If Cab Is Nothing Then
            Return
        End If

        Cab.Detalle_Cheques.Load()

        Detalle_ChequesBindingSource.DataSource = Cab.Detalle_Cheques
        'Detalle_ChequesDataGridView.DataSource = Detalle_ChequesBindingSource
    End Sub

    Private Sub CabecerasDataGridView_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CabecerasDataGridView.RowLeave

    End Sub

    Sub CargarDatos()
        Dim CabList = From c In dm.Cabeceras Select c _
                    Where c.fecha_lectura = Fecha And c.cod_maquina = CodMaquina
        If CabList.Count > 0 Then
            CabList.First().Detalle_Cheques.Load()
            '            DetList = CabList(0).Detalle_Cheques.ToList
        End If
        Me.CabeceraBindingSource.DataSource = CabList
        Me.Detalle_ChequesBindingSource.DataSource = CabList.First().Detalle_Cheques
    End Sub

    Private Sub Worker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles Worker.ProgressChanged
        ' CargarDatos()
        ' Me.CabecerasDataGridView.Rows.Add()
    End Sub

    
    Private Sub Worker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Worker.RunWorkerCompleted
        CargarDatos()


        'Me.CabecerasDataGridView.Refresh()
    End Sub


End Class







