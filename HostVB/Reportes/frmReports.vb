Imports System.Configuration
Public Class frmReports
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim banco As String = Me.TextBox1.Text.ToString
        Dim fecha As Date = Convert.ToDateTime(Me.DateTimePicker1.Text)
        Me.Lecturas1TableAdapter.Fill(Me.dsReportes.Lecturas1, banco, fecha)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class