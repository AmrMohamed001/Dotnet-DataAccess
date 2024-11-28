﻿// <auto-generated />
using System;
using CodeFirstMigrations.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeFirstMigrations.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("CodeFirstMigrations.Entities.Enrollment", b =>
                {
                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<int>("ParticipatorId")
                        .HasColumnType("int");

                    b.HasKey("SectionId", "ParticipatorId");

                    b.HasIndex("ParticipatorId");

                    b.ToTable("Enrollments", (string)null);

                    b.HasData(
                        new
                        {
                            SectionId = 1,
                            ParticipatorId = 1
                        },
                        new
                        {
                            SectionId = 1,
                            ParticipatorId = 2
                        },
                        new
                        {
                            SectionId = 2,
                            ParticipatorId = 3
                        },
                        new
                        {
                            SectionId = 2,
                            ParticipatorId = 4
                        },
                        new
                        {
                            SectionId = 3,
                            ParticipatorId = 5
                        },
                        new
                        {
                            SectionId = 3,
                            ParticipatorId = 1
                        },
                        new
                        {
                            SectionId = 4,
                            ParticipatorId = 2
                        },
                        new
                        {
                            SectionId = 4,
                            ParticipatorId = 3
                        },
                        new
                        {
                            SectionId = 5,
                            ParticipatorId = 4
                        },
                        new
                        {
                            SectionId = 5,
                            ParticipatorId = 5
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

            modelBuilder.Entity("CodeFirstMigrations.Entities.Participator", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("LName")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Participators", (string)null);

                    b.UseTptMappingStrategy();

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

            modelBuilder.Entity("CodeFirstMigrations.Entities.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable((string)null);

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("CodeFirstMigrations.Entities.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("FRI")
                        .HasColumnType("bit");

                    b.Property<bool>("MON")
                        .HasColumnType("bit");

                    b.Property<bool>("SAT")
                        .HasColumnType("bit");

                    b.Property<bool>("SUN")
                        .HasColumnType("bit");

                    b.Property<bool>("THU")
                        .HasColumnType("bit");

                    b.Property<bool>("TUE")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<bool>("WED")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Schedules", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FRI = false,
                            MON = true,
                            SAT = false,
                            SUN = true,
                            THU = true,
                            TUE = true,
                            Title = "Daily",
                            WED = true
                        },
                        new
                        {
                            Id = 2,
                            FRI = false,
                            MON = false,
                            SAT = false,
                            SUN = true,
                            THU = true,
                            TUE = true,
                            Title = "DayAfterDay",
                            WED = false
                        },
                        new
                        {
                            Id = 3,
                            FRI = false,
                            MON = true,
                            SAT = false,
                            SUN = false,
                            THU = false,
                            TUE = false,
                            Title = "Twice-a-Week",
                            WED = true
                        },
                        new
                        {
                            Id = 4,
                            FRI = true,
                            MON = false,
                            SAT = true,
                            SUN = false,
                            THU = false,
                            TUE = false,
                            Title = "Weekend",
                            WED = false
                        },
                        new
                        {
                            Id = 5,
                            FRI = true,
                            MON = true,
                            SAT = true,
                            SUN = true,
                            THU = true,
                            TUE = true,
                            Title = "Compact",
                            WED = true
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

            modelBuilder.Entity("CodeFirstMigrations.Entities.SectionSchedule", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("SectionId");

                    b.ToTable("SectionSchedules", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndTime = new TimeSpan(0, 10, 0, 0, 0),
                            ScheduleId = 1,
                            SectionId = 1,
                            StartTime = new TimeSpan(0, 8, 0, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            ScheduleId = 3,
                            SectionId = 1,
                            StartTime = new TimeSpan(0, 14, 0, 0, 0)
                        },
                        new
                        {
                            Id = 3,
                            EndTime = new TimeSpan(0, 15, 0, 0, 0),
                            ScheduleId = 4,
                            SectionId = 1,
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 4,
                            EndTime = new TimeSpan(0, 12, 0, 0, 0),
                            ScheduleId = 1,
                            SectionId = 2,
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 5,
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            ScheduleId = 1,
                            SectionId = 2,
                            StartTime = new TimeSpan(0, 16, 0, 0, 0)
                        },
                        new
                        {
                            Id = 6,
                            EndTime = new TimeSpan(0, 10, 0, 0, 0),
                            ScheduleId = 2,
                            SectionId = 2,
                            StartTime = new TimeSpan(0, 8, 0, 0, 0)
                        },
                        new
                        {
                            Id = 7,
                            EndTime = new TimeSpan(0, 14, 0, 0, 0),
                            ScheduleId = 3,
                            SectionId = 3,
                            StartTime = new TimeSpan(0, 11, 0, 0, 0)
                        },
                        new
                        {
                            Id = 8,
                            EndTime = new TimeSpan(0, 14, 0, 0, 0),
                            ScheduleId = 4,
                            SectionId = 3,
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 9,
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            ScheduleId = 4,
                            SectionId = 3,
                            StartTime = new TimeSpan(0, 16, 0, 0, 0)
                        },
                        new
                        {
                            Id = 10,
                            EndTime = new TimeSpan(0, 15, 0, 0, 0),
                            ScheduleId = 3,
                            SectionId = 4,
                            StartTime = new TimeSpan(0, 12, 0, 0, 0)
                        },
                        new
                        {
                            Id = 11,
                            EndTime = new TimeSpan(0, 11, 0, 0, 0),
                            ScheduleId = 5,
                            SectionId = 5,
                            StartTime = new TimeSpan(0, 9, 0, 0, 0)
                        });
                });

            modelBuilder.Entity("CodeFirstMigrations.Entities.Coporate", b =>
                {
                    b.HasBaseType("CodeFirstMigrations.Entities.Participator");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Coporates");
                });

            modelBuilder.Entity("CodeFirstMigrations.Entities.Individual", b =>
                {
                    b.HasBaseType("CodeFirstMigrations.Entities.Participator");

                    b.Property<bool>("IsIntern")
                        .HasColumnType("bit");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfGraduation")
                        .HasColumnType("int");

                    b.ToTable("Individuals");
                });

            modelBuilder.Entity("CodeFirstMigrations.Entities.MultipleChoiceQuiz", b =>
                {
                    b.HasBaseType("CodeFirstMigrations.Entities.Quiz");

                    b.Property<string>("CorrectAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("OptionA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("MultipleChoiceQuizes");
                });

            modelBuilder.Entity("CodeFirstMigrations.Entities.TrueAndFalseQuiz", b =>
                {
                    b.HasBaseType("CodeFirstMigrations.Entities.Quiz");

                    b.Property<bool>("CorrectAnswer")
                        .HasColumnType("bit");

                    b.ToTable("TrueAndFalseQuizes");
                });

            modelBuilder.Entity("CodeFirstMigrations.Entities.Enrollment", b =>
                {
                    b.HasOne("CodeFirstMigrations.Entities.Participator", "Participator")
                        .WithMany()
                        .HasForeignKey("ParticipatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstMigrations.Entities.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Participator");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("CodeFirstMigrations.Entities.Instructor", b =>
                {
                    b.HasOne("CodeFirstMigrations.Entities.Office", "Office")
                        .WithOne("Instructor")
                        .HasForeignKey("CodeFirstMigrations.Entities.Instructor", "OfficeId");

                    b.Navigation("Office");
                });

            modelBuilder.Entity("CodeFirstMigrations.Entities.Quiz", b =>
                {
                    b.HasOne("CodeFirstMigrations.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
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

            modelBuilder.Entity("CodeFirstMigrations.Entities.SectionSchedule", b =>
                {
                    b.HasOne("CodeFirstMigrations.Entities.Schedule", null)
                        .WithMany("SectionSchedules")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstMigrations.Entities.Section", null)
                        .WithMany("SectionSchedules")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CodeFirstMigrations.Entities.Coporate", b =>
                {
                    b.HasOne("CodeFirstMigrations.Entities.Participator", null)
                        .WithOne()
                        .HasForeignKey("CodeFirstMigrations.Entities.Coporate", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CodeFirstMigrations.Entities.Individual", b =>
                {
                    b.HasOne("CodeFirstMigrations.Entities.Participator", null)
                        .WithOne()
                        .HasForeignKey("CodeFirstMigrations.Entities.Individual", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("CodeFirstMigrations.Entities.Schedule", b =>
                {
                    b.Navigation("SectionSchedules");
                });

            modelBuilder.Entity("CodeFirstMigrations.Entities.Section", b =>
                {
                    b.Navigation("SectionSchedules");
                });
#pragma warning restore 612, 618
        }
    }
}
