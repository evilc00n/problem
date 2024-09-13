using db_api.Domain.Entities.Cmi;
using db_api.Domain.Entities.Lands;
using db_api.Domain.Entities.Playerpoints;
using db_api.Domain.Entities.Reputation;
using db_api.Domain.Interfaces.Repositories;
using db_api_DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace db_api_DAL.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void AddDataAccessLayer(this IServiceCollection services, IConfiguration configuration)
        {
            var cmiConnectionString = configuration.GetConnectionString("Cmi");
            var reputationConnectionString = configuration.GetConnectionString("Reputation");
            var playerpointsConnectionString = configuration.GetConnectionString("Playerpoints");
            var landsConnectionString = configuration.GetConnectionString("Lands");
            var mySqlVersion = configuration["DatabaseSettings:MySqlVersion"];

            services.AddDbContext<DbCmiContext>(options =>
            {
                options.UseMySql(
                    connectionString: cmiConnectionString, 
                    serverVersion: new MySqlServerVersion(new Version(mySqlVersion)));
            });
            services.AddDbContext<DbReputationContext>(options =>
            {
                options.UseMySql(
                    connectionString: reputationConnectionString,
                    serverVersion: new MySqlServerVersion(new Version(mySqlVersion)));
            });
            services.AddDbContext<DbPlayerpointsContext>(options =>
            {
                options.UseMySql(
                    connectionString: playerpointsConnectionString,
                    serverVersion: new MySqlServerVersion(new Version(mySqlVersion)));
            });

            services.AddDbContext<DbLandsContext>(options =>
            {

                options.UseMySql(
                    connectionString: landsConnectionString,
                    serverVersion: new MySqlServerVersion(new Version(mySqlVersion)));
            });




            services.InitRepositories();
        }


        private static void InitRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<CmiUsers>, 
                CmiRepository<CmiUsers>>();
            services.AddScoped<IBaseRepository<Reputation>, 
                ReputationRepository<Reputation>>();
            services.AddScoped<IBaseRepository<PlayerpointsPoints>,
                PlayerpointsRepository<PlayerpointsPoints>>();
            services.AddScoped<IAdvancedLandsRepository, AdvancedLandsRepository>();    
        }
    }
}
