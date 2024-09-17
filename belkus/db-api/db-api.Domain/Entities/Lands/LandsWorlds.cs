namespace db_api.Domain.Entities.Lands
{
    public class LandsWorlds
    {
        public string Ulid { get; set; } // PK
        public string Server { get; set; } // FK to LandsServer
        public string Name { get; set; }
        public string Uid { get; set; }
        public string? FlagsRole { get; set; }
        public string? FlagsNatural { get; set; }

        public LandsServers LandsServer { get; set; } // Navigation property

        public ICollection<LandsLands> Lands { get; set; }
    }
}
