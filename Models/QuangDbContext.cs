using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public partial class QuangDbContext : DbContext
    {
        public QuangDbContext()
            : base ("name=QuangDbContext")
        {
        }

        
        public virtual DbSet<sinhvien> sinhvien { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }


    }
}