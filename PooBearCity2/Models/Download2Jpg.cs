using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PooBearCity2.Models
{
    public class Download2Jpg
    {
        public string content_type { get; set; }
        public int revpos { get; set; }
        public string digest { get; set; }
        public int length { get; set; }
        public bool stub { get; set; }
    }
}