

namespace db_api.Domain.Entities.Lands
{
    public class LandsPlayers
    {
        public string Uuid { get; set; } // PK
        public string Name { get; set; }
        public string? EditLand { get; set; } // FK to LandsLand.Ulid
        public string? Invites { get; set; }
        public string? Limits { get; set; }
        public string? Chatmode { get; set; }
        public string? Flags { get; set; }

        public LandsLands? EditLandNavigation { get; set; }
    }
}
