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

                #region GetMany
                //var courses = context.Courses;
                //Console.WriteLine(courses.ToQueryString()); // to get the sql query
                //foreach (var course in courses)
                //    Console.WriteLine($"course name: {course.CourseName}, {course.HoursToComplete} hrs., {course.Price.ToString("C")}");
                #endregion

                #region Get-Single-One(if more than one will throw ex)
                //var course = context.Courses.Single(x => x.Id == 1);
                //Console.WriteLine($"course name: {course.CourseName}, {course.HoursToComplete} hrs., {course.Price.ToString("C")}");
                //var course = context.Courses.Single(x => x.HoursToComplete == 25);

                //Console.WriteLine($"{course.CourseName}, {course.Price.ToString("C")}");
                #endregion

                #region Get-First-One-from-group(if nothing throw ex)
                // var course = context.Courses.First(x => x.HoursToComplete == 25);

                // Console.WriteLine($"{course.CourseName}, {course.Price.ToString("C")}");
                #endregion

                #region Get-First-One-from-group(if nothing return null)
                //var course = context.Courses.FirstOrDefault(x => x.HoursToComplete == 999);

                //Console.WriteLine($"{course?.CourseName}, {course?.Price.ToString("C")}");
                #endregion

                #region Get-Single-One(if nothing return null)
                // var course = context.Courses.SingleOrDefault(x => x.HoursToComplete == 999);

                // Console.WriteLine($"{course?.CourseName}, {course?.Price.ToString("C")}");
                #endregion

                #region Get-with-condition
                //var courses = context.Courses.Where(x => x.Price > 3000); //IQuerable

                //Console.WriteLine(courses.ToQueryString());

                //foreach (var course in courses)
                //    Console.WriteLine($"course name: {course.CourseName}, {course.HoursToComplete} hrs., {course.Price.ToString("C")}");
                #endregion

            }
        }
    }
}