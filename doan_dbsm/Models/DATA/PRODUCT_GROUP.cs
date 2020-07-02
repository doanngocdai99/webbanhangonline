using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace doan_dbsm.Models.DATA
{
    public class PRODUCT_GROUP
    {
        [Key]
        public int gr_groupid { get; set; }
        public string gr_groupname { get; set; }
      
        public virtual List<PRODUCT> PRODUCTs { get; set; }


    }
}