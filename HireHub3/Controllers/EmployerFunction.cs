using HireHub3.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HireHub3.Controllers
{
    public class EmployerFunction
    {
        string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MiniJobPortal;Integrated Security=True";
        public List<EmployerJobView> GetEmployerJobs(int employerId)
        {
            List<EmployerJobView> list = new List<EmployerJobView>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                
                string query = @"SELECT j.JobID, j.Title, j.Category, j.Location, j.JobType,
                                COUNT(a.ApplicationID) AS ApplicantCount
                         FROM Jobs j
                         LEFT JOIN Applications a ON j.JobID = a.JobID
                         WHERE j.EmployerID = @EmployerID
                         GROUP BY j.JobID, j.Title, j.Category, j.Location, j.JobType";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@EmployerID", employerId);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(new EmployerJobView
                    {
                        JobID = Convert.ToInt32(dr["JobID"]),
                        Title = dr["Title"].ToString(),
                        Category = dr["Category"].ToString(),
                        Location = dr["Location"].ToString(),
                        JobType = dr["JobType"].ToString(),
                        ApplicantCount = Convert.ToInt32(dr["ApplicantCount"])
                    });
                }
            }

            return list;
        }
    }
}