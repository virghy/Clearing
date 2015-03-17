<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscaCheque
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LecturasDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdLectura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_lectura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New Sorteable.DataGridViewAutoFilterTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New Sorteable.DataGridViewAutoFilterTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New Sorteable.DataGridViewAutoFilterTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New Sorteable.DataGridViewAutoFilterTextBoxColumn()
        Me.tbcSerie = New Sorteable.DataGridViewAutoFilterTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New Sorteable.DataGridViewAutoFilterTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New Sorteable.DataGridViewAutoFilterTextBoxColumn()
        Me.Importe = New Sorteable.DataGridViewAutoFilterTextBoxColumn()
        Me.cod_sucursal = New Sorteable.DataGridViewAutoFilterTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New Sorteable.DataGridViewAutoFilterTextBoxColumn()
        Me.cod_moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod_proceso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdVerImagen = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.LecturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.LecturasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LecturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.63388!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.36612!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNumero, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCuenta, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtFecha, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox1, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(433, 120)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cuenta"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(91, 33)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(86, 20)
        Me.txtNumero.TabIndex = 4
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(91, 63)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(86, 20)
        Me.txtCuenta.TabIndex = 5
        '
        'txtFecha
        '
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha.Location = New System.Drawing.Point(91, 3)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(86, 20)
        Me.txtFecha.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(91, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(183, 3)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(108, 17)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Sin filtro de fecha"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LecturasDataGridView
        '
        Me.LecturasDataGridView.AllowUserToAddRows = False
        Me.LecturasDataGridView.AllowUserToDeleteRows = False
        Me.LecturasDataGridView.AllowUserToOrderColumns = True
        Me.LecturasDataGridView.AutoGenerateColumns = False
        Me.LecturasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LecturasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdLectura, Me.fecha_lectura, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.tbcSerie, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn8, Me.Importe, Me.cod_sucursal, Me.DataGridViewTextBoxColumn12, Me.cod_moneda, Me.cod_proceso, Me.cmdVerImagen})
        Me.LecturasDataGridView.DataSource = Me.LecturasBindingSource
        Me.LecturasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LecturasDataGridView.Location = New System.Drawing.Point(3, 153)
        Me.LecturasDataGridView.Name = "LecturasDataGridView"
        Me.LecturasDataGridView.ReadOnly = True
        Me.LecturasDataGridView.Size = New System.Drawing.Size(819, 330)
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
        'fecha_lectura
        '
        Me.fecha_lectura.DataPropertyName = "fecha_lectura"
        Me.fecha_lectura.FillWeight = 60.0!
        Me.fecha_lectura.HeaderText = "Fecha"
        Me.fecha_lectura.Name = "fecha_lectura"
        Me.fecha_lectura.ReadOnly = True
        Me.fecha_lectura.Width = 60
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nro_lote"
        Me.DataGridViewTextBoxColumn1.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn1.FilteringEnabled = False
        Me.DataGridViewTextBoxColumn1.HeaderText = "Lote"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cod_banco_receptor"
        Me.DataGridViewTextBoxColumn7.FillWeight = 40.0!
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
        Me.DataGridViewTextBoxColumn4.FillWeight = 40.0!
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
        Me.DataGridViewTextBoxColumn27.FillWeight = 40.0!
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
        Me.DataGridViewTextBoxColumn8.FillWeight = 40.0!
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
        DataGridViewCellStyle3.Format = "N2"
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
        Me.cod_sucursal.FillWeight = 50.0!
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
        Me.DataGridViewTextBoxColumn12.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn12.FilteringEnabled = False
        Me.DataGridViewTextBoxColumn12.HeaderText = "Secuencia"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn12.Width = 60
        '
        'cod_moneda
        '
        Me.cod_moneda.DataPropertyName = "cod_moneda"
        Me.cod_moneda.FillWeight = 50.0!
        Me.cod_moneda.HeaderText = "Moneda"
        Me.cod_moneda.Name = "cod_moneda"
        Me.cod_moneda.ReadOnly = True
        Me.cod_moneda.Width = 50
        '
        'cod_proceso
        '
        Me.cod_proceso.DataPropertyName = "cod_proceso"
        Me.cod_proceso.FillWeight = 50.0!
        Me.cod_proceso.HeaderText = "Proceso"
        Me.cod_proceso.Name = "cod_proceso"
        Me.cod_proceso.ReadOnly = True
        Me.cod_proceso.Width = 50
        '
        'cmdVerImagen
        '
        Me.cmdVerImagen.FillWeight = 50.0!
        Me.cmdVerImagen.HeaderText = "Imagen"
        Me.cmdVerImagen.Name = "cmdVerImagen"
        Me.cmdVerImagen.ReadOnly = True
        Me.cmdVerImagen.Text = "..."
        Me.cmdVerImagen.ToolTipText = "Clic para ver la imagen"
        Me.cmdVerImagen.Width = 50
        '
        'LecturasBindingSource
        '
        Me.LecturasBindingSource.DataSource = GetType(DataAccess.Lecturas)
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LecturasDataGridView, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(825, 486)
        Me.TableLayoutPanel2.TabIndex = 10
        '
        'frmBuscaCheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 486)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Name = "frmBuscaCheque"
        Me.Text = "Busqueda de Documentos"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.LecturasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LecturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LecturasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LecturasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents IdLectura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_lectura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents tbcSerie As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents Importe As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents cod_sucursal As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents cod_moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cod_proceso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdVerImagen As System.Windows.Forms.DataGridViewButtonColumn
End Class
