<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.Lecturas1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsReportes = New dsReportes
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BancosTableAdapter = New dsReportesTableAdapters.BancosTableAdapter
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Lecturas1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lecturas1TableAdapter = New dsReportesTableAdapters.Lecturas1TableAdapter
        Me.BancosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Lecturas1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lecturas1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lecturas1BindingSource1
        '
        Me.Lecturas1BindingSource1.DataMember = "Lecturas1"
        Me.Lecturas1BindingSource1.DataSource = Me.dsReportes
        '
        'dsReportes
        '
        Me.dsReportes.DataSetName = "dsReportes"
        Me.dsReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(946, 62)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametros de búsqueda"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(211, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(62, 20)
        Me.TextBox1.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(816, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 39)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Cerrar Reporte"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(58, 25)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(90, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(419, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Banco"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha"
        '
        'BancosBindingSource
        '
        Me.BancosBindingSource.DataMember = "Bancos"
        Me.BancosBindingSource.DataSource = Me.dsReportes
        '
        'BancosTableAdapter
        '
        Me.BancosTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "dsReportes_Lecturas1"
        ReportDataSource1.Value = Me.Lecturas1BindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "rpt_Det_documentos_por_Bancos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 83)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(946, 413)
        Me.ReportViewer1.TabIndex = 12
        '
        'Lecturas1BindingSource
        '
        Me.Lecturas1BindingSource.DataMember = "Lecturas1"
        Me.Lecturas1BindingSource.DataSource = Me.dsReportes
        '
        'Lecturas1TableAdapter
        '
        Me.Lecturas1TableAdapter.ClearBeforeFill = True
        '
        'BancosBindingSource1
        '
        Me.BancosBindingSource1.DataMember = "Bancos"
        Me.BancosBindingSource1.DataSource = Me.dsReportes
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 508)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmReports"
        Me.Text = "frmReports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Lecturas1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsReportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lecturas1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BancosTableAdapter As dsReportesTableAdapters.BancosTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Lecturas1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsReportes As dsReportes
    Friend WithEvents Lecturas1TableAdapter As dsReportesTableAdapters.Lecturas1TableAdapter
    Friend WithEvents Lecturas1BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BancosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BancosBindingSource1 As System.Windows.Forms.BindingSource
End Class
