using CodeFirstMigrations.Data;
using Microsoft.EntityFrameworkCore;


namespace CodeFirstMigrations
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var context = new AppDbContext();

            // Database Api

            //Creating Database if it does not exist without migrations
            await context.Database.EnsureCreatedAsync();
            var sqlScript = context.Database.GenerateCreateScript(); // to generate the sql to create schemas
            // Delete Database if it exists
            await context.Database.EnsureDeletedAsync();
        }
    }
}
