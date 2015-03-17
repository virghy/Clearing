Public Class Res_comp_Cheques_enviados
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim banco As String = Me.ComboBox1.SelectedValue.ToString
        Dim sucursal As String = Me.ComboBox2.SelectedValue.ToString
        Dim fecha As Date = Convert.ToDateTime(Me.DateTimePicker1.Text)
        Me.Lecturas2TableAdapter.Fill(Me.dsReportes.Lecturas2, banco, fecha, sucursal)
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Res_comp_Cheques_enviados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dsReportes.Lecturas2' Puede moverla o quitarla según sea necesario.
        '   '    Me.Lecturas2TableAdapter.Fill(Me.dsReportes.Lecturas2)
        'TODO: esta línea de código carga datos en la tabla 'dsReportes.Sucursales' Puede moverla o quitarla según sea necesario.
        Me.SucursalesTableAdapter.Fill(Me.dsReportes.Sucursales)
        'TODO: esta línea de código carga datos en la tabla 'dsReportes.Bancos' Puede moverla o quitarla según sea necesario.
        Me.BancosTableAdapter.Fill(Me.dsReportes.Bancos)

    End Sub
End Class