using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelCRM.Models;
using System.Configuration;



namespace HotelCRM
{
    public class HotelContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Tariff> Tariffs { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<CleaningTask> CleaningTasks { get; set; }
        public DbSet<RoomMaintenance> RoomMaintenances { get; set; }
        public DbSet<BookingServiceItem> BookingServiceItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Server=localhost;Port=3306;Database=hotel_crm;Uid=root;Pwd=root;";
                var serverVersion = new MySqlServerVersion(new Version(8, 0, 30));

                optionsBuilder.UseMySql(connectionString, serverVersion);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guest>().ToTable("Guests");
            modelBuilder.Entity<Room>().ToTable("Rooms");
            modelBuilder.Entity<Booking>().ToTable("Bookings");
            modelBuilder.Entity<Tariff>().ToTable("Tariffs");
            modelBuilder.Entity<Service>().ToTable("Services");
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<CleaningTask>().ToTable("CleaningTasks");
            modelBuilder.Entity<RoomMaintenance>().ToTable("RoomMaintenance");

            base.OnModelCreating(modelBuilder);
        }
    }
}
