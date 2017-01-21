using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PooBearCity2.Models
{
    public class Neighborhood
    {
        public string _id { get; set; }
        public string _rev { get; set; }
        public string type { get; set; }
        public Properties properties { get; set; }
        public Geometry geometry { get; set; }
    }
}