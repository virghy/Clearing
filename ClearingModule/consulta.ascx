<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="consulta.ascx.vb" Inherits="Futura.Modules.ClearingModule.consulta" %>
    <div>
    
    	<table cellpadding="0" Class="Normal" cellspacing="0" style="width: 100%">
			<tr>
				<td>Fecha</td>
				<td>
				<asp:TextBox id="txtFecha" CssClass="Normal" runat="server"></asp:TextBox>
				&nbsp;</td>
				<td>
				<asp:CheckBox id="CheckBox1" CssClass="Normal" runat="server" Text="Sin Filtro de Fecha" />
				&nbsp;</td>
			</tr>
			<tr>
				<td>Numero</td>
				<td>
				<asp:TextBox id="txtNumero" CssClass="Normal" runat="server"></asp:TextBox>
				&nbsp;</td>
				<td>&nbsp;</td>
			</tr>
			<tr>
				<td>Cuenta</td>
				<td>
				<asp:TextBox id="txtCuenta" CssClass="Normal" runat="server"></asp:TextBox>
				&nbsp;</td>
				<td>&nbsp;</td>
			</tr>
			<tr>
				<td>&nbsp;</td>
				<td>
				<asp:Button id="Button1" CssClass="Normal" runat="server" Text="Buscar" />
				&nbsp;</td>
				<td>&nbsp;</td>
			</tr>
		</table>
    
    </div>
    	<div>
			<asp:GridView id="GridView1" runat="server" CssClass="Normal" AutoGenerateColumns="False" 
                DataKeyNames="IdLectura">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:HyperLink ID="HyperLink1" runat="server" 
                                NavigateUrl='<%# FormatURL(Eval("IdLectura")) %>' Text="Detalle"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
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
