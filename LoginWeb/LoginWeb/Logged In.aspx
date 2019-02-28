<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logged In.aspx.cs" Inherits="LoginWeb.Logged_In" %>

<!DOCTYPE html>
<link href="Content/Site.css" rel="stylesheet" />

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="s">
           <div id="a">
                 <asp:Label ID="loggedInUser" runat="server" Text="Label"></asp:Label>
          </div>
          <div id="d">
          
              <asp:Button ID="LogoutButton" runat="server" Text="log out" Height="120px" OnClick="LogoutButton_Click" Width="200px" />
            </div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
