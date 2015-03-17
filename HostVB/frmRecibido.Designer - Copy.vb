<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecibido
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecibido))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.colcod_tipdoc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Edit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.Worker = New System.ComponentModel.BackgroundWorker
        Me.Label2 = New System.Windows.Forms.Label
        Me.LecturasDataGridView = New System.Windows.Forms.DataGridView
        Me.ColumnLote = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.clBanco = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.tbcSerie = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.clReceptor = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.Importe = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.cod_sucursal = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.cuenta_deposito = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.ConError = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.IdMotivo = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.ENVIADO = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.IdLectura = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.LecturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuInsertar = New System.Windows.Forms.ToolStripMenuItem
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsbIniciarCaptura = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.tsbErrores = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.tsEliminar = New System.Windows.Forms.ToolStripButton
        Me.tsbCargar = New System.Windows.Forms.ToolStripButton
        Me.tsbDescargar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton
        Me.cmdImportar = New System.Windows.Forms.ToolStripButton
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.cboBuscar = New System.Windows.Forms.ComboBox
        Me.lnkBuscar = New System.Windows.Forms.LinkLabel
        Me.TaskPane1 = New WindowsControlLibrary.TaskPane
        Me.TaskFrame1 = New WindowsControlLibrary.TaskFrame
        Me.tfValidar = New WindowsControlLibrary.TaskFrame
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.chkFiltraError = New System.Windows.Forms.CheckBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.TaskFrame4 = New WindowsControlLibrary.TaskFrame
        Me.PanelMotivoDevolucion = New System.Windows.Forms.Panel
        Me.txtMotivo = New System.Windows.Forms.TextBox
        Me.lnkMotivo = New System.Windows.Forms.LinkLabel
        Me.cboMotivo = New System.Windows.Forms.ComboBox
        Me.MotivosRechazoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.lnkReasignar = New System.Windows.Forms.LinkLabel
        Me.txtSucursal = New System.Windows.Forms.TextBox
        Me.nudLote = New System.Windows.Forms.NumericUpDown
        Me.lnkSucursal = New System.Windows.Forms.LinkLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboCajero = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboSucursal = New System.Windows.Forms.ComboBox
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.TaskFrame5 = New WindowsControlLibrary.TaskFrame
        Me.lnkFecha = New System.Windows.Forms.LinkLabel
        Me.lblDIF = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblCHQCant = New System.Windows.Forms.Label
        Me.lblCHQ = New System.Windows.Forms.Label
        Me.lblCABCant = New System.Windows.Forms.Label
        Me.lblCAB = New System.Windows.Forms.Label
        Me.lnkValidarCREC = New System.Windows.Forms.LinkLabel
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.LecturasGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colnro_lote = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcod_banco_receptor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcuenta_cheque = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Edit12 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colnumero_cheque = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Edit8 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colcod_banco_emisor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcod_camara = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colmonto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MontoEditor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colcod_sucursal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcuenta_deposito = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcabecera = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colConError = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdMotivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colENVIADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdLectura = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcadena_captura = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblSubTotalCab = New System.Windows.Forms.Label
        Me.txtSubTotalCab = New System.Windows.Forms.Label
        Me.lblSubTotalDet = New System.Windows.Forms.Label
        Me.txtSubTotalDet = New System.Windows.Forms.Label
        Me.lblSubDif = New System.Windows.Forms.Label
        Me.txtSubDif = New System.Windows.Forms.Label
        Me.lblError = New System.Windows.Forms.Label
        Me.txtErrores = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.LecturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IniciarCapturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ValidarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FiltrarErroresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataRepeater1 = New Microsoft.VisualBasic.PowerPacks.DataRepeater
        Me.ErroresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TaskPane2 = New WindowsControlLibrary.TaskPane
        Me.tfCheque = New WindowsControlLibrary.TaskFrame
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.ImagenBase1 = New HostVB.ImagenBase
        Me.tfCREC = New WindowsControlLibrary.TaskFrame
        Me.CRECDetGridControl = New DevExpress.XtraGrid.GridControl
        Me.CRECDetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIdBanco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCuenta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colImporte = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colSecuencia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExiste = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ChkCorregir = New System.Windows.Forms.CheckBox
        CType(Me.Edit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LecturasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LecturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TaskPane1.SuspendLayout()
        Me.TaskFrame1.SuspendLayout()
        Me.tfValidar.SuspendLayout()
        Me.TaskFrame4.SuspendLayout()
        Me.PanelMotivoDevolucion.SuspendLayout()
        CType(Me.MotivosRechazoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TaskFrame5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.LecturasGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Edit12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Edit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MontoEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.DataRepeater1.ItemTemplate.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        CType(Me.ErroresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TaskPane2.SuspendLayout()
        Me.tfCheque.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.tfCREC.SuspendLayout()
        CType(Me.CRECDetGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRECDetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colcod_tipdoc
        '
        Me.colcod_tipdoc.Caption = "Doc"
        Me.colcod_tipdoc.ColumnEdit = Me.Edit2
        Me.colcod_tipdoc.FieldName = "cod_tipdoc"
        Me.colcod_tipdoc.MinWidth = 30
        Me.colcod_tipdoc.Name = "colcod_tipdoc"
        Me.colcod_tipdoc.Visible = True
        Me.colcod_tipdoc.VisibleIndex = 2
        Me.colcod_tipdoc.Width = 43
        '
        'Edit2
        '
        Me.Edit2.AutoHeight = False
        Me.Edit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Edit2.MaxLength = 2
        Me.Edit2.Name = "Edit2"
        '
        'Worker
        '
        Me.Worker.WorkerReportsProgress = True
        Me.Worker.WorkerSupportsCancellation = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Visión Banco S.A."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LecturasDataGridView
        '
        Me.LecturasDataGridView.AllowUserToOrderColumns = True
        Me.LecturasDataGridView.AutoGenerateColumns = False
        Me.LecturasDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.LecturasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LecturasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnLote, Me.clBanco, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.tbcSerie, Me.clReceptor, Me.DataGridViewTextBoxColumn8, Me.Importe, Me.cod_sucursal, Me.cuenta_deposito, Me.DataGridViewTextBoxColumn12, Me.ConError, Me.IdMotivo, Me.ENVIADO, Me.IdLectura})
        Me.LecturasDataGridView.DataSource = Me.LecturasBindingSource
        Me.LecturasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LecturasDataGridView.Location = New System.Drawing.Point(3, 4)
        Me.LecturasDataGridView.Name = "LecturasDataGridView"
        Me.LecturasDataGridView.RowTemplate.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LecturasDataGridView.Size = New System.Drawing.Size(688, 266)
        Me.LecturasDataGridView.TabIndex = 8
        '
        'ColumnLote
        '
        Me.ColumnLote.AutomaticSortingEnabled = False
        Me.ColumnLote.DataPropertyName = "nro_lote"
        Me.ColumnLote.FilteringEnabled = False
        Me.ColumnLote.HeaderText = "Lote"
        Me.ColumnLote.Name = "ColumnLote"
        Me.ColumnLote.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnLote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColumnLote.Width = 40
        '
        'clBanco
        '
        Me.clBanco.AutomaticSortingEnabled = False
        Me.clBanco.DataPropertyName = "cod_banco_receptor"
        Me.clBanco.FilteringEnabled = False
        Me.clBanco.HeaderText = "Banco"
        Me.clBanco.MaxInputLength = 2
        Me.clBanco.Name = "clBanco"
        Me.clBanco.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clBanco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clBanco.Width = 40
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutomaticSortingEnabled = False
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cod_tipdoc"
        Me.DataGridViewTextBoxColumn4.FilteringEnabled = False
        Me.DataGridViewTextBoxColumn4.HeaderText = "Doc"
        Me.DataGridViewTextBoxColumn4.MaxInputLength = 2
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 40
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutomaticSortingEnabled = False
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "cuenta_cheque"
        DataGridViewCellStyle1.Format = "000000000000"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn5.FilteringEnabled = False
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cuenta"
        Me.DataGridViewTextBoxColumn5.MaxInputLength = 12
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Width = 120
        '
        'tbcSerie
        '
        Me.tbcSerie.AutomaticSortingEnabled = False
        Me.tbcSerie.DataPropertyName = "numero_cheque"
        DataGridViewCellStyle2.Format = "00000000"
        Me.tbcSerie.DefaultCellStyle = DataGridViewCellStyle2
        Me.tbcSerie.FilteringEnabled = False
        Me.tbcSerie.HeaderText = "Serie"
        Me.tbcSerie.MaxInputLength = 8
        Me.tbcSerie.Name = "tbcSerie"
        Me.tbcSerie.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tbcSerie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.tbcSerie.Width = 90
        '
        'clReceptor
        '
        Me.clReceptor.AutomaticSortingEnabled = False
        Me.clReceptor.DataPropertyName = "cod_banco_emisor"
        Me.clReceptor.FilteringEnabled = False
        Me.clReceptor.HeaderText = "Receptor"
        Me.clReceptor.MaxInputLength = 2
        Me.clReceptor.Name = "clReceptor"
        Me.clReceptor.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clReceptor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clReceptor.Width = 40
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutomaticSortingEnabled = False
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "cod_camara"
        Me.DataGridViewTextBoxColumn8.FilteringEnabled = False
        Me.DataGridViewTextBoxColumn8.HeaderText = "Camara"
        Me.DataGridViewTextBoxColumn8.MaxInputLength = 2
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn8.Width = 40
        '
        'Importe
        '
        Me.Importe.DataPropertyName = "monto"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle3
        Me.Importe.FilteringEnabled = False
        Me.Importe.HeaderText = "Importe"
        Me.Importe.MaxInputLength = 12
        Me.Importe.Name = "Importe"
        Me.Importe.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'cod_sucursal
        '
        Me.cod_sucursal.AutomaticSortingEnabled = False
        Me.cod_sucursal.DataPropertyName = "cod_sucursal"
        Me.cod_sucursal.FilteringEnabled = False
        Me.cod_sucursal.HeaderText = "Sucursal"
        Me.cod_sucursal.MaxInputLength = 2
        Me.cod_sucursal.Name = "cod_sucursal"
        Me.cod_sucursal.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cod_sucursal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cod_sucursal.Width = 50
        '
        'cuenta_deposito
        '
        Me.cuenta_deposito.DataPropertyName = "cuenta_deposito"
        Me.cuenta_deposito.FilteringEnabled = False
        Me.cuenta_deposito.HeaderText = "Cta Dep"
        Me.cuenta_deposito.MaxInputLength = 12
        Me.cuenta_deposito.Name = "cuenta_deposito"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "cabecera"
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn12.FilteringEnabled = False
        Me.DataGridViewTextBoxColumn12.HeaderText = "Secuencia"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn12.Width = 60
        '
        'ConError
        '
        Me.ConError.DataPropertyName = "ConError"
        Me.ConError.HeaderText = "Errores"
        Me.ConError.Name = "ConError"
        Me.ConError.ReadOnly = True
        Me.ConError.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'IdMotivo
        '
        Me.IdMotivo.DataPropertyName = "IdMotivo"
        Me.IdMotivo.FilteringEnabled = False
        Me.IdMotivo.HeaderText = "Motivo"
        Me.IdMotivo.MaxInputLength = 2
        Me.IdMotivo.Name = "IdMotivo"
        '
        'ENVIADO
        '
        Me.ENVIADO.DataPropertyName = "ENVIADO"
        Me.ENVIADO.HeaderText = "Editado"
        Me.ENVIADO.Name = "ENVIADO"
        Me.ENVIADO.ReadOnly = True
        Me.ENVIADO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ENVIADO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'IdLectura
        '
        Me.IdLectura.DataPropertyName = "IdLectura"
        Me.IdLectura.FilteringEnabled = False
        Me.IdLectura.HeaderText = "IdLectura"
        Me.IdLectura.Name = "IdLectura"
        Me.IdLectura.ReadOnly = True
        Me.IdLectura.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdLectura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'LecturasBindingSource
        '
        Me.LecturasBindingSource.DataSource = GetType(DataAccess.Lecturas)
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuInsertar, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 70)
        '
        'cmnuInsertar
        '
        Me.cmnuInsertar.Image = Global.HostVB.My.Resources.Resources.VSProject_generatedfile
        Me.cmnuInsertar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmnuInsertar.Name = "cmnuInsertar"
        Me.cmnuInsertar.Size = New System.Drawing.Size(117, 22)
        Me.cmnuInsertar.Text = "&Insertar"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.HostVB.My.Resources.Resources.EditTableHS
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem.Text = "&Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.HostVB.My.Resources.Resources.delete
        Me.EliminarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "E&liminar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbIniciarCaptura, Me.ToolStripButton1, Me.tsbErrores, Me.ToolStripButton2, Me.ToolStripButton3, Me.tsEliminar, Me.tsbCargar, Me.tsbDescargar, Me.ToolStripButton6, Me.cmdImportar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(899, 38)
        Me.ToolStrip1.TabIndex = 31
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbIniciarCaptura
        '
        Me.tsbIniciarCaptura.Image = CType(resources.GetObject("tsbIniciarCaptura.Image"), System.Drawing.Image)
        Me.tsbIniciarCaptura.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbIniciarCaptura.Name = "tsbIniciarCaptura"
        Me.tsbIniciarCaptura.Size = New System.Drawing.Size(88, 35)
        Me.tsbIniciarCaptura.Text = "Iniciar Captura"
        Me.tsbIniciarCaptura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbIniciarCaptura.ToolTipText = "Iniciar Captura (F5)"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(47, 35)
        Me.ToolStripButton1.Text = "Validar"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton1.ToolTipText = "Validar (F8)"
        '
        'tsbErrores
        '
        Me.tsbErrores.Image = CType(resources.GetObject("tsbErrores.Image"), System.Drawing.Image)
        Me.tsbErrores.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbErrores.Name = "tsbErrores"
        Me.tsbErrores.Size = New System.Drawing.Size(47, 35)
        Me.tsbErrores.Text = "Errores"
        Me.tsbErrores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbErrores.ToolTipText = "Errores (F9)"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.HostVB.My.Resources.Resources.VSProject_generatedfile
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(50, 35)
        Me.ToolStripButton2.Text = "Insertar"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton2.ToolTipText = "Insertar (Ctrl + Ins)"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.HostVB.My.Resources.Resources.EditTableHS
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(41, 35)
        Me.ToolStripButton3.Text = "Editar"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton3.ToolTipText = "Editar (Ctrl + Enter)"
        '
        'tsEliminar
        '
        Me.tsEliminar.Image = Global.HostVB.My.Resources.Resources.delete
        Me.tsEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEliminar.Name = "tsEliminar"
        Me.tsEliminar.Size = New System.Drawing.Size(54, 35)
        Me.tsEliminar.Text = "Eliminar"
        Me.tsEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbCargar
        '
        Me.tsbCargar.Image = Global.HostVB.My.Resources.Resources.database
        Me.tsbCargar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCargar.Name = "tsbCargar"
        Me.tsbCargar.Size = New System.Drawing.Size(49, 35)
        Me.tsbCargar.Text = "Cargar "
        Me.tsbCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbDescargar
        '
        Me.tsbDescargar.Image = Global.HostVB.My.Resources.Resources.database_read_only
        Me.tsbDescargar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDescargar.Name = "tsbDescargar"
        Me.tsbDescargar.Size = New System.Drawing.Size(63, 35)
        Me.tsbDescargar.Text = "Descargar"
        Me.tsbDescargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = Global.HostVB.My.Resources.Resources.TableHS
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(54, 35)
        Me.ToolStripButton6.Text = "Exportar"
        Me.ToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdImportar
        '
        Me.cmdImportar.Image = CType(resources.GetObject("cmdImportar.Image"), System.Drawing.Image)
        Me.cmdImportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImportar.Name = "cmdImportar"
        Me.cmdImportar.Size = New System.Drawing.Size(40, 35)
        Me.cmdImportar.Text = "CREC"
        Me.cmdImportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdImportar.ToolTipText = "Importar CREC"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtBuscar, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cboBuscar, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lnkBuscar, 0, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(163, 75)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.Location = New System.Drawing.Point(3, 3)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(157, 20)
        Me.txtBuscar.TabIndex = 1
        '
        'cboBuscar
        '
        Me.cboBuscar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuscar.FormattingEnabled = True
        Me.cboBuscar.Items.AddRange(New Object() {"Cuenta", "Numero", "Importe"})
        Me.cboBuscar.Location = New System.Drawing.Point(3, 29)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(157, 21)
        Me.cboBuscar.TabIndex = 2
        '
        'lnkBuscar
        '
        Me.lnkBuscar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkBuscar.AutoSize = True
        Me.lnkBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lnkBuscar.Location = New System.Drawing.Point(3, 53)
        Me.lnkBuscar.Name = "lnkBuscar"
        Me.lnkBuscar.Size = New System.Drawing.Size(157, 22)
        Me.lnkBuscar.TabIndex = 4
        Me.lnkBuscar.TabStop = True
        Me.lnkBuscar.Text = "Buscar"
        '
        'TaskPane1
        '
        Me.TaskPane1.AutoScroll = True
        Me.TaskPane1.AutoScrollMinSize = New System.Drawing.Size(0, 649)
        Me.TaskPane1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TaskPane1.Controls.Add(Me.TaskFrame1)
        Me.TaskPane1.Controls.Add(Me.tfValidar)
        Me.TaskPane1.Controls.Add(Me.TaskFrame4)
        Me.TaskPane1.Controls.Add(Me.TaskFrame5)
        Me.TaskPane1.CornerStyle = WindowsControlLibrary.TaskFrameCornerStyle.SystemDefault
        Me.TaskPane1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TaskPane1.Location = New System.Drawing.Point(694, 38)
        Me.TaskPane1.Name = "TaskPane1"
        Me.TaskPane1.Size = New System.Drawing.Size(205, 581)
        Me.TaskPane1.TabIndex = 34
        '
        'TaskFrame1
        '
        Me.TaskFrame1.AllowDrop = True
        Me.TaskFrame1.AutoSize = True
        Me.TaskFrame1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TaskFrame1.CaptionBlend = New WindowsControlLibrary.BlendFill(WindowsControlLibrary.BlendStyle.Horizontal, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(230, Byte), Integer)))
        Me.TaskFrame1.Controls.Add(Me.TableLayoutPanel2)
        Me.TaskFrame1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TaskFrame1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.TaskFrame1.IsExpanded = False
        Me.TaskFrame1.Location = New System.Drawing.Point(12, 33)
        Me.TaskFrame1.Name = "TaskFrame1"
        Me.TaskFrame1.Size = New System.Drawing.Size(163, 75)
        Me.TaskFrame1.TabIndex = 1
        Me.TaskFrame1.Text = "Busqueda"
        '
        'tfValidar
        '
        Me.tfValidar.AllowDrop = True
        Me.tfValidar.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tfValidar.CaptionBlend = New WindowsControlLibrary.BlendFill(WindowsControlLibrary.BlendStyle.Horizontal, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(230, Byte), Integer)))
        Me.tfValidar.Controls.Add(Me.LinkLabel2)
        Me.tfValidar.Controls.Add(Me.chkFiltraError)
        Me.tfValidar.Controls.Add(Me.LinkLabel1)
        Me.tfValidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tfValidar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.tfValidar.Location = New System.Drawing.Point(12, 141)
        Me.tfValidar.Name = "TaskFrame2"
        Me.tfValidar.Size = New System.Drawing.Size(163, 80)
        Me.tfValidar.TabIndex = 3
        Me.tfValidar.Text = "Validaciones y Errores"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(3, 43)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(110, 13)
        Me.LinkLabel2.TabIndex = 4
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Verificar repetidos"
        '
        'chkFiltraError
        '
        Me.chkFiltraError.AutoSize = True
        Me.chkFiltraError.Location = New System.Drawing.Point(6, 23)
        Me.chkFiltraError.Name = "chkFiltraError"
        Me.chkFiltraError.Size = New System.Drawing.Size(102, 17)
        Me.chkFiltraError.TabIndex = 3
        Me.chkFiltraError.Text = "Filtrar Errores"
        Me.chkFiltraError.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 7)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(83, 13)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Validar Datos"
        '
        'TaskFrame4
        '
        Me.TaskFrame4.AllowDrop = True
        Me.TaskFrame4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TaskFrame4.CaptionBlend = New WindowsControlLibrary.BlendFill(WindowsControlLibrary.BlendStyle.Horizontal, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(230, Byte), Integer)))
        Me.TaskFrame4.Controls.Add(Me.PanelMotivoDevolucion)
        Me.TaskFrame4.Controls.Add(Me.lnkReasignar)
        Me.TaskFrame4.Controls.Add(Me.txtSucursal)
        Me.TaskFrame4.Controls.Add(Me.nudLote)
        Me.TaskFrame4.Controls.Add(Me.lnkSucursal)
        Me.TaskFrame4.Controls.Add(Me.Label1)
        Me.TaskFrame4.Controls.Add(Me.cboCajero)
        Me.TaskFrame4.Controls.Add(Me.Label6)
        Me.TaskFrame4.Controls.Add(Me.cboSucursal)
        Me.TaskFrame4.Controls.Add(Me.Label3)
        Me.TaskFrame4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TaskFrame4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.TaskFrame4.Location = New System.Drawing.Point(12, 254)
        Me.TaskFrame4.Name = "TaskFrame4"
        Me.TaskFrame4.Size = New System.Drawing.Size(163, 250)
        Me.TaskFrame4.TabIndex = 7
        Me.TaskFrame4.Text = "Opciones"
        '
        'PanelMotivoDevolucion
        '
        Me.PanelMotivoDevolucion.Controls.Add(Me.txtMotivo)
        Me.PanelMotivoDevolucion.Controls.Add(Me.lnkMotivo)
        Me.PanelMotivoDevolucion.Controls.Add(Me.cboMotivo)
        Me.PanelMotivoDevolucion.Controls.Add(Me.Label8)
        Me.PanelMotivoDevolucion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelMotivoDevolucion.Location = New System.Drawing.Point(0, 166)
        Me.PanelMotivoDevolucion.Name = "PanelMotivoDevolucion"
        Me.PanelMotivoDevolucion.Size = New System.Drawing.Size(163, 84)
        Me.PanelMotivoDevolucion.TabIndex = 6
        '
        'txtMotivo
        '
        Me.txtMotivo.AcceptsReturn = True
        Me.txtMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtMotivo.Location = New System.Drawing.Point(4, 27)
        Me.txtMotivo.MaxLength = 3
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(31, 29)
        Me.txtMotivo.TabIndex = 9
        '
        'lnkMotivo
        '
        Me.lnkMotivo.AutoEllipsis = True
        Me.lnkMotivo.AutoSize = True
        Me.lnkMotivo.Location = New System.Drawing.Point(-2, 62)
        Me.lnkMotivo.Name = "lnkMotivo"
        Me.lnkMotivo.Size = New System.Drawing.Size(145, 13)
        Me.lnkMotivo.TabIndex = 8
        Me.lnkMotivo.TabStop = True
        Me.lnkMotivo.Text = "Asignar al Motivo Actual"
        '
        'cboMotivo
        '
        Me.cboMotivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMotivo.DataSource = Me.MotivosRechazoBindingSource
        Me.cboMotivo.DisplayMember = "Motivo"
        Me.cboMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboMotivo.FormattingEnabled = True
        Me.cboMotivo.Location = New System.Drawing.Point(37, 27)
        Me.cboMotivo.Name = "cboMotivo"
        Me.cboMotivo.Size = New System.Drawing.Size(126, 21)
        Me.cboMotivo.TabIndex = 7
        Me.cboMotivo.ValueMember = "IdMotivo"
        '
        'MotivosRechazoBindingSource
        '
        Me.MotivosRechazoBindingSource.DataSource = GetType(ClearingDA.MotivosRechazo)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Motivo Devolucion"
        '
        'lnkReasignar
        '
        Me.lnkReasignar.AutoEllipsis = True
        Me.lnkReasignar.AutoSize = True
        Me.lnkReasignar.Location = New System.Drawing.Point(0, 27)
        Me.lnkReasignar.Name = "lnkReasignar"
        Me.lnkReasignar.Size = New System.Drawing.Size(179, 13)
        Me.lnkReasignar.TabIndex = 2
        Me.lnkReasignar.TabStop = True
        Me.lnkReasignar.Text = "Asignar registros al lote actual"
        '
        'txtSucursal
        '
        Me.txtSucursal.AcceptsReturn = True
        Me.txtSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtSucursal.Location = New System.Drawing.Point(3, 66)
        Me.txtSucursal.MaxLength = 2
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(31, 29)
        Me.txtSucursal.TabIndex = 5
        '
        'nudLote
        '
        Me.nudLote.Location = New System.Drawing.Point(116, 4)
        Me.nudLote.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudLote.Name = "nudLote"
        Me.nudLote.Size = New System.Drawing.Size(44, 20)
        Me.nudLote.TabIndex = 1
        '
        'lnkSucursal
        '
        Me.lnkSucursal.AutoEllipsis = True
        Me.lnkSucursal.AutoSize = True
        Me.lnkSucursal.Location = New System.Drawing.Point(-3, 101)
        Me.lnkSucursal.Name = "lnkSucursal"
        Me.lnkSucursal.Size = New System.Drawing.Size(167, 13)
        Me.lnkSucursal.TabIndex = 4
        Me.lnkSucursal.TabStop = True
        Me.lnkSucursal.Text = "Asignar a la Sucursal Actual"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lote actual"
        '
        'cboCajero
        '
        Me.cboCajero.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCajero.FormattingEnabled = True
        Me.cboCajero.Location = New System.Drawing.Point(0, 139)
        Me.cboCajero.Name = "cboCajero"
        Me.cboCajero.Size = New System.Drawing.Size(161, 21)
        Me.cboCajero.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(0, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Cajero"
        '
        'cboSucursal
        '
        Me.cboSucursal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSucursal.DataSource = Me.SucursalesBindingSource
        Me.cboSucursal.DisplayMember = "nombre_sucusal"
        Me.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSucursal.FormattingEnabled = True
        Me.cboSucursal.Location = New System.Drawing.Point(36, 66)
        Me.cboSucursal.Name = "cboSucursal"
        Me.cboSucursal.Size = New System.Drawing.Size(126, 21)
        Me.cboSucursal.TabIndex = 1
        Me.cboSucursal.ValueMember = "cod_sucursal"
        '
        'SucursalesBindingSource
        '
        Me.SucursalesBindingSource.DataSource = GetType(DataAccess.Sucursales)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sucursal"
        '
        'TaskFrame5
        '
        Me.TaskFrame5.AllowDrop = True
        Me.TaskFrame5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TaskFrame5.CaptionBlend = New WindowsControlLibrary.BlendFill(WindowsControlLibrary.BlendStyle.Horizontal, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(230, Byte), Integer)))
        Me.TaskFrame5.Controls.Add(Me.lnkFecha)
        Me.TaskFrame5.Controls.Add(Me.lblDIF)
        Me.TaskFrame5.Controls.Add(Me.Label9)
        Me.TaskFrame5.Controls.Add(Me.lblCHQCant)
        Me.TaskFrame5.Controls.Add(Me.lblCHQ)
        Me.TaskFrame5.Controls.Add(Me.lblCABCant)
        Me.TaskFrame5.Controls.Add(Me.lblCAB)
        Me.TaskFrame5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TaskFrame5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.TaskFrame5.Location = New System.Drawing.Point(12, 537)
        Me.TaskFrame5.Name = "TaskFrame5"
        Me.TaskFrame5.Size = New System.Drawing.Size(163, 100)
        Me.TaskFrame5.TabIndex = 9
        Me.TaskFrame5.Text = "Totales"
        '
        'lnkFecha
        '
        Me.lnkFecha.AutoSize = True
        Me.lnkFecha.Location = New System.Drawing.Point(5, 87)
        Me.lnkFecha.Name = "lnkFecha"
        Me.lnkFecha.Size = New System.Drawing.Size(69, 13)
        Me.lnkFecha.TabIndex = 6
        Me.lnkFecha.TabStop = True
        Me.lnkFecha.Text = "LinkLabel3"
        '
        'lblDIF
        '
        Me.lblDIF.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDIF.AutoSize = True
        Me.lblDIF.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblDIF.ForeColor = System.Drawing.Color.Black
        Me.lblDIF.Location = New System.Drawing.Point(60, 64)
        Me.lblDIF.Name = "lblDIF"
        Me.lblDIF.Size = New System.Drawing.Size(14, 13)
        Me.lblDIF.TabIndex = 5
        Me.lblDIF.Text = "0"
        Me.lblDIF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(0, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "DIF"
        '
        'lblCHQCant
        '
        Me.lblCHQCant.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCHQCant.AutoSize = True
        Me.lblCHQCant.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblCHQCant.ForeColor = System.Drawing.Color.Black
        Me.lblCHQCant.Location = New System.Drawing.Point(60, 38)
        Me.lblCHQCant.Name = "lblCHQCant"
        Me.lblCHQCant.Size = New System.Drawing.Size(14, 13)
        Me.lblCHQCant.TabIndex = 3
        Me.lblCHQCant.Text = "0"
        Me.lblCHQCant.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCHQ
        '
        Me.lblCHQ.AutoSize = True
        Me.lblCHQ.ForeColor = System.Drawing.Color.Black
        Me.lblCHQ.Location = New System.Drawing.Point(0, 38)
        Me.lblCHQ.Name = "lblCHQ"
        Me.lblCHQ.Size = New System.Drawing.Size(33, 13)
        Me.lblCHQ.TabIndex = 2
        Me.lblCHQ.Text = "CHQ"
        '
        'lblCABCant
        '
        Me.lblCABCant.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCABCant.AutoEllipsis = True
        Me.lblCABCant.AutoSize = True
        Me.lblCABCant.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblCABCant.ForeColor = System.Drawing.Color.Black
        Me.lblCABCant.Location = New System.Drawing.Point(60, 11)
        Me.lblCABCant.Name = "lblCABCant"
        Me.lblCABCant.Size = New System.Drawing.Size(14, 13)
        Me.lblCABCant.TabIndex = 1
        Me.lblCABCant.Text = "0"
        Me.lblCABCant.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCAB
        '
        Me.lblCAB.AutoSize = True
        Me.lblCAB.ForeColor = System.Drawing.Color.Black
        Me.lblCAB.Location = New System.Drawing.Point(0, 11)
        Me.lblCAB.Name = "lblCAB"
        Me.lblCAB.Size = New System.Drawing.Size(31, 13)
        Me.lblCAB.TabIndex = 0
        Me.lblCAB.Text = "CAB"
        '
        'lnkValidarCREC
        '
        Me.lnkValidarCREC.AutoSize = True
        Me.lnkValidarCREC.Location = New System.Drawing.Point(522, 4)
        Me.lnkValidarCREC.Name = "lnkValidarCREC"
        Me.lnkValidarCREC.Size = New System.Drawing.Size(91, 13)
        Me.lnkValidarCREC.TabIndex = 5
        Me.lnkValidarCREC.TabStop = True
        Me.lnkValidarCREC.Text = "Verificar CREC"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.LecturasGridControl, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.LecturasDataGridView, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.MenuStrip1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DataRepeater1, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.TaskPane2, 0, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 38)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 6
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(694, 581)
        Me.TableLayoutPanel3.TabIndex = 35
        '
        'LecturasGridControl
        '
        Me.LecturasGridControl.DataSource = Me.LecturasBindingSource
        Me.LecturasGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LecturasGridControl.Location = New System.Drawing.Point(3, 276)
        Me.LecturasGridControl.MainView = Me.GridView1
        Me.LecturasGridControl.Name = "LecturasGridControl"
        Me.LecturasGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Edit2, Me.Edit12, Me.Edit8, Me.MontoEditor})
        Me.LecturasGridControl.Size = New System.Drawing.Size(688, 220)
        Me.LecturasGridControl.TabIndex = 36
        Me.LecturasGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnro_lote, Me.colcod_banco_receptor, Me.colcod_tipdoc, Me.colcuenta_cheque, Me.colnumero_cheque, Me.colcod_banco_emisor, Me.colcod_camara, Me.colmonto, Me.colcod_sucursal, Me.colcuenta_deposito, Me.colcabecera, Me.colConError, Me.colIdMotivo, Me.colENVIADO, Me.colIdLectura, Me.colcadena_captura})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Navy
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colcod_tipdoc
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Expression = "Cod_Tipdoc=""90"""
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GridView1.GridControl = Me.LecturasGridControl
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "monto", Me.colmonto, "", 1)})
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colnro_lote
        '
        Me.colnro_lote.Caption = "Lote"
        Me.colnro_lote.FieldName = "nro_lote"
        Me.colnro_lote.MinWidth = 30
        Me.colnro_lote.Name = "colnro_lote"
        Me.colnro_lote.OptionsColumn.AllowEdit = False
        Me.colnro_lote.Visible = True
        Me.colnro_lote.VisibleIndex = 0
        Me.colnro_lote.Width = 41
        '
        'colcod_banco_receptor
        '
        Me.colcod_banco_receptor.Caption = "Banco"
        Me.colcod_banco_receptor.ColumnEdit = Me.Edit2
        Me.colcod_banco_receptor.FieldName = "cod_banco_receptor"
        Me.colcod_banco_receptor.MinWidth = 30
        Me.colcod_banco_receptor.Name = "colcod_banco_receptor"
        Me.colcod_banco_receptor.Visible = True
        Me.colcod_banco_receptor.VisibleIndex = 1
        Me.colcod_banco_receptor.Width = 43
        '
        'colcuenta_cheque
        '
        Me.colcuenta_cheque.Caption = "Cuenta"
        Me.colcuenta_cheque.ColumnEdit = Me.Edit12
        Me.colcuenta_cheque.FieldName = "cuenta_cheque"
        Me.colcuenta_cheque.MinWidth = 50
        Me.colcuenta_cheque.Name = "colcuenta_cheque"
        Me.colcuenta_cheque.Visible = True
        Me.colcuenta_cheque.VisibleIndex = 3
        Me.colcuenta_cheque.Width = 53
        '
        'Edit12
        '
        Me.Edit12.AutoHeight = False
        Me.Edit12.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Edit12.Mask.EditMask = "000000000000"
        Me.Edit12.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Edit12.Mask.UseMaskAsDisplayFormat = True
        Me.Edit12.MaxLength = 12
        Me.Edit12.Name = "Edit12"
        '
        'colnumero_cheque
        '
        Me.colnumero_cheque.Caption = "Serie"
        Me.colnumero_cheque.ColumnEdit = Me.Edit8
        Me.colnumero_cheque.FieldName = "numero_cheque"
        Me.colnumero_cheque.MinWidth = 40
        Me.colnumero_cheque.Name = "colnumero_cheque"
        Me.colnumero_cheque.Visible = True
        Me.colnumero_cheque.VisibleIndex = 4
        Me.colnumero_cheque.Width = 53
        '
        'Edit8
        '
        Me.Edit8.AutoHeight = False
        Me.Edit8.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Edit8.Mask.BeepOnError = True
        Me.Edit8.Mask.EditMask = "00000000"
        Me.Edit8.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Edit8.Mask.UseMaskAsDisplayFormat = True
        Me.Edit8.MaxLength = 8
        Me.Edit8.Name = "Edit8"
        '
        'colcod_banco_emisor
        '
        Me.colcod_banco_emisor.Caption = "Receptor"
        Me.colcod_banco_emisor.ColumnEdit = Me.Edit2
        Me.colcod_banco_emisor.FieldName = "cod_banco_emisor"
        Me.colcod_banco_emisor.MinWidth = 30
        Me.colcod_banco_emisor.Name = "colcod_banco_emisor"
        Me.colcod_banco_emisor.Visible = True
        Me.colcod_banco_emisor.VisibleIndex = 5
        Me.colcod_banco_emisor.Width = 31
        '
        'colcod_camara
        '
        Me.colcod_camara.Caption = "Camara"
        Me.colcod_camara.ColumnEdit = Me.Edit2
        Me.colcod_camara.FieldName = "cod_camara"
        Me.colcod_camara.MinWidth = 30
        Me.colcod_camara.Name = "colcod_camara"
        Me.colcod_camara.Visible = True
        Me.colcod_camara.VisibleIndex = 6
        Me.colcod_camara.Width = 43
        '
        'colmonto
        '
        Me.colmonto.Caption = "Importe"
        Me.colmonto.ColumnEdit = Me.MontoEditor
        Me.colmonto.DisplayFormat.FormatString = "N0"
        Me.colmonto.FieldName = "monto"
        Me.colmonto.MinWidth = 50
        Me.colmonto.Name = "colmonto"
        Me.colmonto.SummaryItem.DisplayFormat = "{0:N0}"
        Me.colmonto.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
        Me.colmonto.SummaryItem.Tag = 1
        Me.colmonto.Visible = True
        Me.colmonto.VisibleIndex = 7
        Me.colmonto.Width = 53
        '
        'MontoEditor
        '
        Me.MontoEditor.AutoHeight = False
        Me.MontoEditor.DisplayFormat.FormatString = "N0"
        Me.MontoEditor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MontoEditor.EditFormat.FormatString = "N0"
        Me.MontoEditor.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MontoEditor.Mask.EditMask = "N0"
        Me.MontoEditor.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.MontoEditor.Mask.UseMaskAsDisplayFormat = True
        Me.MontoEditor.Name = "MontoEditor"
        '
        'colcod_sucursal
        '
        Me.colcod_sucursal.Caption = "Suc"
        Me.colcod_sucursal.ColumnEdit = Me.Edit2
        Me.colcod_sucursal.FieldName = "cod_sucursal"
        Me.colcod_sucursal.MinWidth = 30
        Me.colcod_sucursal.Name = "colcod_sucursal"
        Me.colcod_sucursal.Visible = True
        Me.colcod_sucursal.VisibleIndex = 8
        Me.colcod_sucursal.Width = 37
        '
        'colcuenta_deposito
        '
        Me.colcuenta_deposito.Caption = "Cta. Dep"
        Me.colcuenta_deposito.ColumnEdit = Me.Edit12
        Me.colcuenta_deposito.FieldName = "cuenta_deposito"
        Me.colcuenta_deposito.MinWidth = 40
        Me.colcuenta_deposito.Name = "colcuenta_deposito"
        Me.colcuenta_deposito.Visible = True
        Me.colcuenta_deposito.VisibleIndex = 9
        Me.colcuenta_deposito.Width = 51
        '
        'colcabecera
        '
        Me.colcabecera.Caption = "Secuencia"
        Me.colcabecera.FieldName = "cabecera"
        Me.colcabecera.MinWidth = 30
        Me.colcabecera.Name = "colcabecera"
        Me.colcabecera.OptionsColumn.AllowEdit = False
        Me.colcabecera.Visible = True
        Me.colcabecera.VisibleIndex = 10
        Me.colcabecera.Width = 43
        '
        'colConError
        '
        Me.colConError.Caption = "Errores"
        Me.colConError.FieldName = "ConError"
        Me.colConError.MinWidth = 30
        Me.colConError.Name = "colConError"
        Me.colConError.OptionsColumn.AllowEdit = False
        Me.colConError.Visible = True
        Me.colConError.VisibleIndex = 11
        Me.colConError.Width = 30
        '
        'colIdMotivo
        '
        Me.colIdMotivo.Caption = "Motivo"
        Me.colIdMotivo.FieldName = "IdMotivo"
        Me.colIdMotivo.MinWidth = 30
        Me.colIdMotivo.Name = "colIdMotivo"
        Me.colIdMotivo.Visible = True
        Me.colIdMotivo.VisibleIndex = 12
        Me.colIdMotivo.Width = 36
        '
        'colENVIADO
        '
        Me.colENVIADO.Caption = "Editado"
        Me.colENVIADO.FieldName = "ENVIADO"
        Me.colENVIADO.MinWidth = 30
        Me.colENVIADO.Name = "colENVIADO"
        Me.colENVIADO.OptionsColumn.AllowEdit = False
        Me.colENVIADO.Visible = True
        Me.colENVIADO.VisibleIndex = 13
        Me.colENVIADO.Width = 52
        '
        'colIdLectura
        '
        Me.colIdLectura.Caption = "IdLectura"
        Me.colIdLectura.FieldName = "IdLectura"
        Me.colIdLectura.MinWidth = 30
        Me.colIdLectura.Name = "colIdLectura"
        Me.colIdLectura.OptionsColumn.AllowEdit = False
        Me.colIdLectura.Visible = True
        Me.colIdLectura.VisibleIndex = 14
        Me.colIdLectura.Width = 40
        '
        'colcadena_captura
        '
        Me.colcadena_captura.Caption = "Cadena"
        Me.colcadena_captura.FieldName = "cadena_captura"
        Me.colcadena_captura.Name = "colcadena_captura"
        Me.colcadena_captura.OptionsColumn.AllowEdit = False
        Me.colcadena_captura.Visible = True
        Me.colcadena_captura.VisibleIndex = 15
        Me.colcadena_captura.Width = 24
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 533)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(688, 25)
        Me.Panel1.TabIndex = 33
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblSubTotalCab)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtSubTotalCab)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblSubTotalDet)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtSubTotalDet)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblSubDif)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtSubDif)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblError)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtErrores)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(688, 25)
        Me.FlowLayoutPanel1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Sub Totales"
        '
        'lblSubTotalCab
        '
        Me.lblSubTotalCab.AutoSize = True
        Me.lblSubTotalCab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotalCab.Location = New System.Drawing.Point(84, 0)
        Me.lblSubTotalCab.Name = "lblSubTotalCab"
        Me.lblSubTotalCab.Size = New System.Drawing.Size(33, 13)
        Me.lblSubTotalCab.TabIndex = 3
        Me.lblSubTotalCab.Text = "Cab."
        '
        'txtSubTotalCab
        '
        Me.txtSubTotalCab.AutoSize = True
        Me.txtSubTotalCab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubTotalCab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotalCab.Location = New System.Drawing.Point(123, 0)
        Me.txtSubTotalCab.Name = "txtSubTotalCab"
        Me.txtSubTotalCab.Size = New System.Drawing.Size(16, 15)
        Me.txtSubTotalCab.TabIndex = 10
        Me.txtSubTotalCab.Text = "0"
        '
        'lblSubTotalDet
        '
        Me.lblSubTotalDet.AutoSize = True
        Me.lblSubTotalDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotalDet.Location = New System.Drawing.Point(145, 0)
        Me.lblSubTotalDet.Name = "lblSubTotalDet"
        Me.lblSubTotalDet.Size = New System.Drawing.Size(31, 13)
        Me.lblSubTotalDet.TabIndex = 5
        Me.lblSubTotalDet.Text = "Det."
        '
        'txtSubTotalDet
        '
        Me.txtSubTotalDet.AutoSize = True
        Me.txtSubTotalDet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubTotalDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotalDet.Location = New System.Drawing.Point(182, 0)
        Me.txtSubTotalDet.Name = "txtSubTotalDet"
        Me.txtSubTotalDet.Size = New System.Drawing.Size(16, 15)
        Me.txtSubTotalDet.TabIndex = 9
        Me.txtSubTotalDet.Text = "0"
        '
        'lblSubDif
        '
        Me.lblSubDif.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSubDif.AutoSize = True
        Me.lblSubDif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubDif.Location = New System.Drawing.Point(204, 0)
        Me.lblSubDif.Name = "lblSubDif"
        Me.lblSubDif.Size = New System.Drawing.Size(27, 15)
        Me.lblSubDif.TabIndex = 11
        Me.lblSubDif.Text = "Dif."
        '
        'txtSubDif
        '
        Me.txtSubDif.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubDif.AutoSize = True
        Me.txtSubDif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubDif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubDif.Location = New System.Drawing.Point(237, 0)
        Me.txtSubDif.Name = "txtSubDif"
        Me.txtSubDif.Size = New System.Drawing.Size(16, 15)
        Me.txtSubDif.TabIndex = 12
        Me.txtSubDif.Text = "0"
        '
        'lblError
        '
        Me.lblError.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Location = New System.Drawing.Point(259, 0)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(47, 15)
        Me.lblError.TabIndex = 7
        Me.lblError.Text = "Errores"
        '
        'txtErrores
        '
        Me.txtErrores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtErrores.AutoSize = True
        Me.txtErrores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtErrores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtErrores.Location = New System.Drawing.Point(312, 0)
        Me.txtErrores.Name = "txtErrores"
        Me.txtErrores.Size = New System.Drawing.Size(16, 15)
        Me.txtErrores.TabIndex = 8
        Me.txtErrores.Text = "0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LecturasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(71, 1)
        Me.MenuStrip1.TabIndex = 34
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LecturasToolStripMenuItem
        '
        Me.LecturasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciarCapturaToolStripMenuItem, Me.ToolStripMenuItem1, Me.InsertarToolStripMenuItem, Me.EditarToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ValidarToolStripMenuItem, Me.FiltrarErroresToolStripMenuItem})
        Me.LecturasToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.LecturasToolStripMenuItem.MergeIndex = 3
        Me.LecturasToolStripMenuItem.Name = "LecturasToolStripMenuItem"
        Me.LecturasToolStripMenuItem.Size = New System.Drawing.Size(63, 0)
        Me.LecturasToolStripMenuItem.Text = "Lecturas"
        '
        'IniciarCapturaToolStripMenuItem
        '
        Me.IniciarCapturaToolStripMenuItem.Name = "IniciarCapturaToolStripMenuItem"
        Me.IniciarCapturaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.IniciarCapturaToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.IniciarCapturaToolStripMenuItem.Text = "Iniciar Captura"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(167, 6)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Insert), System.Windows.Forms.Keys)
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.InsertarToolStripMenuItem.Text = "Insertar"
        '
        'EditarToolStripMenuItem1
        '
        Me.EditarToolStripMenuItem1.Name = "EditarToolStripMenuItem1"
        Me.EditarToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)
        Me.EditarToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.EditarToolStripMenuItem1.Text = "Editar"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(167, 6)
        '
        'ValidarToolStripMenuItem
        '
        Me.ValidarToolStripMenuItem.Name = "ValidarToolStripMenuItem"
        Me.ValidarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.ValidarToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ValidarToolStripMenuItem.Text = "Validar"
        '
        'FiltrarErroresToolStripMenuItem
        '
        Me.FiltrarErroresToolStripMenuItem.Name = "FiltrarErroresToolStripMenuItem"
        Me.FiltrarErroresToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.FiltrarErroresToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.FiltrarErroresToolStripMenuItem.Text = "Filtrar Errores"
        '
        'DataRepeater1
        '
        Me.DataRepeater1.AllowUserToAddItems = False
        Me.DataRepeater1.AllowUserToDeleteItems = False
        Me.DataRepeater1.DataSource = Me.ErroresBindingSource
        Me.DataRepeater1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataRepeater1.ItemHeaderVisible = False
        '
        'DataRepeater1.ItemTemplate
        '
        Me.DataRepeater1.ItemTemplate.AutoSize = True
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Label7)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Label5)
        Me.DataRepeater1.ItemTemplate.Size = New System.Drawing.Size(663, 20)
        Me.DataRepeater1.Location = New System.Drawing.Point(3, 564)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(688, 14)
        Me.DataRepeater1.TabIndex = 35
        Me.DataRepeater1.Text = "DataRepeater1"
        '
        'ErroresBindingSource
        '
        Me.ErroresBindingSource.AllowNew = False
        Me.ErroresBindingSource.DataMember = "Errores"
        Me.ErroresBindingSource.DataSource = Me.LecturasBindingSource
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ErroresBindingSource, "Codigo", True))
        Me.Label7.Location = New System.Drawing.Point(3, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Label7"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ErroresBindingSource, "Error", True))
        Me.Label5.Location = New System.Drawing.Point(48, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Label5"
        '
        'TaskPane2
        '
        Me.TaskPane2.AutoScroll = True
        Me.TaskPane2.AutoScrollMinSize = New System.Drawing.Size(0, 564)
        Me.TaskPane2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TaskPane2.Controls.Add(Me.tfCheque)
        Me.TaskPane2.Controls.Add(Me.tfCREC)
        Me.TaskPane2.CornerStyle = WindowsControlLibrary.TaskFrameCornerStyle.SystemDefault
        Me.TaskPane2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TaskPane2.Location = New System.Drawing.Point(3, 502)
        Me.TaskPane2.Name = "TaskPane2"
        Me.TaskPane2.Padding = 0
        Me.TaskPane2.Size = New System.Drawing.Size(688, 25)
        Me.TaskPane2.TabIndex = 36
        '
        'tfCheque
        '
        Me.tfCheque.AllowDrop = True
        Me.tfCheque.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tfCheque.CaptionBlend = New WindowsControlLibrary.BlendFill(WindowsControlLibrary.BlendStyle.Horizontal, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(230, Byte), Integer)))
        Me.tfCheque.Controls.Add(Me.TableLayoutPanel4)
        Me.tfCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tfCheque.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.tfCheque.IsExpanded = False
        Me.tfCheque.Location = New System.Drawing.Point(0, -279)
        Me.tfCheque.Name = "tfCheque"
        Me.tfCheque.Size = New System.Drawing.Size(670, 250)
        Me.tfCheque.TabIndex = 1
        Me.tfCheque.Text = "Imagen del cheque"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.ImagenBase1, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(670, 250)
        Me.TableLayoutPanel4.TabIndex = 8
        '
        'ImagenBase1
        '
        Me.ImagenBase1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImagenBase1.Imagen = Nothing
        Me.ImagenBase1.Location = New System.Drawing.Point(3, 3)
        Me.ImagenBase1.MaximumSize = New System.Drawing.Size(700, 400)
        Me.ImagenBase1.MinimumSize = New System.Drawing.Size(200, 150)
        Me.ImagenBase1.Name = "ImagenBase1"
        Me.ImagenBase1.NombreImagen = Nothing
        Me.ImagenBase1.PosicionMenu = HostVB.ImagenBase.Posicion.Bottom
        Me.ImagenBase1.Size = New System.Drawing.Size(664, 244)
        Me.ImagenBase1.TabIndex = 0
        '
        'tfCREC
        '
        Me.tfCREC.AllowDrop = True
        Me.tfCREC.AutoScroll = True
        Me.tfCREC.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tfCREC.CaptionBlend = New WindowsControlLibrary.BlendFill(WindowsControlLibrary.BlendStyle.Horizontal, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(230, Byte), Integer)))
        Me.tfCREC.Controls.Add(Me.CRECDetGridControl)
        Me.tfCREC.Controls.Add(Me.ChkCorregir)
        Me.tfCREC.Controls.Add(Me.lnkValidarCREC)
        Me.tfCREC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tfCREC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.tfCREC.IsExpanded = False
        Me.tfCREC.Location = New System.Drawing.Point(0, -8)
        Me.tfCREC.Name = "tfCREC"
        Me.tfCREC.Size = New System.Drawing.Size(670, 272)
        Me.tfCREC.TabIndex = 3
        Me.tfCREC.Text = "Archivo CREC"
        '
        'CRECDetGridControl
        '
        Me.CRECDetGridControl.DataSource = Me.CRECDetBindingSource
        Me.CRECDetGridControl.Location = New System.Drawing.Point(5, 2)
        Me.CRECDetGridControl.MainView = Me.GridView2
        Me.CRECDetGridControl.Name = "CRECDetGridControl"
        Me.CRECDetGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3})
        Me.CRECDetGridControl.Size = New System.Drawing.Size(511, 220)
        Me.CRECDetGridControl.TabIndex = 13
        Me.CRECDetGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'CRECDetBindingSource
        '
        Me.CRECDetBindingSource.DataSource = GetType(DataAccess.CRECDet)
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdBanco, Me.colCuenta, Me.colNumero, Me.colImporte, Me.colSecuencia, Me.colExiste})
        Me.GridView2.GridControl = Me.CRECDetGridControl
        Me.GridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", Nothing, "N0")})
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowFooter = True
        '
        'colIdBanco
        '
        Me.colIdBanco.Caption = "Banco"
        Me.colIdBanco.FieldName = "IdBanco"
        Me.colIdBanco.Name = "colIdBanco"
        Me.colIdBanco.OptionsColumn.ReadOnly = True
        Me.colIdBanco.Visible = True
        Me.colIdBanco.VisibleIndex = 0
        '
        'colCuenta
        '
        Me.colCuenta.Caption = "Cuenta"
        Me.colCuenta.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colCuenta.DisplayFormat.FormatString = "000000000000"
        Me.colCuenta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCuenta.FieldName = "Cuenta"
        Me.colCuenta.Name = "colCuenta"
        Me.colCuenta.OptionsColumn.ReadOnly = True
        Me.colCuenta.Visible = True
        Me.colCuenta.VisibleIndex = 1
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "000000000000"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.MaxLength = 12
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colNumero
        '
        Me.colNumero.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colNumero.DisplayFormat.FormatString = "00000000"
        Me.colNumero.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNumero.FieldName = "Numero"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.ReadOnly = True
        Me.colNumero.Visible = True
        Me.colNumero.VisibleIndex = 2
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Mask.EditMask = "00000000"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.MaxLength = 8
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'colImporte
        '
        Me.colImporte.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colImporte.DisplayFormat.FormatString = "N0"
        Me.colImporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colImporte.FieldName = "Importe"
        Me.colImporte.Name = "colImporte"
        Me.colImporte.OptionsColumn.ReadOnly = True
        Me.colImporte.SummaryItem.DisplayFormat = "{0:N0}"
        Me.colImporte.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colImporte.Visible = True
        Me.colImporte.VisibleIndex = 3
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Mask.EditMask = "N0"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'colSecuencia
        '
        Me.colSecuencia.FieldName = "Secuencia"
        Me.colSecuencia.Name = "colSecuencia"
        Me.colSecuencia.OptionsColumn.ReadOnly = True
        Me.colSecuencia.Visible = True
        Me.colSecuencia.VisibleIndex = 4
        '
        'colExiste
        '
        Me.colExiste.FieldName = "Existe"
        Me.colExiste.Name = "colExiste"
        Me.colExiste.OptionsColumn.ReadOnly = True
        Me.colExiste.Visible = True
        Me.colExiste.VisibleIndex = 5
        '
        'ChkCorregir
        '
        Me.ChkCorregir.AutoSize = True
        Me.ChkCorregir.Location = New System.Drawing.Point(524, 22)
        Me.ChkCorregir.Name = "ChkCorregir"
        Me.ChkCorregir.Size = New System.Drawing.Size(143, 17)
        Me.ChkCorregir.TabIndex = 13
        Me.ChkCorregir.Text = "Aplicar Correcciones"
        Me.ChkCorregir.UseVisualStyleBackColor = True
        '
        'frmRecibido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 619)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TaskPane1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmRecibido"
        Me.Text = "Recibidos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Edit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LecturasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LecturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TaskPane1.ResumeLayout(False)
        Me.TaskPane1.PerformLayout()
        Me.TaskFrame1.ResumeLayout(False)
        Me.tfValidar.ResumeLayout(False)
        Me.tfValidar.PerformLayout()
        Me.TaskFrame4.ResumeLayout(False)
        Me.TaskFrame4.PerformLayout()
        Me.PanelMotivoDevolucion.ResumeLayout(False)
        Me.PanelMotivoDevolucion.PerformLayout()
        CType(Me.MotivosRechazoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TaskFrame5.ResumeLayout(False)
        Me.TaskFrame5.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.LecturasGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Edit12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Edit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MontoEditor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.DataRepeater1.ItemTemplate.ResumeLayout(False)
        Me.DataRepeater1.ItemTemplate.PerformLayout()
        Me.DataRepeater1.ResumeLayout(False)
        Me.DataRepeater1.PerformLayout()
        CType(Me.ErroresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TaskPane2.ResumeLayout(False)
        Me.tfCheque.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.tfCREC.ResumeLayout(False)
        Me.tfCREC.PerformLayout()
        CType(Me.CRECDetGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRECDetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LecturasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LecturasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmnuInsertar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbIniciarCaptura As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbErrores As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCargar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbDescargar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents cboBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents TaskPane1 As WindowsControlLibrary.TaskPane
    Friend WithEvents TaskFrame1 As WindowsControlLibrary.TaskFrame
    Friend WithEvents tfValidar As WindowsControlLibrary.TaskFrame
    Friend WithEvents lnkBuscar As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents chkFiltraError As System.Windows.Forms.CheckBox
    Friend WithEvents lnkReasignar As System.Windows.Forms.LinkLabel
    Friend WithEvents nudLote As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TaskFrame4 As WindowsControlLibrary.TaskFrame
    Friend WithEvents cboCajero As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TaskFrame5 As WindowsControlLibrary.TaskFrame
    Friend WithEvents SucursalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lblDIF As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblCHQCant As System.Windows.Forms.Label
    Friend WithEvents lblCHQ As System.Windows.Forms.Label
    Friend WithEvents lblCABCant As System.Windows.Forms.Label
    Friend WithEvents lblCAB As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkSucursal As System.Windows.Forms.LinkLabel
    Friend WithEvents txtSucursal As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents LecturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IniciarCapturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ValidarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FiltrarErroresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblSubTotalDet As System.Windows.Forms.Label
    Friend WithEvents lblSubTotalCab As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents DataRepeater1 As Microsoft.VisualBasic.PowerPacks.DataRepeater
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ErroresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txtErrores As System.Windows.Forms.Label
    Friend WithEvents txtSubTotalCab As System.Windows.Forms.Label
    Friend WithEvents txtSubTotalDet As System.Windows.Forms.Label
    Friend WithEvents lblSubDif As System.Windows.Forms.Label
    Friend WithEvents txtSubDif As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TaskPane2 As WindowsControlLibrary.TaskPane
    Friend WithEvents tfCheque As WindowsControlLibrary.TaskFrame
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ImagenBase1 As HostVB.ImagenBase
    Friend WithEvents PanelMotivoDevolucion As System.Windows.Forms.Panel
    Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents lnkMotivo As System.Windows.Forms.LinkLabel
    Friend WithEvents cboMotivo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MotivosRechazoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lnkFecha As System.Windows.Forms.LinkLabel
    Friend WithEvents tsEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdImportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lnkValidarCREC As System.Windows.Forms.LinkLabel
    Friend WithEvents tfCREC As WindowsControlLibrary.TaskFrame
    Friend WithEvents CRECDetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChkCorregir As System.Windows.Forms.CheckBox
    Friend WithEvents ColumnLote As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents clBanco As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents tbcSerie As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents clReceptor As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents Importe As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents cod_sucursal As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents cuenta_deposito As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents ConError As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IdMotivo As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents ENVIADO As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IdLectura As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents LecturasGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnro_lote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcod_tipdoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcuenta_cheque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnumero_cheque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcod_banco_receptor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcod_camara As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcabecera As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcadena_captura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcuenta_deposito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcod_sucursal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcod_banco_emisor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdLectura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdMotivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConError As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Edit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Edit12 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Edit8 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents MontoEditor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colENVIADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CRECDetGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIdBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSecuencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExiste As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
