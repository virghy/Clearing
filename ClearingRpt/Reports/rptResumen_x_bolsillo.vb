Public Class rptResumen_x_bolsillo
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fecha As Date = Convert.ToDateTime(Me.DateTimePicker1.Text)
        Dim bancorcptor As String = Me.txtBcoReceptor.Text.ToString
        Me.Lecturas_x_bolsilloTableAdapter.Fill(Me.DsReportes.Lecturas_x_bolsillo, fecha, bancorcptor)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub rptResumen_x_bolsillo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsReportes.Bancos' Puede moverla o quitarla según sea necesario.
        Me.BancosTableAdapter.Fill(Me.DsReportes.Bancos)

    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class