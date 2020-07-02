using EO.Internal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace doan_dbsm.Models.DATA
{
    public class SHOPONLINE_CONTEXT :DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //Adds configurations for Student from separate class
            modelBuilder.Entity<DETAIL_ORDER>().HasKey(t => new { t.order_ID, t.product_id });

        }

        public DbSet <ABOUT> ABOUTs { get; set; }
        public DbSet <CONTACT>CONTACTs { get; set; }
        public DbSet <CUSTUMER>CUSTUMERs { get; set; }
        public DbSet<DETAIL_ORDER> DETAIL_ORDERs { get; set; }
        public DbSet<FEEDBACK> FEEDBACKs { get; set; }
        public DbSet <ORDER>ORDERs { get; set; }
        public DbSet<PRODUCT> PRODUCTs { get; set; }
        public DbSet<PRODUCT_GROUP> PRODUCT_GROUPs { get; set; }
        public DbSet<SLIDE> SLIDEs { get; set; }
        public DbSet<ADMIN>USERs { get; set; }
    }
}