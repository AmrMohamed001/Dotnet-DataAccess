using CodeFirstMigrations.Entities;
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
            builder.HasData(LoadData());

            builder.ToTable("Courses");
        }

        private static List<Course> LoadData()
        {
            return new List<Course>
            {
                new Course { Id = 1,CourseName="Math",Price=5000 },
                new Course { Id = 2,CourseName="physics",Price=1000 },
                new Course { Id = 3,CourseName="Chemistry",Price=2000 },
                new Course { Id = 4,CourseName="Biology",Price=500 },
                new Course { Id = 5,CourseName="CS-50",Price=10000 },
            };
        }
    }
}
