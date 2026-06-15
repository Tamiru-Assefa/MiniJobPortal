using HireHub3.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HireHub3
{
    public class ApplyFunction
    {
        public void ApplyJob(Applications a)
        {
            using (SqlConnection con = new SqlConnection(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MiniJobPortal;Integrated Security=True"))
            {
                con.Open();

                string query = @"INSERT INTO Applications
                                (UserId, JobId, CoverLetter, AppliedDate, Status)
                                VALUES
                                (@UserId, @JobId, @CoverLetter, GETDATE(), @Status)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@UserId", a.UserId);
                cmd.Parameters.AddWithValue("@JobId", a.JobId);
                cmd.Parameters.AddWithValue("@CoverLetter", a.CoveLetter);
                cmd.Parameters.AddWithValue("@Status", a.Status.ToString());

                cmd.ExecuteNonQuery();
            }
        }
    }
}