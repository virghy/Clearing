<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBanco
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
        Me.BancosDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CuentaPaisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ActivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(ClearingDA.Bancos)
        '
        'BancosDataGridView
        '
        Me.BancosDataGridView.AutoGenerateColumns = False
        Me.BancosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BancosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.CuentaPaisDataGridViewTextBoxColumn, Me.ActivoDataGridViewTextBoxColumn})
        Me.BancosDataGridView.DataSource = Me.BindingSource
        Me.BancosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BancosDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.BancosDataGridView.Name = "BancosDataGridView"
        Me.BancosDataGridView.Size = New System.Drawing.Size(449, 317)
        Me.BancosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "cod_banco"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre_banco"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'CuentaPaisDataGridViewTextBoxColumn
        '
        Me.CuentaPaisDataGridViewTextBoxColumn.DataPropertyName = "CuentaPais"
        Me.CuentaPaisDataGridViewTextBoxColumn.HeaderText = "Cuenta Pais"
        Me.CuentaPaisDataGridViewTextBoxColumn.Name = "CuentaPaisDataGridViewTextBoxColumn"
        '
        'ActivoDataGridViewTextBoxColumn
        '
        Me.ActivoDataGridViewTextBoxColumn.DataPropertyName = "Activo"
        Me.ActivoDataGridViewTextBoxColumn.HeaderText = "Activo"
        Me.ActivoDataGridViewTextBoxColumn.Name = "ActivoDataGridViewTextBoxColumn"
        Me.ActivoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ActivoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ActivoDataGridViewTextBoxColumn.Width = 50
        '
        'frmBanco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 342)
        Me.Controls.Add(Me.BancosDataGridView)
        Me.Name = "frmBanco"
        Me.Text = "frmBanco"
        Me.Controls.SetChildIndex(Me.BancosDataGridView, 0)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BancosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CodbancoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombrebancoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuentaPaisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActivoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
