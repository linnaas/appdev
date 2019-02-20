<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="loginNNN.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title>Login page</title>  
    <style>
       
        #mainArea{
            position: relative;
            padding: 10px;
            background-color: grey;
            width: 200px;
            text-align: center;
            border-radius: 5px 5px;
            left: 40%;
            margin-top: 10%;  
            height: 200px;
        }
        #ttl{
            font-weight: bold;
            font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
        }
        
    </style>
</head>

<body>
    
   
    <form id="form1" runat="server"> 
        <div id="mainArea">
            <h2 id="ttl">Login Page</h2>
            <asp:textbox ID="usernametxt" class="inputz" placeholder="Username" runat="server"></asp:textbox> <br /><br />
            <asp:textbox ID="passwordtxt" class="inputz" placeholder="Password" runat="server" TextMode="Password"></asp:textbox> <br /><br />
            <asp:Button  ID="LoginButton" class="buttonz" runat="server" Text="Log in" OnClick="LoginButton_Click" /> 
        </div>
    </form>
    

    


</body>
</html>