
Public Class Form1
    Dim dm As New DataAccess.Entities
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar.Click
        'Se debe enviar como parametro el banco sin intervencion del usuario

        If Me.Rb1.Checked = True Then
            Cenv.ArchivoCenv(dm, Txtfecha.Text, My.Application.Banco.cod_banco)
        End If
        If Me.Rb2.Checked = True Then
            Cenv.ArchivoASCII(dm, Txtfecha.Text, 2, My.Application.Banco.cod_banco) 'Enviar parametro de codproceso
        End If
        If Me.Rb3.Checked = True Then
            Cenv.ArchivoENVASSDBF(dm, Txtfecha.Text, My.Application.Banco.cod_banco)
        End If
        If Me.Rb4.Checked = True Then
            'Falta procedimiento para generar archivo Cddmm02
        End If
        If Me.Rb5.Checked = True Then
            'Cenv.ArchivoMOVIDIDADBF(dm, txtFecha.Text, My.Application.Banco.cod_banco)
            Cenv.Exportar(txtFecha.Text, 3, "DBF")

        End If
        If Me.rb6.Checked = True Then
            Cenv.Exportar(txtFecha.Text, 2)
        End If


        'Cenv.ArchivoMAYORES(dm, Txtfecha.Text, txtmonto.Text)Para Recibidos
    End Sub
    'Private Sub Rb1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb1.CheckedChanged
    '    Me.lb_monto.Enabled = False
    '    Me.TextBox1.Enabled = False


    'End Sub

    'Private Sub Rb2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb2.CheckedChanged
    '    Me.lb_monto.Enabled = False
    '    Me.TextBox1.Enabled = False
    'End Sub

End Class