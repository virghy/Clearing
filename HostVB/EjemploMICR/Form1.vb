Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Runtime.InteropServices

Imports MICR.CanonAPIbase
<StandardModule(), ComVisible(True)> _
Public Class EjemploMICR
    Dim MICR As MICR.CanonAPIbase = New MICR.CanonCR180

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '        MICR.CanonAPI.CsdProbe()
        Dim hInstance As Long = System.Runtime.InteropServices.Marshal.GetHINSTANCE(System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0)).ToInt32()
        '   Dim MICR As MICR.CanonAPIbase = New MICR.CanonAPI

        Dim result As Integer

        ' result = MICR.CanonAPI.CsdTerminate()
        'IO.Directory.SetCurrentDirectory("C:\Program Files\Canon Electronics\CR180")
        result = MICR.CsdProbe()
        result = MICR.CsdParSet(CSDP_LOAD_CONFIG_FILE, CONFIG_FILE)

        If MICR.CsdDrvDialog(hInstance, Me.Handle.ToInt32, 0) = 0 Then
            result = MICR.CsdParSet(CSDP_SAVE_CONFIG_FILE, CONFIG_FILE)
        End If
        Dim img As MICR.CanonAPIbase.CEIIMAGEINFO
        img.cbSize = Len(img)
        Dim view As MICR.CanonAPIbase.VIEWOFIMAGE
        view.cbSize = Len(view)
        view.hwndFrontSideImage = Me.PictureBox1.Handle
        '  result = MICR.CanonAPI.CsdParSet(MICR.CanonAPI.CSDP_LOAD_CONFIG_FILE, "c:\sistemas\Canon.ini")


        ' result = MICR.CanonAPI.CsdParSet(MICR.CanonAPI.CSDP_LOAD_CONFIG_FILE, "c:\sistemas\Canon.ini")
        'result = MICR.CanonAPI.CsdParSet(MICR.CanonAPI.CSDP_START_VIEW, MICR.CanonAPI.VarPtr(view))
        'result = MICR.CanonAPI.CsdParSet(MICR.CanonAPI.CSDP_START_VIEW,)
        'result = MICR.CanonAPI.CsdDrvDialog(hInstance, Me.Handle, 0)
        'result = MICR.CanonAPI.CsdParSet(MICR.CanonAPI.CSDP_MAXDOCUMENT, 1)
        '        result = MICR.CanonAPI.CsdParSet(MICR.CanonAPI.CSDP_XRESOLUTION, 100)
        '       result = MICR.CanonAPI.CsdParSet(MICR.CanonAPI.CSDP_YRESOLUTION, 100)
        ''result = MICR.CsdParSet(MICR.CanonAPI.CSDP_AUTOSIZE, 1)
        'result = MICR.CanonAPI.CsdParSet(MICR.CanonAPI.CSDP_MODE, MICR.CanonAPI.CSD_4BITGRAYSCALE)
        ''result = MICR.SetCSDP_MODE(CSDP_MODEAttribute.CSD_GRAYSCALE)

        'Inicia el Scan
        result = MICR.CsdStartScan(Nothing, Nothing, Nothing)
        result = MICR.CsdReadPage(img)

        Dim Pagina As Integer = 0
        While result = CSD_OK
            Pagina = Pagina + 1

            'Lee los datos
            Me.LeerMICR()

            'Lee la imagen
            Me.GrabarImagen(Pagina, img)
            result = MICR.CsdReadPage(img)
            '   result = MICR.CanonAPI.CsdStartScan(Nothing, Nothing, Nothing)
        End While

        'result = MICR.CanonAPI.CsdParSet(MICR.CanonAPI.CSDP_DISPLAY_VIEW_FRONT, MICR.CanonAPI.VarPtr(img))




        If result = CSD_OK Then
            result = MICR.CsdReleaseImage(img)
        End If
        result = MICR.CsdTerminate()



    End Sub

    Sub GrabarImagen(ByVal pagina, ByVal img)
        ''Para grabar en disco la imagen
        Dim result As Int32
        Dim file As CEIIMAGEFILEINFO
        file.cbSize = Len(file)
        file.nFileType = CSD_JPEG_FILE
        file.nCompType = CSD_COMP_JPEG
        file.nJpegQuality = Me.TrackBar1.Value
        Dim FileName As String

        FileName = "c:\sistemas\ch" + pagina.ToString.Trim + ".jpg"
        result = MICR.CsdSaveImageEx(img, file, FileName)
        Try
            If Me.PictureBox1.Image Is Nothing Then
                Me.PictureBox1.Image = Image.FromFile(FileName)
            Else
                Me.PictureBox2.Image = Image.FromFile(FileName)


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
    Sub LeerMICR()
        Dim result As Int32
        Dim MicrLength As Long
        Dim cab As MICR.MICRCabecera
        Dim mD As MICR.MICRDetalle
        result = MICR.CsdParGet(CSDP_MICRDATALEN, MicrLength)
        Dim MicrData As String
        MicrData = Space(MicrLength)
        'MicrData = Space(1024)
        result = MICR.CsdParGet(CSDP_MICRDATA, MicrData)
        If result = 0 Then
            If MicrData.Length > 0 Then
                If MicrData.Substring(3, 2) = "00" Then
                    mD = New MICR.MICRDetalle(MicrData, Nothing)
                Else
                    cab = New MICR.MICRCabecera(MicrData, Nothing, Nothing)
                End If

            End If
            Me.TextBox1.Text = Me.TextBox1.Text + Chr(13) + MicrData
            Me.TextBox1.Refresh()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox(Util.DiaProceso(Me.DateTimePicker1.Text, 1))
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim frm As New frmClasificacion
        frm.Show()
    End Sub
End Class