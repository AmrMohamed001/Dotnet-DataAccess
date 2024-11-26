using CodeFirstMigrations.Entities;
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
            builder.HasData(LoadData());

            builder.ToTable("Instructors");
        }

        private static List<Instructor> LoadData()
        {
            return new List<Instructor>
            {
                new Instructor { Id = 1,FName="Ahmed",LName = "test1",OfficeId=1},
                new Instructor { Id = 2,FName="Mohamed",LName = "test2",OfficeId=2},
                new Instructor { Id = 3,FName="Amr", LName = "test3", OfficeId = 3},
                new Instructor { Id = 4,FName="Salah" , LName = "test4", OfficeId = 4},
                new Instructor { Id = 5,FName="Max" , LName = "test5", OfficeId = 5},
            };
        }
    }
}
