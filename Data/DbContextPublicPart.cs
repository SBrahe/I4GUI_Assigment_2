using Microsoft.EntityFrameworkCore;
using I4GUI_Assigment_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace I4GUI_Assigment_2.Data
{
    partial class MyDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Employee>()
                .HasKey(s => s.employeeID);

            modelbuilder.Entity<Guest>()
                .HasKey(s => s.guestID);

            modelbuilder.Entity<Room>()
                .HasKey(s => s.RoomNumber);
        }
    }
}