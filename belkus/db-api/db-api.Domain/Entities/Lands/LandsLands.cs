namespace db_api.Domain.Entities.Lands
{
    public class LandsLands
    {
        public string Ulid { get; set; } // PK
        public string Server { get; set; } // FK to LandsServer
        public string World { get; set; } // FK to LandsWorld
        public string Type { get; set; }
        public string? Category { get; set; }
        public string Name { get; set; }
        public string? Nation { get; set; } // Possible FK to another LandsLand.Ulid (not enforced)
        public string Area { get; set; }
        public string Members { get; set; }
        public DateTime CreatedAt { get; set; }
        public float Balance { get; set; }
        public string? Title { get; set; }
        public string? Spawn { get; set; }
        public string? Inbox { get; set; }
        public string? Limits { get; set; }
        public long Shield { get; set; }
        public string? Stats { get; set; }
        public string? Icon { get; set; }
        public string? Storage { get; set; }
        public short Level { get; set; }

        public LandsServers LandsServer { get; set; }
        public LandsWorlds LandsWorld { get; set; }
        public ICollection<LandsPlayers> Players { get; set; }
    }
}
