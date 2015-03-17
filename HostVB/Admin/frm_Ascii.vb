Imports System.Data.Objects
Imports DataAccess
Public Class frm_Ascii
    Dim _dc As New ClearingDA.ClearingDataContext
    Dim edm As New DataAccess.Entities
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.DC = _dc

        ' Add any initialization after the InitializeComponent() call.
        '    Dim q As List(Of DataAccess.Ascii) = (From s In edm.Ascii.Include("Ascii_Det") Where s.cod_banco = My.Application.Banco.cod_banco).ToList
        '    'Me.BindingSource.DataSource = _dc.Asciis.Where(Function(m) m.cod_banco = My.Application.Banco.cod_banco)
        '    Me.BindingSource.DataSource = q
        '    Me.Ascii_detBindingSource.DataSource = q
        '    Me.Ascii_detBindingSource.DataMember = "Ascii_Det"
    End Sub

    Private Sub AgregandoRegistro(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles BindingSource.AddingNew
        Dim NewReg As New DataAccess.Ascii
        NewReg.cod_banco = My.Application.Banco.cod_banco
        e.NewObject = NewReg
    End Sub

    Sub ActualizarControles()
        ' Dim registro As ClearingDA.Ascii = Me.BindingSource.Current
        Dim registro As DataAccess.Ascii = Me.BindingSource.Current
        Me.rdCamara.Checked = registro.IdFormato = 1
        Me.rdAscii.Checked = registro.IdFormato = 2
        Me.rdDBF.Checked = registro.IdFormato = 3

        'registro.Ascii_det.OrderBy(Function(p) p.tipo And p.orden)
        Me.Ascii_detBindingSource.DataSource = registro.Ascii_det


        IdcabeceraTextBox.ReadOnly = Not (registro.EntityState = EntityState.Added)

    End Sub

    Private Sub BindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingSource.CurrentChanged
        ActualizarControles()
    End Sub

    Private Sub frm_Ascii_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim q As ObjectQuery(Of DataAccess.Ascii)
        'q = edm.Ascii.Where("it.cod_banco=@CodBanco", New ObjectParameter("CodBanco", My.Application.Banco.cod_banco)).Include("Ascii_Det").OrderBy(Function(p) p.idcabecera)
        q = From s In edm.Ascii.Include("Ascii_Det") Where s.cod_banco = My.Application.Banco.cod_banco

        'Dim sql As String = "Select a " + _
        '                    "FROM ascii a inner join ascii_det d " + _
        '                    "on a.IdCabecera = d.IdCabecera " + _
        '                    "WHERE cod_Banco = @CodBanco " + _
        '                    "ORDER BY a.IdCabecera,d.Tipo, d.Orden"

        'q = New ObjectQuery(Of Ascii)(sql, edm)
        'q.Parameters.Add(New ObjectParameter("CodBanco", My.Application.Banco.cod_banco))

        'Select New With {Key s, Key s.Ascii_det.OrderBy(Function (g) g.orden)}

        'Dim q As List(Of DataAccess.Ascii) = (From s In edm.Ascii.Include("Ascii_Det") Where s.cod_banco = My.Application.Banco.cod_banco).ToList
        'Me.BindingSource.DataSource = _dc.Asciis.Where(Function(m) m.cod_banco = My.Application.Banco.cod_banco)
        Me.BindingSource.DataSource = q.Execute(MergeOption.AppendOnly)
        'Me.Ascii_detBindingSource.DataSource = Me.BindingSource.Current
        'Me.Ascii_detBindingSource.DataMember = "Ascii_Det"



    End Sub


    Private Sub frm_Ascii_Validar(ByRef Cancel As Boolean, ByVal ListaCambios As System.Data.Linq.ChangeSet) Handles Me.Validar
        Me.edm.SaveChanges(SaveOptions.AcceptAllChangesAfterSave)
    End Sub

    Private Sub cmdDuplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDuplicar.Click
        Dim o As DataAccess.Ascii
        o = CType(Me.BindingSource.Current, DataAccess.Ascii)
        Dim o2 As New DataAccess.Ascii
        'o2 = 
        '  o2.idcabecera = Me.BindingSource.Count + 1
        o2.ArchivoDestino = o.ArchivoDestino
        o2.ArchivoDestino1 = o.ArchivoDestino1
        o2.cod_banco = o.cod_banco
        o2.descripcion = o.descripcion
        o2.EstructuraDestino = o.EstructuraDestino
        o2.IdFormato = o.IdFormato
        o2.IdMoneda = o.IdMoneda
        o2.IdProceso = o.IdProceso
        o2.registro_fin = o.registro_fin
        o2.registro_inicio = o.registro_inicio
        o2.sql = o.sql
        o2.Titulo = o.Titulo

        For Each d In o.Ascii_det
            Dim d2 As New DataAccess.Ascii_det
            d2.descripcion = d.descripcion
            d2.formato = d.formato
            d2.longitud = d.longitud
            d2.orden = d.orden
            d2.tipo = d.tipo
            d2.valor = d.valor
            o2.Ascii_det.Add(d2)
        Next

        Me.BindingSource.Add(o2)

    End Sub



End Class




