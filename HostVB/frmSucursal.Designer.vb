<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSucursal
    Inherits WindowsControlLibrary.frmBase

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
        Me.Bancos = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.BancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SucursalesDataGridView = New System.Windows.Forms.DataGridView
        Me.CodsucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombresucusalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cod_banco = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(ClearingDA.Sucursales)
        '
        'Bancos
        '
        Me.Bancos.DataPropertyName = "cod_banco"
        Me.Bancos.HeaderText = "Bancos"
        Me.Bancos.Name = "Bancos"
        Me.Bancos.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Bancos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'BancosBindingSource
        '
        Me.BancosBindingSource.DataSource = GetType(ClearingDA.Bancos)
        '
        'SucursalesDataGridView
        '
        Me.SucursalesDataGridView.AutoGenerateColumns = False
        Me.SucursalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SucursalesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodsucursalDataGridViewTextBoxColumn, Me.NombresucusalDataGridViewTextBoxColumn, Me.cod_banco})
        Me.SucursalesDataGridView.DataSource = Me.BindingSource
        Me.SucursalesDataGridView.Location = New System.Drawing.Point(0, 68)
        Me.SucursalesDataGridView.Name = "SucursalesDataGridView"
        Me.SucursalesDataGridView.Size = New System.Drawing.Size(444, 170)
        Me.SucursalesDataGridView.TabIndex = 1
        '
        'CodsucursalDataGridViewTextBoxColumn
        '
        Me.CodsucursalDataGridViewTextBoxColumn.DataPropertyName = "cod_sucursal"
        Me.CodsucursalDataGridViewTextBoxColumn.HeaderText = "cod_sucursal"
        Me.CodsucursalDataGridViewTextBoxColumn.Name = "CodsucursalDataGridViewTextBoxColumn"
        '
        'NombresucusalDataGridViewTextBoxColumn
        '
        Me.NombresucusalDataGridViewTextBoxColumn.DataPropertyName = "nombre_sucusal"
        Me.NombresucusalDataGridViewTextBoxColumn.HeaderText = "nombre_sucusal"
        Me.NombresucusalDataGridViewTextBoxColumn.Name = "NombresucusalDataGridViewTextBoxColumn"
        '
        'cod_banco
        '
        Me.cod_banco.DataPropertyName = "cod_banco"
        Me.cod_banco.HeaderText = "cod_banco"
        Me.cod_banco.Name = "cod_banco"
        Me.cod_banco.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Banco"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.BancosBindingSource
        Me.ComboBox1.DisplayMember = "nombre_banco"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(57, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(162, 21)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.ValueMember = "cod_banco"
        '
        'frmSucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 364)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SucursalesDataGridView)
        Me.Name = "frmSucursal"
        Me.Text = "frmSucursal"
        Me.Controls.SetChildIndex(Me.SucursalesDataGridView, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ComboBox1, 0)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bancos As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents BancosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SucursalesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents CodsucursalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombresucusalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cod_banco As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
