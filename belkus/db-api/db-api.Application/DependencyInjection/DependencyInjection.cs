using db_api.Application.Mapping;
using db_api.Application.Services;
using db_api.Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace db_api.Application.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void AddApplications(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CmiUsersMapping));
            services.InitServices();
        }

        private static void InitServices(this IServiceCollection services)
        {
            services.AddScoped<ICmiUsersService, CmiUsersService>();
            services.AddScoped<IReputationService, ReputationService>();
            services.AddScoped<IPlayerpointsPointsService, PlayerpointsPointsService>();
            services.AddScoped<ILandsLandsService, LandsLandsService>();
        }



    }
}
