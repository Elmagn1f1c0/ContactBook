﻿// <auto-generated />
using System;
using ContactApp.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContactApp.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230422182548_ThirdMigration")]
    partial class ThirdMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ContactAppModels.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phonenumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1001,
                            Address = "Lagos",
                            DateOfBirth = new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "johndoe@example.com",
                            FirstName = "John",
                            Gender = 0,
                            LastName = "Doe",
                            Occupation = "Engineer",
                            Phonenumber = "+2349050160648",
                            PhotoPath = "Images/john.jpg"
                        },
                        new
                        {
                            Id = 1002,
                            Address = "Kano",
                            DateOfBirth = new DateTime(1985, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sarahj@example.com",
                            FirstName = "Sarah",
                            Gender = 1,
                            LastName = "Johnson",
                            Occupation = "Entrepreneur",
                            Phonenumber = "+2347069357893",
                            PhotoPath = "Images/sarah.jpg"
                        },
                        new
                        {
                            Id = 1003,
                            Address = "Jamaica",
                            DateOfBirth = new DateTime(1988, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "michaels@example.com",
                            FirstName = "Michael",
                            Gender = 0,
                            LastName = "Smith",
                            Occupation = "Doctor",
                            Phonenumber = "+2348165473980",
                            PhotoPath = "Images/michael.jpeg"
                        },
                        new
                        {
                            Id = 1004,
                            Address = "USA",
                            DateOfBirth = new DateTime(1989, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mauriceg@example.com",
                            FirstName = "Maurice",
                            Gender = 0,
                            LastName = "Gray",
                            Occupation = "Banker",
                            Phonenumber = "+2347684567806",
                            PhotoPath = "Images/maurice.jpg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
