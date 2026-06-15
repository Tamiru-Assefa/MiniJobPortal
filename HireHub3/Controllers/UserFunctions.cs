using HireHub3.Models;
using System;
using System.Data.SqlClient;
using BCrypt.Net;

namespace HireHub3.Controllers
{
    public class UserFunctions
    {
        public Users LoginUser(Users u)
        {
            using (SqlConnection con = new SqlConnection(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MiniJobPortal;Integrated Security=True"))
            {
                con.Open();

                // get user by email
                string query = @"SELECT UserID, FullName, Email, PasswordHash, Role
                                 FROM Users
                                 WHERE Email = @Email";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", u.Email);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // get hashed password from database
                    string storedHash = reader["PasswordHash"].ToString();

                    // verify entered password against hash
                    bool validPassword = BCrypt.Net.BCrypt.Verify(u.PasswordHash, storedHash);

                    if (validPassword)
                    {
                        Users loggedUser = new Users();

                        loggedUser.UserID = Convert.ToInt32(reader["UserID"]);
                        loggedUser.FullName = reader["FullName"].ToString();
                        loggedUser.Email = reader["Email"].ToString();
                        loggedUser.Role = reader["Role"].ToString();

                        return loggedUser;
                    }
                }

                return null;
            }
        }
    }
}

//using HireHub3.Models;
//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Web;

//namespace HireHub3.Controllers
//{
//    public class UserFunctions
//    {
//        public Users LoginUser(Users u)
//        {
//            using (SqlConnection con = new SqlConnection(
//                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MiniJobPortal;Integrated Security=True"))
//            {
//                con.Open();

//                string query = @"SELECT PasswordHash, Role FROM Users WHERE Email=@Email";
//                //     SELECT * FROM Users WHERE Email = @Email AND PasswordHash = @Password


//                SqlCommand cmd = new SqlCommand(query, con);

//                cmd.Parameters.AddWithValue("@Email", u.Email);
//                //cmd.Parameters.AddWithValue("@Password", u.PasswordHash);

//                SqlDataReader reader = cmd.ExecuteReader();

//                if (reader.Read())
//                {

//                    Users loggedUser = new Users();

//                    loggedUser.UserID = Convert.ToInt32(reader["UserID"]);
//                    loggedUser.FullName = reader["FullName"].ToString();
//                    loggedUser.Email = reader["Email"].ToString();
//                    loggedUser.Role = reader["Role"].ToString();

//                    return loggedUser;
//                }

//                return null;
//            }
//        }
//    }
//}