Public Class frmSucursal

    Dim _dc As New ClearingDA.ClearingDataContext
    Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.DC = _dc
        Me.BancosBindingSource.DataSource = From banco In _dc.Bancos Select banco
        Me.BindingSource.DataSource = _dc.Sucursales

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.BindingSource.DataSource = From suc In _dc.Sucursales Select suc _
                                      Where suc.cod_banco = CInt(Me.ComboBox1.SelectedValue)

    End Sub

    Private Sub frmSucursal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.BindingSource.DataSource = From suc In _dc.Sucursales Select suc _
                              Where suc.cod_banco = CInt(Me.ComboBox1.SelectedValue)

    End Sub

    Private Sub SucursalesDataGridView_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles SucursalesDataGridView.RowsAdded
        ' Me.SucursalesDataGridView.Rows(e.RowIndex).Cells(2).Value = Me.ComboBox1.SelectedValue
    End Sub


    Private Sub SucursalesDataGridView_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles SucursalesDataGridView.UserAddedRow
        'For Each suc As ClearingDA.Sucursales In Me.BindingSource.DataSource
        '    suc.cod_banco = Me.ComboBox1.SelectedValue
        'Next
        ' Me.SucursalesDataGridView.SelectedRows(0).Cells(2).Value = Me.ComboBox1.SelectedValue

    End Sub

    Private Sub frmSucursal_Validar(ByRef Cancel As Boolean, ByVal ListaCambios As System.Data.Linq.ChangeSet) Handles Me.Validar
        For Each suc As ClearingDA.Sucursales In ListaCambios.Inserts
            suc.cod_banco = Me.ComboBox1.SelectedValue

        Next
    End Sub
End Class