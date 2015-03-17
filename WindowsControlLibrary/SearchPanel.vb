Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Public Class SearchPanel

    Private Function GetSearchGridView() As GridView
        Return TryCast(SearchColumn.View, GridView)
    End Function



    Private _SearchText As String
    Public Property SearchText() As String
        Get
            Return _SearchText
        End Get
        Set(ByVal value As String)
            If _SearchText <> value Then
                Reiniciar = True
            End If
            _SearchText = value
            'OnSearchTextChanged()
        End Set
    End Property
    Dim _Reiniciar As Boolean
    Public Property Reiniciar() As Boolean
        Get
            Return _Reiniciar
        End Get
        Set(ByVal value As Boolean)
            _Reiniciar = value
        End Set
    End Property

    Private _SearchColumn As GridColumn
    Public Property SearchColumn() As GridColumn
        Get
            Return _SearchColumn
        End Get
        Set(ByVal value As GridColumn)
            _SearchColumn = value
        End Set
    End Property

    Private Function FindRow(ByVal startRowHandle As Integer, ByVal isForward As Boolean) As Integer
        If SearchColumn Is Nothing Then
            Return GridControl.InvalidRowHandle
        End If
        startRowHandle = Math.Max(0, startRowHandle)
        Dim view As GridView = GetSearchGridView()
        Try
            Dim delta As Integer
            If isForward Then
                delta = 1
            Else
                delta = -1
            End If
            Dim n As Integer = startRowHandle
            Do While view.IsValidRowHandle(n)

                
                Dim cellText As Decimal = GetSearchGridView().GetRowCellValue(n, SearchColumn)
                If cellText.Equals(CDec(SearchText)) Then
                    Return n
                End If
                n += delta
            Loop
        Catch ex As Exception
        End Try
        Return GridControl.InvalidRowHandle
    End Function

    Public Sub FocusNextRow(ByVal isForward As Boolean)
        Dim searchGridView As GridView = GetSearchGridView()
        If searchGridView.FocusedRowHandle >= 0 Then
            searchGridView.UnselectRow(searchGridView.FocusedRowHandle)
        End If

        Dim RowInicial As Integer
        If Reiniciar Then
            RowInicial = 0
            Reiniciar = False
        Else
            RowInicial = searchGridView.FocusedRowHandle + 1
        End If

        Dim focusedRowHandle As Integer = FindRow(RowInicial, isForward)
        searchGridView.FocusedRowHandle = focusedRowHandle
        If GridControl.InvalidRowHandle = focusedRowHandle Then
            MsgBox("Se ha llegado al final de la busqueda", MsgBoxStyle.Information, "Clearing de Cheques")
        End If
        If focusedRowHandle >= 0 Then
            searchGridView.SelectRow(focusedRowHandle)
        End If
    End Sub

    Private Sub txtCadena_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCadena.TextChanged
        SearchText = txtCadena.Text
    End Sub

    Private Sub cmdSearch_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles cmdSearch.LinkClicked
        If e.Button = Windows.Forms.MouseButtons.Right Then
            FocusNextRow(False)
        Else
            FocusNextRow(True)
        End If


    End Sub
End Class
