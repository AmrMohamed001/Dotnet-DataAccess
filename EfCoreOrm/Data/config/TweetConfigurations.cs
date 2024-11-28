using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace efcoreOrm.Data.config;

public class TweetConfigurations : IEntityTypeConfiguration<Tweet>
{
    public void Configure(EntityTypeBuilder<Tweet> builder)
    {
        builder.ToTable("tweets");
        builder.Property(p => p.Id).HasColumnName("TweetId");
    }
}