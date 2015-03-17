<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="ClearingWeb._Default" %>

<%@ Register assembly="System.Web.Entity, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" namespace="System.Web.UI.WebControls" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    	<table cellpadding="0" cellspacing="0" style="width: 100%">
			<tr>
				<td>Fecha</td>
				<td>
				<asp:TextBox id="txtFecha" runat="server"></asp:TextBox>
				&nbsp;</td>
				<td>
				<asp:CheckBox id="CheckBox1" runat="server" Text="Sin Filtro de Fecha" />
				&nbsp;</td>
			</tr>
			<tr>
				<td>Numero</td>
				<td>
				<asp:TextBox id="txtNumero" runat="server"></asp:TextBox>
				&nbsp;</td>
				<td>&nbsp;</td>
			</tr>
			<tr>
				<td>Cuenta</td>
				<td>
				<asp:TextBox id="txtCuenta" runat="server"></asp:TextBox>
				&nbsp;</td>
				<td>&nbsp;</td>
			</tr>
			<tr>
				<td>&nbsp;</td>
				<td>
				<asp:Button id="Button1" runat="server" Text="Buscar" />
				&nbsp;</td>
				<td>&nbsp;</td>
			</tr>
		</table>
    
    </div>
    	<div>
			<asp:GridView id="GridView1" runat="server" AutoGenerateColumns="False" 
                DataKeyNames="IdLectura">
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="IdLectura" 
                        DataNavigateUrlFormatString="detalle.aspx?Id={0}" Text="Detalle" />
                    <asp:BoundField DataField="fecha_lectura" DataFormatString="{0:d}" 
                        HeaderText="Fecha" SortExpression="fecha_lectura" />
                    <asp:BoundField DataField="nro_lote" HeaderText="Lote" 
                        SortExpression="nro_lote" />
                    <asp:BoundField DataField="cod_banco_emisor" HeaderText="Banco" 
                        SortExpression="cod_banco_emisor" />
                    <asp:BoundField DataField="cod_tipdoc" HeaderText="Doc" 
                        SortExpression="cod_tipdoc" />
                    <asp:BoundField DataField="cuenta_cheque" HeaderText="Cuenta" 
                        SortExpression="cuenta_cheque" />
                    <asp:BoundField DataField="numero_cheque" HeaderText="Serie" 
                        SortExpression="numero_cheque" />
                    <asp:BoundField DataField="cod_banco_receptor" HeaderText="Recep" 
                        SortExpression="cod_banco_receptor" />
                    <asp:BoundField DataField="cod_camara" HeaderText="Camara" 
                        SortExpression="cod_camara" />
                    <asp:BoundField DataField="monto" DataFormatString="{0:N2}" 
                        HeaderText="Importe" SortExpression="monto" >
                    <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                    <asp:BoundField DataField="cod_sucursal" HeaderText="Sucursal" 
                        SortExpression="cod_sucursal" />
                    <asp:BoundField DataField="cabecera" HeaderText="Secuencia" 
                        SortExpression="cabecera" />
                    <asp:BoundField DataField="cod_moneda" HeaderText="Moneda" 
                        SortExpression="cod_moneda" />
                    <asp:BoundField DataField="cod_proceso" HeaderText="Proceso" 
                        SortExpression="cod_proceso" />
                    <asp:BoundField DataField="cuenta_deposito" HeaderText="Cta.Dep." 
                        SortExpression="cuenta_deposito" />
                    <asp:BoundField DataField="cod_maquina" HeaderText="Maquina" 
                        SortExpression="cod_maquina" />
                    <asp:BoundField DataField="IdMotivo" HeaderText="Mot.Rchz." 
                        SortExpression="IdMotivo" />
                </Columns>
			</asp:GridView>
		</div>
    </form>
</body>
</html>
