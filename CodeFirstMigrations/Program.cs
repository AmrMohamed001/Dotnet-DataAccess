using CodeFirstMigrations.Data;
using CodeFirstMigrations.Entities;


namespace CodeFirstMigrations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new AppDbContext();
            var Participator1 = new Individual { Id = 6, IsIntern = true, YearOfGraduation = 2024, University = "Damietta" };
            var Participator2 = new Coporate { Id = 7, Company = "Cairo", JobTitle = "BackEnd" };

            context.Add(Participator1);
            context.Add(Participator2);
            context.SaveChanges();
            // Table per hierarchy is the default mapping strategy => making one table having the all 3 tables
        }
    }
}
