using HireHub3.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HireHub3.Controllers
{
    public class JobPostFunction
    {
        public void PostJob(Jobs job)
        {
            string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MiniJobPortal;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Jobs
                        (EmployerID, Title, Description, Category, Location,
                         Salary, JobType, PostedDate)
                         VALUES
                        (@EmployerID, @Title, @Description, @Category, @Location,
                         @Salary, @JobType, @PostedDate)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@EmployerID", job.EmployerID);
                cmd.Parameters.AddWithValue("@Title", job.Title);
                cmd.Parameters.AddWithValue("@Description", job.Description);
                cmd.Parameters.AddWithValue("@Category", job.Category);
                cmd.Parameters.AddWithValue("@Location", job.Location);
                cmd.Parameters.AddWithValue("@Salary", job.Salary);
                cmd.Parameters.AddWithValue("@JobType", job.JobType);
                cmd.Parameters.AddWithValue("@PostedDate", job.PostedDate);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}