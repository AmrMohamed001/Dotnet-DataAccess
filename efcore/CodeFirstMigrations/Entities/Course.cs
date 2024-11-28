namespace CodeFirstMigrations.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string? CourseName { get; set; }
        public decimal Price { get; set; }

        // course has many sections
        public ICollection<Section> sections { get; set; }
    }
}
