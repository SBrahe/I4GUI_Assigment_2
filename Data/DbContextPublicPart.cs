using Microsoft.EntityFrameworkCore;
using I4GUI_Assigment_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace I4GUI_Assigment_2.Data
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        { }
        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<BreakfastReservation> BreakfastReservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Employee>()
                .HasKey(e => e.EmployeeId);

            modelbuilder.Entity<Room>()
                .HasKey(r => r.RoomNumber);

            modelbuilder.Entity<BreakfastReservation>()
                .HasKey(b => b.ReservationId);

            modelbuilder.Entity<BreakfastReservation>()
                .HasOne<Room>(b => b.room)
                .WithMany(r => r.BreakfastDates)
                .HasForeignKey(b => b.roomNumber);

            modelbuilder.Entity<Room>()
                .HasData(
                new Room { 
                    RoomNumber = 101, 
                    NumberOfAdults = 3, 
                    NumberOfChildren = 4 },
                
            new Room
            {
                RoomNumber = 202,
                NumberOfAdults = 1,
                NumberOfChildren = 1
            },

            new Room
            {
                RoomNumber = 303,
                NumberOfAdults = 2,
                NumberOfChildren = 2
            }
            );
        }
    }
}