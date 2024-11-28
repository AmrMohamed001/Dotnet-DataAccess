using CodeFirstMigrations.Entities;
using EF014.SeedDataModel;
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

            builder.HasData(SeedData.LoadOffices());
            builder.ToTable("Offices");

        }


    }
}
