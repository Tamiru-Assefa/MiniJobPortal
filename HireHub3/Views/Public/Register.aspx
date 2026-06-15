<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="HireHub3.Views.Public.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
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

.register{
    background: white;
    padding: 20px;
    width: 300px;
    border-radius: 8px;
    box-shadow: 0 2px 10px rgba(0,0,0,0.1);
    
}

.register input{
    width: 100%;
    padding: 8px;
    margin: 6px 0;
    border: 1px solid #ccc;
    border-radius: 5px;
}

.register input:hover{
    border-color: #888;
}

.register input[type="submit"]{
    background: #4a90e2;
    color: white;
    border: none;
    cursor: pointer;
}

.register input[type="submit"]:hover{
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
    <h1 style="text-align:center; margin:0 0 20px 0;">
    Registration Page
</h1>
    <form id="form2" runat="server">
    <div class="register">
        <asp:Label CssClass="error" ID="error" runat="server"/> <br />
        <asp:Label Text="Full Name" runat="server"/>
        <asp:TextBox ID="txtfname" runat="server" /> <br />
        <asp:Label Text="Email" runat="server"  TextMode="Email"/>
        <asp:TextBox ID="txtemail"  runat="server"  /> <br />
        <asp:Label Text="PassWord" runat="server"/>
        <asp:TextBox ID="txtpassword"  runat="server"  TextMode="Password" /> <br />
        <asp:Button text="Register" OnClick="register_click"  runat="server" /> <br /> <br />
        Already Have Account? <a href="Login.aspx" >Login</a>

        
    </div>
</form>
    
</body>
</html>
