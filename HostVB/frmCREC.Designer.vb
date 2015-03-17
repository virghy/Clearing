<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCREC
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
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim CodBancoLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim ImporteLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.CRECBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CantidadTextBox = New System.Windows.Forms.TextBox
        Me.CodBancoTextBox = New System.Windows.Forms.TextBox
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.ImporteTextBox = New System.Windows.Forms.TextBox
        Me.CRECDetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRECDetDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New Sorteable.DataGridViewAutoFilterTextBoxColumn
        Me.cmdImportar = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Button1 = New System.Windows.Forms.Button
        CantidadLabel = New System.Windows.Forms.Label
        CodBancoLabel = New System.Windows.Forms.Label
        FechaLabel = New System.Windows.Forms.Label
        ImporteLabel = New System.Windows.Forms.Label
        CType(Me.CRECBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRECDetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRECDetDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(3, 90)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 1
        CantidadLabel.Text = "Cantidad:"
        '
        'CodBancoLabel
        '
        CodBancoLabel.AutoSize = True
        CodBancoLabel.Location = New System.Drawing.Point(3, 0)
        CodBancoLabel.Name = "CodBancoLabel"
        CodBancoLabel.Size = New System.Drawing.Size(63, 13)
        CodBancoLabel.TabIndex = 3
        CodBancoLabel.Text = "Cod Banco:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(3, 30)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 5
        FechaLabel.Text = "Fecha:"
        '
        'ImporteLabel
        '
        ImporteLabel.AutoSize = True
        ImporteLabel.Location = New System.Drawing.Point(3, 60)
        ImporteLabel.Name = "ImporteLabel"
        ImporteLabel.Size = New System.Drawing.Size(45, 13)
        ImporteLabel.TabIndex = 9
        ImporteLabel.Text = "Importe:"
        '
        'CRECBindingSource
        '
        Me.CRECBindingSource.DataSource = GetType(DataAccess.CREC)
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CRECBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(153, 93)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.ReadOnly = True
        Me.CantidadTextBox.Size = New System.Drawing.Size(144, 20)
        Me.CantidadTextBox.TabIndex = 2
        '
        'CodBancoTextBox
        '
        Me.CodBancoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CRECBindingSource, "CodBanco", True))
        Me.CodBancoTextBox.Location = New System.Drawing.Point(153, 3)
        Me.CodBancoTextBox.Name = "CodBancoTextBox"
        Me.CodBancoTextBox.ReadOnly = True
        Me.CodBancoTextBox.Size = New System.Drawing.Size(144, 20)
        Me.CodBancoTextBox.TabIndex = 4
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CRECBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Enabled = False
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(153, 33)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(144, 20)
        Me.FechaDateTimePicker.TabIndex = 6
        '
        'ImporteTextBox
        '
        Me.ImporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CRECBindingSource, "Importe", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.ImporteTextBox.Location = New System.Drawing.Point(153, 63)
        Me.ImporteTextBox.Name = "ImporteTextBox"
        Me.ImporteTextBox.ReadOnly = True
        Me.ImporteTextBox.Size = New System.Drawing.Size(144, 20)
        Me.ImporteTextBox.TabIndex = 10
        '
        'CRECDetBindingSource
        '
        Me.CRECDetBindingSource.DataMember = "CRECDet"
        Me.CRECDetBindingSource.DataSource = Me.CRECBindingSource
        '
        'CRECDetDataGridView
        '
        Me.CRECDetDataGridView.AutoGenerateColumns = False
        Me.CRECDetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CRECDetDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TableLayoutPanel1.SetColumnSpan(Me.CRECDetDataGridView, 4)
        Me.CRECDetDataGridView.DataSource = Me.CRECDetBindingSource
        Me.CRECDetDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRECDetDataGridView.Location = New System.Drawing.Point(3, 123)
        Me.CRECDetDataGridView.Name = "CRECDetDataGridView"
        Me.CRECDetDataGridView.ReadOnly = True
        Me.CRECDetDataGridView.Size = New System.Drawing.Size(627, 286)
        Me.CRECDetDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdBanco"
        Me.DataGridViewTextBoxColumn2.FilteringEnabled = False
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdBanco"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Cuenta"
        Me.DataGridViewTextBoxColumn3.FilteringEnabled = False
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cuenta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Numero"
        Me.DataGridViewTextBoxColumn4.FilteringEnabled = False
        Me.DataGridViewTextBoxColumn4.HeaderText = "Numero"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Importe"
        DataGridViewCellStyle2.Format = "N0"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.FilteringEnabled = False
        Me.DataGridViewTextBoxColumn5.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Secuencia"
        Me.DataGridViewTextBoxColumn6.FilteringEnabled = False
        Me.DataGridViewTextBoxColumn6.HeaderText = "Secuencia"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'cmdImportar
        '
        Me.cmdImportar.Location = New System.Drawing.Point(433, 93)
        Me.cmdImportar.Name = "cmdImportar"
        Me.cmdImportar.Size = New System.Drawing.Size(75, 23)
        Me.cmdImportar.TabIndex = 12
        Me.cmdImportar.Text = "Importar ..."
        Me.cmdImportar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Archivo txt|*.txt"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203.0!))
        Me.TableLayoutPanel1.Controls.Add(CodBancoLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CRECDetDataGridView, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.CodBancoTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(FechaLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CantidadTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(CantidadLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.FechaDateTimePicker, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(ImporteLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ImporteTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdImportar, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 2, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(633, 412)
        Me.TableLayoutPanel1.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(303, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Ver Detalle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmCREC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 412)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmCREC"
        Me.Text = "frmCREC"
        CType(Me.CRECBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRECDetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRECDetDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRECBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodBancoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ImporteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CRECDetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CRECDetDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cmdImportar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DataGridViewTextBoxColumn2 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As Sorteable.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
