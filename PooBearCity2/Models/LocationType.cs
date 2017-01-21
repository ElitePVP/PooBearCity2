using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PooBearCity2.Models;

namespace PooBearCity2.Models
{
    public class LocationType
    {
        public PointModel Point { get; set; }
        public Address Address { get; set; }
        public HighwayExit HighwayExit { get; set; }
        public Intersection Intersection { get; set; }
    }
}