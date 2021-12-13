using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public partial class VsContext : DbContext
    {
        public VsContext()
            : base("name=VsDbContext")
        {
        }

        public virtual DbSet<sinhvien> sinhviens { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }


    }
}