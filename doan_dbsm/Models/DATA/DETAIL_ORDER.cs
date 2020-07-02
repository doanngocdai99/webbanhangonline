using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace doan_dbsm.Models.DATA
{
    public class DETAIL_ORDER
    {
        [Key]
        public int order_ID { get; set; }
        [Key]
        public int product_id { get; set; }
        public int  Quantity { get; set; }
        public virtual ORDER ORDER { get; set; }
        public virtual PRODUCT PRODUCT { get; set; }

    }
}