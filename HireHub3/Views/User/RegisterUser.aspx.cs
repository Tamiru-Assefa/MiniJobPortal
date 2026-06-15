using HireHub3.Controllers;
using HireHub3.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HireHub3.Views.User
{
    public partial class RegisterUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void userregister_click(object sender, EventArgs e)
        {
            string password1 = txtpassword.Text;
            string password2 = txtpasspassword2.Text;

            if(password1 != password2)
            {
                 error.Text = ("Password didn't match");
                return;
            }

            Users u = new Users();
            u.FullName = txtfname.Text;
            u.Email = txtemail.Text;
           // u.PasswordHash = txtpassword.Text;
            u.PasswordHash = BCrypt.Net.BCrypt.HashPassword(password1);
            u.PhoneNumber = txtphone.Text;
            u.Bio=txtbio.Text;
            u.Skills = txtskill.Text;
            u.ExperienceYears = Convert.ToInt32(txtexperiance.Text);

            try
            {
                UserRegisterFunction reg = new UserRegisterFunction();
                reg.RegisterUser(u);

                Response.Redirect("../Public/login.aspx");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    error.Text = "This email address is already registered. Please try logging in.";
                }
                else
                {

                    error.Text = "A database error occurred: " + ex.Message;
                }
            }


        }
    }
}