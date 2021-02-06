using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartCollar.Entities;

namespace SmartCollar.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Collar>().HasMany(c => c.Notifications).WithOne(n => n.Collar).HasForeignKey(c => c.DeviceId);
            modelBuilder.Entity<Notification>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
