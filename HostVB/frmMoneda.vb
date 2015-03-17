Public Class frmMoneda
    Dim _dc As New ClearingDA.ClearingDataContext
    Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.DC = _dc
        'Me.BS.DataSource = _dc.Region
        Me.BindingSource.DataSource = _dc.Monedas

    End Sub

End Class