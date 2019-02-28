<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login Page.aspx.cs" Inherits="LoginWeb.Login_Page" %>

<!DOCTYPE html>
<link href="Content/Site.css" rel="stylesheet" />

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div id="mainArea">
            <h2 id="ttl">Login Page</h2>
            <asp:textbox ID="usernametxt" class="inputz" placeholder="Username" runat="server"></asp:textbox> <br /><br />
            <asp:textbox ID="passwordtxt" class="inputz" placeholder="Password" runat="server" TextMode="Password" ></asp:textbox> <br /><br />
            <asp:Button  ID="LoginButton" class="buttonz" runat="server" Text="Log in" OnClick="LoginButton_Click"  /> 
        </div>
    </form>
</body>
</html>
