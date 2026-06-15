using HireHub3.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HireHub3.Views.User
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("../Public/Login.aspx");
            }

            if (!IsPostBack)
            {
                LoadAppliedJobs();
            }

        }
        private void LoadAppliedJobs()
        {
            int userId = Convert.ToInt32(Session["UserID"]);

            AppliedFunction af = new AppliedFunction();

            rptApplied.DataSource = af.GetAppliedJobs(userId);
            rptApplied.DataBind();
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