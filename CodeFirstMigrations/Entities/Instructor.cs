namespace CodeFirstMigrations.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }


        // instructor has one office (1:1)
        public int? OfficeId { get; set; }
        public Office? Office { get; set; } = null!;

        // instructor tech in many sections
        public ICollection<Section> sections { get; set; } = new List<Section>();
    }
}
