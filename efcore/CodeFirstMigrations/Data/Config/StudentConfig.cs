using CodeFirstMigrations.Entities;
using EF014.SeedDataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirstMigrations.Data.Config
{
    internal class ParticpantConfiguration : IEntityTypeConfiguration<Participator>
    {
        public void Configure(EntityTypeBuilder<Participator> builder)
        {
            // Id
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            // FName
            builder.Property(x => x.FName).HasColumnType("VARCHAR").HasMaxLength(200);

            // LName
            builder.Property(x => x.LName).HasColumnType("VARCHAR").HasMaxLength(200);

            // Discriminator
            //builder.HasDiscriminator<string>("ParticipatorType").HasValue<Individual>("INDV").HasValue<Coporate>("COPT");
            //builder.Property("ParticipatorType").HasColumnType("VARCHAR").HasMaxLength(4);

            builder.UseTptMappingStrategy(); // TablePerType

            //Loading data
            builder.HasData(SeedData.LoadCorporates());
            builder.HasData(SeedData.LoadIndividuals());

            builder.ToTable("Participators");

        }


    }
}
