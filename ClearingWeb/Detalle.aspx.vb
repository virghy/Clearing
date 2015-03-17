Imports DataAccess
Partial Public Class Detalle
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Request.QueryString("Id") IsNot Nothing Then
            CargarDatos()
        End If


    End Sub

    Sub CargarDatos()
        Dim IdLectura As Integer = Request.QueryString("Id")
        Dim dm As New Entities
        Dim Lista = (From c In dm.Lecturas _
                 Where c.IdLectura = IdLectura _
                Select c _
                    Order By c.nro_lote, c.cod_tipdoc Descending, c.cabecera).ToList
        Me.DetailsView1.DataSource = Lista
        Me.DetailsView1.DataBind()
    End Sub

End Class