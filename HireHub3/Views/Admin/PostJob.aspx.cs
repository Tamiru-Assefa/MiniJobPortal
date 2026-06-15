using HireHub3.Controllers;
using HireHub3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HireHub3.Views.Admin
{
    public partial class PostJob : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["FullName"] == null)
            {
                Response.Redirect("../Public/Login.aspx");
            }

            if (Session["Role"].ToString() != "Employer")
            {
                Response.Redirect("../Public/Login.aspx");
            }
        }

        protected void btnPostJob_Click(object sender, EventArgs e)
        {
            Jobs job = new Jobs();

            job.EmployerID = Convert.ToInt32(Session["UserID"]);
            job.Title = txtTitle.Text;
            job.Description = txtDescription.Text;
            job.Category = txtCategory.Text;
            job.Location = txtLocation.Text;
            job.Salary = Convert.ToDecimal(txtSalary.Text);
            job.JobType = ddlJobType.SelectedValue;
            job.PostedDate = DateTime.Now;
            try
            {
                JobPostFunction jp = new JobPostFunction();
                jp.PostJob(job);
                SucMessage.Text = "Job posted successfully!";
            }
            catch(Exception ex)
            {
                ErrMessage.Text = "Some Thing Problem  " + ex.Message;
            }
            

           

            // clear form
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtCategory.Text = "";
            txtLocation.Text = "";
            txtSalary.Text = "";
        }

        protected void logout_click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();

            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();
            Response.Cache.SetExpires(DateTime.UtcNow.AddDays(-1));

            Response.Redirect("../Public/Login.aspx", false);
            Context.ApplicationInstance.CompleteRequest();

        }
    }
}