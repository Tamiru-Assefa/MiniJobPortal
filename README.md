# HireHub - Mini Job Portal System

## 📌 Project Overview

**HireHub** is a web-based Mini Job Portal System developed using **ASP.NET Web Forms**, **C#**, and **SQL Server**. The platform connects **Job Seekers** and **Employers** through a centralized recruitment portal where employers can post job vacancies and job seekers can apply for jobs online.

The system replaces traditional manual recruitment processes with a simple digital solution that improves efficiency, accessibility, and application management.

---

## 🚀 Features

### 👨‍💼 Job Seeker Features

* User Registration
* Secure Login
* Profile Creation
* View Available Jobs
* Apply for Jobs
* Submit Cover Letters

### 🏢 Employer Features

* Employer Registration
* Secure Login
* Post Job Vacancies
* Manage Job Listings
* View Applicants

### ⚙️ System Features

* Role-Based Authentication
* Database-Driven Operations
* Job Application Management
* Secure Data Storage
* CRUD Functionality

---

## 🛠️ Technologies Used

| Technology        | Purpose                     |
| ----------------- | --------------------------- |
| ASP.NET Web Forms | Web Application Development |
| C#                | Server-Side Programming     |
| SQL Server        | Database Management         |
| ADO.NET           | Database Connectivity       |
| HTML              | Structure                   |
| CSS               | Styling                     |
| Visual Studio     | Development Environment     |

---

## 🏗️ System Architecture

The project follows a simple layered architecture inspired by the MVC pattern.

### 1. Presentation Layer

Handles user interface and user interactions.

Examples:

* Login.aspx
* RegisterUser.aspx
* RegisterEmployer.aspx
* Dashboard.aspx

### 2. Business Logic Layer

Handles application logic and validations.

Examples:

* UserFunction.cs
* EmpRegisterFunction.cs
* JobFunction.cs

Responsibilities:

* Registration Processing
* Login Validation
* Job Management
* Data Retrieval

### 3. Data Access Layer

Handles communication with SQL Server using ADO.NET.

Components:

* SqlConnection
* SqlCommand
* SqlDataReader

---

## 🗄️ Database Design

### Database Name

```sql
MiniJobPortal
```

### Tables

#### Users

Stores both Job Seekers and Employers.

| Column             |
| ------------------ |
| UserID             |
| FullName           |
| Email              |
| PasswordHash       |
| PhoneNumber        |
| Role               |
| Bio                |
| Skills             |
| ExperienceYears    |
| CompanyName        |
| CompanyDescription |
| CreatedDate        |

---

#### Jobs

Stores all job postings.

| Column      |
| ----------- |
| JobID       |
| EmployerID  |
| Title       |
| Description |
| Category    |
| Location    |
| Salary      |
| JobType     |
| PostedDate  |

---

#### Applications

Stores job applications.

| Column        |
| ------------- |
| ApplicationID |
| UserID        |
| JobID         |
| CoverLetter   |
| AppliedDate   |
| Status        |

---

## 🔗 Entity Relationships

### One-to-Many Relationships

* One Employer ➜ Many Jobs
* One Job Seeker ➜ Many Applications
* One Job ➜ Many Applications

---

## 📋 Functional Requirements

### User Registration

* Job Seeker Registration
* Employer Registration

### Authentication

* Secure Login
* Role-Based Redirection

### Job Management

* Create Jobs
* View Jobs
* Apply for Jobs

### Application Management

* Submit Applications
* View Applicants

---

## ⚡ Non-Functional Requirements

* User-Friendly Interface
* Fast Response Time
* Database Reliability
* Maintainable Code Structure
* Secure Password Handling

---

## 📂 Project Structure

```text
HireHub/
│
├── Pages/
│   ├── Login.aspx
│   ├── RegisterUser.aspx
│   ├── RegisterEmployer.aspx
│   ├── Dashboard.aspx
│
├── BusinessLogic/
│   ├── UserFunction.cs
│   ├── EmpRegisterFunction.cs
│   ├── JobFunction.cs
│
├── Database/
│   ├── SQL Scripts
│
├── CSS/
│   ├── styles.css
│
└── Web.config
```

---

## ▶️ Installation Guide

### Prerequisites

* Visual Studio 2022 (or later)
* SQL Server
* .NET Framework
* IIS Express

### Steps

1. Clone the repository:

```bash
git clone https://github.com/yourusername/HireHub.git
```

2. Open the project in Visual Studio.

3. Create the database:

```sql
CREATE DATABASE MiniJobPortal;
```

4. Execute the provided SQL scripts to create tables.

5. Update the connection string in:

```xml
Web.config
```

Example:

```xml
<connectionStrings>
    <add name="DBConnection"
         connectionString="Data Source=YOUR_SERVER;
                           Initial Catalog=MiniJobPortal;
                           Integrated Security=True"/>
</connectionStrings>
```

6. Run the project using IIS Express.

---

## 📸 System Workflow

### Job Seeker

1. Register Account
2. Login
3. View Jobs
4. Apply for Jobs

### Employer

1. Register Company Account
2. Login
3. Post Jobs
4. Review Applications

---

## 🚧 Challenges Faced

* Implementing Role-Based Authentication
* Managing Nullable Fields in a Single Users Table
* Handling SQL Server Foreign Key Constraints
* Organizing MVC-Style Structure in ASP.NET Web Forms

---

## 🔮 Future Enhancements

* Resume Upload Feature
* Email Notifications
* Job Search & Filtering
* Profile Picture Uploads
* Admin Dashboard
* Enhanced Password Hashing
* Real-Time Messaging System

---

## 🎯 Learning Outcomes

This project demonstrates:

* ASP.NET Web Forms Development
* SQL Server Database Design
* ADO.NET Connectivity
* CRUD Operations
* Authentication & Authorization
* Layered Software Architecture

---

## 👨‍💻 Author

**Tamiru Assefa Welekbea**

* AWS Certified Solutions Architect
* Computer Science Student
* Cloud & Software Development Enthusiast

---

## 📄 License

This project is developed for educational purposes and academic learning.
