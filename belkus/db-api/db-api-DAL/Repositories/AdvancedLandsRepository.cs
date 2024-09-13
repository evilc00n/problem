using db_api.Domain.Entities.Lands;
using db_api.Domain.Interfaces.Repositories;


namespace db_api_DAL.Repositories
{
    public class AdvancedLandsRepository : IAdvancedLandsRepository
    {
        private readonly DbLandsContext _dbContext;
        public AdvancedLandsRepository(DbLandsContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext)); 
        }

        public IQueryable<LandsLands> GetAll()
        {
            Console.WriteLine($"Ошибкаыыыыыыыыыыыыыыыыыы");


            if (_dbContext == null)
            {
                Console.WriteLine("_dbContext не инициализирован");
                throw new NullReferenceException("_dbContext не инициализирован");
            }

            var landsSet = _dbContext.Set<LandsLands>();
            if (landsSet == null)
            {
                Console.WriteLine("DbSet<LandsLands> не инициализирован");
                throw new NullReferenceException("DbSet<LandsLands> не инициализирован");
            }

            Console.WriteLine("Запрос выполнен успешно");
            return landsSet;
        }


        public IQueryable<LandsLands> GetLandsByUUID(string playerUuid)
        {



            return _dbContext.LandsLands
                .Join(
                    _dbContext.LandsPlayers.Where(p => p.EditLand != null),
                    lands => lands.Ulid,
                    player => player.EditLand,
                    (lands, player) => new { Lands = lands, Player = player }
                )
                .Where(x => x.Player.Uuid == playerUuid)
                .Select(x => x.Lands);
        }
    }
}
