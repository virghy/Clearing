<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecibidoDataset
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecibidoDataset))
        Me.Worker = New System.ComponentModel.BackgroundWorker
        Me.Label2 = New System.Windows.Forms.Label
        Me.LecturasDataGridView = New System.Windows.Forms.DataGridView
        Me.IdLectura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.tbcSerie = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.DataGridViewTextBoxColumn27 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.Importe = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.cod_sucursal = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.LecturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClearingDataSets = New HostVB.ClearingDataSets
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
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.cboBuscar = New System.Windows.Forms.ComboBox
        Me.lnkBuscar = New System.Windows.Forms.LinkLabel
        Me.TaskPane1 = New WindowsControlLibrary.TaskPane
        Me.TaskFrame1 = New WindowsControlLibrary.TaskFrame
        Me.TaskFrame2 = New WindowsControlLibrary.TaskFrame
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.chkFiltraError = New System.Windows.Forms.CheckBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.TaskFrame3 = New WindowsControlLibrary.TaskFrame
        Me.lnkReasignar = New System.Windows.Forms.LinkLabel
        Me.nudLote = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.TaskFrame4 = New WindowsControlLibrary.TaskFrame
        Me.txtSucursal = New System.Windows.Forms.TextBox
        Me.lnkSucursal = New System.Windows.Forms.LinkLabel
        Me.cboCajero = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboSucursal = New System.Windows.Forms.ComboBox
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.TaskFrame5 = New WindowsControlLibrary.TaskFrame
        Me.lblDIF = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblCHQCant = New System.Windows.Forms.Label
        Me.lblCHQ = New System.Windows.Forms.Label
        Me.lblCABCant = New System.Windows.Forms.Label
        Me.lblCAB = New System.Windows.Forms.Label
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LecturasTableAdapter = New HostVB.ClearingDataSetsTableAdapters.LecturasTableAdapter
        Me.TableAdapterManager = New HostVB.ClearingDataSetsTableAdapters.TableAdapterManager
        CType(Me.LecturasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LecturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClearingDataSets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TaskPane1.SuspendLayout()
        Me.TaskFrame1.SuspendLayout()
        Me.TaskFrame2.SuspendLayout()
        Me.TaskFrame3.SuspendLayout()
        CType(Me.nudLote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TaskFrame4.SuspendLayout()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TaskFrame5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.LecturasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LecturasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdLectura, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.tbcSerie, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn8, Me.Importe, Me.cod_sucursal, Me.DataGridViewTextBoxColumn12})
        Me.LecturasDataGridView.DataSource = Me.LecturasBindingSource
        Me.LecturasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LecturasDataGridView.Location = New System.Drawing.Point(3, 32)
        Me.LecturasDataGridView.Name = "LecturasDataGridView"
        Me.LecturasDataGridView.ReadOnly = True
        Me.LecturasDataGridView.RowTemplate.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LecturasDataGridView.Size = New System.Drawing.Size(671, 516)
        Me.LecturasDataGridView.TabIndex = 8
        '
        'IdLectura
        '
        Me.IdLectura.DataPropertyName = "IdLectura"
        Me.IdLectura.HeaderText = "IdLectura"
        Me.IdLectura.Name = "IdLectura"
        Me.IdLectura.ReadOnly = True
        Me.IdLectura.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nro_lote"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Lote"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cod_banco_receptor"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Banco"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.Width = 40
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cod_tipdoc"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Doc"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.Width = 40
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "cuenta_cheque"
        DataGridViewCellStyle5.Format = "000000000000"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cuenta"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'tbcSerie
        '
        Me.tbcSerie.DataPropertyName = "numero_cheque"
        DataGridViewCellStyle6.Format = "00000000"
        Me.tbcSerie.DefaultCellStyle = DataGridViewCellStyle6
        Me.tbcSerie.HeaderText = "Serie"
        Me.tbcSerie.Name = "tbcSerie"
        Me.tbcSerie.ReadOnly = True
        Me.tbcSerie.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "cod_banco_emisor"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Receptor"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn27.Width = 40
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "cod_camara"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Camara"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.Width = 40
        '
        'Importe
        '
        Me.Importe.DataPropertyName = "monto"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle7
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        Me.Importe.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'cod_sucursal
        '
        Me.cod_sucursal.DataPropertyName = "cod_sucursal"
        Me.cod_sucursal.HeaderText = "Sucursal"
        Me.cod_sucursal.Name = "cod_sucursal"
        Me.cod_sucursal.ReadOnly = True
        Me.cod_sucursal.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cod_sucursal.Width = 50
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "cabecera"
        DataGridViewCellStyle8.Format = "N0"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn12.HeaderText = "Secuencia"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn12.Width = 60
        '
        'LecturasBindingSource
        '
        Me.LecturasBindingSource.DataMember = "Lecturas"
        Me.LecturasBindingSource.DataSource = Me.ClearingDataSets
        '
        'ClearingDataSets
        '
        Me.ClearingDataSets.DataSetName = "ClearingDataSets"
        Me.ClearingDataSets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuInsertar, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(133, 70)
        '
        'cmnuInsertar
        '
        Me.cmnuInsertar.Image = Global.HostVB.My.Resources.Resources.VSProject_generatedfile
        Me.cmnuInsertar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmnuInsertar.Name = "cmnuInsertar"
        Me.cmnuInsertar.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.cmnuInsertar.Size = New System.Drawing.Size(132, 22)
        Me.cmnuInsertar.Text = "&Insertar"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.HostVB.My.Resources.Resources.EditTableHS
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.EditarToolStripMenuItem.Text = "&Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.HostVB.My.Resources.Resources.delete
        Me.EliminarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.EliminarToolStripMenuItem.Text = "E&liminar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbIniciarCaptura, Me.ToolStripButton1, Me.tsbErrores, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(882, 38)
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
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(54, 35)
        Me.ToolStripButton1.Text = "Verificar"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbErrores
        '
        Me.tsbErrores.Image = CType(resources.GetObject("tsbErrores.Image"), System.Drawing.Image)
        Me.tsbErrores.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbErrores.Name = "tsbErrores"
        Me.tsbErrores.Size = New System.Drawing.Size(47, 35)
        Me.tsbErrores.Text = "Errores"
        Me.tsbErrores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = Global.HostVB.My.Resources.Resources.database
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(49, 35)
        Me.ToolStripButton4.Text = "Cargar "
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = Global.HostVB.My.Resources.Resources.database_read_only
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(63, 35)
        Me.ToolStripButton5.Text = "Descargar"
        Me.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.TaskPane1.AutoScrollMinSize = New System.Drawing.Size(0, 622)
        Me.TaskPane1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TaskPane1.Controls.Add(Me.TaskFrame1)
        Me.TaskPane1.Controls.Add(Me.TaskFrame2)
        Me.TaskPane1.Controls.Add(Me.TaskFrame3)
        Me.TaskPane1.Controls.Add(Me.TaskFrame4)
        Me.TaskPane1.Controls.Add(Me.TaskFrame5)
        Me.TaskPane1.CornerStyle = WindowsControlLibrary.TaskFrameCornerStyle.SystemDefault
        Me.TaskPane1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TaskPane1.Location = New System.Drawing.Point(677, 38)
        Me.TaskPane1.Name = "TaskPane1"
        Me.TaskPane1.Size = New System.Drawing.Size(205, 581)
        Me.TaskPane1.TabIndex = 34
        '
        'TaskFrame1
        '
        Me.TaskFrame1.AllowDrop = True
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
        'TaskFrame2
        '
        Me.TaskFrame2.AllowDrop = True
        Me.TaskFrame2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TaskFrame2.CaptionBlend = New WindowsControlLibrary.BlendFill(WindowsControlLibrary.BlendStyle.Horizontal, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(230, Byte), Integer)))
        Me.TaskFrame2.Controls.Add(Me.LinkLabel2)
        Me.TaskFrame2.Controls.Add(Me.chkFiltraError)
        Me.TaskFrame2.Controls.Add(Me.LinkLabel1)
        Me.TaskFrame2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TaskFrame2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.TaskFrame2.Location = New System.Drawing.Point(12, 141)
        Me.TaskFrame2.Name = "TaskFrame2"
        Me.TaskFrame2.Size = New System.Drawing.Size(163, 80)
        Me.TaskFrame2.TabIndex = 3
        Me.TaskFrame2.Text = "Tareas"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(3, 54)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(110, 13)
        Me.LinkLabel2.TabIndex = 4
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Verificar repetidos"
        '
        'chkFiltraError
        '
        Me.chkFiltraError.AutoSize = True
        Me.chkFiltraError.Location = New System.Drawing.Point(3, 29)
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
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 8)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(83, 13)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Validar Datos"
        '
        'TaskFrame3
        '
        Me.TaskFrame3.AllowDrop = True
        Me.TaskFrame3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TaskFrame3.CaptionBlend = New WindowsControlLibrary.BlendFill(WindowsControlLibrary.BlendStyle.Horizontal, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(230, Byte), Integer)))
        Me.TaskFrame3.Controls.Add(Me.lnkReasignar)
        Me.TaskFrame3.Controls.Add(Me.nudLote)
        Me.TaskFrame3.Controls.Add(Me.Label1)
        Me.TaskFrame3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TaskFrame3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.TaskFrame3.Location = New System.Drawing.Point(12, 254)
        Me.TaskFrame3.Name = "TaskFrame3"
        Me.TaskFrame3.Size = New System.Drawing.Size(163, 70)
        Me.TaskFrame3.TabIndex = 5
        Me.TaskFrame3.Text = "Lotes"
        '
        'lnkReasignar
        '
        Me.lnkReasignar.AutoEllipsis = True
        Me.lnkReasignar.AutoSize = True
        Me.lnkReasignar.Location = New System.Drawing.Point(0, 46)
        Me.lnkReasignar.Name = "lnkReasignar"
        Me.lnkReasignar.Size = New System.Drawing.Size(179, 13)
        Me.lnkReasignar.TabIndex = 2
        Me.lnkReasignar.TabStop = True
        Me.lnkReasignar.Text = "Asignar registros al lote actual"
        '
        'nudLote
        '
        Me.nudLote.Location = New System.Drawing.Point(116, 13)
        Me.nudLote.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudLote.Name = "nudLote"
        Me.nudLote.Size = New System.Drawing.Size(44, 20)
        Me.nudLote.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lote actual"
        '
        'TaskFrame4
        '
        Me.TaskFrame4.AllowDrop = True
        Me.TaskFrame4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TaskFrame4.CaptionBlend = New WindowsControlLibrary.BlendFill(WindowsControlLibrary.BlendStyle.Horizontal, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(230, Byte), Integer)))
        Me.TaskFrame4.Controls.Add(Me.txtSucursal)
        Me.TaskFrame4.Controls.Add(Me.lnkSucursal)
        Me.TaskFrame4.Controls.Add(Me.cboCajero)
        Me.TaskFrame4.Controls.Add(Me.Label6)
        Me.TaskFrame4.Controls.Add(Me.cboSucursal)
        Me.TaskFrame4.Controls.Add(Me.Label3)
        Me.TaskFrame4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TaskFrame4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.TaskFrame4.Location = New System.Drawing.Point(12, 357)
        Me.TaskFrame4.Name = "TaskFrame4"
        Me.TaskFrame4.Size = New System.Drawing.Size(163, 120)
        Me.TaskFrame4.TabIndex = 7
        Me.TaskFrame4.Text = "Opciones"
        '
        'txtSucursal
        '
        Me.txtSucursal.Location = New System.Drawing.Point(6, 21)
        Me.txtSucursal.MaxLength = 2
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(27, 20)
        Me.txtSucursal.TabIndex = 5
        '
        'lnkSucursal
        '
        Me.lnkSucursal.AutoEllipsis = True
        Me.lnkSucursal.AutoSize = True
        Me.lnkSucursal.Location = New System.Drawing.Point(-3, 44)
        Me.lnkSucursal.Name = "lnkSucursal"
        Me.lnkSucursal.Size = New System.Drawing.Size(167, 13)
        Me.lnkSucursal.TabIndex = 4
        Me.lnkSucursal.TabStop = True
        Me.lnkSucursal.Text = "Asignar a la Sucursal Actual"
        '
        'cboCajero
        '
        Me.cboCajero.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCajero.FormattingEnabled = True
        Me.cboCajero.Location = New System.Drawing.Point(0, 82)
        Me.cboCajero.Name = "cboCajero"
        Me.cboCajero.Size = New System.Drawing.Size(160, 21)
        Me.cboCajero.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(0, 65)
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
        Me.cboSucursal.Location = New System.Drawing.Point(36, 21)
        Me.cboSucursal.Name = "cboSucursal"
        Me.cboSucursal.Size = New System.Drawing.Size(124, 21)
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
        Me.Label3.Location = New System.Drawing.Point(0, 4)
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
        Me.TaskFrame5.Controls.Add(Me.lblDIF)
        Me.TaskFrame5.Controls.Add(Me.Label9)
        Me.TaskFrame5.Controls.Add(Me.lblCHQCant)
        Me.TaskFrame5.Controls.Add(Me.lblCHQ)
        Me.TaskFrame5.Controls.Add(Me.lblCABCant)
        Me.TaskFrame5.Controls.Add(Me.lblCAB)
        Me.TaskFrame5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TaskFrame5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.TaskFrame5.Location = New System.Drawing.Point(12, 510)
        Me.TaskFrame5.Name = "TaskFrame5"
        Me.TaskFrame5.Size = New System.Drawing.Size(163, 100)
        Me.TaskFrame5.TabIndex = 9
        Me.TaskFrame5.Text = "Totales"
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
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.LecturasDataGridView, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 38)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(677, 581)
        Me.TableLayoutPanel3.TabIndex = 35
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 554)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(671, 24)
        Me.Panel1.TabIndex = 33
        Me.Panel1.Visible = False
        '
        'LecturasTableAdapter
        '
        Me.LecturasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LecturasTableAdapter = Me.LecturasTableAdapter
        Me.TableAdapterManager.UpdateOrder = HostVB.ClearingDataSetsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmRecibido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 619)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TaskPane1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmRecibido"
        Me.Text = "Recibidos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LecturasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LecturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClearingDataSets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TaskPane1.ResumeLayout(False)
        Me.TaskFrame1.ResumeLayout(False)
        Me.TaskFrame2.ResumeLayout(False)
        Me.TaskFrame2.PerformLayout()
        Me.TaskFrame3.ResumeLayout(False)
        Me.TaskFrame3.PerformLayout()
        CType(Me.nudLote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TaskFrame4.ResumeLayout(False)
        Me.TaskFrame4.PerformLayout()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TaskFrame5.ResumeLayout(False)
        Me.TaskFrame5.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
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
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents cboBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents TaskPane1 As WindowsControlLibrary.TaskPane
    Friend WithEvents TaskFrame1 As WindowsControlLibrary.TaskFrame
    Friend WithEvents TaskFrame2 As WindowsControlLibrary.TaskFrame
    Friend WithEvents lnkBuscar As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents chkFiltraError As System.Windows.Forms.CheckBox
    Friend WithEvents TaskFrame3 As WindowsControlLibrary.TaskFrame
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
    Friend WithEvents LecturasTableAdapter As HostVB.ClearingDataSetsTableAdapters.LecturasTableAdapter
    Friend WithEvents TableAdapterManager As HostVB.ClearingDataSetsTableAdapters.TableAdapterManager
    Friend WithEvents ClearingDataSets As HostVB.ClearingDataSets
    Friend WithEvents IdLectura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents tbcSerie As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents Importe As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents cod_sucursal As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As Sorteable.DataGridViewAutoFilterTextBoxColumn
End Class
