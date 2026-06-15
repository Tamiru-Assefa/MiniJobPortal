using HireHub3.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HireHub3.Controllers
{
    public class ApplicantViewFunction
    {
        string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MiniJobPortal;Integrated Security=True";

        public List<ApplicantView> GetApplicants(int jobId)
        {
            List<ApplicantView> list = new List<ApplicantView>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT a.ApplicationID, u.FullName, u.Email, u.PhoneNumber,
                   a.CoverLetter, a.Status, a.AppliedDate
            FROM Applications a
            INNER JOIN Users u ON a.UserID = u.UserID
            WHERE a.JobID = @JobID";


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@JobID", jobId);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(new ApplicantView
                    {
                        ApplicationId = Convert.ToInt32(dr["ApplicationID"]),
                        FullName = dr["FullName"].ToString(),
                        Email = dr["Email"].ToString(),
                        PhoneNumber = dr["PhoneNumber"].ToString(),
                        CoverLetter = dr["CoverLetter"].ToString(),
                        Status = dr["Status"].ToString(),
                        AppliedDate = Convert.ToDateTime(dr["AppliedDate"])
                    });
                }
            }

            return list;
        }

        public void UpdateStatus(int applicationId, string status)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Applications 
                         SET Status = @Status 
                         WHERE ApplicationID = @ApplicationID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@ApplicationID", applicationId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}