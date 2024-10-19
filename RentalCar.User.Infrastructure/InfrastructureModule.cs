using Microsoft.Extensions.DependencyInjection;
using RentalCar.User.Core.Repositories;
using RentalCar.User.Infrastructure.Repositories;

namespace RentalCar.User.Infrastructure
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddServices();
            return services;
        }

        private static IServiceCollection AddServices(this IServiceCollection services) 
        {
            services.AddScoped<IRoleRepository, RoleRepository>();
            return services;
        }

    }
}
