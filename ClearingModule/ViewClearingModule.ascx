<%@ Control language="vb" Inherits="Futura.Modules.ClearingModule.ViewClearingModule" AutoEventWireup="false" Explicit="True" Codebehind="ViewClearingModule.ascx.vb" %>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<asp:datalist id="lstContent" datakeyfield="ItemID" runat="server" cellpadding="4">
  <itemtemplate>
    <table cellpadding="4" width="100%">
      <tr>
        <td valign="top" width="100%" align="left">
          <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# EditURL("ItemID",DataBinder.Eval(Container.DataItem,"ItemID")) %>' Visible="<%# IsEditable %>" runat="server"><asp:Image ID="Image1" Runat=server ImageUrl="~/images/edit.gif" AlternateText="Edit" Visible="<%#IsEditable%>" resourcekey="Edit"/></asp:hyperlink>
          <asp:Label ID="lblContent" runat="server" CssClass="Normal"/>
        </td>
      </tr>
    </table>
  </itemtemplate>
</asp:datalist>
