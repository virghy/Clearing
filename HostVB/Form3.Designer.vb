<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim IdRegionLabel As System.Windows.Forms.Label
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Descripciontxtbase = New WindowsControlLibrary.txtbase
        Me.IdRegionTextBox = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        DescripcionLabel = New System.Windows.Forms.Label
        IdRegionLabel = New System.Windows.Forms.Label
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(58, 39)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 0
        DescripcionLabel.Text = "Descripcion:"
        '
        'IdRegionLabel
        '
        IdRegionLabel.AutoSize = True
        IdRegionLabel.Location = New System.Drawing.Point(58, 65)
        IdRegionLabel.Name = "IdRegionLabel"
        IdRegionLabel.Size = New System.Drawing.Size(55, 13)
        IdRegionLabel.TabIndex = 2
        IdRegionLabel.Text = "id Region:"
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataSource = GetType(HostVB.Categoria)
        '
        'CategoriaBindingSource1
        '
        Me.CategoriaBindingSource1.DataSource = GetType(HostVB.Categoria)
        '
        'RegionBindingSource
        '
        Me.RegionBindingSource.DataSource = GetType(DataAccess.Region)
        '
        'Descripciontxtbase
        '
        Me.Descripciontxtbase.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Descripciontxtbase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegionBindingSource, "Descripcion", True))
        Me.Descripciontxtbase.Editando = False
        Me.Descripciontxtbase.Location = New System.Drawing.Point(130, 36)
        Me.Descripciontxtbase.Name = "Descripciontxtbase"
        Me.Descripciontxtbase.Size = New System.Drawing.Size(100, 20)
        Me.Descripciontxtbase.TabIndex = 1
        '
        'IdRegionTextBox
        '
        Me.IdRegionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegionBindingSource, "idRegion", True))
        Me.IdRegionTextBox.Location = New System.Drawing.Point(130, 62)
        Me.IdRegionTextBox.Name = "IdRegionTextBox"
        Me.IdRegionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdRegionTextBox.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(130, 89)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 264)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.Descripciontxtbase)
        Me.Controls.Add(IdRegionLabel)
        Me.Controls.Add(Me.IdRegionTextBox)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CategoriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RegionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Descripciontxtbase As WindowsControlLibrary.txtbase
    Friend WithEvents IdRegionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
