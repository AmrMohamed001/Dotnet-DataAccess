using CodeFirstMigrations.Entities;
using EF014.SeedDataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstMigrations.Data.Config
{
    internal class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            // Id
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            // Name
            builder.Property(x => x.FName).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();
            builder.Property(x => x.LName).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();

            // Relationship with the office (1:1)
            builder.HasOne(x => x.Office).WithOne(x => x.Instructor).HasForeignKey<Instructor>(x => x.OfficeId);


            //Loading data
            builder.HasData(SeedData.LoadInstructors());

            builder.ToTable("Instructors");
        }


    }
}
