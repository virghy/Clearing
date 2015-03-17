Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Public Class frmBase
    Private _IdObjeto As Integer
    Private _dc As System.Data.Linq.DataContext
    Private _dm As System.Data.Objects.ObjectContext
    'Private _bs As System.Windows.Forms.BindingSource

    Public Event Validar(ByRef Cancel As Boolean, ByVal ListaCambios As Linq.ChangeSet)


    Public Property IdObjeto() As Integer
        Get
            Return _IdObjeto
        End Get
        Set(ByVal value As Integer)
            _IdObjeto = value
        End Set
    End Property
    Public Property DC() As DataContext
        Get
            Return _dc
        End Get
        Set(ByVal value As DataContext)
            _dc = value
        End Set
    End Property

    'Public Property BS() As BindingSource
    '    Get
    '        Return _bs
    '    End Get
    '    Set(ByVal value As BindingSource)
    '        _bs = value
    '    End Set
    'End Property
    Public Overridable Sub Grabar()
        If Not Me.Validate() Then
            Return
        End If
        Dim Cancel As Boolean = False

        RaiseEvent Validar(Cancel, Me.DC.GetChangeSet)
        If Cancel = True Then
            Return
        End If

        Try
            Me._dc.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GuardarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton.Click
        Me.Grabar()
    End Sub

    Private Sub frmBase_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Me.DC.GetChangeSet.Deletes.Count > 0 Or _
            Me.DC.GetChangeSet.Inserts.Count > 0 Or _
            Me.DC.GetChangeSet.Updates.Count > 0 Then

            Dim r As DialogResult
            r = MessageBox.Show("Sus datos han cambiado." + Chr(13) + "Desea guardar primero sus cambios?", "Atencion", MessageBoxButtons.YesNoCancel)
            Select Case r
                Case Windows.Forms.DialogResult.Cancel
                    e.Cancel = True
                Case Windows.Forms.DialogResult.Yes
                    Me.Grabar()

            End Select

        End If

    End Sub
End Class
