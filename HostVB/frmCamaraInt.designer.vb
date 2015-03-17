<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCamaraInt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCamaraInt))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.colcod_tipdoc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Edit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colmonto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MontoEditor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colConError = New DevExpress.XtraGrid.Columns.GridColumn
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
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.TaskPane1 = New WindowsControlLibrary.TaskPane
        Me.TaskFrame1 = New WindowsControlLibrary.TaskFrame
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.cboBuscar = New System.Windows.Forms.ComboBox
        Me.lnkBuscar = New System.Windows.Forms.LinkLabel
        Me.tfValidar = New WindowsControlLibrary.TaskFrame
        Me.chkLotesConError = New System.Windows.Forms.CheckBox
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.chkFiltraError = New System.Windows.Forms.CheckBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.TaskFrame4 = New WindowsControlLibrary.TaskFrame
        Me.LinkPaqueteAct = New System.Windows.Forms.LinkLabel
        Me.nudPaquete = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.PanelMotivoDevolucion = New System.Windows.Forms.Panel
        Me.txtMotivo = New System.Windows.Forms.TextBox
        Me.lnkMotivo = New System.Windows.Forms.LinkLabel
        Me.cboMotivo = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.lnkReasignar = New System.Windows.Forms.LinkLabel
        Me.txtSucursal = New System.Windows.Forms.TextBox
        Me.nudLote = New System.Windows.Forms.NumericUpDown
        Me.lnkSucursal = New System.Windows.Forms.LinkLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboCajero = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboSucursal = New System.Windows.Forms.ComboBox
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
        Me.LecturasGridControl = New DevExpress.XtraGrid.GridControl
        Me.LecturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LecturaView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colnro_paquete = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnro_lote = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcod_banco_receptor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcuenta_cheque = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Edit12 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colnumero_cheque = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Edit8 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colcod_banco_emisor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcod_camara = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcod_sucursal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcuenta_deposito = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcabecera = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdMotivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colENVIADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdLectura = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcadena_captura = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNroError = New DevExpress.XtraGrid.Columns.GridColumn
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
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TaskPane2 = New WindowsControlLibrary.TaskPane
        Me.tfCheque = New WindowsControlLibrary.TaskFrame
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.ImagenBase1 = New HostVB.ImagenBase
        Me.tfCHERFII = New WindowsControlLibrary.TaskFrame
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel
        Me.chkValidarFiltrar = New System.Windows.Forms.CheckBox
        Me.CHERFIIGridControl = New DevExpress.XtraGrid.GridControl
        Me.CHERFIIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCtaLibradora = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNroCheque = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComprobante = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colImporte = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCtaDeposito = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.ChkCorregir = New System.Windows.Forms.CheckBox
        Me.lnkValidarCHER = New System.Windows.Forms.LinkLabel
        Me.tfCHITCI = New WindowsControlLibrary.TaskFrame
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.CHITCIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCtaDeposito1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMoneda = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colImporte1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCantCheques = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ErroresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuInsertar = New System.Windows.Forms.ToolStripMenuItem
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Worker = New System.ComponentModel.BackgroundWorker
        Me.CRECDetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MotivosRechazoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel
        CType(Me.Edit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MontoEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TaskPane1.SuspendLayout()
        Me.TaskFrame1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.tfValidar.SuspendLayout()
        Me.TaskFrame4.SuspendLayout()
        CType(Me.nudPaquete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMotivoDevolucion.SuspendLayout()
        CType(Me.nudLote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TaskFrame5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.LecturasGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LecturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LecturaView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Edit12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Edit8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.DataRepeater1.ItemTemplate.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        Me.TaskPane2.SuspendLayout()
        Me.tfCheque.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.tfCHERFII.SuspendLayout()
        CType(Me.CHERFIIGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHERFIIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tfCHITCI.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHITCIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErroresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.CRECDetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MotivosRechazoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.colcod_tipdoc.VisibleIndex = 3
        Me.colcod_tipdoc.Width = 43
        '
        'Edit2
        '
        Me.Edit2.AutoHeight = False
        Me.Edit2.MaxLength = 2
        Me.Edit2.Name = "Edit2"
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
        Me.colmonto.VisibleIndex = 8
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
        'colConError
        '
        Me.colConError.Caption = "Errores"
        Me.colConError.FieldName = "ConError"
        Me.colConError.MinWidth = 30
        Me.colConError.Name = "colConError"
        Me.colConError.OptionsColumn.AllowEdit = False
        Me.colConError.Visible = True
        Me.colConError.VisibleIndex = 12
        Me.colConError.Width = 30
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbIniciarCaptura, Me.ToolStripButton1, Me.tsbErrores, Me.ToolStripButton2, Me.ToolStripButton3, Me.tsEliminar, Me.tsbCargar, Me.tsbDescargar, Me.ToolStripButton6, Me.cmdImportar, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(893, 38)
        Me.ToolStrip1.TabIndex = 32
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
        Me.cmdImportar.Size = New System.Drawing.Size(53, 35)
        Me.cmdImportar.Text = "CHERFII"
        Me.cmdImportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdImportar.ToolTipText = "Importar CREC"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(49, 35)
        Me.ToolStripButton4.Text = "CHITCI"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TaskPane1
        '
        Me.TaskPane1.AutoScroll = True
        Me.TaskPane1.AutoScrollMinSize = New System.Drawing.Size(0, 699)
        Me.TaskPane1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TaskPane1.Controls.Add(Me.TaskFrame1)
        Me.TaskPane1.Controls.Add(Me.tfValidar)
        Me.TaskPane1.Controls.Add(Me.TaskFrame4)
        Me.TaskPane1.Controls.Add(Me.TaskFrame5)
        Me.TaskPane1.CornerStyle = WindowsControlLibrary.TaskFrameCornerStyle.SystemDefault
        Me.TaskPane1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TaskPane1.Location = New System.Drawing.Point(688, 38)
        Me.TaskPane1.Name = "TaskPane1"
        Me.TaskPane1.Size = New System.Drawing.Size(205, 572)
        Me.TaskPane1.TabIndex = 35
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
        'tfValidar
        '
        Me.tfValidar.AllowDrop = True
        Me.tfValidar.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tfValidar.CaptionBlend = New WindowsControlLibrary.BlendFill(WindowsControlLibrary.BlendStyle.Horizontal, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(230, Byte), Integer)))
        Me.tfValidar.Controls.Add(Me.chkLotesConError)
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
        'chkLotesConError
        '
        Me.chkLotesConError.AutoSize = True
        Me.chkLotesConError.Location = New System.Drawing.Point(6, 61)
        Me.chkLotesConError.Name = "chkLotesConError"
        Me.chkLotesConError.Size = New System.Drawing.Size(142, 17)
        Me.chkLotesConError.TabIndex = 5
        Me.chkLotesConError.Text = "Solo Lotes con Error"
        Me.chkLotesConError.UseVisualStyleBackColor = True
        Me.chkLotesConError.Visible = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(3, 42)
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
        Me.TaskFrame4.Controls.Add(Me.LinkPaqueteAct)
        Me.TaskFrame4.Controls.Add(Me.nudPaquete)
        Me.TaskFrame4.Controls.Add(Me.Label2)
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
        Me.TaskFrame4.Size = New System.Drawing.Size(163, 300)
        Me.TaskFrame4.TabIndex = 7
        Me.TaskFrame4.Text = "Opciones"
        '
        'LinkPaqueteAct
        '
        Me.LinkPaqueteAct.AutoEllipsis = True
        Me.LinkPaqueteAct.AutoSize = True
        Me.LinkPaqueteAct.Location = New System.Drawing.Point(2, 43)
        Me.LinkPaqueteAct.Name = "LinkPaqueteAct"
        Me.LinkPaqueteAct.Size = New System.Drawing.Size(204, 13)
        Me.LinkPaqueteAct.TabIndex = 9
        Me.LinkPaqueteAct.TabStop = True
        Me.LinkPaqueteAct.Text = "Asignar registros al paquete actual"
        '
        'nudPaquete
        '
        Me.nudPaquete.Location = New System.Drawing.Point(116, 14)
        Me.nudPaquete.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudPaquete.Name = "nudPaquete"
        Me.nudPaquete.Size = New System.Drawing.Size(44, 20)
        Me.nudPaquete.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Paquete Actual"
        '
        'PanelMotivoDevolucion
        '
        Me.PanelMotivoDevolucion.Controls.Add(Me.txtMotivo)
        Me.PanelMotivoDevolucion.Controls.Add(Me.lnkMotivo)
        Me.PanelMotivoDevolucion.Controls.Add(Me.cboMotivo)
        Me.PanelMotivoDevolucion.Controls.Add(Me.Label8)
        Me.PanelMotivoDevolucion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelMotivoDevolucion.Location = New System.Drawing.Point(0, 216)
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
        Me.lnkReasignar.Location = New System.Drawing.Point(0, 79)
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
        Me.txtSucursal.Location = New System.Drawing.Point(3, 116)
        Me.txtSucursal.MaxLength = 2
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(31, 29)
        Me.txtSucursal.TabIndex = 5
        '
        'nudLote
        '
        Me.nudLote.Location = New System.Drawing.Point(116, 58)
        Me.nudLote.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudLote.Name = "nudLote"
        Me.nudLote.Size = New System.Drawing.Size(44, 20)
        Me.nudLote.TabIndex = 1
        '
        'lnkSucursal
        '
        Me.lnkSucursal.AutoEllipsis = True
        Me.lnkSucursal.AutoSize = True
        Me.lnkSucursal.Location = New System.Drawing.Point(-3, 153)
        Me.lnkSucursal.Name = "lnkSucursal"
        Me.lnkSucursal.Size = New System.Drawing.Size(167, 13)
        Me.lnkSucursal.TabIndex = 4
        Me.lnkSucursal.TabStop = True
        Me.lnkSucursal.Text = "Asignar a la Sucursal Actual"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 62)
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
        Me.cboCajero.Location = New System.Drawing.Point(0, 191)
        Me.cboCajero.Name = "cboCajero"
        Me.cboCajero.Size = New System.Drawing.Size(161, 21)
        Me.cboCajero.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(0, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Cajero"
        '
        'cboSucursal
        '
        Me.cboSucursal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSucursal.DisplayMember = "nombre_sucusal"
        Me.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSucursal.FormattingEnabled = True
        Me.cboSucursal.Location = New System.Drawing.Point(36, 120)
        Me.cboSucursal.Name = "cboSucursal"
        Me.cboSucursal.Size = New System.Drawing.Size(126, 21)
        Me.cboSucursal.TabIndex = 1
        Me.cboSucursal.ValueMember = "cod_sucursal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 101)
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
        Me.TaskFrame5.Location = New System.Drawing.Point(12, 587)
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
        Me.TableLayoutPanel3.Controls.Add(Me.LecturasGridControl, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.MenuStrip1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DataRepeater1, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.TaskPane2, 0, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 38)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(688, 572)
        Me.TableLayoutPanel3.TabIndex = 36
        '
        'LecturasGridControl
        '
        Me.LecturasGridControl.DataSource = Me.LecturasBindingSource
        Me.LecturasGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LecturasGridControl.Location = New System.Drawing.Point(3, 4)
        Me.LecturasGridControl.LookAndFeel.SkinName = "Lilian"
        Me.LecturasGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LecturasGridControl.MainView = Me.LecturaView
        Me.LecturasGridControl.Name = "LecturasGridControl"
        Me.LecturasGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Edit2, Me.Edit12, Me.Edit8, Me.MontoEditor})
        Me.LecturasGridControl.Size = New System.Drawing.Size(682, 194)
        Me.LecturasGridControl.TabIndex = 36
        Me.LecturasGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.LecturaView})
        '
        'LecturasBindingSource
        '
        Me.LecturasBindingSource.DataSource = GetType(DataAccess.Lecturas)
        '
        'LecturaView
        '
        Me.LecturaView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnro_paquete, Me.colnro_lote, Me.colcod_banco_receptor, Me.colcod_tipdoc, Me.colcuenta_cheque, Me.colnumero_cheque, Me.colcod_banco_emisor, Me.colcod_camara, Me.colmonto, Me.colcod_sucursal, Me.colcuenta_deposito, Me.colcabecera, Me.colConError, Me.colIdMotivo, Me.colENVIADO, Me.colIdLectura, Me.colcadena_captura, Me.colNroError})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colcod_tipdoc
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Expression = "[cod_tipdoc] == '90'"
        StyleFormatCondition1.Value1 = "90"
        StyleFormatCondition2.Appearance.BorderColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Options.UseBorderColor = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.colmonto
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = New Decimal(New Integer() {0, 0, 0, 0})
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.colConError
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = True
        Me.LecturaView.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.LecturaView.GridControl = Me.LecturasGridControl
        Me.LecturaView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "monto", Nothing, "Cab {0:N0}", 1), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "monto", Nothing, "Det {0:N0}", 2), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "monto", Nothing, "Dif {0:N0}", 3), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ConError", Nothing, "Err {0:N0}")})
        Me.LecturaView.Name = "LecturaView"
        Me.LecturaView.OptionsSelection.MultiSelect = True
        Me.LecturaView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.LecturaView.OptionsView.ColumnAutoWidth = False
        Me.LecturaView.OptionsView.ShowDetailButtons = False
        Me.LecturaView.OptionsView.ShowFooter = True
        '
        'colnro_paquete
        '
        Me.colnro_paquete.Caption = "Paquete"
        Me.colnro_paquete.FieldName = "PAQUETE"
        Me.colnro_paquete.MinWidth = 30
        Me.colnro_paquete.Name = "colnro_paquete"
        Me.colnro_paquete.OptionsColumn.AllowEdit = False
        Me.colnro_paquete.Visible = True
        Me.colnro_paquete.VisibleIndex = 0
        Me.colnro_paquete.Width = 41
        '
        'colnro_lote
        '
        Me.colnro_lote.Caption = "Lote"
        Me.colnro_lote.FieldName = "nro_lote"
        Me.colnro_lote.MinWidth = 30
        Me.colnro_lote.Name = "colnro_lote"
        Me.colnro_lote.OptionsColumn.AllowEdit = False
        Me.colnro_lote.Visible = True
        Me.colnro_lote.VisibleIndex = 1
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
        Me.colcod_banco_receptor.VisibleIndex = 2
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
        Me.colcuenta_cheque.VisibleIndex = 4
        Me.colcuenta_cheque.Width = 58
        '
        'Edit12
        '
        Me.Edit12.AutoHeight = False
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
        Me.colnumero_cheque.VisibleIndex = 5
        Me.colnumero_cheque.Width = 53
        '
        'Edit8
        '
        Me.Edit8.AutoHeight = False
        Me.Edit8.Mask.BeepOnError = True
        Me.Edit8.Mask.EditMask = "00000000"
        Me.Edit8.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Edit8.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(48)
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
        Me.colcod_banco_emisor.VisibleIndex = 6
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
        Me.colcod_camara.VisibleIndex = 7
        Me.colcod_camara.Width = 43
        '
        'colcod_sucursal
        '
        Me.colcod_sucursal.Caption = "Suc"
        Me.colcod_sucursal.ColumnEdit = Me.Edit2
        Me.colcod_sucursal.FieldName = "cod_sucursal"
        Me.colcod_sucursal.MinWidth = 30
        Me.colcod_sucursal.Name = "colcod_sucursal"
        Me.colcod_sucursal.Visible = True
        Me.colcod_sucursal.VisibleIndex = 9
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
        Me.colcuenta_deposito.VisibleIndex = 10
        Me.colcuenta_deposito.Width = 92
        '
        'colcabecera
        '
        Me.colcabecera.Caption = "Secuencia"
        Me.colcabecera.FieldName = "cabecera"
        Me.colcabecera.MinWidth = 30
        Me.colcabecera.Name = "colcabecera"
        Me.colcabecera.OptionsColumn.AllowEdit = False
        Me.colcabecera.Visible = True
        Me.colcabecera.VisibleIndex = 11
        Me.colcabecera.Width = 43
        '
        'colIdMotivo
        '
        Me.colIdMotivo.Caption = "Motivo"
        Me.colIdMotivo.FieldName = "IdMotivo"
        Me.colIdMotivo.MinWidth = 30
        Me.colIdMotivo.Name = "colIdMotivo"
        Me.colIdMotivo.Visible = True
        Me.colIdMotivo.VisibleIndex = 13
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
        Me.colENVIADO.VisibleIndex = 14
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
        Me.colIdLectura.VisibleIndex = 15
        Me.colIdLectura.Width = 40
        '
        'colcadena_captura
        '
        Me.colcadena_captura.Caption = "Cadena"
        Me.colcadena_captura.FieldName = "cadena_captura"
        Me.colcadena_captura.Name = "colcadena_captura"
        Me.colcadena_captura.OptionsColumn.AllowEdit = False
        Me.colcadena_captura.Visible = True
        Me.colcadena_captura.VisibleIndex = 16
        Me.colcadena_captura.Width = 24
        '
        'colNroError
        '
        Me.colNroError.FieldName = "NroError"
        Me.colNroError.Name = "colNroError"
        Me.colNroError.OptionsColumn.AllowEdit = False
        Me.colNroError.Visible = True
        Me.colNroError.VisibleIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 404)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(682, 21)
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
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(682, 25)
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
        Me.MenuStrip1.Size = New System.Drawing.Size(163, 1)
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
        Me.DataRepeater1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataRepeater1.ItemHeaderVisible = False
        '
        'DataRepeater1.ItemTemplate
        '
        Me.DataRepeater1.ItemTemplate.AutoSize = True
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Label7)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Label5)
        Me.DataRepeater1.ItemTemplate.Margin = New System.Windows.Forms.Padding(0)
        Me.DataRepeater1.ItemTemplate.Size = New System.Drawing.Size(674, 20)
        Me.DataRepeater1.Location = New System.Drawing.Point(3, 431)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(682, 138)
        Me.DataRepeater1.TabIndex = 35
        Me.DataRepeater1.Text = "DataRepeater1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Label7"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Label5"
        '
        'TaskPane2
        '
        Me.TaskPane2.AutoScroll = True
        Me.TaskPane2.AutoScrollMinSize = New System.Drawing.Size(0, 533)
        Me.TaskPane2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TaskPane2.Controls.Add(Me.tfCheque)
        Me.TaskPane2.Controls.Add(Me.tfCHERFII)
        Me.TaskPane2.Controls.Add(Me.tfCHITCI)
        Me.TaskPane2.CornerStyle = WindowsControlLibrary.TaskFrameCornerStyle.SystemDefault
        Me.TaskPane2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TaskPane2.Location = New System.Drawing.Point(3, 204)
        Me.TaskPane2.Name = "TaskPane2"
        Me.TaskPane2.Padding = 0
        Me.TaskPane2.Size = New System.Drawing.Size(682, 194)
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
        Me.tfCheque.Location = New System.Drawing.Point(0, 21)
        Me.tfCheque.Name = "tfCheque"
        Me.tfCheque.Size = New System.Drawing.Size(664, 250)
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
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(664, 250)
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
        Me.ImagenBase1.Size = New System.Drawing.Size(658, 244)
        Me.ImagenBase1.TabIndex = 0
        '
        'tfCHERFII
        '
        Me.tfCHERFII.AllowDrop = True
        Me.tfCHERFII.AutoScroll = True
        Me.tfCHERFII.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tfCHERFII.CaptionBlend = New WindowsControlLibrary.BlendFill(WindowsControlLibrary.BlendStyle.Horizontal, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(230, Byte), Integer)))
        Me.tfCHERFII.Controls.Add(Me.LinkLabel3)
        Me.tfCHERFII.Controls.Add(Me.chkValidarFiltrar)
        Me.tfCHERFII.Controls.Add(Me.CHERFIIGridControl)
        Me.tfCHERFII.Controls.Add(Me.ChkCorregir)
        Me.tfCHERFII.Controls.Add(Me.lnkValidarCHER)
        Me.tfCHERFII.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tfCHERFII.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.tfCHERFII.IsExpanded = False
        Me.tfCHERFII.Location = New System.Drawing.Point(0, 292)
        Me.tfCHERFII.Name = "tfCREC"
        Me.tfCHERFII.Size = New System.Drawing.Size(664, 110)
        Me.tfCHERFII.TabIndex = 3
        Me.tfCHERFII.Text = "Archivo CHERFII"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(523, 5)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(79, 13)
        Me.LinkLabel3.TabIndex = 15
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Leer Archivo"
        '
        'chkValidarFiltrar
        '
        Me.chkValidarFiltrar.AutoSize = True
        Me.chkValidarFiltrar.Location = New System.Drawing.Point(524, 64)
        Me.chkValidarFiltrar.Name = "chkValidarFiltrar"
        Me.chkValidarFiltrar.Size = New System.Drawing.Size(199, 17)
        Me.chkValidarFiltrar.TabIndex = 14
        Me.chkValidarFiltrar.Text = "Validar CHERFII al Filtrar Error"
        Me.chkValidarFiltrar.UseVisualStyleBackColor = True
        '
        'CHERFIIGridControl
        '
        Me.CHERFIIGridControl.DataSource = Me.CHERFIIBindingSource
        Me.CHERFIIGridControl.Location = New System.Drawing.Point(6, 4)
        Me.CHERFIIGridControl.LookAndFeel.SkinName = "Lilian"
        Me.CHERFIIGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.CHERFIIGridControl.MainView = Me.GridView2
        Me.CHERFIIGridControl.Name = "CHERFIIGridControl"
        Me.CHERFIIGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3})
        Me.CHERFIIGridControl.Size = New System.Drawing.Size(511, 85)
        Me.CHERFIIGridControl.TabIndex = 13
        Me.CHERFIIGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'CHERFIIBindingSource
        '
        Me.CHERFIIBindingSource.DataSource = GetType(DataAccess.CHERFII)
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCtaLibradora, Me.colNroCheque, Me.colComprobante, Me.colImporte, Me.colCtaDeposito})
        Me.GridView2.GridControl = Me.CHERFIIGridControl
        Me.GridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", Nothing, "{0:N0}")})
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colCtaLibradora
        '
        Me.colCtaLibradora.FieldName = "CtaLibradora"
        Me.colCtaLibradora.Name = "colCtaLibradora"
        Me.colCtaLibradora.OptionsColumn.ReadOnly = True
        Me.colCtaLibradora.Visible = True
        Me.colCtaLibradora.VisibleIndex = 0
        '
        'colNroCheque
        '
        Me.colNroCheque.FieldName = "NroCheque"
        Me.colNroCheque.Name = "colNroCheque"
        Me.colNroCheque.OptionsColumn.ReadOnly = True
        Me.colNroCheque.Visible = True
        Me.colNroCheque.VisibleIndex = 1
        '
        'colComprobante
        '
        Me.colComprobante.FieldName = "Comprobante"
        Me.colComprobante.Name = "colComprobante"
        Me.colComprobante.OptionsColumn.ReadOnly = True
        Me.colComprobante.Visible = True
        Me.colComprobante.VisibleIndex = 2
        '
        'colImporte
        '
        Me.colImporte.FieldName = "Importe"
        Me.colImporte.Name = "colImporte"
        Me.colImporte.OptionsColumn.ReadOnly = True
        Me.colImporte.Visible = True
        Me.colImporte.VisibleIndex = 3
        '
        'colCtaDeposito
        '
        Me.colCtaDeposito.FieldName = "CtaDeposito"
        Me.colCtaDeposito.Name = "colCtaDeposito"
        Me.colCtaDeposito.OptionsColumn.ReadOnly = True
        Me.colCtaDeposito.Visible = True
        Me.colCtaDeposito.VisibleIndex = 4
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
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Mask.EditMask = "00000000"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.MaxLength = 8
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Mask.EditMask = "N0"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'ChkCorregir
        '
        Me.ChkCorregir.AutoSize = True
        Me.ChkCorregir.Location = New System.Drawing.Point(524, 43)
        Me.ChkCorregir.Name = "ChkCorregir"
        Me.ChkCorregir.Size = New System.Drawing.Size(143, 17)
        Me.ChkCorregir.TabIndex = 13
        Me.ChkCorregir.Text = "Aplicar Correcciones"
        Me.ChkCorregir.UseVisualStyleBackColor = True
        '
        'lnkValidarCHER
        '
        Me.lnkValidarCHER.AutoSize = True
        Me.lnkValidarCHER.Location = New System.Drawing.Point(523, 25)
        Me.lnkValidarCHER.Name = "lnkValidarCHER"
        Me.lnkValidarCHER.Size = New System.Drawing.Size(107, 13)
        Me.lnkValidarCHER.TabIndex = 5
        Me.lnkValidarCHER.TabStop = True
        Me.lnkValidarCHER.Text = "Verificar CHERFII"
        '
        'tfCHITCI
        '
        Me.tfCHITCI.AllowDrop = True
        Me.tfCHITCI.AutoScroll = True
        Me.tfCHITCI.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.tfCHITCI.CaptionBlend = New WindowsControlLibrary.BlendFill(WindowsControlLibrary.BlendStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(252, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(212, Byte), Integer)))
        Me.tfCHITCI.Controls.Add(Me.LinkLabel4)
        Me.tfCHITCI.Controls.Add(Me.CheckBox1)
        Me.tfCHITCI.Controls.Add(Me.GridControl1)
        Me.tfCHITCI.Controls.Add(Me.CheckBox2)
        Me.tfCHITCI.Controls.Add(Me.LinkLabel5)
        Me.tfCHITCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tfCHITCI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.tfCHITCI.Location = New System.Drawing.Point(0, 423)
        Me.tfCHITCI.Name = "tfCHITCII"
        Me.tfCHITCI.Size = New System.Drawing.Size(664, 110)
        Me.tfCHITCI.TabIndex = 5
        Me.tfCHITCI.Text = "Archivo CHITCI"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(529, 14)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(79, 13)
        Me.LinkLabel4.TabIndex = 20
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Leer Archivo"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(530, 73)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(191, 17)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "Validar CHITCI al Filtrar Error"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.CHITCIBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 7)
        Me.GridControl1.LookAndFeel.SkinName = "Lilian"
        Me.GridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit4, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6})
        Me.GridControl1.Size = New System.Drawing.Size(511, 85)
        Me.GridControl1.TabIndex = 18
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'CHITCIBindingSource
        '
        Me.CHITCIBindingSource.DataSource = GetType(DataAccess.CHITCI)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCtaDeposito1, Me.colMoneda, Me.colImporte1, Me.colCantCheques})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", Nothing, "{0:N0}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colCtaDeposito1
        '
        Me.colCtaDeposito1.FieldName = "CtaDeposito"
        Me.colCtaDeposito1.Name = "colCtaDeposito1"
        Me.colCtaDeposito1.OptionsColumn.ReadOnly = True
        Me.colCtaDeposito1.Visible = True
        Me.colCtaDeposito1.VisibleIndex = 0
        '
        'colMoneda
        '
        Me.colMoneda.FieldName = "Moneda"
        Me.colMoneda.Name = "colMoneda"
        Me.colMoneda.OptionsColumn.ReadOnly = True
        Me.colMoneda.Visible = True
        Me.colMoneda.VisibleIndex = 1
        '
        'colImporte1
        '
        Me.colImporte1.FieldName = "Importe"
        Me.colImporte1.Name = "colImporte1"
        Me.colImporte1.OptionsColumn.ReadOnly = True
        Me.colImporte1.Visible = True
        Me.colImporte1.VisibleIndex = 2
        '
        'colCantCheques
        '
        Me.colCantCheques.FieldName = "CantCheques"
        Me.colCantCheques.Name = "colCantCheques"
        Me.colCantCheques.OptionsColumn.ReadOnly = True
        Me.colCantCheques.Visible = True
        Me.colCantCheques.VisibleIndex = 3
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Mask.EditMask = "000000000000"
        Me.RepositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit4.MaxLength = 12
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.Mask.EditMask = "00000000"
        Me.RepositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit5.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit5.MaxLength = 8
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.Mask.EditMask = "N0"
        Me.RepositoryItemTextEdit6.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit6.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(530, 52)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(143, 17)
        Me.CheckBox2.TabIndex = 17
        Me.CheckBox2.Text = "Aplicar Correcciones"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Location = New System.Drawing.Point(529, 34)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(99, 13)
        Me.LinkLabel5.TabIndex = 16
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Verificar CHITCI"
        '
        'SucursalesBindingSource
        '
        Me.SucursalesBindingSource.DataSource = GetType(DataAccess.Sucursales)
        '
        'ErroresBindingSource
        '
        Me.ErroresBindingSource.AllowNew = False
        Me.ErroresBindingSource.DataMember = "Errores"
        Me.ErroresBindingSource.DataSource = Me.LecturasBindingSource
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
        'Worker
        '
        Me.Worker.WorkerReportsProgress = True
        Me.Worker.WorkerSupportsCancellation = True
        '
        'CRECDetBindingSource
        '
        Me.CRECDetBindingSource.DataSource = GetType(DataAccess.CRECDet)
        '
        'MotivosRechazoBindingSource
        '
        Me.MotivosRechazoBindingSource.DataSource = GetType(ClearingDA.MotivosRechazo)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LinkLabel6
        '
        Me.LinkLabel6.AutoSize = True
        Me.LinkLabel6.Location = New System.Drawing.Point(523, 5)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(83, 13)
        Me.LinkLabel6.TabIndex = 15
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "Subir Archivo"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(524, 64)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(199, 17)
        Me.CheckBox3.TabIndex = 14
        Me.CheckBox3.Text = "Validar CHERFII al Filtrar Error"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.CHERFIIBindingSource
        Me.GridControl2.Location = New System.Drawing.Point(6, -1)
        Me.GridControl2.LookAndFeel.SkinName = "Lilian"
        Me.GridControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl2.MainView = Me.GridView3
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit7, Me.RepositoryItemTextEdit8, Me.RepositoryItemTextEdit9})
        Me.GridControl2.Size = New System.Drawing.Size(511, 85)
        Me.GridControl2.TabIndex = 13
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.GridView3.GridControl = Me.GridControl2
        Me.GridView3.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", Nothing, "{0:N0}")})
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "CtaLibradora"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        '
        'GridColumn7
        '
        Me.GridColumn7.FieldName = "NroCheque"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        '
        'GridColumn8
        '
        Me.GridColumn8.FieldName = "Comprobante"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        '
        'GridColumn9
        '
        Me.GridColumn9.FieldName = "Importe"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 3
        '
        'GridColumn10
        '
        Me.GridColumn10.FieldName = "CtaDeposito"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 4
        '
        'RepositoryItemTextEdit7
        '
        Me.RepositoryItemTextEdit7.AutoHeight = False
        Me.RepositoryItemTextEdit7.Mask.EditMask = "000000000000"
        Me.RepositoryItemTextEdit7.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit7.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit7.MaxLength = 12
        Me.RepositoryItemTextEdit7.Name = "RepositoryItemTextEdit7"
        '
        'RepositoryItemTextEdit8
        '
        Me.RepositoryItemTextEdit8.AutoHeight = False
        Me.RepositoryItemTextEdit8.Mask.EditMask = "00000000"
        Me.RepositoryItemTextEdit8.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit8.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit8.MaxLength = 8
        Me.RepositoryItemTextEdit8.Name = "RepositoryItemTextEdit8"
        '
        'RepositoryItemTextEdit9
        '
        Me.RepositoryItemTextEdit9.AutoHeight = False
        Me.RepositoryItemTextEdit9.Mask.EditMask = "N0"
        Me.RepositoryItemTextEdit9.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit9.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit9.Name = "RepositoryItemTextEdit9"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(524, 43)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(143, 17)
        Me.CheckBox4.TabIndex = 13
        Me.CheckBox4.Text = "Aplicar Correcciones"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'LinkLabel7
        '
        Me.LinkLabel7.AutoSize = True
        Me.LinkLabel7.Location = New System.Drawing.Point(523, 25)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(107, 13)
        Me.LinkLabel7.TabIndex = 5
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "Verificar CHERFII"
        '
        'frmCamaraInt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 610)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TaskPane1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmCamaraInt"
        Me.Text = "frmCamaraInt"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Edit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MontoEditor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TaskPane1.ResumeLayout(False)
        Me.TaskPane1.PerformLayout()
        Me.TaskFrame1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.tfValidar.ResumeLayout(False)
        Me.tfValidar.PerformLayout()
        Me.TaskFrame4.ResumeLayout(False)
        Me.TaskFrame4.PerformLayout()
        CType(Me.nudPaquete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMotivoDevolucion.ResumeLayout(False)
        Me.PanelMotivoDevolucion.PerformLayout()
        CType(Me.nudLote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TaskFrame5.ResumeLayout(False)
        Me.TaskFrame5.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.LecturasGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LecturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LecturaView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Edit12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Edit8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.DataRepeater1.ItemTemplate.ResumeLayout(False)
        Me.DataRepeater1.ItemTemplate.PerformLayout()
        Me.DataRepeater1.ResumeLayout(False)
        Me.DataRepeater1.PerformLayout()
        Me.TaskPane2.ResumeLayout(False)
        Me.tfCheque.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.tfCHERFII.ResumeLayout(False)
        Me.tfCHERFII.PerformLayout()
        CType(Me.CHERFIIGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHERFIIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tfCHITCI.ResumeLayout(False)
        Me.tfCHITCI.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHITCIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErroresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.CRECDetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MotivosRechazoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbIniciarCaptura As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbErrores As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCargar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbDescargar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdImportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TaskPane1 As WindowsControlLibrary.TaskPane
    Friend WithEvents TaskFrame1 As WindowsControlLibrary.TaskFrame
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents cboBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents lnkBuscar As System.Windows.Forms.LinkLabel
    Friend WithEvents tfValidar As WindowsControlLibrary.TaskFrame
    Friend WithEvents chkLotesConError As System.Windows.Forms.CheckBox
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents chkFiltraError As System.Windows.Forms.CheckBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents TaskFrame4 As WindowsControlLibrary.TaskFrame
    Friend WithEvents PanelMotivoDevolucion As System.Windows.Forms.Panel
    Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents lnkMotivo As System.Windows.Forms.LinkLabel
    Friend WithEvents cboMotivo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lnkReasignar As System.Windows.Forms.LinkLabel
    Friend WithEvents txtSucursal As System.Windows.Forms.TextBox
    Friend WithEvents nudLote As System.Windows.Forms.NumericUpDown
    Friend WithEvents lnkSucursal As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboCajero As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TaskFrame5 As WindowsControlLibrary.TaskFrame
    Friend WithEvents lnkFecha As System.Windows.Forms.LinkLabel
    Friend WithEvents lblDIF As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblCHQCant As System.Windows.Forms.Label
    Friend WithEvents lblCHQ As System.Windows.Forms.Label
    Friend WithEvents lblCABCant As System.Windows.Forms.Label
    Friend WithEvents lblCAB As System.Windows.Forms.Label
    Friend WithEvents LinkPaqueteAct As System.Windows.Forms.LinkLabel
    Friend WithEvents nudPaquete As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LecturasGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents LecturaView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnro_lote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcod_banco_receptor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Edit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colcod_tipdoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcuenta_cheque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Edit12 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colnumero_cheque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Edit8 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colcod_banco_emisor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcod_camara As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MontoEditor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colcod_sucursal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcuenta_deposito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcabecera As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConError As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdMotivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colENVIADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdLectura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcadena_captura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNroError As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSubTotalCab As System.Windows.Forms.Label
    Friend WithEvents txtSubTotalCab As System.Windows.Forms.Label
    Friend WithEvents lblSubTotalDet As System.Windows.Forms.Label
    Friend WithEvents txtSubTotalDet As System.Windows.Forms.Label
    Friend WithEvents lblSubDif As System.Windows.Forms.Label
    Friend WithEvents txtSubDif As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents txtErrores As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents LecturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IniciarCapturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ValidarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FiltrarErroresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataRepeater1 As Microsoft.VisualBasic.PowerPacks.DataRepeater
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TaskPane2 As WindowsControlLibrary.TaskPane
    Friend WithEvents tfCheque As WindowsControlLibrary.TaskFrame
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ImagenBase1 As HostVB.ImagenBase
    Friend WithEvents tfCHERFII As WindowsControlLibrary.TaskFrame
    Friend WithEvents chkValidarFiltrar As System.Windows.Forms.CheckBox
    Friend WithEvents CHERFIIGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ChkCorregir As System.Windows.Forms.CheckBox
    Friend WithEvents lnkValidarCHER As System.Windows.Forms.LinkLabel
    Friend WithEvents LecturasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SucursalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ErroresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmnuInsertar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents CRECDetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MotivosRechazoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colnro_paquete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CHERFIIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colCtaLibradora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNroCheque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComprobante As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCtaDeposito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tfCHITCI As WindowsControlLibrary.TaskFrame
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents LinkLabel5 As System.Windows.Forms.LinkLabel
    Friend WithEvents CHITCIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colCtaDeposito1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMoneda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporte1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantCheques As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LinkLabel6 As System.Windows.Forms.LinkLabel
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents LinkLabel7 As System.Windows.Forms.LinkLabel
End Class
