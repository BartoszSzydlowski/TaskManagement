﻿using Microsoft.Extensions.DependencyInjection;
using TaskManagement.Domain.Interfaces;
using TaskManagement.Infrastructure.Repository;

namespace TaskManagement.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped(typeof(ITaskRepository<>), typeof(TaskRepository<>));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITaskTypeRepository, TaskTypeRepository>();

            services.AddSingleton<MockedData>();

            return services;
        }
    }
}
