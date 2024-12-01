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
                #region proper projection (select) reduce network traffic and reduce the effect on app performance
                //var coursesProjection = context.Courses.AsNoTracking()
                //    .Select(c =>
                //    new
                //    {
                //        CourseId = c.Id,
                //        CourseName = c.CourseName,
                //        Hours = c.HoursToComplete,
                //        Section = c.Sections.Select(s =>
                //        new
                //        {
                //            SectionId = s.Id,
                //            SectionName = s.SectionName,
                //            DateRate = s.DateRange.ToString(),
                //            TimeSlot = s.TimeSlot.ToString()
                //        }),
                //        Reviews = c.Reviews.Select(r =>
                //        new
                //        {
                //            FeedBack = r.Feedback,
                //            CreateAt = r.CreatedAt
                //        })
                //    }).ToList();
                #endregion

                #region Spliting the query
                //var courses1 = context.Courses
                //    .Include(x => x.Sections)
                //    .Include(x => x.Reviews)
                //    .AsSplitQuery() // explicit
                //    .ToList();

                //var courses2 = context.Courses
                //  .Include(x => x.Sections)
                //  .Include(x => x.Reviews) // split by config
                //  .ToList();

                var courses3 = context.Courses
                .Include(x => x.Sections)
                .Include(x => x.Reviews) // split by config
                .AsSingleQuery()
                .ToList();
                #endregion
            }
        }
    }
}