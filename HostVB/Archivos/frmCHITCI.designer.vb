<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCHITCI
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.CRECDetDataGridView = New System.Windows.Forms.DataGridView
        Me.cmdImportar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.CHITCIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NroMovUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaMovDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CtaDepositoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MonedaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AgenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ComprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantChequesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HoraMovDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstadoProcesoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.CRECDetDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHITCIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.CRECDetDataGridView, 0, 4)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(582, 473)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'CRECDetDataGridView
        '
        Me.CRECDetDataGridView.AutoGenerateColumns = False
        Me.CRECDetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CRECDetDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsuarioDataGridViewTextBoxColumn, Me.NroMovUsuarioDataGridViewTextBoxColumn, Me.FechaMovDataGridViewTextBoxColumn, Me.CtaDepositoDataGridViewTextBoxColumn, Me.MonedaDataGridViewTextBoxColumn, Me.AgenciaDataGridViewTextBoxColumn, Me.TipoUsuarioDataGridViewTextBoxColumn, Me.ComprobanteDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.CantChequesDataGridViewTextBoxColumn, Me.HoraMovDataGridViewTextBoxColumn, Me.EstadoProcesoDataGridViewTextBoxColumn})
        Me.TableLayoutPanel1.SetColumnSpan(Me.CRECDetDataGridView, 4)
        Me.CRECDetDataGridView.DataSource = Me.CHITCIBindingSource
        Me.CRECDetDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRECDetDataGridView.Location = New System.Drawing.Point(3, 123)
        Me.CRECDetDataGridView.Name = "CRECDetDataGridView"
        Me.CRECDetDataGridView.ReadOnly = True
        Me.CRECDetDataGridView.Size = New System.Drawing.Size(576, 347)
        Me.CRECDetDataGridView.TabIndex = 11
        '
        'cmdImportar
        '
        Me.cmdImportar.Location = New System.Drawing.Point(382, 93)
        Me.cmdImportar.Name = "cmdImportar"
        Me.cmdImportar.Size = New System.Drawing.Size(75, 23)
        Me.cmdImportar.TabIndex = 12
        Me.cmdImportar.Text = "Importar ..."
        Me.cmdImportar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(303, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Ver Detalle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Archivo txt|*.txt"
        '
        'CHITCIBindingSource
        '
        Me.CHITCIBindingSource.DataSource = GetType(DataAccess.CHITCI)
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NroMovUsuarioDataGridViewTextBoxColumn
        '
        Me.NroMovUsuarioDataGridViewTextBoxColumn.DataPropertyName = "NroMovUsuario"
        Me.NroMovUsuarioDataGridViewTextBoxColumn.HeaderText = "NroMovUsuario"
        Me.NroMovUsuarioDataGridViewTextBoxColumn.Name = "NroMovUsuarioDataGridViewTextBoxColumn"
        Me.NroMovUsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaMovDataGridViewTextBoxColumn
        '
        Me.FechaMovDataGridViewTextBoxColumn.DataPropertyName = "FechaMov"
        Me.FechaMovDataGridViewTextBoxColumn.HeaderText = "FechaMov"
        Me.FechaMovDataGridViewTextBoxColumn.Name = "FechaMovDataGridViewTextBoxColumn"
        Me.FechaMovDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CtaDepositoDataGridViewTextBoxColumn
        '
        Me.CtaDepositoDataGridViewTextBoxColumn.DataPropertyName = "CtaDeposito"
        Me.CtaDepositoDataGridViewTextBoxColumn.HeaderText = "CtaDeposito"
        Me.CtaDepositoDataGridViewTextBoxColumn.Name = "CtaDepositoDataGridViewTextBoxColumn"
        Me.CtaDepositoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MonedaDataGridViewTextBoxColumn
        '
        Me.MonedaDataGridViewTextBoxColumn.DataPropertyName = "Moneda"
        Me.MonedaDataGridViewTextBoxColumn.HeaderText = "Moneda"
        Me.MonedaDataGridViewTextBoxColumn.Name = "MonedaDataGridViewTextBoxColumn"
        Me.MonedaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AgenciaDataGridViewTextBoxColumn
        '
        Me.AgenciaDataGridViewTextBoxColumn.DataPropertyName = "Agencia"
        Me.AgenciaDataGridViewTextBoxColumn.HeaderText = "Agencia"
        Me.AgenciaDataGridViewTextBoxColumn.Name = "AgenciaDataGridViewTextBoxColumn"
        Me.AgenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoUsuarioDataGridViewTextBoxColumn
        '
        Me.TipoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "TipoUsuario"
        Me.TipoUsuarioDataGridViewTextBoxColumn.HeaderText = "TipoUsuario"
        Me.TipoUsuarioDataGridViewTextBoxColumn.Name = "TipoUsuarioDataGridViewTextBoxColumn"
        Me.TipoUsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ComprobanteDataGridViewTextBoxColumn
        '
        Me.ComprobanteDataGridViewTextBoxColumn.DataPropertyName = "Comprobante"
        Me.ComprobanteDataGridViewTextBoxColumn.HeaderText = "Comprobante"
        Me.ComprobanteDataGridViewTextBoxColumn.Name = "ComprobanteDataGridViewTextBoxColumn"
        Me.ComprobanteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantChequesDataGridViewTextBoxColumn
        '
        Me.CantChequesDataGridViewTextBoxColumn.DataPropertyName = "CantCheques"
        Me.CantChequesDataGridViewTextBoxColumn.HeaderText = "CantCheques"
        Me.CantChequesDataGridViewTextBoxColumn.Name = "CantChequesDataGridViewTextBoxColumn"
        Me.CantChequesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HoraMovDataGridViewTextBoxColumn
        '
        Me.HoraMovDataGridViewTextBoxColumn.DataPropertyName = "HoraMov"
        Me.HoraMovDataGridViewTextBoxColumn.HeaderText = "HoraMov"
        Me.HoraMovDataGridViewTextBoxColumn.Name = "HoraMovDataGridViewTextBoxColumn"
        Me.HoraMovDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoProcesoDataGridViewTextBoxColumn
        '
        Me.EstadoProcesoDataGridViewTextBoxColumn.DataPropertyName = "EstadoProceso"
        Me.EstadoProcesoDataGridViewTextBoxColumn.HeaderText = "EstadoProceso"
        Me.EstadoProcesoDataGridViewTextBoxColumn.Name = "EstadoProcesoDataGridViewTextBoxColumn"
        Me.EstadoProcesoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmCHITCI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 473)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmCHITCI"
        Me.Text = "frmCHITCI"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.CRECDetDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHITCIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdImportar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CRECDetDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CHITCIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroMovUsuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaMovDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtaDepositoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonedaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoUsuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComprobanteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantChequesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoraMovDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoProcesoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
