using CodeFirstMigrations.Entities;
using EF014.SeedDataModel;
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
            builder.HasData(SeedData.LoadSections());

            builder.ToTable("Sections");
        }


    }


}
