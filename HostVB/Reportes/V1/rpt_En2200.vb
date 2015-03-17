Public Class rpt_En2200

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Dim hfecha As Date = Convert.ToDateTime(Me.DateTimePicker2.Text)

        'If Not My.MyApplication.Cerrado(My.Application.Banco.cod_banco, DateTimePicker1.Text, My.Application.Moneda.cod_moneda, 5, Me.nudPaquete.Value) Then
        '    MsgBox("No puede realizar esta operacion. Debe cerrar el proceso primero.", MsgBoxStyle.Information)
        '    Return
        'End If

        Me.EN2200TableAdapter.Fill(dsReportes.EN2200, My.Application.Banco.cod_banco, Me.nudAnho.Value, Me.nudMes.Value)

        Dim lParam As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("NombreBanco", My.Application.Banco.nombre_banco))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Mascara", "N" + My.Application.Moneda.decimales.ToString))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Moneda", My.Application.Moneda.descripcion))
        lParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Periodo", String.Format("{0}/{1}", Util.NombreMes(Me.nudMes.Value), Me.nudAnho.Value)))

        Me.ReportViewer1.LocalReport.SetParameters(lParam)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Rpt_Consolidada_CamaraCompensadora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsReportes.EN2200' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'dsReportes.EN1700' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'dsReportes.EN1700' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'dsReportes.EN1200' table. You can move, or remove it, as needed.
        Me.nudMes.Value = Date.Today.Month
        Me.nudAnho.Value = Date.Today.Year
    End Sub


End Class