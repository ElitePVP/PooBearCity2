using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PooBearCity2.Models
{
    public class RequestCategory
    {
        public List<string> Park_Maintenance { get; set; }
        public List<string> Trees { get; set; }
        public List<string> Flooding { get; set; }
        public List<string> Sewer { get; set; }
        public List<string> Street_Light { get; set; }
        public List<string> Water_Services { get; set; }
        public List<string> Signs_and_Signals { get; set; }
        public List<string> Streets_and_Sidewalks { get; set; }
    }
}