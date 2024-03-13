using IronSwords.Repositories.Interfaces;
using IronSwords.Repositories.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace IronSwords.Repositories
{
    public static class ExtentionRepository
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAccommodationRepository, AccommodationRepository>();
            return services;
        }
    }
}
