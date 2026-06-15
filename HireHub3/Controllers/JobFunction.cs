using HireHub3.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HireHub3.Controllers
{
    public class JobFunction
    {
        string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MiniJobPortal;Integrated Security=True";

        public List<Jobs> GetAllJobs()
        {
            List<Jobs> jobs = new List<Jobs>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT * FROM Jobs ORDER BY PostedDate DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Jobs job = new Jobs();

                    job.JobID = Convert.ToInt32(reader["JobID"]);
                    job.EmployerID = Convert.ToInt32(reader["EmployerID"]);
                    job.Title = reader["Title"].ToString();
                    job.Description = reader["Description"].ToString();
                    job.Category = reader["Category"].ToString();
                    job.Location = reader["Location"].ToString();
                    job.Salary = Convert.ToDecimal(reader["Salary"]);
                    job.JobType = reader["JobType"].ToString();
                    job.PostedDate = Convert.ToDateTime(reader["PostedDate"]);

                    jobs.Add(job);
                }
            }

            return jobs;
        }
    }
}