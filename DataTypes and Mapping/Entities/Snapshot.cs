namespace EntityTypes_and_Mapping.Entities
{
    //[NotMapped]
    public class Snapshot
    {
        public DateTime LoadedAt => DateTime.UtcNow;
        public string Version => Guid.NewGuid().ToString().Substring(0, 8);
    }
}
