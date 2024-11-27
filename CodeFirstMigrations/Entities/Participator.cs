namespace CodeFirstMigrations.Entities
{
    public class Participator
    {
        public int Id { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public ICollection<Section> Sections { get; set; }
    }

    public class Individual : Participator
    {
        public string University { get; set; }
        public int YearOfGraduation { get; set; }
        public bool IsIntern { get; set; }
    }
    public class Coporate : Participator
    {
        public string Company { get; set; }
        public string JobTitle { get; set; }
    }
}
