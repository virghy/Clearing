Public Class frmInterfases
    Private dm As New DataAccess.Entities
    Private Sub frmInterfases_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Proceso As Integer = My.Application.IdProceso

        Me.AsciiBindingSource.DataSource = dm.Ascii.Where(Function(p) p.cod_banco = My.Application.Banco.cod_banco And (p.IdProceso = Proceso Or p.IdProceso Is Nothing) And (p.IdMoneda = My.Application.Moneda.cod_moneda Or p.IdMoneda Is Nothing))

    End Sub

    Private Sub btn_generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar.Click
        Dim ascii As DataAccess.Ascii = CType(Me.AsciiBindingSource.Current, DataAccess.Ascii)

        Select Case ascii.IdFormato
            Case 1  ''Ejecutamos el SP
                If Not My.MyApplication.Cerrado(My.Application.Banco.cod_banco, txtFecha.Text, My.Application.Moneda.cod_moneda, 2) Then
                    MsgBox("No puede realizar esta operacion. Debe cerrar el proceso primero.", MsgBoxStyle.Information)
                    Return
                End If
                Cenv.ArchivoCenv(dm, txtFecha.Text, My.Application.Banco.cod_banco)
            Case 2 ''Se exporta a TXT
                If Not My.MyApplication.Cerrado(My.Application.Banco.cod_banco, txtFecha.Text, My.Application.Moneda.cod_moneda, My.Application.IdProceso, Me.nudPaquete.Value) Then
                    MsgBox("No puede realizar esta operacion. Debe cerrar el proceso primero.", MsgBoxStyle.Information)
                    Return
                End If

                Cenv.Exportar(txtFecha.Text, ascii.idcabecera, Me.nudPaquete.Value)
            Case 3 'Se exporta a DBF/XLS
                Cenv.Exportar(txtFecha.Text, ascii.idcabecera, Me.nudPaquete.Value, "DBF")
            Case Else
                Cenv.Exportar(txtFecha.Text, ascii.idcabecera, Me.nudPaquete.Value)
        End Select

    End Sub
End Class
