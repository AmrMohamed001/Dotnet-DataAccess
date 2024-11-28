using QueryData.Data;

namespace QueryData
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                // creating database without migrations
                await context.Database.EnsureCreatedAsync();

                #region Tracking
                var section = context.Sections.FirstOrDefault(x => x.Id == 1);

                Console.WriteLine("before changing tracked object");

                Console.WriteLine(section.SectionName);

                section.SectionName = "this is a new section name";

                context.SaveChanges();

                section = context.Sections.FirstOrDefault(x => x.Id == 1); // will change

                Console.WriteLine("after bein changed");

                Console.WriteLine(section.SectionName);
                #endregion

                #region No Tracking
                //    var section = context.Sections.AsNoTracking().FirstOrDefault(x => x.Id == 1);

                //    Console.WriteLine("before changing tracked object");

                //    Console.WriteLine(section.SectionName); // BlaBla

                //    section.SectionName = "01A51C05";

                //    context.SaveChanges();

                //    section = context.Sections.FirstOrDefault(x => x.Id == 1); // will no change

                //    Console.WriteLine("after bein changed");

                //    Console.WriteLine(section.SectionName);
                #endregion
            }
        }
    }
}