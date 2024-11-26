﻿// <auto-generated />
using CodeFirstMigrations.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeFirstMigrations.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241126111357_split Name to First and Last")]
    partial class splitNametoFirstandLast
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CodeFirstMigrations.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<decimal>("Price")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)");

                    b.HasKey("Id");

                    b.ToTable("Courses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseName = "Math",
                            Price = 5000m
                        },
                        new
                        {
                            Id = 2,
                            CourseName = "physics",
                            Price = 1000m
                        },
                        new
                        {
                            Id = 3,
                            CourseName = "Chemistry",
                            Price = 2000m
                        },
                        new
                        {
                            Id = 4,
                            CourseName = "Biology",
                            Price = 500m
                        },
                        new
                        {
                            Id = 5,
                            CourseName = "CS-50",
                            Price = 10000m
                        });
                });

            modelBuilder.Entity("CodeFirstMigrations.Entities.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Instructors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FName = "Ahmed",
                            LName = "test1"
                        },
                        new
                        {
                            Id = 2,
                            FName = "Mohamed",
                            LName = "test2"
                        },
                        new
                        {
                            Id = 3,
                            FName = "Amr",
                            LName = "test3"
                        },
                        new
                        {
                            Id = 4,
                            FName = "Salah",
                            LName = "test4"
                        },
                        new
                        {
                            Id = 5,
                            FName = "Max",
                            LName = "test5"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
