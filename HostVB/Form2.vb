Public Class Form2
    Dim _dc As New DataAccess.ClearingDataContext
    Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.DC = _dc
        'Me.BS.DataSource = _dc.Region
        Me.BindingSource.DataSource = _dc.Region

        'Dim obj = From cust In _dc.Region Select cust _
        '  Where cust.idRegion = 7

        'Dim c As New DataAccess.Ciudad
        'c.idCiudad = "1"
        'c.Descripcion = "dESC 1"
        '_dc.Ciudad.InsertOnSubmit(c)
        '_dc.SubmitChanges()
        Dim dic(1) As DictionaryEntry
        dic(0) = New DictionaryEntry("A", "Activo")
        dic(1) = New DictionaryEntry("I", "Inactivo")
        Me.ComboBox1.DataSource = dic
        Me.ComboBox1.DisplayMember = "Value"
        Me.ComboBox1.ValueMember = "Key"


    End Sub

End Class