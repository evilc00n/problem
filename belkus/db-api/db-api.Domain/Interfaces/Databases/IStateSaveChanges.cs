namespace db_api.Domain.Interfaces.Databases
{
    public interface IStateSaveChanges
    {
        Task<int> SaveChangesAsync();

    }
}
