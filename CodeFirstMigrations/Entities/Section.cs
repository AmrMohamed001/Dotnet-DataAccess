namespace CodeFirstMigrations.Entities
{
    public class Section
    {
        public int Id { get; set; }
        public string SectionName { get; set; }

        // section has one course (m:1) => section must belong to cource 
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;

        // section has one instructor
        public int? InstructorId { get; set; }
        public Instructor? Instructor { get; set; } = null!;

        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
        public ICollection<SectionSchedule> SectionSchedules { get; set; } = new List<SectionSchedule>();
        public ICollection<Student> Students { get; set; }
    }
}
