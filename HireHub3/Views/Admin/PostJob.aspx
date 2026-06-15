<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostJob.aspx.cs" Inherits="HireHub3.Views.Admin.PostJob" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Post Job</title>
    <style>
        <style>
    body {
        font-family: Arial;
        background: #f4f6f9;
        padding: 20px;
    }

    .page-title {
        text-align: center;
        color: #2c3e50;
    }

    .input-box {
        width: 80%;
        padding: 10px;
        margin: 10px 0;
        border-radius: 5px;
        border: 1px solid #ccc;
        box-sizing: border-box;
        margin-left: 40px;
    }

    .apply-btn {
        background: #4a90e2;
        color: white;
        border: none;
        padding: 10px 20px;
        border-radius: 5px;
        cursor: pointer;
    }

    .apply-btn:hover {
        background: #357ab8;
    }
            .navbar {
    background: #ffffff;
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 20px 60px;
    border-bottom: 1px solid #ddd;
    margin-left: 20px;
}
    .logo {
    font-size: 28px;
    font-weight: bold;
    color: #2c3e50;
}

.nav-links {
    list-style: none;
    display: flex;
    gap: 25px;
}

.nav-links li a {
    text-decoration: none;
    color: #333;
    font-size: 16px;
}

.nav-links li a:hover {
    color: #007bff;
}
.suc{
    color: green;
}
.err{
    color: red;
}
</style>
    
</head>
<body>

    <form id="form1" runat="server">
                        <header>
    <nav class="navbar">
        <div class="logo">HireHub</div>

        <ul class="nav-links">
            <li><a href="#">Post Job</a></li>
            <li><a href="EmployerDashboard.aspx">View Applicants</a></li>
            <li>
                <asp:LinkButton 
                    ID="btnLogout" 
                    runat="server" 
                    OnClick="logout_click">
                    LogOut
                </asp:LinkButton>
            </li>
            
        </ul>
    </nav>
</header>
        <h1 class="page-title">Post a Job</h1>
        <asp:Label ID="SucMessage" runat="server" CssClass="suc" />
         <asp:Label ID="ErrMessage" runat="server" CssClass="err" /><br />

<asp:TextBox ID="txtTitle" runat="server" CssClass="input-box" placeholder="Job Title" />

<asp:TextBox ID="txtDescription" runat="server"
    TextMode="MultiLine"
    Rows="5"
    CssClass="input-box"
    placeholder="Job Description" />

<asp:TextBox ID="txtCategory" runat="server" CssClass="input-box" placeholder="Category" />

<asp:TextBox ID="txtLocation" runat="server" CssClass="input-box" placeholder="Location" />

<asp:TextBox ID="txtSalary" runat="server" CssClass="input-box" placeholder="Salary" />

<asp:DropDownList ID="ddlJobType" runat="server" CssClass="input-box">
    <asp:ListItem Text="Full-Time" Value="Full-Time" />
    <asp:ListItem Text="Part-Time" Value="Part-Time" />
    <asp:ListItem Text="Remote" Value="Remote" />
    <asp:ListItem Text="Contract" Value="Contract" />
</asp:DropDownList>
        <br /><br />

<asp:Button ID="btnPostJob"
    runat="server"
    Text="Post Job"
    CssClass="apply-btn"
    OnClick="btnPostJob_Click" />


    </form>
</body>
</html>
