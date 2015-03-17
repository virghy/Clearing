
Public Class Reportes
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.RadioButton1.Checked = True Then
  
            Dim Frm As New Rpt_Detalle_Documentos
            Frm.Show()
        End If

        If Me.RadioButton2.Checked = True Then
            Dim frm As New Rpt_Consolidada_CamaraCompensadora
            frm.Show()
        End If

        'If Me.RadioButton3.Checked = True Then
        '    Dim frm As New Res_comp_Cheques_enviados
        '    frm.Show()
        'End If

        If Me.RadioButton5.Checked = True Then
            Dim frm As New Rpt_EAvisoDebito
            frm.Show()
        End If
        If Me.RadioButton6.Checked Then
            Dim frm As New frmResumenServicio
            frm.Show()
        End If
        If Me.RadioButton7.Checked Then
            Dim frm As New Rpt_EConsolidada_Sucursal
            frm.Show()
        End If
        If Me.RadioButton8.Checked Then
            Dim frm As New rpt_Irregularidades
            frm.Show()
        End If
        If Me.RadioButton9.Checked Then
            Dim frm As New rpt_Cobranzas
            frm.Show()
        End If

        If Me.RadioButton3.Checked Then
            Dim frm As New rpt_Clasificacion
            frm.Show()
        End If
        If Me.RadioButton4.Checked Then
            Dim frm As New Rpt_Dconsolidada
            frm.Show()
        End If
        If Me.rbEn1200.Checked Then
            Dim frm As New rpt_En1200
            frm.Show()
        End If
        If Me.rb1600.Checked Then
            Dim frm As New rpt_En1600
            frm.Show()
        End If
        If Me.rb1700.Checked Then
            Dim frm As New rpt_En1700
            frm.Show()
        End If

        If Me.rb1900.Checked Then
            Dim frm As New rpt_En1900
            frm.Show()
        End If

        If Me.rb2200.Checked Then
            Dim frm As New rpt_En2200
            frm.Show()
        End If
        If Me.rbCompensacionUSD.Checked Then
            Dim frm As New rpt_CompensacionUSD
            frm.Show()
        End If

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

   
End Class