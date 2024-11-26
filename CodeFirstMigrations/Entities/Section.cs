namespace CodeFirstMigrations.Entities
{
    public class Section
    {
        public int Id { get; set; }
        public string SectionName { get; set; }

        // section has one course (m:1) => section must belong to cource 
        public int CourseId { get; set; }
        public Course Course { get; set; }

        // section has one instructor
        public int? InstructorId { get; set; }
        public Instructor? Instructor { get; set; }
    }
}
