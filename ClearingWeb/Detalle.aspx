<%@ Page Title="" EnableViewState="false" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master.Master" CodeBehind="Detalle.aspx.vb" Inherits="ClearingWeb.Detalle" %>
<%@ Register assembly="System.Web.Entity, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" namespace="System.Web.UI.WebControls" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
        DataKeyNames="IdLectura" Height="50px" Width="125px" 
        EnableViewState="false">
        <Fields>
            <asp:BoundField DataField="cabecera" HeaderText="Secuencia" 
                SortExpression="cabecera" />
            <asp:BoundField DataField="cod_banco_emisor" HeaderText="Banco" 
                SortExpression="cod_banco_emisor" />
            <asp:BoundField DataField="cod_tipdoc" HeaderText="Doc" 
                SortExpression="cod_tipdoc" />
            <asp:BoundField DataField="cuenta_cheque" HeaderText="Cuenta" 
                SortExpression="cuenta_cheque" />
            <asp:BoundField DataField="numero_cheque" HeaderText="Serie" 
                SortExpression="numero_cheque" />
            <asp:BoundField DataField="cod_banco_receptor" HeaderText="Receptor" 
                SortExpression="cod_banco_receptor" />
            <asp:BoundField DataField="cod_camara" HeaderText="Camara" 
                SortExpression="cod_camara" />
            <asp:BoundField DataField="monto" HeaderText="Monto" SortExpression="monto" 
                DataFormatString="{0:N2}" />
            <asp:BoundField DataField="cadena_captura" HeaderText="Cadena Captura" 
                SortExpression="cadena_captura" />
        </Fields>
    </asp:DetailsView>
    <asp:LinkButton ID="LinkButton1" OnClientClick="javascript:history.back();return false;" runat="server">Volver a Consulta</asp:LinkButton>
    <p>
    </p>
</asp:Content>
