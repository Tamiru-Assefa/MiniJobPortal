using HireHub3.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HireHub3.Controllers
{
    public class AppliedFunction
    {
        string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MiniJobPortal;Integrated Security=True";

        public List<AppliedJobView> GetAppliedJobs(int userId)
        {
            List<AppliedJobView> list = new List<AppliedJobView>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"
                    SELECT 
                        a.ApplicationID,
                        a.JobID,
                        j.Title,
                        j.Category,
                        j.Location,
                        j.Salary,
                        j.JobType,
                        a.Status,
                        a.AppliedDate
                    FROM Applications a
                    INNER JOIN Jobs j ON a.JobID = j.JobID
                    WHERE a.UserID = @UserID
                    ORDER BY a.AppliedDate DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", userId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    AppliedJobView app = new AppliedJobView();

                    app.ApplicationId = Convert.ToInt32(reader["ApplicationID"]);
                    app.JobId = Convert.ToInt32(reader["JobID"]);
                    app.Title = reader["Title"].ToString();
                    app.Category = reader["Category"].ToString();
                    app.Location = reader["Location"].ToString();
                    app.Salary = Convert.ToDecimal(reader["Salary"]);
                    app.JobType = reader["JobType"].ToString();
                    app.Status = reader["Status"].ToString();
                    app.AppliedDate = Convert.ToDateTime(reader["AppliedDate"]);

                    list.Add(app);
                }
            }

            return list;
        }
    }
}