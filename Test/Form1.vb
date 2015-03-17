Imports System.Data.Objects
Imports MICR
Imports DataAccess
Imports DevExpress.Data
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class Form1
    Dim Moneda As MICR.Moneda
    Dim configMICR As ConfigMICR
    Dim CodBanco As String
    Dim IdProceso As Integer
    Dim edm As DataAccess.Entities
    Dim STCab As Decimal
    Dim STDet As Decimal
    Dim STErr As Decimal
    Dim StDif As Decimal
    Private Sub Procesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Procesar.Click

        CodBanco = Me.txtBanco.Text
        IdProceso = Me.txtProceso.Text
        Dim Lista As ObjectQuery(Of DataAccess.Lecturas) = From s In edm.Lecturas Where s.cod_banco = Me.txtBanco.Text _
                  And s.fecha_lectura = Me.txtFecha.Value.Date _
                  And s.cod_proceso = CInt(Me.txtProceso.Text) _
                  And s.cod_maquina = CInt(Me.txtMaquina.Text) _
                  And s.cod_moneda = "PYG"
        Me.configMICR = edm.ConfigMICR.Where(Function(p) p.IdBanco = CodBanco And p.IdProceso = IdProceso).FirstOrDefault
        Me.LecturasBindingSource.DataSource = Lista.Execute(MergeOption.AppendOnly)

        ' iniciarLecturaPrueba()
    End Sub
    Sub IniciarVariables()
        CodBanco = Me.txtBanco.Text
        IdProceso = Me.txtProceso.Text

        Me.configMICR = edm.ConfigMICR.Where(Function(p) p.IdBanco = CodBanco And p.IdProceso = IdProceso).FirstOrDefault
    End Sub
    'Private Sub gvMain_CustomSummaryCalculate(ByVal sender As Object, _
    '                                                                       ByVal e As DevExpress.Data.CustomSummaryEventArgs) _
    '                                                                            Handles LecturasGridControl.CustomSummaryCalculate


    'End Sub


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
        data = "C2800E000007002902E12739513A@07@010000004345367@"
        'If data.Length > 0 Then
        mG = New MICRGeneral(data, Moneda, configMICR)
        'Me.Grabar(mG, 2)
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Moneda = New Moneda("PYG", 0)
        Me.edm = New DataAccess.Entities
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        IniciarVariables()
        iniciarLecturaPrueba()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mG As MICRGeneral = Nothing
        mG = New MICRGeneral(Me.txtCadena.Text, Moneda, configMICR)
        'If mG.Detalle IsNot Nothing Then
        'End If
        Me.txtCampo1.Text = mG.Campo1
        Me.txtCampo2.Text = mG.Campo2
        Me.txtCampo3.Text = mG.Campo3
        Me.txtCampo4.Text = mG.Campo4
        Me.txtCadenaDev.Text = mG.Cadena
        AgregarLectura(mG)


    End Sub

    Sub AgregarLectura(ByVal Mg As MICRGeneral)
        Dim l As New Lecturas
        If Mg.Tipo = TipoMICR.Cabecera Then
            l.monto = Mg.Cabecera.Importe
            l.cuenta_cheque = Mg.Cabecera.Cuenta
            l.numero_cheque = Mg.Cabecera.Cheque
            l.cod_banco_receptor = Mg.Cabecera.Banco
            l.cod_tipdoc = Mg.Cabecera.Cpbt
            l.cadena_captura = Mg.Cabecera.Cadena

        ElseIf Mg.Tipo = TipoMICR.Detalle Then

            l.monto = Mg.Detalle.Importe
            l.cuenta_cheque = Mg.Detalle.Cuenta
            l.numero_cheque = Mg.Detalle.Cheque
            l.cod_banco_receptor = Mg.Detalle.BancoR
            l.cod_banco_emisor = Mg.Detalle.BancoE
            l.cod_tipdoc = Mg.Detalle.Cpbt
            l.cod_camara = Mg.Detalle.Camara
            l.cadena_captura = Mg.Detalle.CadenaDet

        End If
        Me.ProcesoBindingSource.Add(l)
    End Sub

    Private Sub GridView1_CustomSummaryCalculate(ByVal sender As Object, ByVal e As DevExpress.Data.CustomSummaryEventArgs) Handles GridView1.CustomSummaryCalculate
        ' Get the summary ID. 
        Dim summaryID As Integer = Convert.ToInt32(CType(e.Item, GridSummaryItem).Tag)
        Dim View As GridView = CType(sender, GridView)
        ' Initialization 
        If e.SummaryProcess = CustomSummaryProcess.Start Then
            STCab = 0
            STDet = 0
            STErr = 0
            STDif = 0
        End If
        ' Calculation 
        If e.SummaryProcess = CustomSummaryProcess.Calculate Then
            Dim esCabecera As Boolean = CBool(View.GetRowCellValue(e.RowHandle, "EsCabecera"))
            Dim conError As Boolean = CBool(View.GetRowCellValue(e.RowHandle, "ConError"))
            Select Case summaryID
                Case 1 ' The total summary calculated against the 'UnitPrice' column. 
                    '                    If Not esCabecera Then STCab += Convert.ToDecimal(e.FieldValue)
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
                    lblCab.Text = STDet.ToString("N0")
                    '               txtSubTotalDet.Text = STDet.ToString("N0")

                    'txtErrores.Text = STErr.ToString("N0")
                    'txtSubDif.Text = (STCab - STDet).ToString("N0")
                Case 2
                    e.TotalValue = STDet
                Case 3
                    e.TotalValue = StDif

            End Select
        End If
    End Sub
End Class
