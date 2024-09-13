
namespace db_api.Domain.DTO.Cmi.CmiUsers
{
    public record CmiUsersDTO
    {
        public int Id { get; init; }
        public string Username { get; init; } = default!;
        public double? Balance { get; init; }
        public ulong? TotalPlayTime { get; init; }
        public string? PlayerUuid { get; init; }
        public string? UserMeta { get; init; }
        public string? DisplayName { get; init; }
    }
}
