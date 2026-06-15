using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HireHub3.Models
{
    public class EmployerJobView
    {
        public int JobID { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public string JobType { get; set; }
        public int ApplicantCount { get; set; }
    }
}