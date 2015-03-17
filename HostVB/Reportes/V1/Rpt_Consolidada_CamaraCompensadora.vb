Public Class Rpt_Consolidada_CamaraCompensadora

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fecha As Date = Convert.ToDateTime(Me.DateTimePicker1.Text)

        If Not My.MyApplication.Cerrado(My.Application.Banco.cod_banco, DateTimePicker1.Text, My.Application.Moneda.cod_moneda, My.Application.IdProceso) Then
            MsgBox("No puede realizar esta operacion. Debe cerrar el proceso primero.", MsgBoxStyle.Information)
            Return
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



        Me.Planilla_Camara_CompensadoraTableAdapter.Fill(dsReportes.Planilla_Camara_Compensadora, fecha, My.Application.IdProceso, My.Application.Banco.cod_banco, My.Application.Moneda.cod_moneda, cd)
        Select Case My.Application.IdProceso

            Case Operacion.Enviado Or Operacion.Devuelto
                '                Me.Planilla_Camara_CompensadoraTableAdapter.Fill(dsReportes.Planilla_Camara_Compensadora, fecha, My.Application.IdProceso, My.Application.Banco.cod_banco, My.Application.Moneda.cod_moneda)

            Case Operacion.Recibido Or Operacion.Rechazado
                '               Me.Planilla_Camara_CompensadoraTableAdapter.FillEnviados(dsReportes.Planilla_Camara_Compensadora, fecha, My.Application.IdProceso, My.Application.Banco.cod_banco, My.Application.Moneda.cod_moneda)
                Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "HostVB.rpt_Consolidad_Recibidos.rdlc"
        End Select

        Dim dm As New DataAccess.Entities

        Dim NombreCamara = (From s In dm.Camaras Where s.cod_camara = My.Settings.Camara Select s.Ciudad).FirstOrDefault


        Dim lParam As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("NombreBanco", My.Application.Banco.nombre_banco))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Mascara", "N" + My.Application.Moneda.decimales.ToString))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Moneda", My.Application.Moneda.descripcion))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Proceso", My.Application.IdProceso))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Camara", NombreCamara))

        Me.ReportViewer1.LocalReport.SetParameters(lParam)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Rpt_Consolidada_CamaraCompensadora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dsReportes.Planilla_Camara_Compensadora' Puede moverla o quitarla según sea necesario.
        '    Me.Planilla_Camara_CompensadoraTableAdapter.Fill(Me.dsReportes.Planilla_Camara_Compensadora)

        Me.cboCD.SelectedIndex = 0
    End Sub
End Class