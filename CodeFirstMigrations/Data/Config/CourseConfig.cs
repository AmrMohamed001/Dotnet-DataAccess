using CodeFirstMigrations.Entities;
using EF014.SeedDataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstMigrations.Data.Config
{
    internal class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            // Id
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            // CourseName
            //builder.Property(x => x.CourseName).HasMaxLength(255);     // nvarchar => we want varchar
            builder.Property(x => x.CourseName).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();

            //Price
            builder.Property(x => x.Price).HasPrecision(15, 2); // make it decimal

            //Loading data
            builder.HasData(SeedData.LoadCourses());

            builder.ToTable("Courses");
        }


    }
}
