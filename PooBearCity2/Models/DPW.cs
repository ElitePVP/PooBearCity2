using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PooBearCity2.Models
{
    public class DPW
    {
        public string _id { get; set; }
        public string _rev { get; set; }
        public string timestamp { get; set; }
        public RequestCategory requestCategory { get; set; }
        public RequestType requestType { get; set; }
        public LocationType locationType { get; set; }
        public string Summary_of_Request { get; set; }
        public Attachments _attachments { get; set; }
    }
}