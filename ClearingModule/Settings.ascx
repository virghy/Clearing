<%@ Control Language="vb" AutoEventWireup="false" Inherits="Futura.Modules.ClearingModule.Settings" Codebehind="Settings.ascx.vb" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<table cellspacing="0" cellpadding="2" border="0" summary="ClearingModule Settings Design Table">
    <tr>
        <td class="SubHead" width="150">TabId del Resultado</td>
        <td valign="bottom" >
            <asp:textbox id="txtTemplate" cssclass="NormalTextBox" maxlength="5" runat="server" />
        </td>
    </tr>
</table>
