Imports Microsoft.Win32
Public Class frmBanco
    Dim _dc As New ClearingDA.ClearingDataContext
    Dim dic(1) As DictionaryEntry


    Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.DC = _dc

        'Me.BS.DataSource = _dc.Region
        Me.BindingSource.DataSource = _dc.Bancos
        'Dim obj(1, 1) As String
        'obj(0, 0) = "ACTIVO"
        'obj(0, 1) = "A"
        'obj(1, 0) = "INACTIVO"
        'obj(1, 1) = "I"
        'Me.estado.DataSource = obj

        'dic(0) = New DictionaryEntry("A", "Activo")
        'dic(1) = New DictionaryEntry("I", "Inactivo")
        'Me.estado.DataSource = dic
        'Me.estado.DisplayMember = "Value"
        'Me.estado.ValueMember = "Key"
        '  Me.EstadosBindingSource.DataSource = From es In _dc.Estados Select es

    End Sub


    Private Sub frmBanco_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim regKey As RegistryKey
        'Dim path As String
        'regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\CR55", False)
        'path = regKey.GetValue("Path")
        'MsgBox(path)

    End Sub
End Class