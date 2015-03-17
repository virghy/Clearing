<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.txtCadena = New System.Windows.Forms.TextBox
        Me.cmdSearch = New System.Windows.Forms.LinkLabel
        Me.SuspendLayout()
        '
        'txtCadena
        '
        Me.txtCadena.Location = New System.Drawing.Point(3, 3)
        Me.txtCadena.Name = "txtCadena"
        Me.txtCadena.Size = New System.Drawing.Size(144, 20)
        Me.txtCadena.TabIndex = 1
        '
        'cmdSearch
        '
        Me.cmdSearch.AutoSize = True
        Me.cmdSearch.Location = New System.Drawing.Point(7, 30)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(40, 13)
        Me.cmdSearch.TabIndex = 2
        Me.cmdSearch.TabStop = True
        Me.cmdSearch.Text = "Buscar"
        '
        'SearchPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.txtCadena)
        Me.Name = "SearchPanel"
        Me.Size = New System.Drawing.Size(150, 58)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCadena As System.Windows.Forms.TextBox
    Friend WithEvents cmdSearch As System.Windows.Forms.LinkLabel

End Class
