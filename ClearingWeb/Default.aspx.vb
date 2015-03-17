Imports DataAccess

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

        CargarDatos()
    End Sub
    Sub CargarDatos()
        'CabList = From c In dm.Lecturas Select c _
        '            Where c.fecha_lectura = Fecha And c.cod_maquina = CodMaquina Order By c.nro_lote, c.cabecera
        '  dm.AcceptAllChanges()
        Dim dm As New Entities
        Dim Lista = (From c In dm.Lecturas _
                 Where c.cod_banco = "06" And (c.fecha_lectura = Me.txtFecha.Text Or Me.CheckBox1.Checked) _
                And (Me.txtNumero.Text.Length = 0 OrElse c.numero_cheque = Me.txtNumero.Text) _
                And (Me.txtCuenta.Text.Length = 0 OrElse c.cuenta_cheque = Me.txtCuenta.Text) _
                And "00-01-02-03-04".Contains(c.cod_tipdoc) _
                Select c _
                    Order By c.nro_lote, c.cod_tipdoc Descending, c.cabecera).ToList
        Me.GridView1.DataSource = Lista
        Me.GridView1.DataBind()
    End Sub


End Class