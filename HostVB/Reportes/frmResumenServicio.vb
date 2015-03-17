Public Class frmResumenServicio

    Private Sub frmResumenServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsReportes.ResumenServicio' table. You can move, or remove it, as needed.
        'TODO: esta línea de código carga datos en la tabla 'dsReportes.ResumenServicio' Puede moverla o quitarla según sea necesario.
        '  Me.ResumenServicioTableAdapter.Fill(Me.dsReportes.ResumenServicio)

        ' Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fecha As Date = Convert.ToDateTime(Me.dFecha.Text)
        Dim entidad As String = Nothing

       
        Me.ResumenServicioTableAdapter.Fill(dsReportes.ResumenServicio, My.Settings.IdEmpresa, Me.dFecha.Text, Me.hFecha.Text)
        '        Me.Rpt_DetalleChequesTableAdapter.Fill(dsReportes.rpt_DetalleCheques, My.Settings.IdEmpresa, fecha, entidad, My.Settings.Moneda)

        Dim lParam As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("NombreBanco", My.Application.Banco.nombre_banco))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("dFecha", Me.dFecha.Text))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("hFecha", Me.hFecha.Text))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", My.User.Name))
        '       lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Mascara", "N" + My.Application.Moneda.decimales.ToString))
        Me.ReportViewer1.LocalReport.SetParameters(lParam)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class