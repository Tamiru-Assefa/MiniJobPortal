using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HireHub3.Models
{
    public enum ApplicationStatus
    {
        Pending,
        Accepted,
        Rejected
    }
    public class Applications
    {
        public int ApplicationId { get; set; }
        public int UserId { get; set; }
        public int JobId { get; set; }
        public string CoveLetter { get; set; }
        public DateTime AppliedDate { get; set; }
        public ApplicationStatus Status { get; set; }
    }
}