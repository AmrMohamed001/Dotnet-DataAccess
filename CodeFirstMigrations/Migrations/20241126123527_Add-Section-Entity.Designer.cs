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
    [Migration("20241126123527_Add-Section-Entity")]
    partial class AddSectionEntity
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

                    b.Property<int?>("OfficeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId")
                        .IsUnique()
                        .HasFilter("[OfficeId] IS NOT NULL");

                    b.ToTable("Instructors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FName = "Ahmed",
                            LName = "test1",
                            OfficeId = 1
                        },
                        new
                        {
                            Id = 2,
                            FName = "Mohamed",
                            LName = "test2",
                            OfficeId = 2
                        },
                        new
                        {
                            Id = 3,
                            FName = "Amr",
                            LName = "test3",
                            OfficeId = 3
                        },
                        new
                        {
                            Id = 4,
                            FName = "Salah",
                            LName = "test4",
                            OfficeId = 4
                        },
                        new
                        {
                            Id = 5,
                            FName = "Max",
                            LName = "test5",
                            OfficeId = 5
                        });
                });

            modelBuilder.Entity("CodeFirstMigrations.Entities.Office", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("OfficeLocation")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("OfficeName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Offices", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OfficeLocation = "x1",
                            OfficeName = "OFF_05"
                        },
                        new
                        {
                            Id = 2,
                            OfficeLocation = "x2",
                            OfficeName = "OFF_06"
                        },
                        new
                        {
                            Id = 3,
                            OfficeLocation = "x3",
                            OfficeName = "OFF_07"
                        },
                        new
                        {
                            Id = 4,
                            OfficeLocation = "x4",
                            OfficeName = "OFF_08"
                        },
                        new
                        {
                            Id = 5,
                            OfficeLocation = "x5",
                            OfficeName = "OFF_09"
                        });
                });

            modelBuilder.Entity("CodeFirstMigrations.Entities.Section", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("SectionName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Sections", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            InstructorId = 1,
                            SectionName = "Math1"
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 1,
                            InstructorId = 2,
                            SectionName = "Math2"
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 3,
                            InstructorId = 3,
                            SectionName = "Chemistry-85"
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 4,
                            InstructorId = 4,
                            SectionName = "Biology-7"
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 5,
                            InstructorId = 5,
                            SectionName = "CS-50-1"
                        });
                });

            modelBuilder.Entity("CodeFirstMigrations.Entities.Instructor", b =>
                {
                    b.HasOne("CodeFirstMigrations.Entities.Office", "Office")
                        .WithOne("Instructor")
                        .HasForeignKey("CodeFirstMigrations.Entities.Instructor", "OfficeId");

                    b.Navigation("Office");
                });

            modelBuilder.Entity("CodeFirstMigrations.Entities.Section", b =>
                {
                    b.HasOne("CodeFirstMigrations.Entities.Course", "Course")
                        .WithMany("sections")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstMigrations.Entities.Instructor", "Instructor")
                        .WithMany("sections")
                        .HasForeignKey("InstructorId");

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("CodeFirstMigrations.Entities.Course", b =>
                {
                    b.Navigation("sections");
                });

            modelBuilder.Entity("CodeFirstMigrations.Entities.Instructor", b =>
                {
                    b.Navigation("sections");
                });

            modelBuilder.Entity("CodeFirstMigrations.Entities.Office", b =>
                {
                    b.Navigation("Instructor");
                });
#pragma warning restore 612, 618
        }
    }
}
