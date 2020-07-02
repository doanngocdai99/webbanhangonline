using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace doan_dbsm.Models.DATA
{
    public class ABOUT
    {
        [Key]
        public int about_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string details { get; set; }
        public string image { get; set; }
        public string datetime { get; set; }
        public string status { get; set; }

    }
}