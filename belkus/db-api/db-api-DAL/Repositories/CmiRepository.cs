namespace db_api_DAL.Repositories
{
    public class CmiRepository<TEntity> : BaseRepository<TEntity> where TEntity : class
    {
        private readonly DbCmiContext _dbContext;
        public CmiRepository(DbCmiContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
