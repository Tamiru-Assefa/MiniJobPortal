<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewApplication.aspx.cs" Inherits="HireHub3.Views.Admin.ViewApplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <titleView Applications></titleView>
    <style>
    body {
        font-family: Arial;
        background: #f4f6f9;
        margin: 0;
        padding: 20px;
    }

    .page-title {
        text-align: center;
        font-size: 28px;
        font-weight: bold;
        color: #2c3e50;
        margin-bottom: 20px;
    }

    .job-card {
        background: white;
        padding: 20px;
        margin-bottom: 20px;
        border-radius: 10px;
        box-shadow: 0 2px 8px rgba(0,0,0,0.1);
        transition: 0.2s ease;
    }

    .job-card:hover {
        transform: translateY(-2px);
    }

    .job-title {
        font-size: 20px;
        font-weight: bold;
        color: #2c3e50;
        margin-bottom: 10px;
    }

    .job-info {
        color: #555;
        margin: 5px 0;
        font-size: 14px;
    }

    .status {
        margin-top: 10px;
        font-weight: bold;
        display: inline-block;
        padding: 5px 10px;
        border-radius: 5px;
    }

    .apply-btn {
        background: #4a90e2;
        color: white;
        border: none;
        padding: 8px 14px;
        border-radius: 5px;
        cursor: pointer;
        margin-right: 8px;
        margin-top: 10px;
    }

    .apply-btn:hover {
        background: #357ab8;
    }

    /* Reject button override */
    .reject-btn {
        background: #e74c3c !important;
    }

    .reject-btn:hover {
        background: #c0392b !important;
    }
            .navbar {
    background: #ffffff;
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 20px 60px;
    border-bottom: 1px solid #ddd;
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
</style>
</head>
<body>

                 
    <form id="form1" runat="server">
                            <header>
    <nav class="navbar">
        <div class="logo">HireHub</div>

        <ul class="nav-links">
            <li><a href="PostJob.aspx">Post Job</a></li>
            <li><a href="#">View Applicants</a></li>
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
        <asp:Repeater ID="rptApplicants" runat="server">
<ItemTemplate>

<div class="job-card">

    <div class="job-title">
        <%# Eval("FullName") %>
    </div>

    <div class="job-info">
        <%# Eval("Email") %> | <%# Eval("PhoneNumber") %>
    </div>

    <div class="job-info">
        <%# Eval("CoverLetter") %>
    </div>

    <div class="job-info">
        Status: <b><%# Eval("Status") %></b>
    </div>

    <!-- ACTION BUTTONS -->
    <asp:Button 
        runat="server"
        Text="Accept"
        CommandArgument='<%# Eval("ApplicationId") %>'
        OnClick="accept_click"
        CssClass="apply-btn" />

    <asp:Button 
        runat="server"
        Text="Reject"
        CommandArgument='<%# Eval("ApplicationId") %>'
        OnClick="reject_click"
        CssClass="apply-btn"
        Style="background:red;" />

</div>

</ItemTemplate>
</asp:Repeater>
    </form>
</body>
</html>
