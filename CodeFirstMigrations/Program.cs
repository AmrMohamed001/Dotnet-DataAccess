using CodeFirstMigrations.Data;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstMigrations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new AppDbContext();

            foreach (var item in context.Sections.Include(x => x.Course))
            {
                Console.WriteLine($"{item.SectionName} belong to {item.Course.CourseName}");
            }
        }
    }
}
