using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PooBearCity2.Models
{
    public class PointModel
    {
        public List<double> coordinates { get; set; }
        public string Service_City_County { get; set; }
        public string Service_State { get; set; }
        public string Service_Postal_Code { get; set; }
    }
}