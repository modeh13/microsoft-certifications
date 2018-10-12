<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Register.aspx.vb" Inherits="Session4.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="utf-8" />
   <meta name="author" content="Germán A. Ramírez" />
   <meta name="viewport" content="width=width-device, initial-scale=1.0" />
   <title>Working with Session state</title>
</head>
<body>
   <form id="form1" runat="server">
      <div>
         <asp:Label runat="server" Text='<%# String.Format("Session initialized: {0}", IIf(IsNothing(Application("session_count")), 0, Application("session_count")))  %>' />
         <asp:TextBox ID="txtName" runat="server" Text="" placeholder="-- Name --" />
         <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
      </div>
   </form>
</body>
</html>