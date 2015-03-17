<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Ascii
    Inherits WindowsControlLibrary.frmBase

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
        Dim ArchivoDestinoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim EstructuraDestinoLabel As System.Windows.Forms.Label
        Dim IdFormatoLabel As System.Windows.Forms.Label
        Dim Registro_finLabel As System.Windows.Forms.Label
        Dim Registro_inicioLabel As System.Windows.Forms.Label
        Dim TituloLabel As System.Windows.Forms.Label
        Dim IdcabeceraLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.ArchivoDestinoTextBox = New System.Windows.Forms.TextBox
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox
        Me.EstructuraDestinoTextBox = New System.Windows.Forms.TextBox
        Me.Registro_finTextBox = New System.Windows.Forms.TextBox
        Me.Registro_inicioTextBox = New System.Windows.Forms.TextBox
        Me.SqlTextBox = New System.Windows.Forms.TextBox
        Me.TituloTextBox = New System.Windows.Forms.TextBox
        Me.rdCamara = New System.Windows.Forms.RadioButton
        Me.rdAscii = New System.Windows.Forms.RadioButton
        Me.rdDBF = New System.Windows.Forms.RadioButton
        Me.IdcabeceraTextBox = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Ascii_detDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ascii_detBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdDuplicar = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        ArchivoDestinoLabel = New System.Windows.Forms.Label
        DescripcionLabel = New System.Windows.Forms.Label
        EstructuraDestinoLabel = New System.Windows.Forms.Label
        IdFormatoLabel = New System.Windows.Forms.Label
        Registro_finLabel = New System.Windows.Forms.Label
        Registro_inicioLabel = New System.Windows.Forms.Label
        TituloLabel = New System.Windows.Forms.Label
        IdcabeceraLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.Ascii_detDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ascii_detBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = GetType(DataAccess.Ascii)
        '
        'ArchivoDestinoLabel
        '
        ArchivoDestinoLabel.AutoSize = True
        ArchivoDestinoLabel.Location = New System.Drawing.Point(12, 15)
        ArchivoDestinoLabel.Name = "ArchivoDestinoLabel"
        ArchivoDestinoLabel.Size = New System.Drawing.Size(85, 13)
        ArchivoDestinoLabel.TabIndex = 1
        ArchivoDestinoLabel.Text = "Archivo Destino:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(10, 71)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 5
        DescripcionLabel.Text = "Descripcion:"
        '
        'EstructuraDestinoLabel
        '
        EstructuraDestinoLabel.AutoSize = True
        EstructuraDestinoLabel.Location = New System.Drawing.Point(12, 44)
        EstructuraDestinoLabel.Name = "EstructuraDestinoLabel"
        EstructuraDestinoLabel.Size = New System.Drawing.Size(97, 13)
        EstructuraDestinoLabel.TabIndex = 7
        EstructuraDestinoLabel.Text = "Estructura Destino:"
        '
        'IdFormatoLabel
        '
        IdFormatoLabel.AutoSize = True
        IdFormatoLabel.Location = New System.Drawing.Point(10, 97)
        IdFormatoLabel.Name = "IdFormatoLabel"
        IdFormatoLabel.Size = New System.Drawing.Size(48, 13)
        IdFormatoLabel.TabIndex = 11
        IdFormatoLabel.Text = "Formato:"
        '
        'Registro_finLabel
        '
        Registro_finLabel.AutoSize = True
        Registro_finLabel.Location = New System.Drawing.Point(12, 70)
        Registro_finLabel.Name = "Registro_finLabel"
        Registro_finLabel.Size = New System.Drawing.Size(58, 13)
        Registro_finLabel.TabIndex = 13
        Registro_finLabel.Text = "registro fin:"
        '
        'Registro_inicioLabel
        '
        Registro_inicioLabel.AutoSize = True
        Registro_inicioLabel.Location = New System.Drawing.Point(12, 96)
        Registro_inicioLabel.Name = "Registro_inicioLabel"
        Registro_inicioLabel.Size = New System.Drawing.Size(71, 13)
        Registro_inicioLabel.TabIndex = 15
        Registro_inicioLabel.Text = "registro inicio:"
        '
        'TituloLabel
        '
        TituloLabel.AutoSize = True
        TituloLabel.Location = New System.Drawing.Point(10, 45)
        TituloLabel.Name = "TituloLabel"
        TituloLabel.Size = New System.Drawing.Size(36, 13)
        TituloLabel.TabIndex = 19
        TituloLabel.Text = "Titulo:"
        '
        'IdcabeceraLabel
        '
        IdcabeceraLabel.AutoSize = True
        IdcabeceraLabel.Location = New System.Drawing.Point(10, 19)
        IdcabeceraLabel.Name = "IdcabeceraLabel"
        IdcabeceraLabel.Size = New System.Drawing.Size(16, 13)
        IdcabeceraLabel.TabIndex = 9
        IdcabeceraLabel.Text = "Id"
        '
        'ArchivoDestinoTextBox
        '
        Me.ArchivoDestinoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "ArchivoDestino", True))
        Me.ArchivoDestinoTextBox.Location = New System.Drawing.Point(115, 15)
        Me.ArchivoDestinoTextBox.Name = "ArchivoDestinoTextBox"
        Me.ArchivoDestinoTextBox.Size = New System.Drawing.Size(636, 20)
        Me.ArchivoDestinoTextBox.TabIndex = 2
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(113, 68)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(403, 20)
        Me.DescripcionTextBox.TabIndex = 6
        '
        'EstructuraDestinoTextBox
        '
        Me.EstructuraDestinoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "EstructuraDestino", True))
        Me.EstructuraDestinoTextBox.Location = New System.Drawing.Point(115, 41)
        Me.EstructuraDestinoTextBox.Name = "EstructuraDestinoTextBox"
        Me.EstructuraDestinoTextBox.Size = New System.Drawing.Size(636, 20)
        Me.EstructuraDestinoTextBox.TabIndex = 8
        '
        'Registro_finTextBox
        '
        Me.Registro_finTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "registro_fin", True))
        Me.Registro_finTextBox.Location = New System.Drawing.Point(115, 67)
        Me.Registro_finTextBox.Name = "Registro_finTextBox"
        Me.Registro_finTextBox.Size = New System.Drawing.Size(636, 20)
        Me.Registro_finTextBox.TabIndex = 14
        '
        'Registro_inicioTextBox
        '
        Me.Registro_inicioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "registro_inicio", True))
        Me.Registro_inicioTextBox.Location = New System.Drawing.Point(115, 93)
        Me.Registro_inicioTextBox.Name = "Registro_inicioTextBox"
        Me.Registro_inicioTextBox.Size = New System.Drawing.Size(636, 20)
        Me.Registro_inicioTextBox.TabIndex = 16
        '
        'SqlTextBox
        '
        Me.SqlTextBox.AcceptsReturn = True
        Me.SqlTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "sql", True))
        Me.SqlTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SqlTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SqlTextBox.Location = New System.Drawing.Point(3, 3)
        Me.SqlTextBox.Multiline = True
        Me.SqlTextBox.Name = "SqlTextBox"
        Me.SqlTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.SqlTextBox.Size = New System.Drawing.Size(764, 259)
        Me.SqlTextBox.TabIndex = 18
        '
        'TituloTextBox
        '
        Me.TituloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Titulo", True))
        Me.TituloTextBox.Location = New System.Drawing.Point(113, 42)
        Me.TituloTextBox.Name = "TituloTextBox"
        Me.TituloTextBox.Size = New System.Drawing.Size(403, 20)
        Me.TituloTextBox.TabIndex = 20
        '
        'rdCamara
        '
        Me.rdCamara.AutoSize = True
        Me.rdCamara.Location = New System.Drawing.Point(113, 92)
        Me.rdCamara.Name = "rdCamara"
        Me.rdCamara.Size = New System.Drawing.Size(61, 17)
        Me.rdCamara.TabIndex = 23
        Me.rdCamara.Text = "Camara"
        Me.rdCamara.UseVisualStyleBackColor = True
        '
        'rdAscii
        '
        Me.rdAscii.AutoSize = True
        Me.rdAscii.Location = New System.Drawing.Point(210, 92)
        Me.rdAscii.Name = "rdAscii"
        Me.rdAscii.Size = New System.Drawing.Size(52, 17)
        Me.rdAscii.TabIndex = 24
        Me.rdAscii.Text = "ASCII"
        Me.rdAscii.UseVisualStyleBackColor = True
        '
        'rdDBF
        '
        Me.rdDBF.AutoSize = True
        Me.rdDBF.Location = New System.Drawing.Point(307, 92)
        Me.rdDBF.Name = "rdDBF"
        Me.rdDBF.Size = New System.Drawing.Size(46, 17)
        Me.rdDBF.TabIndex = 25
        Me.rdDBF.Text = "DBF"
        Me.rdDBF.UseVisualStyleBackColor = True
        '
        'IdcabeceraTextBox
        '
        Me.IdcabeceraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "idcabecera", True))
        Me.IdcabeceraTextBox.Location = New System.Drawing.Point(113, 16)
        Me.IdcabeceraTextBox.Name = "IdcabeceraTextBox"
        Me.IdcabeceraTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdcabeceraTextBox.TabIndex = 10
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 145)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(778, 291)
        Me.TabControl1.TabIndex = 26
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Label1)
        Me.TabPage1.Controls.Add(Me.ArchivoDestinoTextBox)
        Me.TabPage1.Controls.Add(ArchivoDestinoLabel)
        Me.TabPage1.Controls.Add(Me.EstructuraDestinoTextBox)
        Me.TabPage1.Controls.Add(EstructuraDestinoLabel)
        Me.TabPage1.Controls.Add(Me.Registro_finTextBox)
        Me.TabPage1.Controls.Add(Registro_finLabel)
        Me.TabPage1.Controls.Add(Me.Registro_inicioTextBox)
        Me.TabPage1.Controls.Add(Registro_inicioLabel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(770, 265)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Destino"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SqlTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(770, 265)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Instruccion SQL"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.Ascii_detDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(770, 265)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Campos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Ascii_detDataGridView
        '
        Me.Ascii_detDataGridView.AutoGenerateColumns = False
        Me.Ascii_detDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Ascii_detDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.Ascii_detDataGridView.DataSource = Me.Ascii_detBindingSource
        Me.Ascii_detDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ascii_detDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Ascii_detDataGridView.Name = "Ascii_detDataGridView"
        Me.Ascii_detDataGridView.Size = New System.Drawing.Size(770, 265)
        Me.Ascii_detDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "valor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "valor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "orden"
        Me.DataGridViewTextBoxColumn5.HeaderText = "orden"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "longitud"
        Me.DataGridViewTextBoxColumn6.HeaderText = "longitud"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "tipo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "tipo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "formato"
        Me.DataGridViewTextBoxColumn8.HeaderText = "formato"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Ascii_detBindingSource
        '
        Me.Ascii_detBindingSource.DataSource = GetType(ClearingDA.Ascii_det)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(784, 439)
        Me.TableLayoutPanel1.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdDuplicar)
        Me.Panel1.Controls.Add(Me.IdcabeceraTextBox)
        Me.Panel1.Controls.Add(Me.rdDBF)
        Me.Panel1.Controls.Add(TituloLabel)
        Me.Panel1.Controls.Add(IdcabeceraLabel)
        Me.Panel1.Controls.Add(Me.TituloTextBox)
        Me.Panel1.Controls.Add(Me.rdAscii)
        Me.Panel1.Controls.Add(IdFormatoLabel)
        Me.Panel1.Controls.Add(Me.rdCamara)
        Me.Panel1.Controls.Add(Me.DescripcionTextBox)
        Me.Panel1.Controls.Add(DescripcionLabel)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(633, 136)
        Me.Panel1.TabIndex = 0
        '
        'cmdDuplicar
        '
        Me.cmdDuplicar.Location = New System.Drawing.Point(440, 8)
        Me.cmdDuplicar.Name = "cmdDuplicar"
        Me.cmdDuplicar.Size = New System.Drawing.Size(129, 23)
        Me.cmdDuplicar.TabIndex = 26
        Me.cmdDuplicar.Text = "Duplicar este registro"
        Me.cmdDuplicar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "ArchivoDestino1", True))
        Me.TextBox1.Location = New System.Drawing.Point(119, 122)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(636, 20)
        Me.TextBox1.TabIndex = 18
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 122)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(91, 13)
        Label1.TabIndex = 17
        Label1.Text = "Archivo Destino1:"
        '
        'frm_Ascii
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 464)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frm_Ascii"
        Me.Text = "frm_Ascii"
        Me.Controls.SetChildIndex(Me.TableLayoutPanel1, 0)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.Ascii_detDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ascii_detBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ArchivoDestinoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstructuraDestinoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Registro_finTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Registro_inicioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SqlTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TituloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents rdCamara As System.Windows.Forms.RadioButton
    Friend WithEvents rdAscii As System.Windows.Forms.RadioButton
    Friend WithEvents rdDBF As System.Windows.Forms.RadioButton
    Friend WithEvents IdcabeceraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Ascii_detDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Ascii_detBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdDuplicar As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
