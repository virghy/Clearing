Public Class rpt_comp_interbanco_enviados

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fecha As Date = Convert.ToDateTime(Me.DateTimePicker1.Text)
        Me.Compensacion_Interbanco_EnviadosTableAdapter.Fill(dsReportes.Compensacion_Interbanco_Enviados, fecha)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub rpt_comp_interbanco_enviados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dsReportes.Compensacion_Interbanco_Enviados' Puede moverla o quitarla según sea necesario.
        '      Me.Compensacion_Interbanco_EnviadosTableAdapter.Fill(Me.dsReportes.Compensacion_Interbanco_Enviados)

    End Sub
End Class