using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace Sample6.Models
{
    public class Test3DBContext : DbContext
    {
        public Test3DBContext() : base("DBConn") { }
        public DbSet<Test3> Test3s { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Test3>().ToTable("Person");
        }

    }
}