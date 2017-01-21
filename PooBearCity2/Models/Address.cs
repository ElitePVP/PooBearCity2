using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PooBearCity2.Models
{
    public class Address
    {
        public string Service_Street_Number { get; set; }
        public string Service_Street_Prefix { get; set; }
        public string Service_Street_Name { get; set; }
        public string Service_Street_Type { get; set; }
        public string Service_Street_Suffix { get; set; }
        public string Service_Unit { get; set; }
        public string Service_City_County { get; set; }
        public string Service_State { get; set; }
        public string Service_Postal_Code { get; set; }
    }
}