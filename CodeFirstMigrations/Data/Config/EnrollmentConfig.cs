using CodeFirstMigrations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstMigrations.Data.Config
{
    public class EnrollmentConfig : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.HasKey(x => new { x.SectionId, x.StudentId });

            builder.ToTable("Enrollments");

            builder.HasData(LoadEnrollments());
        }

        private static List<Enrollment> LoadEnrollments()
        {
            return new List<Enrollment>
            {
                new Enrollment() { StudentId = 1, SectionId = 1 },
                new Enrollment() { StudentId = 2, SectionId = 1 },
                new Enrollment() { StudentId = 3, SectionId = 2 },
                new Enrollment() { StudentId = 4, SectionId = 2 },
                new Enrollment() { StudentId = 5, SectionId = 3 },
                new Enrollment() { StudentId = 1, SectionId = 3 },
                new Enrollment() { StudentId = 2, SectionId = 4 },
                new Enrollment() { StudentId = 3, SectionId = 4 },
                new Enrollment() { StudentId = 4, SectionId = 5 },
                new Enrollment() { StudentId = 5, SectionId = 5 }
            };
        }
    }
}
