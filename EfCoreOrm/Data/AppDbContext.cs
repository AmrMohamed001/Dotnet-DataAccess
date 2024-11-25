using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace efcoreOrm.Data;

public class AppDbContext:DbContext
{
    public DbSet<Wallets> Wallets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        var configurations = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        optionsBuilder.UseSqlServer(configurations.GetSection("ConnectionStrings").Value);
    }
}