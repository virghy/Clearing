Public Class rpt_Detalle_Cheques_x_sucursal_enviados
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim banco As String = My.Settings.IdEmpresa
        Dim sucursal As Integer = Me.ComboBox2.SelectedValue
        Dim fecha As Date = Convert.ToDateTime(Me.DateTimePicker1.Text)
        Me.Det_cheque_x_sucursal_enviadosTableAdapter.Fill(Me.dsReportes.Det_cheque_x_sucursal_enviados, banco, sucursal, fecha)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub rpt_Detalle_Cheques_x_sucursal_enviados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dsReportes.Det_cheque_x_sucursal_enviados' Puede moverla o quitarla según sea necesario.
        '    Me.Det_cheque_x_sucursal_enviadosTableAdapter.Fill(Me.dsReportes.Det_cheque_x_sucursal_enviados)
        'TODO: esta línea de código carga datos en la tabla 'dsReportes.Sucursales' Puede moverla o quitarla según sea necesario.
        Me.SucursalesTableAdapter.Fill(Me.dsReportes.Sucursales)
        'TODO: esta línea de código carga datos en la tabla 'dsReportes.Sucursales' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'dsReportes.Bancos' Puede moverla o quitarla según sea necesario.
        Me.BancosTableAdapter.Fill(Me.dsReportes.Bancos)

    End Sub
End Class