<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.LecturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClearingDataSets = New HostVB.ClearingDataSets
        Me.LecturasTableAdapter = New HostVB.ClearingDataSetsTableAdapters.LecturasTableAdapter
        Me.TableAdapterManager = New HostVB.ClearingDataSetsTableAdapters.TableAdapterManager
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.LecturasDataGridView = New System.Windows.Forms.DataGridView
        Me.IdLectura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tbcSerie = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cod_sucursal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.LecturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClearingDataSets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.LecturasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LecturasDataGridView, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 13)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(456, 100)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'LecturasDataGridView
        '
        Me.LecturasDataGridView.AllowUserToAddRows = False
        Me.LecturasDataGridView.AllowUserToOrderColumns = True
        Me.LecturasDataGridView.AutoGenerateColumns = False
        Me.LecturasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LecturasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdLectura, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.tbcSerie, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn8, Me.Importe, Me.cod_sucursal, Me.DataGridViewTextBoxColumn12})
        Me.LecturasDataGridView.DataSource = Me.LecturasBindingSource
        Me.LecturasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LecturasDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.LecturasDataGridView.Name = "LecturasDataGridView"
        Me.LecturasDataGridView.ReadOnly = True
        Me.LecturasDataGridView.Size = New System.Drawing.Size(450, 94)
        Me.LecturasDataGridView.TabIndex = 9
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
        Me.DataGridViewTextBoxColumn7.Width = 40
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cod_tipdoc"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Doc"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 40
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "cuenta_cheque"
        DataGridViewCellStyle1.Format = "000000000000"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cuenta"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'tbcSerie
        '
        Me.tbcSerie.DataPropertyName = "numero_cheque"
        DataGridViewCellStyle2.Format = "00000000"
        Me.tbcSerie.DefaultCellStyle = DataGridViewCellStyle2
        Me.tbcSerie.FilteringEnabled = True
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
        Me.DataGridViewTextBoxColumn27.Width = 40
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "cod_camara"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Camara"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 40
        '
        'Importe
        '
        Me.Importe.DataPropertyName = "monto"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle3
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'cod_sucursal
        '
        Me.cod_sucursal.DataPropertyName = "cod_sucursal"
        Me.cod_sucursal.HeaderText = "Sucursal"
        Me.cod_sucursal.Name = "cod_sucursal"
        Me.cod_sucursal.ReadOnly = True
        Me.cod_sucursal.Width = 50
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "cabecera"
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn12.HeaderText = "Secuencia"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 60
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 280)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.LecturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClearingDataSets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.LecturasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ClearingDataSets As HostVB.ClearingDataSets
    Friend WithEvents LecturasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LecturasTableAdapter As HostVB.ClearingDataSetsTableAdapters.LecturasTableAdapter
    Friend WithEvents TableAdapterManager As HostVB.ClearingDataSetsTableAdapters.TableAdapterManager
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LecturasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IdLectura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbcSerie As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cod_sucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
