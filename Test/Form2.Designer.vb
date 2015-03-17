<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.RadDock1 = New Telerik.WinControls.UI.Docking.RadDock
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer
        Me.DocumentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow
        Me.DocumentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip
        Me.ToolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip
        Me.ToolWindow2 = New Telerik.WinControls.UI.Docking.ToolWindow
        Me.ToolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip
        Me.ToolWindow3 = New Telerik.WinControls.UI.Docking.ToolWindow
        Me.ToolTabStrip3 = New Telerik.WinControls.UI.Docking.ToolTabStrip
        Me.ToolWindow4 = New Telerik.WinControls.UI.Docking.ToolWindow
        Me.ToolTabStrip4 = New Telerik.WinControls.UI.Docking.ToolTabStrip
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDock1.SuspendLayout()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentContainer1.SuspendLayout()
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentTabStrip1.SuspendLayout()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip1.SuspendLayout()
        CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip2.SuspendLayout()
        CType(Me.ToolTabStrip3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip3.SuspendLayout()
        CType(Me.ToolTabStrip4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip4.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadDock1
        '
        Me.RadDock1.ActiveWindow = Me.DocumentWindow1
        Me.RadDock1.Controls.Add(Me.DocumentContainer1)
        Me.RadDock1.Controls.Add(Me.ToolTabStrip1)
        Me.RadDock1.Controls.Add(Me.ToolTabStrip2)
        Me.RadDock1.Controls.Add(Me.ToolTabStrip3)
        Me.RadDock1.Controls.Add(Me.ToolTabStrip4)
        Me.RadDock1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadDock1.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront
        Me.RadDock1.IsCleanUpTarget = True
        Me.RadDock1.Location = New System.Drawing.Point(0, 0)
        Me.RadDock1.MainDocumentContainer = Me.DocumentContainer1
        Me.RadDock1.Name = "RadDock1"
        Me.RadDock1.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RadDock1.Padding = New System.Windows.Forms.Padding(5)
        '
        '
        '
        Me.RadDock1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadDock1.Size = New System.Drawing.Size(284, 264)
        Me.RadDock1.SplitterWidth = 4
        Me.RadDock1.TabIndex = 0
        Me.RadDock1.TabStop = False
        Me.RadDock1.Text = "RadDock1"
        '
        'DocumentContainer1
        '
        Me.DocumentContainer1.Controls.Add(Me.DocumentTabStrip1)
        Me.DocumentContainer1.Location = New System.Drawing.Point(5, 5)
        Me.DocumentContainer1.Name = "DocumentContainer1"
        '
        '
        '
        Me.DocumentContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentContainer1.Size = New System.Drawing.Size(274, 25)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.DocumentContainer1.SplitterWidth = 4
        Me.DocumentContainer1.TabIndex = 0
        Me.DocumentContainer1.TabStop = False
        '
        'DocumentWindow1
        '
        Me.DocumentWindow1.Location = New System.Drawing.Point(6, 6)
        Me.DocumentWindow1.Name = "DocumentWindow1"
        Me.DocumentWindow1.Size = New System.Drawing.Size(262, 13)
        Me.DocumentWindow1.Text = "DocumentWindow1"
        '
        'DocumentTabStrip1
        '
        Me.DocumentTabStrip1.Controls.Add(Me.DocumentWindow1)
        Me.DocumentTabStrip1.Location = New System.Drawing.Point(0, 0)
        Me.DocumentTabStrip1.Name = "DocumentTabStrip1"
        '
        '
        '
        Me.DocumentTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentTabStrip1.SelectedIndex = 0
        Me.DocumentTabStrip1.Size = New System.Drawing.Size(274, 25)
        Me.DocumentTabStrip1.TabIndex = 0
        Me.DocumentTabStrip1.TabStop = False
        Me.DocumentTabStrip1.TabStripVisible = False
        '
        'ToolWindow1
        '
        Me.ToolWindow1.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindow1.Name = "ToolWindow1"
        Me.ToolWindow1.Size = New System.Drawing.Size(272, 27)
        Me.ToolWindow1.Text = "ToolWindow1"
        '
        'ToolTabStrip1
        '
        Me.ToolTabStrip1.Controls.Add(Me.ToolWindow1)
        Me.ToolTabStrip1.Location = New System.Drawing.Point(5, 34)
        Me.ToolTabStrip1.Name = "ToolTabStrip1"
        '
        '
        '
        Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip1.SelectedIndex = 0
        Me.ToolTabStrip1.Size = New System.Drawing.Size(274, 53)
        Me.ToolTabStrip1.TabIndex = 1
        Me.ToolTabStrip1.TabStop = False
        '
        'ToolWindow2
        '
        Me.ToolWindow2.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindow2.Name = "ToolWindow2"
        Me.ToolWindow2.Size = New System.Drawing.Size(272, 27)
        Me.ToolWindow2.Text = "ToolWindow2"
        '
        'ToolTabStrip2
        '
        Me.ToolTabStrip2.Controls.Add(Me.ToolWindow2)
        Me.ToolTabStrip2.Location = New System.Drawing.Point(5, 91)
        Me.ToolTabStrip2.Name = "ToolTabStrip2"
        '
        '
        '
        Me.ToolTabStrip2.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip2.SelectedIndex = 0
        Me.ToolTabStrip2.Size = New System.Drawing.Size(274, 53)
        Me.ToolTabStrip2.TabIndex = 2
        Me.ToolTabStrip2.TabStop = False
        '
        'ToolWindow3
        '
        Me.ToolWindow3.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindow3.Name = "ToolWindow3"
        Me.ToolWindow3.Size = New System.Drawing.Size(272, 27)
        Me.ToolWindow3.Text = "ToolWindow3"
        '
        'ToolTabStrip3
        '
        Me.ToolTabStrip3.Controls.Add(Me.ToolWindow3)
        Me.ToolTabStrip3.Location = New System.Drawing.Point(5, 148)
        Me.ToolTabStrip3.Name = "ToolTabStrip3"
        '
        '
        '
        Me.ToolTabStrip3.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip3.SelectedIndex = 0
        Me.ToolTabStrip3.Size = New System.Drawing.Size(274, 53)
        Me.ToolTabStrip3.TabIndex = 3
        Me.ToolTabStrip3.TabStop = False
        '
        'ToolWindow4
        '
        Me.ToolWindow4.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindow4.Name = "ToolWindow4"
        Me.ToolWindow4.Size = New System.Drawing.Size(272, 28)
        Me.ToolWindow4.Text = "ToolWindow4"
        '
        'ToolTabStrip4
        '
        Me.ToolTabStrip4.Controls.Add(Me.ToolWindow4)
        Me.ToolTabStrip4.Location = New System.Drawing.Point(5, 205)
        Me.ToolTabStrip4.Name = "ToolTabStrip4"
        '
        '
        '
        Me.ToolTabStrip4.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip4.SelectedIndex = 0
        Me.ToolTabStrip4.Size = New System.Drawing.Size(274, 54)
        Me.ToolTabStrip4.TabIndex = 4
        Me.ToolTabStrip4.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.RadDock1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDock1.ResumeLayout(False)
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentContainer1.ResumeLayout(False)
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentTabStrip1.ResumeLayout(False)
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip1.ResumeLayout(False)
        CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip2.ResumeLayout(False)
        CType(Me.ToolTabStrip3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip3.ResumeLayout(False)
        CType(Me.ToolTabStrip4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadDock1 As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend WithEvents DocumentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
    Friend WithEvents DocumentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents ToolTabStrip2 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow2 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents ToolTabStrip3 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow3 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents ToolTabStrip4 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow4 As Telerik.WinControls.UI.Docking.ToolWindow
End Class
