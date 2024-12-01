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
                var LeftJoinQuerySyntax =
                (from c in context.Courses
                 join s in context.Sections
                 on c.Id equals s.CourseId into Vacancy
                 from va in Vacancy.DefaultIfEmpty()
                 select new
                 {
                     c.CourseName,
                     va.SectionName,
                     Participants = va != null ? va.Participants : null,
                 }).ToList();
                //foreach (var x in LeftJoinQuerySyntax)
                //    Console.WriteLine(x);
                #endregion

                #region Method syntax
                var officeOccupancyMethodSyntax = context.Offices
                .GroupJoin(
                    context.Instructors,
                    o => o.Id,
                    i => i.OfficeId,
                    (office, instructor) => new { office, instructor }
                )
                .SelectMany(
                    ov => ov.instructor.DefaultIfEmpty(),
                    (ov, instructor) => new
                    {
                        OfficeId = ov.office.Id,
                        Name = ov.office.OfficeName,
                        Location = ov.office.OfficeLocation,
                        Instructor = instructor != null ? instructor.FName : "<<EMPTY>>"
                    }
                ).ToList();

                foreach (var office in officeOccupancyMethodSyntax)
                {
                    Console.WriteLine($"{office.Name} -> {office.Instructor}");
                }
                #endregion

                #endregion
            }
        }
    }
}