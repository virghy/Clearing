Imports System.IO

Public Class frmCherfii
    Dim Fecha As Date
    Dim IdBanco As Integer
    Dim lista As List(Of DataAccess.CHERFII)
    Dim dd As Integer
    Dim mm As Integer
    Dim aaaa As Integer
    Dim hr As Integer
    Dim mn As Integer
    Dim sg As Integer


    'Sub New(ByVal FechaProceso As Date, ByVal Banco As Integer)
    '    'Me.Fecha = FechaProceso
    '    'Me.IdBanco = Banco
    '    '' This call is required by the Windows Form Designer.
    '    'InitializeComponent()
    '    'Me.FechaDateTimePicker.Value = FechaProceso
    '    '' Add any initialization after the InitializeComponent() call.
    '    'Me.DataGridViewTextBoxColumn2.FilteringEnabled = True
    '    'Me.DataGridViewTextBoxColumn3.FilteringEnabled = True
    '    'Me.DataGridViewTextBoxColumn4.FilteringEnabled = True
    '    'Me.DataGridViewTextBoxColumn5.FilteringEnabled = True
    '    'Me.DataGridViewTextBoxColumn6.FilteringEnabled = True
    'End Sub

    Sub CargarCabecera(ByVal Cadena As String)
        'Dim cr As New DataAccess.CREC
        'cr.CodBanco = CInt(Cadena.Substring(10, 4))
        'cr.Fecha = New Date(CInt(Cadena.Substring(14, 4)), CInt(Cadena.Substring(18, 2)), CInt(Cadena.Substring(20, 2)))
        'cr.Importe = Cadena.Substring(22, 17)
        'cr.Cantidad = Cadena.Substring(39, 6)
        'Me.CRECBindingSource.Add(cr)
    End Sub
    Sub CargarDetalle(ByVal Cadena As String)
        Dim cd As New DataAccess.CHERFII
        cd.CtaLibradora = Cadena.Substring(0, 9)
        cd.NroCheque = CInt(Cadena.Substring(9, 7))
        cd.Comprobante = CInt(Cadena.Substring(16, 7))
        cd.AgenciaCR = Cadena.Substring(23, 2)
        cd.Usuario = Cadena.Substring(25, 10)
        cd.Importe = CDec(Cadena.Substring(35, 15))
        dd = CInt(Cadena.Substring(50, 2))
        mm = CInt(Cadena.Substring(52, 2))
        aaaa = CInt(Cadena.Substring(54, 4))
        cd.FechaProc = New Date(aaaa, mm, dd)
        cd.HoraProc = Cadena.Substring(58, 6)
        cd.CtaDeposito = CInt(Cadena.Substring(64, 9))
        Me.CHERFIIBindingSource.Add(cd)
    End Sub

    Sub Grabar()
        Dim edm As New DataAccess.Entities
        edm.AddToCHERFII(Me.CHERFIIBindingSource.Current)
        'edm.SaveChanges()
    End Sub

    Private Sub frmCREC_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Disposed
        Me.CHERFIIBindingSource.Dispose()
    End Sub

    Private Sub frmCREC_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed



    End Sub

    Private Sub frmCREC_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub frmCREC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Using edm As New DataAccess.Entities
            lista = edm.CHERFII.ToList()
            Me.CHERFIIBindingSource.DataSource = lista
        End Using


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Using edm As New DataAccess.Entities
            lista = edm.CHERFII.ToList()
            Me.CHERFIIBindingSource.DataSource = lista
        End Using
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
                    'If Cadena.Substring(0, 10) <> "CHERFII" Then
                    '    MsgBox("El archivo no corresponde al proceso")
                    '    Return
                    'Else
                    '    CargarCabecera(Cadena)
                    'End If
                    CargarDetalle(Cadena)
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
End Class