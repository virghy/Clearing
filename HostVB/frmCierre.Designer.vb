<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCierre
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
        Me.Worker = New System.ComponentModel.BackgroundWorker
        Me.Label2 = New System.Windows.Forms.Label
        Me.LecturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuInsertar = New System.Windows.Forms.ToolStripMenuItem
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TaskPane1 = New WindowsControlLibrary.TaskPane
        Me.TaskFrame2 = New WindowsControlLibrary.TaskFrame
        Me.chkFiltraError = New System.Windows.Forms.CheckBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.TaskFrame5 = New WindowsControlLibrary.TaskFrame
        Me.lblDIF = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblCHQCant = New System.Windows.Forms.Label
        Me.lblCHQ = New System.Windows.Forms.Label
        Me.lblCABCant = New System.Windows.Forms.Label
        Me.lblCAB = New System.Windows.Forms.Label
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.LecturasDataGridView = New System.Windows.Forms.DataGridView
        Me.cod_maquina = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.IdLectura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.tbcSerie = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.DataGridViewTextBoxColumn27 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.Importe = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.cod_sucursal = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.nudPaquete = New System.Windows.Forms.NumericUpDown
        Me.lblPaquete = New System.Windows.Forms.Label
        CType(Me.LecturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TaskPane1.SuspendLayout()
        Me.TaskFrame2.SuspendLayout()
        Me.TaskFrame5.SuspendLayout()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.LecturasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.nudPaquete, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'LecturasBindingSource
        '
        Me.LecturasBindingSource.DataSource = GetType(DataAccess.Lecturas)
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
        'TaskPane1
        '
        Me.TaskPane1.AutoScroll = True
        Me.TaskPane1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TaskPane1.Controls.Add(Me.TaskFrame2)
        Me.TaskPane1.Controls.Add(Me.TaskFrame5)
        Me.TaskPane1.CornerStyle = WindowsControlLibrary.TaskFrameCornerStyle.SystemDefault
        Me.TaskPane1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TaskPane1.Location = New System.Drawing.Point(677, 0)
        Me.TaskPane1.Name = "TaskPane1"
        Me.TaskPane1.Size = New System.Drawing.Size(205, 619)
        Me.TaskPane1.TabIndex = 34
        '
        'TaskFrame2
        '
        Me.TaskFrame2.AllowDrop = True
        Me.TaskFrame2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TaskFrame2.CaptionBlend = New WindowsControlLibrary.BlendFill(WindowsControlLibrary.BlendStyle.Horizontal, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(230, Byte), Integer)))
        Me.TaskFrame2.Controls.Add(Me.nudPaquete)
        Me.TaskFrame2.Controls.Add(Me.lblPaquete)
        Me.TaskFrame2.Controls.Add(Me.chkFiltraError)
        Me.TaskFrame2.Controls.Add(Me.LinkLabel1)
        Me.TaskFrame2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TaskFrame2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.TaskFrame2.Location = New System.Drawing.Point(12, 33)
        Me.TaskFrame2.Name = "TaskFrame2"
        Me.TaskFrame2.Size = New System.Drawing.Size(181, 80)
        Me.TaskFrame2.TabIndex = 3
        Me.TaskFrame2.Text = "Tareas"
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
        Me.TaskFrame5.Location = New System.Drawing.Point(12, 146)
        Me.TaskFrame5.Name = "TaskFrame5"
        Me.TaskFrame5.Size = New System.Drawing.Size(181, 100)
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
        'SucursalesBindingSource
        '
        Me.SucursalesBindingSource.DataSource = GetType(DataAccess.Sucursales)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 592)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(671, 24)
        Me.Panel1.TabIndex = 33
        Me.Panel1.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(671, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'LecturasDataGridView
        '
        Me.LecturasDataGridView.AllowUserToAddRows = False
        Me.LecturasDataGridView.AllowUserToOrderColumns = True
        Me.LecturasDataGridView.AutoGenerateColumns = False
        Me.LecturasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LecturasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_maquina, Me.DataGridViewTextBoxColumn1, Me.IdLectura, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.tbcSerie, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn8, Me.Importe, Me.cod_sucursal, Me.DataGridViewTextBoxColumn12})
        Me.LecturasDataGridView.DataSource = Me.LecturasBindingSource
        Me.LecturasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LecturasDataGridView.Location = New System.Drawing.Point(3, 32)
        Me.LecturasDataGridView.Name = "LecturasDataGridView"
        Me.LecturasDataGridView.ReadOnly = True
        Me.LecturasDataGridView.RowTemplate.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LecturasDataGridView.Size = New System.Drawing.Size(671, 554)
        Me.LecturasDataGridView.TabIndex = 8
        '
        'cod_maquina
        '
        Me.cod_maquina.DataPropertyName = "cod_maquina"
        Me.cod_maquina.FilteringEnabled = False
        Me.cod_maquina.HeaderText = "Maq"
        Me.cod_maquina.Name = "cod_maquina"
        Me.cod_maquina.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nro_lote"
        Me.DataGridViewTextBoxColumn1.FilteringEnabled = False
        Me.DataGridViewTextBoxColumn1.HeaderText = "Lote"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'IdLectura
        '
        Me.IdLectura.DataPropertyName = "IdLectura"
        Me.IdLectura.HeaderText = "IdLectura"
        Me.IdLectura.Name = "IdLectura"
        Me.IdLectura.ReadOnly = True
        Me.IdLectura.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cod_banco_receptor"
        Me.DataGridViewTextBoxColumn7.FilteringEnabled = False
        Me.DataGridViewTextBoxColumn7.HeaderText = "Banco"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.Width = 40
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cod_tipdoc"
        Me.DataGridViewTextBoxColumn4.FilteringEnabled = False
        Me.DataGridViewTextBoxColumn4.HeaderText = "Doc"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.Width = 40
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "cuenta_cheque"
        DataGridViewCellStyle1.Format = "000000000000"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn5.FilteringEnabled = False
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cuenta"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'tbcSerie
        '
        Me.tbcSerie.DataPropertyName = "numero_cheque"
        DataGridViewCellStyle2.Format = "00000000"
        Me.tbcSerie.DefaultCellStyle = DataGridViewCellStyle2
        Me.tbcSerie.FilteringEnabled = False
        Me.tbcSerie.HeaderText = "Serie"
        Me.tbcSerie.Name = "tbcSerie"
        Me.tbcSerie.ReadOnly = True
        Me.tbcSerie.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "cod_banco_emisor"
        Me.DataGridViewTextBoxColumn27.FilteringEnabled = False
        Me.DataGridViewTextBoxColumn27.HeaderText = "Receptor"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn27.Width = 40
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "cod_camara"
        Me.DataGridViewTextBoxColumn8.FilteringEnabled = False
        Me.DataGridViewTextBoxColumn8.HeaderText = "Camara"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
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
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        Me.Importe.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'cod_sucursal
        '
        Me.cod_sucursal.DataPropertyName = "cod_sucursal"
        Me.cod_sucursal.FilteringEnabled = False
        Me.cod_sucursal.HeaderText = "Sucursal"
        Me.cod_sucursal.Name = "cod_sucursal"
        Me.cod_sucursal.ReadOnly = True
        Me.cod_sucursal.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cod_sucursal.Width = 50
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
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.LecturasDataGridView, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(677, 619)
        Me.TableLayoutPanel3.TabIndex = 35
        '
        'nudPaquete
        '
        Me.nudPaquete.Location = New System.Drawing.Point(114, 49)
        Me.nudPaquete.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudPaquete.Name = "nudPaquete"
        Me.nudPaquete.Size = New System.Drawing.Size(44, 20)
        Me.nudPaquete.TabIndex = 13
        Me.nudPaquete.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblPaquete
        '
        Me.lblPaquete.AutoSize = True
        Me.lblPaquete.Location = New System.Drawing.Point(1, 53)
        Me.lblPaquete.Name = "lblPaquete"
        Me.lblPaquete.Size = New System.Drawing.Size(94, 13)
        Me.lblPaquete.TabIndex = 12
        Me.lblPaquete.Text = "Paquete Actual"
        '
        'frmCierre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 619)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TaskPane1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmCierre"
        Me.Text = "Recibidos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LecturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TaskPane1.ResumeLayout(False)
        Me.TaskFrame2.ResumeLayout(False)
        Me.TaskFrame2.PerformLayout()
        Me.TaskFrame5.ResumeLayout(False)
        Me.TaskFrame5.PerformLayout()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.LecturasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.nudPaquete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmnuInsertar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TaskPane1 As WindowsControlLibrary.TaskPane
    Friend WithEvents TaskFrame2 As WindowsControlLibrary.TaskFrame
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents chkFiltraError As System.Windows.Forms.CheckBox
    Friend WithEvents TaskFrame5 As WindowsControlLibrary.TaskFrame
    Friend WithEvents SucursalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lblDIF As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblCHQCant As System.Windows.Forms.Label
    Friend WithEvents lblCHQ As System.Windows.Forms.Label
    Friend WithEvents lblCABCant As System.Windows.Forms.Label
    Friend WithEvents lblCAB As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LecturasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cod_maquina As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents IdLectura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents tbcSerie As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents Importe As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents cod_sucursal As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents nudPaquete As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblPaquete As System.Windows.Forms.Label
End Class
