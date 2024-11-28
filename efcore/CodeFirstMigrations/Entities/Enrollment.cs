namespace CodeFirstMigrations.Entities
{
    public class Enrollment
    {
        public int ParticipatorId { get; set; }
        public int SectionId { get; set; }

        public Section Section { get; set; } = null!;
        public Participator Participator { get; set; } = null!;
    }
}
