
namespace db_api.Domain.DTO.Playerpoints.Points
{
    public record PlayerpointsPointsDTO
    {
        public int Id { get; init; }
        public string Uuid { get; init; } = null!;
        public int Points { get; init; }
    }
}
