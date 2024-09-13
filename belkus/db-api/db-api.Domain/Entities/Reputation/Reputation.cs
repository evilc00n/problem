namespace db_api.Domain.Entities.Reputation
{
    public class Reputation
    {
        public long Id { get; set; }
        public string? Uuid { get; set; }
        public long? ReputationScore { get; set; }
        public bool? AcceptReputation { get; set; }

    }
}
