Imports System.IO

Public Class frmCREC
    Dim Fecha As Date
    Dim IdBanco As Integer
    Dim lista As List(Of DataAccess.CREC)
    Sub New(ByVal FechaProceso As Date, ByVal Banco As Integer)
        Me.Fecha = FechaProceso
        Me.IdBanco = Banco
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.FechaDateTimePicker.Value = FechaProceso
        ' Add any initialization after the InitializeComponent() call.
        Me.DataGridViewTextBoxColumn2.FilteringEnabled = True
        Me.DataGridViewTextBoxColumn3.FilteringEnabled = True
        Me.DataGridViewTextBoxColumn4.FilteringEnabled = True
        Me.DataGridViewTextBoxColumn5.FilteringEnabled = True
        Me.DataGridViewTextBoxColumn6.FilteringEnabled = True
    End Sub
    Private Sub cmdImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImportar.Click
        Try
            Dim FileName As String
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                FileName = OpenFileDialog1.FileName
                Dim txt As StreamReader = New StreamReader(FileName)
                Dim Cadena As String = String.Empty
                Cadena = txt.ReadLine()
                If Cadena.Length > 0 Then
                    If Cadena.Substring(0, 10) <> "CLRRECIBID" Then
                        MsgBox("El archivo no corresponde al proceso")
                        Return
                    Else
                        CargarCabecera(Cadena)
                    End If
                End If
                Cadena = txt.ReadLine()
                While Cadena IsNot Nothing
                    CargarDetalle(Cadena)
                    Cadena = txt.ReadLine()
                End While


                txt.Close()
                Grabar()
                'Me.CRECBindingSource.
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub
    Sub CargarCabecera(ByVal Cadena As String)
        Dim cr As New DataAccess.CREC
        cr.CodBanco = CInt(Cadena.Substring(10, 4))
        cr.Fecha = New Date(CInt(Cadena.Substring(14, 4)), CInt(Cadena.Substring(18, 2)), CInt(Cadena.Substring(20, 2)))
        cr.Importe = Cadena.Substring(22, 17)
        cr.Cantidad = Cadena.Substring(39, 6)
        Me.CRECBindingSource.Add(cr)
    End Sub
    Sub CargarDetalle(ByVal Cadena As String)
        Dim cd As New DataAccess.CRECDet
        'cd.IdBanco = CInt(Cadena.Substring(0, 4))
        cd.IdBanco = Cadena.Substring(2, 2)
        cd.Cuenta = CDec(Cadena.Substring(4, 12))
        cd.Numero = CDec(Cadena.Substring(16, 8))
        cd.Importe = CDec(Cadena.Substring(24, 17))
        cd.Secuencia = CInt(Cadena.Substring(41, 6))
        Me.CRECDetBindingSource.Add(cd)
    End Sub

    Sub Grabar()
        Dim edm As New DataAccess.Entities
        edm.AddToCREC(Me.CRECBindingSource.Current)
        edm.SaveChanges()
    End Sub

    Private Sub frmCREC_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Me.CRECBindingSource.Dispose()
    End Sub

    Private Sub frmCREC_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed



    End Sub

    Private Sub frmCREC_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub frmCREC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Using edm As New DataAccess.Entities
            lista = (edm.CREC.Where(Function(p) p.Fecha = Fecha And p.CodBanco = IdBanco)).ToList()
            Me.CRECBindingSource.DataSource = lista
        End Using


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Using edm As New DataAccess.Entities
            lista = (edm.CREC.Include("CRECDet").Where(Function(p) p.Fecha = Fecha And p.CodBanco = IdBanco)).ToList()
            Me.CRECBindingSource.DataSource = lista
        End Using

    End Sub
End Class