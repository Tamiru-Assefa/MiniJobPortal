using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HireHub3.Models
{
    public class Users
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }
        public string Bio { get; set; }   
        public string Skills { get; set; }   
        public int? ExperienceYears { get; set; }   
        public string CompanyName { get; set; }   
        public DateTime CreatedDate { get; set; }
        public string CompanyDescription { get; set; }   
    }
}