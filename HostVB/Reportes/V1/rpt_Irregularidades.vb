Public Class rpt_Irregularidades

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dfecha As Date = Convert.ToDateTime(Me.DateTimePicker1.Text)
        Dim hfecha As Date = Convert.ToDateTime(Me.DateTimePicker2.Text)

        If Not My.MyApplication.Cerrado(My.Application.Banco.cod_banco, DateTimePicker2.Text, My.Application.Moneda.cod_moneda, 1) Then
            MsgBox("No puede realizar esta operacion. Debe cerrar el proceso primero.", MsgBoxStyle.Information)
            Return
        End If

        Me.IrregularidadesTableAdapter.Fill(dsReportes.Irregularidades, My.Application.Banco.cod_banco, dfecha, hfecha)

        Dim lParam As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("NombreBanco", My.Application.Banco.nombre_banco))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Mascara", "N" + My.Application.Moneda.decimales.ToString))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Moneda", My.Application.Moneda.descripcion))

        Me.ReportViewer1.LocalReport.SetParameters(lParam)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Rpt_Consolidada_CamaraCompensadora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dsReportes.Planilla_Camara_Compensadora' Puede moverla o quitarla según sea necesario.
        '    Me.Planilla_Camara_CompensadoraTableAdapter.Fill(Me.dsReportes.Planilla_Camara_Compensadora)

    End Sub
End Class