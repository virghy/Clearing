Public Class Rpt_Det_Docs_Bancos

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim banco As String = Me.TextBox1.Text.ToString
        Dim fecha As Date = Convert.ToDateTime(Me.DateTimePicker1.Text)
        Me.Detalle_Doc_BancosTableAdapter.Fill(Me.dsReportes.Detalle_Doc_Bancos, banco, fecha)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


End Class