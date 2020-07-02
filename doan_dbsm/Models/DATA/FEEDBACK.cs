using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace doan_dbsm.Models.DATA
{
    public class FEEDBACK
    {
        [Key]
        public int feedback_id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string content { get; set; }
        public string date { get; set; }
    }
}