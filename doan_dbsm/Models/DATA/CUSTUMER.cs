using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace doan_dbsm.Models.DATA
{
    public class CUSTUMER
    {
        [Key]
        public int custumerid { get; set; }
        public string name { get; set; }
        public string pass { get; set; }
        public string phone { get; set; }
        public string adress { get; set; }
        public string email { get; set; }
        public string city { get; set; }
 
        public virtual List<ORDER>  ORDERs { get; set; }
    }
}