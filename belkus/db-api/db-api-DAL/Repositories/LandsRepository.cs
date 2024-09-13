
using db_api.Domain.Entities.Lands;
using System.Linq.Expressions;

namespace db_api_DAL.Repositories
{
    public class LandsRepository<TEntity> : BaseRepository<TEntity> where TEntity : class
    {
        private readonly DbLandsContext _dbContext;
        public LandsRepository(DbLandsContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
