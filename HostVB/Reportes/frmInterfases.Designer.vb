<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInterfases
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
        Me.DataRepeater1 = New Microsoft.VisualBasic.PowerPacks.DataRepeater
        Me.AsciiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFecha = New System.Windows.Forms.DateTimePicker
        Me.lb_fecha = New System.Windows.Forms.Label
        Me.btn_generar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.nudPaquete = New System.Windows.Forms.NumericUpDown
        Me.DataRepeater1.ItemTemplate.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        CType(Me.AsciiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPaquete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataRepeater1
        '
        Me.DataRepeater1.AllowUserToAddItems = False
        Me.DataRepeater1.AllowUserToDeleteItems = False
        Me.DataRepeater1.DataSource = Me.AsciiBindingSource
        '
        'DataRepeater1.ItemTemplate
        '
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Label2)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Label1)
        Me.DataRepeater1.ItemTemplate.Size = New System.Drawing.Size(547, 32)
        Me.DataRepeater1.Location = New System.Drawing.Point(0, 26)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(555, 257)
        Me.DataRepeater1.TabIndex = 0
        Me.DataRepeater1.Text = "DataRepeater1"
        '
        'AsciiBindingSource
        '
        Me.AsciiBindingSource.DataSource = GetType(DataAccess.Ascii)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsciiBindingSource, "descripcion", True))
        Me.Label2.Location = New System.Drawing.Point(3, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsciiBindingSource, "Titulo", True))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(307, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Seleccione la opcion deseada, luego presione el boton Generar"
        '
        'txtFecha
        '
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha.Location = New System.Drawing.Point(53, 294)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(97, 20)
        Me.txtFecha.TabIndex = 9
        '
        'lb_fecha
        '
        Me.lb_fecha.AutoSize = True
        Me.lb_fecha.Location = New System.Drawing.Point(10, 294)
        Me.lb_fecha.Name = "lb_fecha"
        Me.lb_fecha.Size = New System.Drawing.Size(37, 13)
        Me.lb_fecha.TabIndex = 7
        Me.lb_fecha.Text = "Fecha"
        '
        'btn_generar
        '
        Me.btn_generar.Location = New System.Drawing.Point(367, 291)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(100, 31)
        Me.btn_generar.TabIndex = 8
        Me.btn_generar.Text = "Generar"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(156, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Paquete:"
        '
        'nudPaquete
        '
        Me.nudPaquete.Location = New System.Drawing.Point(204, 294)
        Me.nudPaquete.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPaquete.Name = "nudPaquete"
        Me.nudPaquete.Size = New System.Drawing.Size(46, 20)
        Me.nudPaquete.TabIndex = 11
        Me.nudPaquete.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'frmInterfases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 334)
        Me.Controls.Add(Me.nudPaquete)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.lb_fecha)
        Me.Controls.Add(Me.btn_generar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataRepeater1)
        Me.Name = "frmInterfases"
        Me.Text = "frmInterfases"
        Me.DataRepeater1.ItemTemplate.ResumeLayout(False)
        Me.DataRepeater1.ItemTemplate.PerformLayout()
        Me.DataRepeater1.ResumeLayout(False)
        CType(Me.AsciiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPaquete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataRepeater1 As Microsoft.VisualBasic.PowerPacks.DataRepeater
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AsciiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lb_fecha As System.Windows.Forms.Label
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nudPaquete As System.Windows.Forms.NumericUpDown
End Class
