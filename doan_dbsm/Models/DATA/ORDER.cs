using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace doan_dbsm.Models.DATA
{
    public class ORDER
    {
        [Key]
        public int order_ID { get; set; }

        public string Datetime { get; set; }
        public string total { get; set; }
        public string status { get; set; }
        public string note { get; set; }
        public int custumerid { get; set; }
        public virtual CUSTUMER CUSTUMER { get; set; }
        public virtual List<DETAIL_ORDER> DETAIL_ORDERs { get; set; }
    }
}