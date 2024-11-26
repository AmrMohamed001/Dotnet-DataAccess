using CodeFirstMigrations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstMigrations.Data.Config
{
    internal class OfficeConfig : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            // Id
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            // OfficeName
            builder.Property(x => x.OfficeName).HasColumnType("VARCHAR").HasMaxLength(20).IsRequired();

            // OfficeLocation
            builder.Property(x => x.OfficeLocation).HasColumnType("VARCHAR").HasMaxLength(20).IsRequired();

            builder.HasData(LoadData());
            builder.ToTable("Offices");

        }

        private static List<Office> LoadData()
        {
            return new List<Office>
            {
                new Office { Id = 1,OfficeName = "OFF_05",OfficeLocation="x1"},
                new Office { Id = 2,OfficeName = "OFF_06",OfficeLocation = "x2"},
                new Office { Id = 3,OfficeName = "OFF_07",OfficeLocation = "x3"},
                new Office { Id = 4,OfficeName = "OFF_08",OfficeLocation = "x4"},
                new Office { Id = 5,OfficeName = "OFF_09",OfficeLocation = "x5"},
            };
        }
    }
}
