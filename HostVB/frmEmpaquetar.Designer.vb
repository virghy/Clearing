<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpaquetar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.cmdGenerar = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Worker = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboOpcion = New System.Windows.Forms.ComboBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.cmdGetDir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha:"
        '
        'txtFecha
        '
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha.Location = New System.Drawing.Point(74, 36)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(79, 20)
        Me.txtFecha.TabIndex = 1
        '
        'cmdGenerar
        '
        Me.cmdGenerar.Location = New System.Drawing.Point(78, 167)
        Me.cmdGenerar.Name = "cmdGenerar"
        Me.cmdGenerar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGenerar.TabIndex = 2
        Me.cmdGenerar.Text = "Generar"
        Me.cmdGenerar.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Enabled = False
        Me.cmdCancel.Location = New System.Drawing.Point(190, 167)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "Cancelar"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(15, 126)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(316, 23)
        Me.ProgressBar1.TabIndex = 4
        '
        'Worker
        '
        Me.Worker.WorkerReportsProgress = True
        Me.Worker.WorkerSupportsCancellation = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Destino de los archivos generados:"
        '
        'txtDestino
        '
        Me.txtDestino.Location = New System.Drawing.Point(15, 77)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.ReadOnly = True
        Me.txtDestino.Size = New System.Drawing.Size(294, 20)
        Me.txtDestino.TabIndex = 6
        Me.txtDestino.Text = "c:\sistemas\clearing\"
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.Location = New System.Drawing.Point(2, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(327, 43)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Este proceso empaqueta todos los registros estando o no marcados como enviados. T" & _
    "ampoco marca el registro como enviado."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(174, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Opción:"
        '
        'cboOpcion
        '
        Me.cboOpcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOpcion.FormattingEnabled = True
        Me.cboOpcion.Items.AddRange(New Object() {"Empaquetar", "Copiar Estructura"})
        Me.cboOpcion.Location = New System.Drawing.Point(224, 36)
        Me.cboOpcion.Name = "cboOpcion"
        Me.cboOpcion.Size = New System.Drawing.Size(121, 21)
        Me.cboOpcion.TabIndex = 9
        '
        'cmdGetDir
        '
        Me.cmdGetDir.Location = New System.Drawing.Point(315, 75)
        Me.cmdGetDir.Name = "cmdGetDir"
        Me.cmdGetDir.Size = New System.Drawing.Size(30, 23)
        Me.cmdGetDir.TabIndex = 10
        Me.cmdGetDir.Text = "..."
        Me.cmdGetDir.UseVisualStyleBackColor = True
        '
        'frmEmpaquetar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 264)
        Me.Controls.Add(Me.cmdGetDir)
        Me.Controls.Add(Me.cboOpcion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDestino)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdGenerar)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEmpaquetar"
        Me.Text = "Empaquetar Imagenes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdGenerar As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDestino As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboOpcion As System.Windows.Forms.ComboBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents cmdGetDir As System.Windows.Forms.Button
End Class
