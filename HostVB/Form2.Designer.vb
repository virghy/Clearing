<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.RegionDataGridView = New System.Windows.Forms.DataGridView
        Me.IdRegionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(DataAccess.Region)
        '
        'RegionDataGridView
        '
        Me.RegionDataGridView.AutoGenerateColumns = False
        Me.RegionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RegionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdRegionDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn})
        Me.RegionDataGridView.DataSource = Me.BindingSource
        Me.RegionDataGridView.Location = New System.Drawing.Point(26, 38)
        Me.RegionDataGridView.Name = "RegionDataGridView"
        Me.RegionDataGridView.Size = New System.Drawing.Size(300, 117)
        Me.RegionDataGridView.TabIndex = 1
        '
        'IdRegionDataGridViewTextBoxColumn
        '
        Me.IdRegionDataGridViewTextBoxColumn.DataPropertyName = "idRegion"
        Me.IdRegionDataGridViewTextBoxColumn.HeaderText = "idRegion"
        Me.IdRegionDataGridViewTextBoxColumn.Name = "IdRegionDataGridViewTextBoxColumn"
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(26, 181)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 278)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RegionDataGridView)
        Me.IdObjeto = 90
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Controls.SetChildIndex(Me.RegionDataGridView, 0)
        Me.Controls.SetChildIndex(Me.ComboBox1, 0)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RegionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IdRegionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
