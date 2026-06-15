using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HireHub3.Models
{
    public class AppliedJobView
    {
        public int ApplicationId { get; set; }
        public int JobId { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public decimal Salary { get; set; }
        public string JobType { get; set; }
        public string Status { get; set; }
        public DateTime AppliedDate { get; set; }
    }
}