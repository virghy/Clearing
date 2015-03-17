<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbCompensacionUSD = New System.Windows.Forms.RadioButton()
        Me.rb2200 = New System.Windows.Forms.RadioButton()
        Me.rb1900 = New System.Windows.Forms.RadioButton()
        Me.rb1700 = New System.Windows.Forms.RadioButton()
        Me.rb1600 = New System.Windows.Forms.RadioButton()
        Me.rbEn1200 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rbCompensacionUSD)
        Me.GroupBox1.Controls.Add(Me.rb2200)
        Me.GroupBox1.Controls.Add(Me.rb1900)
        Me.GroupBox1.Controls.Add(Me.rb1700)
        Me.GroupBox1.Controls.Add(Me.rb1600)
        Me.GroupBox1.Controls.Add(Me.rbEn1200)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton9)
        Me.GroupBox1.Controls.Add(Me.RadioButton8)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.RadioButton7)
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 289)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reportes Clearing"
        '
        'rbCompensacionUSD
        '
        Me.rbCompensacionUSD.AutoSize = True
        Me.rbCompensacionUSD.Location = New System.Drawing.Point(30, 125)
        Me.rbCompensacionUSD.Name = "rbCompensacionUSD"
        Me.rbCompensacionUSD.Size = New System.Drawing.Size(121, 17)
        Me.rbCompensacionUSD.TabIndex = 17
        Me.rbCompensacionUSD.TabStop = True
        Me.rbCompensacionUSD.Text = "Compensacion USD"
        Me.rbCompensacionUSD.UseVisualStyleBackColor = True
        '
        'rb2200
        '
        Me.rb2200.AutoSize = True
        Me.rb2200.Location = New System.Drawing.Point(320, 125)
        Me.rb2200.Name = "rb2200"
        Me.rb2200.Size = New System.Drawing.Size(175, 17)
        Me.rb2200.TabIndex = 16
        Me.rb2200.TabStop = True
        Me.rb2200.Text = "Resumen de Proceso - EN2200"
        Me.rb2200.UseVisualStyleBackColor = True
        '
        'rb1900
        '
        Me.rb1900.AutoSize = True
        Me.rb1900.Location = New System.Drawing.Point(320, 102)
        Me.rb1900.Name = "rb1900"
        Me.rb1900.Size = New System.Drawing.Size(194, 17)
        Me.rb1900.TabIndex = 15
        Me.rb1900.Text = "Resumen Cuadre de Vale - EN1900"
        Me.rb1900.UseVisualStyleBackColor = True
        '
        'rb1700
        '
        Me.rb1700.AutoSize = True
        Me.rb1700.Location = New System.Drawing.Point(320, 79)
        Me.rb1700.Name = "rb1700"
        Me.rb1700.Size = New System.Drawing.Size(146, 17)
        Me.rb1700.TabIndex = 14
        Me.rb1700.Text = "Cuadre de Vale - EN1700"
        Me.rb1700.UseVisualStyleBackColor = True
        '
        'rb1600
        '
        Me.rb1600.AutoSize = True
        Me.rb1600.Location = New System.Drawing.Point(320, 56)
        Me.rb1600.Name = "rb1600"
        Me.rb1600.Size = New System.Drawing.Size(184, 17)
        Me.rb1600.TabIndex = 13
        Me.rb1600.Text = "Detalle de Rechazados - EN1600"
        Me.rb1600.UseVisualStyleBackColor = True
        '
        'rbEn1200
        '
        Me.rbEn1200.AutoSize = True
        Me.rbEn1200.Location = New System.Drawing.Point(320, 33)
        Me.rbEn1200.Name = "rbEn1200"
        Me.rbEn1200.Size = New System.Drawing.Size(180, 17)
        Me.rbEn1200.TabIndex = 12
        Me.rbEn1200.Text = "Resumen por Sucursal - EN1200"
        Me.rbEn1200.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(30, 217)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(124, 17)
        Me.RadioButton4.TabIndex = 11
        Me.RadioButton4.Text = "Detalle de Devueltos"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(30, 194)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(135, 17)
        Me.RadioButton3.TabIndex = 10
        Me.RadioButton3.Text = "Planilla de Clasificacion"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(30, 171)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(131, 17)
        Me.RadioButton9.TabIndex = 9
        Me.RadioButton9.Text = "Reporte de Cobranzas"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(30, 148)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(150, 17)
        Me.RadioButton8.TabIndex = 8
        Me.RadioButton8.Text = "Reporte de Irregularidades"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(247, 250)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(123, 251)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Generar Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(30, 79)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(179, 17)
        Me.RadioButton7.TabIndex = 3
        Me.RadioButton7.Text = "Resumen Enviados por Sucursal"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(320, 150)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(131, 17)
        Me.RadioButton6.TabIndex = 2
        Me.RadioButton6.Text = "Resumen de Servicios"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(30, 102)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(129, 17)
        Me.RadioButton5.TabIndex = 1
        Me.RadioButton5.Text = "Aviso de Debito USD."
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(30, 33)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(119, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Planilla Consolidada"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(30, 56)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(136, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Detalle de Documentos"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(30, 217)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(124, 17)
        Me.RadioButton10.TabIndex = 11
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 313)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbEn1200 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents rb1600 As System.Windows.Forms.RadioButton
    Friend WithEvents rb1700 As System.Windows.Forms.RadioButton
    Friend WithEvents rb1900 As System.Windows.Forms.RadioButton
    Friend WithEvents rb2200 As System.Windows.Forms.RadioButton
    Friend WithEvents rbCompensacionUSD As System.Windows.Forms.RadioButton
End Class
