﻿using Microsoft.Extensions.DependencyInjection;

namespace eAppointmentServer.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DependencyInjection).Assembly);

            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssemblies(typeof(DependencyInjection).Assembly);
            });

            return services;
        }
    }
}
