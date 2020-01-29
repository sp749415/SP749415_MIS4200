using System;
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

        }

        public DbSet<customer> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }
    }
}