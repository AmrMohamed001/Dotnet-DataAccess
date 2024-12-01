using QueryData.Data;

namespace QueryData
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                #region Inner Join

                #region Query syntax
                var InnerJoinQuerySyntax =
                (from c in context.Courses
                 join s in context.Sections
                 on c.Id equals s.CourseId
                 select new
                 {
                     c.CourseName,
                     s.SectionName
                 }).ToList();
                //foreach (var x in InnerJoinQuerySyntax)
                //    Console.WriteLine(x);
                #endregion

                #region Method syntax
                var InnerJoinMethodSyntax = context.Courses.Join(context.Sections, c => c.Id, s => s.CourseId,
                    (c, s) => new
                    {
                        c.CourseName,
                        s.SectionName
                    });
                //foreach (var x in InnerJoinMethodSyntax)
                //    Console.WriteLine(x);
                #endregion

                #endregion
            }
        }
    }
}