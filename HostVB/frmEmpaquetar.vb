Public Class frmEmpaquetar

    Private Sub cmdGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerar.Click
        Me.cmdGenerar.Enabled = False
        Me.cmdCancel.Enabled = True

        Dim enlace As New Enlace
        enlace.CarpetaImagen = My.Settings.CarpetaImagen
        enlace.CarpetaFTP = Me.txtDestino.Text
        enlace.Marcar = False
        enlace.Banco = My.Application.Banco.cod_banco
        enlace.Proceso = My.Application.IdProceso
        enlace.Moneda = My.Application.Moneda.cod_moneda
        enlace.Fecha = Me.txtFecha.Value.Date
        enlace.Worker = Worker
        enlace.Opcion = Me.cboOpcion.SelectedIndex

        Worker.RunWorkerAsync(enlace)

        'Dim fm As New Formalistica(My.Settings.CarpetaImagen, My.Settings.CarpetaFTP, False)
        'While fm.Procesar(My.Application.Banco.cod_banco, My.Application.IdProceso, My.Application.Moneda.cod_moneda, Me.txtFecha.Value.Date)

        'End While
    End Sub

    Private Sub Worker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Worker.DoWork

        Dim enlace As Enlace = CType(e.Argument, Enlace)
        Select Case enlace.Opcion
            Case "0"
                Dim fm As New Formalistica(enlace.CarpetaImagen, enlace.CarpetaFTP, enlace.Marcar, enlace.Worker)
                While fm.Procesar(enlace.Banco, enlace.Proceso, enlace.Moneda, enlace.Fecha)
                End While
            Case "1"
                Dim fm As New Formalistica(enlace.CarpetaImagen, enlace.CarpetaFTP, enlace.Worker)
                fm.ExportarImagen(enlace.Banco, enlace.Proceso, enlace.Moneda, enlace.Fecha)
        End Select


     

    End Sub

    Private Sub Worker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles Worker.ProgressChanged
        Me.ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub Worker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Worker.RunWorkerCompleted
        Me.cmdGenerar.Enabled = True
        Me.cmdCancel.Enabled = False
        If e.Error IsNot Nothing Then
            MessageBox.Show(Formalistica.EnumErrors(e.Error))
        Else
            MessageBox.Show("Proceso realizado correctamente.")
        End If

    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click

        If Worker.IsBusy Then
            Worker.CancelAsync()
        End If

    End Sub
    Structure Enlace
        Public CarpetaImagen As String
        Public CarpetaFTP As String
        Public Marcar As Boolean
        Public Banco As String
        Public Proceso As Integer
        Public Moneda As String
        Public Fecha As Date
        Public Worker As System.ComponentModel.BackgroundWorker
        Public Opcion As String
    End Structure

    Private Sub cmdGetDir_Click(sender As System.Object, e As System.EventArgs) Handles cmdGetDir.Click
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.txtDestino.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub frmEmpaquetar_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.txtDestino.Text = My.Settings.Carpeta
        Me.cboOpcion.SelectedIndex = 0
    End Sub
End Class