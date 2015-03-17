<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_generar = New System.Windows.Forms.Button
        Me.lb_fecha = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Rb1 = New System.Windows.Forms.RadioButton
        Me.Gb_archivos = New System.Windows.Forms.GroupBox
        Me.rb6 = New System.Windows.Forms.RadioButton
        Me.Rb5 = New System.Windows.Forms.RadioButton
        Me.Rb4 = New System.Windows.Forms.RadioButton
        Me.Rb3 = New System.Windows.Forms.RadioButton
        Me.Rb2 = New System.Windows.Forms.RadioButton
        Me.txtFecha = New System.Windows.Forms.DateTimePicker
        Me.Gb_archivos.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_generar
        '
        Me.btn_generar.Location = New System.Drawing.Point(207, 278)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(100, 31)
        Me.btn_generar.TabIndex = 5
        Me.btn_generar.Text = "Generar"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'lb_fecha
        '
        Me.lb_fecha.AutoSize = True
        Me.lb_fecha.Location = New System.Drawing.Point(70, 238)
        Me.lb_fecha.Name = "lb_fecha"
        Me.lb_fecha.Size = New System.Drawing.Size(37, 13)
        Me.lb_fecha.TabIndex = 3
        Me.lb_fecha.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(175, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Generación de archivos"
        '
        'Rb1
        '
        Me.Rb1.AutoSize = True
        Me.Rb1.Location = New System.Drawing.Point(6, 23)
        Me.Rb1.Name = "Rb1"
        Me.Rb1.Size = New System.Drawing.Size(230, 17)
        Me.Rb1.TabIndex = 0
        Me.Rb1.TabStop = True
        Me.Rb1.Text = "Archivo CENV para Cámara Compensadora"
        Me.Rb1.UseVisualStyleBackColor = True
        '
        'Gb_archivos
        '
        Me.Gb_archivos.Controls.Add(Me.rb6)
        Me.Gb_archivos.Controls.Add(Me.Rb5)
        Me.Gb_archivos.Controls.Add(Me.Rb4)
        Me.Gb_archivos.Controls.Add(Me.Rb3)
        Me.Gb_archivos.Controls.Add(Me.Rb2)
        Me.Gb_archivos.Controls.Add(Me.Rb1)
        Me.Gb_archivos.Location = New System.Drawing.Point(73, 35)
        Me.Gb_archivos.Name = "Gb_archivos"
        Me.Gb_archivos.Size = New System.Drawing.Size(364, 176)
        Me.Gb_archivos.TabIndex = 2
        Me.Gb_archivos.TabStop = False
        Me.Gb_archivos.Text = "Archivos"
        '
        'rb6
        '
        Me.rb6.AutoSize = True
        Me.rb6.Location = New System.Drawing.Point(6, 148)
        Me.rb6.Name = "rb6"
        Me.rb6.Size = New System.Drawing.Size(64, 17)
        Me.rb6.TabIndex = 5
        Me.rb6.TabStop = True
        Me.rb6.Text = "Exportar"
        Me.rb6.UseVisualStyleBackColor = True
        '
        'Rb5
        '
        Me.Rb5.AutoSize = True
        Me.Rb5.Location = New System.Drawing.Point(6, 124)
        Me.Rb5.Name = "Rb5"
        Me.Rb5.Size = New System.Drawing.Size(133, 17)
        Me.Rb5.TabIndex = 4
        Me.Rb5.TabStop = True
        Me.Rb5.Text = "Archivo MOVIDIA.DBF"
        Me.Rb5.UseVisualStyleBackColor = True
        '
        'Rb4
        '
        Me.Rb4.AutoSize = True
        Me.Rb4.Location = New System.Drawing.Point(6, 98)
        Me.Rb4.Name = "Rb4"
        Me.Rb4.Size = New System.Drawing.Size(175, 17)
        Me.Rb4.TabIndex = 3
        Me.Rb4.TabStop = True
        Me.Rb4.Text = "Archivo de consulta Cddmm002"
        Me.Rb4.UseVisualStyleBackColor = True
        '
        'Rb3
        '
        Me.Rb3.AutoSize = True
        Me.Rb3.Location = New System.Drawing.Point(6, 74)
        Me.Rb3.Name = "Rb3"
        Me.Rb3.Size = New System.Drawing.Size(131, 17)
        Me.Rb3.TabIndex = 2
        Me.Rb3.TabStop = True
        Me.Rb3.Text = "Archivo ENVASS.DBF"
        Me.Rb3.UseVisualStyleBackColor = True
        '
        'Rb2
        '
        Me.Rb2.AutoSize = True
        Me.Rb2.Location = New System.Drawing.Point(6, 49)
        Me.Rb2.Name = "Rb2"
        Me.Rb2.Size = New System.Drawing.Size(91, 17)
        Me.Rb2.TabIndex = 1
        Me.Rb2.TabStop = True
        Me.Rb2.Text = "Archivo ASCII"
        Me.Rb2.UseVisualStyleBackColor = True
        '
        'txtFecha
        '
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha.Location = New System.Drawing.Point(113, 238)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(97, 20)
        Me.txtFecha.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 317)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Gb_archivos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lb_fecha)
        Me.Controls.Add(Me.btn_generar)
        Me.Name = "Form1"
        Me.Text = "Archivos Proceso Enviados"
        Me.Gb_archivos.ResumeLayout(False)
        Me.Gb_archivos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents lb_fecha As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents Gb_archivos As System.Windows.Forms.GroupBox
    Friend WithEvents Rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb3 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb4 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb5 As System.Windows.Forms.RadioButton
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents rb6 As System.Windows.Forms.RadioButton
End Class
