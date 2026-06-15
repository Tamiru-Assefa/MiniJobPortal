using HireHub3.Controllers;
using HireHub3.Models;
using System;
using System.Web.UI;

namespace HireHub3.Views.Public
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_click(object sender, EventArgs e)
        {
            Users u = new Users();

            u.Email = txtemail.Text;
            u.PasswordHash = txtpassword.Text;   // entered plain password

            UserFunctions uf = new UserFunctions();

            Users loggedUser = uf.LoginUser(u);

            if (loggedUser != null)
            {
                Session["UserID"] = loggedUser.UserID;
                Session["FullName"] = loggedUser.FullName;
                Session["Role"] = loggedUser.Role;

                if (loggedUser.Role == "Employer")
                {
                    Response.Redirect("../Admin/EmployerDashboard.aspx");
                }
                else if (loggedUser.Role == "JobSeeker")
                {
                    Response.Redirect("../User/JobSeekerDashboard.aspx");
                }
            }
            else
            {
                error.Text = "Invalid Email or Password";
            }
        }
    }
}

//using HireHub3.Controllers;
//using HireHub3.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;

//namespace HireHub3.Views.Public
//{
//    public partial class Login : System.Web.UI.Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {

//        }
//        protected void login_click(object sender, EventArgs e)
//        {
//            Users u = new Users();

//            u.Email = txtemail.Text;
//            u.PasswordHash = txtpassword.Text;

//            UserFunctions uf = new UserFunctions();

//            Users loggedUser = uf.LoginUser(u);

//            if (loggedUser != null)
//            {
//                // store in session
//                Session["UserID"] = loggedUser.UserID;
//                Session["FullName"] = loggedUser.FullName;
//                Session["Role"] = loggedUser.Role;

//                if (loggedUser.Role == "Employer")
//                {
//                    Response.Redirect("../Admin/EmployerDashboard.aspx");
//                }
//                else if (loggedUser.Role == "JobSeeker")
//                {
//                    Response.Redirect("../User/JobSeekerDashboard.aspx");
//                }
//            }
//            else
//            {
//                error.Text = "Invalid Email or Password";
//            }




//        }
//    }
//}