
namespace db_api_DAL.Repositories
{
    public class PlayerpointsRepository<TEntity> : BaseRepository<TEntity> where TEntity : class
    {
        private readonly DbPlayerpointsContext _dbContext;
        public PlayerpointsRepository(DbPlayerpointsContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
