namespace CodeFirstMigrations.Entities
{
    public class Office
    {
        public int Id { get; set; }
        public string? OfficeName { get; set; }
        public string? OfficeLocation { get; set; }

        //Office has one instructor(1:1)
        public Instructor? Instructor { get; set; }
    }
}
