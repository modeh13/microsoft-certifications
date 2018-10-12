<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UnderstadingPageEvents.aspx.vb" Inherits="Session4.UnderstadingPageEvents" %>
<%@ Register TagPrefix="uc" TagName="CustomTextBox" Src="~/UserControls/uc_CustomTextBox.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="utf-8" />
   <meta name="author" content="Germán A. Ramírez Vela" />
   <meta name="viewport" content="width=device-width, initial-scales=1.0" />
   <title>Understanding Page EVENTS</title>
</head>
<body>
   <form id="form1" runat="server">
      <div>
         <uc:CustomTextBox ID="uc_CustomTextBox" runat="server" LabelText="Name" TextBoxText="Your name here !!" />
      </div>
   </form>
</body>
</html>