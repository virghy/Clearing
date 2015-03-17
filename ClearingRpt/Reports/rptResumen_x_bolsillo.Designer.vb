<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptResumen_x_bolsillo
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.Lecturas_x_bolsilloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsReportes = New ClearingRpt.dsReportes
        Me.BancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtBcoReceptor = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LecturasxbolsilloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lecturas_x_bolsilloTableAdapter = New ClearingRpt.dsReportesTableAdapters.Lecturas_x_bolsilloTableAdapter
        Me.BancosTableAdapter = New ClearingRpt.dsReportesTableAdapters.BancosTableAdapter
        CType(Me.Lecturas_x_bolsilloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LecturasxbolsilloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lecturas_x_bolsilloBindingSource
        '
        Me.Lecturas_x_bolsilloBindingSource.DataMember = "Lecturas_x_bolsillo"
        Me.Lecturas_x_bolsilloBindingSource.DataSource = Me.DsReportes
        '
        'DsReportes
        '
        Me.DsReportes.DataSetName = "dsReportes"
        Me.DsReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BancosBindingSource
        '
        Me.BancosBindingSource.DataMember = "Bancos"
        Me.BancosBindingSource.DataSource = Me.DsReportes
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "dsReportes_Lecturas_x_bolsillo"
        ReportDataSource1.Value = Me.Lecturas_x_bolsilloBindingSource
        ReportDataSource2.Name = "dsReportes_Bancos"
        ReportDataSource2.Value = Me.BancosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ClearingRpt.rpt_Resumen_x_bolsillo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 102)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(703, 160)
        Me.ReportViewer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.txtBcoReceptor)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(700, 62)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametros de búsqueda"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(588, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Cerrar Reporte"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtBcoReceptor
        '
        Me.txtBcoReceptor.Location = New System.Drawing.Point(264, 25)
        Me.txtBcoReceptor.Name = "txtBcoReceptor"
        Me.txtBcoReceptor.Size = New System.Drawing.Size(138, 20)
        Me.txtBcoReceptor.TabIndex = 11
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
        Me.Button1.Location = New System.Drawing.Point(408, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Banco Receptor"
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
        'LecturasxbolsilloBindingSource
        '
        Me.LecturasxbolsilloBindingSource.DataMember = "Lecturas_x_bolsillo"
        Me.LecturasxbolsilloBindingSource.DataSource = Me.DsReportes
        '
        'Lecturas_x_bolsilloTableAdapter
        '
        Me.Lecturas_x_bolsilloTableAdapter.ClearBeforeFill = True
        '
        'BancosTableAdapter
        '
        Me.BancosTableAdapter.ClearBeforeFill = True
        '
        'rptResumen_x_bolsillo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 264)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "rptResumen_x_bolsillo"
        Me.Text = "rptResumen_x_bolsillo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Lecturas_x_bolsilloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LecturasxbolsilloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBcoReceptor As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LecturasxbolsilloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsReportes As ClearingRpt.dsReportes
    Friend WithEvents Lecturas_x_bolsilloTableAdapter As ClearingRpt.dsReportesTableAdapters.Lecturas_x_bolsilloTableAdapter
    Friend WithEvents Lecturas_x_bolsilloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BancosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BancosTableAdapter As ClearingRpt.dsReportesTableAdapters.BancosTableAdapter
End Class
