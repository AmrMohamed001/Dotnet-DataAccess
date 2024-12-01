using QueryData.Data;

namespace QueryData
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                #region Group By

                #region Query syntax
                var instructorSections =
                    from s in context.Sections
                    group s by s.Instructor
                    into g
                    select new
                    {
                        Key = g.Key,
                        TotalSections = g.Count()
                    };

                foreach (var item in instructorSections)
                {
                    Console.WriteLine($"{item.Key.FName}" +
                        $"==> Total Sections #[{item.TotalSections}]");
                }
                #endregion

                #region Method syntax
                var instructorSections =
                    context.Sections.GroupBy(x => x.Instructor)
                    .Select(x => new
                    {
                        Key = x.Key,
                        TotalSections = x.Count()
                    });


                foreach (var item in instructorSections)
                {
                    Console.WriteLine($"{item.Key.FName} " +
                        $"==> Total Sections #[{item.TotalSections}]");
                }
                #endregion

                #endregion
            }
        }
    }
}