<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployerDashboard.aspx.cs" Inherits="HireHub3.Views.Admin.EmployerDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Company DashBoard</title>
    <style>
        .job-card {
    background: white;
    padding: 20px;
    margin: 15px;
    border-radius: 10px;
    box-shadow: 0 2px 8px rgba(0,0,0,0.1);
}

.job-title {
    font-size: 20px;
    font-weight: bold;
}

.job-info {
    color: #555;
    margin: 5px 0;
}

        .apply-btn {
            display: inline-block;
            margin-top: 10px;
            padding: 8px 12px;
            background: #4a90e2;
            color: white;
            border-radius: 5px;
            text-decoration: none;
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
        <asp:Repeater ID="rptEmployerJobs" runat="server">
    <ItemTemplate>

        <div class="job-card">

            <div class="job-title">
                <%# Eval("Title") %>
            </div>

            <div class="job-info">
                <%# Eval("Category") %> | <%# Eval("Location") %>
            </div>

            <div class="job-info">
                Applicants:
                <b><%# Eval("ApplicantCount") %></b>
            </div>

            <asp:LinkButton 
                runat="server"
                Text="View Applicants"
                CssClass="apply-btn"
                PostBackUrl='<%# "ViewApplication.aspx?jobId=" + Eval("JobID") %>' /> 

        </div>

    </ItemTemplate>
</asp:Repeater>
    </form>
</body>
</html>
