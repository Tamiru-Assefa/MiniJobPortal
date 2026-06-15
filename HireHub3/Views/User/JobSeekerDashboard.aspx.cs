using HireHub3.Controllers;
using HireHub3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HireHub3.Views.User
{
    public partial class JobSeekerDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["FullName"] == null)
            {
                Response.Redirect("../Public/Login.aspx");
            }
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1));
            Response.Cache.SetNoStore();
            if (!IsPostBack)
            {
                LoadJobs();
            }

        }
        private void LoadJobs()
        {
            JobFunction jf = new JobFunction();

            rptJobs.DataSource = jf.GetAllJobs();
            rptJobs.DataBind();
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
        protected void apply_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            RepeaterItem item = (RepeaterItem)btn.NamingContainer;

            // Find textbox inside this row
            TextBox txtcoverletter = (TextBox)item.FindControl("txtcoverletter");

            string coverLetter = txtcoverletter.Text;

            int jobId = Convert.ToInt32(btn.CommandArgument);

            int userId = Convert.ToInt32(Session["UserID"]);

            Applications a = new Applications();

            a.UserId = userId;
            a.JobId = jobId;
            a.CoveLetter = coverLetter;    
            a.Status = ApplicationStatus.Pending;

            try
            {
                ApplyFunction af = new ApplyFunction();

                af.ApplyJob(a);
                msgsuc.Text = "Submitted";
            }
            catch(Exception ex)
            {
                msgerr.Text = "You Already Applied!!" + "  " + ex.Message;
            }

            
        }

    }
}