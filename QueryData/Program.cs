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

                var sectionId = 1;

                var section = context.Sections
                    .FirstOrDefault(x => x.Id == sectionId);

                // Explicit Loading
                var query = context.Entry(section).Collection(x => x.Participants).Query();

                Console.WriteLine($"section: {section.SectionName}");
                Console.WriteLine($"--------------------");

                foreach (var participant in query)
                    Console.WriteLine($"[{participant.Id}] {participant.FName} {participant.LName}");
            }
        }
    }
}