using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazor.Data
{
    public class MyBlazorDbContext : DbContext
    {
        public MyBlazorDbContext(DbContextOptions<MyBlazorDbContext> options)
           : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //  base.OnModelCreating(modelBuilder);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Certificate>().HasKey(p => p.ID);
            modelBuilder.Entity<Certificate>().ToTable("Certificate");
           
        }
        public DbSet<Certificate> TableCertificates { get; set; }

      //  public DbSet<UsersActivation> UsersActivations { get; set; }
    }
}
