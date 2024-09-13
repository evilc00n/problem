using Microsoft.EntityFrameworkCore;

namespace db_api_DAL.Repositories
{
    public class ReputationRepository<TEntity> : BaseRepository<TEntity> where TEntity : class
    {
        private readonly DbReputationContext _dbContext;
        public ReputationRepository(DbReputationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
