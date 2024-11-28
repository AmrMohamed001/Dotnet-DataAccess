using Microsoft.EntityFrameworkCore;
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

                #region one Join
                //    var sectionId = 1;
                //    var sectionQuery = context.Sections
                //        .Include(x => x.Participants)
                //        .Where(x => x.Id == sectionId);

                //    Console.WriteLine(sectionQuery.ToQueryString());


                //    var section = sectionQuery.FirstOrDefault();
                //    Console.WriteLine($"section: {section.SectionName}");
                //    Console.WriteLine($"--------------------");
                //    foreach (var participant in section.Participants)
                //        Console.WriteLine($"[{participant.Id}] {participant.FName} {participant.LName}");
                #endregion

                #region Many Joins
                var sectionId = 1;

                var sectionQuery = context.Sections
                    .Include(x => x.Instructor)
                    .ThenInclude(x => x.Office)
                    .Where(x => x.Id == sectionId);

                Console.WriteLine(sectionQuery.ToQueryString());


                var section = sectionQuery.FirstOrDefault();

                Console.WriteLine($"section: {section.SectionName} " +
                    $"[{section.Instructor.FName} " +
                    $"{section.Instructor.LName} " +
                    $"({section.Instructor.Office.OfficeName})]");

                #endregion
            }
        }
    }
}