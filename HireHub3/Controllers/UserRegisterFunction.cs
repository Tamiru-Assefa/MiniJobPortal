using HireHub3.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HireHub3.Controllers
{
    public class UserRegisterFunction
    {
        public void RegisterUser(Users u) 
        {
            
            using (SqlConnection con = new SqlConnection(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MiniJobPortal;Integrated Security=True"))
            {
                con.Open();
                //string query = "insert into Users values (@companyName,@email,@phonenum,@companydesc,@passwordhash,@role)";

                string query = @"INSERT INTO Users 
                (FullName, Email, PasswordHash, PhoneNumber, Role, Bio, Skills, ExperienceYears, CompanyName, CreatedDate, CompanyDescription) 
                VALUES 
                (@fullname, @email, @passwordhash, @phonenum, @role, @bio, @skills, @experienceYears, @companyName, GETDATE(), @companydesc)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@fullname", u.FullName);
                cmd.Parameters.AddWithValue("@email", u.Email);
                cmd.Parameters.AddWithValue("@passwordhash", u.PasswordHash);
                cmd.Parameters.AddWithValue("@phonenum", u.PhoneNumber);
                cmd.Parameters.AddWithValue("@role", "JobSeeker");
                cmd.Parameters.AddWithValue("@bio", u.Bio);
                cmd.Parameters.AddWithValue("@skills", u.Skills);
                cmd.Parameters.AddWithValue("@experienceYears", u.ExperienceYears);

                cmd.Parameters.AddWithValue("@companydesc", DBNull.Value);
                cmd.Parameters.AddWithValue("@companyName", DBNull.Value);

                
                cmd.ExecuteNonQuery(); //for insertion

            }
        }
    
    }
}