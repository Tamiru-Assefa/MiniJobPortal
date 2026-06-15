using HireHub3.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HireHub3.Views.Admin
{
    public partial class ViewApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null || Session["Role"].ToString() != "Employer")
            {
                Response.Redirect("../Public/Login.aspx");
            }
            

            if (!IsPostBack)
            {
                LoadApplicants();
            }
        }

        private void LoadApplicants()
        {
            int jobId = Convert.ToInt32(Request.QueryString["jobId"]);

            ApplicantViewFunction af = new ApplicantViewFunction();

            rptApplicants.DataSource = af.GetApplicants(jobId);
            rptApplicants.DataBind();
        }

        protected void accept_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int appId = Convert.ToInt32(btn.CommandArgument);

            ApplicantViewFunction af = new ApplicantViewFunction();
            af.UpdateStatus(appId, "Accepted");

            LoadApplicants();
        }

        protected void reject_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int appId = Convert.ToInt32(btn.CommandArgument);

            ApplicantViewFunction af = new ApplicantViewFunction();
            af.UpdateStatus(appId, "Rejected");

            LoadApplicants();
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