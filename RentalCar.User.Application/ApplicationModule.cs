using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using RentalCar.User.Application.Handlers.Roles;
using RentalCar.User.Application.Validators.Roles;

namespace RentalCar.User.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplicationModule(this IServiceCollection services)
        {
            services
                .AddFluentValidation()
                .AddHandlers()
                ;
            return services;
        }

        private static IServiceCollection AddFluentValidation(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation().AddValidatorsFromAssemblyContaining<CreateRoleValidator>();
            return services;
        }

        private static IServiceCollection AddHandlers(this IServiceCollection services) 
        {
            services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<CreateRoleHandler>());
            return services;
        }

        /*
        private static IServiceCollection AddHandlers(this IServiceCollection services) 
        {
            services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<CreateDonorHandler>());

            return services;
        }
         */

    }
}
