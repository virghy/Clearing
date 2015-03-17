<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecibido1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecibido1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Worker = New System.ComponentModel.BackgroundWorker
        Me.Label2 = New System.Windows.Forms.Label
        Me.LecturasDataGridView = New System.Windows.Forms.DataGridView
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
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
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
        Me.cnro_lote = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.ccod_banco_receptor = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.ccod_tipdoc = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.ccuenta_cheque = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.cnumero_cheque = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.ccod_banco_emisor = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.ccod_camara = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.cmonto = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.ccod_sucursal = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.ccabecera = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.cConError = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.cIdMotivo = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.cENVIADO = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.cIdLectura = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        CType(Me.LecturasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LecturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TaskPane1.SuspendLayout()
        Me.TaskFrame1.SuspendLayout()
        Me.TaskFrame2.SuspendLayout()
        Me.TaskFrame4.SuspendLayout()
        Me.PanelMotivoDevolucion.SuspendLayout()
        CType(Me.MotivosRechazoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TaskFrame5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.DataRepeater1.ItemTemplate.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        CType(Me.ErroresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TaskPane2.SuspendLayout()
        Me.tfCheque.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
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
        Me.LecturasDataGridView.AllowUserToAddRows = False
        Me.LecturasDataGridView.AllowUserToOrderColumns = True
        Me.LecturasDataGridView.AutoGenerateColumns = False
        Me.LecturasDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.LecturasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LecturasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cnro_lote, Me.ccod_banco_receptor, Me.ccod_tipdoc, Me.ccuenta_cheque, Me.cnumero_cheque, Me.ccod_banco_emisor, Me.ccod_camara, Me.cmonto, Me.ccod_sucursal, Me.ccabecera, Me.cConError, Me.cIdMotivo, Me.cENVIADO, Me.cIdLectura})
        Me.LecturasDataGridView.DataSource = Me.LecturasBindingSource
        Me.LecturasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LecturasDataGridView.Location = New System.Drawing.Point(3, 4)
        Me.LecturasDataGridView.Name = "LecturasDataGridView"
        Me.LecturasDataGridView.ReadOnly = True
        Me.LecturasDataGridView.RowTemplate.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LecturasDataGridView.Size = New System.Drawing.Size(671, 464)
        Me.LecturasDataGridView.TabIndex = 8
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbIniciarCaptura, Me.ToolStripButton1, Me.tsbErrores, Me.ToolStripButton2, Me.ToolStripButton3, Me.tsEliminar, Me.tsbCargar, Me.tsbDescargar, Me.ToolStripButton6})
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
        Me.TaskPane1.AutoScrollMinSize = New System.Drawing.Size(0, 629)
        Me.TaskPane1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TaskPane1.Controls.Add(Me.TaskFrame1)
        Me.TaskPane1.Controls.Add(Me.TaskFrame2)
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
        Me.TaskFrame2.Size = New System.Drawing.Size(163, 60)
        Me.TaskFrame2.TabIndex = 3
        Me.TaskFrame2.Text = "Validaciones y Errores"
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
        Me.TaskFrame4.Location = New System.Drawing.Point(12, 234)
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
        Me.TaskFrame5.Location = New System.Drawing.Point(12, 517)
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
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.LecturasDataGridView, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.MenuStrip1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DataRepeater1, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.TaskPane2, 0, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 38)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(677, 581)
        Me.TableLayoutPanel3.TabIndex = 35
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 502)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(671, 25)
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
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(671, 25)
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
        Me.IniciarCapturaToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.IniciarCapturaToolStripMenuItem.Text = "Iniciar Captura"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(173, 6)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Insert), System.Windows.Forms.Keys)
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.InsertarToolStripMenuItem.Text = "Insertar"
        '
        'EditarToolStripMenuItem1
        '
        Me.EditarToolStripMenuItem1.Name = "EditarToolStripMenuItem1"
        Me.EditarToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)
        Me.EditarToolStripMenuItem1.Size = New System.Drawing.Size(176, 22)
        Me.EditarToolStripMenuItem1.Text = "Editar"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(173, 6)
        '
        'ValidarToolStripMenuItem
        '
        Me.ValidarToolStripMenuItem.Name = "ValidarToolStripMenuItem"
        Me.ValidarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.ValidarToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ValidarToolStripMenuItem.Text = "Validar"
        '
        'FiltrarErroresToolStripMenuItem
        '
        Me.FiltrarErroresToolStripMenuItem.Name = "FiltrarErroresToolStripMenuItem"
        Me.FiltrarErroresToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.FiltrarErroresToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
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
        Me.DataRepeater1.Location = New System.Drawing.Point(3, 533)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(671, 45)
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
        Me.TaskPane2.AutoScrollMinSize = New System.Drawing.Size(0, 271)
        Me.TaskPane2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TaskPane2.Controls.Add(Me.tfCheque)
        Me.TaskPane2.CornerStyle = WindowsControlLibrary.TaskFrameCornerStyle.SystemDefault
        Me.TaskPane2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TaskPane2.Location = New System.Drawing.Point(3, 474)
        Me.TaskPane2.Name = "TaskPane2"
        Me.TaskPane2.Padding = 0
        Me.TaskPane2.Size = New System.Drawing.Size(671, 22)
        Me.TaskPane2.TabIndex = 36
        '
        'tfCheque
        '
        Me.tfCheque.AllowDrop = True
        Me.tfCheque.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.tfCheque.CaptionBlend = New WindowsControlLibrary.BlendFill(WindowsControlLibrary.BlendStyle.Horizontal, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(230, Byte), Integer)))
        Me.tfCheque.Controls.Add(Me.TableLayoutPanel4)
        Me.tfCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tfCheque.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.tfCheque.IsExpanded = False
        Me.tfCheque.Location = New System.Drawing.Point(0, 21)
        Me.tfCheque.Name = "tfCheque"
        Me.tfCheque.Size = New System.Drawing.Size(653, 250)
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
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(653, 250)
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
        Me.ImagenBase1.Size = New System.Drawing.Size(647, 244)
        Me.ImagenBase1.TabIndex = 0
        '
        'cnro_lote
        '
        Me.cnro_lote.AutomaticSortingEnabled = False
        Me.cnro_lote.DataPropertyName = "nro_lote"
        Me.cnro_lote.FilteringEnabled = False
        Me.cnro_lote.HeaderText = "Lote"
        Me.cnro_lote.Name = "cnro_lote"
        Me.cnro_lote.ReadOnly = True
        Me.cnro_lote.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cnro_lote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cnro_lote.Width = 40
        '
        'ccod_banco_receptor
        '
        Me.ccod_banco_receptor.AutomaticSortingEnabled = False
        Me.ccod_banco_receptor.DataPropertyName = "cod_banco_receptor"
        Me.ccod_banco_receptor.FilteringEnabled = False
        Me.ccod_banco_receptor.HeaderText = "Banco"
        Me.ccod_banco_receptor.Name = "ccod_banco_receptor"
        Me.ccod_banco_receptor.ReadOnly = True
        Me.ccod_banco_receptor.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ccod_banco_receptor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ccod_banco_receptor.Width = 40
        '
        'ccod_tipdoc
        '
        Me.ccod_tipdoc.AutomaticSortingEnabled = False
        Me.ccod_tipdoc.DataPropertyName = "cod_tipdoc"
        Me.ccod_tipdoc.FilteringEnabled = False
        Me.ccod_tipdoc.HeaderText = "Doc"
        Me.ccod_tipdoc.Name = "ccod_tipdoc"
        Me.ccod_tipdoc.ReadOnly = True
        Me.ccod_tipdoc.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ccod_tipdoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ccod_tipdoc.Width = 40
        '
        'ccuenta_cheque
        '
        Me.ccuenta_cheque.AutomaticSortingEnabled = False
        Me.ccuenta_cheque.DataPropertyName = "cuenta_cheque"
        DataGridViewCellStyle1.Format = "000000000000"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ccuenta_cheque.DefaultCellStyle = DataGridViewCellStyle1
        Me.ccuenta_cheque.FilteringEnabled = False
        Me.ccuenta_cheque.HeaderText = "Cuenta"
        Me.ccuenta_cheque.Name = "ccuenta_cheque"
        Me.ccuenta_cheque.ReadOnly = True
        Me.ccuenta_cheque.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ccuenta_cheque.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ccuenta_cheque.Width = 120
        '
        'cnumero_cheque
        '
        Me.cnumero_cheque.AutomaticSortingEnabled = False
        Me.cnumero_cheque.DataPropertyName = "numero_cheque"
        DataGridViewCellStyle2.Format = "00000000"
        Me.cnumero_cheque.DefaultCellStyle = DataGridViewCellStyle2
        Me.cnumero_cheque.FilteringEnabled = False
        Me.cnumero_cheque.HeaderText = "Serie"
        Me.cnumero_cheque.Name = "cnumero_cheque"
        Me.cnumero_cheque.ReadOnly = True
        Me.cnumero_cheque.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cnumero_cheque.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cnumero_cheque.Width = 90
        '
        'ccod_banco_emisor
        '
        Me.ccod_banco_emisor.AutomaticSortingEnabled = False
        Me.ccod_banco_emisor.DataPropertyName = "cod_banco_emisor"
        Me.ccod_banco_emisor.FilteringEnabled = False
        Me.ccod_banco_emisor.HeaderText = "Receptor"
        Me.ccod_banco_emisor.Name = "ccod_banco_emisor"
        Me.ccod_banco_emisor.ReadOnly = True
        Me.ccod_banco_emisor.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ccod_banco_emisor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ccod_banco_emisor.Width = 40
        '
        'ccod_camara
        '
        Me.ccod_camara.AutomaticSortingEnabled = False
        Me.ccod_camara.DataPropertyName = "cod_camara"
        Me.ccod_camara.FilteringEnabled = False
        Me.ccod_camara.HeaderText = "Camara"
        Me.ccod_camara.Name = "ccod_camara"
        Me.ccod_camara.ReadOnly = True
        Me.ccod_camara.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ccod_camara.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ccod_camara.Width = 40
        '
        'cmonto
        '
        Me.cmonto.DataPropertyName = "monto"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.cmonto.DefaultCellStyle = DataGridViewCellStyle3
        Me.cmonto.FilteringEnabled = False
        Me.cmonto.HeaderText = "Importe"
        Me.cmonto.Name = "cmonto"
        Me.cmonto.ReadOnly = True
        Me.cmonto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'ccod_sucursal
        '
        Me.ccod_sucursal.AutomaticSortingEnabled = False
        Me.ccod_sucursal.DataPropertyName = "cod_sucursal"
        Me.ccod_sucursal.FilteringEnabled = False
        Me.ccod_sucursal.HeaderText = "Sucursal"
        Me.ccod_sucursal.Name = "ccod_sucursal"
        Me.ccod_sucursal.ReadOnly = True
        Me.ccod_sucursal.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ccod_sucursal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ccod_sucursal.Width = 50
        '
        'ccabecera
        '
        Me.ccabecera.DataPropertyName = "cabecera"
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ccabecera.DefaultCellStyle = DataGridViewCellStyle4
        Me.ccabecera.FilteringEnabled = False
        Me.ccabecera.HeaderText = "Secuencia"
        Me.ccabecera.Name = "ccabecera"
        Me.ccabecera.ReadOnly = True
        Me.ccabecera.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ccabecera.Width = 60
        '
        'cConError
        '
        Me.cConError.DataPropertyName = "ConError"
        Me.cConError.HeaderText = "Errores"
        Me.cConError.Name = "cConError"
        Me.cConError.ReadOnly = True
        Me.cConError.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'cIdMotivo
        '
        Me.cIdMotivo.DataPropertyName = "IdMotivo"
        Me.cIdMotivo.FilteringEnabled = False
        Me.cIdMotivo.HeaderText = "Motivo"
        Me.cIdMotivo.Name = "cIdMotivo"
        Me.cIdMotivo.ReadOnly = True
        '
        'cENVIADO
        '
        Me.cENVIADO.DataPropertyName = "ENVIADO"
        Me.cENVIADO.HeaderText = "Editado"
        Me.cENVIADO.Name = "cENVIADO"
        Me.cENVIADO.ReadOnly = True
        Me.cENVIADO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cENVIADO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'cIdLectura
        '
        Me.cIdLectura.DataPropertyName = "IdLectura"
        Me.cIdLectura.FilteringEnabled = False
        Me.cIdLectura.HeaderText = "IdLectura"
        Me.cIdLectura.Name = "cIdLectura"
        Me.cIdLectura.ReadOnly = True
        Me.cIdLectura.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cIdLectura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmRecibido1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 619)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TaskPane1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmRecibido1"
        Me.Text = "Recibidos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
        Me.TaskFrame2.ResumeLayout(False)
        Me.TaskFrame2.PerformLayout()
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
    Friend WithEvents TaskFrame2 As WindowsControlLibrary.TaskFrame
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
    Friend WithEvents cnro_lote As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents ccod_banco_receptor As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents ccod_tipdoc As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents ccuenta_cheque As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents cnumero_cheque As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents ccod_banco_emisor As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents ccod_camara As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents cmonto As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents ccod_sucursal As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents ccabecera As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents cConError As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cIdMotivo As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents cENVIADO As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cIdLectura As Sorteable.DataGridViewAutoFilterTextBoxColumn
End Class
