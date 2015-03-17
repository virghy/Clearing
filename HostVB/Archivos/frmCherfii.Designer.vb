<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCherfii
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
        Me.CHERFIIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdImportar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.CRECBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CtaLibradoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NroChequeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ComprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AgenciaCRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaProcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HoraProcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CtaDepositoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.CRECDetDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHERFIIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRECBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(549, 462)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'CRECDetDataGridView
        '
        Me.CRECDetDataGridView.AutoGenerateColumns = False
        Me.CRECDetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CRECDetDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CtaLibradoraDataGridViewTextBoxColumn, Me.NroChequeDataGridViewTextBoxColumn, Me.ComprobanteDataGridViewTextBoxColumn, Me.AgenciaCRDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.FechaProcDataGridViewTextBoxColumn, Me.HoraProcDataGridViewTextBoxColumn, Me.CtaDepositoDataGridViewTextBoxColumn})
        Me.TableLayoutPanel1.SetColumnSpan(Me.CRECDetDataGridView, 4)
        Me.CRECDetDataGridView.DataSource = Me.CHERFIIBindingSource
        Me.CRECDetDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRECDetDataGridView.Location = New System.Drawing.Point(3, 123)
        Me.CRECDetDataGridView.Name = "CRECDetDataGridView"
        Me.CRECDetDataGridView.ReadOnly = True
        Me.CRECDetDataGridView.Size = New System.Drawing.Size(543, 336)
        Me.CRECDetDataGridView.TabIndex = 11
        '
        'CHERFIIBindingSource
        '
        Me.CHERFIIBindingSource.DataSource = GetType(DataAccess.CHERFII)
        '
        'cmdImportar
        '
        Me.cmdImportar.Location = New System.Drawing.Point(349, 93)
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
        'CRECBindingSource
        '
        Me.CRECBindingSource.DataSource = GetType(DataAccess.CREC)
        '
        'CtaLibradoraDataGridViewTextBoxColumn
        '
        Me.CtaLibradoraDataGridViewTextBoxColumn.DataPropertyName = "CtaLibradora"
        Me.CtaLibradoraDataGridViewTextBoxColumn.HeaderText = "CtaLibradora"
        Me.CtaLibradoraDataGridViewTextBoxColumn.Name = "CtaLibradoraDataGridViewTextBoxColumn"
        Me.CtaLibradoraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NroChequeDataGridViewTextBoxColumn
        '
        Me.NroChequeDataGridViewTextBoxColumn.DataPropertyName = "NroCheque"
        Me.NroChequeDataGridViewTextBoxColumn.HeaderText = "NroCheque"
        Me.NroChequeDataGridViewTextBoxColumn.Name = "NroChequeDataGridViewTextBoxColumn"
        Me.NroChequeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ComprobanteDataGridViewTextBoxColumn
        '
        Me.ComprobanteDataGridViewTextBoxColumn.DataPropertyName = "Comprobante"
        Me.ComprobanteDataGridViewTextBoxColumn.HeaderText = "Comprobante"
        Me.ComprobanteDataGridViewTextBoxColumn.Name = "ComprobanteDataGridViewTextBoxColumn"
        Me.ComprobanteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AgenciaCRDataGridViewTextBoxColumn
        '
        Me.AgenciaCRDataGridViewTextBoxColumn.DataPropertyName = "AgenciaCR"
        Me.AgenciaCRDataGridViewTextBoxColumn.HeaderText = "AgenciaCR"
        Me.AgenciaCRDataGridViewTextBoxColumn.Name = "AgenciaCRDataGridViewTextBoxColumn"
        Me.AgenciaCRDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImporteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'FechaProcDataGridViewTextBoxColumn
        '
        Me.FechaProcDataGridViewTextBoxColumn.DataPropertyName = "FechaProc"
        Me.FechaProcDataGridViewTextBoxColumn.HeaderText = "FechaProc"
        Me.FechaProcDataGridViewTextBoxColumn.Name = "FechaProcDataGridViewTextBoxColumn"
        Me.FechaProcDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaProcDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'HoraProcDataGridViewTextBoxColumn
        '
        Me.HoraProcDataGridViewTextBoxColumn.DataPropertyName = "HoraProc"
        Me.HoraProcDataGridViewTextBoxColumn.HeaderText = "HoraProc"
        Me.HoraProcDataGridViewTextBoxColumn.Name = "HoraProcDataGridViewTextBoxColumn"
        Me.HoraProcDataGridViewTextBoxColumn.ReadOnly = True
        Me.HoraProcDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'CtaDepositoDataGridViewTextBoxColumn
        '
        Me.CtaDepositoDataGridViewTextBoxColumn.DataPropertyName = "CtaDeposito"
        Me.CtaDepositoDataGridViewTextBoxColumn.HeaderText = "CtaDeposito"
        Me.CtaDepositoDataGridViewTextBoxColumn.Name = "CtaDepositoDataGridViewTextBoxColumn"
        Me.CtaDepositoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CtaDepositoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'frmCherfii
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 462)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmCherfii"
        Me.Text = "frmCherfii"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.CRECDetDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHERFIIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRECBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CRECBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cmdImportar As System.Windows.Forms.Button
    Friend WithEvents CRECDetDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CHERFIIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CtaLibradoraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroChequeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComprobanteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgenciaCRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaProcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoraProcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtaDepositoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
