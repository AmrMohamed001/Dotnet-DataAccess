using CodeFirstMigrations.Entities;
using EF014.SeedDataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstMigrations.Data.Config
{
    internal class ScheduleConfig : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            // builder.Property(x => x.CourseName).HasMaxLength(255); // nvarchar(255)

            builder.Property(x => x.Title)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50).IsRequired();


            builder.ToTable("Schedules");


            builder.HasData(SeedData.LoadSchedules());
        }


    }
}
