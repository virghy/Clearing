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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecibido))
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim AutoHideGroup5 As Telerik.WinControls.UI.Docking.AutoHideGroup = New Telerik.WinControls.UI.Docking.AutoHideGroup()
        Dim AutoHideGroup6 As Telerik.WinControls.UI.Docking.AutoHideGroup = New Telerik.WinControls.UI.Docking.AutoHideGroup()
        Dim AutoHideGroup7 As Telerik.WinControls.UI.Docking.AutoHideGroup = New Telerik.WinControls.UI.Docking.AutoHideGroup()
        Dim AutoHideGroup8 As Telerik.WinControls.UI.Docking.AutoHideGroup = New Telerik.WinControls.UI.Docking.AutoHideGroup()
        Me.colcod_tipdoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Edit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colmonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MontoEditor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DockWindowPlaceholder1 = New Telerik.WinControls.UI.Docking.DockWindowPlaceholder()
        Me.DockWindowPlaceholder2 = New Telerik.WinControls.UI.Docking.DockWindowPlaceholder()
        Me.DockWindowPlaceholder3 = New Telerik.WinControls.UI.Docking.DockWindowPlaceholder()
        Me.DockWindowPlaceholder4 = New Telerik.WinControls.UI.Docking.DockWindowPlaceholder()
        Me.colConError = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Worker = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LecturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuInsertar = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbIniciarCaptura = New System.Windows.Forms.ToolStripButton()
        Me.tsbValidar = New System.Windows.Forms.ToolStripButton()
        Me.tsbErrores = New System.Windows.Forms.ToolStripButton()
        Me.tsbInsertar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCargar = New System.Windows.Forms.ToolStripButton()
        Me.tsbDescargar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.cmdImportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.tsbCierre = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cboBuscar = New System.Windows.Forms.ComboBox()
        Me.lnkBuscar = New System.Windows.Forms.LinkLabel()
        Me.tpOpciones = New WindowsControlLibrary.TaskPane()
        Me.TaskFrame1 = New WindowsControlLibrary.TaskFrame()
        Me.tfValidar = New WindowsControlLibrary.TaskFrame()
        Me.chkLotesConError = New System.Windows.Forms.CheckBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.chkFiltraError = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.tfOpciones = New WindowsControlLibrary.TaskFrame()
        Me.chkCD = New System.Windows.Forms.CheckBox()
        Me.LinkPaqueteAct = New System.Windows.Forms.LinkLabel()
        Me.nudPaquete = New System.Windows.Forms.NumericUpDown()
        Me.lblPaquete = New System.Windows.Forms.Label()
        Me.PanelMotivoDevolucion = New System.Windows.Forms.Panel()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.lnkMotivo = New System.Windows.Forms.LinkLabel()
        Me.cboMotivo = New System.Windows.Forms.ComboBox()
        Me.MotivosRechazoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lnkReasignar = New System.Windows.Forms.LinkLabel()
        Me.txtSucursal = New System.Windows.Forms.TextBox()
        Me.nudLote = New System.Windows.Forms.NumericUpDown()
        Me.lnkSucursal = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCajero = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboSucursal = New System.Windows.Forms.ComboBox()
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TaskFrame5 = New WindowsControlLibrary.TaskFrame()
        Me.lnkFecha = New System.Windows.Forms.LinkLabel()
        Me.lblDIF = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCHQCant = New System.Windows.Forms.Label()
        Me.lblCHQ = New System.Windows.Forms.Label()
        Me.lblCABCant = New System.Windows.Forms.Label()
        Me.lblCAB = New System.Windows.Forms.Label()
        Me.TaskFrame2 = New WindowsControlLibrary.TaskFrame()
        Me.SearchPanel1 = New WindowsControlLibrary.SearchPanel()
        Me.lnkValidarCREC = New System.Windows.Forms.LinkLabel()
        Me.LecturasGridControl = New DevExpress.XtraGrid.GridControl()
        Me.LecturaView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colcod_maquina = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPAQUETE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnro_lote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcod_banco_receptor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcuenta_cheque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Edit12 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colnumero_cheque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Edit8 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colcod_banco_emisor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcod_camara = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcod_sucursal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcuenta_deposito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcabecera = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdMotivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colENVIADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcadena_captura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNroError = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnro_corrida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataRepeater1 = New Microsoft.VisualBasic.PowerPacks.DataRepeater()
        Me.ErroresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ImagenBase1 = New HostVB.ImagenBase()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.CRECDetGridControl = New DevExpress.XtraGrid.GridControl()
        Me.CRECDetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdBanco = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCuenta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colImporte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colSecuencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExiste = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkValidarFiltrar = New System.Windows.Forms.CheckBox()
        Me.ChkCorregir = New System.Windows.Forms.CheckBox()
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel()
        Me.chkFiltrarErrorCHITCI = New System.Windows.Forms.CheckBox()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.CHITCIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridCHITCI = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCtaDeposito1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComprobante1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImporte1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantCheques = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAgencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUsuario1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkCorregirCHITCI = New System.Windows.Forms.CheckBox()
        Me.LinkLabel9 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.CHERFIIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridCHERFII = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colcfCtaLibradora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcfSerie = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcfBoleta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcfImporte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcfCtaDep = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAgenciaCR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit11 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit12 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CHERFIIGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCtaLibradora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNroCheque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComprobante = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCtaDeposito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.lnkValidarCHER = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.txtErrores = New System.Windows.Forms.Label()
        Me.lblSubDif = New System.Windows.Forms.Label()
        Me.txtSubDif = New System.Windows.Forms.Label()
        Me.lblSubTotalDet = New System.Windows.Forms.Label()
        Me.txtSubTotalDet = New System.Windows.Forms.Label()
        Me.lblSubTotalCab = New System.Windows.Forms.Label()
        Me.txtSubTotalCab = New System.Windows.Forms.Label()
        Me.RadDock1 = New Telerik.WinControls.UI.Docking.RadDock()
        Me.ToolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.DocumentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        Me.DocumentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.ToolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.tfCREC = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.ToolTabStrip3 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.tfCHITCI = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ToolTabStrip4 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.tfCHERFII = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LecturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciarCapturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ValidarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiltrarErroresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.Edit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MontoEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LecturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.tpOpciones.SuspendLayout()
        Me.TaskFrame1.SuspendLayout()
        Me.tfValidar.SuspendLayout()
        Me.tfOpciones.SuspendLayout()
        CType(Me.nudPaquete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMotivoDevolucion.SuspendLayout()
        CType(Me.MotivosRechazoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TaskFrame5.SuspendLayout()
        Me.TaskFrame2.SuspendLayout()
        CType(Me.LecturasGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LecturaView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Edit12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Edit8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataRepeater1.ItemTemplate.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        CType(Me.ErroresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.CRECDetGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRECDetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHITCIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCHITCI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHERFIIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCHERFII, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHERFIIGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolWindow1.SuspendLayout()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentWindow1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tfCREC.SuspendLayout()
        CType(Me.ToolTabStrip3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tfCHITCI.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ToolTabStrip4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tfCHERFII.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
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
        Me.colcod_tipdoc.VisibleIndex = 4
        Me.colcod_tipdoc.Width = 42
        '
        'Edit2
        '
        Me.Edit2.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.Edit2.AutoHeight = False
        Me.Edit2.MaxLength = 2
        Me.Edit2.Name = "Edit2"
        Me.Edit2.NullText = "-"
        Me.Edit2.NullValuePrompt = "(Nulo)"
        Me.Edit2.NullValuePromptShowForEmptyValue = True
        '
        'colmonto
        '
        Me.colmonto.Caption = "Importe"
        Me.colmonto.ColumnEdit = Me.MontoEditor
        Me.colmonto.DisplayFormat.FormatString = "N0"
        Me.colmonto.FieldName = "monto"
        Me.colmonto.MinWidth = 50
        Me.colmonto.Name = "colmonto"
        Me.colmonto.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "monto", "{0:N0}", 1)})
        Me.colmonto.Visible = True
        Me.colmonto.VisibleIndex = 9
        Me.colmonto.Width = 88
        '
        'MontoEditor
        '
        Me.MontoEditor.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.MontoEditor.AutoHeight = False
        Me.MontoEditor.DisplayFormat.FormatString = "N0"
        Me.MontoEditor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MontoEditor.EditFormat.FormatString = "N0"
        Me.MontoEditor.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MontoEditor.Mask.EditMask = "N0"
        Me.MontoEditor.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.MontoEditor.Mask.UseMaskAsDisplayFormat = True
        Me.MontoEditor.Name = "MontoEditor"
        Me.MontoEditor.NullText = "0"
        Me.MontoEditor.NullValuePrompt = "(Nulo)"
        Me.MontoEditor.NullValuePromptShowForEmptyValue = True
        '
        'DockWindowPlaceholder1
        '
        Me.DockWindowPlaceholder1.DockWindowName = "ToolWindow1"
        Me.DockWindowPlaceholder1.DockWindowText = "Imagen"
        Me.DockWindowPlaceholder1.Location = New System.Drawing.Point(0, 0)
        Me.DockWindowPlaceholder1.Name = "DockWindowPlaceholder1"
        Me.DockWindowPlaceholder1.Text = "DockWindowPlaceholder1"
        '
        'DockWindowPlaceholder2
        '
        Me.DockWindowPlaceholder2.DockWindowName = "tfCREC"
        Me.DockWindowPlaceholder2.DockWindowText = "CREC"
        Me.DockWindowPlaceholder2.Location = New System.Drawing.Point(0, 0)
        Me.DockWindowPlaceholder2.Name = "DockWindowPlaceholder2"
        Me.DockWindowPlaceholder2.Text = "DockWindowPlaceholder2"
        '
        'DockWindowPlaceholder3
        '
        Me.DockWindowPlaceholder3.DockWindowName = "tfCHERFII"
        Me.DockWindowPlaceholder3.DockWindowText = "CHERFII"
        Me.DockWindowPlaceholder3.Location = New System.Drawing.Point(0, 0)
        Me.DockWindowPlaceholder3.Name = "DockWindowPlaceholder3"
        Me.DockWindowPlaceholder3.Text = "DockWindowPlaceholder3"
        '
        'DockWindowPlaceholder4
        '
        Me.DockWindowPlaceholder4.DockWindowName = "tfCHITCI"
        Me.DockWindowPlaceholder4.DockWindowText = "CHITCI"
        Me.DockWindowPlaceholder4.Location = New System.Drawing.Point(0, 0)
        Me.DockWindowPlaceholder4.Name = "DockWindowPlaceholder4"
        Me.DockWindowPlaceholder4.Text = "DockWindowPlaceholder4"
        '
        'colConError
        '
        Me.colConError.Caption = "Errores"
        Me.colConError.FieldName = "ConError"
        Me.colConError.MinWidth = 30
        Me.colConError.Name = "colConError"
        Me.colConError.OptionsColumn.AllowEdit = False
        Me.colConError.Visible = True
        Me.colConError.VisibleIndex = 13
        Me.colConError.Width = 63
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbIniciarCaptura, Me.tsbValidar, Me.tsbErrores, Me.tsbInsertar, Me.tsbEditar, Me.tsEliminar, Me.tsbCargar, Me.tsbDescargar, Me.ToolStripButton6, Me.cmdImportar, Me.ToolStripButton4, Me.tsbCierre})
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
        'tsbValidar
        '
        Me.tsbValidar.Image = CType(resources.GetObject("tsbValidar.Image"), System.Drawing.Image)
        Me.tsbValidar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbValidar.Name = "tsbValidar"
        Me.tsbValidar.Size = New System.Drawing.Size(47, 35)
        Me.tsbValidar.Text = "Validar"
        Me.tsbValidar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbValidar.ToolTipText = "Validar (F8)"
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
        'tsbInsertar
        '
        Me.tsbInsertar.Image = Global.HostVB.My.Resources.Resources.VSProject_generatedfile
        Me.tsbInsertar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbInsertar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbInsertar.Name = "tsbInsertar"
        Me.tsbInsertar.Size = New System.Drawing.Size(50, 35)
        Me.tsbInsertar.Text = "Insertar"
        Me.tsbInsertar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbInsertar.ToolTipText = "Insertar (Ctrl + Ins)"
        '
        'tsbEditar
        '
        Me.tsbEditar.Image = Global.HostVB.My.Resources.Resources.EditTableHS
        Me.tsbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditar.Name = "tsbEditar"
        Me.tsbEditar.Size = New System.Drawing.Size(41, 35)
        Me.tsbEditar.Text = "Editar"
        Me.tsbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbEditar.ToolTipText = "Editar (Ctrl + Enter)"
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
        'ToolStripButton4
        '
        Me.ToolStripButton4.CheckOnClick = True
        Me.ToolStripButton4.Image = Global.HostVB.My.Resources.Resources._125_FullView_24x24_72_png
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(54, 35)
        Me.ToolStripButton4.Text = "Agrupar"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbCierre
        '
        Me.tsbCierre.Image = Global.HostVB.My.Resources.Resources.base_lock_32
        Me.tsbCierre.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCierre.Name = "tsbCierre"
        Me.tsbCierre.Size = New System.Drawing.Size(42, 35)
        Me.tsbCierre.Text = "Cierre"
        Me.tsbCierre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbCierre.ToolTipText = "Cierre de Lecturas"
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
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
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
        'tpOpciones
        '
        Me.tpOpciones.AutoScroll = True
        Me.tpOpciones.AutoScrollMinSize = New System.Drawing.Size(0, 812)
        Me.tpOpciones.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.tpOpciones.Controls.Add(Me.TaskFrame1)
        Me.tpOpciones.Controls.Add(Me.tfValidar)
        Me.tpOpciones.Controls.Add(Me.tfOpciones)
        Me.tpOpciones.Controls.Add(Me.TaskFrame5)
        Me.tpOpciones.Controls.Add(Me.TaskFrame2)
        Me.tpOpciones.Dock = System.Windows.Forms.DockStyle.Right
        Me.tpOpciones.Location = New System.Drawing.Point(694, 38)
        Me.tpOpciones.Name = "tpOpciones"
        Me.tpOpciones.Size = New System.Drawing.Size(205, 726)
        Me.tpOpciones.TabIndex = 34
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
        Me.chkLotesConError.Size = New System.Drawing.Size(159, 17)
        Me.chkLotesConError.TabIndex = 5
        Me.chkLotesConError.Text = "Descarg Lotes sin Error"
        Me.chkLotesConError.UseVisualStyleBackColor = True
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
        'tfOpciones
        '
        Me.tfOpciones.AllowDrop = True
        Me.tfOpciones.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tfOpciones.CaptionBlend = New WindowsControlLibrary.BlendFill(WindowsControlLibrary.BlendStyle.Horizontal, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(230, Byte), Integer)))
        Me.tfOpciones.Controls.Add(Me.chkCD)
        Me.tfOpciones.Controls.Add(Me.LinkPaqueteAct)
        Me.tfOpciones.Controls.Add(Me.nudPaquete)
        Me.tfOpciones.Controls.Add(Me.lblPaquete)
        Me.tfOpciones.Controls.Add(Me.PanelMotivoDevolucion)
        Me.tfOpciones.Controls.Add(Me.lnkReasignar)
        Me.tfOpciones.Controls.Add(Me.txtSucursal)
        Me.tfOpciones.Controls.Add(Me.nudLote)
        Me.tfOpciones.Controls.Add(Me.lnkSucursal)
        Me.tfOpciones.Controls.Add(Me.Label1)
        Me.tfOpciones.Controls.Add(Me.cboCajero)
        Me.tfOpciones.Controls.Add(Me.Label6)
        Me.tfOpciones.Controls.Add(Me.cboSucursal)
        Me.tfOpciones.Controls.Add(Me.Label3)
        Me.tfOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tfOpciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.tfOpciones.Location = New System.Drawing.Point(12, 254)
        Me.tfOpciones.Name = "TaskFrame4"
        Me.tfOpciones.Size = New System.Drawing.Size(163, 300)
        Me.tfOpciones.TabIndex = 7
        Me.tfOpciones.Text = "Opciones"
        '
        'chkCD
        '
        Me.chkCD.AutoSize = True
        Me.chkCD.Location = New System.Drawing.Point(4, 131)
        Me.chkCD.Name = "chkCD"
        Me.chkCD.Size = New System.Drawing.Size(153, 17)
        Me.chkCD.TabIndex = 13
        Me.chkCD.Text = "Compensación Directa"
        Me.chkCD.UseVisualStyleBackColor = True
        '
        'LinkPaqueteAct
        '
        Me.LinkPaqueteAct.AutoEllipsis = True
        Me.LinkPaqueteAct.AutoSize = True
        Me.LinkPaqueteAct.Location = New System.Drawing.Point(0, 145)
        Me.LinkPaqueteAct.Name = "LinkPaqueteAct"
        Me.LinkPaqueteAct.Size = New System.Drawing.Size(204, 13)
        Me.LinkPaqueteAct.TabIndex = 12
        Me.LinkPaqueteAct.TabStop = True
        Me.LinkPaqueteAct.Text = "Asignar registros al paquete actual"
        '
        'nudPaquete
        '
        Me.nudPaquete.Location = New System.Drawing.Point(93, 123)
        Me.nudPaquete.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudPaquete.Name = "nudPaquete"
        Me.nudPaquete.Size = New System.Drawing.Size(65, 20)
        Me.nudPaquete.TabIndex = 11
        Me.nudPaquete.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblPaquete
        '
        Me.lblPaquete.AutoSize = True
        Me.lblPaquete.Location = New System.Drawing.Point(1, 127)
        Me.lblPaquete.Name = "lblPaquete"
        Me.lblPaquete.Size = New System.Drawing.Size(94, 13)
        Me.lblPaquete.TabIndex = 10
        Me.lblPaquete.Text = "Paquete Actual"
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
        Me.txtSucursal.MaxLength = Global.HostVB.My.MySettings.Default.SucursalMaxLenght
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(39, 29)
        Me.txtSucursal.TabIndex = 5
        '
        'nudLote
        '
        Me.nudLote.Location = New System.Drawing.Point(93, 4)
        Me.nudLote.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudLote.Name = "nudLote"
        Me.nudLote.Size = New System.Drawing.Size(67, 20)
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
        Me.cboCajero.Location = New System.Drawing.Point(3, 180)
        Me.cboCajero.Name = "cboCajero"
        Me.cboCajero.Size = New System.Drawing.Size(161, 21)
        Me.cboCajero.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 163)
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
        Me.cboSucursal.Location = New System.Drawing.Point(42, 66)
        Me.cboSucursal.Name = "cboSucursal"
        Me.cboSucursal.Size = New System.Drawing.Size(116, 21)
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
        Me.TaskFrame5.Location = New System.Drawing.Point(12, 587)
        Me.TaskFrame5.Name = "TaskFrame5"
        Me.TaskFrame5.Size = New System.Drawing.Size(163, 80)
        Me.TaskFrame5.TabIndex = 9
        Me.TaskFrame5.Text = "Totales"
        '
        'lnkFecha
        '
        Me.lnkFecha.AutoSize = True
        Me.lnkFecha.Location = New System.Drawing.Point(5, 61)
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
        Me.lblDIF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDIF.ForeColor = System.Drawing.Color.Black
        Me.lblDIF.Location = New System.Drawing.Point(69, 45)
        Me.lblDIF.Name = "lblDIF"
        Me.lblDIF.Size = New System.Drawing.Size(14, 13)
        Me.lblDIF.TabIndex = 5
        Me.lblDIF.Text = "0"
        Me.lblDIF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(0, 45)
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
        Me.lblCHQCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCHQCant.ForeColor = System.Drawing.Color.Black
        Me.lblCHQCant.Location = New System.Drawing.Point(69, 28)
        Me.lblCHQCant.Name = "lblCHQCant"
        Me.lblCHQCant.Size = New System.Drawing.Size(14, 13)
        Me.lblCHQCant.TabIndex = 3
        Me.lblCHQCant.Text = "0"
        Me.lblCHQCant.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCHQ
        '
        Me.lblCHQ.AutoSize = True
        Me.lblCHQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCHQ.ForeColor = System.Drawing.Color.Black
        Me.lblCHQ.Location = New System.Drawing.Point(0, 28)
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
        Me.lblCABCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCABCant.ForeColor = System.Drawing.Color.Black
        Me.lblCABCant.Location = New System.Drawing.Point(69, 11)
        Me.lblCABCant.Name = "lblCABCant"
        Me.lblCABCant.Size = New System.Drawing.Size(14, 13)
        Me.lblCABCant.TabIndex = 1
        Me.lblCABCant.Text = "0"
        Me.lblCABCant.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCAB
        '
        Me.lblCAB.AutoSize = True
        Me.lblCAB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCAB.ForeColor = System.Drawing.Color.Black
        Me.lblCAB.Location = New System.Drawing.Point(0, 11)
        Me.lblCAB.Name = "lblCAB"
        Me.lblCAB.Size = New System.Drawing.Size(31, 13)
        Me.lblCAB.TabIndex = 0
        Me.lblCAB.Text = "CAB"
        '
        'TaskFrame2
        '
        Me.TaskFrame2.AllowDrop = True
        Me.TaskFrame2.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TaskFrame2.CaptionBlend = New WindowsControlLibrary.BlendFill(WindowsControlLibrary.BlendStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(252, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(212, Byte), Integer)))
        Me.TaskFrame2.Controls.Add(Me.SearchPanel1)
        Me.TaskFrame2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TaskFrame2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.TaskFrame2.Location = New System.Drawing.Point(12, 700)
        Me.TaskFrame2.Name = "TaskFrame2"
        Me.TaskFrame2.Size = New System.Drawing.Size(163, 100)
        Me.TaskFrame2.TabIndex = 11
        Me.TaskFrame2.Text = "TaskFrame2"
        Me.TaskFrame2.Visible = False
        '
        'SearchPanel1
        '
        Me.SearchPanel1.Location = New System.Drawing.Point(3, 12)
        Me.SearchPanel1.Name = "SearchPanel1"
        Me.SearchPanel1.Reiniciar = False
        Me.SearchPanel1.SearchColumn = Nothing
        Me.SearchPanel1.SearchText = Nothing
        Me.SearchPanel1.Size = New System.Drawing.Size(150, 58)
        Me.SearchPanel1.TabIndex = 0
        '
        'lnkValidarCREC
        '
        Me.lnkValidarCREC.AutoSize = True
        Me.lnkValidarCREC.Location = New System.Drawing.Point(2, 19)
        Me.lnkValidarCREC.Name = "lnkValidarCREC"
        Me.lnkValidarCREC.Size = New System.Drawing.Size(79, 13)
        Me.lnkValidarCREC.TabIndex = 5
        Me.lnkValidarCREC.TabStop = True
        Me.lnkValidarCREC.Text = "Verificar CREC"
        '
        'LecturasGridControl
        '
        Me.LecturasGridControl.DataSource = Me.LecturasBindingSource
        Me.LecturasGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LecturasGridControl.Location = New System.Drawing.Point(3, 3)
        Me.LecturasGridControl.LookAndFeel.SkinName = "Lilian"
        Me.LecturasGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LecturasGridControl.MainView = Me.LecturaView
        Me.LecturasGridControl.Name = "LecturasGridControl"
        Me.LecturasGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Edit2, Me.Edit12, Me.Edit8, Me.MontoEditor})
        Me.LecturasGridControl.Size = New System.Drawing.Size(666, 79)
        Me.LecturasGridControl.TabIndex = 36
        Me.LecturasGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.LecturaView})
        '
        'LecturaView
        '
        Me.LecturaView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcod_maquina, Me.colPAQUETE, Me.colnro_lote, Me.colcod_banco_receptor, Me.colcod_tipdoc, Me.colcuenta_cheque, Me.colnumero_cheque, Me.colcod_banco_emisor, Me.colcod_camara, Me.colmonto, Me.colcod_sucursal, Me.colcuenta_deposito, Me.colcabecera, Me.colConError, Me.colIdMotivo, Me.colENVIADO, Me.colcadena_captura, Me.colNroError, Me.colnro_corrida})
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.colcod_tipdoc
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Expression = "[cod_tipdoc] == '90'"
        StyleFormatCondition3.Value1 = "90"
        StyleFormatCondition4.Appearance.BorderColor = System.Drawing.Color.Red
        StyleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition4.Appearance.Options.UseBorderColor = True
        StyleFormatCondition4.Appearance.Options.UseForeColor = True
        StyleFormatCondition4.Column = Me.colmonto
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition4.Value1 = New Decimal(New Integer() {0, 0, 0, 0})
        Me.LecturaView.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition3, StyleFormatCondition4})
        Me.LecturaView.GridControl = Me.LecturasGridControl
        Me.LecturaView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "monto", Nothing, "Cab {0:N0}", 1), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "monto", Nothing, "Det {0:N0}", 2), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "monto", Nothing, "Dif {0:N0}", 3), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ConError", Nothing, "Err {0:N0}", 4)})
        Me.LecturaView.Name = "LecturaView"
        Me.LecturaView.OptionsLayout.StoreDataSettings = False
        Me.LecturaView.OptionsSelection.MultiSelect = True
        Me.LecturaView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.LecturaView.OptionsView.ColumnAutoWidth = False
        Me.LecturaView.OptionsView.ShowDetailButtons = False
        Me.LecturaView.OptionsView.ShowGroupPanel = False
        '
        'colcod_maquina
        '
        Me.colcod_maquina.Caption = "Maq"
        Me.colcod_maquina.FieldName = "cod_maquina"
        Me.colcod_maquina.Name = "colcod_maquina"
        Me.colcod_maquina.OptionsColumn.AllowEdit = False
        Me.colcod_maquina.Visible = True
        Me.colcod_maquina.VisibleIndex = 0
        Me.colcod_maquina.Width = 47
        '
        'colPAQUETE
        '
        Me.colPAQUETE.Caption = "Paq"
        Me.colPAQUETE.FieldName = "PAQUETE"
        Me.colPAQUETE.Name = "colPAQUETE"
        Me.colPAQUETE.OptionsColumn.AllowEdit = False
        Me.colPAQUETE.Visible = True
        Me.colPAQUETE.VisibleIndex = 1
        Me.colPAQUETE.Width = 47
        '
        'colnro_lote
        '
        Me.colnro_lote.Caption = "Lote"
        Me.colnro_lote.FieldName = "nro_lote"
        Me.colnro_lote.MinWidth = 30
        Me.colnro_lote.Name = "colnro_lote"
        Me.colnro_lote.OptionsColumn.AllowEdit = False
        Me.colnro_lote.Visible = True
        Me.colnro_lote.VisibleIndex = 2
        Me.colnro_lote.Width = 46
        '
        'colcod_banco_receptor
        '
        Me.colcod_banco_receptor.Caption = "Banco"
        Me.colcod_banco_receptor.ColumnEdit = Me.Edit2
        Me.colcod_banco_receptor.FieldName = "cod_banco_receptor"
        Me.colcod_banco_receptor.MinWidth = 30
        Me.colcod_banco_receptor.Name = "colcod_banco_receptor"
        Me.colcod_banco_receptor.Visible = True
        Me.colcod_banco_receptor.VisibleIndex = 3
        Me.colcod_banco_receptor.Width = 53
        '
        'colcuenta_cheque
        '
        Me.colcuenta_cheque.Caption = "Cuenta"
        Me.colcuenta_cheque.ColumnEdit = Me.Edit12
        Me.colcuenta_cheque.FieldName = "cuenta_cheque"
        Me.colcuenta_cheque.MinWidth = 50
        Me.colcuenta_cheque.Name = "colcuenta_cheque"
        Me.colcuenta_cheque.Visible = True
        Me.colcuenta_cheque.VisibleIndex = 5
        Me.colcuenta_cheque.Width = 88
        '
        'Edit12
        '
        Me.Edit12.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.Edit12.AutoHeight = False
        Me.Edit12.Mask.EditMask = "000000000000"
        Me.Edit12.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Edit12.Mask.UseMaskAsDisplayFormat = True
        Me.Edit12.MaxLength = 12
        Me.Edit12.Name = "Edit12"
        Me.Edit12.NullText = "0"
        Me.Edit12.NullValuePrompt = "(Nulo)"
        Me.Edit12.NullValuePromptShowForEmptyValue = True
        '
        'colnumero_cheque
        '
        Me.colnumero_cheque.Caption = "Serie"
        Me.colnumero_cheque.ColumnEdit = Me.Edit8
        Me.colnumero_cheque.FieldName = "numero_cheque"
        Me.colnumero_cheque.MinWidth = 40
        Me.colnumero_cheque.Name = "colnumero_cheque"
        Me.colnumero_cheque.Visible = True
        Me.colnumero_cheque.VisibleIndex = 6
        Me.colnumero_cheque.Width = 69
        '
        'Edit8
        '
        Me.Edit8.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.Edit8.AutoHeight = False
        Me.Edit8.Mask.BeepOnError = True
        Me.Edit8.Mask.EditMask = "00000000"
        Me.Edit8.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Edit8.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(48)
        Me.Edit8.Mask.UseMaskAsDisplayFormat = True
        Me.Edit8.MaxLength = 8
        Me.Edit8.Name = "Edit8"
        Me.Edit8.NullText = "0"
        Me.Edit8.NullValuePrompt = "(Nulo)"
        Me.Edit8.NullValuePromptShowForEmptyValue = True
        '
        'colcod_banco_emisor
        '
        Me.colcod_banco_emisor.Caption = "Receptor"
        Me.colcod_banco_emisor.ColumnEdit = Me.Edit2
        Me.colcod_banco_emisor.FieldName = "cod_banco_emisor"
        Me.colcod_banco_emisor.MinWidth = 30
        Me.colcod_banco_emisor.Name = "colcod_banco_emisor"
        Me.colcod_banco_emisor.Visible = True
        Me.colcod_banco_emisor.VisibleIndex = 7
        Me.colcod_banco_emisor.Width = 65
        '
        'colcod_camara
        '
        Me.colcod_camara.Caption = "Camara"
        Me.colcod_camara.ColumnEdit = Me.Edit2
        Me.colcod_camara.FieldName = "cod_camara"
        Me.colcod_camara.MinWidth = 30
        Me.colcod_camara.Name = "colcod_camara"
        Me.colcod_camara.Visible = True
        Me.colcod_camara.VisibleIndex = 8
        Me.colcod_camara.Width = 58
        '
        'colcod_sucursal
        '
        Me.colcod_sucursal.Caption = "Suc"
        Me.colcod_sucursal.ColumnEdit = Me.Edit2
        Me.colcod_sucursal.FieldName = "cod_sucursal"
        Me.colcod_sucursal.MinWidth = 30
        Me.colcod_sucursal.Name = "colcod_sucursal"
        Me.colcod_sucursal.Visible = True
        Me.colcod_sucursal.VisibleIndex = 10
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
        Me.colcuenta_deposito.VisibleIndex = 11
        Me.colcuenta_deposito.Width = 87
        '
        'colcabecera
        '
        Me.colcabecera.Caption = "Secuencia"
        Me.colcabecera.FieldName = "cabecera"
        Me.colcabecera.MinWidth = 30
        Me.colcabecera.Name = "colcabecera"
        Me.colcabecera.OptionsColumn.AllowEdit = False
        Me.colcabecera.Visible = True
        Me.colcabecera.VisibleIndex = 12
        Me.colcabecera.Width = 72
        '
        'colIdMotivo
        '
        Me.colIdMotivo.Caption = "Motivo"
        Me.colIdMotivo.FieldName = "IdMotivo"
        Me.colIdMotivo.MinWidth = 30
        Me.colIdMotivo.Name = "colIdMotivo"
        Me.colIdMotivo.Visible = True
        Me.colIdMotivo.VisibleIndex = 14
        Me.colIdMotivo.Width = 53
        '
        'colENVIADO
        '
        Me.colENVIADO.Caption = "Editado"
        Me.colENVIADO.FieldName = "Editado"
        Me.colENVIADO.MinWidth = 30
        Me.colENVIADO.Name = "colENVIADO"
        Me.colENVIADO.OptionsColumn.AllowEdit = False
        Me.colENVIADO.Visible = True
        Me.colENVIADO.VisibleIndex = 15
        Me.colENVIADO.Width = 61
        '
        'colcadena_captura
        '
        Me.colcadena_captura.Caption = "Cadena"
        Me.colcadena_captura.FieldName = "cadena_captura"
        Me.colcadena_captura.Name = "colcadena_captura"
        Me.colcadena_captura.OptionsColumn.AllowEdit = False
        Me.colcadena_captura.Visible = True
        Me.colcadena_captura.VisibleIndex = 17
        Me.colcadena_captura.Width = 74
        '
        'colNroError
        '
        Me.colNroError.Caption = "NroError"
        Me.colNroError.FieldName = "NroError"
        Me.colNroError.Name = "colNroError"
        Me.colNroError.OptionsColumn.AllowEdit = False
        Me.colNroError.Visible = True
        Me.colNroError.VisibleIndex = 16
        Me.colNroError.Width = 78
        '
        'colnro_corrida
        '
        Me.colnro_corrida.Caption = "Orden"
        Me.colnro_corrida.FieldName = "nro_corrida"
        Me.colnro_corrida.Name = "colnro_corrida"
        Me.colnro_corrida.OptionsColumn.AllowEdit = False
        Me.colnro_corrida.Visible = True
        Me.colnro_corrida.VisibleIndex = 18
        Me.colnro_corrida.Width = 68
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
        Me.DataRepeater1.ItemTemplate.Margin = New System.Windows.Forms.Padding(0)
        Me.DataRepeater1.ItemTemplate.Size = New System.Drawing.Size(641, 20)
        Me.DataRepeater1.Location = New System.Drawing.Point(3, 118)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(666, 24)
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
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Label7"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ErroresBindingSource, "Error", True))
        Me.Label5.Location = New System.Drawing.Point(48, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Label5"
        '
        'ImagenBase1
        '
        Me.ImagenBase1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImagenBase1.Imagen = Nothing
        Me.ImagenBase1.Location = New System.Drawing.Point(0, 0)
        Me.ImagenBase1.MaximumSize = New System.Drawing.Size(600, 400)
        Me.ImagenBase1.MinimumSize = New System.Drawing.Size(171, 150)
        Me.ImagenBase1.Name = "ImagenBase1"
        Me.ImagenBase1.NombreImagen = Nothing
        Me.ImagenBase1.NombreImagen1 = Nothing
        Me.ImagenBase1.Size = New System.Drawing.Size(600, 172)
        Me.ImagenBase1.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.CRECDetGridControl, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(682, 99)
        Me.TableLayoutPanel3.TabIndex = 15
        '
        'CRECDetGridControl
        '
        Me.CRECDetGridControl.DataSource = Me.CRECDetBindingSource
        Me.CRECDetGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRECDetGridControl.Location = New System.Drawing.Point(3, 3)
        Me.CRECDetGridControl.LookAndFeel.SkinName = "Lilian"
        Me.CRECDetGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.CRECDetGridControl.MainView = Me.GridView2
        Me.CRECDetGridControl.Name = "CRECDetGridControl"
        Me.CRECDetGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3})
        Me.CRECDetGridControl.Size = New System.Drawing.Size(476, 93)
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
        Me.GridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", Nothing, "{0:N0}")})
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colIdBanco
        '
        Me.colIdBanco.Caption = "Banco"
        Me.colIdBanco.FieldName = "IdBanco"
        Me.colIdBanco.Name = "colIdBanco"
        Me.colIdBanco.OptionsColumn.AllowEdit = False
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
        Me.colCuenta.OptionsColumn.AllowEdit = False
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
        Me.colNumero.OptionsColumn.AllowEdit = False
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
        Me.colImporte.OptionsColumn.AllowEdit = False
        Me.colImporte.OptionsColumn.ReadOnly = True
        Me.colImporte.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", "{0:N0}")})
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
        Me.colSecuencia.OptionsColumn.AllowEdit = False
        Me.colSecuencia.OptionsColumn.ReadOnly = True
        Me.colSecuencia.Visible = True
        Me.colSecuencia.VisibleIndex = 4
        '
        'colExiste
        '
        Me.colExiste.FieldName = "Existe"
        Me.colExiste.Name = "colExiste"
        Me.colExiste.OptionsColumn.AllowEdit = False
        Me.colExiste.OptionsColumn.ReadOnly = True
        Me.colExiste.Visible = True
        Me.colExiste.VisibleIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lnkValidarCREC)
        Me.Panel1.Controls.Add(Me.chkValidarFiltrar)
        Me.Panel1.Controls.Add(Me.ChkCorregir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(485, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(194, 93)
        Me.Panel1.TabIndex = 14
        '
        'chkValidarFiltrar
        '
        Me.chkValidarFiltrar.AutoSize = True
        Me.chkValidarFiltrar.Location = New System.Drawing.Point(4, 56)
        Me.chkValidarFiltrar.Name = "chkValidarFiltrar"
        Me.chkValidarFiltrar.Size = New System.Drawing.Size(165, 17)
        Me.chkValidarFiltrar.TabIndex = 14
        Me.chkValidarFiltrar.Text = "Validar CREC al Filtrar Error"
        Me.chkValidarFiltrar.UseVisualStyleBackColor = True
        '
        'ChkCorregir
        '
        Me.ChkCorregir.AutoSize = True
        Me.ChkCorregir.Location = New System.Drawing.Point(4, 37)
        Me.ChkCorregir.Name = "ChkCorregir"
        Me.ChkCorregir.Size = New System.Drawing.Size(130, 17)
        Me.ChkCorregir.TabIndex = 13
        Me.ChkCorregir.Text = "Aplicar Correcciones"
        Me.ChkCorregir.UseVisualStyleBackColor = True
        '
        'LinkLabel8
        '
        Me.LinkLabel8.AutoSize = True
        Me.LinkLabel8.Location = New System.Drawing.Point(8, 14)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(69, 13)
        Me.LinkLabel8.TabIndex = 20
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "Leer Archivo"
        '
        'chkFiltrarErrorCHITCI
        '
        Me.chkFiltrarErrorCHITCI.AutoSize = True
        Me.chkFiltrarErrorCHITCI.Location = New System.Drawing.Point(9, 73)
        Me.chkFiltrarErrorCHITCI.Name = "chkFiltrarErrorCHITCI"
        Me.chkFiltrarErrorCHITCI.Size = New System.Drawing.Size(146, 17)
        Me.chkFiltrarErrorCHITCI.TabIndex = 19
        Me.chkFiltrarErrorCHITCI.Text = "Filtrar Errores al Validar"
        Me.chkFiltrarErrorCHITCI.UseVisualStyleBackColor = True
        '
        'GridControl3
        '
        Me.GridControl3.DataSource = Me.CHITCIBindingSource
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(3, 3)
        Me.GridControl3.LookAndFeel.SkinName = "Lilian"
        Me.GridControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl3.MainView = Me.gridCHITCI
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(506, 91)
        Me.GridControl3.TabIndex = 18
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridCHITCI})
        '
        'CHITCIBindingSource
        '
        Me.CHITCIBindingSource.DataSource = GetType(DataAccess.CHITCI)
        '
        'gridCHITCI
        '
        Me.gridCHITCI.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCtaDeposito1, Me.colComprobante1, Me.colImporte1, Me.colCantCheques, Me.colTipoUsuario, Me.colAgencia, Me.colUsuario1})
        Me.gridCHITCI.GridControl = Me.GridControl3
        Me.gridCHITCI.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", Nothing, "{0:N0}")})
        Me.gridCHITCI.Name = "gridCHITCI"
        Me.gridCHITCI.OptionsView.ShowGroupPanel = False
        Me.gridCHITCI.OptionsView.ShowIndicator = False
        '
        'colCtaDeposito1
        '
        Me.colCtaDeposito1.Caption = "Cuenta"
        Me.colCtaDeposito1.FieldName = "CtaDeposito"
        Me.colCtaDeposito1.Name = "colCtaDeposito1"
        Me.colCtaDeposito1.OptionsColumn.ReadOnly = True
        Me.colCtaDeposito1.Visible = True
        Me.colCtaDeposito1.VisibleIndex = 0
        '
        'colComprobante1
        '
        Me.colComprobante1.Caption = "Serie"
        Me.colComprobante1.FieldName = "Comprobante"
        Me.colComprobante1.Name = "colComprobante1"
        Me.colComprobante1.OptionsColumn.ReadOnly = True
        Me.colComprobante1.Visible = True
        Me.colComprobante1.VisibleIndex = 1
        '
        'colImporte1
        '
        Me.colImporte1.DisplayFormat.FormatString = "N0"
        Me.colImporte1.FieldName = "Importe"
        Me.colImporte1.Name = "colImporte1"
        Me.colImporte1.OptionsColumn.ReadOnly = True
        Me.colImporte1.Visible = True
        Me.colImporte1.VisibleIndex = 2
        '
        'colCantCheques
        '
        Me.colCantCheques.Caption = "Cantidad"
        Me.colCantCheques.FieldName = "CantCheques"
        Me.colCantCheques.Name = "colCantCheques"
        Me.colCantCheques.OptionsColumn.ReadOnly = True
        Me.colCantCheques.Visible = True
        Me.colCantCheques.VisibleIndex = 3
        '
        'colTipoUsuario
        '
        Me.colTipoUsuario.Caption = "Existe"
        Me.colTipoUsuario.FieldName = "Existe"
        Me.colTipoUsuario.Name = "colTipoUsuario"
        Me.colTipoUsuario.OptionsColumn.ReadOnly = True
        Me.colTipoUsuario.Visible = True
        Me.colTipoUsuario.VisibleIndex = 4
        '
        'colAgencia
        '
        Me.colAgencia.FieldName = "Agencia"
        Me.colAgencia.Name = "colAgencia"
        Me.colAgencia.OptionsColumn.ReadOnly = True
        Me.colAgencia.Visible = True
        Me.colAgencia.VisibleIndex = 5
        '
        'colUsuario1
        '
        Me.colUsuario1.FieldName = "Usuario"
        Me.colUsuario1.Name = "colUsuario1"
        Me.colUsuario1.OptionsColumn.ReadOnly = True
        Me.colUsuario1.Visible = True
        Me.colUsuario1.VisibleIndex = 6
        '
        'chkCorregirCHITCI
        '
        Me.chkCorregirCHITCI.AutoSize = True
        Me.chkCorregirCHITCI.Location = New System.Drawing.Point(9, 52)
        Me.chkCorregirCHITCI.Name = "chkCorregirCHITCI"
        Me.chkCorregirCHITCI.Size = New System.Drawing.Size(130, 17)
        Me.chkCorregirCHITCI.TabIndex = 17
        Me.chkCorregirCHITCI.Text = "Aplicar Correcciones"
        Me.chkCorregirCHITCI.UseVisualStyleBackColor = True
        '
        'LinkLabel9
        '
        Me.LinkLabel9.AutoSize = True
        Me.LinkLabel9.Location = New System.Drawing.Point(8, 34)
        Me.LinkLabel9.Name = "LinkLabel9"
        Me.LinkLabel9.Size = New System.Drawing.Size(79, 13)
        Me.LinkLabel9.TabIndex = 16
        Me.LinkLabel9.TabStop = True
        Me.LinkLabel9.Text = "Validar CHITCI"
        '
        'LinkLabel6
        '
        Me.LinkLabel6.AutoSize = True
        Me.LinkLabel6.Location = New System.Drawing.Point(2, 6)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(69, 13)
        Me.LinkLabel6.TabIndex = 15
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "Leer Archivo"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(3, 65)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(178, 17)
        Me.CheckBox5.TabIndex = 14
        Me.CheckBox5.Text = "Validar CHERFII al Filtrar Error"
        Me.CheckBox5.UseVisualStyleBackColor = True
        Me.CheckBox5.Visible = False
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.CHERFIIBindingSource
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(3, 3)
        Me.GridControl2.LookAndFeel.SkinName = "Lilian"
        Me.GridControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl2.MainView = Me.gridCHERFII
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit10, Me.RepositoryItemTextEdit11, Me.RepositoryItemTextEdit12})
        Me.GridControl2.Size = New System.Drawing.Size(506, 65)
        Me.GridControl2.TabIndex = 13
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridCHERFII})
        '
        'CHERFIIBindingSource
        '
        Me.CHERFIIBindingSource.DataSource = GetType(DataAccess.CHERFII)
        '
        'gridCHERFII
        '
        Me.gridCHERFII.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcfCtaLibradora, Me.colcfSerie, Me.colcfBoleta, Me.colcfImporte, Me.colcfCtaDep, Me.colAgenciaCR, Me.colUsuario})
        Me.gridCHERFII.GridControl = Me.GridControl2
        Me.gridCHERFII.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", Nothing, "{0:N0}")})
        Me.gridCHERFII.Name = "gridCHERFII"
        Me.gridCHERFII.OptionsView.ShowGroupPanel = False
        Me.gridCHERFII.OptionsView.ShowIndicator = False
        '
        'colcfCtaLibradora
        '
        Me.colcfCtaLibradora.Caption = "Cuenta"
        Me.colcfCtaLibradora.FieldName = "CtaLibradora"
        Me.colcfCtaLibradora.Name = "colcfCtaLibradora"
        Me.colcfCtaLibradora.OptionsColumn.AllowEdit = False
        Me.colcfCtaLibradora.OptionsColumn.ReadOnly = True
        Me.colcfCtaLibradora.Visible = True
        Me.colcfCtaLibradora.VisibleIndex = 0
        '
        'colcfSerie
        '
        Me.colcfSerie.Caption = "Serie"
        Me.colcfSerie.FieldName = "NroCheque"
        Me.colcfSerie.Name = "colcfSerie"
        Me.colcfSerie.OptionsColumn.AllowEdit = False
        Me.colcfSerie.OptionsColumn.ReadOnly = True
        Me.colcfSerie.Visible = True
        Me.colcfSerie.VisibleIndex = 1
        '
        'colcfBoleta
        '
        Me.colcfBoleta.Caption = "Boleta"
        Me.colcfBoleta.FieldName = "Comprobante"
        Me.colcfBoleta.Name = "colcfBoleta"
        Me.colcfBoleta.OptionsColumn.AllowEdit = False
        Me.colcfBoleta.OptionsColumn.ReadOnly = True
        Me.colcfBoleta.Visible = True
        Me.colcfBoleta.VisibleIndex = 2
        '
        'colcfImporte
        '
        Me.colcfImporte.FieldName = "Importe"
        Me.colcfImporte.Name = "colcfImporte"
        Me.colcfImporte.OptionsColumn.AllowEdit = False
        Me.colcfImporte.OptionsColumn.ReadOnly = True
        Me.colcfImporte.Visible = True
        Me.colcfImporte.VisibleIndex = 3
        '
        'colcfCtaDep
        '
        Me.colcfCtaDep.Caption = "Cta. Dep."
        Me.colcfCtaDep.FieldName = "CtaDeposito"
        Me.colcfCtaDep.Name = "colcfCtaDep"
        Me.colcfCtaDep.OptionsColumn.AllowEdit = False
        Me.colcfCtaDep.OptionsColumn.ReadOnly = True
        Me.colcfCtaDep.Visible = True
        Me.colcfCtaDep.VisibleIndex = 4
        '
        'colAgenciaCR
        '
        Me.colAgenciaCR.FieldName = "AgenciaCR"
        Me.colAgenciaCR.Name = "colAgenciaCR"
        Me.colAgenciaCR.OptionsColumn.AllowEdit = False
        Me.colAgenciaCR.Visible = True
        Me.colAgenciaCR.VisibleIndex = 5
        '
        'colUsuario
        '
        Me.colUsuario.FieldName = "Usuario"
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.OptionsColumn.AllowEdit = False
        Me.colUsuario.Visible = True
        Me.colUsuario.VisibleIndex = 6
        '
        'RepositoryItemTextEdit10
        '
        Me.RepositoryItemTextEdit10.AutoHeight = False
        Me.RepositoryItemTextEdit10.Mask.EditMask = "000000000000"
        Me.RepositoryItemTextEdit10.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit10.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit10.MaxLength = 12
        Me.RepositoryItemTextEdit10.Name = "RepositoryItemTextEdit10"
        '
        'RepositoryItemTextEdit11
        '
        Me.RepositoryItemTextEdit11.AutoHeight = False
        Me.RepositoryItemTextEdit11.Mask.EditMask = "00000000"
        Me.RepositoryItemTextEdit11.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit11.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit11.MaxLength = 8
        Me.RepositoryItemTextEdit11.Name = "RepositoryItemTextEdit11"
        '
        'RepositoryItemTextEdit12
        '
        Me.RepositoryItemTextEdit12.AutoHeight = False
        Me.RepositoryItemTextEdit12.Mask.EditMask = "N0"
        Me.RepositoryItemTextEdit12.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit12.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit12.Name = "RepositoryItemTextEdit12"
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(3, 44)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(130, 17)
        Me.CheckBox6.TabIndex = 13
        Me.CheckBox6.Text = "Aplicar Correcciones"
        Me.CheckBox6.UseVisualStyleBackColor = True
        Me.CheckBox6.Visible = False
        '
        'LinkLabel7
        '
        Me.LinkLabel7.AutoSize = True
        Me.LinkLabel7.Location = New System.Drawing.Point(2, 26)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(85, 13)
        Me.LinkLabel7.TabIndex = 5
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "Aplicar CHERFII"
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
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(524, 64)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(199, 17)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Validar CHERFII al Filtrar Error"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CHERFIIGridControl
        '
        Me.CHERFIIGridControl.Location = New System.Drawing.Point(6, 4)
        Me.CHERFIIGridControl.LookAndFeel.SkinName = "Lilian"
        Me.CHERFIIGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.CHERFIIGridControl.MainView = Me.GridView1
        Me.CHERFIIGridControl.Name = "CHERFIIGridControl"
        Me.CHERFIIGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit4, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6})
        Me.CHERFIIGridControl.Size = New System.Drawing.Size(511, 85)
        Me.CHERFIIGridControl.TabIndex = 13
        Me.CHERFIIGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCtaLibradora, Me.colNroCheque, Me.colComprobante, Me.GridColumn1, Me.colCtaDeposito})
        Me.GridView1.GridControl = Me.CHERFIIGridControl
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", Nothing, "{0:N0}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
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
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "Importe"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 3
        '
        'colCtaDeposito
        '
        Me.colCtaDeposito.FieldName = "CtaDeposito"
        Me.colCtaDeposito.Name = "colCtaDeposito"
        Me.colCtaDeposito.OptionsColumn.ReadOnly = True
        Me.colCtaDeposito.Visible = True
        Me.colCtaDeposito.VisibleIndex = 4
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
        Me.CheckBox2.Location = New System.Drawing.Point(524, 43)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(143, 17)
        Me.CheckBox2.TabIndex = 13
        Me.CheckBox2.Text = "Aplicar Correcciones"
        Me.CheckBox2.UseVisualStyleBackColor = True
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
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(523, 5)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(79, 13)
        Me.LinkLabel4.TabIndex = 15
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Leer Archivo"
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
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(6, 4)
        Me.GridControl1.LookAndFeel.SkinName = "Lilian"
        Me.GridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl1.MainView = Me.GridView3
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit7, Me.RepositoryItemTextEdit8, Me.RepositoryItemTextEdit9})
        Me.GridControl1.Size = New System.Drawing.Size(511, 85)
        Me.GridControl1.TabIndex = 13
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.GridView3.GridControl = Me.GridControl1
        Me.GridView3.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", Nothing, "{0:N0}")})
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "CtaLibradora"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "NroCheque"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "Comprobante"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.FieldName = "Importe"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "CtaDeposito"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
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
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Location = New System.Drawing.Point(523, 25)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(107, 13)
        Me.LinkLabel5.TabIndex = 5
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Verificar CHERFII"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblError)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtErrores)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblSubDif)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtSubDif)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblSubTotalDet)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtSubTotalDet)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblSubTotalCab)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtSubTotalCab)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 88)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(666, 24)
        Me.FlowLayoutPanel1.TabIndex = 36
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
        'lblError
        '
        Me.lblError.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Location = New System.Drawing.Point(84, 0)
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
        Me.txtErrores.Location = New System.Drawing.Point(137, 0)
        Me.txtErrores.Name = "txtErrores"
        Me.txtErrores.Size = New System.Drawing.Size(16, 15)
        Me.txtErrores.TabIndex = 8
        Me.txtErrores.Text = "0"
        '
        'lblSubDif
        '
        Me.lblSubDif.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSubDif.AutoSize = True
        Me.lblSubDif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubDif.Location = New System.Drawing.Point(159, 0)
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
        Me.txtSubDif.Location = New System.Drawing.Point(192, 0)
        Me.txtSubDif.Name = "txtSubDif"
        Me.txtSubDif.Size = New System.Drawing.Size(16, 15)
        Me.txtSubDif.TabIndex = 12
        Me.txtSubDif.Text = "0"
        '
        'lblSubTotalDet
        '
        Me.lblSubTotalDet.AutoSize = True
        Me.lblSubTotalDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotalDet.Location = New System.Drawing.Point(214, 0)
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
        Me.txtSubTotalDet.Location = New System.Drawing.Point(251, 0)
        Me.txtSubTotalDet.Name = "txtSubTotalDet"
        Me.txtSubTotalDet.Size = New System.Drawing.Size(16, 15)
        Me.txtSubTotalDet.TabIndex = 9
        Me.txtSubTotalDet.Text = "0"
        '
        'lblSubTotalCab
        '
        Me.lblSubTotalCab.AutoSize = True
        Me.lblSubTotalCab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotalCab.Location = New System.Drawing.Point(273, 0)
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
        Me.txtSubTotalCab.Location = New System.Drawing.Point(312, 0)
        Me.txtSubTotalCab.Name = "txtSubTotalCab"
        Me.txtSubTotalCab.Size = New System.Drawing.Size(16, 15)
        Me.txtSubTotalCab.TabIndex = 10
        Me.txtSubTotalCab.Text = "0"
        '
        'RadDock1
        '
        Me.RadDock1.ActiveWindow = Me.ToolWindow1
        Me.RadDock1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.RadDock1.CausesValidation = False
        Me.RadDock1.Controls.Add(Me.DocumentContainer1)
        Me.RadDock1.Controls.Add(Me.ToolTabStrip1)
        Me.RadDock1.Controls.Add(Me.ToolTabStrip2)
        Me.RadDock1.Controls.Add(Me.ToolTabStrip3)
        Me.RadDock1.Controls.Add(Me.ToolTabStrip4)
        Me.RadDock1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadDock1.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront
        Me.RadDock1.IsCleanUpTarget = True
        Me.RadDock1.Location = New System.Drawing.Point(0, 38)
        Me.RadDock1.MainDocumentContainer = Me.DocumentContainer1
        Me.RadDock1.Name = "RadDock1"
        Me.RadDock1.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RadDock1.Padding = New System.Windows.Forms.Padding(5)
        '
        '
        '
        Me.RadDock1.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 200, 200)
        Me.RadDock1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadDock1.RootElement.Padding = New System.Windows.Forms.Padding(5)
        AutoHideGroup5.Windows.Add(Me.DockWindowPlaceholder1)
        AutoHideGroup6.Windows.Add(Me.DockWindowPlaceholder2)
        AutoHideGroup7.Windows.Add(Me.DockWindowPlaceholder3)
        AutoHideGroup8.Windows.Add(Me.DockWindowPlaceholder4)
        Me.RadDock1.SerializableAutoHideContainer.BottomAutoHideGroups.Add(AutoHideGroup5)
        Me.RadDock1.SerializableAutoHideContainer.BottomAutoHideGroups.Add(AutoHideGroup6)
        Me.RadDock1.SerializableAutoHideContainer.BottomAutoHideGroups.Add(AutoHideGroup7)
        Me.RadDock1.SerializableAutoHideContainer.BottomAutoHideGroups.Add(AutoHideGroup8)
        Me.RadDock1.Size = New System.Drawing.Size(694, 726)
        Me.RadDock1.SplitterWidth = 4
        Me.RadDock1.TabIndex = 37
        Me.RadDock1.TabStop = False
        Me.RadDock1.Text = "RadDock1"
        '
        'ToolWindow1
        '
        Me.ToolWindow1.Controls.Add(Me.ImagenBase1)
        Me.ToolWindow1.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindow1.Name = "ToolWindow1"
        Me.ToolWindow1.Size = New System.Drawing.Size(682, 172)
        Me.ToolWindow1.Text = "Imagen"
        Me.ToolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide
        '
        'DocumentContainer1
        '
        Me.DocumentContainer1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DocumentContainer1.CausesValidation = False
        Me.DocumentContainer1.Controls.Add(Me.DocumentTabStrip1)
        Me.DocumentContainer1.Location = New System.Drawing.Point(5, 5)
        Me.DocumentContainer1.Name = "DocumentContainer1"
        '
        '
        '
        Me.DocumentContainer1.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 200, 200)
        Me.DocumentContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentContainer1.Size = New System.Drawing.Size(684, 157)
        Me.DocumentContainer1.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 67)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.DocumentContainer1.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -394)
        Me.DocumentContainer1.SplitterWidth = 4
        Me.DocumentContainer1.TabIndex = 0
        Me.DocumentContainer1.TabStop = False
        '
        'DocumentTabStrip1
        '
        Me.DocumentTabStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DocumentTabStrip1.CausesValidation = False
        Me.DocumentTabStrip1.Controls.Add(Me.DocumentWindow1)
        Me.DocumentTabStrip1.Location = New System.Drawing.Point(0, 0)
        Me.DocumentTabStrip1.Name = "DocumentTabStrip1"
        '
        '
        '
        Me.DocumentTabStrip1.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 200, 200)
        Me.DocumentTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentTabStrip1.SelectedIndex = 0
        Me.DocumentTabStrip1.Size = New System.Drawing.Size(684, 157)
        Me.DocumentTabStrip1.TabIndex = 0
        Me.DocumentTabStrip1.TabStop = False
        Me.DocumentTabStrip1.TabStripVisible = False
        '
        'DocumentWindow1
        '
        Me.DocumentWindow1.CloseAction = Telerik.WinControls.UI.Docking.DockWindowCloseAction.Hide
        Me.DocumentWindow1.Controls.Add(Me.TableLayoutPanel5)
        Me.DocumentWindow1.Location = New System.Drawing.Point(6, 6)
        Me.DocumentWindow1.Name = "DocumentWindow1"
        Me.DocumentWindow1.Size = New System.Drawing.Size(672, 145)
        Me.DocumentWindow1.Text = "DocumentWindow1"
        Me.DocumentWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.LecturasGridControl, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.DataRepeater1, 0, 2)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 3
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(672, 145)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'ToolTabStrip1
        '
        Me.ToolTabStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolTabStrip1.Controls.Add(Me.ToolWindow1)
        Me.ToolTabStrip1.Location = New System.Drawing.Point(5, 166)
        Me.ToolTabStrip1.Name = "ToolTabStrip1"
        '
        '
        '
        Me.ToolTabStrip1.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 200, 200)
        Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip1.SelectedIndex = 0
        Me.ToolTabStrip1.Size = New System.Drawing.Size(684, 198)
        Me.ToolTabStrip1.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 198)
        Me.ToolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 161)
        Me.ToolTabStrip1.TabIndex = 1
        Me.ToolTabStrip1.TabStop = False
        '
        'ToolTabStrip2
        '
        Me.ToolTabStrip2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolTabStrip2.Controls.Add(Me.tfCREC)
        Me.ToolTabStrip2.Location = New System.Drawing.Point(5, 368)
        Me.ToolTabStrip2.Name = "ToolTabStrip2"
        '
        '
        '
        Me.ToolTabStrip2.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 200, 200)
        Me.ToolTabStrip2.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip2.SelectedIndex = 0
        Me.ToolTabStrip2.Size = New System.Drawing.Size(684, 125)
        Me.ToolTabStrip2.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 125)
        Me.ToolTabStrip2.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 88)
        Me.ToolTabStrip2.TabIndex = 2
        Me.ToolTabStrip2.TabStop = False
        '
        'tfCREC
        '
        Me.tfCREC.Controls.Add(Me.TableLayoutPanel3)
        Me.tfCREC.Location = New System.Drawing.Point(1, 24)
        Me.tfCREC.Name = "tfCREC"
        Me.tfCREC.Size = New System.Drawing.Size(682, 99)
        Me.tfCREC.Text = "CREC"
        Me.tfCREC.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide
        '
        'ToolTabStrip3
        '
        Me.ToolTabStrip3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolTabStrip3.Controls.Add(Me.tfCHITCI)
        Me.ToolTabStrip3.Location = New System.Drawing.Point(5, 497)
        Me.ToolTabStrip3.Name = "ToolTabStrip3"
        '
        '
        '
        Me.ToolTabStrip3.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 200, 200)
        Me.ToolTabStrip3.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip3.SelectedIndex = 0
        Me.ToolTabStrip3.Size = New System.Drawing.Size(684, 123)
        Me.ToolTabStrip3.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 123)
        Me.ToolTabStrip3.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 86)
        Me.ToolTabStrip3.TabIndex = 3
        Me.ToolTabStrip3.TabStop = False
        '
        'tfCHITCI
        '
        Me.tfCHITCI.Controls.Add(Me.TableLayoutPanel4)
        Me.tfCHITCI.Location = New System.Drawing.Point(1, 24)
        Me.tfCHITCI.Name = "tfCHITCI"
        Me.tfCHITCI.Size = New System.Drawing.Size(682, 97)
        Me.tfCHITCI.Text = "CHITCI"
        Me.tfCHITCI.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.GridControl3, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(682, 97)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LinkLabel8)
        Me.Panel3.Controls.Add(Me.chkFiltrarErrorCHITCI)
        Me.Panel3.Controls.Add(Me.LinkLabel9)
        Me.Panel3.Controls.Add(Me.chkCorregirCHITCI)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(515, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(164, 91)
        Me.Panel3.TabIndex = 19
        '
        'ToolTabStrip4
        '
        Me.ToolTabStrip4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolTabStrip4.Controls.Add(Me.tfCHERFII)
        Me.ToolTabStrip4.Location = New System.Drawing.Point(5, 624)
        Me.ToolTabStrip4.Name = "ToolTabStrip4"
        '
        '
        '
        Me.ToolTabStrip4.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 200, 200)
        Me.ToolTabStrip4.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip4.SelectedIndex = 0
        Me.ToolTabStrip4.Size = New System.Drawing.Size(684, 97)
        Me.ToolTabStrip4.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 97)
        Me.ToolTabStrip4.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 59)
        Me.ToolTabStrip4.TabIndex = 4
        Me.ToolTabStrip4.TabStop = False
        '
        'tfCHERFII
        '
        Me.tfCHERFII.Controls.Add(Me.TableLayoutPanel6)
        Me.tfCHERFII.Location = New System.Drawing.Point(1, 24)
        Me.tfCHERFII.Name = "tfCHERFII"
        Me.tfCHERFII.Size = New System.Drawing.Size(682, 71)
        Me.tfCHERFII.Text = "CHERFII"
        Me.tfCHERFII.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.GridControl2, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(682, 71)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LinkLabel6)
        Me.Panel2.Controls.Add(Me.CheckBox5)
        Me.Panel2.Controls.Add(Me.LinkLabel7)
        Me.Panel2.Controls.Add(Me.CheckBox6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(515, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(164, 65)
        Me.Panel2.TabIndex = 14
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LecturasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(722, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(71, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LecturasToolStripMenuItem
        '
        Me.LecturasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciarCapturaToolStripMenuItem, Me.ToolStripMenuItem1, Me.InsertarToolStripMenuItem, Me.EditarToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ValidarToolStripMenuItem, Me.FiltrarErroresToolStripMenuItem})
        Me.LecturasToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.LecturasToolStripMenuItem.MergeIndex = 3
        Me.LecturasToolStripMenuItem.Name = "LecturasToolStripMenuItem"
        Me.LecturasToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
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
        'frmRecibido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 764)
        Me.Controls.Add(Me.RadDock1)
        Me.Controls.Add(Me.tpOpciones)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmRecibido"
        Me.Text = "Recibidos"
        CType(Me.Edit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MontoEditor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LecturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.tpOpciones.ResumeLayout(False)
        Me.tpOpciones.PerformLayout()
        Me.TaskFrame1.ResumeLayout(False)
        Me.tfValidar.ResumeLayout(False)
        Me.tfValidar.PerformLayout()
        Me.tfOpciones.ResumeLayout(False)
        Me.tfOpciones.PerformLayout()
        CType(Me.nudPaquete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMotivoDevolucion.ResumeLayout(False)
        Me.PanelMotivoDevolucion.PerformLayout()
        CType(Me.MotivosRechazoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TaskFrame5.ResumeLayout(False)
        Me.TaskFrame5.PerformLayout()
        Me.TaskFrame2.ResumeLayout(False)
        CType(Me.LecturasGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LecturaView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Edit12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Edit8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataRepeater1.ItemTemplate.ResumeLayout(False)
        Me.DataRepeater1.ItemTemplate.PerformLayout()
        Me.DataRepeater1.ResumeLayout(False)
        Me.DataRepeater1.PerformLayout()
        CType(Me.ErroresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.CRECDetGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRECDetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHITCIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCHITCI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHERFIIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCHERFII, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHERFIIGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolWindow1.ResumeLayout(False)
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentWindow1.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tfCREC.ResumeLayout(False)
        CType(Me.ToolTabStrip3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tfCHITCI.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ToolTabStrip4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tfCHERFII.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmnuInsertar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbIniciarCaptura As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbValidar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbErrores As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbInsertar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCargar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbDescargar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents cboBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents tpOpciones As WindowsControlLibrary.TaskPane
    Friend WithEvents TaskFrame1 As WindowsControlLibrary.TaskFrame
    Friend WithEvents tfValidar As WindowsControlLibrary.TaskFrame
    Friend WithEvents lnkBuscar As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents chkFiltraError As System.Windows.Forms.CheckBox
    Friend WithEvents lnkReasignar As System.Windows.Forms.LinkLabel
    Friend WithEvents nudLote As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tfOpciones As WindowsControlLibrary.TaskFrame
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
    Friend WithEvents DataRepeater1 As Microsoft.VisualBasic.PowerPacks.DataRepeater
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ErroresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label7 As System.Windows.Forms.Label
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
    Friend WithEvents CRECDetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChkCorregir As System.Windows.Forms.CheckBox
    Friend WithEvents LecturasGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents LecturaView As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents colIdMotivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConError As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Edit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
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
    Friend WithEvents chkLotesConError As System.Windows.Forms.CheckBox
    Friend WithEvents colNroError As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkValidarFiltrar As System.Windows.Forms.CheckBox
    Friend WithEvents TaskFrame2 As WindowsControlLibrary.TaskFrame
    Friend WithEvents SearchPanel1 As WindowsControlLibrary.SearchPanel
    Friend WithEvents colnro_corrida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPAQUETE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LinkPaqueteAct As System.Windows.Forms.LinkLabel
    Friend WithEvents nudPaquete As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblPaquete As System.Windows.Forms.Label
    Friend WithEvents LinkLabel6 As System.Windows.Forms.LinkLabel
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridCHERFII As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colcfCtaLibradora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcfSerie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcfBoleta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcfImporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcfCtaDep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit11 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit12 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents LinkLabel7 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CHERFIIGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCtaLibradora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNroCheque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComprobante As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCtaDeposito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents lnkValidarCHER As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents LinkLabel5 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel8 As System.Windows.Forms.LinkLabel
    Friend WithEvents chkFiltrarErrorCHITCI As System.Windows.Forms.CheckBox
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridCHITCI As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCtaDeposito1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporte1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantCheques As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkCorregirCHITCI As System.Windows.Forms.CheckBox
    Friend WithEvents LinkLabel9 As System.Windows.Forms.LinkLabel
    Friend WithEvents CHERFIIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CHITCIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colComprobante1 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents Edit12 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Public WithEvents Edit8 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Public WithEvents MontoEditor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colTipoUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcod_maquina As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAgenciaCR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAgencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsuario1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txtErrores As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents txtSubDif As System.Windows.Forms.Label
    Friend WithEvents lblSubDif As System.Windows.Forms.Label
    Friend WithEvents txtSubTotalDet As System.Windows.Forms.Label
    Friend WithEvents lblSubTotalDet As System.Windows.Forms.Label
    Friend WithEvents txtSubTotalCab As System.Windows.Forms.Label
    Friend WithEvents lblSubTotalCab As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents LecturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IniciarCapturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ValidarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FiltrarErroresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCierre As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkCD As System.Windows.Forms.CheckBox
    Private WithEvents RadDock1 As Telerik.WinControls.UI.Docking.RadDock
    Private WithEvents DocumentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
    Private WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Private WithEvents DocumentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Private WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Private WithEvents ToolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
    Private WithEvents ToolTabStrip2 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Private WithEvents tfCREC As Telerik.WinControls.UI.Docking.ToolWindow
    Private WithEvents ToolTabStrip3 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Private WithEvents tfCHITCI As Telerik.WinControls.UI.Docking.ToolWindow
    Private WithEvents ToolTabStrip4 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Private WithEvents tfCHERFII As Telerik.WinControls.UI.Docking.ToolWindow
    Private WithEvents DockWindowPlaceholder1 As Telerik.WinControls.UI.Docking.DockWindowPlaceholder
    Private WithEvents DockWindowPlaceholder2 As Telerik.WinControls.UI.Docking.DockWindowPlaceholder
    Private WithEvents DockWindowPlaceholder3 As Telerik.WinControls.UI.Docking.DockWindowPlaceholder
    Private WithEvents DockWindowPlaceholder4 As Telerik.WinControls.UI.Docking.DockWindowPlaceholder
End Class
