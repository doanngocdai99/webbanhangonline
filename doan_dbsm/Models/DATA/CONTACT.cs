using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace doan_dbsm.Models.DATA
{
    public class CONTACT
    {
        [Key]
        public int contact_id { get; set; }
        public string content { get; set; }
        public string status { get; set; }

    }
}