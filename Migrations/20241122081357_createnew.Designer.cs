﻿// <auto-generated />
using System;
using Hospital.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hospital.Migrations
{
    [DbContext(typeof(ApplicationDBcontext))]
    [Migration("20241122081357_createnew")]
    partial class createnew
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hospital.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("AppointmentDate")
                        .HasColumnType("date");

                    b.Property<TimeOnly>("AppointmentTime")
                        .HasColumnType("time");

                    b.Property<string>("PatientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Hospital.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Img = "doctor1.jpg",
                            Name = "Dr. John Smith",
                            Specialization = "Cardiology"
                        },
                        new
                        {
                            Id = 2,
                            Img = "doctor3.jpg",
                            Name = "Dr. Sarah Johnson",
                            Specialization = "Pediatrics"
                        },
                        new
                        {
                            Id = 3,
                            Img = "doctor5.jpg",
                            Name = "Dr. Emily Davis",
                            Specialization = "Dermatology"
                        },
                        new
                        {
                            Id = 4,
                            Img = "doctor2.jpg",
                            Name = "Dr. Michael Lee",
                            Specialization = "Orthopedics"
                        },
                        new
                        {
                            Id = 5,
                            Img = "doctor6.jpg",
                            Name = "Dr. William Clark",
                            Specialization = "Neurology"
                        },
                        new
                        {
                            Id = 6,
                            Img = "doctor4.jpg",
                            Name = "Dr. Younis Musa",
                            Specialization = "Cardiac surgery"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
