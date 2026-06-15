using HireHub3.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HireHub3.Views.Admin
{
    public partial class EmployerDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["FullName"] == null)
            {
                Response.Redirect("../Public/Login.aspx");
            }

            if (!IsPostBack)
            {
                LoadEmployerJobs();
            }
        }

        private void LoadEmployerJobs()
        {
            int employerId = Convert.ToInt32(Session["UserID"]);

            EmployerFunction ef = new EmployerFunction();

            rptEmployerJobs.DataSource = ef.GetEmployerJobs(employerId);
            rptEmployerJobs.DataBind();
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