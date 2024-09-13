namespace db_api.Domain.Entities.Lands
{
    public class LandsServers
    {
        public string Server { get; set; }
        public DateTime LastSeen { get; set; }
        public string Version { get; set; }
        public string VersionPrev { get; set; }
        public string? Timestamps { get; set; }
        public string? Flags { get; set; }

        public ICollection<LandsLands> LandsLands { get; set; } = new List<LandsLands>();
        public ICollection<LandsWorlds> LandsWorlds { get; set; } = new List<LandsWorlds>();
    }
}
