using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartCollar.Entities;

namespace SmartCollar.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureRelations(modelBuilder);
            ConfigurePrecisions(modelBuilder);
            ConfigureSeed(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private static void ConfigureRelations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Collar>().ToTable("Collar").HasMany(c => c.Notifications).WithOne(n => n.Collar).HasForeignKey(c => c.DeviceId);
            modelBuilder.Entity<Notification>().ToTable("Notification").HasMany(e => e.UserObservations).WithOne(e => e.Notification).HasForeignKey(e => e.NotificationId);
            modelBuilder.Entity<MobileUser>().ToTable("MobileUser").HasMany(a => a.Notifications).WithOne(a => a.User).HasForeignKey(a => a.UserId);
            modelBuilder.Entity<UserNotification>().ToTable("UserNotification").HasKey(e => new { e.UserId, e.NotificationId });
        }

        private static void ConfigureSeed(ModelBuilder modelBuilder)
        {
            DataSeed dataSeed = new DataSeed();
            modelBuilder.Entity<Collar>().HasData(dataSeed.Collars);
            modelBuilder.Entity<MobileUser>().HasData(dataSeed.Users);
            modelBuilder.Entity<Notification>().HasData(dataSeed.Notifications);
            modelBuilder.Entity<UserNotification>().HasData(dataSeed.UserNotifications);
        }

        private static void ConfigurePrecisions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Collar>().Property(s => s.Latitude).HasColumnType("decimal(12,8)");
            modelBuilder.Entity<Collar>().Property(s => s.Longitude).HasColumnType("decimal(12,8)");
            modelBuilder.Entity<Notification>().Property(s => s.Latitude).HasColumnType("decimal(12,8)");
            modelBuilder.Entity<Notification>().Property(s => s.Longitude).HasColumnType("decimal(12,8)");
        }

        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Collar> Collars { get; set; }
        public DbSet<MobileUser> MobileUsers { get; set; }
        public DbSet<UserNotification> UserNotifications { get; set; }
    }
}
