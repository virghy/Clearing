Imports System.Data.Linq
Imports System.Reflection

Public Class frmClasificacion
    Private dm As New DataAccess.Entities
    Private Condiciones As List(Of DataAccess.Clasificacion)
    Private Sub frmClasificacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Condiciones = (From s In dm.Clasificacion.Include("ClasificacionDet") Where s.Idbanco = My.Application.Banco.cod_banco Order By s.Prioridad Select s).ToList
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Function Analizar(ByVal objeto As DataAccess.Lecturas) As Integer
        Dim valorCondicion As Object
        Dim enumType As Type = objeto.GetType()
        Dim infos As PropertyInfo
        Dim Valido As Boolean = True
        Dim Continuacion As String = Nothing
        For Each con In Condiciones
            For Each ev In con.ClasificacionDet
                infos = enumType.GetProperty(ev.Propiedad)
                If infos IsNot Nothing Then
                    valorCondicion = infos.GetValue(objeto, Nothing)
                Else
                    Throw New Exception(String.Format("No se encuentra la propiedad"))
                End If

                'CType(ev.Valor, infos)
                If Continuacion Is Nothing Then
                    Valido = Comparar(valorCondicion, ev.Condicion, ev.Valor)
                Else

                    If Continuacion = "OR" Then
                        Valido = Valido Or Comparar(valorCondicion, ev.Condicion, ev.Valor)
                    Else
                        Valido = Valido And Comparar(valorCondicion, ev.Condicion, ev.Valor)
                    End If



                End If
                Continuacion = ev.Continuacion
            Next
            If Valido Then
                Return con.IdClasificacion
            End If
        Next

        Return Nothing



    End Function
    Function Comparar(ByVal objeto1 As Object, ByVal condicion As String, ByVal objeto2 As Object) As Boolean
        Select Case condicion
            Case "="
                Return objeto1 = objeto2
            Case ">"
                Return objeto1 > objeto2
            Case "<"
                Return objeto1 < objeto2
            Case ">="
                Return objeto1 >= objeto2
            Case "<="
                Return objeto1 <= objeto2


        End Select
        Return False
    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Condiciones = (From s In dm.Clasificacion.Include("ClasificacionDet") Where s.Idbanco = My.Application.Banco.cod_banco Order By s.Prioridad Select s).ToList
            Dim IdProceso As Integer = My.Application.IdProceso
            Dim lista As List(Of DataAccess.Lecturas)
            lista = (From s In dm.Lecturas Where s.fecha_lectura = Me.DateTimePicker1.Text And s.cod_proceso = 3 And s.cod_moneda = My.Application.Moneda.cod_moneda And s.cod_tipdoc <> "90").ToList

            Me.ProgressBar1.Maximum = lista.Count
            Me.ProgressBar1.Value = 0
            Dim IdCondicion As Integer
            For Each item In lista

                IdCondicion = Analizar(item)

                item.IdClasificacion = IIf(IdCondicion = 0, Nothing, IdCondicion)
                '   Dim ok = item.Where(condicion)
                Me.ProgressBar1.Value += 1

            Next
            'Dim ok = (From s In lista Where (condicion)).ToList

            dm.SaveChanges()
            '    Me.LecturasBindingSource.DataSource = lista
            MsgBox("Proceso Finalizado")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class