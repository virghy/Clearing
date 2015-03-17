Imports ClearingRpt
Public Class Reportes
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.RadioButton1.Checked = True Then
            Dim Frm As New rpt_Detalle_Cheques_x_sucursal_enviados
            Frm.Show()
        End If

        If Me.RadioButton2.Checked = True Then
            Dim frm As New rpt_comp_interbanco_enviados
            frm.Show()
        End If

        If Me.RadioButton3.Checked = True Then
            Dim frm As New Res_comp_Cheques_enviados
            frm.Show()
        End If
        If Me.RadioButton4.Checked = True Then
            Dim frm As New Rpt_Det_Docs_Bancos
            frm.Show()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Reportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
End Class