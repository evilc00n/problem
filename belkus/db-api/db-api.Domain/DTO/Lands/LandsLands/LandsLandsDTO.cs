namespace db_api.Domain.DTO.Lands.LandsLands
{
    public record LandsLandsDTO
    {
        public string Ulid { get; init; }
        public string Server { get; init; }
        public string World { get; init; }
        public string? Category { get; init; }
        public string Members { get; init; }
        public string Area { get; init; }
        public float? Balance { get; init; }
        public string Type { get; init; }
        public string Name { get; init; }
        public DateTime CreatedAt { get; init; }
        public string Title { get; init; }
    }
}
