<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="Detalle.ascx.vb" Inherits="Futura.Modules.ClearingModule.Detalle" %>
<asp:DetailsView CssClass="Normal" ID="DetailsView1" runat="server" AutoGenerateRows="False" 
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