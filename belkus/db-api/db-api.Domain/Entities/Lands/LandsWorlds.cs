namespace db_api.Domain.Entities.Lands
{
    public class LandsWorlds
    {
        public string Ulid { get; set; }
        public string Server { get; set; }
        public string Name { get; set; }
        public string Uid { get; set; }
        public string? FlagsRole { get; set; }
        public string? FlagsNatural { get; set; }

        public LandsServers? ServerNavigation { get; set; }
        public ICollection<LandsLands> LandsLands { get; set; } = new List<LandsLands>();
    }
}
