<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LandingPage.aspx.cs" Inherits="HireHub3.Views.Public.LandingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Landing page</title>
    <style>
        
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        body {
            font-family: Arial, sans-serif;
            line-height: 1.6;
            background-color: #f8f9fa;
            color: #333;
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

        .signin-btn {
            background: #007bff;
            color: white !important;
            padding: 8px 16px;
            border-radius: 5px;
        }

        
        .hero {
            height: 80vh;
            display: flex;
            justify-content: center;
            align-items: center;
            text-align: center;
            padding: 20px;
            background: #eef4ff;
        }

        .hero-content {
            max-width: 700px;
        }

        .hero h1 {
            font-size: 48px;
            margin-bottom: 20px;
            color: #2c3e50;
        }

        .hero p {
            font-size: 18px;
            margin-bottom: 30px;
            color: #555;
        }

        
        .hero-buttons {
            display: flex;
            justify-content: center;
            gap: 15px;
        }

        .btn-primary,
        .btn-secondary {
            text-decoration: none;
            padding: 12px 25px;
            border-radius: 5px;
            font-size: 16px;
        }

        .btn-primary {
            background: #007bff;
            color: white;
        }

        .btn-secondary {
            background: #ddd;
            color: #333;
        }

        
        .section {
            padding: 60px 20px;
            text-align: center;
            background: white;
            margin-top: 10px;
        }

        .section h2 {
            font-size: 32px;
            margin-bottom: 20px;
        }

        .section p {
            max-width: 700px;
            margin: auto;
            color: #555;
        }

        
        footer {
            background: #2c3e50;
            color: white;
            text-align: center;
            padding: 20px;
        }

        .role-container{
            display:flex;
            justify-content:center;
            gap:20px;
            margin-top:80px;
            font-family:Arial;
        }

        .role-card{
            width:300px;
            background:white;
            border-radius:10px;
            box-shadow:0 2px 10px rgba(0,0,0,0.1);
            text-align:center;
            padding:20px;
            transition:0.3s;
        }

        .role-card:hover{
            transform:translateY(-5px);
        }

        .role-card img{
            width:100px;
            height:100px;
            object-fit:cover;
            margin-bottom:10px;
        }

        .role-card h2{
            margin:10px 0;
            font-size:18px;
            color:#333;
        }

        .role-card a{
            padding:8px 15px;
            border:none;
            border-radius:5px;
            cursor:pointer;
            background:#4a90e2;
            color:white;
            text-decoration: none;
        }

        .role-card a:hover{
            background:#357ab8;
        }
    </style>
</head>
<body>
    

    <form id="form1" runat="server">

        <!-- Navigation -->
        <header>
            <nav class="navbar">
                <div class="logo">HireHub</div>

                <ul class="nav-links">
                    <li><a href="#about">About</a></li>
                    <li><a href="#contact">Contact</a></li>
                    <li><a href="#explore">Explore</a></li>
                    
                </ul>
            </nav>
        </header>

        <!-- Hero Section -->
        <section class="hero">
            <div class="hero-content">
                <h1>Welcome to HireHub</h1>
                <p>
                    Connecting job seekers with employers in one simple platform.
                    Build your portfolio, apply for jobs, and hire top talent easily.
                </p>

                <div class="hero-buttons">
                    <a href="#log" class="btn-primary">Get Started</a>
                    <a href="#about" class="btn-secondary">Learn More</a>
                </div>
            </div>
        </section>

        <section class="role-container" id="log">

            <div class="role-card">
                <img src="https://cdn-icons-png.flaticon.com/512/3062/3062634.png" alt="Company"/>
                <h2>Company</h2>
                <a href="../Admin/RegisterEmployer.aspx">Register as Company</a>
                
            </div>

            <div class="role-card" id="explore">
                <img src="https://cdn-icons-png.flaticon.com/512/3135/3135715.png" alt="Job Seeker"/>
                <h2>Job Seeker</h2>
                <a href="../User/RegisterUser.aspx">Register as Seeker</a>
            </div>

        </section>

        <!-- About Section -->
        <section id="about" class="section">
            <h2>About HireHub</h2>
            <p>
                HireHub is a simple job portal where job seekers can create profiles,
                apply for jobs, and employers can post vacancies and manage applicants.
            </p>
        </section>

        <!-- Contact Section -->
        <section id="contact" class="section">
            <h2>Contact Us</h2>
            <p>Email: support@hirehub.com</p>
            <p>Phone: +251 900 000 000</p>
        </section>

        <!-- Footer -->
        <footer>
            <p>&copy; 2026 HireHub. All Rights Reserved.</p>
        </footer>

    </form>


</body>
</html>
