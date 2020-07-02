using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace doan_dbsm.Models.DATA
{
    public class SLIDE
    {
        [Key]
        public int  slide_id { get; set; }
        public string image { get; set; }
        public string link { get; set; }
        public string status { get; set; }

    }
}