using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HireHub3.Models
{
    public class ApplicantView
    {
        public int ApplicationId { get; set; }   

        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CoverLetter { get; set; }
        public string Status { get; set; }
        public DateTime AppliedDate { get; set; }
    }
}