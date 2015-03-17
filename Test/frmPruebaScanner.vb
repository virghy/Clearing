Imports MICR
Imports MICR.CanonAPIbase
Imports DataAccess
Imports System.IO
Public Class frmPruebaScanner
    Dim MICR As MICR.CanonAPIbase
    Dim ConfigFilePath As String
    Dim Moneda As MICR.Moneda
    Dim configMICR As ConfigMICR
    Dim FilePath As String
    Dim file As CEIIMAGEFILEINFO
    Dim WithEvents frmProgreso As New ProgresoScaneo
    Dim dm As Entities
    Dim ImagenPath As String

    Function IniciarLectura() As String
        If MICR Is Nothing Then
            MICR = New MICR.CanonCR180
        End If

        Dim progressChunk As Integer = 0

        Dim ErrorLectura As Integer

     
        Dim result As Integer
        Dim Pagina As Integer = 0
        Dim data As String
        Dim mG As MICRGeneral = Nothing
        Dim NombreImagen As String
        Dim NroImagen As String = ""
        Dim proceso As Integer = 1



        result = MICR.CsdProbe()

        If result <> 0 Then
            'Dim Stop1 = MICR.CsdStopScan()
            'Stop1 = MICR.CsdTerminate()
            'result = MICR.CsdProbe()
            Me.MostrarError(result)
        End If

        Dim img As MICR.CanonAPIbase.CEIIMAGEINFO
        img.cbSize = Len(img)

        If result = 0 Then
            result = MICR.CsdParSet(CanonAPIbase.CSDP_LOAD_CONFIG_FILE, ConfigFilePath)
            If result <> 0 Then
                Me.MostrarError(result)
                Return Nothing
            End If
        End If

        If result = 0 Then
            result = MICR.CsdStartScan(Nothing, Nothing, Nothing)
            If result <> 0 Then
                Me.MostrarError(result)
                Return Nothing
            End If

        End If

        If result = 0 Then
            result = MICR.CsdReadPage(img)
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

                NroImagen = proceso.ToString.TrimEnd + "171" + Path.GetFileNameWithoutExtension(Path.GetRandomFileName())

                NombreImagen = "GF" + NroImagen + ".jpg"
            Else
                NombreImagen = "GR" + NroImagen + ".jpg"
            End If

            result = MICR.CsdSaveImageEx(img, file, Path.Combine(FilePath, NombreImagen))
            If result <> 0 Then
                Me.MostrarError(result)
                Exit While
            End If
            'Me.GrabarImagen(Pagina, img)
            result = MICR.CsdReleaseImage(img)
            If result <> 0 Then
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

            'Movemos aca la verificacion 
            If result = 0 Then
                result = MICR.CsdReadPage(img)
            Else
                Me.MostrarError(result)
                ErrorLectura = result
                Exit While
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

        Return ErrorLectura

        '   End If
    End Function

    Sub Grabar(mc As MICRGeneral, Pagina As Integer)
        Worker.ReportProgress(Pagina, mc)
    End Sub

    Private Sub MostrarError(ByVal NroError As Integer)

        frmProgreso.Hide()

        Select Case NroError
            Case 2
                MsgBox("No se ha hallado el Scanner. Compruebe el cable.", MsgBoxStyle.Critical)
            Case 6
                ''No mostrar error cuando no hay mas cheques que leer
            Case 7
                MsgBox("Papel atascado en el scanner, extraiga el papel y continue.", MsgBoxStyle.Critical)
            Case 18
                MsgBox("Error desconocido al acceder al Scanner.", MsgBoxStyle.Critical)
            Case Else
                MsgBox("Error no controlado al acceder al Scanner. Error: " + NroError.ToString, MsgBoxStyle.Critical)
        End Select
        frmProgreso.Show()
        MICR.CsdAbortScan()
        MICR.CsdTerminate()
    End Sub

    Private Function LeerMICR() As String
        Dim result As Int32
        Dim MicrLength As Long
        result = MICR.CsdParGet(CSDP_MICRDATALEN, MicrLength)
        Dim MicrData As String
        MicrData = Space(MicrLength)

        result = MICR.CsdParGet(CSDP_MICRDATA, MicrData)

        Return MicrData
    End Function

    Sub ConfigScanner()
        ConfigFilePath = Path.Combine(My.Application.Info.DirectoryPath, CanonAPIbase.CONFIG_FILE)

        Dim NroOper As String = "1"
      

        Dim NewConfigFile As String = Path.Combine(My.Application.Info.DirectoryPath, String.Concat("Canon", NroOper, ".ini"))

        Dim fi1 As New FileInfo(NewConfigFile)
        If fi1.Exists Then
            ConfigFilePath = NewConfigFile
        End If

    End Sub


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmPruebaScanner_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Moneda = New Moneda("PYG", 0)
        dm = New Entities
        Me.configMICR = dm.ConfigMICR.FirstOrDefault(Function(p) p.IdBanco = "17" And p.IdProceso = 1)
        Me.ConfigScanner()

    End Sub

    Private Sub Worker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Worker.DoWork
        Me.IniciarLectura()
    End Sub

    Private Sub Worker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles Worker.ProgressChanged
        Dim m As MICRGeneral
        m = CType(e.UserState, MICRGeneral)
        Me.TextBox1.Text += m.Cadena + vbCrLf
        frmProgreso.Label1.Text = String.Format("Escaneando {0}", (e.ProgressPercentage / 2).ToString("N0"))
        frmProgreso.Refresh()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ConfigCarpetaImagen()
        SetearImagen()
        frmProgreso.Show()
        Worker.RunWorkerAsync()
    End Sub

    Private Sub Worker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Worker.RunWorkerCompleted
        frmProgreso.Hide()
        If e.Error IsNot Nothing Then
            MsgBox(e.Error.Message)
        Else
            ''   MsgBox("Proceso Finalizado")
        End If
    End Sub

    Function ConfigCarpetaImagen() As Boolean

        FilePath = "c:\Sistemas\Clearing\Images"
        If Not FilePath.StartsWith("\\") Then
            If FilePath.Substring(1, 1) <> ":" Then
                FilePath = Path.Combine(My.Application.Info.DirectoryPath, FilePath)
            End If

        End If

        ' MsgBox(FilePath)

        ImagenPath = Path.Combine(Date.Today.ToString("yyyyMMdd"), 1)

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

    Sub SetearImagen()
        file.cbSize = Len(file)
        file.nFileType = CanonAPIbase.CSD_JPEG_FILE
        file.nCompType = CanonAPIbase.CSD_COMP_JPEG
        file.nJpegQuality = 70
    End Sub
End Class