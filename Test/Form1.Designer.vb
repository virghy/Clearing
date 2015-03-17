<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LecturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LecturasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.LecturasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.LecturasGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colnro_lote = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcod_tipdoc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcuenta_cheque = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnumero_cheque = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcod_banco_receptor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcod_camara = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colmonto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcabecera = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcadena_captura = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcod_banco_emisor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdLectura = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCORREGIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.txtMaquina = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCant = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Procesar = New System.Windows.Forms.Button
        Me.txtProceso = New System.Windows.Forms.TextBox
        Me.txtFecha = New System.Windows.Forms.DateTimePicker
        Me.txtBanco = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ProcesoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtCadenaDev = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCampo4 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCampo3 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCampo2 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtCampo1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCadena = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblCab = New System.Windows.Forms.Label
        CType(Me.LecturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LecturasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LecturasBindingNavigator.SuspendLayout()
        CType(Me.LecturasGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProcesoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'LecturasBindingSource
        '
        Me.LecturasBindingSource.DataSource = GetType(DataAccess.Lecturas)
        '
        'LecturasBindingNavigator
        '
        Me.LecturasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LecturasBindingNavigator.BindingSource = Me.LecturasBindingSource
        Me.LecturasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LecturasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LecturasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LecturasBindingNavigatorSaveItem})
        Me.LecturasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LecturasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LecturasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LecturasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LecturasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LecturasBindingNavigator.Name = "LecturasBindingNavigator"
        Me.LecturasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LecturasBindingNavigator.Size = New System.Drawing.Size(590, 25)
        Me.LecturasBindingNavigator.TabIndex = 0
        Me.LecturasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'LecturasBindingNavigatorSaveItem
        '
        Me.LecturasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LecturasBindingNavigatorSaveItem.Enabled = False
        Me.LecturasBindingNavigatorSaveItem.Image = CType(resources.GetObject("LecturasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LecturasBindingNavigatorSaveItem.Name = "LecturasBindingNavigatorSaveItem"
        Me.LecturasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LecturasBindingNavigatorSaveItem.Text = "Save Data"
        '
        'LecturasGridControl
        '
        Me.LecturasGridControl.DataSource = Me.LecturasBindingSource
        Me.LecturasGridControl.Location = New System.Drawing.Point(3, 3)
        Me.LecturasGridControl.MainView = Me.GridView1
        Me.LecturasGridControl.Name = "LecturasGridControl"
        Me.LecturasGridControl.Size = New System.Drawing.Size(576, 187)
        Me.LecturasGridControl.TabIndex = 1
        Me.LecturasGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnro_lote, Me.colcod_tipdoc, Me.colcuenta_cheque, Me.colnumero_cheque, Me.colcod_banco_receptor, Me.colcod_camara, Me.colmonto, Me.colcabecera, Me.colcadena_captura, Me.colcod_banco_emisor, Me.colIdLectura, Me.colCORREGIDO})
        Me.GridView1.GridControl = Me.LecturasGridControl
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "monto", Nothing, "", 1)})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colnro_lote
        '
        Me.colnro_lote.FieldName = "nro_lote"
        Me.colnro_lote.Name = "colnro_lote"
        Me.colnro_lote.Visible = True
        Me.colnro_lote.VisibleIndex = 0
        '
        'colcod_tipdoc
        '
        Me.colcod_tipdoc.FieldName = "cod_tipdoc"
        Me.colcod_tipdoc.Name = "colcod_tipdoc"
        Me.colcod_tipdoc.Visible = True
        Me.colcod_tipdoc.VisibleIndex = 1
        '
        'colcuenta_cheque
        '
        Me.colcuenta_cheque.FieldName = "cuenta_cheque"
        Me.colcuenta_cheque.Name = "colcuenta_cheque"
        Me.colcuenta_cheque.Visible = True
        Me.colcuenta_cheque.VisibleIndex = 2
        '
        'colnumero_cheque
        '
        Me.colnumero_cheque.FieldName = "numero_cheque"
        Me.colnumero_cheque.Name = "colnumero_cheque"
        Me.colnumero_cheque.Visible = True
        Me.colnumero_cheque.VisibleIndex = 3
        '
        'colcod_banco_receptor
        '
        Me.colcod_banco_receptor.FieldName = "cod_banco_receptor"
        Me.colcod_banco_receptor.Name = "colcod_banco_receptor"
        Me.colcod_banco_receptor.Visible = True
        Me.colcod_banco_receptor.VisibleIndex = 4
        '
        'colcod_camara
        '
        Me.colcod_camara.FieldName = "cod_camara"
        Me.colcod_camara.Name = "colcod_camara"
        Me.colcod_camara.Visible = True
        Me.colcod_camara.VisibleIndex = 5
        '
        'colmonto
        '
        Me.colmonto.FieldName = "monto"
        Me.colmonto.Name = "colmonto"
        Me.colmonto.SummaryItem.DisplayFormat = "{0:N0}"
        Me.colmonto.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
        Me.colmonto.Visible = True
        Me.colmonto.VisibleIndex = 6
        '
        'colcabecera
        '
        Me.colcabecera.FieldName = "cabecera"
        Me.colcabecera.Name = "colcabecera"
        Me.colcabecera.Visible = True
        Me.colcabecera.VisibleIndex = 7
        '
        'colcadena_captura
        '
        Me.colcadena_captura.FieldName = "cadena_captura"
        Me.colcadena_captura.Name = "colcadena_captura"
        Me.colcadena_captura.Visible = True
        Me.colcadena_captura.VisibleIndex = 8
        '
        'colcod_banco_emisor
        '
        Me.colcod_banco_emisor.FieldName = "cod_banco_emisor"
        Me.colcod_banco_emisor.Name = "colcod_banco_emisor"
        Me.colcod_banco_emisor.Visible = True
        Me.colcod_banco_emisor.VisibleIndex = 9
        '
        'colIdLectura
        '
        Me.colIdLectura.FieldName = "IdLectura"
        Me.colIdLectura.Name = "colIdLectura"
        Me.colIdLectura.Visible = True
        Me.colIdLectura.VisibleIndex = 10
        '
        'colCORREGIDO
        '
        Me.colCORREGIDO.FieldName = "CORREGIDO"
        Me.colCORREGIDO.Name = "colCORREGIDO"
        Me.colCORREGIDO.Visible = True
        Me.colCORREGIDO.VisibleIndex = 11
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(590, 253)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblCab)
        Me.TabPage1.Controls.Add(Me.LecturasGridControl)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(582, 227)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtMaquina)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtCant)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Procesar)
        Me.TabPage2.Controls.Add(Me.txtProceso)
        Me.TabPage2.Controls.Add(Me.txtFecha)
        Me.TabPage2.Controls.Add(Me.txtBanco)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(582, 227)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtMaquina
        '
        Me.txtMaquina.Location = New System.Drawing.Point(80, 133)
        Me.txtMaquina.Name = "txtMaquina"
        Me.txtMaquina.Size = New System.Drawing.Size(100, 20)
        Me.txtMaquina.TabIndex = 10
        Me.txtMaquina.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Maquina"
        '
        'txtCant
        '
        Me.txtCant.Location = New System.Drawing.Point(80, 107)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(100, 20)
        Me.txtCant.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cant"
        '
        'Procesar
        '
        Me.Procesar.Location = New System.Drawing.Point(407, 20)
        Me.Procesar.Name = "Procesar"
        Me.Procesar.Size = New System.Drawing.Size(75, 23)
        Me.Procesar.TabIndex = 6
        Me.Procesar.Text = "Cargar"
        Me.Procesar.UseVisualStyleBackColor = True
        '
        'txtProceso
        '
        Me.txtProceso.Location = New System.Drawing.Point(80, 77)
        Me.txtProceso.Name = "txtProceso"
        Me.txtProceso.Size = New System.Drawing.Size(100, 20)
        Me.txtProceso.TabIndex = 5
        Me.txtProceso.Text = "2"
        '
        'txtFecha
        '
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha.Location = New System.Drawing.Point(80, 50)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 4
        Me.txtFecha.Value = New Date(2010, 3, 10, 0, 0, 0, 0)
        '
        'txtBanco
        '
        Me.txtBanco.Location = New System.Drawing.Point(80, 23)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(100, 20)
        Me.txtBanco.TabIndex = 3
        Me.txtBanco.Text = "06"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Proceso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Banco"
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.GridControl1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(582, 227)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.ProcesoBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(3, 3)
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(576, 221)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'ProcesoBindingSource
        '
        Me.ProcesoBindingSource.DataSource = GetType(DataAccess.Lecturas)
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12})
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowFooter = True
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "nro_lote"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "cod_tipdoc"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "cuenta_cheque"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "numero_cheque"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.FieldName = "cod_banco_receptor"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "cod_camara"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'GridColumn7
        '
        Me.GridColumn7.FieldName = "monto"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        '
        'GridColumn8
        '
        Me.GridColumn8.FieldName = "cabecera"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        '
        'GridColumn9
        '
        Me.GridColumn9.FieldName = "cadena_captura"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        '
        'GridColumn10
        '
        Me.GridColumn10.FieldName = "cod_banco_emisor"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        '
        'GridColumn11
        '
        Me.GridColumn11.FieldName = "IdLectura"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 10
        '
        'GridColumn12
        '
        Me.GridColumn12.FieldName = "CORREGIDO"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 11
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.txtCadenaDev)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.txtCampo4)
        Me.TabPage4.Controls.Add(Me.Label9)
        Me.TabPage4.Controls.Add(Me.txtCampo3)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Controls.Add(Me.txtCampo2)
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Controls.Add(Me.txtCampo1)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.txtCadena)
        Me.TabPage4.Controls.Add(Me.Button1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(582, 227)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 174)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Cadena Dev"
        '
        'txtCadenaDev
        '
        Me.txtCadenaDev.Location = New System.Drawing.Point(98, 171)
        Me.txtCadenaDev.Name = "txtCadenaDev"
        Me.txtCadenaDev.Size = New System.Drawing.Size(405, 20)
        Me.txtCadenaDev.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Campo4"
        '
        'txtCampo4
        '
        Me.txtCampo4.Location = New System.Drawing.Point(98, 145)
        Me.txtCampo4.Name = "txtCampo4"
        Me.txtCampo4.Size = New System.Drawing.Size(143, 20)
        Me.txtCampo4.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Campo3"
        '
        'txtCampo3
        '
        Me.txtCampo3.Location = New System.Drawing.Point(98, 119)
        Me.txtCampo3.Name = "txtCampo3"
        Me.txtCampo3.Size = New System.Drawing.Size(143, 20)
        Me.txtCampo3.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Campo2"
        '
        'txtCampo2
        '
        Me.txtCampo2.Location = New System.Drawing.Point(98, 93)
        Me.txtCampo2.Name = "txtCampo2"
        Me.txtCampo2.Size = New System.Drawing.Size(143, 20)
        Me.txtCampo2.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Campo1"
        '
        'txtCampo1
        '
        Me.txtCampo1.Location = New System.Drawing.Point(98, 67)
        Me.txtCampo1.Name = "txtCampo1"
        Me.txtCampo1.Size = New System.Drawing.Size(143, 20)
        Me.txtCampo1.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Cadena"
        '
        'txtCadena
        '
        Me.txtCadena.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LecturasBindingSource, "cadena_captura", True))
        Me.txtCadena.Location = New System.Drawing.Point(98, 28)
        Me.txtCadena.Name = "txtCadena"
        Me.txtCadena.Size = New System.Drawing.Size(405, 20)
        Me.txtCadena.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(428, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Procesar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblCab
        '
        Me.lblCab.AutoSize = True
        Me.lblCab.Location = New System.Drawing.Point(9, 197)
        Me.lblCab.Name = "lblCab"
        Me.lblCab.Size = New System.Drawing.Size(0, 13)
        Me.lblCab.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 278)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.LecturasBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.LecturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LecturasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LecturasBindingNavigator.ResumeLayout(False)
        Me.LecturasBindingNavigator.PerformLayout()
        CType(Me.LecturasGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProcesoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LecturasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LecturasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LecturasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents colcod_banco_emisor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdLectura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtProceso As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCant As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Procesar As System.Windows.Forms.Button
    Friend WithEvents txtMaquina As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents colCORREGIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ProcesoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents txtCadena As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCampo4 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCampo3 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCampo2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCampo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCadenaDev As System.Windows.Forms.TextBox
    Friend WithEvents lblCab As System.Windows.Forms.Label

End Class
