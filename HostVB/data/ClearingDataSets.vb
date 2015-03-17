
Partial Class ClearingDataSets
    Partial Class LecturasDataTable

        Private Sub LecturasDataTable_LecturasRowChanging(ByVal sender As System.Object, ByVal e As LecturasRowChangeEvent) Handles Me.LecturasRowChanging

        End Sub

        Public Sub Validar()
            For Each row As LecturasRow In Me.Rows
                If row.monto <= 0 Then
                    row.CORREGIDO = False
                    row.SetColumnError("monto", "El Importe debe ser Mayor a 0")
                Else
                    row.SetColumnError("monto", "")
                End If

                If Not row.EsCabecera Then
                    If (row.cod_proceso = 2 Or row.cod_proceso = 1) _
                      AndAlso row.cod_banco_emisor = row.cod_banco_receptor Then ''Enviado y Devuelto
                        row.CORREGIDO = False
                        row.SetColumnError("cod_banco_receptor", "El banco emisor no puede ser igual a receptor")
                    Else
                        row.SetColumnError("cod_banco_receptor", "")
                    End If

                    If row.cod_proceso = 2 Then
                        If row.cod_banco <> row.cod_banco_emisor Then
                            row.CORREGIDO = False
                            row.SetColumnError("cod_banco_emisor", "El banco receptor debe ser igual al banco actual")
                        Else
                            row.SetColumnError("cod_banco_emisor", "")
                        End If
                    End If


                    If row.cod_proceso = 3 Then
                        If row.cod_banco <> row.cod_banco_receptor Then
                            row.CORREGIDO = False
                            row.SetColumnError("cod_banco_receptor", "El banco emisor debe ser igual al banco actual")
                        Else
                            row.SetColumnError("cod_banco_receptor", "")
                        End If
                    End If

                    If row.numero_cheque = 0 Then
                        row.SetColumnError("numero_cheque", "Nro de Cheque no valido.")
                    Else
                        row.SetColumnError("numero_cheque", "")
                    End If
                End If


            Next
        End Sub
        Private Sub LecturasDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.cod_banco_receptorColumn.ColumnName) Then
                'Agregar código de usuario aquí

            End If

        End Sub

    End Class

    Partial Class LecturasRow
        Public ReadOnly Property EsCabecera() As Boolean
            Get
                If "00-01-02-03-04-05".Contains(Me.cod_tipdoc) Then
                    Return False
                Else
                    Return True
                End If
            End Get
        End Property

    End Class


End Class
