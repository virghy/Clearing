﻿Public Class rpt_Cobranzas
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fecha As Date = Convert.ToDateTime(Me.DateTimePicker1.Text)

        If Not My.MyApplication.Cerrado(My.Application.Banco.cod_banco, fecha, My.Application.Moneda.cod_moneda, My.Application.IdProceso) Then
            MsgBox("No puede realizar esta operacion. Debe cerrar el proceso primero.", MsgBoxStyle.Information)
            Return
        End If

        Me.CobranzasTableAdapter.Fill(dsReportes.Cobranzas, My.Application.Banco.cod_banco, Util.DiaProceso(fecha, 2), fecha, Util.DiaProceso(fecha, 1))

        Dim lParam As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("NombreBanco", My.Application.Banco.nombre_banco))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Mascara", "N" + My.Application.Moneda.decimales.ToString))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Moneda", My.Application.Moneda.descripcion))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", My.User.Name))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Fecha", fecha))

        Me.ReportViewer1.LocalReport.SetParameters(lParam)

        Me.ReportViewer1.RefreshReport()

    End Sub

    
End Class