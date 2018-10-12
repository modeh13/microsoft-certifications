<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Session4.Defaul" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="utf-8" />
   <meta name="author" content="Germán A. Ramírez" />
   <meta name="viewport" content="width=width-device, initial-scale=1.0" />
   <title>Default Page</title>
</head>
<body>
   <form id="form1" runat="server">
      <div>
         <asp:Label ID="lblUserName" runat="server" /><br />
         <asp:Button ID="btnClearSession" runat="server" Text="Clear session" OnClick="btnClearSession_Click" />
      </div>
   </form>
</body>
</html>