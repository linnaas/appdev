<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loggedin.aspx.cs" Inherits="loginNNN.loggedin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome!</title>
    <style>
        #d{
            position: relative;
            padding: 10px;
           
            text-align: center;
            border-radius: 5px 5px;
            right: 0px;
            top: 25%;  
            height: 200px;
        }
        #a{
            position: relative;
            top: 10%;
            border-radius: 5px 5px;
            color:darkgreen;
            text-align: center;
           
            right: 0px;
            font-size:xx-large;
        }
        #s{
            position: relative;
            padding: 10px;
            background-color: darkgrey;
            width: 280px;
            text-align: center;
            border-radius: 5px 5px;
            left: 40%;
            margin-top: 10%;  
            height: 300px;
        }
    </style>
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
