<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Applied.aspx.cs" Inherits="HireHub3.Views.User.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Applied</title>
        <script>
        
    window.history.forward();
    function noBack() {
        window.history.forward();
    }
</script>
    <style>
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
        font-size: 22px;
        color: #2c3e50;
        font-weight: bold;
        margin-bottom: 10px;
    }

    .job-info {
        color: #555;
        margin: 5px 0;
        font-size: 14px;
    }

    .salary {
        color: green;
        font-weight: bold;
        margin-top: 10px;
    }

    /* STATUS COLORS */
    .status {
        margin-top: 10px;
        font-weight: bold;
        padding: 5px 10px;
        display: inline-block;
        border-radius: 5px;
        font-size: 13px;
    }

    .pending {
        background: #fff3cd;
        color: #856404;
    }

    .accepted {
        background: #d4edda;
        color: #155724;
    }

    .rejected {
        background: #f8d7da;
        color: #721c24;
    }
    #stat{
        background-color: springgreen;
        padding: 10px;
        width:8%;
        border-radius:20px;
    }
    </style>
</head>
<body onload="noBack();" onpageshow="if (event.persisted) noBack();">
    <form id="form1" runat="server">
        <header>
    <nav class="navbar">
        <div class="logo">HireHub</div>

        <ul class="nav-links">
            <li><a href="JobSeekerDashboard.aspx">Explore</a></li>
            <li><a href="#">Applied</a></li>
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
    </form>
    <asp:Repeater ID="rptApplied" runat="server">
    <ItemTemplate>

        <div class="job-card">

            <div class="job-title">
                <%# Eval("Title") %>
            </div>

            <div class="job-info">
                <b>Category:</b> <%# Eval("Category") %>
            </div>

            <div class="job-info">
                <b>Location:</b> <%# Eval("Location") %>
            </div>

            <div class="job-info">
                <b>Job Type:</b> <%# Eval("JobType") %>
            </div>

            <div class="job-info">
                <b>Applied Date:</b> <%# Eval("AppliedDate") %>
            </div>

            <div class="job-info" id="stat">
                <b>Status:</b> <%# Eval("Status") %>
            </div>

            <div class="salary">
                Salary: ETB <%# Eval("Salary") %>
            </div>

        </div>

    </ItemTemplate>
</asp:Repeater>
</body>
</html>
