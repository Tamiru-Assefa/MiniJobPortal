<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HireHub3.Views.Public.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LogIn</title>
    <style>
        
    body{
         font-family: Arial;
         background-color: #f4f6f9;
         display: flex;
         justify-content: center;
         align-items: center;
         height: 100vh;
         margin: 0;
         flex-direction: column;
    }

    .login{
        background: white;
        padding: 20px;
        width: 300px;
        border-radius: 8px;
        box-shadow: 0 2px 10px rgba(0,0,0,0.1);
       
        
    }

    .login input{
        width: 100%;
        padding: 8px;
        margin: 6px 0;
        border: 1px solid #ccc;
        border-radius: 5px;
    }

    .login input:hover{
        border-color: #888;
    }

    .login input[type="submit"]{
        background: #4a90e2;
        color: white;
        border: none;
        cursor: pointer;
    }

    .login input[type="submit"]:hover{
        background: #357ab8;
    }

    .error{
        color: red;
        display: block;
        margin-bottom: 10px;
    }
</style>
    
</head>
<body>
    <h1 style="text-align:center; ">Login Page</h1>
    
    
    <form id="form1" runat="server">
        <div class="login">
            <asp:Label CssClass="error" ID="error" runat="server"/> <br />
            <asp:Label Text="Email" runat="server"/>
            <asp:TextBox ID="txtemail" runat="server" /> <br /><br />
            <asp:Label Text="Password" runat="server"/>
            <asp:TextBox ID="txtpassword"  runat="server" TextMode="password" /> <br />
            <asp:Button text="Login" OnClick="login_click"  runat="server" /> <br /> <br />
            Don't Have Account? <a href="../Public/LandingPage.aspx#explore" >Register</a>

            
        </div>
    </form>
       
  
</body>
</html>
