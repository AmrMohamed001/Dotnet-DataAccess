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

                foreach (var participant in section.Participants)
                    Console.WriteLine($"[{participant.Id}] {participant.FName} {participant.LName}");
            }
        }
    }
}