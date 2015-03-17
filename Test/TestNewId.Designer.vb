<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestNewId
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestNewId))
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtLimite = New System.Windows.Forms.TextBox
        Me.PruebaNewIdBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PruebaNewIdBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.PruebaNewIdBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.PruebaNewIdGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colInstancia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtInstancia = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.PruebaNewIdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PruebaNewIdBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PruebaNewIdBindingNavigator.SuspendLayout()
        CType(Me.PruebaNewIdGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(400, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtLimite
        '
        Me.txtLimite.Location = New System.Drawing.Point(400, 71)
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.Size = New System.Drawing.Size(100, 20)
        Me.txtLimite.TabIndex = 3
        Me.txtLimite.Text = "5000"
        '
        'PruebaNewIdBindingSource
        '
        Me.PruebaNewIdBindingSource.DataSource = GetType(DataAccess.PruebaNewId)
        '
        'PruebaNewIdBindingNavigator
        '
        Me.PruebaNewIdBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PruebaNewIdBindingNavigator.BindingSource = Me.PruebaNewIdBindingSource
        Me.PruebaNewIdBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PruebaNewIdBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PruebaNewIdBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PruebaNewIdBindingNavigatorSaveItem})
        Me.PruebaNewIdBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PruebaNewIdBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PruebaNewIdBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PruebaNewIdBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PruebaNewIdBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PruebaNewIdBindingNavigator.Name = "PruebaNewIdBindingNavigator"
        Me.PruebaNewIdBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PruebaNewIdBindingNavigator.Size = New System.Drawing.Size(520, 25)
        Me.PruebaNewIdBindingNavigator.TabIndex = 4
        Me.PruebaNewIdBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PruebaNewIdBindingNavigatorSaveItem
        '
        Me.PruebaNewIdBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PruebaNewIdBindingNavigatorSaveItem.Enabled = False
        Me.PruebaNewIdBindingNavigatorSaveItem.Image = CType(resources.GetObject("PruebaNewIdBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PruebaNewIdBindingNavigatorSaveItem.Name = "PruebaNewIdBindingNavigatorSaveItem"
        Me.PruebaNewIdBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PruebaNewIdBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PruebaNewIdGridControl
        '
        Me.PruebaNewIdGridControl.DataSource = Me.PruebaNewIdBindingSource
        Me.PruebaNewIdGridControl.Location = New System.Drawing.Point(20, 35)
        Me.PruebaNewIdGridControl.MainView = Me.GridView1
        Me.PruebaNewIdGridControl.Name = "PruebaNewIdGridControl"
        Me.PruebaNewIdGridControl.Size = New System.Drawing.Size(300, 220)
        Me.PruebaNewIdGridControl.TabIndex = 4
        Me.PruebaNewIdGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colNro, Me.colInstancia})
        Me.GridView1.GridControl = Me.PruebaNewIdGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        '
        'colNro
        '
        Me.colNro.FieldName = "Nro"
        Me.colNro.Name = "colNro"
        Me.colNro.Visible = True
        Me.colNro.VisibleIndex = 1
        '
        'colInstancia
        '
        Me.colInstancia.FieldName = "Instancia"
        Me.colInstancia.Name = "colInstancia"
        Me.colInstancia.Visible = True
        Me.colInstancia.VisibleIndex = 2
        '
        'txtInstancia
        '
        Me.txtInstancia.Location = New System.Drawing.Point(400, 98)
        Me.txtInstancia.Name = "txtInstancia"
        Me.txtInstancia.Size = New System.Drawing.Size(100, 20)
        Me.txtInstancia.TabIndex = 5
        Me.txtInstancia.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(327, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Iteraccion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(327, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Instancia"
        '
        'TestNewId
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 277)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInstancia)
        Me.Controls.Add(Me.PruebaNewIdGridControl)
        Me.Controls.Add(Me.PruebaNewIdBindingNavigator)
        Me.Controls.Add(Me.txtLimite)
        Me.Controls.Add(Me.Button1)
        Me.Name = "TestNewId"
        Me.Text = "TestNewId"
        CType(Me.PruebaNewIdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PruebaNewIdBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PruebaNewIdBindingNavigator.ResumeLayout(False)
        Me.PruebaNewIdBindingNavigator.PerformLayout()
        CType(Me.PruebaNewIdGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtLimite As System.Windows.Forms.TextBox
    Friend WithEvents PruebaNewIdBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PruebaNewIdBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PruebaNewIdBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PruebaNewIdGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInstancia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtInstancia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
