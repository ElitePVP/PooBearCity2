using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PooBearCity2.Models;

namespace PooBearCity2.Models
{
    public class RequestType
    {
        public Individual Individual { get; set; }
        public Business Business { get; set; }
        public Anonymous Anonymous { get; set; }
    }
}