using EntityTypes_and_Mapping.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EntityTypes_and_Mapping.Data
{
    internal class AppDbContext : DbContext
    {
        #region DbSets
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderWithDetailsView> OrderWithDetailsView { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            optionsBuilder.UseSqlServer(config.GetSection("ConnectionStrings").Value);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().ToTable("Products", schema: "Inventory").HasKey(x => x.Id);
            modelBuilder.Entity<Order>().ToTable("Orders", schema: "Sales").HasKey(x => x.Id);
            modelBuilder.Entity<OrderDetail>().ToTable("OrderDetails", schema: "Sales").HasKey(x => x.Id);
            modelBuilder.Ignore<Snapshot>(); // to not map Snapshot only use it in memory
            modelBuilder.Entity<OrderWithDetailsView>().ToView("OrderWithDetailsView").HasNoKey(); // Mapping View
            //modelBuilder.HasDefaultSchema("Sales");
        }
    }
}
