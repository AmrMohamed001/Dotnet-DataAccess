using CodeFirstMigrations.Entities;

namespace EF014.SeedDataModel
{
    public static class SeedData
    {

        // Method to load data for Offices
        public static List<Office> LoadOffices() => new()
        {
            new Office { Id = 1, OfficeName = "Off_05", OfficeLocation = "Building A" },
            new Office { Id = 2, OfficeName = "Off_12", OfficeLocation = "Building B" },
            new Office { Id = 3, OfficeName = "Off_32", OfficeLocation = "Administration" },
            new Office { Id = 4, OfficeName = "Off_44", OfficeLocation = "IT Department" },
            new Office { Id = 5, OfficeName = "Off_43", OfficeLocation = "IT Department" }
        };

        // Method to load data for Courses
        public static List<Course> LoadCourses() => new()
        {
           new Course { Id = 1, CourseName = "Mathematics", Price = 1000.00m },
           new Course { Id = 2, CourseName = "Physics", Price = 2000.00m },
           new Course { Id = 3, CourseName = "Chemistry", Price = 1500.00m },
           new Course { Id = 4, CourseName = "Biology", Price = 1200.00m },
           new Course { Id = 5, CourseName = "CS-50", Price = 3000.00m }
        };

        // Method to load data for Schedules
        public static List<Schedule> LoadSchedules() => new()
        {
          new Schedule { Id = 1, Title = "Daily", SUN = true, MON = true, TUE = true, WED = true, THU = true, FRI = false, SAT = false },
          new Schedule { Id = 2, Title = "DayAfterDay", SUN = true, MON = false, TUE = true, WED = false, THU = true, FRI = false, SAT = false },
          new Schedule { Id = 3, Title = "TwiceAWeek", SUN = false, MON = true, TUE = false, WED = true, THU = false, FRI = false, SAT = false },
          new Schedule { Id = 4, Title = "Weekend", SUN = false, MON = false, TUE = false, WED = false, THU = false, FRI = true, SAT = true },
          new Schedule { Id = 5, Title = "Compact", SUN = true, MON = true, TUE = true, WED = true, THU = true, FRI = true, SAT = true }
        };

        // Method to load data for Instructors
        public static List<Instructor> LoadInstructors() => new()
        {
            new Instructor { Id = 1, FName = "Ahmed", LName = "Abdullah", OfficeId = 1 },
            new Instructor { Id = 2, FName = "Yasmeen", LName = "Mohammed", OfficeId = 2 },
            new Instructor { Id = 3, FName = "Khalid", LName = "Hassan", OfficeId = 3 },
            new Instructor { Id = 4, FName = "Nadia", LName = "Ali", OfficeId = 4 },
            new Instructor { Id = 5, FName = "Omar", LName = "Ibrahim", OfficeId = 5 }
        };

        // Method to load data for Sections
        public static List<Section> LoadSections() => new()
        {
            new Section { Id = 1,SectionName="Math1",CourseId=1 ,InstructorId =1},
                new Section { Id = 2,SectionName="Math2",CourseId=1 ,InstructorId =2},
                new Section { Id = 3,SectionName="Chemistry-85",CourseId=3 ,InstructorId =3},
                new Section { Id = 4,SectionName="Biology-7",CourseId=4 ,InstructorId =4},
                new Section { Id = 5,SectionName="CS-50-1",CourseId=5 ,InstructorId =5},
        };


        // Method to load data for Corporates
        public static List<Coporate> LoadCorporates() => new()
        {
            new Coporate { Id = 2, FName = "Noor", LName = "Saleh", Company = "ABC", JobTitle = "Developer" },
            new Coporate { Id = 4, FName = "Huda", LName = "Ahmed", Company = "ABC", JobTitle = "QA" },
            new Coporate { Id = 7, FName = "Yousef", LName = "Farid", Company = "EFG", JobTitle = "Developer" },
            new Coporate { Id = 8, FName = "Layla", LName = "Mustafa", Company = "EFG", JobTitle = "QA" }
        };

        // Method to load data for Individuals
        public static List<Individual> LoadIndividuals() => new()
        {
            new Individual { Id = 1, FName = "Fatima", LName = "Ali",University = "XYZ", YearOfGraduation = 2024, IsIntern = false },
            new Individual { Id = 3, FName = "Omar", LName = "Youssef", University = "POQ", YearOfGraduation = 2023, IsIntern = true },
            new Individual { Id = 5, FName = "Amira", LName = "Tariq", University = "POQ", YearOfGraduation = 2025, IsIntern = false },
            new Individual { Id = 6, FName = "Zainab", LName = "Ismail", University = "POQ", YearOfGraduation = 2023, IsIntern = true },
            new Individual { Id = 9, FName = "Mohammed", LName = "Adel", University = "XYZ", YearOfGraduation = 2024, IsIntern = false },
            new Individual { Id = 10, FName = "Samira", LName = "Nabil", University = "XYZ", YearOfGraduation = 2024, IsIntern = false }
        };


        // Method to load data for Enrollments
        public static List<Enrollment> LoadEnrollments() => new()
        {
            new Enrollment { SectionId = 6, ParticipatorId = 1 },
            new Enrollment { SectionId = 6, ParticipatorId = 2 },
            new Enrollment { SectionId = 7, ParticipatorId = 3 },
            new Enrollment { SectionId = 7, ParticipatorId = 4 },
            new Enrollment { SectionId = 8, ParticipatorId = 5 },
            new Enrollment { SectionId = 8, ParticipatorId = 6 },
            new Enrollment { SectionId = 9, ParticipatorId = 7 },
            new Enrollment { SectionId = 9, ParticipatorId = 8 },
            new Enrollment { SectionId = 10, ParticipatorId = 9 },
            new Enrollment { SectionId = 10, ParticipatorId = 10 }
        };
    }
}