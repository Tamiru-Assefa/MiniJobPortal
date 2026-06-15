using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HireHub3.Models
{
    public class Jobs
    {
        public int JobID { get; set; }
        public int EmployerID { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }

        public decimal Salary { get; set; }
        public string JobType { get; set; }

        public DateTime PostedDate { get; set; }
    }
}