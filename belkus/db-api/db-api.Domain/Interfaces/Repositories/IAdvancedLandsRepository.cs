
using db_api.Domain.Entities.Lands;
using Microsoft.EntityFrameworkCore;

namespace db_api.Domain.Interfaces.Repositories
{
    public interface IAdvancedLandsRepository
    {
        IQueryable<LandsLands> GetLandsByUUID(string playerUuid);
        IQueryable<LandsLands> GetAll();
    }
}
