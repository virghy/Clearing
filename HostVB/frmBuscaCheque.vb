Imports DataAccess
Public Class frmBuscaCheque
    Dim dm As New Entities
    Dim dxe As New Sorteable.FilteredBindingList(Of Lecturas)(dm)
    Dim codBanco As String = "05"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CargarDatos()
    End Sub

    Sub CargarDatos()
        'CabList = From c In dm.Lecturas Select c _
        '            Where c.fecha_lectura = Fecha And c.cod_maquina = CodMaquina Order By c.nro_lote, c.cabecera
        '  dm.AcceptAllChanges()
        dxe.Clear()

        Dim Cheque As Decimal = 0
        Dim Cuenta As Decimal = 0

        If IsNumeric(Me.txtNumero.Text) Then
            Cheque = CDec(Me.txtNumero.Text)
        End If

        If IsNumeric(Me.txtCuenta.Text) Then
            Cuenta = CDec(Me.txtCuenta.Text)
        End If


        dxe.Load(From c In dm.Lecturas _
                 Where c.cod_banco = Me.codBanco And (c.fecha_lectura = Me.txtFecha.Text Or Me.CheckBox1.Checked) _
                And (Cheque = 0 OrElse c.numero_cheque = Cheque) _
                And (Cuenta = 0 OrElse c.cuenta_cheque = Cuenta) _
                And "00-01-02-03-04".Contains(c.cod_tipdoc) _
                Select c _
                    Order By c.nro_lote, c.cod_tipdoc Descending, c.cabecera)
        Me.LecturasBindingSource.DataSource = dxe
    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        codBanco = My.MySettings.Default.IdEmpresa
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub LecturasDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LecturasDataGridView.CellClick
        If e.ColumnIndex = 14 Then
            Dim frm As New FrmEditarDetalle(Me.LecturasBindingSource.Current)
            '    frm.LecturasBindingSource.DataSource = Me.CabList
            '   frm.LecturasBindingSource.Position = Me.LecturasBindingSource.Position
            frm.SoloLectura = True
            Me.LecturasDataGridView.BeginEdit(False)
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                frm.LecturasBindingSource.EndEdit()
                Me.LecturasBindingSource.EndEdit()
                'Me.ProcesarLectura()
            Else
                frm.LecturasBindingSource.CancelEdit()
                Me.LecturasBindingSource.CancelEdit()
            End If

        End If
    End Sub
End Class