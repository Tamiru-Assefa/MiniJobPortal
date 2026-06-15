using HireHub3.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;

namespace HireHub3.Controllers
{
    public class EmpRegisterFunction
    {
        public void RegisterCompany(Users u)
        {
            using (SqlConnection con = new SqlConnection(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MiniJobPortal;Integrated Security=True"))
            {
                con.Open();
                //string query = "insert into Users values (@companyName,@email,@phonenum,@companydesc,@passwordhash,@role)";

                string query = @"INSERT INTO Users 
                (FullName, Email, PasswordHash, PhoneNumber, Role, Bio, Skills, ExperienceYears, CompanyName, CreatedDate, CompanyDescription) 
                VALUES 
                (@companyName, @email, @passwordhash, @phonenum, @role, @bio, @skills, @experienceYears, @companyName, GETDATE(), @companydesc)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@companyName", u.CompanyName );
                cmd.Parameters.AddWithValue("@email", u.Email );
                cmd.Parameters.AddWithValue("@passwordhash", u.PasswordHash );
                cmd.Parameters.AddWithValue("@phonenum", u.PhoneNumber);
                cmd.Parameters.AddWithValue("@role", "Employer");
                cmd.Parameters.AddWithValue("@companydesc", u.CompanyDescription);

                // Job Seeker Data (Pass explicit NULLs because they don't apply to an Employer)
                cmd.Parameters.AddWithValue("@bio", DBNull.Value);
                cmd.Parameters.AddWithValue("@skills", DBNull.Value);
                cmd.Parameters.AddWithValue("@experienceYears", DBNull.Value);

                //cmd.Parameters.AddWithValue("@companyName",u.CompanyName );
                //cmd.Parameters.AddWithValue("@email", u.Email);
                //cmd.Parameters.AddWithValue("@phonenum", u.PhoneNumber);
                //cmd.Parameters.AddWithValue("@companydesc", u.CompanyDescription);
                //cmd.Parameters.AddWithValue("@passwordhash", u.PasswordHash);
                //cmd.Parameters.AddWithValue("@role", "Employer");
                cmd.ExecuteNonQuery(); //for insertion

            }
        }
        
    }
}