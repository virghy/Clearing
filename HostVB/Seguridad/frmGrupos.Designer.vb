<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrupos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim IdgrupoLabel As System.Windows.Forms.Label
        Dim IdsistemaLabel As System.Windows.Forms.Label
        Dim GrupoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrupos))
        Me.DsSeguridad = New HostVB.dsSeguridad
        Me.Aspnet_gruposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Aspnet_gruposTableAdapter = New HostVB.dsSeguridadTableAdapters.aspnet_gruposTableAdapter
        Me.TableAdapterManager = New HostVB.dsSeguridadTableAdapters.TableAdapterManager
        Me.Aspnet_gruposBindingNavigator = New WindowsControlLibrary.ValidatingBindingNavigator(Me.components)
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
        Me.Aspnet_gruposBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GrupoTextBox = New System.Windows.Forms.TextBox
        Me.IdgrupoTextBox = New System.Windows.Forms.TextBox
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Aspnet_grupoUsuarioDataGridView = New System.Windows.Forms.DataGridView
        Me.Aspnet_grupoUsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.Aspnet_permisosDataGridView = New System.Windows.Forms.DataGridView
        Me.Aspnet_permisosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Aspnet_grupoUsuarioTableAdapter = New HostVB.dsSeguridadTableAdapters.aspnet_grupoUsuarioTableAdapter
        Me.Aspnet_permisosTableAdapter = New HostVB.dsSeguridadTableAdapters.aspnet_permisosTableAdapter
        Me.FKaspnetgrupoUsuarioaspnetgruposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Aspnet_sistemasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Aspnet_sistemasTableAdapter = New HostVB.dsSeguridadTableAdapters.aspnet_sistemasTableAdapter
        Me.Aspnet_gruposDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Objeto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        IdgrupoLabel = New System.Windows.Forms.Label
        IdsistemaLabel = New System.Windows.Forms.Label
        GrupoLabel = New System.Windows.Forms.Label
        CType(Me.DsSeguridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Aspnet_gruposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Aspnet_gruposBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Aspnet_gruposBindingNavigator.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.Aspnet_grupoUsuarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Aspnet_grupoUsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.Aspnet_permisosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Aspnet_permisosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.FKaspnetgrupoUsuarioaspnetgruposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Aspnet_sistemasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Aspnet_gruposDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdgrupoLabel
        '
        IdgrupoLabel.AutoSize = True
        IdgrupoLabel.Location = New System.Drawing.Point(13, 7)
        IdgrupoLabel.Name = "IdgrupoLabel"
        IdgrupoLabel.Size = New System.Drawing.Size(48, 13)
        IdgrupoLabel.TabIndex = 0
        IdgrupoLabel.Text = "Id Grupo"
        '
        'IdsistemaLabel
        '
        IdsistemaLabel.AutoSize = True
        IdsistemaLabel.Location = New System.Drawing.Point(13, 33)
        IdsistemaLabel.Name = "IdsistemaLabel"
        IdsistemaLabel.Size = New System.Drawing.Size(44, 13)
        IdsistemaLabel.TabIndex = 2
        IdsistemaLabel.Text = "Sistema"
        '
        'GrupoLabel
        '
        GrupoLabel.AutoSize = True
        GrupoLabel.Location = New System.Drawing.Point(13, 59)
        GrupoLabel.Name = "GrupoLabel"
        GrupoLabel.Size = New System.Drawing.Size(36, 13)
        GrupoLabel.TabIndex = 4
        GrupoLabel.Text = "Grupo"
        '
        'DsSeguridad
        '
        Me.DsSeguridad.DataSetName = "dsSeguridad"
        Me.DsSeguridad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Aspnet_gruposBindingSource
        '
        Me.Aspnet_gruposBindingSource.DataMember = "aspnet_grupos"
        Me.Aspnet_gruposBindingSource.DataSource = Me.DsSeguridad
        '
        'Aspnet_gruposTableAdapter
        '
        Me.Aspnet_gruposTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.aspnet_gruposTableAdapter = Me.Aspnet_gruposTableAdapter
        Me.TableAdapterManager.aspnet_grupoUsuarioTableAdapter = Me.Aspnet_grupoUsuarioTableAdapter
        Me.TableAdapterManager.aspnet_objetosTableAdapter = Nothing
        Me.TableAdapterManager.aspnet_permisosTableAdapter = Me.Aspnet_permisosTableAdapter
        Me.TableAdapterManager.aspnet_sistemasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = HostVB.dsSeguridadTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Aspnet_gruposBindingNavigator
        '
        Me.Aspnet_gruposBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Aspnet_gruposBindingNavigator.BindingSource = Me.Aspnet_gruposBindingSource
        Me.Aspnet_gruposBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Aspnet_gruposBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Aspnet_gruposBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Aspnet_gruposBindingNavigatorSaveItem})
        Me.Aspnet_gruposBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Aspnet_gruposBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Aspnet_gruposBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Aspnet_gruposBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Aspnet_gruposBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Aspnet_gruposBindingNavigator.Name = "Aspnet_gruposBindingNavigator"
        Me.Aspnet_gruposBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Aspnet_gruposBindingNavigator.Size = New System.Drawing.Size(595, 25)
        Me.Aspnet_gruposBindingNavigator.TabIndex = 0
        Me.Aspnet_gruposBindingNavigator.Text = "BindingNavigator1"
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
        'Aspnet_gruposBindingNavigatorSaveItem
        '
        Me.Aspnet_gruposBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Aspnet_gruposBindingNavigatorSaveItem.Image = CType(resources.GetObject("Aspnet_gruposBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Aspnet_gruposBindingNavigatorSaveItem.Name = "Aspnet_gruposBindingNavigatorSaveItem"
        Me.Aspnet_gruposBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Aspnet_gruposBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(595, 383)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(587, 357)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Entrada de Datos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(581, 351)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(IdgrupoLabel)
        Me.Panel1.Controls.Add(Me.GrupoTextBox)
        Me.Panel1.Controls.Add(Me.IdgrupoTextBox)
        Me.Panel1.Controls.Add(GrupoLabel)
        Me.Panel1.Controls.Add(IdsistemaLabel)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(575, 94)
        Me.Panel1.TabIndex = 6
        '
        'GrupoTextBox
        '
        Me.GrupoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Aspnet_gruposBindingSource, "grupo", True))
        Me.GrupoTextBox.Location = New System.Drawing.Point(72, 56)
        Me.GrupoTextBox.Name = "GrupoTextBox"
        Me.GrupoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GrupoTextBox.TabIndex = 5
        '
        'IdgrupoTextBox
        '
        Me.IdgrupoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Aspnet_gruposBindingSource, "idgrupo", True))
        Me.IdgrupoTextBox.Location = New System.Drawing.Point(72, 4)
        Me.IdgrupoTextBox.Name = "IdgrupoTextBox"
        Me.IdgrupoTextBox.ReadOnly = True
        Me.IdgrupoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdgrupoTextBox.TabIndex = 1
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(3, 103)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(575, 245)
        Me.TabControl2.TabIndex = 7
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.Aspnet_grupoUsuarioDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(567, 219)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Usuarios"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Aspnet_grupoUsuarioDataGridView
        '
        Me.Aspnet_grupoUsuarioDataGridView.AutoGenerateColumns = False
        Me.Aspnet_grupoUsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Aspnet_grupoUsuarioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.Nombre})
        Me.Aspnet_grupoUsuarioDataGridView.DataSource = Me.FKaspnetgrupoUsuarioaspnetgruposBindingSource
        Me.Aspnet_grupoUsuarioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Aspnet_grupoUsuarioDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Aspnet_grupoUsuarioDataGridView.Name = "Aspnet_grupoUsuarioDataGridView"
        Me.Aspnet_grupoUsuarioDataGridView.Size = New System.Drawing.Size(561, 213)
        Me.Aspnet_grupoUsuarioDataGridView.TabIndex = 0
        '
        'Aspnet_grupoUsuarioBindingSource
        '
        Me.Aspnet_grupoUsuarioBindingSource.DataMember = "aspnet_grupoUsuario"
        Me.Aspnet_grupoUsuarioBindingSource.DataSource = Me.DsSeguridad
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.Aspnet_permisosDataGridView)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(567, 219)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Permisos"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Aspnet_permisosDataGridView
        '
        Me.Aspnet_permisosDataGridView.AllowUserToAddRows = False
        Me.Aspnet_permisosDataGridView.AllowUserToDeleteRows = False
        Me.Aspnet_permisosDataGridView.AutoGenerateColumns = False
        Me.Aspnet_permisosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Aspnet_permisosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.Objeto, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewCheckBoxColumn5})
        Me.Aspnet_permisosDataGridView.DataSource = Me.Aspnet_permisosBindingSource
        Me.Aspnet_permisosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Aspnet_permisosDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Aspnet_permisosDataGridView.Name = "Aspnet_permisosDataGridView"
        Me.Aspnet_permisosDataGridView.Size = New System.Drawing.Size(561, 213)
        Me.Aspnet_permisosDataGridView.TabIndex = 0
        '
        'Aspnet_permisosBindingSource
        '
        Me.Aspnet_permisosBindingSource.DataMember = "aspnet_permisos"
        Me.Aspnet_permisosBindingSource.DataSource = Me.DsSeguridad
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Aspnet_gruposDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(587, 357)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lista"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Aspnet_grupoUsuarioTableAdapter
        '
        Me.Aspnet_grupoUsuarioTableAdapter.ClearBeforeFill = True
        '
        'Aspnet_permisosTableAdapter
        '
        Me.Aspnet_permisosTableAdapter.ClearBeforeFill = True
        '
        'FKaspnetgrupoUsuarioaspnetgruposBindingSource
        '
        Me.FKaspnetgrupoUsuarioaspnetgruposBindingSource.DataMember = "FK_aspnet_grupoUsuario_aspnet_grupos"
        Me.FKaspnetgrupoUsuarioaspnetgruposBindingSource.DataSource = Me.Aspnet_gruposBindingSource
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Aspnet_gruposBindingSource, "idsistema", True))
        Me.ComboBox1.DataSource = Me.Aspnet_sistemasBindingSource
        Me.ComboBox1.DisplayMember = "sistema"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(72, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.ValueMember = "idsistema"
        '
        'Aspnet_sistemasBindingSource
        '
        Me.Aspnet_sistemasBindingSource.DataMember = "aspnet_sistemas"
        Me.Aspnet_sistemasBindingSource.DataSource = Me.DsSeguridad
        '
        'Aspnet_sistemasTableAdapter
        '
        Me.Aspnet_sistemasTableAdapter.ClearBeforeFill = True
        '
        'Aspnet_gruposDataGridView
        '
        Me.Aspnet_gruposDataGridView.AllowUserToAddRows = False
        Me.Aspnet_gruposDataGridView.AllowUserToDeleteRows = False
        Me.Aspnet_gruposDataGridView.AutoGenerateColumns = False
        Me.Aspnet_gruposDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Aspnet_gruposDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Aspnet_gruposDataGridView.DataSource = Me.Aspnet_gruposBindingSource
        Me.Aspnet_gruposDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Aspnet_gruposDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Aspnet_gruposDataGridView.Name = "Aspnet_gruposDataGridView"
        Me.Aspnet_gruposDataGridView.ReadOnly = True
        Me.Aspnet_gruposDataGridView.Size = New System.Drawing.Size(581, 351)
        Me.Aspnet_gruposDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idgrupo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idgrupo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "idsistema"
        Me.DataGridViewTextBoxColumn4.HeaderText = "idsistema"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "grupo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "grupo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "idobjeto"
        Me.DataGridViewTextBoxColumn7.HeaderText = "idobjeto"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'Objeto
        '
        Me.Objeto.HeaderText = "Objeto"
        Me.Objeto.Name = "Objeto"
        Me.Objeto.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "ejecutar"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "ejecutar"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "agregar"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "agregar"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "modificar"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "modificar"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "borrar"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "borrar"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.DataPropertyName = "consultar"
        Me.DataGridViewCheckBoxColumn5.HeaderText = "consultar"
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idusuario"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'frmGrupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 408)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Aspnet_gruposBindingNavigator)
        Me.Name = "frmGrupos"
        Me.Text = "Grupos y Permisos"
        CType(Me.DsSeguridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Aspnet_gruposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Aspnet_gruposBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Aspnet_gruposBindingNavigator.ResumeLayout(False)
        Me.Aspnet_gruposBindingNavigator.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.Aspnet_grupoUsuarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Aspnet_grupoUsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.Aspnet_permisosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Aspnet_permisosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.FKaspnetgrupoUsuarioaspnetgruposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Aspnet_sistemasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Aspnet_gruposDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsSeguridad As HostVB.dsSeguridad
    Friend WithEvents Aspnet_gruposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Aspnet_gruposTableAdapter As HostVB.dsSeguridadTableAdapters.aspnet_gruposTableAdapter
    Friend WithEvents TableAdapterManager As HostVB.dsSeguridadTableAdapters.TableAdapterManager
    Friend WithEvents Aspnet_gruposBindingNavigator As WindowsControlLibrary.ValidatingBindingNavigator
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
    Friend WithEvents Aspnet_gruposBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GrupoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdgrupoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Aspnet_grupoUsuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Aspnet_grupoUsuarioTableAdapter As HostVB.dsSeguridadTableAdapters.aspnet_grupoUsuarioTableAdapter
    Friend WithEvents Aspnet_grupoUsuarioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Aspnet_permisosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Aspnet_permisosTableAdapter As HostVB.dsSeguridadTableAdapters.aspnet_permisosTableAdapter
    Friend WithEvents Aspnet_permisosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FKaspnetgrupoUsuarioaspnetgruposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Aspnet_sistemasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Aspnet_sistemasTableAdapter As HostVB.dsSeguridadTableAdapters.aspnet_sistemasTableAdapter
    Friend WithEvents Aspnet_gruposDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Objeto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn5 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
