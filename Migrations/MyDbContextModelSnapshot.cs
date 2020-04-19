﻿// <auto-generated />
using System;
using I4GUI_Assigment_2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace I4GUI_Assigment_2.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("I4GUI_Assigment_2.Models.BreakfastReservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2020, 4, 19, 13, 41, 4, 748, DateTimeKind.Local).AddTicks(6881));

                    b.Property<int>("NumberOfAdultReservations")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfAdultsCheckedIn")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfChildReservations")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfChildrenCheckedIn")
                        .HasColumnType("int");

                    b.Property<int>("roomNumber")
                        .HasColumnType("int");

                    b.HasKey("ReservationId");

                    b.HasIndex("roomNumber");

                    b.ToTable("BreakfastReservations");
                });

            modelBuilder.Entity("I4GUI_Assigment_2.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeType")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("I4GUI_Assigment_2.Models.Room", b =>
                {
                    b.Property<int>("RoomNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumberOfAdults")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfChildren")
                        .HasColumnType("int");

                    b.HasKey("RoomNumber");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("I4GUI_Assigment_2.Models.BreakfastReservation", b =>
                {
                    b.HasOne("I4GUI_Assigment_2.Models.Room", "room")
                        .WithMany("BreakfastDates")
                        .HasForeignKey("roomNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}