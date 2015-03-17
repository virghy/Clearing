Public Class Rpt_EConsolidada_Sucursal

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fecha As Date = Convert.ToDateTime(Me.DateTimePicker1.Text)

        Me.EConsolidada_SucursalTableAdapter.Fill(Me.dsReportes.EConsolidada_Sucursal, fecha, My.Application.Banco.cod_banco, My.Application.Moneda.cod_moneda)

        Dim lParam As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("NombreBanco", My.Application.Banco.nombre_banco))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Mascara", "N" + My.Application.Moneda.decimales.ToString))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Moneda", My.Application.Moneda.descripcion))

        Me.ReportViewer1.LocalReport.SetParameters(lParam)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Rpt_Consolidada_CamaraCompensadora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dsReportes.EConsolidada_Sucursal' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'dsReportes.Planilla_Camara_Compensadora' Puede moverla o quitarla según sea necesario.
        '  Me.Planilla_Camara_CompensadoraTableAdapter.Fill(Me.dsReportes.Planilla_Camara_Compensadora)
        'TODO: esta línea de código carga datos en la tabla 'dsReportes.Planilla_Camara_Compensadora' Puede moverla o quitarla según sea necesario.
        '    Me.Planilla_Camara_CompensadoraTableAdapter.Fill(Me.dsReportes.Planilla_Camara_Compensadora)

    End Sub
End Class