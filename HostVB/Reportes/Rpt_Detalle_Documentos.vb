Public Class Rpt_Detalle_Documentos

    Private Sub Rpt_Detalle_Documentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsReportes.Detalle_Documentos_Bancos' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'DsReportes.Bancos' Puede moverla o quitarla según sea necesario.
        Me.BancosTableAdapter.Fill(Me.DsReportes.Bancos)
        Dim dr As dsReportes.BancosRow
        dr = Me.DsReportes.Bancos.NewBancosRow
        dr.cod_banco = ""
        dr.nombre_banco = "(Todos)"
        Me.DsReportes.Bancos.Rows.InsertAt(dr, 0)
        Me.ComboBox2.SelectedIndex = 0
        Me.cboCD.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Not My.MyApplication.Cerrado(My.Application.Banco.cod_banco, DateTimePicker1.Text, My.Application.Moneda.cod_moneda, My.Application.IdProceso) Then
            MsgBox("No puede realizar esta operacion. Debe cerrar el proceso primero.", MsgBoxStyle.Information)
            Return
        End If

        Dim fecha As Date = Convert.ToDateTime(Me.DateTimePicker1.Text)
        Dim entidad As String = Nothing

        If Not Me.ComboBox2.SelectedValue Is Nothing And Me.ComboBox2.SelectedValue <> "" Then
            entidad = Me.ComboBox2.SelectedValue

        End If

        Dim cd As Nullable(Of Boolean)
        Select Case cboCD.SelectedIndex
            Case 0
                cd = False
            Case 1
                cd = True
            Case 2
                cd = Nothing
        End Select

        Me.Rpt_DetalleChequesTableAdapter.Fill(DsReportes.rpt_DetalleCheques, My.Settings.IdEmpresa, fecha, entidad, My.Settings.Moneda, My.Application.IdProceso, cd)



        Dim lParam As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("NombreBanco", My.Application.Banco.nombre_banco))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Mascara", "N" + My.Application.Moneda.decimales.ToString))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Proceso", Util.NombreProceso(My.Application.IdProceso)))



        If My.Settings.CalidadImpresion Is Nothing Then
            My.Settings.CalidadImpresion = "F"
            My.Settings.Save()
        End If


        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("CalidadImpresion", My.Settings.CalidadImpresion))

        Me.ReportViewer1.LocalReport.SetParameters(lParam)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class