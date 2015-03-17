﻿Public Class rpt_CompensacionUSD

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dfecha As Date = Convert.ToDateTime(Me.DateTimePicker1.Text)
        ' Dim hfecha As Date = Convert.ToDateTime(Me.DateTimePicker2.Text)

        If Not My.MyApplication.Cerrado(My.Application.Banco.cod_banco, DateTimePicker1.Text, My.Application.Moneda.cod_moneda, 3) Then
            MsgBox("No puede realizar esta operacion. Debe cerrar el proceso primero.", MsgBoxStyle.Information)
            Return
        End If

        Me.CompensacionUSDTableAdapter.Fill(Me.dsReportes.CompensacionUSD, My.Application.Banco.cod_banco, Util.DiaProceso(dfecha, 1), dfecha)

        Dim lParam As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("NombreBanco", My.Application.Banco.nombre_banco))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Mascara", "N" + My.Application.Moneda.decimales.ToString))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Moneda", My.Application.Moneda.descripcion))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Fecha", dfecha))

        Me.ReportViewer1.LocalReport.SetParameters(lParam)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Rpt_Consolidada_CamaraCompensadora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsReportes.CompensacionUSD' table. You can move, or remove it, as needed.
        'Me.CompensacionUSDTableAdapter.Fill(Me.dsReportes.CompensacionUSD)
        'TODO: This line of code loads data into the 'dsReportes.EN1200' table. You can move, or remove it, as needed.

    End Sub


End Class