Public Class Form3
    Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim dic(1) As DictionaryEntry
        dic(0) = New DictionaryEntry("A", "Activo")
        dic(1) = New DictionaryEntry("I", "Inactivo")
        Me.ComboBox1.Items.Add(dic)
        Me.ComboBox1.DisplayMember = "Value"


    End Sub
End Class