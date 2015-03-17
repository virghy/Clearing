Imports System.IO

Public Class frmCHITCI
    Dim Fecha As Date
    Dim IdBanco As Integer
    Dim lista As List(Of DataAccess.CHITCI)
    Dim dd As Integer
    Dim mm As Integer
    Dim aaaa As Integer
    Dim hr As Integer
    Dim mn As Integer
    Dim sg As Integer

    Sub CargarCabecera(ByVal Cadena As String)
        'Dim cr As New DataAccess.CREC
        'cr.CodBanco = CInt(Cadena.Substring(10, 4))
        'cr.Fecha = New Date(CInt(Cadena.Substring(14, 4)), CInt(Cadena.Substring(18, 2)), CInt(Cadena.Substring(20, 2)))
        'cr.Importe = Cadena.Substring(22, 17)
        'cr.Cantidad = Cadena.Substring(39, 6)
        'Me.CRECBindingSource.Add(cr)
    End Sub


    Sub CargarDetalle(ByVal Cadena As String)
        Dim cd As New DataAccess.CHITCI
        'cd.IdBanco = CInt(Cadena.Substring(0, 4))
        cd.Usuario = Cadena.Substring(0, 10)
        cd.NroMovUsuario = CInt(Cadena.Substring(10, 4))
        aaaa = CInt(Cadena.Substring(14, 4))
        mm = CInt(Cadena.Substring(18, 2))
        dd = CInt(Cadena.Substring(20, 2))
        cd.FechaMov = New Date(aaaa, mm, dd)
        cd.CtaDeposito = Cadena.Substring(22, 9)
        cd.Moneda = Cadena.Substring(31, 2)
        cd.Agencia = Cadena.Substring(33, 2)
        cd.TipoUsuario = Cadena.Substring(35, 1)
        cd.Comprobante = CInt(Cadena.Substring(36, 7))
        cd.Importe = CDec(Cadena.Substring(43, 14))
        cd.CantCheques = CInt(Cadena.Substring(57, 4))
        cd.HoraMov = Cadena.Substring(61, 6)
        cd.EstadoProceso = Cadena.Substring(67, 1)
        Me.CHITCIBindingSource.Add(cd)
    End Sub
    Sub Grabar()
        Dim edm As New DataAccess.Entities
        edm.AddToCHITCI(Me.CHITCIBindingSource.Current)
        'edm.SaveChanges()
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Using edm As New DataAccess.Entities
            lista = edm.CHITCI.ToList()
            Me.CHITCIBindingSource.DataSource = lista
        End Using
    End Sub

    Private Sub frmCHITCI_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Me.CHITCIBindingSource.Dispose()
    End Sub

    Private Sub frmCHITCI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Using edm As New DataAccess.Entities
            lista = edm.CHITCI.ToList()
            Me.CHITCIBindingSource.DataSource = lista
        End Using
    End Sub
End Class