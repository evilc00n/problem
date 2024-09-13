

namespace db_api.Domain.DTO.Reputation
{
    public record ReputationDTO
    {
        public string? Uuid { get; init; }
        public ulong? ReputationScore { get; init; }
        public bool? AcceptReputation { get; init; }


    }
}
