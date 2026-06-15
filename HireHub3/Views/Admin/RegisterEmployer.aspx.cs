using HireHub3.Controllers;
using HireHub3.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HireHub3.Views.Admin
{
    public partial class RegisterEmployer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void companyregister_click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.CompanyName = txtcname.Text;
            u.Email = txtemail.Text;
            //u.PasswordHash = txtpassword.Text;
            u.PasswordHash = BCrypt.Net.BCrypt.HashPassword(txtpassword.Text);
            u.PhoneNumber = txtphone.Text;
            u.CompanyDescription = txtCompanyDesc.Text;

            try
            {
                EmpRegisterFunction reg = new EmpRegisterFunction();
                reg.RegisterCompany(u);

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
            


            //error.Text = ("Invalid Email/Password");


        }
    }
}