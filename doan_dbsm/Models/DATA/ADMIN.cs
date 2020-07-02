using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace doan_dbsm.Models.DATA
{
    public class ADMIN
    {
        [Key]
        public int adminid { get; set; }
        public string name { get; set; }
        public string pass { get; set; }
        
   

    }
}