﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SP749415_MIS4200.Models;

namespace SP749415_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            // add the SetInitializer statement here
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context,
            SP749415_MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }

        public DbSet<customer> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        // add this method - it will be used later
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}