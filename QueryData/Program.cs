using QueryData.Data;

namespace QueryData
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                #region left Outer Join

                #region Query syntax
                var sectionInstructorQuerySyntax =
                        (from s in context.Sections // 200
                         from i in context.Instructors // 100
                         select new
                         {
                             s.SectionName,
                             i.FName
                         }).ToList();
                #endregion

                #region Method syntax
                var sectionInstructorMethodSyntax = context.Sections
                .SelectMany(
                    s => context.Instructors,
                    (s, i) => new { s.SectionName, i.FName }
                ).ToList();

                Console.WriteLine(sectionInstructorMethodSyntax.Count());
                #endregion

                #endregion
            }
        }
    }
}