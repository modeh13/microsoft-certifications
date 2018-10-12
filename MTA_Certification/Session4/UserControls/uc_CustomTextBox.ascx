<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="uc_CustomTextBox.ascx.vb" Inherits="Session4.uc_CustomTextBox" %>

<asp:Panel runat="server">
   <asp:Label runat="server"><%= LabelText %></asp:Label>
   <asp:TextBox runat="server" Text='<%# TextBoxText %>' />
</asp:Panel>