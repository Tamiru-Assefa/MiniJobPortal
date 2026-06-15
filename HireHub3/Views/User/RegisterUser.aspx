<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterUser.aspx.cs" Inherits="HireHub3.Views.User.RegisterUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>

    <style>
        body {
            font-family: 'Segoe UI', Arial, sans-serif;
            background: linear-gradient(135deg, #e3f2fd, #f4f6f9);
            margin: 0;
            padding: 40px 0;

            display: flex;
            flex-direction: column;
            align-items: center;

            min-height: 100vh;
        }

        h1 {
            color: #2c3e50;
            margin-bottom: 5px;
        }

        h2 {
            color: #7f8c8d;
            font-weight: normal;
            margin-bottom: 20px;
        }

        .register {
            background: white;
            padding: 30px;
            width: 520px;
            border-radius: 12px;
            box-shadow: 0 10px 30px rgba(0,0,0,0.1);
        }

        .form-group {
            margin-bottom: 12px;
        }

        .register label {
            font-weight: 600;
            font-size: 13px;
            color: #34495e;
        }

        .register input,
        .register textarea {
            width: 100%;
            padding: 10px;
            margin-top: 5px;
            border: 1px solid #ddd;
            border-radius: 6px;
            font-size: 14px;
            transition: 0.3s;
        }

        .register input:focus,
        .register textarea:focus {
            border-color: #4a90e2;
            outline: none;
            box-shadow: 0 0 5px rgba(74,144,226,0.3);
        }

        .register input[type="submit"] {
            background: #4a90e2;
            color: white;
            border: none;
            cursor: pointer;
            font-weight: bold;
            padding: 12px;
            border-radius: 6px;
            transition: 0.3s;
            width: 100%;
        }

        .register input[type="submit"]:hover {
            background: #357ab8;
            transform: scale(1.02);
        }

        .error {
            color: red;
            font-size: 13px;
            margin-bottom: 10px;
            display: block;
        }

        a {
            color: #4a90e2;
            text-decoration: none;
        }

        a:hover {
            text-decoration: underline;
        }
    </style>
</head>

<body>

    <h1>HireHub</h1>
    <h2>Complete your profile</h2>

    <form id="form2" runat="server">

        <div class="register">

            <asp:Label CssClass="error" ID="error" runat="server" />

            <div class="form-group">
                <asp:Label Text="Full Name" runat="server" />
                <asp:TextBox ID="txtfname" runat="server" placeholder="Enter full name" />
            </div>

            <div class="form-group">
                <asp:Label Text="Email" runat="server" />
                <asp:TextBox ID="txtemail" runat="server" TextMode="Email" placeholder="example@email.com" />
            </div>

            <div class="form-group">
                <asp:Label Text="Phone Number" runat="server" />
                <asp:TextBox ID="txtphone" runat="server" TextMode="Phone" placeholder="09xxxxxxxx" />
            </div>

            <div class="form-group">
                <asp:Label Text="Bio" runat="server" />
                <asp:TextBox 
                    ID="txtbio" 
                    runat="server" 
                    TextMode="MultiLine" 
                    Rows="4"
                    placeholder="Write something about yourself..." />
            </div>

            <div class="form-group">
                <asp:Label Text="Skills (comma separated)" runat="server" />
                <asp:TextBox 
                    ID="txtskill" 
                    runat="server"
                    placeholder="C#, ASP.NET, SQL, JavaScript" />
            </div>

            <div class="form-group">
                <asp:Label Text="Experience (Years)" runat="server" />
                <asp:TextBox ID="txtexperiance" runat="server" TextMode="Number" placeholder="e.g. 2" />
            </div>

            <div class="form-group">
                <asp:Label Text="Password" runat="server" />
                <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" />
            </div>

            <div class="form-group">
                <asp:Label Text="Confirm Password" runat="server" />
                <asp:TextBox ID="txtpasspassword2" runat="server" TextMode="Password" />
            </div>

            <asp:Button Text="Register" OnClick="userregister_click" runat="server" />

            <p style="text-align:center; margin-top:15px;">
                Already have an account?
                <a href="../Public/Login.aspx">Login</a>
            </p>

        </div>

    </form>

</body>
</html>