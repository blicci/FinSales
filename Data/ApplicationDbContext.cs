using System;
using System.Collections.Generic;
using System.Text;
using finSales.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace finSales.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Company>().ToTable("Company");
            base.OnModelCreating(builder);
        }
    }
}
