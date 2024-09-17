namespace db_api.Domain.Entities.Lands
{
    public class LandsServers
    {
        public string Server { get; set; } // PK
        public DateTime LastSeen { get; set; }
        public string Version { get; set; }
        public string VersionPrev { get; set; }
        public string? Timestamps { get; set; }
        public string? Flags { get; set; }

        public ICollection<LandsWorlds> Worlds { get; set; }
        public ICollection<LandsLands> Lands { get; set; }
    }
}
