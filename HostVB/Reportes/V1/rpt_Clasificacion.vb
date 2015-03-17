Public Class rpt_Clasificacion
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fecha As Date = Convert.ToDateTime(Me.DateTimePicker1.Text)

        'If Not My.MyApplication.Cerrado(My.Application.Banco.cod_banco, fecha, My.Application.Moneda.cod_moneda, My.Application.IdProceso) Then
        '    MsgBox("No puede realizar esta operacion. Debe cerrar el proceso primero.", MsgBoxStyle.Information)
        '    Return
        'End If

        Me.ClasificacionTableAdapter.Fill(dsReportes.Clasificacion, My.Application.Banco.cod_banco, fecha)

        Dim lParam As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("NombreBanco", My.Application.Banco.nombre_banco))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Mascara", "N" + My.Application.Moneda.decimales.ToString))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Moneda", My.Application.Moneda.descripcion))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", My.User.Name))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Fecha", fecha))

        Me.ReportViewer1.LocalReport.SetParameters(lParam)

        Me.ReportViewer1.RefreshReport()

    End Sub


    Private Sub rpt_Clasificacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsReportes.Clasificacion' table. You can move, or remove it, as needed.

    End Sub
End Class