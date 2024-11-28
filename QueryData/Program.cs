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

                #region Server Evaluation
                //    var courseId = 1;
                //    var result = context.Sections
                //        .Where(x => x.CourseId == courseId)
                //        .Select(x => new // projection
                //        {
                //            Id = x.Id,
                //            Section = x.SectionName
                //        });

                // ---------------------------- EVALUATED SQL ----------------------------

                //    //DECLARE @__courseId_0 int = 1;
                //    //SELECT[s].[Id], [s].[SectionName] AS[Section]
                //    //FROM[Sections] AS[s]
                //    //WHERE[s].[CourseId] = @__courseId_0

                // ------------------------------------------------------------------------
                //    Console.WriteLine(result.ToQueryString());

                //    foreach (var item in result)
                //    {
                //        Console.WriteLine($"{item.Id} {item.Section}");
                //    }
                //}
                #endregion

                #region Client Evaluation
                var courseId = 1;

                var result = context.Sections
                    .Where(x => x.CourseId == courseId)
                    .Select(x => new
                    {
                        Id = x.Id,
                        Section = x.SectionName.Substring(4),
                        TotalDays = CalculateTotalDays(x.DateRange.StartDate, x.DateRange.EndDate)
                    });
                // ---------------------------- EVALUATED SQL ----------------------------
                //  SELECT [s].[Id], [s].[SectionName], [s].[StartDate], [s].[EndDate]
                //  FROM [Sections] AS [s]
                //  WHERE [s].[CourseId] = @__courseId_0
                // ------------------------------------------------------------------------
                Console.WriteLine(result.ToQueryString());

                foreach (var item in result)
                {
                    Console.WriteLine($"{item.Id} {item.Section} ({item.TotalDays})");
                }
                #endregion

            }
        }
    }
}