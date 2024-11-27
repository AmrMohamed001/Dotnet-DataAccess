using CodeFirstMigrations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstMigrations.Data.Config
{
    internal class SectionConfig : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            // Id
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            // SectionName
            builder.Property(x => x.SectionName).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();

            // Instructor relationship (M:1)
            builder.HasOne(x => x.Instructor).WithMany(x => x.sections).HasForeignKey(x => x.InstructorId).IsRequired(false);

            // Course relationship (M:1)
            builder.HasOne(x => x.Course).WithMany(x => x.sections).HasForeignKey(x => x.CourseId).IsRequired();

            // SectionSchedule relationship (M:M)
            builder.HasMany(c => c.Schedules).WithMany(x => x.Sections).UsingEntity<SectionSchedule>();

            // Enrollment relationship (M:M)
            builder.HasMany(c => c.Participators).WithMany(x => x.Sections).UsingEntity<Enrollment>();

            //Loading data
            builder.HasData(LoadData());

            builder.ToTable("Sections");
        }

        private static List<Section> LoadData()
        {
            return new List<Section>
            {
                new Section { Id = 1,SectionName="Math1",CourseId=1 ,InstructorId =1},
                new Section { Id = 2,SectionName="Math2",CourseId=1 ,InstructorId =2},
                new Section { Id = 3,SectionName="Chemistry-85",CourseId=3 ,InstructorId =3},
                new Section { Id = 4,SectionName="Biology-7",CourseId=4 ,InstructorId =4},
                new Section { Id = 5,SectionName="CS-50-1",CourseId=5 ,InstructorId =5},
            };
        }
    }


}
