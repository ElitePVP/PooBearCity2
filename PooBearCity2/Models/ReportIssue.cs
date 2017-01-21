using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PooBearCity2.Models
{
    public class ReportIssue
    {
        public string UserEmail { get; set; }
        public string IssueType { get; set; }
        public string Description { get; set; }
        public string DateCreated { get; set; }
        public int Severity { get; set; }
        public string LocationAddress { get; set; }
        public string LocationCity { get; set; }
        public int LocationZip { get; set; }
    }
}