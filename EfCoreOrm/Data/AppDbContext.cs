using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace efcoreOrm.Data;

public class AppDbContext:DbContext
{

    #region DBSets
    public DbSet<User> users { get; set; }
    public DbSet<Tweet> tweets { get; set; }
    public DbSet<Comment> Comments { get; set; }
    #endregion
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        var configurations = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        optionsBuilder.UseSqlServer(configurations.GetSection("ConnectionStrings").Value).LogTo(Console.WriteLine,LogLevel.Information);
    }
}