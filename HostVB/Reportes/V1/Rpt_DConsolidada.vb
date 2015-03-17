Public Class Rpt_Dconsolidada

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fecha As Date = Convert.ToDateTime(Me.DateTimePicker1.Text)

        Me.ConsolDevueltosTableAdapter.Fill(Me.dsReportes.ConsolDevueltos, My.Application.Banco.cod_banco, fecha)

        Dim lParam As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("NombreBanco", My.Application.Banco.nombre_banco))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Mascara", "N" + My.Application.Moneda.decimales.ToString))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Moneda", My.Application.Moneda.descripcion))

        Me.ReportViewer1.LocalReport.SetParameters(lParam)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Rpt_Consolidada_CamaraCompensadora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsReportes.ConsolDevueltos' table. You can move, or remove it, as needed.
        'Me.ConsolDevueltosTableAdapter.Fill(Me.dsReportes.ConsolDevueltos)
        'TODO: esta línea de código carga datos en la tabla 'dsReportes.EConsolidada_Sucursal' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'dsReportes.Planilla_Camara_Compensadora' Puede moverla o quitarla según sea necesario.
        '  Me.Planilla_Camara_CompensadoraTableAdapter.Fill(Me.dsReportes.Planilla_Camara_Compensadora)
        'TODO: esta línea de código carga datos en la tabla 'dsReportes.Planilla_Camara_Compensadora' Puede moverla o quitarla según sea necesario.
        '    Me.Planilla_Camara_CompensadoraTableAdapter.Fill(Me.dsReportes.Planilla_Camara_Compensadora)

    End Sub
End Class