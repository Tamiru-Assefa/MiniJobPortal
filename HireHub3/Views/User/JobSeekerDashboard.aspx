<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JobSeekerDashboard.aspx.cs" Inherits="HireHub3.Views.User.JobSeekerDashboard" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Job Dashboard</title>

    <script>
        
    window.history.forward();
    function noBack() {
        window.history.forward();
    }
</script>
    

    <style>
        body {
            font-family: Arial;
            background: #f4f6f9;
            margin: 0;
            padding: 20px;
        }

        .job-card {
            background: white;
            padding: 20px;
            margin-bottom: 20px;
            border-radius: 10px;
            box-shadow: 0 2px 8px rgba(0,0,0,0.1);
        }

        .job-title {
            font-size: 22px;
            color: #2c3e50;
            font-weight: bold;
        }

        .job-info {
            color: #555;
            margin: 5px 0;
        }

        .salary {
            color: green;
            font-weight: bold;
        }

        .apply-btn {
            background: #4a90e2;
            color: white;
            border: none;
            padding: 10px 18px;
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
 .msgsuc{
     color: green;
    
 }
 .msgerr{
     color: red;
 }

        
    </style>
</head>
<body onload="noBack();" onpageshow="if (event.persisted) noBack();">
    <form id="form2" runat="server">
     <!-- Navigation -->
<header>
    <nav class="navbar">
        <div class="logo">HireHub</div>

        <ul class="nav-links">
            <li><a href="#">Explore</a></li>
            <li><a href="Applied.aspx">Applied</a></li>
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
    
    <br />
    <h1>Available Jobs</h1>

        <asp:Label CssClass="msgsuc" ID="msgsuc" runat="server" />
        <asp:Label CssClass="msgerr" ID="msgerr" runat="server" />

    

        <asp:Repeater ID="rptJobs" runat="server">
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
                        <%# Eval("Description") %>
                    </div>

                    <div class="salary">
                        Salary: ETB <%# Eval("Salary") %>
                    </div><br />
                    <i>Cover Letter</i><br />
                    <asp:TextBox ID="txtcoverletter" runat="server"
                        TextMode="MultiLine"
                        Rows="5"
                        CssClass="input-box"
                        placeholder="I am Interested for this position ..." />

                    
                    <br />
                    <asp:Button 
                        ID="btnApply"
                        runat="server"
                        Text="Apply Now"
                        CssClass="apply-btn"
                        CommandArgument='<%# Eval("JobID") %>'
                        OnClick="apply_click"
                    />

                </div>

            </ItemTemplate>
        </asp:Repeater>

    </form>

</body>
</html>