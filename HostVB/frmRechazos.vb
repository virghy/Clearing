Imports DataAccess
Imports System.Data.Entity
Imports System.Data.Entity.Database
Imports System.Data.Objects

Public Class frmRechazos
    Dim dm As Entities
    Dim codBanco As String = "05"
    Dim Editando As Boolean = False
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles cmdBuscar.Click

        If Not IsNumeric(Me.txtNumero.Text) Then
            Return
        End If

        Dim q As ObjectQuery(Of Lecturas) = From s In dm.Lecturas.Include("LecturasRechazos").Include("LecturasRechazos.MotivosRechazo") _
            Where s.cod_banco = codBanco _
               And s.numero_cheque = Me.txtNumero.Text _
               And s.fecha_lectura = Me.txtFecha.Value.Date _
               And s.cod_proceso = 5 _
               And s.cod_tipdoc <> "90"
               Select s

        Me.LecturasBindingSource.DataSource = q.Execute(MergeOption.OverwriteChanges)
        If Me.LecturasBindingSource.Count = 0 Then
            MsgBox("No se encuentra el valor indicado.")
        Else
            Me.Editando = True
            Me.GridControl1.Focus()
        End If

        Me.CambiarEdicion()

    End Sub

    Sub CambiarEdicion()
        Me.txtNumero.Enabled = Not Me.Editando
        Me.cmdBuscar.Enabled = Not Me.Editando
        Me.GridControl1.Enabled = Me.Editando

        Me.cmdGrabar.Enabled = Me.Editando
        Me.cmdCancel.Enabled = Me.Editando

    End Sub

    Private Sub frmRechazos_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'If dm.g
    End Sub

    Private Sub frmRechazos_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        dm = New Entities
        codBanco = My.MySettings.Default.IdEmpresa
        dm.MotivosRechazo.Where(Function(p) p.IdBanco = codBanco).Load()
        Me.CambiarEdicion()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles cmdGrabar.Click
        Grabar()
    End Sub

    Sub Grabar()
        Try

            Dim l As Lecturas = CType(Me.LecturasBindingSource.Current, Lecturas)

            If l.LecturasRechazos.Count > 0 Then
                l.IdMotivo = l.LecturasRechazos(0).IdMotivo
            Else
                l.IdMotivo = Nothing
            End If

            dm.SaveChanges()
            Me.LecturasBindingSource.Clear()
            Me.txtNumero.Text = ""

            Me.Editando = False
            Me.CambiarEdicion()

        Catch ex As Exception
            MessageBox.Show(Util.EnumErrors(ex), "Un error ha ocurrido")
        Finally
            Me.Refresh()
        End Try

    End Sub
    Private Sub LecturasRechazosBindingSource_AddingNew(sender As System.Object, e As System.ComponentModel.AddingNewEventArgs) Handles LecturasRechazosBindingSource.AddingNew
        Dim mr As New LecturasRechazo
        mr.Audit_Fecha = Date.Now
        mr.Audit_Usuario = My.User.Name
        mr.IdBanco = Me.codBanco
        e.NewObject = mr

    End Sub

    Private Sub GridView1_InvalidValueException(sender As Object, e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles GridView1.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
        e.WindowCaption = "Error de entrada"
        e.ErrorText = "Motivo no válido."
        GridView1.HideEditor()
    End Sub

    Private Sub GridView1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        'If (e.KeyCode = Keys.Delete And e.Modifiers = Keys.Control) Then
        If Not Me.LecturasRechazosBindingSource.Current Is Nothing Then
            If (e.KeyCode = Keys.Delete) Then
                If (MessageBox.Show("Borrar registro?", "Confirmación", _
                  MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return

                dm.LecturasRechazos.DeleteObject(CType(Me.LecturasRechazosBindingSource.Current, LecturasRechazo))

            End If
        End If
    End Sub





    Private Sub GridView1_ValidatingEditor(sender As Object, e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GridView1.ValidatingEditor
        If GridView1.FocusedColumn.Name <> "colIdMotivo" Then
            Return
        End If
        e.Valid = False
        For Each s In dm.MotivosRechazo
            If s.IdMotivo.Trim = CType(e.Value, String).Trim Then
                e.Valid = True
                'GridView1.SetFocusedRowCellValue(colMotivosRechazo, s.Motivo)
                CType(Me.LecturasRechazosBindingSource.Current, LecturasRechazo).Motivo = s.Motivo
                Exit For
            End If

        Next

    End Sub



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        txtImporte.DataBindings.Add("text", Me.LecturasBindingSource, "monto", _
True, DataSourceUpdateMode.OnPropertyChanged, 0, "N" + My.Application.Moneda.decimales.ToString)

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cmdCancel_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancel.Click
        Me.LecturasBindingSource.Clear()
        Me.txtNumero.Text = ""

        Me.Editando = False
        Me.CambiarEdicion()
    End Sub
End Class

