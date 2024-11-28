using CodeFirstMigrations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CodeFirstMigrations.Data
{
    public class AppDbContext : DbContext
    {
        #region DbSets
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<SectionSchedule> SectionSchedules { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Participator> Participators { get; set; }
        //public DbSet<Individual> Individuals { get; set; }
        //public DbSet<Coporate> Coporates { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
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
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly); // best practice to load all the configs
        }
    }
}
