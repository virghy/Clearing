Public Class Form2

    Private Sub LecturasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.LecturasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClearingDataSets)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClearingDataSets.Lecturas' Puede moverla o quitarla según sea necesario.
        Me.LecturasTableAdapter.Fill(Me.ClearingDataSets.Lecturas)

    End Sub
End Class